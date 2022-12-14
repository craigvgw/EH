/*!
 * @pixi/filter-blur - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/filter-blur is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
this.PIXI.filters = this.PIXI.filters || {};
var _pixi_filter_blur = (function (exports, core, settings, constants) {
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

    var vertTemplate = "\n    attribute vec2 aVertexPosition;\n\n    uniform mat3 projectionMatrix;\n\n    uniform float strength;\n\n    varying vec2 vBlurTexCoords[%size%];\n\n    uniform vec4 inputSize;\n    uniform vec4 outputFrame;\n\n    vec4 filterVertexPosition( void )\n    {\n        vec2 position = aVertexPosition * max(outputFrame.zw, vec2(0.)) + outputFrame.xy;\n\n        return vec4((projectionMatrix * vec3(position, 1.0)).xy, 0.0, 1.0);\n    }\n\n    vec2 filterTextureCoord( void )\n    {\n        return aVertexPosition * (outputFrame.zw * inputSize.zw);\n    }\n\n    void main(void)\n    {\n        gl_Position = filterVertexPosition();\n\n        vec2 textureCoord = filterTextureCoord();\n        %blur%\n    }";
    function generateBlurVertSource(kernelSize, x) {
        var halfLength = Math.ceil(kernelSize / 2);
        var vertSource = vertTemplate;
        var blurLoop = '';
        var template;
        if (x) {
            template = 'vBlurTexCoords[%index%] =  textureCoord + vec2(%sampleIndex% * strength, 0.0);';
        }
        else {
            template = 'vBlurTexCoords[%index%] =  textureCoord + vec2(0.0, %sampleIndex% * strength);';
        }
        for (var i = 0; i < kernelSize; i++) {
            var blur = template.replace('%index%', i.toString());
            blur = blur.replace('%sampleIndex%', i - (halfLength - 1) + ".0");
            blurLoop += blur;
            blurLoop += '\n';
        }
        vertSource = vertSource.replace('%blur%', blurLoop);
        vertSource = vertSource.replace('%size%', kernelSize.toString());
        return vertSource;
    }

    var GAUSSIAN_VALUES = {
        5: [0.153388, 0.221461, 0.250301],
        7: [0.071303, 0.131514, 0.189879, 0.214607],
        9: [0.028532, 0.067234, 0.124009, 0.179044, 0.20236],
        11: [0.0093, 0.028002, 0.065984, 0.121703, 0.175713, 0.198596],
        13: [0.002406, 0.009255, 0.027867, 0.065666, 0.121117, 0.174868, 0.197641],
        15: [0.000489, 0.002403, 0.009246, 0.02784, 0.065602, 0.120999, 0.174697, 0.197448],
    };
    var fragTemplate = [
        'varying vec2 vBlurTexCoords[%size%];',
        'uniform sampler2D uSampler;',
        'void main(void)',
        '{',
        '    gl_FragColor = vec4(0.0);',
        '    %blur%',
        '}' ].join('\n');
    function generateBlurFragSource(kernelSize) {
        var kernel = GAUSSIAN_VALUES[kernelSize];
        var halfLength = kernel.length;
        var fragSource = fragTemplate;
        var blurLoop = '';
        var template = 'gl_FragColor += texture2D(uSampler, vBlurTexCoords[%index%]) * %value%;';
        var value;
        for (var i = 0; i < kernelSize; i++) {
            var blur = template.replace('%index%', i.toString());
            value = i;
            if (i >= halfLength) {
                value = kernelSize - i - 1;
            }
            blur = blur.replace('%value%', kernel[value].toString());
            blurLoop += blur;
            blurLoop += '\n';
        }
        fragSource = fragSource.replace('%blur%', blurLoop);
        fragSource = fragSource.replace('%size%', kernelSize.toString());
        return fragSource;
    }

    /**
     * The BlurFilterPass applies a horizontal or vertical Gaussian blur to an object.
     * @memberof PIXI.filters
     */
    var BlurFilterPass = /** @class */ (function (_super) {
        __extends(BlurFilterPass, _super);
        /**
         * @param horizontal - Do pass along the x-axis (`true`) or y-axis (`false`).
         * @param strength - The strength of the blur filter.
         * @param quality - The quality of the blur filter.
         * @param resolution - The resolution of the blur filter.
         * @param kernelSize - The kernelSize of the blur filter.Options: 5, 7, 9, 11, 13, 15.
         */
        function BlurFilterPass(horizontal, strength, quality, resolution, kernelSize) {
            if (strength === void 0) { strength = 8; }
            if (quality === void 0) { quality = 4; }
            if (resolution === void 0) { resolution = settings.settings.FILTER_RESOLUTION; }
            if (kernelSize === void 0) { kernelSize = 5; }
            var _this = this;
            var vertSrc = generateBlurVertSource(kernelSize, horizontal);
            var fragSrc = generateBlurFragSource(kernelSize);
            _this = _super.call(this, 
            // vertex shader
            vertSrc, 
            // fragment shader
            fragSrc) || this;
            _this.horizontal = horizontal;
            _this.resolution = resolution;
            _this._quality = 0;
            _this.quality = quality;
            _this.blur = strength;
            return _this;
        }
        /**
         * Applies the filter.
         * @param filterManager - The manager.
         * @param input - The input target.
         * @param output - The output target.
         * @param clearMode - How to clear
         */
        BlurFilterPass.prototype.apply = function (filterManager, input, output, clearMode) {
            if (output) {
                if (this.horizontal) {
                    this.uniforms.strength = (1 / output.width) * (output.width / input.width);
                }
                else {
                    this.uniforms.strength = (1 / output.height) * (output.height / input.height);
                }
            }
            else {
                if (this.horizontal) // eslint-disable-line
                 {
                    this.uniforms.strength = (1 / filterManager.renderer.width) * (filterManager.renderer.width / input.width);
                }
                else {
                    this.uniforms.strength = (1 / filterManager.renderer.height) * (filterManager.renderer.height / input.height); // eslint-disable-line
                }
            }
            // screen space!
            this.uniforms.strength *= this.strength;
            this.uniforms.strength /= this.passes;
            if (this.passes === 1) {
                filterManager.applyFilter(this, input, output, clearMode);
            }
            else {
                var renderTarget = filterManager.getFilterTexture();
                var renderer = filterManager.renderer;
                var flip = input;
                var flop = renderTarget;
                this.state.blend = false;
                filterManager.applyFilter(this, flip, flop, constants.CLEAR_MODES.CLEAR);
                for (var i = 1; i < this.passes - 1; i++) {
                    filterManager.bindAndClear(flip, constants.CLEAR_MODES.BLIT);
                    this.uniforms.uSampler = flop;
                    var temp = flop;
                    flop = flip;
                    flip = temp;
                    renderer.shader.bind(this);
                    renderer.geometry.draw(5);
                }
                this.state.blend = true;
                filterManager.applyFilter(this, flop, output, clearMode);
                filterManager.returnFilterTexture(renderTarget);
            }
        };
        Object.defineProperty(BlurFilterPass.prototype, "blur", {
            /**
             * Sets the strength of both the blur.
             * @default 16
             */
            get: function () {
                return this.strength;
            },
            set: function (value) {
                this.padding = 1 + (Math.abs(value) * 2);
                this.strength = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BlurFilterPass.prototype, "quality", {
            /**
             * Sets the quality of the blur by modifying the number of passes. More passes means higher
             * quality bluring but the lower the performance.
             * @default 4
             */
            get: function () {
                return this._quality;
            },
            set: function (value) {
                this._quality = value;
                this.passes = value;
            },
            enumerable: false,
            configurable: true
        });
        return BlurFilterPass;
    }(core.Filter));

    /**
     * The BlurFilter applies a Gaussian blur to an object.
     *
     * The strength of the blur can be set for the x-axis and y-axis separately.
     * @memberof PIXI.filters
     */
    var BlurFilter = /** @class */ (function (_super) {
        __extends(BlurFilter, _super);
        /**
         * @param strength - The strength of the blur filter.
         * @param quality - The quality of the blur filter.
         * @param [resolution=PIXI.settings.FILTER_RESOLUTION] - The resolution of the blur filter.
         * @param kernelSize - The kernelSize of the blur filter.Options: 5, 7, 9, 11, 13, 15.
         */
        function BlurFilter(strength, quality, resolution, kernelSize) {
            if (strength === void 0) { strength = 8; }
            if (quality === void 0) { quality = 4; }
            if (resolution === void 0) { resolution = settings.settings.FILTER_RESOLUTION; }
            if (kernelSize === void 0) { kernelSize = 5; }
            var _this = _super.call(this) || this;
            _this.blurXFilter = new BlurFilterPass(true, strength, quality, resolution, kernelSize);
            _this.blurYFilter = new BlurFilterPass(false, strength, quality, resolution, kernelSize);
            _this.resolution = resolution;
            _this.quality = quality;
            _this.blur = strength;
            _this.repeatEdgePixels = false;
            return _this;
        }
        /**
         * Applies the filter.
         * @param filterManager - The manager.
         * @param input - The input target.
         * @param output - The output target.
         * @param clearMode - How to clear
         */
        BlurFilter.prototype.apply = function (filterManager, input, output, clearMode) {
            var xStrength = Math.abs(this.blurXFilter.strength);
            var yStrength = Math.abs(this.blurYFilter.strength);
            if (xStrength && yStrength) {
                var renderTarget = filterManager.getFilterTexture();
                this.blurXFilter.apply(filterManager, input, renderTarget, constants.CLEAR_MODES.CLEAR);
                this.blurYFilter.apply(filterManager, renderTarget, output, clearMode);
                filterManager.returnFilterTexture(renderTarget);
            }
            else if (yStrength) {
                this.blurYFilter.apply(filterManager, input, output, clearMode);
            }
            else {
                this.blurXFilter.apply(filterManager, input, output, clearMode);
            }
        };
        BlurFilter.prototype.updatePadding = function () {
            if (this._repeatEdgePixels) {
                this.padding = 0;
            }
            else {
                this.padding = Math.max(Math.abs(this.blurXFilter.strength), Math.abs(this.blurYFilter.strength)) * 2;
            }
        };
        Object.defineProperty(BlurFilter.prototype, "blur", {
            /**
             * Sets the strength of both the blurX and blurY properties simultaneously
             * @default 2
             */
            get: function () {
                return this.blurXFilter.blur;
            },
            set: function (value) {
                this.blurXFilter.blur = this.blurYFilter.blur = value;
                this.updatePadding();
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BlurFilter.prototype, "quality", {
            /**
             * Sets the number of passes for blur. More passes means higher quality bluring.
             * @default 1
             */
            get: function () {
                return this.blurXFilter.quality;
            },
            set: function (value) {
                this.blurXFilter.quality = this.blurYFilter.quality = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BlurFilter.prototype, "blurX", {
            /**
             * Sets the strength of the blurX property
             * @default 2
             */
            get: function () {
                return this.blurXFilter.blur;
            },
            set: function (value) {
                this.blurXFilter.blur = value;
                this.updatePadding();
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BlurFilter.prototype, "blurY", {
            /**
             * Sets the strength of the blurY property
             * @default 2
             */
            get: function () {
                return this.blurYFilter.blur;
            },
            set: function (value) {
                this.blurYFilter.blur = value;
                this.updatePadding();
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BlurFilter.prototype, "blendMode", {
            /**
             * Sets the blendmode of the filter
             * @default PIXI.BLEND_MODES.NORMAL
             */
            get: function () {
                return this.blurYFilter.blendMode;
            },
            set: function (value) {
                this.blurYFilter.blendMode = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BlurFilter.prototype, "repeatEdgePixels", {
            /**
             * If set to true the edge of the target will be clamped
             * @default false
             */
            get: function () {
                return this._repeatEdgePixels;
            },
            set: function (value) {
                this._repeatEdgePixels = value;
                this.updatePadding();
            },
            enumerable: false,
            configurable: true
        });
        return BlurFilter;
    }(core.Filter));

    exports.BlurFilter = BlurFilter;
    exports.BlurFilterPass = BlurFilterPass;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI);
Object.assign(this.PIXI.filters, _pixi_filter_blur);
//# sourceMappingURL=filter-blur.js.map
