/*!
 * @pixi/core - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/core is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_core = (function (exports, settings, constants, utils, extensions, runner, ticker, math) {
    'use strict';

    /**
     * The maximum support for using WebGL. If a device does not
     * support WebGL version, for instance WebGL 2, it will still
     * attempt to fallback support to WebGL 1. If you want to
     * explicitly remove feature support to target a more stable
     * baseline, prefer a lower environment.
     *
     * Due to {@link https://bugs.chromium.org/p/chromium/issues/detail?id=934823|bug in chromium}
     * we disable webgl2 by default for all non-apple mobile devices.
     * @static
     * @name PREFER_ENV
     * @memberof PIXI.settings
     * @type {number}
     * @default PIXI.ENV.WEBGL2
     */
    settings.settings.PREFER_ENV = utils.isMobile.any ? constants.ENV.WEBGL : constants.ENV.WEBGL2;
    /**
     * If set to `true`, *only* Textures and BaseTexture objects stored
     * in the caches ({@link PIXI.utils.TextureCache TextureCache} and
     * {@link PIXI.utils.BaseTextureCache BaseTextureCache}) can be
     * used when calling {@link PIXI.Texture.from Texture.from} or
     * {@link PIXI.BaseTexture.from BaseTexture.from}.
     * Otherwise, these `from` calls throw an exception. Using this property
     * can be useful if you want to enforce preloading all assets with
     * {@link PIXI.Loader Loader}.
     * @static
     * @name STRICT_TEXTURE_CACHE
     * @memberof PIXI.settings
     * @type {boolean}
     * @default false
     */
    settings.settings.STRICT_TEXTURE_CACHE = false;

    /**
     * Collection of installed resource types, class must extend {@link PIXI.Resource}.
     * @example
     * class CustomResource extends PIXI.Resource {
     *   // MUST have source, options constructor signature
     *   // for auto-detected resources to be created.
     *   constructor(source, options) {
     *     super();
     *   }
     *   upload(renderer, baseTexture, glTexture) {
     *     // upload with GL
     *     return true;
     *   }
     *   // used to auto-detect resource
     *   static test(source, extension) {
     *     return extension === 'xyz'|| source instanceof SomeClass;
     *   }
     * }
     * // Install the new resource type
     * PIXI.INSTALLED.push(CustomResource);
     * @memberof PIXI
     * @type {Array<PIXI.IResourcePlugin>}
     * @static
     * @readonly
     */
    var INSTALLED = [];
    /**
     * Create a resource element from a single source element. This
     * auto-detects which type of resource to create. All resources that
     * are auto-detectable must have a static `test` method and a constructor
     * with the arguments `(source, options?)`. Currently, the supported
     * resources for auto-detection include:
     *  - {@link PIXI.ImageResource}
     *  - {@link PIXI.CanvasResource}
     *  - {@link PIXI.VideoResource}
     *  - {@link PIXI.SVGResource}
     *  - {@link PIXI.BufferResource}
     * @static
     * @memberof PIXI
     * @function autoDetectResource
     * @param {string|*} source - Resource source, this can be the URL to the resource,
     *        a typed-array (for BufferResource), HTMLVideoElement, SVG data-uri
     *        or any other resource that can be auto-detected. If not resource is
     *        detected, it's assumed to be an ImageResource.
     * @param {object} [options] - Pass-through options to use for Resource
     * @param {number} [options.width] - Width of BufferResource or SVG rasterization
     * @param {number} [options.height] - Height of BufferResource or SVG rasterization
     * @param {boolean} [options.autoLoad=true] - Image, SVG and Video flag to start loading
     * @param {number} [options.scale=1] - SVG source scale. Overridden by width, height
     * @param {boolean} [options.createBitmap=PIXI.settings.CREATE_IMAGE_BITMAP] - Image option to create Bitmap object
     * @param {boolean} [options.crossorigin=true] - Image and Video option to set crossOrigin
     * @param {boolean} [options.autoPlay=true] - Video option to start playing video immediately
     * @param {number} [options.updateFPS=0] - Video option to update how many times a second the
     *        texture should be updated from the video. Leave at 0 to update at every render
     * @returns {PIXI.Resource} The created resource.
     */
    function autoDetectResource(source, options) {
        if (!source) {
            return null;
        }
        var extension = '';
        if (typeof source === 'string') {
            // search for file extension: period, 3-4 chars, then ?, # or EOL
            var result = (/\.(\w{3,4})(?:$|\?|#)/i).exec(source);
            if (result) {
                extension = result[1].toLowerCase();
            }
        }
        for (var i = INSTALLED.length - 1; i >= 0; --i) {
            var ResourcePlugin = INSTALLED[i];
            if (ResourcePlugin.test && ResourcePlugin.test(source, extension)) {
                return new ResourcePlugin(source, options);
            }
        }
        throw new Error('Unrecognized source type to auto-detect Resource');
    }

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
     * Base resource class for textures that manages validation and uploading, depending on its type.
     *
     * Uploading of a base texture to the GPU is required.
     * @memberof PIXI
     */
    var Resource = /** @class */ (function () {
        /**
         * @param width - Width of the resource
         * @param height - Height of the resource
         */
        function Resource(width, height) {
            if (width === void 0) { width = 0; }
            if (height === void 0) { height = 0; }
            this._width = width;
            this._height = height;
            this.destroyed = false;
            this.internal = false;
            this.onResize = new runner.Runner('setRealSize');
            this.onUpdate = new runner.Runner('update');
            this.onError = new runner.Runner('onError');
        }
        /**
         * Bind to a parent BaseTexture
         * @param baseTexture - Parent texture
         */
        Resource.prototype.bind = function (baseTexture) {
            this.onResize.add(baseTexture);
            this.onUpdate.add(baseTexture);
            this.onError.add(baseTexture);
            // Call a resize immediate if we already
            // have the width and height of the resource
            if (this._width || this._height) {
                this.onResize.emit(this._width, this._height);
            }
        };
        /**
         * Unbind to a parent BaseTexture
         * @param baseTexture - Parent texture
         */
        Resource.prototype.unbind = function (baseTexture) {
            this.onResize.remove(baseTexture);
            this.onUpdate.remove(baseTexture);
            this.onError.remove(baseTexture);
        };
        /**
         * Trigger a resize event
         * @param width - X dimension
         * @param height - Y dimension
         */
        Resource.prototype.resize = function (width, height) {
            if (width !== this._width || height !== this._height) {
                this._width = width;
                this._height = height;
                this.onResize.emit(width, height);
            }
        };
        Object.defineProperty(Resource.prototype, "valid", {
            /**
             * Has been validated
             * @readonly
             */
            get: function () {
                return !!this._width && !!this._height;
            },
            enumerable: false,
            configurable: true
        });
        /** Has been updated trigger event. */
        Resource.prototype.update = function () {
            if (!this.destroyed) {
                this.onUpdate.emit();
            }
        };
        /**
         * This can be overridden to start preloading a resource
         * or do any other prepare step.
         * @protected
         * @returns Handle the validate event
         */
        Resource.prototype.load = function () {
            return Promise.resolve(this);
        };
        Object.defineProperty(Resource.prototype, "width", {
            /**
             * The width of the resource.
             * @readonly
             */
            get: function () {
                return this._width;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Resource.prototype, "height", {
            /**
             * The height of the resource.
             * @readonly
             */
            get: function () {
                return this._height;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Set the style, optional to override
         * @param _renderer - yeah, renderer!
         * @param _baseTexture - the texture
         * @param _glTexture - texture instance for this webgl context
         * @returns - `true` is success
         */
        Resource.prototype.style = function (_renderer, _baseTexture, _glTexture) {
            return false;
        };
        /** Clean up anything, this happens when destroying is ready. */
        Resource.prototype.dispose = function () {
            // override
        };
        /**
         * Call when destroying resource, unbind any BaseTexture object
         * before calling this method, as reference counts are maintained
         * internally.
         */
        Resource.prototype.destroy = function () {
            if (!this.destroyed) {
                this.destroyed = true;
                this.dispose();
                this.onError.removeAll();
                this.onError = null;
                this.onResize.removeAll();
                this.onResize = null;
                this.onUpdate.removeAll();
                this.onUpdate = null;
            }
        };
        /**
         * Abstract, used to auto-detect resource type.
         * @param {*} _source - The source object
         * @param {string} _extension - The extension of source, if set
         */
        Resource.test = function (_source, _extension) {
            return false;
        };
        return Resource;
    }());

    /**
     * @interface SharedArrayBuffer
     */
    /**
     * Buffer resource with data of typed array.
     * @memberof PIXI
     */
    var BufferResource = /** @class */ (function (_super) {
        __extends(BufferResource, _super);
        /**
         * @param source - Source buffer
         * @param options - Options
         * @param {number} options.width - Width of the texture
         * @param {number} options.height - Height of the texture
         */
        function BufferResource(source, options) {
            var _this = this;
            var _a = options || {}, width = _a.width, height = _a.height;
            if (!width || !height) {
                throw new Error('BufferResource width or height invalid');
            }
            _this = _super.call(this, width, height) || this;
            _this.data = source;
            return _this;
        }
        /**
         * Upload the texture to the GPU.
         * @param renderer - Upload to the renderer
         * @param baseTexture - Reference to parent texture
         * @param glTexture - glTexture
         * @returns - true is success
         */
        BufferResource.prototype.upload = function (renderer, baseTexture, glTexture) {
            var gl = renderer.gl;
            gl.pixelStorei(gl.UNPACK_PREMULTIPLY_ALPHA_WEBGL, baseTexture.alphaMode === constants.ALPHA_MODES.UNPACK);
            var width = baseTexture.realWidth;
            var height = baseTexture.realHeight;
            if (glTexture.width === width && glTexture.height === height) {
                gl.texSubImage2D(baseTexture.target, 0, 0, 0, width, height, baseTexture.format, glTexture.type, this.data);
            }
            else {
                glTexture.width = width;
                glTexture.height = height;
                gl.texImage2D(baseTexture.target, 0, glTexture.internalFormat, width, height, 0, baseTexture.format, glTexture.type, this.data);
            }
            return true;
        };
        /** Destroy and don't use after this. */
        BufferResource.prototype.dispose = function () {
            this.data = null;
        };
        /**
         * Used to auto-detect the type of resource.
         * @param {*} source - The source object
         * @returns {boolean} `true` if <canvas>
         */
        BufferResource.test = function (source) {
            return source instanceof Float32Array
                || source instanceof Uint8Array
                || source instanceof Uint32Array;
        };
        return BufferResource;
    }(Resource));

    var defaultBufferOptions = {
        scaleMode: constants.SCALE_MODES.NEAREST,
        format: constants.FORMATS.RGBA,
        alphaMode: constants.ALPHA_MODES.NPM,
    };
    /**
     * A Texture stores the information that represents an image.
     * All textures have a base texture, which contains information about the source.
     * Therefore you can have many textures all using a single BaseTexture
     * @memberof PIXI
     * @typeParam R - The BaseTexture's Resource type.
     * @typeParam RO - The options for constructing resource.
     */
    var BaseTexture = /** @class */ (function (_super) {
        __extends(BaseTexture, _super);
        /**
         * @param {PIXI.Resource|string|HTMLImageElement|HTMLCanvasElement|HTMLVideoElement} [resource=null] -
         *        The current resource to use, for things that aren't Resource objects, will be converted
         *        into a Resource.
         * @param options - Collection of options
         * @param {PIXI.MIPMAP_MODES} [options.mipmap=PIXI.settings.MIPMAP_TEXTURES] - If mipmapping is enabled for texture
         * @param {number} [options.anisotropicLevel=PIXI.settings.ANISOTROPIC_LEVEL] - Anisotropic filtering level of texture
         * @param {PIXI.WRAP_MODES} [options.wrapMode=PIXI.settings.WRAP_MODE] - Wrap mode for textures
         * @param {PIXI.SCALE_MODES} [options.scaleMode=PIXI.settings.SCALE_MODE] - Default scale mode, linear, nearest
         * @param {PIXI.FORMATS} [options.format=PIXI.FORMATS.RGBA] - GL format type
         * @param {PIXI.TYPES} [options.type=PIXI.TYPES.UNSIGNED_BYTE] - GL data type
         * @param {PIXI.TARGETS} [options.target=PIXI.TARGETS.TEXTURE_2D] - GL texture target
         * @param {PIXI.ALPHA_MODES} [options.alphaMode=PIXI.ALPHA_MODES.UNPACK] - Pre multiply the image alpha
         * @param {number} [options.width=0] - Width of the texture
         * @param {number} [options.height=0] - Height of the texture
         * @param {number} [options.resolution=PIXI.settings.RESOLUTION] - Resolution of the base texture
         * @param {object} [options.resourceOptions] - Optional resource options,
         *        see {@link PIXI.autoDetectResource autoDetectResource}
         */
        function BaseTexture(resource, options) {
            if (resource === void 0) { resource = null; }
            if (options === void 0) { options = null; }
            var _this = _super.call(this) || this;
            options = options || {};
            var alphaMode = options.alphaMode, mipmap = options.mipmap, anisotropicLevel = options.anisotropicLevel, scaleMode = options.scaleMode, width = options.width, height = options.height, wrapMode = options.wrapMode, format = options.format, type = options.type, target = options.target, resolution = options.resolution, resourceOptions = options.resourceOptions;
            // Convert the resource to a Resource object
            if (resource && !(resource instanceof Resource)) {
                resource = autoDetectResource(resource, resourceOptions);
                resource.internal = true;
            }
            _this.resolution = resolution || settings.settings.RESOLUTION;
            _this.width = Math.round((width || 0) * _this.resolution) / _this.resolution;
            _this.height = Math.round((height || 0) * _this.resolution) / _this.resolution;
            _this._mipmap = mipmap !== undefined ? mipmap : settings.settings.MIPMAP_TEXTURES;
            _this.anisotropicLevel = anisotropicLevel !== undefined ? anisotropicLevel : settings.settings.ANISOTROPIC_LEVEL;
            _this._wrapMode = wrapMode || settings.settings.WRAP_MODE;
            _this._scaleMode = scaleMode !== undefined ? scaleMode : settings.settings.SCALE_MODE;
            _this.format = format || constants.FORMATS.RGBA;
            _this.type = type || constants.TYPES.UNSIGNED_BYTE;
            _this.target = target || constants.TARGETS.TEXTURE_2D;
            _this.alphaMode = alphaMode !== undefined ? alphaMode : constants.ALPHA_MODES.UNPACK;
            _this.uid = utils.uid();
            _this.touched = 0;
            _this.isPowerOfTwo = false;
            _this._refreshPOT();
            _this._glTextures = {};
            _this.dirtyId = 0;
            _this.dirtyStyleId = 0;
            _this.cacheId = null;
            _this.valid = width > 0 && height > 0;
            _this.textureCacheIds = [];
            _this.destroyed = false;
            _this.resource = null;
            _this._batchEnabled = 0;
            _this._batchLocation = 0;
            _this.parentTextureArray = null;
            /**
             * Fired when a not-immediately-available source finishes loading.
             * @protected
             * @event PIXI.BaseTexture#loaded
             * @param {PIXI.BaseTexture} baseTexture - Resource loaded.
             */
            /**
             * Fired when a not-immediately-available source fails to load.
             * @protected
             * @event PIXI.BaseTexture#error
             * @param {PIXI.BaseTexture} baseTexture - Resource errored.
             * @param {ErrorEvent} event - Load error event.
             */
            /**
             * Fired when BaseTexture is updated.
             * @protected
             * @event PIXI.BaseTexture#loaded
             * @param {PIXI.BaseTexture} baseTexture - Resource loaded.
             */
            /**
             * Fired when BaseTexture is updated.
             * @protected
             * @event PIXI.BaseTexture#update
             * @param {PIXI.BaseTexture} baseTexture - Instance of texture being updated.
             */
            /**
             * Fired when BaseTexture is destroyed.
             * @protected
             * @event PIXI.BaseTexture#dispose
             * @param {PIXI.BaseTexture} baseTexture - Instance of texture being destroyed.
             */
            // Set the resource
            _this.setResource(resource);
            return _this;
        }
        Object.defineProperty(BaseTexture.prototype, "realWidth", {
            /**
             * Pixel width of the source of this texture
             * @readonly
             */
            get: function () {
                return Math.round(this.width * this.resolution);
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BaseTexture.prototype, "realHeight", {
            /**
             * Pixel height of the source of this texture
             * @readonly
             */
            get: function () {
                return Math.round(this.height * this.resolution);
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BaseTexture.prototype, "mipmap", {
            /**
             * Mipmap mode of the texture, affects downscaled images
             * @default PIXI.settings.MIPMAP_TEXTURES
             */
            get: function () {
                return this._mipmap;
            },
            set: function (value) {
                if (this._mipmap !== value) {
                    this._mipmap = value;
                    this.dirtyStyleId++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BaseTexture.prototype, "scaleMode", {
            /**
             * The scale mode to apply when scaling this texture
             * @default PIXI.settings.SCALE_MODE
             */
            get: function () {
                return this._scaleMode;
            },
            set: function (value) {
                if (this._scaleMode !== value) {
                    this._scaleMode = value;
                    this.dirtyStyleId++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BaseTexture.prototype, "wrapMode", {
            /**
             * How the texture wraps
             * @default PIXI.settings.WRAP_MODE
             */
            get: function () {
                return this._wrapMode;
            },
            set: function (value) {
                if (this._wrapMode !== value) {
                    this._wrapMode = value;
                    this.dirtyStyleId++;
                }
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Changes style options of BaseTexture
         * @param scaleMode - Pixi scalemode
         * @param mipmap - enable mipmaps
         * @returns - this
         */
        BaseTexture.prototype.setStyle = function (scaleMode, mipmap) {
            var dirty;
            if (scaleMode !== undefined && scaleMode !== this.scaleMode) {
                this.scaleMode = scaleMode;
                dirty = true;
            }
            if (mipmap !== undefined && mipmap !== this.mipmap) {
                this.mipmap = mipmap;
                dirty = true;
            }
            if (dirty) {
                this.dirtyStyleId++;
            }
            return this;
        };
        /**
         * Changes w/h/resolution. Texture becomes valid if width and height are greater than zero.
         * @param desiredWidth - Desired visual width
         * @param desiredHeight - Desired visual height
         * @param resolution - Optionally set resolution
         * @returns - this
         */
        BaseTexture.prototype.setSize = function (desiredWidth, desiredHeight, resolution) {
            resolution = resolution || this.resolution;
            return this.setRealSize(desiredWidth * resolution, desiredHeight * resolution, resolution);
        };
        /**
         * Sets real size of baseTexture, preserves current resolution.
         * @param realWidth - Full rendered width
         * @param realHeight - Full rendered height
         * @param resolution - Optionally set resolution
         * @returns - this
         */
        BaseTexture.prototype.setRealSize = function (realWidth, realHeight, resolution) {
            this.resolution = resolution || this.resolution;
            this.width = Math.round(realWidth) / this.resolution;
            this.height = Math.round(realHeight) / this.resolution;
            this._refreshPOT();
            this.update();
            return this;
        };
        /**
         * Refresh check for isPowerOfTwo texture based on size
         * @private
         */
        BaseTexture.prototype._refreshPOT = function () {
            this.isPowerOfTwo = utils.isPow2(this.realWidth) && utils.isPow2(this.realHeight);
        };
        /**
         * Changes resolution
         * @param resolution - res
         * @returns - this
         */
        BaseTexture.prototype.setResolution = function (resolution) {
            var oldResolution = this.resolution;
            if (oldResolution === resolution) {
                return this;
            }
            this.resolution = resolution;
            if (this.valid) {
                this.width = Math.round(this.width * oldResolution) / resolution;
                this.height = Math.round(this.height * oldResolution) / resolution;
                this.emit('update', this);
            }
            this._refreshPOT();
            return this;
        };
        /**
         * Sets the resource if it wasn't set. Throws error if resource already present
         * @param resource - that is managing this BaseTexture
         * @returns - this
         */
        BaseTexture.prototype.setResource = function (resource) {
            if (this.resource === resource) {
                return this;
            }
            if (this.resource) {
                throw new Error('Resource can be set only once');
            }
            resource.bind(this);
            this.resource = resource;
            return this;
        };
        /** Invalidates the object. Texture becomes valid if width and height are greater than zero. */
        BaseTexture.prototype.update = function () {
            if (!this.valid) {
                if (this.width > 0 && this.height > 0) {
                    this.valid = true;
                    this.emit('loaded', this);
                    this.emit('update', this);
                }
            }
            else {
                this.dirtyId++;
                this.dirtyStyleId++;
                this.emit('update', this);
            }
        };
        /**
         * Handle errors with resources.
         * @private
         * @param event - Error event emitted.
         */
        BaseTexture.prototype.onError = function (event) {
            this.emit('error', this, event);
        };
        /**
         * Destroys this base texture.
         * The method stops if resource doesn't want this texture to be destroyed.
         * Removes texture from all caches.
         */
        BaseTexture.prototype.destroy = function () {
            // remove and destroy the resource
            if (this.resource) {
                this.resource.unbind(this);
                // only destroy resourced created internally
                if (this.resource.internal) {
                    this.resource.destroy();
                }
                this.resource = null;
            }
            if (this.cacheId) {
                delete utils.BaseTextureCache[this.cacheId];
                delete utils.TextureCache[this.cacheId];
                this.cacheId = null;
            }
            // finally let the WebGL renderer know..
            this.dispose();
            BaseTexture.removeFromCache(this);
            this.textureCacheIds = null;
            this.destroyed = true;
        };
        /**
         * Frees the texture from WebGL memory without destroying this texture object.
         * This means you can still use the texture later which will upload it to GPU
         * memory again.
         * @fires PIXI.BaseTexture#dispose
         */
        BaseTexture.prototype.dispose = function () {
            this.emit('dispose', this);
        };
        /** Utility function for BaseTexture|Texture cast. */
        BaseTexture.prototype.castToBaseTexture = function () {
            return this;
        };
        /**
         * Helper function that creates a base texture based on the source you provide.
         * The source can be - image url, image element, canvas element. If the
         * source is an image url or an image element and not in the base texture
         * cache, it will be created and loaded.
         * @static
         * @param {string|string[]|HTMLImageElement|HTMLCanvasElement|SVGElement|HTMLVideoElement} source - The
         *        source to create base texture from.
         * @param options - See {@link PIXI.BaseTexture}'s constructor for options.
         * @param {string} [options.pixiIdPrefix=pixiid] - If a source has no id, this is the prefix of the generated id
         * @param {boolean} [strict] - Enforce strict-mode, see {@link PIXI.settings.STRICT_TEXTURE_CACHE}.
         * @returns {PIXI.BaseTexture} The new base texture.
         */
        BaseTexture.from = function (source, options, strict) {
            if (strict === void 0) { strict = settings.settings.STRICT_TEXTURE_CACHE; }
            var isFrame = typeof source === 'string';
            var cacheId = null;
            if (isFrame) {
                cacheId = source;
            }
            else {
                if (!source._pixiId) {
                    var prefix = (options && options.pixiIdPrefix) || 'pixiid';
                    source._pixiId = prefix + "_" + utils.uid();
                }
                cacheId = source._pixiId;
            }
            var baseTexture = utils.BaseTextureCache[cacheId];
            // Strict-mode rejects invalid cacheIds
            if (isFrame && strict && !baseTexture) {
                throw new Error("The cacheId \"" + cacheId + "\" does not exist in BaseTextureCache.");
            }
            if (!baseTexture) {
                baseTexture = new BaseTexture(source, options);
                baseTexture.cacheId = cacheId;
                BaseTexture.addToCache(baseTexture, cacheId);
            }
            return baseTexture;
        };
        /**
         * Create a new BaseTexture with a BufferResource from a Float32Array.
         * RGBA values are floats from 0 to 1.
         * @param {Float32Array|Uint8Array} buffer - The optional array to use, if no data
         *        is provided, a new Float32Array is created.
         * @param width - Width of the resource
         * @param height - Height of the resource
         * @param options - See {@link PIXI.BaseTexture}'s constructor for options.
         *        Default properties are different from the constructor's defaults.
         * @param {PIXI.FORMATS} [options.format=PIXI.FORMATS.RGBA] - GL format type
         * @param {PIXI.ALPHA_MODES} [options.alphaMode=PIXI.ALPHA_MODES.NPM] - Image alpha, not premultiplied by default
         * @param {PIXI.SCALE_MODES} [options.scaleMode=PIXI.SCALE_MODES.NEAREST] - Scale mode, pixelating by default
         * @returns - The resulting new BaseTexture
         */
        BaseTexture.fromBuffer = function (buffer, width, height, options) {
            buffer = buffer || new Float32Array(width * height * 4);
            var resource = new BufferResource(buffer, { width: width, height: height });
            var type = buffer instanceof Float32Array ? constants.TYPES.FLOAT : constants.TYPES.UNSIGNED_BYTE;
            return new BaseTexture(resource, Object.assign(defaultBufferOptions, options || { width: width, height: height, type: type }));
        };
        /**
         * Adds a BaseTexture to the global BaseTextureCache. This cache is shared across the whole PIXI object.
         * @param {PIXI.BaseTexture} baseTexture - The BaseTexture to add to the cache.
         * @param {string} id - The id that the BaseTexture will be stored against.
         */
        BaseTexture.addToCache = function (baseTexture, id) {
            if (id) {
                if (baseTexture.textureCacheIds.indexOf(id) === -1) {
                    baseTexture.textureCacheIds.push(id);
                }
                if (utils.BaseTextureCache[id]) {
                    // eslint-disable-next-line no-console
                    console.warn("BaseTexture added to the cache with an id [" + id + "] that already had an entry");
                }
                utils.BaseTextureCache[id] = baseTexture;
            }
        };
        /**
         * Remove a BaseTexture from the global BaseTextureCache.
         * @param {string|PIXI.BaseTexture} baseTexture - id of a BaseTexture to be removed, or a BaseTexture instance itself.
         * @returns {PIXI.BaseTexture|null} The BaseTexture that was removed.
         */
        BaseTexture.removeFromCache = function (baseTexture) {
            if (typeof baseTexture === 'string') {
                var baseTextureFromCache = utils.BaseTextureCache[baseTexture];
                if (baseTextureFromCache) {
                    var index = baseTextureFromCache.textureCacheIds.indexOf(baseTexture);
                    if (index > -1) {
                        baseTextureFromCache.textureCacheIds.splice(index, 1);
                    }
                    delete utils.BaseTextureCache[baseTexture];
                    return baseTextureFromCache;
                }
            }
            else if (baseTexture && baseTexture.textureCacheIds) {
                for (var i = 0; i < baseTexture.textureCacheIds.length; ++i) {
                    delete utils.BaseTextureCache[baseTexture.textureCacheIds[i]];
                }
                baseTexture.textureCacheIds.length = 0;
                return baseTexture;
            }
            return null;
        };
        /** Global number of the texture batch, used by multi-texture renderers. */
        BaseTexture._globalBatch = 0;
        return BaseTexture;
    }(utils.EventEmitter));

    /**
     * Resource that can manage several resource (items) inside.
     * All resources need to have the same pixel size.
     * Parent class for CubeResource and ArrayResource
     * @memberof PIXI
     */
    var AbstractMultiResource = /** @class */ (function (_super) {
        __extends(AbstractMultiResource, _super);
        /**
         * @param length
         * @param options - Options to for Resource constructor
         * @param {number} [options.width] - Width of the resource
         * @param {number} [options.height] - Height of the resource
         */
        function AbstractMultiResource(length, options) {
            var _this = this;
            var _a = options || {}, width = _a.width, height = _a.height;
            _this = _super.call(this, width, height) || this;
            _this.items = [];
            _this.itemDirtyIds = [];
            for (var i = 0; i < length; i++) {
                var partTexture = new BaseTexture();
                _this.items.push(partTexture);
                // -2 - first run of texture array upload
                // -1 - texture item was allocated
                // >=0 - texture item uploaded , in sync with items[i].dirtyId
                _this.itemDirtyIds.push(-2);
            }
            _this.length = length;
            _this._load = null;
            _this.baseTexture = null;
            return _this;
        }
        /**
         * Used from ArrayResource and CubeResource constructors.
         * @param resources - Can be resources, image elements, canvas, etc. ,
         *  length should be same as constructor length
         * @param options - Detect options for resources
         */
        AbstractMultiResource.prototype.initFromArray = function (resources, options) {
            for (var i = 0; i < this.length; i++) {
                if (!resources[i]) {
                    continue;
                }
                if (resources[i].castToBaseTexture) {
                    this.addBaseTextureAt(resources[i].castToBaseTexture(), i);
                }
                else if (resources[i] instanceof Resource) {
                    this.addResourceAt(resources[i], i);
                }
                else {
                    this.addResourceAt(autoDetectResource(resources[i], options), i);
                }
            }
        };
        /** Destroy this BaseImageResource. */
        AbstractMultiResource.prototype.dispose = function () {
            for (var i = 0, len = this.length; i < len; i++) {
                this.items[i].destroy();
            }
            this.items = null;
            this.itemDirtyIds = null;
            this._load = null;
        };
        /**
         * Set a resource by ID
         * @param resource
         * @param index - Zero-based index of resource to set
         * @returns - Instance for chaining
         */
        AbstractMultiResource.prototype.addResourceAt = function (resource, index) {
            if (!this.items[index]) {
                throw new Error("Index " + index + " is out of bounds");
            }
            // Inherit the first resource dimensions
            if (resource.valid && !this.valid) {
                this.resize(resource.width, resource.height);
            }
            this.items[index].setResource(resource);
            return this;
        };
        /**
         * Set the parent base texture.
         * @param baseTexture
         */
        AbstractMultiResource.prototype.bind = function (baseTexture) {
            if (this.baseTexture !== null) {
                throw new Error('Only one base texture per TextureArray is allowed');
            }
            _super.prototype.bind.call(this, baseTexture);
            for (var i = 0; i < this.length; i++) {
                this.items[i].parentTextureArray = baseTexture;
                this.items[i].on('update', baseTexture.update, baseTexture);
            }
        };
        /**
         * Unset the parent base texture.
         * @param baseTexture
         */
        AbstractMultiResource.prototype.unbind = function (baseTexture) {
            _super.prototype.unbind.call(this, baseTexture);
            for (var i = 0; i < this.length; i++) {
                this.items[i].parentTextureArray = null;
                this.items[i].off('update', baseTexture.update, baseTexture);
            }
        };
        /**
         * Load all the resources simultaneously
         * @returns - When load is resolved
         */
        AbstractMultiResource.prototype.load = function () {
            var _this = this;
            if (this._load) {
                return this._load;
            }
            var resources = this.items.map(function (item) { return item.resource; }).filter(function (item) { return item; });
            // TODO: also implement load part-by-part strategy
            var promises = resources.map(function (item) { return item.load(); });
            this._load = Promise.all(promises)
                .then(function () {
                var _a = _this.items[0], realWidth = _a.realWidth, realHeight = _a.realHeight;
                _this.resize(realWidth, realHeight);
                return Promise.resolve(_this);
            });
            return this._load;
        };
        return AbstractMultiResource;
    }(Resource));

    /**
     * A resource that contains a number of sources.
     * @memberof PIXI
     */
    var ArrayResource = /** @class */ (function (_super) {
        __extends(ArrayResource, _super);
        /**
         * @param source - Number of items in array or the collection
         *        of image URLs to use. Can also be resources, image elements, canvas, etc.
         * @param options - Options to apply to {@link PIXI.autoDetectResource}
         * @param {number} [options.width] - Width of the resource
         * @param {number} [options.height] - Height of the resource
         */
        function ArrayResource(source, options) {
            var _this = this;
            var _a = options || {}, width = _a.width, height = _a.height;
            var urls;
            var length;
            if (Array.isArray(source)) {
                urls = source;
                length = source.length;
            }
            else {
                length = source;
            }
            _this = _super.call(this, length, { width: width, height: height }) || this;
            if (urls) {
                _this.initFromArray(urls, options);
            }
            return _this;
        }
        /**
         * Set a baseTexture by ID,
         * ArrayResource just takes resource from it, nothing more
         * @param baseTexture
         * @param index - Zero-based index of resource to set
         * @returns - Instance for chaining
         */
        ArrayResource.prototype.addBaseTextureAt = function (baseTexture, index) {
            if (baseTexture.resource) {
                this.addResourceAt(baseTexture.resource, index);
            }
            else {
                throw new Error('ArrayResource does not support RenderTexture');
            }
            return this;
        };
        /**
         * Add binding
         * @param baseTexture
         */
        ArrayResource.prototype.bind = function (baseTexture) {
            _super.prototype.bind.call(this, baseTexture);
            baseTexture.target = constants.TARGETS.TEXTURE_2D_ARRAY;
        };
        /**
         * Upload the resources to the GPU.
         * @param renderer
         * @param texture
         * @param glTexture
         * @returns - whether texture was uploaded
         */
        ArrayResource.prototype.upload = function (renderer, texture, glTexture) {
            var _a = this, length = _a.length, itemDirtyIds = _a.itemDirtyIds, items = _a.items;
            var gl = renderer.gl;
            if (glTexture.dirtyId < 0) {
                gl.texImage3D(gl.TEXTURE_2D_ARRAY, 0, glTexture.internalFormat, this._width, this._height, length, 0, texture.format, glTexture.type, null);
            }
            for (var i = 0; i < length; i++) {
                var item = items[i];
                if (itemDirtyIds[i] < item.dirtyId) {
                    itemDirtyIds[i] = item.dirtyId;
                    if (item.valid) {
                        gl.texSubImage3D(gl.TEXTURE_2D_ARRAY, 0, 0, // xoffset
                        0, // yoffset
                        i, // zoffset
                        item.resource.width, item.resource.height, 1, texture.format, glTexture.type, item.resource.source);
                    }
                }
            }
            return true;
        };
        return ArrayResource;
    }(AbstractMultiResource));

    /**
     * Base for all the image/canvas resources.
     * @memberof PIXI
     */
    var BaseImageResource = /** @class */ (function (_super) {
        __extends(BaseImageResource, _super);
        /**
         * @param {HTMLImageElement|HTMLCanvasElement|HTMLVideoElement|SVGElement} source
         */
        function BaseImageResource(source) {
            var _this = this;
            var sourceAny = source;
            var width = sourceAny.naturalWidth || sourceAny.videoWidth || sourceAny.width;
            var height = sourceAny.naturalHeight || sourceAny.videoHeight || sourceAny.height;
            _this = _super.call(this, width, height) || this;
            _this.source = source;
            _this.noSubImage = false;
            return _this;
        }
        /**
         * Set cross origin based detecting the url and the crossorigin
         * @param element - Element to apply crossOrigin
         * @param url - URL to check
         * @param crossorigin - Cross origin value to use
         */
        BaseImageResource.crossOrigin = function (element, url, crossorigin) {
            if (crossorigin === undefined && url.indexOf('data:') !== 0) {
                element.crossOrigin = utils.determineCrossOrigin(url);
            }
            else if (crossorigin !== false) {
                element.crossOrigin = typeof crossorigin === 'string' ? crossorigin : 'anonymous';
            }
        };
        /**
         * Upload the texture to the GPU.
         * @param renderer - Upload to the renderer
         * @param baseTexture - Reference to parent texture
         * @param glTexture
         * @param {HTMLImageElement|HTMLCanvasElement|HTMLVideoElement|SVGElement} [source] - (optional)
         * @returns - true is success
         */
        BaseImageResource.prototype.upload = function (renderer, baseTexture, glTexture, source) {
            var gl = renderer.gl;
            var width = baseTexture.realWidth;
            var height = baseTexture.realHeight;
            source = source || this.source;
            if (source instanceof HTMLImageElement) {
                if (!source.complete || source.naturalWidth === 0) {
                    return false;
                }
            }
            else if (source instanceof HTMLVideoElement) {
                if (source.readyState <= 1) {
                    return false;
                }
            }
            gl.pixelStorei(gl.UNPACK_PREMULTIPLY_ALPHA_WEBGL, baseTexture.alphaMode === constants.ALPHA_MODES.UNPACK);
            if (!this.noSubImage
                && baseTexture.target === gl.TEXTURE_2D
                && glTexture.width === width
                && glTexture.height === height) {
                gl.texSubImage2D(gl.TEXTURE_2D, 0, 0, 0, baseTexture.format, glTexture.type, source);
            }
            else {
                glTexture.width = width;
                glTexture.height = height;
                gl.texImage2D(baseTexture.target, 0, glTexture.internalFormat, baseTexture.format, glTexture.type, source);
            }
            return true;
        };
        /**
         * Checks if source width/height was changed, resize can cause extra baseTexture update.
         * Triggers one update in any case.
         */
        BaseImageResource.prototype.update = function () {
            if (this.destroyed) {
                return;
            }
            var source = this.source;
            var width = source.naturalWidth || source.videoWidth || source.width;
            var height = source.naturalHeight || source.videoHeight || source.height;
            this.resize(width, height);
            _super.prototype.update.call(this);
        };
        /** Destroy this {@link BaseImageResource} */
        BaseImageResource.prototype.dispose = function () {
            this.source = null;
        };
        return BaseImageResource;
    }(Resource));

    /**
     * @interface OffscreenCanvas
     */
    /**
     * Resource type for HTMLCanvasElement.
     * @memberof PIXI
     */
    var CanvasResource = /** @class */ (function (_super) {
        __extends(CanvasResource, _super);
        /**
         * @param source - Canvas element to use
         */
        // eslint-disable-next-line @typescript-eslint/no-useless-constructor
        function CanvasResource(source) {
            return _super.call(this, source) || this;
        }
        /**
         * Used to auto-detect the type of resource.
         * @param {*} source - The source object
         * @returns {boolean} `true` if source is HTMLCanvasElement or OffscreenCanvas
         */
        CanvasResource.test = function (source) {
            var OffscreenCanvas = globalThis.OffscreenCanvas;
            // Check for browsers that don't yet support OffscreenCanvas
            if (OffscreenCanvas && source instanceof OffscreenCanvas) {
                return true;
            }
            return globalThis.HTMLCanvasElement && source instanceof HTMLCanvasElement;
        };
        return CanvasResource;
    }(BaseImageResource));

    /**
     * Resource for a CubeTexture which contains six resources.
     * @memberof PIXI
     */
    var CubeResource = /** @class */ (function (_super) {
        __extends(CubeResource, _super);
        /**
         * @param {Array<string|PIXI.Resource>} [source] - Collection of URLs or resources
         *        to use as the sides of the cube.
         * @param options - ImageResource options
         * @param {number} [options.width] - Width of resource
         * @param {number} [options.height] - Height of resource
         * @param {number} [options.autoLoad=true] - Whether to auto-load resources
         * @param {number} [options.linkBaseTexture=true] - In case BaseTextures are supplied,
         *   whether to copy them or use
         */
        function CubeResource(source, options) {
            var _this = this;
            var _a = options || {}, width = _a.width, height = _a.height, autoLoad = _a.autoLoad, linkBaseTexture = _a.linkBaseTexture;
            if (source && source.length !== CubeResource.SIDES) {
                throw new Error("Invalid length. Got " + source.length + ", expected 6");
            }
            _this = _super.call(this, 6, { width: width, height: height }) || this;
            for (var i = 0; i < CubeResource.SIDES; i++) {
                _this.items[i].target = constants.TARGETS.TEXTURE_CUBE_MAP_POSITIVE_X + i;
            }
            _this.linkBaseTexture = linkBaseTexture !== false;
            if (source) {
                _this.initFromArray(source, options);
            }
            if (autoLoad !== false) {
                _this.load();
            }
            return _this;
        }
        /**
         * Add binding.
         * @param baseTexture - parent base texture
         */
        CubeResource.prototype.bind = function (baseTexture) {
            _super.prototype.bind.call(this, baseTexture);
            baseTexture.target = constants.TARGETS.TEXTURE_CUBE_MAP;
        };
        CubeResource.prototype.addBaseTextureAt = function (baseTexture, index, linkBaseTexture) {
            if (linkBaseTexture === undefined) {
                linkBaseTexture = this.linkBaseTexture;
            }
            if (!this.items[index]) {
                throw new Error("Index " + index + " is out of bounds");
            }
            if (!this.linkBaseTexture
                || baseTexture.parentTextureArray
                || Object.keys(baseTexture._glTextures).length > 0) {
                // copy mode
                if (baseTexture.resource) {
                    this.addResourceAt(baseTexture.resource, index);
                }
                else {
                    throw new Error("CubeResource does not support copying of renderTexture.");
                }
            }
            else {
                // link mode, the difficult one!
                baseTexture.target = constants.TARGETS.TEXTURE_CUBE_MAP_POSITIVE_X + index;
                baseTexture.parentTextureArray = this.baseTexture;
                this.items[index] = baseTexture;
            }
            if (baseTexture.valid && !this.valid) {
                this.resize(baseTexture.realWidth, baseTexture.realHeight);
            }
            this.items[index] = baseTexture;
            return this;
        };
        /**
         * Upload the resource
         * @param renderer
         * @param _baseTexture
         * @param glTexture
         * @returns {boolean} true is success
         */
        CubeResource.prototype.upload = function (renderer, _baseTexture, glTexture) {
            var dirty = this.itemDirtyIds;
            for (var i = 0; i < CubeResource.SIDES; i++) {
                var side = this.items[i];
                if (dirty[i] < side.dirtyId || glTexture.dirtyId < _baseTexture.dirtyId) {
                    if (side.valid && side.resource) {
                        side.resource.upload(renderer, side, glTexture);
                        dirty[i] = side.dirtyId;
                    }
                    else if (dirty[i] < -1) {
                        // either item is not valid yet, either its a renderTexture
                        // allocate the memory
                        renderer.gl.texImage2D(side.target, 0, glTexture.internalFormat, _baseTexture.realWidth, _baseTexture.realHeight, 0, _baseTexture.format, glTexture.type, null);
                        dirty[i] = -1;
                    }
                }
            }
            return true;
        };
        /**
         * Used to auto-detect the type of resource.
         * @param {*} source - The source object
         * @returns {boolean} `true` if source is an array of 6 elements
         */
        CubeResource.test = function (source) {
            return Array.isArray(source) && source.length === CubeResource.SIDES;
        };
        /** Number of texture sides to store for CubeResources. */
        CubeResource.SIDES = 6;
        return CubeResource;
    }(AbstractMultiResource));

    /**
     * Resource type for HTMLImageElement.
     * @memberof PIXI
     */
    var ImageResource = /** @class */ (function (_super) {
        __extends(ImageResource, _super);
        /**
         * @param source - image source or URL
         * @param options
         * @param {boolean} [options.autoLoad=true] - start loading process
         * @param {boolean} [options.createBitmap=PIXI.settings.CREATE_IMAGE_BITMAP] - whether its required to create
         *        a bitmap before upload
         * @param {boolean} [options.crossorigin=true] - Load image using cross origin
         * @param {PIXI.ALPHA_MODES} [options.alphaMode=PIXI.ALPHA_MODES.UNPACK] - Premultiply image alpha in bitmap
         */
        function ImageResource(source, options) {
            var _this = this;
            options = options || {};
            if (!(source instanceof HTMLImageElement)) {
                var imageElement = new Image();
                BaseImageResource.crossOrigin(imageElement, source, options.crossorigin);
                imageElement.src = source;
                source = imageElement;
            }
            _this = _super.call(this, source) || this;
            // FireFox 68, and possibly other versions, seems like setting the HTMLImageElement#width and #height
            // to non-zero values before its loading completes if images are in a cache.
            // Because of this, need to set the `_width` and the `_height` to zero to avoid uploading incomplete images.
            // Please refer to the issue #5968 (https://github.com/pixijs/pixi.js/issues/5968).
            if (!source.complete && !!_this._width && !!_this._height) {
                _this._width = 0;
                _this._height = 0;
            }
            _this.url = source.src;
            _this._process = null;
            _this.preserveBitmap = false;
            _this.createBitmap = (options.createBitmap !== undefined
                ? options.createBitmap : settings.settings.CREATE_IMAGE_BITMAP) && !!globalThis.createImageBitmap;
            _this.alphaMode = typeof options.alphaMode === 'number' ? options.alphaMode : null;
            _this.bitmap = null;
            _this._load = null;
            if (options.autoLoad !== false) {
                _this.load();
            }
            return _this;
        }
        /**
         * Returns a promise when image will be loaded and processed.
         * @param createBitmap - whether process image into bitmap
         */
        ImageResource.prototype.load = function (createBitmap) {
            var _this = this;
            if (this._load) {
                return this._load;
            }
            if (createBitmap !== undefined) {
                this.createBitmap = createBitmap;
            }
            this._load = new Promise(function (resolve, reject) {
                var source = _this.source;
                _this.url = source.src;
                var completed = function () {
                    if (_this.destroyed) {
                        return;
                    }
                    source.onload = null;
                    source.onerror = null;
                    _this.resize(source.width, source.height);
                    _this._load = null;
                    if (_this.createBitmap) {
                        resolve(_this.process());
                    }
                    else {
                        resolve(_this);
                    }
                };
                if (source.complete && source.src) {
                    completed();
                }
                else {
                    source.onload = completed;
                    source.onerror = function (event) {
                        // Avoids Promise freezing when resource broken
                        reject(event);
                        _this.onError.emit(event);
                    };
                }
            });
            return this._load;
        };
        /**
         * Called when we need to convert image into BitmapImage.
         * Can be called multiple times, real promise is cached inside.
         * @returns - Cached promise to fill that bitmap
         */
        ImageResource.prototype.process = function () {
            var _this = this;
            var source = this.source;
            if (this._process !== null) {
                return this._process;
            }
            if (this.bitmap !== null || !globalThis.createImageBitmap) {
                return Promise.resolve(this);
            }
            var createImageBitmap = globalThis.createImageBitmap;
            var cors = !source.crossOrigin || source.crossOrigin === 'anonymous';
            this._process = fetch(source.src, {
                mode: cors ? 'cors' : 'no-cors'
            })
                .then(function (r) { return r.blob(); })
                .then(function (blob) { return createImageBitmap(blob, 0, 0, source.width, source.height, {
                premultiplyAlpha: _this.alphaMode === constants.ALPHA_MODES.UNPACK ? 'premultiply' : 'none',
            }); })
                .then(function (bitmap) {
                if (_this.destroyed) {
                    return Promise.reject();
                }
                _this.bitmap = bitmap;
                _this.update();
                _this._process = null;
                return Promise.resolve(_this);
            });
            return this._process;
        };
        /**
         * Upload the image resource to GPU.
         * @param renderer - Renderer to upload to
         * @param baseTexture - BaseTexture for this resource
         * @param glTexture - GLTexture to use
         * @returns {boolean} true is success
         */
        ImageResource.prototype.upload = function (renderer, baseTexture, glTexture) {
            if (typeof this.alphaMode === 'number') {
                // bitmap stores unpack premultiply flag, we dont have to notify texImage2D about it
                baseTexture.alphaMode = this.alphaMode;
            }
            if (!this.createBitmap) {
                return _super.prototype.upload.call(this, renderer, baseTexture, glTexture);
            }
            if (!this.bitmap) {
                // yeah, ignore the output
                this.process();
                if (!this.bitmap) {
                    return false;
                }
            }
            _super.prototype.upload.call(this, renderer, baseTexture, glTexture, this.bitmap);
            if (!this.preserveBitmap) {
                // checks if there are other renderers that possibly need this bitmap
                var flag = true;
                var glTextures = baseTexture._glTextures;
                for (var key in glTextures) {
                    var otherTex = glTextures[key];
                    if (otherTex !== glTexture && otherTex.dirtyId !== baseTexture.dirtyId) {
                        flag = false;
                        break;
                    }
                }
                if (flag) {
                    if (this.bitmap.close) {
                        this.bitmap.close();
                    }
                    this.bitmap = null;
                }
            }
            return true;
        };
        /** Destroys this resource. */
        ImageResource.prototype.dispose = function () {
            this.source.onload = null;
            this.source.onerror = null;
            _super.prototype.dispose.call(this);
            if (this.bitmap) {
                this.bitmap.close();
                this.bitmap = null;
            }
            this._process = null;
            this._load = null;
        };
        /**
         * Used to auto-detect the type of resource.
         * @param {*} source - The source object
         * @returns {boolean} `true` if source is string or HTMLImageElement
         */
        ImageResource.test = function (source) {
            return typeof source === 'string' || source instanceof HTMLImageElement;
        };
        return ImageResource;
    }(BaseImageResource));

    /**
     * Resource type for SVG elements and graphics.
     * @memberof PIXI
     */
    var SVGResource = /** @class */ (function (_super) {
        __extends(SVGResource, _super);
        /**
         * @param sourceBase64 - Base64 encoded SVG element or URL for SVG file.
         * @param {object} [options] - Options to use
         * @param {number} [options.scale=1] - Scale to apply to SVG. Overridden by...
         * @param {number} [options.width] - Rasterize SVG this wide. Aspect ratio preserved if height not specified.
         * @param {number} [options.height] - Rasterize SVG this high. Aspect ratio preserved if width not specified.
         * @param {boolean} [options.autoLoad=true] - Start loading right away.
         */
        function SVGResource(sourceBase64, options) {
            var _this = this;
            options = options || {};
            _this = _super.call(this, settings.settings.ADAPTER.createCanvas()) || this;
            _this._width = 0;
            _this._height = 0;
            _this.svg = sourceBase64;
            _this.scale = options.scale || 1;
            _this._overrideWidth = options.width;
            _this._overrideHeight = options.height;
            _this._resolve = null;
            _this._crossorigin = options.crossorigin;
            _this._load = null;
            if (options.autoLoad !== false) {
                _this.load();
            }
            return _this;
        }
        SVGResource.prototype.load = function () {
            var _this = this;
            if (this._load) {
                return this._load;
            }
            this._load = new Promise(function (resolve) {
                // Save this until after load is finished
                _this._resolve = function () {
                    _this.resize(_this.source.width, _this.source.height);
                    resolve(_this);
                };
                // Convert SVG inline string to data-uri
                if (SVGResource.SVG_XML.test(_this.svg.trim())) {
                    if (!btoa) {
                        throw new Error('Your browser doesn\'t support base64 conversions.');
                    }
                    _this.svg = "data:image/svg+xml;base64," + btoa(unescape(encodeURIComponent(_this.svg)));
                }
                _this._loadSvg();
            });
            return this._load;
        };
        /** Loads an SVG image from `imageUrl` or `data URL`. */
        SVGResource.prototype._loadSvg = function () {
            var _this = this;
            var tempImage = new Image();
            BaseImageResource.crossOrigin(tempImage, this.svg, this._crossorigin);
            tempImage.src = this.svg;
            tempImage.onerror = function (event) {
                if (!_this._resolve) {
                    return;
                }
                tempImage.onerror = null;
                _this.onError.emit(event);
            };
            tempImage.onload = function () {
                if (!_this._resolve) {
                    return;
                }
                var svgWidth = tempImage.width;
                var svgHeight = tempImage.height;
                if (!svgWidth || !svgHeight) {
                    throw new Error('The SVG image must have width and height defined (in pixels), canvas API needs them.');
                }
                // Set render size
                var width = svgWidth * _this.scale;
                var height = svgHeight * _this.scale;
                if (_this._overrideWidth || _this._overrideHeight) {
                    width = _this._overrideWidth || _this._overrideHeight / svgHeight * svgWidth;
                    height = _this._overrideHeight || _this._overrideWidth / svgWidth * svgHeight;
                }
                width = Math.round(width);
                height = Math.round(height);
                // Create a canvas element
                var canvas = _this.source;
                canvas.width = width;
                canvas.height = height;
                canvas._pixiId = "canvas_" + utils.uid();
                // Draw the Svg to the canvas
                canvas
                    .getContext('2d')
                    .drawImage(tempImage, 0, 0, svgWidth, svgHeight, 0, 0, width, height);
                _this._resolve();
                _this._resolve = null;
            };
        };
        /**
         * Get size from an svg string using a regular expression.
         * @param svgString - a serialized svg element
         * @returns - image extension
         */
        SVGResource.getSize = function (svgString) {
            var sizeMatch = SVGResource.SVG_SIZE.exec(svgString);
            var size = {};
            if (sizeMatch) {
                size[sizeMatch[1]] = Math.round(parseFloat(sizeMatch[3]));
                size[sizeMatch[5]] = Math.round(parseFloat(sizeMatch[7]));
            }
            return size;
        };
        /** Destroys this texture. */
        SVGResource.prototype.dispose = function () {
            _super.prototype.dispose.call(this);
            this._resolve = null;
            this._crossorigin = null;
        };
        /**
         * Used to auto-detect the type of resource.
         * @param {*} source - The source object
         * @param {string} extension - The extension of source, if set
         * @returns {boolean} - If the source is a SVG source or data file
         */
        SVGResource.test = function (source, extension) {
            // url file extension is SVG
            return extension === 'svg'
                // source is SVG data-uri
                || (typeof source === 'string' && (/^data:image\/svg\+xml(;(charset=utf8|utf8))?;base64/).test(source))
                // source is SVG inline
                || (typeof source === 'string' && SVGResource.SVG_XML.test(source));
        };
        /**
         * Regular expression for SVG XML document.
         * @example &lt;?xml version="1.0" encoding="utf-8" ?&gt;&lt;!-- image/svg --&gt;&lt;svg
         * @readonly
         */
        SVGResource.SVG_XML = /^(<\?xml[^?]+\?>)?\s*(<!--[^(-->)]*-->)?\s*\<svg/m;
        /**
         * Regular expression for SVG size.
         * @example &lt;svg width="100" height="100"&gt;&lt;/svg&gt;
         * @readonly
         */
        SVGResource.SVG_SIZE = /<svg[^>]*(?:\s(width|height)=('|")(\d*(?:\.\d+)?)(?:px)?('|"))[^>]*(?:\s(width|height)=('|")(\d*(?:\.\d+)?)(?:px)?('|"))[^>]*>/i; // eslint-disable-line max-len
        return SVGResource;
    }(BaseImageResource));

    /**
     * Resource type for {@code HTMLVideoElement}.
     * @memberof PIXI
     */
    var VideoResource = /** @class */ (function (_super) {
        __extends(VideoResource, _super);
        /**
         * @param {HTMLVideoElement|object|string|Array<string|object>} source - Video element to use.
         * @param {object} [options] - Options to use
         * @param {boolean} [options.autoLoad=true] - Start loading the video immediately
         * @param {boolean} [options.autoPlay=true] - Start playing video immediately
         * @param {number} [options.updateFPS=0] - How many times a second to update the texture from the video.
         * Leave at 0 to update at every render.
         * @param {boolean} [options.crossorigin=true] - Load image using cross origin
         */
        function VideoResource(source, options) {
            var _this = this;
            options = options || {};
            if (!(source instanceof HTMLVideoElement)) {
                var videoElement = document.createElement('video');
                // workaround for https://github.com/pixijs/pixi.js/issues/5996
                videoElement.setAttribute('preload', 'auto');
                videoElement.setAttribute('webkit-playsinline', '');
                videoElement.setAttribute('playsinline', '');
                if (typeof source === 'string') {
                    source = [source];
                }
                var firstSrc = source[0].src || source[0];
                BaseImageResource.crossOrigin(videoElement, firstSrc, options.crossorigin);
                // array of objects or strings
                for (var i = 0; i < source.length; ++i) {
                    var sourceElement = document.createElement('source');
                    var _a = source[i], src = _a.src, mime = _a.mime;
                    src = src || source[i];
                    var baseSrc = src.split('?').shift().toLowerCase();
                    var ext = baseSrc.slice(baseSrc.lastIndexOf('.') + 1);
                    mime = mime || VideoResource.MIME_TYPES[ext] || "video/" + ext;
                    sourceElement.src = src;
                    sourceElement.type = mime;
                    videoElement.appendChild(sourceElement);
                }
                // Override the source
                source = videoElement;
            }
            _this = _super.call(this, source) || this;
            _this.noSubImage = true;
            _this._autoUpdate = true;
            _this._isConnectedToTicker = false;
            _this._updateFPS = options.updateFPS || 0;
            _this._msToNextUpdate = 0;
            _this.autoPlay = options.autoPlay !== false;
            _this._load = null;
            _this._resolve = null;
            // Bind for listeners
            _this._onCanPlay = _this._onCanPlay.bind(_this);
            _this._onError = _this._onError.bind(_this);
            if (options.autoLoad !== false) {
                _this.load();
            }
            return _this;
        }
        /**
         * Trigger updating of the texture.
         * @param _deltaTime - time delta since last tick
         */
        VideoResource.prototype.update = function (_deltaTime) {
            if (_deltaTime === void 0) { _deltaTime = 0; }
            if (!this.destroyed) {
                // account for if video has had its playbackRate changed
                var elapsedMS = ticker.Ticker.shared.elapsedMS * this.source.playbackRate;
                this._msToNextUpdate = Math.floor(this._msToNextUpdate - elapsedMS);
                if (!this._updateFPS || this._msToNextUpdate <= 0) {
                    _super.prototype.update.call(this);
                    this._msToNextUpdate = this._updateFPS ? Math.floor(1000 / this._updateFPS) : 0;
                }
            }
        };
        /**
         * Start preloading the video resource.
         * @returns {Promise<void>} Handle the validate event
         */
        VideoResource.prototype.load = function () {
            var _this = this;
            if (this._load) {
                return this._load;
            }
            var source = this.source;
            if ((source.readyState === source.HAVE_ENOUGH_DATA || source.readyState === source.HAVE_FUTURE_DATA)
                && source.width && source.height) {
                source.complete = true;
            }
            source.addEventListener('play', this._onPlayStart.bind(this));
            source.addEventListener('pause', this._onPlayStop.bind(this));
            if (!this._isSourceReady()) {
                source.addEventListener('canplay', this._onCanPlay);
                source.addEventListener('canplaythrough', this._onCanPlay);
                source.addEventListener('error', this._onError, true);
            }
            else {
                this._onCanPlay();
            }
            this._load = new Promise(function (resolve) {
                if (_this.valid) {
                    resolve(_this);
                }
                else {
                    _this._resolve = resolve;
                    source.load();
                }
            });
            return this._load;
        };
        /**
         * Handle video error events.
         * @param event
         */
        VideoResource.prototype._onError = function (event) {
            this.source.removeEventListener('error', this._onError, true);
            this.onError.emit(event);
        };
        /**
         * Returns true if the underlying source is playing.
         * @returns - True if playing.
         */
        VideoResource.prototype._isSourcePlaying = function () {
            var source = this.source;
            return (source.currentTime > 0 && source.paused === false && source.ended === false && source.readyState > 2);
        };
        /**
         * Returns true if the underlying source is ready for playing.
         * @returns - True if ready.
         */
        VideoResource.prototype._isSourceReady = function () {
            var source = this.source;
            return source.readyState === 3 || source.readyState === 4;
        };
        /** Runs the update loop when the video is ready to play. */
        VideoResource.prototype._onPlayStart = function () {
            // Just in case the video has not received its can play even yet..
            if (!this.valid) {
                this._onCanPlay();
            }
            if (this.autoUpdate && !this._isConnectedToTicker) {
                ticker.Ticker.shared.add(this.update, this);
                this._isConnectedToTicker = true;
            }
        };
        /** Fired when a pause event is triggered, stops the update loop. */
        VideoResource.prototype._onPlayStop = function () {
            if (this._isConnectedToTicker) {
                ticker.Ticker.shared.remove(this.update, this);
                this._isConnectedToTicker = false;
            }
        };
        /** Fired when the video is loaded and ready to play. */
        VideoResource.prototype._onCanPlay = function () {
            var source = this.source;
            source.removeEventListener('canplay', this._onCanPlay);
            source.removeEventListener('canplaythrough', this._onCanPlay);
            var valid = this.valid;
            this.resize(source.videoWidth, source.videoHeight);
            // prevent multiple loaded dispatches..
            if (!valid && this._resolve) {
                this._resolve(this);
                this._resolve = null;
            }
            if (this._isSourcePlaying()) {
                this._onPlayStart();
            }
            else if (this.autoPlay) {
                source.play();
            }
        };
        /** Destroys this texture. */
        VideoResource.prototype.dispose = function () {
            if (this._isConnectedToTicker) {
                ticker.Ticker.shared.remove(this.update, this);
                this._isConnectedToTicker = false;
            }
            var source = this.source;
            if (source) {
                source.removeEventListener('error', this._onError, true);
                source.pause();
                source.src = '';
                source.load();
            }
            _super.prototype.dispose.call(this);
        };
        Object.defineProperty(VideoResource.prototype, "autoUpdate", {
            /** Should the base texture automatically update itself, set to true by default. */
            get: function () {
                return this._autoUpdate;
            },
            set: function (value) {
                if (value !== this._autoUpdate) {
                    this._autoUpdate = value;
                    if (!this._autoUpdate && this._isConnectedToTicker) {
                        ticker.Ticker.shared.remove(this.update, this);
                        this._isConnectedToTicker = false;
                    }
                    else if (this._autoUpdate && !this._isConnectedToTicker && this._isSourcePlaying()) {
                        ticker.Ticker.shared.add(this.update, this);
                        this._isConnectedToTicker = true;
                    }
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(VideoResource.prototype, "updateFPS", {
            /**
             * How many times a second to update the texture from the video. Leave at 0 to update at every render.
             * A lower fps can help performance, as updating the texture at 60fps on a 30ps video may not be efficient.
             */
            get: function () {
                return this._updateFPS;
            },
            set: function (value) {
                if (value !== this._updateFPS) {
                    this._updateFPS = value;
                }
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Used to auto-detect the type of resource.
         * @param {*} source - The source object
         * @param {string} extension - The extension of source, if set
         * @returns {boolean} `true` if video source
         */
        VideoResource.test = function (source, extension) {
            return (globalThis.HTMLVideoElement && source instanceof HTMLVideoElement)
                || VideoResource.TYPES.indexOf(extension) > -1;
        };
        /**
         * List of common video file extensions supported by VideoResource.
         * @readonly
         */
        VideoResource.TYPES = ['mp4', 'm4v', 'webm', 'ogg', 'ogv', 'h264', 'avi', 'mov'];
        /**
         * Map of video MIME types that can't be directly derived from file extensions.
         * @readonly
         */
        VideoResource.MIME_TYPES = {
            ogv: 'video/ogg',
            mov: 'video/quicktime',
            m4v: 'video/mp4',
        };
        return VideoResource;
    }(BaseImageResource));

    /**
     * Resource type for ImageBitmap.
     * @memberof PIXI
     */
    var ImageBitmapResource = /** @class */ (function (_super) {
        __extends(ImageBitmapResource, _super);
        /**
         * @param source - Image element to use
         */
        // eslint-disable-next-line @typescript-eslint/no-useless-constructor
        function ImageBitmapResource(source) {
            return _super.call(this, source) || this;
        }
        /**
         * Used to auto-detect the type of resource.
         * @param {*} source - The source object
         * @returns {boolean} `true` if source is an ImageBitmap
         */
        ImageBitmapResource.test = function (source) {
            return !!globalThis.createImageBitmap && typeof ImageBitmap !== 'undefined' && source instanceof ImageBitmap;
        };
        return ImageBitmapResource;
    }(BaseImageResource));

    INSTALLED.push(ImageResource, ImageBitmapResource, CanvasResource, VideoResource, SVGResource, BufferResource, CubeResource, ArrayResource);

    var _resources = {
        __proto__: null,
        Resource: Resource,
        BaseImageResource: BaseImageResource,
        INSTALLED: INSTALLED,
        autoDetectResource: autoDetectResource,
        AbstractMultiResource: AbstractMultiResource,
        ArrayResource: ArrayResource,
        BufferResource: BufferResource,
        CanvasResource: CanvasResource,
        CubeResource: CubeResource,
        ImageResource: ImageResource,
        SVGResource: SVGResource,
        VideoResource: VideoResource,
        ImageBitmapResource: ImageBitmapResource
    };

    /**
     * Resource type for DepthTexture.
     * @memberof PIXI
     */
    var DepthResource = /** @class */ (function (_super) {
        __extends(DepthResource, _super);
        function DepthResource() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        /**
         * Upload the texture to the GPU.
         * @param renderer - Upload to the renderer
         * @param baseTexture - Reference to parent texture
         * @param glTexture - glTexture
         * @returns - true is success
         */
        DepthResource.prototype.upload = function (renderer, baseTexture, glTexture) {
            var gl = renderer.gl;
            gl.pixelStorei(gl.UNPACK_PREMULTIPLY_ALPHA_WEBGL, baseTexture.alphaMode === constants.ALPHA_MODES.UNPACK);
            var width = baseTexture.realWidth;
            var height = baseTexture.realHeight;
            if (glTexture.width === width && glTexture.height === height) {
                gl.texSubImage2D(baseTexture.target, 0, 0, 0, width, height, baseTexture.format, glTexture.type, this.data);
            }
            else {
                glTexture.width = width;
                glTexture.height = height;
                gl.texImage2D(baseTexture.target, 0, glTexture.internalFormat, width, height, 0, baseTexture.format, glTexture.type, this.data);
            }
            return true;
        };
        return DepthResource;
    }(BufferResource));

    /**
     * A framebuffer can be used to render contents off of the screen. {@link PIXI.BaseRenderTexture} uses
     * one internally to render into itself. You can attach a depth or stencil buffer to a framebuffer.
     *
     * On WebGL 2 machines, shaders can output to multiple textures simultaneously with GLSL 300 ES.
     * @memberof PIXI
     */
    var Framebuffer = /** @class */ (function () {
        /**
         * @param width - Width of the frame buffer
         * @param height - Height of the frame buffer
         */
        function Framebuffer(width, height) {
            this.width = Math.round(width || 100);
            this.height = Math.round(height || 100);
            this.stencil = false;
            this.depth = false;
            this.dirtyId = 0;
            this.dirtyFormat = 0;
            this.dirtySize = 0;
            this.depthTexture = null;
            this.colorTextures = [];
            this.glFramebuffers = {};
            this.disposeRunner = new runner.Runner('disposeFramebuffer');
            this.multisample = constants.MSAA_QUALITY.NONE;
        }
        Object.defineProperty(Framebuffer.prototype, "colorTexture", {
            /**
             * Reference to the colorTexture.
             * @readonly
             */
            get: function () {
                return this.colorTextures[0];
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Add texture to the colorTexture array.
         * @param index - Index of the array to add the texture to
         * @param texture - Texture to add to the array
         */
        Framebuffer.prototype.addColorTexture = function (index, texture) {
            if (index === void 0) { index = 0; }
            // TODO add some validation to the texture - same width / height etc?
            this.colorTextures[index] = texture || new BaseTexture(null, {
                scaleMode: constants.SCALE_MODES.NEAREST,
                resolution: 1,
                mipmap: constants.MIPMAP_MODES.OFF,
                width: this.width,
                height: this.height,
            });
            this.dirtyId++;
            this.dirtyFormat++;
            return this;
        };
        /**
         * Add a depth texture to the frame buffer.
         * @param texture - Texture to add.
         */
        Framebuffer.prototype.addDepthTexture = function (texture) {
            /* eslint-disable max-len */
            this.depthTexture = texture || new BaseTexture(new DepthResource(null, { width: this.width, height: this.height }), {
                scaleMode: constants.SCALE_MODES.NEAREST,
                resolution: 1,
                width: this.width,
                height: this.height,
                mipmap: constants.MIPMAP_MODES.OFF,
                format: constants.FORMATS.DEPTH_COMPONENT,
                type: constants.TYPES.UNSIGNED_SHORT,
            });
            this.dirtyId++;
            this.dirtyFormat++;
            return this;
        };
        /** Enable depth on the frame buffer. */
        Framebuffer.prototype.enableDepth = function () {
            this.depth = true;
            this.dirtyId++;
            this.dirtyFormat++;
            return this;
        };
        /** Enable stencil on the frame buffer. */
        Framebuffer.prototype.enableStencil = function () {
            this.stencil = true;
            this.dirtyId++;
            this.dirtyFormat++;
            return this;
        };
        /**
         * Resize the frame buffer
         * @param width - Width of the frame buffer to resize to
         * @param height - Height of the frame buffer to resize to
         */
        Framebuffer.prototype.resize = function (width, height) {
            width = Math.round(width);
            height = Math.round(height);
            if (width === this.width && height === this.height)
                { return; }
            this.width = width;
            this.height = height;
            this.dirtyId++;
            this.dirtySize++;
            for (var i = 0; i < this.colorTextures.length; i++) {
                var texture = this.colorTextures[i];
                var resolution = texture.resolution;
                // take into account the fact the texture may have a different resolution..
                texture.setSize(width / resolution, height / resolution);
            }
            if (this.depthTexture) {
                var resolution = this.depthTexture.resolution;
                this.depthTexture.setSize(width / resolution, height / resolution);
            }
        };
        /** Disposes WebGL resources that are connected to this geometry. */
        Framebuffer.prototype.dispose = function () {
            this.disposeRunner.emit(this, false);
        };
        /** Destroys and removes the depth texture added to this framebuffer. */
        Framebuffer.prototype.destroyDepthTexture = function () {
            if (this.depthTexture) {
                this.depthTexture.destroy();
                this.depthTexture = null;
                ++this.dirtyId;
                ++this.dirtyFormat;
            }
        };
        return Framebuffer;
    }());

    /**
     * A BaseRenderTexture is a special texture that allows any PixiJS display object to be rendered to it.
     *
     * __Hint__: All DisplayObjects (i.e. Sprites) that render to a BaseRenderTexture should be preloaded
     * otherwise black rectangles will be drawn instead.
     *
     * A BaseRenderTexture takes a snapshot of any Display Object given to its render method. The position
     * and rotation of the given Display Objects is ignored. For example:
     *
     * ```js
     * let renderer = PIXI.autoDetectRenderer();
     * let baseRenderTexture = new PIXI.BaseRenderTexture({ width: 800, height: 600 });
     * let renderTexture = new PIXI.RenderTexture(baseRenderTexture);
     * let sprite = PIXI.Sprite.from("spinObj_01.png");
     *
     * sprite.position.x = 800/2;
     * sprite.position.y = 600/2;
     * sprite.anchor.x = 0.5;
     * sprite.anchor.y = 0.5;
     *
     * renderer.render(sprite, {renderTexture});
     * ```
     *
     * The Sprite in this case will be rendered using its local transform. To render this sprite at 0,0
     * you can clear the transform
     *
     * ```js
     *
     * sprite.setTransform()
     *
     * let baseRenderTexture = new PIXI.BaseRenderTexture({ width: 100, height: 100 });
     * let renderTexture = new PIXI.RenderTexture(baseRenderTexture);
     *
     * renderer.render(sprite, {renderTexture});  // Renders to center of RenderTexture
     * ```
     * @memberof PIXI
     */
    var BaseRenderTexture = /** @class */ (function (_super) {
        __extends(BaseRenderTexture, _super);
        /**
         * @param options
         * @param {number} [options.width=100] - The width of the base render texture.
         * @param {number} [options.height=100] - The height of the base render texture.
         * @param {PIXI.SCALE_MODES} [options.scaleMode=PIXI.settings.SCALE_MODE] - See {@link PIXI.SCALE_MODES}
         *   for possible values.
         * @param {number} [options.resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio
         *   of the texture being generated.
         * @param {PIXI.MSAA_QUALITY} [options.multisample=PIXI.MSAA_QUALITY.NONE] - The number of samples of the frame buffer.
         */
        function BaseRenderTexture(options) {
            if (options === void 0) { options = {}; }
            var _this = this;
            if (typeof options === 'number') {
                /* eslint-disable prefer-rest-params */
                // Backward compatibility of signature
                var width = arguments[0];
                var height = arguments[1];
                var scaleMode = arguments[2];
                var resolution = arguments[3];
                options = { width: width, height: height, scaleMode: scaleMode, resolution: resolution };
                /* eslint-enable prefer-rest-params */
            }
            options.width = options.width || 100;
            options.height = options.height || 100;
            options.multisample = options.multisample !== undefined ? options.multisample : constants.MSAA_QUALITY.NONE;
            _this = _super.call(this, null, options) || this;
            // Set defaults
            _this.mipmap = constants.MIPMAP_MODES.OFF;
            _this.valid = true;
            _this.clearColor = [0, 0, 0, 0];
            _this.framebuffer = new Framebuffer(_this.realWidth, _this.realHeight)
                .addColorTexture(0, _this);
            _this.framebuffer.multisample = options.multisample;
            // TODO - could this be added the systems?
            _this.maskStack = [];
            _this.filterStack = [{}];
            return _this;
        }
        /**
         * Resizes the BaseRenderTexture.
         * @param desiredWidth - The desired width to resize to.
         * @param desiredHeight - The desired height to resize to.
         */
        BaseRenderTexture.prototype.resize = function (desiredWidth, desiredHeight) {
            this.framebuffer.resize(desiredWidth * this.resolution, desiredHeight * this.resolution);
            this.setRealSize(this.framebuffer.width, this.framebuffer.height);
        };
        /**
         * Frees the texture and framebuffer from WebGL memory without destroying this texture object.
         * This means you can still use the texture later which will upload it to GPU
         * memory again.
         * @fires PIXI.BaseTexture#dispose
         */
        BaseRenderTexture.prototype.dispose = function () {
            this.framebuffer.dispose();
            _super.prototype.dispose.call(this);
        };
        /** Destroys this texture. */
        BaseRenderTexture.prototype.destroy = function () {
            _super.prototype.destroy.call(this);
            this.framebuffer.destroyDepthTexture();
            this.framebuffer = null;
        };
        return BaseRenderTexture;
    }(BaseTexture));

    /**
     * Stores a texture's frame in UV coordinates, in
     * which everything lies in the rectangle `[(0,0), (1,0),
     * (1,1), (0,1)]`.
     *
     * | Corner       | Coordinates |
     * |--------------|-------------|
     * | Top-Left     | `(x0,y0)`   |
     * | Top-Right    | `(x1,y1)`   |
     * | Bottom-Right | `(x2,y2)`   |
     * | Bottom-Left  | `(x3,y3)`   |
     * @protected
     * @memberof PIXI
     */
    var TextureUvs = /** @class */ (function () {
        function TextureUvs() {
            this.x0 = 0;
            this.y0 = 0;
            this.x1 = 1;
            this.y1 = 0;
            this.x2 = 1;
            this.y2 = 1;
            this.x3 = 0;
            this.y3 = 1;
            this.uvsFloat32 = new Float32Array(8);
        }
        /**
         * Sets the texture Uvs based on the given frame information.
         * @protected
         * @param frame - The frame of the texture
         * @param baseFrame - The base frame of the texture
         * @param rotate - Rotation of frame, see {@link PIXI.groupD8}
         */
        TextureUvs.prototype.set = function (frame, baseFrame, rotate) {
            var tw = baseFrame.width;
            var th = baseFrame.height;
            if (rotate) {
                // width and height div 2 div baseFrame size
                var w2 = frame.width / 2 / tw;
                var h2 = frame.height / 2 / th;
                // coordinates of center
                var cX = (frame.x / tw) + w2;
                var cY = (frame.y / th) + h2;
                rotate = math.groupD8.add(rotate, math.groupD8.NW); // NW is top-left corner
                this.x0 = cX + (w2 * math.groupD8.uX(rotate));
                this.y0 = cY + (h2 * math.groupD8.uY(rotate));
                rotate = math.groupD8.add(rotate, 2); // rotate 90 degrees clockwise
                this.x1 = cX + (w2 * math.groupD8.uX(rotate));
                this.y1 = cY + (h2 * math.groupD8.uY(rotate));
                rotate = math.groupD8.add(rotate, 2);
                this.x2 = cX + (w2 * math.groupD8.uX(rotate));
                this.y2 = cY + (h2 * math.groupD8.uY(rotate));
                rotate = math.groupD8.add(rotate, 2);
                this.x3 = cX + (w2 * math.groupD8.uX(rotate));
                this.y3 = cY + (h2 * math.groupD8.uY(rotate));
            }
            else {
                this.x0 = frame.x / tw;
                this.y0 = frame.y / th;
                this.x1 = (frame.x + frame.width) / tw;
                this.y1 = frame.y / th;
                this.x2 = (frame.x + frame.width) / tw;
                this.y2 = (frame.y + frame.height) / th;
                this.x3 = frame.x / tw;
                this.y3 = (frame.y + frame.height) / th;
            }
            this.uvsFloat32[0] = this.x0;
            this.uvsFloat32[1] = this.y0;
            this.uvsFloat32[2] = this.x1;
            this.uvsFloat32[3] = this.y1;
            this.uvsFloat32[4] = this.x2;
            this.uvsFloat32[5] = this.y2;
            this.uvsFloat32[6] = this.x3;
            this.uvsFloat32[7] = this.y3;
        };
        TextureUvs.prototype.toString = function () {
            return "[@pixi/core:TextureUvs "
                + ("x0=" + this.x0 + " y0=" + this.y0 + " ")
                + ("x1=" + this.x1 + " y1=" + this.y1 + " x2=" + this.x2 + " ")
                + ("y2=" + this.y2 + " x3=" + this.x3 + " y3=" + this.y3)
                + "]";
        };
        return TextureUvs;
    }());

    var DEFAULT_UVS = new TextureUvs();
    /**
     * Used to remove listeners from WHITE and EMPTY Textures
     * @ignore
     */
    function removeAllHandlers(tex) {
        tex.destroy = function _emptyDestroy() { };
        tex.on = function _emptyOn() { };
        tex.once = function _emptyOnce() { };
        tex.emit = function _emptyEmit() { };
    }
    /**
     * A texture stores the information that represents an image or part of an image.
     *
     * It cannot be added to the display list directly; instead use it as the texture for a Sprite.
     * If no frame is provided for a texture, then the whole image is used.
     *
     * You can directly create a texture from an image and then reuse it multiple times like this :
     *
     * ```js
     * let texture = PIXI.Texture.from('assets/image.png');
     * let sprite1 = new PIXI.Sprite(texture);
     * let sprite2 = new PIXI.Sprite(texture);
     * ```
     *
     * If you didnt pass the texture frame to constructor, it enables `noFrame` mode:
     * it subscribes on baseTexture events, it automatically resizes at the same time as baseTexture.
     *
     * Textures made from SVGs, loaded or not, cannot be used before the file finishes processing.
     * You can check for this by checking the sprite's _textureID property.
     * ```js
     * var texture = PIXI.Texture.from('assets/image.svg');
     * var sprite1 = new PIXI.Sprite(texture);
     * //sprite1._textureID should not be undefined if the texture has finished processing the SVG file
     * ```
     * You can use a ticker or rAF to ensure your sprites load the finished textures after processing. See issue #3068.
     * @memberof PIXI
     * @typeParam R - The BaseTexture's Resource type.
     */
    var Texture = /** @class */ (function (_super) {
        __extends(Texture, _super);
        /**
         * @param baseTexture - The base texture source to create the texture from
         * @param frame - The rectangle frame of the texture to show
         * @param orig - The area of original texture
         * @param trim - Trimmed rectangle of original texture
         * @param rotate - indicates how the texture was rotated by texture packer. See {@link PIXI.groupD8}
         * @param anchor - Default anchor point used for sprite placement / rotation
         */
        function Texture(baseTexture, frame, orig, trim, rotate, anchor) {
            var _this = _super.call(this) || this;
            _this.noFrame = false;
            if (!frame) {
                _this.noFrame = true;
                frame = new math.Rectangle(0, 0, 1, 1);
            }
            if (baseTexture instanceof Texture) {
                baseTexture = baseTexture.baseTexture;
            }
            _this.baseTexture = baseTexture;
            _this._frame = frame;
            _this.trim = trim;
            _this.valid = false;
            _this._uvs = DEFAULT_UVS;
            _this.uvMatrix = null;
            _this.orig = orig || frame; // new Rectangle(0, 0, 1, 1);
            _this._rotate = Number(rotate || 0);
            if (rotate === true) {
                // this is old texturepacker legacy, some games/libraries are passing "true" for rotated textures
                _this._rotate = 2;
            }
            else if (_this._rotate % 2 !== 0) {
                throw new Error('attempt to use diamond-shaped UVs. If you are sure, set rotation manually');
            }
            _this.defaultAnchor = anchor ? new math.Point(anchor.x, anchor.y) : new math.Point(0, 0);
            _this._updateID = 0;
            _this.textureCacheIds = [];
            if (!baseTexture.valid) {
                baseTexture.once('loaded', _this.onBaseTextureUpdated, _this);
            }
            else if (_this.noFrame) {
                // if there is no frame we should monitor for any base texture changes..
                if (baseTexture.valid) {
                    _this.onBaseTextureUpdated(baseTexture);
                }
            }
            else {
                _this.frame = frame;
            }
            if (_this.noFrame) {
                baseTexture.on('update', _this.onBaseTextureUpdated, _this);
            }
            return _this;
        }
        /**
         * Updates this texture on the gpu.
         *
         * Calls the TextureResource update.
         *
         * If you adjusted `frame` manually, please call `updateUvs()` instead.
         */
        Texture.prototype.update = function () {
            if (this.baseTexture.resource) {
                this.baseTexture.resource.update();
            }
        };
        /**
         * Called when the base texture is updated
         * @protected
         * @param baseTexture - The base texture.
         */
        Texture.prototype.onBaseTextureUpdated = function (baseTexture) {
            if (this.noFrame) {
                if (!this.baseTexture.valid) {
                    return;
                }
                this._frame.width = baseTexture.width;
                this._frame.height = baseTexture.height;
                this.valid = true;
                this.updateUvs();
            }
            else {
                // TODO this code looks confusing.. boo to abusing getters and setters!
                // if user gave us frame that has bigger size than resized texture it can be a problem
                this.frame = this._frame;
            }
            this.emit('update', this);
        };
        /**
         * Destroys this texture
         * @param [destroyBase=false] - Whether to destroy the base texture as well
         */
        Texture.prototype.destroy = function (destroyBase) {
            if (this.baseTexture) {
                if (destroyBase) {
                    var resource = this.baseTexture.resource;
                    // delete the texture if it exists in the texture cache..
                    // this only needs to be removed if the base texture is actually destroyed too..
                    if (resource && resource.url && utils.TextureCache[resource.url]) {
                        Texture.removeFromCache(resource.url);
                    }
                    this.baseTexture.destroy();
                }
                this.baseTexture.off('loaded', this.onBaseTextureUpdated, this);
                this.baseTexture.off('update', this.onBaseTextureUpdated, this);
                this.baseTexture = null;
            }
            this._frame = null;
            this._uvs = null;
            this.trim = null;
            this.orig = null;
            this.valid = false;
            Texture.removeFromCache(this);
            this.textureCacheIds = null;
        };
        /**
         * Creates a new texture object that acts the same as this one.
         * @returns - The new texture
         */
        Texture.prototype.clone = function () {
            var clonedFrame = this._frame.clone();
            var clonedOrig = this._frame === this.orig ? clonedFrame : this.orig.clone();
            var clonedTexture = new Texture(this.baseTexture, !this.noFrame && clonedFrame, clonedOrig, this.trim && this.trim.clone(), this.rotate, this.defaultAnchor);
            if (this.noFrame) {
                clonedTexture._frame = clonedFrame;
            }
            return clonedTexture;
        };
        /**
         * Updates the internal WebGL UV cache. Use it after you change `frame` or `trim` of the texture.
         * Call it after changing the frame
         */
        Texture.prototype.updateUvs = function () {
            if (this._uvs === DEFAULT_UVS) {
                this._uvs = new TextureUvs();
            }
            this._uvs.set(this._frame, this.baseTexture, this.rotate);
            this._updateID++;
        };
        /**
         * Helper function that creates a new Texture based on the source you provide.
         * The source can be - frame id, image url, video url, canvas element, video element, base texture
         * @param {string|HTMLImageElement|HTMLCanvasElement|HTMLVideoElement|PIXI.BaseTexture} source -
         *        Source or array of sources to create texture from
         * @param options - See {@link PIXI.BaseTexture}'s constructor for options.
         * @param {string} [options.pixiIdPrefix=pixiid] - If a source has no id, this is the prefix of the generated id
         * @param {boolean} [strict] - Enforce strict-mode, see {@link PIXI.settings.STRICT_TEXTURE_CACHE}.
         * @returns {PIXI.Texture} The newly created texture
         */
        Texture.from = function (source, options, strict) {
            if (options === void 0) { options = {}; }
            if (strict === void 0) { strict = settings.settings.STRICT_TEXTURE_CACHE; }
            var isFrame = typeof source === 'string';
            var cacheId = null;
            if (isFrame) {
                cacheId = source;
            }
            else if (source instanceof BaseTexture) {
                if (!source.cacheId) {
                    var prefix = (options && options.pixiIdPrefix) || 'pixiid';
                    source.cacheId = prefix + "-" + utils.uid();
                    BaseTexture.addToCache(source, source.cacheId);
                }
                cacheId = source.cacheId;
            }
            else {
                if (!source._pixiId) {
                    var prefix = (options && options.pixiIdPrefix) || 'pixiid';
                    source._pixiId = prefix + "_" + utils.uid();
                }
                cacheId = source._pixiId;
            }
            var texture = utils.TextureCache[cacheId];
            // Strict-mode rejects invalid cacheIds
            if (isFrame && strict && !texture) {
                throw new Error("The cacheId \"" + cacheId + "\" does not exist in TextureCache.");
            }
            if (!texture && !(source instanceof BaseTexture)) {
                if (!options.resolution) {
                    options.resolution = utils.getResolutionOfUrl(source);
                }
                texture = new Texture(new BaseTexture(source, options));
                texture.baseTexture.cacheId = cacheId;
                BaseTexture.addToCache(texture.baseTexture, cacheId);
                Texture.addToCache(texture, cacheId);
            }
            else if (!texture && (source instanceof BaseTexture)) {
                texture = new Texture(source);
                Texture.addToCache(texture, cacheId);
            }
            // lets assume its a base texture!
            return texture;
        };
        /**
         * Useful for loading textures via URLs. Use instead of `Texture.from` because
         * it does a better job of handling failed URLs more effectively. This also ignores
         * `PIXI.settings.STRICT_TEXTURE_CACHE`. Works for Videos, SVGs, Images.
         * @param url - The remote URL or array of URLs to load.
         * @param options - Optional options to include
         * @returns - A Promise that resolves to a Texture.
         */
        Texture.fromURL = function (url, options) {
            var resourceOptions = Object.assign({ autoLoad: false }, options === null || options === void 0 ? void 0 : options.resourceOptions);
            var texture = Texture.from(url, Object.assign({ resourceOptions: resourceOptions }, options), false);
            var resource = texture.baseTexture.resource;
            // The texture was already loaded
            if (texture.baseTexture.valid) {
                return Promise.resolve(texture);
            }
            // Manually load the texture, this should allow users to handle load errors
            return resource.load().then(function () { return Promise.resolve(texture); });
        };
        /**
         * Create a new Texture with a BufferResource from a Float32Array.
         * RGBA values are floats from 0 to 1.
         * @param {Float32Array|Uint8Array} buffer - The optional array to use, if no data
         *        is provided, a new Float32Array is created.
         * @param width - Width of the resource
         * @param height - Height of the resource
         * @param options - See {@link PIXI.BaseTexture}'s constructor for options.
         * @returns - The resulting new BaseTexture
         */
        Texture.fromBuffer = function (buffer, width, height, options) {
            return new Texture(BaseTexture.fromBuffer(buffer, width, height, options));
        };
        /**
         * Create a texture from a source and add to the cache.
         * @param {HTMLImageElement|HTMLCanvasElement|string} source - The input source.
         * @param imageUrl - File name of texture, for cache and resolving resolution.
         * @param name - Human readable name for the texture cache. If no name is
         *        specified, only `imageUrl` will be used as the cache ID.
         * @param options
         * @returns - Output texture
         */
        Texture.fromLoader = function (source, imageUrl, name, options) {
            var baseTexture = new BaseTexture(source, Object.assign({
                scaleMode: settings.settings.SCALE_MODE,
                resolution: utils.getResolutionOfUrl(imageUrl),
            }, options));
            var resource = baseTexture.resource;
            if (resource instanceof ImageResource) {
                resource.url = imageUrl;
            }
            var texture = new Texture(baseTexture);
            // No name, use imageUrl instead
            if (!name) {
                name = imageUrl;
            }
            // lets also add the frame to pixi's global cache for 'fromLoader' function
            BaseTexture.addToCache(texture.baseTexture, name);
            Texture.addToCache(texture, name);
            // also add references by url if they are different.
            if (name !== imageUrl) {
                BaseTexture.addToCache(texture.baseTexture, imageUrl);
                Texture.addToCache(texture, imageUrl);
            }
            // Generally images are valid right away
            if (texture.baseTexture.valid) {
                return Promise.resolve(texture);
            }
            // SVG assets need to be parsed async, let's wait
            return new Promise(function (resolve) {
                texture.baseTexture.once('loaded', function () { return resolve(texture); });
            });
        };
        /**
         * Adds a Texture to the global TextureCache. This cache is shared across the whole PIXI object.
         * @param texture - The Texture to add to the cache.
         * @param id - The id that the Texture will be stored against.
         */
        Texture.addToCache = function (texture, id) {
            if (id) {
                if (texture.textureCacheIds.indexOf(id) === -1) {
                    texture.textureCacheIds.push(id);
                }
                if (utils.TextureCache[id]) {
                    // eslint-disable-next-line no-console
                    console.warn("Texture added to the cache with an id [" + id + "] that already had an entry");
                }
                utils.TextureCache[id] = texture;
            }
        };
        /**
         * Remove a Texture from the global TextureCache.
         * @param texture - id of a Texture to be removed, or a Texture instance itself
         * @returns - The Texture that was removed
         */
        Texture.removeFromCache = function (texture) {
            if (typeof texture === 'string') {
                var textureFromCache = utils.TextureCache[texture];
                if (textureFromCache) {
                    var index = textureFromCache.textureCacheIds.indexOf(texture);
                    if (index > -1) {
                        textureFromCache.textureCacheIds.splice(index, 1);
                    }
                    delete utils.TextureCache[texture];
                    return textureFromCache;
                }
            }
            else if (texture && texture.textureCacheIds) {
                for (var i = 0; i < texture.textureCacheIds.length; ++i) {
                    // Check that texture matches the one being passed in before deleting it from the cache.
                    if (utils.TextureCache[texture.textureCacheIds[i]] === texture) {
                        delete utils.TextureCache[texture.textureCacheIds[i]];
                    }
                }
                texture.textureCacheIds.length = 0;
                return texture;
            }
            return null;
        };
        Object.defineProperty(Texture.prototype, "resolution", {
            /**
             * Returns resolution of baseTexture
             * @readonly
             */
            get: function () {
                return this.baseTexture.resolution;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Texture.prototype, "frame", {
            /**
             * The frame specifies the region of the base texture that this texture uses.
             * Please call `updateUvs()` after you change coordinates of `frame` manually.
             */
            get: function () {
                return this._frame;
            },
            set: function (frame) {
                this._frame = frame;
                this.noFrame = false;
                var x = frame.x, y = frame.y, width = frame.width, height = frame.height;
                var xNotFit = x + width > this.baseTexture.width;
                var yNotFit = y + height > this.baseTexture.height;
                if (xNotFit || yNotFit) {
                    var relationship = xNotFit && yNotFit ? 'and' : 'or';
                    var errorX = "X: " + x + " + " + width + " = " + (x + width) + " > " + this.baseTexture.width;
                    var errorY = "Y: " + y + " + " + height + " = " + (y + height) + " > " + this.baseTexture.height;
                    throw new Error('Texture Error: frame does not fit inside the base Texture dimensions: '
                        + (errorX + " " + relationship + " " + errorY));
                }
                this.valid = width && height && this.baseTexture.valid;
                if (!this.trim && !this.rotate) {
                    this.orig = frame;
                }
                if (this.valid) {
                    this.updateUvs();
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Texture.prototype, "rotate", {
            /**
             * Indicates whether the texture is rotated inside the atlas
             * set to 2 to compensate for texture packer rotation
             * set to 6 to compensate for spine packer rotation
             * can be used to rotate or mirror sprites
             * See {@link PIXI.groupD8} for explanation
             */
            get: function () {
                return this._rotate;
            },
            set: function (rotate) {
                this._rotate = rotate;
                if (this.valid) {
                    this.updateUvs();
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Texture.prototype, "width", {
            /** The width of the Texture in pixels. */
            get: function () {
                return this.orig.width;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Texture.prototype, "height", {
            /** The height of the Texture in pixels. */
            get: function () {
                return this.orig.height;
            },
            enumerable: false,
            configurable: true
        });
        /** Utility function for BaseTexture|Texture cast. */
        Texture.prototype.castToBaseTexture = function () {
            return this.baseTexture;
        };
        Object.defineProperty(Texture, "EMPTY", {
            /** An empty texture, used often to not have to create multiple empty textures. Can not be destroyed. */
            get: function () {
                if (!Texture._EMPTY) {
                    Texture._EMPTY = new Texture(new BaseTexture());
                    removeAllHandlers(Texture._EMPTY);
                    removeAllHandlers(Texture._EMPTY.baseTexture);
                }
                return Texture._EMPTY;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Texture, "WHITE", {
            /** A white texture of 16x16 size, used for graphics and other things Can not be destroyed. */
            get: function () {
                if (!Texture._WHITE) {
                    var canvas = settings.settings.ADAPTER.createCanvas(16, 16);
                    var context = canvas.getContext('2d');
                    canvas.width = 16;
                    canvas.height = 16;
                    context.fillStyle = 'white';
                    context.fillRect(0, 0, 16, 16);
                    Texture._WHITE = new Texture(BaseTexture.from(canvas));
                    removeAllHandlers(Texture._WHITE);
                    removeAllHandlers(Texture._WHITE.baseTexture);
                }
                return Texture._WHITE;
            },
            enumerable: false,
            configurable: true
        });
        return Texture;
    }(utils.EventEmitter));

    /**
     * A RenderTexture is a special texture that allows any PixiJS display object to be rendered to it.
     *
     * __Hint__: All DisplayObjects (i.e. Sprites) that render to a RenderTexture should be preloaded
     * otherwise black rectangles will be drawn instead.
     *
     * __Hint-2__: The actual memory allocation will happen on first render.
     * You shouldn't create renderTextures each frame just to delete them after, try to reuse them.
     *
     * A RenderTexture takes a snapshot of any Display Object given to its render method. For example:
     *
     * ```js
     * let renderer = PIXI.autoDetectRenderer();
     * let renderTexture = PIXI.RenderTexture.create({ width: 800, height: 600 });
     * let sprite = PIXI.Sprite.from("spinObj_01.png");
     *
     * sprite.position.x = 800/2;
     * sprite.position.y = 600/2;
     * sprite.anchor.x = 0.5;
     * sprite.anchor.y = 0.5;
     *
     * renderer.render(sprite, {renderTexture});
     * ```
     * Note that you should not create a new renderer, but reuse the same one as the rest of the application.
     *
     * The Sprite in this case will be rendered using its local transform. To render this sprite at 0,0
     * you can clear the transform
     *
     * ```js
     *
     * sprite.setTransform()
     *
     * let renderTexture = new PIXI.RenderTexture.create({ width: 100, height: 100 });
     *
     * renderer.render(sprite, {renderTexture});  // Renders to center of RenderTexture
     * ```
     * @memberof PIXI
     */
    var RenderTexture = /** @class */ (function (_super) {
        __extends(RenderTexture, _super);
        /**
         * @param baseRenderTexture - The base texture object that this texture uses.
         * @param frame - The rectangle frame of the texture to show.
         */
        function RenderTexture(baseRenderTexture, frame) {
            var _this = _super.call(this, baseRenderTexture, frame) || this;
            _this.valid = true;
            _this.filterFrame = null;
            _this.filterPoolKey = null;
            _this.updateUvs();
            return _this;
        }
        Object.defineProperty(RenderTexture.prototype, "framebuffer", {
            /**
             * Shortcut to `this.baseTexture.framebuffer`, saves baseTexture cast.
             * @readonly
             */
            get: function () {
                return this.baseTexture.framebuffer;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(RenderTexture.prototype, "multisample", {
            /**
             * Shortcut to `this.framebuffer.multisample`.
             * @default PIXI.MSAA_QUALITY.NONE
             */
            get: function () {
                return this.framebuffer.multisample;
            },
            set: function (value) {
                this.framebuffer.multisample = value;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Resizes the RenderTexture.
         * @param desiredWidth - The desired width to resize to.
         * @param desiredHeight - The desired height to resize to.
         * @param resizeBaseTexture - Should the baseTexture.width and height values be resized as well?
         */
        RenderTexture.prototype.resize = function (desiredWidth, desiredHeight, resizeBaseTexture) {
            if (resizeBaseTexture === void 0) { resizeBaseTexture = true; }
            var resolution = this.baseTexture.resolution;
            var width = Math.round(desiredWidth * resolution) / resolution;
            var height = Math.round(desiredHeight * resolution) / resolution;
            // TODO - could be not required..
            this.valid = (width > 0 && height > 0);
            this._frame.width = this.orig.width = width;
            this._frame.height = this.orig.height = height;
            if (resizeBaseTexture) {
                this.baseTexture.resize(width, height);
            }
            this.updateUvs();
        };
        /**
         * Changes the resolution of baseTexture, but does not change framebuffer size.
         * @param resolution - The new resolution to apply to RenderTexture
         */
        RenderTexture.prototype.setResolution = function (resolution) {
            var baseTexture = this.baseTexture;
            if (baseTexture.resolution === resolution) {
                return;
            }
            baseTexture.setResolution(resolution);
            this.resize(baseTexture.width, baseTexture.height, false);
        };
        RenderTexture.create = function (options) {
            var arguments$1 = arguments;

            var rest = [];
            for (var _i = 1; _i < arguments.length; _i++) {
                rest[_i - 1] = arguments$1[_i];
            }
            // @deprecated fallback, old-style: create(width, height, scaleMode, resolution)
            if (typeof options === 'number') {
                utils.deprecation('6.0.0', 'Arguments (width, height, scaleMode, resolution) have been deprecated.');
                /* eslint-disable prefer-rest-params */
                options = {
                    width: options,
                    height: rest[0],
                    scaleMode: rest[1],
                    resolution: rest[2],
                };
                /* eslint-enable prefer-rest-params */
            }
            return new RenderTexture(new BaseRenderTexture(options));
        };
        return RenderTexture;
    }(Texture));

    /**
     * Texture pool, used by FilterSystem and plugins.
     *
     * Stores collection of temporary pow2 or screen-sized renderTextures
     *
     * If you use custom RenderTexturePool for your filters, you can use methods
     * `getFilterTexture` and `returnFilterTexture` same as in
     * @memberof PIXI
     */
    var RenderTexturePool = /** @class */ (function () {
        /**
         * @param textureOptions - options that will be passed to BaseRenderTexture constructor
         * @param {PIXI.SCALE_MODES} [textureOptions.scaleMode] - See {@link PIXI.SCALE_MODES} for possible values.
         */
        function RenderTexturePool(textureOptions) {
            this.texturePool = {};
            this.textureOptions = textureOptions || {};
            this.enableFullScreen = false;
            this._pixelsWidth = 0;
            this._pixelsHeight = 0;
        }
        /**
         * Creates texture with params that were specified in pool constructor.
         * @param realWidth - Width of texture in pixels.
         * @param realHeight - Height of texture in pixels.
         * @param multisample - Number of samples of the framebuffer.
         */
        RenderTexturePool.prototype.createTexture = function (realWidth, realHeight, multisample) {
            if (multisample === void 0) { multisample = constants.MSAA_QUALITY.NONE; }
            var baseRenderTexture = new BaseRenderTexture(Object.assign({
                width: realWidth,
                height: realHeight,
                resolution: 1,
                multisample: multisample,
            }, this.textureOptions));
            return new RenderTexture(baseRenderTexture);
        };
        /**
         * Gets a Power-of-Two render texture or fullScreen texture
         * @param minWidth - The minimum width of the render texture.
         * @param minHeight - The minimum height of the render texture.
         * @param resolution - The resolution of the render texture.
         * @param multisample - Number of samples of the render texture.
         * @returns The new render texture.
         */
        RenderTexturePool.prototype.getOptimalTexture = function (minWidth, minHeight, resolution, multisample) {
            if (resolution === void 0) { resolution = 1; }
            if (multisample === void 0) { multisample = constants.MSAA_QUALITY.NONE; }
            var key;
            minWidth = Math.ceil((minWidth * resolution) - 1e-6);
            minHeight = Math.ceil((minHeight * resolution) - 1e-6);
            if (!this.enableFullScreen || minWidth !== this._pixelsWidth || minHeight !== this._pixelsHeight) {
                minWidth = utils.nextPow2(minWidth);
                minHeight = utils.nextPow2(minHeight);
                key = (((minWidth & 0xFFFF) << 16) | (minHeight & 0xFFFF)) >>> 0;
                if (multisample > 1) {
                    key += multisample * 0x100000000;
                }
            }
            else {
                key = multisample > 1 ? -multisample : -1;
            }
            if (!this.texturePool[key]) {
                this.texturePool[key] = [];
            }
            var renderTexture = this.texturePool[key].pop();
            if (!renderTexture) {
                renderTexture = this.createTexture(minWidth, minHeight, multisample);
            }
            renderTexture.filterPoolKey = key;
            renderTexture.setResolution(resolution);
            return renderTexture;
        };
        /**
         * Gets extra texture of the same size as input renderTexture
         *
         * `getFilterTexture(input, 0.5)` or `getFilterTexture(0.5, input)`
         * @param input - renderTexture from which size and resolution will be copied
         * @param resolution - override resolution of the renderTexture
         *  It overrides, it does not multiply
         * @param multisample - number of samples of the renderTexture
         */
        RenderTexturePool.prototype.getFilterTexture = function (input, resolution, multisample) {
            var filterTexture = this.getOptimalTexture(input.width, input.height, resolution || input.resolution, multisample || constants.MSAA_QUALITY.NONE);
            filterTexture.filterFrame = input.filterFrame;
            return filterTexture;
        };
        /**
         * Place a render texture back into the pool.
         * @param renderTexture - The renderTexture to free
         */
        RenderTexturePool.prototype.returnTexture = function (renderTexture) {
            var key = renderTexture.filterPoolKey;
            renderTexture.filterFrame = null;
            this.texturePool[key].push(renderTexture);
        };
        /**
         * Alias for returnTexture, to be compliant with FilterSystem interface.
         * @param renderTexture - The renderTexture to free
         */
        RenderTexturePool.prototype.returnFilterTexture = function (renderTexture) {
            this.returnTexture(renderTexture);
        };
        /**
         * Clears the pool.
         * @param destroyTextures - Destroy all stored textures.
         */
        RenderTexturePool.prototype.clear = function (destroyTextures) {
            destroyTextures = destroyTextures !== false;
            if (destroyTextures) {
                for (var i in this.texturePool) {
                    var textures = this.texturePool[i];
                    if (textures) {
                        for (var j = 0; j < textures.length; j++) {
                            textures[j].destroy(true);
                        }
                    }
                }
            }
            this.texturePool = {};
        };
        /**
         * If screen size was changed, drops all screen-sized textures,
         * sets new screen size, sets `enableFullScreen` to true
         *
         * Size is measured in pixels, `renderer.view` can be passed here, not `renderer.screen`
         * @param size - Initial size of screen.
         */
        RenderTexturePool.prototype.setScreenSize = function (size) {
            if (size.width === this._pixelsWidth
                && size.height === this._pixelsHeight) {
                return;
            }
            this.enableFullScreen = size.width > 0 && size.height > 0;
            for (var i in this.texturePool) {
                if (!(Number(i) < 0)) {
                    continue;
                }
                var textures = this.texturePool[i];
                if (textures) {
                    for (var j = 0; j < textures.length; j++) {
                        textures[j].destroy(true);
                    }
                }
                this.texturePool[i] = [];
            }
            this._pixelsWidth = size.width;
            this._pixelsHeight = size.height;
        };
        /**
         * Key that is used to store fullscreen renderTextures in a pool
         * @constant
         */
        RenderTexturePool.SCREEN_KEY = -1;
        return RenderTexturePool;
    }());

    /* eslint-disable max-len */
    /**
     * Holds the information for a single attribute structure required to render geometry.
     *
     * This does not contain the actual data, but instead has a buffer id that maps to a {@link PIXI.Buffer}
     * This can include anything from positions, uvs, normals, colors etc.
     * @memberof PIXI
     */
    var Attribute = /** @class */ (function () {
        /**
         * @param buffer - the id of the buffer that this attribute will look for
         * @param size - the size of the attribute. If you have 2 floats per vertex (eg position x and y) this would be 2.
         * @param normalized - should the data be normalized.
         * @param {PIXI.TYPES} [type=PIXI.TYPES.FLOAT] - what type of number is the attribute. Check {@link PIXI.TYPES} to see the ones available
         * @param [stride=0] - How far apart, in bytes, the start of each value is. (used for interleaving data)
         * @param [start=0] - How far into the array to start reading values (used for interleaving data)
         * @param [instance=false] - Whether the geometry is instanced.
         */
        function Attribute(buffer, size, normalized, type, stride, start, instance) {
            if (size === void 0) { size = 0; }
            if (normalized === void 0) { normalized = false; }
            if (type === void 0) { type = constants.TYPES.FLOAT; }
            this.buffer = buffer;
            this.size = size;
            this.normalized = normalized;
            this.type = type;
            this.stride = stride;
            this.start = start;
            this.instance = instance;
        }
        /** Destroys the Attribute. */
        Attribute.prototype.destroy = function () {
            this.buffer = null;
        };
        /**
         * Helper function that creates an Attribute based on the information provided
         * @param buffer - the id of the buffer that this attribute will look for
         * @param [size=0] - the size of the attribute. If you have 2 floats per vertex (eg position x and y) this would be 2
         * @param [normalized=false] - should the data be normalized.
         * @param [type=PIXI.TYPES.FLOAT] - what type of number is the attribute. Check {@link PIXI.TYPES} to see the ones available
         * @param [stride=0] - How far apart, in bytes, the start of each value is. (used for interleaving data)
         * @returns - A new {@link PIXI.Attribute} based on the information provided
         */
        Attribute.from = function (buffer, size, normalized, type, stride) {
            return new Attribute(buffer, size, normalized, type, stride);
        };
        return Attribute;
    }());

    var UID$4 = 0;
    /**
     * A wrapper for data so that it can be used and uploaded by WebGL
     * @memberof PIXI
     */
    var Buffer = /** @class */ (function () {
        /**
         * @param {PIXI.IArrayBuffer} data - the data to store in the buffer.
         * @param _static - `true` for static buffer
         * @param index - `true` for index buffer
         */
        function Buffer(data, _static, index) {
            if (_static === void 0) { _static = true; }
            if (index === void 0) { index = false; }
            this.data = (data || new Float32Array(1));
            this._glBuffers = {};
            this._updateID = 0;
            this.index = index;
            this.static = _static;
            this.id = UID$4++;
            this.disposeRunner = new runner.Runner('disposeBuffer');
        }
        // TODO could explore flagging only a partial upload?
        /**
         * Flags this buffer as requiring an upload to the GPU.
         * @param {PIXI.IArrayBuffer|number[]} [data] - the data to update in the buffer.
         */
        Buffer.prototype.update = function (data) {
            if (data instanceof Array) {
                data = new Float32Array(data);
            }
            this.data = data || this.data;
            this._updateID++;
        };
        /** Disposes WebGL resources that are connected to this geometry. */
        Buffer.prototype.dispose = function () {
            this.disposeRunner.emit(this, false);
        };
        /** Destroys the buffer. */
        Buffer.prototype.destroy = function () {
            this.dispose();
            this.data = null;
        };
        Object.defineProperty(Buffer.prototype, "index", {
            get: function () {
                return this.type === constants.BUFFER_TYPE.ELEMENT_ARRAY_BUFFER;
            },
            /**
             * Flags whether this is an index buffer.
             *
             * Index buffers are of type `ELEMENT_ARRAY_BUFFER`. Note that setting this property to false will make
             * the buffer of type `ARRAY_BUFFER`.
             *
             * For backwards compatibility.
             */
            set: function (value) {
                this.type = value ? constants.BUFFER_TYPE.ELEMENT_ARRAY_BUFFER : constants.BUFFER_TYPE.ARRAY_BUFFER;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Helper function that creates a buffer based on an array or TypedArray
         * @param {ArrayBufferView | number[]} data - the TypedArray that the buffer will store. If this is a regular Array it will be converted to a Float32Array.
         * @returns - A new Buffer based on the data provided.
         */
        Buffer.from = function (data) {
            if (data instanceof Array) {
                data = new Float32Array(data);
            }
            return new Buffer(data);
        };
        return Buffer;
    }());

    /* eslint-disable object-shorthand */
    var map$1 = {
        Float32Array: Float32Array,
        Uint32Array: Uint32Array,
        Int32Array: Int32Array,
        Uint8Array: Uint8Array,
    };
    function interleaveTypedArrays(arrays, sizes) {
        var outSize = 0;
        var stride = 0;
        var views = {};
        for (var i = 0; i < arrays.length; i++) {
            stride += sizes[i];
            outSize += arrays[i].length;
        }
        var buffer = new ArrayBuffer(outSize * 4);
        var out = null;
        var littleOffset = 0;
        for (var i = 0; i < arrays.length; i++) {
            var size = sizes[i];
            var array = arrays[i];
            var type = utils.getBufferType(array);
            if (!views[type]) {
                views[type] = new map$1[type](buffer);
            }
            out = views[type];
            for (var j = 0; j < array.length; j++) {
                var indexStart = ((j / size | 0) * stride) + littleOffset;
                var index = j % size;
                out[indexStart + index] = array[j];
            }
            littleOffset += size;
        }
        return new Float32Array(buffer);
    }

    var byteSizeMap$1 = { 5126: 4, 5123: 2, 5121: 1 };
    var UID$3 = 0;
    /* eslint-disable object-shorthand */
    var map = {
        Float32Array: Float32Array,
        Uint32Array: Uint32Array,
        Int32Array: Int32Array,
        Uint8Array: Uint8Array,
        Uint16Array: Uint16Array,
    };
    /* eslint-disable max-len */
    /**
     * The Geometry represents a model. It consists of two components:
     * - GeometryStyle - The structure of the model such as the attributes layout
     * - GeometryData - the data of the model - this consists of buffers.
     * This can include anything from positions, uvs, normals, colors etc.
     *
     * Geometry can be defined without passing in a style or data if required (thats how I prefer!)
     *
     * ```js
     * let geometry = new PIXI.Geometry();
     *
     * geometry.addAttribute('positions', [0, 0, 100, 0, 100, 100, 0, 100], 2);
     * geometry.addAttribute('uvs', [0,0,1,0,1,1,0,1],2)
     * geometry.addIndex([0,1,2,1,3,2])
     * ```
     * @memberof PIXI
     */
    var Geometry = /** @class */ (function () {
        /**
         * @param buffers - An array of buffers. optional.
         * @param attributes - Of the geometry, optional structure of the attributes layout
         */
        function Geometry(buffers, attributes) {
            if (buffers === void 0) { buffers = []; }
            if (attributes === void 0) { attributes = {}; }
            this.buffers = buffers;
            this.indexBuffer = null;
            this.attributes = attributes;
            this.glVertexArrayObjects = {};
            this.id = UID$3++;
            this.instanced = false;
            this.instanceCount = 1;
            this.disposeRunner = new runner.Runner('disposeGeometry');
            this.refCount = 0;
        }
        /**
         *
         * Adds an attribute to the geometry
         * Note: `stride` and `start` should be `undefined` if you dont know them, not 0!
         * @param id - the name of the attribute (matching up to a shader)
         * @param {PIXI.Buffer|number[]} buffer - the buffer that holds the data of the attribute . You can also provide an Array and a buffer will be created from it.
         * @param size - the size of the attribute. If you have 2 floats per vertex (eg position x and y) this would be 2
         * @param normalized - should the data be normalized.
         * @param [type=PIXI.TYPES.FLOAT] - what type of number is the attribute. Check {PIXI.TYPES} to see the ones available
         * @param [stride=0] - How far apart, in bytes, the start of each value is. (used for interleaving data)
         * @param [start=0] - How far into the array to start reading values (used for interleaving data)
         * @param instance - Instancing flag
         * @returns - Returns self, useful for chaining.
         */
        Geometry.prototype.addAttribute = function (id, buffer, size, normalized, type, stride, start, instance) {
            if (size === void 0) { size = 0; }
            if (normalized === void 0) { normalized = false; }
            if (instance === void 0) { instance = false; }
            if (!buffer) {
                throw new Error('You must pass a buffer when creating an attribute');
            }
            // check if this is a buffer!
            if (!(buffer instanceof Buffer)) {
                // its an array!
                if (buffer instanceof Array) {
                    buffer = new Float32Array(buffer);
                }
                buffer = new Buffer(buffer);
            }
            var ids = id.split('|');
            if (ids.length > 1) {
                for (var i = 0; i < ids.length; i++) {
                    this.addAttribute(ids[i], buffer, size, normalized, type);
                }
                return this;
            }
            var bufferIndex = this.buffers.indexOf(buffer);
            if (bufferIndex === -1) {
                this.buffers.push(buffer);
                bufferIndex = this.buffers.length - 1;
            }
            this.attributes[id] = new Attribute(bufferIndex, size, normalized, type, stride, start, instance);
            // assuming that if there is instanced data then this will be drawn with instancing!
            this.instanced = this.instanced || instance;
            return this;
        };
        /**
         * Returns the requested attribute.
         * @param id - The name of the attribute required
         * @returns - The attribute requested.
         */
        Geometry.prototype.getAttribute = function (id) {
            return this.attributes[id];
        };
        /**
         * Returns the requested buffer.
         * @param id - The name of the buffer required.
         * @returns - The buffer requested.
         */
        Geometry.prototype.getBuffer = function (id) {
            return this.buffers[this.getAttribute(id).buffer];
        };
        /**
         *
         * Adds an index buffer to the geometry
         * The index buffer contains integers, three for each triangle in the geometry, which reference the various attribute buffers (position, colour, UV coordinates, other UV coordinates, normal, ???). There is only ONE index buffer.
         * @param {PIXI.Buffer|number[]} [buffer] - The buffer that holds the data of the index buffer. You can also provide an Array and a buffer will be created from it.
         * @returns - Returns self, useful for chaining.
         */
        Geometry.prototype.addIndex = function (buffer) {
            if (!(buffer instanceof Buffer)) {
                // its an array!
                if (buffer instanceof Array) {
                    buffer = new Uint16Array(buffer);
                }
                buffer = new Buffer(buffer);
            }
            buffer.type = constants.BUFFER_TYPE.ELEMENT_ARRAY_BUFFER;
            this.indexBuffer = buffer;
            if (this.buffers.indexOf(buffer) === -1) {
                this.buffers.push(buffer);
            }
            return this;
        };
        /**
         * Returns the index buffer
         * @returns - The index buffer.
         */
        Geometry.prototype.getIndex = function () {
            return this.indexBuffer;
        };
        /**
         * This function modifies the structure so that all current attributes become interleaved into a single buffer
         * This can be useful if your model remains static as it offers a little performance boost
         * @returns - Returns self, useful for chaining.
         */
        Geometry.prototype.interleave = function () {
            // a simple check to see if buffers are already interleaved..
            if (this.buffers.length === 1 || (this.buffers.length === 2 && this.indexBuffer))
                { return this; }
            // assume already that no buffers are interleaved
            var arrays = [];
            var sizes = [];
            var interleavedBuffer = new Buffer();
            var i;
            for (i in this.attributes) {
                var attribute = this.attributes[i];
                var buffer = this.buffers[attribute.buffer];
                arrays.push(buffer.data);
                sizes.push((attribute.size * byteSizeMap$1[attribute.type]) / 4);
                attribute.buffer = 0;
            }
            interleavedBuffer.data = interleaveTypedArrays(arrays, sizes);
            for (i = 0; i < this.buffers.length; i++) {
                if (this.buffers[i] !== this.indexBuffer) {
                    this.buffers[i].destroy();
                }
            }
            this.buffers = [interleavedBuffer];
            if (this.indexBuffer) {
                this.buffers.push(this.indexBuffer);
            }
            return this;
        };
        /** Get the size of the geometries, in vertices. */
        Geometry.prototype.getSize = function () {
            for (var i in this.attributes) {
                var attribute = this.attributes[i];
                var buffer = this.buffers[attribute.buffer];
                return buffer.data.length / ((attribute.stride / 4) || attribute.size);
            }
            return 0;
        };
        /** Disposes WebGL resources that are connected to this geometry. */
        Geometry.prototype.dispose = function () {
            this.disposeRunner.emit(this, false);
        };
        /** Destroys the geometry. */
        Geometry.prototype.destroy = function () {
            this.dispose();
            this.buffers = null;
            this.indexBuffer = null;
            this.attributes = null;
        };
        /**
         * Returns a clone of the geometry.
         * @returns - A new clone of this geometry.
         */
        Geometry.prototype.clone = function () {
            var geometry = new Geometry();
            for (var i = 0; i < this.buffers.length; i++) {
                geometry.buffers[i] = new Buffer(this.buffers[i].data.slice(0));
            }
            for (var i in this.attributes) {
                var attrib = this.attributes[i];
                geometry.attributes[i] = new Attribute(attrib.buffer, attrib.size, attrib.normalized, attrib.type, attrib.stride, attrib.start, attrib.instance);
            }
            if (this.indexBuffer) {
                geometry.indexBuffer = geometry.buffers[this.buffers.indexOf(this.indexBuffer)];
                geometry.indexBuffer.type = constants.BUFFER_TYPE.ELEMENT_ARRAY_BUFFER;
            }
            return geometry;
        };
        /**
         * Merges an array of geometries into a new single one.
         *
         * Geometry attribute styles must match for this operation to work.
         * @param geometries - array of geometries to merge
         * @returns - Shiny new geometry!
         */
        Geometry.merge = function (geometries) {
            // todo add a geometry check!
            // also a size check.. cant be too big!]
            var geometryOut = new Geometry();
            var arrays = [];
            var sizes = [];
            var offsets = [];
            var geometry;
            // pass one.. get sizes..
            for (var i = 0; i < geometries.length; i++) {
                geometry = geometries[i];
                for (var j = 0; j < geometry.buffers.length; j++) {
                    sizes[j] = sizes[j] || 0;
                    sizes[j] += geometry.buffers[j].data.length;
                    offsets[j] = 0;
                }
            }
            // build the correct size arrays..
            for (var i = 0; i < geometry.buffers.length; i++) {
                // TODO types!
                arrays[i] = new map[utils.getBufferType(geometry.buffers[i].data)](sizes[i]);
                geometryOut.buffers[i] = new Buffer(arrays[i]);
            }
            // pass to set data..
            for (var i = 0; i < geometries.length; i++) {
                geometry = geometries[i];
                for (var j = 0; j < geometry.buffers.length; j++) {
                    arrays[j].set(geometry.buffers[j].data, offsets[j]);
                    offsets[j] += geometry.buffers[j].data.length;
                }
            }
            geometryOut.attributes = geometry.attributes;
            if (geometry.indexBuffer) {
                geometryOut.indexBuffer = geometryOut.buffers[geometry.buffers.indexOf(geometry.indexBuffer)];
                geometryOut.indexBuffer.type = constants.BUFFER_TYPE.ELEMENT_ARRAY_BUFFER;
                var offset = 0;
                var stride = 0;
                var offset2 = 0;
                var bufferIndexToCount = 0;
                // get a buffer
                for (var i = 0; i < geometry.buffers.length; i++) {
                    if (geometry.buffers[i] !== geometry.indexBuffer) {
                        bufferIndexToCount = i;
                        break;
                    }
                }
                // figure out the stride of one buffer..
                for (var i in geometry.attributes) {
                    var attribute = geometry.attributes[i];
                    if ((attribute.buffer | 0) === bufferIndexToCount) {
                        stride += ((attribute.size * byteSizeMap$1[attribute.type]) / 4);
                    }
                }
                // time to off set all indexes..
                for (var i = 0; i < geometries.length; i++) {
                    var indexBufferData = geometries[i].indexBuffer.data;
                    for (var j = 0; j < indexBufferData.length; j++) {
                        geometryOut.indexBuffer.data[j + offset2] += offset;
                    }
                    offset += geometries[i].buffers[bufferIndexToCount].data.length / (stride);
                    offset2 += indexBufferData.length;
                }
            }
            return geometryOut;
        };
        return Geometry;
    }());

    /**
     * Helper class to create a quad
     * @memberof PIXI
     */
    var Quad = /** @class */ (function (_super) {
        __extends(Quad, _super);
        function Quad() {
            var _this = _super.call(this) || this;
            _this.addAttribute('aVertexPosition', new Float32Array([
                0, 0,
                1, 0,
                1, 1,
                0, 1 ]))
                .addIndex([0, 1, 3, 2]);
            return _this;
        }
        return Quad;
    }(Geometry));

    /**
     * Helper class to create a quad with uvs like in v4
     * @memberof PIXI
     */
    var QuadUv = /** @class */ (function (_super) {
        __extends(QuadUv, _super);
        function QuadUv() {
            var _this = _super.call(this) || this;
            _this.vertices = new Float32Array([
                -1, -1,
                1, -1,
                1, 1,
                -1, 1 ]);
            _this.uvs = new Float32Array([
                0, 0,
                1, 0,
                1, 1,
                0, 1 ]);
            _this.vertexBuffer = new Buffer(_this.vertices);
            _this.uvBuffer = new Buffer(_this.uvs);
            _this.addAttribute('aVertexPosition', _this.vertexBuffer)
                .addAttribute('aTextureCoord', _this.uvBuffer)
                .addIndex([0, 1, 2, 0, 2, 3]);
            return _this;
        }
        /**
         * Maps two Rectangle to the quad.
         * @param targetTextureFrame - The first rectangle
         * @param destinationFrame - The second rectangle
         * @returns - Returns itself.
         */
        QuadUv.prototype.map = function (targetTextureFrame, destinationFrame) {
            var x = 0; // destinationFrame.x / targetTextureFrame.width;
            var y = 0; // destinationFrame.y / targetTextureFrame.height;
            this.uvs[0] = x;
            this.uvs[1] = y;
            this.uvs[2] = x + (destinationFrame.width / targetTextureFrame.width);
            this.uvs[3] = y;
            this.uvs[4] = x + (destinationFrame.width / targetTextureFrame.width);
            this.uvs[5] = y + (destinationFrame.height / targetTextureFrame.height);
            this.uvs[6] = x;
            this.uvs[7] = y + (destinationFrame.height / targetTextureFrame.height);
            x = destinationFrame.x;
            y = destinationFrame.y;
            this.vertices[0] = x;
            this.vertices[1] = y;
            this.vertices[2] = x + destinationFrame.width;
            this.vertices[3] = y;
            this.vertices[4] = x + destinationFrame.width;
            this.vertices[5] = y + destinationFrame.height;
            this.vertices[6] = x;
            this.vertices[7] = y + destinationFrame.height;
            this.invalidate();
            return this;
        };
        /**
         * Legacy upload method, just marks buffers dirty.
         * @returns - Returns itself.
         */
        QuadUv.prototype.invalidate = function () {
            this.vertexBuffer._updateID++;
            this.uvBuffer._updateID++;
            return this;
        };
        return QuadUv;
    }(Geometry));

    var UID$2 = 0;
    /**
     * Uniform group holds uniform map and some ID's for work
     *
     * `UniformGroup` has two modes:
     *
     * 1: Normal mode
     * Normal mode will upload the uniforms with individual function calls as required
     *
     * 2: Uniform buffer mode
     * This mode will treat the uniforms as a uniform buffer. You can pass in either a buffer that you manually handle, or
     * or a generic object that PixiJS will automatically map to a buffer for you.
     * For maximum benefits, make Ubo UniformGroups static, and only update them each frame.
     *
     * Rules of UBOs:
     * - UBOs only work with WebGL2, so make sure you have a fallback!
     * - Only floats are supported (including vec[2,3,4], mat[2,3,4])
     * - Samplers cannot be used in ubo's (a GPU limitation)
     * - You must ensure that the object you pass in exactly matches in the shader ubo structure.
     * Otherwise, weirdness will ensue!
     * - The name of the ubo object added to the group must match exactly the name of the ubo in the shader.
     *
     * ```
     * // ubo in shader:
     * uniform myCoolData { // declaring a ubo..
     * mat4 uCoolMatrix;
     * float uFloatyMcFloatFace
     *
     *
     * // a new uniform buffer object..
     * const myCoolData = new UniformBufferGroup({
     *   uCoolMatrix: new Matrix(),
     *   uFloatyMcFloatFace: 23,
     * }}
     *
     * // build a shader...
     * const shader = Shader.from(srcVert, srcFrag, {
     *   myCoolData // name matches the ubo name in the shader. will be processed accordingly.
     * })
     *
     *  ```
     * @memberof PIXI
     */
    var UniformGroup = /** @class */ (function () {
        /**
         * @param {object | Buffer} [uniforms] - Custom uniforms to use to augment the built-in ones. Or a pixi buffer.
         * @param isStatic - Uniforms wont be changed after creation.
         * @param isUbo - If true, will treat this uniform group as a uniform buffer object.
         */
        function UniformGroup(uniforms, isStatic, isUbo) {
            this.group = true;
            // lets generate this when the shader ?
            this.syncUniforms = {};
            this.dirtyId = 0;
            this.id = UID$2++;
            this.static = !!isStatic;
            this.ubo = !!isUbo;
            if (uniforms instanceof Buffer) {
                this.buffer = uniforms;
                this.buffer.type = constants.BUFFER_TYPE.UNIFORM_BUFFER;
                this.autoManage = false;
                this.ubo = true;
            }
            else {
                this.uniforms = uniforms;
                if (this.ubo) {
                    this.buffer = new Buffer(new Float32Array(1));
                    this.buffer.type = constants.BUFFER_TYPE.UNIFORM_BUFFER;
                    this.autoManage = true;
                }
            }
        }
        UniformGroup.prototype.update = function () {
            this.dirtyId++;
            if (!this.autoManage && this.buffer) {
                this.buffer.update();
            }
        };
        UniformGroup.prototype.add = function (name, uniforms, _static) {
            if (!this.ubo) {
                this.uniforms[name] = new UniformGroup(uniforms, _static);
            }
            else {
                // eslint-disable-next-line max-len
                throw new Error('[UniformGroup] uniform groups in ubo mode cannot be modified, or have uniform groups nested in them');
            }
        };
        UniformGroup.from = function (uniforms, _static, _ubo) {
            return new UniformGroup(uniforms, _static, _ubo);
        };
        /**
         * A short hand function for creating a static UBO UniformGroup.
         * @param uniforms - the ubo item
         * @param _static - should this be updated each time it is used? defaults to true here!
         */
        UniformGroup.uboFrom = function (uniforms, _static) {
            return new UniformGroup(uniforms, _static !== null && _static !== void 0 ? _static : true, true);
        };
        return UniformGroup;
    }());

    /**
     * System plugin to the renderer to manage filter states.
     * @ignore
     */
    var FilterState = /** @class */ (function () {
        function FilterState() {
            this.renderTexture = null;
            this.target = null;
            this.legacy = false;
            this.resolution = 1;
            this.multisample = constants.MSAA_QUALITY.NONE;
            // next three fields are created only for root
            // re-assigned for everything else
            this.sourceFrame = new math.Rectangle();
            this.destinationFrame = new math.Rectangle();
            this.bindingSourceFrame = new math.Rectangle();
            this.bindingDestinationFrame = new math.Rectangle();
            this.filters = [];
            this.transform = null;
        }
        /** Clears the state */
        FilterState.prototype.clear = function () {
            this.target = null;
            this.filters = null;
            this.renderTexture = null;
        };
        return FilterState;
    }());

    var tempPoints = [new math.Point(), new math.Point(), new math.Point(), new math.Point()];
    var tempMatrix$2 = new math.Matrix();
    /**
     * System plugin to the renderer to manage filters.
     *
     * ## Pipeline
     *
     * The FilterSystem executes the filtering pipeline by rendering the display-object into a texture, applying its
     * [filters]{@link PIXI.Filter} in series, and the last filter outputs into the final render-target.
     *
     * The filter-frame is the rectangle in world space being filtered, and those contents are mapped into
     * `(0, 0, filterFrame.width, filterFrame.height)` into the filter render-texture. The filter-frame is also called
     * the source-frame, as it is used to bind the filter render-textures. The last filter outputs to the `filterFrame`
     * in the final render-target.
     *
     * ## Usage
     *
     * {@link PIXI.Container#renderAdvanced} is an example of how to use the filter system. It is a 3 step process:
     *
     * **push**: Use {@link PIXI.FilterSystem#push} to push the set of filters to be applied on a filter-target.
     * **render**: Render the contents to be filtered using the renderer. The filter-system will only capture the contents
     *      inside the bounds of the filter-target. NOTE: Using {@link PIXI.Renderer#render} is
     *      illegal during an existing render cycle, and it may reset the filter system.
     * **pop**: Use {@link PIXI.FilterSystem#pop} to pop & execute the filters you initially pushed. It will apply them
     *      serially and output to the bounds of the filter-target.
     * @memberof PIXI
     */
    var FilterSystem = /** @class */ (function () {
        /**
         * @param renderer - The renderer this System works for.
         */
        function FilterSystem(renderer) {
            this.renderer = renderer;
            this.defaultFilterStack = [{}];
            this.texturePool = new RenderTexturePool();
            this.texturePool.setScreenSize(renderer.view);
            this.statePool = [];
            this.quad = new Quad();
            this.quadUv = new QuadUv();
            this.tempRect = new math.Rectangle();
            this.activeState = {};
            this.globalUniforms = new UniformGroup({
                outputFrame: new math.Rectangle(),
                inputSize: new Float32Array(4),
                inputPixel: new Float32Array(4),
                inputClamp: new Float32Array(4),
                resolution: 1,
                // legacy variables
                filterArea: new Float32Array(4),
                filterClamp: new Float32Array(4),
            }, true);
            this.forceClear = false;
            this.useMaxPadding = false;
        }
        /**
         * Pushes a set of filters to be applied later to the system. This will redirect further rendering into an
         * input render-texture for the rest of the filtering pipeline.
         * @param {PIXI.DisplayObject} target - The target of the filter to render.
         * @param filters - The filters to apply.
         */
        FilterSystem.prototype.push = function (target, filters) {
            var _a, _b;
            var renderer = this.renderer;
            var filterStack = this.defaultFilterStack;
            var state = this.statePool.pop() || new FilterState();
            var renderTextureSystem = this.renderer.renderTexture;
            var resolution = filters[0].resolution;
            var multisample = filters[0].multisample;
            var padding = filters[0].padding;
            var autoFit = filters[0].autoFit;
            // We don't know whether it's a legacy filter until it was bound for the first time,
            // therefore we have to assume that it is if legacy is undefined.
            var legacy = (_a = filters[0].legacy) !== null && _a !== void 0 ? _a : true;
            for (var i = 1; i < filters.length; i++) {
                var filter = filters[i];
                // let's use the lowest resolution
                resolution = Math.min(resolution, filter.resolution);
                // let's use the lowest number of samples
                multisample = Math.min(multisample, filter.multisample);
                // figure out the padding required for filters
                padding = this.useMaxPadding
                    // old behavior: use largest amount of padding!
                    ? Math.max(padding, filter.padding)
                    // new behavior: sum the padding
                    : padding + filter.padding;
                // only auto fit if all filters are autofit
                autoFit = autoFit && filter.autoFit;
                legacy = legacy || ((_b = filter.legacy) !== null && _b !== void 0 ? _b : true);
            }
            if (filterStack.length === 1) {
                this.defaultFilterStack[0].renderTexture = renderTextureSystem.current;
            }
            filterStack.push(state);
            state.resolution = resolution;
            state.multisample = multisample;
            state.legacy = legacy;
            state.target = target;
            state.sourceFrame.copyFrom(target.filterArea || target.getBounds(true));
            state.sourceFrame.pad(padding);
            var sourceFrameProjected = this.tempRect.copyFrom(renderTextureSystem.sourceFrame);
            // Project source frame into world space (if projection is applied)
            if (renderer.projection.transform) {
                this.transformAABB(tempMatrix$2.copyFrom(renderer.projection.transform).invert(), sourceFrameProjected);
            }
            if (autoFit) {
                state.sourceFrame.fit(sourceFrameProjected);
                if (state.sourceFrame.width <= 0 || state.sourceFrame.height <= 0) {
                    state.sourceFrame.width = 0;
                    state.sourceFrame.height = 0;
                }
            }
            else if (!state.sourceFrame.intersects(sourceFrameProjected)) {
                state.sourceFrame.width = 0;
                state.sourceFrame.height = 0;
            }
            // Round sourceFrame in screen space based on render-texture.
            this.roundFrame(state.sourceFrame, renderTextureSystem.current ? renderTextureSystem.current.resolution : renderer.resolution, renderTextureSystem.sourceFrame, renderTextureSystem.destinationFrame, renderer.projection.transform);
            state.renderTexture = this.getOptimalFilterTexture(state.sourceFrame.width, state.sourceFrame.height, resolution, multisample);
            state.filters = filters;
            state.destinationFrame.width = state.renderTexture.width;
            state.destinationFrame.height = state.renderTexture.height;
            var destinationFrame = this.tempRect;
            destinationFrame.x = 0;
            destinationFrame.y = 0;
            destinationFrame.width = state.sourceFrame.width;
            destinationFrame.height = state.sourceFrame.height;
            state.renderTexture.filterFrame = state.sourceFrame;
            state.bindingSourceFrame.copyFrom(renderTextureSystem.sourceFrame);
            state.bindingDestinationFrame.copyFrom(renderTextureSystem.destinationFrame);
            state.transform = renderer.projection.transform;
            renderer.projection.transform = null;
            renderTextureSystem.bind(state.renderTexture, state.sourceFrame, destinationFrame);
            renderer.framebuffer.clear(0, 0, 0, 0);
        };
        /** Pops off the filter and applies it. */
        FilterSystem.prototype.pop = function () {
            var filterStack = this.defaultFilterStack;
            var state = filterStack.pop();
            var filters = state.filters;
            this.activeState = state;
            var globalUniforms = this.globalUniforms.uniforms;
            globalUniforms.outputFrame = state.sourceFrame;
            globalUniforms.resolution = state.resolution;
            var inputSize = globalUniforms.inputSize;
            var inputPixel = globalUniforms.inputPixel;
            var inputClamp = globalUniforms.inputClamp;
            inputSize[0] = state.destinationFrame.width;
            inputSize[1] = state.destinationFrame.height;
            inputSize[2] = 1.0 / inputSize[0];
            inputSize[3] = 1.0 / inputSize[1];
            inputPixel[0] = Math.round(inputSize[0] * state.resolution);
            inputPixel[1] = Math.round(inputSize[1] * state.resolution);
            inputPixel[2] = 1.0 / inputPixel[0];
            inputPixel[3] = 1.0 / inputPixel[1];
            inputClamp[0] = 0.5 * inputPixel[2];
            inputClamp[1] = 0.5 * inputPixel[3];
            inputClamp[2] = (state.sourceFrame.width * inputSize[2]) - (0.5 * inputPixel[2]);
            inputClamp[3] = (state.sourceFrame.height * inputSize[3]) - (0.5 * inputPixel[3]);
            // only update the rect if its legacy..
            if (state.legacy) {
                var filterArea = globalUniforms.filterArea;
                filterArea[0] = state.destinationFrame.width;
                filterArea[1] = state.destinationFrame.height;
                filterArea[2] = state.sourceFrame.x;
                filterArea[3] = state.sourceFrame.y;
                globalUniforms.filterClamp = globalUniforms.inputClamp;
            }
            this.globalUniforms.update();
            var lastState = filterStack[filterStack.length - 1];
            this.renderer.framebuffer.blit();
            if (filters.length === 1) {
                filters[0].apply(this, state.renderTexture, lastState.renderTexture, constants.CLEAR_MODES.BLEND, state);
                this.returnFilterTexture(state.renderTexture);
            }
            else {
                var flip = state.renderTexture;
                var flop = this.getOptimalFilterTexture(flip.width, flip.height, state.resolution);
                flop.filterFrame = flip.filterFrame;
                var i = 0;
                for (i = 0; i < filters.length - 1; ++i) {
                    if (i === 1 && state.multisample > 1) {
                        flop = this.getOptimalFilterTexture(flip.width, flip.height, state.resolution);
                        flop.filterFrame = flip.filterFrame;
                    }
                    filters[i].apply(this, flip, flop, constants.CLEAR_MODES.CLEAR, state);
                    var t = flip;
                    flip = flop;
                    flop = t;
                }
                filters[i].apply(this, flip, lastState.renderTexture, constants.CLEAR_MODES.BLEND, state);
                if (i > 1 && state.multisample > 1) {
                    this.returnFilterTexture(state.renderTexture);
                }
                this.returnFilterTexture(flip);
                this.returnFilterTexture(flop);
            }
            // lastState.renderTexture is blitted when lastState is popped
            state.clear();
            this.statePool.push(state);
        };
        /**
         * Binds a renderTexture with corresponding `filterFrame`, clears it if mode corresponds.
         * @param filterTexture - renderTexture to bind, should belong to filter pool or filter stack
         * @param clearMode - clearMode, by default its CLEAR/YES. See {@link PIXI.CLEAR_MODES}
         */
        FilterSystem.prototype.bindAndClear = function (filterTexture, clearMode) {
            if (clearMode === void 0) { clearMode = constants.CLEAR_MODES.CLEAR; }
            var _a = this.renderer, renderTextureSystem = _a.renderTexture, stateSystem = _a.state;
            if (filterTexture === this.defaultFilterStack[this.defaultFilterStack.length - 1].renderTexture) {
                // Restore projection transform if rendering into the output render-target.
                this.renderer.projection.transform = this.activeState.transform;
            }
            else {
                // Prevent projection within filtering pipeline.
                this.renderer.projection.transform = null;
            }
            if (filterTexture && filterTexture.filterFrame) {
                var destinationFrame = this.tempRect;
                destinationFrame.x = 0;
                destinationFrame.y = 0;
                destinationFrame.width = filterTexture.filterFrame.width;
                destinationFrame.height = filterTexture.filterFrame.height;
                renderTextureSystem.bind(filterTexture, filterTexture.filterFrame, destinationFrame);
            }
            else if (filterTexture !== this.defaultFilterStack[this.defaultFilterStack.length - 1].renderTexture) {
                renderTextureSystem.bind(filterTexture);
            }
            else {
                // Restore binding for output render-target.
                this.renderer.renderTexture.bind(filterTexture, this.activeState.bindingSourceFrame, this.activeState.bindingDestinationFrame);
            }
            // Clear the texture in BLIT mode if blending is disabled or the forceClear flag is set. The blending
            // is stored in the 0th bit of the state.
            var autoClear = (stateSystem.stateId & 1) || this.forceClear;
            if (clearMode === constants.CLEAR_MODES.CLEAR
                || (clearMode === constants.CLEAR_MODES.BLIT && autoClear)) {
                // Use framebuffer.clear because we want to clear the whole filter texture, not just the filtering
                // area over which the shaders are run. This is because filters may sampling outside of it (e.g. blur)
                // instead of clamping their arithmetic.
                this.renderer.framebuffer.clear(0, 0, 0, 0);
            }
        };
        /**
         * Draws a filter using the default rendering process.
         *
         * This should be called only by {@link Filter#apply}.
         * @param filter - The filter to draw.
         * @param input - The input render target.
         * @param output - The target to output to.
         * @param clearMode - Should the output be cleared before rendering to it
         */
        FilterSystem.prototype.applyFilter = function (filter, input, output, clearMode) {
            var renderer = this.renderer;
            // Set state before binding, so bindAndClear gets the blend mode.
            renderer.state.set(filter.state);
            this.bindAndClear(output, clearMode);
            // set the uniforms..
            filter.uniforms.uSampler = input;
            filter.uniforms.filterGlobals = this.globalUniforms;
            // TODO make it so that the order of this does not matter..
            // because it does at the moment cos of global uniforms.
            // they need to get resynced
            renderer.shader.bind(filter);
            // check to see if the filter is a legacy one..
            filter.legacy = !!filter.program.attributeData.aTextureCoord;
            if (filter.legacy) {
                this.quadUv.map(input._frame, input.filterFrame);
                renderer.geometry.bind(this.quadUv);
                renderer.geometry.draw(constants.DRAW_MODES.TRIANGLES);
            }
            else {
                renderer.geometry.bind(this.quad);
                renderer.geometry.draw(constants.DRAW_MODES.TRIANGLE_STRIP);
            }
        };
        /**
         * Multiply _input normalized coordinates_ to this matrix to get _sprite texture normalized coordinates_.
         *
         * Use `outputMatrix * vTextureCoord` in the shader.
         * @param outputMatrix - The matrix to output to.
         * @param {PIXI.Sprite} sprite - The sprite to map to.
         * @returns The mapped matrix.
         */
        FilterSystem.prototype.calculateSpriteMatrix = function (outputMatrix, sprite) {
            var _a = this.activeState, sourceFrame = _a.sourceFrame, destinationFrame = _a.destinationFrame;
            var orig = sprite._texture.orig;
            var mappedMatrix = outputMatrix.set(destinationFrame.width, 0, 0, destinationFrame.height, sourceFrame.x, sourceFrame.y);
            var worldTransform = sprite.worldTransform.copyTo(math.Matrix.TEMP_MATRIX);
            worldTransform.invert();
            mappedMatrix.prepend(worldTransform);
            mappedMatrix.scale(1.0 / orig.width, 1.0 / orig.height);
            mappedMatrix.translate(sprite.anchor.x, sprite.anchor.y);
            return mappedMatrix;
        };
        /** Destroys this Filter System. */
        FilterSystem.prototype.destroy = function () {
            this.renderer = null;
            // Those textures has to be destroyed by RenderTextureSystem or FramebufferSystem
            this.texturePool.clear(false);
        };
        /**
         * Gets a Power-of-Two render texture or fullScreen texture
         * @param minWidth - The minimum width of the render texture in real pixels.
         * @param minHeight - The minimum height of the render texture in real pixels.
         * @param resolution - The resolution of the render texture.
         * @param multisample - Number of samples of the render texture.
         * @returns - The new render texture.
         */
        FilterSystem.prototype.getOptimalFilterTexture = function (minWidth, minHeight, resolution, multisample) {
            if (resolution === void 0) { resolution = 1; }
            if (multisample === void 0) { multisample = constants.MSAA_QUALITY.NONE; }
            return this.texturePool.getOptimalTexture(minWidth, minHeight, resolution, multisample);
        };
        /**
         * Gets extra render texture to use inside current filter
         * To be compliant with older filters, you can use params in any order
         * @param input - renderTexture from which size and resolution will be copied
         * @param resolution - override resolution of the renderTexture
         * @param multisample - number of samples of the renderTexture
         */
        FilterSystem.prototype.getFilterTexture = function (input, resolution, multisample) {
            if (typeof input === 'number') {
                var swap = input;
                input = resolution;
                resolution = swap;
            }
            input = input || this.activeState.renderTexture;
            var filterTexture = this.texturePool.getOptimalTexture(input.width, input.height, resolution || input.resolution, multisample || constants.MSAA_QUALITY.NONE);
            filterTexture.filterFrame = input.filterFrame;
            return filterTexture;
        };
        /**
         * Frees a render texture back into the pool.
         * @param renderTexture - The renderTarget to free
         */
        FilterSystem.prototype.returnFilterTexture = function (renderTexture) {
            this.texturePool.returnTexture(renderTexture);
        };
        /** Empties the texture pool. */
        FilterSystem.prototype.emptyPool = function () {
            this.texturePool.clear(true);
        };
        /** Calls `texturePool.resize()`, affects fullScreen renderTextures. */
        FilterSystem.prototype.resize = function () {
            this.texturePool.setScreenSize(this.renderer.view);
        };
        /**
         * @param matrix - first param
         * @param rect - second param
         */
        FilterSystem.prototype.transformAABB = function (matrix, rect) {
            var lt = tempPoints[0];
            var lb = tempPoints[1];
            var rt = tempPoints[2];
            var rb = tempPoints[3];
            lt.set(rect.left, rect.top);
            lb.set(rect.left, rect.bottom);
            rt.set(rect.right, rect.top);
            rb.set(rect.right, rect.bottom);
            matrix.apply(lt, lt);
            matrix.apply(lb, lb);
            matrix.apply(rt, rt);
            matrix.apply(rb, rb);
            var x0 = Math.min(lt.x, lb.x, rt.x, rb.x);
            var y0 = Math.min(lt.y, lb.y, rt.y, rb.y);
            var x1 = Math.max(lt.x, lb.x, rt.x, rb.x);
            var y1 = Math.max(lt.y, lb.y, rt.y, rb.y);
            rect.x = x0;
            rect.y = y0;
            rect.width = x1 - x0;
            rect.height = y1 - y0;
        };
        FilterSystem.prototype.roundFrame = function (frame, resolution, bindingSourceFrame, bindingDestinationFrame, transform) {
            if (frame.width <= 0 || frame.height <= 0 || bindingSourceFrame.width <= 0 || bindingSourceFrame.height <= 0) {
                return;
            }
            if (transform) {
                var a = transform.a, b = transform.b, c = transform.c, d = transform.d;
                // Skip if skew/rotation present in matrix, except for multiple of 90?? rotation. If rotation
                // is a multiple of 90??, then either pair of (b,c) or (a,d) will be (0,0).
                if ((Math.abs(b) > 1e-4 || Math.abs(c) > 1e-4)
                    && (Math.abs(a) > 1e-4 || Math.abs(d) > 1e-4)) {
                    return;
                }
            }
            transform = transform ? tempMatrix$2.copyFrom(transform) : tempMatrix$2.identity();
            // Get forward transform from world space to screen space
            transform
                .translate(-bindingSourceFrame.x, -bindingSourceFrame.y)
                .scale(bindingDestinationFrame.width / bindingSourceFrame.width, bindingDestinationFrame.height / bindingSourceFrame.height)
                .translate(bindingDestinationFrame.x, bindingDestinationFrame.y);
            // Convert frame to screen space
            this.transformAABB(transform, frame);
            // Round frame in screen space
            frame.ceil(resolution);
            // Project back into world space.
            this.transformAABB(transform.invert(), frame);
        };
        return FilterSystem;
    }());

    /**
     * Base for a common object renderer that can be used as a
     * system renderer plugin.
     * @memberof PIXI
     */
    var ObjectRenderer = /** @class */ (function () {
        /**
         * @param renderer - The renderer this manager works for.
         */
        function ObjectRenderer(renderer) {
            this.renderer = renderer;
        }
        /** Stub method that should be used to empty the current batch by rendering objects now. */
        ObjectRenderer.prototype.flush = function () {
            // flush!
        };
        /** Generic destruction method that frees all resources. This should be called by subclasses. */
        ObjectRenderer.prototype.destroy = function () {
            this.renderer = null;
        };
        /**
         * Stub method that initializes any state required before
         * rendering starts. It is different from the `prerender`
         * signal, which occurs every frame, in that it is called
         * whenever an object requests _this_ renderer specifically.
         */
        ObjectRenderer.prototype.start = function () {
            // set the shader..
        };
        /** Stops the renderer. It should free up any state and become dormant. */
        ObjectRenderer.prototype.stop = function () {
            this.flush();
        };
        /**
         * Keeps the object to render. It doesn't have to be
         * rendered immediately.
         * @param {PIXI.DisplayObject} _object - The object to render.
         */
        ObjectRenderer.prototype.render = function (_object) {
            // render the object
        };
        return ObjectRenderer;
    }());

    /**
     * System plugin to the renderer to manage batching.
     * @memberof PIXI
     */
    var BatchSystem = /** @class */ (function () {
        /**
         * @param renderer - The renderer this System works for.
         */
        function BatchSystem(renderer) {
            this.renderer = renderer;
            this.emptyRenderer = new ObjectRenderer(renderer);
            this.currentRenderer = this.emptyRenderer;
        }
        /**
         * Changes the current renderer to the one given in parameter
         * @param objectRenderer - The object renderer to use.
         */
        BatchSystem.prototype.setObjectRenderer = function (objectRenderer) {
            if (this.currentRenderer === objectRenderer) {
                return;
            }
            this.currentRenderer.stop();
            this.currentRenderer = objectRenderer;
            this.currentRenderer.start();
        };
        /**
         * This should be called if you wish to do some custom rendering
         * It will basically render anything that may be batched up such as sprites
         */
        BatchSystem.prototype.flush = function () {
            this.setObjectRenderer(this.emptyRenderer);
        };
        /** Reset the system to an empty renderer */
        BatchSystem.prototype.reset = function () {
            this.setObjectRenderer(this.emptyRenderer);
        };
        /**
         * Handy function for batch renderers: copies bound textures in first maxTextures locations to array
         * sets actual _batchLocation for them
         * @param arr - arr copy destination
         * @param maxTextures - number of copied elements
         */
        BatchSystem.prototype.copyBoundTextures = function (arr, maxTextures) {
            var boundTextures = this.renderer.texture.boundTextures;
            for (var i = maxTextures - 1; i >= 0; --i) {
                arr[i] = boundTextures[i] || null;
                if (arr[i]) {
                    arr[i]._batchLocation = i;
                }
            }
        };
        /**
         * Assigns batch locations to textures in array based on boundTextures state.
         * All textures in texArray should have `_batchEnabled = _batchId`,
         * and their count should be less than `maxTextures`.
         * @param texArray - textures to bound
         * @param boundTextures - current state of bound textures
         * @param batchId - marker for _batchEnabled param of textures in texArray
         * @param maxTextures - number of texture locations to manipulate
         */
        BatchSystem.prototype.boundArray = function (texArray, boundTextures, batchId, maxTextures) {
            var elements = texArray.elements, ids = texArray.ids, count = texArray.count;
            var j = 0;
            for (var i = 0; i < count; i++) {
                var tex = elements[i];
                var loc = tex._batchLocation;
                if (loc >= 0 && loc < maxTextures
                    && boundTextures[loc] === tex) {
                    ids[i] = loc;
                    continue;
                }
                while (j < maxTextures) {
                    var bound = boundTextures[j];
                    if (bound && bound._batchEnabled === batchId
                        && bound._batchLocation === j) {
                        j++;
                        continue;
                    }
                    ids[i] = j;
                    tex._batchLocation = j;
                    boundTextures[j] = tex;
                    break;
                }
            }
        };
        /**
         * @ignore
         */
        BatchSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return BatchSystem;
    }());

    var CONTEXT_UID_COUNTER = 0;
    /**
     * System plugin to the renderer to manage the context.
     * @memberof PIXI
     */
    var ContextSystem = /** @class */ (function () {
        /** @param renderer - The renderer this System works for. */
        function ContextSystem(renderer) {
            this.renderer = renderer;
            this.webGLVersion = 1;
            this.extensions = {};
            this.supports = {
                uint32Indices: false,
            };
            // Bind functions
            this.handleContextLost = this.handleContextLost.bind(this);
            this.handleContextRestored = this.handleContextRestored.bind(this);
            renderer.view.addEventListener('webglcontextlost', this.handleContextLost, false);
            renderer.view.addEventListener('webglcontextrestored', this.handleContextRestored, false);
        }
        Object.defineProperty(ContextSystem.prototype, "isLost", {
            /**
             * `true` if the context is lost
             * @readonly
             */
            get: function () {
                return (!this.gl || this.gl.isContextLost());
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Handles the context change event.
         * @param {WebGLRenderingContext} gl - New WebGL context.
         */
        ContextSystem.prototype.contextChange = function (gl) {
            this.gl = gl;
            this.renderer.gl = gl;
            this.renderer.CONTEXT_UID = CONTEXT_UID_COUNTER++;
            // restore a context if it was previously lost
            if (gl.isContextLost() && gl.getExtension('WEBGL_lose_context')) {
                gl.getExtension('WEBGL_lose_context').restoreContext();
            }
        };
        /**
         * Initializes the context.
         * @protected
         * @param {WebGLRenderingContext} gl - WebGL context
         */
        ContextSystem.prototype.initFromContext = function (gl) {
            this.gl = gl;
            this.validateContext(gl);
            this.renderer.gl = gl;
            this.renderer.CONTEXT_UID = CONTEXT_UID_COUNTER++;
            this.renderer.runners.contextChange.emit(gl);
        };
        /**
         * Initialize from context options
         * @protected
         * @see https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement/getContext
         * @param {object} options - context attributes
         */
        ContextSystem.prototype.initFromOptions = function (options) {
            var gl = this.createContext(this.renderer.view, options);
            this.initFromContext(gl);
        };
        /**
         * Helper class to create a WebGL Context
         * @param canvas - the canvas element that we will get the context from
         * @param options - An options object that gets passed in to the canvas element containing the
         *    context attributes
         * @see https://developer.mozilla.org/en/docs/Web/API/HTMLCanvasElement/getContext
         * @returns {WebGLRenderingContext} the WebGL context
         */
        ContextSystem.prototype.createContext = function (canvas, options) {
            var gl;
            if (settings.settings.PREFER_ENV >= constants.ENV.WEBGL2) {
                gl = canvas.getContext('webgl2', options);
            }
            if (gl) {
                this.webGLVersion = 2;
            }
            else {
                this.webGLVersion = 1;
                gl = canvas.getContext('webgl', options) || canvas.getContext('experimental-webgl', options);
                if (!gl) {
                    // fail, not able to get a context
                    throw new Error('This browser does not support WebGL. Try using the canvas renderer');
                }
            }
            this.gl = gl;
            this.getExtensions();
            return this.gl;
        };
        /** Auto-populate the {@link PIXI.ContextSystem.extensions extensions}. */
        ContextSystem.prototype.getExtensions = function () {
            // time to set up default extensions that Pixi uses.
            var gl = this.gl;
            var common = {
                anisotropicFiltering: gl.getExtension('EXT_texture_filter_anisotropic'),
                floatTextureLinear: gl.getExtension('OES_texture_float_linear'),
                s3tc: gl.getExtension('WEBGL_compressed_texture_s3tc'),
                s3tc_sRGB: gl.getExtension('WEBGL_compressed_texture_s3tc_srgb'),
                etc: gl.getExtension('WEBGL_compressed_texture_etc'),
                etc1: gl.getExtension('WEBGL_compressed_texture_etc1'),
                pvrtc: gl.getExtension('WEBGL_compressed_texture_pvrtc')
                    || gl.getExtension('WEBKIT_WEBGL_compressed_texture_pvrtc'),
                atc: gl.getExtension('WEBGL_compressed_texture_atc'),
                astc: gl.getExtension('WEBGL_compressed_texture_astc')
            };
            if (this.webGLVersion === 1) {
                Object.assign(this.extensions, common, {
                    drawBuffers: gl.getExtension('WEBGL_draw_buffers'),
                    depthTexture: gl.getExtension('WEBGL_depth_texture'),
                    loseContext: gl.getExtension('WEBGL_lose_context'),
                    vertexArrayObject: gl.getExtension('OES_vertex_array_object')
                        || gl.getExtension('MOZ_OES_vertex_array_object')
                        || gl.getExtension('WEBKIT_OES_vertex_array_object'),
                    uint32ElementIndex: gl.getExtension('OES_element_index_uint'),
                    // Floats and half-floats
                    floatTexture: gl.getExtension('OES_texture_float'),
                    floatTextureLinear: gl.getExtension('OES_texture_float_linear'),
                    textureHalfFloat: gl.getExtension('OES_texture_half_float'),
                    textureHalfFloatLinear: gl.getExtension('OES_texture_half_float_linear'),
                });
            }
            else if (this.webGLVersion === 2) {
                Object.assign(this.extensions, common, {
                    // Floats and half-floats
                    colorBufferFloat: gl.getExtension('EXT_color_buffer_float')
                });
            }
        };
        /**
         * Handles a lost webgl context
         * @param {WebGLContextEvent} event - The context lost event.
         */
        ContextSystem.prototype.handleContextLost = function (event) {
            event.preventDefault();
        };
        /** Handles a restored webgl context. */
        ContextSystem.prototype.handleContextRestored = function () {
            this.renderer.runners.contextChange.emit(this.gl);
        };
        ContextSystem.prototype.destroy = function () {
            var view = this.renderer.view;
            this.renderer = null;
            // remove listeners
            view.removeEventListener('webglcontextlost', this.handleContextLost);
            view.removeEventListener('webglcontextrestored', this.handleContextRestored);
            this.gl.useProgram(null);
            if (this.extensions.loseContext) {
                this.extensions.loseContext.loseContext();
            }
        };
        /** Handle the post-render runner event. */
        ContextSystem.prototype.postrender = function () {
            if (this.renderer.renderingToScreen) {
                this.gl.flush();
            }
        };
        /**
         * Validate context.
         * @param {WebGLRenderingContext} gl - Render context.
         */
        ContextSystem.prototype.validateContext = function (gl) {
            var attributes = gl.getContextAttributes();
            var isWebGl2 = 'WebGL2RenderingContext' in globalThis && gl instanceof globalThis.WebGL2RenderingContext;
            if (isWebGl2) {
                this.webGLVersion = 2;
            }
            // this is going to be fairly simple for now.. but at least we have room to grow!
            if (attributes && !attributes.stencil) {
                /* eslint-disable max-len, no-console */
                console.warn('Provided WebGL context does not have a stencil buffer, masks may not render correctly');
                /* eslint-enable max-len, no-console */
            }
            var hasuint32 = isWebGl2 || !!gl.getExtension('OES_element_index_uint');
            this.supports.uint32Indices = hasuint32;
            if (!hasuint32) {
                /* eslint-disable max-len, no-console */
                console.warn('Provided WebGL context does not support 32 index buffer, complex graphics may not render correctly');
                /* eslint-enable max-len, no-console */
            }
        };
        return ContextSystem;
    }());

    /**
     * Internal framebuffer for WebGL context.
     * @memberof PIXI
     */
    var GLFramebuffer = /** @class */ (function () {
        function GLFramebuffer(framebuffer) {
            this.framebuffer = framebuffer;
            this.stencil = null;
            this.dirtyId = -1;
            this.dirtyFormat = -1;
            this.dirtySize = -1;
            this.multisample = constants.MSAA_QUALITY.NONE;
            this.msaaBuffer = null;
            this.blitFramebuffer = null;
            this.mipLevel = 0;
        }
        return GLFramebuffer;
    }());

    var tempRectangle = new math.Rectangle();
    /**
     * System plugin to the renderer to manage framebuffers.
     * @memberof PIXI
     */
    var FramebufferSystem = /** @class */ (function () {
        /**
         * @param renderer - The renderer this System works for.
         */
        function FramebufferSystem(renderer) {
            this.renderer = renderer;
            this.managedFramebuffers = [];
            this.unknownFramebuffer = new Framebuffer(10, 10);
            this.msaaSamples = null;
        }
        /** Sets up the renderer context and necessary buffers. */
        FramebufferSystem.prototype.contextChange = function () {
            var gl = this.gl = this.renderer.gl;
            this.CONTEXT_UID = this.renderer.CONTEXT_UID;
            this.current = this.unknownFramebuffer;
            this.viewport = new math.Rectangle();
            this.hasMRT = true;
            this.writeDepthTexture = true;
            this.disposeAll(true);
            // webgl2
            if (this.renderer.context.webGLVersion === 1) {
                // webgl 1!
                var nativeDrawBuffersExtension_1 = this.renderer.context.extensions.drawBuffers;
                var nativeDepthTextureExtension = this.renderer.context.extensions.depthTexture;
                if (settings.settings.PREFER_ENV === constants.ENV.WEBGL_LEGACY) {
                    nativeDrawBuffersExtension_1 = null;
                    nativeDepthTextureExtension = null;
                }
                if (nativeDrawBuffersExtension_1) {
                    gl.drawBuffers = function (activeTextures) {
                        return nativeDrawBuffersExtension_1.drawBuffersWEBGL(activeTextures);
                    };
                }
                else {
                    this.hasMRT = false;
                    gl.drawBuffers = function () {
                        // empty
                    };
                }
                if (!nativeDepthTextureExtension) {
                    this.writeDepthTexture = false;
                }
            }
            else {
                // WebGL2
                // cache possible MSAA samples
                this.msaaSamples = gl.getInternalformatParameter(gl.RENDERBUFFER, gl.RGBA8, gl.SAMPLES);
            }
        };
        /**
         * Bind a framebuffer.
         * @param framebuffer
         * @param frame - frame, default is framebuffer size
         * @param mipLevel - optional mip level to set on the framebuffer - defaults to 0
         */
        FramebufferSystem.prototype.bind = function (framebuffer, frame, mipLevel) {
            if (mipLevel === void 0) { mipLevel = 0; }
            var gl = this.gl;
            if (framebuffer) {
                // TODO caching layer!
                var fbo = framebuffer.glFramebuffers[this.CONTEXT_UID] || this.initFramebuffer(framebuffer);
                if (this.current !== framebuffer) {
                    this.current = framebuffer;
                    gl.bindFramebuffer(gl.FRAMEBUFFER, fbo.framebuffer);
                }
                // make sure all textures are unbound..
                if (fbo.mipLevel !== mipLevel) {
                    framebuffer.dirtyId++;
                    framebuffer.dirtyFormat++;
                    fbo.mipLevel = mipLevel;
                }
                // now check for updates...
                if (fbo.dirtyId !== framebuffer.dirtyId) {
                    fbo.dirtyId = framebuffer.dirtyId;
                    if (fbo.dirtyFormat !== framebuffer.dirtyFormat) {
                        fbo.dirtyFormat = framebuffer.dirtyFormat;
                        fbo.dirtySize = framebuffer.dirtySize;
                        this.updateFramebuffer(framebuffer, mipLevel);
                    }
                    else if (fbo.dirtySize !== framebuffer.dirtySize) {
                        fbo.dirtySize = framebuffer.dirtySize;
                        this.resizeFramebuffer(framebuffer);
                    }
                }
                for (var i = 0; i < framebuffer.colorTextures.length; i++) {
                    var tex = framebuffer.colorTextures[i];
                    this.renderer.texture.unbind(tex.parentTextureArray || tex);
                }
                if (framebuffer.depthTexture) {
                    this.renderer.texture.unbind(framebuffer.depthTexture);
                }
                if (frame) {
                    var mipWidth = (frame.width >> mipLevel);
                    var mipHeight = (frame.height >> mipLevel);
                    var scale = mipWidth / frame.width;
                    this.setViewport(frame.x * scale, frame.y * scale, mipWidth, mipHeight);
                }
                else {
                    var mipWidth = (framebuffer.width >> mipLevel);
                    var mipHeight = (framebuffer.height >> mipLevel);
                    this.setViewport(0, 0, mipWidth, mipHeight);
                }
            }
            else {
                if (this.current) {
                    this.current = null;
                    gl.bindFramebuffer(gl.FRAMEBUFFER, null);
                }
                if (frame) {
                    this.setViewport(frame.x, frame.y, frame.width, frame.height);
                }
                else {
                    this.setViewport(0, 0, this.renderer.width, this.renderer.height);
                }
            }
        };
        /**
         * Set the WebGLRenderingContext's viewport.
         * @param x - X position of viewport
         * @param y - Y position of viewport
         * @param width - Width of viewport
         * @param height - Height of viewport
         */
        FramebufferSystem.prototype.setViewport = function (x, y, width, height) {
            var v = this.viewport;
            x = Math.round(x);
            y = Math.round(y);
            width = Math.round(width);
            height = Math.round(height);
            if (v.width !== width || v.height !== height || v.x !== x || v.y !== y) {
                v.x = x;
                v.y = y;
                v.width = width;
                v.height = height;
                this.gl.viewport(x, y, width, height);
            }
        };
        Object.defineProperty(FramebufferSystem.prototype, "size", {
            /**
             * Get the size of the current width and height. Returns object with `width` and `height` values.
             * @readonly
             */
            get: function () {
                if (this.current) {
                    // TODO store temp
                    return { x: 0, y: 0, width: this.current.width, height: this.current.height };
                }
                return { x: 0, y: 0, width: this.renderer.width, height: this.renderer.height };
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Clear the color of the context
         * @param r - Red value from 0 to 1
         * @param g - Green value from 0 to 1
         * @param b - Blue value from 0 to 1
         * @param a - Alpha value from 0 to 1
         * @param {PIXI.BUFFER_BITS} [mask=BUFFER_BITS.COLOR | BUFFER_BITS.DEPTH] - Bitwise OR of masks
         *  that indicate the buffers to be cleared, by default COLOR and DEPTH buffers.
         */
        FramebufferSystem.prototype.clear = function (r, g, b, a, mask) {
            if (mask === void 0) { mask = constants.BUFFER_BITS.COLOR | constants.BUFFER_BITS.DEPTH; }
            var gl = this.gl;
            // TODO clear color can be set only one right?
            gl.clearColor(r, g, b, a);
            gl.clear(mask);
        };
        /**
         * Initialize framebuffer for this context
         * @protected
         * @param framebuffer
         * @returns - created GLFramebuffer
         */
        FramebufferSystem.prototype.initFramebuffer = function (framebuffer) {
            var gl = this.gl;
            var fbo = new GLFramebuffer(gl.createFramebuffer());
            fbo.multisample = this.detectSamples(framebuffer.multisample);
            framebuffer.glFramebuffers[this.CONTEXT_UID] = fbo;
            this.managedFramebuffers.push(framebuffer);
            framebuffer.disposeRunner.add(this);
            return fbo;
        };
        /**
         * Resize the framebuffer
         * @param framebuffer
         * @protected
         */
        FramebufferSystem.prototype.resizeFramebuffer = function (framebuffer) {
            var gl = this.gl;
            var fbo = framebuffer.glFramebuffers[this.CONTEXT_UID];
            if (fbo.msaaBuffer) {
                gl.bindRenderbuffer(gl.RENDERBUFFER, fbo.msaaBuffer);
                gl.renderbufferStorageMultisample(gl.RENDERBUFFER, fbo.multisample, gl.RGBA8, framebuffer.width, framebuffer.height);
            }
            if (fbo.stencil) {
                gl.bindRenderbuffer(gl.RENDERBUFFER, fbo.stencil);
                if (fbo.msaaBuffer) {
                    gl.renderbufferStorageMultisample(gl.RENDERBUFFER, fbo.multisample, gl.DEPTH24_STENCIL8, framebuffer.width, framebuffer.height);
                }
                else {
                    gl.renderbufferStorage(gl.RENDERBUFFER, gl.DEPTH_STENCIL, framebuffer.width, framebuffer.height);
                }
            }
            var colorTextures = framebuffer.colorTextures;
            var count = colorTextures.length;
            if (!gl.drawBuffers) {
                count = Math.min(count, 1);
            }
            for (var i = 0; i < count; i++) {
                var texture = colorTextures[i];
                var parentTexture = texture.parentTextureArray || texture;
                this.renderer.texture.bind(parentTexture, 0);
            }
            if (framebuffer.depthTexture && this.writeDepthTexture) {
                this.renderer.texture.bind(framebuffer.depthTexture, 0);
            }
        };
        /**
         * Update the framebuffer
         * @param framebuffer
         * @param mipLevel
         * @protected
         */
        FramebufferSystem.prototype.updateFramebuffer = function (framebuffer, mipLevel) {
            var gl = this.gl;
            var fbo = framebuffer.glFramebuffers[this.CONTEXT_UID];
            // bind the color texture
            var colorTextures = framebuffer.colorTextures;
            var count = colorTextures.length;
            if (!gl.drawBuffers) {
                count = Math.min(count, 1);
            }
            if (fbo.multisample > 1 && this.canMultisampleFramebuffer(framebuffer)) {
                fbo.msaaBuffer = fbo.msaaBuffer || gl.createRenderbuffer();
                gl.bindRenderbuffer(gl.RENDERBUFFER, fbo.msaaBuffer);
                gl.renderbufferStorageMultisample(gl.RENDERBUFFER, fbo.multisample, gl.RGBA8, framebuffer.width, framebuffer.height);
                gl.framebufferRenderbuffer(gl.FRAMEBUFFER, gl.COLOR_ATTACHMENT0, gl.RENDERBUFFER, fbo.msaaBuffer);
            }
            else if (fbo.msaaBuffer) {
                gl.deleteRenderbuffer(fbo.msaaBuffer);
                fbo.msaaBuffer = null;
                if (fbo.blitFramebuffer) {
                    fbo.blitFramebuffer.dispose();
                    fbo.blitFramebuffer = null;
                }
            }
            var activeTextures = [];
            for (var i = 0; i < count; i++) {
                var texture = colorTextures[i];
                var parentTexture = texture.parentTextureArray || texture;
                this.renderer.texture.bind(parentTexture, 0);
                if (i === 0 && fbo.msaaBuffer) {
                    continue;
                }
                gl.framebufferTexture2D(gl.FRAMEBUFFER, gl.COLOR_ATTACHMENT0 + i, texture.target, parentTexture._glTextures[this.CONTEXT_UID].texture, mipLevel);
                activeTextures.push(gl.COLOR_ATTACHMENT0 + i);
            }
            if (activeTextures.length > 1) {
                gl.drawBuffers(activeTextures);
            }
            if (framebuffer.depthTexture) {
                var writeDepthTexture = this.writeDepthTexture;
                if (writeDepthTexture) {
                    var depthTexture = framebuffer.depthTexture;
                    this.renderer.texture.bind(depthTexture, 0);
                    gl.framebufferTexture2D(gl.FRAMEBUFFER, gl.DEPTH_ATTACHMENT, gl.TEXTURE_2D, depthTexture._glTextures[this.CONTEXT_UID].texture, mipLevel);
                }
            }
            if ((framebuffer.stencil || framebuffer.depth) && !(framebuffer.depthTexture && this.writeDepthTexture)) {
                fbo.stencil = fbo.stencil || gl.createRenderbuffer();
                gl.bindRenderbuffer(gl.RENDERBUFFER, fbo.stencil);
                if (fbo.msaaBuffer) {
                    gl.renderbufferStorageMultisample(gl.RENDERBUFFER, fbo.multisample, gl.DEPTH24_STENCIL8, framebuffer.width, framebuffer.height);
                }
                else {
                    gl.renderbufferStorage(gl.RENDERBUFFER, gl.DEPTH_STENCIL, framebuffer.width, framebuffer.height);
                }
                gl.framebufferRenderbuffer(gl.FRAMEBUFFER, gl.DEPTH_STENCIL_ATTACHMENT, gl.RENDERBUFFER, fbo.stencil);
            }
            else if (fbo.stencil) {
                gl.deleteRenderbuffer(fbo.stencil);
                fbo.stencil = null;
            }
        };
        /**
         * Returns true if the frame buffer can be multisampled.
         * @param framebuffer
         */
        FramebufferSystem.prototype.canMultisampleFramebuffer = function (framebuffer) {
            return this.renderer.context.webGLVersion !== 1
                && framebuffer.colorTextures.length <= 1 && !framebuffer.depthTexture;
        };
        /**
         * Detects number of samples that is not more than a param but as close to it as possible
         * @param samples - number of samples
         * @returns - recommended number of samples
         */
        FramebufferSystem.prototype.detectSamples = function (samples) {
            var msaaSamples = this.msaaSamples;
            var res = constants.MSAA_QUALITY.NONE;
            if (samples <= 1 || msaaSamples === null) {
                return res;
            }
            for (var i = 0; i < msaaSamples.length; i++) {
                if (msaaSamples[i] <= samples) {
                    res = msaaSamples[i];
                    break;
                }
            }
            if (res === 1) {
                res = constants.MSAA_QUALITY.NONE;
            }
            return res;
        };
        /**
         * Only works with WebGL2
         *
         * blits framebuffer to another of the same or bigger size
         * after that target framebuffer is bound
         *
         * Fails with WebGL warning if blits multisample framebuffer to different size
         * @param framebuffer - by default it blits "into itself", from renderBuffer to texture.
         * @param sourcePixels - source rectangle in pixels
         * @param destPixels - dest rectangle in pixels, assumed to be the same as sourcePixels
         */
        FramebufferSystem.prototype.blit = function (framebuffer, sourcePixels, destPixels) {
            var _a = this, current = _a.current, renderer = _a.renderer, gl = _a.gl, CONTEXT_UID = _a.CONTEXT_UID;
            if (renderer.context.webGLVersion !== 2) {
                return;
            }
            if (!current) {
                return;
            }
            var fbo = current.glFramebuffers[CONTEXT_UID];
            if (!fbo) {
                return;
            }
            if (!framebuffer) {
                if (!fbo.msaaBuffer) {
                    return;
                }
                var colorTexture = current.colorTextures[0];
                if (!colorTexture) {
                    return;
                }
                if (!fbo.blitFramebuffer) {
                    fbo.blitFramebuffer = new Framebuffer(current.width, current.height);
                    fbo.blitFramebuffer.addColorTexture(0, colorTexture);
                }
                framebuffer = fbo.blitFramebuffer;
                if (framebuffer.colorTextures[0] !== colorTexture) {
                    framebuffer.colorTextures[0] = colorTexture;
                    framebuffer.dirtyId++;
                    framebuffer.dirtyFormat++;
                }
                if (framebuffer.width !== current.width || framebuffer.height !== current.height) {
                    framebuffer.width = current.width;
                    framebuffer.height = current.height;
                    framebuffer.dirtyId++;
                    framebuffer.dirtySize++;
                }
            }
            if (!sourcePixels) {
                sourcePixels = tempRectangle;
                sourcePixels.width = current.width;
                sourcePixels.height = current.height;
            }
            if (!destPixels) {
                destPixels = sourcePixels;
            }
            var sameSize = sourcePixels.width === destPixels.width && sourcePixels.height === destPixels.height;
            this.bind(framebuffer);
            gl.bindFramebuffer(gl.READ_FRAMEBUFFER, fbo.framebuffer);
            gl.blitFramebuffer(sourcePixels.left, sourcePixels.top, sourcePixels.right, sourcePixels.bottom, destPixels.left, destPixels.top, destPixels.right, destPixels.bottom, gl.COLOR_BUFFER_BIT, sameSize ? gl.NEAREST : gl.LINEAR);
        };
        /**
         * Disposes framebuffer.
         * @param framebuffer - framebuffer that has to be disposed of
         * @param contextLost - If context was lost, we suppress all delete function calls
         */
        FramebufferSystem.prototype.disposeFramebuffer = function (framebuffer, contextLost) {
            var fbo = framebuffer.glFramebuffers[this.CONTEXT_UID];
            var gl = this.gl;
            if (!fbo) {
                return;
            }
            delete framebuffer.glFramebuffers[this.CONTEXT_UID];
            var index = this.managedFramebuffers.indexOf(framebuffer);
            if (index >= 0) {
                this.managedFramebuffers.splice(index, 1);
            }
            framebuffer.disposeRunner.remove(this);
            if (!contextLost) {
                gl.deleteFramebuffer(fbo.framebuffer);
                if (fbo.msaaBuffer) {
                    gl.deleteRenderbuffer(fbo.msaaBuffer);
                }
                if (fbo.stencil) {
                    gl.deleteRenderbuffer(fbo.stencil);
                }
            }
            if (fbo.blitFramebuffer) {
                fbo.blitFramebuffer.dispose();
            }
        };
        /**
         * Disposes all framebuffers, but not textures bound to them.
         * @param [contextLost=false] - If context was lost, we suppress all delete function calls
         */
        FramebufferSystem.prototype.disposeAll = function (contextLost) {
            var list = this.managedFramebuffers;
            this.managedFramebuffers = [];
            for (var i = 0; i < list.length; i++) {
                this.disposeFramebuffer(list[i], contextLost);
            }
        };
        /**
         * Forcing creation of stencil buffer for current framebuffer, if it wasn't done before.
         * Used by MaskSystem, when its time to use stencil mask for Graphics element.
         *
         * Its an alternative for public lazy `framebuffer.enableStencil`, in case we need stencil without rebind.
         * @private
         */
        FramebufferSystem.prototype.forceStencil = function () {
            var framebuffer = this.current;
            if (!framebuffer) {
                return;
            }
            var fbo = framebuffer.glFramebuffers[this.CONTEXT_UID];
            if (!fbo || fbo.stencil) {
                return;
            }
            framebuffer.stencil = true;
            var w = framebuffer.width;
            var h = framebuffer.height;
            var gl = this.gl;
            var stencil = gl.createRenderbuffer();
            gl.bindRenderbuffer(gl.RENDERBUFFER, stencil);
            if (fbo.msaaBuffer) {
                gl.renderbufferStorageMultisample(gl.RENDERBUFFER, fbo.multisample, gl.DEPTH24_STENCIL8, w, h);
            }
            else {
                gl.renderbufferStorage(gl.RENDERBUFFER, gl.DEPTH_STENCIL, w, h);
            }
            fbo.stencil = stencil;
            gl.framebufferRenderbuffer(gl.FRAMEBUFFER, gl.DEPTH_STENCIL_ATTACHMENT, gl.RENDERBUFFER, stencil);
        };
        /** Resets framebuffer stored state, binds screen framebuffer. Should be called before renderTexture reset(). */
        FramebufferSystem.prototype.reset = function () {
            this.current = this.unknownFramebuffer;
            this.viewport = new math.Rectangle();
        };
        FramebufferSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return FramebufferSystem;
    }());

    var byteSizeMap = { 5126: 4, 5123: 2, 5121: 1 };
    /**
     * System plugin to the renderer to manage geometry.
     * @memberof PIXI
     */
    var GeometrySystem = /** @class */ (function () {
        /** @param renderer - The renderer this System works for. */
        function GeometrySystem(renderer) {
            this.renderer = renderer;
            this._activeGeometry = null;
            this._activeVao = null;
            this.hasVao = true;
            this.hasInstance = true;
            this.canUseUInt32ElementIndex = false;
            this.managedGeometries = {};
        }
        /** Sets up the renderer context and necessary buffers. */
        GeometrySystem.prototype.contextChange = function () {
            this.disposeAll(true);
            var gl = this.gl = this.renderer.gl;
            var context = this.renderer.context;
            this.CONTEXT_UID = this.renderer.CONTEXT_UID;
            // webgl2
            if (context.webGLVersion !== 2) {
                // webgl 1!
                var nativeVaoExtension_1 = this.renderer.context.extensions.vertexArrayObject;
                if (settings.settings.PREFER_ENV === constants.ENV.WEBGL_LEGACY) {
                    nativeVaoExtension_1 = null;
                }
                if (nativeVaoExtension_1) {
                    gl.createVertexArray = function () {
                        return nativeVaoExtension_1.createVertexArrayOES();
                    };
                    gl.bindVertexArray = function (vao) {
                        return nativeVaoExtension_1.bindVertexArrayOES(vao);
                    };
                    gl.deleteVertexArray = function (vao) {
                        return nativeVaoExtension_1.deleteVertexArrayOES(vao);
                    };
                }
                else {
                    this.hasVao = false;
                    gl.createVertexArray = function () {
                        return null;
                    };
                    gl.bindVertexArray = function () {
                        return null;
                    };
                    gl.deleteVertexArray = function () {
                        return null;
                    };
                }
            }
            if (context.webGLVersion !== 2) {
                var instanceExt_1 = gl.getExtension('ANGLE_instanced_arrays');
                if (instanceExt_1) {
                    gl.vertexAttribDivisor = function (a, b) {
                        return instanceExt_1.vertexAttribDivisorANGLE(a, b);
                    };
                    gl.drawElementsInstanced = function (a, b, c, d, e) {
                        return instanceExt_1.drawElementsInstancedANGLE(a, b, c, d, e);
                    };
                    gl.drawArraysInstanced = function (a, b, c, d) {
                        return instanceExt_1.drawArraysInstancedANGLE(a, b, c, d);
                    };
                }
                else {
                    this.hasInstance = false;
                }
            }
            this.canUseUInt32ElementIndex = context.webGLVersion === 2 || !!context.extensions.uint32ElementIndex;
        };
        /**
         * Binds geometry so that is can be drawn. Creating a Vao if required
         * @param geometry - Instance of geometry to bind.
         * @param shader - Instance of shader to use vao for.
         */
        GeometrySystem.prototype.bind = function (geometry, shader) {
            shader = shader || this.renderer.shader.shader;
            var gl = this.gl;
            // not sure the best way to address this..
            // currently different shaders require different VAOs for the same geometry
            // Still mulling over the best way to solve this one..
            // will likely need to modify the shader attribute locations at run time!
            var vaos = geometry.glVertexArrayObjects[this.CONTEXT_UID];
            var incRefCount = false;
            if (!vaos) {
                this.managedGeometries[geometry.id] = geometry;
                geometry.disposeRunner.add(this);
                geometry.glVertexArrayObjects[this.CONTEXT_UID] = vaos = {};
                incRefCount = true;
            }
            var vao = vaos[shader.program.id] || this.initGeometryVao(geometry, shader, incRefCount);
            this._activeGeometry = geometry;
            if (this._activeVao !== vao) {
                this._activeVao = vao;
                if (this.hasVao) {
                    gl.bindVertexArray(vao);
                }
                else {
                    this.activateVao(geometry, shader.program);
                }
            }
            // TODO - optimise later!
            // don't need to loop through if nothing changed!
            // maybe look to add an 'autoupdate' to geometry?
            this.updateBuffers();
        };
        /** Reset and unbind any active VAO and geometry. */
        GeometrySystem.prototype.reset = function () {
            this.unbind();
        };
        /** Update buffers of the currently bound geometry. */
        GeometrySystem.prototype.updateBuffers = function () {
            var geometry = this._activeGeometry;
            var bufferSystem = this.renderer.buffer;
            for (var i = 0; i < geometry.buffers.length; i++) {
                var buffer = geometry.buffers[i];
                bufferSystem.update(buffer);
            }
        };
        /**
         * Check compatibility between a geometry and a program
         * @param geometry - Geometry instance.
         * @param program - Program instance.
         */
        GeometrySystem.prototype.checkCompatibility = function (geometry, program) {
            // geometry must have at least all the attributes that the shader requires.
            var geometryAttributes = geometry.attributes;
            var shaderAttributes = program.attributeData;
            for (var j in shaderAttributes) {
                if (!geometryAttributes[j]) {
                    throw new Error("shader and geometry incompatible, geometry missing the \"" + j + "\" attribute");
                }
            }
        };
        /**
         * Takes a geometry and program and generates a unique signature for them.
         * @param geometry - To get signature from.
         * @param program - To test geometry against.
         * @returns - Unique signature of the geometry and program
         */
        GeometrySystem.prototype.getSignature = function (geometry, program) {
            var attribs = geometry.attributes;
            var shaderAttributes = program.attributeData;
            var strings = ['g', geometry.id];
            for (var i in attribs) {
                if (shaderAttributes[i]) {
                    strings.push(i, shaderAttributes[i].location);
                }
            }
            return strings.join('-');
        };
        /**
         * Creates or gets Vao with the same structure as the geometry and stores it on the geometry.
         * If vao is created, it is bound automatically. We use a shader to infer what and how to set up the
         * attribute locations.
         * @param geometry - Instance of geometry to to generate Vao for.
         * @param shader - Instance of the shader.
         * @param incRefCount - Increment refCount of all geometry buffers.
         */
        GeometrySystem.prototype.initGeometryVao = function (geometry, shader, incRefCount) {
            if (incRefCount === void 0) { incRefCount = true; }
            var gl = this.gl;
            var CONTEXT_UID = this.CONTEXT_UID;
            var bufferSystem = this.renderer.buffer;
            var program = shader.program;
            if (!program.glPrograms[CONTEXT_UID]) {
                this.renderer.shader.generateProgram(shader);
            }
            this.checkCompatibility(geometry, program);
            var signature = this.getSignature(geometry, program);
            var vaoObjectHash = geometry.glVertexArrayObjects[this.CONTEXT_UID];
            var vao = vaoObjectHash[signature];
            if (vao) {
                // this will give us easy access to the vao
                vaoObjectHash[program.id] = vao;
                return vao;
            }
            var buffers = geometry.buffers;
            var attributes = geometry.attributes;
            var tempStride = {};
            var tempStart = {};
            for (var j in buffers) {
                tempStride[j] = 0;
                tempStart[j] = 0;
            }
            for (var j in attributes) {
                if (!attributes[j].size && program.attributeData[j]) {
                    attributes[j].size = program.attributeData[j].size;
                }
                else if (!attributes[j].size) {
                    console.warn("PIXI Geometry attribute '" + j + "' size cannot be determined (likely the bound shader does not have the attribute)"); // eslint-disable-line
                }
                tempStride[attributes[j].buffer] += attributes[j].size * byteSizeMap[attributes[j].type];
            }
            for (var j in attributes) {
                var attribute = attributes[j];
                var attribSize = attribute.size;
                if (attribute.stride === undefined) {
                    if (tempStride[attribute.buffer] === attribSize * byteSizeMap[attribute.type]) {
                        attribute.stride = 0;
                    }
                    else {
                        attribute.stride = tempStride[attribute.buffer];
                    }
                }
                if (attribute.start === undefined) {
                    attribute.start = tempStart[attribute.buffer];
                    tempStart[attribute.buffer] += attribSize * byteSizeMap[attribute.type];
                }
            }
            vao = gl.createVertexArray();
            gl.bindVertexArray(vao);
            // first update - and create the buffers!
            // only create a gl buffer if it actually gets
            for (var i = 0; i < buffers.length; i++) {
                var buffer = buffers[i];
                bufferSystem.bind(buffer);
                if (incRefCount) {
                    buffer._glBuffers[CONTEXT_UID].refCount++;
                }
            }
            // TODO - maybe make this a data object?
            // lets wait to see if we need to first!
            this.activateVao(geometry, program);
            this._activeVao = vao;
            // add it to the cache!
            vaoObjectHash[program.id] = vao;
            vaoObjectHash[signature] = vao;
            return vao;
        };
        /**
         * Disposes geometry.
         * @param geometry - Geometry with buffers. Only VAO will be disposed
         * @param [contextLost=false] - If context was lost, we suppress deleteVertexArray
         */
        GeometrySystem.prototype.disposeGeometry = function (geometry, contextLost) {
            var _a;
            if (!this.managedGeometries[geometry.id]) {
                return;
            }
            delete this.managedGeometries[geometry.id];
            var vaos = geometry.glVertexArrayObjects[this.CONTEXT_UID];
            var gl = this.gl;
            var buffers = geometry.buffers;
            var bufferSystem = (_a = this.renderer) === null || _a === void 0 ? void 0 : _a.buffer;
            geometry.disposeRunner.remove(this);
            if (!vaos) {
                return;
            }
            // bufferSystem may have already been destroyed..
            // if this is the case, there is no need to destroy the geometry buffers...
            // they already have been!
            if (bufferSystem) {
                for (var i = 0; i < buffers.length; i++) {
                    var buf = buffers[i]._glBuffers[this.CONTEXT_UID];
                    // my be null as context may have changed right before the dispose is called
                    if (buf) {
                        buf.refCount--;
                        if (buf.refCount === 0 && !contextLost) {
                            bufferSystem.dispose(buffers[i], contextLost);
                        }
                    }
                }
            }
            if (!contextLost) {
                for (var vaoId in vaos) {
                    // delete only signatures, everything else are copies
                    if (vaoId[0] === 'g') {
                        var vao = vaos[vaoId];
                        if (this._activeVao === vao) {
                            this.unbind();
                        }
                        gl.deleteVertexArray(vao);
                    }
                }
            }
            delete geometry.glVertexArrayObjects[this.CONTEXT_UID];
        };
        /**
         * Dispose all WebGL resources of all managed geometries.
         * @param [contextLost=false] - If context was lost, we suppress `gl.delete` calls
         */
        GeometrySystem.prototype.disposeAll = function (contextLost) {
            var all = Object.keys(this.managedGeometries);
            for (var i = 0; i < all.length; i++) {
                this.disposeGeometry(this.managedGeometries[all[i]], contextLost);
            }
        };
        /**
         * Activate vertex array object.
         * @param geometry - Geometry instance.
         * @param program - Shader program instance.
         */
        GeometrySystem.prototype.activateVao = function (geometry, program) {
            var gl = this.gl;
            var CONTEXT_UID = this.CONTEXT_UID;
            var bufferSystem = this.renderer.buffer;
            var buffers = geometry.buffers;
            var attributes = geometry.attributes;
            if (geometry.indexBuffer) {
                // first update the index buffer if we have one..
                bufferSystem.bind(geometry.indexBuffer);
            }
            var lastBuffer = null;
            // add a new one!
            for (var j in attributes) {
                var attribute = attributes[j];
                var buffer = buffers[attribute.buffer];
                var glBuffer = buffer._glBuffers[CONTEXT_UID];
                if (program.attributeData[j]) {
                    if (lastBuffer !== glBuffer) {
                        bufferSystem.bind(buffer);
                        lastBuffer = glBuffer;
                    }
                    var location = program.attributeData[j].location;
                    // TODO introduce state again
                    // we can optimise this for older devices that have no VAOs
                    gl.enableVertexAttribArray(location);
                    gl.vertexAttribPointer(location, attribute.size, attribute.type || gl.FLOAT, attribute.normalized, attribute.stride, attribute.start);
                    if (attribute.instance) {
                        // TODO calculate instance count based of this...
                        if (this.hasInstance) {
                            gl.vertexAttribDivisor(location, 1);
                        }
                        else {
                            throw new Error('geometry error, GPU Instancing is not supported on this device');
                        }
                    }
                }
            }
        };
        /**
         * Draws the currently bound geometry.
         * @param type - The type primitive to render.
         * @param size - The number of elements to be rendered. If not specified, all vertices after the
         *  starting vertex will be drawn.
         * @param start - The starting vertex in the geometry to start drawing from. If not specified,
         *  drawing will start from the first vertex.
         * @param instanceCount - The number of instances of the set of elements to execute. If not specified,
         *  all instances will be drawn.
         */
        GeometrySystem.prototype.draw = function (type, size, start, instanceCount) {
            var gl = this.gl;
            var geometry = this._activeGeometry;
            // TODO.. this should not change so maybe cache the function?
            if (geometry.indexBuffer) {
                var byteSize = geometry.indexBuffer.data.BYTES_PER_ELEMENT;
                var glType = byteSize === 2 ? gl.UNSIGNED_SHORT : gl.UNSIGNED_INT;
                if (byteSize === 2 || (byteSize === 4 && this.canUseUInt32ElementIndex)) {
                    if (geometry.instanced) {
                        /* eslint-disable max-len */
                        gl.drawElementsInstanced(type, size || geometry.indexBuffer.data.length, glType, (start || 0) * byteSize, instanceCount || 1);
                        /* eslint-enable max-len */
                    }
                    else {
                        /* eslint-disable max-len */
                        gl.drawElements(type, size || geometry.indexBuffer.data.length, glType, (start || 0) * byteSize);
                        /* eslint-enable max-len */
                    }
                }
                else {
                    console.warn('unsupported index buffer type: uint32');
                }
            }
            else if (geometry.instanced) {
                // TODO need a better way to calculate size..
                gl.drawArraysInstanced(type, start, size || geometry.getSize(), instanceCount || 1);
            }
            else {
                gl.drawArrays(type, start, size || geometry.getSize());
            }
            return this;
        };
        /** Unbind/reset everything. */
        GeometrySystem.prototype.unbind = function () {
            this.gl.bindVertexArray(null);
            this._activeVao = null;
            this._activeGeometry = null;
        };
        GeometrySystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return GeometrySystem;
    }());

    /**
     * Component for masked elements.
     *
     * Holds mask mode and temporary data about current mask.
     * @memberof PIXI
     */
    var MaskData = /** @class */ (function () {
        /**
         * Create MaskData
         * @param {PIXI.DisplayObject} [maskObject=null] - object that describes the mask
         */
        function MaskData(maskObject) {
            if (maskObject === void 0) { maskObject = null; }
            this.type = constants.MASK_TYPES.NONE;
            this.autoDetect = true;
            this.maskObject = maskObject || null;
            this.pooled = false;
            this.isMaskData = true;
            this.resolution = null;
            this.multisample = settings.settings.FILTER_MULTISAMPLE;
            this.enabled = true;
            this.colorMask = 0xf;
            this._filters = null;
            this._stencilCounter = 0;
            this._scissorCounter = 0;
            this._scissorRect = null;
            this._scissorRectLocal = null;
            this._colorMask = 0xf;
            this._target = null;
        }
        Object.defineProperty(MaskData.prototype, "filter", {
            /**
             * The sprite mask filter.
             * If set to `null`, the default sprite mask filter is used.
             * @default null
             */
            get: function () {
                return this._filters ? this._filters[0] : null;
            },
            set: function (value) {
                if (value) {
                    if (this._filters) {
                        this._filters[0] = value;
                    }
                    else {
                        this._filters = [value];
                    }
                }
                else {
                    this._filters = null;
                }
            },
            enumerable: false,
            configurable: true
        });
        /** Resets the mask data after popMask(). */
        MaskData.prototype.reset = function () {
            if (this.pooled) {
                this.maskObject = null;
                this.type = constants.MASK_TYPES.NONE;
                this.autoDetect = true;
            }
            this._target = null;
            this._scissorRectLocal = null;
        };
        /**
         * Copies counters from maskData above, called from pushMask().
         * @param maskAbove
         */
        MaskData.prototype.copyCountersOrReset = function (maskAbove) {
            if (maskAbove) {
                this._stencilCounter = maskAbove._stencilCounter;
                this._scissorCounter = maskAbove._scissorCounter;
                this._scissorRect = maskAbove._scissorRect;
            }
            else {
                this._stencilCounter = 0;
                this._scissorCounter = 0;
                this._scissorRect = null;
            }
        };
        return MaskData;
    }());

    /**
     * @private
     * @param {WebGLRenderingContext} gl - The current WebGL context {WebGLProgram}
     * @param {number} type - the type, can be either VERTEX_SHADER or FRAGMENT_SHADER
     * @param {string} src - The vertex shader source as an array of strings.
     * @returns {WebGLShader} the shader
     */
    function compileShader(gl, type, src) {
        var shader = gl.createShader(type);
        gl.shaderSource(shader, src);
        gl.compileShader(shader);
        return shader;
    }

    /**
     * will log a shader error highlighting the lines with the error
     * also will add numbers along the side.
     * @param gl - the WebGLContext
     * @param shader - the shader to log errors for
     */
    function logPrettyShaderError(gl, shader) {
        var shaderSrc = gl.getShaderSource(shader)
            .split('\n')
            .map(function (line, index) { return index + ": " + line; });
        var shaderLog = gl.getShaderInfoLog(shader);
        var splitShader = shaderLog.split('\n');
        var dedupe = {};
        var lineNumbers = splitShader.map(function (line) { return parseFloat(line.replace(/^ERROR\: 0\:([\d]+)\:.*$/, '$1')); })
            .filter(function (n) {
            if (n && !dedupe[n]) {
                dedupe[n] = true;
                return true;
            }
            return false;
        });
        var logArgs = [''];
        lineNumbers.forEach(function (number) {
            shaderSrc[number - 1] = "%c" + shaderSrc[number - 1] + "%c";
            logArgs.push('background: #FF0000; color:#FFFFFF; font-size: 10px', 'font-size: 10px');
        });
        var fragmentSourceToLog = shaderSrc
            .join('\n');
        logArgs[0] = fragmentSourceToLog;
        console.error(shaderLog);
        // eslint-disable-next-line no-console
        console.groupCollapsed('click to view full shader code');
        console.warn.apply(console, logArgs);
        // eslint-disable-next-line no-console
        console.groupEnd();
    }
    /**
     *
     * logs out any program errors
     * @param gl - The current WebGL context
     * @param program - the WebGL program to display errors for
     * @param vertexShader  - the fragment WebGL shader program
     * @param fragmentShader - the vertex WebGL shader program
     */
    function logProgramError(gl, program, vertexShader, fragmentShader) {
        // if linking fails, then log and cleanup
        if (!gl.getProgramParameter(program, gl.LINK_STATUS)) {
            if (!gl.getShaderParameter(vertexShader, gl.COMPILE_STATUS)) {
                logPrettyShaderError(gl, vertexShader);
            }
            if (!gl.getShaderParameter(fragmentShader, gl.COMPILE_STATUS)) {
                logPrettyShaderError(gl, fragmentShader);
            }
            console.error('PixiJS Error: Could not initialize shader.');
            // if there is a program info log, log it
            if (gl.getProgramInfoLog(program) !== '') {
                console.warn('PixiJS Warning: gl.getProgramInfoLog()', gl.getProgramInfoLog(program));
            }
        }
    }

    function booleanArray(size) {
        var array = new Array(size);
        for (var i = 0; i < array.length; i++) {
            array[i] = false;
        }
        return array;
    }
    /**
     * @method defaultValue
     * @memberof PIXI.glCore.shader
     * @param {string} type - Type of value
     * @param {number} size
     * @private
     */
    function defaultValue(type, size) {
        switch (type) {
            case 'float':
                return 0;
            case 'vec2':
                return new Float32Array(2 * size);
            case 'vec3':
                return new Float32Array(3 * size);
            case 'vec4':
                return new Float32Array(4 * size);
            case 'int':
            case 'uint':
            case 'sampler2D':
            case 'sampler2DArray':
                return 0;
            case 'ivec2':
                return new Int32Array(2 * size);
            case 'ivec3':
                return new Int32Array(3 * size);
            case 'ivec4':
                return new Int32Array(4 * size);
            case 'uvec2':
                return new Uint32Array(2 * size);
            case 'uvec3':
                return new Uint32Array(3 * size);
            case 'uvec4':
                return new Uint32Array(4 * size);
            case 'bool':
                return false;
            case 'bvec2':
                return booleanArray(2 * size);
            case 'bvec3':
                return booleanArray(3 * size);
            case 'bvec4':
                return booleanArray(4 * size);
            case 'mat2':
                return new Float32Array([1, 0,
                    0, 1]);
            case 'mat3':
                return new Float32Array([1, 0, 0,
                    0, 1, 0,
                    0, 0, 1]);
            case 'mat4':
                return new Float32Array([1, 0, 0, 0,
                    0, 1, 0, 0,
                    0, 0, 1, 0,
                    0, 0, 0, 1]);
        }
        return null;
    }

    var unknownContext = {};
    var context = unknownContext;
    /**
     * returns a little WebGL context to use for program inspection.
     * @static
     * @private
     * @returns {WebGLRenderingContext} a gl context to test with
     */
    function getTestContext() {
        if (context === unknownContext || (context && context.isContextLost())) {
            var canvas = settings.settings.ADAPTER.createCanvas();
            var gl = void 0;
            if (settings.settings.PREFER_ENV >= constants.ENV.WEBGL2) {
                gl = canvas.getContext('webgl2', {});
            }
            if (!gl) {
                gl = (canvas.getContext('webgl', {})
                    || canvas.getContext('experimental-webgl', {}));
                if (!gl) {
                    // fail, not able to get a context
                    gl = null;
                }
                else {
                    // for shader testing..
                    gl.getExtension('WEBGL_draw_buffers');
                }
            }
            context = gl;
        }
        return context;
    }

    var maxFragmentPrecision;
    function getMaxFragmentPrecision() {
        if (!maxFragmentPrecision) {
            maxFragmentPrecision = constants.PRECISION.MEDIUM;
            var gl = getTestContext();
            if (gl) {
                if (gl.getShaderPrecisionFormat) {
                    var shaderFragment = gl.getShaderPrecisionFormat(gl.FRAGMENT_SHADER, gl.HIGH_FLOAT);
                    maxFragmentPrecision = shaderFragment.precision ? constants.PRECISION.HIGH : constants.PRECISION.MEDIUM;
                }
            }
        }
        return maxFragmentPrecision;
    }

    /**
     * Sets the float precision on the shader, ensuring the device supports the request precision.
     * If the precision is already present, it just ensures that the device is able to handle it.
     * @private
     * @param {string} src - The shader source
     * @param {PIXI.PRECISION} requestedPrecision - The request float precision of the shader.
     * @param {PIXI.PRECISION} maxSupportedPrecision - The maximum precision the shader supports.
     * @returns {string} modified shader source
     */
    function setPrecision(src, requestedPrecision, maxSupportedPrecision) {
        if (src.substring(0, 9) !== 'precision') {
            // no precision supplied, so PixiJS will add the requested level.
            var precision = requestedPrecision;
            // If highp is requested but not supported, downgrade precision to a level all devices support.
            if (requestedPrecision === constants.PRECISION.HIGH && maxSupportedPrecision !== constants.PRECISION.HIGH) {
                precision = constants.PRECISION.MEDIUM;
            }
            return "precision " + precision + " float;\n" + src;
        }
        else if (maxSupportedPrecision !== constants.PRECISION.HIGH && src.substring(0, 15) === 'precision highp') {
            // precision was supplied, but at a level this device does not support, so downgrading to mediump.
            return src.replace('precision highp', 'precision mediump');
        }
        return src;
    }

    var GLSL_TO_SIZE = {
        float: 1,
        vec2: 2,
        vec3: 3,
        vec4: 4,
        int: 1,
        ivec2: 2,
        ivec3: 3,
        ivec4: 4,
        uint: 1,
        uvec2: 2,
        uvec3: 3,
        uvec4: 4,
        bool: 1,
        bvec2: 2,
        bvec3: 3,
        bvec4: 4,
        mat2: 4,
        mat3: 9,
        mat4: 16,
        sampler2D: 1,
    };
    /**
     * @private
     * @method mapSize
     * @memberof PIXI.glCore.shader
     * @param {string} type
     */
    function mapSize(type) {
        return GLSL_TO_SIZE[type];
    }

    var GL_TABLE = null;
    var GL_TO_GLSL_TYPES = {
        FLOAT: 'float',
        FLOAT_VEC2: 'vec2',
        FLOAT_VEC3: 'vec3',
        FLOAT_VEC4: 'vec4',
        INT: 'int',
        INT_VEC2: 'ivec2',
        INT_VEC3: 'ivec3',
        INT_VEC4: 'ivec4',
        UNSIGNED_INT: 'uint',
        UNSIGNED_INT_VEC2: 'uvec2',
        UNSIGNED_INT_VEC3: 'uvec3',
        UNSIGNED_INT_VEC4: 'uvec4',
        BOOL: 'bool',
        BOOL_VEC2: 'bvec2',
        BOOL_VEC3: 'bvec3',
        BOOL_VEC4: 'bvec4',
        FLOAT_MAT2: 'mat2',
        FLOAT_MAT3: 'mat3',
        FLOAT_MAT4: 'mat4',
        SAMPLER_2D: 'sampler2D',
        INT_SAMPLER_2D: 'sampler2D',
        UNSIGNED_INT_SAMPLER_2D: 'sampler2D',
        SAMPLER_CUBE: 'samplerCube',
        INT_SAMPLER_CUBE: 'samplerCube',
        UNSIGNED_INT_SAMPLER_CUBE: 'samplerCube',
        SAMPLER_2D_ARRAY: 'sampler2DArray',
        INT_SAMPLER_2D_ARRAY: 'sampler2DArray',
        UNSIGNED_INT_SAMPLER_2D_ARRAY: 'sampler2DArray',
    };
    // eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
    function mapType(gl, type) {
        if (!GL_TABLE) {
            var typeNames = Object.keys(GL_TO_GLSL_TYPES);
            GL_TABLE = {};
            for (var i = 0; i < typeNames.length; ++i) {
                var tn = typeNames[i];
                GL_TABLE[gl[tn]] = GL_TO_GLSL_TYPES[tn];
            }
        }
        return GL_TABLE[type];
    }

    /* eslint-disable @typescript-eslint/explicit-module-boundary-types */
    // Parsers, each one of these will take a look at the type of shader property and uniform.
    // if they pass the test function then the code function is called that returns a the shader upload code for that uniform.
    // Shader upload code is automagically generated with these parsers.
    // If no parser is valid then the default upload functions are used.
    // exposing Parsers means that custom upload logic can be added to pixi's shaders.
    // A good example would be a pixi rectangle can be directly set on a uniform.
    // If the shader sees it it knows how to upload the rectangle structure as a vec4
    // format is as follows:
    //
    // {
    //     test: (data, uniform) => {} <--- test is this code should be used for this uniform
    //     code: (name, uniform) => {} <--- returns the string of the piece of code that uploads the uniform
    //     codeUbo: (name, uniform) => {} <--- returns the string of the piece of code that uploads the
    //                                         uniform to a uniform buffer
    // }
    var uniformParsers = [
        // a float cache layer
        {
            test: function (data) {
                return data.type === 'float' && data.size === 1;
            },
            code: function (name) {
                return "\n            if(uv[\"" + name + "\"] !== ud[\"" + name + "\"].value)\n            {\n                ud[\"" + name + "\"].value = uv[\"" + name + "\"]\n                gl.uniform1f(ud[\"" + name + "\"].location, uv[\"" + name + "\"])\n            }\n            ";
            },
        },
        // handling samplers
        {
            test: function (data) {
                // eslint-disable-next-line max-len
                return (data.type === 'sampler2D' || data.type === 'samplerCube' || data.type === 'sampler2DArray') && data.size === 1 && !data.isArray;
            },
            code: function (name) { return "t = syncData.textureCount++;\n\n            renderer.texture.bind(uv[\"" + name + "\"], t);\n\n            if(ud[\"" + name + "\"].value !== t)\n            {\n                ud[\"" + name + "\"].value = t;\n                gl.uniform1i(ud[\"" + name + "\"].location, t);\n; // eslint-disable-line max-len\n            }"; },
        },
        // uploading pixi matrix object to mat3
        {
            test: function (data, uniform) {
                return data.type === 'mat3' && data.size === 1 && uniform.a !== undefined;
            },
            code: function (name) {
                // TODO and some smart caching dirty ids here!
                return "\n            gl.uniformMatrix3fv(ud[\"" + name + "\"].location, false, uv[\"" + name + "\"].toArray(true));\n            ";
            },
            codeUbo: function (name) {
                return "\n                var " + name + "_matrix = uv." + name + ".toArray(true);\n\n                data[offset] = " + name + "_matrix[0];\n                data[offset+1] = " + name + "_matrix[1];\n                data[offset+2] = " + name + "_matrix[2];\n        \n                data[offset + 4] = " + name + "_matrix[3];\n                data[offset + 5] = " + name + "_matrix[4];\n                data[offset + 6] = " + name + "_matrix[5];\n        \n                data[offset + 8] = " + name + "_matrix[6];\n                data[offset + 9] = " + name + "_matrix[7];\n                data[offset + 10] = " + name + "_matrix[8];\n            ";
            },
        },
        // uploading a pixi point as a vec2 with caching layer
        {
            test: function (data, uniform) {
                return data.type === 'vec2' && data.size === 1 && uniform.x !== undefined;
            },
            code: function (name) {
                return "\n                cv = ud[\"" + name + "\"].value;\n                v = uv[\"" + name + "\"];\n\n                if(cv[0] !== v.x || cv[1] !== v.y)\n                {\n                    cv[0] = v.x;\n                    cv[1] = v.y;\n                    gl.uniform2f(ud[\"" + name + "\"].location, v.x, v.y);\n                }";
            },
            codeUbo: function (name) {
                return "\n                v = uv." + name + ";\n\n                data[offset] = v.x;\n                data[offset+1] = v.y;\n            ";
            }
        },
        // caching layer for a vec2
        {
            test: function (data) {
                return data.type === 'vec2' && data.size === 1;
            },
            code: function (name) {
                return "\n                cv = ud[\"" + name + "\"].value;\n                v = uv[\"" + name + "\"];\n\n                if(cv[0] !== v[0] || cv[1] !== v[1])\n                {\n                    cv[0] = v[0];\n                    cv[1] = v[1];\n                    gl.uniform2f(ud[\"" + name + "\"].location, v[0], v[1]);\n                }\n            ";
            },
        },
        // upload a pixi rectangle as a vec4 with caching layer
        {
            test: function (data, uniform) {
                return data.type === 'vec4' && data.size === 1 && uniform.width !== undefined;
            },
            code: function (name) {
                return "\n                cv = ud[\"" + name + "\"].value;\n                v = uv[\"" + name + "\"];\n\n                if(cv[0] !== v.x || cv[1] !== v.y || cv[2] !== v.width || cv[3] !== v.height)\n                {\n                    cv[0] = v.x;\n                    cv[1] = v.y;\n                    cv[2] = v.width;\n                    cv[3] = v.height;\n                    gl.uniform4f(ud[\"" + name + "\"].location, v.x, v.y, v.width, v.height)\n                }";
            },
            codeUbo: function (name) {
                return "\n                    v = uv." + name + ";\n\n                    data[offset] = v.x;\n                    data[offset+1] = v.y;\n                    data[offset+2] = v.width;\n                    data[offset+3] = v.height;\n                ";
            }
        },
        // a caching layer for vec4 uploading
        {
            test: function (data) {
                return data.type === 'vec4' && data.size === 1;
            },
            code: function (name) {
                return "\n                cv = ud[\"" + name + "\"].value;\n                v = uv[\"" + name + "\"];\n\n                if(cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2] || cv[3] !== v[3])\n                {\n                    cv[0] = v[0];\n                    cv[1] = v[1];\n                    cv[2] = v[2];\n                    cv[3] = v[3];\n\n                    gl.uniform4f(ud[\"" + name + "\"].location, v[0], v[1], v[2], v[3])\n                }";
            },
        } ];

    // cu = Cached value's uniform data field
    // cv = Cached value
    // v = value to upload
    // ud = uniformData
    // uv = uniformValue
    // l = location
    var GLSL_TO_SINGLE_SETTERS_CACHED = {
        float: "\n    if (cv !== v)\n    {\n        cu.value = v;\n        gl.uniform1f(location, v);\n    }",
        vec2: "\n    if (cv[0] !== v[0] || cv[1] !== v[1])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n\n        gl.uniform2f(location, v[0], v[1])\n    }",
        vec3: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n\n        gl.uniform3f(location, v[0], v[1], v[2])\n    }",
        vec4: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2] || cv[3] !== v[3])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n        cv[3] = v[3];\n\n        gl.uniform4f(location, v[0], v[1], v[2], v[3]);\n    }",
        int: "\n    if (cv !== v)\n    {\n        cu.value = v;\n\n        gl.uniform1i(location, v);\n    }",
        ivec2: "\n    if (cv[0] !== v[0] || cv[1] !== v[1])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n\n        gl.uniform2i(location, v[0], v[1]);\n    }",
        ivec3: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n\n        gl.uniform3i(location, v[0], v[1], v[2]);\n    }",
        ivec4: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2] || cv[3] !== v[3])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n        cv[3] = v[3];\n\n        gl.uniform4i(location, v[0], v[1], v[2], v[3]);\n    }",
        uint: "\n    if (cv !== v)\n    {\n        cu.value = v;\n\n        gl.uniform1ui(location, v);\n    }",
        uvec2: "\n    if (cv[0] !== v[0] || cv[1] !== v[1])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n\n        gl.uniform2ui(location, v[0], v[1]);\n    }",
        uvec3: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n\n        gl.uniform3ui(location, v[0], v[1], v[2]);\n    }",
        uvec4: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2] || cv[3] !== v[3])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n        cv[3] = v[3];\n\n        gl.uniform4ui(location, v[0], v[1], v[2], v[3]);\n    }",
        bool: "\n    if (cv !== v)\n    {\n        cu.value = v;\n        gl.uniform1i(location, v);\n    }",
        bvec2: "\n    if (cv[0] != v[0] || cv[1] != v[1])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n\n        gl.uniform2i(location, v[0], v[1]);\n    }",
        bvec3: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n\n        gl.uniform3i(location, v[0], v[1], v[2]);\n    }",
        bvec4: "\n    if (cv[0] !== v[0] || cv[1] !== v[1] || cv[2] !== v[2] || cv[3] !== v[3])\n    {\n        cv[0] = v[0];\n        cv[1] = v[1];\n        cv[2] = v[2];\n        cv[3] = v[3];\n\n        gl.uniform4i(location, v[0], v[1], v[2], v[3]);\n    }",
        mat2: 'gl.uniformMatrix2fv(location, false, v)',
        mat3: 'gl.uniformMatrix3fv(location, false, v)',
        mat4: 'gl.uniformMatrix4fv(location, false, v)',
        sampler2D: 'gl.uniform1i(location, v)',
        samplerCube: 'gl.uniform1i(location, v)',
        sampler2DArray: 'gl.uniform1i(location, v)',
    };
    var GLSL_TO_ARRAY_SETTERS = {
        float: "gl.uniform1fv(location, v)",
        vec2: "gl.uniform2fv(location, v)",
        vec3: "gl.uniform3fv(location, v)",
        vec4: 'gl.uniform4fv(location, v)',
        mat4: 'gl.uniformMatrix4fv(location, false, v)',
        mat3: 'gl.uniformMatrix3fv(location, false, v)',
        mat2: 'gl.uniformMatrix2fv(location, false, v)',
        int: 'gl.uniform1iv(location, v)',
        ivec2: 'gl.uniform2iv(location, v)',
        ivec3: 'gl.uniform3iv(location, v)',
        ivec4: 'gl.uniform4iv(location, v)',
        uint: 'gl.uniform1uiv(location, v)',
        uvec2: 'gl.uniform2uiv(location, v)',
        uvec3: 'gl.uniform3uiv(location, v)',
        uvec4: 'gl.uniform4uiv(location, v)',
        bool: 'gl.uniform1iv(location, v)',
        bvec2: 'gl.uniform2iv(location, v)',
        bvec3: 'gl.uniform3iv(location, v)',
        bvec4: 'gl.uniform4iv(location, v)',
        sampler2D: 'gl.uniform1iv(location, v)',
        samplerCube: 'gl.uniform1iv(location, v)',
        sampler2DArray: 'gl.uniform1iv(location, v)',
    };
    function generateUniformsSync(group, uniformData) {
        var _a;
        var funcFragments = ["\n        var v = null;\n        var cv = null;\n        var cu = null;\n        var t = 0;\n        var gl = renderer.gl;\n    "];
        for (var i in group.uniforms) {
            var data = uniformData[i];
            if (!data) {
                if ((_a = group.uniforms[i]) === null || _a === void 0 ? void 0 : _a.group) {
                    if (group.uniforms[i].ubo) {
                        funcFragments.push("\n                        renderer.shader.syncUniformBufferGroup(uv." + i + ", '" + i + "');\n                    ");
                    }
                    else {
                        funcFragments.push("\n                        renderer.shader.syncUniformGroup(uv." + i + ", syncData);\n                    ");
                    }
                }
                continue;
            }
            var uniform = group.uniforms[i];
            var parsed = false;
            for (var j = 0; j < uniformParsers.length; j++) {
                if (uniformParsers[j].test(data, uniform)) {
                    funcFragments.push(uniformParsers[j].code(i, uniform));
                    parsed = true;
                    break;
                }
            }
            if (!parsed) {
                var templateType = (data.size === 1) ? GLSL_TO_SINGLE_SETTERS_CACHED : GLSL_TO_ARRAY_SETTERS;
                var template = templateType[data.type].replace('location', "ud[\"" + i + "\"].location");
                funcFragments.push("\n            cu = ud[\"" + i + "\"];\n            cv = cu.value;\n            v = uv[\"" + i + "\"];\n            " + template + ";");
            }
        }
        /*
         * the introduction of syncData is to solve an issue where textures in uniform groups are not set correctly
         * the texture count was always starting from 0 in each group. This needs to increment each time a texture is used
         * no matter which group is being used
         *
         */
        // eslint-disable-next-line no-new-func
        return new Function('ud', 'uv', 'renderer', 'syncData', funcFragments.join('\n'));
    }

    var fragTemplate = [
        'precision mediump float;',
        'void main(void){',
        'float test = 0.1;',
        '%forloop%',
        'gl_FragColor = vec4(0.0);',
        '}' ].join('\n');
    function generateIfTestSrc(maxIfs) {
        var src = '';
        for (var i = 0; i < maxIfs; ++i) {
            if (i > 0) {
                src += '\nelse ';
            }
            if (i < maxIfs - 1) {
                src += "if(test == " + i + ".0){}";
            }
        }
        return src;
    }
    function checkMaxIfStatementsInShader(maxIfs, gl) {
        if (maxIfs === 0) {
            throw new Error('Invalid value of `0` passed to `checkMaxIfStatementsInShader`');
        }
        var shader = gl.createShader(gl.FRAGMENT_SHADER);
        while (true) // eslint-disable-line no-constant-condition
         {
            var fragmentSrc = fragTemplate.replace(/%forloop%/gi, generateIfTestSrc(maxIfs));
            gl.shaderSource(shader, fragmentSrc);
            gl.compileShader(shader);
            if (!gl.getShaderParameter(shader, gl.COMPILE_STATUS)) {
                maxIfs = (maxIfs / 2) | 0;
            }
            else {
                // valid!
                break;
            }
        }
        return maxIfs;
    }

    // Cache the result to prevent running this over and over
    var unsafeEval;
    /**
     * Not all platforms allow to generate function code (e.g., `new Function`).
     * this provides the platform-level detection.
     * @private
     * @returns {boolean} `true` if `new Function` is supported.
     */
    function unsafeEvalSupported() {
        if (typeof unsafeEval === 'boolean') {
            return unsafeEval;
        }
        try {
            /* eslint-disable no-new-func */
            var func = new Function('param1', 'param2', 'param3', 'return param1[param2] === param3;');
            /* eslint-enable no-new-func */
            unsafeEval = func({ a: 'b' }, 'a', 'b') === true;
        }
        catch (e) {
            unsafeEval = false;
        }
        return unsafeEval;
    }

    /**
     * @namespace PIXI.glCore
     * @private
     */

    var defaultFragment$2 = "varying vec2 vTextureCoord;\n\nuniform sampler2D uSampler;\n\nvoid main(void){\n   gl_FragColor *= texture2D(uSampler, vTextureCoord);\n}";

    var defaultVertex$3 = "attribute vec2 aVertexPosition;\nattribute vec2 aTextureCoord;\n\nuniform mat3 projectionMatrix;\n\nvarying vec2 vTextureCoord;\n\nvoid main(void){\n   gl_Position = vec4((projectionMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\n   vTextureCoord = aTextureCoord;\n}\n";

    var UID$1 = 0;
    var nameCache = {};
    /**
     * Helper class to create a shader program.
     * @memberof PIXI
     */
    var Program = /** @class */ (function () {
        /**
         * @param vertexSrc - The source of the vertex shader.
         * @param fragmentSrc - The source of the fragment shader.
         * @param name - Name for shader
         */
        function Program(vertexSrc, fragmentSrc, name) {
            if (name === void 0) { name = 'pixi-shader'; }
            this.id = UID$1++;
            this.vertexSrc = vertexSrc || Program.defaultVertexSrc;
            this.fragmentSrc = fragmentSrc || Program.defaultFragmentSrc;
            this.vertexSrc = this.vertexSrc.trim();
            this.fragmentSrc = this.fragmentSrc.trim();
            if (this.vertexSrc.substring(0, 8) !== '#version') {
                name = name.replace(/\s+/g, '-');
                if (nameCache[name]) {
                    nameCache[name]++;
                    name += "-" + nameCache[name];
                }
                else {
                    nameCache[name] = 1;
                }
                this.vertexSrc = "#define SHADER_NAME " + name + "\n" + this.vertexSrc;
                this.fragmentSrc = "#define SHADER_NAME " + name + "\n" + this.fragmentSrc;
                this.vertexSrc = setPrecision(this.vertexSrc, settings.settings.PRECISION_VERTEX, constants.PRECISION.HIGH);
                this.fragmentSrc = setPrecision(this.fragmentSrc, settings.settings.PRECISION_FRAGMENT, getMaxFragmentPrecision());
            }
            // currently this does not extract structs only default types
            // this is where we store shader references..
            this.glPrograms = {};
            this.syncUniforms = null;
        }
        Object.defineProperty(Program, "defaultVertexSrc", {
            /**
             * The default vertex shader source.
             * @constant
             */
            get: function () {
                return defaultVertex$3;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Program, "defaultFragmentSrc", {
            /**
             * The default fragment shader source.
             * @constant
             */
            get: function () {
                return defaultFragment$2;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * A short hand function to create a program based of a vertex and fragment shader.
         *
         * This method will also check to see if there is a cached program.
         * @param vertexSrc - The source of the vertex shader.
         * @param fragmentSrc - The source of the fragment shader.
         * @param name - Name for shader
         * @returns A shiny new PixiJS shader program!
         */
        Program.from = function (vertexSrc, fragmentSrc, name) {
            var key = vertexSrc + fragmentSrc;
            var program = utils.ProgramCache[key];
            if (!program) {
                utils.ProgramCache[key] = program = new Program(vertexSrc, fragmentSrc, name);
            }
            return program;
        };
        return Program;
    }());

    /**
     * A helper class for shaders.
     * @memberof PIXI
     */
    var Shader = /** @class */ (function () {
        /**
         * @param program - The program the shader will use.
         * @param uniforms - Custom uniforms to use to augment the built-in ones.
         */
        function Shader(program, uniforms) {
            /**
             * Used internally to bind uniform buffer objects.
             * @ignore
             */
            this.uniformBindCount = 0;
            this.program = program;
            // lets see whats been passed in
            // uniforms should be converted to a uniform group
            if (uniforms) {
                if (uniforms instanceof UniformGroup) {
                    this.uniformGroup = uniforms;
                }
                else {
                    this.uniformGroup = new UniformGroup(uniforms);
                }
            }
            else {
                this.uniformGroup = new UniformGroup({});
            }
        }
        // TODO move to shader system..
        Shader.prototype.checkUniformExists = function (name, group) {
            if (group.uniforms[name]) {
                return true;
            }
            for (var i in group.uniforms) {
                var uniform = group.uniforms[i];
                if (uniform.group) {
                    if (this.checkUniformExists(name, uniform)) {
                        return true;
                    }
                }
            }
            return false;
        };
        Shader.prototype.destroy = function () {
            // usage count on programs?
            // remove if not used!
            this.uniformGroup = null;
        };
        Object.defineProperty(Shader.prototype, "uniforms", {
            /**
             * Shader uniform values, shortcut for `uniformGroup.uniforms`.
             * @readonly
             */
            get: function () {
                return this.uniformGroup.uniforms;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * A short hand function to create a shader based of a vertex and fragment shader.
         * @param vertexSrc - The source of the vertex shader.
         * @param fragmentSrc - The source of the fragment shader.
         * @param uniforms - Custom uniforms to use to augment the built-in ones.
         * @returns A shiny new PixiJS shader!
         */
        Shader.from = function (vertexSrc, fragmentSrc, uniforms) {
            var program = Program.from(vertexSrc, fragmentSrc);
            return new Shader(program, uniforms);
        };
        return Shader;
    }());

    /* eslint-disable max-len */
    var BLEND$1 = 0;
    var OFFSET$1 = 1;
    var CULLING$1 = 2;
    var DEPTH_TEST$1 = 3;
    var WINDING$1 = 4;
    var DEPTH_MASK$1 = 5;
    /**
     * This is a WebGL state, and is is passed to {@link PIXI.StateSystem}.
     *
     * Each mesh rendered may require WebGL to be in a different state.
     * For example you may want different blend mode or to enable polygon offsets
     * @memberof PIXI
     */
    var State = /** @class */ (function () {
        function State() {
            this.data = 0;
            this.blendMode = constants.BLEND_MODES.NORMAL;
            this.polygonOffset = 0;
            this.blend = true;
            this.depthMask = true;
            //  this.depthTest = true;
        }
        Object.defineProperty(State.prototype, "blend", {
            /**
             * Activates blending of the computed fragment color values.
             * @default true
             */
            get: function () {
                return !!(this.data & (1 << BLEND$1));
            },
            set: function (value) {
                if (!!(this.data & (1 << BLEND$1)) !== value) {
                    this.data ^= (1 << BLEND$1);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(State.prototype, "offsets", {
            /**
             * Activates adding an offset to depth values of polygon's fragments
             * @default false
             */
            get: function () {
                return !!(this.data & (1 << OFFSET$1));
            },
            set: function (value) {
                if (!!(this.data & (1 << OFFSET$1)) !== value) {
                    this.data ^= (1 << OFFSET$1);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(State.prototype, "culling", {
            /**
             * Activates culling of polygons.
             * @default false
             */
            get: function () {
                return !!(this.data & (1 << CULLING$1));
            },
            set: function (value) {
                if (!!(this.data & (1 << CULLING$1)) !== value) {
                    this.data ^= (1 << CULLING$1);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(State.prototype, "depthTest", {
            /**
             * Activates depth comparisons and updates to the depth buffer.
             * @default false
             */
            get: function () {
                return !!(this.data & (1 << DEPTH_TEST$1));
            },
            set: function (value) {
                if (!!(this.data & (1 << DEPTH_TEST$1)) !== value) {
                    this.data ^= (1 << DEPTH_TEST$1);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(State.prototype, "depthMask", {
            /**
             * Enables or disables writing to the depth buffer.
             * @default true
             */
            get: function () {
                return !!(this.data & (1 << DEPTH_MASK$1));
            },
            set: function (value) {
                if (!!(this.data & (1 << DEPTH_MASK$1)) !== value) {
                    this.data ^= (1 << DEPTH_MASK$1);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(State.prototype, "clockwiseFrontFace", {
            /**
             * Specifies whether or not front or back-facing polygons can be culled.
             * @default false
             */
            get: function () {
                return !!(this.data & (1 << WINDING$1));
            },
            set: function (value) {
                if (!!(this.data & (1 << WINDING$1)) !== value) {
                    this.data ^= (1 << WINDING$1);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(State.prototype, "blendMode", {
            /**
             * The blend mode to be applied when this state is set. Apply a value of `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
             * Setting this mode to anything other than NO_BLEND will automatically switch blending on.
             * @default PIXI.BLEND_MODES.NORMAL
             */
            get: function () {
                return this._blendMode;
            },
            set: function (value) {
                this.blend = (value !== constants.BLEND_MODES.NONE);
                this._blendMode = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(State.prototype, "polygonOffset", {
            /**
             * The polygon offset. Setting this property to anything other than 0 will automatically enable polygon offset fill.
             * @default 0
             */
            get: function () {
                return this._polygonOffset;
            },
            set: function (value) {
                this.offsets = !!value;
                this._polygonOffset = value;
            },
            enumerable: false,
            configurable: true
        });
        State.prototype.toString = function () {
            return "[@pixi/core:State "
                + ("blendMode=" + this.blendMode + " ")
                + ("clockwiseFrontFace=" + this.clockwiseFrontFace + " ")
                + ("culling=" + this.culling + " ")
                + ("depthMask=" + this.depthMask + " ")
                + ("polygonOffset=" + this.polygonOffset)
                + "]";
        };
        State.for2d = function () {
            var state = new State();
            state.depthTest = false;
            state.blend = true;
            return state;
        };
        return State;
    }());

    var defaultFragment$1 = "varying vec2 vTextureCoord;\n\nuniform sampler2D uSampler;\n\nvoid main(void){\n   gl_FragColor = texture2D(uSampler, vTextureCoord);\n}\n";

    var defaultVertex$2 = "attribute vec2 aVertexPosition;\n\nuniform mat3 projectionMatrix;\n\nvarying vec2 vTextureCoord;\n\nuniform vec4 inputSize;\nuniform vec4 outputFrame;\n\nvec4 filterVertexPosition( void )\n{\n    vec2 position = aVertexPosition * max(outputFrame.zw, vec2(0.)) + outputFrame.xy;\n\n    return vec4((projectionMatrix * vec3(position, 1.0)).xy, 0.0, 1.0);\n}\n\nvec2 filterTextureCoord( void )\n{\n    return aVertexPosition * (outputFrame.zw * inputSize.zw);\n}\n\nvoid main(void)\n{\n    gl_Position = filterVertexPosition();\n    vTextureCoord = filterTextureCoord();\n}\n";

    /**
     * A filter is a special shader that applies post-processing effects to an input texture and writes into an output
     * render-target.
     *
     * {@link http://pixijs.io/examples/#/filters/blur-filter.js Example} of the
     * {@link PIXI.filters.BlurFilter BlurFilter}.
     *
     * ### Usage
     * Filters can be applied to any DisplayObject or Container.
     * PixiJS' `FilterSystem` renders the container into temporary Framebuffer,
     * then filter renders it to the screen.
     * Multiple filters can be added to the `filters` array property and stacked on each other.
     *
     * ```
     * const filter = new PIXI.Filter(myShaderVert, myShaderFrag, { myUniform: 0.5 });
     * const container = new PIXI.Container();
     * container.filters = [filter];
     * ```
     *
     * ### Previous Version Differences
     *
     * In PixiJS **v3**, a filter was always applied to _whole screen_.
     *
     * In PixiJS **v4**, a filter can be applied _only part of the screen_.
     * Developers had to create a set of uniforms to deal with coordinates.
     *
     * In PixiJS **v5** combines _both approaches_.
     * Developers can use normal coordinates of v3 and then allow filter to use partial Framebuffers,
     * bringing those extra uniforms into account.
     *
     * Also be aware that we have changed default vertex shader, please consult
     * {@link https://github.com/pixijs/pixi.js/wiki/v5-Creating-filters Wiki}.
     *
     * ### Frames
     *
     * The following table summarizes the coordinate spaces used in the filtering pipeline:
     *
     * <table>
     * <thead>
     *   <tr>
     *     <th>Coordinate Space</th>
     *     <th>Description</th>
     *   </tr>
     * </thead>
     * <tbody>
     *   <tr>
     *     <td>Texture Coordinates</td>
     *     <td>
     *         The texture (or UV) coordinates in the input base-texture's space. These are normalized into the (0,1) range along
     *         both axes.
     *     </td>
     *   </tr>
     *   <tr>
     *     <td>World Space</td>
     *     <td>
     *         A point in the same space as the world bounds of any display-object (i.e. in the scene graph's space).
     *     </td>
     *   </tr>
     *   <tr>
     *     <td>Physical Pixels</td>
     *     <td>
     *         This is base-texture's space with the origin on the top-left. You can calculate these by multiplying the texture
     *         coordinates by the dimensions of the texture.
     *     </td>
     *   </tr>
     * </tbody>
     * </table>
     *
     * ### Built-in Uniforms
     *
     * PixiJS viewport uses screen (CSS) coordinates, `(0, 0, renderer.screen.width, renderer.screen.height)`,
     * and `projectionMatrix` uniform maps it to the gl viewport.
     *
     * **uSampler**
     *
     * The most important uniform is the input texture that container was rendered into.
     * _Important note: as with all Framebuffers in PixiJS, both input and output are
     * premultiplied by alpha._
     *
     * By default, input normalized coordinates are passed to fragment shader with `vTextureCoord`.
     * Use it to sample the input.
     *
     * ```
     * const fragment = `
     * varying vec2 vTextureCoord;
     * uniform sampler2D uSampler;
     * void main(void)
     * {
     *    gl_FragColor = texture2D(uSampler, vTextureCoord);
     * }
     * `;
     *
     * const myFilter = new PIXI.Filter(null, fragment);
     * ```
     *
     * This filter is just one uniform less than {@link PIXI.filters.AlphaFilter AlphaFilter}.
     *
     * **outputFrame**
     *
     * The `outputFrame` holds the rectangle where filter is applied in screen (CSS) coordinates.
     * It's the same as `renderer.screen` for a fullscreen filter.
     * Only a part of  `outputFrame.zw` size of temporary Framebuffer is used,
     * `(0, 0, outputFrame.width, outputFrame.height)`,
     *
     * Filters uses this quad to normalized (0-1) space, its passed into `aVertexPosition` attribute.
     * To calculate vertex position in screen space using normalized (0-1) space:
     *
     * ```
     * vec4 filterVertexPosition( void )
     * {
     *     vec2 position = aVertexPosition * max(outputFrame.zw, vec2(0.)) + outputFrame.xy;
     *     return vec4((projectionMatrix * vec3(position, 1.0)).xy, 0.0, 1.0);
     * }
     * ```
     *
     * **inputSize**
     *
     * Temporary framebuffer is different, it can be either the size of screen, either power-of-two.
     * The `inputSize.xy` are size of temporary framebuffer that holds input.
     * The `inputSize.zw` is inverted, it's a shortcut to evade division inside the shader.
     *
     * Set `inputSize.xy = outputFrame.zw` for a fullscreen filter.
     *
     * To calculate input normalized coordinate, you have to map it to filter normalized space.
     * Multiply by `outputFrame.zw` to get input coordinate.
     * Divide by `inputSize.xy` to get input normalized coordinate.
     *
     * ```
     * vec2 filterTextureCoord( void )
     * {
     *     return aVertexPosition * (outputFrame.zw * inputSize.zw); // same as /inputSize.xy
     * }
     * ```
     * **resolution**
     *
     * The `resolution` is the ratio of screen (CSS) pixels to real pixels.
     *
     * **inputPixel**
     *
     * `inputPixel.xy` is the size of framebuffer in real pixels, same as `inputSize.xy * resolution`
     * `inputPixel.zw` is inverted `inputPixel.xy`.
     *
     * It's handy for filters that use neighbour pixels, like {@link PIXI.filters.FXAAFilter FXAAFilter}.
     *
     * **inputClamp**
     *
     * If you try to get info from outside of used part of Framebuffer - you'll get undefined behaviour.
     * For displacements, coordinates has to be clamped.
     *
     * The `inputClamp.xy` is left-top pixel center, you may ignore it, because we use left-top part of Framebuffer
     * `inputClamp.zw` is bottom-right pixel center.
     *
     * ```
     * vec4 color = texture2D(uSampler, clamp(modifiedTextureCoord, inputClamp.xy, inputClamp.zw))
     * ```
     * OR
     * ```
     * vec4 color = texture2D(uSampler, min(modifigedTextureCoord, inputClamp.zw))
     * ```
     *
     * ### Additional Information
     *
     * Complete documentation on Filter usage is located in the
     * {@link https://github.com/pixijs/pixi.js/wiki/v5-Creating-filters Wiki}.
     *
     * Since PixiJS only had a handful of built-in filters, additional filters can be downloaded
     * {@link https://github.com/pixijs/pixi-filters here} from the PixiJS Filters repository.
     * @memberof PIXI
     */
    var Filter = /** @class */ (function (_super) {
        __extends(Filter, _super);
        /**
         * @param vertexSrc - The source of the vertex shader.
         * @param fragmentSrc - The source of the fragment shader.
         * @param uniforms - Custom uniforms to use to augment the built-in ones.
         */
        function Filter(vertexSrc, fragmentSrc, uniforms) {
            var _this = this;
            var program = Program.from(vertexSrc || Filter.defaultVertexSrc, fragmentSrc || Filter.defaultFragmentSrc);
            _this = _super.call(this, program, uniforms) || this;
            _this.padding = 0;
            _this.resolution = settings.settings.FILTER_RESOLUTION;
            _this.multisample = settings.settings.FILTER_MULTISAMPLE;
            _this.enabled = true;
            _this.autoFit = true;
            _this.state = new State();
            return _this;
        }
        /**
         * Applies the filter
         * @param {PIXI.FilterSystem} filterManager - The renderer to retrieve the filter from
         * @param {PIXI.RenderTexture} input - The input render target.
         * @param {PIXI.RenderTexture} output - The target to output to.
         * @param {PIXI.CLEAR_MODES} [clearMode] - Should the output be cleared before rendering to it.
         * @param {object} [_currentState] - It's current state of filter.
         *        There are some useful properties in the currentState :
         *        target, filters, sourceFrame, destinationFrame, renderTarget, resolution
         */
        Filter.prototype.apply = function (filterManager, input, output, clearMode, _currentState) {
            // do as you please!
            filterManager.applyFilter(this, input, output, clearMode);
            // or just do a regular render..
        };
        Object.defineProperty(Filter.prototype, "blendMode", {
            /**
             * Sets the blend mode of the filter.
             * @default PIXI.BLEND_MODES.NORMAL
             */
            get: function () {
                return this.state.blendMode;
            },
            set: function (value) {
                this.state.blendMode = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Filter.prototype, "resolution", {
            /**
             * The resolution of the filter. Setting this to be lower will lower the quality but
             * increase the performance of the filter.
             */
            get: function () {
                return this._resolution;
            },
            set: function (value) {
                this._resolution = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Filter, "defaultVertexSrc", {
            /**
             * The default vertex shader source
             * @constant
             */
            get: function () {
                return defaultVertex$2;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Filter, "defaultFragmentSrc", {
            /**
             * The default fragment shader source
             * @constant
             */
            get: function () {
                return defaultFragment$1;
            },
            enumerable: false,
            configurable: true
        });
        return Filter;
    }(Shader));

    var vertex = "attribute vec2 aVertexPosition;\nattribute vec2 aTextureCoord;\n\nuniform mat3 projectionMatrix;\nuniform mat3 otherMatrix;\n\nvarying vec2 vMaskCoord;\nvarying vec2 vTextureCoord;\n\nvoid main(void)\n{\n    gl_Position = vec4((projectionMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\n\n    vTextureCoord = aTextureCoord;\n    vMaskCoord = ( otherMatrix * vec3( aTextureCoord, 1.0)  ).xy;\n}\n";

    var fragment = "varying vec2 vMaskCoord;\nvarying vec2 vTextureCoord;\n\nuniform sampler2D uSampler;\nuniform sampler2D mask;\nuniform float alpha;\nuniform float npmAlpha;\nuniform vec4 maskClamp;\n\nvoid main(void)\n{\n    float clip = step(3.5,\n        step(maskClamp.x, vMaskCoord.x) +\n        step(maskClamp.y, vMaskCoord.y) +\n        step(vMaskCoord.x, maskClamp.z) +\n        step(vMaskCoord.y, maskClamp.w));\n\n    vec4 original = texture2D(uSampler, vTextureCoord);\n    vec4 masky = texture2D(mask, vMaskCoord);\n    float alphaMul = 1.0 - npmAlpha * (1.0 - masky.a);\n\n    original *= (alphaMul * masky.r * alpha * clip);\n\n    gl_FragColor = original;\n}\n";

    var tempMat = new math.Matrix();
    /**
     * Class controls uv mapping from Texture normal space to BaseTexture normal space.
     *
     * Takes `trim` and `rotate` into account. May contain clamp settings for Meshes and TilingSprite.
     *
     * Can be used in Texture `uvMatrix` field, or separately, you can use different clamp settings on the same texture.
     * If you want to add support for texture region of certain feature or filter, that's what you're looking for.
     *
     * Takes track of Texture changes through `_lastTextureID` private field.
     * Use `update()` method call to track it from outside.
     * @see PIXI.Texture
     * @see PIXI.Mesh
     * @see PIXI.TilingSprite
     * @memberof PIXI
     */
    var TextureMatrix = /** @class */ (function () {
        /**
         * @param texture - observed texture
         * @param clampMargin - Changes frame clamping, 0.5 by default. Use -0.5 for extra border.
         */
        function TextureMatrix(texture, clampMargin) {
            this._texture = texture;
            this.mapCoord = new math.Matrix();
            this.uClampFrame = new Float32Array(4);
            this.uClampOffset = new Float32Array(2);
            this._textureID = -1;
            this._updateID = 0;
            this.clampOffset = 0;
            this.clampMargin = (typeof clampMargin === 'undefined') ? 0.5 : clampMargin;
            this.isSimple = false;
        }
        Object.defineProperty(TextureMatrix.prototype, "texture", {
            /** Texture property. */
            get: function () {
                return this._texture;
            },
            set: function (value) {
                this._texture = value;
                this._textureID = -1;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Multiplies uvs array to transform
         * @param uvs - mesh uvs
         * @param [out=uvs] - output
         * @returns - output
         */
        TextureMatrix.prototype.multiplyUvs = function (uvs, out) {
            if (out === undefined) {
                out = uvs;
            }
            var mat = this.mapCoord;
            for (var i = 0; i < uvs.length; i += 2) {
                var x = uvs[i];
                var y = uvs[i + 1];
                out[i] = (x * mat.a) + (y * mat.c) + mat.tx;
                out[i + 1] = (x * mat.b) + (y * mat.d) + mat.ty;
            }
            return out;
        };
        /**
         * Updates matrices if texture was changed.
         * @param [forceUpdate=false] - if true, matrices will be updated any case
         * @returns - Whether or not it was updated
         */
        TextureMatrix.prototype.update = function (forceUpdate) {
            var tex = this._texture;
            if (!tex || !tex.valid) {
                return false;
            }
            if (!forceUpdate
                && this._textureID === tex._updateID) {
                return false;
            }
            this._textureID = tex._updateID;
            this._updateID++;
            var uvs = tex._uvs;
            this.mapCoord.set(uvs.x1 - uvs.x0, uvs.y1 - uvs.y0, uvs.x3 - uvs.x0, uvs.y3 - uvs.y0, uvs.x0, uvs.y0);
            var orig = tex.orig;
            var trim = tex.trim;
            if (trim) {
                tempMat.set(orig.width / trim.width, 0, 0, orig.height / trim.height, -trim.x / trim.width, -trim.y / trim.height);
                this.mapCoord.append(tempMat);
            }
            var texBase = tex.baseTexture;
            var frame = this.uClampFrame;
            var margin = this.clampMargin / texBase.resolution;
            var offset = this.clampOffset;
            frame[0] = (tex._frame.x + margin + offset) / texBase.width;
            frame[1] = (tex._frame.y + margin + offset) / texBase.height;
            frame[2] = (tex._frame.x + tex._frame.width - margin + offset) / texBase.width;
            frame[3] = (tex._frame.y + tex._frame.height - margin + offset) / texBase.height;
            this.uClampOffset[0] = offset / texBase.realWidth;
            this.uClampOffset[1] = offset / texBase.realHeight;
            this.isSimple = tex._frame.width === texBase.width
                && tex._frame.height === texBase.height
                && tex.rotate === 0;
            return true;
        };
        return TextureMatrix;
    }());

    /**
     * This handles a Sprite acting as a mask, as opposed to a Graphic.
     *
     * WebGL only.
     * @memberof PIXI
     */
    var SpriteMaskFilter = /** @class */ (function (_super) {
        __extends(SpriteMaskFilter, _super);
        /** @ignore */
        function SpriteMaskFilter(vertexSrc, fragmentSrc, uniforms) {
            var _this = this;
            var sprite = null;
            if (typeof vertexSrc !== 'string' && fragmentSrc === undefined && uniforms === undefined) {
                sprite = vertexSrc;
                vertexSrc = undefined;
                fragmentSrc = undefined;
                uniforms = undefined;
            }
            _this = _super.call(this, vertexSrc || vertex, fragmentSrc || fragment, uniforms) || this;
            _this.maskSprite = sprite;
            _this.maskMatrix = new math.Matrix();
            return _this;
        }
        Object.defineProperty(SpriteMaskFilter.prototype, "maskSprite", {
            /**
             * Sprite mask
             * @type {PIXI.DisplayObject}
             */
            get: function () {
                return this._maskSprite;
            },
            set: function (value) {
                this._maskSprite = value;
                if (this._maskSprite) {
                    this._maskSprite.renderable = false;
                }
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Applies the filter
         * @param filterManager - The renderer to retrieve the filter from
         * @param input - The input render target.
         * @param output - The target to output to.
         * @param clearMode - Should the output be cleared before rendering to it.
         */
        SpriteMaskFilter.prototype.apply = function (filterManager, input, output, clearMode) {
            var maskSprite = this._maskSprite;
            var tex = maskSprite._texture;
            if (!tex.valid) {
                return;
            }
            if (!tex.uvMatrix) {
                // margin = 0.0, let it bleed a bit, shader code becomes easier
                // assuming that atlas textures were made with 1-pixel padding
                tex.uvMatrix = new TextureMatrix(tex, 0.0);
            }
            tex.uvMatrix.update();
            this.uniforms.npmAlpha = tex.baseTexture.alphaMode ? 0.0 : 1.0;
            this.uniforms.mask = tex;
            // get _normalized sprite texture coords_ and convert them to _normalized atlas texture coords_ with `prepend`
            this.uniforms.otherMatrix = filterManager.calculateSpriteMatrix(this.maskMatrix, maskSprite)
                .prepend(tex.uvMatrix.mapCoord);
            this.uniforms.alpha = maskSprite.worldAlpha;
            this.uniforms.maskClamp = tex.uvMatrix.uClampFrame;
            filterManager.applyFilter(this, input, output, clearMode);
        };
        return SpriteMaskFilter;
    }(Filter));

    /**
     * System plugin to the renderer to manage masks.
     *
     * There are three built-in types of masking:
     * **Scissor Masking**: Scissor masking discards pixels that are outside of a rectangle called the scissor box. It is
     *  the most performant as the scissor test is inexpensive. However, it can only be used when the mask is rectangular.
     * **Stencil Masking**: Stencil masking discards pixels that don't overlap with the pixels rendered into the stencil
     *  buffer. It is the next fastest option as it does not require rendering into a separate framebuffer. However, it does
     *  cause the mask to be rendered **twice** for each masking operation; hence, minimize the rendering cost of your masks.
     * **Sprite Mask Filtering**: Sprite mask filtering discards pixels based on the red channel of the sprite-mask's
     *  texture. (Generally, the masking texture is grayscale). Using advanced techniques, you might be able to embed this
     *  type of masking in a custom shader - and hence, bypassing the masking system fully for performance wins.
     *
     * The best type of masking is auto-detected when you `push` one. To use scissor masking, you must pass in a `Graphics`
     * object with just a rectangle drawn.
     *
     * ## Mask Stacks
     *
     * In the scene graph, masks can be applied recursively, i.e. a mask can be applied during a masking operation. The mask
     * stack stores the currently applied masks in order. Each {@link PIXI.BaseRenderTexture} holds its own mask stack, i.e.
     * when you switch render-textures, the old masks only applied when you switch back to rendering to the old render-target.
     * @memberof PIXI
     */
    var MaskSystem = /** @class */ (function () {
        /**
         * @param renderer - The renderer this System works for.
         */
        function MaskSystem(renderer) {
            this.renderer = renderer;
            this.enableScissor = true;
            this.alphaMaskPool = [];
            this.maskDataPool = [];
            this.maskStack = [];
            this.alphaMaskIndex = 0;
        }
        /**
         * Changes the mask stack that is used by this System.
         * @param maskStack - The mask stack
         */
        MaskSystem.prototype.setMaskStack = function (maskStack) {
            this.maskStack = maskStack;
            this.renderer.scissor.setMaskStack(maskStack);
            this.renderer.stencil.setMaskStack(maskStack);
        };
        /**
         * Enables the mask and appends it to the current mask stack.
         *
         * NOTE: The batch renderer should be flushed beforehand to prevent pending renders from being masked.
         * @param {PIXI.DisplayObject} target - Display Object to push the mask to
         * @param {PIXI.MaskData|PIXI.Sprite|PIXI.Graphics|PIXI.DisplayObject} maskDataOrTarget - The masking data.
         */
        MaskSystem.prototype.push = function (target, maskDataOrTarget) {
            var maskData = maskDataOrTarget;
            if (!maskData.isMaskData) {
                var d = this.maskDataPool.pop() || new MaskData();
                d.pooled = true;
                d.maskObject = maskDataOrTarget;
                maskData = d;
            }
            var maskAbove = this.maskStack.length !== 0 ? this.maskStack[this.maskStack.length - 1] : null;
            maskData.copyCountersOrReset(maskAbove);
            maskData._colorMask = maskAbove ? maskAbove._colorMask : 0xf;
            if (maskData.autoDetect) {
                this.detect(maskData);
            }
            maskData._target = target;
            if (maskData.type !== constants.MASK_TYPES.SPRITE) {
                this.maskStack.push(maskData);
            }
            if (maskData.enabled) {
                switch (maskData.type) {
                    case constants.MASK_TYPES.SCISSOR:
                        this.renderer.scissor.push(maskData);
                        break;
                    case constants.MASK_TYPES.STENCIL:
                        this.renderer.stencil.push(maskData);
                        break;
                    case constants.MASK_TYPES.SPRITE:
                        maskData.copyCountersOrReset(null);
                        this.pushSpriteMask(maskData);
                        break;
                    case constants.MASK_TYPES.COLOR:
                        this.pushColorMask(maskData);
                        break;
                    default:
                        break;
                }
            }
            if (maskData.type === constants.MASK_TYPES.SPRITE) {
                this.maskStack.push(maskData);
            }
        };
        /**
         * Removes the last mask from the mask stack and doesn't return it.
         *
         * NOTE: The batch renderer should be flushed beforehand to render the masked contents before the mask is removed.
         * @param {PIXI.IMaskTarget} target - Display Object to pop the mask from
         */
        MaskSystem.prototype.pop = function (target) {
            var maskData = this.maskStack.pop();
            if (!maskData || maskData._target !== target) {
                // TODO: add an assert when we have it
                return;
            }
            if (maskData.enabled) {
                switch (maskData.type) {
                    case constants.MASK_TYPES.SCISSOR:
                        this.renderer.scissor.pop(maskData);
                        break;
                    case constants.MASK_TYPES.STENCIL:
                        this.renderer.stencil.pop(maskData.maskObject);
                        break;
                    case constants.MASK_TYPES.SPRITE:
                        this.popSpriteMask(maskData);
                        break;
                    case constants.MASK_TYPES.COLOR:
                        this.popColorMask(maskData);
                        break;
                    default:
                        break;
                }
            }
            maskData.reset();
            if (maskData.pooled) {
                this.maskDataPool.push(maskData);
            }
            if (this.maskStack.length !== 0) {
                var maskCurrent = this.maskStack[this.maskStack.length - 1];
                if (maskCurrent.type === constants.MASK_TYPES.SPRITE && maskCurrent._filters) {
                    maskCurrent._filters[0].maskSprite = maskCurrent.maskObject;
                }
            }
        };
        /**
         * Sets type of MaskData based on its maskObject.
         * @param maskData
         */
        MaskSystem.prototype.detect = function (maskData) {
            var maskObject = maskData.maskObject;
            if (!maskObject) {
                maskData.type = constants.MASK_TYPES.COLOR;
            }
            else if (maskObject.isSprite) {
                maskData.type = constants.MASK_TYPES.SPRITE;
            }
            else if (this.enableScissor && this.renderer.scissor.testScissor(maskData)) {
                maskData.type = constants.MASK_TYPES.SCISSOR;
            }
            else {
                maskData.type = constants.MASK_TYPES.STENCIL;
            }
        };
        /**
         * Applies the Mask and adds it to the current filter stack.
         * @param maskData - Sprite to be used as the mask.
         */
        MaskSystem.prototype.pushSpriteMask = function (maskData) {
            var _a, _b;
            var maskObject = maskData.maskObject;
            var target = maskData._target;
            var alphaMaskFilter = maskData._filters;
            if (!alphaMaskFilter) {
                alphaMaskFilter = this.alphaMaskPool[this.alphaMaskIndex];
                if (!alphaMaskFilter) {
                    alphaMaskFilter = this.alphaMaskPool[this.alphaMaskIndex] = [new SpriteMaskFilter()];
                }
            }
            var renderer = this.renderer;
            var renderTextureSystem = renderer.renderTexture;
            var resolution;
            var multisample;
            if (renderTextureSystem.current) {
                var renderTexture = renderTextureSystem.current;
                resolution = maskData.resolution || renderTexture.resolution;
                multisample = (_a = maskData.multisample) !== null && _a !== void 0 ? _a : renderTexture.multisample;
            }
            else {
                resolution = maskData.resolution || renderer.resolution;
                multisample = (_b = maskData.multisample) !== null && _b !== void 0 ? _b : renderer.multisample;
            }
            alphaMaskFilter[0].resolution = resolution;
            alphaMaskFilter[0].multisample = multisample;
            alphaMaskFilter[0].maskSprite = maskObject;
            var stashFilterArea = target.filterArea;
            target.filterArea = maskObject.getBounds(true);
            renderer.filter.push(target, alphaMaskFilter);
            target.filterArea = stashFilterArea;
            if (!maskData._filters) {
                this.alphaMaskIndex++;
            }
        };
        /**
         * Removes the last filter from the filter stack and doesn't return it.
         * @param maskData - Sprite to be used as the mask.
         */
        MaskSystem.prototype.popSpriteMask = function (maskData) {
            this.renderer.filter.pop();
            if (maskData._filters) {
                maskData._filters[0].maskSprite = null;
            }
            else {
                this.alphaMaskIndex--;
                this.alphaMaskPool[this.alphaMaskIndex][0].maskSprite = null;
            }
        };
        /**
         * Pushes the color mask.
         * @param maskData - The mask data
         */
        MaskSystem.prototype.pushColorMask = function (maskData) {
            var currColorMask = maskData._colorMask;
            var nextColorMask = maskData._colorMask = currColorMask & maskData.colorMask;
            if (nextColorMask !== currColorMask) {
                this.renderer.gl.colorMask((nextColorMask & 0x1) !== 0, (nextColorMask & 0x2) !== 0, (nextColorMask & 0x4) !== 0, (nextColorMask & 0x8) !== 0);
            }
        };
        /**
         * Pops the color mask.
         * @param maskData - The mask data
         */
        MaskSystem.prototype.popColorMask = function (maskData) {
            var currColorMask = maskData._colorMask;
            var nextColorMask = this.maskStack.length > 0
                ? this.maskStack[this.maskStack.length - 1]._colorMask : 0xf;
            if (nextColorMask !== currColorMask) {
                this.renderer.gl.colorMask((nextColorMask & 0x1) !== 0, (nextColorMask & 0x2) !== 0, (nextColorMask & 0x4) !== 0, (nextColorMask & 0x8) !== 0);
            }
        };
        MaskSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return MaskSystem;
    }());

    /**
     * System plugin to the renderer to manage specific types of masking operations.
     * @memberof PIXI
     */
    var AbstractMaskSystem = /** @class */ (function () {
        /**
         * @param renderer - The renderer this System works for.
         */
        function AbstractMaskSystem(renderer) {
            this.renderer = renderer;
            this.maskStack = [];
            this.glConst = 0;
        }
        /** Gets count of masks of certain type. */
        AbstractMaskSystem.prototype.getStackLength = function () {
            return this.maskStack.length;
        };
        /**
         * Changes the mask stack that is used by this System.
         * @param {PIXI.MaskData[]} maskStack - The mask stack
         */
        AbstractMaskSystem.prototype.setMaskStack = function (maskStack) {
            var gl = this.renderer.gl;
            var curStackLen = this.getStackLength();
            this.maskStack = maskStack;
            var newStackLen = this.getStackLength();
            if (newStackLen !== curStackLen) {
                if (newStackLen === 0) {
                    gl.disable(this.glConst);
                }
                else {
                    gl.enable(this.glConst);
                    this._useCurrent();
                }
            }
        };
        /**
         * Setup renderer to use the current mask data.
         * @private
         */
        AbstractMaskSystem.prototype._useCurrent = function () {
            // OVERWRITE;
        };
        /** Destroys the mask stack. */
        AbstractMaskSystem.prototype.destroy = function () {
            this.renderer = null;
            this.maskStack = null;
        };
        return AbstractMaskSystem;
    }());

    var tempMatrix$1 = new math.Matrix();
    var rectPool = [];
    /**
     * System plugin to the renderer to manage scissor masking.
     *
     * Scissor masking discards pixels outside of a rectangle called the scissor box. The scissor box is in the framebuffer
     * viewport's space; however, the mask's rectangle is projected from world-space to viewport space automatically
     * by this system.
     * @memberof PIXI
     */
    var ScissorSystem = /** @class */ (function (_super) {
        __extends(ScissorSystem, _super);
        /**
         * @param {PIXI.Renderer} renderer - The renderer this System works for.
         */
        function ScissorSystem(renderer) {
            var _this = _super.call(this, renderer) || this;
            _this.glConst = settings.settings.ADAPTER.getWebGLRenderingContext().SCISSOR_TEST;
            return _this;
        }
        ScissorSystem.prototype.getStackLength = function () {
            var maskData = this.maskStack[this.maskStack.length - 1];
            if (maskData) {
                return maskData._scissorCounter;
            }
            return 0;
        };
        /**
         * evaluates _boundsTransformed, _scissorRect for MaskData
         * @param maskData
         */
        ScissorSystem.prototype.calcScissorRect = function (maskData) {
            var _a;
            if (maskData._scissorRectLocal) {
                return;
            }
            var prevData = maskData._scissorRect;
            var maskObject = maskData.maskObject;
            var renderer = this.renderer;
            var renderTextureSystem = renderer.renderTexture;
            var rect = maskObject.getBounds(true, (_a = rectPool.pop()) !== null && _a !== void 0 ? _a : new math.Rectangle());
            this.roundFrameToPixels(rect, renderTextureSystem.current ? renderTextureSystem.current.resolution : renderer.resolution, renderTextureSystem.sourceFrame, renderTextureSystem.destinationFrame, renderer.projection.transform);
            if (prevData) {
                rect.fit(prevData);
            }
            maskData._scissorRectLocal = rect;
        };
        ScissorSystem.isMatrixRotated = function (matrix) {
            if (!matrix) {
                return false;
            }
            var a = matrix.a, b = matrix.b, c = matrix.c, d = matrix.d;
            // Skip if skew/rotation present in matrix, except for multiple of 90?? rotation. If rotation
            // is a multiple of 90??, then either pair of (b,c) or (a,d) will be (0,0).
            return ((Math.abs(b) > 1e-4 || Math.abs(c) > 1e-4)
                && (Math.abs(a) > 1e-4 || Math.abs(d) > 1e-4));
        };
        /**
         * Test, whether the object can be scissor mask with current renderer projection.
         * Calls "calcScissorRect()" if its true.
         * @param maskData - mask data
         * @returns whether Whether the object can be scissor mask
         */
        ScissorSystem.prototype.testScissor = function (maskData) {
            var maskObject = maskData.maskObject;
            if (!maskObject.isFastRect || !maskObject.isFastRect()) {
                return false;
            }
            if (ScissorSystem.isMatrixRotated(maskObject.worldTransform)) {
                return false;
            }
            if (ScissorSystem.isMatrixRotated(this.renderer.projection.transform)) {
                return false;
            }
            this.calcScissorRect(maskData);
            var rect = maskData._scissorRectLocal;
            return rect.width > 0 && rect.height > 0;
        };
        ScissorSystem.prototype.roundFrameToPixels = function (frame, resolution, bindingSourceFrame, bindingDestinationFrame, transform) {
            if (ScissorSystem.isMatrixRotated(transform)) {
                return;
            }
            transform = transform ? tempMatrix$1.copyFrom(transform) : tempMatrix$1.identity();
            // Get forward transform from world space to screen space
            transform
                .translate(-bindingSourceFrame.x, -bindingSourceFrame.y)
                .scale(bindingDestinationFrame.width / bindingSourceFrame.width, bindingDestinationFrame.height / bindingSourceFrame.height)
                .translate(bindingDestinationFrame.x, bindingDestinationFrame.y);
            // Convert frame to screen space
            this.renderer.filter.transformAABB(transform, frame);
            frame.fit(bindingDestinationFrame);
            frame.x = Math.round(frame.x * resolution);
            frame.y = Math.round(frame.y * resolution);
            frame.width = Math.round(frame.width * resolution);
            frame.height = Math.round(frame.height * resolution);
        };
        /**
         * Applies the Mask and adds it to the current stencil stack.
         * @author alvin
         * @param maskData - The mask data.
         */
        ScissorSystem.prototype.push = function (maskData) {
            if (!maskData._scissorRectLocal) {
                this.calcScissorRect(maskData);
            }
            var gl = this.renderer.gl;
            if (!maskData._scissorRect) {
                gl.enable(gl.SCISSOR_TEST);
            }
            maskData._scissorCounter++;
            maskData._scissorRect = maskData._scissorRectLocal;
            this._useCurrent();
        };
        /**
         * This should be called after a mask is popped off the mask stack. It will rebind the scissor box to be latest with the
         * last mask in the stack.
         *
         * This can also be called when you directly modify the scissor box and want to restore PixiJS state.
         * @param maskData - The mask data.
         */
        ScissorSystem.prototype.pop = function (maskData) {
            var gl = this.renderer.gl;
            if (maskData) {
                rectPool.push(maskData._scissorRectLocal);
            }
            if (this.getStackLength() > 0) {
                this._useCurrent();
            }
            else {
                gl.disable(gl.SCISSOR_TEST);
            }
        };
        /**
         * Setup renderer to use the current scissor data.
         * @private
         */
        ScissorSystem.prototype._useCurrent = function () {
            var rect = this.maskStack[this.maskStack.length - 1]._scissorRect;
            var y;
            if (this.renderer.renderTexture.current) {
                y = rect.y;
            }
            else {
                // flipY. In future we'll have it over renderTextures as an option
                y = this.renderer.height - rect.height - rect.y;
            }
            this.renderer.gl.scissor(rect.x, y, rect.width, rect.height);
        };
        return ScissorSystem;
    }(AbstractMaskSystem));

    /**
     * System plugin to the renderer to manage stencils (used for masks).
     * @memberof PIXI
     */
    var StencilSystem = /** @class */ (function (_super) {
        __extends(StencilSystem, _super);
        /**
         * @param renderer - The renderer this System works for.
         */
        function StencilSystem(renderer) {
            var _this = _super.call(this, renderer) || this;
            _this.glConst = settings.settings.ADAPTER.getWebGLRenderingContext().STENCIL_TEST;
            return _this;
        }
        StencilSystem.prototype.getStackLength = function () {
            var maskData = this.maskStack[this.maskStack.length - 1];
            if (maskData) {
                return maskData._stencilCounter;
            }
            return 0;
        };
        /**
         * Applies the Mask and adds it to the current stencil stack.
         * @param maskData - The mask data
         */
        StencilSystem.prototype.push = function (maskData) {
            var maskObject = maskData.maskObject;
            var gl = this.renderer.gl;
            var prevMaskCount = maskData._stencilCounter;
            if (prevMaskCount === 0) {
                // force use stencil texture in current framebuffer
                this.renderer.framebuffer.forceStencil();
                gl.clearStencil(0);
                gl.clear(gl.STENCIL_BUFFER_BIT);
                gl.enable(gl.STENCIL_TEST);
            }
            maskData._stencilCounter++;
            var colorMask = maskData._colorMask;
            if (colorMask !== 0) {
                maskData._colorMask = 0;
                gl.colorMask(false, false, false, false);
            }
            // Increment the reference stencil value where the new mask overlaps with the old ones.
            gl.stencilFunc(gl.EQUAL, prevMaskCount, 0xFFFFFFFF);
            gl.stencilOp(gl.KEEP, gl.KEEP, gl.INCR);
            maskObject.renderable = true;
            maskObject.render(this.renderer);
            this.renderer.batch.flush();
            maskObject.renderable = false;
            if (colorMask !== 0) {
                maskData._colorMask = colorMask;
                gl.colorMask((colorMask & 1) !== 0, (colorMask & 2) !== 0, (colorMask & 4) !== 0, (colorMask & 8) !== 0);
            }
            this._useCurrent();
        };
        /**
         * Pops stencil mask. MaskData is already removed from stack
         * @param {PIXI.DisplayObject} maskObject - object of popped mask data
         */
        StencilSystem.prototype.pop = function (maskObject) {
            var gl = this.renderer.gl;
            if (this.getStackLength() === 0) {
                // the stack is empty!
                gl.disable(gl.STENCIL_TEST);
            }
            else {
                var maskData = this.maskStack.length !== 0 ? this.maskStack[this.maskStack.length - 1] : null;
                var colorMask = maskData ? maskData._colorMask : 0xf;
                if (colorMask !== 0) {
                    maskData._colorMask = 0;
                    gl.colorMask(false, false, false, false);
                }
                // Decrement the reference stencil value where the popped mask overlaps with the other ones
                gl.stencilOp(gl.KEEP, gl.KEEP, gl.DECR);
                maskObject.renderable = true;
                maskObject.render(this.renderer);
                this.renderer.batch.flush();
                maskObject.renderable = false;
                if (colorMask !== 0) {
                    maskData._colorMask = colorMask;
                    gl.colorMask((colorMask & 0x1) !== 0, (colorMask & 0x2) !== 0, (colorMask & 0x4) !== 0, (colorMask & 0x8) !== 0);
                }
                this._useCurrent();
            }
        };
        /**
         * Setup renderer to use the current stencil data.
         * @private
         */
        StencilSystem.prototype._useCurrent = function () {
            var gl = this.renderer.gl;
            gl.stencilFunc(gl.EQUAL, this.getStackLength(), 0xFFFFFFFF);
            gl.stencilOp(gl.KEEP, gl.KEEP, gl.KEEP);
        };
        return StencilSystem;
    }(AbstractMaskSystem));

    /**
     * System plugin to the renderer to manage the projection matrix.
     *
     * The `projectionMatrix` is a global uniform provided to all shaders. It is used to transform points in world space to
     * normalized device coordinates.
     * @memberof PIXI
     */
    var ProjectionSystem = /** @class */ (function () {
        /** @param renderer - The renderer this System works for. */
        function ProjectionSystem(renderer) {
            this.renderer = renderer;
            this.destinationFrame = null;
            this.sourceFrame = null;
            this.defaultFrame = null;
            this.projectionMatrix = new math.Matrix();
            this.transform = null;
        }
        /**
         * Updates the projection-matrix based on the sourceFrame ??? destinationFrame mapping provided.
         *
         * NOTE: It is expected you call `renderer.framebuffer.setViewport(destinationFrame)` after this. This is because
         * the framebuffer viewport converts shader vertex output in normalized device coordinates to window coordinates.
         *
         * NOTE-2: {@link RenderTextureSystem#bind} updates the projection-matrix when you bind a render-texture. It is expected
         * that you dirty the current bindings when calling this manually.
         * @param destinationFrame - The rectangle in the render-target to render the contents into. If rendering to the canvas,
         *  the origin is on the top-left; if rendering to a render-texture, the origin is on the bottom-left.
         * @param sourceFrame - The rectangle in world space that contains the contents being rendered.
         * @param resolution - The resolution of the render-target, which is the ratio of
         *  world-space (or CSS) pixels to physical pixels.
         * @param root - Whether the render-target is the screen. This is required because rendering to textures
         *  is y-flipped (i.e. upside down relative to the screen).
         */
        ProjectionSystem.prototype.update = function (destinationFrame, sourceFrame, resolution, root) {
            this.destinationFrame = destinationFrame || this.destinationFrame || this.defaultFrame;
            this.sourceFrame = sourceFrame || this.sourceFrame || destinationFrame;
            // Calculate object-space to clip-space projection
            this.calculateProjection(this.destinationFrame, this.sourceFrame, resolution, root);
            if (this.transform) {
                this.projectionMatrix.append(this.transform);
            }
            var renderer = this.renderer;
            renderer.globalUniforms.uniforms.projectionMatrix = this.projectionMatrix;
            renderer.globalUniforms.update();
            // this will work for now
            // but would be sweet to stick and even on the global uniforms..
            if (renderer.shader.shader) {
                renderer.shader.syncUniformGroup(renderer.shader.shader.uniforms.globals);
            }
        };
        /**
         * Calculates the `projectionMatrix` to map points inside `sourceFrame` to inside `destinationFrame`.
         * @param _destinationFrame - The destination frame in the render-target.
         * @param sourceFrame - The source frame in world space.
         * @param _resolution - The render-target's resolution, i.e. ratio of CSS to physical pixels.
         * @param root - Whether rendering into the screen. Otherwise, if rendering to a framebuffer, the projection
         *  is y-flipped.
         */
        ProjectionSystem.prototype.calculateProjection = function (_destinationFrame, sourceFrame, _resolution, root) {
            var pm = this.projectionMatrix;
            var sign = !root ? 1 : -1;
            pm.identity();
            pm.a = (1 / sourceFrame.width * 2);
            pm.d = sign * (1 / sourceFrame.height * 2);
            pm.tx = -1 - (sourceFrame.x * pm.a);
            pm.ty = -sign - (sourceFrame.y * pm.d);
        };
        /**
         * Sets the transform of the active render target to the given matrix.
         * @param _matrix - The transformation matrix
         */
        ProjectionSystem.prototype.setTransform = function (_matrix) {
            // this._activeRenderTarget.transform = matrix;
        };
        ProjectionSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return ProjectionSystem;
    }());

    // Temporary rectangle for assigned sourceFrame or destinationFrame
    var tempRect = new math.Rectangle();
    // Temporary rectangle for renderTexture destinationFrame
    var tempRect2 = new math.Rectangle();
    /* eslint-disable max-len */
    /**
     * System plugin to the renderer to manage render textures.
     *
     * Should be added after FramebufferSystem
     *
     * ### Frames
     *
     * The `RenderTextureSystem` holds a sourceFrame ??? destinationFrame projection. The following table explains the different
     * coordinate spaces used:
     *
     * | Frame                  | Description                                                      | Coordinate System                                       |
     * | ---------------------- | ---------------------------------------------------------------- | ------------------------------------------------------- |
     * | sourceFrame            | The rectangle inside of which display-objects are being rendered | **World Space**: The origin on the top-left             |
     * | destinationFrame       | The rectangle in the render-target (canvas or texture) into which contents should be rendered | If rendering to the canvas, this is in screen space and the origin is on the top-left. If rendering to a render-texture, this is in its base-texture's space with the origin on the bottom-left.  |
     * | viewportFrame          | The framebuffer viewport corresponding to the destination-frame  | **Window Coordinates**: The origin is always on the bottom-left. |
     * @memberof PIXI
     */
    var RenderTextureSystem = /** @class */ (function () {
        /**
         * @param renderer - The renderer this System works for.
         */
        function RenderTextureSystem(renderer) {
            this.renderer = renderer;
            this.clearColor = renderer._backgroundColorRgba;
            this.defaultMaskStack = [];
            this.current = null;
            this.sourceFrame = new math.Rectangle();
            this.destinationFrame = new math.Rectangle();
            this.viewportFrame = new math.Rectangle();
        }
        /**
         * Bind the current render texture.
         * @param renderTexture - RenderTexture to bind, by default its `null` - the screen.
         * @param sourceFrame - Part of world that is mapped to the renderTexture.
         * @param destinationFrame - Part of renderTexture, by default it has the same size as sourceFrame.
         */
        RenderTextureSystem.prototype.bind = function (renderTexture, sourceFrame, destinationFrame) {
            if (renderTexture === void 0) { renderTexture = null; }
            var renderer = this.renderer;
            this.current = renderTexture;
            var baseTexture;
            var framebuffer;
            var resolution;
            if (renderTexture) {
                baseTexture = renderTexture.baseTexture;
                resolution = baseTexture.resolution;
                if (!sourceFrame) {
                    tempRect.width = renderTexture.frame.width;
                    tempRect.height = renderTexture.frame.height;
                    sourceFrame = tempRect;
                }
                if (!destinationFrame) {
                    tempRect2.x = renderTexture.frame.x;
                    tempRect2.y = renderTexture.frame.y;
                    tempRect2.width = sourceFrame.width;
                    tempRect2.height = sourceFrame.height;
                    destinationFrame = tempRect2;
                }
                framebuffer = baseTexture.framebuffer;
            }
            else {
                resolution = renderer.resolution;
                if (!sourceFrame) {
                    tempRect.width = renderer.screen.width;
                    tempRect.height = renderer.screen.height;
                    sourceFrame = tempRect;
                }
                if (!destinationFrame) {
                    destinationFrame = tempRect;
                    destinationFrame.width = sourceFrame.width;
                    destinationFrame.height = sourceFrame.height;
                }
            }
            var viewportFrame = this.viewportFrame;
            viewportFrame.x = destinationFrame.x * resolution;
            viewportFrame.y = destinationFrame.y * resolution;
            viewportFrame.width = destinationFrame.width * resolution;
            viewportFrame.height = destinationFrame.height * resolution;
            if (!renderTexture) {
                viewportFrame.y = renderer.view.height - (viewportFrame.y + viewportFrame.height);
            }
            viewportFrame.ceil();
            this.renderer.framebuffer.bind(framebuffer, viewportFrame);
            this.renderer.projection.update(destinationFrame, sourceFrame, resolution, !framebuffer);
            if (renderTexture) {
                this.renderer.mask.setMaskStack(baseTexture.maskStack);
            }
            else {
                this.renderer.mask.setMaskStack(this.defaultMaskStack);
            }
            this.sourceFrame.copyFrom(sourceFrame);
            this.destinationFrame.copyFrom(destinationFrame);
        };
        /**
         * Erases the render texture and fills the drawing area with a colour.
         * @param clearColor - The color as rgba, default to use the renderer backgroundColor
         * @param [mask=BUFFER_BITS.COLOR | BUFFER_BITS.DEPTH] - Bitwise OR of masks
         *  that indicate the buffers to be cleared, by default COLOR and DEPTH buffers.
         */
        RenderTextureSystem.prototype.clear = function (clearColor, mask) {
            if (this.current) {
                clearColor = clearColor || this.current.baseTexture.clearColor;
            }
            else {
                clearColor = clearColor || this.clearColor;
            }
            var destinationFrame = this.destinationFrame;
            var baseFrame = this.current ? this.current.baseTexture : this.renderer.screen;
            var clearMask = destinationFrame.width !== baseFrame.width || destinationFrame.height !== baseFrame.height;
            if (clearMask) {
                var _a = this.viewportFrame, x = _a.x, y = _a.y, width = _a.width, height = _a.height;
                x = Math.round(x);
                y = Math.round(y);
                width = Math.round(width);
                height = Math.round(height);
                // TODO: ScissorSystem should cache whether the scissor test is enabled or not.
                this.renderer.gl.enable(this.renderer.gl.SCISSOR_TEST);
                this.renderer.gl.scissor(x, y, width, height);
            }
            this.renderer.framebuffer.clear(clearColor[0], clearColor[1], clearColor[2], clearColor[3], mask);
            if (clearMask) {
                // Restore the scissor box
                this.renderer.scissor.pop();
            }
        };
        RenderTextureSystem.prototype.resize = function () {
            // resize the root only!
            this.bind(null);
        };
        /** Resets render-texture state. */
        RenderTextureSystem.prototype.reset = function () {
            this.bind(null);
        };
        RenderTextureSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return RenderTextureSystem;
    }());

    function uboUpdate(_ud, _uv, _renderer, _syncData, buffer) {
        _renderer.buffer.update(buffer);
    }
    // cv = CachedValue
    // v = value
    // ud = uniformData
    // uv = uniformValue
    // l = location
    var UBO_TO_SINGLE_SETTERS = {
        float: "\n        data[offset] = v;\n    ",
        vec2: "\n        data[offset] = v[0];\n        data[offset+1] = v[1];\n    ",
        vec3: "\n        data[offset] = v[0];\n        data[offset+1] = v[1];\n        data[offset+2] = v[2];\n\n    ",
        vec4: "\n        data[offset] = v[0];\n        data[offset+1] = v[1];\n        data[offset+2] = v[2];\n        data[offset+3] = v[3];\n    ",
        mat2: "\n        data[offset] = v[0];\n        data[offset+1] = v[1];\n\n        data[offset+4] = v[2];\n        data[offset+5] = v[3];\n    ",
        mat3: "\n        data[offset] = v[0];\n        data[offset+1] = v[1];\n        data[offset+2] = v[2];\n\n        data[offset + 4] = v[3];\n        data[offset + 5] = v[4];\n        data[offset + 6] = v[5];\n\n        data[offset + 8] = v[6];\n        data[offset + 9] = v[7];\n        data[offset + 10] = v[8];\n    ",
        mat4: "\n        for(var i = 0; i < 16; i++)\n        {\n            data[offset + i] = v[i];\n        }\n    "
    };
    var GLSL_TO_STD40_SIZE = {
        float: 4,
        vec2: 8,
        vec3: 12,
        vec4: 16,
        int: 4,
        ivec2: 8,
        ivec3: 12,
        ivec4: 16,
        uint: 4,
        uvec2: 8,
        uvec3: 12,
        uvec4: 16,
        bool: 4,
        bvec2: 8,
        bvec3: 12,
        bvec4: 16,
        mat2: 16 * 2,
        mat3: 16 * 3,
        mat4: 16 * 4,
    };
    /**
     * logic originally from here: https://github.com/sketchpunk/FunWithWebGL2/blob/master/lesson_022/Shaders.js
     * rewrote it, but this was a great starting point to get a solid understanding of whats going on :)
     * @ignore
     * @param uniformData
     */
    function createUBOElements(uniformData) {
        var uboElements = uniformData.map(function (data) {
            return ({
                data: data,
                offset: 0,
                dataLen: 0,
                dirty: 0
            });
        });
        var size = 0;
        var chunkSize = 0;
        var offset = 0;
        for (var i = 0; i < uboElements.length; i++) {
            var uboElement = uboElements[i];
            size = GLSL_TO_STD40_SIZE[uboElement.data.type];
            if (uboElement.data.size > 1) {
                size = Math.max(size, 16) * uboElement.data.size;
            }
            uboElement.dataLen = size;
            // add some size offset..
            // must align to the nearest 16 bytes or internally nearest round size
            if (chunkSize % size !== 0 && chunkSize < 16) {
                // diff required to line up..
                var lineUpValue = (chunkSize % size) % 16;
                chunkSize += lineUpValue;
                offset += lineUpValue;
            }
            if ((chunkSize + size) > 16) {
                offset = Math.ceil(offset / 16) * 16;
                uboElement.offset = offset;
                offset += size;
                chunkSize = size;
            }
            else {
                uboElement.offset = offset;
                chunkSize += size;
                offset += size;
            }
        }
        offset = Math.ceil(offset / 16) * 16;
        return { uboElements: uboElements, size: offset };
    }
    function getUBOData(uniforms, uniformData) {
        var usedUniformDatas = [];
        // build..
        for (var i in uniforms) {
            if (uniformData[i]) {
                usedUniformDatas.push(uniformData[i]);
            }
        }
        // sort them out by index!
        usedUniformDatas.sort(function (a, b) { return a.index - b.index; });
        return usedUniformDatas;
    }
    function generateUniformBufferSync(group, uniformData) {
        if (!group.autoManage) {
            // if the group is nott automatically managed, we don't need to generate a special function for it...
            return { size: 0, syncFunc: uboUpdate };
        }
        var usedUniformDatas = getUBOData(group.uniforms, uniformData);
        var _a = createUBOElements(usedUniformDatas), uboElements = _a.uboElements, size = _a.size;
        var funcFragments = ["\n    var v = null;\n    var v2 = null;\n    var cv = null;\n    var t = 0;\n    var gl = renderer.gl\n    var index = 0;\n    var data = buffer.data;\n    "];
        for (var i = 0; i < uboElements.length; i++) {
            var uboElement = uboElements[i];
            var uniform = group.uniforms[uboElement.data.name];
            var name = uboElement.data.name;
            var parsed = false;
            for (var j = 0; j < uniformParsers.length; j++) {
                var uniformParser = uniformParsers[j];
                if (uniformParser.codeUbo && uniformParser.test(uboElement.data, uniform)) {
                    funcFragments.push("offset = " + uboElement.offset / 4 + ";", uniformParsers[j].codeUbo(uboElement.data.name, uniform));
                    parsed = true;
                    break;
                }
            }
            if (!parsed) {
                if (uboElement.data.size > 1) {
                    var size_1 = mapSize(uboElement.data.type);
                    var rowSize = Math.max(GLSL_TO_STD40_SIZE[uboElement.data.type] / 16, 1);
                    var elementSize = size_1 / rowSize;
                    var remainder = (4 - (elementSize % 4)) % 4;
                    funcFragments.push("\n                cv = ud." + name + ".value;\n                v = uv." + name + ";\n                offset = " + uboElement.offset / 4 + ";\n\n                t = 0;\n\n                for(var i=0; i < " + uboElement.data.size * rowSize + "; i++)\n                {\n                    for(var j = 0; j < " + elementSize + "; j++)\n                    {\n                        data[offset++] = v[t++];\n                    }\n                    offset += " + remainder + ";\n                }\n\n                ");
                }
                else {
                    var template = UBO_TO_SINGLE_SETTERS[uboElement.data.type];
                    funcFragments.push("\n                cv = ud." + name + ".value;\n                v = uv." + name + ";\n                offset = " + uboElement.offset / 4 + ";\n                " + template + ";\n                ");
                }
            }
        }
        funcFragments.push("\n       renderer.buffer.update(buffer);\n    ");
        return {
            size: size,
            // eslint-disable-next-line no-new-func
            syncFunc: new Function('ud', 'uv', 'renderer', 'syncData', 'buffer', funcFragments.join('\n'))
        };
    }

    /**
     * @private
     */
    var IGLUniformData = /** @class */ (function () {
        function IGLUniformData() {
        }
        return IGLUniformData;
    }());
    /**
     * Helper class to create a WebGL Program
     * @memberof PIXI
     */
    var GLProgram = /** @class */ (function () {
        /**
         * Makes a new Pixi program.
         * @param program - webgl program
         * @param uniformData - uniforms
         */
        function GLProgram(program, uniformData) {
            this.program = program;
            this.uniformData = uniformData;
            this.uniformGroups = {};
            this.uniformDirtyGroups = {};
            this.uniformBufferBindings = {};
        }
        /** Destroys this program. */
        GLProgram.prototype.destroy = function () {
            this.uniformData = null;
            this.uniformGroups = null;
            this.uniformDirtyGroups = null;
            this.uniformBufferBindings = null;
            this.program = null;
        };
        return GLProgram;
    }());

    /**
     * returns the attribute data from the program
     * @private
     * @param {WebGLProgram} [program] - the WebGL program
     * @param {WebGLRenderingContext} [gl] - the WebGL context
     * @returns {object} the attribute data for this program
     */
    function getAttributeData(program, gl) {
        var attributes = {};
        var totalAttributes = gl.getProgramParameter(program, gl.ACTIVE_ATTRIBUTES);
        for (var i = 0; i < totalAttributes; i++) {
            var attribData = gl.getActiveAttrib(program, i);
            if (attribData.name.indexOf('gl_') === 0) {
                continue;
            }
            var type = mapType(gl, attribData.type);
            var data = {
                type: type,
                name: attribData.name,
                size: mapSize(type),
                location: gl.getAttribLocation(program, attribData.name),
            };
            attributes[attribData.name] = data;
        }
        return attributes;
    }

    /**
     * returns the uniform data from the program
     * @private
     * @param program - the webgl program
     * @param gl - the WebGL context
     * @returns {object} the uniform data for this program
     */
    function getUniformData(program, gl) {
        var uniforms = {};
        var totalUniforms = gl.getProgramParameter(program, gl.ACTIVE_UNIFORMS);
        for (var i = 0; i < totalUniforms; i++) {
            var uniformData = gl.getActiveUniform(program, i);
            var name = uniformData.name.replace(/\[.*?\]$/, '');
            var isArray = !!(uniformData.name.match(/\[.*?\]$/));
            var type = mapType(gl, uniformData.type);
            uniforms[name] = {
                name: name,
                index: i,
                type: type,
                size: uniformData.size,
                isArray: isArray,
                value: defaultValue(type, uniformData.size),
            };
        }
        return uniforms;
    }

    /**
     * generates a WebGL Program object from a high level Pixi Program.
     * @param gl - a rendering context on which to generate the program
     * @param program - the high level Pixi Program.
     */
    function generateProgram(gl, program) {
        var glVertShader = compileShader(gl, gl.VERTEX_SHADER, program.vertexSrc);
        var glFragShader = compileShader(gl, gl.FRAGMENT_SHADER, program.fragmentSrc);
        var webGLProgram = gl.createProgram();
        gl.attachShader(webGLProgram, glVertShader);
        gl.attachShader(webGLProgram, glFragShader);
        gl.linkProgram(webGLProgram);
        if (!gl.getProgramParameter(webGLProgram, gl.LINK_STATUS)) {
            logProgramError(gl, webGLProgram, glVertShader, glFragShader);
        }
        program.attributeData = getAttributeData(webGLProgram, gl);
        program.uniformData = getUniformData(webGLProgram, gl);
        // GLSL 1.00: bind attributes sorted by name in ascending order
        // GLSL 3.00: don't change the attribute locations that where chosen by the compiler
        //            or assigned by the layout specifier in the shader source code
        if (!(/^[ \t]*#[ \t]*version[ \t]+300[ \t]+es[ \t]*$/m).test(program.vertexSrc)) {
            var keys = Object.keys(program.attributeData);
            keys.sort(function (a, b) { return (a > b) ? 1 : -1; }); // eslint-disable-line no-confusing-arrow
            for (var i = 0; i < keys.length; i++) {
                program.attributeData[keys[i]].location = i;
                gl.bindAttribLocation(webGLProgram, i, keys[i]);
            }
            gl.linkProgram(webGLProgram);
        }
        gl.deleteShader(glVertShader);
        gl.deleteShader(glFragShader);
        var uniformData = {};
        for (var i in program.uniformData) {
            var data = program.uniformData[i];
            uniformData[i] = {
                location: gl.getUniformLocation(webGLProgram, i),
                value: defaultValue(data.type, data.size),
            };
        }
        var glProgram = new GLProgram(webGLProgram, uniformData);
        return glProgram;
    }

    var UID = 0;
    // default sync data so we don't create a new one each time!
    var defaultSyncData = { textureCount: 0, uboCount: 0 };
    /**
     * System plugin to the renderer to manage shaders.
     * @memberof PIXI
     */
    var ShaderSystem = /** @class */ (function () {
        /** @param renderer - The renderer this System works for. */
        function ShaderSystem(renderer) {
            this.destroyed = false;
            this.renderer = renderer;
            // Validation check that this environment support `new Function`
            this.systemCheck();
            this.gl = null;
            this.shader = null;
            this.program = null;
            this.cache = {};
            this._uboCache = {};
            this.id = UID++;
        }
        /**
         * Overrideable function by `@pixi/unsafe-eval` to silence
         * throwing an error if platform doesn't support unsafe-evals.
         * @private
         */
        ShaderSystem.prototype.systemCheck = function () {
            if (!unsafeEvalSupported()) {
                throw new Error('Current environment does not allow unsafe-eval, '
                    + 'please use @pixi/unsafe-eval module to enable support.');
            }
        };
        ShaderSystem.prototype.contextChange = function (gl) {
            this.gl = gl;
            this.reset();
        };
        /**
         * Changes the current shader to the one given in parameter.
         * @param shader - the new shader
         * @param dontSync - false if the shader should automatically sync its uniforms.
         * @returns the glProgram that belongs to the shader.
         */
        ShaderSystem.prototype.bind = function (shader, dontSync) {
            shader.uniforms.globals = this.renderer.globalUniforms;
            var program = shader.program;
            var glProgram = program.glPrograms[this.renderer.CONTEXT_UID] || this.generateProgram(shader);
            this.shader = shader;
            // TODO - some current Pixi plugins bypass this.. so it not safe to use yet..
            if (this.program !== program) {
                this.program = program;
                this.gl.useProgram(glProgram.program);
            }
            if (!dontSync) {
                defaultSyncData.textureCount = 0;
                defaultSyncData.uboCount = 0;
                this.syncUniformGroup(shader.uniformGroup, defaultSyncData);
            }
            return glProgram;
        };
        /**
         * Uploads the uniforms values to the currently bound shader.
         * @param uniforms - the uniforms values that be applied to the current shader
         */
        ShaderSystem.prototype.setUniforms = function (uniforms) {
            var shader = this.shader.program;
            var glProgram = shader.glPrograms[this.renderer.CONTEXT_UID];
            shader.syncUniforms(glProgram.uniformData, uniforms, this.renderer);
        };
        /* eslint-disable @typescript-eslint/explicit-module-boundary-types */
        /**
         * Syncs uniforms on the group
         * @param group - the uniform group to sync
         * @param syncData - this is data that is passed to the sync function and any nested sync functions
         */
        ShaderSystem.prototype.syncUniformGroup = function (group, syncData) {
            var glProgram = this.getGlProgram();
            if (!group.static || group.dirtyId !== glProgram.uniformDirtyGroups[group.id]) {
                glProgram.uniformDirtyGroups[group.id] = group.dirtyId;
                this.syncUniforms(group, glProgram, syncData);
            }
        };
        /**
         * Overrideable by the @pixi/unsafe-eval package to use static syncUniforms instead.
         * @param group
         * @param glProgram
         * @param syncData
         */
        ShaderSystem.prototype.syncUniforms = function (group, glProgram, syncData) {
            var syncFunc = group.syncUniforms[this.shader.program.id] || this.createSyncGroups(group);
            syncFunc(glProgram.uniformData, group.uniforms, this.renderer, syncData);
        };
        ShaderSystem.prototype.createSyncGroups = function (group) {
            var id = this.getSignature(group, this.shader.program.uniformData, 'u');
            if (!this.cache[id]) {
                this.cache[id] = generateUniformsSync(group, this.shader.program.uniformData);
            }
            group.syncUniforms[this.shader.program.id] = this.cache[id];
            return group.syncUniforms[this.shader.program.id];
        };
        /**
         * Syncs uniform buffers
         * @param group - the uniform buffer group to sync
         * @param name - the name of the uniform buffer
         */
        ShaderSystem.prototype.syncUniformBufferGroup = function (group, name) {
            var glProgram = this.getGlProgram();
            if (!group.static || group.dirtyId !== 0 || !glProgram.uniformGroups[group.id]) {
                group.dirtyId = 0;
                var syncFunc = glProgram.uniformGroups[group.id]
                    || this.createSyncBufferGroup(group, glProgram, name);
                // TODO wrap update in a cache??
                group.buffer.update();
                syncFunc(glProgram.uniformData, group.uniforms, this.renderer, defaultSyncData, group.buffer);
            }
            this.renderer.buffer.bindBufferBase(group.buffer, glProgram.uniformBufferBindings[name]);
        };
        /**
         * Will create a function that uploads a uniform buffer using the STD140 standard.
         * The upload function will then be cached for future calls
         * If a group is manually managed, then a simple upload function is generated
         * @param group - the uniform buffer group to sync
         * @param glProgram - the gl program to attach the uniform bindings to
         * @param name - the name of the uniform buffer (must exist on the shader)
         */
        ShaderSystem.prototype.createSyncBufferGroup = function (group, glProgram, name) {
            var gl = this.renderer.gl;
            this.renderer.buffer.bind(group.buffer);
            // bind them...
            var uniformBlockIndex = this.gl.getUniformBlockIndex(glProgram.program, name);
            glProgram.uniformBufferBindings[name] = this.shader.uniformBindCount;
            gl.uniformBlockBinding(glProgram.program, uniformBlockIndex, this.shader.uniformBindCount);
            this.shader.uniformBindCount++;
            var id = this.getSignature(group, this.shader.program.uniformData, 'ubo');
            var uboData = this._uboCache[id];
            if (!uboData) {
                uboData = this._uboCache[id] = generateUniformBufferSync(group, this.shader.program.uniformData);
            }
            if (group.autoManage) {
                var data = new Float32Array(uboData.size / 4);
                group.buffer.update(data);
            }
            glProgram.uniformGroups[group.id] = uboData.syncFunc;
            return glProgram.uniformGroups[group.id];
        };
        /**
         * Takes a uniform group and data and generates a unique signature for them.
         * @param group - The uniform group to get signature of
         * @param group.uniforms
         * @param uniformData - Uniform information generated by the shader
         * @param preFix
         * @returns Unique signature of the uniform group
         */
        ShaderSystem.prototype.getSignature = function (group, uniformData, preFix) {
            var uniforms = group.uniforms;
            var strings = [preFix + "-"];
            for (var i in uniforms) {
                strings.push(i);
                if (uniformData[i]) {
                    strings.push(uniformData[i].type);
                }
            }
            return strings.join('-');
        };
        /**
         * Returns the underlying GLShade rof the currently bound shader.
         *
         * This can be handy for when you to have a little more control over the setting of your uniforms.
         * @returns The glProgram for the currently bound Shader for this context
         */
        ShaderSystem.prototype.getGlProgram = function () {
            if (this.shader) {
                return this.shader.program.glPrograms[this.renderer.CONTEXT_UID];
            }
            return null;
        };
        /**
         * Generates a glProgram version of the Shader provided.
         * @param shader - The shader that the glProgram will be based on.
         * @returns A shiny new glProgram!
         */
        ShaderSystem.prototype.generateProgram = function (shader) {
            var gl = this.gl;
            var program = shader.program;
            var glProgram = generateProgram(gl, program);
            program.glPrograms[this.renderer.CONTEXT_UID] = glProgram;
            return glProgram;
        };
        /** Resets ShaderSystem state, does not affect WebGL state. */
        ShaderSystem.prototype.reset = function () {
            this.program = null;
            this.shader = null;
        };
        /** Destroys this System and removes all its textures. */
        ShaderSystem.prototype.destroy = function () {
            this.renderer = null;
            // TODO implement destroy method for ShaderSystem
            this.destroyed = true;
        };
        return ShaderSystem;
    }());

    /**
     * Maps gl blend combinations to WebGL.
     * @memberof PIXI
     * @function mapWebGLBlendModesToPixi
     * @private
     * @param {WebGLRenderingContext} gl - The rendering context.
     * @param {number[][]} [array=[]] - The array to output into.
     * @returns {number[][]} Mapped modes.
     */
    function mapWebGLBlendModesToPixi(gl, array) {
        if (array === void 0) { array = []; }
        // TODO - premultiply alpha would be different.
        // add a boolean for that!
        array[constants.BLEND_MODES.NORMAL] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.ADD] = [gl.ONE, gl.ONE];
        array[constants.BLEND_MODES.MULTIPLY] = [gl.DST_COLOR, gl.ONE_MINUS_SRC_ALPHA, gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.SCREEN] = [gl.ONE, gl.ONE_MINUS_SRC_COLOR, gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.OVERLAY] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.DARKEN] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.LIGHTEN] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.COLOR_DODGE] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.COLOR_BURN] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.HARD_LIGHT] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.SOFT_LIGHT] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.DIFFERENCE] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.EXCLUSION] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.HUE] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.SATURATION] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.COLOR] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.LUMINOSITY] = [gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.NONE] = [0, 0];
        // not-premultiplied blend modes
        array[constants.BLEND_MODES.NORMAL_NPM] = [gl.SRC_ALPHA, gl.ONE_MINUS_SRC_ALPHA, gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.ADD_NPM] = [gl.SRC_ALPHA, gl.ONE, gl.ONE, gl.ONE];
        array[constants.BLEND_MODES.SCREEN_NPM] = [gl.SRC_ALPHA, gl.ONE_MINUS_SRC_COLOR, gl.ONE, gl.ONE_MINUS_SRC_ALPHA];
        // composite operations
        array[constants.BLEND_MODES.SRC_IN] = [gl.DST_ALPHA, gl.ZERO];
        array[constants.BLEND_MODES.SRC_OUT] = [gl.ONE_MINUS_DST_ALPHA, gl.ZERO];
        array[constants.BLEND_MODES.SRC_ATOP] = [gl.DST_ALPHA, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.DST_OVER] = [gl.ONE_MINUS_DST_ALPHA, gl.ONE];
        array[constants.BLEND_MODES.DST_IN] = [gl.ZERO, gl.SRC_ALPHA];
        array[constants.BLEND_MODES.DST_OUT] = [gl.ZERO, gl.ONE_MINUS_SRC_ALPHA];
        array[constants.BLEND_MODES.DST_ATOP] = [gl.ONE_MINUS_DST_ALPHA, gl.SRC_ALPHA];
        array[constants.BLEND_MODES.XOR] = [gl.ONE_MINUS_DST_ALPHA, gl.ONE_MINUS_SRC_ALPHA];
        // SUBTRACT from flash
        array[constants.BLEND_MODES.SUBTRACT] = [gl.ONE, gl.ONE, gl.ONE, gl.ONE, gl.FUNC_REVERSE_SUBTRACT, gl.FUNC_ADD];
        return array;
    }

    var BLEND = 0;
    var OFFSET = 1;
    var CULLING = 2;
    var DEPTH_TEST = 3;
    var WINDING = 4;
    var DEPTH_MASK = 5;
    /**
     * System plugin to the renderer to manage WebGL state machines.
     * @memberof PIXI
     */
    var StateSystem = /** @class */ (function () {
        function StateSystem() {
            this.gl = null;
            this.stateId = 0;
            this.polygonOffset = 0;
            this.blendMode = constants.BLEND_MODES.NONE;
            this._blendEq = false;
            // map functions for when we set state..
            this.map = [];
            this.map[BLEND] = this.setBlend;
            this.map[OFFSET] = this.setOffset;
            this.map[CULLING] = this.setCullFace;
            this.map[DEPTH_TEST] = this.setDepthTest;
            this.map[WINDING] = this.setFrontFace;
            this.map[DEPTH_MASK] = this.setDepthMask;
            this.checks = [];
            this.defaultState = new State();
            this.defaultState.blend = true;
        }
        StateSystem.prototype.contextChange = function (gl) {
            this.gl = gl;
            this.blendModes = mapWebGLBlendModesToPixi(gl);
            this.set(this.defaultState);
            this.reset();
        };
        /**
         * Sets the current state
         * @param {*} state - The state to set.
         */
        StateSystem.prototype.set = function (state) {
            state = state || this.defaultState;
            // TODO maybe to an object check? ( this.state === state )?
            if (this.stateId !== state.data) {
                var diff = this.stateId ^ state.data;
                var i = 0;
                // order from least to most common
                while (diff) {
                    if (diff & 1) {
                        // state change!
                        this.map[i].call(this, !!(state.data & (1 << i)));
                    }
                    diff = diff >> 1;
                    i++;
                }
                this.stateId = state.data;
            }
            // based on the above settings we check for specific modes..
            // for example if blend is active we check and set the blend modes
            // or of polygon offset is active we check the poly depth.
            for (var i = 0; i < this.checks.length; i++) {
                this.checks[i](this, state);
            }
        };
        /**
         * Sets the state, when previous state is unknown.
         * @param {*} state - The state to set
         */
        StateSystem.prototype.forceState = function (state) {
            state = state || this.defaultState;
            for (var i = 0; i < this.map.length; i++) {
                this.map[i].call(this, !!(state.data & (1 << i)));
            }
            for (var i = 0; i < this.checks.length; i++) {
                this.checks[i](this, state);
            }
            this.stateId = state.data;
        };
        /**
         * Sets whether to enable or disable blending.
         * @param value - Turn on or off WebGl blending.
         */
        StateSystem.prototype.setBlend = function (value) {
            this.updateCheck(StateSystem.checkBlendMode, value);
            this.gl[value ? 'enable' : 'disable'](this.gl.BLEND);
        };
        /**
         * Sets whether to enable or disable polygon offset fill.
         * @param value - Turn on or off webgl polygon offset testing.
         */
        StateSystem.prototype.setOffset = function (value) {
            this.updateCheck(StateSystem.checkPolygonOffset, value);
            this.gl[value ? 'enable' : 'disable'](this.gl.POLYGON_OFFSET_FILL);
        };
        /**
         * Sets whether to enable or disable depth test.
         * @param value - Turn on or off webgl depth testing.
         */
        StateSystem.prototype.setDepthTest = function (value) {
            this.gl[value ? 'enable' : 'disable'](this.gl.DEPTH_TEST);
        };
        /**
         * Sets whether to enable or disable depth mask.
         * @param value - Turn on or off webgl depth mask.
         */
        StateSystem.prototype.setDepthMask = function (value) {
            this.gl.depthMask(value);
        };
        /**
         * Sets whether to enable or disable cull face.
         * @param {boolean} value - Turn on or off webgl cull face.
         */
        StateSystem.prototype.setCullFace = function (value) {
            this.gl[value ? 'enable' : 'disable'](this.gl.CULL_FACE);
        };
        /**
         * Sets the gl front face.
         * @param {boolean} value - true is clockwise and false is counter-clockwise
         */
        StateSystem.prototype.setFrontFace = function (value) {
            this.gl.frontFace(this.gl[value ? 'CW' : 'CCW']);
        };
        /**
         * Sets the blend mode.
         * @param {number} value - The blend mode to set to.
         */
        StateSystem.prototype.setBlendMode = function (value) {
            if (value === this.blendMode) {
                return;
            }
            this.blendMode = value;
            var mode = this.blendModes[value];
            var gl = this.gl;
            if (mode.length === 2) {
                gl.blendFunc(mode[0], mode[1]);
            }
            else {
                gl.blendFuncSeparate(mode[0], mode[1], mode[2], mode[3]);
            }
            if (mode.length === 6) {
                this._blendEq = true;
                gl.blendEquationSeparate(mode[4], mode[5]);
            }
            else if (this._blendEq) {
                this._blendEq = false;
                gl.blendEquationSeparate(gl.FUNC_ADD, gl.FUNC_ADD);
            }
        };
        /**
         * Sets the polygon offset.
         * @param {number} value - the polygon offset
         * @param {number} scale - the polygon offset scale
         */
        StateSystem.prototype.setPolygonOffset = function (value, scale) {
            this.gl.polygonOffset(value, scale);
        };
        // used
        /** Resets all the logic and disables the VAOs. */
        StateSystem.prototype.reset = function () {
            this.gl.pixelStorei(this.gl.UNPACK_FLIP_Y_WEBGL, false);
            this.forceState(this.defaultState);
            this._blendEq = true;
            this.blendMode = -1;
            this.setBlendMode(0);
        };
        /**
         * Checks to see which updates should be checked based on which settings have been activated.
         *
         * For example, if blend is enabled then we should check the blend modes each time the state is changed
         * or if polygon fill is activated then we need to check if the polygon offset changes.
         * The idea is that we only check what we have too.
         * @param func - the checking function to add or remove
         * @param value - should the check function be added or removed.
         */
        StateSystem.prototype.updateCheck = function (func, value) {
            var index = this.checks.indexOf(func);
            if (value && index === -1) {
                this.checks.push(func);
            }
            else if (!value && index !== -1) {
                this.checks.splice(index, 1);
            }
        };
        /**
         * A private little wrapper function that we call to check the blend mode.
         * @param system - the System to perform the state check on
         * @param state - the state that the blendMode will pulled from
         */
        StateSystem.checkBlendMode = function (system, state) {
            system.setBlendMode(state.blendMode);
        };
        /**
         * A private little wrapper function that we call to check the polygon offset.
         * @param system - the System to perform the state check on
         * @param state - the state that the blendMode will pulled from
         */
        StateSystem.checkPolygonOffset = function (system, state) {
            system.setPolygonOffset(1, state.polygonOffset);
        };
        /**
         * @ignore
         */
        StateSystem.prototype.destroy = function () {
            this.gl = null;
        };
        return StateSystem;
    }());

    /**
     * System plugin to the renderer to manage texture garbage collection on the GPU,
     * ensuring that it does not get clogged up with textures that are no longer being used.
     * @memberof PIXI
     */
    var TextureGCSystem = /** @class */ (function () {
        /** @param renderer - The renderer this System works for. */
        function TextureGCSystem(renderer) {
            this.renderer = renderer;
            this.count = 0;
            this.checkCount = 0;
            this.maxIdle = settings.settings.GC_MAX_IDLE;
            this.checkCountMax = settings.settings.GC_MAX_CHECK_COUNT;
            this.mode = settings.settings.GC_MODE;
        }
        /**
         * Checks to see when the last time a texture was used
         * if the texture has not been used for a specified amount of time it will be removed from the GPU
         */
        TextureGCSystem.prototype.postrender = function () {
            if (!this.renderer.renderingToScreen) {
                return;
            }
            this.count++;
            if (this.mode === constants.GC_MODES.MANUAL) {
                return;
            }
            this.checkCount++;
            if (this.checkCount > this.checkCountMax) {
                this.checkCount = 0;
                this.run();
            }
        };
        /**
         * Checks to see when the last time a texture was used
         * if the texture has not been used for a specified amount of time it will be removed from the GPU
         */
        TextureGCSystem.prototype.run = function () {
            var tm = this.renderer.texture;
            var managedTextures = tm.managedTextures;
            var wasRemoved = false;
            for (var i = 0; i < managedTextures.length; i++) {
                var texture = managedTextures[i];
                // only supports non generated textures at the moment!
                if (!texture.framebuffer && this.count - texture.touched > this.maxIdle) {
                    tm.destroyTexture(texture, true);
                    managedTextures[i] = null;
                    wasRemoved = true;
                }
            }
            if (wasRemoved) {
                var j = 0;
                for (var i = 0; i < managedTextures.length; i++) {
                    if (managedTextures[i] !== null) {
                        managedTextures[j++] = managedTextures[i];
                    }
                }
                managedTextures.length = j;
            }
        };
        /**
         * Removes all the textures within the specified displayObject and its children from the GPU
         * @param {PIXI.DisplayObject} displayObject - the displayObject to remove the textures from.
         */
        TextureGCSystem.prototype.unload = function (displayObject) {
            var tm = this.renderer.texture;
            var texture = displayObject._texture;
            // only destroy non generated textures
            if (texture && !texture.framebuffer) {
                tm.destroyTexture(texture);
            }
            for (var i = displayObject.children.length - 1; i >= 0; i--) {
                this.unload(displayObject.children[i]);
            }
        };
        TextureGCSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return TextureGCSystem;
    }());

    /**
     * Returns a lookup table that maps each type-format pair to a compatible internal format.
     * @memberof PIXI
     * @function mapTypeAndFormatToInternalFormat
     * @private
     * @param {WebGLRenderingContext} gl - The rendering context.
     * @returns Lookup table.
     */
    function mapTypeAndFormatToInternalFormat(gl) {
        var _a, _b, _c, _d, _e, _f, _g, _h, _j, _k, _l, _m, _o, _p, _q, _r, _s, _t, _u, _v, _w, _x;
        var table;
        if ('WebGL2RenderingContext' in globalThis && gl instanceof globalThis.WebGL2RenderingContext) {
            table = (_a = {},
                _a[constants.TYPES.UNSIGNED_BYTE] = (_b = {},
                    _b[constants.FORMATS.RGBA] = gl.RGBA8,
                    _b[constants.FORMATS.RGB] = gl.RGB8,
                    _b[constants.FORMATS.RG] = gl.RG8,
                    _b[constants.FORMATS.RED] = gl.R8,
                    _b[constants.FORMATS.RGBA_INTEGER] = gl.RGBA8UI,
                    _b[constants.FORMATS.RGB_INTEGER] = gl.RGB8UI,
                    _b[constants.FORMATS.RG_INTEGER] = gl.RG8UI,
                    _b[constants.FORMATS.RED_INTEGER] = gl.R8UI,
                    _b[constants.FORMATS.ALPHA] = gl.ALPHA,
                    _b[constants.FORMATS.LUMINANCE] = gl.LUMINANCE,
                    _b[constants.FORMATS.LUMINANCE_ALPHA] = gl.LUMINANCE_ALPHA,
                    _b),
                _a[constants.TYPES.BYTE] = (_c = {},
                    _c[constants.FORMATS.RGBA] = gl.RGBA8_SNORM,
                    _c[constants.FORMATS.RGB] = gl.RGB8_SNORM,
                    _c[constants.FORMATS.RG] = gl.RG8_SNORM,
                    _c[constants.FORMATS.RED] = gl.R8_SNORM,
                    _c[constants.FORMATS.RGBA_INTEGER] = gl.RGBA8I,
                    _c[constants.FORMATS.RGB_INTEGER] = gl.RGB8I,
                    _c[constants.FORMATS.RG_INTEGER] = gl.RG8I,
                    _c[constants.FORMATS.RED_INTEGER] = gl.R8I,
                    _c),
                _a[constants.TYPES.UNSIGNED_SHORT] = (_d = {},
                    _d[constants.FORMATS.RGBA_INTEGER] = gl.RGBA16UI,
                    _d[constants.FORMATS.RGB_INTEGER] = gl.RGB16UI,
                    _d[constants.FORMATS.RG_INTEGER] = gl.RG16UI,
                    _d[constants.FORMATS.RED_INTEGER] = gl.R16UI,
                    _d[constants.FORMATS.DEPTH_COMPONENT] = gl.DEPTH_COMPONENT16,
                    _d),
                _a[constants.TYPES.SHORT] = (_e = {},
                    _e[constants.FORMATS.RGBA_INTEGER] = gl.RGBA16I,
                    _e[constants.FORMATS.RGB_INTEGER] = gl.RGB16I,
                    _e[constants.FORMATS.RG_INTEGER] = gl.RG16I,
                    _e[constants.FORMATS.RED_INTEGER] = gl.R16I,
                    _e),
                _a[constants.TYPES.UNSIGNED_INT] = (_f = {},
                    _f[constants.FORMATS.RGBA_INTEGER] = gl.RGBA32UI,
                    _f[constants.FORMATS.RGB_INTEGER] = gl.RGB32UI,
                    _f[constants.FORMATS.RG_INTEGER] = gl.RG32UI,
                    _f[constants.FORMATS.RED_INTEGER] = gl.R32UI,
                    _f[constants.FORMATS.DEPTH_COMPONENT] = gl.DEPTH_COMPONENT24,
                    _f),
                _a[constants.TYPES.INT] = (_g = {},
                    _g[constants.FORMATS.RGBA_INTEGER] = gl.RGBA32I,
                    _g[constants.FORMATS.RGB_INTEGER] = gl.RGB32I,
                    _g[constants.FORMATS.RG_INTEGER] = gl.RG32I,
                    _g[constants.FORMATS.RED_INTEGER] = gl.R32I,
                    _g),
                _a[constants.TYPES.FLOAT] = (_h = {},
                    _h[constants.FORMATS.RGBA] = gl.RGBA32F,
                    _h[constants.FORMATS.RGB] = gl.RGB32F,
                    _h[constants.FORMATS.RG] = gl.RG32F,
                    _h[constants.FORMATS.RED] = gl.R32F,
                    _h[constants.FORMATS.DEPTH_COMPONENT] = gl.DEPTH_COMPONENT32F,
                    _h),
                _a[constants.TYPES.HALF_FLOAT] = (_j = {},
                    _j[constants.FORMATS.RGBA] = gl.RGBA16F,
                    _j[constants.FORMATS.RGB] = gl.RGB16F,
                    _j[constants.FORMATS.RG] = gl.RG16F,
                    _j[constants.FORMATS.RED] = gl.R16F,
                    _j),
                _a[constants.TYPES.UNSIGNED_SHORT_5_6_5] = (_k = {},
                    _k[constants.FORMATS.RGB] = gl.RGB565,
                    _k),
                _a[constants.TYPES.UNSIGNED_SHORT_4_4_4_4] = (_l = {},
                    _l[constants.FORMATS.RGBA] = gl.RGBA4,
                    _l),
                _a[constants.TYPES.UNSIGNED_SHORT_5_5_5_1] = (_m = {},
                    _m[constants.FORMATS.RGBA] = gl.RGB5_A1,
                    _m),
                _a[constants.TYPES.UNSIGNED_INT_2_10_10_10_REV] = (_o = {},
                    _o[constants.FORMATS.RGBA] = gl.RGB10_A2,
                    _o[constants.FORMATS.RGBA_INTEGER] = gl.RGB10_A2UI,
                    _o),
                _a[constants.TYPES.UNSIGNED_INT_10F_11F_11F_REV] = (_p = {},
                    _p[constants.FORMATS.RGB] = gl.R11F_G11F_B10F,
                    _p),
                _a[constants.TYPES.UNSIGNED_INT_5_9_9_9_REV] = (_q = {},
                    _q[constants.FORMATS.RGB] = gl.RGB9_E5,
                    _q),
                _a[constants.TYPES.UNSIGNED_INT_24_8] = (_r = {},
                    _r[constants.FORMATS.DEPTH_STENCIL] = gl.DEPTH24_STENCIL8,
                    _r),
                _a[constants.TYPES.FLOAT_32_UNSIGNED_INT_24_8_REV] = (_s = {},
                    _s[constants.FORMATS.DEPTH_STENCIL] = gl.DEPTH32F_STENCIL8,
                    _s),
                _a);
        }
        else {
            table = (_t = {},
                _t[constants.TYPES.UNSIGNED_BYTE] = (_u = {},
                    _u[constants.FORMATS.RGBA] = gl.RGBA,
                    _u[constants.FORMATS.RGB] = gl.RGB,
                    _u[constants.FORMATS.ALPHA] = gl.ALPHA,
                    _u[constants.FORMATS.LUMINANCE] = gl.LUMINANCE,
                    _u[constants.FORMATS.LUMINANCE_ALPHA] = gl.LUMINANCE_ALPHA,
                    _u),
                _t[constants.TYPES.UNSIGNED_SHORT_5_6_5] = (_v = {},
                    _v[constants.FORMATS.RGB] = gl.RGB,
                    _v),
                _t[constants.TYPES.UNSIGNED_SHORT_4_4_4_4] = (_w = {},
                    _w[constants.FORMATS.RGBA] = gl.RGBA,
                    _w),
                _t[constants.TYPES.UNSIGNED_SHORT_5_5_5_1] = (_x = {},
                    _x[constants.FORMATS.RGBA] = gl.RGBA,
                    _x),
                _t);
        }
        return table;
    }

    /**
     * Internal texture for WebGL context.
     * @memberof PIXI
     */
    var GLTexture = /** @class */ (function () {
        function GLTexture(texture) {
            this.texture = texture;
            this.width = -1;
            this.height = -1;
            this.dirtyId = -1;
            this.dirtyStyleId = -1;
            this.mipmap = false;
            this.wrapMode = 33071;
            this.type = constants.TYPES.UNSIGNED_BYTE;
            this.internalFormat = constants.FORMATS.RGBA;
            this.samplerType = 0;
        }
        return GLTexture;
    }());

    /**
     * System plugin to the renderer to manage textures.
     * @memberof PIXI
     */
    var TextureSystem = /** @class */ (function () {
        /**
         * @param renderer - The renderer this system works for.
         */
        function TextureSystem(renderer) {
            this.renderer = renderer;
            // TODO set to max textures...
            this.boundTextures = [];
            this.currentLocation = -1;
            this.managedTextures = [];
            this._unknownBoundTextures = false;
            this.unknownTexture = new BaseTexture();
            this.hasIntegerTextures = false;
        }
        /** Sets up the renderer context and necessary buffers. */
        TextureSystem.prototype.contextChange = function () {
            var gl = this.gl = this.renderer.gl;
            this.CONTEXT_UID = this.renderer.CONTEXT_UID;
            this.webGLVersion = this.renderer.context.webGLVersion;
            this.internalFormats = mapTypeAndFormatToInternalFormat(gl);
            var maxTextures = gl.getParameter(gl.MAX_TEXTURE_IMAGE_UNITS);
            this.boundTextures.length = maxTextures;
            for (var i = 0; i < maxTextures; i++) {
                this.boundTextures[i] = null;
            }
            // TODO move this.. to a nice make empty textures class..
            this.emptyTextures = {};
            var emptyTexture2D = new GLTexture(gl.createTexture());
            gl.bindTexture(gl.TEXTURE_2D, emptyTexture2D.texture);
            gl.texImage2D(gl.TEXTURE_2D, 0, gl.RGBA, 1, 1, 0, gl.RGBA, gl.UNSIGNED_BYTE, new Uint8Array(4));
            this.emptyTextures[gl.TEXTURE_2D] = emptyTexture2D;
            this.emptyTextures[gl.TEXTURE_CUBE_MAP] = new GLTexture(gl.createTexture());
            gl.bindTexture(gl.TEXTURE_CUBE_MAP, this.emptyTextures[gl.TEXTURE_CUBE_MAP].texture);
            for (var i = 0; i < 6; i++) {
                gl.texImage2D(gl.TEXTURE_CUBE_MAP_POSITIVE_X + i, 0, gl.RGBA, 1, 1, 0, gl.RGBA, gl.UNSIGNED_BYTE, null);
            }
            gl.texParameteri(gl.TEXTURE_CUBE_MAP, gl.TEXTURE_MAG_FILTER, gl.LINEAR);
            gl.texParameteri(gl.TEXTURE_CUBE_MAP, gl.TEXTURE_MIN_FILTER, gl.LINEAR);
            for (var i = 0; i < this.boundTextures.length; i++) {
                this.bind(null, i);
            }
        };
        /**
         * Bind a texture to a specific location
         *
         * If you want to unbind something, please use `unbind(texture)` instead of `bind(null, textureLocation)`
         * @param texture - Texture to bind
         * @param [location=0] - Location to bind at
         */
        TextureSystem.prototype.bind = function (texture, location) {
            if (location === void 0) { location = 0; }
            var gl = this.gl;
            texture = texture === null || texture === void 0 ? void 0 : texture.castToBaseTexture();
            // cannot bind partial texture
            // TODO: report a warning
            if (texture && texture.valid && !texture.parentTextureArray) {
                texture.touched = this.renderer.textureGC.count;
                var glTexture = texture._glTextures[this.CONTEXT_UID] || this.initTexture(texture);
                if (this.boundTextures[location] !== texture) {
                    if (this.currentLocation !== location) {
                        this.currentLocation = location;
                        gl.activeTexture(gl.TEXTURE0 + location);
                    }
                    gl.bindTexture(texture.target, glTexture.texture);
                }
                if (glTexture.dirtyId !== texture.dirtyId) {
                    if (this.currentLocation !== location) {
                        this.currentLocation = location;
                        gl.activeTexture(gl.TEXTURE0 + location);
                    }
                    this.updateTexture(texture);
                }
                this.boundTextures[location] = texture;
            }
            else {
                if (this.currentLocation !== location) {
                    this.currentLocation = location;
                    gl.activeTexture(gl.TEXTURE0 + location);
                }
                gl.bindTexture(gl.TEXTURE_2D, this.emptyTextures[gl.TEXTURE_2D].texture);
                this.boundTextures[location] = null;
            }
        };
        /** Resets texture location and bound textures Actual `bind(null, i)` calls will be performed at next `unbind()` call */
        TextureSystem.prototype.reset = function () {
            this._unknownBoundTextures = true;
            this.hasIntegerTextures = false;
            this.currentLocation = -1;
            for (var i = 0; i < this.boundTextures.length; i++) {
                this.boundTextures[i] = this.unknownTexture;
            }
        };
        /**
         * Unbind a texture.
         * @param texture - Texture to bind
         */
        TextureSystem.prototype.unbind = function (texture) {
            var _a = this, gl = _a.gl, boundTextures = _a.boundTextures;
            if (this._unknownBoundTextures) {
                this._unknownBoundTextures = false;
                // someone changed webGL state,
                // we have to be sure that our texture does not appear in multi-texture renderer samplers
                for (var i = 0; i < boundTextures.length; i++) {
                    if (boundTextures[i] === this.unknownTexture) {
                        this.bind(null, i);
                    }
                }
            }
            for (var i = 0; i < boundTextures.length; i++) {
                if (boundTextures[i] === texture) {
                    if (this.currentLocation !== i) {
                        gl.activeTexture(gl.TEXTURE0 + i);
                        this.currentLocation = i;
                    }
                    gl.bindTexture(texture.target, this.emptyTextures[texture.target].texture);
                    boundTextures[i] = null;
                }
            }
        };
        /**
         * Ensures that current boundTextures all have FLOAT sampler type,
         * see {@link PIXI.SAMPLER_TYPES} for explanation.
         * @param maxTextures - number of locations to check
         */
        TextureSystem.prototype.ensureSamplerType = function (maxTextures) {
            var _a = this, boundTextures = _a.boundTextures, hasIntegerTextures = _a.hasIntegerTextures, CONTEXT_UID = _a.CONTEXT_UID;
            if (!hasIntegerTextures) {
                return;
            }
            for (var i = maxTextures - 1; i >= 0; --i) {
                var tex = boundTextures[i];
                if (tex) {
                    var glTexture = tex._glTextures[CONTEXT_UID];
                    if (glTexture.samplerType !== constants.SAMPLER_TYPES.FLOAT) {
                        this.renderer.texture.unbind(tex);
                    }
                }
            }
        };
        /**
         * Initialize a texture
         * @private
         * @param texture - Texture to initialize
         */
        TextureSystem.prototype.initTexture = function (texture) {
            var glTexture = new GLTexture(this.gl.createTexture());
            // guarantee an update..
            glTexture.dirtyId = -1;
            texture._glTextures[this.CONTEXT_UID] = glTexture;
            this.managedTextures.push(texture);
            texture.on('dispose', this.destroyTexture, this);
            return glTexture;
        };
        TextureSystem.prototype.initTextureType = function (texture, glTexture) {
            var _a, _b;
            glTexture.internalFormat = (_b = (_a = this.internalFormats[texture.type]) === null || _a === void 0 ? void 0 : _a[texture.format]) !== null && _b !== void 0 ? _b : texture.format;
            if (this.webGLVersion === 2 && texture.type === constants.TYPES.HALF_FLOAT) {
                // TYPES.HALF_FLOAT is WebGL1 HALF_FLOAT_OES
                // we have to convert it to WebGL HALF_FLOAT
                glTexture.type = this.gl.HALF_FLOAT;
            }
            else {
                glTexture.type = texture.type;
            }
        };
        /**
         * Update a texture
         * @private
         * @param {PIXI.BaseTexture} texture - Texture to initialize
         */
        TextureSystem.prototype.updateTexture = function (texture) {
            var glTexture = texture._glTextures[this.CONTEXT_UID];
            if (!glTexture) {
                return;
            }
            var renderer = this.renderer;
            this.initTextureType(texture, glTexture);
            if (texture.resource && texture.resource.upload(renderer, texture, glTexture)) {
                // texture is uploaded, dont do anything!
                if (glTexture.samplerType !== constants.SAMPLER_TYPES.FLOAT) {
                    this.hasIntegerTextures = true;
                }
            }
            else {
                // default, renderTexture-like logic
                var width = texture.realWidth;
                var height = texture.realHeight;
                var gl = renderer.gl;
                if (glTexture.width !== width
                    || glTexture.height !== height
                    || glTexture.dirtyId < 0) {
                    glTexture.width = width;
                    glTexture.height = height;
                    gl.texImage2D(texture.target, 0, glTexture.internalFormat, width, height, 0, texture.format, glTexture.type, null);
                }
            }
            // lets only update what changes..
            if (texture.dirtyStyleId !== glTexture.dirtyStyleId) {
                this.updateTextureStyle(texture);
            }
            glTexture.dirtyId = texture.dirtyId;
        };
        /**
         * Deletes the texture from WebGL
         * @private
         * @param texture - the texture to destroy
         * @param [skipRemove=false] - Whether to skip removing the texture from the TextureManager.
         */
        TextureSystem.prototype.destroyTexture = function (texture, skipRemove) {
            var gl = this.gl;
            texture = texture.castToBaseTexture();
            if (texture._glTextures[this.CONTEXT_UID]) {
                this.unbind(texture);
                gl.deleteTexture(texture._glTextures[this.CONTEXT_UID].texture);
                texture.off('dispose', this.destroyTexture, this);
                delete texture._glTextures[this.CONTEXT_UID];
                if (!skipRemove) {
                    var i = this.managedTextures.indexOf(texture);
                    if (i !== -1) {
                        utils.removeItems(this.managedTextures, i, 1);
                    }
                }
            }
        };
        /**
         * Update texture style such as mipmap flag
         * @private
         * @param {PIXI.BaseTexture} texture - Texture to update
         */
        TextureSystem.prototype.updateTextureStyle = function (texture) {
            var glTexture = texture._glTextures[this.CONTEXT_UID];
            if (!glTexture) {
                return;
            }
            if ((texture.mipmap === constants.MIPMAP_MODES.POW2 || this.webGLVersion !== 2) && !texture.isPowerOfTwo) {
                glTexture.mipmap = false;
            }
            else {
                glTexture.mipmap = texture.mipmap >= 1;
            }
            if (this.webGLVersion !== 2 && !texture.isPowerOfTwo) {
                glTexture.wrapMode = constants.WRAP_MODES.CLAMP;
            }
            else {
                glTexture.wrapMode = texture.wrapMode;
            }
            if (texture.resource && texture.resource.style(this.renderer, texture, glTexture)) {
                // style is set, dont do anything!
            }
            else {
                this.setStyle(texture, glTexture);
            }
            glTexture.dirtyStyleId = texture.dirtyStyleId;
        };
        /**
         * Set style for texture
         * @private
         * @param texture - Texture to update
         * @param glTexture
         */
        TextureSystem.prototype.setStyle = function (texture, glTexture) {
            var gl = this.gl;
            if (glTexture.mipmap && texture.mipmap !== constants.MIPMAP_MODES.ON_MANUAL) {
                gl.generateMipmap(texture.target);
            }
            gl.texParameteri(texture.target, gl.TEXTURE_WRAP_S, glTexture.wrapMode);
            gl.texParameteri(texture.target, gl.TEXTURE_WRAP_T, glTexture.wrapMode);
            if (glTexture.mipmap) {
                /* eslint-disable max-len */
                gl.texParameteri(texture.target, gl.TEXTURE_MIN_FILTER, texture.scaleMode === constants.SCALE_MODES.LINEAR ? gl.LINEAR_MIPMAP_LINEAR : gl.NEAREST_MIPMAP_NEAREST);
                /* eslint-disable max-len */
                var anisotropicExt = this.renderer.context.extensions.anisotropicFiltering;
                if (anisotropicExt && texture.anisotropicLevel > 0 && texture.scaleMode === constants.SCALE_MODES.LINEAR) {
                    var level = Math.min(texture.anisotropicLevel, gl.getParameter(anisotropicExt.MAX_TEXTURE_MAX_ANISOTROPY_EXT));
                    gl.texParameterf(texture.target, anisotropicExt.TEXTURE_MAX_ANISOTROPY_EXT, level);
                }
            }
            else {
                gl.texParameteri(texture.target, gl.TEXTURE_MIN_FILTER, texture.scaleMode === constants.SCALE_MODES.LINEAR ? gl.LINEAR : gl.NEAREST);
            }
            gl.texParameteri(texture.target, gl.TEXTURE_MAG_FILTER, texture.scaleMode === constants.SCALE_MODES.LINEAR ? gl.LINEAR : gl.NEAREST);
        };
        TextureSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        return TextureSystem;
    }());

    var _systems = {
        __proto__: null,
        FilterSystem: FilterSystem,
        BatchSystem: BatchSystem,
        ContextSystem: ContextSystem,
        FramebufferSystem: FramebufferSystem,
        GeometrySystem: GeometrySystem,
        MaskSystem: MaskSystem,
        ScissorSystem: ScissorSystem,
        StencilSystem: StencilSystem,
        ProjectionSystem: ProjectionSystem,
        RenderTextureSystem: RenderTextureSystem,
        ShaderSystem: ShaderSystem,
        StateSystem: StateSystem,
        TextureGCSystem: TextureGCSystem,
        TextureSystem: TextureSystem
    };

    var tempMatrix = new math.Matrix();
    /**
     * The AbstractRenderer is the base for a PixiJS Renderer. It is extended by the {@link PIXI.CanvasRenderer}
     * and {@link PIXI.Renderer} which can be used for rendering a PixiJS scene.
     * @abstract
     * @class
     * @extends PIXI.utils.EventEmitter
     * @memberof PIXI
     */
    var AbstractRenderer = /** @class */ (function (_super) {
        __extends(AbstractRenderer, _super);
        /**
         * @param type - The renderer type.
         * @param [options] - The optional renderer parameters.
         * @param {number} [options.width=800] - The width of the screen.
         * @param {number} [options.height=600] - The height of the screen.
         * @param {HTMLCanvasElement} [options.view] - The canvas to use as a view, optional.
         * @param {boolean} [options.useContextAlpha=true] - Pass-through value for canvas' context `alpha` property.
         *   If you want to set transparency, please use `backgroundAlpha`. This option is for cases where the
         *   canvas needs to be opaque, possibly for performance reasons on some older devices.
         * @param {boolean} [options.autoDensity=false] - Resizes renderer view in CSS pixels to allow for
         *   resolutions other than 1.
         * @param {boolean} [options.antialias=false] - Sets antialias
         * @param {number} [options.resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio of the renderer.
         * @param {boolean} [options.preserveDrawingBuffer=false] - Enables drawing buffer preservation,
         *  enable this if you need to call toDataUrl on the WebGL context.
         * @param {boolean} [options.clearBeforeRender=true] - This sets if the renderer will clear the canvas or
         *      not before the new render pass.
         * @param {number} [options.backgroundColor=0x000000] - The background color of the rendered area
         *  (shown if not transparent).
         * @param {number} [options.backgroundAlpha=1] - Value from 0 (fully transparent) to 1 (fully opaque).
         */
        function AbstractRenderer(type, options) {
            if (type === void 0) { type = constants.RENDERER_TYPE.UNKNOWN; }
            var _this = _super.call(this) || this;
            // Add the default render options
            options = Object.assign({}, settings.settings.RENDER_OPTIONS, options);
            /**
             * The supplied constructor options.
             * @member {object}
             * @readonly
             */
            _this.options = options;
            /**
             * The type of the renderer.
             * @member {number}
             * @default PIXI.RENDERER_TYPE.UNKNOWN
             * @see PIXI.RENDERER_TYPE
             */
            _this.type = type;
            /**
             * Measurements of the screen. (0, 0, screenWidth, screenHeight).
             *
             * Its safe to use as filterArea or hitArea for the whole stage.
             * @member {PIXI.Rectangle}
             */
            _this.screen = new math.Rectangle(0, 0, options.width, options.height);
            /**
             * The canvas element that everything is drawn to.
             * @member {HTMLCanvasElement}
             */
            _this.view = options.view || settings.settings.ADAPTER.createCanvas();
            /**
             * The resolution / device pixel ratio of the renderer.
             * @member {number}
             * @default PIXI.settings.RESOLUTION
             */
            _this.resolution = options.resolution || settings.settings.RESOLUTION;
            /**
             * Pass-thru setting for the canvas' context `alpha` property. This is typically
             * not something you need to fiddle with. If you want transparency, use `backgroundAlpha`.
             * @member {boolean}
             */
            _this.useContextAlpha = options.useContextAlpha;
            /**
             * Whether CSS dimensions of canvas view should be resized to screen dimensions automatically.
             * @member {boolean}
             */
            _this.autoDensity = !!options.autoDensity;
            /**
             * The value of the preserveDrawingBuffer flag affects whether or not the contents of
             * the stencil buffer is retained after rendering.
             * @member {boolean}
             */
            _this.preserveDrawingBuffer = options.preserveDrawingBuffer;
            /**
             * This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
             * If the scene is NOT transparent PixiJS will use a canvas sized fillRect operation every
             * frame to set the canvas background color. If the scene is transparent PixiJS will use clearRect
             * to clear the canvas every frame. Disable this by setting this to false. For example, if
             * your game has a canvas filling background image you often don't need this set.
             * @member {boolean}
             * @default
             */
            _this.clearBeforeRender = options.clearBeforeRender;
            /**
             * The background color as a number.
             * @member {number}
             * @protected
             */
            _this._backgroundColor = 0x000000;
            /**
             * The background color as an [R, G, B, A] array.
             * @member {number[]}
             * @protected
             */
            _this._backgroundColorRgba = [0, 0, 0, 1];
            /**
             * The background color as a string.
             * @member {string}
             * @protected
             */
            _this._backgroundColorString = '#000000';
            _this.backgroundColor = options.backgroundColor || _this._backgroundColor; // run bg color setter
            _this.backgroundAlpha = options.backgroundAlpha;
            // @deprecated
            if (options.transparent !== undefined) {
                utils.deprecation('6.0.0', 'Option transparent is deprecated, please use backgroundAlpha instead.');
                _this.useContextAlpha = options.transparent;
                _this.backgroundAlpha = options.transparent ? 0 : 1;
            }
            /**
             * The last root object that the renderer tried to render.
             * @member {PIXI.DisplayObject}
             * @protected
             */
            _this._lastObjectRendered = null;
            /**
             * Collection of plugins.
             * @readonly
             * @member {object}
             */
            _this.plugins = {};
            return _this;
        }
        /**
         * Initialize the plugins.
         * @protected
         * @param {object} staticMap - The dictionary of statically saved plugins.
         */
        AbstractRenderer.prototype.initPlugins = function (staticMap) {
            for (var o in staticMap) {
                this.plugins[o] = new (staticMap[o])(this);
            }
        };
        Object.defineProperty(AbstractRenderer.prototype, "width", {
            /**
             * Same as view.width, actual number of pixels in the canvas by horizontal.
             * @member {number}
             * @readonly
             * @default 800
             */
            get: function () {
                return this.view.width;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(AbstractRenderer.prototype, "height", {
            /**
             * Same as view.height, actual number of pixels in the canvas by vertical.
             * @member {number}
             * @readonly
             * @default 600
             */
            get: function () {
                return this.view.height;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Resizes the screen and canvas as close as possible to the specified width and height.
         * Canvas dimensions are multiplied by resolution and rounded to the nearest integers.
         * The new canvas dimensions divided by the resolution become the new screen dimensions.
         * @param desiredScreenWidth - The desired width of the screen.
         * @param desiredScreenHeight - The desired height of the screen.
         */
        AbstractRenderer.prototype.resize = function (desiredScreenWidth, desiredScreenHeight) {
            this.view.width = Math.round(desiredScreenWidth * this.resolution);
            this.view.height = Math.round(desiredScreenHeight * this.resolution);
            var screenWidth = this.view.width / this.resolution;
            var screenHeight = this.view.height / this.resolution;
            this.screen.width = screenWidth;
            this.screen.height = screenHeight;
            if (this.autoDensity) {
                this.view.style.width = screenWidth + "px";
                this.view.style.height = screenHeight + "px";
            }
            /**
             * Fired after view has been resized.
             * @event PIXI.Renderer#resize
             * @param {number} screenWidth - The new width of the screen.
             * @param {number} screenHeight - The new height of the screen.
             */
            this.emit('resize', screenWidth, screenHeight);
        };
        /**
         * @ignore
         */
        AbstractRenderer.prototype.generateTexture = function (displayObject, options, resolution, region) {
            if (options === void 0) { options = {}; }
            // @deprecated parameters spread, use options instead
            if (typeof options === 'number') {
                utils.deprecation('6.1.0', 'generateTexture options (scaleMode, resolution, region) are now object options.');
                options = { scaleMode: options, resolution: resolution, region: region };
            }
            var manualRegion = options.region, textureOptions = __rest(options, ["region"]);
            region = manualRegion || displayObject.getLocalBounds(null, true);
            // minimum texture size is 1x1, 0x0 will throw an error
            if (region.width === 0)
                { region.width = 1; }
            if (region.height === 0)
                { region.height = 1; }
            var renderTexture = RenderTexture.create(__assign({ width: region.width, height: region.height }, textureOptions));
            tempMatrix.tx = -region.x;
            tempMatrix.ty = -region.y;
            this.render(displayObject, {
                renderTexture: renderTexture,
                clear: false,
                transform: tempMatrix,
                skipUpdateTransform: !!displayObject.parent
            });
            return renderTexture;
        };
        /**
         * Removes everything from the renderer and optionally removes the Canvas DOM element.
         * @param [removeView=false] - Removes the Canvas element from the DOM.
         */
        AbstractRenderer.prototype.destroy = function (removeView) {
            for (var o in this.plugins) {
                this.plugins[o].destroy();
                this.plugins[o] = null;
            }
            if (removeView && this.view.parentNode) {
                this.view.parentNode.removeChild(this.view);
            }
            var thisAny = this;
            // null-ing all objects, that's a tradition!
            thisAny.plugins = null;
            thisAny.type = constants.RENDERER_TYPE.UNKNOWN;
            thisAny.view = null;
            thisAny.screen = null;
            thisAny._tempDisplayObjectParent = null;
            thisAny.options = null;
            this._backgroundColorRgba = null;
            this._backgroundColorString = null;
            this._lastObjectRendered = null;
        };
        Object.defineProperty(AbstractRenderer.prototype, "backgroundColor", {
            /**
             * The background color to fill if not transparent
             * @member {number}
             */
            get: function () {
                return this._backgroundColor;
            },
            set: function (value) {
                this._backgroundColor = value;
                this._backgroundColorString = utils.hex2string(value);
                utils.hex2rgb(value, this._backgroundColorRgba);
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(AbstractRenderer.prototype, "backgroundAlpha", {
            /**
             * The background color alpha. Setting this to 0 will make the canvas transparent.
             * @member {number}
             */
            get: function () {
                return this._backgroundColorRgba[3];
            },
            set: function (value) {
                this._backgroundColorRgba[3] = value;
            },
            enumerable: false,
            configurable: true
        });
        return AbstractRenderer;
    }(utils.EventEmitter));

    var GLBuffer = /** @class */ (function () {
        function GLBuffer(buffer) {
            this.buffer = buffer || null;
            this.updateID = -1;
            this.byteLength = -1;
            this.refCount = 0;
        }
        return GLBuffer;
    }());

    /**
     * System plugin to the renderer to manage buffers.
     *
     * WebGL uses Buffers as a way to store objects to the GPU.
     * This system makes working with them a lot easier.
     *
     * Buffers are used in three main places in WebGL
     * - geometry information
     * - Uniform information (via uniform buffer objects - a WebGL 2 only feature)
     * - Transform feedback information. (WebGL 2 only feature)
     *
     * This system will handle the binding of buffers to the GPU as well as uploading
     * them. With this system, you never need to work directly with GPU buffers, but instead work with
     * the PIXI.Buffer class.
     * @class
     * @memberof PIXI
     */
    var BufferSystem = /** @class */ (function () {
        /**
         * @param {PIXI.Renderer} renderer - The renderer this System works for.
         */
        function BufferSystem(renderer) {
            this.renderer = renderer;
            this.managedBuffers = {};
            this.boundBufferBases = {};
        }
        /**
         * @ignore
         */
        BufferSystem.prototype.destroy = function () {
            this.renderer = null;
        };
        /** Sets up the renderer context and necessary buffers. */
        BufferSystem.prototype.contextChange = function () {
            this.disposeAll(true);
            this.gl = this.renderer.gl;
            // TODO fill out...
            this.CONTEXT_UID = this.renderer.CONTEXT_UID;
        };
        /**
         * This binds specified buffer. On first run, it will create the webGL buffers for the context too
         * @param buffer - the buffer to bind to the renderer
         */
        BufferSystem.prototype.bind = function (buffer) {
            var _a = this, gl = _a.gl, CONTEXT_UID = _a.CONTEXT_UID;
            var glBuffer = buffer._glBuffers[CONTEXT_UID] || this.createGLBuffer(buffer);
            gl.bindBuffer(buffer.type, glBuffer.buffer);
        };
        /**
         * Binds an uniform buffer to at the given index.
         *
         * A cache is used so a buffer will not be bound again if already bound.
         * @param buffer - the buffer to bind
         * @param index - the base index to bind it to.
         */
        BufferSystem.prototype.bindBufferBase = function (buffer, index) {
            var _a = this, gl = _a.gl, CONTEXT_UID = _a.CONTEXT_UID;
            if (this.boundBufferBases[index] !== buffer) {
                var glBuffer = buffer._glBuffers[CONTEXT_UID] || this.createGLBuffer(buffer);
                this.boundBufferBases[index] = buffer;
                gl.bindBufferBase(gl.UNIFORM_BUFFER, index, glBuffer.buffer);
            }
        };
        /**
         * Binds a buffer whilst also binding its range.
         * This will make the buffer start from the offset supplied rather than 0 when it is read.
         * @param buffer - the buffer to bind
         * @param index - the base index to bind at, defaults to 0
         * @param offset - the offset to bind at (this is blocks of 256). 0 = 0, 1 = 256, 2 = 512 etc
         */
        BufferSystem.prototype.bindBufferRange = function (buffer, index, offset) {
            var _a = this, gl = _a.gl, CONTEXT_UID = _a.CONTEXT_UID;
            offset = offset || 0;
            var glBuffer = buffer._glBuffers[CONTEXT_UID] || this.createGLBuffer(buffer);
            gl.bindBufferRange(gl.UNIFORM_BUFFER, index || 0, glBuffer.buffer, offset * 256, 256);
        };
        /**
         * Will ensure the data in the buffer is uploaded to the GPU.
         * @param {PIXI.Buffer} buffer - the buffer to update
         */
        BufferSystem.prototype.update = function (buffer) {
            var _a = this, gl = _a.gl, CONTEXT_UID = _a.CONTEXT_UID;
            var glBuffer = buffer._glBuffers[CONTEXT_UID];
            if (buffer._updateID === glBuffer.updateID) {
                return;
            }
            glBuffer.updateID = buffer._updateID;
            gl.bindBuffer(buffer.type, glBuffer.buffer);
            if (glBuffer.byteLength >= buffer.data.byteLength) {
                // offset is always zero for now!
                gl.bufferSubData(buffer.type, 0, buffer.data);
            }
            else {
                var drawType = buffer.static ? gl.STATIC_DRAW : gl.DYNAMIC_DRAW;
                glBuffer.byteLength = buffer.data.byteLength;
                gl.bufferData(buffer.type, buffer.data, drawType);
            }
        };
        /**
         * Disposes buffer
         * @param {PIXI.Buffer} buffer - buffer with data
         * @param {boolean} [contextLost=false] - If context was lost, we suppress deleteVertexArray
         */
        BufferSystem.prototype.dispose = function (buffer, contextLost) {
            if (!this.managedBuffers[buffer.id]) {
                return;
            }
            delete this.managedBuffers[buffer.id];
            var glBuffer = buffer._glBuffers[this.CONTEXT_UID];
            var gl = this.gl;
            buffer.disposeRunner.remove(this);
            if (!glBuffer) {
                return;
            }
            if (!contextLost) {
                gl.deleteBuffer(glBuffer.buffer);
            }
            delete buffer._glBuffers[this.CONTEXT_UID];
        };
        /**
         * dispose all WebGL resources of all managed buffers
         * @param {boolean} [contextLost=false] - If context was lost, we suppress `gl.delete` calls
         */
        BufferSystem.prototype.disposeAll = function (contextLost) {
            var all = Object.keys(this.managedBuffers);
            for (var i = 0; i < all.length; i++) {
                this.dispose(this.managedBuffers[all[i]], contextLost);
            }
        };
        /**
         * creates and attaches a GLBuffer object tied to the current context.
         * @param buffer
         * @protected
         */
        BufferSystem.prototype.createGLBuffer = function (buffer) {
            var _a = this, CONTEXT_UID = _a.CONTEXT_UID, gl = _a.gl;
            buffer._glBuffers[CONTEXT_UID] = new GLBuffer(gl.createBuffer());
            this.managedBuffers[buffer.id] = buffer;
            buffer.disposeRunner.add(this);
            return buffer._glBuffers[CONTEXT_UID];
        };
        return BufferSystem;
    }());

    /**
     * The Renderer draws the scene and all its content onto a WebGL enabled canvas.
     *
     * This renderer should be used for browsers that support WebGL.
     *
     * This renderer works by automatically managing WebGLBatchesm, so no need for Sprite Batches or Sprite Clouds.
     * Don't forget to add the view to your DOM or you will not see anything!
     *
     * Renderer is composed of systems that manage specific tasks. The following systems are added by default
     * whenever you create a renderer:
     *
     * | System                               | Description                                                                   |
     * | ------------------------------------ | ----------------------------------------------------------------------------- |
     * | {@link PIXI.BatchSystem}             | This manages object renderers that defer rendering until a flush.             |
     * | {@link PIXI.ContextSystem}           | This manages the WebGL context and extensions.                                |
     * | {@link PIXI.EventSystem}             | This manages UI events.                                                       |
     * | {@link PIXI.FilterSystem}            | This manages the filtering pipeline for post-processing effects.              |
     * | {@link PIXI.FramebufferSystem}       | This manages framebuffers, which are used for offscreen rendering.            |
     * | {@link PIXI.GeometrySystem}          | This manages geometries & buffers, which are used to draw object meshes.      |
     * | {@link PIXI.MaskSystem}              | This manages masking operations.                                              |
     * | {@link PIXI.ProjectionSystem}        | This manages the `projectionMatrix`, used by shaders to get NDC coordinates.  |
     * | {@link PIXI.RenderTextureSystem}     | This manages render-textures, which are an abstraction over framebuffers.     |
     * | {@link PIXI.ScissorSystem}           | This handles scissor masking, and is used internally by {@link MaskSystem}    |
     * | {@link PIXI.ShaderSystem}            | This manages shaders, programs that run on the GPU to calculate 'em pixels.   |
     * | {@link PIXI.StateSystem}             | This manages the WebGL state variables like blend mode, depth testing, etc.   |
     * | {@link PIXI.StencilSystem}           | This handles stencil masking, and is used internally by {@link MaskSystem}    |
     * | {@link PIXI.TextureSystem}           | This manages textures and their resources on the GPU.                         |
     * | {@link PIXI.TextureGCSystem}         | This will automatically remove textures from the GPU if they are not used.    |
     *
     * The breadth of the API surface provided by the renderer is contained within these systems.
     * @memberof PIXI
     */
    var Renderer = /** @class */ (function (_super) {
        __extends(Renderer, _super);
        /**
         * @param [options] - The optional renderer parameters.
         * @param {number} [options.width=800] - The width of the screen.
         * @param {number} [options.height=600] - The height of the screen.
         * @param {HTMLCanvasElement} [options.view] - The canvas to use as a view, optional.
         * @param {boolean} [options.useContextAlpha=true] - Pass-through value for canvas' context `alpha` property.
         *   If you want to set transparency, please use `backgroundAlpha`. This option is for cases where the
         *   canvas needs to be opaque, possibly for performance reasons on some older devices.
         * @param {boolean} [options.autoDensity=false] - Resizes renderer view in CSS pixels to allow for
         *   resolutions other than 1.
         * @param {boolean} [options.antialias=false] - Sets antialias. If not available natively then FXAA
         *  antialiasing is used.
         * @param {number} [options.resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio of the renderer.
         * @param {boolean} [options.clearBeforeRender=true] - This sets if the renderer will clear
         *  the canvas or not before the new render pass. If you wish to set this to false, you *must* set
         *  preserveDrawingBuffer to `true`.
         * @param {boolean} [options.preserveDrawingBuffer=false] - Enables drawing buffer preservation,
         *  enable this if you need to call toDataUrl on the WebGL context.
         * @param {number} [options.backgroundColor=0x000000] - The background color of the rendered area
         *  (shown if not transparent).
         * @param {number} [options.backgroundAlpha=1] - Value from 0 (fully transparent) to 1 (fully opaque).
         * @param {string} [options.powerPreference] - Parameter passed to WebGL context, set to "high-performance"
         *  for devices with dual graphics card.
         * @param {object} [options.context] - If WebGL context already exists, all parameters must be taken from it.
         */
        function Renderer(options) {
            var _this = _super.call(this, constants.RENDERER_TYPE.WEBGL, options) || this;
            // the options will have been modified here in the super constructor with pixi's default settings..
            options = _this.options;
            _this.gl = null;
            _this.CONTEXT_UID = 0;
            _this.runners = {
                destroy: new runner.Runner('destroy'),
                contextChange: new runner.Runner('contextChange'),
                reset: new runner.Runner('reset'),
                update: new runner.Runner('update'),
                postrender: new runner.Runner('postrender'),
                prerender: new runner.Runner('prerender'),
                resize: new runner.Runner('resize'),
            };
            _this.runners.contextChange.add(_this);
            _this.globalUniforms = new UniformGroup({
                projectionMatrix: new math.Matrix(),
            }, true);
            _this.addSystem(MaskSystem, 'mask')
                .addSystem(ContextSystem, 'context')
                .addSystem(StateSystem, 'state')
                .addSystem(ShaderSystem, 'shader')
                .addSystem(TextureSystem, 'texture')
                .addSystem(BufferSystem, 'buffer')
                .addSystem(GeometrySystem, 'geometry')
                .addSystem(FramebufferSystem, 'framebuffer')
                .addSystem(ScissorSystem, 'scissor')
                .addSystem(StencilSystem, 'stencil')
                .addSystem(ProjectionSystem, 'projection')
                .addSystem(TextureGCSystem, 'textureGC')
                .addSystem(FilterSystem, 'filter')
                .addSystem(RenderTextureSystem, 'renderTexture')
                .addSystem(BatchSystem, 'batch');
            _this.initPlugins(Renderer.__plugins);
            _this.multisample = undefined;
            /*
             * The options passed in to create a new WebGL context.
             */
            if (options.context) {
                _this.context.initFromContext(options.context);
            }
            else {
                _this.context.initFromOptions({
                    alpha: !!_this.useContextAlpha,
                    antialias: options.antialias,
                    premultipliedAlpha: _this.useContextAlpha && _this.useContextAlpha !== 'notMultiplied',
                    stencil: true,
                    preserveDrawingBuffer: options.preserveDrawingBuffer,
                    powerPreference: _this.options.powerPreference,
                });
            }
            _this.renderingToScreen = true;
            utils.sayHello(_this.context.webGLVersion === 2 ? 'WebGL 2' : 'WebGL 1');
            _this.resize(_this.options.width, _this.options.height);
            return _this;
        }
        /**
         * Create renderer if WebGL is available. Overrideable
         * by the **@pixi/canvas-renderer** package to allow fallback.
         * throws error if WebGL is not available.
         * @param options
         * @private
         */
        Renderer.create = function (options) {
            if (utils.isWebGLSupported()) {
                return new Renderer(options);
            }
            throw new Error('WebGL unsupported in this browser, use "pixi.js-legacy" for fallback canvas2d support.');
        };
        Renderer.prototype.contextChange = function () {
            var gl = this.gl;
            var samples;
            if (this.context.webGLVersion === 1) {
                var framebuffer = gl.getParameter(gl.FRAMEBUFFER_BINDING);
                gl.bindFramebuffer(gl.FRAMEBUFFER, null);
                samples = gl.getParameter(gl.SAMPLES);
                gl.bindFramebuffer(gl.FRAMEBUFFER, framebuffer);
            }
            else {
                var framebuffer = gl.getParameter(gl.DRAW_FRAMEBUFFER_BINDING);
                gl.bindFramebuffer(gl.DRAW_FRAMEBUFFER, null);
                samples = gl.getParameter(gl.SAMPLES);
                gl.bindFramebuffer(gl.DRAW_FRAMEBUFFER, framebuffer);
            }
            if (samples >= constants.MSAA_QUALITY.HIGH) {
                this.multisample = constants.MSAA_QUALITY.HIGH;
            }
            else if (samples >= constants.MSAA_QUALITY.MEDIUM) {
                this.multisample = constants.MSAA_QUALITY.MEDIUM;
            }
            else if (samples >= constants.MSAA_QUALITY.LOW) {
                this.multisample = constants.MSAA_QUALITY.LOW;
            }
            else {
                this.multisample = constants.MSAA_QUALITY.NONE;
            }
        };
        /**
         * Add a new system to the renderer.
         * @param ClassRef - Class reference
         * @param name - Property name for system, if not specified
         *        will use a static `name` property on the class itself. This
         *        name will be assigned as s property on the Renderer so make
         *        sure it doesn't collide with properties on Renderer.
         * @returns Return instance of renderer
         */
        Renderer.prototype.addSystem = function (ClassRef, name) {
            var system = new ClassRef(this);
            if (this[name]) {
                throw new Error("Whoops! The name \"" + name + "\" is already in use");
            }
            this[name] = system;
            for (var i in this.runners) {
                this.runners[i].add(system);
            }
            /**
             * Fired after rendering finishes.
             * @event PIXI.Renderer#postrender
             */
            /**
             * Fired before rendering starts.
             * @event PIXI.Renderer#prerender
             */
            /**
             * Fired when the WebGL context is set.
             * @event PIXI.Renderer#context
             * @param {WebGLRenderingContext} gl - WebGL context.
             */
            return this;
        };
        /**
         * @ignore
         */
        Renderer.prototype.render = function (displayObject, options) {
            var renderTexture;
            var clear;
            var transform;
            var skipUpdateTransform;
            if (options) {
                if (options instanceof RenderTexture) {
                    utils.deprecation('6.0.0', 'Renderer#render arguments changed, use options instead.');
                    /* eslint-disable prefer-rest-params */
                    renderTexture = options;
                    clear = arguments[2];
                    transform = arguments[3];
                    skipUpdateTransform = arguments[4];
                    /* eslint-enable prefer-rest-params */
                }
                else {
                    renderTexture = options.renderTexture;
                    clear = options.clear;
                    transform = options.transform;
                    skipUpdateTransform = options.skipUpdateTransform;
                }
            }
            // can be handy to know!
            this.renderingToScreen = !renderTexture;
            this.runners.prerender.emit();
            this.emit('prerender');
            // apply a transform at a GPU level
            this.projection.transform = transform;
            // no point rendering if our context has been blown up!
            if (this.context.isLost) {
                return;
            }
            if (!renderTexture) {
                this._lastObjectRendered = displayObject;
            }
            if (!skipUpdateTransform) {
                // update the scene graph
                var cacheParent = displayObject.enableTempParent();
                displayObject.updateTransform();
                displayObject.disableTempParent(cacheParent);
                // displayObject.hitArea = //TODO add a temp hit area
            }
            this.renderTexture.bind(renderTexture);
            this.batch.currentRenderer.start();
            if (clear !== undefined ? clear : this.clearBeforeRender) {
                this.renderTexture.clear();
            }
            displayObject.render(this);
            // apply transform..
            this.batch.currentRenderer.flush();
            if (renderTexture) {
                renderTexture.baseTexture.update();
            }
            this.runners.postrender.emit();
            // reset transform after render
            this.projection.transform = null;
            this.emit('postrender');
        };
        /**
         * @override
         * @ignore
         */
        Renderer.prototype.generateTexture = function (displayObject, options, resolution, region) {
            if (options === void 0) { options = {}; }
            var renderTexture = _super.prototype.generateTexture.call(this, displayObject, options, resolution, region);
            this.framebuffer.blit();
            return renderTexture;
        };
        /**
         * Resizes the WebGL view to the specified width and height.
         * @param desiredScreenWidth - The desired width of the screen.
         * @param desiredScreenHeight - The desired height of the screen.
         */
        Renderer.prototype.resize = function (desiredScreenWidth, desiredScreenHeight) {
            _super.prototype.resize.call(this, desiredScreenWidth, desiredScreenHeight);
            this.runners.resize.emit(this.screen.height, this.screen.width);
        };
        /**
         * Resets the WebGL state so you can render things however you fancy!
         * @returns Returns itself.
         */
        Renderer.prototype.reset = function () {
            this.runners.reset.emit();
            return this;
        };
        /** Clear the frame buffer. */
        Renderer.prototype.clear = function () {
            this.renderTexture.bind();
            this.renderTexture.clear();
        };
        /**
         * Removes everything from the renderer (event listeners, spritebatch, etc...)
         * @param [removeView=false] - Removes the Canvas element from the DOM.
         *  See: https://github.com/pixijs/pixi.js/issues/2233
         */
        Renderer.prototype.destroy = function (removeView) {
            this.runners.destroy.emit();
            for (var r in this.runners) {
                this.runners[r].destroy();
            }
            // call base destroy
            _super.prototype.destroy.call(this, removeView);
            // TODO nullify all the managers..
            this.gl = null;
        };
        Object.defineProperty(Renderer.prototype, "extract", {
            /**
             * Please use `plugins.extract` instead.
             * @member {PIXI.Extract} extract
             * @deprecated since 6.0.0
             * @readonly
             */
            get: function () {
                utils.deprecation('6.0.0', 'Renderer#extract has been deprecated, please use Renderer#plugins.extract instead.');
                return this.plugins.extract;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Use the {@link PIXI.extensions.add} API to register plugins.
         * @deprecated since 6.5.0
         * @param pluginName - The name of the plugin.
         * @param ctor - The constructor function or class for the plugin.
         */
        Renderer.registerPlugin = function (pluginName, ctor) {
            utils.deprecation('6.5.0', 'Renderer.registerPlugin() has been deprecated, please use extensions.add() instead.');
            extensions.extensions.add({
                name: pluginName,
                type: extensions.ExtensionType.RendererPlugin,
                ref: ctor,
            });
        };
        /**
         * Collection of installed plugins. These are included by default in PIXI, but can be excluded
         * by creating a custom build. Consult the README for more information about creating custom
         * builds and excluding plugins.
         * @readonly
         * @property {PIXI.AccessibilityManager} accessibility Support tabbing interactive elements.
         * @property {PIXI.Extract} extract Extract image data from renderer.
         * @property {PIXI.InteractionManager} interaction Handles mouse, touch and pointer events.
         * @property {PIXI.ParticleRenderer} particle Renderer for ParticleContainer objects.
         * @property {PIXI.Prepare} prepare Pre-render display objects.
         * @property {PIXI.BatchRenderer} batch Batching of Sprite, Graphics and Mesh objects.
         * @property {PIXI.TilingSpriteRenderer} tilingSprite Renderer for TilingSprite objects.
         */
        Renderer.__plugins = {};
        return Renderer;
    }(AbstractRenderer));
    // Handle registration of extensions
    extensions.extensions.handleByMap(extensions.ExtensionType.RendererPlugin, Renderer.__plugins);

    /**
     * This helper function will automatically detect which renderer you should be using.
     * WebGL is the preferred renderer as it is a lot faster. If WebGL is not supported by
     * the browser then this function will return a canvas renderer
     * @memberof PIXI
     * @function autoDetectRenderer
     * @param {object} [options] - The optional renderer parameters
     * @param {number} [options.width=800] - the width of the renderers view
     * @param {number} [options.height=600] - the height of the renderers view
     * @param {HTMLCanvasElement} [options.view] - the canvas to use as a view, optional
     * @param {boolean} [options.useContextAlpha=true] - Pass-through value for canvas' context `alpha` property.
     *   If you want to set transparency, please use `backgroundAlpha`. This option is for cases where the
     *   canvas needs to be opaque, possibly for performance reasons on some older devices.
     * @param {boolean} [options.autoDensity=false] - Resizes renderer view in CSS pixels to allow for
     *   resolutions other than 1
     * @param {boolean} [options.antialias=false] - sets antialias
     * @param {boolean} [options.preserveDrawingBuffer=false] - enables drawing buffer preservation, enable this if you
     *  need to call toDataUrl on the webgl context
     * @param {number} [options.backgroundColor=0x000000] - The background color of the rendered area
     *  (shown if not transparent).
     * @param {number} [options.backgroundAlpha=1] - Value from 0 (fully transparent) to 1 (fully opaque).
     * @param {boolean} [options.clearBeforeRender=true] - This sets if the renderer will clear the canvas or
     *   not before the new render pass.
     * @param {number} [options.resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio of the renderer.
     * @param {boolean} [options.forceCanvas=false] - prevents selection of WebGL renderer, even if such is present, this
     *   option only is available when using **pixi.js-legacy** or **@pixi/canvas-renderer** modules, otherwise
     *   it is ignored.
     * @param {string} [options.powerPreference] - Parameter passed to webgl context, set to "high-performance"
     *  for devices with dual graphics card **webgl only**
     * @returns {PIXI.Renderer|PIXI.CanvasRenderer} Returns WebGL renderer if available, otherwise CanvasRenderer
     */
    function autoDetectRenderer(options) {
        return Renderer.create(options);
    }

    var $defaultVertex = "attribute vec2 aVertexPosition;\nattribute vec2 aTextureCoord;\n\nuniform mat3 projectionMatrix;\n\nvarying vec2 vTextureCoord;\n\nvoid main(void)\n{\n    gl_Position = vec4((projectionMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\n    vTextureCoord = aTextureCoord;\n}";

    var $defaultFilterVertex = "attribute vec2 aVertexPosition;\n\nuniform mat3 projectionMatrix;\n\nvarying vec2 vTextureCoord;\n\nuniform vec4 inputSize;\nuniform vec4 outputFrame;\n\nvec4 filterVertexPosition( void )\n{\n    vec2 position = aVertexPosition * max(outputFrame.zw, vec2(0.)) + outputFrame.xy;\n\n    return vec4((projectionMatrix * vec3(position, 1.0)).xy, 0.0, 1.0);\n}\n\nvec2 filterTextureCoord( void )\n{\n    return aVertexPosition * (outputFrame.zw * inputSize.zw);\n}\n\nvoid main(void)\n{\n    gl_Position = filterVertexPosition();\n    vTextureCoord = filterTextureCoord();\n}\n";

    /**
     * Default vertex shader
     * @memberof PIXI
     * @member {string} defaultVertex
     */
    /**
     * Default filter vertex shader
     * @memberof PIXI
     * @member {string} defaultFilterVertex
     */
    // NOTE: This black magic is so that @microsoft/api-extractor does not complain! This explicitly specifies the types
    // of defaultVertex, defaultFilterVertex.
    var defaultVertex$1 = $defaultVertex;
    var defaultFilterVertex = $defaultFilterVertex;

    /**
     * Use the ISystem interface instead.
     * @deprecated since 6.1.0
     * @memberof PIXI
     */
    var System = /** @class */ (function () {
        /**
         * @param renderer - Reference to Renderer
         */
        function System(renderer) {
            utils.deprecation('6.1.0', 'System class is deprecated, implemement ISystem interface instead.');
            this.renderer = renderer;
        }
        /** Destroy and don't use after this. */
        System.prototype.destroy = function () {
            this.renderer = null;
        };
        return System;
    }());

    /**
     * Used by the batcher to draw batches.
     * Each one of these contains all information required to draw a bound geometry.
     * @memberof PIXI
     */
    var BatchDrawCall = /** @class */ (function () {
        function BatchDrawCall() {
            this.texArray = null;
            this.blend = 0;
            this.type = constants.DRAW_MODES.TRIANGLES;
            this.start = 0;
            this.size = 0;
            this.data = null;
        }
        return BatchDrawCall;
    }());

    /**
     * Used by the batcher to build texture batches.
     * Holds list of textures and their respective locations.
     * @memberof PIXI
     */
    var BatchTextureArray = /** @class */ (function () {
        function BatchTextureArray() {
            this.elements = [];
            this.ids = [];
            this.count = 0;
        }
        BatchTextureArray.prototype.clear = function () {
            for (var i = 0; i < this.count; i++) {
                this.elements[i] = null;
            }
            this.count = 0;
        };
        return BatchTextureArray;
    }());

    /**
     * Flexible wrapper around `ArrayBuffer` that also provides typed array views on demand.
     * @memberof PIXI
     */
    var ViewableBuffer = /** @class */ (function () {
        function ViewableBuffer(sizeOrBuffer) {
            if (typeof sizeOrBuffer === 'number') {
                this.rawBinaryData = new ArrayBuffer(sizeOrBuffer);
            }
            else if (sizeOrBuffer instanceof Uint8Array) {
                this.rawBinaryData = sizeOrBuffer.buffer;
            }
            else {
                this.rawBinaryData = sizeOrBuffer;
            }
            this.uint32View = new Uint32Array(this.rawBinaryData);
            this.float32View = new Float32Array(this.rawBinaryData);
        }
        Object.defineProperty(ViewableBuffer.prototype, "int8View", {
            /** View on the raw binary data as a `Int8Array`. */
            get: function () {
                if (!this._int8View) {
                    this._int8View = new Int8Array(this.rawBinaryData);
                }
                return this._int8View;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(ViewableBuffer.prototype, "uint8View", {
            /** View on the raw binary data as a `Uint8Array`. */
            get: function () {
                if (!this._uint8View) {
                    this._uint8View = new Uint8Array(this.rawBinaryData);
                }
                return this._uint8View;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(ViewableBuffer.prototype, "int16View", {
            /**  View on the raw binary data as a `Int16Array`. */
            get: function () {
                if (!this._int16View) {
                    this._int16View = new Int16Array(this.rawBinaryData);
                }
                return this._int16View;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(ViewableBuffer.prototype, "uint16View", {
            /** View on the raw binary data as a `Uint16Array`. */
            get: function () {
                if (!this._uint16View) {
                    this._uint16View = new Uint16Array(this.rawBinaryData);
                }
                return this._uint16View;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(ViewableBuffer.prototype, "int32View", {
            /** View on the raw binary data as a `Int32Array`. */
            get: function () {
                if (!this._int32View) {
                    this._int32View = new Int32Array(this.rawBinaryData);
                }
                return this._int32View;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Returns the view of the given type.
         * @param type - One of `int8`, `uint8`, `int16`,
         *    `uint16`, `int32`, `uint32`, and `float32`.
         * @returns - typed array of given type
         */
        ViewableBuffer.prototype.view = function (type) {
            return this[type + "View"];
        };
        /** Destroys all buffer references. Do not use after calling this. */
        ViewableBuffer.prototype.destroy = function () {
            this.rawBinaryData = null;
            this._int8View = null;
            this._uint8View = null;
            this._int16View = null;
            this._uint16View = null;
            this._int32View = null;
            this.uint32View = null;
            this.float32View = null;
        };
        ViewableBuffer.sizeOf = function (type) {
            switch (type) {
                case 'int8':
                case 'uint8':
                    return 1;
                case 'int16':
                case 'uint16':
                    return 2;
                case 'int32':
                case 'uint32':
                case 'float32':
                    return 4;
                default:
                    throw new Error(type + " isn't a valid view type");
            }
        };
        return ViewableBuffer;
    }());

    /**
     * Renderer dedicated to drawing and batching sprites.
     *
     * This is the default batch renderer. It buffers objects
     * with texture-based geometries and renders them in
     * batches. It uploads multiple textures to the GPU to
     * reduce to the number of draw calls.
     * @memberof PIXI
     */
    var AbstractBatchRenderer = /** @class */ (function (_super) {
        __extends(AbstractBatchRenderer, _super);
        /**
         * This will hook onto the renderer's `contextChange`
         * and `prerender` signals.
         * @param {PIXI.Renderer} renderer - The renderer this works for.
         */
        function AbstractBatchRenderer(renderer) {
            var _this = _super.call(this, renderer) || this;
            _this.shaderGenerator = null;
            _this.geometryClass = null;
            _this.vertexSize = null;
            _this.state = State.for2d();
            _this.size = settings.settings.SPRITE_BATCH_SIZE * 4;
            _this._vertexCount = 0;
            _this._indexCount = 0;
            _this._bufferedElements = [];
            _this._bufferedTextures = [];
            _this._bufferSize = 0;
            _this._shader = null;
            _this._packedGeometries = [];
            _this._packedGeometryPoolSize = 2;
            _this._flushId = 0;
            _this._aBuffers = {};
            _this._iBuffers = {};
            _this.MAX_TEXTURES = 1;
            _this.renderer.on('prerender', _this.onPrerender, _this);
            renderer.runners.contextChange.add(_this);
            _this._dcIndex = 0;
            _this._aIndex = 0;
            _this._iIndex = 0;
            _this._attributeBuffer = null;
            _this._indexBuffer = null;
            _this._tempBoundTextures = [];
            return _this;
        }
        /**
         * Handles the `contextChange` signal.
         *
         * It calculates `this.MAX_TEXTURES` and allocating the packed-geometry object pool.
         */
        AbstractBatchRenderer.prototype.contextChange = function () {
            var gl = this.renderer.gl;
            if (settings.settings.PREFER_ENV === constants.ENV.WEBGL_LEGACY) {
                this.MAX_TEXTURES = 1;
            }
            else {
                // step 1: first check max textures the GPU can handle.
                this.MAX_TEXTURES = Math.min(gl.getParameter(gl.MAX_TEXTURE_IMAGE_UNITS), settings.settings.SPRITE_MAX_TEXTURES);
                // step 2: check the maximum number of if statements the shader can have too..
                this.MAX_TEXTURES = checkMaxIfStatementsInShader(this.MAX_TEXTURES, gl);
            }
            this._shader = this.shaderGenerator.generateShader(this.MAX_TEXTURES);
            // we use the second shader as the first one depending on your browser
            // may omit aTextureId as it is not used by the shader so is optimized out.
            for (var i = 0; i < this._packedGeometryPoolSize; i++) {
                /* eslint-disable max-len */
                this._packedGeometries[i] = new (this.geometryClass)();
            }
            this.initFlushBuffers();
        };
        /** Makes sure that static and dynamic flush pooled objects have correct dimensions. */
        AbstractBatchRenderer.prototype.initFlushBuffers = function () {
            var _drawCallPool = AbstractBatchRenderer._drawCallPool, _textureArrayPool = AbstractBatchRenderer._textureArrayPool;
            // max draw calls
            var MAX_SPRITES = this.size / 4;
            // max texture arrays
            var MAX_TA = Math.floor(MAX_SPRITES / this.MAX_TEXTURES) + 1;
            while (_drawCallPool.length < MAX_SPRITES) {
                _drawCallPool.push(new BatchDrawCall());
            }
            while (_textureArrayPool.length < MAX_TA) {
                _textureArrayPool.push(new BatchTextureArray());
            }
            for (var i = 0; i < this.MAX_TEXTURES; i++) {
                this._tempBoundTextures[i] = null;
            }
        };
        /** Handles the `prerender` signal. It ensures that flushes start from the first geometry object again. */
        AbstractBatchRenderer.prototype.onPrerender = function () {
            this._flushId = 0;
        };
        /**
         * Buffers the "batchable" object. It need not be rendered immediately.
         * @param {PIXI.DisplayObject} element - the element to render when
         *    using this renderer
         */
        AbstractBatchRenderer.prototype.render = function (element) {
            if (!element._texture.valid) {
                return;
            }
            if (this._vertexCount + (element.vertexData.length / 2) > this.size) {
                this.flush();
            }
            this._vertexCount += element.vertexData.length / 2;
            this._indexCount += element.indices.length;
            this._bufferedTextures[this._bufferSize] = element._texture.baseTexture;
            this._bufferedElements[this._bufferSize++] = element;
        };
        AbstractBatchRenderer.prototype.buildTexturesAndDrawCalls = function () {
            var _a = this, textures = _a._bufferedTextures, MAX_TEXTURES = _a.MAX_TEXTURES;
            var textureArrays = AbstractBatchRenderer._textureArrayPool;
            var batch = this.renderer.batch;
            var boundTextures = this._tempBoundTextures;
            var touch = this.renderer.textureGC.count;
            var TICK = ++BaseTexture._globalBatch;
            var countTexArrays = 0;
            var texArray = textureArrays[0];
            var start = 0;
            batch.copyBoundTextures(boundTextures, MAX_TEXTURES);
            for (var i = 0; i < this._bufferSize; ++i) {
                var tex = textures[i];
                textures[i] = null;
                if (tex._batchEnabled === TICK) {
                    continue;
                }
                if (texArray.count >= MAX_TEXTURES) {
                    batch.boundArray(texArray, boundTextures, TICK, MAX_TEXTURES);
                    this.buildDrawCalls(texArray, start, i);
                    start = i;
                    texArray = textureArrays[++countTexArrays];
                    ++TICK;
                }
                tex._batchEnabled = TICK;
                tex.touched = touch;
                texArray.elements[texArray.count++] = tex;
            }
            if (texArray.count > 0) {
                batch.boundArray(texArray, boundTextures, TICK, MAX_TEXTURES);
                this.buildDrawCalls(texArray, start, this._bufferSize);
                ++countTexArrays;
                ++TICK;
            }
            // Clean-up
            for (var i = 0; i < boundTextures.length; i++) {
                boundTextures[i] = null;
            }
            BaseTexture._globalBatch = TICK;
        };
        /**
         * Populating drawcalls for rendering
         * @param texArray
         * @param start
         * @param finish
         */
        AbstractBatchRenderer.prototype.buildDrawCalls = function (texArray, start, finish) {
            var _a = this, elements = _a._bufferedElements, _attributeBuffer = _a._attributeBuffer, _indexBuffer = _a._indexBuffer, vertexSize = _a.vertexSize;
            var drawCalls = AbstractBatchRenderer._drawCallPool;
            var dcIndex = this._dcIndex;
            var aIndex = this._aIndex;
            var iIndex = this._iIndex;
            var drawCall = drawCalls[dcIndex];
            drawCall.start = this._iIndex;
            drawCall.texArray = texArray;
            for (var i = start; i < finish; ++i) {
                var sprite = elements[i];
                var tex = sprite._texture.baseTexture;
                var spriteBlendMode = utils.premultiplyBlendMode[tex.alphaMode ? 1 : 0][sprite.blendMode];
                elements[i] = null;
                if (start < i && drawCall.blend !== spriteBlendMode) {
                    drawCall.size = iIndex - drawCall.start;
                    start = i;
                    drawCall = drawCalls[++dcIndex];
                    drawCall.texArray = texArray;
                    drawCall.start = iIndex;
                }
                this.packInterleavedGeometry(sprite, _attributeBuffer, _indexBuffer, aIndex, iIndex);
                aIndex += sprite.vertexData.length / 2 * vertexSize;
                iIndex += sprite.indices.length;
                drawCall.blend = spriteBlendMode;
            }
            if (start < finish) {
                drawCall.size = iIndex - drawCall.start;
                ++dcIndex;
            }
            this._dcIndex = dcIndex;
            this._aIndex = aIndex;
            this._iIndex = iIndex;
        };
        /**
         * Bind textures for current rendering
         * @param texArray
         */
        AbstractBatchRenderer.prototype.bindAndClearTexArray = function (texArray) {
            var textureSystem = this.renderer.texture;
            for (var j = 0; j < texArray.count; j++) {
                textureSystem.bind(texArray.elements[j], texArray.ids[j]);
                texArray.elements[j] = null;
            }
            texArray.count = 0;
        };
        AbstractBatchRenderer.prototype.updateGeometry = function () {
            var _a = this, packedGeometries = _a._packedGeometries, attributeBuffer = _a._attributeBuffer, indexBuffer = _a._indexBuffer;
            if (!settings.settings.CAN_UPLOAD_SAME_BUFFER) { /* Usually on iOS devices, where the browser doesn't
                like uploads to the same buffer in a single frame. */
                if (this._packedGeometryPoolSize <= this._flushId) {
                    this._packedGeometryPoolSize++;
                    packedGeometries[this._flushId] = new (this.geometryClass)();
                }
                packedGeometries[this._flushId]._buffer.update(attributeBuffer.rawBinaryData);
                packedGeometries[this._flushId]._indexBuffer.update(indexBuffer);
                this.renderer.geometry.bind(packedGeometries[this._flushId]);
                this.renderer.geometry.updateBuffers();
                this._flushId++;
            }
            else {
                // lets use the faster option, always use buffer number 0
                packedGeometries[this._flushId]._buffer.update(attributeBuffer.rawBinaryData);
                packedGeometries[this._flushId]._indexBuffer.update(indexBuffer);
                this.renderer.geometry.updateBuffers();
            }
        };
        AbstractBatchRenderer.prototype.drawBatches = function () {
            var dcCount = this._dcIndex;
            var _a = this.renderer, gl = _a.gl, stateSystem = _a.state;
            var drawCalls = AbstractBatchRenderer._drawCallPool;
            var curTexArray = null;
            // Upload textures and do the draw calls
            for (var i = 0; i < dcCount; i++) {
                var _b = drawCalls[i], texArray = _b.texArray, type = _b.type, size = _b.size, start = _b.start, blend = _b.blend;
                if (curTexArray !== texArray) {
                    curTexArray = texArray;
                    this.bindAndClearTexArray(texArray);
                }
                this.state.blendMode = blend;
                stateSystem.set(this.state);
                gl.drawElements(type, size, gl.UNSIGNED_SHORT, start * 2);
            }
        };
        /** Renders the content _now_ and empties the current batch. */
        AbstractBatchRenderer.prototype.flush = function () {
            if (this._vertexCount === 0) {
                return;
            }
            this._attributeBuffer = this.getAttributeBuffer(this._vertexCount);
            this._indexBuffer = this.getIndexBuffer(this._indexCount);
            this._aIndex = 0;
            this._iIndex = 0;
            this._dcIndex = 0;
            this.buildTexturesAndDrawCalls();
            this.updateGeometry();
            this.drawBatches();
            // reset elements buffer for the next flush
            this._bufferSize = 0;
            this._vertexCount = 0;
            this._indexCount = 0;
        };
        /** Starts a new sprite batch. */
        AbstractBatchRenderer.prototype.start = function () {
            this.renderer.state.set(this.state);
            this.renderer.texture.ensureSamplerType(this.MAX_TEXTURES);
            this.renderer.shader.bind(this._shader);
            if (settings.settings.CAN_UPLOAD_SAME_BUFFER) {
                // bind buffer #0, we don't need others
                this.renderer.geometry.bind(this._packedGeometries[this._flushId]);
            }
        };
        /** Stops and flushes the current batch. */
        AbstractBatchRenderer.prototype.stop = function () {
            this.flush();
        };
        /** Destroys this `AbstractBatchRenderer`. It cannot be used again. */
        AbstractBatchRenderer.prototype.destroy = function () {
            for (var i = 0; i < this._packedGeometryPoolSize; i++) {
                if (this._packedGeometries[i]) {
                    this._packedGeometries[i].destroy();
                }
            }
            this.renderer.off('prerender', this.onPrerender, this);
            this._aBuffers = null;
            this._iBuffers = null;
            this._packedGeometries = null;
            this._attributeBuffer = null;
            this._indexBuffer = null;
            if (this._shader) {
                this._shader.destroy();
                this._shader = null;
            }
            _super.prototype.destroy.call(this);
        };
        /**
         * Fetches an attribute buffer from `this._aBuffers` that can hold atleast `size` floats.
         * @param size - minimum capacity required
         * @returns - buffer than can hold atleast `size` floats
         */
        AbstractBatchRenderer.prototype.getAttributeBuffer = function (size) {
            // 8 vertices is enough for 2 quads
            var roundedP2 = utils.nextPow2(Math.ceil(size / 8));
            var roundedSizeIndex = utils.log2(roundedP2);
            var roundedSize = roundedP2 * 8;
            if (this._aBuffers.length <= roundedSizeIndex) {
                this._iBuffers.length = roundedSizeIndex + 1;
            }
            var buffer = this._aBuffers[roundedSize];
            if (!buffer) {
                this._aBuffers[roundedSize] = buffer = new ViewableBuffer(roundedSize * this.vertexSize * 4);
            }
            return buffer;
        };
        /**
         * Fetches an index buffer from `this._iBuffers` that can
         * have at least `size` capacity.
         * @param size - minimum required capacity
         * @returns - buffer that can fit `size` indices.
         */
        AbstractBatchRenderer.prototype.getIndexBuffer = function (size) {
            // 12 indices is enough for 2 quads
            var roundedP2 = utils.nextPow2(Math.ceil(size / 12));
            var roundedSizeIndex = utils.log2(roundedP2);
            var roundedSize = roundedP2 * 12;
            if (this._iBuffers.length <= roundedSizeIndex) {
                this._iBuffers.length = roundedSizeIndex + 1;
            }
            var buffer = this._iBuffers[roundedSizeIndex];
            if (!buffer) {
                this._iBuffers[roundedSizeIndex] = buffer = new Uint16Array(roundedSize);
            }
            return buffer;
        };
        /**
         * Takes the four batching parameters of `element`, interleaves
         * and pushes them into the batching attribute/index buffers given.
         *
         * It uses these properties: `vertexData` `uvs`, `textureId` and
         * `indicies`. It also uses the "tint" of the base-texture, if
         * present.
         * @param {PIXI.DisplayObject} element - element being rendered
         * @param attributeBuffer - attribute buffer.
         * @param indexBuffer - index buffer
         * @param aIndex - number of floats already in the attribute buffer
         * @param iIndex - number of indices already in `indexBuffer`
         */
        AbstractBatchRenderer.prototype.packInterleavedGeometry = function (element, attributeBuffer, indexBuffer, aIndex, iIndex) {
            var uint32View = attributeBuffer.uint32View, float32View = attributeBuffer.float32View;
            var packedVertices = aIndex / this.vertexSize;
            var uvs = element.uvs;
            var indicies = element.indices;
            var vertexData = element.vertexData;
            var textureId = element._texture.baseTexture._batchLocation;
            var alpha = Math.min(element.worldAlpha, 1.0);
            var argb = (alpha < 1.0
                && element._texture.baseTexture.alphaMode)
                ? utils.premultiplyTint(element._tintRGB, alpha)
                : element._tintRGB + (alpha * 255 << 24);
            // lets not worry about tint! for now..
            for (var i = 0; i < vertexData.length; i += 2) {
                float32View[aIndex++] = vertexData[i];
                float32View[aIndex++] = vertexData[i + 1];
                float32View[aIndex++] = uvs[i];
                float32View[aIndex++] = uvs[i + 1];
                uint32View[aIndex++] = argb;
                float32View[aIndex++] = textureId;
            }
            for (var i = 0; i < indicies.length; i++) {
                indexBuffer[iIndex++] = packedVertices + indicies[i];
            }
        };
        /**
         * Pool of `BatchDrawCall` objects that `flush` used
         * to create "batches" of the objects being rendered.
         *
         * These are never re-allocated again.
         * Shared between all batch renderers because it can be only one "flush" working at the moment.
         * @member {PIXI.BatchDrawCall[]}
         */
        AbstractBatchRenderer._drawCallPool = [];
        /**
         * Pool of `BatchDrawCall` objects that `flush` used
         * to create "batches" of the objects being rendered.
         *
         * These are never re-allocated again.
         * Shared between all batch renderers because it can be only one "flush" working at the moment.
         * @member {PIXI.BatchTextureArray[]}
         */
        AbstractBatchRenderer._textureArrayPool = [];
        return AbstractBatchRenderer;
    }(ObjectRenderer));

    /**
     * Helper that generates batching multi-texture shader. Use it with your new BatchRenderer
     * @memberof PIXI
     */
    var BatchShaderGenerator = /** @class */ (function () {
        /**
         * @param vertexSrc - Vertex shader
         * @param fragTemplate - Fragment shader template
         */
        function BatchShaderGenerator(vertexSrc, fragTemplate) {
            this.vertexSrc = vertexSrc;
            this.fragTemplate = fragTemplate;
            this.programCache = {};
            this.defaultGroupCache = {};
            if (fragTemplate.indexOf('%count%') < 0) {
                throw new Error('Fragment template must contain "%count%".');
            }
            if (fragTemplate.indexOf('%forloop%') < 0) {
                throw new Error('Fragment template must contain "%forloop%".');
            }
        }
        BatchShaderGenerator.prototype.generateShader = function (maxTextures) {
            if (!this.programCache[maxTextures]) {
                var sampleValues = new Int32Array(maxTextures);
                for (var i = 0; i < maxTextures; i++) {
                    sampleValues[i] = i;
                }
                this.defaultGroupCache[maxTextures] = UniformGroup.from({ uSamplers: sampleValues }, true);
                var fragmentSrc = this.fragTemplate;
                fragmentSrc = fragmentSrc.replace(/%count%/gi, "" + maxTextures);
                fragmentSrc = fragmentSrc.replace(/%forloop%/gi, this.generateSampleSrc(maxTextures));
                this.programCache[maxTextures] = new Program(this.vertexSrc, fragmentSrc);
            }
            var uniforms = {
                tint: new Float32Array([1, 1, 1, 1]),
                translationMatrix: new math.Matrix(),
                default: this.defaultGroupCache[maxTextures],
            };
            return new Shader(this.programCache[maxTextures], uniforms);
        };
        BatchShaderGenerator.prototype.generateSampleSrc = function (maxTextures) {
            var src = '';
            src += '\n';
            src += '\n';
            for (var i = 0; i < maxTextures; i++) {
                if (i > 0) {
                    src += '\nelse ';
                }
                if (i < maxTextures - 1) {
                    src += "if(vTextureId < " + i + ".5)";
                }
                src += '\n{';
                src += "\n\tcolor = texture2D(uSamplers[" + i + "], vTextureCoord);";
                src += '\n}';
            }
            src += '\n';
            src += '\n';
            return src;
        };
        return BatchShaderGenerator;
    }());

    /**
     * Geometry used to batch standard PIXI content (e.g. Mesh, Sprite, Graphics objects).
     * @memberof PIXI
     */
    var BatchGeometry = /** @class */ (function (_super) {
        __extends(BatchGeometry, _super);
        /**
         * @param {boolean} [_static=false] - Optimization flag, where `false`
         *        is updated every frame, `true` doesn't change frame-to-frame.
         */
        function BatchGeometry(_static) {
            if (_static === void 0) { _static = false; }
            var _this = _super.call(this) || this;
            _this._buffer = new Buffer(null, _static, false);
            _this._indexBuffer = new Buffer(null, _static, true);
            _this.addAttribute('aVertexPosition', _this._buffer, 2, false, constants.TYPES.FLOAT)
                .addAttribute('aTextureCoord', _this._buffer, 2, false, constants.TYPES.FLOAT)
                .addAttribute('aColor', _this._buffer, 4, true, constants.TYPES.UNSIGNED_BYTE)
                .addAttribute('aTextureId', _this._buffer, 1, true, constants.TYPES.FLOAT)
                .addIndex(_this._indexBuffer);
            return _this;
        }
        return BatchGeometry;
    }(Geometry));

    var defaultVertex = "precision highp float;\nattribute vec2 aVertexPosition;\nattribute vec2 aTextureCoord;\nattribute vec4 aColor;\nattribute float aTextureId;\n\nuniform mat3 projectionMatrix;\nuniform mat3 translationMatrix;\nuniform vec4 tint;\n\nvarying vec2 vTextureCoord;\nvarying vec4 vColor;\nvarying float vTextureId;\n\nvoid main(void){\n    gl_Position = vec4((projectionMatrix * translationMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\n\n    vTextureCoord = aTextureCoord;\n    vTextureId = aTextureId;\n    vColor = aColor * tint;\n}\n";

    var defaultFragment = "varying vec2 vTextureCoord;\nvarying vec4 vColor;\nvarying float vTextureId;\nuniform sampler2D uSamplers[%count%];\n\nvoid main(void){\n    vec4 color;\n    %forloop%\n    gl_FragColor = color * vColor;\n}\n";

    /** @memberof PIXI */
    var BatchPluginFactory = /** @class */ (function () {
        function BatchPluginFactory() {
        }
        /**
         * Create a new BatchRenderer plugin for Renderer. this convenience can provide an easy way
         * to extend BatchRenderer with all the necessary pieces.
         * @example
         * const fragment = `
         * varying vec2 vTextureCoord;
         * varying vec4 vColor;
         * varying float vTextureId;
         * uniform sampler2D uSamplers[%count%];
         *
         * void main(void){
         *     vec4 color;
         *     %forloop%
         *     gl_FragColor = vColor * vec4(color.a - color.rgb, color.a);
         * }
         * `;
         * const InvertBatchRenderer = PIXI.BatchPluginFactory.create({ fragment });
         * PIXI.extensions.add({
         *  name: 'invert',
         *  ref: InvertBatchRenderer,
         *  type: PIXI.ExtensionType.RendererPlugin,
         * });
         * const sprite = new PIXI.Sprite();
         * sprite.pluginName = 'invert';
         * @param {object} [options]
         * @param {string} [options.vertex=PIXI.BatchPluginFactory.defaultVertexSrc] - Vertex shader source
         * @param {string} [options.fragment=PIXI.BatchPluginFactory.defaultFragmentTemplate] - Fragment shader template
         * @param {number} [options.vertexSize=6] - Vertex size
         * @param {object} [options.geometryClass=PIXI.BatchGeometry]
         * @returns {*} New batch renderer plugin
         */
        BatchPluginFactory.create = function (options) {
            var _a = Object.assign({
                vertex: defaultVertex,
                fragment: defaultFragment,
                geometryClass: BatchGeometry,
                vertexSize: 6,
            }, options), vertex = _a.vertex, fragment = _a.fragment, vertexSize = _a.vertexSize, geometryClass = _a.geometryClass;
            return /** @class */ (function (_super) {
                __extends(BatchPlugin, _super);
                function BatchPlugin(renderer) {
                    var _this = _super.call(this, renderer) || this;
                    _this.shaderGenerator = new BatchShaderGenerator(vertex, fragment);
                    _this.geometryClass = geometryClass;
                    _this.vertexSize = vertexSize;
                    return _this;
                }
                return BatchPlugin;
            }(AbstractBatchRenderer));
        };
        Object.defineProperty(BatchPluginFactory, "defaultVertexSrc", {
            /**
             * The default vertex shader source
             * @readonly
             */
            get: function () {
                return defaultVertex;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BatchPluginFactory, "defaultFragmentTemplate", {
            /**
             * The default fragment shader source
             * @readonly
             */
            get: function () {
                return defaultFragment;
            },
            enumerable: false,
            configurable: true
        });
        return BatchPluginFactory;
    }());
    // Setup the default BatchRenderer plugin, this is what
    // we'll actually export at the root level
    var BatchRenderer = BatchPluginFactory.create();
    Object.assign(BatchRenderer, {
        extension: {
            name: 'batch',
            type: extensions.ExtensionType.RendererPlugin,
        },
    });

    /**
     * @memberof PIXI
     * @namespace resources
     * @see PIXI
     * @deprecated since 6.0.0
     */
    var resources = {};
    var _loop_1 = function (name) {
        Object.defineProperty(resources, name, {
            get: function () {
                utils.deprecation('6.0.0', "PIXI.systems." + name + " has moved to PIXI." + name);
                return _resources[name];
            },
        });
    };
    for (var name in _resources) {
        _loop_1(name);
    }
    /**
     * @memberof PIXI
     * @namespace systems
     * @see PIXI
     * @deprecated since 6.0.0
     */
    var systems = {};
    var _loop_2 = function (name) {
        Object.defineProperty(systems, name, {
            get: function () {
                utils.deprecation('6.0.0', "PIXI.resources." + name + " has moved to PIXI." + name);
                return _systems[name];
            },
        });
    };
    for (var name in _systems) {
        _loop_2(name);
    }

    /**
     * @namespace PIXI
     */
    /**
     * String of the current PIXI version.
     * @memberof PIXI
     */
    var VERSION = '6.5.2';

    exports.AbstractBatchRenderer = AbstractBatchRenderer;
    exports.AbstractMultiResource = AbstractMultiResource;
    exports.AbstractRenderer = AbstractRenderer;
    exports.ArrayResource = ArrayResource;
    exports.Attribute = Attribute;
    exports.BaseImageResource = BaseImageResource;
    exports.BaseRenderTexture = BaseRenderTexture;
    exports.BaseTexture = BaseTexture;
    exports.BatchDrawCall = BatchDrawCall;
    exports.BatchGeometry = BatchGeometry;
    exports.BatchPluginFactory = BatchPluginFactory;
    exports.BatchRenderer = BatchRenderer;
    exports.BatchShaderGenerator = BatchShaderGenerator;
    exports.BatchSystem = BatchSystem;
    exports.BatchTextureArray = BatchTextureArray;
    exports.Buffer = Buffer;
    exports.BufferResource = BufferResource;
    exports.CanvasResource = CanvasResource;
    exports.ContextSystem = ContextSystem;
    exports.CubeResource = CubeResource;
    exports.Filter = Filter;
    exports.FilterState = FilterState;
    exports.FilterSystem = FilterSystem;
    exports.Framebuffer = Framebuffer;
    exports.FramebufferSystem = FramebufferSystem;
    exports.GLFramebuffer = GLFramebuffer;
    exports.GLProgram = GLProgram;
    exports.GLTexture = GLTexture;
    exports.Geometry = Geometry;
    exports.GeometrySystem = GeometrySystem;
    exports.IGLUniformData = IGLUniformData;
    exports.INSTALLED = INSTALLED;
    exports.ImageBitmapResource = ImageBitmapResource;
    exports.ImageResource = ImageResource;
    exports.MaskData = MaskData;
    exports.MaskSystem = MaskSystem;
    exports.ObjectRenderer = ObjectRenderer;
    exports.Program = Program;
    exports.ProjectionSystem = ProjectionSystem;
    exports.Quad = Quad;
    exports.QuadUv = QuadUv;
    exports.RenderTexture = RenderTexture;
    exports.RenderTexturePool = RenderTexturePool;
    exports.RenderTextureSystem = RenderTextureSystem;
    exports.Renderer = Renderer;
    exports.Resource = Resource;
    exports.SVGResource = SVGResource;
    exports.ScissorSystem = ScissorSystem;
    exports.Shader = Shader;
    exports.ShaderSystem = ShaderSystem;
    exports.SpriteMaskFilter = SpriteMaskFilter;
    exports.State = State;
    exports.StateSystem = StateSystem;
    exports.StencilSystem = StencilSystem;
    exports.System = System;
    exports.Texture = Texture;
    exports.TextureGCSystem = TextureGCSystem;
    exports.TextureMatrix = TextureMatrix;
    exports.TextureSystem = TextureSystem;
    exports.TextureUvs = TextureUvs;
    exports.UniformGroup = UniformGroup;
    exports.VERSION = VERSION;
    exports.VideoResource = VideoResource;
    exports.ViewableBuffer = ViewableBuffer;
    exports.autoDetectRenderer = autoDetectRenderer;
    exports.autoDetectResource = autoDetectResource;
    exports.checkMaxIfStatementsInShader = checkMaxIfStatementsInShader;
    exports.createUBOElements = createUBOElements;
    exports.defaultFilterVertex = defaultFilterVertex;
    exports.defaultVertex = defaultVertex$1;
    exports.generateProgram = generateProgram;
    exports.generateUniformBufferSync = generateUniformBufferSync;
    exports.getTestContext = getTestContext;
    exports.getUBOData = getUBOData;
    exports.resources = resources;
    exports.systems = systems;
    exports.uniformParsers = uniformParsers;
    Object.keys(extensions).forEach(function (k) {
        if (k !== 'default' && !exports.hasOwnProperty(k)) Object.defineProperty(exports, k, {
            enumerable: true,
            get: function () { return extensions[k]; }
        });
    });

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI.utils, PIXI, PIXI, PIXI, PIXI);
Object.assign(this.PIXI, _pixi_core);
//# sourceMappingURL=core.js.map
