/*!
 * @pixi/sprite-tiling - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/sprite-tiling is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_sprite_tiling = (function (exports, core, math, sprite, constants, utils) {
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

    var tempPoint = new math.Point();
    /**
     * A tiling sprite is a fast way of rendering a tiling image.
     * @memberof PIXI
     */
    var TilingSprite = /** @class */ (function (_super) {
        __extends(TilingSprite, _super);
        /**
         * @param texture - The texture of the tiling sprite.
         * @param width - The width of the tiling sprite.
         * @param height - The height of the tiling sprite.
         */
        function TilingSprite(texture, width, height) {
            if (width === void 0) { width = 100; }
            if (height === void 0) { height = 100; }
            var _this = _super.call(this, texture) || this;
            _this.tileTransform = new math.Transform();
            // The width of the tiling sprite
            _this._width = width;
            // The height of the tiling sprite
            _this._height = height;
            _this.uvMatrix = _this.texture.uvMatrix || new core.TextureMatrix(texture);
            /**
             * Plugin that is responsible for rendering this element.
             * Allows to customize the rendering process without overriding '_render' method.
             * @default 'tilingSprite'
             */
            _this.pluginName = 'tilingSprite';
            _this.uvRespectAnchor = false;
            return _this;
        }
        Object.defineProperty(TilingSprite.prototype, "clampMargin", {
            /**
             * Changes frame clamping in corresponding textureTransform, shortcut
             * Change to -0.5 to add a pixel to the edge, recommended for transparent trimmed textures in atlas
             * @default 0.5
             * @member {number}
             */
            get: function () {
                return this.uvMatrix.clampMargin;
            },
            set: function (value) {
                this.uvMatrix.clampMargin = value;
                this.uvMatrix.update(true);
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TilingSprite.prototype, "tileScale", {
            /** The scaling of the image that is being tiled. */
            get: function () {
                return this.tileTransform.scale;
            },
            set: function (value) {
                this.tileTransform.scale.copyFrom(value);
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TilingSprite.prototype, "tilePosition", {
            /** The offset of the image that is being tiled. */
            get: function () {
                return this.tileTransform.position;
            },
            set: function (value) {
                this.tileTransform.position.copyFrom(value);
            },
            enumerable: false,
            configurable: true
        });
        /**
         * @protected
         */
        TilingSprite.prototype._onTextureUpdate = function () {
            if (this.uvMatrix) {
                this.uvMatrix.texture = this._texture;
            }
            this._cachedTint = 0xFFFFFF;
        };
        /**
         * Renders the object using the WebGL renderer
         * @param renderer - The renderer
         */
        TilingSprite.prototype._render = function (renderer) {
            // tweak our texture temporarily..
            var texture = this._texture;
            if (!texture || !texture.valid) {
                return;
            }
            this.tileTransform.updateLocalTransform();
            this.uvMatrix.update();
            renderer.batch.setObjectRenderer(renderer.plugins[this.pluginName]);
            renderer.plugins[this.pluginName].render(this);
        };
        /** Updates the bounds of the tiling sprite. */
        TilingSprite.prototype._calculateBounds = function () {
            var minX = this._width * -this._anchor._x;
            var minY = this._height * -this._anchor._y;
            var maxX = this._width * (1 - this._anchor._x);
            var maxY = this._height * (1 - this._anchor._y);
            this._bounds.addFrame(this.transform, minX, minY, maxX, maxY);
        };
        /**
         * Gets the local bounds of the sprite object.
         * @param rect - Optional output rectangle.
         * @returns The bounds.
         */
        TilingSprite.prototype.getLocalBounds = function (rect) {
            // we can do a fast local bounds if the sprite has no children!
            if (this.children.length === 0) {
                this._bounds.minX = this._width * -this._anchor._x;
                this._bounds.minY = this._height * -this._anchor._y;
                this._bounds.maxX = this._width * (1 - this._anchor._x);
                this._bounds.maxY = this._height * (1 - this._anchor._y);
                if (!rect) {
                    if (!this._localBoundsRect) {
                        this._localBoundsRect = new math.Rectangle();
                    }
                    rect = this._localBoundsRect;
                }
                return this._bounds.getRectangle(rect);
            }
            return _super.prototype.getLocalBounds.call(this, rect);
        };
        /**
         * Checks if a point is inside this tiling sprite.
         * @param point - The point to check.
         * @returns Whether or not the sprite contains the point.
         */
        TilingSprite.prototype.containsPoint = function (point) {
            this.worldTransform.applyInverse(point, tempPoint);
            var width = this._width;
            var height = this._height;
            var x1 = -width * this.anchor._x;
            if (tempPoint.x >= x1 && tempPoint.x < x1 + width) {
                var y1 = -height * this.anchor._y;
                if (tempPoint.y >= y1 && tempPoint.y < y1 + height) {
                    return true;
                }
            }
            return false;
        };
        /**
         * Destroys this sprite and optionally its texture and children
         * @param {object|boolean} [options] - Options parameter. A boolean will act as if all options
         *  have been set to that value
         * @param {boolean} [options.children=false] - if set to true, all the children will have their destroy
         *      method called as well. 'options' will be passed on to those calls.
         * @param {boolean} [options.texture=false] - Should it destroy the current texture of the sprite as well
         * @param {boolean} [options.baseTexture=false] - Should it destroy the base texture of the sprite as well
         */
        TilingSprite.prototype.destroy = function (options) {
            _super.prototype.destroy.call(this, options);
            this.tileTransform = null;
            this.uvMatrix = null;
        };
        /**
         * Helper function that creates a new tiling sprite based on the source you provide.
         * The source can be - frame id, image url, video url, canvas element, video element, base texture
         * @static
         * @param {string|PIXI.Texture|HTMLCanvasElement|HTMLVideoElement} source - Source to create texture from
         * @param {object} options - See {@link PIXI.BaseTexture}'s constructor for options.
         * @param {number} options.width - required width of the tiling sprite
         * @param {number} options.height - required height of the tiling sprite
         * @returns {PIXI.TilingSprite} The newly created texture
         */
        TilingSprite.from = function (source, options) {
            var texture = (source instanceof core.Texture)
                ? source
                : core.Texture.from(source, options);
            return new TilingSprite(texture, options.width, options.height);
        };
        Object.defineProperty(TilingSprite.prototype, "width", {
            /** The width of the sprite, setting this will actually modify the scale to achieve the value set. */
            get: function () {
                return this._width;
            },
            set: function (value) {
                this._width = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TilingSprite.prototype, "height", {
            /** The height of the TilingSprite, setting this will actually modify the scale to achieve the value set. */
            get: function () {
                return this._height;
            },
            set: function (value) {
                this._height = value;
            },
            enumerable: false,
            configurable: true
        });
        return TilingSprite;
    }(sprite.Sprite));

    var fragmentSimpleSrc = "#version 100\n#define SHADER_NAME Tiling-Sprite-Simple-100\n\nprecision lowp float;\n\nvarying vec2 vTextureCoord;\n\nuniform sampler2D uSampler;\nuniform vec4 uColor;\n\nvoid main(void)\n{\n    vec4 texSample = texture2D(uSampler, vTextureCoord);\n    gl_FragColor = texSample * uColor;\n}\n";

    var gl1VertexSrc = "#version 100\n#define SHADER_NAME Tiling-Sprite-100\n\nprecision lowp float;\n\nattribute vec2 aVertexPosition;\nattribute vec2 aTextureCoord;\n\nuniform mat3 projectionMatrix;\nuniform mat3 translationMatrix;\nuniform mat3 uTransform;\n\nvarying vec2 vTextureCoord;\n\nvoid main(void)\n{\n    gl_Position = vec4((projectionMatrix * translationMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\n\n    vTextureCoord = (uTransform * vec3(aTextureCoord, 1.0)).xy;\n}\n";

    var gl1FragmentSrc = "#version 100\n#ifdef GL_EXT_shader_texture_lod\n    #extension GL_EXT_shader_texture_lod : enable\n#endif\n#define SHADER_NAME Tiling-Sprite-100\n\nprecision lowp float;\n\nvarying vec2 vTextureCoord;\n\nuniform sampler2D uSampler;\nuniform vec4 uColor;\nuniform mat3 uMapCoord;\nuniform vec4 uClampFrame;\nuniform vec2 uClampOffset;\n\nvoid main(void)\n{\n    vec2 coord = vTextureCoord + ceil(uClampOffset - vTextureCoord);\n    coord = (uMapCoord * vec3(coord, 1.0)).xy;\n    vec2 unclamped = coord;\n    coord = clamp(coord, uClampFrame.xy, uClampFrame.zw);\n\n    #ifdef GL_EXT_shader_texture_lod\n        vec4 texSample = unclamped == coord\n            ? texture2D(uSampler, coord) \n            : texture2DLodEXT(uSampler, coord, 0);\n    #else\n        vec4 texSample = texture2D(uSampler, coord);\n    #endif\n\n    gl_FragColor = texSample * uColor;\n}\n";

    var gl2VertexSrc = "#version 300 es\n#define SHADER_NAME Tiling-Sprite-300\n\nprecision lowp float;\n\nin vec2 aVertexPosition;\nin vec2 aTextureCoord;\n\nuniform mat3 projectionMatrix;\nuniform mat3 translationMatrix;\nuniform mat3 uTransform;\n\nout vec2 vTextureCoord;\n\nvoid main(void)\n{\n    gl_Position = vec4((projectionMatrix * translationMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\n\n    vTextureCoord = (uTransform * vec3(aTextureCoord, 1.0)).xy;\n}\n";

    var gl2FragmentSrc = "#version 300 es\n#define SHADER_NAME Tiling-Sprite-100\n\nprecision lowp float;\n\nin vec2 vTextureCoord;\n\nout vec4 fragmentColor;\n\nuniform sampler2D uSampler;\nuniform vec4 uColor;\nuniform mat3 uMapCoord;\nuniform vec4 uClampFrame;\nuniform vec2 uClampOffset;\n\nvoid main(void)\n{\n    vec2 coord = vTextureCoord + ceil(uClampOffset - vTextureCoord);\n    coord = (uMapCoord * vec3(coord, 1.0)).xy;\n    vec2 unclamped = coord;\n    coord = clamp(coord, uClampFrame.xy, uClampFrame.zw);\n\n    vec4 texSample = texture(uSampler, coord, unclamped == coord ? 0.0f : -32.0f);// lod-bias very negative to force lod 0\n\n    fragmentColor = texSample * uColor;\n}\n";

    var tempMat = new math.Matrix();
    /**
     * WebGL renderer plugin for tiling sprites
     * @class
     * @memberof PIXI
     * @extends PIXI.ObjectRenderer
     */
    var TilingSpriteRenderer = /** @class */ (function (_super) {
        __extends(TilingSpriteRenderer, _super);
        /**
         * constructor for renderer
         * @param {PIXI.Renderer} renderer - The renderer this tiling awesomeness works for.
         */
        function TilingSpriteRenderer(renderer) {
            var _this = _super.call(this, renderer) || this;
            // WebGL version is not available during initialization!
            renderer.runners.contextChange.add(_this);
            _this.quad = new core.QuadUv();
            /**
             * The WebGL state in which this renderer will work.
             * @member {PIXI.State}
             * @readonly
             */
            _this.state = core.State.for2d();
            return _this;
        }
        /** Creates shaders when context is initialized. */
        TilingSpriteRenderer.prototype.contextChange = function () {
            var renderer = this.renderer;
            var uniforms = { globals: renderer.globalUniforms };
            this.simpleShader = core.Shader.from(gl1VertexSrc, fragmentSimpleSrc, uniforms);
            this.shader = renderer.context.webGLVersion > 1
                ? core.Shader.from(gl2VertexSrc, gl2FragmentSrc, uniforms)
                : core.Shader.from(gl1VertexSrc, gl1FragmentSrc, uniforms);
        };
        /**
         * @param {PIXI.TilingSprite} ts - tilingSprite to be rendered
         */
        TilingSpriteRenderer.prototype.render = function (ts) {
            var renderer = this.renderer;
            var quad = this.quad;
            var vertices = quad.vertices;
            vertices[0] = vertices[6] = (ts._width) * -ts.anchor.x;
            vertices[1] = vertices[3] = ts._height * -ts.anchor.y;
            vertices[2] = vertices[4] = (ts._width) * (1.0 - ts.anchor.x);
            vertices[5] = vertices[7] = ts._height * (1.0 - ts.anchor.y);
            var anchorX = ts.uvRespectAnchor ? ts.anchor.x : 0;
            var anchorY = ts.uvRespectAnchor ? ts.anchor.y : 0;
            vertices = quad.uvs;
            vertices[0] = vertices[6] = -anchorX;
            vertices[1] = vertices[3] = -anchorY;
            vertices[2] = vertices[4] = 1.0 - anchorX;
            vertices[5] = vertices[7] = 1.0 - anchorY;
            quad.invalidate();
            var tex = ts._texture;
            var baseTex = tex.baseTexture;
            var premultiplied = baseTex.alphaMode > 0;
            var lt = ts.tileTransform.localTransform;
            var uv = ts.uvMatrix;
            var isSimple = baseTex.isPowerOfTwo
                && tex.frame.width === baseTex.width && tex.frame.height === baseTex.height;
            // auto, force repeat wrapMode for big tiling textures
            if (isSimple) {
                if (!baseTex._glTextures[renderer.CONTEXT_UID]) {
                    if (baseTex.wrapMode === constants.WRAP_MODES.CLAMP) {
                        baseTex.wrapMode = constants.WRAP_MODES.REPEAT;
                    }
                }
                else {
                    isSimple = baseTex.wrapMode !== constants.WRAP_MODES.CLAMP;
                }
            }
            var shader = isSimple ? this.simpleShader : this.shader;
            var w = tex.width;
            var h = tex.height;
            var W = ts._width;
            var H = ts._height;
            tempMat.set(lt.a * w / W, lt.b * w / H, lt.c * h / W, lt.d * h / H, lt.tx / W, lt.ty / H);
            // that part is the same as above:
            // tempMat.identity();
            // tempMat.scale(tex.width, tex.height);
            // tempMat.prepend(lt);
            // tempMat.scale(1.0 / ts._width, 1.0 / ts._height);
            tempMat.invert();
            if (isSimple) {
                tempMat.prepend(uv.mapCoord);
            }
            else {
                shader.uniforms.uMapCoord = uv.mapCoord.toArray(true);
                shader.uniforms.uClampFrame = uv.uClampFrame;
                shader.uniforms.uClampOffset = uv.uClampOffset;
            }
            shader.uniforms.uTransform = tempMat.toArray(true);
            shader.uniforms.uColor = utils.premultiplyTintToRgba(ts.tint, ts.worldAlpha, shader.uniforms.uColor, premultiplied);
            shader.uniforms.translationMatrix = ts.transform.worldTransform.toArray(true);
            shader.uniforms.uSampler = tex;
            renderer.shader.bind(shader);
            renderer.geometry.bind(quad);
            this.state.blendMode = utils.correctBlendMode(ts.blendMode, premultiplied);
            renderer.state.set(this.state);
            renderer.geometry.draw(this.renderer.gl.TRIANGLES, 6, 0);
        };
        /** @ignore */
        TilingSpriteRenderer.extension = {
            name: 'tilingSprite',
            type: core.ExtensionType.RendererPlugin,
        };
        return TilingSpriteRenderer;
    }(core.ObjectRenderer));

    exports.TilingSprite = TilingSprite;
    exports.TilingSpriteRenderer = TilingSpriteRenderer;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI, PIXI, PIXI.utils);
Object.assign(this.PIXI, _pixi_sprite_tiling);
//# sourceMappingURL=sprite-tiling.js.map
