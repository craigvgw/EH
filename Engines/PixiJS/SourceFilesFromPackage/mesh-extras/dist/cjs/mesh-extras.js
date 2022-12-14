/*!
 * @pixi/mesh-extras - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/mesh-extras is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

var mesh = require('@pixi/mesh');
var constants = require('@pixi/constants');
var core = require('@pixi/core');

/*! *****************************************************************************
Copyright (c) Microsoft Corporation.

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
PERFORMANCE OF THIS SOFTWARE.
***************************************************************************** */
/* global Reflect, Promise */

var extendStatics = function(d, b) {
    extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) { if (b.hasOwnProperty(p)) { d[p] = b[p]; } } };
    return extendStatics(d, b);
};

function __extends(d, b) {
    extendStatics(d, b);
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
}

/**
 * @memberof PIXI
 */
var PlaneGeometry = /** @class */ (function (_super) {
    __extends(PlaneGeometry, _super);
    /**
     * @param width - The width of the plane.
     * @param height - The height of the plane.
     * @param segWidth - Number of horizontal segments.
     * @param segHeight - Number of vertical segments.
     */
    function PlaneGeometry(width, height, segWidth, segHeight) {
        if (width === void 0) { width = 100; }
        if (height === void 0) { height = 100; }
        if (segWidth === void 0) { segWidth = 10; }
        if (segHeight === void 0) { segHeight = 10; }
        var _this = _super.call(this) || this;
        _this.segWidth = segWidth;
        _this.segHeight = segHeight;
        _this.width = width;
        _this.height = height;
        _this.build();
        return _this;
    }
    /**
     * Refreshes plane coordinates
     * @private
     */
    PlaneGeometry.prototype.build = function () {
        var total = this.segWidth * this.segHeight;
        var verts = [];
        var uvs = [];
        var indices = [];
        var segmentsX = this.segWidth - 1;
        var segmentsY = this.segHeight - 1;
        var sizeX = (this.width) / segmentsX;
        var sizeY = (this.height) / segmentsY;
        for (var i = 0; i < total; i++) {
            var x = (i % this.segWidth);
            var y = ((i / this.segWidth) | 0);
            verts.push(x * sizeX, y * sizeY);
            uvs.push(x / segmentsX, y / segmentsY);
        }
        var totalSub = segmentsX * segmentsY;
        for (var i = 0; i < totalSub; i++) {
            var xpos = i % segmentsX;
            var ypos = (i / segmentsX) | 0;
            var value = (ypos * this.segWidth) + xpos;
            var value2 = (ypos * this.segWidth) + xpos + 1;
            var value3 = ((ypos + 1) * this.segWidth) + xpos;
            var value4 = ((ypos + 1) * this.segWidth) + xpos + 1;
            indices.push(value, value2, value3, value2, value4, value3);
        }
        this.buffers[0].data = new Float32Array(verts);
        this.buffers[1].data = new Float32Array(uvs);
        this.indexBuffer.data = new Uint16Array(indices);
        // ensure that the changes are uploaded
        this.buffers[0].update();
        this.buffers[1].update();
        this.indexBuffer.update();
    };
    return PlaneGeometry;
}(mesh.MeshGeometry));

/**
 * RopeGeometry allows you to draw a geometry across several points and then manipulate these points.
 *
 * ```js
 * for (let i = 0; i < 20; i++) {
 *     points.push(new PIXI.Point(i * 50, 0));
 * };
 * const rope = new PIXI.RopeGeometry(100, points);
 * ```
 * @memberof PIXI
 */
var RopeGeometry = /** @class */ (function (_super) {
    __extends(RopeGeometry, _super);
    /**
     * @param width - The width (i.e., thickness) of the rope.
     * @param points - An array of {@link PIXI.Point} objects to construct this rope.
     * @param textureScale - By default the rope texture will be stretched to match
     *     rope length. If textureScale is positive this value will be treated as a scaling
     *     factor and the texture will preserve its aspect ratio instead. To create a tiling rope
     *     set baseTexture.wrapMode to {@link PIXI.WRAP_MODES.REPEAT} and use a power of two texture,
     *     then set textureScale=1 to keep the original texture pixel size.
     *     In order to reduce alpha channel artifacts provide a larger texture and downsample -
     *     i.e. set textureScale=0.5 to scale it down twice.
     */
    function RopeGeometry(width, points, textureScale) {
        if (width === void 0) { width = 200; }
        if (textureScale === void 0) { textureScale = 0; }
        var _this = _super.call(this, new Float32Array(points.length * 4), new Float32Array(points.length * 4), new Uint16Array((points.length - 1) * 6)) || this;
        _this.points = points;
        _this._width = width;
        _this.textureScale = textureScale;
        _this.build();
        return _this;
    }
    Object.defineProperty(RopeGeometry.prototype, "width", {
        /**
         * The width (i.e., thickness) of the rope.
         * @readonly
         */
        get: function () {
            return this._width;
        },
        enumerable: false,
        configurable: true
    });
    /** Refreshes Rope indices and uvs */
    RopeGeometry.prototype.build = function () {
        var points = this.points;
        if (!points)
            { return; }
        var vertexBuffer = this.getBuffer('aVertexPosition');
        var uvBuffer = this.getBuffer('aTextureCoord');
        var indexBuffer = this.getIndex();
        // if too little points, or texture hasn't got UVs set yet just move on.
        if (points.length < 1) {
            return;
        }
        // if the number of points has changed we will need to recreate the arraybuffers
        if (vertexBuffer.data.length / 4 !== points.length) {
            vertexBuffer.data = new Float32Array(points.length * 4);
            uvBuffer.data = new Float32Array(points.length * 4);
            indexBuffer.data = new Uint16Array((points.length - 1) * 6);
        }
        var uvs = uvBuffer.data;
        var indices = indexBuffer.data;
        uvs[0] = 0;
        uvs[1] = 0;
        uvs[2] = 0;
        uvs[3] = 1;
        var amount = 0;
        var prev = points[0];
        var textureWidth = this._width * this.textureScale;
        var total = points.length; // - 1;
        for (var i = 0; i < total; i++) {
            // time to do some smart drawing!
            var index = i * 4;
            if (this.textureScale > 0) {
                // calculate pixel distance from previous point
                var dx = prev.x - points[i].x;
                var dy = prev.y - points[i].y;
                var distance = Math.sqrt((dx * dx) + (dy * dy));
                prev = points[i];
                amount += distance / textureWidth;
            }
            else {
                // stretch texture
                amount = i / (total - 1);
            }
            uvs[index] = amount;
            uvs[index + 1] = 0;
            uvs[index + 2] = amount;
            uvs[index + 3] = 1;
        }
        var indexCount = 0;
        for (var i = 0; i < total - 1; i++) {
            var index = i * 2;
            indices[indexCount++] = index;
            indices[indexCount++] = index + 1;
            indices[indexCount++] = index + 2;
            indices[indexCount++] = index + 2;
            indices[indexCount++] = index + 1;
            indices[indexCount++] = index + 3;
        }
        // ensure that the changes are uploaded
        uvBuffer.update();
        indexBuffer.update();
        this.updateVertices();
    };
    /** refreshes vertices of Rope mesh */
    RopeGeometry.prototype.updateVertices = function () {
        var points = this.points;
        if (points.length < 1) {
            return;
        }
        var lastPoint = points[0];
        var nextPoint;
        var perpX = 0;
        var perpY = 0;
        var vertices = this.buffers[0].data;
        var total = points.length;
        for (var i = 0; i < total; i++) {
            var point = points[i];
            var index = i * 4;
            if (i < points.length - 1) {
                nextPoint = points[i + 1];
            }
            else {
                nextPoint = point;
            }
            perpY = -(nextPoint.x - lastPoint.x);
            perpX = nextPoint.y - lastPoint.y;
            var perpLength = Math.sqrt((perpX * perpX) + (perpY * perpY));
            var num = this.textureScale > 0 ? this.textureScale * this._width / 2 : this._width / 2;
            perpX /= perpLength;
            perpY /= perpLength;
            perpX *= num;
            perpY *= num;
            vertices[index] = point.x + perpX;
            vertices[index + 1] = point.y + perpY;
            vertices[index + 2] = point.x - perpX;
            vertices[index + 3] = point.y - perpY;
            lastPoint = point;
        }
        this.buffers[0].update();
    };
    RopeGeometry.prototype.update = function () {
        if (this.textureScale > 0) {
            this.build(); // we need to update UVs
        }
        else {
            this.updateVertices();
        }
    };
    return RopeGeometry;
}(mesh.MeshGeometry));

/**
 * The rope allows you to draw a texture across several points and then manipulate these points
 *
 *```js
 * for (let i = 0; i < 20; i++) {
 *     points.push(new PIXI.Point(i * 50, 0));
 * };
 * let rope = new PIXI.SimpleRope(PIXI.Texture.from("snake.png"), points);
 *  ```
 * @memberof PIXI
 */
var SimpleRope = /** @class */ (function (_super) {
    __extends(SimpleRope, _super);
    /**
     * @param texture - The texture to use on the rope.
     * @param points - An array of {@link PIXI.Point} objects to construct this rope.
     * @param {number} textureScale - Optional. Positive values scale rope texture
     * keeping its aspect ratio. You can reduce alpha channel artifacts by providing a larger texture
     * and downsampling here. If set to zero, texture will be stretched instead.
     */
    function SimpleRope(texture, points, textureScale) {
        if (textureScale === void 0) { textureScale = 0; }
        var _this = this;
        var ropeGeometry = new RopeGeometry(texture.height, points, textureScale);
        var meshMaterial = new mesh.MeshMaterial(texture);
        if (textureScale > 0) {
            // attempt to set UV wrapping, will fail on non-power of two textures
            texture.baseTexture.wrapMode = constants.WRAP_MODES.REPEAT;
        }
        _this = _super.call(this, ropeGeometry, meshMaterial) || this;
        /**
         * re-calculate vertices by rope points each frame
         * @member {boolean}
         */
        _this.autoUpdate = true;
        return _this;
    }
    SimpleRope.prototype._render = function (renderer) {
        var geometry = this.geometry;
        if (this.autoUpdate || geometry._width !== this.shader.texture.height) {
            geometry._width = this.shader.texture.height;
            geometry.update();
        }
        _super.prototype._render.call(this, renderer);
    };
    return SimpleRope;
}(mesh.Mesh));

/**
 * The SimplePlane allows you to draw a texture across several points and then manipulate these points
 *
 *```js
 * for (let i = 0; i < 20; i++) {
 *     points.push(new PIXI.Point(i * 50, 0));
 * };
 * let SimplePlane = new PIXI.SimplePlane(PIXI.Texture.from("snake.png"), points);
 *  ```
 * @memberof PIXI
 */
var SimplePlane = /** @class */ (function (_super) {
    __extends(SimplePlane, _super);
    /**
     * @param texture - The texture to use on the SimplePlane.
     * @param verticesX - The number of vertices in the x-axis
     * @param verticesY - The number of vertices in the y-axis
     */
    function SimplePlane(texture, verticesX, verticesY) {
        var _this = this;
        var planeGeometry = new PlaneGeometry(texture.width, texture.height, verticesX, verticesY);
        var meshMaterial = new mesh.MeshMaterial(core.Texture.WHITE);
        _this = _super.call(this, planeGeometry, meshMaterial) || this;
        // lets call the setter to ensure all necessary updates are performed
        _this.texture = texture;
        _this.autoResize = true;
        return _this;
    }
    /**
     * Method used for overrides, to do something in case texture frame was changed.
     * Meshes based on plane can override it and change more details based on texture.
     */
    SimplePlane.prototype.textureUpdated = function () {
        this._textureID = this.shader.texture._updateID;
        var geometry = this.geometry;
        var _a = this.shader.texture, width = _a.width, height = _a.height;
        if (this.autoResize && (geometry.width !== width || geometry.height !== height)) {
            geometry.width = this.shader.texture.width;
            geometry.height = this.shader.texture.height;
            geometry.build();
        }
    };
    Object.defineProperty(SimplePlane.prototype, "texture", {
        get: function () {
            return this.shader.texture;
        },
        set: function (value) {
            // Track texture same way sprite does.
            // For generated meshes like NineSlicePlane it can change the geometry.
            // Unfortunately, this method might not work if you directly change texture in material.
            if (this.shader.texture === value) {
                return;
            }
            this.shader.texture = value;
            this._textureID = -1;
            if (value.baseTexture.valid) {
                this.textureUpdated();
            }
            else {
                value.once('update', this.textureUpdated, this);
            }
        },
        enumerable: false,
        configurable: true
    });
    SimplePlane.prototype._render = function (renderer) {
        if (this._textureID !== this.shader.texture._updateID) {
            this.textureUpdated();
        }
        _super.prototype._render.call(this, renderer);
    };
    SimplePlane.prototype.destroy = function (options) {
        this.shader.texture.off('update', this.textureUpdated, this);
        _super.prototype.destroy.call(this, options);
    };
    return SimplePlane;
}(mesh.Mesh));

/**
 * The Simple Mesh class mimics Mesh in PixiJS v4, providing easy-to-use constructor arguments.
 * For more robust customization, use {@link PIXI.Mesh}.
 * @memberof PIXI
 */
var SimpleMesh = /** @class */ (function (_super) {
    __extends(SimpleMesh, _super);
    /**
     * @param texture - The texture to use
     * @param {Float32Array} [vertices] - if you want to specify the vertices
     * @param {Float32Array} [uvs] - if you want to specify the uvs
     * @param {Uint16Array} [indices] - if you want to specify the indices
     * @param drawMode - the drawMode, can be any of the Mesh.DRAW_MODES consts
     */
    function SimpleMesh(texture, vertices, uvs, indices, drawMode) {
        if (texture === void 0) { texture = core.Texture.EMPTY; }
        var _this = this;
        var geometry = new mesh.MeshGeometry(vertices, uvs, indices);
        geometry.getBuffer('aVertexPosition').static = false;
        var meshMaterial = new mesh.MeshMaterial(texture);
        _this = _super.call(this, geometry, meshMaterial, null, drawMode) || this;
        _this.autoUpdate = true;
        return _this;
    }
    Object.defineProperty(SimpleMesh.prototype, "vertices", {
        /**
         * Collection of vertices data.
         * @type {Float32Array}
         */
        get: function () {
            return this.geometry.getBuffer('aVertexPosition').data;
        },
        set: function (value) {
            this.geometry.getBuffer('aVertexPosition').data = value;
        },
        enumerable: false,
        configurable: true
    });
    SimpleMesh.prototype._render = function (renderer) {
        if (this.autoUpdate) {
            this.geometry.getBuffer('aVertexPosition').update();
        }
        _super.prototype._render.call(this, renderer);
    };
    return SimpleMesh;
}(mesh.Mesh));

var DEFAULT_BORDER_SIZE = 10;
/**
 * The NineSlicePlane allows you to stretch a texture using 9-slice scaling. The corners will remain unscaled (useful
 * for buttons with rounded corners for example) and the other areas will be scaled horizontally and or vertically
 *
 *```js
 * let Plane9 = new PIXI.NineSlicePlane(PIXI.Texture.from('BoxWithRoundedCorners.png'), 15, 15, 15, 15);
 *  ```
 * <pre>
 *      A                          B
 *    +---+----------------------+---+
 *  C | 1 |          2           | 3 |
 *    +---+----------------------+---+
 *    |   |                      |   |
 *    | 4 |          5           | 6 |
 *    |   |                      |   |
 *    +---+----------------------+---+
 *  D | 7 |          8           | 9 |
 *    +---+----------------------+---+
 *  When changing this objects width and/or height:
 *     areas 1 3 7 and 9 will remain unscaled.
 *     areas 2 and 8 will be stretched horizontally
 *     areas 4 and 6 will be stretched vertically
 *     area 5 will be stretched both horizontally and vertically
 * </pre>
 * @memberof PIXI
 */
var NineSlicePlane = /** @class */ (function (_super) {
    __extends(NineSlicePlane, _super);
    /**
     * @param texture - The texture to use on the NineSlicePlane.
     * @param {number} [leftWidth=10] - size of the left vertical bar (A)
     * @param {number} [topHeight=10] - size of the top horizontal bar (C)
     * @param {number} [rightWidth=10] - size of the right vertical bar (B)
     * @param {number} [bottomHeight=10] - size of the bottom horizontal bar (D)
     */
    function NineSlicePlane(texture, leftWidth, topHeight, rightWidth, bottomHeight) {
        if (leftWidth === void 0) { leftWidth = DEFAULT_BORDER_SIZE; }
        if (topHeight === void 0) { topHeight = DEFAULT_BORDER_SIZE; }
        if (rightWidth === void 0) { rightWidth = DEFAULT_BORDER_SIZE; }
        if (bottomHeight === void 0) { bottomHeight = DEFAULT_BORDER_SIZE; }
        var _this = _super.call(this, core.Texture.WHITE, 4, 4) || this;
        _this._origWidth = texture.orig.width;
        _this._origHeight = texture.orig.height;
        /** The width of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane. */
        _this._width = _this._origWidth;
        /** The height of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane. */
        _this._height = _this._origHeight;
        _this._leftWidth = leftWidth;
        _this._rightWidth = rightWidth;
        _this._topHeight = topHeight;
        _this._bottomHeight = bottomHeight;
        // lets call the setter to ensure all necessary updates are performed
        _this.texture = texture;
        return _this;
    }
    NineSlicePlane.prototype.textureUpdated = function () {
        this._textureID = this.shader.texture._updateID;
        this._refresh();
    };
    Object.defineProperty(NineSlicePlane.prototype, "vertices", {
        get: function () {
            return this.geometry.getBuffer('aVertexPosition').data;
        },
        set: function (value) {
            this.geometry.getBuffer('aVertexPosition').data = value;
        },
        enumerable: false,
        configurable: true
    });
    /** Updates the horizontal vertices. */
    NineSlicePlane.prototype.updateHorizontalVertices = function () {
        var vertices = this.vertices;
        var scale = this._getMinScale();
        vertices[9] = vertices[11] = vertices[13] = vertices[15] = this._topHeight * scale;
        vertices[17] = vertices[19] = vertices[21] = vertices[23] = this._height - (this._bottomHeight * scale);
        vertices[25] = vertices[27] = vertices[29] = vertices[31] = this._height;
    };
    /** Updates the vertical vertices. */
    NineSlicePlane.prototype.updateVerticalVertices = function () {
        var vertices = this.vertices;
        var scale = this._getMinScale();
        vertices[2] = vertices[10] = vertices[18] = vertices[26] = this._leftWidth * scale;
        vertices[4] = vertices[12] = vertices[20] = vertices[28] = this._width - (this._rightWidth * scale);
        vertices[6] = vertices[14] = vertices[22] = vertices[30] = this._width;
    };
    /**
     * Returns the smaller of a set of vertical and horizontal scale of nine slice corners.
     * @returns Smaller number of vertical and horizontal scale.
     */
    NineSlicePlane.prototype._getMinScale = function () {
        var w = this._leftWidth + this._rightWidth;
        var scaleW = this._width > w ? 1.0 : this._width / w;
        var h = this._topHeight + this._bottomHeight;
        var scaleH = this._height > h ? 1.0 : this._height / h;
        var scale = Math.min(scaleW, scaleH);
        return scale;
    };
    Object.defineProperty(NineSlicePlane.prototype, "width", {
        /** The width of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane. */
        get: function () {
            return this._width;
        },
        set: function (value) {
            this._width = value;
            this._refresh();
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(NineSlicePlane.prototype, "height", {
        /** The height of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane. */
        get: function () {
            return this._height;
        },
        set: function (value) {
            this._height = value;
            this._refresh();
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(NineSlicePlane.prototype, "leftWidth", {
        /** The width of the left column. */
        get: function () {
            return this._leftWidth;
        },
        set: function (value) {
            this._leftWidth = value;
            this._refresh();
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(NineSlicePlane.prototype, "rightWidth", {
        /** The width of the right column. */
        get: function () {
            return this._rightWidth;
        },
        set: function (value) {
            this._rightWidth = value;
            this._refresh();
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(NineSlicePlane.prototype, "topHeight", {
        /** The height of the top row. */
        get: function () {
            return this._topHeight;
        },
        set: function (value) {
            this._topHeight = value;
            this._refresh();
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(NineSlicePlane.prototype, "bottomHeight", {
        /** The height of the bottom row. */
        get: function () {
            return this._bottomHeight;
        },
        set: function (value) {
            this._bottomHeight = value;
            this._refresh();
        },
        enumerable: false,
        configurable: true
    });
    /** Refreshes NineSlicePlane coords. All of them. */
    NineSlicePlane.prototype._refresh = function () {
        var texture = this.texture;
        var uvs = this.geometry.buffers[1].data;
        this._origWidth = texture.orig.width;
        this._origHeight = texture.orig.height;
        var _uvw = 1.0 / this._origWidth;
        var _uvh = 1.0 / this._origHeight;
        uvs[0] = uvs[8] = uvs[16] = uvs[24] = 0;
        uvs[1] = uvs[3] = uvs[5] = uvs[7] = 0;
        uvs[6] = uvs[14] = uvs[22] = uvs[30] = 1;
        uvs[25] = uvs[27] = uvs[29] = uvs[31] = 1;
        uvs[2] = uvs[10] = uvs[18] = uvs[26] = _uvw * this._leftWidth;
        uvs[4] = uvs[12] = uvs[20] = uvs[28] = 1 - (_uvw * this._rightWidth);
        uvs[9] = uvs[11] = uvs[13] = uvs[15] = _uvh * this._topHeight;
        uvs[17] = uvs[19] = uvs[21] = uvs[23] = 1 - (_uvh * this._bottomHeight);
        this.updateHorizontalVertices();
        this.updateVerticalVertices();
        this.geometry.buffers[0].update();
        this.geometry.buffers[1].update();
    };
    return NineSlicePlane;
}(SimplePlane));

exports.NineSlicePlane = NineSlicePlane;
exports.PlaneGeometry = PlaneGeometry;
exports.RopeGeometry = RopeGeometry;
exports.SimpleMesh = SimpleMesh;
exports.SimplePlane = SimplePlane;
exports.SimpleRope = SimpleRope;
//# sourceMappingURL=mesh-extras.js.map
