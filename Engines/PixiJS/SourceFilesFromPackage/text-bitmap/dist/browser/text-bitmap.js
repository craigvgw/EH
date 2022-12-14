/*!
 * @pixi/text-bitmap - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/text-bitmap is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_text_bitmap = (function (exports, math, settings, mesh, utils, core, text, constants, display, loaders) {
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

    /* eslint-disable max-len */
    /**
     * Normalized parsed data from .fnt files.
     * @memberof PIXI
     */
    var BitmapFontData = /** @class */ (function () {
        function BitmapFontData() {
            this.info = [];
            this.common = [];
            this.page = [];
            this.char = [];
            this.kerning = [];
            this.distanceField = [];
        }
        return BitmapFontData;
    }());

    /**
     * BitmapFont format that's Text-based.
     * @private
     */
    var TextFormat = /** @class */ (function () {
        function TextFormat() {
        }
        /**
         * Check if resource refers to txt font data.
         * @param data
         * @returns - True if resource could be treated as font data, false otherwise.
         */
        TextFormat.test = function (data) {
            return typeof data === 'string' && data.indexOf('info face=') === 0;
        };
        /**
         * Convert text font data to a javascript object.
         * @param txt - Raw string data to be converted
         * @returns - Parsed font data
         */
        TextFormat.parse = function (txt) {
            // Retrieve data item
            var items = txt.match(/^[a-z]+\s+.+$/gm);
            var rawData = {
                info: [],
                common: [],
                page: [],
                char: [],
                chars: [],
                kerning: [],
                kernings: [],
                distanceField: [],
            };
            for (var i in items) {
                // Extract item name
                var name = items[i].match(/^[a-z]+/gm)[0];
                // Extract item attribute list as string ex.: "width=10"
                var attributeList = items[i].match(/[a-zA-Z]+=([^\s"']+|"([^"]*)")/gm);
                // Convert attribute list into an object
                var itemData = {};
                for (var i_1 in attributeList) {
                    // Split key-value pairs
                    var split = attributeList[i_1].split('=');
                    var key = split[0];
                    // Remove eventual quotes from value
                    var strValue = split[1].replace(/"/gm, '');
                    // Try to convert value into float
                    var floatValue = parseFloat(strValue);
                    // Use string value case float value is NaN
                    var value = isNaN(floatValue) ? strValue : floatValue;
                    itemData[key] = value;
                }
                // Push current item to the resulting data
                rawData[name].push(itemData);
            }
            var font = new BitmapFontData();
            rawData.info.forEach(function (info) { return font.info.push({
                face: info.face,
                size: parseInt(info.size, 10),
            }); });
            rawData.common.forEach(function (common) { return font.common.push({
                lineHeight: parseInt(common.lineHeight, 10),
            }); });
            rawData.page.forEach(function (page) { return font.page.push({
                id: parseInt(page.id, 10),
                file: page.file,
            }); });
            rawData.char.forEach(function (char) { return font.char.push({
                id: parseInt(char.id, 10),
                page: parseInt(char.page, 10),
                x: parseInt(char.x, 10),
                y: parseInt(char.y, 10),
                width: parseInt(char.width, 10),
                height: parseInt(char.height, 10),
                xoffset: parseInt(char.xoffset, 10),
                yoffset: parseInt(char.yoffset, 10),
                xadvance: parseInt(char.xadvance, 10),
            }); });
            rawData.kerning.forEach(function (kerning) { return font.kerning.push({
                first: parseInt(kerning.first, 10),
                second: parseInt(kerning.second, 10),
                amount: parseInt(kerning.amount, 10),
            }); });
            rawData.distanceField.forEach(function (df) { return font.distanceField.push({
                distanceRange: parseInt(df.distanceRange, 10),
                fieldType: df.fieldType,
            }); });
            return font;
        };
        return TextFormat;
    }());

    /**
     * BitmapFont format that's XML-based.
     * @private
     */
    var XMLFormat = /** @class */ (function () {
        function XMLFormat() {
        }
        /**
         * Check if resource refers to xml font data.
         * @param data
         * @returns - True if resource could be treated as font data, false otherwise.
         */
        XMLFormat.test = function (data) {
            return data instanceof XMLDocument
                && data.getElementsByTagName('page').length
                && data.getElementsByTagName('info')[0].getAttribute('face') !== null;
        };
        /**
         * Convert the XML into BitmapFontData that we can use.
         * @param xml
         * @returns - Data to use for BitmapFont
         */
        XMLFormat.parse = function (xml) {
            var data = new BitmapFontData();
            var info = xml.getElementsByTagName('info');
            var common = xml.getElementsByTagName('common');
            var page = xml.getElementsByTagName('page');
            var char = xml.getElementsByTagName('char');
            var kerning = xml.getElementsByTagName('kerning');
            var distanceField = xml.getElementsByTagName('distanceField');
            for (var i = 0; i < info.length; i++) {
                data.info.push({
                    face: info[i].getAttribute('face'),
                    size: parseInt(info[i].getAttribute('size'), 10),
                });
            }
            for (var i = 0; i < common.length; i++) {
                data.common.push({
                    lineHeight: parseInt(common[i].getAttribute('lineHeight'), 10),
                });
            }
            for (var i = 0; i < page.length; i++) {
                data.page.push({
                    id: parseInt(page[i].getAttribute('id'), 10) || 0,
                    file: page[i].getAttribute('file'),
                });
            }
            for (var i = 0; i < char.length; i++) {
                var letter = char[i];
                data.char.push({
                    id: parseInt(letter.getAttribute('id'), 10),
                    page: parseInt(letter.getAttribute('page'), 10) || 0,
                    x: parseInt(letter.getAttribute('x'), 10),
                    y: parseInt(letter.getAttribute('y'), 10),
                    width: parseInt(letter.getAttribute('width'), 10),
                    height: parseInt(letter.getAttribute('height'), 10),
                    xoffset: parseInt(letter.getAttribute('xoffset'), 10),
                    yoffset: parseInt(letter.getAttribute('yoffset'), 10),
                    xadvance: parseInt(letter.getAttribute('xadvance'), 10),
                });
            }
            for (var i = 0; i < kerning.length; i++) {
                data.kerning.push({
                    first: parseInt(kerning[i].getAttribute('first'), 10),
                    second: parseInt(kerning[i].getAttribute('second'), 10),
                    amount: parseInt(kerning[i].getAttribute('amount'), 10),
                });
            }
            for (var i = 0; i < distanceField.length; i++) {
                data.distanceField.push({
                    fieldType: distanceField[i].getAttribute('fieldType'),
                    distanceRange: parseInt(distanceField[i].getAttribute('distanceRange'), 10),
                });
            }
            return data;
        };
        return XMLFormat;
    }());

    /**
     * BitmapFont format that's XML-based.
     * @private
     */
    var XMLStringFormat = /** @class */ (function () {
        function XMLStringFormat() {
        }
        /**
         * Check if resource refers to text xml font data.
         * @param data
         * @returns - True if resource could be treated as font data, false otherwise.
         */
        XMLStringFormat.test = function (data) {
            if (typeof data === 'string' && data.indexOf('<font>') > -1) {
                var xml = new globalThis.DOMParser().parseFromString(data, 'text/xml');
                return XMLFormat.test(xml);
            }
            return false;
        };
        /**
         * Convert the text XML into BitmapFontData that we can use.
         * @param xmlTxt
         * @returns - Data to use for BitmapFont
         */
        XMLStringFormat.parse = function (xmlTxt) {
            var xml = new globalThis.DOMParser().parseFromString(xmlTxt, 'text/xml');
            return XMLFormat.parse(xml);
        };
        return XMLStringFormat;
    }());

    // Registered formats, maybe make this extensible in the future?
    var formats = [
        TextFormat,
        XMLFormat,
        XMLStringFormat ];
    /**
     * Auto-detect BitmapFont parsing format based on data.
     * @private
     * @param {any} data - Data to detect format
     * @returns {any} Format or null
     */
    function autoDetectFormat(data) {
        for (var i = 0; i < formats.length; i++) {
            if (formats[i].test(data)) {
                return formats[i];
            }
        }
        return null;
    }

    // TODO: Prevent code duplication b/w generateFillStyle & Text#generateFillStyle
    /**
     * Generates the fill style. Can automatically generate a gradient based on the fill style being an array
     * @private
     * @param canvas
     * @param context
     * @param {object} style - The style.
     * @param resolution
     * @param {string[]} lines - The lines of text.
     * @param metrics
     * @returns {string|number|CanvasGradient} The fill style
     */
    function generateFillStyle(canvas, context, style, resolution, lines, metrics) {
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
        var width = (canvas.width / resolution) - dropShadowCorrection - (padding * 2);
        var height = (canvas.height / resolution) - dropShadowCorrection - (padding * 2);
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
        if (style.fillGradientType === text.TEXT_GRADIENT.LINEAR_VERTICAL) {
            // start the gradient at the top center of the canvas, and end at the bottom middle of the canvas
            gradient = context.createLinearGradient(width / 2, padding, width / 2, height + padding);
            // we need to repeat the gradient so that each individual line of text has the same vertical gradient effect
            // ['#FF0000', '#00FF00', '#0000FF'] over 2 lines would create stops at 0.125, 0.25, 0.375, 0.625, 0.75, 0.875
            // There's potential for floating point precision issues at the seams between gradient repeats.
            // The loop below generates the stops in order, so track the last generated one to prevent
            // floating point precision from making us go the teeniest bit backwards, resulting in
            // the first and last colors getting swapped.
            var lastIterationStop = 0;
            // Actual height of the text itself, not counting spacing for lineHeight/leading/dropShadow etc
            var textHeight = metrics.fontProperties.fontSize + style.strokeThickness;
            // textHeight, but as a 0-1 size in global gradient stop space
            var gradStopLineHeight = textHeight / height;
            for (var i = 0; i < lines.length; i++) {
                var thisLineTop = metrics.lineHeight * i;
                for (var j = 0; j < fill.length; j++) {
                    // 0-1 stop point for the current line, multiplied to global space afterwards
                    var lineStop = 0;
                    if (typeof fillGradientStops[j] === 'number') {
                        lineStop = fillGradientStops[j];
                    }
                    else {
                        lineStop = j / fill.length;
                    }
                    var globalStop = (thisLineTop / height) + (lineStop * gradStopLineHeight);
                    // Prevent color stop generation going backwards from floating point imprecision
                    var clampedStop = Math.max(lastIterationStop, globalStop);
                    clampedStop = Math.min(clampedStop, 1); // Cap at 1 as well for safety's sake to avoid a possible throw.
                    gradient.addColorStop(clampedStop, fill[j]);
                    lastIterationStop = clampedStop;
                }
            }
        }
        else {
            // start the gradient at the center left of the canvas, and end at the center right of the canvas
            gradient = context.createLinearGradient(padding, height / 2, width + padding, height / 2);
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
    }

    // TODO: Prevent code duplication b/w drawGlyph & Text#updateText
    /**
     * Draws the glyph `metrics.text` on the given canvas.
     *
     * Ignored because not directly exposed.
     * @ignore
     * @param {HTMLCanvasElement} canvas
     * @param {CanvasRenderingContext2D} context
     * @param {TextMetrics} metrics
     * @param {number} x
     * @param {number} y
     * @param {number} resolution
     * @param {TextStyle} style
     */
    function drawGlyph(canvas, context, metrics, x, y, resolution, style) {
        var char = metrics.text;
        var fontProperties = metrics.fontProperties;
        context.translate(x, y);
        context.scale(resolution, resolution);
        var tx = style.strokeThickness / 2;
        var ty = -(style.strokeThickness / 2);
        context.font = style.toFontString();
        context.lineWidth = style.strokeThickness;
        context.textBaseline = style.textBaseline;
        context.lineJoin = style.lineJoin;
        context.miterLimit = style.miterLimit;
        // set canvas text styles
        context.fillStyle = generateFillStyle(canvas, context, style, resolution, [char], metrics);
        context.strokeStyle = style.stroke;
        if (style.dropShadow) {
            var dropShadowColor = style.dropShadowColor;
            var rgb = utils.hex2rgb(typeof dropShadowColor === 'number' ? dropShadowColor : utils.string2hex(dropShadowColor));
            var dropShadowBlur = style.dropShadowBlur * resolution;
            var dropShadowDistance = style.dropShadowDistance * resolution;
            context.shadowColor = "rgba(" + rgb[0] * 255 + "," + rgb[1] * 255 + "," + rgb[2] * 255 + "," + style.dropShadowAlpha + ")";
            context.shadowBlur = dropShadowBlur;
            context.shadowOffsetX = Math.cos(style.dropShadowAngle) * dropShadowDistance;
            context.shadowOffsetY = Math.sin(style.dropShadowAngle) * dropShadowDistance;
        }
        else {
            context.shadowColor = 'black';
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
        }
        if (style.stroke && style.strokeThickness) {
            context.strokeText(char, tx, ty + metrics.lineHeight - fontProperties.descent);
        }
        if (style.fill) {
            context.fillText(char, tx, ty + metrics.lineHeight - fontProperties.descent);
        }
        context.setTransform(1, 0, 0, 1, 0, 0); // defaults needed for older browsers (e.g. Opera 29)
        context.fillStyle = 'rgba(0, 0, 0, 0)';
    }

    /**
     * Ponyfill for IE because it doesn't support `Array.from`
     * @param text
     * @private
     */
    function splitTextToCharacters(text) {
        return Array.from ? Array.from(text) : text.split('');
    }

    /**
     * Processes the passed character set data and returns a flattened array of all the characters.
     *
     * Ignored because not directly exposed.
     * @ignore
     * @param {string | string[] | string[][] } chars
     * @returns {string[]} the flattened array of characters
     */
    function resolveCharacters(chars) {
        // Split the chars string into individual characters
        if (typeof chars === 'string') {
            chars = [chars];
        }
        // Handle an array of characters+ranges
        var result = [];
        for (var i = 0, j = chars.length; i < j; i++) {
            var item = chars[i];
            // Handle range delimited by start/end chars
            if (Array.isArray(item)) {
                if (item.length !== 2) {
                    throw new Error("[BitmapFont]: Invalid character range length, expecting 2 got " + item.length + ".");
                }
                var startCode = item[0].charCodeAt(0);
                var endCode = item[1].charCodeAt(0);
                if (endCode < startCode) {
                    throw new Error('[BitmapFont]: Invalid character range.');
                }
                for (var i_1 = startCode, j_1 = endCode; i_1 <= j_1; i_1++) {
                    result.push(String.fromCharCode(i_1));
                }
            }
            // Handle a character set string
            else {
                result.push.apply(result, splitTextToCharacters(item));
            }
        }
        if (result.length === 0) {
            throw new Error('[BitmapFont]: Empty set when resolving characters.');
        }
        return result;
    }

    /**
     * Ponyfill for IE because it doesn't support `codePointAt`
     * @param str
     * @private
     */
    function extractCharCode(str) {
        return str.codePointAt ? str.codePointAt(0) : str.charCodeAt(0);
    }

    /**
     * BitmapFont represents a typeface available for use with the BitmapText class. Use the `install`
     * method for adding a font to be used.
     * @memberof PIXI
     */
    var BitmapFont = /** @class */ (function () {
        /**
         * @param data
         * @param textures
         * @param ownsTextures - Setting to `true` will destroy page textures
         *        when the font is uninstalled.
         */
        function BitmapFont(data, textures, ownsTextures) {
            var _a, _b;
            var info = data.info[0];
            var common = data.common[0];
            var page = data.page[0];
            var distanceField = data.distanceField[0];
            var res = utils.getResolutionOfUrl(page.file);
            var pageTextures = {};
            this._ownsTextures = ownsTextures;
            this.font = info.face;
            this.size = info.size;
            this.lineHeight = common.lineHeight / res;
            this.chars = {};
            this.pageTextures = pageTextures;
            // Convert the input Texture, Textures or object
            // into a page Texture lookup by "id"
            for (var i = 0; i < data.page.length; i++) {
                var _c = data.page[i], id = _c.id, file = _c.file;
                pageTextures[id] = textures instanceof Array
                    ? textures[i] : textures[file];
                // only MSDF and SDF fonts need no-premultiplied-alpha
                if ((distanceField === null || distanceField === void 0 ? void 0 : distanceField.fieldType) && distanceField.fieldType !== 'none') {
                    pageTextures[id].baseTexture.alphaMode = constants.ALPHA_MODES.NO_PREMULTIPLIED_ALPHA;
                }
            }
            // parse letters
            for (var i = 0; i < data.char.length; i++) {
                var _d = data.char[i], id = _d.id, page_1 = _d.page;
                var _e = data.char[i], x = _e.x, y = _e.y, width = _e.width, height = _e.height, xoffset = _e.xoffset, yoffset = _e.yoffset, xadvance = _e.xadvance;
                x /= res;
                y /= res;
                width /= res;
                height /= res;
                xoffset /= res;
                yoffset /= res;
                xadvance /= res;
                var rect = new math.Rectangle(x + (pageTextures[page_1].frame.x / res), y + (pageTextures[page_1].frame.y / res), width, height);
                this.chars[id] = {
                    xOffset: xoffset,
                    yOffset: yoffset,
                    xAdvance: xadvance,
                    kerning: {},
                    texture: new core.Texture(pageTextures[page_1].baseTexture, rect),
                    page: page_1,
                };
            }
            // parse kernings
            for (var i = 0; i < data.kerning.length; i++) {
                var _f = data.kerning[i], first = _f.first, second = _f.second, amount = _f.amount;
                first /= res;
                second /= res;
                amount /= res;
                if (this.chars[second]) {
                    this.chars[second].kerning[first] = amount;
                }
            }
            // Store distance field information
            this.distanceFieldRange = distanceField === null || distanceField === void 0 ? void 0 : distanceField.distanceRange;
            this.distanceFieldType = (_b = (_a = distanceField === null || distanceField === void 0 ? void 0 : distanceField.fieldType) === null || _a === void 0 ? void 0 : _a.toLowerCase()) !== null && _b !== void 0 ? _b : 'none';
        }
        /** Remove references to created glyph textures. */
        BitmapFont.prototype.destroy = function () {
            for (var id in this.chars) {
                this.chars[id].texture.destroy();
                this.chars[id].texture = null;
            }
            for (var id in this.pageTextures) {
                if (this._ownsTextures) {
                    this.pageTextures[id].destroy(true);
                }
                this.pageTextures[id] = null;
            }
            // Set readonly null.
            this.chars = null;
            this.pageTextures = null;
        };
        /**
         * Register a new bitmap font.
         * @param data - The
         *        characters map that could be provided as xml or raw string.
         * @param textures - List of textures for each page.
         * @param ownsTextures - Set to `true` to destroy page textures
         *        when the font is uninstalled. By default fonts created with
         *        `BitmapFont.from` or from the `BitmapFontLoader` are `true`.
         * @returns {PIXI.BitmapFont} Result font object with font, size, lineHeight
         *         and char fields.
         */
        BitmapFont.install = function (data, textures, ownsTextures) {
            var fontData;
            if (data instanceof BitmapFontData) {
                fontData = data;
            }
            else {
                var format = autoDetectFormat(data);
                if (!format) {
                    throw new Error('Unrecognized data format for font.');
                }
                fontData = format.parse(data);
            }
            // Single texture, convert to list
            if (textures instanceof core.Texture) {
                textures = [textures];
            }
            var font = new BitmapFont(fontData, textures, ownsTextures);
            BitmapFont.available[font.font] = font;
            return font;
        };
        /**
         * Remove bitmap font by name.
         * @param name - Name of the font to uninstall.
         */
        BitmapFont.uninstall = function (name) {
            var font = BitmapFont.available[name];
            if (!font) {
                throw new Error("No font found named '" + name + "'");
            }
            font.destroy();
            delete BitmapFont.available[name];
        };
        /**
         * Generates a bitmap-font for the given style and character set. This does not support
         * kernings yet. With `style` properties, only the following non-layout properties are used:
         *
         * - {@link PIXI.TextStyle#dropShadow|dropShadow}
         * - {@link PIXI.TextStyle#dropShadowDistance|dropShadowDistance}
         * - {@link PIXI.TextStyle#dropShadowColor|dropShadowColor}
         * - {@link PIXI.TextStyle#dropShadowBlur|dropShadowBlur}
         * - {@link PIXI.TextStyle#dropShadowAngle|dropShadowAngle}
         * - {@link PIXI.TextStyle#fill|fill}
         * - {@link PIXI.TextStyle#fillGradientStops|fillGradientStops}
         * - {@link PIXI.TextStyle#fillGradientType|fillGradientType}
         * - {@link PIXI.TextStyle#fontFamily|fontFamily}
         * - {@link PIXI.TextStyle#fontSize|fontSize}
         * - {@link PIXI.TextStyle#fontVariant|fontVariant}
         * - {@link PIXI.TextStyle#fontWeight|fontWeight}
         * - {@link PIXI.TextStyle#lineJoin|lineJoin}
         * - {@link PIXI.TextStyle#miterLimit|miterLimit}
         * - {@link PIXI.TextStyle#stroke|stroke}
         * - {@link PIXI.TextStyle#strokeThickness|strokeThickness}
         * - {@link PIXI.TextStyle#textBaseline|textBaseline}
         * @param name - The name of the custom font to use with BitmapText.
         * @param textStyle - Style options to render with BitmapFont.
         * @param options - Setup options for font or name of the font.
         * @param {string|string[]|string[][]} [options.chars=PIXI.BitmapFont.ALPHANUMERIC] - characters included
         *      in the font set. You can also use ranges. For example, `[['a', 'z'], ['A', 'Z'], "!@#$%^&*()~{}[] "]`.
         *      Don't forget to include spaces ' ' in your character set!
         * @param {number} [options.resolution=1] - Render resolution for glyphs.
         * @param {number} [options.textureWidth=512] - Optional width of atlas, smaller values to reduce memory.
         * @param {number} [options.textureHeight=512] - Optional height of atlas, smaller values to reduce memory.
         * @param {number} [options.padding=4] - Padding between glyphs on texture atlas.
         * @returns Font generated by style options.
         * @example
         * PIXI.BitmapFont.from("TitleFont", {
         *     fontFamily: "Arial",
         *     fontSize: 12,
         *     strokeThickness: 2,
         *     fill: "purple"
         * });
         *
         * const title = new PIXI.BitmapText("This is the title", { fontName: "TitleFont" });
         */
        BitmapFont.from = function (name, textStyle, options) {
            if (!name) {
                throw new Error('[BitmapFont] Property `name` is required.');
            }
            var _a = Object.assign({}, BitmapFont.defaultOptions, options), chars = _a.chars, padding = _a.padding, resolution = _a.resolution, textureWidth = _a.textureWidth, textureHeight = _a.textureHeight;
            var charsList = resolveCharacters(chars);
            var style = textStyle instanceof text.TextStyle ? textStyle : new text.TextStyle(textStyle);
            var lineWidth = textureWidth;
            var fontData = new BitmapFontData();
            fontData.info[0] = {
                face: style.fontFamily,
                size: style.fontSize,
            };
            fontData.common[0] = {
                lineHeight: style.fontSize,
            };
            var positionX = 0;
            var positionY = 0;
            var canvas;
            var context;
            var baseTexture;
            var maxCharHeight = 0;
            var baseTextures = [];
            var textures = [];
            for (var i = 0; i < charsList.length; i++) {
                if (!canvas) {
                    canvas = settings.settings.ADAPTER.createCanvas();
                    canvas.width = textureWidth;
                    canvas.height = textureHeight;
                    context = canvas.getContext('2d');
                    baseTexture = new core.BaseTexture(canvas, { resolution: resolution });
                    baseTextures.push(baseTexture);
                    textures.push(new core.Texture(baseTexture));
                    fontData.page.push({
                        id: textures.length - 1,
                        file: '',
                    });
                }
                // Measure glyph dimensions
                var metrics = text.TextMetrics.measureText(charsList[i], style, false, canvas);
                var width = metrics.width;
                var height = Math.ceil(metrics.height);
                // This is ugly - but italics are given more space so they don't overlap
                var textureGlyphWidth = Math.ceil((style.fontStyle === 'italic' ? 2 : 1) * width);
                // Can't fit char anymore: next canvas please!
                if (positionY >= textureHeight - (height * resolution)) {
                    if (positionY === 0) {
                        // We don't want user debugging an infinite loop (or do we? :)
                        throw new Error("[BitmapFont] textureHeight " + textureHeight + "px is "
                            + ("too small for " + style.fontSize + "px fonts"));
                    }
                    --i;
                    // Create new atlas once current has filled up
                    canvas = null;
                    context = null;
                    baseTexture = null;
                    positionY = 0;
                    positionX = 0;
                    maxCharHeight = 0;
                    continue;
                }
                maxCharHeight = Math.max(height + metrics.fontProperties.descent, maxCharHeight);
                // Wrap line once full row has been rendered
                if ((textureGlyphWidth * resolution) + positionX >= lineWidth) {
                    --i;
                    positionY += maxCharHeight * resolution;
                    positionY = Math.ceil(positionY);
                    positionX = 0;
                    maxCharHeight = 0;
                    continue;
                }
                drawGlyph(canvas, context, metrics, positionX, positionY, resolution, style);
                // Unique (numeric) ID mapping to this glyph
                var id = extractCharCode(metrics.text);
                // Create a texture holding just the glyph
                fontData.char.push({
                    id: id,
                    page: textures.length - 1,
                    x: positionX / resolution,
                    y: positionY / resolution,
                    width: textureGlyphWidth,
                    height: height,
                    xoffset: 0,
                    yoffset: 0,
                    xadvance: Math.ceil(width
                        - (style.dropShadow ? style.dropShadowDistance : 0)
                        - (style.stroke ? style.strokeThickness : 0)),
                });
                positionX += (textureGlyphWidth + (2 * padding)) * resolution;
                positionX = Math.ceil(positionX);
            }
            // Brute-force kerning info, this can be expensive b/c it's an O(n??),
            // but we're using measureText which is native and fast.
            for (var i = 0, len = charsList.length; i < len; i++) {
                var first = charsList[i];
                for (var j = 0; j < len; j++) {
                    var second = charsList[j];
                    var c1 = context.measureText(first).width;
                    var c2 = context.measureText(second).width;
                    var total = context.measureText(first + second).width;
                    var amount = total - (c1 + c2);
                    if (amount) {
                        fontData.kerning.push({
                            first: extractCharCode(first),
                            second: extractCharCode(second),
                            amount: amount,
                        });
                    }
                }
            }
            var font = new BitmapFont(fontData, textures, true);
            // Make it easier to replace a font
            if (BitmapFont.available[name] !== undefined) {
                BitmapFont.uninstall(name);
            }
            BitmapFont.available[name] = font;
            return font;
        };
        /**
         * This character set includes all the letters in the alphabet (both lower- and upper- case).
         * @type {string[][]}
         * @example
         * BitmapFont.from("ExampleFont", style, { chars: BitmapFont.ALPHA })
         */
        BitmapFont.ALPHA = [['a', 'z'], ['A', 'Z'], ' '];
        /**
         * This character set includes all decimal digits (from 0 to 9).
         * @type {string[][]}
         * @example
         * BitmapFont.from("ExampleFont", style, { chars: BitmapFont.NUMERIC })
         */
        BitmapFont.NUMERIC = [['0', '9']];
        /**
         * This character set is the union of `BitmapFont.ALPHA` and `BitmapFont.NUMERIC`.
         * @type {string[][]}
         */
        BitmapFont.ALPHANUMERIC = [['a', 'z'], ['A', 'Z'], ['0', '9'], ' '];
        /**
         * This character set consists of all the ASCII table.
         * @member {string[][]}
         * @see http://www.asciitable.com/
         */
        BitmapFont.ASCII = [[' ', '~']];
        /**
         * Collection of default options when using `BitmapFont.from`.
         * @property {number} [resolution=1] -
         * @property {number} [textureWidth=512] -
         * @property {number} [textureHeight=512] -
         * @property {number} [padding=4] -
         * @property {string|string[]|string[][]} chars = PIXI.BitmapFont.ALPHANUMERIC
         */
        BitmapFont.defaultOptions = {
            resolution: 1,
            textureWidth: 512,
            textureHeight: 512,
            padding: 4,
            chars: BitmapFont.ALPHANUMERIC,
        };
        /** Collection of available/installed fonts. */
        BitmapFont.available = {};
        return BitmapFont;
    }());

    var msdfFrag = "// Pixi texture info\r\nvarying vec2 vTextureCoord;\r\nuniform sampler2D uSampler;\r\n\r\n// Tint\r\nuniform vec4 uColor;\r\n\r\n// on 2D applications fwidth is screenScale / glyphAtlasScale * distanceFieldRange\r\nuniform float uFWidth;\r\n\r\nvoid main(void) {\r\n\r\n  // To stack MSDF and SDF we need a non-pre-multiplied-alpha texture.\r\n  vec4 texColor = texture2D(uSampler, vTextureCoord);\r\n\r\n  // MSDF\r\n  float median = texColor.r + texColor.g + texColor.b -\r\n                  min(texColor.r, min(texColor.g, texColor.b)) -\r\n                  max(texColor.r, max(texColor.g, texColor.b));\r\n  // SDF\r\n  median = min(median, texColor.a);\r\n\r\n  float screenPxDistance = uFWidth * (median - 0.5);\r\n  float alpha = clamp(screenPxDistance + 0.5, 0.0, 1.0);\r\n\r\n  // NPM Textures, NPM outputs\r\n  gl_FragColor = vec4(uColor.rgb, uColor.a * alpha);\r\n\r\n}\r\n";

    var msdfVert = "// Mesh material default fragment\r\nattribute vec2 aVertexPosition;\r\nattribute vec2 aTextureCoord;\r\n\r\nuniform mat3 projectionMatrix;\r\nuniform mat3 translationMatrix;\r\nuniform mat3 uTextureMatrix;\r\n\r\nvarying vec2 vTextureCoord;\r\n\r\nvoid main(void)\r\n{\r\n    gl_Position = vec4((projectionMatrix * translationMatrix * vec3(aVertexPosition, 1.0)).xy, 0.0, 1.0);\r\n\r\n    vTextureCoord = (uTextureMatrix * vec3(aTextureCoord, 1.0)).xy;\r\n}\r\n";

    // If we ever need more than two pools, please make a Dict or something better.
    var pageMeshDataDefaultPageMeshData = [];
    var pageMeshDataMSDFPageMeshData = [];
    var charRenderDataPool = [];
    /**
     * A BitmapText object will create a line or multiple lines of text using bitmap font.
     *
     * The primary advantage of this class over Text is that all of your textures are pre-generated and loading,
     * meaning that rendering is fast, and changing text has no performance implications.
     *
     * Supporting character sets other than latin, such as CJK languages, may be impractical due to the number of characters.
     *
     * To split a line you can use '\n', '\r' or '\r\n' in your string.
     *
     * PixiJS can auto-generate fonts on-the-fly using BitmapFont or use fnt files provided by:
     * http://www.angelcode.com/products/bmfont/ for Windows or
     * http://www.bmglyph.com/ for Mac.
     *
     * You can also use SDF, MSDF and MTSDF BitmapFonts for vector-like scaling appearance provided by:
     * https://github.com/soimy/msdf-bmfont-xml for SDF and MSDF fnt files or
     * https://github.com/Chlumsky/msdf-atlas-gen for SDF, MSDF and MTSDF json files
     *
     * A BitmapText can only be created when the font is loaded.
     *
     * ```js
     * // in this case the font is in a file called 'desyrel.fnt'
     * let bitmapText = new PIXI.BitmapText("text using a fancy font!", {
     *   fontName: "Desyrel",
     *   fontSize: 35,
     *   align: "right"
     * });
     * ```
     * @memberof PIXI
     */
    var BitmapText = /** @class */ (function (_super) {
        __extends(BitmapText, _super);
        /**
         * @param text - A string that you would like the text to display.
         * @param style - The style parameters.
         * @param {string} style.fontName - The installed BitmapFont name.
         * @param {number} [style.fontSize] - The size of the font in pixels, e.g. 24. If undefined,
         *.     this will default to the BitmapFont size.
         * @param {string} [style.align='left'] - Alignment for multiline text ('left', 'center', 'right' or 'justify'),
         *      does not affect single line text.
         * @param {number} [style.tint=0xFFFFFF] - The tint color.
         * @param {number} [style.letterSpacing=0] - The amount of spacing between letters.
         * @param {number} [style.maxWidth=0] - The max width of the text before line wrapping.
         */
        function BitmapText(text, style) {
            if (style === void 0) { style = {}; }
            var _this = _super.call(this) || this;
            /**
             * Private tracker for the current tint.
             * @private
             */
            _this._tint = 0xFFFFFF;
            // Apply the defaults
            var _a = Object.assign({}, BitmapText.styleDefaults, style), align = _a.align, tint = _a.tint, maxWidth = _a.maxWidth, letterSpacing = _a.letterSpacing, fontName = _a.fontName, fontSize = _a.fontSize;
            if (!BitmapFont.available[fontName]) {
                throw new Error("Missing BitmapFont \"" + fontName + "\"");
            }
            _this._activePagesMeshData = [];
            _this._textWidth = 0;
            _this._textHeight = 0;
            _this._align = align;
            _this._tint = tint;
            _this._fontName = fontName;
            _this._fontSize = fontSize || BitmapFont.available[fontName].size;
            _this.text = text;
            _this._maxWidth = maxWidth;
            _this._maxLineHeight = 0;
            _this._letterSpacing = letterSpacing;
            _this._anchor = new math.ObservablePoint(function () { _this.dirty = true; }, _this, 0, 0);
            _this._roundPixels = settings.settings.ROUND_PIXELS;
            _this.dirty = true;
            _this._resolution = settings.settings.RESOLUTION;
            _this._autoResolution = true;
            _this._textureCache = {};
            return _this;
        }
        /** Renders text and updates it when needed. This should only be called if the BitmapFont is regenerated. */
        BitmapText.prototype.updateText = function () {
            var _a;
            var data = BitmapFont.available[this._fontName];
            var scale = this._fontSize / data.size;
            var pos = new math.Point();
            var chars = [];
            var lineWidths = [];
            var lineSpaces = [];
            var text = this._text.replace(/(?:\r\n|\r)/g, '\n') || ' ';
            var charsInput = splitTextToCharacters(text);
            var maxWidth = this._maxWidth * data.size / this._fontSize;
            var pageMeshDataPool = data.distanceFieldType === 'none'
                ? pageMeshDataDefaultPageMeshData : pageMeshDataMSDFPageMeshData;
            var prevCharCode = null;
            var lastLineWidth = 0;
            var maxLineWidth = 0;
            var line = 0;
            var lastBreakPos = -1;
            var lastBreakWidth = 0;
            var spacesRemoved = 0;
            var maxLineHeight = 0;
            var spaceCount = 0;
            for (var i = 0; i < charsInput.length; i++) {
                var char = charsInput[i];
                var charCode = extractCharCode(char);
                if ((/(?:\s)/).test(char)) {
                    lastBreakPos = i;
                    lastBreakWidth = lastLineWidth;
                    spaceCount++;
                }
                if (char === '\r' || char === '\n') {
                    lineWidths.push(lastLineWidth);
                    lineSpaces.push(-1);
                    maxLineWidth = Math.max(maxLineWidth, lastLineWidth);
                    ++line;
                    ++spacesRemoved;
                    pos.x = 0;
                    pos.y += data.lineHeight;
                    prevCharCode = null;
                    spaceCount = 0;
                    continue;
                }
                var charData = data.chars[charCode];
                if (!charData) {
                    continue;
                }
                if (prevCharCode && charData.kerning[prevCharCode]) {
                    pos.x += charData.kerning[prevCharCode];
                }
                var charRenderData = charRenderDataPool.pop() || {
                    texture: core.Texture.EMPTY,
                    line: 0,
                    charCode: 0,
                    prevSpaces: 0,
                    position: new math.Point(),
                };
                charRenderData.texture = charData.texture;
                charRenderData.line = line;
                charRenderData.charCode = charCode;
                charRenderData.position.x = pos.x + charData.xOffset + (this._letterSpacing / 2);
                charRenderData.position.y = pos.y + charData.yOffset;
                charRenderData.prevSpaces = spaceCount;
                chars.push(charRenderData);
                lastLineWidth = charRenderData.position.x
                    + Math.max(charData.xAdvance - charData.xOffset, charData.texture.orig.width);
                pos.x += charData.xAdvance + this._letterSpacing;
                maxLineHeight = Math.max(maxLineHeight, (charData.yOffset + charData.texture.height));
                prevCharCode = charCode;
                if (lastBreakPos !== -1 && maxWidth > 0 && pos.x > maxWidth) {
                    ++spacesRemoved;
                    utils.removeItems(chars, 1 + lastBreakPos - spacesRemoved, 1 + i - lastBreakPos);
                    i = lastBreakPos;
                    lastBreakPos = -1;
                    lineWidths.push(lastBreakWidth);
                    lineSpaces.push(chars.length > 0 ? chars[chars.length - 1].prevSpaces : 0);
                    maxLineWidth = Math.max(maxLineWidth, lastBreakWidth);
                    line++;
                    pos.x = 0;
                    pos.y += data.lineHeight;
                    prevCharCode = null;
                    spaceCount = 0;
                }
            }
            var lastChar = charsInput[charsInput.length - 1];
            if (lastChar !== '\r' && lastChar !== '\n') {
                if ((/(?:\s)/).test(lastChar)) {
                    lastLineWidth = lastBreakWidth;
                }
                lineWidths.push(lastLineWidth);
                maxLineWidth = Math.max(maxLineWidth, lastLineWidth);
                lineSpaces.push(-1);
            }
            var lineAlignOffsets = [];
            for (var i = 0; i <= line; i++) {
                var alignOffset = 0;
                if (this._align === 'right') {
                    alignOffset = maxLineWidth - lineWidths[i];
                }
                else if (this._align === 'center') {
                    alignOffset = (maxLineWidth - lineWidths[i]) / 2;
                }
                else if (this._align === 'justify') {
                    alignOffset = lineSpaces[i] < 0 ? 0 : (maxLineWidth - lineWidths[i]) / lineSpaces[i];
                }
                lineAlignOffsets.push(alignOffset);
            }
            var lenChars = chars.length;
            var pagesMeshData = {};
            var newPagesMeshData = [];
            var activePagesMeshData = this._activePagesMeshData;
            for (var i = 0; i < activePagesMeshData.length; i++) {
                pageMeshDataPool.push(activePagesMeshData[i]);
            }
            for (var i = 0; i < lenChars; i++) {
                var texture = chars[i].texture;
                var baseTextureUid = texture.baseTexture.uid;
                if (!pagesMeshData[baseTextureUid]) {
                    var pageMeshData = pageMeshDataPool.pop();
                    if (!pageMeshData) {
                        var geometry = new mesh.MeshGeometry();
                        var material = void 0;
                        var meshBlendMode = void 0;
                        if (data.distanceFieldType === 'none') {
                            material = new mesh.MeshMaterial(core.Texture.EMPTY);
                            meshBlendMode = constants.BLEND_MODES.NORMAL;
                        }
                        else {
                            material = new mesh.MeshMaterial(core.Texture.EMPTY, { program: core.Program.from(msdfVert, msdfFrag), uniforms: { uFWidth: 0 } });
                            meshBlendMode = constants.BLEND_MODES.NORMAL_NPM;
                        }
                        var mesh$1 = new mesh.Mesh(geometry, material);
                        mesh$1.blendMode = meshBlendMode;
                        pageMeshData = {
                            index: 0,
                            indexCount: 0,
                            vertexCount: 0,
                            uvsCount: 0,
                            total: 0,
                            mesh: mesh$1,
                            vertices: null,
                            uvs: null,
                            indices: null,
                        };
                    }
                    // reset data..
                    pageMeshData.index = 0;
                    pageMeshData.indexCount = 0;
                    pageMeshData.vertexCount = 0;
                    pageMeshData.uvsCount = 0;
                    pageMeshData.total = 0;
                    // TODO need to get page texture here somehow..
                    var _textureCache = this._textureCache;
                    _textureCache[baseTextureUid] = _textureCache[baseTextureUid] || new core.Texture(texture.baseTexture);
                    pageMeshData.mesh.texture = _textureCache[baseTextureUid];
                    pageMeshData.mesh.tint = this._tint;
                    newPagesMeshData.push(pageMeshData);
                    pagesMeshData[baseTextureUid] = pageMeshData;
                }
                pagesMeshData[baseTextureUid].total++;
            }
            // lets find any previously active pageMeshDatas that are no longer required for
            // the updated text (if any), removed and return them to the pool.
            for (var i = 0; i < activePagesMeshData.length; i++) {
                if (newPagesMeshData.indexOf(activePagesMeshData[i]) === -1) {
                    this.removeChild(activePagesMeshData[i].mesh);
                }
            }
            // next lets add any new meshes, that have not yet been added to this BitmapText
            // we only add if its not already a child of this BitmapObject
            for (var i = 0; i < newPagesMeshData.length; i++) {
                if (newPagesMeshData[i].mesh.parent !== this) {
                    this.addChild(newPagesMeshData[i].mesh);
                }
            }
            // active page mesh datas are set to be the new pages added.
            this._activePagesMeshData = newPagesMeshData;
            for (var i in pagesMeshData) {
                var pageMeshData = pagesMeshData[i];
                var total = pageMeshData.total;
                // lets only allocate new buffers if we can fit the new text in the current ones..
                // unless that is, we will be batching. Currently batching dose not respect the size property of mesh
                if (!(((_a = pageMeshData.indices) === null || _a === void 0 ? void 0 : _a.length) > 6 * total) || pageMeshData.vertices.length < mesh.Mesh.BATCHABLE_SIZE * 2) {
                    pageMeshData.vertices = new Float32Array(4 * 2 * total);
                    pageMeshData.uvs = new Float32Array(4 * 2 * total);
                    pageMeshData.indices = new Uint16Array(6 * total);
                }
                else {
                    var total_1 = pageMeshData.total;
                    var vertices = pageMeshData.vertices;
                    // Clear the garbage at the end of the vertices buffer. This will prevent the bounds miscalculation.
                    for (var i_1 = total_1 * 4 * 2; i_1 < vertices.length; i_1++) {
                        vertices[i_1] = 0;
                    }
                }
                // as a buffer maybe bigger than the current word, we set the size of the meshMaterial
                // to match the number of letters needed
                pageMeshData.mesh.size = 6 * total;
            }
            for (var i = 0; i < lenChars; i++) {
                var char = chars[i];
                var offset = char.position.x + (lineAlignOffsets[char.line] * (this._align === 'justify' ? char.prevSpaces : 1));
                if (this._roundPixels) {
                    offset = Math.round(offset);
                }
                var xPos = offset * scale;
                var yPos = char.position.y * scale;
                var texture = char.texture;
                var pageMesh = pagesMeshData[texture.baseTexture.uid];
                var textureFrame = texture.frame;
                var textureUvs = texture._uvs;
                var index = pageMesh.index++;
                pageMesh.indices[(index * 6) + 0] = 0 + (index * 4);
                pageMesh.indices[(index * 6) + 1] = 1 + (index * 4);
                pageMesh.indices[(index * 6) + 2] = 2 + (index * 4);
                pageMesh.indices[(index * 6) + 3] = 0 + (index * 4);
                pageMesh.indices[(index * 6) + 4] = 2 + (index * 4);
                pageMesh.indices[(index * 6) + 5] = 3 + (index * 4);
                pageMesh.vertices[(index * 8) + 0] = xPos;
                pageMesh.vertices[(index * 8) + 1] = yPos;
                pageMesh.vertices[(index * 8) + 2] = xPos + (textureFrame.width * scale);
                pageMesh.vertices[(index * 8) + 3] = yPos;
                pageMesh.vertices[(index * 8) + 4] = xPos + (textureFrame.width * scale);
                pageMesh.vertices[(index * 8) + 5] = yPos + (textureFrame.height * scale);
                pageMesh.vertices[(index * 8) + 6] = xPos;
                pageMesh.vertices[(index * 8) + 7] = yPos + (textureFrame.height * scale);
                pageMesh.uvs[(index * 8) + 0] = textureUvs.x0;
                pageMesh.uvs[(index * 8) + 1] = textureUvs.y0;
                pageMesh.uvs[(index * 8) + 2] = textureUvs.x1;
                pageMesh.uvs[(index * 8) + 3] = textureUvs.y1;
                pageMesh.uvs[(index * 8) + 4] = textureUvs.x2;
                pageMesh.uvs[(index * 8) + 5] = textureUvs.y2;
                pageMesh.uvs[(index * 8) + 6] = textureUvs.x3;
                pageMesh.uvs[(index * 8) + 7] = textureUvs.y3;
            }
            this._textWidth = maxLineWidth * scale;
            this._textHeight = (pos.y + data.lineHeight) * scale;
            for (var i in pagesMeshData) {
                var pageMeshData = pagesMeshData[i];
                // apply anchor
                if (this.anchor.x !== 0 || this.anchor.y !== 0) {
                    var vertexCount = 0;
                    var anchorOffsetX = this._textWidth * this.anchor.x;
                    var anchorOffsetY = this._textHeight * this.anchor.y;
                    for (var i_2 = 0; i_2 < pageMeshData.total; i_2++) {
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetX;
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetY;
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetX;
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetY;
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetX;
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetY;
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetX;
                        pageMeshData.vertices[vertexCount++] -= anchorOffsetY;
                    }
                }
                this._maxLineHeight = maxLineHeight * scale;
                var vertexBuffer = pageMeshData.mesh.geometry.getBuffer('aVertexPosition');
                var textureBuffer = pageMeshData.mesh.geometry.getBuffer('aTextureCoord');
                var indexBuffer = pageMeshData.mesh.geometry.getIndex();
                vertexBuffer.data = pageMeshData.vertices;
                textureBuffer.data = pageMeshData.uvs;
                indexBuffer.data = pageMeshData.indices;
                vertexBuffer.update();
                textureBuffer.update();
                indexBuffer.update();
            }
            for (var i = 0; i < chars.length; i++) {
                charRenderDataPool.push(chars[i]);
            }
        };
        BitmapText.prototype.updateTransform = function () {
            this.validate();
            this.containerUpdateTransform();
        };
        BitmapText.prototype._render = function (renderer) {
            if (this._autoResolution && this._resolution !== renderer.resolution) {
                this._resolution = renderer.resolution;
                this.dirty = true;
            }
            // Update the uniform
            var _a = BitmapFont.available[this._fontName], distanceFieldRange = _a.distanceFieldRange, distanceFieldType = _a.distanceFieldType, size = _a.size;
            if (distanceFieldType !== 'none') {
                // Inject the shader code with the correct value
                var _b = this.worldTransform, a = _b.a, b = _b.b, c = _b.c, d = _b.d;
                var dx = Math.sqrt((a * a) + (b * b));
                var dy = Math.sqrt((c * c) + (d * d));
                var worldScale = (Math.abs(dx) + Math.abs(dy)) / 2;
                var fontScale = this._fontSize / size;
                for (var _i = 0, _c = this._activePagesMeshData; _i < _c.length; _i++) {
                    var mesh = _c[_i];
                    mesh.mesh.shader.uniforms.uFWidth = worldScale * distanceFieldRange * fontScale * this._resolution;
                }
            }
            _super.prototype._render.call(this, renderer);
        };
        /**
         * Validates text before calling parent's getLocalBounds
         * @returns - The rectangular bounding area
         */
        BitmapText.prototype.getLocalBounds = function () {
            this.validate();
            return _super.prototype.getLocalBounds.call(this);
        };
        /**
         * Updates text when needed
         * @private
         */
        BitmapText.prototype.validate = function () {
            if (this.dirty) {
                this.updateText();
                this.dirty = false;
            }
        };
        Object.defineProperty(BitmapText.prototype, "tint", {
            /**
             * The tint of the BitmapText object.
             * @default 0xffffff
             */
            get: function () {
                return this._tint;
            },
            set: function (value) {
                if (this._tint === value)
                    { return; }
                this._tint = value;
                for (var i = 0; i < this._activePagesMeshData.length; i++) {
                    this._activePagesMeshData[i].mesh.tint = value;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "align", {
            /**
             * The alignment of the BitmapText object.
             * @member {string}
             * @default 'left'
             */
            get: function () {
                return this._align;
            },
            set: function (value) {
                if (this._align !== value) {
                    this._align = value;
                    this.dirty = true;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "fontName", {
            /** The name of the BitmapFont. */
            get: function () {
                return this._fontName;
            },
            set: function (value) {
                if (!BitmapFont.available[value]) {
                    throw new Error("Missing BitmapFont \"" + value + "\"");
                }
                if (this._fontName !== value) {
                    this._fontName = value;
                    this.dirty = true;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "fontSize", {
            /** The size of the font to display. */
            get: function () {
                return this._fontSize;
            },
            set: function (value) {
                if (this._fontSize !== value) {
                    this._fontSize = value;
                    this.dirty = true;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "anchor", {
            /**
             * The anchor sets the origin point of the text.
             *
             * The default is `(0,0)`, this means the text's origin is the top left.
             *
             * Setting the anchor to `(0.5,0.5)` means the text's origin is centered.
             *
             * Setting the anchor to `(1,1)` would mean the text's origin point will be the bottom right corner.
             */
            get: function () {
                return this._anchor;
            },
            set: function (value) {
                if (typeof value === 'number') {
                    this._anchor.set(value);
                }
                else {
                    this._anchor.copyFrom(value);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "text", {
            /** The text of the BitmapText object. */
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
        Object.defineProperty(BitmapText.prototype, "maxWidth", {
            /**
             * The max width of this bitmap text in pixels. If the text provided is longer than the
             * value provided, line breaks will be automatically inserted in the last whitespace.
             * Disable by setting the value to 0.
             */
            get: function () {
                return this._maxWidth;
            },
            set: function (value) {
                if (this._maxWidth === value) {
                    return;
                }
                this._maxWidth = value;
                this.dirty = true;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "maxLineHeight", {
            /**
             * The max line height. This is useful when trying to use the total height of the Text,
             * i.e. when trying to vertically align.
             * @readonly
             */
            get: function () {
                this.validate();
                return this._maxLineHeight;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "textWidth", {
            /**
             * The width of the overall text, different from fontSize,
             * which is defined in the style object.
             * @readonly
             */
            get: function () {
                this.validate();
                return this._textWidth;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "letterSpacing", {
            /** Additional space between characters. */
            get: function () {
                return this._letterSpacing;
            },
            set: function (value) {
                if (this._letterSpacing !== value) {
                    this._letterSpacing = value;
                    this.dirty = true;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "roundPixels", {
            /**
             * If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
             * Advantages can include sharper image quality (like text) and faster rendering on canvas.
             * The main disadvantage is movement of objects may appear less smooth.
             * To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
             * @default PIXI.settings.ROUND_PIXELS
             */
            get: function () {
                return this._roundPixels;
            },
            set: function (value) {
                if (value !== this._roundPixels) {
                    this._roundPixels = value;
                    this.dirty = true;
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "textHeight", {
            /**
             * The height of the overall text, different from fontSize,
             * which is defined in the style object.
             * @readonly
             */
            get: function () {
                this.validate();
                return this._textHeight;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(BitmapText.prototype, "resolution", {
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
        BitmapText.prototype.destroy = function (options) {
            var _textureCache = this._textureCache;
            for (var id in _textureCache) {
                var texture = _textureCache[id];
                texture.destroy();
                delete _textureCache[id];
            }
            this._textureCache = null;
            _super.prototype.destroy.call(this, options);
        };
        BitmapText.styleDefaults = {
            align: 'left',
            tint: 0xFFFFFF,
            maxWidth: 0,
            letterSpacing: 0,
        };
        return BitmapText;
    }(display.Container));

    /**
     * {@link PIXI.Loader Loader} middleware for loading
     * bitmap-based fonts suitable for using with {@link PIXI.BitmapText}.
     * @memberof PIXI
     */
    var BitmapFontLoader = /** @class */ (function () {
        function BitmapFontLoader() {
        }
        /**
         * Called when the plugin is installed.
         * @see PIXI.extensions.add
         */
        BitmapFontLoader.add = function () {
            loaders.LoaderResource.setExtensionXhrType('fnt', loaders.LoaderResource.XHR_RESPONSE_TYPE.TEXT);
        };
        /**
         * Called after a resource is loaded.
         * @see PIXI.Loader.loaderMiddleware
         * @param this
         * @param {PIXI.LoaderResource} resource
         * @param {Function} next
         */
        BitmapFontLoader.use = function (resource, next) {
            var format = autoDetectFormat(resource.data);
            // Resource was not recognised as any of the expected font data format
            if (!format) {
                next();
                return;
            }
            var baseUrl = BitmapFontLoader.getBaseUrl(this, resource);
            var data = format.parse(resource.data);
            var textures = {};
            // Handle completed, when the number of textures
            // load is the same number as references in the fnt file
            var completed = function (page) {
                textures[page.metadata.pageFile] = page.texture;
                if (Object.keys(textures).length === data.page.length) {
                    resource.bitmapFont = BitmapFont.install(data, textures, true);
                    next();
                }
            };
            for (var i = 0; i < data.page.length; ++i) {
                var pageFile = data.page[i].file;
                var url = baseUrl + pageFile;
                var exists = false;
                // incase the image is loaded outside
                // using the same loader, resource will be available
                for (var name in this.resources) {
                    var bitmapResource = this.resources[name];
                    if (bitmapResource.url === url) {
                        bitmapResource.metadata.pageFile = pageFile;
                        if (bitmapResource.texture) {
                            completed(bitmapResource);
                        }
                        else {
                            bitmapResource.onAfterMiddleware.add(completed);
                        }
                        exists = true;
                        break;
                    }
                }
                // texture is not loaded, we'll attempt to add
                // it to the load and add the texture to the list
                if (!exists) {
                    // Standard loading options for images
                    var options = {
                        crossOrigin: resource.crossOrigin,
                        loadType: loaders.LoaderResource.LOAD_TYPE.IMAGE,
                        metadata: Object.assign({ pageFile: pageFile }, resource.metadata.imageMetadata),
                        parentResource: resource,
                    };
                    this.add(url, options, completed);
                }
            }
        };
        /**
         * Get folder path from a resource.
         * @param loader
         * @param resource
         */
        BitmapFontLoader.getBaseUrl = function (loader, resource) {
            var resUrl = !resource.isDataUrl ? BitmapFontLoader.dirname(resource.url) : '';
            if (resource.isDataUrl) {
                if (resUrl === '.') {
                    resUrl = '';
                }
                if (loader.baseUrl && resUrl) {
                    // if baseurl has a trailing slash then add one to resUrl so the replace works below
                    if (loader.baseUrl.charAt(loader.baseUrl.length - 1) === '/') {
                        resUrl += '/';
                    }
                }
            }
            // remove baseUrl from resUrl
            resUrl = resUrl.replace(loader.baseUrl, '');
            // if there is an resUrl now, it needs a trailing slash. Ensure that it does if the string isn't empty.
            if (resUrl && resUrl.charAt(resUrl.length - 1) !== '/') {
                resUrl += '/';
            }
            return resUrl;
        };
        /**
         * Replacement for NodeJS's path.dirname
         * @param {string} url - Path to get directory for
         */
        BitmapFontLoader.dirname = function (url) {
            var dir = url
                .replace(/\\/g, '/') // convert windows notation to UNIX notation, URL-safe because it's a forbidden character
                .replace(/\/$/, '') // replace trailing slash
                .replace(/\/[^\/]*$/, ''); // remove everything after the last
            // File request is relative, use current directory
            if (dir === url) {
                return '.';
            }
            // Started with a slash
            else if (dir === '') {
                return '/';
            }
            return dir;
        };
        /** @ignore */
        BitmapFontLoader.extension = core.ExtensionType.Loader;
        return BitmapFontLoader;
    }());

    exports.BitmapFont = BitmapFont;
    exports.BitmapFontData = BitmapFontData;
    exports.BitmapFontLoader = BitmapFontLoader;
    exports.BitmapText = BitmapText;
    exports.TextFormat = TextFormat;
    exports.XMLFormat = XMLFormat;
    exports.XMLStringFormat = XMLStringFormat;
    exports.autoDetectFormat = autoDetectFormat;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI, PIXI.utils, PIXI, PIXI, PIXI, PIXI, PIXI);
Object.assign(this.PIXI, _pixi_text_bitmap);
//# sourceMappingURL=text-bitmap.js.map
