/*!
 * @pixi/utils - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/utils is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

var settings = require('@pixi/settings');
var eventemitter3 = require('eventemitter3');
var earcut = require('earcut');
var url$1 = require('url');
var constants = require('@pixi/constants');

function _interopDefaultLegacy (e) { return e && typeof e === 'object' && 'default' in e ? e : { 'default': e }; }

var eventemitter3__default = /*#__PURE__*/_interopDefaultLegacy(eventemitter3);
var earcut__default = /*#__PURE__*/_interopDefaultLegacy(earcut);

/**
 * This file contains redeclared types for Node `url` and `querystring` modules. These modules
 * don't provide their own typings but instead are a part of the full Node typings. The purpose of
 * this file is to redeclare the required types to avoid having the whole Node types as a
 * dependency.
 */
var url = {
    parse: url$1.parse,
    format: url$1.format,
    resolve: url$1.resolve,
};

function assertPath(path) {
    if (typeof path !== 'string') {
        throw new TypeError("Path must be a string. Received " + JSON.stringify(path));
    }
}
function escapeRegExp(string) {
    return string.replace(/[.*+?^${}()|[\]\\]/g, '\\$&'); // $& means the whole matched string
}
function replaceAll(str, find, replace) {
    return str.replace(new RegExp(escapeRegExp(find), 'g'), replace);
}
// Resolves . and .. elements in a path with directory names
function normalizeStringPosix(path, allowAboveRoot) {
    var res = '';
    var lastSegmentLength = 0;
    var lastSlash = -1;
    var dots = 0;
    var code;
    for (var i = 0; i <= path.length; ++i) {
        if (i < path.length) {
            code = path.charCodeAt(i);
        }
        else if (code === 47) {
            break;
        }
        else {
            code = 47;
        }
        if (code === 47) {
            if (lastSlash === i - 1 || dots === 1) ;
            else if (lastSlash !== i - 1 && dots === 2) {
                if (res.length < 2
                    || lastSegmentLength !== 2
                    || res.charCodeAt(res.length - 1) !== 46
                    || res.charCodeAt(res.length - 2) !== 46) {
                    if (res.length > 2) {
                        var lastSlashIndex = res.lastIndexOf('/');
                        if (lastSlashIndex !== res.length - 1) {
                            if (lastSlashIndex === -1) {
                                res = '';
                                lastSegmentLength = 0;
                            }
                            else {
                                res = res.slice(0, lastSlashIndex);
                                lastSegmentLength = res.length - 1 - res.lastIndexOf('/');
                            }
                            lastSlash = i;
                            dots = 0;
                            continue;
                        }
                    }
                    else if (res.length === 2 || res.length === 1) {
                        res = '';
                        lastSegmentLength = 0;
                        lastSlash = i;
                        dots = 0;
                        continue;
                    }
                }
                if (allowAboveRoot) {
                    if (res.length > 0) {
                        res += '/..';
                    }
                    else {
                        res = '..';
                    }
                    lastSegmentLength = 2;
                }
            }
            else {
                if (res.length > 0) {
                    res += "/" + path.slice(lastSlash + 1, i);
                }
                else {
                    res = path.slice(lastSlash + 1, i);
                }
                lastSegmentLength = i - lastSlash - 1;
            }
            lastSlash = i;
            dots = 0;
        }
        else if (code === 46 && dots !== -1) {
            ++dots;
        }
        else {
            dots = -1;
        }
    }
    return res;
}
var path = {
    /**
     * Converts a path to posix format.
     * @param path - The path to convert to posix
     */
    toPosix: function (path) { return replaceAll(path, '\\', '/'); },
    /**
     * Checks if the path is a URL
     * @param path - The path to check
     */
    isUrl: function (path) { return (/^https?:/).test(this.toPosix(path)); },
    /**
     * Checks if the path is a data URL
     * @param path - The path to check
     */
    isDataUrl: function (path) {
        // eslint-disable-next-line max-len
        return (/^data:([a-z]+\/[a-z0-9-+.]+(;[a-z0-9-.!#$%*+.{}|~`]+=[a-z0-9-.!#$%*+.{}()_|~`]+)*)?(;base64)?,([a-z0-9!$&',()*+;=\-._~:@\/?%\s<>]*?)$/i)
            .test(path);
    },
    /**
     * Checks if the path has a protocol e.g. http://
     * This will return true for windows file paths
     * @param path - The path to check
     */
    hasProtocol: function (path) { return (/^[^/:]+:\//).test(this.toPosix(path)); },
    /**
     * Returns the protocol of the path e.g. http://, C:/, file:///
     * @param path - The path to get the protocol from
     */
    getProtocol: function (path) {
        assertPath(path);
        path = this.toPosix(path);
        var protocol = '';
        var isFile = (/^file:\/\/\//).exec(path);
        var isHttp = (/^[^/:]+:\/\//).exec(path);
        var isWindows = (/^[^/:]+:\//).exec(path);
        if (isFile || isHttp || isWindows) {
            var arr = (isFile === null || isFile === void 0 ? void 0 : isFile[0]) || (isHttp === null || isHttp === void 0 ? void 0 : isHttp[0]) || (isWindows === null || isWindows === void 0 ? void 0 : isWindows[0]);
            protocol = arr;
            path = path.slice(arr.length);
        }
        return protocol;
    },
    /**
     * Converts URL to an absolute path.
     * When loading from a Web Worker, we must use absolute paths.
     * If the URL is already absolute we return it as is
     * If it's not, we convert it
     * @param url - The URL to test
     * @param customBaseUrl - The base URL to use
     * @param customRootUrl - The root URL to use
     */
    toAbsolute: function (url, customBaseUrl, customRootUrl) {
        if (this.isDataUrl(url))
            { return url; }
        var baseUrl = this.toPosix(customBaseUrl !== null && customBaseUrl !== void 0 ? customBaseUrl : settings.settings.ADAPTER.getBaseUrl());
        var rootUrl = this.toPosix(customRootUrl !== null && customRootUrl !== void 0 ? customRootUrl : this.rootname(baseUrl));
        assertPath(url);
        url = this.toPosix(url);
        // root relative url
        if (url.startsWith('/')) {
            return path.join(rootUrl, url.slice(1));
        }
        var absolutePath = this.isAbsolute(url) ? url : this.join(baseUrl, url);
        return absolutePath;
    },
    /**
     * Normalizes the given path, resolving '..' and '.' segments
     * @param path - The path to normalize
     */
    normalize: function (path) {
        path = this.toPosix(path);
        assertPath(path);
        if (path.length === 0)
            { return '.'; }
        var protocol = '';
        var isAbsolute = path.startsWith('/');
        if (this.hasProtocol(path)) {
            protocol = this.rootname(path);
            path = path.slice(protocol.length);
        }
        var trailingSeparator = path.endsWith('/');
        // Normalize the path
        path = normalizeStringPosix(path, false);
        if (path.length > 0 && trailingSeparator)
            { path += '/'; }
        if (isAbsolute)
            { return "/" + path; }
        return protocol + path;
    },
    /**
     * Determines if path is an absolute path.
     * Absolute paths can be urls, data urls, or paths on disk
     * @param path - The path to test
     */
    isAbsolute: function (path) {
        assertPath(path);
        path = this.toPosix(path);
        if (this.hasProtocol(path))
            { return true; }
        return path.startsWith('/');
    },
    /**
     * Joins all given path segments together using the platform-specific separator as a delimiter,
     * then normalizes the resulting path
     * @param segments - The segments of the path to join
     */
    join: function () {
        var arguments$1 = arguments;

        var segments = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            segments[_i] = arguments$1[_i];
        }
        if (segments.length === 0) {
            return '.';
        }
        var joined;
        for (var i = 0; i < segments.length; ++i) {
            var arg = segments[i];
            assertPath(arg);
            if (arg.length > 0) {
                if (joined === undefined)
                    { joined = arg; }
                else
                    { joined += "/" + arg; }
            }
        }
        if (joined === undefined) {
            return '.';
        }
        return this.normalize(joined);
    },
    /**
     * Returns the directory name of a path
     * @param path - The path to parse
     */
    dirname: function (path) {
        assertPath(path);
        if (path.length === 0)
            { return '.'; }
        path = this.toPosix(path);
        var code = path.charCodeAt(0);
        var hasRoot = code === 47;
        var end = -1;
        var matchedSlash = true;
        var proto = this.getProtocol(path);
        var origpath = path;
        path = path.slice(proto.length);
        for (var i = path.length - 1; i >= 1; --i) {
            code = path.charCodeAt(i);
            if (code === 47) {
                if (!matchedSlash) {
                    end = i;
                    break;
                }
            }
            else {
                // We saw the first non-path separator
                matchedSlash = false;
            }
        }
        // if end is -1 and its a url then we need to add the path back
        // eslint-disable-next-line no-nested-ternary
        if (end === -1)
            { return hasRoot ? '/' : this.isUrl(origpath) ? proto + path : proto; }
        if (hasRoot && end === 1)
            { return '//'; }
        return proto + path.slice(0, end);
    },
    /**
     * Returns the root of the path e.g. /, C:/, file:///, http://domain.com/
     * @param path - The path to parse
     */
    rootname: function (path) {
        assertPath(path);
        path = this.toPosix(path);
        var root = '';
        if (path.startsWith('/'))
            { root = '/'; }
        else {
            root = this.getProtocol(path);
        }
        if (this.isUrl(path)) {
            // need to find the first path separator
            var index = path.indexOf('/', root.length);
            if (index !== -1) {
                root = path.slice(0, index);
            }
            else
                { root = path; }
            if (!root.endsWith('/'))
                { root += '/'; }
        }
        return root;
    },
    /**
     * Returns the last portion of a path
     * @param path - The path to test
     * @param ext - Optional extension to remove
     */
    basename: function (path, ext) {
        assertPath(path);
        if (ext)
            { assertPath(ext); }
        path = this.toPosix(path);
        var start = 0;
        var end = -1;
        var matchedSlash = true;
        var i;
        if (ext !== undefined && ext.length > 0 && ext.length <= path.length) {
            if (ext.length === path.length && ext === path)
                { return ''; }
            var extIdx = ext.length - 1;
            var firstNonSlashEnd = -1;
            for (i = path.length - 1; i >= 0; --i) {
                var code = path.charCodeAt(i);
                if (code === 47) {
                    // If we reached a path separator that was not part of a set of path
                    // separators at the end of the string, stop now
                    if (!matchedSlash) {
                        start = i + 1;
                        break;
                    }
                }
                else {
                    if (firstNonSlashEnd === -1) {
                        // We saw the first non-path separator, remember this index in case
                        // we need it if the extension ends up not matching
                        matchedSlash = false;
                        firstNonSlashEnd = i + 1;
                    }
                    if (extIdx >= 0) {
                        // Try to match the explicit extension
                        if (code === ext.charCodeAt(extIdx)) {
                            if (--extIdx === -1) {
                                // We matched the extension, so mark this as the end of our path
                                // component
                                end = i;
                            }
                        }
                        else {
                            // Extension does not match, so our result is the entire path
                            // component
                            extIdx = -1;
                            end = firstNonSlashEnd;
                        }
                    }
                }
            }
            if (start === end)
                { end = firstNonSlashEnd; }
            else if (end === -1)
                { end = path.length; }
            return path.slice(start, end);
        }
        for (i = path.length - 1; i >= 0; --i) {
            if (path.charCodeAt(i) === 47) {
                // If we reached a path separator that was not part of a set of path
                // separators at the end of the string, stop now
                if (!matchedSlash) {
                    start = i + 1;
                    break;
                }
            }
            else if (end === -1) {
                // We saw the first non-path separator, mark this as the end of our
                // path component
                matchedSlash = false;
                end = i + 1;
            }
        }
        if (end === -1)
            { return ''; }
        return path.slice(start, end);
    },
    /**
     * Returns the extension of the path, from the last occurrence of the . (period) character to end of string in the last
     * portion of the path. If there is no . in the last portion of the path, or if there are no . characters other than
     * the first character of the basename of path, an empty string is returned.
     * @param path - The path to parse
     */
    extname: function (path) {
        assertPath(path);
        path = this.toPosix(path);
        var startDot = -1;
        var startPart = 0;
        var end = -1;
        var matchedSlash = true;
        // Track the state of characters (if any) we see before our first dot and
        // after any path separator we find
        var preDotState = 0;
        for (var i = path.length - 1; i >= 0; --i) {
            var code = path.charCodeAt(i);
            if (code === 47) {
                // If we reached a path separator that was not part of a set of path
                // separators at the end of the string, stop now
                if (!matchedSlash) {
                    startPart = i + 1;
                    break;
                }
                continue;
            }
            if (end === -1) {
                // We saw the first non-path separator, mark this as the end of our
                // extension
                matchedSlash = false;
                end = i + 1;
            }
            if (code === 46) {
                // If this is our first dot, mark it as the start of our extension
                if (startDot === -1)
                    { startDot = i; }
                else if (preDotState !== 1)
                    { preDotState = 1; }
            }
            else if (startDot !== -1) {
                // We saw a non-dot and non-path separator before our dot, so we should
                // have a good chance at having a non-empty extension
                preDotState = -1;
            }
        }
        if (startDot === -1 || end === -1
            // We saw a non-dot character immediately before the dot
            || preDotState === 0
            // The (right-most) trimmed path component is exactly '..'
            // eslint-disable-next-line no-mixed-operators
            || preDotState === 1 && startDot === end - 1 && startDot === startPart + 1) {
            return '';
        }
        return path.slice(startDot, end);
    },
    /**
     * Parses a path into an object containing the 'root', `dir`, `base`, `ext`, and `name` properties.
     * @param path - The path to parse
     */
    parse: function (path) {
        assertPath(path);
        var ret = { root: '', dir: '', base: '', ext: '', name: '' };
        if (path.length === 0)
            { return ret; }
        path = this.toPosix(path);
        var code = path.charCodeAt(0);
        var isAbsolute = this.isAbsolute(path);
        var start;
        ret.root = this.rootname(path);
        if (isAbsolute || this.hasProtocol(path)) {
            start = 1;
        }
        else {
            start = 0;
        }
        var startDot = -1;
        var startPart = 0;
        var end = -1;
        var matchedSlash = true;
        var i = path.length - 1;
        // Track the state of characters (if any) we see before our first dot and
        // after any path separator we find
        var preDotState = 0;
        // Get non-dir info
        for (; i >= start; --i) {
            code = path.charCodeAt(i);
            if (code === 47) {
                // If we reached a path separator that was not part of a set of path
                // separators at the end of the string, stop now
                if (!matchedSlash) {
                    startPart = i + 1;
                    break;
                }
                continue;
            }
            if (end === -1) {
                // We saw the first non-path separator, mark this as the end of our
                // extension
                matchedSlash = false;
                end = i + 1;
            }
            if (code === 46) {
                // If this is our first dot, mark it as the start of our extension
                if (startDot === -1)
                    { startDot = i; }
                else if (preDotState !== 1)
                    { preDotState = 1; }
            }
            else if (startDot !== -1) {
                // We saw a non-dot and non-path separator before our dot, so we should
                // have a good chance at having a non-empty extension
                preDotState = -1;
            }
        }
        if (startDot === -1 || end === -1
            // We saw a non-dot character immediately before the dot
            || preDotState === 0
            // The (right-most) trimmed path component is exactly '..'
            // eslint-disable-next-line no-mixed-operators
            || preDotState === 1 && startDot === end - 1 && startDot === startPart + 1) {
            if (end !== -1) {
                if (startPart === 0 && isAbsolute)
                    { ret.base = ret.name = path.slice(1, end); }
                else
                    { ret.base = ret.name = path.slice(startPart, end); }
            }
        }
        else {
            if (startPart === 0 && isAbsolute) {
                ret.name = path.slice(1, startDot);
                ret.base = path.slice(1, end);
            }
            else {
                ret.name = path.slice(startPart, startDot);
                ret.base = path.slice(startPart, end);
            }
            ret.ext = path.slice(startDot, end);
        }
        ret.dir = this.dirname(path);
        return ret;
    },
    sep: '/',
    delimiter: ':'
};

/**
 * The prefix that denotes a URL is for a retina asset.
 * @static
 * @name RETINA_PREFIX
 * @memberof PIXI.settings
 * @type {RegExp}
 * @default /@([0-9\.]+)x/
 * @example `@2x`
 */
settings.settings.RETINA_PREFIX = /@([0-9\.]+)x/;
/**
 * Should the `failIfMajorPerformanceCaveat` flag be enabled as a context option used in the `isWebGLSupported` function.
 * If set to true, a WebGL renderer can fail to be created if the browser thinks there could be performance issues when
 * using WebGL.
 *
 * In PixiJS v6 this has changed from true to false by default, to allow WebGL to work in as many scenarios as possible.
 * However, some users may have a poor experience, for example, if a user has a gpu or driver version blacklisted by the
 * browser.
 *
 * If your application requires high performance rendering, you may wish to set this to false.
 * We recommend one of two options if you decide to set this flag to false:
 *
 * 1: Use the `pixi.js-legacy` package, which includes a Canvas renderer as a fallback in case high performance WebGL is
 *    not supported.
 *
 * 2: Call `isWebGLSupported` (which if found in the PIXI.utils package) in your code before attempting to create a PixiJS
 *    renderer, and show an error message to the user if the function returns false, explaining that their device & browser
 *    combination does not support high performance WebGL.
 *    This is a much better strategy than trying to create a PixiJS renderer and finding it then fails.
 * @static
 * @name FAIL_IF_MAJOR_PERFORMANCE_CAVEAT
 * @memberof PIXI.settings
 * @type {boolean}
 * @default false
 */
settings.settings.FAIL_IF_MAJOR_PERFORMANCE_CAVEAT = false;

var saidHello = false;
var VERSION = '6.5.2';
/**
 * Skips the hello message of renderers that are created after this is run.
 * @function skipHello
 * @memberof PIXI.utils
 */
function skipHello() {
    saidHello = true;
}
/**
 * Logs out the version and renderer information for this running instance of PIXI.
 * If you don't want to see this message you can run `PIXI.utils.skipHello()` before
 * creating your renderer. Keep in mind that doing that will forever make you a jerk face.
 * @static
 * @function sayHello
 * @memberof PIXI.utils
 * @param {string} type - The string renderer type to log.
 */
function sayHello(type) {
    var _a;
    if (saidHello) {
        return;
    }
    if (settings.settings.ADAPTER.getNavigator().userAgent.toLowerCase().indexOf('chrome') > -1) {
        var args = [
            "\n %c %c %c PixiJS " + VERSION + " - \u2730 " + type + " \u2730  %c  %c  http://www.pixijs.com/  %c %c \u2665%c\u2665%c\u2665 \n\n",
            'background: #ff66a5; padding:5px 0;',
            'background: #ff66a5; padding:5px 0;',
            'color: #ff66a5; background: #030307; padding:5px 0;',
            'background: #ff66a5; padding:5px 0;',
            'background: #ffc3dc; padding:5px 0;',
            'background: #ff66a5; padding:5px 0;',
            'color: #ff2424; background: #fff; padding:5px 0;',
            'color: #ff2424; background: #fff; padding:5px 0;',
            'color: #ff2424; background: #fff; padding:5px 0;' ];
        (_a = globalThis.console).log.apply(_a, args);
    }
    else if (globalThis.console) {
        globalThis.console.log("PixiJS " + VERSION + " - " + type + " - http://www.pixijs.com/");
    }
    saidHello = true;
}

var supported;
/**
 * Helper for checking for WebGL support.
 * @memberof PIXI.utils
 * @function isWebGLSupported
 * @returns {boolean} Is WebGL supported.
 */
function isWebGLSupported() {
    if (typeof supported === 'undefined') {
        supported = (function supported() {
            var contextOptions = {
                stencil: true,
                failIfMajorPerformanceCaveat: settings.settings.FAIL_IF_MAJOR_PERFORMANCE_CAVEAT,
            };
            try {
                if (!settings.settings.ADAPTER.getWebGLRenderingContext()) {
                    return false;
                }
                var canvas = settings.settings.ADAPTER.createCanvas();
                var gl = (canvas.getContext('webgl', contextOptions)
                    || canvas.getContext('experimental-webgl', contextOptions));
                var success = !!(gl && gl.getContextAttributes().stencil);
                if (gl) {
                    var loseContext = gl.getExtension('WEBGL_lose_context');
                    if (loseContext) {
                        loseContext.loseContext();
                    }
                }
                gl = null;
                return success;
            }
            catch (e) {
                return false;
            }
        })();
    }
    return supported;
}

var aliceblue = "#f0f8ff";
var antiquewhite = "#faebd7";
var aqua = "#00ffff";
var aquamarine = "#7fffd4";
var azure = "#f0ffff";
var beige = "#f5f5dc";
var bisque = "#ffe4c4";
var black = "#000000";
var blanchedalmond = "#ffebcd";
var blue = "#0000ff";
var blueviolet = "#8a2be2";
var brown = "#a52a2a";
var burlywood = "#deb887";
var cadetblue = "#5f9ea0";
var chartreuse = "#7fff00";
var chocolate = "#d2691e";
var coral = "#ff7f50";
var cornflowerblue = "#6495ed";
var cornsilk = "#fff8dc";
var crimson = "#dc143c";
var cyan = "#00ffff";
var darkblue = "#00008b";
var darkcyan = "#008b8b";
var darkgoldenrod = "#b8860b";
var darkgray = "#a9a9a9";
var darkgreen = "#006400";
var darkgrey = "#a9a9a9";
var darkkhaki = "#bdb76b";
var darkmagenta = "#8b008b";
var darkolivegreen = "#556b2f";
var darkorange = "#ff8c00";
var darkorchid = "#9932cc";
var darkred = "#8b0000";
var darksalmon = "#e9967a";
var darkseagreen = "#8fbc8f";
var darkslateblue = "#483d8b";
var darkslategray = "#2f4f4f";
var darkslategrey = "#2f4f4f";
var darkturquoise = "#00ced1";
var darkviolet = "#9400d3";
var deeppink = "#ff1493";
var deepskyblue = "#00bfff";
var dimgray = "#696969";
var dimgrey = "#696969";
var dodgerblue = "#1e90ff";
var firebrick = "#b22222";
var floralwhite = "#fffaf0";
var forestgreen = "#228b22";
var fuchsia = "#ff00ff";
var gainsboro = "#dcdcdc";
var ghostwhite = "#f8f8ff";
var goldenrod = "#daa520";
var gold = "#ffd700";
var gray = "#808080";
var green = "#008000";
var greenyellow = "#adff2f";
var grey = "#808080";
var honeydew = "#f0fff0";
var hotpink = "#ff69b4";
var indianred = "#cd5c5c";
var indigo = "#4b0082";
var ivory = "#fffff0";
var khaki = "#f0e68c";
var lavenderblush = "#fff0f5";
var lavender = "#e6e6fa";
var lawngreen = "#7cfc00";
var lemonchiffon = "#fffacd";
var lightblue = "#add8e6";
var lightcoral = "#f08080";
var lightcyan = "#e0ffff";
var lightgoldenrodyellow = "#fafad2";
var lightgray = "#d3d3d3";
var lightgreen = "#90ee90";
var lightgrey = "#d3d3d3";
var lightpink = "#ffb6c1";
var lightsalmon = "#ffa07a";
var lightseagreen = "#20b2aa";
var lightskyblue = "#87cefa";
var lightslategray = "#778899";
var lightslategrey = "#778899";
var lightsteelblue = "#b0c4de";
var lightyellow = "#ffffe0";
var lime = "#00ff00";
var limegreen = "#32cd32";
var linen = "#faf0e6";
var magenta = "#ff00ff";
var maroon = "#800000";
var mediumaquamarine = "#66cdaa";
var mediumblue = "#0000cd";
var mediumorchid = "#ba55d3";
var mediumpurple = "#9370db";
var mediumseagreen = "#3cb371";
var mediumslateblue = "#7b68ee";
var mediumspringgreen = "#00fa9a";
var mediumturquoise = "#48d1cc";
var mediumvioletred = "#c71585";
var midnightblue = "#191970";
var mintcream = "#f5fffa";
var mistyrose = "#ffe4e1";
var moccasin = "#ffe4b5";
var navajowhite = "#ffdead";
var navy = "#000080";
var oldlace = "#fdf5e6";
var olive = "#808000";
var olivedrab = "#6b8e23";
var orange = "#ffa500";
var orangered = "#ff4500";
var orchid = "#da70d6";
var palegoldenrod = "#eee8aa";
var palegreen = "#98fb98";
var paleturquoise = "#afeeee";
var palevioletred = "#db7093";
var papayawhip = "#ffefd5";
var peachpuff = "#ffdab9";
var peru = "#cd853f";
var pink = "#ffc0cb";
var plum = "#dda0dd";
var powderblue = "#b0e0e6";
var purple = "#800080";
var rebeccapurple = "#663399";
var red = "#ff0000";
var rosybrown = "#bc8f8f";
var royalblue = "#4169e1";
var saddlebrown = "#8b4513";
var salmon = "#fa8072";
var sandybrown = "#f4a460";
var seagreen = "#2e8b57";
var seashell = "#fff5ee";
var sienna = "#a0522d";
var silver = "#c0c0c0";
var skyblue = "#87ceeb";
var slateblue = "#6a5acd";
var slategray = "#708090";
var slategrey = "#708090";
var snow = "#fffafa";
var springgreen = "#00ff7f";
var steelblue = "#4682b4";
var tan = "#d2b48c";
var teal = "#008080";
var thistle = "#d8bfd8";
var tomato = "#ff6347";
var turquoise = "#40e0d0";
var violet = "#ee82ee";
var wheat = "#f5deb3";
var white = "#ffffff";
var whitesmoke = "#f5f5f5";
var yellow = "#ffff00";
var yellowgreen = "#9acd32";
var cssColorNames = {
	aliceblue: aliceblue,
	antiquewhite: antiquewhite,
	aqua: aqua,
	aquamarine: aquamarine,
	azure: azure,
	beige: beige,
	bisque: bisque,
	black: black,
	blanchedalmond: blanchedalmond,
	blue: blue,
	blueviolet: blueviolet,
	brown: brown,
	burlywood: burlywood,
	cadetblue: cadetblue,
	chartreuse: chartreuse,
	chocolate: chocolate,
	coral: coral,
	cornflowerblue: cornflowerblue,
	cornsilk: cornsilk,
	crimson: crimson,
	cyan: cyan,
	darkblue: darkblue,
	darkcyan: darkcyan,
	darkgoldenrod: darkgoldenrod,
	darkgray: darkgray,
	darkgreen: darkgreen,
	darkgrey: darkgrey,
	darkkhaki: darkkhaki,
	darkmagenta: darkmagenta,
	darkolivegreen: darkolivegreen,
	darkorange: darkorange,
	darkorchid: darkorchid,
	darkred: darkred,
	darksalmon: darksalmon,
	darkseagreen: darkseagreen,
	darkslateblue: darkslateblue,
	darkslategray: darkslategray,
	darkslategrey: darkslategrey,
	darkturquoise: darkturquoise,
	darkviolet: darkviolet,
	deeppink: deeppink,
	deepskyblue: deepskyblue,
	dimgray: dimgray,
	dimgrey: dimgrey,
	dodgerblue: dodgerblue,
	firebrick: firebrick,
	floralwhite: floralwhite,
	forestgreen: forestgreen,
	fuchsia: fuchsia,
	gainsboro: gainsboro,
	ghostwhite: ghostwhite,
	goldenrod: goldenrod,
	gold: gold,
	gray: gray,
	green: green,
	greenyellow: greenyellow,
	grey: grey,
	honeydew: honeydew,
	hotpink: hotpink,
	indianred: indianred,
	indigo: indigo,
	ivory: ivory,
	khaki: khaki,
	lavenderblush: lavenderblush,
	lavender: lavender,
	lawngreen: lawngreen,
	lemonchiffon: lemonchiffon,
	lightblue: lightblue,
	lightcoral: lightcoral,
	lightcyan: lightcyan,
	lightgoldenrodyellow: lightgoldenrodyellow,
	lightgray: lightgray,
	lightgreen: lightgreen,
	lightgrey: lightgrey,
	lightpink: lightpink,
	lightsalmon: lightsalmon,
	lightseagreen: lightseagreen,
	lightskyblue: lightskyblue,
	lightslategray: lightslategray,
	lightslategrey: lightslategrey,
	lightsteelblue: lightsteelblue,
	lightyellow: lightyellow,
	lime: lime,
	limegreen: limegreen,
	linen: linen,
	magenta: magenta,
	maroon: maroon,
	mediumaquamarine: mediumaquamarine,
	mediumblue: mediumblue,
	mediumorchid: mediumorchid,
	mediumpurple: mediumpurple,
	mediumseagreen: mediumseagreen,
	mediumslateblue: mediumslateblue,
	mediumspringgreen: mediumspringgreen,
	mediumturquoise: mediumturquoise,
	mediumvioletred: mediumvioletred,
	midnightblue: midnightblue,
	mintcream: mintcream,
	mistyrose: mistyrose,
	moccasin: moccasin,
	navajowhite: navajowhite,
	navy: navy,
	oldlace: oldlace,
	olive: olive,
	olivedrab: olivedrab,
	orange: orange,
	orangered: orangered,
	orchid: orchid,
	palegoldenrod: palegoldenrod,
	palegreen: palegreen,
	paleturquoise: paleturquoise,
	palevioletred: palevioletred,
	papayawhip: papayawhip,
	peachpuff: peachpuff,
	peru: peru,
	pink: pink,
	plum: plum,
	powderblue: powderblue,
	purple: purple,
	rebeccapurple: rebeccapurple,
	red: red,
	rosybrown: rosybrown,
	royalblue: royalblue,
	saddlebrown: saddlebrown,
	salmon: salmon,
	sandybrown: sandybrown,
	seagreen: seagreen,
	seashell: seashell,
	sienna: sienna,
	silver: silver,
	skyblue: skyblue,
	slateblue: slateblue,
	slategray: slategray,
	slategrey: slategrey,
	snow: snow,
	springgreen: springgreen,
	steelblue: steelblue,
	tan: tan,
	teal: teal,
	thistle: thistle,
	tomato: tomato,
	turquoise: turquoise,
	violet: violet,
	wheat: wheat,
	white: white,
	whitesmoke: whitesmoke,
	yellow: yellow,
	yellowgreen: yellowgreen
};

/**
 * Converts a hexadecimal color number to an [R, G, B] array of normalized floats (numbers from 0.0 to 1.0).
 * @example
 * PIXI.utils.hex2rgb(0xffffff); // returns [1, 1, 1]
 * @memberof PIXI.utils
 * @function hex2rgb
 * @param {number} hex - The hexadecimal number to convert
 * @param  {number[]} [out=[]] - If supplied, this array will be used rather than returning a new one
 * @returns {number[]} An array representing the [R, G, B] of the color where all values are floats.
 */
function hex2rgb(hex, out) {
    if (out === void 0) { out = []; }
    out[0] = ((hex >> 16) & 0xFF) / 255;
    out[1] = ((hex >> 8) & 0xFF) / 255;
    out[2] = (hex & 0xFF) / 255;
    return out;
}
/**
 * Converts a hexadecimal color number to a string.
 * @example
 * PIXI.utils.hex2string(0xffffff); // returns "#ffffff"
 * @memberof PIXI.utils
 * @function hex2string
 * @param {number} hex - Number in hex (e.g., `0xffffff`)
 * @returns {string} The string color (e.g., `"#ffffff"`).
 */
function hex2string(hex) {
    var hexString = hex.toString(16);
    hexString = '000000'.substring(0, 6 - hexString.length) + hexString;
    return "#" + hexString;
}
/**
 * Converts a string to a hexadecimal color number.
 * It can handle:
 *  hex strings starting with #: "#ffffff"
 *  hex strings starting with 0x: "0xffffff"
 *  hex strings without prefix: "ffffff"
 *  css colors: "black"
 * @example
 * PIXI.utils.string2hex("#ffffff"); // returns 0xffffff
 * @memberof PIXI.utils
 * @function string2hex
 * @param {string} string - The string color (e.g., `"#ffffff"`)
 * @returns {number} Number in hexadecimal.
 */
function string2hex(string) {
    if (typeof string === 'string') {
        string = cssColorNames[string.toLowerCase()] || string;
        if (string[0] === '#') {
            string = string.slice(1);
        }
    }
    return parseInt(string, 16);
}
/**
 * Converts a color as an [R, G, B] array of normalized floats to a hexadecimal number.
 * @example
 * PIXI.utils.rgb2hex([1, 1, 1]); // returns 0xffffff
 * @memberof PIXI.utils
 * @function rgb2hex
 * @param {number[]} rgb - Array of numbers where all values are normalized floats from 0.0 to 1.0.
 * @returns {number} Number in hexadecimal.
 */
function rgb2hex(rgb) {
    return (((rgb[0] * 255) << 16) + ((rgb[1] * 255) << 8) + (rgb[2] * 255 | 0));
}

/**
 * Corrects PixiJS blend, takes premultiplied alpha into account
 * @memberof PIXI.utils
 * @function mapPremultipliedBlendModes
 * @private
 * @returns {Array<number[]>} Mapped modes.
 */
function mapPremultipliedBlendModes() {
    var pm = [];
    var npm = [];
    for (var i = 0; i < 32; i++) {
        pm[i] = i;
        npm[i] = i;
    }
    pm[constants.BLEND_MODES.NORMAL_NPM] = constants.BLEND_MODES.NORMAL;
    pm[constants.BLEND_MODES.ADD_NPM] = constants.BLEND_MODES.ADD;
    pm[constants.BLEND_MODES.SCREEN_NPM] = constants.BLEND_MODES.SCREEN;
    npm[constants.BLEND_MODES.NORMAL] = constants.BLEND_MODES.NORMAL_NPM;
    npm[constants.BLEND_MODES.ADD] = constants.BLEND_MODES.ADD_NPM;
    npm[constants.BLEND_MODES.SCREEN] = constants.BLEND_MODES.SCREEN_NPM;
    var array = [];
    array.push(npm);
    array.push(pm);
    return array;
}
/**
 * maps premultiply flag and blendMode to adjusted blendMode
 * @memberof PIXI.utils
 * @constant premultiplyBlendMode
 * @type {Array<number[]>}
 */
var premultiplyBlendMode = mapPremultipliedBlendModes();
/**
 * changes blendMode according to texture format
 * @memberof PIXI.utils
 * @function correctBlendMode
 * @param {number} blendMode - supposed blend mode
 * @param {boolean} premultiplied - whether source is premultiplied
 * @returns {number} true blend mode for this texture
 */
function correctBlendMode(blendMode, premultiplied) {
    return premultiplyBlendMode[premultiplied ? 1 : 0][blendMode];
}
/**
 * combines rgb and alpha to out array
 * @memberof PIXI.utils
 * @function premultiplyRgba
 * @param {Float32Array|number[]} rgb - input rgb
 * @param {number} alpha - alpha param
 * @param {Float32Array} [out] - output
 * @param {boolean} [premultiply=true] - do premultiply it
 * @returns {Float32Array} vec4 rgba
 */
function premultiplyRgba(rgb, alpha, out, premultiply) {
    out = out || new Float32Array(4);
    if (premultiply || premultiply === undefined) {
        out[0] = rgb[0] * alpha;
        out[1] = rgb[1] * alpha;
        out[2] = rgb[2] * alpha;
    }
    else {
        out[0] = rgb[0];
        out[1] = rgb[1];
        out[2] = rgb[2];
    }
    out[3] = alpha;
    return out;
}
/**
 * premultiplies tint
 * @memberof PIXI.utils
 * @function premultiplyTint
 * @param {number} tint - integer RGB
 * @param {number} alpha - floating point alpha (0.0-1.0)
 * @returns {number} tint multiplied by alpha
 */
function premultiplyTint(tint, alpha) {
    if (alpha === 1.0) {
        return (alpha * 255 << 24) + tint;
    }
    if (alpha === 0.0) {
        return 0;
    }
    var R = ((tint >> 16) & 0xFF);
    var G = ((tint >> 8) & 0xFF);
    var B = (tint & 0xFF);
    R = ((R * alpha) + 0.5) | 0;
    G = ((G * alpha) + 0.5) | 0;
    B = ((B * alpha) + 0.5) | 0;
    return (alpha * 255 << 24) + (R << 16) + (G << 8) + B;
}
/**
 * converts integer tint and float alpha to vec4 form, premultiplies by default
 * @memberof PIXI.utils
 * @function premultiplyTintToRgba
 * @param {number} tint - input tint
 * @param {number} alpha - alpha param
 * @param {Float32Array} [out] - output
 * @param {boolean} [premultiply=true] - do premultiply it
 * @returns {Float32Array} vec4 rgba
 */
function premultiplyTintToRgba(tint, alpha, out, premultiply) {
    out = out || new Float32Array(4);
    out[0] = ((tint >> 16) & 0xFF) / 255.0;
    out[1] = ((tint >> 8) & 0xFF) / 255.0;
    out[2] = (tint & 0xFF) / 255.0;
    if (premultiply || premultiply === undefined) {
        out[0] *= alpha;
        out[1] *= alpha;
        out[2] *= alpha;
    }
    out[3] = alpha;
    return out;
}

/**
 * Generic Mask Stack data structure
 * @memberof PIXI.utils
 * @function createIndicesForQuads
 * @param {number} size - Number of quads
 * @param {Uint16Array|Uint32Array} [outBuffer] - Buffer for output, length has to be `6 * size`
 * @returns {Uint16Array|Uint32Array} - Resulting index buffer
 */
function createIndicesForQuads(size, outBuffer) {
    if (outBuffer === void 0) { outBuffer = null; }
    // the total number of indices in our array, there are 6 points per quad.
    var totalIndices = size * 6;
    outBuffer = outBuffer || new Uint16Array(totalIndices);
    if (outBuffer.length !== totalIndices) {
        throw new Error("Out buffer length is incorrect, got " + outBuffer.length + " and expected " + totalIndices);
    }
    // fill the indices with the quads to draw
    for (var i = 0, j = 0; i < totalIndices; i += 6, j += 4) {
        outBuffer[i + 0] = j + 0;
        outBuffer[i + 1] = j + 1;
        outBuffer[i + 2] = j + 2;
        outBuffer[i + 3] = j + 0;
        outBuffer[i + 4] = j + 2;
        outBuffer[i + 5] = j + 3;
    }
    return outBuffer;
}

function getBufferType(array) {
    if (array.BYTES_PER_ELEMENT === 4) {
        if (array instanceof Float32Array) {
            return 'Float32Array';
        }
        else if (array instanceof Uint32Array) {
            return 'Uint32Array';
        }
        return 'Int32Array';
    }
    else if (array.BYTES_PER_ELEMENT === 2) {
        if (array instanceof Uint16Array) {
            return 'Uint16Array';
        }
    }
    else if (array.BYTES_PER_ELEMENT === 1) {
        if (array instanceof Uint8Array) {
            return 'Uint8Array';
        }
    }
    // TODO map out the rest of the array elements!
    return null;
}

/* eslint-disable object-shorthand */
var map = { Float32Array: Float32Array, Uint32Array: Uint32Array, Int32Array: Int32Array, Uint8Array: Uint8Array };
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
        /*
        @todo This is unsafe casting but consistent with how the code worked previously. Should it stay this way
              or should and `getBufferTypeUnsafe` function be exposed that throws an Error if unsupported type is passed?
         */
        var type = getBufferType(array);
        if (!views[type]) {
            views[type] = new map[type](buffer);
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

// Taken from the bit-twiddle package
/**
 * Rounds to next power of two.
 * @function nextPow2
 * @memberof PIXI.utils
 * @param {number} v - input value
 * @returns {number} - next rounded power of two
 */
function nextPow2(v) {
    v += v === 0 ? 1 : 0;
    --v;
    v |= v >>> 1;
    v |= v >>> 2;
    v |= v >>> 4;
    v |= v >>> 8;
    v |= v >>> 16;
    return v + 1;
}
/**
 * Checks if a number is a power of two.
 * @function isPow2
 * @memberof PIXI.utils
 * @param {number} v - input value
 * @returns {boolean} `true` if value is power of two
 */
function isPow2(v) {
    return !(v & (v - 1)) && (!!v);
}
/**
 * Computes ceil of log base 2
 * @function log2
 * @memberof PIXI.utils
 * @param {number} v - input value
 * @returns {number} logarithm base 2
 */
function log2(v) {
    var r = (v > 0xFFFF ? 1 : 0) << 4;
    v >>>= r;
    var shift = (v > 0xFF ? 1 : 0) << 3;
    v >>>= shift;
    r |= shift;
    shift = (v > 0xF ? 1 : 0) << 2;
    v >>>= shift;
    r |= shift;
    shift = (v > 0x3 ? 1 : 0) << 1;
    v >>>= shift;
    r |= shift;
    return r | (v >> 1);
}

/**
 * Remove items from a javascript array without generating garbage
 * @function removeItems
 * @memberof PIXI.utils
 * @param {Array<any>} arr - Array to remove elements from
 * @param {number} startIdx - starting index
 * @param {number} removeCount - how many to remove
 */
function removeItems(arr, startIdx, removeCount) {
    var length = arr.length;
    var i;
    if (startIdx >= length || removeCount === 0) {
        return;
    }
    removeCount = (startIdx + removeCount > length ? length - startIdx : removeCount);
    var len = length - removeCount;
    for (i = startIdx; i < len; ++i) {
        arr[i] = arr[i + removeCount];
    }
    arr.length = len;
}

/**
 * Returns sign of number
 * @memberof PIXI.utils
 * @function sign
 * @param {number} n - the number to check the sign of
 * @returns {number} 0 if `n` is 0, -1 if `n` is negative, 1 if `n` is positive
 */
function sign(n) {
    if (n === 0)
        { return 0; }
    return n < 0 ? -1 : 1;
}

var nextUid = 0;
/**
 * Gets the next unique identifier
 * @memberof PIXI.utils
 * @function uid
 * @returns {number} The next unique identifier to use.
 */
function uid() {
    return ++nextUid;
}

// A map of warning messages already fired
var warnings = {};
/**
 * Helper for warning developers about deprecated features & settings.
 * A stack track for warnings is given; useful for tracking-down where
 * deprecated methods/properties/classes are being used within the code.
 * @memberof PIXI.utils
 * @function deprecation
 * @param {string} version - The version where the feature became deprecated
 * @param {string} message - Message should include what is deprecated, where, and the new solution
 * @param {number} [ignoreDepth=3] - The number of steps to ignore at the top of the error stack
 *        this is mostly to ignore internal deprecation calls.
 */
function deprecation(version, message, ignoreDepth) {
    if (ignoreDepth === void 0) { ignoreDepth = 3; }
    // Ignore duplicat
    if (warnings[message]) {
        return;
    }
    /* eslint-disable no-console */
    var stack = new Error().stack;
    // Handle IE < 10 and Safari < 6
    if (typeof stack === 'undefined') {
        console.warn('PixiJS Deprecation Warning: ', message + "\nDeprecated since v" + version);
    }
    else {
        // chop off the stack trace which includes PixiJS internal calls
        stack = stack.split('\n').splice(ignoreDepth).join('\n');
        if (console.groupCollapsed) {
            console.groupCollapsed('%cPixiJS Deprecation Warning: %c%s', 'color:#614108;background:#fffbe6', 'font-weight:normal;color:#614108;background:#fffbe6', message + "\nDeprecated since v" + version);
            console.warn(stack);
            console.groupEnd();
        }
        else {
            console.warn('PixiJS Deprecation Warning: ', message + "\nDeprecated since v" + version);
            console.warn(stack);
        }
    }
    /* eslint-enable no-console */
    warnings[message] = true;
}

/**
 * @todo Describe property usage
 * @static
 * @name ProgramCache
 * @memberof PIXI.utils
 * @type {object}
 */
var ProgramCache = {};
/**
 * @todo Describe property usage
 * @static
 * @name TextureCache
 * @memberof PIXI.utils
 * @type {object}
 */
var TextureCache = Object.create(null);
/**
 * @todo Describe property usage
 * @static
 * @name BaseTextureCache
 * @memberof PIXI.utils
 * @type {object}
 */
var BaseTextureCache = Object.create(null);
/**
 * Destroys all texture in the cache
 * @memberof PIXI.utils
 * @function destroyTextureCache
 */
function destroyTextureCache() {
    var key;
    for (key in TextureCache) {
        TextureCache[key].destroy();
    }
    for (key in BaseTextureCache) {
        BaseTextureCache[key].destroy();
    }
}
/**
 * Removes all textures from cache, but does not destroy them
 * @memberof PIXI.utils
 * @function clearTextureCache
 */
function clearTextureCache() {
    var key;
    for (key in TextureCache) {
        delete TextureCache[key];
    }
    for (key in BaseTextureCache) {
        delete BaseTextureCache[key];
    }
}

/**
 * Creates a Canvas element of the given size to be used as a target for rendering to.
 * @class
 * @memberof PIXI.utils
 */
var CanvasRenderTarget = /** @class */ (function () {
    /**
     * @param width - the width for the newly created canvas
     * @param height - the height for the newly created canvas
     * @param {number} [resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio of the canvas
     */
    function CanvasRenderTarget(width, height, resolution) {
        this.canvas = settings.settings.ADAPTER.createCanvas();
        this.context = this.canvas.getContext('2d');
        this.resolution = resolution || settings.settings.RESOLUTION;
        this.resize(width, height);
    }
    /**
     * Clears the canvas that was created by the CanvasRenderTarget class.
     * @private
     */
    CanvasRenderTarget.prototype.clear = function () {
        this.context.setTransform(1, 0, 0, 1, 0, 0);
        this.context.clearRect(0, 0, this.canvas.width, this.canvas.height);
    };
    /**
     * Resizes the canvas to the specified width and height.
     * @param desiredWidth - the desired width of the canvas
     * @param desiredHeight - the desired height of the canvas
     */
    CanvasRenderTarget.prototype.resize = function (desiredWidth, desiredHeight) {
        this.canvas.width = Math.round(desiredWidth * this.resolution);
        this.canvas.height = Math.round(desiredHeight * this.resolution);
    };
    /** Destroys this canvas. */
    CanvasRenderTarget.prototype.destroy = function () {
        this.context = null;
        this.canvas = null;
    };
    Object.defineProperty(CanvasRenderTarget.prototype, "width", {
        /**
         * The width of the canvas buffer in pixels.
         * @member {number}
         */
        get: function () {
            return this.canvas.width;
        },
        set: function (val) {
            this.canvas.width = Math.round(val);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(CanvasRenderTarget.prototype, "height", {
        /**
         * The height of the canvas buffer in pixels.
         * @member {number}
         */
        get: function () {
            return this.canvas.height;
        },
        set: function (val) {
            this.canvas.height = Math.round(val);
        },
        enumerable: false,
        configurable: true
    });
    return CanvasRenderTarget;
}());

/**
 * Trim transparent borders from a canvas
 * @memberof PIXI.utils
 * @function trimCanvas
 * @param {HTMLCanvasElement} canvas - the canvas to trim
 * @returns {object} Trim data
 */
function trimCanvas(canvas) {
    // https://gist.github.com/remy/784508
    var width = canvas.width;
    var height = canvas.height;
    var context = canvas.getContext('2d');
    var imageData = context.getImageData(0, 0, width, height);
    var pixels = imageData.data;
    var len = pixels.length;
    var bound = {
        top: null,
        left: null,
        right: null,
        bottom: null,
    };
    var data = null;
    var i;
    var x;
    var y;
    for (i = 0; i < len; i += 4) {
        if (pixels[i + 3] !== 0) {
            x = (i / 4) % width;
            y = ~~((i / 4) / width);
            if (bound.top === null) {
                bound.top = y;
            }
            if (bound.left === null) {
                bound.left = x;
            }
            else if (x < bound.left) {
                bound.left = x;
            }
            if (bound.right === null) {
                bound.right = x + 1;
            }
            else if (bound.right < x) {
                bound.right = x + 1;
            }
            if (bound.bottom === null) {
                bound.bottom = y;
            }
            else if (bound.bottom < y) {
                bound.bottom = y;
            }
        }
    }
    if (bound.top !== null) {
        width = bound.right - bound.left;
        height = bound.bottom - bound.top + 1;
        data = context.getImageData(bound.left, bound.top, width, height);
    }
    return {
        height: height,
        width: width,
        data: data,
    };
}

/**
 * Regexp for data URI.
 * Based on: {@link https://github.com/ragingwind/data-uri-regex}
 * @static
 * @constant {RegExp|string} DATA_URI
 * @memberof PIXI
 * @example data:image/png;base64
 */
var DATA_URI = /^\s*data:(?:([\w-]+)\/([\w+.-]+))?(?:;charset=([\w-]+))?(?:;(base64))?,(.*)/i;

/**
 * @memberof PIXI.utils
 * @interface DecomposedDataUri
 */
/**
 * type, eg. `image`
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} mediaType
 */
/**
 * Sub type, eg. `png`
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} subType
 */
/**
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} charset
 */
/**
 * Data encoding, eg. `base64`
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} encoding
 */
/**
 * The actual data
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} data
 */
/**
 * Split a data URI into components. Returns undefined if
 * parameter `dataUri` is not a valid data URI.
 * @memberof PIXI.utils
 * @function decomposeDataUri
 * @param {string} dataUri - the data URI to check
 * @returns {PIXI.utils.DecomposedDataUri|undefined} The decomposed data uri or undefined
 */
function decomposeDataUri(dataUri) {
    var dataUriMatch = DATA_URI.exec(dataUri);
    if (dataUriMatch) {
        return {
            mediaType: dataUriMatch[1] ? dataUriMatch[1].toLowerCase() : undefined,
            subType: dataUriMatch[2] ? dataUriMatch[2].toLowerCase() : undefined,
            charset: dataUriMatch[3] ? dataUriMatch[3].toLowerCase() : undefined,
            encoding: dataUriMatch[4] ? dataUriMatch[4].toLowerCase() : undefined,
            data: dataUriMatch[5],
        };
    }
    return undefined;
}

var tempAnchor;
/**
 * Sets the `crossOrigin` property for this resource based on if the url
 * for this resource is cross-origin. If crossOrigin was manually set, this
 * function does nothing.
 * Nipped from the resource loader!
 * @ignore
 * @param {string} url - The url to test.
 * @param {object} [loc=window.location] - The location object to test against.
 * @returns {string} The crossOrigin value to use (or empty string for none).
 */
function determineCrossOrigin(url$1, loc) {
    if (loc === void 0) { loc = globalThis.location; }
    // data: and javascript: urls are considered same-origin
    if (url$1.indexOf('data:') === 0) {
        return '';
    }
    // default is window.location
    loc = loc || globalThis.location;
    if (!tempAnchor) {
        tempAnchor = document.createElement('a');
    }
    // let the browser determine the full href for the url of this resource and then
    // parse with the node url lib, we can't use the properties of the anchor element
    // because they don't work in IE9 :(
    tempAnchor.href = url$1;
    var parsedUrl = url.parse(tempAnchor.href);
    var samePort = (!parsedUrl.port && loc.port === '') || (parsedUrl.port === loc.port);
    // if cross origin
    if (parsedUrl.hostname !== loc.hostname || !samePort || parsedUrl.protocol !== loc.protocol) {
        return 'anonymous';
    }
    return '';
}

/**
 * get the resolution / device pixel ratio of an asset by looking for the prefix
 * used by spritesheets and image urls
 * @memberof PIXI.utils
 * @function getResolutionOfUrl
 * @param {string} url - the image path
 * @param {number} [defaultValue=1] - the defaultValue if no filename prefix is set.
 * @returns {number} resolution / device pixel ratio of an asset
 */
function getResolutionOfUrl(url, defaultValue) {
    var resolution = settings.settings.RETINA_PREFIX.exec(url);
    if (resolution) {
        return parseFloat(resolution[1]);
    }
    return defaultValue !== undefined ? defaultValue : 1;
}

Object.defineProperty(exports, 'isMobile', {
    enumerable: true,
    get: function () { return settings.isMobile; }
});
Object.defineProperty(exports, 'EventEmitter', {
    enumerable: true,
    get: function () { return eventemitter3__default["default"]; }
});
Object.defineProperty(exports, 'earcut', {
    enumerable: true,
    get: function () { return earcut__default["default"]; }
});
exports.BaseTextureCache = BaseTextureCache;
exports.CanvasRenderTarget = CanvasRenderTarget;
exports.DATA_URI = DATA_URI;
exports.ProgramCache = ProgramCache;
exports.TextureCache = TextureCache;
exports.clearTextureCache = clearTextureCache;
exports.correctBlendMode = correctBlendMode;
exports.createIndicesForQuads = createIndicesForQuads;
exports.decomposeDataUri = decomposeDataUri;
exports.deprecation = deprecation;
exports.destroyTextureCache = destroyTextureCache;
exports.determineCrossOrigin = determineCrossOrigin;
exports.getBufferType = getBufferType;
exports.getResolutionOfUrl = getResolutionOfUrl;
exports.hex2rgb = hex2rgb;
exports.hex2string = hex2string;
exports.interleaveTypedArrays = interleaveTypedArrays;
exports.isPow2 = isPow2;
exports.isWebGLSupported = isWebGLSupported;
exports.log2 = log2;
exports.nextPow2 = nextPow2;
exports.path = path;
exports.premultiplyBlendMode = premultiplyBlendMode;
exports.premultiplyRgba = premultiplyRgba;
exports.premultiplyTint = premultiplyTint;
exports.premultiplyTintToRgba = premultiplyTintToRgba;
exports.removeItems = removeItems;
exports.rgb2hex = rgb2hex;
exports.sayHello = sayHello;
exports.sign = sign;
exports.skipHello = skipHello;
exports.string2hex = string2hex;
exports.trimCanvas = trimCanvas;
exports.uid = uid;
exports.url = url;
//# sourceMappingURL=utils.js.map
