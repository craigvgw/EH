/*!
 * @pixi/prepare - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/prepare is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_prepare = (function (exports, settings, core, graphics, ticker, display, text, utils) {
    'use strict';

    /**
     * Default number of uploads per frame using prepare plugin.
     * @static
     * @memberof PIXI.settings
     * @name UPLOADS_PER_FRAME
     * @type {number}
     * @default 4
     */
    settings.settings.UPLOADS_PER_FRAME = 4;

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
     * CountLimiter limits the number of items handled by a {@link PIXI.BasePrepare} to a specified
     * number of items per frame.
     * @memberof PIXI
     */
    var CountLimiter = /** @class */ (function () {
        /**
         * @param maxItemsPerFrame - The maximum number of items that can be prepared each frame.
         */
        function CountLimiter(maxItemsPerFrame) {
            this.maxItemsPerFrame = maxItemsPerFrame;
            this.itemsLeft = 0;
        }
        /** Resets any counting properties to start fresh on a new frame. */
        CountLimiter.prototype.beginFrame = function () {
            this.itemsLeft = this.maxItemsPerFrame;
        };
        /**
         * Checks to see if another item can be uploaded. This should only be called once per item.
         * @returns If the item is allowed to be uploaded.
         */
        CountLimiter.prototype.allowedToUpload = function () {
            return this.itemsLeft-- > 0;
        };
        return CountLimiter;
    }());

    /**
     * Built-in hook to find multiple textures from objects like AnimatedSprites.
     * @private
     * @param item - Display object to check
     * @param queue - Collection of items to upload
     * @returns If a PIXI.Texture object was found.
     */
    function findMultipleBaseTextures(item, queue) {
        var result = false;
        // Objects with multiple textures
        if (item && item._textures && item._textures.length) {
            for (var i = 0; i < item._textures.length; i++) {
                if (item._textures[i] instanceof core.Texture) {
                    var baseTexture = item._textures[i].baseTexture;
                    if (queue.indexOf(baseTexture) === -1) {
                        queue.push(baseTexture);
                        result = true;
                    }
                }
            }
        }
        return result;
    }
    /**
     * Built-in hook to find BaseTextures from Texture.
     * @private
     * @param item - Display object to check
     * @param queue - Collection of items to upload
     * @returns If a PIXI.Texture object was found.
     */
    function findBaseTexture(item, queue) {
        if (item.baseTexture instanceof core.BaseTexture) {
            var texture = item.baseTexture;
            if (queue.indexOf(texture) === -1) {
                queue.push(texture);
            }
            return true;
        }
        return false;
    }
    /**
     * Built-in hook to find textures from objects.
     * @private
     * @param item - Display object to check
     * @param queue - Collection of items to upload
     * @returns If a PIXI.Texture object was found.
     */
    function findTexture(item, queue) {
        if (item._texture && item._texture instanceof core.Texture) {
            var texture = item._texture.baseTexture;
            if (queue.indexOf(texture) === -1) {
                queue.push(texture);
            }
            return true;
        }
        return false;
    }
    /**
     * Built-in hook to draw PIXI.Text to its texture.
     * @private
     * @param _helper - Not used by this upload handler
     * @param item - Item to check
     * @returns If item was uploaded.
     */
    function drawText(_helper, item) {
        if (item instanceof text.Text) {
            // updating text will return early if it is not dirty
            item.updateText(true);
            return true;
        }
        return false;
    }
    /**
     * Built-in hook to calculate a text style for a PIXI.Text object.
     * @private
     * @param _helper - Not used by this upload handler
     * @param item - Item to check
     * @returns If item was uploaded.
     */
    function calculateTextStyle(_helper, item) {
        if (item instanceof text.TextStyle) {
            var font = item.toFontString();
            text.TextMetrics.measureFont(font);
            return true;
        }
        return false;
    }
    /**
     * Built-in hook to find Text objects.
     * @private
     * @param item - Display object to check
     * @param queue - Collection of items to upload
     * @returns if a PIXI.Text object was found.
     */
    function findText(item, queue) {
        if (item instanceof text.Text) {
            // push the text style to prepare it - this can be really expensive
            if (queue.indexOf(item.style) === -1) {
                queue.push(item.style);
            }
            // also push the text object so that we can render it (to canvas/texture) if needed
            if (queue.indexOf(item) === -1) {
                queue.push(item);
            }
            // also push the Text's texture for upload to GPU
            var texture = item._texture.baseTexture;
            if (queue.indexOf(texture) === -1) {
                queue.push(texture);
            }
            return true;
        }
        return false;
    }
    /**
     * Built-in hook to find TextStyle objects.
     * @private
     * @param item - Display object to check
     * @param queue - Collection of items to upload
     * @returns If a PIXI.TextStyle object was found.
     */
    function findTextStyle(item, queue) {
        if (item instanceof text.TextStyle) {
            if (queue.indexOf(item) === -1) {
                queue.push(item);
            }
            return true;
        }
        return false;
    }
    /**
     * The prepare manager provides functionality to upload content to the GPU.
     *
     * BasePrepare handles basic queuing functionality and is extended by
     * {@link PIXI.Prepare} and {@link PIXI.CanvasPrepare}
     * to provide preparation capabilities specific to their respective renderers.
     * @example
     * // Create a sprite
     * const sprite = PIXI.Sprite.from('something.png');
     *
     * // Load object into GPU
     * app.renderer.plugins.prepare.upload(sprite, () => {
     *
     *     //Texture(s) has been uploaded to GPU
     *     app.stage.addChild(sprite);
     *
     * })
     * @abstract
     * @memberof PIXI
     */
    var BasePrepare = /** @class */ (function () {
        /**
         * @param {PIXI.AbstractRenderer} renderer - A reference to the current renderer
         */
        function BasePrepare(renderer) {
            var _this = this;
            this.limiter = new CountLimiter(settings.settings.UPLOADS_PER_FRAME);
            this.renderer = renderer;
            this.uploadHookHelper = null;
            this.queue = [];
            this.addHooks = [];
            this.uploadHooks = [];
            this.completes = [];
            this.ticking = false;
            this.delayedTick = function () {
                // unlikely, but in case we were destroyed between tick() and delayedTick()
                if (!_this.queue) {
                    return;
                }
                _this.prepareItems();
            };
            // hooks to find the correct texture
            this.registerFindHook(findText);
            this.registerFindHook(findTextStyle);
            this.registerFindHook(findMultipleBaseTextures);
            this.registerFindHook(findBaseTexture);
            this.registerFindHook(findTexture);
            // upload hooks
            this.registerUploadHook(drawText);
            this.registerUploadHook(calculateTextStyle);
        }
        /** @ignore */
        BasePrepare.prototype.upload = function (item, done) {
            var _this = this;
            if (typeof item === 'function') {
                done = item;
                item = null;
            }
            if (done) {
                utils.deprecation('6.5.0', 'BasePrepare.upload callback is deprecated, use the return Promise instead.');
            }
            return new Promise(function (resolve) {
                // If a display object, search for items
                // that we could upload
                if (item) {
                    _this.add(item);
                }
                // TODO: remove done callback and just use resolve
                var complete = function () {
                    done === null || done === void 0 ? void 0 : done();
                    resolve();
                };
                // Get the items for upload from the display
                if (_this.queue.length) {
                    _this.completes.push(complete);
                    if (!_this.ticking) {
                        _this.ticking = true;
                        ticker.Ticker.system.addOnce(_this.tick, _this, ticker.UPDATE_PRIORITY.UTILITY);
                    }
                }
                else {
                    complete();
                }
            });
        };
        /**
         * Handle tick update
         * @private
         */
        BasePrepare.prototype.tick = function () {
            setTimeout(this.delayedTick, 0);
        };
        /**
         * Actually prepare items. This is handled outside of the tick because it will take a while
         * and we do NOT want to block the current animation frame from rendering.
         * @private
         */
        BasePrepare.prototype.prepareItems = function () {
            this.limiter.beginFrame();
            // Upload the graphics
            while (this.queue.length && this.limiter.allowedToUpload()) {
                var item = this.queue[0];
                var uploaded = false;
                if (item && !item._destroyed) {
                    for (var i = 0, len = this.uploadHooks.length; i < len; i++) {
                        if (this.uploadHooks[i](this.uploadHookHelper, item)) {
                            this.queue.shift();
                            uploaded = true;
                            break;
                        }
                    }
                }
                if (!uploaded) {
                    this.queue.shift();
                }
            }
            // We're finished
            if (!this.queue.length) {
                this.ticking = false;
                var completes = this.completes.slice(0);
                this.completes.length = 0;
                for (var i = 0, len = completes.length; i < len; i++) {
                    completes[i]();
                }
            }
            else {
                // if we are not finished, on the next rAF do this again
                ticker.Ticker.system.addOnce(this.tick, this, ticker.UPDATE_PRIORITY.UTILITY);
            }
        };
        /**
         * Adds hooks for finding items.
         * @param {Function} addHook - Function call that takes two parameters: `item:*, queue:Array`
         *          function must return `true` if it was able to add item to the queue.
         * @returns Instance of plugin for chaining.
         */
        BasePrepare.prototype.registerFindHook = function (addHook) {
            if (addHook) {
                this.addHooks.push(addHook);
            }
            return this;
        };
        /**
         * Adds hooks for uploading items.
         * @param {Function} uploadHook - Function call that takes two parameters: `prepare:CanvasPrepare, item:*` and
         *          function must return `true` if it was able to handle upload of item.
         * @returns Instance of plugin for chaining.
         */
        BasePrepare.prototype.registerUploadHook = function (uploadHook) {
            if (uploadHook) {
                this.uploadHooks.push(uploadHook);
            }
            return this;
        };
        /**
         * Manually add an item to the uploading queue.
         * @param {PIXI.DisplayObject|PIXI.Container|PIXI.BaseTexture|PIXI.Texture|PIXI.Graphics|PIXI.Text|*} item - Object to
         *        add to the queue
         * @returns Instance of plugin for chaining.
         */
        BasePrepare.prototype.add = function (item) {
            // Add additional hooks for finding elements on special
            // types of objects that
            for (var i = 0, len = this.addHooks.length; i < len; i++) {
                if (this.addHooks[i](item, this.queue)) {
                    break;
                }
            }
            // Get children recursively
            if (item instanceof display.Container) {
                for (var i = item.children.length - 1; i >= 0; i--) {
                    this.add(item.children[i]);
                }
            }
            return this;
        };
        /** Destroys the plugin, don't use after this. */
        BasePrepare.prototype.destroy = function () {
            if (this.ticking) {
                ticker.Ticker.system.remove(this.tick, this);
            }
            this.ticking = false;
            this.addHooks = null;
            this.uploadHooks = null;
            this.renderer = null;
            this.completes = null;
            this.queue = null;
            this.limiter = null;
            this.uploadHookHelper = null;
        };
        return BasePrepare;
    }());

    /**
     * Built-in hook to upload PIXI.Texture objects to the GPU.
     * @private
     * @param renderer - instance of the webgl renderer
     * @param item - Item to check
     * @returns If item was uploaded.
     */
    function uploadBaseTextures(renderer, item) {
        if (item instanceof core.BaseTexture) {
            // if the texture already has a GL texture, then the texture has been prepared or rendered
            // before now. If the texture changed, then the changer should be calling texture.update() which
            // reuploads the texture without need for preparing it again
            if (!item._glTextures[renderer.CONTEXT_UID]) {
                renderer.texture.bind(item);
            }
            return true;
        }
        return false;
    }
    /**
     * Built-in hook to upload PIXI.Graphics to the GPU.
     * @private
     * @param renderer - instance of the webgl renderer
     * @param item - Item to check
     * @returns If item was uploaded.
     */
    function uploadGraphics(renderer, item) {
        if (!(item instanceof graphics.Graphics)) {
            return false;
        }
        var geometry = item.geometry;
        // update dirty graphics to get batches
        item.finishPoly();
        geometry.updateBatches();
        var batches = geometry.batches;
        // upload all textures found in styles
        for (var i = 0; i < batches.length; i++) {
            var texture = batches[i].style.texture;
            if (texture) {
                uploadBaseTextures(renderer, texture.baseTexture);
            }
        }
        // if its not batchable - update vao for particular shader
        if (!geometry.batchable) {
            renderer.geometry.bind(geometry, item._resolveDirectShader(renderer));
        }
        return true;
    }
    /**
     * Built-in hook to find graphics.
     * @private
     * @param item - Display object to check
     * @param queue - Collection of items to upload
     * @returns if a PIXI.Graphics object was found.
     */
    function findGraphics(item, queue) {
        if (item instanceof graphics.Graphics) {
            queue.push(item);
            return true;
        }
        return false;
    }
    /**
     * The prepare plugin provides renderer-specific plugins for pre-rendering DisplayObjects. These plugins are useful for
     * asynchronously preparing and uploading to the GPU assets, textures, graphics waiting to be displayed.
     *
     * Do not instantiate this plugin directly. It is available from the `renderer.plugins` property.
     * See {@link PIXI.CanvasRenderer#plugins} or {@link PIXI.Renderer#plugins}.
     * @example
     * // Create a new application
     * const app = new PIXI.Application();
     * document.body.appendChild(app.view);
     *
     * // Don't start rendering right away
     * app.stop();
     *
     * // create a display object
     * const rect = new PIXI.Graphics()
     *     .beginFill(0x00ff00)
     *     .drawRect(40, 40, 200, 200);
     *
     * // Add to the stage
     * app.stage.addChild(rect);
     *
     * // Don't start rendering until the graphic is uploaded to the GPU
     * app.renderer.plugins.prepare.upload(app.stage, () => {
     *     app.start();
     * });
     * @memberof PIXI
     */
    var Prepare = /** @class */ (function (_super) {
        __extends(Prepare, _super);
        /**
         * @param {PIXI.Renderer} renderer - A reference to the current renderer
         */
        function Prepare(renderer) {
            var _this = _super.call(this, renderer) || this;
            _this.uploadHookHelper = _this.renderer;
            // Add textures and graphics to upload
            _this.registerFindHook(findGraphics);
            _this.registerUploadHook(uploadBaseTextures);
            _this.registerUploadHook(uploadGraphics);
            return _this;
        }
        /** @ignore */
        Prepare.extension = {
            name: 'prepare',
            type: core.ExtensionType.RendererPlugin,
        };
        return Prepare;
    }(BasePrepare));

    /**
     * TimeLimiter limits the number of items handled by a {@link PIXI.BasePrepare} to a specified
     * number of milliseconds per frame.
     * @memberof PIXI
     */
    var TimeLimiter = /** @class */ (function () {
        /** @param maxMilliseconds - The maximum milliseconds that can be spent preparing items each frame. */
        function TimeLimiter(maxMilliseconds) {
            this.maxMilliseconds = maxMilliseconds;
            this.frameStart = 0;
        }
        /** Resets any counting properties to start fresh on a new frame. */
        TimeLimiter.prototype.beginFrame = function () {
            this.frameStart = Date.now();
        };
        /**
         * Checks to see if another item can be uploaded. This should only be called once per item.
         * @returns - If the item is allowed to be uploaded.
         */
        TimeLimiter.prototype.allowedToUpload = function () {
            return Date.now() - this.frameStart < this.maxMilliseconds;
        };
        return TimeLimiter;
    }());

    exports.BasePrepare = BasePrepare;
    exports.CountLimiter = CountLimiter;
    exports.Prepare = Prepare;
    exports.TimeLimiter = TimeLimiter;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI, PIXI, PIXI, PIXI, PIXI.utils);
Object.assign(this.PIXI, _pixi_prepare);
//# sourceMappingURL=prepare.js.map
