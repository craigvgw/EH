/*!
 * @pixi/graphics - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/graphics is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_graphics = (function (exports, core, math, utils, constants, display) {
    'use strict';

    /**
     * Supported line joints in `PIXI.LineStyle` for graphics.
     * @see PIXI.Graphics#lineStyle
     * @see https://graphicdesign.stackexchange.com/questions/59018/what-is-a-bevel-join-of-two-lines-exactly-illustrator
     * @name LINE_JOIN
     * @memberof PIXI
     * @static
     * @enum {string}
     * @property {string} MITER - 'miter': make a sharp corner where outer part of lines meet
     * @property {string} BEVEL - 'bevel': add a square butt at each end of line segment and fill the triangle at turn
     * @property {string} ROUND - 'round': add an arc at the joint
     */
    exports.LINE_JOIN = void 0;
    (function (LINE_JOIN) {
        LINE_JOIN["MITER"] = "miter";
        LINE_JOIN["BEVEL"] = "bevel";
        LINE_JOIN["ROUND"] = "round";
    })(exports.LINE_JOIN || (exports.LINE_JOIN = {}));
    /**
     * Support line caps in `PIXI.LineStyle` for graphics.
     * @see PIXI.Graphics#lineStyle
     * @name LINE_CAP
     * @memberof PIXI
     * @static
     * @enum {string}
     * @property {string} BUTT - 'butt': don't add any cap at line ends (leaves orthogonal edges)
     * @property {string} ROUND - 'round': add semicircle at ends
     * @property {string} SQUARE - 'square': add square at end (like `BUTT` except more length at end)
     */
    exports.LINE_CAP = void 0;
    (function (LINE_CAP) {
        LINE_CAP["BUTT"] = "butt";
        LINE_CAP["ROUND"] = "round";
        LINE_CAP["SQUARE"] = "square";
    })(exports.LINE_CAP || (exports.LINE_CAP = {}));
    /**
     * Graphics curves resolution settings. If `adaptive` flag is set to `true`,
     * the resolution is calculated based on the curve's length to ensure better visual quality.
     * Adaptive draw works with `bezierCurveTo` and `quadraticCurveTo`.
     * @static
     * @constant
     * @memberof PIXI
     * @name GRAPHICS_CURVES
     * @type {object}
     * @property {boolean} [adaptive=true] - flag indicating if the resolution should be adaptive
     * @property {number} [maxLength=10] - maximal length of a single segment of the curve (if adaptive = false, ignored)
     * @property {number} [minSegments=8] - minimal number of segments in the curve (if adaptive = false, ignored)
     * @property {number} [maxSegments=2048] - maximal number of segments in the curve (if adaptive = false, ignored)
     */
    var GRAPHICS_CURVES = {
        adaptive: true,
        maxLength: 10,
        minSegments: 8,
        maxSegments: 2048,
        epsilon: 0.0001,
        _segmentsCount: function (length, defaultSegments) {
            if (defaultSegments === void 0) { defaultSegments = 20; }
            if (!this.adaptive || !length || isNaN(length)) {
                return defaultSegments;
            }
            var result = Math.ceil(length / this.maxLength);
            if (result < this.minSegments) {
                result = this.minSegments;
            }
            else if (result > this.maxSegments) {
                result = this.maxSegments;
            }
            return result;
        },
    };

    /**
     * Fill style object for Graphics.
     * @memberof PIXI
     */
    var FillStyle = /** @class */ (function () {
        function FillStyle() {
            /**
             * The hex color value used when coloring the Graphics object.
             * @default 0xFFFFFF
             */
            this.color = 0xFFFFFF;
            /** The alpha value used when filling the Graphics object. */
            this.alpha = 1.0;
            /**
             * The texture to be used for the fill.
             * @default 0
             */
            this.texture = core.Texture.WHITE;
            /**
             * The transform applied to the texture.
             * @default null
             */
            this.matrix = null;
            /** If the current fill is visible. */
            this.visible = false;
            this.reset();
        }
        /** Clones the object */
        FillStyle.prototype.clone = function () {
            var obj = new FillStyle();
            obj.color = this.color;
            obj.alpha = this.alpha;
            obj.texture = this.texture;
            obj.matrix = this.matrix;
            obj.visible = this.visible;
            return obj;
        };
        /** Reset */
        FillStyle.prototype.reset = function () {
            this.color = 0xFFFFFF;
            this.alpha = 1;
            this.texture = core.Texture.WHITE;
            this.matrix = null;
            this.visible = false;
        };
        /** Destroy and don't use after this. */
        FillStyle.prototype.destroy = function () {
            this.texture = null;
            this.matrix = null;
        };
        return FillStyle;
    }());

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

    function fixOrientation(points, hole) {
        var _a, _b;
        if (hole === void 0) { hole = false; }
        var m = points.length;
        if (m < 6) {
            return;
        }
        var area = 0;
        for (var i = 0, x1 = points[m - 2], y1 = points[m - 1]; i < m; i += 2) {
            var x2 = points[i];
            var y2 = points[i + 1];
            area += (x2 - x1) * (y2 + y1);
            x1 = x2;
            y1 = y2;
        }
        if ((!hole && area > 0) || (hole && area <= 0)) {
            var n = m / 2;
            for (var i = n + (n % 2); i < m; i += 2) {
                var i1 = m - i - 2;
                var i2 = m - i - 1;
                var i3 = i;
                var i4 = i + 1;
                _a = [points[i3], points[i1]], points[i1] = _a[0], points[i3] = _a[1];
                _b = [points[i4], points[i2]], points[i2] = _b[0], points[i4] = _b[1];
            }
        }
    }
    /**
     * Builds a polygon to draw
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {PIXI.WebGLGraphicsData} graphicsData - The graphics object containing all the necessary properties
     * @param {object} webGLData - an object containing all the WebGL-specific information to create this shape
     * @param {object} webGLDataNativeLines - an object containing all the WebGL-specific information to create nativeLines
     */
    var buildPoly = {
        build: function (graphicsData) {
            graphicsData.points = graphicsData.shape.points.slice();
        },
        triangulate: function (graphicsData, graphicsGeometry) {
            var points = graphicsData.points;
            var holes = graphicsData.holes;
            var verts = graphicsGeometry.points;
            var indices = graphicsGeometry.indices;
            if (points.length >= 6) {
                fixOrientation(points, false);
                var holeArray = [];
                // Process holes..
                for (var i = 0; i < holes.length; i++) {
                    var hole = holes[i];
                    fixOrientation(hole.points, true);
                    holeArray.push(points.length / 2);
                    points = points.concat(hole.points);
                }
                // sort color
                var triangles = utils.earcut(points, holeArray, 2);
                if (!triangles) {
                    return;
                }
                var vertPos = verts.length / 2;
                for (var i = 0; i < triangles.length; i += 3) {
                    indices.push(triangles[i] + vertPos);
                    indices.push(triangles[i + 1] + vertPos);
                    indices.push(triangles[i + 2] + vertPos);
                }
                for (var i = 0; i < points.length; i++) {
                    verts.push(points[i]);
                }
            }
        },
    };

    // for type only
    /**
     * Builds a circle to draw
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {PIXI.WebGLGraphicsData} graphicsData - The graphics object to draw
     * @param {object} webGLData - an object containing all the WebGL-specific information to create this shape
     * @param {object} webGLDataNativeLines - an object containing all the WebGL-specific information to create nativeLines
     */
    var buildCircle = {
        build: function (graphicsData) {
            // need to convert points to a nice regular data
            var points = graphicsData.points;
            var x;
            var y;
            var dx;
            var dy;
            var rx;
            var ry;
            if (graphicsData.type === math.SHAPES.CIRC) {
                var circle = graphicsData.shape;
                x = circle.x;
                y = circle.y;
                rx = ry = circle.radius;
                dx = dy = 0;
            }
            else if (graphicsData.type === math.SHAPES.ELIP) {
                var ellipse = graphicsData.shape;
                x = ellipse.x;
                y = ellipse.y;
                rx = ellipse.width;
                ry = ellipse.height;
                dx = dy = 0;
            }
            else {
                var roundedRect = graphicsData.shape;
                var halfWidth = roundedRect.width / 2;
                var halfHeight = roundedRect.height / 2;
                x = roundedRect.x + halfWidth;
                y = roundedRect.y + halfHeight;
                rx = ry = Math.max(0, Math.min(roundedRect.radius, Math.min(halfWidth, halfHeight)));
                dx = halfWidth - rx;
                dy = halfHeight - ry;
            }
            if (!(rx >= 0 && ry >= 0 && dx >= 0 && dy >= 0)) {
                points.length = 0;
                return;
            }
            // Choose a number of segments such that the maximum absolute deviation from the circle is approximately 0.029
            var n = Math.ceil(2.3 * Math.sqrt(rx + ry));
            var m = (n * 8) + (dx ? 4 : 0) + (dy ? 4 : 0);
            points.length = m;
            if (m === 0) {
                return;
            }
            if (n === 0) {
                points.length = 8;
                points[0] = points[6] = x + dx;
                points[1] = points[3] = y + dy;
                points[2] = points[4] = x - dx;
                points[5] = points[7] = y - dy;
                return;
            }
            var j1 = 0;
            var j2 = (n * 4) + (dx ? 2 : 0) + 2;
            var j3 = j2;
            var j4 = m;
            {
                var x0 = dx + rx;
                var y0 = dy;
                var x1 = x + x0;
                var x2 = x - x0;
                var y1 = y + y0;
                points[j1++] = x1;
                points[j1++] = y1;
                points[--j2] = y1;
                points[--j2] = x2;
                if (dy) {
                    var y2 = y - y0;
                    points[j3++] = x2;
                    points[j3++] = y2;
                    points[--j4] = y2;
                    points[--j4] = x1;
                }
            }
            for (var i = 1; i < n; i++) {
                var a = Math.PI / 2 * (i / n);
                var x0 = dx + (Math.cos(a) * rx);
                var y0 = dy + (Math.sin(a) * ry);
                var x1 = x + x0;
                var x2 = x - x0;
                var y1 = y + y0;
                var y2 = y - y0;
                points[j1++] = x1;
                points[j1++] = y1;
                points[--j2] = y1;
                points[--j2] = x2;
                points[j3++] = x2;
                points[j3++] = y2;
                points[--j4] = y2;
                points[--j4] = x1;
            }
            {
                var x0 = dx;
                var y0 = dy + ry;
                var x1 = x + x0;
                var x2 = x - x0;
                var y1 = y + y0;
                var y2 = y - y0;
                points[j1++] = x1;
                points[j1++] = y1;
                points[--j4] = y2;
                points[--j4] = x1;
                if (dx) {
                    points[j1++] = x2;
                    points[j1++] = y1;
                    points[--j4] = y2;
                    points[--j4] = x2;
                }
            }
        },
        triangulate: function (graphicsData, graphicsGeometry) {
            var points = graphicsData.points;
            var verts = graphicsGeometry.points;
            var indices = graphicsGeometry.indices;
            if (points.length === 0) {
                return;
            }
            var vertPos = verts.length / 2;
            var center = vertPos;
            var x;
            var y;
            if (graphicsData.type !== math.SHAPES.RREC) {
                var circle = graphicsData.shape;
                x = circle.x;
                y = circle.y;
            }
            else {
                var roundedRect = graphicsData.shape;
                x = roundedRect.x + (roundedRect.width / 2);
                y = roundedRect.y + (roundedRect.height / 2);
            }
            var matrix = graphicsData.matrix;
            // Push center (special point)
            verts.push(graphicsData.matrix ? (matrix.a * x) + (matrix.c * y) + matrix.tx : x, graphicsData.matrix ? (matrix.b * x) + (matrix.d * y) + matrix.ty : y);
            vertPos++;
            verts.push(points[0], points[1]);
            for (var i = 2; i < points.length; i += 2) {
                verts.push(points[i], points[i + 1]);
                // add some uvs
                indices.push(vertPos++, center, vertPos);
            }
            indices.push(center + 1, center, vertPos);
        },
    };

    /**
     * Builds a rectangle to draw
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {PIXI.WebGLGraphicsData} graphicsData - The graphics object containing all the necessary properties
     * @param {object} webGLData - an object containing all the WebGL-specific information to create this shape
     * @param {object} webGLDataNativeLines - an object containing all the WebGL-specific information to create nativeLines
     */
    var buildRectangle = {
        build: function (graphicsData) {
            // --- //
            // need to convert points to a nice regular data
            //
            var rectData = graphicsData.shape;
            var x = rectData.x;
            var y = rectData.y;
            var width = rectData.width;
            var height = rectData.height;
            var points = graphicsData.points;
            points.length = 0;
            points.push(x, y, x + width, y, x + width, y + height, x, y + height);
        },
        triangulate: function (graphicsData, graphicsGeometry) {
            var points = graphicsData.points;
            var verts = graphicsGeometry.points;
            var vertPos = verts.length / 2;
            verts.push(points[0], points[1], points[2], points[3], points[6], points[7], points[4], points[5]);
            graphicsGeometry.indices.push(vertPos, vertPos + 1, vertPos + 2, vertPos + 1, vertPos + 2, vertPos + 3);
        },
    };

    /**
     * Calculate a single point for a quadratic bezier curve.
     * Utility function used by quadraticBezierCurve.
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {number} n1 - first number
     * @param {number} n2 - second number
     * @param {number} perc - percentage
     * @returns {number} the result
     */
    function getPt(n1, n2, perc) {
        var diff = n2 - n1;
        return n1 + (diff * perc);
    }
    /**
     * Calculate the points for a quadratic bezier curve. (helper function..)
     * Based on: https://stackoverflow.com/questions/785097/how-do-i-implement-a-bezier-curve-in-c
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {number} fromX - Origin point x
     * @param {number} fromY - Origin point x
     * @param {number} cpX - Control point x
     * @param {number} cpY - Control point y
     * @param {number} toX - Destination point x
     * @param {number} toY - Destination point y
     * @param {number[]} [out=[]] - The output array to add points into. If not passed, a new array is created.
     * @returns {number[]} an array of points
     */
    function quadraticBezierCurve(fromX, fromY, cpX, cpY, toX, toY, out) {
        if (out === void 0) { out = []; }
        var n = 20;
        var points = out;
        var xa = 0;
        var ya = 0;
        var xb = 0;
        var yb = 0;
        var x = 0;
        var y = 0;
        for (var i = 0, j = 0; i <= n; ++i) {
            j = i / n;
            // The Green Line
            xa = getPt(fromX, cpX, j);
            ya = getPt(fromY, cpY, j);
            xb = getPt(cpX, toX, j);
            yb = getPt(cpY, toY, j);
            // The Black Dot
            x = getPt(xa, xb, j);
            y = getPt(ya, yb, j);
            // Handle case when first curve points overlaps and earcut fails to triangulate
            if (i === 0 && points[points.length - 2] === x && points[points.length - 1] === y) {
                continue;
            }
            points.push(x, y);
        }
        return points;
    }
    /**
     * Builds a rounded rectangle to draw
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {PIXI.WebGLGraphicsData} graphicsData - The graphics object containing all the necessary properties
     * @param {object} webGLData - an object containing all the WebGL-specific information to create this shape
     * @param {object} webGLDataNativeLines - an object containing all the WebGL-specific information to create nativeLines
     */
    var buildRoundedRectangle = {
        build: function (graphicsData) {
            if (Graphics.nextRoundedRectBehavior) {
                buildCircle.build(graphicsData);
                return;
            }
            var rrectData = graphicsData.shape;
            var points = graphicsData.points;
            var x = rrectData.x;
            var y = rrectData.y;
            var width = rrectData.width;
            var height = rrectData.height;
            // Don't allow negative radius or greater than half the smallest width
            var radius = Math.max(0, Math.min(rrectData.radius, Math.min(width, height) / 2));
            points.length = 0;
            // No radius, do a simple rectangle
            if (!radius) {
                points.push(x, y, x + width, y, x + width, y + height, x, y + height);
            }
            else {
                quadraticBezierCurve(x, y + radius, x, y, x + radius, y, points);
                quadraticBezierCurve(x + width - radius, y, x + width, y, x + width, y + radius, points);
                quadraticBezierCurve(x + width, y + height - radius, x + width, y + height, x + width - radius, y + height, points);
                quadraticBezierCurve(x + radius, y + height, x, y + height, x, y + height - radius, points);
            }
        },
        triangulate: function (graphicsData, graphicsGeometry) {
            if (Graphics.nextRoundedRectBehavior) {
                buildCircle.triangulate(graphicsData, graphicsGeometry);
                return;
            }
            var points = graphicsData.points;
            var verts = graphicsGeometry.points;
            var indices = graphicsGeometry.indices;
            var vecPos = verts.length / 2;
            var triangles = utils.earcut(points, null, 2);
            for (var i = 0, j = triangles.length; i < j; i += 3) {
                indices.push(triangles[i] + vecPos);
                //     indices.push(triangles[i] + vecPos);
                indices.push(triangles[i + 1] + vecPos);
                //   indices.push(triangles[i + 2] + vecPos);
                indices.push(triangles[i + 2] + vecPos);
            }
            for (var i = 0, j = points.length; i < j; i++) {
                verts.push(points[i], points[++i]);
            }
        },
    };

    /**
     * Buffers vertices to draw a square cap.
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {number} x - X-coord of end point
     * @param {number} y - Y-coord of end point
     * @param {number} nx - X-coord of line normal pointing inside
     * @param {number} ny - Y-coord of line normal pointing inside
     * @param {number} innerWeight - Weight of inner points
     * @param {number} outerWeight - Weight of outer points
     * @param {boolean} clockwise - Whether the cap is drawn clockwise
     * @param {Array<number>} verts - vertex buffer
     * @returns {number} - no. of vertices pushed
     */
    function square(x, y, nx, ny, innerWeight, outerWeight, clockwise, /* rotation for square (true at left end, false at right end) */ verts) {
        var ix = x - (nx * innerWeight);
        var iy = y - (ny * innerWeight);
        var ox = x + (nx * outerWeight);
        var oy = y + (ny * outerWeight);
        /* Rotate nx,ny for extension vector */
        var exx;
        var eyy;
        if (clockwise) {
            exx = ny;
            eyy = -nx;
        }
        else {
            exx = -ny;
            eyy = nx;
        }
        /* [i|0]x,y extended at cap */
        var eix = ix + exx;
        var eiy = iy + eyy;
        var eox = ox + exx;
        var eoy = oy + eyy;
        /* Square itself must be inserted clockwise*/
        verts.push(eix, eiy);
        verts.push(eox, eoy);
        return 2;
    }
    /**
     * Buffers vertices to draw an arc at the line joint or cap.
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {number} cx - X-coord of center
     * @param {number} cy - Y-coord of center
     * @param {number} sx - X-coord of arc start
     * @param {number} sy - Y-coord of arc start
     * @param {number} ex - X-coord of arc end
     * @param {number} ey - Y-coord of arc end
     * @param {Array<number>} verts - buffer of vertices
     * @param {boolean} clockwise - orientation of vertices
     * @returns {number} - no. of vertices pushed
     */
    function round(cx, cy, sx, sy, ex, ey, verts, clockwise) {
        var cx2p0x = sx - cx;
        var cy2p0y = sy - cy;
        var angle0 = Math.atan2(cx2p0x, cy2p0y);
        var angle1 = Math.atan2(ex - cx, ey - cy);
        if (clockwise && angle0 < angle1) {
            angle0 += Math.PI * 2;
        }
        else if (!clockwise && angle0 > angle1) {
            angle1 += Math.PI * 2;
        }
        var startAngle = angle0;
        var angleDiff = angle1 - angle0;
        var absAngleDiff = Math.abs(angleDiff);
        /* if (absAngleDiff >= PI_LBOUND && absAngleDiff <= PI_UBOUND)
        {
            const r1x = cx - nxtPx;
            const r1y = cy - nxtPy;

            if (r1x === 0)
            {
                if (r1y > 0)
                {
                    angleDiff = -angleDiff;
                }
            }
            else if (r1x >= -GRAPHICS_CURVES.epsilon)
            {
                angleDiff = -angleDiff;
            }
        }*/
        var radius = Math.sqrt((cx2p0x * cx2p0x) + (cy2p0y * cy2p0y));
        var segCount = ((15 * absAngleDiff * Math.sqrt(radius) / Math.PI) >> 0) + 1;
        var angleInc = angleDiff / segCount;
        startAngle += angleInc;
        if (clockwise) {
            verts.push(cx, cy);
            verts.push(sx, sy);
            for (var i = 1, angle = startAngle; i < segCount; i++, angle += angleInc) {
                verts.push(cx, cy);
                verts.push(cx + ((Math.sin(angle) * radius)), cy + ((Math.cos(angle) * radius)));
            }
            verts.push(cx, cy);
            verts.push(ex, ey);
        }
        else {
            verts.push(sx, sy);
            verts.push(cx, cy);
            for (var i = 1, angle = startAngle; i < segCount; i++, angle += angleInc) {
                verts.push(cx + ((Math.sin(angle) * radius)), cy + ((Math.cos(angle) * radius)));
                verts.push(cx, cy);
            }
            verts.push(ex, ey);
            verts.push(cx, cy);
        }
        return segCount * 2;
    }
    /**
     * Builds a line to draw using the polygon method.
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {PIXI.GraphicsData} graphicsData - The graphics object containing all the necessary properties
     * @param {PIXI.GraphicsGeometry} graphicsGeometry - Geometry where to append output
     */
    function buildNonNativeLine(graphicsData, graphicsGeometry) {
        var shape = graphicsData.shape;
        var points = graphicsData.points || shape.points.slice();
        var eps = graphicsGeometry.closePointEps;
        if (points.length === 0) {
            return;
        }
        // if the line width is an odd number add 0.5 to align to a whole pixel
        // commenting this out fixes #711 and #1620
        // if (graphicsData.lineWidth%2)
        // {
        //     for (i = 0; i < points.length; i++)
        //     {
        //         points[i] += 0.5;
        //     }
        // }
        var style = graphicsData.lineStyle;
        // get first and last point.. figure out the middle!
        var firstPoint = new math.Point(points[0], points[1]);
        var lastPoint = new math.Point(points[points.length - 2], points[points.length - 1]);
        var closedShape = shape.type !== math.SHAPES.POLY || shape.closeStroke;
        var closedPath = Math.abs(firstPoint.x - lastPoint.x) < eps
            && Math.abs(firstPoint.y - lastPoint.y) < eps;
        // if the first point is the last point - gonna have issues :)
        if (closedShape) {
            // need to clone as we are going to slightly modify the shape..
            points = points.slice();
            if (closedPath) {
                points.pop();
                points.pop();
                lastPoint.set(points[points.length - 2], points[points.length - 1]);
            }
            var midPointX = (firstPoint.x + lastPoint.x) * 0.5;
            var midPointY = (lastPoint.y + firstPoint.y) * 0.5;
            points.unshift(midPointX, midPointY);
            points.push(midPointX, midPointY);
        }
        var verts = graphicsGeometry.points;
        var length = points.length / 2;
        var indexCount = points.length;
        var indexStart = verts.length / 2;
        // Max. inner and outer width
        var width = style.width / 2;
        var widthSquared = width * width;
        var miterLimitSquared = style.miterLimit * style.miterLimit;
        /* Line segments of interest where (x1,y1) forms the corner. */
        var x0 = points[0];
        var y0 = points[1];
        var x1 = points[2];
        var y1 = points[3];
        var x2 = 0;
        var y2 = 0;
        /* perp[?](x|y) = the line normal with magnitude lineWidth. */
        var perpx = -(y0 - y1);
        var perpy = x0 - x1;
        var perp1x = 0;
        var perp1y = 0;
        var dist = Math.sqrt((perpx * perpx) + (perpy * perpy));
        perpx /= dist;
        perpy /= dist;
        perpx *= width;
        perpy *= width;
        var ratio = style.alignment; // 0.5;
        var innerWeight = (1 - ratio) * 2;
        var outerWeight = ratio * 2;
        if (!closedShape) {
            if (style.cap === exports.LINE_CAP.ROUND) {
                indexCount += round(x0 - (perpx * (innerWeight - outerWeight) * 0.5), y0 - (perpy * (innerWeight - outerWeight) * 0.5), x0 - (perpx * innerWeight), y0 - (perpy * innerWeight), x0 + (perpx * outerWeight), y0 + (perpy * outerWeight), verts, true) + 2;
            }
            else if (style.cap === exports.LINE_CAP.SQUARE) {
                indexCount += square(x0, y0, perpx, perpy, innerWeight, outerWeight, true, verts);
            }
        }
        // Push first point (below & above vertices)
        verts.push(x0 - (perpx * innerWeight), y0 - (perpy * innerWeight));
        verts.push(x0 + (perpx * outerWeight), y0 + (perpy * outerWeight));
        for (var i = 1; i < length - 1; ++i) {
            x0 = points[(i - 1) * 2];
            y0 = points[((i - 1) * 2) + 1];
            x1 = points[i * 2];
            y1 = points[(i * 2) + 1];
            x2 = points[(i + 1) * 2];
            y2 = points[((i + 1) * 2) + 1];
            perpx = -(y0 - y1);
            perpy = x0 - x1;
            dist = Math.sqrt((perpx * perpx) + (perpy * perpy));
            perpx /= dist;
            perpy /= dist;
            perpx *= width;
            perpy *= width;
            perp1x = -(y1 - y2);
            perp1y = x1 - x2;
            dist = Math.sqrt((perp1x * perp1x) + (perp1y * perp1y));
            perp1x /= dist;
            perp1y /= dist;
            perp1x *= width;
            perp1y *= width;
            /* d[x|y](0|1) = the component displacement between points p(0,1|1,2) */
            var dx0 = x1 - x0;
            var dy0 = y0 - y1;
            var dx1 = x1 - x2;
            var dy1 = y2 - y1;
            /* +ve if internal angle counterclockwise, -ve if internal angle clockwise. */
            var cross = (dy0 * dx1) - (dy1 * dx0);
            var clockwise = (cross < 0);
            /* Going nearly straight? */
            if (Math.abs(cross) < 0.1) {
                verts.push(x1 - (perpx * innerWeight), y1 - (perpy * innerWeight));
                verts.push(x1 + (perpx * outerWeight), y1 + (perpy * outerWeight));
                continue;
            }
            /* p[x|y] is the miter point. pdist is the distance between miter point and p1. */
            var c1 = ((-perpx + x0) * (-perpy + y1)) - ((-perpx + x1) * (-perpy + y0));
            var c2 = ((-perp1x + x2) * (-perp1y + y1)) - ((-perp1x + x1) * (-perp1y + y2));
            var px = ((dx0 * c2) - (dx1 * c1)) / cross;
            var py = ((dy1 * c1) - (dy0 * c2)) / cross;
            var pdist = ((px - x1) * (px - x1)) + ((py - y1) * (py - y1));
            /* Inner miter point */
            var imx = x1 + ((px - x1) * innerWeight);
            var imy = y1 + ((py - y1) * innerWeight);
            /* Outer miter point */
            var omx = x1 - ((px - x1) * outerWeight);
            var omy = y1 - ((py - y1) * outerWeight);
            /* Is the inside miter point too far away, creating a spike? */
            var smallerInsideSegmentSq = Math.min((dx0 * dx0) + (dy0 * dy0), (dx1 * dx1) + (dy1 * dy1));
            var insideWeight = clockwise ? innerWeight : outerWeight;
            var smallerInsideDiagonalSq = smallerInsideSegmentSq + (insideWeight * insideWeight * widthSquared);
            var insideMiterOk = pdist <= smallerInsideDiagonalSq;
            if (insideMiterOk) {
                if (style.join === exports.LINE_JOIN.BEVEL || pdist / widthSquared > miterLimitSquared) {
                    if (clockwise) /* rotating at inner angle */ {
                        verts.push(imx, imy); // inner miter point
                        verts.push(x1 + (perpx * outerWeight), y1 + (perpy * outerWeight)); // first segment's outer vertex
                        verts.push(imx, imy); // inner miter point
                        verts.push(x1 + (perp1x * outerWeight), y1 + (perp1y * outerWeight)); // second segment's outer vertex
                    }
                    else /* rotating at outer angle */ {
                        verts.push(x1 - (perpx * innerWeight), y1 - (perpy * innerWeight)); // first segment's inner vertex
                        verts.push(omx, omy); // outer miter point
                        verts.push(x1 - (perp1x * innerWeight), y1 - (perp1y * innerWeight)); // second segment's outer vertex
                        verts.push(omx, omy); // outer miter point
                    }
                    indexCount += 2;
                }
                else if (style.join === exports.LINE_JOIN.ROUND) {
                    if (clockwise) /* arc is outside */ {
                        verts.push(imx, imy);
                        verts.push(x1 + (perpx * outerWeight), y1 + (perpy * outerWeight));
                        indexCount += round(x1, y1, x1 + (perpx * outerWeight), y1 + (perpy * outerWeight), x1 + (perp1x * outerWeight), y1 + (perp1y * outerWeight), verts, true) + 4;
                        verts.push(imx, imy);
                        verts.push(x1 + (perp1x * outerWeight), y1 + (perp1y * outerWeight));
                    }
                    else /* arc is inside */ {
                        verts.push(x1 - (perpx * innerWeight), y1 - (perpy * innerWeight));
                        verts.push(omx, omy);
                        indexCount += round(x1, y1, x1 - (perpx * innerWeight), y1 - (perpy * innerWeight), x1 - (perp1x * innerWeight), y1 - (perp1y * innerWeight), verts, false) + 4;
                        verts.push(x1 - (perp1x * innerWeight), y1 - (perp1y * innerWeight));
                        verts.push(omx, omy);
                    }
                }
                else {
                    verts.push(imx, imy);
                    verts.push(omx, omy);
                }
            }
            else // inside miter is NOT ok
             {
                verts.push(x1 - (perpx * innerWeight), y1 - (perpy * innerWeight)); // first segment's inner vertex
                verts.push(x1 + (perpx * outerWeight), y1 + (perpy * outerWeight)); // first segment's outer vertex
                if (style.join === exports.LINE_JOIN.ROUND) {
                    if (clockwise) /* arc is outside */ {
                        indexCount += round(x1, y1, x1 + (perpx * outerWeight), y1 + (perpy * outerWeight), x1 + (perp1x * outerWeight), y1 + (perp1y * outerWeight), verts, true) + 2;
                    }
                    else /* arc is inside */ {
                        indexCount += round(x1, y1, x1 - (perpx * innerWeight), y1 - (perpy * innerWeight), x1 - (perp1x * innerWeight), y1 - (perp1y * innerWeight), verts, false) + 2;
                    }
                }
                else if (style.join === exports.LINE_JOIN.MITER && pdist / widthSquared <= miterLimitSquared) {
                    if (clockwise) {
                        verts.push(omx, omy); // inner miter point
                        verts.push(omx, omy); // inner miter point
                    }
                    else {
                        verts.push(imx, imy); // outer miter point
                        verts.push(imx, imy); // outer miter point
                    }
                    indexCount += 2;
                }
                verts.push(x1 - (perp1x * innerWeight), y1 - (perp1y * innerWeight)); // second segment's inner vertex
                verts.push(x1 + (perp1x * outerWeight), y1 + (perp1y * outerWeight)); // second segment's outer vertex
                indexCount += 2;
            }
        }
        x0 = points[(length - 2) * 2];
        y0 = points[((length - 2) * 2) + 1];
        x1 = points[(length - 1) * 2];
        y1 = points[((length - 1) * 2) + 1];
        perpx = -(y0 - y1);
        perpy = x0 - x1;
        dist = Math.sqrt((perpx * perpx) + (perpy * perpy));
        perpx /= dist;
        perpy /= dist;
        perpx *= width;
        perpy *= width;
        verts.push(x1 - (perpx * innerWeight), y1 - (perpy * innerWeight));
        verts.push(x1 + (perpx * outerWeight), y1 + (perpy * outerWeight));
        if (!closedShape) {
            if (style.cap === exports.LINE_CAP.ROUND) {
                indexCount += round(x1 - (perpx * (innerWeight - outerWeight) * 0.5), y1 - (perpy * (innerWeight - outerWeight) * 0.5), x1 - (perpx * innerWeight), y1 - (perpy * innerWeight), x1 + (perpx * outerWeight), y1 + (perpy * outerWeight), verts, false) + 2;
            }
            else if (style.cap === exports.LINE_CAP.SQUARE) {
                indexCount += square(x1, y1, perpx, perpy, innerWeight, outerWeight, false, verts);
            }
        }
        var indices = graphicsGeometry.indices;
        var eps2 = GRAPHICS_CURVES.epsilon * GRAPHICS_CURVES.epsilon;
        // indices.push(indexStart);
        for (var i = indexStart; i < indexCount + indexStart - 2; ++i) {
            x0 = verts[(i * 2)];
            y0 = verts[(i * 2) + 1];
            x1 = verts[(i + 1) * 2];
            y1 = verts[((i + 1) * 2) + 1];
            x2 = verts[(i + 2) * 2];
            y2 = verts[((i + 2) * 2) + 1];
            /* Skip zero area triangles */
            if (Math.abs((x0 * (y1 - y2)) + (x1 * (y2 - y0)) + (x2 * (y0 - y1))) < eps2) {
                continue;
            }
            indices.push(i, i + 1, i + 2);
        }
    }
    /**
     * Builds a line to draw using the gl.drawArrays(gl.LINES) method
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {PIXI.GraphicsData} graphicsData - The graphics object containing all the necessary properties
     * @param {PIXI.GraphicsGeometry} graphicsGeometry - Geometry where to append output
     */
    function buildNativeLine(graphicsData, graphicsGeometry) {
        var i = 0;
        var shape = graphicsData.shape;
        var points = graphicsData.points || shape.points;
        var closedShape = shape.type !== math.SHAPES.POLY || shape.closeStroke;
        if (points.length === 0)
            { return; }
        var verts = graphicsGeometry.points;
        var indices = graphicsGeometry.indices;
        var length = points.length / 2;
        var startIndex = verts.length / 2;
        var currentIndex = startIndex;
        verts.push(points[0], points[1]);
        for (i = 1; i < length; i++) {
            verts.push(points[i * 2], points[(i * 2) + 1]);
            indices.push(currentIndex, currentIndex + 1);
            currentIndex++;
        }
        if (closedShape) {
            indices.push(currentIndex, startIndex);
        }
    }
    /**
     * Builds a line to draw
     *
     * Ignored from docs since it is not directly exposed.
     * @ignore
     * @private
     * @param {PIXI.GraphicsData} graphicsData - The graphics object containing all the necessary properties
     * @param {PIXI.GraphicsGeometry} graphicsGeometry - Geometry where to append output
     */
    function buildLine(graphicsData, graphicsGeometry) {
        if (graphicsData.lineStyle.native) {
            buildNativeLine(graphicsData, graphicsGeometry);
        }
        else {
            buildNonNativeLine(graphicsData, graphicsGeometry);
        }
    }

    /**
     * Utilities for arc curves.
     * @private
     */
    var ArcUtils = /** @class */ (function () {
        function ArcUtils() {
        }
        /**
         * The arcTo() method creates an arc/curve between two tangents on the canvas.
         *
         * "borrowed" from https://code.google.com/p/fxcanvas/ - thanks google!
         * @private
         * @param x1 - The x-coordinate of the beginning of the arc
         * @param y1 - The y-coordinate of the beginning of the arc
         * @param x2 - The x-coordinate of the end of the arc
         * @param y2 - The y-coordinate of the end of the arc
         * @param radius - The radius of the arc
         * @param points -
         * @returns - If the arc length is valid, return center of circle, radius and other info otherwise `null`.
         */
        ArcUtils.curveTo = function (x1, y1, x2, y2, radius, points) {
            var fromX = points[points.length - 2];
            var fromY = points[points.length - 1];
            var a1 = fromY - y1;
            var b1 = fromX - x1;
            var a2 = y2 - y1;
            var b2 = x2 - x1;
            var mm = Math.abs((a1 * b2) - (b1 * a2));
            if (mm < 1.0e-8 || radius === 0) {
                if (points[points.length - 2] !== x1 || points[points.length - 1] !== y1) {
                    points.push(x1, y1);
                }
                return null;
            }
            var dd = (a1 * a1) + (b1 * b1);
            var cc = (a2 * a2) + (b2 * b2);
            var tt = (a1 * a2) + (b1 * b2);
            var k1 = radius * Math.sqrt(dd) / mm;
            var k2 = radius * Math.sqrt(cc) / mm;
            var j1 = k1 * tt / dd;
            var j2 = k2 * tt / cc;
            var cx = (k1 * b2) + (k2 * b1);
            var cy = (k1 * a2) + (k2 * a1);
            var px = b1 * (k2 + j1);
            var py = a1 * (k2 + j1);
            var qx = b2 * (k1 + j2);
            var qy = a2 * (k1 + j2);
            var startAngle = Math.atan2(py - cy, px - cx);
            var endAngle = Math.atan2(qy - cy, qx - cx);
            return {
                cx: (cx + x1),
                cy: (cy + y1),
                radius: radius,
                startAngle: startAngle,
                endAngle: endAngle,
                anticlockwise: (b1 * a2 > b2 * a1),
            };
        };
        /* eslint-disable max-len */
        /**
         * The arc method creates an arc/curve (used to create circles, or parts of circles).
         * @private
         * @param _startX - Start x location of arc
         * @param _startY - Start y location of arc
         * @param cx - The x-coordinate of the center of the circle
         * @param cy - The y-coordinate of the center of the circle
         * @param radius - The radius of the circle
         * @param startAngle - The starting angle, in radians (0 is at the 3 o'clock position
         *  of the arc's circle)
         * @param endAngle - The ending angle, in radians
         * @param _anticlockwise - Specifies whether the drawing should be
         *  counter-clockwise or clockwise. False is default, and indicates clockwise, while true
         *  indicates counter-clockwise.
         * @param points - Collection of points to add to
         */
        ArcUtils.arc = function (_startX, _startY, cx, cy, radius, startAngle, endAngle, _anticlockwise, points) {
            var sweep = endAngle - startAngle;
            var n = GRAPHICS_CURVES._segmentsCount(Math.abs(sweep) * radius, Math.ceil(Math.abs(sweep) / math.PI_2) * 40);
            var theta = (sweep) / (n * 2);
            var theta2 = theta * 2;
            var cTheta = Math.cos(theta);
            var sTheta = Math.sin(theta);
            var segMinus = n - 1;
            var remainder = (segMinus % 1) / segMinus;
            for (var i = 0; i <= segMinus; ++i) {
                var real = i + (remainder * i);
                var angle = ((theta) + startAngle + (theta2 * real));
                var c = Math.cos(angle);
                var s = -Math.sin(angle);
                points.push((((cTheta * c) + (sTheta * s)) * radius) + cx, (((cTheta * -s) + (sTheta * c)) * radius) + cy);
            }
        };
        return ArcUtils;
    }());

    /**
     * Utilities for bezier curves
     * @private
     */
    var BezierUtils = /** @class */ (function () {
        function BezierUtils() {
        }
        /**
         * Calculate length of bezier curve.
         * Analytical solution is impossible, since it involves an integral that does not integrate in general.
         * Therefore numerical solution is used.
         * @private
         * @param fromX - Starting point x
         * @param fromY - Starting point y
         * @param cpX - Control point x
         * @param cpY - Control point y
         * @param cpX2 - Second Control point x
         * @param cpY2 - Second Control point y
         * @param toX - Destination point x
         * @param toY - Destination point y
         * @returns - Length of bezier curve
         */
        BezierUtils.curveLength = function (fromX, fromY, cpX, cpY, cpX2, cpY2, toX, toY) {
            var n = 10;
            var result = 0.0;
            var t = 0.0;
            var t2 = 0.0;
            var t3 = 0.0;
            var nt = 0.0;
            var nt2 = 0.0;
            var nt3 = 0.0;
            var x = 0.0;
            var y = 0.0;
            var dx = 0.0;
            var dy = 0.0;
            var prevX = fromX;
            var prevY = fromY;
            for (var i = 1; i <= n; ++i) {
                t = i / n;
                t2 = t * t;
                t3 = t2 * t;
                nt = (1.0 - t);
                nt2 = nt * nt;
                nt3 = nt2 * nt;
                x = (nt3 * fromX) + (3.0 * nt2 * t * cpX) + (3.0 * nt * t2 * cpX2) + (t3 * toX);
                y = (nt3 * fromY) + (3.0 * nt2 * t * cpY) + (3 * nt * t2 * cpY2) + (t3 * toY);
                dx = prevX - x;
                dy = prevY - y;
                prevX = x;
                prevY = y;
                result += Math.sqrt((dx * dx) + (dy * dy));
            }
            return result;
        };
        /**
         * Calculate the points for a bezier curve and then draws it.
         *
         * Ignored from docs since it is not directly exposed.
         * @ignore
         * @param cpX - Control point x
         * @param cpY - Control point y
         * @param cpX2 - Second Control point x
         * @param cpY2 - Second Control point y
         * @param toX - Destination point x
         * @param toY - Destination point y
         * @param points - Path array to push points into
         */
        BezierUtils.curveTo = function (cpX, cpY, cpX2, cpY2, toX, toY, points) {
            var fromX = points[points.length - 2];
            var fromY = points[points.length - 1];
            points.length -= 2;
            var n = GRAPHICS_CURVES._segmentsCount(BezierUtils.curveLength(fromX, fromY, cpX, cpY, cpX2, cpY2, toX, toY));
            var dt = 0;
            var dt2 = 0;
            var dt3 = 0;
            var t2 = 0;
            var t3 = 0;
            points.push(fromX, fromY);
            for (var i = 1, j = 0; i <= n; ++i) {
                j = i / n;
                dt = (1 - j);
                dt2 = dt * dt;
                dt3 = dt2 * dt;
                t2 = j * j;
                t3 = t2 * j;
                points.push((dt3 * fromX) + (3 * dt2 * j * cpX) + (3 * dt * t2 * cpX2) + (t3 * toX), (dt3 * fromY) + (3 * dt2 * j * cpY) + (3 * dt * t2 * cpY2) + (t3 * toY));
            }
        };
        return BezierUtils;
    }());

    /**
     * Utilities for quadratic curves.
     * @private
     */
    var QuadraticUtils = /** @class */ (function () {
        function QuadraticUtils() {
        }
        /**
         * Calculate length of quadratic curve
         * @see {@link http://www.malczak.linuxpl.com/blog/quadratic-bezier-curve-length/}
         * for the detailed explanation of math behind this.
         * @private
         * @param fromX - x-coordinate of curve start point
         * @param fromY - y-coordinate of curve start point
         * @param cpX - x-coordinate of curve control point
         * @param cpY - y-coordinate of curve control point
         * @param toX - x-coordinate of curve end point
         * @param toY - y-coordinate of curve end point
         * @returns - Length of quadratic curve
         */
        QuadraticUtils.curveLength = function (fromX, fromY, cpX, cpY, toX, toY) {
            var ax = fromX - (2.0 * cpX) + toX;
            var ay = fromY - (2.0 * cpY) + toY;
            var bx = (2.0 * cpX) - (2.0 * fromX);
            var by = (2.0 * cpY) - (2.0 * fromY);
            var a = 4.0 * ((ax * ax) + (ay * ay));
            var b = 4.0 * ((ax * bx) + (ay * by));
            var c = (bx * bx) + (by * by);
            var s = 2.0 * Math.sqrt(a + b + c);
            var a2 = Math.sqrt(a);
            var a32 = 2.0 * a * a2;
            var c2 = 2.0 * Math.sqrt(c);
            var ba = b / a2;
            return ((a32 * s)
                + (a2 * b * (s - c2))
                + (((4.0 * c * a) - (b * b))
                    * Math.log(((2.0 * a2) + ba + s) / (ba + c2)))) / (4.0 * a32);
        };
        /**
         * Calculate the points for a quadratic bezier curve and then draws it.
         * Based on: https://stackoverflow.com/questions/785097/how-do-i-implement-a-bezier-curve-in-c
         * @private
         * @param cpX - Control point x
         * @param cpY - Control point y
         * @param toX - Destination point x
         * @param toY - Destination point y
         * @param points - Points to add segments to.
         */
        QuadraticUtils.curveTo = function (cpX, cpY, toX, toY, points) {
            var fromX = points[points.length - 2];
            var fromY = points[points.length - 1];
            var n = GRAPHICS_CURVES._segmentsCount(QuadraticUtils.curveLength(fromX, fromY, cpX, cpY, toX, toY));
            var xa = 0;
            var ya = 0;
            for (var i = 1; i <= n; ++i) {
                var j = i / n;
                xa = fromX + ((cpX - fromX) * j);
                ya = fromY + ((cpY - fromY) * j);
                points.push(xa + (((cpX + ((toX - cpX) * j)) - xa) * j), ya + (((cpY + ((toY - cpY) * j)) - ya) * j));
            }
        };
        return QuadraticUtils;
    }());

    /**
     * A structure to hold interim batch objects for Graphics.
     * @memberof PIXI.graphicsUtils
     */
    var BatchPart = /** @class */ (function () {
        function BatchPart() {
            this.reset();
        }
        /**
         * Begin batch part.
         * @param style
         * @param startIndex
         * @param attribStart
         */
        BatchPart.prototype.begin = function (style, startIndex, attribStart) {
            this.reset();
            this.style = style;
            this.start = startIndex;
            this.attribStart = attribStart;
        };
        /**
         * End batch part.
         * @param endIndex
         * @param endAttrib
         */
        BatchPart.prototype.end = function (endIndex, endAttrib) {
            this.attribSize = endAttrib - this.attribStart;
            this.size = endIndex - this.start;
        };
        BatchPart.prototype.reset = function () {
            this.style = null;
            this.size = 0;
            this.start = 0;
            this.attribStart = 0;
            this.attribSize = 0;
        };
        return BatchPart;
    }());

    /**
     * Generalized convenience utilities for Graphics.
     * @namespace graphicsUtils
     * @memberof PIXI
     */
    var _a;
    /**
     * Map of fill commands for each shape type.
     * @memberof PIXI.graphicsUtils
     * @member {object} FILL_COMMANDS
     */
    var FILL_COMMANDS = (_a = {},
        _a[math.SHAPES.POLY] = buildPoly,
        _a[math.SHAPES.CIRC] = buildCircle,
        _a[math.SHAPES.ELIP] = buildCircle,
        _a[math.SHAPES.RECT] = buildRectangle,
        _a[math.SHAPES.RREC] = buildRoundedRectangle,
        _a);
    /**
     * Batch pool, stores unused batches for preventing allocations.
     * @memberof PIXI.graphicsUtils
     * @member {Array<PIXI.graphicsUtils.BatchPart>} BATCH_POOL
     */
    var BATCH_POOL = [];
    /**
     * Draw call pool, stores unused draw calls for preventing allocations.
     * @memberof PIXI.graphicsUtils
     * @member {Array<PIXI.BatchDrawCall>} DRAW_CALL_POOL
     */
    var DRAW_CALL_POOL = [];

    /**
     * A class to contain data useful for Graphics objects
     * @memberof PIXI
     */
    var GraphicsData = /** @class */ (function () {
        /**
         * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - The shape object to draw.
         * @param fillStyle - the width of the line to draw
         * @param lineStyle - the color of the line to draw
         * @param matrix - Transform matrix
         */
        function GraphicsData(shape, fillStyle, lineStyle, matrix) {
            if (fillStyle === void 0) { fillStyle = null; }
            if (lineStyle === void 0) { lineStyle = null; }
            if (matrix === void 0) { matrix = null; }
            /** The collection of points. */
            this.points = [];
            /** The collection of holes. */
            this.holes = [];
            this.shape = shape;
            this.lineStyle = lineStyle;
            this.fillStyle = fillStyle;
            this.matrix = matrix;
            this.type = shape.type;
        }
        /**
         * Creates a new GraphicsData object with the same values as this one.
         * @returns - Cloned GraphicsData object
         */
        GraphicsData.prototype.clone = function () {
            return new GraphicsData(this.shape, this.fillStyle, this.lineStyle, this.matrix);
        };
        /** Destroys the Graphics data. */
        GraphicsData.prototype.destroy = function () {
            this.shape = null;
            this.holes.length = 0;
            this.holes = null;
            this.points.length = 0;
            this.points = null;
            this.lineStyle = null;
            this.fillStyle = null;
        };
        return GraphicsData;
    }());

    var tmpPoint = new math.Point();
    /**
     * The Graphics class contains methods used to draw primitive shapes such as lines, circles and
     * rectangles to the display, and to color and fill them.
     *
     * GraphicsGeometry is designed to not be continually updating the geometry since it's expensive
     * to re-tesselate using **earcut**. Consider using {@link PIXI.Mesh} for this use-case, it's much faster.
     * @memberof PIXI
     */
    var GraphicsGeometry = /** @class */ (function (_super) {
        __extends(GraphicsGeometry, _super);
        // eslint-disable-next-line @typescript-eslint/no-useless-constructor
        function GraphicsGeometry() {
            var _this = _super.call(this) || this;
            /** Minimal distance between points that are considered different. Affects line tesselation. */
            _this.closePointEps = 1e-4;
            /** Padding to add to the bounds. */
            _this.boundsPadding = 0;
            _this.uvsFloat32 = null;
            _this.indicesUint16 = null;
            _this.batchable = false;
            /** An array of points to draw, 2 numbers per point */
            _this.points = [];
            /** The collection of colors */
            _this.colors = [];
            /** The UVs collection */
            _this.uvs = [];
            /** The indices of the vertices */
            _this.indices = [];
            /** Reference to the texture IDs. */
            _this.textureIds = [];
            /**
             * The collection of drawn shapes.
             * @member {PIXI.GraphicsData[]}
             */
            _this.graphicsData = [];
            /**
             * List of current draw calls drived from the batches.
             * @member {PIXI.BatchDrawCall[]}
             */
            _this.drawCalls = [];
            /** Batches need to regenerated if the geometry is updated. */
            _this.batchDirty = -1;
            /**
             * Intermediate abstract format sent to batch system.
             * Can be converted to drawCalls or to batchable objects.
             * @member {PIXI.graphicsUtils.BatchPart[]}
             */
            _this.batches = [];
            /** Used to detect if the graphics object has changed. */
            _this.dirty = 0;
            /** Used to check if the cache is dirty. */
            _this.cacheDirty = -1;
            /** Used to detect if we cleared the graphicsData. */
            _this.clearDirty = 0;
            /** Index of the last batched shape in the stack of calls. */
            _this.shapeIndex = 0;
            /** Cached bounds. */
            _this._bounds = new display.Bounds();
            /** The bounds dirty flag. */
            _this.boundsDirty = -1;
            return _this;
        }
        Object.defineProperty(GraphicsGeometry.prototype, "bounds", {
            /**
             * Get the current bounds of the graphic geometry.
             * @readonly
             */
            get: function () {
                this.updateBatches();
                if (this.boundsDirty !== this.dirty) {
                    this.boundsDirty = this.dirty;
                    this.calculateBounds();
                }
                return this._bounds;
            },
            enumerable: false,
            configurable: true
        });
        /** Call if you changed graphicsData manually. Empties all batch buffers. */
        GraphicsGeometry.prototype.invalidate = function () {
            this.boundsDirty = -1;
            this.dirty++;
            this.batchDirty++;
            this.shapeIndex = 0;
            this.points.length = 0;
            this.colors.length = 0;
            this.uvs.length = 0;
            this.indices.length = 0;
            this.textureIds.length = 0;
            for (var i = 0; i < this.drawCalls.length; i++) {
                this.drawCalls[i].texArray.clear();
                DRAW_CALL_POOL.push(this.drawCalls[i]);
            }
            this.drawCalls.length = 0;
            for (var i = 0; i < this.batches.length; i++) {
                var batchPart = this.batches[i];
                batchPart.reset();
                BATCH_POOL.push(batchPart);
            }
            this.batches.length = 0;
        };
        /**
         * Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
         * @returns - This GraphicsGeometry object. Good for chaining method calls
         */
        GraphicsGeometry.prototype.clear = function () {
            if (this.graphicsData.length > 0) {
                this.invalidate();
                this.clearDirty++;
                this.graphicsData.length = 0;
            }
            return this;
        };
        /**
         * Draws the given shape to this Graphics object. Can be any of Circle, Rectangle, Ellipse, Line or Polygon.
         * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - The shape object to draw.
         * @param fillStyle - Defines style of the fill.
         * @param lineStyle - Defines style of the lines.
         * @param matrix - Transform applied to the points of the shape.
         * @returns - Returns geometry for chaining.
         */
        GraphicsGeometry.prototype.drawShape = function (shape, fillStyle, lineStyle, matrix) {
            if (fillStyle === void 0) { fillStyle = null; }
            if (lineStyle === void 0) { lineStyle = null; }
            if (matrix === void 0) { matrix = null; }
            var data = new GraphicsData(shape, fillStyle, lineStyle, matrix);
            this.graphicsData.push(data);
            this.dirty++;
            return this;
        };
        /**
         * Draws the given shape to this Graphics object. Can be any of Circle, Rectangle, Ellipse, Line or Polygon.
         * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - The shape object to draw.
         * @param matrix - Transform applied to the points of the shape.
         * @returns - Returns geometry for chaining.
         */
        GraphicsGeometry.prototype.drawHole = function (shape, matrix) {
            if (matrix === void 0) { matrix = null; }
            if (!this.graphicsData.length) {
                return null;
            }
            var data = new GraphicsData(shape, null, null, matrix);
            var lastShape = this.graphicsData[this.graphicsData.length - 1];
            data.lineStyle = lastShape.lineStyle;
            lastShape.holes.push(data);
            this.dirty++;
            return this;
        };
        /** Destroys the GraphicsGeometry object. */
        GraphicsGeometry.prototype.destroy = function () {
            _super.prototype.destroy.call(this);
            // destroy each of the GraphicsData objects
            for (var i = 0; i < this.graphicsData.length; ++i) {
                this.graphicsData[i].destroy();
            }
            this.points.length = 0;
            this.points = null;
            this.colors.length = 0;
            this.colors = null;
            this.uvs.length = 0;
            this.uvs = null;
            this.indices.length = 0;
            this.indices = null;
            this.indexBuffer.destroy();
            this.indexBuffer = null;
            this.graphicsData.length = 0;
            this.graphicsData = null;
            this.drawCalls.length = 0;
            this.drawCalls = null;
            this.batches.length = 0;
            this.batches = null;
            this._bounds = null;
        };
        /**
         * Check to see if a point is contained within this geometry.
         * @param point - Point to check if it's contained.
         * @returns {boolean} `true` if the point is contained within geometry.
         */
        GraphicsGeometry.prototype.containsPoint = function (point) {
            var graphicsData = this.graphicsData;
            for (var i = 0; i < graphicsData.length; ++i) {
                var data = graphicsData[i];
                if (!data.fillStyle.visible) {
                    continue;
                }
                // only deal with fills..
                if (data.shape) {
                    if (data.matrix) {
                        data.matrix.applyInverse(point, tmpPoint);
                    }
                    else {
                        tmpPoint.copyFrom(point);
                    }
                    if (data.shape.contains(tmpPoint.x, tmpPoint.y)) {
                        var hitHole = false;
                        if (data.holes) {
                            for (var i_1 = 0; i_1 < data.holes.length; i_1++) {
                                var hole = data.holes[i_1];
                                if (hole.shape.contains(tmpPoint.x, tmpPoint.y)) {
                                    hitHole = true;
                                    break;
                                }
                            }
                        }
                        if (!hitHole) {
                            return true;
                        }
                    }
                }
            }
            return false;
        };
        /**
         * Generates intermediate batch data. Either gets converted to drawCalls
         * or used to convert to batch objects directly by the Graphics object.
         */
        GraphicsGeometry.prototype.updateBatches = function () {
            if (!this.graphicsData.length) {
                this.batchable = true;
                return;
            }
            if (!this.validateBatching()) {
                return;
            }
            this.cacheDirty = this.dirty;
            var uvs = this.uvs;
            var graphicsData = this.graphicsData;
            var batchPart = null;
            var currentStyle = null;
            if (this.batches.length > 0) {
                batchPart = this.batches[this.batches.length - 1];
                currentStyle = batchPart.style;
            }
            for (var i = this.shapeIndex; i < graphicsData.length; i++) {
                this.shapeIndex++;
                var data = graphicsData[i];
                var fillStyle = data.fillStyle;
                var lineStyle = data.lineStyle;
                var command = FILL_COMMANDS[data.type];
                // build out the shapes points..
                command.build(data);
                if (data.matrix) {
                    this.transformPoints(data.points, data.matrix);
                }
                if (fillStyle.visible || lineStyle.visible) {
                    this.processHoles(data.holes);
                }
                for (var j = 0; j < 2; j++) {
                    var style = (j === 0) ? fillStyle : lineStyle;
                    if (!style.visible)
                        { continue; }
                    var nextTexture = style.texture.baseTexture;
                    var index_1 = this.indices.length;
                    var attribIndex = this.points.length / 2;
                    nextTexture.wrapMode = constants.WRAP_MODES.REPEAT;
                    if (j === 0) {
                        this.processFill(data);
                    }
                    else {
                        this.processLine(data);
                    }
                    var size = (this.points.length / 2) - attribIndex;
                    if (size === 0)
                        { continue; }
                    // close batch if style is different
                    if (batchPart && !this._compareStyles(currentStyle, style)) {
                        batchPart.end(index_1, attribIndex);
                        batchPart = null;
                    }
                    // spawn new batch if its first batch or previous was closed
                    if (!batchPart) {
                        batchPart = BATCH_POOL.pop() || new BatchPart();
                        batchPart.begin(style, index_1, attribIndex);
                        this.batches.push(batchPart);
                        currentStyle = style;
                    }
                    this.addUvs(this.points, uvs, style.texture, attribIndex, size, style.matrix);
                }
            }
            var index = this.indices.length;
            var attrib = this.points.length / 2;
            if (batchPart) {
                batchPart.end(index, attrib);
            }
            if (this.batches.length === 0) {
                // there are no visible styles in GraphicsData
                // its possible that someone wants Graphics just for the bounds
                this.batchable = true;
                return;
            }
            var need32 = attrib > 0xffff;
            // prevent allocation when length is same as buffer
            if (this.indicesUint16 && this.indices.length === this.indicesUint16.length
                && need32 === (this.indicesUint16.BYTES_PER_ELEMENT > 2)) {
                this.indicesUint16.set(this.indices);
            }
            else {
                this.indicesUint16 = need32 ? new Uint32Array(this.indices) : new Uint16Array(this.indices);
            }
            // TODO make this a const..
            this.batchable = this.isBatchable();
            if (this.batchable) {
                this.packBatches();
            }
            else {
                this.buildDrawCalls();
            }
        };
        /**
         * Affinity check
         * @param styleA
         * @param styleB
         */
        GraphicsGeometry.prototype._compareStyles = function (styleA, styleB) {
            if (!styleA || !styleB) {
                return false;
            }
            if (styleA.texture.baseTexture !== styleB.texture.baseTexture) {
                return false;
            }
            if (styleA.color + styleA.alpha !== styleB.color + styleB.alpha) {
                return false;
            }
            if (!!styleA.native !== !!styleB.native) {
                return false;
            }
            return true;
        };
        /** Test geometry for batching process. */
        GraphicsGeometry.prototype.validateBatching = function () {
            if (this.dirty === this.cacheDirty || !this.graphicsData.length) {
                return false;
            }
            for (var i = 0, l = this.graphicsData.length; i < l; i++) {
                var data = this.graphicsData[i];
                var fill = data.fillStyle;
                var line = data.lineStyle;
                if (fill && !fill.texture.baseTexture.valid)
                    { return false; }
                if (line && !line.texture.baseTexture.valid)
                    { return false; }
            }
            return true;
        };
        /** Offset the indices so that it works with the batcher. */
        GraphicsGeometry.prototype.packBatches = function () {
            this.batchDirty++;
            this.uvsFloat32 = new Float32Array(this.uvs);
            var batches = this.batches;
            for (var i = 0, l = batches.length; i < l; i++) {
                var batch = batches[i];
                for (var j = 0; j < batch.size; j++) {
                    var index = batch.start + j;
                    this.indicesUint16[index] = this.indicesUint16[index] - batch.attribStart;
                }
            }
        };
        /**
         * Checks to see if this graphics geometry can be batched.
         * Currently it needs to be small enough and not contain any native lines.
         */
        GraphicsGeometry.prototype.isBatchable = function () {
            // prevent heavy mesh batching
            if (this.points.length > 0xffff * 2) {
                return false;
            }
            var batches = this.batches;
            for (var i = 0; i < batches.length; i++) {
                if (batches[i].style.native) {
                    return false;
                }
            }
            return (this.points.length < GraphicsGeometry.BATCHABLE_SIZE * 2);
        };
        /** Converts intermediate batches data to drawCalls. */
        GraphicsGeometry.prototype.buildDrawCalls = function () {
            var TICK = ++core.BaseTexture._globalBatch;
            for (var i = 0; i < this.drawCalls.length; i++) {
                this.drawCalls[i].texArray.clear();
                DRAW_CALL_POOL.push(this.drawCalls[i]);
            }
            this.drawCalls.length = 0;
            var colors = this.colors;
            var textureIds = this.textureIds;
            var currentGroup = DRAW_CALL_POOL.pop();
            if (!currentGroup) {
                currentGroup = new core.BatchDrawCall();
                currentGroup.texArray = new core.BatchTextureArray();
            }
            currentGroup.texArray.count = 0;
            currentGroup.start = 0;
            currentGroup.size = 0;
            currentGroup.type = constants.DRAW_MODES.TRIANGLES;
            var textureCount = 0;
            var currentTexture = null;
            var textureId = 0;
            var native = false;
            var drawMode = constants.DRAW_MODES.TRIANGLES;
            var index = 0;
            this.drawCalls.push(currentGroup);
            // TODO - this can be simplified
            for (var i = 0; i < this.batches.length; i++) {
                var data = this.batches[i];
                // TODO add some full on MAX_TEXTURE CODE..
                var MAX_TEXTURES = 8;
                // Forced cast for checking `native` without errors
                var style = data.style;
                var nextTexture = style.texture.baseTexture;
                if (native !== !!style.native) {
                    native = !!style.native;
                    drawMode = native ? constants.DRAW_MODES.LINES : constants.DRAW_MODES.TRIANGLES;
                    // force the batch to break!
                    currentTexture = null;
                    textureCount = MAX_TEXTURES;
                    TICK++;
                }
                if (currentTexture !== nextTexture) {
                    currentTexture = nextTexture;
                    if (nextTexture._batchEnabled !== TICK) {
                        if (textureCount === MAX_TEXTURES) {
                            TICK++;
                            textureCount = 0;
                            if (currentGroup.size > 0) {
                                currentGroup = DRAW_CALL_POOL.pop();
                                if (!currentGroup) {
                                    currentGroup = new core.BatchDrawCall();
                                    currentGroup.texArray = new core.BatchTextureArray();
                                }
                                this.drawCalls.push(currentGroup);
                            }
                            currentGroup.start = index;
                            currentGroup.size = 0;
                            currentGroup.texArray.count = 0;
                            currentGroup.type = drawMode;
                        }
                        // TODO add this to the render part..
                        // Hack! Because texture has protected `touched`
                        nextTexture.touched = 1; // touch;
                        nextTexture._batchEnabled = TICK;
                        nextTexture._batchLocation = textureCount;
                        nextTexture.wrapMode = constants.WRAP_MODES.REPEAT;
                        currentGroup.texArray.elements[currentGroup.texArray.count++] = nextTexture;
                        textureCount++;
                    }
                }
                currentGroup.size += data.size;
                index += data.size;
                textureId = nextTexture._batchLocation;
                this.addColors(colors, style.color, style.alpha, data.attribSize, data.attribStart);
                this.addTextureIds(textureIds, textureId, data.attribSize, data.attribStart);
            }
            core.BaseTexture._globalBatch = TICK;
            // upload..
            // merge for now!
            this.packAttributes();
        };
        /** Packs attributes to single buffer. */
        GraphicsGeometry.prototype.packAttributes = function () {
            var verts = this.points;
            var uvs = this.uvs;
            var colors = this.colors;
            var textureIds = this.textureIds;
            // verts are 2 positions.. so we * by 3 as there are 6 properties.. then 4 cos its bytes
            var glPoints = new ArrayBuffer(verts.length * 3 * 4);
            var f32 = new Float32Array(glPoints);
            var u32 = new Uint32Array(glPoints);
            var p = 0;
            for (var i = 0; i < verts.length / 2; i++) {
                f32[p++] = verts[i * 2];
                f32[p++] = verts[(i * 2) + 1];
                f32[p++] = uvs[i * 2];
                f32[p++] = uvs[(i * 2) + 1];
                u32[p++] = colors[i];
                f32[p++] = textureIds[i];
            }
            this._buffer.update(glPoints);
            this._indexBuffer.update(this.indicesUint16);
        };
        /**
         * Process fill part of Graphics.
         * @param data
         */
        GraphicsGeometry.prototype.processFill = function (data) {
            if (data.holes.length) {
                buildPoly.triangulate(data, this);
            }
            else {
                var command = FILL_COMMANDS[data.type];
                command.triangulate(data, this);
            }
        };
        /**
         * Process line part of Graphics.
         * @param data
         */
        GraphicsGeometry.prototype.processLine = function (data) {
            buildLine(data, this);
            for (var i = 0; i < data.holes.length; i++) {
                buildLine(data.holes[i], this);
            }
        };
        /**
         * Process the holes data.
         * @param holes
         */
        GraphicsGeometry.prototype.processHoles = function (holes) {
            for (var i = 0; i < holes.length; i++) {
                var hole = holes[i];
                var command = FILL_COMMANDS[hole.type];
                command.build(hole);
                if (hole.matrix) {
                    this.transformPoints(hole.points, hole.matrix);
                }
            }
        };
        /** Update the local bounds of the object. Expensive to use performance-wise. */
        GraphicsGeometry.prototype.calculateBounds = function () {
            var bounds = this._bounds;
            bounds.clear();
            bounds.addVertexData(this.points, 0, this.points.length);
            bounds.pad(this.boundsPadding, this.boundsPadding);
        };
        /**
         * Transform points using matrix.
         * @param points - Points to transform
         * @param matrix - Transform matrix
         */
        GraphicsGeometry.prototype.transformPoints = function (points, matrix) {
            for (var i = 0; i < points.length / 2; i++) {
                var x = points[(i * 2)];
                var y = points[(i * 2) + 1];
                points[(i * 2)] = (matrix.a * x) + (matrix.c * y) + matrix.tx;
                points[(i * 2) + 1] = (matrix.b * x) + (matrix.d * y) + matrix.ty;
            }
        };
        /**
         * Add colors.
         * @param colors - List of colors to add to
         * @param color - Color to add
         * @param alpha - Alpha to use
         * @param size - Number of colors to add
         * @param offset
         */
        GraphicsGeometry.prototype.addColors = function (colors, color, alpha, size, offset) {
            if (offset === void 0) { offset = 0; }
            // TODO use the premultiply bits Ivan added
            var rgb = (color >> 16) + (color & 0xff00) + ((color & 0xff) << 16);
            var rgba = utils.premultiplyTint(rgb, alpha);
            colors.length = Math.max(colors.length, offset + size);
            for (var i = 0; i < size; i++) {
                colors[offset + i] = rgba;
            }
        };
        /**
         * Add texture id that the shader/fragment wants to use.
         * @param textureIds
         * @param id
         * @param size
         * @param offset
         */
        GraphicsGeometry.prototype.addTextureIds = function (textureIds, id, size, offset) {
            if (offset === void 0) { offset = 0; }
            textureIds.length = Math.max(textureIds.length, offset + size);
            for (var i = 0; i < size; i++) {
                textureIds[offset + i] = id;
            }
        };
        /**
         * Generates the UVs for a shape.
         * @param verts - Vertices
         * @param uvs - UVs
         * @param texture - Reference to Texture
         * @param start - Index buffer start index.
         * @param size - The size/length for index buffer.
         * @param matrix - Optional transform for all points.
         */
        GraphicsGeometry.prototype.addUvs = function (verts, uvs, texture, start, size, matrix) {
            if (matrix === void 0) { matrix = null; }
            var index = 0;
            var uvsStart = uvs.length;
            var frame = texture.frame;
            while (index < size) {
                var x = verts[(start + index) * 2];
                var y = verts[((start + index) * 2) + 1];
                if (matrix) {
                    var nx = (matrix.a * x) + (matrix.c * y) + matrix.tx;
                    y = (matrix.b * x) + (matrix.d * y) + matrix.ty;
                    x = nx;
                }
                index++;
                uvs.push(x / frame.width, y / frame.height);
            }
            var baseTexture = texture.baseTexture;
            if (frame.width < baseTexture.width
                || frame.height < baseTexture.height) {
                this.adjustUvs(uvs, texture, uvsStart, size);
            }
        };
        /**
         * Modify uvs array according to position of texture region
         * Does not work with rotated or trimmed textures
         * @param uvs - array
         * @param texture - region
         * @param start - starting index for uvs
         * @param size - how many points to adjust
         */
        GraphicsGeometry.prototype.adjustUvs = function (uvs, texture, start, size) {
            var baseTexture = texture.baseTexture;
            var eps = 1e-6;
            var finish = start + (size * 2);
            var frame = texture.frame;
            var scaleX = frame.width / baseTexture.width;
            var scaleY = frame.height / baseTexture.height;
            var offsetX = frame.x / frame.width;
            var offsetY = frame.y / frame.height;
            var minX = Math.floor(uvs[start] + eps);
            var minY = Math.floor(uvs[start + 1] + eps);
            for (var i = start + 2; i < finish; i += 2) {
                minX = Math.min(minX, Math.floor(uvs[i] + eps));
                minY = Math.min(minY, Math.floor(uvs[i + 1] + eps));
            }
            offsetX -= minX;
            offsetY -= minY;
            for (var i = start; i < finish; i += 2) {
                uvs[i] = (uvs[i] + offsetX) * scaleX;
                uvs[i + 1] = (uvs[i + 1] + offsetY) * scaleY;
            }
        };
        /**
         * The maximum number of points to consider an object "batchable",
         * able to be batched by the renderer's batch system.
    \
         */
        GraphicsGeometry.BATCHABLE_SIZE = 100;
        return GraphicsGeometry;
    }(core.BatchGeometry));

    /**
     * Represents the line style for Graphics.
     * @memberof PIXI
     */
    var LineStyle = /** @class */ (function (_super) {
        __extends(LineStyle, _super);
        function LineStyle() {
            var _this = _super !== null && _super.apply(this, arguments) || this;
            /** The width (thickness) of any lines drawn. */
            _this.width = 0;
            /** The alignment of any lines drawn (0.5 = middle, 1 = outer, 0 = inner). WebGL only. */
            _this.alignment = 0.5;
            /** If true the lines will be draw using LINES instead of TRIANGLE_STRIP. */
            _this.native = false;
            /**
             * Line cap style.
             * @member {PIXI.LINE_CAP}
             * @default PIXI.LINE_CAP.BUTT
             */
            _this.cap = exports.LINE_CAP.BUTT;
            /**
             * Line join style.
             * @member {PIXI.LINE_JOIN}
             * @default PIXI.LINE_JOIN.MITER
             */
            _this.join = exports.LINE_JOIN.MITER;
            /** Miter limit. */
            _this.miterLimit = 10;
            return _this;
        }
        /** Clones the object. */
        LineStyle.prototype.clone = function () {
            var obj = new LineStyle();
            obj.color = this.color;
            obj.alpha = this.alpha;
            obj.texture = this.texture;
            obj.matrix = this.matrix;
            obj.visible = this.visible;
            obj.width = this.width;
            obj.alignment = this.alignment;
            obj.native = this.native;
            obj.cap = this.cap;
            obj.join = this.join;
            obj.miterLimit = this.miterLimit;
            return obj;
        };
        /** Reset the line style to default. */
        LineStyle.prototype.reset = function () {
            _super.prototype.reset.call(this);
            // Override default line style color
            this.color = 0x0;
            this.alignment = 0.5;
            this.width = 0;
            this.native = false;
        };
        return LineStyle;
    }(FillStyle));

    var temp = new Float32Array(3);
    // a default shaders map used by graphics..
    var DEFAULT_SHADERS = {};
    /**
     * The Graphics class is primarily used to render primitive shapes such as lines, circles and
     * rectangles to the display, and to color and fill them.  However, you can also use a Graphics
     * object to build a list of primitives to use as a mask, or as a complex hitArea.
     *
     * Please note that due to legacy naming conventions, the behavior of some functions in this class
     * can be confusing.  Each call to `drawRect()`, `drawPolygon()`, etc. actually stores that primitive
     * in the Geometry class's GraphicsGeometry object for later use in rendering or hit testing - the
     * functions do not directly draw anything to the screen.  Similarly, the `clear()` function doesn't
     * change the screen, it simply resets the list of primitives, which can be useful if you want to
     * rebuild the contents of an existing Graphics object.
     *
     * Once a GraphicsGeometry list is built, you can re-use it in other Geometry objects as
     * an optimization, by passing it into a new Geometry object's constructor.  Because of this
     * ability, it's important to call `destroy()` on Geometry objects once you are done with them, to
     * properly dereference each GraphicsGeometry and prevent memory leaks.
     * @memberof PIXI
     */
    var Graphics = /** @class */ (function (_super) {
        __extends(Graphics, _super);
        /**
         * @param geometry - Geometry to use, if omitted will create a new GraphicsGeometry instance.
         */
        function Graphics(geometry) {
            if (geometry === void 0) { geometry = null; }
            var _this = _super.call(this) || this;
            /**
             * Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
             * Can be shared between multiple Graphics objects.
             */
            _this.shader = null;
            /** Renderer plugin for batching */
            _this.pluginName = 'batch';
            /**
             * Current path
             * @readonly
             */
            _this.currentPath = null;
            /** A collections of batches! These can be drawn by the renderer batch system. */
            _this.batches = [];
            /** Update dirty for limiting calculating tints for batches. */
            _this.batchTint = -1;
            /** Update dirty for limiting calculating batches.*/
            _this.batchDirty = -1;
            /** Copy of the object vertex data. */
            _this.vertexData = null;
            /** Current fill style. */
            _this._fillStyle = new FillStyle();
            /** Current line style. */
            _this._lineStyle = new LineStyle();
            /** Current shape transform matrix. */
            _this._matrix = null;
            /** Current hole mode is enabled. */
            _this._holeMode = false;
            /**
             * Represents the WebGL state the Graphics required to render, excludes shader and geometry. E.g.,
             * blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
             */
            _this.state = core.State.for2d();
            _this._geometry = geometry || new GraphicsGeometry();
            _this._geometry.refCount++;
            /**
             * When cacheAsBitmap is set to true the graphics object will be rendered as if it was a sprite.
             * This is useful if your graphics element does not change often, as it will speed up the rendering
             * of the object in exchange for taking up texture memory. It is also useful if you need the graphics
             * object to be anti-aliased, because it will be rendered using canvas. This is not recommended if
             * you are constantly redrawing the graphics element.
             * @name cacheAsBitmap
             * @member {boolean}
             * @memberof PIXI.Graphics#
             * @default false
             */
            _this._transformID = -1;
            // Set default
            _this.tint = 0xFFFFFF;
            _this.blendMode = constants.BLEND_MODES.NORMAL;
            return _this;
        }
        Object.defineProperty(Graphics.prototype, "geometry", {
            /**
             * Includes vertex positions, face indices, normals, colors, UVs, and
             * custom attributes within buffers, reducing the cost of passing all
             * this data to the GPU. Can be shared between multiple Mesh or Graphics objects.
             * @readonly
             */
            get: function () {
                return this._geometry;
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Creates a new Graphics object with the same values as this one.
         * Note that only the geometry of the object is cloned, not its transform (position,scale,etc)
         * @returns - A clone of the graphics object
         */
        Graphics.prototype.clone = function () {
            this.finishPoly();
            return new Graphics(this._geometry);
        };
        Object.defineProperty(Graphics.prototype, "blendMode", {
            get: function () {
                return this.state.blendMode;
            },
            /**
             * The blend mode to be applied to the graphic shape. Apply a value of
             * `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.  Note that, since each
             * primitive in the GraphicsGeometry list is rendered sequentially, modes
             * such as `PIXI.BLEND_MODES.ADD` and `PIXI.BLEND_MODES.MULTIPLY` will
             * be applied per-primitive.
             * @default PIXI.BLEND_MODES.NORMAL
             */
            set: function (value) {
                this.state.blendMode = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Graphics.prototype, "tint", {
            /**
             * The tint applied to each graphic shape. This is a hex value. A value of
             * 0xFFFFFF will remove any tint effect.
             * @default 0xFFFFFF
             */
            get: function () {
                return this._tint;
            },
            set: function (value) {
                this._tint = value;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Graphics.prototype, "fill", {
            /**
             * The current fill style.
             * @readonly
             */
            get: function () {
                return this._fillStyle;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Graphics.prototype, "line", {
            /**
             * The current line style.
             * @readonly
             */
            get: function () {
                return this._lineStyle;
            },
            enumerable: false,
            configurable: true
        });
        Graphics.prototype.lineStyle = function (options, color, alpha, alignment, native) {
            if (options === void 0) { options = null; }
            if (color === void 0) { color = 0x0; }
            if (alpha === void 0) { alpha = 1; }
            if (alignment === void 0) { alignment = 0.5; }
            if (native === void 0) { native = false; }
            // Support non-object params: (width, color, alpha, alignment, native)
            if (typeof options === 'number') {
                options = { width: options, color: color, alpha: alpha, alignment: alignment, native: native };
            }
            return this.lineTextureStyle(options);
        };
        /**
         * Like line style but support texture for line fill.
         * @param [options] - Collection of options for setting line style.
         * @param {number} [options.width=0] - width of the line to draw, will update the objects stored style
         * @param {PIXI.Texture} [options.texture=PIXI.Texture.WHITE] - Texture to use
         * @param {number} [options.color=0x0] - color of the line to draw, will update the objects stored style.
         *  Default 0xFFFFFF if texture present.
         * @param {number} [options.alpha=1] - alpha of the line to draw, will update the objects stored style
         * @param {PIXI.Matrix} [options.matrix=null] - Texture matrix to transform texture
         * @param {number} [options.alignment=0.5] - alignment of the line to draw, (0 = inner, 0.5 = middle, 1 = outer).
         *        WebGL only.
         * @param {boolean} [options.native=false] - If true the lines will be draw using LINES instead of TRIANGLE_STRIP
         * @param {PIXI.LINE_CAP}[options.cap=PIXI.LINE_CAP.BUTT] - line cap style
         * @param {PIXI.LINE_JOIN}[options.join=PIXI.LINE_JOIN.MITER] - line join style
         * @param {number}[options.miterLimit=10] - miter limit ratio
         * @returns {PIXI.Graphics} This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.lineTextureStyle = function (options) {
            // Apply defaults
            options = Object.assign({
                width: 0,
                texture: core.Texture.WHITE,
                color: (options && options.texture) ? 0xFFFFFF : 0x0,
                alpha: 1,
                matrix: null,
                alignment: 0.5,
                native: false,
                cap: exports.LINE_CAP.BUTT,
                join: exports.LINE_JOIN.MITER,
                miterLimit: 10,
            }, options);
            if (this.currentPath) {
                this.startPoly();
            }
            var visible = options.width > 0 && options.alpha > 0;
            if (!visible) {
                this._lineStyle.reset();
            }
            else {
                if (options.matrix) {
                    options.matrix = options.matrix.clone();
                    options.matrix.invert();
                }
                Object.assign(this._lineStyle, { visible: visible }, options);
            }
            return this;
        };
        /**
         * Start a polygon object internally.
         * @protected
         */
        Graphics.prototype.startPoly = function () {
            if (this.currentPath) {
                var points = this.currentPath.points;
                var len = this.currentPath.points.length;
                if (len > 2) {
                    this.drawShape(this.currentPath);
                    this.currentPath = new math.Polygon();
                    this.currentPath.closeStroke = false;
                    this.currentPath.points.push(points[len - 2], points[len - 1]);
                }
            }
            else {
                this.currentPath = new math.Polygon();
                this.currentPath.closeStroke = false;
            }
        };
        /**
         * Finish the polygon object.
         * @protected
         */
        Graphics.prototype.finishPoly = function () {
            if (this.currentPath) {
                if (this.currentPath.points.length > 2) {
                    this.drawShape(this.currentPath);
                    this.currentPath = null;
                }
                else {
                    this.currentPath.points.length = 0;
                }
            }
        };
        /**
         * Moves the current drawing position to x, y.
         * @param x - the X coordinate to move to
         * @param y - the Y coordinate to move to
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.moveTo = function (x, y) {
            this.startPoly();
            this.currentPath.points[0] = x;
            this.currentPath.points[1] = y;
            return this;
        };
        /**
         * Draws a line using the current line style from the current drawing position to (x, y);
         * The current drawing position is then set to (x, y).
         * @param x - the X coordinate to draw to
         * @param y - the Y coordinate to draw to
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.lineTo = function (x, y) {
            if (!this.currentPath) {
                this.moveTo(0, 0);
            }
            // remove duplicates..
            var points = this.currentPath.points;
            var fromX = points[points.length - 2];
            var fromY = points[points.length - 1];
            if (fromX !== x || fromY !== y) {
                points.push(x, y);
            }
            return this;
        };
        /**
         * Initialize the curve
         * @param x
         * @param y
         */
        Graphics.prototype._initCurve = function (x, y) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = 0; }
            if (this.currentPath) {
                if (this.currentPath.points.length === 0) {
                    this.currentPath.points = [x, y];
                }
            }
            else {
                this.moveTo(x, y);
            }
        };
        /**
         * Calculate the points for a quadratic bezier curve and then draws it.
         * Based on: https://stackoverflow.com/questions/785097/how-do-i-implement-a-bezier-curve-in-c
         * @param cpX - Control point x
         * @param cpY - Control point y
         * @param toX - Destination point x
         * @param toY - Destination point y
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.quadraticCurveTo = function (cpX, cpY, toX, toY) {
            this._initCurve();
            var points = this.currentPath.points;
            if (points.length === 0) {
                this.moveTo(0, 0);
            }
            QuadraticUtils.curveTo(cpX, cpY, toX, toY, points);
            return this;
        };
        /**
         * Calculate the points for a bezier curve and then draws it.
         * @param cpX - Control point x
         * @param cpY - Control point y
         * @param cpX2 - Second Control point x
         * @param cpY2 - Second Control point y
         * @param toX - Destination point x
         * @param toY - Destination point y
         * @returns This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.bezierCurveTo = function (cpX, cpY, cpX2, cpY2, toX, toY) {
            this._initCurve();
            BezierUtils.curveTo(cpX, cpY, cpX2, cpY2, toX, toY, this.currentPath.points);
            return this;
        };
        /**
         * The arcTo() method creates an arc/curve between two tangents on the canvas.
         *
         * "borrowed" from https://code.google.com/p/fxcanvas/ - thanks google!
         * @param x1 - The x-coordinate of the first tangent point of the arc
         * @param y1 - The y-coordinate of the first tangent point of the arc
         * @param x2 - The x-coordinate of the end of the arc
         * @param y2 - The y-coordinate of the end of the arc
         * @param radius - The radius of the arc
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.arcTo = function (x1, y1, x2, y2, radius) {
            this._initCurve(x1, y1);
            var points = this.currentPath.points;
            var result = ArcUtils.curveTo(x1, y1, x2, y2, radius, points);
            if (result) {
                var cx = result.cx, cy = result.cy, radius_1 = result.radius, startAngle = result.startAngle, endAngle = result.endAngle, anticlockwise = result.anticlockwise;
                this.arc(cx, cy, radius_1, startAngle, endAngle, anticlockwise);
            }
            return this;
        };
        /**
         * The arc method creates an arc/curve (used to create circles, or parts of circles).
         * @param cx - The x-coordinate of the center of the circle
         * @param cy - The y-coordinate of the center of the circle
         * @param radius - The radius of the circle
         * @param startAngle - The starting angle, in radians (0 is at the 3 o'clock position
         *  of the arc's circle)
         * @param endAngle - The ending angle, in radians
         * @param anticlockwise - Specifies whether the drawing should be
         *  counter-clockwise or clockwise. False is default, and indicates clockwise, while true
         *  indicates counter-clockwise.
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.arc = function (cx, cy, radius, startAngle, endAngle, anticlockwise) {
            if (anticlockwise === void 0) { anticlockwise = false; }
            if (startAngle === endAngle) {
                return this;
            }
            if (!anticlockwise && endAngle <= startAngle) {
                endAngle += math.PI_2;
            }
            else if (anticlockwise && startAngle <= endAngle) {
                startAngle += math.PI_2;
            }
            var sweep = endAngle - startAngle;
            if (sweep === 0) {
                return this;
            }
            var startX = cx + (Math.cos(startAngle) * radius);
            var startY = cy + (Math.sin(startAngle) * radius);
            var eps = this._geometry.closePointEps;
            // If the currentPath exists, take its points. Otherwise call `moveTo` to start a path.
            var points = this.currentPath ? this.currentPath.points : null;
            if (points) {
                // TODO: make a better fix.
                // We check how far our start is from the last existing point
                var xDiff = Math.abs(points[points.length - 2] - startX);
                var yDiff = Math.abs(points[points.length - 1] - startY);
                if (xDiff < eps && yDiff < eps) {
                    // If the point is very close, we don't add it, since this would lead to artifacts
                    // during tessellation due to floating point imprecision.
                }
                else {
                    points.push(startX, startY);
                }
            }
            else {
                this.moveTo(startX, startY);
                points = this.currentPath.points;
            }
            ArcUtils.arc(startX, startY, cx, cy, radius, startAngle, endAngle, anticlockwise, points);
            return this;
        };
        /**
         * Specifies a simple one-color fill that subsequent calls to other Graphics methods
         * (such as lineTo() or drawCircle()) use when drawing.
         * @param color - the color of the fill
         * @param alpha - the alpha of the fill
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.beginFill = function (color, alpha) {
            if (color === void 0) { color = 0; }
            if (alpha === void 0) { alpha = 1; }
            return this.beginTextureFill({ texture: core.Texture.WHITE, color: color, alpha: alpha });
        };
        /**
         * Begin the texture fill
         * @param options - Object object.
         * @param {PIXI.Texture} [options.texture=PIXI.Texture.WHITE] - Texture to fill
         * @param {number} [options.color=0xffffff] - Background to fill behind texture
         * @param {number} [options.alpha=1] - Alpha of fill
         * @param {PIXI.Matrix} [options.matrix=null] - Transform matrix
         * @returns {PIXI.Graphics} This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.beginTextureFill = function (options) {
            // Apply defaults
            options = Object.assign({
                texture: core.Texture.WHITE,
                color: 0xFFFFFF,
                alpha: 1,
                matrix: null,
            }, options);
            if (this.currentPath) {
                this.startPoly();
            }
            var visible = options.alpha > 0;
            if (!visible) {
                this._fillStyle.reset();
            }
            else {
                if (options.matrix) {
                    options.matrix = options.matrix.clone();
                    options.matrix.invert();
                }
                Object.assign(this._fillStyle, { visible: visible }, options);
            }
            return this;
        };
        /**
         * Applies a fill to the lines and shapes that were added since the last call to the beginFill() method.
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.endFill = function () {
            this.finishPoly();
            this._fillStyle.reset();
            return this;
        };
        /**
         * Draws a rectangle shape.
         * @param x - The X coord of the top-left of the rectangle
         * @param y - The Y coord of the top-left of the rectangle
         * @param width - The width of the rectangle
         * @param height - The height of the rectangle
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.drawRect = function (x, y, width, height) {
            return this.drawShape(new math.Rectangle(x, y, width, height));
        };
        /**
         * Draw a rectangle shape with rounded/beveled corners.
         * @param x - The X coord of the top-left of the rectangle
         * @param y - The Y coord of the top-left of the rectangle
         * @param width - The width of the rectangle
         * @param height - The height of the rectangle
         * @param radius - Radius of the rectangle corners
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.drawRoundedRect = function (x, y, width, height, radius) {
            return this.drawShape(new math.RoundedRectangle(x, y, width, height, radius));
        };
        /**
         * Draws a circle.
         * @param x - The X coordinate of the center of the circle
         * @param y - The Y coordinate of the center of the circle
         * @param radius - The radius of the circle
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.drawCircle = function (x, y, radius) {
            return this.drawShape(new math.Circle(x, y, radius));
        };
        /**
         * Draws an ellipse.
         * @param x - The X coordinate of the center of the ellipse
         * @param y - The Y coordinate of the center of the ellipse
         * @param width - The half width of the ellipse
         * @param height - The half height of the ellipse
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.drawEllipse = function (x, y, width, height) {
            return this.drawShape(new math.Ellipse(x, y, width, height));
        };
        /**
         * Draws a polygon using the given path.
         * @param {number[]|PIXI.IPointData[]|PIXI.Polygon} path - The path data used to construct the polygon.
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.drawPolygon = function () {
            var arguments$1 = arguments;

            var path = [];
            for (var _i = 0; _i < arguments.length; _i++) {
                path[_i] = arguments$1[_i];
            }
            var points;
            var closeStroke = true; // !!this._fillStyle;
            var poly = path[0];
            // check if data has points..
            if (poly.points) {
                closeStroke = poly.closeStroke;
                points = poly.points;
            }
            else if (Array.isArray(path[0])) {
                points = path[0];
            }
            else {
                points = path;
            }
            var shape = new math.Polygon(points);
            shape.closeStroke = closeStroke;
            this.drawShape(shape);
            return this;
        };
        /**
         * Draw any shape.
         * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - Shape to draw
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.drawShape = function (shape) {
            if (!this._holeMode) {
                this._geometry.drawShape(shape, this._fillStyle.clone(), this._lineStyle.clone(), this._matrix);
            }
            else {
                this._geometry.drawHole(shape, this._matrix);
            }
            return this;
        };
        /**
         * Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
         * @returns - This Graphics object. Good for chaining method calls
         */
        Graphics.prototype.clear = function () {
            this._geometry.clear();
            this._lineStyle.reset();
            this._fillStyle.reset();
            this._boundsID++;
            this._matrix = null;
            this._holeMode = false;
            this.currentPath = null;
            return this;
        };
        /**
         * True if graphics consists of one rectangle, and thus, can be drawn like a Sprite and
         * masked with gl.scissor.
         * @returns - True if only 1 rect.
         */
        Graphics.prototype.isFastRect = function () {
            var data = this._geometry.graphicsData;
            return data.length === 1
                && data[0].shape.type === math.SHAPES.RECT
                && !data[0].matrix
                && !data[0].holes.length
                && !(data[0].lineStyle.visible && data[0].lineStyle.width);
        };
        /**
         * Renders the object using the WebGL renderer
         * @param renderer - The renderer
         */
        Graphics.prototype._render = function (renderer) {
            this.finishPoly();
            var geometry = this._geometry;
            // batch part..
            // batch it!
            geometry.updateBatches();
            if (geometry.batchable) {
                if (this.batchDirty !== geometry.batchDirty) {
                    this._populateBatches();
                }
                this._renderBatched(renderer);
            }
            else {
                // no batching...
                renderer.batch.flush();
                this._renderDirect(renderer);
            }
        };
        /** Populating batches for rendering. */
        Graphics.prototype._populateBatches = function () {
            var geometry = this._geometry;
            var blendMode = this.blendMode;
            var len = geometry.batches.length;
            this.batchTint = -1;
            this._transformID = -1;
            this.batchDirty = geometry.batchDirty;
            this.batches.length = len;
            this.vertexData = new Float32Array(geometry.points);
            for (var i = 0; i < len; i++) {
                var gI = geometry.batches[i];
                var color = gI.style.color;
                var vertexData = new Float32Array(this.vertexData.buffer, gI.attribStart * 4 * 2, gI.attribSize * 2);
                var uvs = new Float32Array(geometry.uvsFloat32.buffer, gI.attribStart * 4 * 2, gI.attribSize * 2);
                var indices = new Uint16Array(geometry.indicesUint16.buffer, gI.start * 2, gI.size);
                var batch = {
                    vertexData: vertexData,
                    blendMode: blendMode,
                    indices: indices,
                    uvs: uvs,
                    _batchRGB: utils.hex2rgb(color),
                    _tintRGB: color,
                    _texture: gI.style.texture,
                    alpha: gI.style.alpha,
                    worldAlpha: 1
                };
                this.batches[i] = batch;
            }
        };
        /**
         * Renders the batches using the BathedRenderer plugin
         * @param renderer - The renderer
         */
        Graphics.prototype._renderBatched = function (renderer) {
            if (!this.batches.length) {
                return;
            }
            renderer.batch.setObjectRenderer(renderer.plugins[this.pluginName]);
            this.calculateVertices();
            this.calculateTints();
            for (var i = 0, l = this.batches.length; i < l; i++) {
                var batch = this.batches[i];
                batch.worldAlpha = this.worldAlpha * batch.alpha;
                renderer.plugins[this.pluginName].render(batch);
            }
        };
        /**
         * Renders the graphics direct
         * @param renderer - The renderer
         */
        Graphics.prototype._renderDirect = function (renderer) {
            var shader = this._resolveDirectShader(renderer);
            var geometry = this._geometry;
            var tint = this.tint;
            var worldAlpha = this.worldAlpha;
            var uniforms = shader.uniforms;
            var drawCalls = geometry.drawCalls;
            // lets set the transfomr
            uniforms.translationMatrix = this.transform.worldTransform;
            // and then lets set the tint..
            uniforms.tint[0] = (((tint >> 16) & 0xFF) / 255) * worldAlpha;
            uniforms.tint[1] = (((tint >> 8) & 0xFF) / 255) * worldAlpha;
            uniforms.tint[2] = ((tint & 0xFF) / 255) * worldAlpha;
            uniforms.tint[3] = worldAlpha;
            // the first draw call, we can set the uniforms of the shader directly here.
            // this means that we can tack advantage of the sync function of pixi!
            // bind and sync uniforms..
            // there is a way to optimise this..
            renderer.shader.bind(shader);
            renderer.geometry.bind(geometry, shader);
            // set state..
            renderer.state.set(this.state);
            // then render the rest of them...
            for (var i = 0, l = drawCalls.length; i < l; i++) {
                this._renderDrawCallDirect(renderer, geometry.drawCalls[i]);
            }
        };
        /**
         * Renders specific DrawCall
         * @param renderer
         * @param drawCall
         */
        Graphics.prototype._renderDrawCallDirect = function (renderer, drawCall) {
            var texArray = drawCall.texArray, type = drawCall.type, size = drawCall.size, start = drawCall.start;
            var groupTextureCount = texArray.count;
            for (var j = 0; j < groupTextureCount; j++) {
                renderer.texture.bind(texArray.elements[j], j);
            }
            renderer.geometry.draw(type, size, start);
        };
        /**
         * Resolves shader for direct rendering
         * @param renderer - The renderer
         */
        Graphics.prototype._resolveDirectShader = function (renderer) {
            var shader = this.shader;
            var pluginName = this.pluginName;
            if (!shader) {
                // if there is no shader here, we can use the default shader.
                // and that only gets created if we actually need it..
                // but may be more than one plugins for graphics
                if (!DEFAULT_SHADERS[pluginName]) {
                    var MAX_TEXTURES = renderer.plugins[pluginName].MAX_TEXTURES;
                    var sampleValues = new Int32Array(MAX_TEXTURES);
                    for (var i = 0; i < MAX_TEXTURES; i++) {
                        sampleValues[i] = i;
                    }
                    var uniforms = {
                        tint: new Float32Array([1, 1, 1, 1]),
                        translationMatrix: new math.Matrix(),
                        default: core.UniformGroup.from({ uSamplers: sampleValues }, true),
                    };
                    var program = renderer.plugins[pluginName]._shader.program;
                    DEFAULT_SHADERS[pluginName] = new core.Shader(program, uniforms);
                }
                shader = DEFAULT_SHADERS[pluginName];
            }
            return shader;
        };
        /** Retrieves the bounds of the graphic shape as a rectangle object. */
        Graphics.prototype._calculateBounds = function () {
            this.finishPoly();
            var geometry = this._geometry;
            // skipping when graphics is empty, like a container
            if (!geometry.graphicsData.length) {
                return;
            }
            var _a = geometry.bounds, minX = _a.minX, minY = _a.minY, maxX = _a.maxX, maxY = _a.maxY;
            this._bounds.addFrame(this.transform, minX, minY, maxX, maxY);
        };
        /**
         * Tests if a point is inside this graphics object
         * @param point - the point to test
         * @returns - the result of the test
         */
        Graphics.prototype.containsPoint = function (point) {
            this.worldTransform.applyInverse(point, Graphics._TEMP_POINT);
            return this._geometry.containsPoint(Graphics._TEMP_POINT);
        };
        /** Recalculate the tint by applying tint to batches using Graphics tint. */
        Graphics.prototype.calculateTints = function () {
            if (this.batchTint !== this.tint) {
                this.batchTint = this.tint;
                var tintRGB = utils.hex2rgb(this.tint, temp);
                for (var i = 0; i < this.batches.length; i++) {
                    var batch = this.batches[i];
                    var batchTint = batch._batchRGB;
                    var r = (tintRGB[0] * batchTint[0]) * 255;
                    var g = (tintRGB[1] * batchTint[1]) * 255;
                    var b = (tintRGB[2] * batchTint[2]) * 255;
                    // TODO Ivan, can this be done in one go?
                    var color = (r << 16) + (g << 8) + (b | 0);
                    batch._tintRGB = (color >> 16)
                        + (color & 0xff00)
                        + ((color & 0xff) << 16);
                }
            }
        };
        /** If there's a transform update or a change to the shape of the geometry, recalculate the vertices. */
        Graphics.prototype.calculateVertices = function () {
            var wtID = this.transform._worldID;
            if (this._transformID === wtID) {
                return;
            }
            this._transformID = wtID;
            var wt = this.transform.worldTransform;
            var a = wt.a;
            var b = wt.b;
            var c = wt.c;
            var d = wt.d;
            var tx = wt.tx;
            var ty = wt.ty;
            var data = this._geometry.points; // batch.vertexDataOriginal;
            var vertexData = this.vertexData;
            var count = 0;
            for (var i = 0; i < data.length; i += 2) {
                var x = data[i];
                var y = data[i + 1];
                vertexData[count++] = (a * x) + (c * y) + tx;
                vertexData[count++] = (d * y) + (b * x) + ty;
            }
        };
        /**
         * Closes the current path.
         * @returns - Returns itself.
         */
        Graphics.prototype.closePath = function () {
            var currentPath = this.currentPath;
            if (currentPath) {
                // we don't need to add extra point in the end because buildLine will take care of that
                currentPath.closeStroke = true;
                // ensure that the polygon is completed, and is available for hit detection
                // (even if the graphics is not rendered yet)
                this.finishPoly();
            }
            return this;
        };
        /**
         * Apply a matrix to the positional data.
         * @param matrix - Matrix to use for transform current shape.
         * @returns - Returns itself.
         */
        Graphics.prototype.setMatrix = function (matrix) {
            this._matrix = matrix;
            return this;
        };
        /**
         * Begin adding holes to the last draw shape
         * IMPORTANT: holes must be fully inside a shape to work
         * Also weirdness ensues if holes overlap!
         * Ellipses, Circles, Rectangles and Rounded Rectangles cannot be holes or host for holes in CanvasRenderer,
         * please use `moveTo` `lineTo`, `quadraticCurveTo` if you rely on pixi-legacy bundle.
         * @returns - Returns itself.
         */
        Graphics.prototype.beginHole = function () {
            this.finishPoly();
            this._holeMode = true;
            return this;
        };
        /**
         * End adding holes to the last draw shape.
         * @returns - Returns itself.
         */
        Graphics.prototype.endHole = function () {
            this.finishPoly();
            this._holeMode = false;
            return this;
        };
        /**
         * Destroys the Graphics object.
         * @param options - Options parameter. A boolean will act as if all
         *  options have been set to that value
         * @param {boolean} [options.children=false] - if set to true, all the children will have
         *  their destroy method called as well. 'options' will be passed on to those calls.
         * @param {boolean} [options.texture=false] - Only used for child Sprites if options.children is set to true
         *  Should it destroy the texture of the child sprite
         * @param {boolean} [options.baseTexture=false] - Only used for child Sprites if options.children is set to true
         *  Should it destroy the base texture of the child sprite
         */
        Graphics.prototype.destroy = function (options) {
            this._geometry.refCount--;
            if (this._geometry.refCount === 0) {
                this._geometry.dispose();
            }
            this._matrix = null;
            this.currentPath = null;
            this._lineStyle.destroy();
            this._lineStyle = null;
            this._fillStyle.destroy();
            this._fillStyle = null;
            this._geometry = null;
            this.shader = null;
            this.vertexData = null;
            this.batches.length = 0;
            this.batches = null;
            _super.prototype.destroy.call(this, options);
        };
        /**
         * New rendering behavior for rounded rectangles: circular arcs instead of quadratic bezier curves.
         * In the next major release, we'll enable this by default.
         */
        Graphics.nextRoundedRectBehavior = false;
        /**
         * Temporary point to use for containsPoint.
         * @private
         */
        Graphics._TEMP_POINT = new math.Point();
        return Graphics;
    }(display.Container));

    var graphicsUtils = {
        buildPoly: buildPoly,
        buildCircle: buildCircle,
        buildRectangle: buildRectangle,
        buildRoundedRectangle: buildRoundedRectangle,
        buildLine: buildLine,
        ArcUtils: ArcUtils,
        BezierUtils: BezierUtils,
        QuadraticUtils: QuadraticUtils,
        BatchPart: BatchPart,
        FILL_COMMANDS: FILL_COMMANDS,
        BATCH_POOL: BATCH_POOL,
        DRAW_CALL_POOL: DRAW_CALL_POOL
    };

    exports.FillStyle = FillStyle;
    exports.GRAPHICS_CURVES = GRAPHICS_CURVES;
    exports.Graphics = Graphics;
    exports.GraphicsData = GraphicsData;
    exports.GraphicsGeometry = GraphicsGeometry;
    exports.LineStyle = LineStyle;
    exports.graphicsUtils = graphicsUtils;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({}, PIXI, PIXI, PIXI.utils, PIXI, PIXI);
Object.assign(this.PIXI, _pixi_graphics);
//# sourceMappingURL=graphics.js.map
