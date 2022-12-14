/// <reference path="./global.d.ts" />

import type { Dict } from "./../utils/index";
import type { ExtensionMetadata } from "./../extensions/index";
import type { IBaseTextureOptions } from "./../core/index";
import type { Texture } from "./../core/index";

/**
 * Application plugin for supporting loader option. Installing the LoaderPlugin
 * is not necessary if using **pixi.js** or **pixi.js-legacy**.
 * @example
 * import {AppLoaderPlugin} from "./../loaders/index";
 * import {extensions} from "./../core/index";
 * extensions.add(AppLoaderPlugin);
 * @memberof PIXI
 */
export declare class AppLoaderPlugin {
    /** @ignore */
    static extension: ExtensionMetadata;
    /**
     * Loader instance to help with asset loading.
     * @memberof PIXI.Application#
     * @readonly
     */
    static loader: Loader;
    /**
     * Called on application constructor
     * @param options
     * @private
     */
    static init(options?: GlobalMixins.IApplicationOptions): void;
    /**
     * Called when application destroyed
     * @private
     */
    static destroy(): void;
}

/**
 * Options for a call to `.add()`.
 * @see Loader#add
 * @property {string} name - The name of the resource to load, if not passed the url is used.
 * @property {string} key - Alias for `name`.
 * @property {string} url - The url for this resource, relative to the baseUrl of this loader.
 * @property {string|boolean} crossOrigin - Is this request cross-origin? Default is to determine automatically.
 * @property {number} [timeout=0] - A timeout in milliseconds for the load. If the load takes longer
 *      than this time it is cancelled and the load is considered a failure. If this value is
 *      set to `0` then there is no explicit timeout.
 * @property {LoaderResource.LOAD_TYPE} [loadType=LoaderResource.LOAD_TYPE.XHR] - How should this resource be loaded?
 * @property {LoaderResource.XHR_RESPONSE_TYPE} [xhrType=LoaderResource.XHR_RESPONSE_TYPE.DEFAULT] - How should the data
 *      being loaded be interpreted when using XHR?
 * @property {LoaderResource.OnCompleteSignal} onComplete - Callback to add an an onComplete signal istener.
 * @property {LoaderResource.OnCompleteSignal} callback - Alias for `onComplete`.
 * @property {IResourceMetadata} metadata - Extra configuration for middleware and the Resource object.
 */
export declare interface IAddOptions {
    name?: string;
    key?: string;
    url?: string;
    crossOrigin?: string | boolean;
    timeout?: number;
    parentResource?: LoaderResource;
    loadType?: LoaderResource.LOAD_TYPE;
    xhrType?: LoaderResource.XHR_RESPONSE_TYPE;
    onComplete?: LoaderResource.OnCompleteSignal;
    callback?: LoaderResource.OnCompleteSignal;
    metadata?: IResourceMetadata;
}

export declare interface ILoaderAdd {
    (this: Loader, name: string, url: string, callback?: LoaderResource.OnCompleteSignal): Loader;
    (this: Loader, name: string, url: string, options?: IAddOptions, callback?: LoaderResource.OnCompleteSignal): Loader;
    (this: Loader, url: string, callback?: LoaderResource.OnCompleteSignal): Loader;
    (this: Loader, url: string, options?: IAddOptions, callback?: LoaderResource.OnCompleteSignal): Loader;
    (this: Loader, options: IAddOptions, callback?: LoaderResource.OnCompleteSignal): Loader;
    (this: Loader, resources: (IAddOptions | string)[], callback?: LoaderResource.OnCompleteSignal): Loader;
}

export declare type ILoaderMiddleware = (resource: LoaderResource, next: (...args: any[]) => void) => void;

/**
 * Plugin to be installed for handling specific Loader resources.
 * @property {Function} add - Function to call immediate after registering plugin.
 * @property {Function} pre - Middleware function to run before load, the
 *           arguments for this are `(resource, next)`
 * @property {Function} use - Middleware function to run after load, the
 *           arguments for this are `(resource, next)`
 */
export declare interface ILoaderPlugin {
    /** Function to call immediate after registering plugin. */
    add?(): void;
    /**
     * Middleware function to run before load
     * @param {LoaderResource} resource - resource
     * @param {LoaderResource} next - next middleware
     */
    pre?(resource: LoaderResource, next: (...args: any[]) => void): void;
    /**
     * Middleware function to run after load
     * @param {LoaderResource} resource - resource
     * @param {LoaderResource} next - next middleware
     */
    use?(resource: LoaderResource, next: (...args: any[]) => void): void;
}

/** @deprecated - Use LoaderResource instead */
export declare type ILoaderResource = LoaderResource;

/**
 * Metadata for loader resource. It is very messy way to pass options for loader middlewares
 *
 * Can be extended in `GlobalMixins.IResourceMetadata`
 * @memberof PIXI
 */
export declare interface IResourceMetadata extends GlobalMixins.IResourceMetadata, IBaseTextureOptions {
    /** The element to use for loading, instead of creating one. */
    loadElement?: HTMLImageElement | HTMLAudioElement | HTMLVideoElement;
    /**
     * Skips adding source(s) to the load element. This
     * is useful if you want to pass in a `loadElement` that you already added load sources to.
     */
    skipSource?: boolean;
    /**
     * The mime type to use for the source element
     * of a video/audio elment. If the urls are an array, you can pass this as an array as well
     * where each index is the mime type to use for the corresponding url index.
     */
    mimeType?: string | string[];
    /**
     * Used by BitmapFonts, Spritesheet and CompressedTextures as the options to used for
     * metadata when loading the child image.
     */
    imageMetadata?: IResourceMetadata;
}

/**
 * The new loader, forked from Resource Loader by Chad Engler: https://github.com/englercj/resource-loader
 *
 * ```js
 * const loader = PIXI.Loader.shared; // PixiJS exposes a premade instance for you to use.
 * // or
 * const loader = new PIXI.Loader(); // You can also create your own if you want
 *
 * const sprites = {};
 *
 * // Chainable `add` to enqueue a resource
 * loader.add('bunny', 'data/bunny.png')
 *       .add('spaceship', 'assets/spritesheet.json');
 * loader.add('scoreFont', 'assets/score.fnt');
 *
 * // Chainable `pre` to add a middleware that runs for each resource, *before* loading that resource.
 * // This is useful to implement custom caching modules (using filesystem, indexeddb, memory, etc).
 * loader.pre(cachingMiddleware);
 *
 * // Chainable `use` to add a middleware that runs for each resource, *after* loading that resource.
 * // This is useful to implement custom parsing modules (like spritesheet parsers, spine parser, etc).
 * loader.use(parsingMiddleware);
 *
 * // The `load` method loads the queue of resources, and calls the passed in callback called once all
 * // resources have loaded.
 * loader.load((loader, resources) => {
 *     // resources is an object where the key is the name of the resource loaded and the value is the resource object.
 *     // They have a couple default properties:
 *     // - `url`: The URL that the resource was loaded from
 *     // - `error`: The error that happened when trying to load (if any)
 *     // - `data`: The raw data that was loaded
 *     // also may contain other properties based on the middleware that runs.
 *     sprites.bunny = new PIXI.TilingSprite(resources.bunny.texture);
 *     sprites.spaceship = new PIXI.TilingSprite(resources.spaceship.texture);
 *     sprites.scoreFont = new PIXI.TilingSprite(resources.scoreFont.texture);
 * });
 *
 * // throughout the process multiple signals can be dispatched.
 * loader.onProgress.add(() => {}); // called once per loaded/errored file
 * loader.onError.add(() => {}); // called once per errored file
 * loader.onLoad.add(() => {}); // called once per loaded file
 * loader.onComplete.add(() => {}); // called once when the queued resources all load.
 * ```
 * @memberof PIXI
 */
export declare class Loader {
    /** The base url for all resources loaded by this loader. */
    baseUrl: string;
    /** The progress percent of the loader going through the queue. */
    progress: number;
    /** Loading state of the loader, true if it is currently loading resources. */
    loading: boolean;
    /**
     * A querystring to append to every URL added to the loader.
     *
     * This should be a valid query string *without* the question-mark (`?`). The loader will
     * also *not* escape values for you. Make sure to escape your parameters with
     * [`encodeURIComponent`](https://mdn.io/encodeURIComponent) before assigning this property.
     * @example
     * const loader = new Loader();
     *
     * loader.defaultQueryString = 'user=me&password=secret';
     *
     * // This will request 'image.png?user=me&password=secret'
     * loader.add('image.png').load();
     *
     * loader.reset();
     *
     * // This will request 'image.png?v=1&user=me&password=secret'
     * loader.add('iamge.png?v=1').load();
     */
    defaultQueryString: string;
    /** The middleware to run before loading each resource. */
    private _beforeMiddleware;
    /** The middleware to run after loading each resource. */
    private _afterMiddleware;
    /** The tracks the resources we are currently completing parsing for. */
    private _resourcesParsing;
    /**
     * The `_loadResource` function bound with this object context.
     * @param r - The resource to load
     * @param d - The dequeue function
     */
    private _boundLoadResource;
    /** The resources waiting to be loaded. */
    private _queue;
    /** All the resources for this loader keyed by name. */
    resources: Dict<LoaderResource>;
    /** Dispatched once per loaded or errored resource. */
    onProgress: Signal<Loader.OnProgressSignal>;
    /** Dispatched once per errored resource. */
    onError: Signal<Loader.OnErrorSignal>;
    /** Dispatched once per loaded resource. */
    onLoad: Signal<Loader.OnLoadSignal>;
    /** Dispatched when the loader begins to process the queue. */
    onStart: Signal<Loader.OnStartSignal>;
    /** Dispatched when the queued resources all load. */
    onComplete: Signal<Loader.OnCompleteSignal>;
    /**
     * @param baseUrl - The base url for all resources loaded by this loader.
     * @param concurrency - The number of resources to load concurrently.
     */
    constructor(baseUrl?: string, concurrency?: number);
    /**
     * Adds a resource (or multiple resources) to the loader queue.
     *
     * This function can take a wide variety of different parameters. The only thing that is always
     * required the url to load. All the following will work:
     *
     * ```js
     * loader
     *     // normal param syntax
     *     .add('key', 'http://...', function () {})
     *     .add('http://...', function () {})
     *     .add('http://...')
     *
     *     // object syntax
     *     .add({
     *         name: 'key2',
     *         url: 'http://...'
     *     }, function () {})
     *     .add({
     *         url: 'http://...'
     *     }, function () {})
     *     .add({
     *         name: 'key3',
     *         url: 'http://...'
     *         onComplete: function () {}
     *     })
     *     .add({
     *         url: 'https://...',
     *         onComplete: function () {},
     *         crossOrigin: true
     *     })
     *
     *     // you can also pass an array of objects or urls or both
     *     .add([
     *         { name: 'key4', url: 'http://...', onComplete: function () {} },
     *         { url: 'http://...', onComplete: function () {} },
     *         'http://...'
     *     ])
     *
     *     // and you can use both params and options
     *     .add('key', 'http://...', { crossOrigin: true }, function () {})
     *     .add('http://...', { crossOrigin: true }, function () {});
     * ```
     */
    add: ILoaderAdd;
    /**
     * Same as add, params have strict order
     * @private
     * @param name - The name of the resource to load.
     * @param url - The url for this resource, relative to the baseUrl of this loader.
     * @param options - The options for the load.
     * @param callback - Function to call when this specific resource completes loading.
     * @returns The loader itself.
     */
    protected _add(name: string, url: string, options: IAddOptions, callback?: LoaderResource.OnCompleteSignal): this;
    /**
     * Sets up a middleware function that will run *before* the
     * resource is loaded.
     * @param fn - The middleware function to register.
     * @returns The loader itself.
     */
    pre(fn: ILoaderMiddleware): this;
    /**
     * Sets up a middleware function that will run *after* the
     * resource is loaded.
     * @param fn - The middleware function to register.
     * @returns The loader itself.
     */
    use(fn: ILoaderMiddleware): this;
    /**
     * Resets the queue of the loader to prepare for a new load.
     * @returns The loader itself.
     */
    reset(): this;
    /**
     * Starts loading the queued resources.
     * @param cb - Optional callback that will be bound to the `complete` event.
     * @returns The loader itself.
     */
    load(cb?: Loader.OnCompleteSignal): this;
    /**
     * The number of resources to load concurrently.
     * @default 10
     */
    get concurrency(): number;
    set concurrency(concurrency: number);
    /**
     * Prepares a url for usage based on the configuration of this object
     * @param url - The url to prepare.
     * @returns The prepared url.
     */
    private _prepareUrl;
    /**
     * Loads a single resource.
     * @param resource - The resource to load.
     * @param dequeue - The function to call when we need to dequeue this item.
     */
    private _loadResource;
    /** Called once loading has started. */
    private _onStart;
    /** Called once each resource has loaded. */
    private _onComplete;
    /**
     * Called each time a resources is loaded.
     * @param resource - The resource that was loaded
     */
    private _onLoad;
    static _plugins: Array<ILoaderPlugin>;
    private static _shared;
    /**
     * If this loader cannot be destroyed.
     * @default false
     */
    private _protected;
    /** Destroy the loader, removes references. */
    destroy(): void;
    /** A premade instance of the loader that can be used to load resources. */
    static get shared(): Loader;
    /**
     * Use the {@link PIXI.extensions.add} API to register plugins.
     * @deprecated since 6.5.0
     * @param plugin - The plugin to add
     * @returns Reference to PIXI.Loader for chaining
     */
    static registerPlugin(plugin: ILoaderPlugin): typeof Loader;
}

export declare namespace Loader {
    /**
     * When the resource starts to load.
     * @param resource - The resource that the event happened on.
     */
    export type OnStartSignal = (loader: Loader) => void;
    /**
     * When the progress changes the loader and resource are dispatched.
     * @param loader - The loader the progress is advancing on.
     * @param resource - The resource that has completed or failed to cause the progress to advance.
     */
    export type OnProgressSignal = (loader: Loader, resource: LoaderResource) => void;
    /**
     * When a load completes without error the loader and resource are dispatched.
     * @param loader - The loader that has started loading resources.
     * @param resource - The resource that has completed.
     */
    export type OnLoadSignal = (loader: Loader, resource: LoaderResource) => void;
    /**
     * When the loader starts loading resources it dispatches this callback.
     * @param loader - The loader that has started loading resources.
     */
    export type OnCompleteSignal = (loader: Loader, resources: Dict<LoaderResource>) => void;
    /**
     * When an error occurs the loader and resource are dispatched.
     * @param loader - The loader the error happened in.
     * @param resource - The resource that caused the error.
     */
    export type OnErrorSignal = (error: Error, loader: Loader, resource: LoaderResource) => void;
}

export declare interface LoaderResource extends GlobalMixins.LoaderResource, GlobalMixins.ILoaderResource {
}

/**
 * Manages the state and loading of a resource and all child resources.
 *
 * Can be extended in `GlobalMixins.LoaderResource`.
 * @memberof PIXI
 */
export declare class LoaderResource {
    /**
     * Texture reference for loading images and other textures.
     * @type {PIXI.Texture}
     */
    texture?: Texture;
    /** used by parsing middleware */
    blob?: Blob;
    /**
     * The name of this resource.
     * @readonly
     * @type {string}
     */
    readonly name: string;
    /**
     * The url used to load this resource.
     * @readonly
     * @type {string}
     */
    readonly url: string;
    /**
     * The extension used to load this resource.
     * @readonly
     * @type {string}
     */
    readonly extension: string;
    /** The data that was loaded by the resource. */
    data: any;
    /** Is this request cross-origin? If unset, determined automatically. */
    crossOrigin: string | boolean;
    /**
     * A timeout in milliseconds for the load. If the load takes longer than this time
     * it is cancelled and the load is considered a failure. If this value is set to `0`
     * then there is no explicit timeout.
     * @type {number}
     */
    timeout: number;
    /**
     * The method of loading to use for this resource.
     * @type {PIXI.LoaderResource.LOAD_TYPE}
     */
    loadType: LoaderResource.LOAD_TYPE;
    /**
     * The type used to load the resource via XHR. If unset, determined automatically.
     * @member {string}
     */
    xhrType: string;
    /**
     * Extra info for middleware, and controlling specifics about how the resource loads.
     *
     * Note that if you pass in a `loadElement`, the Resource class takes ownership of it.
     * Meaning it will modify it as it sees fit.
     * @type {PIXI.IResourceMetadata}
     */
    metadata: IResourceMetadata;
    /**
     * The error that occurred while loading (if any).
     * @readonly
     * @member {Error}
     */
    error: Error;
    /**
     * The XHR object that was used to load this resource. This is only set
     * when `loadType` is `LoaderResource.LOAD_TYPE.XHR`.
     * @readonly
     */
    xhr: XMLHttpRequest;
    private xdr;
    /**
     * The child resources this resource owns.
     * @type {PIXI.LoaderResource[]}
     */
    readonly children: LoaderResource[];
    /**
     * The resource type.
     * @readonly
     * @type {PIXI.LoaderResource.TYPE}
     */
    type: LoaderResource.TYPE;
    /**
     * The progress chunk owned by this resource.
     * @readonly
     * @member {number}
     */
    progressChunk: number;
    /**
     * Dispatched when the resource beings to load.
     *
     * The callback looks like {@link LoaderResource.OnStartSignal}.
     * @type {PIXI.Signal}
     */
    onStart: Signal<LoaderResource.OnStartSignal>;
    /**
     * Dispatched each time progress of this resource load updates.
     * Not all resources types and loader systems can support this event
     * so sometimes it may not be available. If the resource
     * is being loaded on a modern browser, using XHR, and the remote server
     * properly sets Content-Length headers, then this will be available.
     *
     * The callback looks like {@link LoaderResource.OnProgressSignal}.
     * @type {PIXI.Signal}
     */
    onProgress: Signal<LoaderResource.OnProgressSignal>;
    /**
     * Dispatched once this resource has loaded, if there was an error it will
     * be in the `error` property.
     *
     * The callback looks like {@link LoaderResource.OnCompleteSignal}.
     * @type {PIXI.Signal}
     */
    onComplete: Signal<LoaderResource.OnCompleteSignal>;
    /**
     * Dispatched after this resource has had all the *after* middleware run on it.
     *
     * The callback looks like {@link LoaderResource.OnCompleteSignal}.
     * @type {PIXI.Signal}
     */
    onAfterMiddleware: Signal<LoaderResource.OnCompleteSignal>;
    /**
     * The state flags of this resource.
     * @private
     * @member {number}
     */
    private _flags;
    /**
     * The `dequeue` method that will be used a storage place for the async queue dequeue method
     * used privately by the loader.
     * @private
     * @member {Function}
     */
    _dequeue: any;
    /**
     * Used a storage place for the on load binding used privately by the loader.
     * @private
     * @member {Function}
     */
    _onLoadBinding: any;
    /**
     * The timer for element loads to check if they timeout.
     * @private
     */
    private _elementTimer;
    /**
     * The `complete` function bound to this resource's context.
     * @private
     * @type {Function}
     */
    private _boundComplete;
    /**
     * The `_onError` function bound to this resource's context.
     * @private
     * @type {Function}
     */
    private _boundOnError;
    /**
     * The `_onProgress` function bound to this resource's context.
     * @private
     * @type {Function}
     */
    private _boundOnProgress;
    /**
     * The `_onTimeout` function bound to this resource's context.
     * @private
     * @type {Function}
     */
    private _boundOnTimeout;
    private _boundXhrOnError;
    private _boundXhrOnTimeout;
    private _boundXhrOnAbort;
    private _boundXhrOnLoad;
    /**
     * Sets the load type to be used for a specific extension.
     * @static
     * @param {string} extname - The extension to set the type for, e.g. "png" or "fnt"
     * @param {PIXI.LoaderResource.LOAD_TYPE} loadType - The load type to set it to.
     */
    static setExtensionLoadType(extname: string, loadType: LoaderResource.LOAD_TYPE): void;
    /**
     * Sets the load type to be used for a specific extension.
     * @static
     * @param {string} extname - The extension to set the type for, e.g. "png" or "fnt"
     * @param {PIXI.LoaderResource.XHR_RESPONSE_TYPE} xhrType - The xhr type to set it to.
     */
    static setExtensionXhrType(extname: string, xhrType: LoaderResource.XHR_RESPONSE_TYPE): void;
    /**
     * @param {string} name - The name of the resource to load.
     * @param {string|string[]} url - The url for this resource, for audio/video loads you can pass
     *      an array of sources.
     * @param {object} [options] - The options for the load.
     * @param {string|boolean} [options.crossOrigin] - Is this request cross-origin? Default is to
     *      determine automatically.
     * @param {number} [options.timeout=0] - A timeout in milliseconds for the load. If the load takes
     *      longer than this time it is cancelled and the load is considered a failure. If this value is
     *      set to `0` then there is no explicit timeout.
     * @param {PIXI.LoaderResource.LOAD_TYPE} [options.loadType=LOAD_TYPE.XHR] - How should this resource
     *      be loaded?
     * @param {PIXI.LoaderResource.XHR_RESPONSE_TYPE} [options.xhrType=XHR_RESPONSE_TYPE.DEFAULT] - How
     *      should the data being loaded be interpreted when using XHR?
     * @param {PIXI.LoaderResource.IMetadata} [options.metadata] - Extra configuration for middleware
     *      and the Resource object.
     */
    constructor(name: string, url: string | string[], options?: {
        crossOrigin?: string | boolean;
        timeout?: number;
        loadType?: LoaderResource.LOAD_TYPE;
        xhrType?: LoaderResource.XHR_RESPONSE_TYPE;
        metadata?: IResourceMetadata;
    });
    /**
     * When the resource starts to load.
     * @memberof PIXI.LoaderResource
     * @callback OnStartSignal@callback OnStartSignal
     * @param {PIXI.Resource} resource - The resource that the event happened on.
     */
    /**
     * When the resource reports loading progress.
     * @memberof PIXI.LoaderResource
     * @callback OnProgressSignal@callback OnProgressSignal
     * @param {PIXI.Resource} resource - The resource that the event happened on.
     * @param {number} percentage - The progress of the load in the range [0, 1].
     */
    /**
     * When the resource finishes loading.
     * @memberof PIXI.LoaderResource
     * @callback OnCompleteSignal@callback OnCompleteSignal
     * @param {PIXI.Resource} resource - The resource that the event happened on.
     */
    /**
     * @memberof PIXI.LoaderResource
     * @property {boolean} [skipSource=false] - Skips adding source(s) to the load element. This
     *      is useful if you want to pass in a `loadElement` that you already added load sources to.
     * @property {string|string[]} [mimeType] - The mime type to use for the source element
     *      of a video/audio elment. If the urls are an array, you can pass this as an array as well
     *      where each index is the mime type to use for the corresponding url index.
     */
    /**
     * Stores whether or not this url is a data url.
     * @readonly
     * @member {boolean}
     */
    get isDataUrl(): boolean;
    /**
     * Describes if this resource has finished loading. Is true when the resource has completely
     * loaded.
     * @readonly
     * @member {boolean}
     */
    get isComplete(): boolean;
    /**
     * Describes if this resource is currently loading. Is true when the resource starts loading,
     * and is false again when complete.
     * @readonly
     * @member {boolean}
     */
    get isLoading(): boolean;
    /** Marks the resource as complete. */
    complete(): void;
    /**
     * Aborts the loading of this resource, with an optional message.
     * @param {string} message - The message to use for the error
     */
    abort(message: string): void;
    /**
     * Kicks off loading of this resource. This method is asynchronous.
     * @param {PIXI.LoaderResource.OnCompleteSignal} [cb] - Optional callback to call once the resource is loaded.
     */
    load(cb?: LoaderResource.OnCompleteSignal): void;
    /**
     * Checks if the flag is set.
     * @param flag - The flag to check.
     * @returns True if the flag is set.
     */
    private _hasFlag;
    /**
     * (Un)Sets the flag.
     * @param flag - The flag to (un)set.
     * @param value - Whether to set or (un)set the flag.
     */
    private _setFlag;
    /** Clears all the events from the underlying loading source. */
    private _clearEvents;
    /** Finalizes the load. */
    private _finish;
    /**
     * Loads this resources using an element that has a single source,
     * like an HTMLImageElement.
     * @private
     * @param type - The type of element to use.
     */
    _loadElement(type: string): void;
    /**
     * Loads this resources using an element that has multiple sources,
     * like an HTMLAudioElement or HTMLVideoElement.
     * @param type - The type of element to use.
     */
    private _loadSourceElement;
    /** Loads this resources using an XMLHttpRequest. */
    private _loadXhr;
    /** Loads this resources using an XDomainRequest. This is here because we need to support IE9 (gross). */
    private _loadXdr;
    /**
     * Creates a source used in loading via an element.
     * @param type - The element type (video or audio).
     * @param url - The source URL to load from.
     * @param [mime] - The mime type of the video
     * @returns The source element.
     */
    private _createSource;
    /**
     * Called if a load errors out.
     * @param event - The error event from the element that emits it.
     */
    private _onError;
    /**
     * Called if a load progress event fires for an element or xhr/xdr.
     * @param event - Progress event.
     */
    private _onProgress;
    /** Called if a timeout event fires for an element. */
    private _onTimeout;
    /** Called if an error event fires for xhr/xdr. */
    private _xhrOnError;
    /** Called if an error event fires for xhr/xdr. */
    private _xhrOnTimeout;
    /** Called if an abort event fires for xhr/xdr. */
    private _xhrOnAbort;
    /** Called when data successfully loads from an xhr/xdr request. */
    private _xhrOnLoad;
    /**
     * Sets the `crossOrigin` property for this resource based on if the url
     * for this resource is cross-origin. If crossOrigin was manually set, this
     * function does nothing.
     * @private
     * @param url - The url to test.
     * @param [loc=globalThis.location] - The location object to test against.
     * @returns The crossOrigin value to use (or empty string for none).
     */
    _determineCrossOrigin(url: string, loc?: any): string;
    /**
     * Determines the responseType of an XHR request based on the extension of the
     * resource being loaded.
     * @private
     * @returns {PIXI.LoaderResource.XHR_RESPONSE_TYPE} The responseType to use.
     */
    private _determineXhrType;
    /**
     * Determines the loadType of a resource based on the extension of the
     * resource being loaded.
     * @private
     * @returns {PIXI.LoaderResource.LOAD_TYPE} The loadType to use.
     */
    private _determineLoadType;
    /**
     * Extracts the extension (sans '.') of the file being loaded by the resource.
     * @param [url] - url to parse, `this.url` by default.
     * @returns The extension.
     */
    private _getExtension;
    /**
     * Determines the mime type of an XHR request based on the responseType of
     * resource being loaded.
     * @param type - The type to get a mime type for.
     * @private
     * @returns The mime type to use.
     */
    _getMimeFromXhrType(type: LoaderResource.XHR_RESPONSE_TYPE): string;
}

export declare namespace LoaderResource {
    /**
     * When the resource starts to load.
     * @memberof PIXI.LoaderResource
     * @callback OnStartSignal@callback OnStartSignal
     * @param {PIXI.Resource} resource - The resource that the event happened on.
     */
    export type OnStartSignal = (resource: LoaderResource) => void;
    /**
     * When the resource reports loading progress.
     * @memberof PIXI.LoaderResource
     * @callback OnProgressSignal@callback OnProgressSignal
     * @param {PIXI.Resource} resource - The resource that the event happened on.
     * @param {number} percentage - The progress of the load in the range [0, 1].
     */
    export type OnProgressSignal = (resource: LoaderResource, percentage: number) => void;
    /**
     * When the resource finishes loading.
     * @memberof PIXI.LoaderResource
     * @callback OnCompleteSignal@callback OnCompleteSignal
     * @param {PIXI.Resource} resource - The resource that the event happened on.
     */
    export type OnCompleteSignal = (resource: LoaderResource) => void;
    /**
     * The types of resources a resource could represent.
     * @static
     * @readonly
     * @enum {number}
     * @memberof PIXI.LoaderResource
     */
    export enum STATUS_FLAGS {
        /** None */
        NONE = 0,
        /** Data URL */
        DATA_URL = 1,
        /** Complete */
        COMPLETE = 2,
        /** Loading */
        LOADING = 4
    }
    /**
     * The types of resources a resource could represent.
     * @static
     * @readonly
     * @enum {number}
     * @memberof PIXI.LoaderResource
     */
    export enum TYPE {
        /** Unknown */
        UNKNOWN = 0,
        /** JSON */
        JSON = 1,
        /** XML */
        XML = 2,
        /** Image */
        IMAGE = 3,
        /** Audio */
        AUDIO = 4,
        /** Video */
        VIDEO = 5,
        /** Plain text */
        TEXT = 6
    }
    /**
     * The types of loading a resource can use.
     * @static
     * @readonly
     * @enum {number}
     * @memberof PIXI.LoaderResource
     */
    export enum LOAD_TYPE {
        /** Uses XMLHttpRequest to load the resource. */
        XHR = 1,
        /** Uses an `Image` object to load the resource. */
        IMAGE = 2,
        /** Uses an `Audio` object to load the resource. */
        AUDIO = 3,
        /** Uses a `Video` object to load the resource. */
        VIDEO = 4
    }
    /**
     * The XHR ready states, used internally.
     * @static
     * @readonly
     * @enum {string}
     * @memberof PIXI.LoaderResource
     */
    export enum XHR_RESPONSE_TYPE {
        /** string */
        DEFAULT = "text",
        /** ArrayBuffer */
        BUFFER = "arraybuffer",
        /** Blob */
        BLOB = "blob",
        /** Document */
        DOCUMENT = "document",
        /** Object */
        JSON = "json",
        /** String */
        TEXT = "text"
    }
    const _loadTypeMap: Dict<number>;
    const _xhrTypeMap: Dict<XHR_RESPONSE_TYPE>;
    const EMPTY_GIF = "data:image/gif;base64,R0lGODlhAQABAIAAAP///wAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==";
}

/**
 * @memberof PIXI
 */
declare class Signal<CbType = (...args: any) => void> {
    _head: SignalBinding<CbType>;
    _tail: SignalBinding<CbType>;
    /**
     * MiniSignal constructor.
     * @example
     * let mySignal = new Signal();
     * let binding = mySignal.add(onSignal);
     * mySignal.dispatch('foo', 'bar');
     * mySignal.detach(binding);
     */
    constructor();
    /**
     * Return an array of attached SignalBinding.
     * @param {boolean} [exists=false] - We only need to know if there are handlers.
     * @returns {PIXI.SignalBinding[] | boolean} Array of attached SignalBinding or Boolean if called with exists = true
     * @api public
     */
    handlers(exists?: boolean): Array<SignalBinding<CbType>> | boolean;
    /**
     * Return true if node is a SignalBinding attached to this MiniSignal
     * @param {PIXI.SignalBinding} node - Node to check.
     * @returns {boolean} True if node is attache to mini-signal
     */
    has(node: SignalBinding<CbType>): boolean;
    /**
     * Dispaches a signal to all registered listeners.
     * @param {...any} args
     * @returns {boolean} Indication if we've emitted an event.
     */
    dispatch(...args: any[]): boolean;
    /**
     * Register a new listener.
     * @param {Function} fn - Callback function.
     * @param {object} [thisArg] - The context of the callback function.
     * @returns {PIXI.SignalBinding} The SignalBinding node that was added.
     */
    add(fn: CbType, thisArg?: any): SignalBinding<CbType>;
    /**
     * Register a new listener that will be executed only once.
     * @param {Function} fn - Callback function.
     * @param {object} [thisArg] - The context of the callback function.
     * @returns {PIXI.SignalBinding} The SignalBinding node that was added.
     */
    once(fn: CbType, thisArg?: any): SignalBinding<CbType>;
    /**
     * Remove binding object.
     * @param {PIXI.SignalBinding} node - The binding node that will be removed.
     * @returns {Signal} The instance on which this method was called.
     @api public */
    detach(node: SignalBinding<CbType>): this;
    /**
     * Detach all listeners.
     * @returns {Signal} The instance on which this method was called.
     */
    detachAll(): this;
}

/**
 * @memberof PIXI
 */
declare class SignalBinding<CbType> {
    _fn: any;
    _once: boolean;
    _next: SignalBinding<CbType>;
    _prev: SignalBinding<CbType>;
    _owner: Signal<CbType>;
    _thisArg: any;
    /**
     * SignalBinding constructor.
     * @constructs SignalBinding
     * @param {Function} fn - Event handler to be called.
     * @param {boolean} [once=false] - Should this listener be removed after dispatch
     * @param {object} [thisArg] - The context of the callback function.
     * @api private
     */
    constructor(fn: CbType, once: boolean, thisArg: any);
    detach(): boolean;
}

/**
 * Loader plugin for handling Texture resources.
 * @memberof PIXI
 */
export declare class TextureLoader {
    /** @ignore */
    static extension: ExtensionMetadata;
    /** Handle SVG elements a text, render with SVGResource. */
    static add(): void;
    /**
     * Called after a resource is loaded.
     * @see PIXI.Loader.loaderMiddleware
     * @param resource
     * @param {Function} next
     */
    static use(resource: LoaderResource, next: (...args: any[]) => void): void;
}

export { }
