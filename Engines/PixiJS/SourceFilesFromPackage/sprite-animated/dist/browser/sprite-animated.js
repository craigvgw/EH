/*!
 * @pixi/sprite-animated - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/sprite-animated is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_sprite_animated = (function (exports, core, sprite, ticker) {
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
     * An AnimatedSprite is a simple way to display an animation depicted by a list of textures.
     *
     * ```js
     * let alienImages = ["image_sequence_01.png","image_sequence_02.png","image_sequence_03.png","image_sequence_04.png"];
     * let textureArray = [];
     *
     * for (let i=0; i < 4; i++)
     * {
     *      let texture = PIXI.Texture.from(alienImages[i]);
     *      textureArray.push(texture);
     * };
     *
     * let animatedSprite = new PIXI.AnimatedSprite(textureArray);
     * ```
     *
     * The more efficient and simpler way to create an animated sprite is using a {@link PIXI.Spritesheet}
     * containing the animation definitions:
     *
     * ```js
     * PIXI.Loader.shared.add("assets/spritesheet.json").load(setup);
     *
     * function setup() {
     *   let sheet = PIXI.Loader.shared.resources["assets/spritesheet.json"].spritesheet;
     *   animatedSprite = new PIXI.AnimatedSprite(sheet.animations["image_sequence"]);
     *   ...
     * }
     * ```
     * @memberof PIXI
     */
    var AnimatedSprite = /** @class */ (function (_super) {
        __extends(AnimatedSprite, _super);
        /**
         * @param textures - An array of {@link PIXI.Texture} or frame
         *  objects that make up the animation.
         * @param {boolean} [autoUpdate=true] - Whether to use PIXI.Ticker.shared to auto update animation time.
         */
        function AnimatedSprite(textures, autoUpdate) {
            if (autoUpdate === void 0) { autoUpdate = true; }
            var _this = _super.call(this, textures[0] instanceof core.Texture ? textures[0] : textures[0].texture) || this;
            _this._textures = null;
            _this._durations = null;
            _this._autoUpdate = autoUpdate;
            _this._isConnectedToTicker = false;
            _this.animationSpeed = 1;
            _this.loop = true;
            _this.updateAnchor = false;
            _this.onComplete = null;
            _this.onFrameChange = null;
            _this.onLoop = null;
            _this._currentTime = 0;
            _this._playing = false;
            _this._previousFrame = null;
            _this.textures = textures;
            return _this;
        }
        /** Stops the AnimatedSprite. */
        AnimatedSprite.prototype.stop = function () {
            if (!this._playing) {
                return;
            }
            this._playing = false;
            if (this._autoUpdate && this._isConnectedToTicker) {
                ticker.Ticker.shared.remove(this.update, this);
                this._isConnectedToTicker = false;
            }
        };
        /** Plays the AnimatedSprite. */
        AnimatedSprite.prototype.play = function () {
            if (this._playing) {
                return;
            }
            this._playing = true;
            if (this._autoUpdate && !this._isConnectedToTicker) {
                ticker.Ticker.shared.add(this.update, this, ticker.UPDATE_PRIORITY.HIGH);
                this._isConnectedToTicker = true;
            }
        };
        /**
         * Stops the AnimatedSprite and goes to a specific frame.
         * @param frameNumber - Frame index to stop at.
         */
        AnimatedSprite.prototype.gotoAndStop = function (frameNumber) {
            this.stop();
            var previousFrame = this.currentFrame;
            this._currentTime = frameNumber;
            if (previousFrame !== this.currentFrame) {
                this.updateTexture();
            }
        };
        /**
         * Goes to a specific frame and begins playing the AnimatedSprite.
         * @param frameNumber - Frame index to start at.
         */
        AnimatedSprite.prototype.gotoAndPlay = function (frameNumber) {
            var previousFrame = this.currentFrame;
            this._currentTime = frameNumber;
            if (previousFrame !== this.currentFrame) {
                this.updateTexture();
            }
            this.play();
        };
        /**
         * Updates the object transform for rendering.
         * @param deltaTime - Time since last tick.
         */
        AnimatedSprite.prototype.update = function (deltaTime) {
            if (!this._playing) {
                return;
            }
            var elapsed = this.animationSpeed * deltaTime;
            var previousFrame = this.currentFrame;
            if (this._durations !== null) {
                var lag = this._currentTime % 1 * this._durations[this.currentFrame];
                lag += elapsed / 60 * 1000;
                while (lag < 0) {
                    this._currentTime--;
                    lag += this._durations[this.currentFrame];
                }
                var sign = Math.sign(this.animationSpeed * deltaTime);
                this._currentTime = Math.floor(this._currentTime);
                while (lag >= this._durations[this.currentFrame]) {
                    lag -= this._durations[this.currentFrame] * sign;
                    this._currentTime += sign;
                }
                this._currentTime += lag / this._durations[this.currentFrame];
            }
            else {
                this._currentTime += elapsed;
            }
            if (this._currentTime < 0 && !this.loop) {
                this.gotoAndStop(0);
                if (this.onComplete) {
                    this.onComplete();
                }
            }
            else if (this._currentTime >= this._textures.length && !this.loop) {
                this.gotoAndStop(this._textures.length - 1);
                if (this.onComplete) {
                    this.onComplete();
                }
            }
            else if (previousFrame !== this.currentFrame) {
                if (this.loop && this.onLoop) {
                    if (this.animationSpeed > 0 && this.currentFrame < previousFrame) {
                        this.onLoop();
                    }
                    else if (this.animationSpeed < 0 && this.currentFrame > previousFrame) {
                        this.onLoop();
                    }
                }
                this.updateTexture();
            }
        };
        /** Updates the displayed texture to match the current frame index. */
        AnimatedSprite.prototype.updateTexture = function () {
            var currentFrame = this.currentFrame;
            if (this._previousFrame === currentFrame) {
                return;
            }
            this._previousFrame = currentFrame;
            this._texture = this._textures[currentFrame];
            this._textureID = -1;
            this._textureTrimmedID = -1;
            this._cachedTint = 0xFFFFFF;
            this.uvs = this._texture._uvs.uvsFloat32;
            if (this.updateAnchor) {
                this._anchor.copyFrom(this._texture.defaultAnchor);
            }
            if (this.onFrameChange) {
                this.onFrameChange(this.currentFrame);
            }
        };
        /**
         * Stops the AnimatedSprite and destroys it.
         * @param {object|boolean} [options] - Options parameter. A boolean will act as if all options
         *  have been set to that value.
         * @param {boolean} [options.children=false] - If set to true, all the children will have their destroy
         *      method called as well. 'options' will be passed on to those calls.
         * @param {boolean} [options.texture=false] - Should it destroy the current texture of the sprite as well.
         * @param {boolean} [options.baseTexture=false] - Should it destroy the base texture of the sprite as well.
         */
        AnimatedSprite.prototype.destroy = function (options) {
            this.stop();
            _super.prototype.destroy.call(this, options);
            this.onComplete = null;
            this.onFrameChange = null;
            this.onLoop = null;
        };
        /**
         * A short hand way of creating an AnimatedSprite from an array of frame ids.
         * @param frames - The array of frames ids the AnimatedSprite will use as its texture frames.
         * @returns - The new animated sprite with the specified frames.
         */
        AnimatedSprite.fromFrames = function (frames) {
            var textures = [];
            for (var i = 0; i < frames.length; ++i) {
                textures.push(core.Texture.from(frames[i]));
            }
            return new AnimatedSprite(textures);
        };
        /**
         * A short hand way of creating an AnimatedSprite from an array of image ids.
         * @param images - The array of image urls the AnimatedSprite will use as its texture frames.
         * @returns The new animate sprite with the specified images as frames.
         */
        AnimatedSprite.fromImages = function (images) {
            var textures = [];
            for (var i = 0; i < images.length; ++i) {
                textures.push(core.Texture.from(images[i]));
            }
            return new AnimatedSprite(textures);
        };
        Object.defineProperty(AnimatedSprite.prototype, "totalFrames", {
            /**
             * The total number of frames in the AnimatedSprite. This is the same as number of textures
             * assigned to the AnimatedSprite.
             * @readonly
             * @default 0
             */
            get: function () {
                return this._textures.length;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(AnimatedSprite.prototype, "textures", {
            /** The array of textures used for this AnimatedSprite. */
            get: function () {
                return this._textures;
            },
            set: function (value) {
                if (value[0] instanceof core.Texture) {
                    this._textures = value;
                    this._durations = null;
                }
                else {
                    this._textures = [];
                    this._durations = [];
                    for (var i = 0; i < value.length; i++) {
                        this._textures.push(value[i].texture);
                        this._durations.push(value[i].time);
                    }
                }
                this._previousFrame = null;
                this.gotoAndStop(0);
                this.updateTexture();
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(AnimatedSprite.prototype, "currentFrame", {
            /**
             * The AnimatedSprites current frame index.
             * @readonly
             */
            get: function () {
                var currentFrame = Math.floor(this._currentTime) % this._textures.length;
                if (currentFrame < 0) {
                    currentFrame += this._textures.length;
                }
                return currentFrame;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(AnimatedSprite.prototype, "playing", {
            /**
             * Indicates if the AnimatedSprite is currently playing.
             * @readonly
             */
            get: function () {
                return this._playing;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(AnimatedSprite.prototype, "autoUpdate", {
            /** Whether to use PIXI.Ticker.shared to auto update animation time. */
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
                    else if (this._autoUpdate && !this._isConnectedToTicker && this._playing) {
                        ticker.Ticker.shared.add(this.update, this);
                        this._isConnectedToTicker = true;
                    }
                }
            },
            enumerable: false,
            configurable: true
        });
        return AnimatedSprite;
    }(sprite.Sprite));

    exports.AnimatedSprite = AnimatedSprite;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI);
Object.assign(this.PIXI, _pixi_sprite_animated);
//# sourceMappingURL=sprite-animated.js.map
