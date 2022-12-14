/*!
 * @pixi/mixin-cache-as-bitmap - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/mixin-cache-as-bitmap is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_mixin_cache_as_bitmap = (function (exports, core, sprite, display, math, utils, settings, constants) {
    'use strict';

    var _tempMatrix = new math.Matrix();
    display.DisplayObject.prototype._cacheAsBitmap = false;
    display.DisplayObject.prototype._cacheData = null;
    display.DisplayObject.prototype._cacheAsBitmapResolution = null;
    display.DisplayObject.prototype._cacheAsBitmapMultisample = constants.MSAA_QUALITY.NONE;
    // figured there's no point adding ALL the extra variables to prototype.
    // this model can hold the information needed. This can also be generated on demand as
    // most objects are not cached as bitmaps.
    /**
     * @class
     * @ignore
     * @private
     */
    var CacheData = /** @class */ (function () {
        function CacheData() {
            this.textureCacheId = null;
            this.originalRender = null;
            this.originalRenderCanvas = null;
            this.originalCalculateBounds = null;
            this.originalGetLocalBounds = null;
            this.originalUpdateTransform = null;
            this.originalDestroy = null;
            this.originalMask = null;
            this.originalFilterArea = null;
            this.originalContainsPoint = null;
            this.sprite = null;
        }
        return CacheData;
    }());
    Object.defineProperties(display.DisplayObject.prototype, {
        /**
         * The resolution to use for cacheAsBitmap. By default this will use the renderer's resolution
         * but can be overriden for performance. Lower values will reduce memory usage at the expense
         * of render quality. A falsey value of `null` or `0` will default to the renderer's resolution.
         * If `cacheAsBitmap` is set to `true`, this will re-render with the new resolution.
         * @member {number} cacheAsBitmapResolution
         * @memberof PIXI.DisplayObject#
         * @default null
         */
        cacheAsBitmapResolution: {
            get: function () {
                return this._cacheAsBitmapResolution;
            },
            set: function (resolution) {
                if (resolution === this._cacheAsBitmapResolution) {
                    return;
                }
                this._cacheAsBitmapResolution = resolution;
                if (this.cacheAsBitmap) {
                    // Toggle to re-render at the new resolution
                    this.cacheAsBitmap = false;
                    this.cacheAsBitmap = true;
                }
            },
        },
        /**
         * The number of samples to use for cacheAsBitmap. If set to `null`, the renderer's
         * sample count is used.
         * If `cacheAsBitmap` is set to `true`, this will re-render with the new number of samples.
         * @member {number} cacheAsBitmapMultisample
         * @memberof PIXI.DisplayObject#
         * @default PIXI.MSAA_QUALITY.NONE
         */
        cacheAsBitmapMultisample: {
            get: function () {
                return this._cacheAsBitmapMultisample;
            },
            set: function (multisample) {
                if (multisample === this._cacheAsBitmapMultisample) {
                    return;
                }
                this._cacheAsBitmapMultisample = multisample;
                if (this.cacheAsBitmap) {
                    // Toggle to re-render with new multisample
                    this.cacheAsBitmap = false;
                    this.cacheAsBitmap = true;
                }
            },
        },
        /**
         * Set this to true if you want this display object to be cached as a bitmap.
         * This basically takes a snap shot of the display object as it is at that moment. It can
         * provide a performance benefit for complex static displayObjects.
         * To remove simply set this property to `false`
         *
         * IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
         * as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
         * @member {boolean}
         * @memberof PIXI.DisplayObject#
         */
        cacheAsBitmap: {
            get: function () {
                return this._cacheAsBitmap;
            },
            set: function (value) {
                if (this._cacheAsBitmap === value) {
                    return;
                }
                this._cacheAsBitmap = value;
                var data;
                if (value) {
                    if (!this._cacheData) {
                        this._cacheData = new CacheData();
                    }
                    data = this._cacheData;
                    data.originalRender = this.render;
                    data.originalRenderCanvas = this.renderCanvas;
                    data.originalUpdateTransform = this.updateTransform;
                    data.originalCalculateBounds = this.calculateBounds;
                    data.originalGetLocalBounds = this.getLocalBounds;
                    data.originalDestroy = this.destroy;
                    data.originalContainsPoint = this.containsPoint;
                    data.originalMask = this._mask;
                    data.originalFilterArea = this.filterArea;
                    this.render = this._renderCached;
                    this.renderCanvas = this._renderCachedCanvas;
                    this.destroy = this._cacheAsBitmapDestroy;
                }
                else {
                    data = this._cacheData;
                    if (data.sprite) {
                        this._destroyCachedDisplayObject();
                    }
                    this.render = data.originalRender;
                    this.renderCanvas = data.originalRenderCanvas;
                    this.calculateBounds = data.originalCalculateBounds;
                    this.getLocalBounds = data.originalGetLocalBounds;
                    this.destroy = data.originalDestroy;
                    this.updateTransform = data.originalUpdateTransform;
                    this.containsPoint = data.originalContainsPoint;
                    this._mask = data.originalMask;
                    this.filterArea = data.originalFilterArea;
                }
            },
        },
    });
    /**
     * Renders a cached version of the sprite with WebGL
     * @private
     * @method _renderCached
     * @memberof PIXI.DisplayObject#
     * @param {PIXI.Renderer} renderer - the WebGL renderer
     */
    display.DisplayObject.prototype._renderCached = function _renderCached(renderer) {
        if (!this.visible || this.worldAlpha <= 0 || !this.renderable) {
            return;
        }
        this._initCachedDisplayObject(renderer);
        this._cacheData.sprite.transform._worldID = this.transform._worldID;
        this._cacheData.sprite.worldAlpha = this.worldAlpha;
        this._cacheData.sprite._render(renderer);
    };
    /**
     * Prepares the WebGL renderer to cache the sprite
     * @private
     * @method _initCachedDisplayObject
     * @memberof PIXI.DisplayObject#
     * @param {PIXI.Renderer} renderer - the WebGL renderer
     */
    display.DisplayObject.prototype._initCachedDisplayObject = function _initCachedDisplayObject(renderer) {
        var _a;
        if (this._cacheData && this._cacheData.sprite) {
            return;
        }
        // make sure alpha is set to 1 otherwise it will get rendered as invisible!
        var cacheAlpha = this.alpha;
        this.alpha = 1;
        // first we flush anything left in the renderer (otherwise it would get rendered to the cached texture)
        renderer.batch.flush();
        // this.filters= [];
        // next we find the dimensions of the untransformed object
        // this function also calls updatetransform on all its children as part of the measuring.
        // This means we don't need to update the transform again in this function
        // TODO pass an object to clone too? saves having to create a new one each time!
        var bounds = this.getLocalBounds(null, true).clone();
        // add some padding!
        if (this.filters && this.filters.length) {
            var padding = this.filters[0].padding;
            bounds.pad(padding);
        }
        bounds.ceil(settings.settings.RESOLUTION);
        // for now we cache the current renderTarget that the WebGL renderer is currently using.
        // this could be more elegant..
        var cachedRenderTexture = renderer.renderTexture.current;
        var cachedSourceFrame = renderer.renderTexture.sourceFrame.clone();
        var cachedDestinationFrame = renderer.renderTexture.destinationFrame.clone();
        var cachedProjectionTransform = renderer.projection.transform;
        // We also store the filter stack - I will definitely look to change how this works a little later down the line.
        // const stack = renderer.filterManager.filterStack;
        // this renderTexture will be used to store the cached DisplayObject
        var renderTexture = core.RenderTexture.create({
            width: bounds.width,
            height: bounds.height,
            resolution: this.cacheAsBitmapResolution || renderer.resolution,
            multisample: (_a = this.cacheAsBitmapMultisample) !== null && _a !== void 0 ? _a : renderer.multisample,
        });
        var textureCacheId = "cacheAsBitmap_" + utils.uid();
        this._cacheData.textureCacheId = textureCacheId;
        core.BaseTexture.addToCache(renderTexture.baseTexture, textureCacheId);
        core.Texture.addToCache(renderTexture, textureCacheId);
        // need to set //
        var m = this.transform.localTransform.copyTo(_tempMatrix).invert().translate(-bounds.x, -bounds.y);
        // set all properties to there original so we can render to a texture
        this.render = this._cacheData.originalRender;
        renderer.render(this, { renderTexture: renderTexture, clear: true, transform: m, skipUpdateTransform: false });
        renderer.framebuffer.blit();
        // now restore the state be setting the new properties
        renderer.projection.transform = cachedProjectionTransform;
        renderer.renderTexture.bind(cachedRenderTexture, cachedSourceFrame, cachedDestinationFrame);
        // renderer.filterManager.filterStack = stack;
        this.render = this._renderCached;
        // the rest is the same as for Canvas
        this.updateTransform = this.displayObjectUpdateTransform;
        this.calculateBounds = this._calculateCachedBounds;
        this.getLocalBounds = this._getCachedLocalBounds;
        this._mask = null;
        this.filterArea = null;
        this.alpha = cacheAlpha;
        // create our cached sprite
        var cachedSprite = new sprite.Sprite(renderTexture);
        cachedSprite.transform.worldTransform = this.transform.worldTransform;
        cachedSprite.anchor.x = -(bounds.x / bounds.width);
        cachedSprite.anchor.y = -(bounds.y / bounds.height);
        cachedSprite.alpha = cacheAlpha;
        cachedSprite._bounds = this._bounds;
        this._cacheData.sprite = cachedSprite;
        this.transform._parentID = -1;
        // restore the transform of the cached sprite to avoid the nasty flicker..
        if (!this.parent) {
            this.enableTempParent();
            this.updateTransform();
            this.disableTempParent(null);
        }
        else {
            this.updateTransform();
        }
        // map the hit test..
        this.containsPoint = cachedSprite.containsPoint.bind(cachedSprite);
    };
    /**
     * Renders a cached version of the sprite with canvas
     * @private
     * @method _renderCachedCanvas
     * @memberof PIXI.DisplayObject#
     * @param {PIXI.CanvasRenderer} renderer - The canvas renderer
     */
    display.DisplayObject.prototype._renderCachedCanvas = function _renderCachedCanvas(renderer) {
        if (!this.visible || this.worldAlpha <= 0 || !this.renderable) {
            return;
        }
        this._initCachedDisplayObjectCanvas(renderer);
        this._cacheData.sprite.worldAlpha = this.worldAlpha;
        this._cacheData.sprite._renderCanvas(renderer);
    };
    // TODO this can be the same as the WebGL version.. will need to do a little tweaking first though..
    /**
     * Prepares the Canvas renderer to cache the sprite
     * @private
     * @method _initCachedDisplayObjectCanvas
     * @memberof PIXI.DisplayObject#
     * @param {PIXI.CanvasRenderer} renderer - The canvas renderer
     */
    display.DisplayObject.prototype._initCachedDisplayObjectCanvas = function _initCachedDisplayObjectCanvas(renderer) {
        if (this._cacheData && this._cacheData.sprite) {
            return;
        }
        // get bounds actually transforms the object for us already!
        var bounds = this.getLocalBounds(null, true);
        var cacheAlpha = this.alpha;
        this.alpha = 1;
        var cachedRenderTarget = renderer.context;
        var cachedProjectionTransform = renderer._projTransform;
        bounds.ceil(settings.settings.RESOLUTION);
        var renderTexture = core.RenderTexture.create({ width: bounds.width, height: bounds.height });
        var textureCacheId = "cacheAsBitmap_" + utils.uid();
        this._cacheData.textureCacheId = textureCacheId;
        core.BaseTexture.addToCache(renderTexture.baseTexture, textureCacheId);
        core.Texture.addToCache(renderTexture, textureCacheId);
        // need to set //
        var m = _tempMatrix;
        this.transform.localTransform.copyTo(m);
        m.invert();
        m.tx -= bounds.x;
        m.ty -= bounds.y;
        // m.append(this.transform.worldTransform.)
        // set all properties to there original so we can render to a texture
        this.renderCanvas = this._cacheData.originalRenderCanvas;
        renderer.render(this, { renderTexture: renderTexture, clear: true, transform: m, skipUpdateTransform: false });
        // now restore the state be setting the new properties
        renderer.context = cachedRenderTarget;
        renderer._projTransform = cachedProjectionTransform;
        this.renderCanvas = this._renderCachedCanvas;
        // the rest is the same as for WebGL
        this.updateTransform = this.displayObjectUpdateTransform;
        this.calculateBounds = this._calculateCachedBounds;
        this.getLocalBounds = this._getCachedLocalBounds;
        this._mask = null;
        this.filterArea = null;
        this.alpha = cacheAlpha;
        // create our cached sprite
        var cachedSprite = new sprite.Sprite(renderTexture);
        cachedSprite.transform.worldTransform = this.transform.worldTransform;
        cachedSprite.anchor.x = -(bounds.x / bounds.width);
        cachedSprite.anchor.y = -(bounds.y / bounds.height);
        cachedSprite.alpha = cacheAlpha;
        cachedSprite._bounds = this._bounds;
        this._cacheData.sprite = cachedSprite;
        this.transform._parentID = -1;
        // restore the transform of the cached sprite to avoid the nasty flicker..
        if (!this.parent) {
            this.parent = renderer._tempDisplayObjectParent;
            this.updateTransform();
            this.parent = null;
        }
        else {
            this.updateTransform();
        }
        // map the hit test..
        this.containsPoint = cachedSprite.containsPoint.bind(cachedSprite);
    };
    /**
     * Calculates the bounds of the cached sprite
     * @private
     * @method
     */
    display.DisplayObject.prototype._calculateCachedBounds = function _calculateCachedBounds() {
        this._bounds.clear();
        this._cacheData.sprite.transform._worldID = this.transform._worldID;
        this._cacheData.sprite._calculateBounds();
        this._bounds.updateID = this._boundsID;
    };
    /**
     * Gets the bounds of the cached sprite.
     * @private
     * @method
     * @returns {Rectangle} The local bounds.
     */
    display.DisplayObject.prototype._getCachedLocalBounds = function _getCachedLocalBounds() {
        return this._cacheData.sprite.getLocalBounds(null);
    };
    /**
     * Destroys the cached sprite.
     * @private
     * @method
     */
    display.DisplayObject.prototype._destroyCachedDisplayObject = function _destroyCachedDisplayObject() {
        this._cacheData.sprite._texture.destroy(true);
        this._cacheData.sprite = null;
        core.BaseTexture.removeFromCache(this._cacheData.textureCacheId);
        core.Texture.removeFromCache(this._cacheData.textureCacheId);
        this._cacheData.textureCacheId = null;
    };
    /**
     * Destroys the cached object.
     * @private
     * @method
     * @param {object|boolean} [options] - Options parameter. A boolean will act as if all options
     *  have been set to that value.
     *  Used when destroying containers, see the Container.destroy method.
     */
    display.DisplayObject.prototype._cacheAsBitmapDestroy = function _cacheAsBitmapDestroy(options) {
        this.cacheAsBitmap = false;
        this.destroy(options);
    };

    exports.CacheData = CacheData;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI, PIXI, PIXI.utils, PIXI, PIXI);
//# sourceMappingURL=mixin-cache-as-bitmap.js.map
