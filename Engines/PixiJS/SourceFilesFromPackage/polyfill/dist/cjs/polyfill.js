/*!
 * @pixi/polyfill - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/polyfill is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

var Polyfill = require('promise-polyfill');
var objectAssign = require('object-assign');

function _interopDefaultLegacy (e) { return e && typeof e === 'object' && 'default' in e ? e : { 'default': e }; }

var Polyfill__default = /*#__PURE__*/_interopDefaultLegacy(Polyfill);
var objectAssign__default = /*#__PURE__*/_interopDefaultLegacy(objectAssign);

if (typeof globalThis === 'undefined') {
    if (typeof self !== 'undefined') {
        // covers browsers
        // @ts-expect-error not-writable ts(2540) error only on node
        self.globalThis = self;
    }
    else if (typeof global !== 'undefined') {
        // covers versions of Node < 12
        // @ts-expect-error not-writable ts(2540) error only on node
        global.globalThis = global;
    }
}

// Support for IE 9 - 11 which does not include Promises
if (!globalThis.Promise) {
    globalThis.Promise = Polyfill__default["default"];
}

// References:
if (!Object.assign) {
    Object.assign = objectAssign__default["default"];
}

// References:
// http://paulirish.com/2011/requestanimationframe-for-smart-animating/
// https://gist.github.com/1579671
// http://updates.html5rocks.com/2012/05/requestAnimationFrame-API-now-with-sub-millisecond-precision
// https://gist.github.com/timhall/4078614
// https://github.com/Financial-Times/polyfill-service/tree/master/polyfills/requestAnimationFrame
// Expected to be used with Browserfiy
// Browserify automatically detects the use of `global` and passes the
// correct reference of `global`, `globalThis`, and finally `window`
var ONE_FRAME_TIME = 16;
// Date.now
if (!(Date.now && Date.prototype.getTime)) {
    Date.now = function now() {
        return new Date().getTime();
    };
}
// performance.now
if (!(globalThis.performance && globalThis.performance.now)) {
    var startTime_1 = Date.now();
    if (!globalThis.performance) {
        globalThis.performance = {};
    }
    globalThis.performance.now = function () { return Date.now() - startTime_1; };
}
// requestAnimationFrame
var lastTime = Date.now();
var vendors = ['ms', 'moz', 'webkit', 'o'];
for (var x = 0; x < vendors.length && !globalThis.requestAnimationFrame; ++x) {
    var p = vendors[x];
    globalThis.requestAnimationFrame = globalThis[p + "RequestAnimationFrame"];
    globalThis.cancelAnimationFrame = globalThis[p + "CancelAnimationFrame"]
        || globalThis[p + "CancelRequestAnimationFrame"];
}
if (!globalThis.requestAnimationFrame) {
    globalThis.requestAnimationFrame = function (callback) {
        if (typeof callback !== 'function') {
            throw new TypeError(callback + "is not a function");
        }
        var currentTime = Date.now();
        var delay = ONE_FRAME_TIME + lastTime - currentTime;
        if (delay < 0) {
            delay = 0;
        }
        lastTime = currentTime;
        return globalThis.self.setTimeout(function () {
            lastTime = Date.now();
            callback(performance.now());
        }, delay);
    };
}
if (!globalThis.cancelAnimationFrame) {
    globalThis.cancelAnimationFrame = function (id) { return clearTimeout(id); };
}

// References:
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Math/sign
if (!Math.sign) {
    Math.sign = function mathSign(x) {
        x = Number(x);
        if (x === 0 || isNaN(x)) {
            return x;
        }
        return x > 0 ? 1 : -1;
    };
}

// References:
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Number/isInteger
if (!Number.isInteger) {
    Number.isInteger = function numberIsInteger(value) {
        return typeof value === 'number' && isFinite(value) && Math.floor(value) === value;
    };
}

if (!globalThis.ArrayBuffer) {
    globalThis.ArrayBuffer = Array;
}
if (!globalThis.Float32Array) {
    globalThis.Float32Array = Array;
}
if (!globalThis.Uint32Array) {
    globalThis.Uint32Array = Array;
}
if (!globalThis.Uint16Array) {
    globalThis.Uint16Array = Array;
}
if (!globalThis.Uint8Array) {
    globalThis.Uint8Array = Array;
}
if (!globalThis.Int32Array) {
    globalThis.Int32Array = Array;
}
//# sourceMappingURL=polyfill.js.map
