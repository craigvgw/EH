/*!
 * @pixi/text - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/text is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_text = (function (exports, sprite, core, settings, math, utils) {
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
     * Constants that define the type of gradient on text.
     * @static
     * @constant
     * @name TEXT_GRADIENT
     * @memberof PIXI
     * @type {object}
     * @property {number} LINEAR_VERTICAL Vertical gradient
     * @property {number} LINEAR_HORIZONTAL Linear gradient
     */
    exports.TEXT_GRADIENT = void 0;
    (function (TEXT_GRADIENT) {
        TEXT_GRADIENT[TEXT_GRADIENT["LINEAR_VERTICAL"] = 0] = "LINEAR_VERTICAL";
        TEXT_GRADIENT[TEXT_GRADIENT["LINEAR_HORIZONTAL"] = 1] = "LINEAR_HORIZONTAL";
    })(exports.TEXT_GRADIENT || (exports.TEXT_GRADIENT = {}));

    // disabling eslint for now, going to rewrite this in v5
    var defaultStyle = {
        align: 'left',
        breakWords: false,
        dropShadow: false,
        dropShadowAlpha: 1,
        dropShadowAngle: Math.PI / 6,
        dropShadowBlur: 0,
        dropShadowColor: 'black',
        dropShadowDistance: 5,
        fill: 'black',
        fillGradientType: exports.TEXT_GRADIENT.LINEAR_VERTICAL,
        fillGradientStops: [],
        fontFamily: 'Arial',
        fontSize: 26,
        fontStyle: 'normal',
        fontVariant: 'normal',
        fontWeight: 'normal',
        letterSpacing: 0,
        lineHeight: 0,
        lineJoin: 'miter',
        miterLimit: 10,
        padding: 0,
        stroke: 'black',
        strokeThickness: 0,
        textBaseline: 'alphabetic',
        trim: false,
        whiteSpace: 'pre',
        wordWrap: false,
        wordWrapWidth: 100,
        leading: 0,
    };
    var genericFontFamilies = [
        'serif',
        'sans-serif',
        'monospace',
        'cursive',
        'fantasy',
        'system-ui' ];
    /**
     * A TextStyle Object contains information to decorate a Text objects.
     *
     * An instance can be shared between multiple Text objects; then changing the style will update all text objects using it.
     *
     * A tool can be used to generate a text style [here](https://pixijs.io/pixi-text-style).
     *
     * @memberof PIXI
     */
    var TextStyle = /** @class */ (function () {
        /**
         * @param {object} [style] - The style parameters
         * @param {string} [style.align='left'] - Alignment for multiline text ('left', 'center' or 'right'),
         *  does not affect single line text
         * @param {boolean} [style.breakWords=false] - Indicates if lines can be wrapped within words, it
         *  needs wordWrap to be set to true
         * @param {boolean} [style.dropShadow=false] - Set a drop shadow for the text
         * @param {number} [style.dropShadowAlpha=1] - Set alpha for the drop shadow
         * @param {number} [style.dropShadowAngle=Math.PI/6] - Set a angle of the drop shadow
         * @param {number} [style.dropShadowBlur=0] - Set a shadow blur radius
         * @param {string|number} [style.dropShadowColor='black'] - A fill style to be used on the dropshadow e.g 'red', '#00FF00'
         * @param {number} [style.dropShadowDistance=5] - Set a distance of the drop shadow
         * @param {string|string[]|number|number[]|CanvasGradient|CanvasPattern} [style.fill='black'] - A canvas
         *  fillstyle that will be used on the text e.g 'red', '#00FF00'. Can be an array to create a gradient
         *  eg ['#000000','#FFFFFF']
         * {@link https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/fillStyle|MDN}
         * @param {number} [style.fillGradientType=PIXI.TEXT_GRADIENT.LINEAR_VERTICAL] - If fill is an array of colours
         *  to create a gradient, this can change the type/direction of the gradient. See {@link PIXI.TEXT_GRADIENT}
         * @param {number[]} [style.fillGradientStops] - If fill is an array of colours to create a gradient, this array can set
         * the stop points (numbers between 0 and 1) for the color, overriding the default behaviour of evenly spacing them.
         * @param {string|string[]} [style.fontFamily='Arial'] - The font family
         * @param {number|string} [style.fontSize=26] - The font size (as a number it converts to px, but as a string,
         *  equivalents are '26px','20pt','160%' or '1.6em')
         * @param {string} [style.fontStyle='normal'] - The font style ('normal', 'italic' or 'oblique')
         * @param {string} [style.fontVariant='normal'] - The font variant ('normal' or 'small-caps')
         * @param {string} [style.fontWeight='normal'] - The font weight ('normal', 'bold', 'bolder', 'lighter' and '100',
         *  '200', '300', '400', '500', '600', '700', '800' or '900')
         * @param {number} [style.leading=0] - The space between lines
         * @param {number} [style.letterSpacing=0] - The amount of spacing between letters, default is 0
         * @param {number} [style.lineHeight] - The line height, a number that represents the vertical space that a letter uses
         * @param {string} [style.lineJoin='miter'] - The lineJoin property sets the type of corner created, it can resolve
         *      spiked text issues. Possible values "miter" (creates a sharp corner), "round" (creates a round corner) or "bevel"
         *      (creates a squared corner).
         * @param {number} [style.miterLimit=10] - The miter limit to use when using the 'miter' lineJoin mode. This can reduce
         *      or increase the spikiness of rendered text.
         * @param {number} [style.padding=0] - Occasionally some fonts are cropped. Adding some padding will prevent this from
         *     happening by adding padding to all sides of the text.
         * @param {string|number} [style.stroke='black'] - A canvas fillstyle that will be used on the text stroke
         *  e.g 'blue', '#FCFF00'
         * @param {number} [style.strokeThickness=0] - A number that represents the thickness of the stroke.
         *  Default is 0 (no stroke)
         * @param {boolean} [style.trim=false] - Trim transparent borders
         * @param {string} [style.textBaseline='alphabetic'] - The baseline of the text that is rendered.
         * @param {string} [style.whiteSpace='pre'] - Determines whether newlines & spaces are collapsed or preserved "normal"
         *      (collapse, collapse), "pre" (preserve, preserve) | "pre-line" (preserve, collapse). It needs wordWrap to be set to true
         * @param {boolean} [style.wordWrap=false] - Indicates if word wrap should be used
         * @param {number} [style.wordWrapWidth=100] - The width at which text will wrap, it needs wordWrap to be set to true
         */
        function TextStyle(style) {
            this.styleID = 0;
            this.reset();
            deepCopyProperties(this, style, style);
        }
        /**
         * Creates a new TextStyle object with the same values as this one.
         * Note that the only the properties of the object are cloned.
         *
         * @return New cloned TextStyle object
         */
        TextStyle.prototype.clone = function () {
            var clonedProperties = {};
            deepCopyProperties(clonedProperties, this, defaultStyle);
            return new TextStyle(clonedProperties);
        };
        /** Resets all properties to the defaults specified in TextStyle.prototype._default */
        TextStyle.prototype.reset = function () {
            deepCopyProperties(this, defaultStyle, defaultStyle);
        };
        Object.defineProperty(TextStyle.prototype, "align", {
            /**
             * Alignment for multiline text ('left', 'center' or 'right'), does not affect single line text
             *
             * @member {string}
             */
            get: function () {
                return this._align;
            },
            set: function (align) {
                if (this._align !== align) {
                    this._align = align;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "breakWords", {
            /** Indicates if lines can be wrapped within words, it needs wordWrap to be set to true. */
            get: function () {
                return this._breakWords;
            },
            set: function (breakWords) {
                if (this._breakWords !== breakWords) {
                    this._breakWords = breakWords;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "dropShadow", {
            /** Set a drop shadow for the text. */
            get: function () {
                return this._dropShadow;
            },
            set: function (dropShadow) {
                if (this._dropShadow !== dropShadow) {
                    this._dropShadow = dropShadow;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "dropShadowAlpha", {
            /** Set alpha for the drop shadow. */
            get: function () {
                return this._dropShadowAlpha;
            },
            set: function (dropShadowAlpha) {
                if (this._dropShadowAlpha !== dropShadowAlpha) {
                    this._dropShadowAlpha = dropShadowAlpha;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "dropShadowAngle", {
            /** Set a angle of the drop shadow. */
            get: function () {
                return this._dropShadowAngle;
            },
            set: function (dropShadowAngle) {
                if (this._dropShadowAngle !== dropShadowAngle) {
                    this._dropShadowAngle = dropShadowAngle;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "dropShadowBlur", {
            /** Set a shadow blur radius. */
            get: function () {
                return this._dropShadowBlur;
            },
            set: function (dropShadowBlur) {
                if (this._dropShadowBlur !== dropShadowBlur) {
                    this._dropShadowBlur = dropShadowBlur;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "dropShadowColor", {
            /** A fill style to be used on the dropshadow e.g 'red', '#00FF00'. */
            get: function () {
                return this._dropShadowColor;
            },
            set: function (dropShadowColor) {
                var outputColor = getColor(dropShadowColor);
                if (this._dropShadowColor !== outputColor) {
                    this._dropShadowColor = outputColor;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "dropShadowDistance", {
            /** Set a distance of the drop shadow. */
            get: function () {
                return this._dropShadowDistance;
            },
            set: function (dropShadowDistance) {
                if (this._dropShadowDistance !== dropShadowDistance) {
                    this._dropShadowDistance = dropShadowDistance;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fill", {
            /**
             * A canvas fillstyle that will be used on the text e.g 'red', '#00FF00'.
             *
             * Can be an array to create a gradient eg ['#000000','#FFFFFF']
             * {@link https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/fillStyle|MDN}
             *
             * @member {string|string[]|number|number[]|CanvasGradient|CanvasPattern}
             */
            get: function () {
                return this._fill;
            },
            set: function (fill) {
                // TODO: Can't have different types for getter and setter. The getter shouldn't have the number type as
                //       the setter converts to string. See this thread for more details:
                //       https://github.com/microsoft/TypeScript/issues/2521
                // TODO: Not sure if getColor works properly with CanvasGradient and/or CanvasPattern, can't pass in
                //       without casting here.
                var outputColor = getColor(fill);
                if (this._fill !== outputColor) {
                    this._fill = outputColor;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fillGradientType", {
            /**
             * If fill is an array of colours to create a gradient, this can change the type/direction of the gradient.
             *
             * @see PIXI.TEXT_GRADIENT
             */
            get: function () {
                return this._fillGradientType;
            },
            set: function (fillGradientType) {
                if (this._fillGradientType !== fillGradientType) {
                    this._fillGradientType = fillGradientType;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fillGradientStops", {
            /**
             * If fill is an array of colours to create a gradient, this array can set the stop points
             * (numbers between 0 and 1) for the color, overriding the default behaviour of evenly spacing them.
             */
            get: function () {
                return this._fillGradientStops;
            },
            set: function (fillGradientStops) {
                if (!areArraysEqual(this._fillGradientStops, fillGradientStops)) {
                    this._fillGradientStops = fillGradientStops;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fontFamily", {
            /** The font family. */
            get: function () {
                return this._fontFamily;
            },
            set: function (fontFamily) {
                if (this.fontFamily !== fontFamily) {
                    this._fontFamily = fontFamily;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fontSize", {
            /**
             * The font size
             * (as a number it converts to px, but as a string, equivalents are '26px','20pt','160%' or '1.6em')
             */
            get: function () {
                return this._fontSize;
            },
            set: function (fontSize) {
                if (this._fontSize !== fontSize) {
                    this._fontSize = fontSize;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fontStyle", {
            /**
             * The font style
             * ('normal', 'italic' or 'oblique')
             *
             * @member {string}
             */
            get: function () {
                return this._fontStyle;
            },
            set: function (fontStyle) {
                if (this._fontStyle !== fontStyle) {
                    this._fontStyle = fontStyle;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fontVariant", {
            /**
             * The font variant
             * ('normal' or 'small-caps')
             *
             * @member {string}
             */
            get: function () {
                return this._fontVariant;
            },
            set: function (fontVariant) {
                if (this._fontVariant !== fontVariant) {
                    this._fontVariant = fontVariant;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "fontWeight", {
            /**
             * The font weight
             * ('normal', 'bold', 'bolder', 'lighter' and '100', '200', '300', '400', '500', '600', '700', 800' or '900')
             *
             * @member {string}
             */
            get: function () {
                return this._fontWeight;
            },
            set: function (fontWeight) {
                if (this._fontWeight !== fontWeight) {
                    this._fontWeight = fontWeight;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "letterSpacing", {
            /** The amount of spacing between letters, default is 0. */
            get: function () {
                return this._letterSpacing;
            },
            set: function (letterSpacing) {
                if (this._letterSpacing !== letterSpacing) {
                    this._letterSpacing = letterSpacing;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "lineHeight", {
            /** The line height, a number that represents the vertical space that a letter uses. */
            get: function () {
                return this._lineHeight;
            },
            set: function (lineHeight) {
                if (this._lineHeight !== lineHeight) {
                    this._lineHeight = lineHeight;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "leading", {
            /** The space between lines. */
            get: function () {
                return this._leading;
            },
            set: function (leading) {
                if (this._leading !== leading) {
                    this._leading = leading;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "lineJoin", {
            /**
             * The lineJoin property sets the type of corner created, it can resolve spiked text issues.
             * Default is 'miter' (creates a sharp corner).
             *
             * @member {string}
             */
            get: function () {
                return this._lineJoin;
            },
            set: function (lineJoin) {
                if (this._lineJoin !== lineJoin) {
                    this._lineJoin = lineJoin;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "miterLimit", {
            /**
             * The miter limit to use when using the 'miter' lineJoin mode.
             *
             * This can reduce or increase the spikiness of rendered text.
             */
            get: function () {
                return this._miterLimit;
            },
            set: function (miterLimit) {
                if (this._miterLimit !== miterLimit) {
                    this._miterLimit = miterLimit;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "padding", {
            /**
             * Occasionally some fonts are cropped. Adding some padding will prevent this from happening
             * by adding padding to all sides of the text.
             */
            get: function () {
                return this._padding;
            },
            set: function (padding) {
                if (this._padding !== padding) {
                    this._padding = padding;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "stroke", {
            /**
             * A canvas fillstyle that will be used on the text stroke
             * e.g 'blue', '#FCFF00'
             */
            get: function () {
                return this._stroke;
            },
            set: function (stroke) {
                // TODO: Can't have different types for getter and setter. The getter shouldn't have the number type as
                //       the setter converts to string. See this thread for more details:
                //       https://github.com/microsoft/TypeScript/issues/2521
                var outputColor = getColor(stroke);
                if (this._stroke !== outputColor) {
                    this._stroke = outputColor;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "strokeThickness", {
            /**
             * A number that represents the thickness of the stroke.
             *
             * @default 0
             */
            get: function () {
                return this._strokeThickness;
            },
            set: function (strokeThickness) {
                if (this._strokeThickness !== strokeThickness) {
                    this._strokeThickness = strokeThickness;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "textBaseline", {
            /**
             * The baseline of the text that is rendered.
             *
             * @member {string}
             */
            get: function () {
                return this._textBaseline;
            },
            set: function (textBaseline) {
                if (this._textBaseline !== textBaseline) {
                    this._textBaseline = textBaseline;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "trim", {
            /** Trim transparent borders. */
            get: function () {
                return this._trim;
            },
            set: function (trim) {
                if (this._trim !== trim) {
                    this._trim = trim;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "whiteSpace", {
            /**
             * How newlines and spaces should be handled.
             * Default is 'pre' (preserve, preserve).
             *
             *  value       | New lines     |   Spaces
             *  ---         | ---           |   ---
             * 'normal'     | Collapse      |   Collapse
             * 'pre'        | Preserve      |   Preserve
             * 'pre-line'   | Preserve      |   Collapse
             *
             * @member {string}
             */
            get: function () {
                return this._whiteSpace;
            },
            set: function (whiteSpace) {
                if (this._whiteSpace !== whiteSpace) {
                    this._whiteSpace = whiteSpace;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "wordWrap", {
            /** Indicates if word wrap should be used. */
            get: function () {
                return this._wordWrap;
            },
            set: function (wordWrap) {
                if (this._wordWrap !== wordWrap) {
                    this._wordWrap = wordWrap;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextStyle.prototype, "wordWrapWidth", {
            /** The width at which text will wrap, it needs wordWrap to be set to true. */
            get: function () {
                return this._wordWrapWidth;
            },
            set: function (wordWrapWidth) {
                if (this._wordWrapWidth !== wordWrapWidth) {
                    this._wordWrapWidth = wordWrapWidth;
                    this.styleID++;
                }
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Generates a font style string to use for `TextMetrics.measureFont()`.
         *
         * @return Font style string, for passing to `TextMetrics.measureFont()`
         */
        TextStyle.prototype.toFontString = function () {
            // build canvas api font setting from individual components. Convert a numeric this.fontSize to px
            var fontSizeString = (typeof this.fontSize === 'number') ? this.fontSize + "px" : this.fontSize;
            // Clean-up fontFamily property by quoting each font name
            // this will support font names with spaces
            var fontFamilies = this.fontFamily;
            if (!Array.isArray(this.fontFamily)) {
                fontFamilies = this.fontFamily.split(',');
            }
            for (var i = fontFamilies.length - 1; i >= 0; i--) {
                // Trim any extra white-space
                var fontFamily = fontFamilies[i].trim();
                // Check if font already contains strings
                if (!(/([\"\'])[^\'\"]+\1/).test(fontFamily) && genericFontFamilies.indexOf(fontFamily) < 0) {
                    fontFamily = "\"" + fontFamily + "\"";
                }
                fontFamilies[i] = fontFamily;
            }
            return this.fontStyle + " " + this.fontVariant + " " + this.fontWeight + " " + fontSizeString + " " + fontFamilies.join(',');
        };
        return TextStyle;
    }());
    /**
     * Utility function to convert hexadecimal colors to strings, and simply return the color if it's a string.
     * @private
     * @param color
     * @return The color as a string.
     */
    function getSingleColor(color) {
        if (typeof color === 'number') {
            return utils.hex2string(color);
        }
        else if (typeof color === 'string') {
            if (color.indexOf('0x') === 0) {
                color = color.replace('0x', '#');
            }
        }
        return color;
    }
    function getColor(color) {
        if (!Array.isArray(color)) {
            return getSingleColor(color);
        }
        else {
            for (var i = 0; i < color.length; ++i) {
                color[i] = getSingleColor(color[i]);
            }
            return color;
        }
    }
    /**
     * Utility function to convert hexadecimal colors to strings, and simply return the color if it's a string.
     * This version can also convert array of colors
     * @private
     * @param array1 - First array to compare
     * @param array2 - Second array to compare
     * @return Do the arrays contain the same values in the same order
     */
    function areArraysEqual(array1, array2) {
        if (!Array.isArray(array1) || !Array.isArray(array2)) {
            return false;
        }
        if (array1.length !== array2.length) {
            return false;
        }
        for (var i = 0; i < array1.length; ++i) {
            if (array1[i] !== array2[i]) {
                return false;
            }
        }
        return true;
    }
    /**
     * Utility function to ensure that object properties are copied by value, and not by reference
     * @private
     * @param target - Target object to copy properties into
     * @param source - Source object for the properties to copy
     * @param propertyObj - Object containing properties names we want to loop over
     */
    function deepCopyProperties(target, source, propertyObj) {
        for (var prop in propertyObj) {
            if (Array.isArray(source[prop])) {
                target[prop] = source[prop].slice();
            }
            else {
                target[prop] = source[prop];
            }
        }
    }

    /**
     * The TextMetrics object represents the measurement of a block of text with a specified style.
     *
     * ```js
     * let style = new PIXI.TextStyle({fontFamily : 'Arial', fontSize: 24, fill : 0xff1010, align : 'center'})
     * let textMetrics = PIXI.TextMetrics.measureText('Your text', style)
     * ```
     * @memberof PIXI
     */
    var TextMetrics = /** @class */ (function () {
        /**
         * @param text - the text that was measured
         * @param style - the style that was measured
         * @param width - the measured width of the text
         * @param height - the measured height of the text
         * @param lines - an array of the lines of text broken by new lines and wrapping if specified in style
         * @param lineWidths - an array of the line widths for each line matched to `lines`
         * @param lineHeight - the measured line height for this style
         * @param maxLineWidth - the maximum line width for all measured lines
         * @param {PIXI.IFontMetrics} fontProperties - the font properties object from TextMetrics.measureFont
         */
        function TextMetrics(text, style, width, height, lines, lineWidths, lineHeight, maxLineWidth, fontProperties) {
            this.text = text;
            this.style = style;
            this.width = width;
            this.height = height;
            this.lines = lines;
            this.lineWidths = lineWidths;
            this.lineHeight = lineHeight;
            this.maxLineWidth = maxLineWidth;
            this.fontProperties = fontProperties;
        }
        /**
         * Measures the supplied string of text and returns a Rectangle.
         * @param text - The text to measure.
         * @param style - The text style to use for measuring
         * @param wordWrap - Override for if word-wrap should be applied to the text.
         * @param canvas - optional specification of the canvas to use for measuring.
         * @returns Measured width and height of the text.
         */
        TextMetrics.measureText = function (text, style, wordWrap, canvas) {
            if (canvas === void 0) { canvas = TextMetrics._canvas; }
            wordWrap = (wordWrap === undefined || wordWrap === null) ? style.wordWrap : wordWrap;
            var font = style.toFontString();
            var fontProperties = TextMetrics.measureFont(font);
            // fallback in case UA disallow canvas data extraction
            // (toDataURI, getImageData functions)
            if (fontProperties.fontSize === 0) {
                fontProperties.fontSize = style.fontSize;
                fontProperties.ascent = style.fontSize;
            }
            var context = canvas.getContext('2d');
            context.font = font;
            var outputText = wordWrap ? TextMetrics.wordWrap(text, style, canvas) : text;
            var lines = outputText.split(/(?:\r\n|\r|\n)/);
            var lineWidths = new Array(lines.length);
            var maxLineWidth = 0;
            for (var i = 0; i < lines.length; i++) {
                var lineWidth = context.measureText(lines[i]).width + ((lines[i].length - 1) * style.letterSpacing);
                lineWidths[i] = lineWidth;
                maxLineWidth = Math.max(maxLineWidth, lineWidth);
            }
            var width = maxLineWidth + style.strokeThickness;
            if (style.dropShadow) {
                width += style.dropShadowDistance;
            }
            var lineHeight = style.lineHeight || fontProperties.fontSize + style.strokeThickness;
            var height = Math.max(lineHeight, fontProperties.fontSize + style.strokeThickness)
                + ((lines.length - 1) * (lineHeight + style.leading));
            if (style.dropShadow) {
                height += style.dropShadowDistance;
            }
            return new TextMetrics(text, style, width, height, lines, lineWidths, lineHeight + style.leading, maxLineWidth, fontProperties);
        };
        /**
         * Applies newlines to a string to have it optimally fit into the horizontal
         * bounds set by the Text object's wordWrapWidth property.
         * @param text - String to apply word wrapping to
         * @param style - the style to use when wrapping
         * @param canvas - optional specification of the canvas to use for measuring.
         * @returns New string with new lines applied where required
         */
        TextMetrics.wordWrap = function (text, style, canvas) {
            if (canvas === void 0) { canvas = TextMetrics._canvas; }
            var context = canvas.getContext('2d');
            var width = 0;
            var line = '';
            var lines = '';
            var cache = Object.create(null);
            var letterSpacing = style.letterSpacing, whiteSpace = style.whiteSpace;
            // How to handle whitespaces
            var collapseSpaces = TextMetrics.collapseSpaces(whiteSpace);
            var collapseNewlines = TextMetrics.collapseNewlines(whiteSpace);
            // whether or not spaces may be added to the beginning of lines
            var canPrependSpaces = !collapseSpaces;
            // There is letterSpacing after every char except the last one
            // t_h_i_s_' '_i_s_' '_a_n_' '_e_x_a_m_p_l_e_' '_!
            // so for convenience the above needs to be compared to width + 1 extra letterSpace
            // t_h_i_s_' '_i_s_' '_a_n_' '_e_x_a_m_p_l_e_' '_!_
            // ________________________________________________
            // And then the final space is simply no appended to each line
            var wordWrapWidth = style.wordWrapWidth + letterSpacing;
            // break text into words, spaces and newline chars
            var tokens = TextMetrics.tokenize(text);
            for (var i = 0; i < tokens.length; i++) {
                // get the word, space or newlineChar
                var token = tokens[i];
                // if word is a new line
                if (TextMetrics.isNewline(token)) {
                    // keep the new line
                    if (!collapseNewlines) {
                        lines += TextMetrics.addLine(line);
                        canPrependSpaces = !collapseSpaces;
                        line = '';
                        width = 0;
                        continue;
                    }
                    // if we should collapse new lines
                    // we simply convert it into a space
                    token = ' ';
                }
                // if we should collapse repeated whitespaces
                if (collapseSpaces) {
                    // check both this and the last tokens for spaces
                    var currIsBreakingSpace = TextMetrics.isBreakingSpace(token);
                    var lastIsBreakingSpace = TextMetrics.isBreakingSpace(line[line.length - 1]);
                    if (currIsBreakingSpace && lastIsBreakingSpace) {
                        continue;
                    }
                }
                // get word width from cache if possible
                var tokenWidth = TextMetrics.getFromCache(token, letterSpacing, cache, context);
                // word is longer than desired bounds
                if (tokenWidth > wordWrapWidth) {
                    // if we are not already at the beginning of a line
                    if (line !== '') {
                        // start newlines for overflow words
                        lines += TextMetrics.addLine(line);
                        line = '';
                        width = 0;
                    }
                    // break large word over multiple lines
                    if (TextMetrics.canBreakWords(token, style.breakWords)) {
                        // break word into characters
                        var characters = TextMetrics.wordWrapSplit(token);
                        // loop the characters
                        for (var j = 0; j < characters.length; j++) {
                            var char = characters[j];
                            var k = 1;
                            // we are not at the end of the token
                            while (characters[j + k]) {
                                var nextChar = characters[j + k];
                                var lastChar = char[char.length - 1];
                                // should not split chars
                                if (!TextMetrics.canBreakChars(lastChar, nextChar, token, j, style.breakWords)) {
                                    // combine chars & move forward one
                                    char += nextChar;
                                }
                                else {
                                    break;
                                }
                                k++;
                            }
                            j += char.length - 1;
                            var characterWidth = TextMetrics.getFromCache(char, letterSpacing, cache, context);
                            if (characterWidth + width > wordWrapWidth) {
                                lines += TextMetrics.addLine(line);
                                canPrependSpaces = false;
                                line = '';
                                width = 0;
                            }
                            line += char;
                            width += characterWidth;
                        }
                    }
                    // run word out of the bounds
                    else {
                        // if there are words in this line already
                        // finish that line and start a new one
                        if (line.length > 0) {
                            lines += TextMetrics.addLine(line);
                            line = '';
                            width = 0;
                        }
                        var isLastToken = i === tokens.length - 1;
                        // give it its own line if it's not the end
                        lines += TextMetrics.addLine(token, !isLastToken);
                        canPrependSpaces = false;
                        line = '';
                        width = 0;
                    }
                }
                // word could fit
                else {
                    // word won't fit because of existing words
                    // start a new line
                    if (tokenWidth + width > wordWrapWidth) {
                        // if its a space we don't want it
                        canPrependSpaces = false;
                        // add a new line
                        lines += TextMetrics.addLine(line);
                        // start a new line
                        line = '';
                        width = 0;
                    }
                    // don't add spaces to the beginning of lines
                    if (line.length > 0 || !TextMetrics.isBreakingSpace(token) || canPrependSpaces) {
                        // add the word to the current line
                        line += token;
                        // update width counter
                        width += tokenWidth;
                    }
                }
            }
            lines += TextMetrics.addLine(line, false);
            return lines;
        };
        /**
         * Convienience function for logging each line added during the wordWrap method.
         * @param line    - The line of text to add
         * @param newLine - Add new line character to end
         * @returns A formatted line
         */
        TextMetrics.addLine = function (line, newLine) {
            if (newLine === void 0) { newLine = true; }
            line = TextMetrics.trimRight(line);
            line = (newLine) ? line + "\n" : line;
            return line;
        };
        /**
         * Gets & sets the widths of calculated characters in a cache object
         * @param key            - The key
         * @param letterSpacing  - The letter spacing
         * @param cache          - The cache
         * @param context        - The canvas context
         * @returns The from cache.
         */
        TextMetrics.getFromCache = function (key, letterSpacing, cache, context) {
            var width = cache[key];
            if (typeof width !== 'number') {
                var spacing = ((key.length) * letterSpacing);
                width = context.measureText(key).width + spacing;
                cache[key] = width;
            }
            return width;
        };
        /**
         * Determines whether we should collapse breaking spaces.
         * @param whiteSpace - The TextStyle property whiteSpace
         * @returns Should collapse
         */
        TextMetrics.collapseSpaces = function (whiteSpace) {
            return (whiteSpace === 'normal' || whiteSpace === 'pre-line');
        };
        /**
         * Determines whether we should collapse newLine chars.
         * @param whiteSpace - The white space
         * @returns  should collapse
         */
        TextMetrics.collapseNewlines = function (whiteSpace) {
            return (whiteSpace === 'normal');
        };
        /**
         * Trims breaking whitespaces from string.
         * @param  text - The text
         * @returns Trimmed string
         */
        TextMetrics.trimRight = function (text) {
            if (typeof text !== 'string') {
                return '';
            }
            for (var i = text.length - 1; i >= 0; i--) {
                var char = text[i];
                if (!TextMetrics.isBreakingSpace(char)) {
                    break;
                }
                text = text.slice(0, -1);
            }
            return text;
        };
        /**
         * Determines if char is a newline.
         * @param  char - The character
         * @returns True if newline, False otherwise.
         */
        TextMetrics.isNewline = function (char) {
            if (typeof char !== 'string') {
                return false;
            }
            return (TextMetrics._newlines.indexOf(char.charCodeAt(0)) >= 0);
        };
        /**
         * Determines if char is a breaking whitespace.
         *
         * It allows one to determine whether char should be a breaking whitespace
         * For example certain characters in CJK langs or numbers.
         * It must return a boolean.
         * @param char - The character
         * @param [_nextChar] - The next character
         * @returns True if whitespace, False otherwise.
         */
        TextMetrics.isBreakingSpace = function (char, _nextChar) {
            if (typeof char !== 'string') {
                return false;
            }
            return (TextMetrics._breakingSpaces.indexOf(char.charCodeAt(0)) >= 0);
        };
        /**
         * Splits a string into words, breaking-spaces and newLine characters
         * @param  text - The text
         * @returns  A tokenized array
         */
        TextMetrics.tokenize = function (text) {
            var tokens = [];
            var token = '';
            if (typeof text !== 'string') {
                return tokens;
            }
            for (var i = 0; i < text.length; i++) {
                var char = text[i];
                var nextChar = text[i + 1];
                if (TextMetrics.isBreakingSpace(char, nextChar) || TextMetrics.isNewline(char)) {
                    if (token !== '') {
                        tokens.push(token);
                        token = '';
                    }
                    tokens.push(char);
                    continue;
                }
                token += char;
            }
            if (token !== '') {
                tokens.push(token);
            }
            return tokens;
        };
        /**
         * Overridable helper method used internally by TextMetrics, exposed to allow customizing the class's behavior.
         *
         * It allows one to customise which words should break
         * Examples are if the token is CJK or numbers.
         * It must return a boolean.
         * @param _token - The token
         * @param  breakWords - The style attr break words
         * @returns Whether to break word or not
         */
        TextMetrics.canBreakWords = function (_token, breakWords) {
            return breakWords;
        };
        /**
         * Overridable helper method used internally by TextMetrics, exposed to allow customizing the class's behavior.
         *
         * It allows one to determine whether a pair of characters
         * should be broken by newlines
         * For example certain characters in CJK langs or numbers.
         * It must return a boolean.
         * @param _char - The character
         * @param _nextChar - The next character
         * @param _token - The token/word the characters are from
         * @param _index - The index in the token of the char
         * @param _breakWords - The style attr break words
         * @returns whether to break word or not
         */
        TextMetrics.canBreakChars = function (_char, _nextChar, _token, _index, _breakWords) {
            return true;
        };
        /**
         * Overridable helper method used internally by TextMetrics, exposed to allow customizing the class's behavior.
         *
         * It is called when a token (usually a word) has to be split into separate pieces
         * in order to determine the point to break a word.
         * It must return an array of characters.
         * @example
         * // Correctly splits emojis, eg "????????" will result in two element array, each with one emoji.
         * TextMetrics.wordWrapSplit = (token) => [...token];
         * @param  token - The token to split
         * @returns The characters of the token
         */
        TextMetrics.wordWrapSplit = function (token) {
            return token.split('');
        };
        /**
         * Calculates the ascent, descent and fontSize of a given font-style
         * @param font - String representing the style of the font
         * @returns Font properties object
         */
        TextMetrics.measureFont = function (font) {
            // as this method is used for preparing assets, don't recalculate things if we don't need to
            if (TextMetrics._fonts[font]) {
                return TextMetrics._fonts[font];
            }
            var properties = {
                ascent: 0,
                descent: 0,
                fontSize: 0,
            };
            var canvas = TextMetrics._canvas;
            var context = TextMetrics._context;
            context.font = font;
            var metricsString = TextMetrics.METRICS_STRING + TextMetrics.BASELINE_SYMBOL;
            var width = Math.ceil(context.measureText(metricsString).width);
            var baseline = Math.ceil(context.measureText(TextMetrics.BASELINE_SYMBOL).width);
            var height = Math.ceil(TextMetrics.HEIGHT_MULTIPLIER * baseline);
            baseline = baseline * TextMetrics.BASELINE_MULTIPLIER | 0;
            canvas.width = width;
            canvas.height = height;
            context.fillStyle = '#f00';
            context.fillRect(0, 0, width, height);
            context.font = font;
            context.textBaseline = 'alphabetic';
            context.fillStyle = '#000';
            context.fillText(metricsString, 0, baseline);
            var imagedata = context.getImageData(0, 0, width, height).data;
            var pixels = imagedata.length;
            var line = width * 4;
            var i = 0;
            var idx = 0;
            var stop = false;
            // ascent. scan from top to bottom until we find a non red pixel
            for (i = 0; i < baseline; ++i) {
                for (var j = 0; j < line; j += 4) {
                    if (imagedata[idx + j] !== 255) {
                        stop = true;
                        break;
                    }
                }
                if (!stop) {
                    idx += line;
                }
                else {
                    break;
                }
            }
            properties.ascent = baseline - i;
            idx = pixels - line;
            stop = false;
            // descent. scan from bottom to top until we find a non red pixel
            for (i = height; i > baseline; --i) {
                for (var j = 0; j < line; j += 4) {
                    if (imagedata[idx + j] !== 255) {
                        stop = true;
                        break;
                    }
                }
                if (!stop) {
                    idx -= line;
                }
                else {
                    break;
                }
            }
            properties.descent = i - baseline;
            properties.fontSize = properties.ascent + properties.descent;
            TextMetrics._fonts[font] = properties;
            return properties;
        };
        /**
         * Clear font metrics in metrics cache.
         * @param {string} [font] - font name. If font name not set then clear cache for all fonts.
         */
        TextMetrics.clearMetrics = function (font) {
            if (font === void 0) { font = ''; }
            if (font) {
                delete TextMetrics._fonts[font];
            }
            else {
                TextMetrics._fonts = {};
            }
        };
        Object.defineProperty(TextMetrics, "_canvas", {
            /**
             * Cached canvas element for measuring text
             * TODO: this should be private, but isn't because of backward compat, will fix later.
             * @ignore
             */
            get: function () {
                if (!TextMetrics.__canvas) {
                    var canvas = void 0;
                    try {
                        // OffscreenCanvas2D measureText can be up to 40% faster.
                        var c = new OffscreenCanvas(0, 0);
                        var context = c.getContext('2d');
                        if (context && context.measureText) {
                            TextMetrics.__canvas = c;
                            return c;
                        }
                        canvas = settings.settings.ADAPTER.createCanvas();
                    }
                    catch (ex) {
                        canvas = settings.settings.ADAPTER.createCanvas();
                    }
                    canvas.width = canvas.height = 10;
                    TextMetrics.__canvas = canvas;
                }
                return TextMetrics.__canvas;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(TextMetrics, "_context", {
            /**
             * TODO: this should be private, but isn't because of backward compat, will fix later.
             * @ignore
             */
            get: function () {
                if (!TextMetrics.__context) {
                    TextMetrics.__context = TextMetrics._canvas.getContext('2d');
                }
                return TextMetrics.__context;
            },
            enumerable: false,
            configurable: true
        });
        return TextMetrics;
    }());
    /**
     * Internal return object for {@link PIXI.TextMetrics.measureFont `TextMetrics.measureFont`}.
     * @typedef {object} FontMetrics
     * @property {number} ascent - The ascent distance
     * @property {number} descent - The descent distance
     * @property {number} fontSize - Font size from ascent to descent
     * @memberof PIXI.TextMetrics
     * @private
     */
    /**
     * Cache of {@see PIXI.TextMetrics.FontMetrics} objects.
     * @memberof PIXI.TextMetrics
     * @type {object}
     * @private
     */
    TextMetrics._fonts = {};
    /**
     * String used for calculate font metrics.
     * These characters are all tall to help calculate the height required for text.
     * @static
     * @memberof PIXI.TextMetrics
     * @name METRICS_STRING
     * @type {string}
     * @default |??q??
     */
    TextMetrics.METRICS_STRING = '|??q??';
    /**
     * Baseline symbol for calculate font metrics.
     * @static
     * @memberof PIXI.TextMetrics
     * @name BASELINE_SYMBOL
     * @type {string}
     * @default M
     */
    TextMetrics.BASELINE_SYMBOL = 'M';
    /**
     * Baseline multiplier for calculate font metrics.
     * @static
     * @memberof PIXI.TextMetrics
     * @name BASELINE_MULTIPLIER
     * @type {number}
     * @default 1.4
     */
    TextMetrics.BASELINE_MULTIPLIER = 1.4;
    /**
     * Height multiplier for setting height of canvas to calculate font metrics.
     * @static
     * @memberof PIXI.TextMetrics
     * @name HEIGHT_MULTIPLIER
     * @type {number}
     * @default 2.00
     */
    TextMetrics.HEIGHT_MULTIPLIER = 2.0;
    /**
     * Cache of new line chars.
     * @memberof PIXI.TextMetrics
     * @type {number[]}
     * @private
     */
    TextMetrics._newlines = [
        0x000A,
        0x000D ];
    /**
     * Cache of breaking spaces.
     * @memberof PIXI.TextMetrics
     * @type {number[]}
     * @private
     */
    TextMetrics._breakingSpaces = [
        0x0009,
        0x0020,
        0x2000,
        0x2001,
        0x2002,
        0x2003,
        0x2004,
        0x2005,
        0x2006,
        0x2008,
        0x2009,
        0x200A,
        0x205F,
        0x3000 ];
    /**
     * A number, or a string containing a number.
     * @memberof PIXI
     * @typedef {object} IFontMetrics
     * @property {number} ascent - Font ascent
     * @property {number} descent - Font descent
     * @property {number} fontSize - Font size
     */

    var defaultDestroyOptions = {
        texture: true,
        children: false,
        baseTexture: true,
    };
    /**
     * A Text Object will create a line or multiple lines of text.
     *
     * The text is created using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
     *
     * The primary advantage of this class over BitmapText is that you have great control over the style of the text,
     * which you can change at runtime.
     *
     * The primary disadvantages is that each piece of text has it's own texture, which can use more memory.
     * When text changes, this texture has to be re-generated and re-uploaded to the GPU, taking up time.
     *
     * To split a line you can use '\n' in your text string, or, on the `style` object,
     * change its `wordWrap` property to true and and give the `wordWrapWidth` property a value.
     *
     * A Text can be created directly from a string and a style object,
     * which can be generated [here](https://pixijs.io/pixi-text-style).
     *
     * ```js
     * let text = new PIXI.Text('This is a PixiJS text',{fontFamily : 'Arial', fontSize: 24, fill : 0xff1010, align : 'center'});
     * ```
     * @memberof PIXI
     */
    var Text = /** @class */ (function (_super) {
        __extends(Text, _super);
        /**
         * @param text - The string that you would like the text to display
         * @param {object|PIXI.TextStyle} [style] - The style parameters
         * @param canvas - The canvas element for drawing text
         */
        function Text(text, style, canvas) {
            var _this = this;
            var ownCanvas = false;
            if (!canvas) {
                canvas = settings.settings.ADAPTER.createCanvas();
                ownCanvas = true;
            }
            canvas.width = 3;
            canvas.height = 3;
            var texture = core.Texture.from(canvas);
            texture.orig = new math.Rectangle();
            texture.trim = new math.Rectangle();
            _this = _super.call(this, texture) || this;
            _this._ownCanvas = ownCanvas;
            _this.canvas = canvas;
            _this.context = canvas.getContext('2d');
            _this._resolution = settings.settings.RESOLUTION;
            _this._autoResolution = true;
            _this._text = null;
            _this._style = null;
            _this._styleListener = null;
            _this._font = '';
            _this.text = text;
            _this.style = style;
            _this.localStyleID = -1;
            return _this;
        }
        /**
         * Renders text to its canvas, and updates its texture.
         *
         * By default this is used internally to ensure the texture is correct before rendering,
         * but it can be used called externally, for example from this class to 'pre-generate' the texture from a piece of text,
         * and then shared across multiple Sprites.
         * @param respectDirty - Whether to abort updating the text if the Text isn't dirty and the function is called.
         */
        Text.prototype.updateText = function (respectDirty) {
            var style = this._style;
            // check if style has changed..
            if (this.localStyleID !== style.styleID) {
                this.dirty = true;
                this.localStyleID = style.styleID;
            }
            if (!this.dirty && respectDirty) {
                return;
            }
            this._font = this._style.toFontString();
            var context = this.context;
            var measured = TextMetrics.measureText(this._text || ' ', this._style, this._style.wordWrap, this.canvas);
            var width = measured.width;
            var height = measured.height;
            var lines = measured.lines;
            var lineHeight = measured.lineHeight;
            var lineWidths = measured.lineWidths;
            var maxLineWidth = measured.maxLineWidth;
            var fontProperties = measured.fontProperties;
            this.canvas.width = Math.ceil(Math.ceil((Math.max(1, width) + (style.padding * 2))) * this._resolution);
            this.canvas.height = Math.ceil(Math.ceil((Math.max(1, height) + (style.padding * 2))) * this._resolution);
            context.scale(this._resolution, this._resolution);
            context.clearRect(0, 0, this.canvas.width, this.canvas.height);
            context.font = this._font;
            context.lineWidth = style.strokeThickness;
            context.textBaseline = style.textBaseline;
            context.lineJoin = style.lineJoin;
            context.miterLimit = style.miterLimit;
            var linePositionX;
            var linePositionY;
            // require 2 passes if a shadow; the first to draw the drop shadow, the second to draw the text
            var passesCount = style.dropShadow ? 2 : 1;
            // For v4, we drew text at the colours of the drop shadow underneath the normal text. This gave the correct zIndex,
            // but features such as alpha and shadowblur did not look right at all, since we were using actual text as a shadow.
            //
            // For v5.0.0, we moved over to just use the canvas API for drop shadows, which made them look much nicer and more
            // visually please, but now because the stroke is drawn and then the fill, drop shadows would appear on both the fill
            // and the stroke; and fill drop shadows would appear over the top of the stroke.
            //
            // For v5.1.1, the new route is to revert to v4 style of drawing text first to get the drop shadows underneath normal
            // text, but instead drawing text in the correct location, we'll draw it off screen (-paddingY), and then adjust the
            // drop shadow so only that appears on screen (+paddingY). Now we'll have the correct draw order of the shadow
            // beneath the text, whilst also having the proper text shadow styling.
            for (var i = 0; i < passesCount; ++i) {
                var isShadowPass = style.dropShadow && i === 0;
                // we only want the drop shadow, so put text way off-screen
                var dsOffsetText = isShadowPass ? Math.ceil(Math.max(1, height) + (style.padding * 2)) : 0;
                var dsOffsetShadow = dsOffsetText * this._resolution;
                if (isShadowPass) {
                    // On Safari, text with gradient and drop shadows together do not position correctly
                    // if the scale of the canvas is not 1: https://bugs.webkit.org/show_bug.cgi?id=197689
                    // Therefore we'll set the styles to be a plain black whilst generating this drop shadow
                    context.fillStyle = 'black';
                    context.strokeStyle = 'black';
                    var dropShadowColor = style.dropShadowColor;
                    var rgb = utils.hex2rgb(typeof dropShadowColor === 'number' ? dropShadowColor : utils.string2hex(dropShadowColor));
                    var dropShadowBlur = style.dropShadowBlur * this._resolution;
                    var dropShadowDistance = style.dropShadowDistance * this._resolution;
                    context.shadowColor = "rgba(" + rgb[0] * 255 + "," + rgb[1] * 255 + "," + rgb[2] * 255 + "," + style.dropShadowAlpha + ")";
                    context.shadowBlur = dropShadowBlur;
                    context.shadowOffsetX = Math.cos(style.dropShadowAngle) * dropShadowDistance;
                    context.shadowOffsetY = (Math.sin(style.dropShadowAngle) * dropShadowDistance) + dsOffsetShadow;
                }
                else {
                    // set canvas text styles
                    context.fillStyle = this._generateFillStyle(style, lines, measured);
                    // TODO: Can't have different types for getter and setter. The getter shouldn't have the number type as
                    //       the setter converts to string. See this thread for more details:
                    //       https://github.com/microsoft/TypeScript/issues/2521
                    context.strokeStyle = style.stroke;
                    context.shadowColor = 'black';
                    context.shadowBlur = 0;
                    context.shadowOffsetX = 0;
                    context.shadowOffsetY = 0;
                }
                var linePositionYShift = (lineHeight - fontProperties.fontSize) / 2;
                if (!Text.nextLineHeightBehavior || lineHeight - fontProperties.fontSize < 0) {
                    linePositionYShift = 0;
                }
                // draw lines line by line
                for (var i_1 = 0; i_1 < lines.length; i_1++) {
                    linePositionX = style.strokeThickness / 2;
                    linePositionY = ((style.strokeThickness / 2) + (i_1 * lineHeight)) + fontProperties.ascent
                        + linePositionYShift;
                    if (style.align === 'right') {
                        linePositionX += maxLineWidth - lineWidths[i_1];
                    }
                    else if (style.align === 'center') {
                        linePositionX += (maxLineWidth - lineWidths[i_1]) / 2;
                    }
                    if (style.stroke && style.strokeThickness) {
                        this.drawLetterSpacing(lines[i_1], linePositionX + style.padding, linePositionY + style.padding - dsOffsetText, true);
                    }
                    if (style.fill) {
                        this.drawLetterSpacing(lines[i_1], linePositionX + style.padding, linePositionY + style.padding - dsOffsetText);
                    }
                }
            }
            this.updateTexture();
        };
        /**
         * Render the text with letter-spacing.
         * @param text - The text to draw
         * @param x - Horizontal position to draw the text
         * @param y - Vertical position to draw the text
         * @param isStroke - Is this drawing for the outside stroke of the
         *  text? If not, it's for the inside fill
         */
        Text.prototype.drawLetterSpacing = function (text, x, y, isStroke) {
            if (isStroke === void 0) { isStroke = false; }
            var style = this._style;
            // letterSpacing of 0 means normal
            var letterSpacing = style.letterSpacing;
            // Checking that we can use moddern canvas2D api
            // https://developer.chrome.com/origintrials/#/view_trial/3585991203293757441
            // note: this is unstable API, Chrome less 94 use a `textLetterSpacing`, newest use a letterSpacing
            // eslint-disable-next-line max-len
            var supportLetterSpacing = Text.experimentalLetterSpacing
                && ('letterSpacing' in CanvasRenderingContext2D.prototype
                    || 'textLetterSpacing' in CanvasRenderingContext2D.prototype);
            if (letterSpacing === 0 || supportLetterSpacing) {
                if (supportLetterSpacing) {
                    this.context.letterSpacing = letterSpacing;
                    this.context.textLetterSpacing = letterSpacing;
                }
                if (isStroke) {
                    this.context.strokeText(text, x, y);
                }
                else {
                    this.context.fillText(text, x, y);
                }
                return;
            }
            var currentPosition = x;
            // Using Array.from correctly splits characters whilst keeping emoji together.
            // This is not supported on IE as it requires ES6, so regular text splitting occurs.
            // This also doesn't account for emoji that are multiple emoji put together to make something else.
            // Handling all of this would require a big library itself.
            // https://medium.com/@giltayar/iterating-over-emoji-characters-the-es6-way-f06e4589516
            // https://github.com/orling/grapheme-splitter
            var stringArray = Array.from ? Array.from(text) : text.split('');
            var previousWidth = this.context.measureText(text).width;
            var currentWidth = 0;
            for (var i = 0; i < stringArray.length; ++i) {
                var currentChar = stringArray[i];
                if (isStroke) {
                    this.context.strokeText(currentChar, currentPosition, y);
                }
                else {
                    this.context.fillText(currentChar, currentPosition, y);
                }
                var textStr = '';
                for (var j = i + 1; j < stringArray.length; ++j) {
                    textStr += stringArray[j];
                }
                currentWidth = this.context.measureText(textStr).width;
                currentPosition += previousWidth - currentWidth + letterSpacing;
                previousWidth = currentWidth;
            }
        };
        /** Updates texture size based on canvas size. */
        Text.prototype.updateTexture = function () {
            var canvas = this.canvas;
            if (this._style.trim) {
                var trimmed = utils.trimCanvas(canvas);
                if (trimmed.data) {
                    canvas.width = trimmed.width;
                    canvas.height = trimmed.height;
                    this.context.putImageData(trimmed.data, 0, 0);
                }
            }
            var texture = this._texture;
            var style = this._style;
            var padding = style.trim ? 0 : style.padding;
            var baseTexture = texture.baseTexture;
            texture.trim.width = texture._frame.width = canvas.width / this._resolution;
            texture.trim.height = texture._frame.height = canvas.height / this._resolution;
            texture.trim.x = -padding;
            texture.trim.y = -padding;
            texture.orig.width = texture._frame.width - (padding * 2);
            texture.orig.height = texture._frame.height - (padding * 2);
            // call sprite onTextureUpdate to update scale if _width or _height were set
            this._onTextureUpdate();
            baseTexture.setRealSize(canvas.width, canvas.height, this._resolution);
            texture.updateUvs();
            this.dirty = false;
        };
        /**
         * Renders the object using the WebGL renderer
         * @param renderer - The renderer
         */
        Text.prototype._render = function (renderer) {
            if (this._autoResolution && this._resolution !== renderer.resolution) {
                this._resolution = renderer.resolution;
                this.dirty = true;
            }
            this.updateText(true);
            _super.prototype._render.call(this, renderer);
        };
        /** Updates the transform on all children of this container for rendering. */
        Text.prototype.updateTransform = function () {
            this.updateText(true);
            _super.prototype.updateTransform.call(this);
        };
        Text.prototype.getBounds = function (skipUpdate, rect) {
            this.updateText(true);
            if (this._textureID === -1) {
                // texture was updated: recalculate transforms
                skipUpdate = false;
            }
            return _super.prototype.getBounds.call(this, skipUpdate, rect);
        };
        /**
         * Gets the local bounds of the text object.
         * @param rect - The output rectangle.
         * @returns The bounds.
         */
        Text.prototype.getLocalBounds = function (rect) {
            this.updateText(true);
            return _super.prototype.getLocalBounds.call(this, rect);
        };
        /** Calculates the bounds of the Text as a rectangle. The bounds calculation takes the worldTransform into account. */
        Text.prototype._calculateBounds = function () {
            this.calculateVertices();
            // if we have already done this on THIS frame.
            this._bounds.addQuad(this.vertexData);
        };
        /**
         * Generates the fill style. Can automatically generate a gradient based on the fill style being an array
         * @param style - The style.
         * @param lines - The lines of text.
         * @param metrics
         * @returns The fill style
         */
        Text.prototype._generateFillStyle = function (style, lines, metrics) {
            // TODO: Can't have different types for getter and setter. The getter shouldn't have the number type as
            //       the setter converts to string. See this thread for more details:
            //       https://github.com/microsoft/TypeScript/issues/2521
            var fillStyle = style.fill;
            if (!Array.isArray(fillStyle)) {
                return fillStyle;
            }
            else if (fillStyle.length === 1) {
                return fillStyle[0];
            }
            // the gradient will be evenly spaced out according to how large the array is.
            // ['#FF0000', '#00FF00', '#0000FF'] would created stops at 0.25, 0.5 and 0.75
            var gradient;
            // a dropshadow will enlarge the canvas and result in the gradient being
            // generated with the incorrect dimensions
            var dropShadowCorrection = (style.dropShadow) ? style.dropShadowDistance : 0;
            // should also take padding into account, padding can offset the gradient
            var padding = style.padding || 0;
            var width = (this.canvas.width / this._resolution) - dropShadowCorrection - (padding * 2);
            var height = (this.canvas.height / this._resolution) - dropShadowCorrection - (padding * 2);
            // make a copy of the style settings, so we can manipulate them later
            var fill = fillStyle.slice();
            var fillGradientStops = style.fillGradientStops.slice();
            // wanting to evenly distribute the fills. So an array of 4 colours should give fills of 0.25, 0.5 and 0.75
            if (!fillGradientStops.length) {
                var lengthPlus1 = fill.length + 1;
                for (var i = 1; i < lengthPlus1; ++i) {
                    fillGradientStops.push(i / lengthPlus1);
                }
            }
            // stop the bleeding of the last gradient on the line above to the top gradient of the this line
            // by hard defining the first gradient colour at point 0, and last gradient colour at point 1
            fill.unshift(fillStyle[0]);
            fillGradientStops.unshift(0);
            fill.push(fillStyle[fillStyle.length - 1]);
            fillGradientStops.push(1);
            if (style.fillGradientType === exports.TEXT_GRADIENT.LINEAR_VERTICAL) {
                // start the gradient at the top center of the canvas, and end at the bottom middle of the canvas
                gradient = this.context.createLinearGradient(width / 2, padding, width / 2, height + padding);
                // we need to repeat the gradient so that each individual line of text has the same vertical gradient effect
                // ['#FF0000', '#00FF00', '#0000FF'] over 2 lines would create stops at 0.125, 0.25, 0.375, 0.625, 0.75, 0.875
                // Actual height of the text itself, not counting spacing for lineHeight/leading/dropShadow etc
                var textHeight = metrics.fontProperties.fontSize + style.strokeThickness;
                for (var i = 0; i < lines.length; i++) {
                    var lastLineBottom = (metrics.lineHeight * (i - 1)) + textHeight;
                    var thisLineTop = metrics.lineHeight * i;
                    var thisLineGradientStart = thisLineTop;
                    // Handle case where last & this line overlap
                    if (i > 0 && lastLineBottom > thisLineTop) {
                        thisLineGradientStart = (thisLineTop + lastLineBottom) / 2;
                    }
                    var thisLineBottom = thisLineTop + textHeight;
                    var nextLineTop = metrics.lineHeight * (i + 1);
                    var thisLineGradientEnd = thisLineBottom;
                    // Handle case where this & next line overlap
                    if (i + 1 < lines.length && nextLineTop < thisLineBottom) {
                        thisLineGradientEnd = (thisLineBottom + nextLineTop) / 2;
                    }
                    // textHeight, but as a 0-1 size in global gradient stop space
                    var gradStopLineHeight = (thisLineGradientEnd - thisLineGradientStart) / height;
                    for (var j = 0; j < fill.length; j++) {
                        // 0-1 stop point for the current line, multiplied to global space afterwards
                        var lineStop = 0;
                        if (typeof fillGradientStops[j] === 'number') {
                            lineStop = fillGradientStops[j];
                        }
                        else {
                            lineStop = j / fill.length;
                        }
                        var globalStop = Math.min(1, Math.max(0, (thisLineGradientStart / height) + (lineStop * gradStopLineHeight)));
                        // There's potential for floating point precision issues at the seams between gradient repeats.
                        globalStop = Number(globalStop.toFixed(5));
                        gradient.addColorStop(globalStop, fill[j]);
                    }
                }
            }
            else {
                // start the gradient at the center left of the canvas, and end at the center right of the canvas
                gradient = this.context.createLinearGradient(padding, height / 2, width + padding, height / 2);
                // can just evenly space out the gradients in this case, as multiple lines makes no difference
                // to an even left to right gradient
                var totalIterations = fill.length + 1;
                var currentIteration = 1;
                for (var i = 0; i < fill.length; i++) {
                    var stop = void 0;
                    if (typeof fillGradientStops[i] === 'number') {
                        stop = fillGradientStops[i];
                    }
                    else {
                        stop = currentIteration / totalIterations;
                    }
                    gradient.addColorStop(stop, fill[i]);
                    currentIteration++;
                }
            }
            return gradient;
        };
        /**
         * Destroys this text object.
         *
         * Note* Unlike a Sprite, a Text object will automatically destroy its baseTexture and texture as
         * the majority of the time the texture will not be shared with any other Sprites.
         * @param options - Options parameter. A boolean will act as if all options
         *  have been set to that value
         * @param {boolean} [options.children=false] - if set to true, all the children will have their
         *  destroy method called as well. 'options' will be passed on to those calls.
         * @param {boolean} [options.texture=true] - Should it destroy the current texture of the sprite as well
         * @param {boolean} [options.baseTexture=true] - Should it destroy the base texture of the sprite as well
         */
        Text.prototype.destroy = function (options) {
            if (typeof options === 'boolean') {
                options = { children: options };
            }
            options = Object.assign({}, defaultDestroyOptions, options);
            _super.prototype.destroy.call(this, options);
            // set canvas width and height to 0 to workaround memory leak in Safari < 13
            // https://stackoverflow.com/questions/52532614/total-canvas-memory-use-exceeds-the-maximum-limit-safari-12
            if (this._ownCanvas) {
                this.canvas.height = this.canvas.width = 0;
            }
            // make sure to reset the context and canvas.. dont want this hanging around in memory!
            this.context = null;
            this.canvas = null;
            this._style = null;
        };
        Object.defineProperty(Text.prototype, "width", {
            /** The width of the Text, setting this will actually modify the scale to achieve the value set. */
            get: function () {
                this.updateText(true);
                return Math.abs(this.scale.x) * this._texture.orig.width;
            },
            set: function (value) {
                this.updateText(true);
                var s = utils.sign(this.scale.x) || 1;
                this.scale.x = s * value / this._texture.orig.width;
                this._width = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Text.prototype, "height", {
            /** The height of the Text, setting this will actually modify the scale to achieve the value set. */
            get: function () {
                this.updateText(true);
                return Math.abs(this.scale.y) * this._texture.orig.height;
            },
            set: function (value) {
                this.updateText(true);
                var s = utils.sign(this.scale.y) || 1;
                this.scale.y = s * value / this._texture.orig.height;
                this._height = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Text.prototype, "style", {
            /**
             * Set the style of the text.
             *
             * Set up an event listener to listen for changes on the style object and mark the text as dirty.
             */
            get: function () {
                // TODO: Can't have different types for getter and setter. The getter shouldn't have the ITextStyle
                //       since the setter creates the TextStyle. See this thread for more details:
                //       https://github.com/microsoft/TypeScript/issues/2521
                return this._style;
            },
            set: function (style) {
                style = style || {};
                if (style instanceof TextStyle) {
                    this._style = style;
                }
                else {
                    this._style = new TextStyle(style);
                }
                this.localStyleID = -1;
                this.dirty = true;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Text.prototype, "text", {
            /** Set the copy for the text object. To split a line you can use '\n'. */
            get: function () {
                return this._text;
            },
            set: function (text) {
                text = String(text === null || text === undefined ? '' : text);
                if (this._text === text) {
                    return;
                }
                this._text = text;
                this.dirty = true;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Text.prototype, "resolution", {
            /**
             * The resolution / device pixel ratio of the canvas.
             *
             * This is set to automatically match the renderer resolution by default, but can be overridden by setting manually.
             * @default 1
             */
            get: function () {
                return this._resolution;
            },
            set: function (value) {
                this._autoResolution = false;
                if (this._resolution === value) {
                    return;
                }
                this._resolution = value;
                this.dirty = true;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * New behavior for `lineHeight` that's meant to mimic HTML text. A value of `true` will
         * make sure the first baseline is offset by the `lineHeight` value if it is greater than `fontSize`.
         * A value of `false` will use the legacy behavior and not change the baseline of the first line.
         * In the next major release, we'll enable this by default.
         */
        Text.nextLineHeightBehavior = false;
        /**
         * New rendering behavior for letter-spacing which uses Chrome's new native API. This will
         * lead to more accurate letter-spacing results because it does not try to manually draw
         * each character. However, this Chrome API is experimental and may not serve all cases yet.
         */
        Text.experimentalLetterSpacing = false;
        return Text;
    }(sprite.Sprite));

    exports.Text = Text;
    exports.TextMetrics = TextMetrics;
    exports.TextStyle = TextStyle;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI, PIXI, PIXI.utils);
Object.assign(this.PIXI, _pixi_text);
//# sourceMappingURL=text.js.map
