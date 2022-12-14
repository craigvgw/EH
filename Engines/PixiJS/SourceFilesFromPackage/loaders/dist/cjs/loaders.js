/*!
 * @pixi/loaders - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/loaders is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

var core = require('@pixi/core');
var utils = require('@pixi/utils');

/* jshint -W097 */
/**
 * @memberof PIXI
 */
var SignalBinding = /** @class */ (function () {
    /**
     * SignalBinding constructor.
     * @constructs SignalBinding
     * @param {Function} fn - Event handler to be called.
     * @param {boolean} [once=false] - Should this listener be removed after dispatch
     * @param {object} [thisArg] - The context of the callback function.
     * @api private
     */
    // eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
    function SignalBinding(fn, once, thisArg) {
        if (once === void 0) { once = false; }
        this._fn = fn;
        this._once = once;
        this._thisArg = thisArg;
        this._next = this._prev = this._owner = null;
    }
    SignalBinding.prototype.detach = function () {
        if (this._owner === null)
            { return false; }
        this._owner.detach(this);
        return true;
    };
    return SignalBinding;
}());
/**
 * @param self
 * @param node
 * @private
 */
function _addSignalBinding(self, node) {
    if (!self._head) {
        self._head = node;
        self._tail = node;
    }
    else {
        self._tail._next = node;
        node._prev = self._tail;
        self._tail = node;
    }
    node._owner = self;
    return node;
}
/**
 * @memberof PIXI
 */
var Signal = /** @class */ (function () {
    /**
     * MiniSignal constructor.
     * @example
     * let mySignal = new Signal();
     * let binding = mySignal.add(onSignal);
     * mySignal.dispatch('foo', 'bar');
     * mySignal.detach(binding);
     */
    function Signal() {
        this._head = this._tail = undefined;
    }
    /**
     * Return an array of attached SignalBinding.
     * @param {boolean} [exists=false] - We only need to know if there are handlers.
     * @returns {PIXI.SignalBinding[] | boolean} Array of attached SignalBinding or Boolean if called with exists = true
     * @api public
     */
    Signal.prototype.handlers = function (exists) {
        if (exists === void 0) { exists = false; }
        var node = this._head;
        if (exists)
            { return !!node; }
        var ee = [];
        while (node) {
            ee.push(node);
            node = node._next;
        }
        return ee;
    };
    /**
     * Return true if node is a SignalBinding attached to this MiniSignal
     * @param {PIXI.SignalBinding} node - Node to check.
     * @returns {boolean} True if node is attache to mini-signal
     */
    Signal.prototype.has = function (node) {
        if (!(node instanceof SignalBinding)) {
            throw new Error('MiniSignal#has(): First arg must be a SignalBinding object.');
        }
        return node._owner === this;
    };
    /**
     * Dispaches a signal to all registered listeners.
     * @param {...any} args
     * @returns {boolean} Indication if we've emitted an event.
     */
    Signal.prototype.dispatch = function () {
        var arguments$1 = arguments;

        var args = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            args[_i] = arguments$1[_i];
        }
        var node = this._head;
        if (!node)
            { return false; }
        while (node) {
            if (node._once)
                { this.detach(node); }
            node._fn.apply(node._thisArg, args);
            node = node._next;
        }
        return true;
    };
    /**
     * Register a new listener.
     * @param {Function} fn - Callback function.
     * @param {object} [thisArg] - The context of the callback function.
     * @returns {PIXI.SignalBinding} The SignalBinding node that was added.
     */
    Signal.prototype.add = function (fn, thisArg) {
        if (thisArg === void 0) { thisArg = null; }
        if (typeof fn !== 'function') {
            throw new Error('MiniSignal#add(): First arg must be a Function.');
        }
        return _addSignalBinding(this, new SignalBinding(fn, false, thisArg));
    };
    /**
     * Register a new listener that will be executed only once.
     * @param {Function} fn - Callback function.
     * @param {object} [thisArg] - The context of the callback function.
     * @returns {PIXI.SignalBinding} The SignalBinding node that was added.
     */
    Signal.prototype.once = function (fn, thisArg) {
        if (thisArg === void 0) { thisArg = null; }
        if (typeof fn !== 'function') {
            throw new Error('MiniSignal#once(): First arg must be a Function.');
        }
        return _addSignalBinding(this, new SignalBinding(fn, true, thisArg));
    };
    /**
     * Remove binding object.
     * @param {PIXI.SignalBinding} node - The binding node that will be removed.
     * @returns {Signal} The instance on which this method was called.
      @api public */
    Signal.prototype.detach = function (node) {
        if (!(node instanceof SignalBinding)) {
            throw new Error('MiniSignal#detach(): First arg must be a SignalBinding object.');
        }
        if (node._owner !== this)
            { return this; } // todo: or error?
        if (node._prev)
            { node._prev._next = node._next; }
        if (node._next)
            { node._next._prev = node._prev; }
        if (node === this._head) { // first node
            this._head = node._next;
            if (node._next === null) {
                this._tail = null;
            }
        }
        else if (node === this._tail) { // last node
            this._tail = node._prev;
            this._tail._next = null;
        }
        node._owner = null;
        return this;
    };
    /**
     * Detach all listeners.
     * @returns {Signal} The instance on which this method was called.
     */
    Signal.prototype.detachAll = function () {
        var node = this._head;
        if (!node)
            { return this; }
        this._head = this._tail = null;
        while (node) {
            node._owner = null;
            node = node._next;
        }
        return this;
    };
    return Signal;
}());

/**
 * function from npm package `parseUri`, converted to TS to avoid leftpad incident
 * @param {string} str
 * @param [opts] - options
 * @param {boolean} [opts.strictMode] - type of parser
 */
function parseUri(str, opts) {
    opts = opts || {};
    var o = {
        // eslint-disable-next-line max-len
        key: ['source', 'protocol', 'authority', 'userInfo', 'user', 'password', 'host', 'port', 'relative', 'path', 'directory', 'file', 'query', 'anchor'],
        q: {
            name: 'queryKey',
            parser: /(?:^|&)([^&=]*)=?([^&]*)/g
        },
        parser: {
            // eslint-disable-next-line max-len
            strict: /^(?:([^:\/?#]+):)?(?:\/\/((?:(([^:@]*)(?::([^:@]*))?)?@)?([^:\/?#]*)(?::(\d*))?))?((((?:[^?#\/]*\/)*)([^?#]*))(?:\?([^#]*))?(?:#(.*))?)/,
            // eslint-disable-next-line max-len
            loose: /^(?:(?![^:@]+:[^:@\/]*@)([^:\/?#.]+):)?(?:\/\/)?((?:(([^:@]*)(?::([^:@]*))?)?@)?([^:\/?#]*)(?::(\d*))?)(((\/(?:[^?#](?![^?#\/]*\.[^?#\/.]+(?:[?#]|$)))*\/?)?([^?#\/]*))(?:\?([^#]*))?(?:#(.*))?)/
        }
    };
    var m = o.parser[opts.strictMode ? 'strict' : 'loose'].exec(str);
    var uri = {};
    var i = 14;
    while (i--)
        { uri[o.key[i]] = m[i] || ''; }
    uri[o.q.name] = {};
    uri[o.key[12]].replace(o.q.parser, function (_t0, t1, t2) {
        if (t1)
            { uri[o.q.name][t1] = t2; }
    });
    return uri;
}

// tests if CORS is supported in XHR, if not we need to use XDR
var useXdr;
var tempAnchor = null;
// some status constants
var STATUS_NONE = 0;
var STATUS_OK = 200;
var STATUS_EMPTY = 204;
var STATUS_IE_BUG_EMPTY = 1223;
var STATUS_TYPE_OK = 2;
// noop
function _noop$1() { }
/**
 * Quick helper to set a value on one of the extension maps. Ensures there is no
 * dot at the start of the extension.
 * @ignore
 * @param map - The map to set on.
 * @param extname - The extension (or key) to set.
 * @param val - The value to set.
 */
function setExtMap(map, extname, val) {
    if (extname && extname.indexOf('.') === 0) {
        extname = extname.substring(1);
    }
    if (!extname) {
        return;
    }
    map[extname] = val;
}
/**
 * Quick helper to get string xhr type.
 * @ignore
 * @param xhr - The request to check.
 * @returns The type.
 */
function reqType(xhr) {
    return xhr.toString().replace('object ', '');
}
/**
 * Manages the state and loading of a resource and all child resources.
 *
 * Can be extended in `GlobalMixins.LoaderResource`.
 * @memberof PIXI
 */
exports.LoaderResource = /** @class */ (function () {
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
    function LoaderResource(name, url, options) {
        /**
         * The `dequeue` method that will be used a storage place for the async queue dequeue method
         * used privately by the loader.
         * @private
         * @member {Function}
         */
        this._dequeue = _noop$1;
        /**
         * Used a storage place for the on load binding used privately by the loader.
         * @private
         * @member {Function}
         */
        this._onLoadBinding = null;
        /**
         * The timer for element loads to check if they timeout.
         * @private
         */
        this._elementTimer = 0;
        /**
         * The `complete` function bound to this resource's context.
         * @private
         * @type {Function}
         */
        this._boundComplete = null;
        /**
         * The `_onError` function bound to this resource's context.
         * @private
         * @type {Function}
         */
        this._boundOnError = null;
        /**
         * The `_onProgress` function bound to this resource's context.
         * @private
         * @type {Function}
         */
        this._boundOnProgress = null;
        /**
         * The `_onTimeout` function bound to this resource's context.
         * @private
         * @type {Function}
         */
        this._boundOnTimeout = null;
        this._boundXhrOnError = null;
        this._boundXhrOnTimeout = null;
        this._boundXhrOnAbort = null;
        this._boundXhrOnLoad = null;
        if (typeof name !== 'string' || typeof url !== 'string') {
            throw new Error('Both name and url are required for constructing a resource.');
        }
        options = options || {};
        this._flags = 0;
        // set data url flag, needs to be set early for some _determineX checks to work.
        this._setFlag(LoaderResource.STATUS_FLAGS.DATA_URL, url.indexOf('data:') === 0);
        this.name = name;
        this.url = url;
        this.extension = this._getExtension();
        this.data = null;
        this.crossOrigin = options.crossOrigin === true ? 'anonymous' : options.crossOrigin;
        this.timeout = options.timeout || 0;
        this.loadType = options.loadType || this._determineLoadType();
        // The type used to load the resource via XHR. If unset, determined automatically.
        this.xhrType = options.xhrType;
        // Extra info for middleware, and controlling specifics about how the resource loads.
        // Note that if you pass in a `loadElement`, the Resource class takes ownership of it.
        // Meaning it will modify it as it sees fit.
        this.metadata = options.metadata || {};
        // The error that occurred while loading (if any).
        this.error = null;
        // The XHR object that was used to load this resource. This is only set
        // when `loadType` is `LoaderResource.LOAD_TYPE.XHR`.
        this.xhr = null;
        // The child resources this resource owns.
        this.children = [];
        // The resource type.
        this.type = LoaderResource.TYPE.UNKNOWN;
        // The progress chunk owned by this resource.
        this.progressChunk = 0;
        // The `dequeue` method that will be used a storage place for the async queue dequeue method
        // used privately by the loader.
        this._dequeue = _noop$1;
        // Used a storage place for the on load binding used privately by the loader.
        this._onLoadBinding = null;
        // The timer for element loads to check if they timeout.
        this._elementTimer = 0;
        this._boundComplete = this.complete.bind(this);
        this._boundOnError = this._onError.bind(this);
        this._boundOnProgress = this._onProgress.bind(this);
        this._boundOnTimeout = this._onTimeout.bind(this);
        // xhr callbacks
        this._boundXhrOnError = this._xhrOnError.bind(this);
        this._boundXhrOnTimeout = this._xhrOnTimeout.bind(this);
        this._boundXhrOnAbort = this._xhrOnAbort.bind(this);
        this._boundXhrOnLoad = this._xhrOnLoad.bind(this);
        // Dispatched when the resource beings to load.
        this.onStart = new Signal();
        // Dispatched each time progress of this resource load updates.
        // Not all resources types and loader systems can support this event
        // so sometimes it may not be available. If the resource
        // is being loaded on a modern browser, using XHR, and the remote server
        // properly sets Content-Length headers, then this will be available.
        this.onProgress = new Signal();
        // Dispatched once this resource has loaded, if there was an error it will
        // be in the `error` property.
        this.onComplete = new Signal();
        // Dispatched after this resource has had all the *after* middleware run on it.
        this.onAfterMiddleware = new Signal();
    }
    /**
     * Sets the load type to be used for a specific extension.
     * @static
     * @param {string} extname - The extension to set the type for, e.g. "png" or "fnt"
     * @param {PIXI.LoaderResource.LOAD_TYPE} loadType - The load type to set it to.
     */
    LoaderResource.setExtensionLoadType = function (extname, loadType) {
        setExtMap(LoaderResource._loadTypeMap, extname, loadType);
    };
    /**
     * Sets the load type to be used for a specific extension.
     * @static
     * @param {string} extname - The extension to set the type for, e.g. "png" or "fnt"
     * @param {PIXI.LoaderResource.XHR_RESPONSE_TYPE} xhrType - The xhr type to set it to.
     */
    LoaderResource.setExtensionXhrType = function (extname, xhrType) {
        setExtMap(LoaderResource._xhrTypeMap, extname, xhrType);
    };
    Object.defineProperty(LoaderResource.prototype, "isDataUrl", {
        /**
         * When the resource starts to load.
         * @memberof PIXI.LoaderResource
         * @callback OnStartSignal
         * @param {PIXI.Resource} resource - The resource that the event happened on.
         */
        /**
         * When the resource reports loading progress.
         * @memberof PIXI.LoaderResource
         * @callback OnProgressSignal
         * @param {PIXI.Resource} resource - The resource that the event happened on.
         * @param {number} percentage - The progress of the load in the range [0, 1].
         */
        /**
         * When the resource finishes loading.
         * @memberof PIXI.LoaderResource
         * @callback OnCompleteSignal
         * @param {PIXI.Resource} resource - The resource that the event happened on.
         */
        /**
         * @memberof PIXI.LoaderResource
         * @typedef {object} IMetadata
         * @property {HTMLImageElement|HTMLAudioElement|HTMLVideoElement} [loadElement=null] - The
         *      element to use for loading, instead of creating one.
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
        get: function () {
            return this._hasFlag(LoaderResource.STATUS_FLAGS.DATA_URL);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(LoaderResource.prototype, "isComplete", {
        /**
         * Describes if this resource has finished loading. Is true when the resource has completely
         * loaded.
         * @readonly
         * @member {boolean}
         */
        get: function () {
            return this._hasFlag(LoaderResource.STATUS_FLAGS.COMPLETE);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(LoaderResource.prototype, "isLoading", {
        /**
         * Describes if this resource is currently loading. Is true when the resource starts loading,
         * and is false again when complete.
         * @readonly
         * @member {boolean}
         */
        get: function () {
            return this._hasFlag(LoaderResource.STATUS_FLAGS.LOADING);
        },
        enumerable: false,
        configurable: true
    });
    /** Marks the resource as complete. */
    LoaderResource.prototype.complete = function () {
        this._clearEvents();
        this._finish();
    };
    /**
     * Aborts the loading of this resource, with an optional message.
     * @param {string} message - The message to use for the error
     */
    LoaderResource.prototype.abort = function (message) {
        // abort can be called multiple times, ignore subsequent calls.
        if (this.error) {
            return;
        }
        // store error
        this.error = new Error(message);
        // clear events before calling aborts
        this._clearEvents();
        // abort the actual loading
        if (this.xhr) {
            this.xhr.abort();
        }
        else if (this.xdr) {
            this.xdr.abort();
        }
        else if (this.data) {
            // single source
            if (this.data.src) {
                this.data.src = LoaderResource.EMPTY_GIF;
            }
            // multi-source
            else {
                while (this.data.firstChild) {
                    this.data.removeChild(this.data.firstChild);
                }
            }
        }
        // done now.
        this._finish();
    };
    /**
     * Kicks off loading of this resource. This method is asynchronous.
     * @param {PIXI.LoaderResource.OnCompleteSignal} [cb] - Optional callback to call once the resource is loaded.
     */
    LoaderResource.prototype.load = function (cb) {
        var _this = this;
        if (this.isLoading) {
            return;
        }
        if (this.isComplete) {
            if (cb) {
                setTimeout(function () { return cb(_this); }, 1);
            }
            return;
        }
        else if (cb) {
            this.onComplete.once(cb);
        }
        this._setFlag(LoaderResource.STATUS_FLAGS.LOADING, true);
        this.onStart.dispatch(this);
        // if unset, determine the value
        if (this.crossOrigin === false || typeof this.crossOrigin !== 'string') {
            this.crossOrigin = this._determineCrossOrigin(this.url);
        }
        switch (this.loadType) {
            case LoaderResource.LOAD_TYPE.IMAGE:
                this.type = LoaderResource.TYPE.IMAGE;
                this._loadElement('image');
                break;
            case LoaderResource.LOAD_TYPE.AUDIO:
                this.type = LoaderResource.TYPE.AUDIO;
                this._loadSourceElement('audio');
                break;
            case LoaderResource.LOAD_TYPE.VIDEO:
                this.type = LoaderResource.TYPE.VIDEO;
                this._loadSourceElement('video');
                break;
            case LoaderResource.LOAD_TYPE.XHR:
            /* falls through */
            default:
                if (typeof useXdr === 'undefined') {
                    useXdr = !!(globalThis.XDomainRequest && !('withCredentials' in (new XMLHttpRequest())));
                }
                if (useXdr && this.crossOrigin) {
                    this._loadXdr();
                }
                else {
                    this._loadXhr();
                }
                break;
        }
    };
    /**
     * Checks if the flag is set.
     * @param flag - The flag to check.
     * @returns True if the flag is set.
     */
    LoaderResource.prototype._hasFlag = function (flag) {
        return (this._flags & flag) !== 0;
    };
    /**
     * (Un)Sets the flag.
     * @param flag - The flag to (un)set.
     * @param value - Whether to set or (un)set the flag.
     */
    LoaderResource.prototype._setFlag = function (flag, value) {
        this._flags = value ? (this._flags | flag) : (this._flags & ~flag);
    };
    /** Clears all the events from the underlying loading source. */
    LoaderResource.prototype._clearEvents = function () {
        clearTimeout(this._elementTimer);
        if (this.data && this.data.removeEventListener) {
            this.data.removeEventListener('error', this._boundOnError, false);
            this.data.removeEventListener('load', this._boundComplete, false);
            this.data.removeEventListener('progress', this._boundOnProgress, false);
            this.data.removeEventListener('canplaythrough', this._boundComplete, false);
        }
        if (this.xhr) {
            if (this.xhr.removeEventListener) {
                this.xhr.removeEventListener('error', this._boundXhrOnError, false);
                this.xhr.removeEventListener('timeout', this._boundXhrOnTimeout, false);
                this.xhr.removeEventListener('abort', this._boundXhrOnAbort, false);
                this.xhr.removeEventListener('progress', this._boundOnProgress, false);
                this.xhr.removeEventListener('load', this._boundXhrOnLoad, false);
            }
            else {
                this.xhr.onerror = null;
                this.xhr.ontimeout = null;
                this.xhr.onprogress = null;
                this.xhr.onload = null;
            }
        }
    };
    /** Finalizes the load. */
    LoaderResource.prototype._finish = function () {
        if (this.isComplete) {
            throw new Error('Complete called again for an already completed resource.');
        }
        this._setFlag(LoaderResource.STATUS_FLAGS.COMPLETE, true);
        this._setFlag(LoaderResource.STATUS_FLAGS.LOADING, false);
        this.onComplete.dispatch(this);
    };
    /**
     * Loads this resources using an element that has a single source,
     * like an HTMLImageElement.
     * @private
     * @param type - The type of element to use.
     */
    LoaderResource.prototype._loadElement = function (type) {
        if (this.metadata.loadElement) {
            this.data = this.metadata.loadElement;
        }
        else if (type === 'image' && typeof globalThis.Image !== 'undefined') {
            this.data = new Image();
        }
        else {
            this.data = document.createElement(type);
        }
        if (this.crossOrigin) {
            this.data.crossOrigin = this.crossOrigin;
        }
        if (!this.metadata.skipSource) {
            this.data.src = this.url;
        }
        this.data.addEventListener('error', this._boundOnError, false);
        this.data.addEventListener('load', this._boundComplete, false);
        this.data.addEventListener('progress', this._boundOnProgress, false);
        if (this.timeout) {
            this._elementTimer = setTimeout(this._boundOnTimeout, this.timeout);
        }
    };
    /**
     * Loads this resources using an element that has multiple sources,
     * like an HTMLAudioElement or HTMLVideoElement.
     * @param type - The type of element to use.
     */
    LoaderResource.prototype._loadSourceElement = function (type) {
        if (this.metadata.loadElement) {
            this.data = this.metadata.loadElement;
        }
        else if (type === 'audio' && typeof globalThis.Audio !== 'undefined') {
            this.data = new Audio();
        }
        else {
            this.data = document.createElement(type);
        }
        if (this.data === null) {
            this.abort("Unsupported element: " + type);
            return;
        }
        if (this.crossOrigin) {
            this.data.crossOrigin = this.crossOrigin;
        }
        if (!this.metadata.skipSource) {
            // support for CocoonJS Canvas+ runtime, lacks document.createElement('source')
            if (navigator.isCocoonJS) {
                this.data.src = Array.isArray(this.url) ? this.url[0] : this.url;
            }
            else if (Array.isArray(this.url)) {
                var mimeTypes = this.metadata.mimeType;
                for (var i = 0; i < this.url.length; ++i) {
                    this.data.appendChild(this._createSource(type, this.url[i], Array.isArray(mimeTypes) ? mimeTypes[i] : mimeTypes));
                }
            }
            else {
                var mimeTypes = this.metadata.mimeType;
                this.data.appendChild(this._createSource(type, this.url, Array.isArray(mimeTypes) ? mimeTypes[0] : mimeTypes));
            }
        }
        this.data.addEventListener('error', this._boundOnError, false);
        this.data.addEventListener('load', this._boundComplete, false);
        this.data.addEventListener('progress', this._boundOnProgress, false);
        this.data.addEventListener('canplaythrough', this._boundComplete, false);
        this.data.load();
        if (this.timeout) {
            this._elementTimer = setTimeout(this._boundOnTimeout, this.timeout);
        }
    };
    /** Loads this resources using an XMLHttpRequest. */
    LoaderResource.prototype._loadXhr = function () {
        // if unset, determine the value
        if (typeof this.xhrType !== 'string') {
            this.xhrType = this._determineXhrType();
        }
        var xhr = this.xhr = new XMLHttpRequest();
        // send credentials when crossOrigin with credentials requested
        if (this.crossOrigin === 'use-credentials') {
            xhr.withCredentials = true;
        }
        // set the request type and url
        xhr.open('GET', this.url, true);
        xhr.timeout = this.timeout;
        // load json as text and parse it ourselves. We do this because some browsers
        // *cough* safari *cough* can't deal with it.
        if (this.xhrType === LoaderResource.XHR_RESPONSE_TYPE.JSON
            || this.xhrType === LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT) {
            xhr.responseType = LoaderResource.XHR_RESPONSE_TYPE.TEXT;
        }
        else {
            xhr.responseType = this.xhrType;
        }
        xhr.addEventListener('error', this._boundXhrOnError, false);
        xhr.addEventListener('timeout', this._boundXhrOnTimeout, false);
        xhr.addEventListener('abort', this._boundXhrOnAbort, false);
        xhr.addEventListener('progress', this._boundOnProgress, false);
        xhr.addEventListener('load', this._boundXhrOnLoad, false);
        xhr.send();
    };
    /** Loads this resources using an XDomainRequest. This is here because we need to support IE9 (gross). */
    LoaderResource.prototype._loadXdr = function () {
        // if unset, determine the value
        if (typeof this.xhrType !== 'string') {
            this.xhrType = this._determineXhrType();
        }
        var xdr = this.xhr = new globalThis.XDomainRequest(); // eslint-disable-line no-undef
        // XDomainRequest has a few quirks. Occasionally it will abort requests
        // A way to avoid this is to make sure ALL callbacks are set even if not used
        // More info here: http://stackoverflow.com/questions/15786966/xdomainrequest-aborts-post-on-ie-9
        xdr.timeout = this.timeout || 5000; // XDR needs a timeout value or it breaks in IE9
        xdr.onerror = this._boundXhrOnError;
        xdr.ontimeout = this._boundXhrOnTimeout;
        xdr.onprogress = this._boundOnProgress;
        xdr.onload = this._boundXhrOnLoad;
        xdr.open('GET', this.url, true);
        // Note: The xdr.send() call is wrapped in a timeout to prevent an
        // issue with the interface where some requests are lost if multiple
        // XDomainRequests are being sent at the same time.
        // Some info here: https://github.com/photonstorm/phaser/issues/1248
        setTimeout(function () { return xdr.send(); }, 1);
    };
    /**
     * Creates a source used in loading via an element.
     * @param type - The element type (video or audio).
     * @param url - The source URL to load from.
     * @param [mime] - The mime type of the video
     * @returns The source element.
     */
    LoaderResource.prototype._createSource = function (type, url, mime) {
        if (!mime) {
            mime = type + "/" + this._getExtension(url);
        }
        var source = document.createElement('source');
        source.src = url;
        source.type = mime;
        return source;
    };
    /**
     * Called if a load errors out.
     * @param event - The error event from the element that emits it.
     */
    LoaderResource.prototype._onError = function (event) {
        this.abort("Failed to load element using: " + event.target.nodeName);
    };
    /**
     * Called if a load progress event fires for an element or xhr/xdr.
     * @param event - Progress event.
     */
    LoaderResource.prototype._onProgress = function (event) {
        if (event && event.lengthComputable) {
            this.onProgress.dispatch(this, event.loaded / event.total);
        }
    };
    /** Called if a timeout event fires for an element. */
    LoaderResource.prototype._onTimeout = function () {
        this.abort("Load timed out.");
    };
    /** Called if an error event fires for xhr/xdr. */
    LoaderResource.prototype._xhrOnError = function () {
        var xhr = this.xhr;
        this.abort(reqType(xhr) + " Request failed. Status: " + xhr.status + ", text: \"" + xhr.statusText + "\"");
    };
    /** Called if an error event fires for xhr/xdr. */
    LoaderResource.prototype._xhrOnTimeout = function () {
        var xhr = this.xhr;
        this.abort(reqType(xhr) + " Request timed out.");
    };
    /** Called if an abort event fires for xhr/xdr. */
    LoaderResource.prototype._xhrOnAbort = function () {
        var xhr = this.xhr;
        this.abort(reqType(xhr) + " Request was aborted by the user.");
    };
    /** Called when data successfully loads from an xhr/xdr request. */
    LoaderResource.prototype._xhrOnLoad = function () {
        var xhr = this.xhr;
        var text = '';
        var status = typeof xhr.status === 'undefined' ? STATUS_OK : xhr.status; // XDR has no `.status`, assume 200.
        // responseText is accessible only if responseType is '' or 'text' and on older browsers
        if (xhr.responseType === '' || xhr.responseType === 'text' || typeof xhr.responseType === 'undefined') {
            text = xhr.responseText;
        }
        // status can be 0 when using the `file://` protocol so we also check if a response is set.
        // If it has a response, we assume 200; otherwise a 0 status code with no contents is an aborted request.
        if (status === STATUS_NONE && (text.length > 0 || xhr.responseType === LoaderResource.XHR_RESPONSE_TYPE.BUFFER)) {
            status = STATUS_OK;
        }
        // handle IE9 bug: http://stackoverflow.com/questions/10046972/msie-returns-status-code-of-1223-for-ajax-request
        else if (status === STATUS_IE_BUG_EMPTY) {
            status = STATUS_EMPTY;
        }
        var statusType = (status / 100) | 0;
        if (statusType === STATUS_TYPE_OK) {
            // if text, just return it
            if (this.xhrType === LoaderResource.XHR_RESPONSE_TYPE.TEXT) {
                this.data = text;
                this.type = LoaderResource.TYPE.TEXT;
            }
            // if json, parse into json object
            else if (this.xhrType === LoaderResource.XHR_RESPONSE_TYPE.JSON) {
                try {
                    this.data = JSON.parse(text);
                    this.type = LoaderResource.TYPE.JSON;
                }
                catch (e) {
                    this.abort("Error trying to parse loaded json: " + e);
                    return;
                }
            }
            // if xml, parse into an xml document or div element
            else if (this.xhrType === LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT) {
                try {
                    if (globalThis.DOMParser) {
                        var domparser = new DOMParser();
                        this.data = domparser.parseFromString(text, 'text/xml');
                    }
                    else {
                        var div = document.createElement('div');
                        div.innerHTML = text;
                        this.data = div;
                    }
                    this.type = LoaderResource.TYPE.XML;
                }
                catch (e$1) {
                    this.abort("Error trying to parse loaded xml: " + e$1);
                    return;
                }
            }
            // other types just return the response
            else {
                this.data = xhr.response || text;
            }
        }
        else {
            this.abort("[" + xhr.status + "] " + xhr.statusText + ": " + xhr.responseURL);
            return;
        }
        this.complete();
    };
    /**
     * Sets the `crossOrigin` property for this resource based on if the url
     * for this resource is cross-origin. If crossOrigin was manually set, this
     * function does nothing.
     * @private
     * @param url - The url to test.
     * @param [loc=globalThis.location] - The location object to test against.
     * @returns The crossOrigin value to use (or empty string for none).
     */
    // eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
    LoaderResource.prototype._determineCrossOrigin = function (url, loc) {
        // data: and javascript: urls are considered same-origin
        if (url.indexOf('data:') === 0) {
            return '';
        }
        // A sandboxed iframe without the 'allow-same-origin' attribute will have a special
        // origin designed not to match globalThis.location.origin, and will always require
        // crossOrigin requests regardless of whether the location matches.
        if (globalThis.origin !== globalThis.location.origin) {
            return 'anonymous';
        }
        // default is globalThis.location
        loc = loc || globalThis.location;
        if (!tempAnchor) {
            tempAnchor = document.createElement('a');
        }
        // let the browser determine the full href for the url of this resource and then
        // parse with the node url lib, we can't use the properties of the anchor element
        // because they don't work in IE9 :(
        tempAnchor.href = url;
        var parsedUrl = parseUri(tempAnchor.href, { strictMode: true });
        var samePort = (!parsedUrl.port && loc.port === '') || (parsedUrl.port === loc.port);
        var protocol = parsedUrl.protocol ? parsedUrl.protocol + ":" : '';
        // if cross origin
        if (parsedUrl.host !== loc.hostname || !samePort || protocol !== loc.protocol) {
            return 'anonymous';
        }
        return '';
    };
    /**
     * Determines the responseType of an XHR request based on the extension of the
     * resource being loaded.
     * @private
     * @returns {PIXI.LoaderResource.XHR_RESPONSE_TYPE} The responseType to use.
     */
    LoaderResource.prototype._determineXhrType = function () {
        return LoaderResource._xhrTypeMap[this.extension] || LoaderResource.XHR_RESPONSE_TYPE.TEXT;
    };
    /**
     * Determines the loadType of a resource based on the extension of the
     * resource being loaded.
     * @private
     * @returns {PIXI.LoaderResource.LOAD_TYPE} The loadType to use.
     */
    LoaderResource.prototype._determineLoadType = function () {
        return LoaderResource._loadTypeMap[this.extension] || LoaderResource.LOAD_TYPE.XHR;
    };
    /**
     * Extracts the extension (sans '.') of the file being loaded by the resource.
     * @param [url] - url to parse, `this.url` by default.
     * @returns The extension.
     */
    LoaderResource.prototype._getExtension = function (url) {
        if (url === void 0) { url = this.url; }
        var ext = '';
        if (this.isDataUrl) {
            var slashIndex = url.indexOf('/');
            ext = url.substring(slashIndex + 1, url.indexOf(';', slashIndex));
        }
        else {
            var queryStart = url.indexOf('?');
            var hashStart = url.indexOf('#');
            var index = Math.min(queryStart > -1 ? queryStart : url.length, hashStart > -1 ? hashStart : url.length);
            url = url.substring(0, index);
            ext = url.substring(url.lastIndexOf('.') + 1);
        }
        return ext.toLowerCase();
    };
    /**
     * Determines the mime type of an XHR request based on the responseType of
     * resource being loaded.
     * @param type - The type to get a mime type for.
     * @private
     * @returns The mime type to use.
     */
    LoaderResource.prototype._getMimeFromXhrType = function (type) {
        switch (type) {
            case LoaderResource.XHR_RESPONSE_TYPE.BUFFER:
                return 'application/octet-binary';
            case LoaderResource.XHR_RESPONSE_TYPE.BLOB:
                return 'application/blob';
            case LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT:
                return 'application/xml';
            case LoaderResource.XHR_RESPONSE_TYPE.JSON:
                return 'application/json';
            case LoaderResource.XHR_RESPONSE_TYPE.DEFAULT:
            case LoaderResource.XHR_RESPONSE_TYPE.TEXT:
            /* falls through */
            default:
                return 'text/plain';
        }
    };
    return LoaderResource;
}());
// eslint-disable-next-line @typescript-eslint/no-namespace
(function (LoaderResource) {
    (function (STATUS_FLAGS) {
        /** None */
        STATUS_FLAGS[STATUS_FLAGS["NONE"] = 0] = "NONE";
        /** Data URL */
        STATUS_FLAGS[STATUS_FLAGS["DATA_URL"] = 1] = "DATA_URL";
        /** Complete */
        STATUS_FLAGS[STATUS_FLAGS["COMPLETE"] = 2] = "COMPLETE";
        /** Loading */
        STATUS_FLAGS[STATUS_FLAGS["LOADING"] = 4] = "LOADING";
    })(LoaderResource.STATUS_FLAGS || (LoaderResource.STATUS_FLAGS = {}));
    (function (TYPE) {
        /** Unknown */
        TYPE[TYPE["UNKNOWN"] = 0] = "UNKNOWN";
        /** JSON */
        TYPE[TYPE["JSON"] = 1] = "JSON";
        /** XML */
        TYPE[TYPE["XML"] = 2] = "XML";
        /** Image */
        TYPE[TYPE["IMAGE"] = 3] = "IMAGE";
        /** Audio */
        TYPE[TYPE["AUDIO"] = 4] = "AUDIO";
        /** Video */
        TYPE[TYPE["VIDEO"] = 5] = "VIDEO";
        /** Plain text */
        TYPE[TYPE["TEXT"] = 6] = "TEXT";
    })(LoaderResource.TYPE || (LoaderResource.TYPE = {}));
    (function (LOAD_TYPE) {
        /** Uses XMLHttpRequest to load the resource. */
        LOAD_TYPE[LOAD_TYPE["XHR"] = 1] = "XHR";
        /** Uses an `Image` object to load the resource. */
        LOAD_TYPE[LOAD_TYPE["IMAGE"] = 2] = "IMAGE";
        /** Uses an `Audio` object to load the resource. */
        LOAD_TYPE[LOAD_TYPE["AUDIO"] = 3] = "AUDIO";
        /** Uses a `Video` object to load the resource. */
        LOAD_TYPE[LOAD_TYPE["VIDEO"] = 4] = "VIDEO";
    })(LoaderResource.LOAD_TYPE || (LoaderResource.LOAD_TYPE = {}));
    (function (XHR_RESPONSE_TYPE) {
        /** string */
        XHR_RESPONSE_TYPE["DEFAULT"] = "text";
        /** ArrayBuffer */
        XHR_RESPONSE_TYPE["BUFFER"] = "arraybuffer";
        /** Blob */
        XHR_RESPONSE_TYPE["BLOB"] = "blob";
        /** Document */
        XHR_RESPONSE_TYPE["DOCUMENT"] = "document";
        /** Object */
        XHR_RESPONSE_TYPE["JSON"] = "json";
        /** String */
        XHR_RESPONSE_TYPE["TEXT"] = "text";
    })(LoaderResource.XHR_RESPONSE_TYPE || (LoaderResource.XHR_RESPONSE_TYPE = {}));
    LoaderResource._loadTypeMap = {
        // images
        gif: LoaderResource.LOAD_TYPE.IMAGE,
        png: LoaderResource.LOAD_TYPE.IMAGE,
        bmp: LoaderResource.LOAD_TYPE.IMAGE,
        jpg: LoaderResource.LOAD_TYPE.IMAGE,
        jpeg: LoaderResource.LOAD_TYPE.IMAGE,
        tif: LoaderResource.LOAD_TYPE.IMAGE,
        tiff: LoaderResource.LOAD_TYPE.IMAGE,
        webp: LoaderResource.LOAD_TYPE.IMAGE,
        tga: LoaderResource.LOAD_TYPE.IMAGE,
        svg: LoaderResource.LOAD_TYPE.IMAGE,
        'svg+xml': LoaderResource.LOAD_TYPE.IMAGE,
        // audio
        mp3: LoaderResource.LOAD_TYPE.AUDIO,
        ogg: LoaderResource.LOAD_TYPE.AUDIO,
        wav: LoaderResource.LOAD_TYPE.AUDIO,
        // videos
        mp4: LoaderResource.LOAD_TYPE.VIDEO,
        webm: LoaderResource.LOAD_TYPE.VIDEO,
    };
    LoaderResource._xhrTypeMap = {
        // xml
        xhtml: LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT,
        html: LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT,
        htm: LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT,
        xml: LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT,
        tmx: LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT,
        svg: LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT,
        // This was added to handle Tiled Tileset XML, but .tsx is also a TypeScript React Component.
        // Since it is way less likely for people to be loading TypeScript files instead of Tiled files,
        // this should probably be fine.
        tsx: LoaderResource.XHR_RESPONSE_TYPE.DOCUMENT,
        // images
        gif: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        png: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        bmp: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        jpg: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        jpeg: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        tif: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        tiff: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        webp: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        tga: LoaderResource.XHR_RESPONSE_TYPE.BLOB,
        // json
        json: LoaderResource.XHR_RESPONSE_TYPE.JSON,
        // text
        text: LoaderResource.XHR_RESPONSE_TYPE.TEXT,
        txt: LoaderResource.XHR_RESPONSE_TYPE.TEXT,
        // fonts
        ttf: LoaderResource.XHR_RESPONSE_TYPE.BUFFER,
        otf: LoaderResource.XHR_RESPONSE_TYPE.BUFFER,
    };
    // We can't set the `src` attribute to empty string, so on abort we set it to this 1px transparent gif
    LoaderResource.EMPTY_GIF = 'data:image/gif;base64,R0lGODlhAQABAIAAAP///wAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==';
})(exports.LoaderResource || (exports.LoaderResource = {}));

/**
 * Smaller version of the async library constructs.
 * @ignore
 */
function _noop() {
}
/**
 * Ensures a function is only called once.
 * @ignore
 * @param {Function} fn - The function to wrap.
 * @returns {Function} The wrapping function.
 */
function onlyOnce(fn) {
    return function onceWrapper() {
        var arguments$1 = arguments;

        var args = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            args[_i] = arguments$1[_i];
        }
        if (fn === null) {
            throw new Error('Callback was already called.');
        }
        var callFn = fn;
        fn = null;
        callFn.apply(this, args);
    };
}
/**
 * @private
 * @memberof PIXI
 */
var AsyncQueueItem = /** @class */ (function () {
    /**
     * @param data
     * @param callback
     * @private
     */
    function AsyncQueueItem(data, callback) {
        this.data = data;
        this.callback = callback;
    }
    return AsyncQueueItem;
}());
/**
 * @private
 * @memberof PIXI
 */
var AsyncQueue = /** @class */ (function () {
    /**
     * @param worker
     * @param concurrency
     * @private
     */
    function AsyncQueue(worker, concurrency) {
        var _this = this;
        if (concurrency === void 0) { concurrency = 1; }
        this.workers = 0;
        this.saturated = _noop;
        this.unsaturated = _noop;
        this.empty = _noop;
        this.drain = _noop;
        this.error = _noop;
        this.started = false;
        this.paused = false;
        this._tasks = [];
        this._insert = function (data, insertAtFront, callback) {
            if (callback && typeof callback !== 'function') {
                throw new Error('task callback must be a function');
            }
            _this.started = true;
            // eslint-disable-next-line no-eq-null,eqeqeq
            if (data == null && _this.idle()) {
                // call drain immediately if there are no tasks
                setTimeout(function () { return _this.drain(); }, 1);
                return;
            }
            var item = new AsyncQueueItem(data, typeof callback === 'function' ? callback : _noop);
            if (insertAtFront) {
                _this._tasks.unshift(item);
            }
            else {
                _this._tasks.push(item);
            }
            setTimeout(_this.process, 1);
        };
        this.process = function () {
            while (!_this.paused && _this.workers < _this.concurrency && _this._tasks.length) {
                var task = _this._tasks.shift();
                if (_this._tasks.length === 0) {
                    _this.empty();
                }
                _this.workers += 1;
                if (_this.workers === _this.concurrency) {
                    _this.saturated();
                }
                _this._worker(task.data, onlyOnce(_this._next(task)));
            }
        };
        this._worker = worker;
        if (concurrency === 0) {
            throw new Error('Concurrency must not be zero');
        }
        this.concurrency = concurrency;
        this.buffer = concurrency / 4.0;
    }
    /**
     * @param task
     * @private
     */
    AsyncQueue.prototype._next = function (task) {
        var _this = this;
        return function () {
            var arguments$1 = arguments;

            var args = [];
            for (var _i = 0; _i < arguments.length; _i++) {
                args[_i] = arguments$1[_i];
            }
            _this.workers -= 1;
            task.callback.apply(task, args);
            // eslint-disable-next-line no-eq-null,eqeqeq
            if (args[0] != null) {
                _this.error(args[0], task.data);
            }
            if (_this.workers <= (_this.concurrency - _this.buffer)) {
                _this.unsaturated();
            }
            if (_this.idle()) {
                _this.drain();
            }
            _this.process();
        };
    };
    // That was in object
    // eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
    AsyncQueue.prototype.push = function (data, callback) {
        this._insert(data, false, callback);
    };
    AsyncQueue.prototype.kill = function () {
        this.workers = 0;
        this.drain = _noop;
        this.started = false;
        this._tasks = [];
    };
    // eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
    AsyncQueue.prototype.unshift = function (data, callback) {
        this._insert(data, true, callback);
    };
    AsyncQueue.prototype.length = function () {
        return this._tasks.length;
    };
    AsyncQueue.prototype.running = function () {
        return this.workers;
    };
    AsyncQueue.prototype.idle = function () {
        return this._tasks.length + this.workers === 0;
    };
    AsyncQueue.prototype.pause = function () {
        if (this.paused === true) {
            return;
        }
        this.paused = true;
    };
    AsyncQueue.prototype.resume = function () {
        if (this.paused === false) {
            return;
        }
        this.paused = false;
        // Need to call this.process once per concurrent
        // worker to preserve full concurrency after pause
        for (var w = 1; w <= this.concurrency; w++) {
            this.process();
        }
    };
    /**
     * Iterates an array in series.
     * @param {Array.<*>} array - Array to iterate.
     * @param {Function} iterator - Function to call for each element.
     * @param {Function} callback - Function to call when done, or on error.
     * @param {boolean} [deferNext=false] - Break synchronous each loop by calling next with a setTimeout of 1.
     */
    AsyncQueue.eachSeries = function (array, iterator, callback, deferNext) {
        var i = 0;
        var len = array.length;
        function next(err) {
            if (err || i === len) {
                if (callback) {
                    callback(err);
                }
                return;
            }
            if (deferNext) {
                setTimeout(function () {
                    iterator(array[i++], next);
                }, 1);
            }
            else {
                iterator(array[i++], next);
            }
        }
        next();
    };
    /**
     * Async queue implementation,
     * @param {Function} worker - The worker function to call for each task.
     * @param {number} concurrency - How many workers to run in parrallel.
     * @returns {*} The async queue object.
     */
    AsyncQueue.queue = function (worker, concurrency) {
        return new AsyncQueue(worker, concurrency);
    };
    return AsyncQueue;
}());

// some constants
var MAX_PROGRESS = 100;
var rgxExtractUrlHash = /(#[\w-]+)?$/;
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
var Loader = /** @class */ (function () {
    /**
     * @param baseUrl - The base url for all resources loaded by this loader.
     * @param concurrency - The number of resources to load concurrently.
     */
    function Loader(baseUrl, concurrency) {
        var _this = this;
        if (baseUrl === void 0) { baseUrl = ''; }
        if (concurrency === void 0) { concurrency = 10; }
        /** The progress percent of the loader going through the queue. */
        this.progress = 0;
        /** Loading state of the loader, true if it is currently loading resources. */
        this.loading = false;
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
        this.defaultQueryString = '';
        /** The middleware to run before loading each resource. */
        this._beforeMiddleware = [];
        /** The middleware to run after loading each resource. */
        this._afterMiddleware = [];
        /** The tracks the resources we are currently completing parsing for. */
        this._resourcesParsing = [];
        /**
         * The `_loadResource` function bound with this object context.
         * @param r - The resource to load
         * @param d - The dequeue function
         */
        this._boundLoadResource = function (r, d) { return _this._loadResource(r, d); };
        /** All the resources for this loader keyed by name. */
        this.resources = {};
        this.baseUrl = baseUrl;
        this._beforeMiddleware = [];
        this._afterMiddleware = [];
        this._resourcesParsing = [];
        this._boundLoadResource = function (r, d) { return _this._loadResource(r, d); };
        this._queue = AsyncQueue.queue(this._boundLoadResource, concurrency);
        this._queue.pause();
        this.resources = {};
        this.onProgress = new Signal();
        this.onError = new Signal();
        this.onLoad = new Signal();
        this.onStart = new Signal();
        this.onComplete = new Signal();
        for (var i = 0; i < Loader._plugins.length; ++i) {
            var plugin = Loader._plugins[i];
            var pre = plugin.pre, use = plugin.use;
            if (pre) {
                this.pre(pre);
            }
            if (use) {
                this.use(use);
            }
        }
        this._protected = false;
    }
    /**
     * Same as add, params have strict order
     * @private
     * @param name - The name of the resource to load.
     * @param url - The url for this resource, relative to the baseUrl of this loader.
     * @param options - The options for the load.
     * @param callback - Function to call when this specific resource completes loading.
     * @returns The loader itself.
     */
    Loader.prototype._add = function (name, url, options, callback) {
        // if loading already you can only add resources that have a parent.
        if (this.loading && (!options || !options.parentResource)) {
            throw new Error('Cannot add resources while the loader is running.');
        }
        // check if resource already exists.
        if (this.resources[name]) {
            throw new Error("Resource named \"" + name + "\" already exists.");
        }
        // add base url if this isn't an absolute url
        url = this._prepareUrl(url);
        // create the store the resource
        this.resources[name] = new exports.LoaderResource(name, url, options);
        if (typeof callback === 'function') {
            this.resources[name].onAfterMiddleware.once(callback);
        }
        // if actively loading, make sure to adjust progress chunks for that parent and its children
        if (this.loading) {
            var parent = options.parentResource;
            var incompleteChildren = [];
            for (var i = 0; i < parent.children.length; ++i) {
                if (!parent.children[i].isComplete) {
                    incompleteChildren.push(parent.children[i]);
                }
            }
            var fullChunk = parent.progressChunk * (incompleteChildren.length + 1); // +1 for parent
            var eachChunk = fullChunk / (incompleteChildren.length + 2); // +2 for parent & new child
            parent.children.push(this.resources[name]);
            parent.progressChunk = eachChunk;
            for (var i = 0; i < incompleteChildren.length; ++i) {
                incompleteChildren[i].progressChunk = eachChunk;
            }
            this.resources[name].progressChunk = eachChunk;
        }
        // add the resource to the queue
        this._queue.push(this.resources[name]);
        return this;
    };
    /* eslint-enable require-jsdoc,valid-jsdoc */
    /**
     * Sets up a middleware function that will run *before* the
     * resource is loaded.
     * @param fn - The middleware function to register.
     * @returns The loader itself.
     */
    Loader.prototype.pre = function (fn) {
        this._beforeMiddleware.push(fn);
        return this;
    };
    /**
     * Sets up a middleware function that will run *after* the
     * resource is loaded.
     * @param fn - The middleware function to register.
     * @returns The loader itself.
     */
    Loader.prototype.use = function (fn) {
        this._afterMiddleware.push(fn);
        return this;
    };
    /**
     * Resets the queue of the loader to prepare for a new load.
     * @returns The loader itself.
     */
    Loader.prototype.reset = function () {
        this.progress = 0;
        this.loading = false;
        this._queue.kill();
        this._queue.pause();
        // abort all resource loads
        for (var k in this.resources) {
            var res = this.resources[k];
            if (res._onLoadBinding) {
                res._onLoadBinding.detach();
            }
            if (res.isLoading) {
                res.abort('loader reset');
            }
        }
        this.resources = {};
        return this;
    };
    /**
     * Starts loading the queued resources.
     * @param cb - Optional callback that will be bound to the `complete` event.
     * @returns The loader itself.
     */
    Loader.prototype.load = function (cb) {
        utils.deprecation('6.5.0', '@pixi/loaders is being replaced with @pixi/assets in the next major release.');
        // register complete callback if they pass one
        if (typeof cb === 'function') {
            this.onComplete.once(cb);
        }
        // if the queue has already started we are done here
        if (this.loading) {
            return this;
        }
        if (this._queue.idle()) {
            this._onStart();
            this._onComplete();
        }
        else {
            // distribute progress chunks
            var numTasks = this._queue._tasks.length;
            var chunk = MAX_PROGRESS / numTasks;
            for (var i = 0; i < this._queue._tasks.length; ++i) {
                this._queue._tasks[i].data.progressChunk = chunk;
            }
            // notify we are starting
            this._onStart();
            // start loading
            this._queue.resume();
        }
        return this;
    };
    Object.defineProperty(Loader.prototype, "concurrency", {
        /**
         * The number of resources to load concurrently.
         * @default 10
         */
        get: function () {
            return this._queue.concurrency;
        },
        set: function (concurrency) {
            this._queue.concurrency = concurrency;
        },
        enumerable: false,
        configurable: true
    });
    /**
     * Prepares a url for usage based on the configuration of this object
     * @param url - The url to prepare.
     * @returns The prepared url.
     */
    Loader.prototype._prepareUrl = function (url) {
        var parsedUrl = parseUri(url, { strictMode: true });
        var result;
        // absolute url, just use it as is.
        if (parsedUrl.protocol || !parsedUrl.path || url.indexOf('//') === 0) {
            result = url;
        }
        // if baseUrl doesn't end in slash and url doesn't start with slash, then add a slash inbetween
        else if (this.baseUrl.length
            && this.baseUrl.lastIndexOf('/') !== this.baseUrl.length - 1
            && url.charAt(0) !== '/') {
            result = this.baseUrl + "/" + url;
        }
        else {
            result = this.baseUrl + url;
        }
        // if we need to add a default querystring, there is a bit more work
        if (this.defaultQueryString) {
            var hash = rgxExtractUrlHash.exec(result)[0];
            result = result.slice(0, result.length - hash.length);
            if (result.indexOf('?') !== -1) {
                result += "&" + this.defaultQueryString;
            }
            else {
                result += "?" + this.defaultQueryString;
            }
            result += hash;
        }
        return result;
    };
    /**
     * Loads a single resource.
     * @param resource - The resource to load.
     * @param dequeue - The function to call when we need to dequeue this item.
     */
    Loader.prototype._loadResource = function (resource, dequeue) {
        var _this = this;
        resource._dequeue = dequeue;
        // run before middleware
        AsyncQueue.eachSeries(this._beforeMiddleware, function (fn, next) {
            fn.call(_this, resource, function () {
                // if the before middleware marks the resource as complete,
                // break and don't process any more before middleware
                next(resource.isComplete ? {} : null);
            });
        }, function () {
            if (resource.isComplete) {
                _this._onLoad(resource);
            }
            else {
                resource._onLoadBinding = resource.onComplete.once(_this._onLoad, _this);
                resource.load();
            }
        }, true);
    };
    /** Called once loading has started. */
    Loader.prototype._onStart = function () {
        this.progress = 0;
        this.loading = true;
        this.onStart.dispatch(this);
    };
    /** Called once each resource has loaded. */
    Loader.prototype._onComplete = function () {
        this.progress = MAX_PROGRESS;
        this.loading = false;
        this.onComplete.dispatch(this, this.resources);
    };
    /**
     * Called each time a resources is loaded.
     * @param resource - The resource that was loaded
     */
    Loader.prototype._onLoad = function (resource) {
        var _this = this;
        resource._onLoadBinding = null;
        // remove this resource from the async queue, and add it to our list of resources that are being parsed
        this._resourcesParsing.push(resource);
        resource._dequeue();
        // run all the after middleware for this resource
        AsyncQueue.eachSeries(this._afterMiddleware, function (fn, next) {
            fn.call(_this, resource, next);
        }, function () {
            resource.onAfterMiddleware.dispatch(resource);
            _this.progress = Math.min(MAX_PROGRESS, _this.progress + resource.progressChunk);
            _this.onProgress.dispatch(_this, resource);
            if (resource.error) {
                _this.onError.dispatch(resource.error, _this, resource);
            }
            else {
                _this.onLoad.dispatch(_this, resource);
            }
            _this._resourcesParsing.splice(_this._resourcesParsing.indexOf(resource), 1);
            // do completion check
            if (_this._queue.idle() && _this._resourcesParsing.length === 0) {
                _this._onComplete();
            }
        }, true);
    };
    /** Destroy the loader, removes references. */
    Loader.prototype.destroy = function () {
        if (!this._protected) {
            this.reset();
        }
    };
    Object.defineProperty(Loader, "shared", {
        /** A premade instance of the loader that can be used to load resources. */
        get: function () {
            var shared = Loader._shared;
            if (!shared) {
                shared = new Loader();
                shared._protected = true;
                Loader._shared = shared;
            }
            return shared;
        },
        enumerable: false,
        configurable: true
    });
    /**
     * Use the {@link PIXI.extensions.add} API to register plugins.
     * @deprecated since 6.5.0
     * @param plugin - The plugin to add
     * @returns Reference to PIXI.Loader for chaining
     */
    Loader.registerPlugin = function (plugin) {
        utils.deprecation('6.5.0', 'Loader.registerPlugin() is deprecated, use extensions.add() instead.');
        core.extensions.add({
            type: core.ExtensionType.Loader,
            ref: plugin,
        });
        return Loader;
    };
    Loader._plugins = [];
    return Loader;
}());
core.extensions.handleByList(core.ExtensionType.Loader, Loader._plugins);
Loader.prototype.add = function add(name, url, options, callback) {
    // special case of an array of objects or urls
    if (Array.isArray(name)) {
        for (var i = 0; i < name.length; ++i) {
            this.add(name[i]);
        }
        return this;
    }
    // if an object is passed instead of params
    if (typeof name === 'object') {
        options = name;
        callback = url || options.callback || options.onComplete;
        url = options.url;
        name = options.name || options.key || options.url;
    }
    // case where no name is passed shift all args over by one.
    if (typeof url !== 'string') {
        callback = options;
        options = url;
        url = name;
    }
    // now that we shifted make sure we have a proper url.
    if (typeof url !== 'string') {
        throw new Error('No url passed to add resource to loader.');
    }
    // options are optional so people might pass a function and no options
    if (typeof options === 'function') {
        callback = options;
        options = null;
    }
    return this._add(name, url, options, callback);
};

/**
 * Application plugin for supporting loader option. Installing the LoaderPlugin
 * is not necessary if using **pixi.js** or **pixi.js-legacy**.
 * @example
 * import {AppLoaderPlugin} from '@pixi/loaders';
 * import {extensions} from '@pixi/core';
 * extensions.add(AppLoaderPlugin);
 * @memberof PIXI
 */
var AppLoaderPlugin = /** @class */ (function () {
    function AppLoaderPlugin() {
    }
    /**
     * Called on application constructor
     * @param options
     * @private
     */
    AppLoaderPlugin.init = function (options) {
        options = Object.assign({
            sharedLoader: false,
        }, options);
        this.loader = options.sharedLoader ? Loader.shared : new Loader();
    };
    /**
     * Called when application destroyed
     * @private
     */
    AppLoaderPlugin.destroy = function () {
        if (this.loader) {
            this.loader.destroy();
            this.loader = null;
        }
    };
    /** @ignore */
    AppLoaderPlugin.extension = core.ExtensionType.Application;
    return AppLoaderPlugin;
}());

/**
 * Loader plugin for handling Texture resources.
 * @memberof PIXI
 */
var TextureLoader = /** @class */ (function () {
    function TextureLoader() {
    }
    /** Handle SVG elements a text, render with SVGResource. */
    TextureLoader.add = function () {
        exports.LoaderResource.setExtensionLoadType('svg', exports.LoaderResource.LOAD_TYPE.XHR);
        exports.LoaderResource.setExtensionXhrType('svg', exports.LoaderResource.XHR_RESPONSE_TYPE.TEXT);
    };
    /**
     * Called after a resource is loaded.
     * @see PIXI.Loader.loaderMiddleware
     * @param resource
     * @param {Function} next
     */
    TextureLoader.use = function (resource, next) {
        // create a new texture if the data is an Image object
        if (resource.data && (resource.type === exports.LoaderResource.TYPE.IMAGE || resource.extension === 'svg')) {
            var data = resource.data, url = resource.url, name = resource.name, metadata = resource.metadata;
            core.Texture.fromLoader(data, url, name, metadata).then(function (texture) {
                resource.texture = texture;
                next();
            })
                // TODO: handle errors in Texture.fromLoader
                // so we can pass them to the Loader
                .catch(next);
        }
        else {
            next();
        }
    };
    /** @ignore */
    TextureLoader.extension = core.ExtensionType.Loader;
    return TextureLoader;
}());

var _keyStr = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=';
/**
 * Encodes binary into base64.
 * @function encodeBinary
 * @param {string} input - The input data to encode.
 * @returns {string} The encoded base64 string
 */
function encodeBinary(input) {
    var output = '';
    var inx = 0;
    while (inx < input.length) {
        // Fill byte buffer array
        var bytebuffer = [0, 0, 0];
        var encodedCharIndexes = [0, 0, 0, 0];
        for (var jnx = 0; jnx < bytebuffer.length; ++jnx) {
            if (inx < input.length) {
                // throw away high-order byte, as documented at:
                // https://developer.mozilla.org/En/Using_XMLHttpRequest#Handling_binary_data
                bytebuffer[jnx] = input.charCodeAt(inx++) & 0xff;
            }
            else {
                bytebuffer[jnx] = 0;
            }
        }
        // Get each encoded character, 6 bits at a time
        // index 1: first 6 bits
        encodedCharIndexes[0] = bytebuffer[0] >> 2;
        // index 2: second 6 bits (2 least significant bits from input byte 1 + 4 most significant bits from byte 2)
        encodedCharIndexes[1] = ((bytebuffer[0] & 0x3) << 4) | (bytebuffer[1] >> 4);
        // index 3: third 6 bits (4 least significant bits from input byte 2 + 2 most significant bits from byte 3)
        encodedCharIndexes[2] = ((bytebuffer[1] & 0x0f) << 2) | (bytebuffer[2] >> 6);
        // index 3: forth 6 bits (6 least significant bits from input byte 3)
        encodedCharIndexes[3] = bytebuffer[2] & 0x3f;
        // Determine whether padding happened, and adjust accordingly
        var paddingBytes = inx - (input.length - 1);
        switch (paddingBytes) {
            case 2:
                // Set last 2 characters to padding char
                encodedCharIndexes[3] = 64;
                encodedCharIndexes[2] = 64;
                break;
            case 1:
                // Set last character to padding char
                encodedCharIndexes[3] = 64;
                break;
        }
        // Now we will grab each appropriate character out of our keystring
        // based on our index array and append it to the output string
        for (var jnx = 0; jnx < encodedCharIndexes.length; ++jnx) {
            output += _keyStr.charAt(encodedCharIndexes[jnx]);
        }
    }
    return output;
}

/**
 * A middleware for transforming XHR loaded Blobs into more useful objects
 * @ignore
 * @function parsing
 * @example
 * import { Loader, middleware } from 'resource-loader';
 * const loader = new Loader();
 * loader.use(middleware.parsing);
 * @param resource - Current Resource
 * @param next - Callback when complete
 */
function parsing(resource, next) {
    if (!resource.data) {
        next();
        return;
    }
    // if this was an XHR load of a blob
    if (resource.xhr && resource.xhrType === exports.LoaderResource.XHR_RESPONSE_TYPE.BLOB) {
        // if there is no blob support we probably got a binary string back
        if (!self.Blob || typeof resource.data === 'string') {
            var type = resource.xhr.getResponseHeader('content-type');
            // this is an image, convert the binary string into a data url
            if (type && type.indexOf('image') === 0) {
                resource.data = new Image();
                resource.data.src = "data:" + type + ";base64," + encodeBinary(resource.xhr.responseText);
                resource.type = exports.LoaderResource.TYPE.IMAGE;
                // wait until the image loads and then callback
                resource.data.onload = function () {
                    resource.data.onload = null;
                    next();
                };
                // next will be called on load
                return;
            }
        }
        // if content type says this is an image, then we should transform the blob into an Image object
        else if (resource.data.type.indexOf('image') === 0) {
            var Url_1 = globalThis.URL || globalThis.webkitURL;
            var src_1 = Url_1.createObjectURL(resource.data);
            resource.blob = resource.data;
            resource.data = new Image();
            resource.data.src = src_1;
            resource.type = exports.LoaderResource.TYPE.IMAGE;
            // cleanup the no longer used blob after the image loads
            // TODO: Is this correct? Will the image be invalid after revoking?
            resource.data.onload = function () {
                Url_1.revokeObjectURL(src_1);
                resource.data.onload = null;
                next();
            };
            // next will be called on load.
            return;
        }
    }
    next();
}

/**
 * Parse any blob into more usable objects (e.g. Image).
 * @memberof PIXI
 */
var ParsingLoader = /** @class */ (function () {
    function ParsingLoader() {
    }
    /** @ignore */
    ParsingLoader.extension = core.ExtensionType.Loader;
    ParsingLoader.use = parsing;
    return ParsingLoader;
}());

core.extensions.add(TextureLoader, ParsingLoader);

exports.AppLoaderPlugin = AppLoaderPlugin;
exports.Loader = Loader;
exports.TextureLoader = TextureLoader;
//# sourceMappingURL=loaders.js.map
