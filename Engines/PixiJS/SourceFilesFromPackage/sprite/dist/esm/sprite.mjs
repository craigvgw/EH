/*!
 * @pixi/sprite - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/sprite is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
import { BLEND_MODES } from '@pixi/constants';
import { Texture } from '@pixi/core';
import { Bounds, Container } from '@pixi/display';
import { Point, Rectangle, ObservablePoint } from '@pixi/math';
import { settings } from '@pixi/settings';
import { sign } from '@pixi/utils';

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

var tempPoint = new Point();
var indices = new Uint16Array([0, 1, 2, 0, 2, 3]);
/**
 * The Sprite object is the base for all textured objects that are rendered to the screen
 *
 * A sprite can be created directly from an image like this:
 *
 * ```js
 * let sprite = PIXI.Sprite.from('assets/image.png');
 * ```
 *
 * The more efficient way to create sprites is using a {@link PIXI.Spritesheet},
 * as swapping base textures when rendering to the screen is inefficient.
 *
 * ```js
 * PIXI.Loader.shared.add("assets/spritesheet.json").load(setup);
 *
 * function setup() {
 *   let sheet = PIXI.Loader.shared.resources["assets/spritesheet.json"].spritesheet;
 *   let sprite = new PIXI.Sprite(sheet.textures["image.png"]);
 *   ...
 * }
 * ```
 * @memberof PIXI
 */
var Sprite = /** @class */ (function (_super) {
    __extends(Sprite, _super);
    /** @param texture - The texture for this sprite. */
    function Sprite(texture) {
        var _this = _super.call(this) || this;
        _this._anchor = new ObservablePoint(_this._onAnchorUpdate, _this, (texture ? texture.defaultAnchor.x : 0), (texture ? texture.defaultAnchor.y : 0));
        _this._texture = null;
        _this._width = 0;
        _this._height = 0;
        _this._tint = null;
        _this._tintRGB = null;
        _this.tint = 0xFFFFFF;
        _this.blendMode = BLEND_MODES.NORMAL;
        _this._cachedTint = 0xFFFFFF;
        _this.uvs = null;
        // call texture setter
        _this.texture = texture || Texture.EMPTY;
        _this.vertexData = new Float32Array(8);
        _this.vertexTrimmedData = null;
        _this._transformID = -1;
        _this._textureID = -1;
        _this._transformTrimmedID = -1;
        _this._textureTrimmedID = -1;
        // Batchable stuff..
        // TODO could make this a mixin?
        _this.indices = indices;
        _this.pluginName = 'batch';
        /**
         * Used to fast check if a sprite is.. a sprite!
         * @member {boolean}
         */
        _this.isSprite = true;
        _this._roundPixels = settings.ROUND_PIXELS;
        return _this;
    }
    /** When the texture is updated, this event will fire to update the scale and frame. */
    Sprite.prototype._onTextureUpdate = function () {
        this._textureID = -1;
        this._textureTrimmedID = -1;
        this._cachedTint = 0xFFFFFF;
        // so if _width is 0 then width was not set..
        if (this._width) {
            this.scale.x = sign(this.scale.x) * this._width / this._texture.orig.width;
        }
        if (this._height) {
            this.scale.y = sign(this.scale.y) * this._height / this._texture.orig.height;
        }
    };
    /** Called when the anchor position updates. */
    Sprite.prototype._onAnchorUpdate = function () {
        this._transformID = -1;
        this._transformTrimmedID = -1;
    };
    /** Calculates worldTransform * vertices, store it in vertexData. */
    Sprite.prototype.calculateVertices = function () {
        var texture = this._texture;
        if (this._transformID === this.transform._worldID && this._textureID === texture._updateID) {
            return;
        }
        // update texture UV here, because base texture can be changed without calling `_onTextureUpdate`
        if (this._textureID !== texture._updateID) {
            this.uvs = this._texture._uvs.uvsFloat32;
        }
        this._transformID = this.transform._worldID;
        this._textureID = texture._updateID;
        // set the vertex data
        var wt = this.transform.worldTransform;
        var a = wt.a;
        var b = wt.b;
        var c = wt.c;
        var d = wt.d;
        var tx = wt.tx;
        var ty = wt.ty;
        var vertexData = this.vertexData;
        var trim = texture.trim;
        var orig = texture.orig;
        var anchor = this._anchor;
        var w0 = 0;
        var w1 = 0;
        var h0 = 0;
        var h1 = 0;
        if (trim) {
            // if the sprite is trimmed and is not a tilingsprite then we need to add the extra
            // space before transforming the sprite coords.
            w1 = trim.x - (anchor._x * orig.width);
            w0 = w1 + trim.width;
            h1 = trim.y - (anchor._y * orig.height);
            h0 = h1 + trim.height;
        }
        else {
            w1 = -anchor._x * orig.width;
            w0 = w1 + orig.width;
            h1 = -anchor._y * orig.height;
            h0 = h1 + orig.height;
        }
        // xy
        vertexData[0] = (a * w1) + (c * h1) + tx;
        vertexData[1] = (d * h1) + (b * w1) + ty;
        // xy
        vertexData[2] = (a * w0) + (c * h1) + tx;
        vertexData[3] = (d * h1) + (b * w0) + ty;
        // xy
        vertexData[4] = (a * w0) + (c * h0) + tx;
        vertexData[5] = (d * h0) + (b * w0) + ty;
        // xy
        vertexData[6] = (a * w1) + (c * h0) + tx;
        vertexData[7] = (d * h0) + (b * w1) + ty;
        if (this._roundPixels) {
            var resolution = settings.RESOLUTION;
            for (var i = 0; i < vertexData.length; ++i) {
                vertexData[i] = Math.round((vertexData[i] * resolution | 0) / resolution);
            }
        }
    };
    /**
     * Calculates worldTransform * vertices for a non texture with a trim. store it in vertexTrimmedData.
     *
     * This is used to ensure that the true width and height of a trimmed texture is respected.
     */
    Sprite.prototype.calculateTrimmedVertices = function () {
        if (!this.vertexTrimmedData) {
            this.vertexTrimmedData = new Float32Array(8);
        }
        else if (this._transformTrimmedID === this.transform._worldID && this._textureTrimmedID === this._texture._updateID) {
            return;
        }
        this._transformTrimmedID = this.transform._worldID;
        this._textureTrimmedID = this._texture._updateID;
        // lets do some special trim code!
        var texture = this._texture;
        var vertexData = this.vertexTrimmedData;
        var orig = texture.orig;
        var anchor = this._anchor;
        // lets calculate the new untrimmed bounds..
        var wt = this.transform.worldTransform;
        var a = wt.a;
        var b = wt.b;
        var c = wt.c;
        var d = wt.d;
        var tx = wt.tx;
        var ty = wt.ty;
        var w1 = -anchor._x * orig.width;
        var w0 = w1 + orig.width;
        var h1 = -anchor._y * orig.height;
        var h0 = h1 + orig.height;
        // xy
        vertexData[0] = (a * w1) + (c * h1) + tx;
        vertexData[1] = (d * h1) + (b * w1) + ty;
        // xy
        vertexData[2] = (a * w0) + (c * h1) + tx;
        vertexData[3] = (d * h1) + (b * w0) + ty;
        // xy
        vertexData[4] = (a * w0) + (c * h0) + tx;
        vertexData[5] = (d * h0) + (b * w0) + ty;
        // xy
        vertexData[6] = (a * w1) + (c * h0) + tx;
        vertexData[7] = (d * h0) + (b * w1) + ty;
    };
    /**
     *
     * Renders the object using the WebGL renderer
     * @param renderer - The webgl renderer to use.
     */
    Sprite.prototype._render = function (renderer) {
        this.calculateVertices();
        renderer.batch.setObjectRenderer(renderer.plugins[this.pluginName]);
        renderer.plugins[this.pluginName].render(this);
    };
    /** Updates the bounds of the sprite. */
    Sprite.prototype._calculateBounds = function () {
        var trim = this._texture.trim;
        var orig = this._texture.orig;
        // First lets check to see if the current texture has a trim..
        if (!trim || (trim.width === orig.width && trim.height === orig.height)) {
            // no trim! lets use the usual calculations..
            this.calculateVertices();
            this._bounds.addQuad(this.vertexData);
        }
        else {
            // lets calculate a special trimmed bounds...
            this.calculateTrimmedVertices();
            this._bounds.addQuad(this.vertexTrimmedData);
        }
    };
    /**
     * Gets the local bounds of the sprite object.
     * @param rect - Optional output rectangle.
     * @returns The bounds.
     */
    Sprite.prototype.getLocalBounds = function (rect) {
        // we can do a fast local bounds if the sprite has no children!
        if (this.children.length === 0) {
            if (!this._localBounds) {
                this._localBounds = new Bounds();
            }
            this._localBounds.minX = this._texture.orig.width * -this._anchor._x;
            this._localBounds.minY = this._texture.orig.height * -this._anchor._y;
            this._localBounds.maxX = this._texture.orig.width * (1 - this._anchor._x);
            this._localBounds.maxY = this._texture.orig.height * (1 - this._anchor._y);
            if (!rect) {
                if (!this._localBoundsRect) {
                    this._localBoundsRect = new Rectangle();
                }
                rect = this._localBoundsRect;
            }
            return this._localBounds.getRectangle(rect);
        }
        return _super.prototype.getLocalBounds.call(this, rect);
    };
    /**
     * Tests if a point is inside this sprite
     * @param point - the point to test
     * @returns The result of the test
     */
    Sprite.prototype.containsPoint = function (point) {
        this.worldTransform.applyInverse(point, tempPoint);
        var width = this._texture.orig.width;
        var height = this._texture.orig.height;
        var x1 = -width * this.anchor.x;
        var y1 = 0;
        if (tempPoint.x >= x1 && tempPoint.x < x1 + width) {
            y1 = -height * this.anchor.y;
            if (tempPoint.y >= y1 && tempPoint.y < y1 + height) {
                return true;
            }
        }
        return false;
    };
    /**
     * Destroys this sprite and optionally its texture and children.
     * @param options - Options parameter. A boolean will act as if all options
     *  have been set to that value
     * @param [options.children=false] - if set to true, all the children will have their destroy
     *      method called as well. 'options' will be passed on to those calls.
     * @param [options.texture=false] - Should it destroy the current texture of the sprite as well
     * @param [options.baseTexture=false] - Should it destroy the base texture of the sprite as well
     */
    Sprite.prototype.destroy = function (options) {
        _super.prototype.destroy.call(this, options);
        this._texture.off('update', this._onTextureUpdate, this);
        this._anchor = null;
        var destroyTexture = typeof options === 'boolean' ? options : options && options.texture;
        if (destroyTexture) {
            var destroyBaseTexture = typeof options === 'boolean' ? options : options && options.baseTexture;
            this._texture.destroy(!!destroyBaseTexture);
        }
        this._texture = null;
    };
    // some helper functions..
    /**
     * Helper function that creates a new sprite based on the source you provide.
     * The source can be - frame id, image url, video url, canvas element, video element, base texture
     * @param {string|PIXI.Texture|HTMLCanvasElement|HTMLVideoElement} source - Source to create texture from
     * @param {object} [options] - See {@link PIXI.BaseTexture}'s constructor for options.
     * @returns The newly created sprite
     */
    Sprite.from = function (source, options) {
        var texture = (source instanceof Texture)
            ? source
            : Texture.from(source, options);
        return new Sprite(texture);
    };
    Object.defineProperty(Sprite.prototype, "roundPixels", {
        get: function () {
            return this._roundPixels;
        },
        /**
         * If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
         *
         * Advantages can include sharper image quality (like text) and faster rendering on canvas.
         * The main disadvantage is movement of objects may appear less smooth.
         *
         * To set the global default, change {@link PIXI.settings.ROUND_PIXELS}.
         * @default false
         */
        set: function (value) {
            if (this._roundPixels !== value) {
                this._transformID = -1;
            }
            this._roundPixels = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Sprite.prototype, "width", {
        /** The width of the sprite, setting this will actually modify the scale to achieve the value set. */
        get: function () {
            return Math.abs(this.scale.x) * this._texture.orig.width;
        },
        set: function (value) {
            var s = sign(this.scale.x) || 1;
            this.scale.x = s * value / this._texture.orig.width;
            this._width = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Sprite.prototype, "height", {
        /** The height of the sprite, setting this will actually modify the scale to achieve the value set. */
        get: function () {
            return Math.abs(this.scale.y) * this._texture.orig.height;
        },
        set: function (value) {
            var s = sign(this.scale.y) || 1;
            this.scale.y = s * value / this._texture.orig.height;
            this._height = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Sprite.prototype, "anchor", {
        /**
         * The anchor sets the origin point of the sprite. The default value is taken from the {@link PIXI.Texture|Texture}
         * and passed to the constructor.
         *
         * The default is `(0,0)`, this means the sprite's origin is the top left.
         *
         * Setting the anchor to `(0.5,0.5)` means the sprite's origin is centered.
         *
         * Setting the anchor to `(1,1)` would mean the sprite's origin point will be the bottom right corner.
         *
         * If you pass only single parameter, it will set both x and y to the same value as shown in the example below.
         * @example
         * const sprite = new PIXI.Sprite(texture);
         * sprite.anchor.set(0.5); // This will set the origin to center. (0.5) is same as (0.5, 0.5).
         */
        get: function () {
            return this._anchor;
        },
        set: function (value) {
            this._anchor.copyFrom(value);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Sprite.prototype, "tint", {
        /**
         * The tint applied to the sprite. This is a hex value.
         *
         * A value of 0xFFFFFF will remove any tint effect.
         * @default 0xFFFFFF
         */
        get: function () {
            return this._tint;
        },
        set: function (value) {
            this._tint = value;
            this._tintRGB = (value >> 16) + (value & 0xff00) + ((value & 0xff) << 16);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Sprite.prototype, "texture", {
        /** The texture that the sprite is using. */
        get: function () {
            return this._texture;
        },
        set: function (value) {
            if (this._texture === value) {
                return;
            }
            if (this._texture) {
                this._texture.off('update', this._onTextureUpdate, this);
            }
            this._texture = value || Texture.EMPTY;
            this._cachedTint = 0xFFFFFF;
            this._textureID = -1;
            this._textureTrimmedID = -1;
            if (value) {
                // wait for the texture to load
                if (value.baseTexture.valid) {
                    this._onTextureUpdate();
                }
                else {
                    value.once('update', this._onTextureUpdate, this);
                }
            }
        },
        enumerable: false,
        configurable: true
    });
    return Sprite;
}(Container));

export { Sprite };
//# sourceMappingURL=sprite.mjs.map
