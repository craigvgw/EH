declare namespace GlobalMixins
{
    interface DisplayObject
    {
        cacheAsBitmap: boolean;
        cacheAsBitmapResolution: number;
        cacheAsBitmapMultisample: import("./../constants/index").MSAA_QUALITY;
        _cacheAsBitmapResolution: number;
        _cacheAsBitmapMultisample: import("./../constants/index").MSAA_QUALITY;
        _cacheAsBitmap: boolean;
        _cacheData: import("./../mixin-cache-as-bitmap/index").CacheData;
        _renderCached(renderer: import("./../core/index").Renderer): void;
        _initCachedDisplayObject(renderer: import("./../core/index").Renderer): void;
        _calculateCachedBounds(): void;
        _getCachedLocalBounds(): import("./../math/index").Rectangle;
        _renderCachedCanvas(renderer: import("./../core/index").AbstractRenderer): void;
        _initCachedDisplayObjectCanvas(renderer: import("./../core/index").AbstractRenderer): void;
        _destroyCachedDisplayObject(): void;
        _cacheAsBitmapDestroy(options?: import("./../display/index").IDestroyOptions | boolean): void;
    }
}
