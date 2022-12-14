/*!
 * @pixi/sprite - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/sprite is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_sprite = (function (exports, constants, core, display, math, settings, utils) {
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
            _this._anchor = new math.ObservablePoint(_this._onAnchorUpdate, _this, (texture ? texture.defaultAnchor.x : 0), (texture ? texture.defaultAnchor.y : 0));
            _this._texture = null;
            _this._width = 0;
            _this._height = 0;
            _this._tint = null;
            _this._tintRGB = null;
            _this.tint = 0xFFFFFF;
            _this.blendMode = constants.BLEND_MODES.NORMAL;
            _this._cachedTint = 0xFFFFFF;
            _this.uvs = null;
            // call texture setter
            _this.texture = texture || core.Texture.EMPTY;
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
            _this._roundPixels = settings.settings.ROUND_PIXELS;
            return _this;
        }
        /** When the texture is updated, this event will fire to update the scale and frame. */
        Sprite.prototype._onTextureUpdate = function () {
            this._textureID = -1;
            this._textureTrimmedID = -1;
            this._cachedTint = 0xFFFFFF;
            // so if _width is 0 then width was not set..
            if (this._width) {
                this.scale.x = utils.sign(this.scale.x) * this._width / this._texture.orig.width;
            }
            if (this._height) {
                this.scale.y = utils.sign(this.scale.y) * this._height / this._texture.orig.height;
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
                var resolution = settings.settings.RESOLUTION;
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
                    this._localBounds = new display.Bounds();
                }
                this._localBounds.minX = this._texture.orig.width * -this._anchor._x;
                this._localBounds.minY = this._texture.orig.height * -this._anchor._y;
                this._localBounds.maxX = this._texture.orig.width * (1 - this._anchor._x);
                this._localBounds.maxY = this._texture.orig.height * (1 - this._anchor._y);
                if (!rect) {
                    if (!this._localBoundsRect) {
                        this._localBoundsRect = new math.Rectangle();
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
            var texture = (source instanceof core.Texture)
                ? source
                : core.Texture.from(source, options);
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
                var s = utils.sign(this.scale.x) || 1;
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
                var s = utils.sign(this.scale.y) || 1;
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
                this._texture = value || core.Texture.EMPTY;
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
    }(display.Container));

    exports.Sprite = Sprite;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI, PIXI, PIXI, PIXI.utils);
Object.assign(this.PIXI, _pixi_sprite);
//# sourceMappingURL=sprite.js.map
