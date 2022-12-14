/*!
 * @pixi/settings - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/settings is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_settings = (function (exports, constants) {
    'use strict';

    var BrowserAdapter = {
        /**
         * Creates a canvas element of the given size.
         * This canvas is created using the browser's native canvas element.
         * @param width - width of the canvas
         * @param height - height of the canvas
         */
        createCanvas: function (width, height) {
            var canvas = document.createElement('canvas');
            canvas.width = width;
            canvas.height = height;
            return canvas;
        },
        getWebGLRenderingContext: function () { return WebGLRenderingContext; },
        getNavigator: function () { return navigator; },
        getBaseUrl: function () { var _a; return ((_a = document.baseURI) !== null && _a !== void 0 ? _a : window.location.href); },
        fetch: function (url, options) { return fetch(url, options); },
    };

    var appleIphone = /iPhone/i;
    var appleIpod = /iPod/i;
    var appleTablet = /iPad/i;
    var appleUniversal = /\biOS-universal(?:.+)Mac\b/i;
    var androidPhone = /\bAndroid(?:.+)Mobile\b/i;
    var androidTablet = /Android/i;
    var amazonPhone = /(?:SD4930UR|\bSilk(?:.+)Mobile\b)/i;
    var amazonTablet = /Silk/i;
    var windowsPhone = /Windows Phone/i;
    var windowsTablet = /\bWindows(?:.+)ARM\b/i;
    var otherBlackBerry = /BlackBerry/i;
    var otherBlackBerry10 = /BB10/i;
    var otherOpera = /Opera Mini/i;
    var otherChrome = /\b(CriOS|Chrome)(?:.+)Mobile/i;
    var otherFirefox = /Mobile(?:.+)Firefox\b/i;
    var isAppleTabletOnIos13 = function (navigator) {
        return (typeof navigator !== 'undefined' &&
            navigator.platform === 'MacIntel' &&
            typeof navigator.maxTouchPoints === 'number' &&
            navigator.maxTouchPoints > 1 &&
            typeof MSStream === 'undefined');
    };
    function createMatch(userAgent) {
        return function (regex) { return regex.test(userAgent); };
    }
    function isMobile$1(param) {
        var nav = {
            userAgent: '',
            platform: '',
            maxTouchPoints: 0
        };
        if (!param && typeof navigator !== 'undefined') {
            nav = {
                userAgent: navigator.userAgent,
                platform: navigator.platform,
                maxTouchPoints: navigator.maxTouchPoints || 0
            };
        }
        else if (typeof param === 'string') {
            nav.userAgent = param;
        }
        else if (param && param.userAgent) {
            nav = {
                userAgent: param.userAgent,
                platform: param.platform,
                maxTouchPoints: param.maxTouchPoints || 0
            };
        }
        var userAgent = nav.userAgent;
        var tmp = userAgent.split('[FBAN');
        if (typeof tmp[1] !== 'undefined') {
            userAgent = tmp[0];
        }
        tmp = userAgent.split('Twitter');
        if (typeof tmp[1] !== 'undefined') {
            userAgent = tmp[0];
        }
        var match = createMatch(userAgent);
        var result = {
            apple: {
                phone: match(appleIphone) && !match(windowsPhone),
                ipod: match(appleIpod),
                tablet: !match(appleIphone) &&
                    (match(appleTablet) || isAppleTabletOnIos13(nav)) &&
                    !match(windowsPhone),
                universal: match(appleUniversal),
                device: (match(appleIphone) ||
                    match(appleIpod) ||
                    match(appleTablet) ||
                    match(appleUniversal) ||
                    isAppleTabletOnIos13(nav)) &&
                    !match(windowsPhone)
            },
            amazon: {
                phone: match(amazonPhone),
                tablet: !match(amazonPhone) && match(amazonTablet),
                device: match(amazonPhone) || match(amazonTablet)
            },
            android: {
                phone: (!match(windowsPhone) && match(amazonPhone)) ||
                    (!match(windowsPhone) && match(androidPhone)),
                tablet: !match(windowsPhone) &&
                    !match(amazonPhone) &&
                    !match(androidPhone) &&
                    (match(amazonTablet) || match(androidTablet)),
                device: (!match(windowsPhone) &&
                    (match(amazonPhone) ||
                        match(amazonTablet) ||
                        match(androidPhone) ||
                        match(androidTablet))) ||
                    match(/\bokhttp\b/i)
            },
            windows: {
                phone: match(windowsPhone),
                tablet: match(windowsTablet),
                device: match(windowsPhone) || match(windowsTablet)
            },
            other: {
                blackberry: match(otherBlackBerry),
                blackberry10: match(otherBlackBerry10),
                opera: match(otherOpera),
                firefox: match(otherFirefox),
                chrome: match(otherChrome),
                device: match(otherBlackBerry) ||
                    match(otherBlackBerry10) ||
                    match(otherOpera) ||
                    match(otherFirefox) ||
                    match(otherChrome)
            },
            any: false,
            phone: false,
            tablet: false
        };
        result.any =
            result.apple.device ||
                result.android.device ||
                result.windows.device ||
                result.other.device;
        result.phone =
            result.apple.phone || result.android.phone || result.windows.phone;
        result.tablet =
            result.apple.tablet || result.android.tablet || result.windows.tablet;
        return result;
    }

    var isMobile = isMobile$1(globalThis.navigator);

    /**
     * Uploading the same buffer multiple times in a single frame can cause performance issues.
     * Apparent on iOS so only check for that at the moment
     * This check may become more complex if this issue pops up elsewhere.
     * @private
     * @returns {boolean} `true` if the same buffer may be uploaded more than once.
     */
    function canUploadSameBuffer() {
        return !isMobile.apple.device;
    }

    /**
     * The maximum recommended texture units to use.
     * In theory the bigger the better, and for desktop we'll use as many as we can.
     * But some mobile devices slow down if there is to many branches in the shader.
     * So in practice there seems to be a sweet spot size that varies depending on the device.
     *
     * In v4, all mobile devices were limited to 4 texture units because for this.
     * In v5, we allow all texture units to be used on modern Apple or Android devices.
     * @private
     * @param {number} max
     * @returns {number} The maximum recommended texture units to use.
     */
    function maxRecommendedTextures(max) {
        var allowMax = true;
        if (isMobile.tablet || isMobile.phone) {
            if (isMobile.apple.device) {
                var match = (navigator.userAgent).match(/OS (\d+)_(\d+)?/);
                if (match) {
                    var majorVersion = parseInt(match[1], 10);
                    // Limit texture units on devices below iOS 11, which will be older hardware
                    if (majorVersion < 11) {
                        allowMax = false;
                    }
                }
            }
            if (isMobile.android.device) {
                var match = (navigator.userAgent).match(/Android\s([0-9.]*)/);
                if (match) {
                    var majorVersion = parseInt(match[1], 10);
                    // Limit texture units on devices below Android 7 (Nougat), which will be older hardware
                    if (majorVersion < 7) {
                        allowMax = false;
                    }
                }
            }
        }
        return allowMax ? max : 4;
    }

    /**
     * User's customizable globals for overriding the default PIXI settings, such
     * as a renderer's default resolution, framerate, float precision, etc.
     * @example
     * // Use the native window resolution as the default resolution
     * // will support high-density displays when rendering
     * PIXI.settings.RESOLUTION = window.devicePixelRatio;
     *
     * // Disable interpolation when scaling, will make texture be pixelated
     * PIXI.settings.SCALE_MODE = PIXI.SCALE_MODES.NEAREST;
     * @namespace PIXI.settings
     */
    var settings = {
        /**
         * This adapter is used to call methods that are platform dependent.
         * For example `document.createElement` only runs on the web but fails in node environments.
         * This allows us to support more platforms by abstracting away specific implementations per platform.
         *
         * By default the adapter is set to work in the browser. However you can create your own
         * by implementing the `IAdapter` interface. See `IAdapter` for more information.
         * @name ADAPTER
         * @memberof PIXI.settings
         * @type {PIXI.IAdapter}
         * @default PIXI.BrowserAdapter
         */
        ADAPTER: BrowserAdapter,
        /**
         * If set to true WebGL will attempt make textures mimpaped by default.
         * Mipmapping will only succeed if the base texture uploaded has power of two dimensions.
         * @static
         * @name MIPMAP_TEXTURES
         * @memberof PIXI.settings
         * @type {PIXI.MIPMAP_MODES}
         * @default PIXI.MIPMAP_MODES.POW2
         */
        MIPMAP_TEXTURES: constants.MIPMAP_MODES.POW2,
        /**
         * Default anisotropic filtering level of textures.
         * Usually from 0 to 16
         * @static
         * @name ANISOTROPIC_LEVEL
         * @memberof PIXI.settings
         * @type {number}
         * @default 0
         */
        ANISOTROPIC_LEVEL: 0,
        /**
         * Default resolution / device pixel ratio of the renderer.
         * @static
         * @name RESOLUTION
         * @memberof PIXI.settings
         * @type {number}
         * @default 1
         */
        RESOLUTION: 1,
        /**
         * Default filter resolution.
         * @static
         * @name FILTER_RESOLUTION
         * @memberof PIXI.settings
         * @type {number}
         * @default 1
         */
        FILTER_RESOLUTION: 1,
        /**
         * Default filter samples.
         * @static
         * @name FILTER_MULTISAMPLE
         * @memberof PIXI.settings
         * @type {PIXI.MSAA_QUALITY}
         * @default PIXI.MSAA_QUALITY.NONE
         */
        FILTER_MULTISAMPLE: constants.MSAA_QUALITY.NONE,
        /**
         * The maximum textures that this device supports.
         * @static
         * @name SPRITE_MAX_TEXTURES
         * @memberof PIXI.settings
         * @type {number}
         * @default 32
         */
        SPRITE_MAX_TEXTURES: maxRecommendedTextures(32),
        // TODO: maybe change to SPRITE.BATCH_SIZE: 2000
        // TODO: maybe add PARTICLE.BATCH_SIZE: 15000
        /**
         * The default sprite batch size.
         *
         * The default aims to balance desktop and mobile devices.
         * @static
         * @name SPRITE_BATCH_SIZE
         * @memberof PIXI.settings
         * @type {number}
         * @default 4096
         */
        SPRITE_BATCH_SIZE: 4096,
        /**
         * The default render options if none are supplied to {@link PIXI.Renderer}
         * or {@link PIXI.CanvasRenderer}.
         * @static
         * @name RENDER_OPTIONS
         * @memberof PIXI.settings
         * @type {object}
         * @property {HTMLCanvasElement} [view=null] -
         * @property {boolean} [antialias=false] -
         * @property {boolean} [autoDensity=false] -
         * @property {boolean} [useContextAlpha=true]  -
         * @property {number} [backgroundColor=0x000000] -
         * @property {number} [backgroundAlpha=1] -
         * @property {boolean} [clearBeforeRender=true] -
         * @property {boolean} [preserveDrawingBuffer=false] -
         * @property {number} [width=800] -
         * @property {number} [height=600] -
         * @property {boolean} [legacy=false] -
         */
        RENDER_OPTIONS: {
            view: null,
            antialias: false,
            autoDensity: false,
            backgroundColor: 0x000000,
            backgroundAlpha: 1,
            useContextAlpha: true,
            clearBeforeRender: true,
            preserveDrawingBuffer: false,
            width: 800,
            height: 600,
            legacy: false,
        },
        /**
         * Default Garbage Collection mode.
         * @static
         * @name GC_MODE
         * @memberof PIXI.settings
         * @type {PIXI.GC_MODES}
         * @default PIXI.GC_MODES.AUTO
         */
        GC_MODE: constants.GC_MODES.AUTO,
        /**
         * Default Garbage Collection max idle.
         * @static
         * @name GC_MAX_IDLE
         * @memberof PIXI.settings
         * @type {number}
         * @default 3600
         */
        GC_MAX_IDLE: 60 * 60,
        /**
         * Default Garbage Collection maximum check count.
         * @static
         * @name GC_MAX_CHECK_COUNT
         * @memberof PIXI.settings
         * @type {number}
         * @default 600
         */
        GC_MAX_CHECK_COUNT: 60 * 10,
        /**
         * Default wrap modes that are supported by pixi.
         * @static
         * @name WRAP_MODE
         * @memberof PIXI.settings
         * @type {PIXI.WRAP_MODES}
         * @default PIXI.WRAP_MODES.CLAMP
         */
        WRAP_MODE: constants.WRAP_MODES.CLAMP,
        /**
         * Default scale mode for textures.
         * @static
         * @name SCALE_MODE
         * @memberof PIXI.settings
         * @type {PIXI.SCALE_MODES}
         * @default PIXI.SCALE_MODES.LINEAR
         */
        SCALE_MODE: constants.SCALE_MODES.LINEAR,
        /**
         * Default specify float precision in vertex shader.
         * @static
         * @name PRECISION_VERTEX
         * @memberof PIXI.settings
         * @type {PIXI.PRECISION}
         * @default PIXI.PRECISION.HIGH
         */
        PRECISION_VERTEX: constants.PRECISION.HIGH,
        /**
         * Default specify float precision in fragment shader.
         * iOS is best set at highp due to https://github.com/pixijs/pixi.js/issues/3742
         * @static
         * @name PRECISION_FRAGMENT
         * @memberof PIXI.settings
         * @type {PIXI.PRECISION}
         * @default PIXI.PRECISION.MEDIUM
         */
        PRECISION_FRAGMENT: isMobile.apple.device ? constants.PRECISION.HIGH : constants.PRECISION.MEDIUM,
        /**
         * Can we upload the same buffer in a single frame?
         * @static
         * @name CAN_UPLOAD_SAME_BUFFER
         * @memberof PIXI.settings
         * @type {boolean}
         */
        CAN_UPLOAD_SAME_BUFFER: canUploadSameBuffer(),
        /**
         * Enables bitmap creation before image load. This feature is experimental.
         * @static
         * @name CREATE_IMAGE_BITMAP
         * @memberof PIXI.settings
         * @type {boolean}
         * @default false
         */
        CREATE_IMAGE_BITMAP: false,
        /**
         * If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
         * Advantages can include sharper image quality (like text) and faster rendering on canvas.
         * The main disadvantage is movement of objects may appear less smooth.
         * @static
         * @constant
         * @memberof PIXI.settings
         * @type {boolean}
         * @default false
         */
        ROUND_PIXELS: false,
    };

    exports.BrowserAdapter = BrowserAdapter;
    exports.isMobile = isMobile;
    exports.settings = settings;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI);
Object.assign(this.PIXI, _pixi_settings);
//# sourceMappingURL=settings.js.map
