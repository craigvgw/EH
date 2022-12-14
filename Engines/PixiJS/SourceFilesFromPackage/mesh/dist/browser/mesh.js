/*!
 * @pixi/mesh - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/mesh is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_mesh = (function (exports, core, math, constants, display, settings, utils) {
    'use strict';

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

    var __assign = function() {
        __assign = Object.assign || function __assign(t) {
            var arguments$1 = arguments;

            for (var s, i = 1, n = arguments.length; i < n; i++) {
                s = arguments$1[i];
                for (var p in s) { if (Object.prototype.hasOwnProperty.call(s, p)) { t[p] = s[p]; } }
            }
            return t;
        };
        return __assign.apply(this, arguments);
    };

    function __rest(s, e) {
        var t = {};
        for (var p in s) { if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
            { t[p] = s[p]; } }
        if (s != null && typeof Object.getOwnPropertySymbols === "function")
            { for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
                if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                    { t[p[i]] = s[p[i]]; }
            } }
        return t;
    }

    function __decorate(decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") { r = Reflect.decorate(decorators, target, key, desc); }
        else { for (var i = decorators.length - 1; i >= 0; i--) { if (d = decorators[i]) { r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r; } } }
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    }

    function __param(paramIndex, decorator) {
        return function (target, key) { decorator(target, key, paramIndex); }
    }

    function __metadata(metadataKey, metadataValue) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") { return Reflect.metadata(metadataKey, metadataValue); }
    }

    function __awaiter(thisArg, _arguments, P, generator) {
        function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
        return new (P || (P = Promise))(function (resolve, reject) {
            function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
            function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
            function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
            step((generator = generator.apply(thisArg, _arguments || [])).next());
        });
    }

    function __generator(thisArg, body) {
        var _ = { label: 0, sent: function() { if (t[0] & 1) { throw t[1]; } return t[1]; }, trys: [], ops: [] }, f, y, t, g;
        return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
        function verb(n) { return function (v) { return step([n, v]); }; }
        function step(op) {
            if (f) { throw new TypeError("Generator is already executing."); }
            while (_) { try {
                if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) { return t; }
                if (y = 0, t) { op = [op[0] & 2, t.value]; }
                switch (op[0]) {
                    case 0: case 1: t = op; break;
                    case 4: _.label++; return { value: op[1], done: false };
                    case 5: _.label++; y = op[1]; op = [0]; continue;
                    case 7: op = _.ops.pop(); _.trys.pop(); continue;
                    default:
                        if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                        if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                        if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                        if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                        if (t[2]) { _.ops.pop(); }
                        _.trys.pop(); continue;
                }
                op = body.call(thisArg, _);
            } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; } }
            if (op[0] & 5) { throw op[1]; } return { value: op[0] ? op[1] : void 0, done: true };
        }
    }

    function __createBinding(o, m, k, k2) {
        if (k2 === undefined) { k2 = k; }
        o[k2] = m[k];
    }

    function __exportStar(m, exports) {
        for (var p in m) { if (p !== "default" && !exports.hasOwnProperty(p)) { exports[p] = m[p]; } }
    }

    function __values(o) {
        var s = typeof Symbol === "function" && Symbol.iterator, m = s && o[s], i = 0;
        if (m) { return m.call(o); }
        if (o && typeof o.length === "number") { return {
            next: function () {
                if (o && i >= o.length) { o = void 0; }
                return { value: o && o[i++], done: !o };
            }
        }; }
        throw new TypeError(s ? "Object is not iterable." : "Symbol.iterator is not defined.");
    }

    function __read(o, n) {
        var m = typeof Symbol === "function" && o[Symbol.iterator];
        if (!m) { return o; }
        var i = m.call(o), r, ar = [], e;
        try {
            while ((n === void 0 || n-- > 0) && !(r = i.next()).done) { ar.push(r.value); }
        }
        catch (error) { e = { error: error }; }
        finally {
            try {
                if (r && !r.done && (m = i["return"])) { m.call(i); }
            }
            finally { if (e) { throw e.error; } }
        }
        return ar;
    }

    function __spread() {
        var arguments$1 = arguments;

        for (var ar = [], i = 0; i < arguments.length; i++)
            { ar = ar.concat(__read(arguments$1[i])); }
        return ar;
    }

    function __spreadArrays() {
        var arguments$1 = arguments;

        for (var s = 0, i = 0, il = arguments.length; i < il; i++) { s += arguments$1[i].length; }
        for (var r = Array(s), k = 0, i = 0; i < il; i++)
            { for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
                { r[k] = a[j]; } }
        return r;
    };

    function __await(v) {
        return this instanceof __await ? (this.v = v, this) : new __await(v);
    }

    function __asyncGenerator(thisArg, _arguments, generator) {
        if (!Symbol.asyncIterator) { throw new TypeError("Symbol.asyncIterator is not defined."); }
        var g = generator.apply(thisArg, _arguments || []), i, q = [];
        return i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i;
        function verb(n) { if (g[n]) { i[n] = function (v) { return new Promise(function (a, b) { q.push([n, v, a, b]) > 1 || resume(n, v); }); }; } }
        function resume(n, v) { try { step(g[n](v)); } catch (e) { settle(q[0][3], e); } }
        function step(r) { r.value instanceof __await ? Promise.resolve(r.value.v).then(fulfill, reject) : settle(q[0][2], r); }
        function fulfill(value) { resume("next", value); }
        function reject(value) { resume("throw", value); }
        function settle(f, v) { if (f(v), q.shift(), q.length) { resume(q[0][0], q[0][1]); } }
    }

    function __asyncDelegator(o) {
        var i, p;
        return i = {}, verb("next"), verb("throw", function (e) { throw e; }), verb("return"), i[Symbol.iterator] = function () { return this; }, i;
        function verb(n, f) { i[n] = o[n] ? function (v) { return (p = !p) ? { value: __await(o[n](v)), done: n === "return" } : f ? f(v) : v; } : f; }
    }

    function __asyncValues(o) {
        if (!Symbol.asyncIterator) { throw new TypeError("Symbol.asyncIterator is not defined."); }
        var m = o[Symbol.asyncIterator], i;
        return m ? m.call(o) : (o = typeof __values === "function" ? __values(o) : o[Symbol.iterator](), i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i);
        function verb(n) { i[n] = o[n] && function (v) { return new Promise(function (resolve, reject) { v = o[n](v), settle(resolve, reject, v.done, v.value); }); }; }
        function settle(resolve, reject, d, v) { Promise.resolve(v).then(function(v) { resolve({ value: v, done: d }); }, reject); }
    }

    function __makeTemplateObject(cooked, raw) {
        if (Object.defineProperty) { Object.defineProperty(cooked, "raw", { value: raw }); } else { cooked.raw = raw; }
        return cooked;
    };

    function __importStar(mod) {
        if (mod && mod.__esModule) { return mod; }
        var result = {};
        if (mod != null) { for (var k in mod) { if (Object.hasOwnProperty.call(mod, k)) { result[k] = mod[k]; } } }
        result.default = mod;
        return result;
    }

    function __importDefault(mod) {
        return (mod && mod.__esModule) ? mod : { default: mod };
    }

    function __classPrivateFieldGet(receiver, privateMap) {
        if (!privateMap.has(receiver)) {
            throw new TypeError("attempted to get private field on non-instance");
        }
        return privateMap.get(receiver);
    }

    function __classPrivateFieldSet(receiver, privateMap, value) {
        if (!privateMap.has(receiver)) {
            throw new TypeError("attempted to set private field on non-instance");
        }
        privateMap.set(receiver, value);
        return value;
    }

    /**
     * Class controls cache for UV mapping from Texture normal space to BaseTexture normal space.
     * @memberof PIXI
     */
    var MeshBatchUvs = /** @class */ (function () {
        /**
         * @param uvBuffer - Buffer with normalized uv's
         * @param uvMatrix - Material UV matrix
         */
        function MeshBatchUvs(uvBuffer, uvMatrix) {
            this.uvBuffer = uvBuffer;
            this.uvMatrix = uvMatrix;
            this.data = null;
            this._bufferUpdateId = -1;
            this._textureUpdateId = -1;
            this._updateID = 0;
        }
        /**
         * Updates
         * @param forceUpdate - force the update
         */
        MeshBatchUvs.prototype.update = function (forceUpdate) {
            if (!forceUpdate
                && this._bufferUpdateId === this.uvBuffer._updateID
                && this._textureUpdateId === this.uvMatrix._updateID) {
                return;
            }
            this._bufferUpdateId = this.uvBuffer._updateID;
            this._textureUpdateId = this.uvMatrix._updateID;
            var data = this.uvBuffer.data;
            if (!this.data || this.data.length !== data.length) {
                this.data = new Float32Array(data.length);
            }
            this.uvMatrix.multiplyUvs(data, this.data);
            this._updateID++;
        };
        return MeshBatchUvs;
    }());

    var tempPoint = new math.Point();
    var tempPolygon = new math.Polygon();
    /**
     * Base mesh class.
     *
     * This class empowers you to have maximum flexibility to render any kind of WebGL visuals you can think of.
     * This class assumes a certain level of WebGL knowledge.
     * If you know a bit this should abstract enough away to make your life easier!
     *
     * Pretty much ALL WebGL can be broken down into the following:
     * - Geometry - The structure and data for the mesh. This can include anything from positions, uvs, normals, colors etc..
     * - Shader - This is the shader that PixiJS will render the geometry with (attributes in the shader must match the geometry)
     * - State - This is the state of WebGL required to render the mesh.
     *
     * Through a combination of the above elements you can render anything you want, 2D or 3D!
     * @memberof PIXI
     */
    var Mesh = /** @class */ (function (_super) {
        __extends(Mesh, _super);
        /**
         * @param geometry - The geometry the mesh will use.
         * @param {PIXI.MeshMaterial} shader - The shader the mesh will use.
         * @param state - The state that the WebGL context is required to be in to render the mesh
         *        if no state is provided, uses {@link PIXI.State.for2d} to create a 2D state for PixiJS.
         * @param drawMode - The drawMode, can be any of the {@link PIXI.DRAW_MODES} constants.
         */
        function Mesh(geometry, shader, state, drawMode) {
            if (drawMode === void 0) { drawMode = constants.DRAW_MODES.TRIANGLES; }
            var _this = _super.call(this) || this;
            _this.geometry = geometry;
            _this.shader = shader;
            _this.state = state || core.State.for2d();
            _this.drawMode = drawMode;
            _this.start = 0;
            _this.size = 0;
            _this.uvs = null;
            _this.indices = null;
            _this.vertexData = new Float32Array(1);
            _this.vertexDirty = -1;
            _this._transformID = -1;
            _this._roundPixels = settings.settings.ROUND_PIXELS;
            _this.batchUvs = null;
            return _this;
        }
        Object.defineProperty(Mesh.prototype, "geometry", {
            /**
             * Includes vertex positions, face indices, normals, colors, UVs, and
             * custom attributes within buffers, reducing the cost of passing all
             * this data to the GPU. Can be shared between multiple Mesh objects.
             */
            get: function () {
                return this._geometry;
            },
            set: function (value) {
                if (this._geometry === value) {
                    return;
                }
                if (this._geometry) {
                    this._geometry.refCount--;
                    if (this._geometry.refCount === 0) {
                        this._geometry.dispose();
                    }
                }
                this._geometry = value;
                if (this._geometry) {
                    this._geometry.refCount++;
                }
                this.vertexDirty = -1;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Mesh.prototype, "uvBuffer", {
            /**
             * To change mesh uv's, change its uvBuffer data and increment its _updateID.
             * @readonly
             */
            get: function () {
                return this.geometry.buffers[1];
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Mesh.prototype, "verticesBuffer", {
            /**
             * To change mesh vertices, change its uvBuffer data and increment its _updateID.
             * Incrementing _updateID is optional because most of Mesh objects do it anyway.
             * @readonly
             */
            get: function () {
                return this.geometry.buffers[0];
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Mesh.prototype, "material", {
            get: function () {
                return this.shader;
            },
            /** Alias for {@link PIXI.Mesh#shader}. */
            set: function (value) {
                this.shader = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Mesh.prototype, "blendMode", {
            get: function () {
                return this.state.blendMode;
            },
            /**
             * The blend mode to be applied to the Mesh. Apply a value of
             * `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
             * @default PIXI.BLEND_MODES.NORMAL;
             */
            set: function (value) {
                this.state.blendMode = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Mesh.prototype, "roundPixels", {
            get: function () {
                return this._roundPixels;
            },
            /**
             * If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
             * Advantages can include sharper image quality (like text) and faster rendering on canvas.
             * The main disadvantage is movement of objects may appear less smooth.
             * To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
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
        Object.defineProperty(Mesh.prototype, "tint", {
            /**
             * The multiply tint applied to the Mesh. This is a hex value. A value of
             * `0xFFFFFF` will remove any tint effect.
             *
             * Null for non-MeshMaterial shaders
             * @default 0xFFFFFF
             */
            get: function () {
                return 'tint' in this.shader ? this.shader.tint : null;
            },
            set: function (value) {
                this.shader.tint = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Mesh.prototype, "texture", {
            /** The texture that the Mesh uses. Null for non-MeshMaterial shaders */
            get: function () {
                return 'texture' in this.shader ? this.shader.texture : null;
            },
            set: function (value) {
                this.shader.texture = value;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Standard renderer draw.
         * @param renderer - Instance to renderer.
         */
        Mesh.prototype._render = function (renderer) {
            // set properties for batching..
            // TODO could use a different way to grab verts?
            var vertices = this.geometry.buffers[0].data;
            var shader = this.shader;
            // TODO benchmark check for attribute size..
            if (shader.batchable
                && this.drawMode === constants.DRAW_MODES.TRIANGLES
                && vertices.length < Mesh.BATCHABLE_SIZE * 2) {
                this._renderToBatch(renderer);
            }
            else {
                this._renderDefault(renderer);
            }
        };
        /**
         * Standard non-batching way of rendering.
         * @param renderer - Instance to renderer.
         */
        Mesh.prototype._renderDefault = function (renderer) {
            var shader = this.shader;
            shader.alpha = this.worldAlpha;
            if (shader.update) {
                shader.update();
            }
            renderer.batch.flush();
            // bind and sync uniforms..
            shader.uniforms.translationMatrix = this.transform.worldTransform.toArray(true);
            renderer.shader.bind(shader);
            // set state..
            renderer.state.set(this.state);
            // bind the geometry...
            renderer.geometry.bind(this.geometry, shader);
            // then render it
            renderer.geometry.draw(this.drawMode, this.size, this.start, this.geometry.instanceCount);
        };
        /**
         * Rendering by using the Batch system.
         * @param renderer - Instance to renderer.
         */
        Mesh.prototype._renderToBatch = function (renderer) {
            var geometry = this.geometry;
            var shader = this.shader;
            if (shader.uvMatrix) {
                shader.uvMatrix.update();
                this.calculateUvs();
            }
            // set properties for batching..
            this.calculateVertices();
            this.indices = geometry.indexBuffer.data;
            this._tintRGB = shader._tintRGB;
            this._texture = shader.texture;
            var pluginName = this.material.pluginName;
            renderer.batch.setObjectRenderer(renderer.plugins[pluginName]);
            renderer.plugins[pluginName].render(this);
        };
        /** Updates vertexData field based on transform and vertices. */
        Mesh.prototype.calculateVertices = function () {
            var geometry = this.geometry;
            var verticesBuffer = geometry.buffers[0];
            var vertices = verticesBuffer.data;
            var vertexDirtyId = verticesBuffer._updateID;
            if (vertexDirtyId === this.vertexDirty && this._transformID === this.transform._worldID) {
                return;
            }
            this._transformID = this.transform._worldID;
            if (this.vertexData.length !== vertices.length) {
                this.vertexData = new Float32Array(vertices.length);
            }
            var wt = this.transform.worldTransform;
            var a = wt.a;
            var b = wt.b;
            var c = wt.c;
            var d = wt.d;
            var tx = wt.tx;
            var ty = wt.ty;
            var vertexData = this.vertexData;
            for (var i = 0; i < vertexData.length / 2; i++) {
                var x = vertices[(i * 2)];
                var y = vertices[(i * 2) + 1];
                vertexData[(i * 2)] = (a * x) + (c * y) + tx;
                vertexData[(i * 2) + 1] = (b * x) + (d * y) + ty;
            }
            if (this._roundPixels) {
                var resolution = settings.settings.RESOLUTION;
                for (var i = 0; i < vertexData.length; ++i) {
                    vertexData[i] = Math.round((vertexData[i] * resolution | 0) / resolution);
                }
            }
            this.vertexDirty = vertexDirtyId;
        };
        /** Updates uv field based on from geometry uv's or batchUvs. */
        Mesh.prototype.calculateUvs = function () {
            var geomUvs = this.geometry.buffers[1];
            var shader = this.shader;
            if (!shader.uvMatrix.isSimple) {
                if (!this.batchUvs) {
                    this.batchUvs = new MeshBatchUvs(geomUvs, shader.uvMatrix);
                }
                this.batchUvs.update();
                this.uvs = this.batchUvs.data;
            }
            else {
                this.uvs = geomUvs.data;
            }
        };
        /**
         * Updates the bounds of the mesh as a rectangle. The bounds calculation takes the worldTransform into account.
         * there must be a aVertexPosition attribute present in the geometry for bounds to be calculated correctly.
         */
        Mesh.prototype._calculateBounds = function () {
            this.calculateVertices();
            this._bounds.addVertexData(this.vertexData, 0, this.vertexData.length);
        };
        /**
         * Tests if a point is inside this mesh. Works only for PIXI.DRAW_MODES.TRIANGLES.
         * @param point - The point to test.
         * @returns - The result of the test.
         */
        Mesh.prototype.containsPoint = function (point) {
            if (!this.getBounds().contains(point.x, point.y)) {
                return false;
            }
            this.worldTransform.applyInverse(point, tempPoint);
            var vertices = this.geometry.getBuffer('aVertexPosition').data;
            var points = tempPolygon.points;
            var indices = this.geometry.getIndex().data;
            var len = indices.length;
            var step = this.drawMode === 4 ? 3 : 1;
            for (var i = 0; i + 2 < len; i += step) {
                var ind0 = indices[i] * 2;
                var ind1 = indices[i + 1] * 2;
                var ind2 = indices[i + 2] * 2;
                points[0] = vertices[ind0];
                points[1] = vertices[ind0 + 1];
                points[2] = vertices[ind1];
                points[3] = vertices[ind1 + 1];
                points[4] = vertices[ind2];
                points[5] = vertices[ind2 + 1];
                if (tempPolygon.contains(tempPoint.x, tempPoint.y)) {
                    return true;
                }
            }
            return false;
        };
        Mesh.prototype.destroy = function (options) {
            _super.prototype.destroy.call(this, options);
            if (this._cachedTexture) {
                this._cachedTexture.destroy();
                this._cachedTexture = null;
            }
            this.geometry = null;
            this.shader = null;
            this.state = null;
            this.uvs = null;
            this.indices = null;
            this.vertexData = null;
        };
        /** The maximum number of vertices to consider batchable. Generally, the complexity of the geometry. */
        Mesh.BATCHABLE_SIZE = 100;
        return Mesh;
    }(display.Container));

    var fragment = "varying vec2 vTextureCoord;\nuniform vec4 uColor;\n\nuniform sampler2D uSampler;\n\nvoid main(void)\n{\n    gl_FragColor = texture2D(uSampler, vTextureCoord) * uColor;\n}\n";

    var vertex = "attribute vec2 aVertexPosition;\nattribute vec2 aTextureCoord;\n\nuniform mat3 projectionMatrix;\nuniform mat3 translationMatrix;\nuniform mat3 uTextureMatrix;\n\nvarying vec2 vTextureCoord;\n\nvoid main(void)\n{\n    gl_Position = vec4((projectionMatrix * translationMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\n\n    vTextureCoord = (uTextureMatrix * vec3(aTextureCoord, 1.0)).xy;\n}\n";

    /**
     * Slightly opinionated default shader for PixiJS 2D objects.
     * @memberof PIXI
     */
    var MeshMaterial = /** @class */ (function (_super) {
        __extends(MeshMaterial, _super);
        /**
         * @param uSampler - Texture that material uses to render.
         * @param options - Additional options
         * @param {number} [options.alpha=1] - Default alpha.
         * @param {number} [options.tint=0xFFFFFF] - Default tint.
         * @param {string} [options.pluginName='batch'] - Renderer plugin for batching.
         * @param {PIXI.Program} [options.program=0xFFFFFF] - Custom program.
         * @param {object} [options.uniforms] - Custom uniforms.
         */
        function MeshMaterial(uSampler, options) {
            var _this = this;
            var uniforms = {
                uSampler: uSampler,
                alpha: 1,
                uTextureMatrix: math.Matrix.IDENTITY,
                uColor: new Float32Array([1, 1, 1, 1]),
            };
            // Set defaults
            options = Object.assign({
                tint: 0xFFFFFF,
                alpha: 1,
                pluginName: 'batch',
            }, options);
            if (options.uniforms) {
                Object.assign(uniforms, options.uniforms);
            }
            _this = _super.call(this, options.program || core.Program.from(vertex, fragment), uniforms) || this;
            _this._colorDirty = false;
            _this.uvMatrix = new core.TextureMatrix(uSampler);
            _this.batchable = options.program === undefined;
            _this.pluginName = options.pluginName;
            _this.tint = options.tint;
            _this.alpha = options.alpha;
            return _this;
        }
        Object.defineProperty(MeshMaterial.prototype, "texture", {
            /** Reference to the texture being rendered. */
            get: function () {
                return this.uniforms.uSampler;
            },
            set: function (value) {
                if (this.uniforms.uSampler !== value) {
                    if (!this.uniforms.uSampler.baseTexture.alphaMode !== !value.baseTexture.alphaMode) {
                        this._colorDirty = true;
                    }
                    this.uniforms.uSampler = value;
                    this.uvMatrix.texture = value;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(MeshMaterial.prototype, "alpha", {
            get: function () {
                return this._alpha;
            },
            /**
             * This gets automatically set by the object using this.
             * @default 1
             */
            set: function (value) {
                if (value === this._alpha)
                    { return; }
                this._alpha = value;
                this._colorDirty = true;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(MeshMaterial.prototype, "tint", {
            get: function () {
                return this._tint;
            },
            /**
             * Multiply tint for the material.
             * @default 0xFFFFFF
             */
            set: function (value) {
                if (value === this._tint)
                    { return; }
                this._tint = value;
                this._tintRGB = (value >> 16) + (value & 0xff00) + ((value & 0xff) << 16);
                this._colorDirty = true;
            },
            enumerable: false,
            configurable: true
        });
        /** Gets called automatically by the Mesh. Intended to be overridden for custom {@link MeshMaterial} objects. */
        MeshMaterial.prototype.update = function () {
            if (this._colorDirty) {
                this._colorDirty = false;
                var baseTexture = this.texture.baseTexture;
                utils.premultiplyTintToRgba(this._tint, this._alpha, this.uniforms.uColor, baseTexture.alphaMode);
            }
            if (this.uvMatrix.update()) {
                this.uniforms.uTextureMatrix = this.uvMatrix.mapCoord;
            }
        };
        return MeshMaterial;
    }(core.Shader));

    /**
     * Standard 2D geometry used in PixiJS.
     *
     * Geometry can be defined without passing in a style or data if required.
     *
     * ```js
     * const geometry = new PIXI.Geometry();
     *
     * geometry.addAttribute('positions', [0, 0, 100, 0, 100, 100, 0, 100], 2);
     * geometry.addAttribute('uvs', [0,0,1,0,1,1,0,1], 2);
     * geometry.addIndex([0,1,2,1,3,2]);
     *
     * ```
     * @memberof PIXI
     */
    var MeshGeometry = /** @class */ (function (_super) {
        __extends(MeshGeometry, _super);
        /**
         * @param {Float32Array|number[]} [vertices] - Positional data on geometry.
         * @param {Float32Array|number[]} [uvs] - Texture UVs.
         * @param {Uint16Array|number[]} [index] - IndexBuffer
         */
        function MeshGeometry(vertices, uvs, index) {
            var _this = _super.call(this) || this;
            var verticesBuffer = new core.Buffer(vertices);
            var uvsBuffer = new core.Buffer(uvs, true);
            var indexBuffer = new core.Buffer(index, true, true);
            _this.addAttribute('aVertexPosition', verticesBuffer, 2, false, constants.TYPES.FLOAT)
                .addAttribute('aTextureCoord', uvsBuffer, 2, false, constants.TYPES.FLOAT)
                .addIndex(indexBuffer);
            _this._updateId = -1;
            return _this;
        }
        Object.defineProperty(MeshGeometry.prototype, "vertexDirtyId", {
            /**
             * If the vertex position is updated.
             * @readonly
             * @private
             */
            get: function () {
                return this.buffers[0]._updateID;
            },
            enumerable: false,
            configurable: true
        });
        return MeshGeometry;
    }(core.Geometry));

    exports.Mesh = Mesh;
    exports.MeshBatchUvs = MeshBatchUvs;
    exports.MeshGeometry = MeshGeometry;
    exports.MeshMaterial = MeshMaterial;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI, PIXI, PIXI, PIXI.utils);
Object.assign(this.PIXI, _pixi_mesh);
//# sourceMappingURL=mesh.js.map
