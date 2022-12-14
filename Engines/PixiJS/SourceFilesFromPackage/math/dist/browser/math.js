/*!
 * @pixi/math - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/math is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_math = (function (exports) {
    'use strict';

    /**
     * Two Pi.
     * @static
     * @member {number}
     * @memberof PIXI
     */
    var PI_2 = Math.PI * 2;
    /**
     * Conversion factor for converting radians to degrees.
     * @static
     * @member {number} RAD_TO_DEG
     * @memberof PIXI
     */
    var RAD_TO_DEG = 180 / Math.PI;
    /**
     * Conversion factor for converting degrees to radians.
     * @static
     * @member {number}
     * @memberof PIXI
     */
    var DEG_TO_RAD = Math.PI / 180;
    /**
     * Constants that identify shapes, mainly to prevent `instanceof` calls.
     * @static
     * @memberof PIXI
     * @enum {number}
     * @property {number} POLY Polygon
     * @property {number} RECT Rectangle
     * @property {number} CIRC Circle
     * @property {number} ELIP Ellipse
     * @property {number} RREC Rounded Rectangle
     */
    exports.SHAPES = void 0;
    (function (SHAPES) {
        SHAPES[SHAPES["POLY"] = 0] = "POLY";
        SHAPES[SHAPES["RECT"] = 1] = "RECT";
        SHAPES[SHAPES["CIRC"] = 2] = "CIRC";
        SHAPES[SHAPES["ELIP"] = 3] = "ELIP";
        SHAPES[SHAPES["RREC"] = 4] = "RREC";
    })(exports.SHAPES || (exports.SHAPES = {}));

    /**
     * The Point object represents a location in a two-dimensional coordinate system, where `x` represents
     * the position on the horizontal axis and `y` represents the position on the vertical axis
     * @class
     * @memberof PIXI
     * @implements {IPoint}
     */
    var Point = /** @class */ (function () {
        /**
         * Creates a new `Point`
         * @param {number} [x=0] - position of the point on the x axis
         * @param {number} [y=0] - position of the point on the y axis
         */
        function Point(x, y) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = 0; }
            /** Position of the point on the x axis */
            this.x = 0;
            /** Position of the point on the y axis */
            this.y = 0;
            this.x = x;
            this.y = y;
        }
        /**
         * Creates a clone of this point
         * @returns A clone of this point
         */
        Point.prototype.clone = function () {
            return new Point(this.x, this.y);
        };
        /**
         * Copies `x` and `y` from the given point into this point
         * @param p - The point to copy from
         * @returns The point instance itself
         */
        Point.prototype.copyFrom = function (p) {
            this.set(p.x, p.y);
            return this;
        };
        /**
         * Copies this point's x and y into the given point (`p`).
         * @param p - The point to copy to. Can be any of type that is or extends `IPointData`
         * @returns The point (`p`) with values updated
         */
        Point.prototype.copyTo = function (p) {
            p.set(this.x, this.y);
            return p;
        };
        /**
         * Accepts another point (`p`) and returns `true` if the given point is equal to this point
         * @param p - The point to check
         * @returns Returns `true` if both `x` and `y` are equal
         */
        Point.prototype.equals = function (p) {
            return (p.x === this.x) && (p.y === this.y);
        };
        /**
         * Sets the point to a new `x` and `y` position.
         * If `y` is omitted, both `x` and `y` will be set to `x`.
         * @param {number} [x=0] - position of the point on the `x` axis
         * @param {number} [y=x] - position of the point on the `y` axis
         * @returns The point instance itself
         */
        Point.prototype.set = function (x, y) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = x; }
            this.x = x;
            this.y = y;
            return this;
        };
        Point.prototype.toString = function () {
            return "[@pixi/math:Point x=" + this.x + " y=" + this.y + "]";
        };
        return Point;
    }());

    var tempPoints = [new Point(), new Point(), new Point(), new Point()];
    /**
     * Size object, contains width and height
     * @memberof PIXI
     * @typedef {object} ISize
     * @property {number} width - Width component
     * @property {number} height - Height component
     */
    /**
     * Rectangle object is an area defined by its position, as indicated by its top-left corner
     * point (x, y) and by its width and its height.
     * @memberof PIXI
     */
    var Rectangle = /** @class */ (function () {
        /**
         * @param x - The X coordinate of the upper-left corner of the rectangle
         * @param y - The Y coordinate of the upper-left corner of the rectangle
         * @param width - The overall width of the rectangle
         * @param height - The overall height of the rectangle
         */
        function Rectangle(x, y, width, height) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = 0; }
            if (width === void 0) { width = 0; }
            if (height === void 0) { height = 0; }
            this.x = Number(x);
            this.y = Number(y);
            this.width = Number(width);
            this.height = Number(height);
            this.type = exports.SHAPES.RECT;
        }
        Object.defineProperty(Rectangle.prototype, "left", {
            /** Returns the left edge of the rectangle. */
            get: function () {
                return this.x;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Rectangle.prototype, "right", {
            /** Returns the right edge of the rectangle. */
            get: function () {
                return this.x + this.width;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Rectangle.prototype, "top", {
            /** Returns the top edge of the rectangle. */
            get: function () {
                return this.y;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Rectangle.prototype, "bottom", {
            /** Returns the bottom edge of the rectangle. */
            get: function () {
                return this.y + this.height;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Rectangle, "EMPTY", {
            /** A constant empty rectangle. */
            get: function () {
                return new Rectangle(0, 0, 0, 0);
            },
            enumerable: false,
            configurable: true
        });
        /**
         * Creates a clone of this Rectangle
         * @returns a copy of the rectangle
         */
        Rectangle.prototype.clone = function () {
            return new Rectangle(this.x, this.y, this.width, this.height);
        };
        /**
         * Copies another rectangle to this one.
         * @param rectangle - The rectangle to copy from.
         * @returns Returns itself.
         */
        Rectangle.prototype.copyFrom = function (rectangle) {
            this.x = rectangle.x;
            this.y = rectangle.y;
            this.width = rectangle.width;
            this.height = rectangle.height;
            return this;
        };
        /**
         * Copies this rectangle to another one.
         * @param rectangle - The rectangle to copy to.
         * @returns Returns given parameter.
         */
        Rectangle.prototype.copyTo = function (rectangle) {
            rectangle.x = this.x;
            rectangle.y = this.y;
            rectangle.width = this.width;
            rectangle.height = this.height;
            return rectangle;
        };
        /**
         * Checks whether the x and y coordinates given are contained within this Rectangle
         * @param x - The X coordinate of the point to test
         * @param y - The Y coordinate of the point to test
         * @returns Whether the x/y coordinates are within this Rectangle
         */
        Rectangle.prototype.contains = function (x, y) {
            if (this.width <= 0 || this.height <= 0) {
                return false;
            }
            if (x >= this.x && x < this.x + this.width) {
                if (y >= this.y && y < this.y + this.height) {
                    return true;
                }
            }
            return false;
        };
        /**
         * Determines whether the `other` Rectangle transformed by `transform` intersects with `this` Rectangle object.
         * Returns true only if the area of the intersection is >0, this means that Rectangles
         * sharing a side are not overlapping. Another side effect is that an arealess rectangle
         * (width or height equal to zero) can't intersect any other rectangle.
         * @param {Rectangle} other - The Rectangle to intersect with `this`.
         * @param {Matrix} transform - The transformation matrix of `other`.
         * @returns {boolean} A value of `true` if the transformed `other` Rectangle intersects with `this`; otherwise `false`.
         */
        Rectangle.prototype.intersects = function (other, transform) {
            if (!transform) {
                var x0_1 = this.x < other.x ? other.x : this.x;
                var x1_1 = this.right > other.right ? other.right : this.right;
                if (x1_1 <= x0_1) {
                    return false;
                }
                var y0_1 = this.y < other.y ? other.y : this.y;
                var y1_1 = this.bottom > other.bottom ? other.bottom : this.bottom;
                return y1_1 > y0_1;
            }
            var x0 = this.left;
            var x1 = this.right;
            var y0 = this.top;
            var y1 = this.bottom;
            if (x1 <= x0 || y1 <= y0) {
                return false;
            }
            var lt = tempPoints[0].set(other.left, other.top);
            var lb = tempPoints[1].set(other.left, other.bottom);
            var rt = tempPoints[2].set(other.right, other.top);
            var rb = tempPoints[3].set(other.right, other.bottom);
            if (rt.x <= lt.x || lb.y <= lt.y) {
                return false;
            }
            var s = Math.sign((transform.a * transform.d) - (transform.b * transform.c));
            if (s === 0) {
                return false;
            }
            transform.apply(lt, lt);
            transform.apply(lb, lb);
            transform.apply(rt, rt);
            transform.apply(rb, rb);
            if (Math.max(lt.x, lb.x, rt.x, rb.x) <= x0
                || Math.min(lt.x, lb.x, rt.x, rb.x) >= x1
                || Math.max(lt.y, lb.y, rt.y, rb.y) <= y0
                || Math.min(lt.y, lb.y, rt.y, rb.y) >= y1) {
                return false;
            }
            var nx = s * (lb.y - lt.y);
            var ny = s * (lt.x - lb.x);
            var n00 = (nx * x0) + (ny * y0);
            var n10 = (nx * x1) + (ny * y0);
            var n01 = (nx * x0) + (ny * y1);
            var n11 = (nx * x1) + (ny * y1);
            if (Math.max(n00, n10, n01, n11) <= (nx * lt.x) + (ny * lt.y)
                || Math.min(n00, n10, n01, n11) >= (nx * rb.x) + (ny * rb.y)) {
                return false;
            }
            var mx = s * (lt.y - rt.y);
            var my = s * (rt.x - lt.x);
            var m00 = (mx * x0) + (my * y0);
            var m10 = (mx * x1) + (my * y0);
            var m01 = (mx * x0) + (my * y1);
            var m11 = (mx * x1) + (my * y1);
            if (Math.max(m00, m10, m01, m11) <= (mx * lt.x) + (my * lt.y)
                || Math.min(m00, m10, m01, m11) >= (mx * rb.x) + (my * rb.y)) {
                return false;
            }
            return true;
        };
        /**
         * Pads the rectangle making it grow in all directions.
         * If paddingY is omitted, both paddingX and paddingY will be set to paddingX.
         * @param paddingX - The horizontal padding amount.
         * @param paddingY - The vertical padding amount.
         * @returns Returns itself.
         */
        Rectangle.prototype.pad = function (paddingX, paddingY) {
            if (paddingX === void 0) { paddingX = 0; }
            if (paddingY === void 0) { paddingY = paddingX; }
            this.x -= paddingX;
            this.y -= paddingY;
            this.width += paddingX * 2;
            this.height += paddingY * 2;
            return this;
        };
        /**
         * Fits this rectangle around the passed one.
         * @param rectangle - The rectangle to fit.
         * @returns Returns itself.
         */
        Rectangle.prototype.fit = function (rectangle) {
            var x1 = Math.max(this.x, rectangle.x);
            var x2 = Math.min(this.x + this.width, rectangle.x + rectangle.width);
            var y1 = Math.max(this.y, rectangle.y);
            var y2 = Math.min(this.y + this.height, rectangle.y + rectangle.height);
            this.x = x1;
            this.width = Math.max(x2 - x1, 0);
            this.y = y1;
            this.height = Math.max(y2 - y1, 0);
            return this;
        };
        /**
         * Enlarges rectangle that way its corners lie on grid
         * @param resolution - resolution
         * @param eps - precision
         * @returns Returns itself.
         */
        Rectangle.prototype.ceil = function (resolution, eps) {
            if (resolution === void 0) { resolution = 1; }
            if (eps === void 0) { eps = 0.001; }
            var x2 = Math.ceil((this.x + this.width - eps) * resolution) / resolution;
            var y2 = Math.ceil((this.y + this.height - eps) * resolution) / resolution;
            this.x = Math.floor((this.x + eps) * resolution) / resolution;
            this.y = Math.floor((this.y + eps) * resolution) / resolution;
            this.width = x2 - this.x;
            this.height = y2 - this.y;
            return this;
        };
        /**
         * Enlarges this rectangle to include the passed rectangle.
         * @param rectangle - The rectangle to include.
         * @returns Returns itself.
         */
        Rectangle.prototype.enlarge = function (rectangle) {
            var x1 = Math.min(this.x, rectangle.x);
            var x2 = Math.max(this.x + this.width, rectangle.x + rectangle.width);
            var y1 = Math.min(this.y, rectangle.y);
            var y2 = Math.max(this.y + this.height, rectangle.y + rectangle.height);
            this.x = x1;
            this.width = x2 - x1;
            this.y = y1;
            this.height = y2 - y1;
            return this;
        };
        Rectangle.prototype.toString = function () {
            return "[@pixi/math:Rectangle x=" + this.x + " y=" + this.y + " width=" + this.width + " height=" + this.height + "]";
        };
        return Rectangle;
    }());

    /**
     * The Circle object is used to help draw graphics and can also be used to specify a hit area for displayObjects.
     * @memberof PIXI
     */
    var Circle = /** @class */ (function () {
        /**
         * @param x - The X coordinate of the center of this circle
         * @param y - The Y coordinate of the center of this circle
         * @param radius - The radius of the circle
         */
        function Circle(x, y, radius) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = 0; }
            if (radius === void 0) { radius = 0; }
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.type = exports.SHAPES.CIRC;
        }
        /**
         * Creates a clone of this Circle instance
         * @returns A copy of the Circle
         */
        Circle.prototype.clone = function () {
            return new Circle(this.x, this.y, this.radius);
        };
        /**
         * Checks whether the x and y coordinates given are contained within this circle
         * @param x - The X coordinate of the point to test
         * @param y - The Y coordinate of the point to test
         * @returns Whether the x/y coordinates are within this Circle
         */
        Circle.prototype.contains = function (x, y) {
            if (this.radius <= 0) {
                return false;
            }
            var r2 = this.radius * this.radius;
            var dx = (this.x - x);
            var dy = (this.y - y);
            dx *= dx;
            dy *= dy;
            return (dx + dy <= r2);
        };
        /**
         * Returns the framing rectangle of the circle as a Rectangle object
         * @returns The framing rectangle
         */
        Circle.prototype.getBounds = function () {
            return new Rectangle(this.x - this.radius, this.y - this.radius, this.radius * 2, this.radius * 2);
        };
        Circle.prototype.toString = function () {
            return "[@pixi/math:Circle x=" + this.x + " y=" + this.y + " radius=" + this.radius + "]";
        };
        return Circle;
    }());

    /**
     * The Ellipse object is used to help draw graphics and can also be used to specify a hit area for displayObjects.
     * @memberof PIXI
     */
    var Ellipse = /** @class */ (function () {
        /**
         * @param x - The X coordinate of the center of this ellipse
         * @param y - The Y coordinate of the center of this ellipse
         * @param halfWidth - The half width of this ellipse
         * @param halfHeight - The half height of this ellipse
         */
        function Ellipse(x, y, halfWidth, halfHeight) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = 0; }
            if (halfWidth === void 0) { halfWidth = 0; }
            if (halfHeight === void 0) { halfHeight = 0; }
            this.x = x;
            this.y = y;
            this.width = halfWidth;
            this.height = halfHeight;
            this.type = exports.SHAPES.ELIP;
        }
        /**
         * Creates a clone of this Ellipse instance
         * @returns {PIXI.Ellipse} A copy of the ellipse
         */
        Ellipse.prototype.clone = function () {
            return new Ellipse(this.x, this.y, this.width, this.height);
        };
        /**
         * Checks whether the x and y coordinates given are contained within this ellipse
         * @param x - The X coordinate of the point to test
         * @param y - The Y coordinate of the point to test
         * @returns Whether the x/y coords are within this ellipse
         */
        Ellipse.prototype.contains = function (x, y) {
            if (this.width <= 0 || this.height <= 0) {
                return false;
            }
            // normalize the coords to an ellipse with center 0,0
            var normx = ((x - this.x) / this.width);
            var normy = ((y - this.y) / this.height);
            normx *= normx;
            normy *= normy;
            return (normx + normy <= 1);
        };
        /**
         * Returns the framing rectangle of the ellipse as a Rectangle object
         * @returns The framing rectangle
         */
        Ellipse.prototype.getBounds = function () {
            return new Rectangle(this.x - this.width, this.y - this.height, this.width, this.height);
        };
        Ellipse.prototype.toString = function () {
            return "[@pixi/math:Ellipse x=" + this.x + " y=" + this.y + " width=" + this.width + " height=" + this.height + "]";
        };
        return Ellipse;
    }());

    /**
     * A class to define a shape via user defined coordinates.
     * @memberof PIXI
     */
    var Polygon = /** @class */ (function () {
        /**
         * @param {PIXI.IPointData[]|number[]} points - This can be an array of Points
         *  that form the polygon, a flat array of numbers that will be interpreted as [x,y, x,y, ...], or
         *  the arguments passed can be all the points of the polygon e.g.
         *  `new PIXI.Polygon(new PIXI.Point(), new PIXI.Point(), ...)`, or the arguments passed can be flat
         *  x,y values e.g. `new Polygon(x,y, x,y, x,y, ...)` where `x` and `y` are Numbers.
         */
        function Polygon() {
            var arguments$1 = arguments;

            var points = [];
            for (var _i = 0; _i < arguments.length; _i++) {
                points[_i] = arguments$1[_i];
            }
            var flat = Array.isArray(points[0]) ? points[0] : points;
            // if this is an array of points, convert it to a flat array of numbers
            if (typeof flat[0] !== 'number') {
                var p = [];
                for (var i = 0, il = flat.length; i < il; i++) {
                    p.push(flat[i].x, flat[i].y);
                }
                flat = p;
            }
            this.points = flat;
            this.type = exports.SHAPES.POLY;
            this.closeStroke = true;
        }
        /**
         * Creates a clone of this polygon.
         * @returns - A copy of the polygon.
         */
        Polygon.prototype.clone = function () {
            var points = this.points.slice();
            var polygon = new Polygon(points);
            polygon.closeStroke = this.closeStroke;
            return polygon;
        };
        /**
         * Checks whether the x and y coordinates passed to this function are contained within this polygon.
         * @param x - The X coordinate of the point to test.
         * @param y - The Y coordinate of the point to test.
         * @returns - Whether the x/y coordinates are within this polygon.
         */
        Polygon.prototype.contains = function (x, y) {
            var inside = false;
            // use some raycasting to test hits
            // https://github.com/substack/point-in-polygon/blob/master/index.js
            var length = this.points.length / 2;
            for (var i = 0, j = length - 1; i < length; j = i++) {
                var xi = this.points[i * 2];
                var yi = this.points[(i * 2) + 1];
                var xj = this.points[j * 2];
                var yj = this.points[(j * 2) + 1];
                var intersect = ((yi > y) !== (yj > y)) && (x < ((xj - xi) * ((y - yi) / (yj - yi))) + xi);
                if (intersect) {
                    inside = !inside;
                }
            }
            return inside;
        };
        Polygon.prototype.toString = function () {
            return "[@pixi/math:Polygon"
                + ("closeStroke=" + this.closeStroke)
                + ("points=" + this.points.reduce(function (pointsDesc, currentPoint) { return pointsDesc + ", " + currentPoint; }, '') + "]");
        };
        return Polygon;
    }());

    /**
     * The Rounded Rectangle object is an area that has nice rounded corners, as indicated by its
     * top-left corner point (x, y) and by its width and its height and its radius.
     * @memberof PIXI
     */
    var RoundedRectangle = /** @class */ (function () {
        /**
         * @param x - The X coordinate of the upper-left corner of the rounded rectangle
         * @param y - The Y coordinate of the upper-left corner of the rounded rectangle
         * @param width - The overall width of this rounded rectangle
         * @param height - The overall height of this rounded rectangle
         * @param radius - Controls the radius of the rounded corners
         */
        function RoundedRectangle(x, y, width, height, radius) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = 0; }
            if (width === void 0) { width = 0; }
            if (height === void 0) { height = 0; }
            if (radius === void 0) { radius = 20; }
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.radius = radius;
            this.type = exports.SHAPES.RREC;
        }
        /**
         * Creates a clone of this Rounded Rectangle.
         * @returns - A copy of the rounded rectangle.
         */
        RoundedRectangle.prototype.clone = function () {
            return new RoundedRectangle(this.x, this.y, this.width, this.height, this.radius);
        };
        /**
         * Checks whether the x and y coordinates given are contained within this Rounded Rectangle
         * @param x - The X coordinate of the point to test.
         * @param y - The Y coordinate of the point to test.
         * @returns - Whether the x/y coordinates are within this Rounded Rectangle.
         */
        RoundedRectangle.prototype.contains = function (x, y) {
            if (this.width <= 0 || this.height <= 0) {
                return false;
            }
            if (x >= this.x && x <= this.x + this.width) {
                if (y >= this.y && y <= this.y + this.height) {
                    var radius = Math.max(0, Math.min(this.radius, Math.min(this.width, this.height) / 2));
                    if ((y >= this.y + radius && y <= this.y + this.height - radius)
                        || (x >= this.x + radius && x <= this.x + this.width - radius)) {
                        return true;
                    }
                    var dx = x - (this.x + radius);
                    var dy = y - (this.y + radius);
                    var radius2 = radius * radius;
                    if ((dx * dx) + (dy * dy) <= radius2) {
                        return true;
                    }
                    dx = x - (this.x + this.width - radius);
                    if ((dx * dx) + (dy * dy) <= radius2) {
                        return true;
                    }
                    dy = y - (this.y + this.height - radius);
                    if ((dx * dx) + (dy * dy) <= radius2) {
                        return true;
                    }
                    dx = x - (this.x + radius);
                    if ((dx * dx) + (dy * dy) <= radius2) {
                        return true;
                    }
                }
            }
            return false;
        };
        RoundedRectangle.prototype.toString = function () {
            return "[@pixi/math:RoundedRectangle x=" + this.x + " y=" + this.y
                + ("width=" + this.width + " height=" + this.height + " radius=" + this.radius + "]");
        };
        return RoundedRectangle;
    }());

    /**
     * Common interface for points. Both Point and ObservablePoint implement it
     * @memberof PIXI
     * @interface IPointData
     */
    /**
     * X coord
     * @memberof PIXI.IPointData#
     * @member {number} x
     */
    /**
     * Y coord
     * @memberof PIXI.IPointData#
     * @member {number} y
     */

    /**
     * Common interface for points. Both Point and ObservablePoint implement it
     * @memberof PIXI
     * @interface IPoint
     * @extends PIXI.IPointData
     */
    /**
     * Sets the point to a new x and y position.
     * If y is omitted, both x and y will be set to x.
     * @method set
     * @memberof PIXI.IPoint#
     * @param {number} [x=0] - position of the point on the x axis
     * @param {number} [y=x] - position of the point on the y axis
     */
    /**
     * Copies x and y from the given point
     * @method copyFrom
     * @memberof PIXI.IPoint#
     * @param {PIXI.IPointData} p - The point to copy from
     * @returns {this} Returns itself.
     */
    /**
     * Copies x and y into the given point
     * @method copyTo
     * @memberof PIXI.IPoint#
     * @param {PIXI.IPoint} p - The point to copy.
     * @returns {PIXI.IPoint} Given point with values updated
     */
    /**
     * Returns true if the given point is equal to this point
     * @method equals
     * @memberof PIXI.IPoint#
     * @param {PIXI.IPointData} p - The point to check
     * @returns {boolean} Whether the given point equal to this point
     */

    /**
     * The ObservablePoint object represents a location in a two-dimensional coordinate system, where `x` represents
     * the position on the horizontal axis and `y` represents the position on the vertical axis.
     *
     * An `ObservablePoint` is a point that triggers a callback when the point's position is changed.
     * @memberof PIXI
     */
    var ObservablePoint = /** @class */ (function () {
        /**
         * Creates a new `ObservablePoint`
         * @param cb - callback function triggered when `x` and/or `y` are changed
         * @param scope - owner of callback
         * @param {number} [x=0] - position of the point on the x axis
         * @param {number} [y=0] - position of the point on the y axis
         */
        function ObservablePoint(cb, scope, x, y) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = 0; }
            this._x = x;
            this._y = y;
            this.cb = cb;
            this.scope = scope;
        }
        /**
         * Creates a clone of this point.
         * The callback and scope params can be overridden otherwise they will default
         * to the clone object's values.
         * @override
         * @param cb - The callback function triggered when `x` and/or `y` are changed
         * @param scope - The owner of the callback
         * @returns a copy of this observable point
         */
        ObservablePoint.prototype.clone = function (cb, scope) {
            if (cb === void 0) { cb = this.cb; }
            if (scope === void 0) { scope = this.scope; }
            return new ObservablePoint(cb, scope, this._x, this._y);
        };
        /**
         * Sets the point to a new `x` and `y` position.
         * If `y` is omitted, both `x` and `y` will be set to `x`.
         * @param {number} [x=0] - position of the point on the x axis
         * @param {number} [y=x] - position of the point on the y axis
         * @returns The observable point instance itself
         */
        ObservablePoint.prototype.set = function (x, y) {
            if (x === void 0) { x = 0; }
            if (y === void 0) { y = x; }
            if (this._x !== x || this._y !== y) {
                this._x = x;
                this._y = y;
                this.cb.call(this.scope);
            }
            return this;
        };
        /**
         * Copies x and y from the given point (`p`)
         * @param p - The point to copy from. Can be any of type that is or extends `IPointData`
         * @returns The observable point instance itself
         */
        ObservablePoint.prototype.copyFrom = function (p) {
            if (this._x !== p.x || this._y !== p.y) {
                this._x = p.x;
                this._y = p.y;
                this.cb.call(this.scope);
            }
            return this;
        };
        /**
         * Copies this point's x and y into that of the given point (`p`)
         * @param p - The point to copy to. Can be any of type that is or extends `IPointData`
         * @returns The point (`p`) with values updated
         */
        ObservablePoint.prototype.copyTo = function (p) {
            p.set(this._x, this._y);
            return p;
        };
        /**
         * Accepts another point (`p`) and returns `true` if the given point is equal to this point
         * @param p - The point to check
         * @returns Returns `true` if both `x` and `y` are equal
         */
        ObservablePoint.prototype.equals = function (p) {
            return (p.x === this._x) && (p.y === this._y);
        };
        ObservablePoint.prototype.toString = function () {
            return "[@pixi/math:ObservablePoint x=" + 0 + " y=" + 0 + " scope=" + this.scope + "]";
        };
        Object.defineProperty(ObservablePoint.prototype, "x", {
            /** Position of the observable point on the x axis. */
            get: function () {
                return this._x;
            },
            set: function (value) {
                if (this._x !== value) {
                    this._x = value;
                    this.cb.call(this.scope);
                }
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(ObservablePoint.prototype, "y", {
            /** Position of the observable point on the y axis. */
            get: function () {
                return this._y;
            },
            set: function (value) {
                if (this._y !== value) {
                    this._y = value;
                    this.cb.call(this.scope);
                }
            },
            enumerable: false,
            configurable: true
        });
        return ObservablePoint;
    }());

    /**
     * The PixiJS Matrix as a class makes it a lot faster.
     *
     * Here is a representation of it:
     * ```js
     * | a | c | tx|
     * | b | d | ty|
     * | 0 | 0 | 1 |
     * ```
     * @memberof PIXI
     */
    var Matrix = /** @class */ (function () {
        /**
         * @param a - x scale
         * @param b - y skew
         * @param c - x skew
         * @param d - y scale
         * @param tx - x translation
         * @param ty - y translation
         */
        function Matrix(a, b, c, d, tx, ty) {
            if (a === void 0) { a = 1; }
            if (b === void 0) { b = 0; }
            if (c === void 0) { c = 0; }
            if (d === void 0) { d = 1; }
            if (tx === void 0) { tx = 0; }
            if (ty === void 0) { ty = 0; }
            this.array = null;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.tx = tx;
            this.ty = ty;
        }
        /**
         * Creates a Matrix object based on the given array. The Element to Matrix mapping order is as follows:
         *
         * a = array[0]
         * b = array[1]
         * c = array[3]
         * d = array[4]
         * tx = array[2]
         * ty = array[5]
         * @param array - The array that the matrix will be populated from.
         */
        Matrix.prototype.fromArray = function (array) {
            this.a = array[0];
            this.b = array[1];
            this.c = array[3];
            this.d = array[4];
            this.tx = array[2];
            this.ty = array[5];
        };
        /**
         * Sets the matrix properties.
         * @param a - Matrix component
         * @param b - Matrix component
         * @param c - Matrix component
         * @param d - Matrix component
         * @param tx - Matrix component
         * @param ty - Matrix component
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.set = function (a, b, c, d, tx, ty) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.tx = tx;
            this.ty = ty;
            return this;
        };
        /**
         * Creates an array from the current Matrix object.
         * @param transpose - Whether we need to transpose the matrix or not
         * @param [out=new Float32Array(9)] - If provided the array will be assigned to out
         * @returns The newly created array which contains the matrix
         */
        Matrix.prototype.toArray = function (transpose, out) {
            if (!this.array) {
                this.array = new Float32Array(9);
            }
            var array = out || this.array;
            if (transpose) {
                array[0] = this.a;
                array[1] = this.b;
                array[2] = 0;
                array[3] = this.c;
                array[4] = this.d;
                array[5] = 0;
                array[6] = this.tx;
                array[7] = this.ty;
                array[8] = 1;
            }
            else {
                array[0] = this.a;
                array[1] = this.c;
                array[2] = this.tx;
                array[3] = this.b;
                array[4] = this.d;
                array[5] = this.ty;
                array[6] = 0;
                array[7] = 0;
                array[8] = 1;
            }
            return array;
        };
        /**
         * Get a new position with the current transformation applied.
         * Can be used to go from a child's coordinate space to the world coordinate space. (e.g. rendering)
         * @param pos - The origin
         * @param {PIXI.Point} [newPos] - The point that the new position is assigned to (allowed to be same as input)
         * @returns {PIXI.Point} The new point, transformed through this matrix
         */
        Matrix.prototype.apply = function (pos, newPos) {
            newPos = (newPos || new Point());
            var x = pos.x;
            var y = pos.y;
            newPos.x = (this.a * x) + (this.c * y) + this.tx;
            newPos.y = (this.b * x) + (this.d * y) + this.ty;
            return newPos;
        };
        /**
         * Get a new position with the inverse of the current transformation applied.
         * Can be used to go from the world coordinate space to a child's coordinate space. (e.g. input)
         * @param pos - The origin
         * @param {PIXI.Point} [newPos] - The point that the new position is assigned to (allowed to be same as input)
         * @returns {PIXI.Point} The new point, inverse-transformed through this matrix
         */
        Matrix.prototype.applyInverse = function (pos, newPos) {
            newPos = (newPos || new Point());
            var id = 1 / ((this.a * this.d) + (this.c * -this.b));
            var x = pos.x;
            var y = pos.y;
            newPos.x = (this.d * id * x) + (-this.c * id * y) + (((this.ty * this.c) - (this.tx * this.d)) * id);
            newPos.y = (this.a * id * y) + (-this.b * id * x) + (((-this.ty * this.a) + (this.tx * this.b)) * id);
            return newPos;
        };
        /**
         * Translates the matrix on the x and y.
         * @param x - How much to translate x by
         * @param y - How much to translate y by
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.translate = function (x, y) {
            this.tx += x;
            this.ty += y;
            return this;
        };
        /**
         * Applies a scale transformation to the matrix.
         * @param x - The amount to scale horizontally
         * @param y - The amount to scale vertically
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.scale = function (x, y) {
            this.a *= x;
            this.d *= y;
            this.c *= x;
            this.b *= y;
            this.tx *= x;
            this.ty *= y;
            return this;
        };
        /**
         * Applies a rotation transformation to the matrix.
         * @param angle - The angle in radians.
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.rotate = function (angle) {
            var cos = Math.cos(angle);
            var sin = Math.sin(angle);
            var a1 = this.a;
            var c1 = this.c;
            var tx1 = this.tx;
            this.a = (a1 * cos) - (this.b * sin);
            this.b = (a1 * sin) + (this.b * cos);
            this.c = (c1 * cos) - (this.d * sin);
            this.d = (c1 * sin) + (this.d * cos);
            this.tx = (tx1 * cos) - (this.ty * sin);
            this.ty = (tx1 * sin) + (this.ty * cos);
            return this;
        };
        /**
         * Appends the given Matrix to this Matrix.
         * @param matrix - The matrix to append.
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.append = function (matrix) {
            var a1 = this.a;
            var b1 = this.b;
            var c1 = this.c;
            var d1 = this.d;
            this.a = (matrix.a * a1) + (matrix.b * c1);
            this.b = (matrix.a * b1) + (matrix.b * d1);
            this.c = (matrix.c * a1) + (matrix.d * c1);
            this.d = (matrix.c * b1) + (matrix.d * d1);
            this.tx = (matrix.tx * a1) + (matrix.ty * c1) + this.tx;
            this.ty = (matrix.tx * b1) + (matrix.ty * d1) + this.ty;
            return this;
        };
        /**
         * Sets the matrix based on all the available properties
         * @param x - Position on the x axis
         * @param y - Position on the y axis
         * @param pivotX - Pivot on the x axis
         * @param pivotY - Pivot on the y axis
         * @param scaleX - Scale on the x axis
         * @param scaleY - Scale on the y axis
         * @param rotation - Rotation in radians
         * @param skewX - Skew on the x axis
         * @param skewY - Skew on the y axis
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.setTransform = function (x, y, pivotX, pivotY, scaleX, scaleY, rotation, skewX, skewY) {
            this.a = Math.cos(rotation + skewY) * scaleX;
            this.b = Math.sin(rotation + skewY) * scaleX;
            this.c = -Math.sin(rotation - skewX) * scaleY;
            this.d = Math.cos(rotation - skewX) * scaleY;
            this.tx = x - ((pivotX * this.a) + (pivotY * this.c));
            this.ty = y - ((pivotX * this.b) + (pivotY * this.d));
            return this;
        };
        /**
         * Prepends the given Matrix to this Matrix.
         * @param matrix - The matrix to prepend
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.prepend = function (matrix) {
            var tx1 = this.tx;
            if (matrix.a !== 1 || matrix.b !== 0 || matrix.c !== 0 || matrix.d !== 1) {
                var a1 = this.a;
                var c1 = this.c;
                this.a = (a1 * matrix.a) + (this.b * matrix.c);
                this.b = (a1 * matrix.b) + (this.b * matrix.d);
                this.c = (c1 * matrix.a) + (this.d * matrix.c);
                this.d = (c1 * matrix.b) + (this.d * matrix.d);
            }
            this.tx = (tx1 * matrix.a) + (this.ty * matrix.c) + matrix.tx;
            this.ty = (tx1 * matrix.b) + (this.ty * matrix.d) + matrix.ty;
            return this;
        };
        /**
         * Decomposes the matrix (x, y, scaleX, scaleY, and rotation) and sets the properties on to a transform.
         * @param transform - The transform to apply the properties to.
         * @returns The transform with the newly applied properties
         */
        Matrix.prototype.decompose = function (transform) {
            // sort out rotation / skew..
            var a = this.a;
            var b = this.b;
            var c = this.c;
            var d = this.d;
            var pivot = transform.pivot;
            var skewX = -Math.atan2(-c, d);
            var skewY = Math.atan2(b, a);
            var delta = Math.abs(skewX + skewY);
            if (delta < 0.00001 || Math.abs(PI_2 - delta) < 0.00001) {
                transform.rotation = skewY;
                transform.skew.x = transform.skew.y = 0;
            }
            else {
                transform.rotation = 0;
                transform.skew.x = skewX;
                transform.skew.y = skewY;
            }
            // next set scale
            transform.scale.x = Math.sqrt((a * a) + (b * b));
            transform.scale.y = Math.sqrt((c * c) + (d * d));
            // next set position
            transform.position.x = this.tx + ((pivot.x * a) + (pivot.y * c));
            transform.position.y = this.ty + ((pivot.x * b) + (pivot.y * d));
            return transform;
        };
        /**
         * Inverts this matrix
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.invert = function () {
            var a1 = this.a;
            var b1 = this.b;
            var c1 = this.c;
            var d1 = this.d;
            var tx1 = this.tx;
            var n = (a1 * d1) - (b1 * c1);
            this.a = d1 / n;
            this.b = -b1 / n;
            this.c = -c1 / n;
            this.d = a1 / n;
            this.tx = ((c1 * this.ty) - (d1 * tx1)) / n;
            this.ty = -((a1 * this.ty) - (b1 * tx1)) / n;
            return this;
        };
        /**
         * Resets this Matrix to an identity (default) matrix.
         * @returns This matrix. Good for chaining method calls.
         */
        Matrix.prototype.identity = function () {
            this.a = 1;
            this.b = 0;
            this.c = 0;
            this.d = 1;
            this.tx = 0;
            this.ty = 0;
            return this;
        };
        /**
         * Creates a new Matrix object with the same values as this one.
         * @returns A copy of this matrix. Good for chaining method calls.
         */
        Matrix.prototype.clone = function () {
            var matrix = new Matrix();
            matrix.a = this.a;
            matrix.b = this.b;
            matrix.c = this.c;
            matrix.d = this.d;
            matrix.tx = this.tx;
            matrix.ty = this.ty;
            return matrix;
        };
        /**
         * Changes the values of the given matrix to be the same as the ones in this matrix
         * @param matrix - The matrix to copy to.
         * @returns The matrix given in parameter with its values updated.
         */
        Matrix.prototype.copyTo = function (matrix) {
            matrix.a = this.a;
            matrix.b = this.b;
            matrix.c = this.c;
            matrix.d = this.d;
            matrix.tx = this.tx;
            matrix.ty = this.ty;
            return matrix;
        };
        /**
         * Changes the values of the matrix to be the same as the ones in given matrix
         * @param {PIXI.Matrix} matrix - The matrix to copy from.
         * @returns {PIXI.Matrix} this
         */
        Matrix.prototype.copyFrom = function (matrix) {
            this.a = matrix.a;
            this.b = matrix.b;
            this.c = matrix.c;
            this.d = matrix.d;
            this.tx = matrix.tx;
            this.ty = matrix.ty;
            return this;
        };
        Matrix.prototype.toString = function () {
            return "[@pixi/math:Matrix a=" + this.a + " b=" + this.b + " c=" + this.c + " d=" + this.d + " tx=" + this.tx + " ty=" + this.ty + "]";
        };
        Object.defineProperty(Matrix, "IDENTITY", {
            /**
             * A default (identity) matrix
             * @readonly
             */
            get: function () {
                return new Matrix();
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Matrix, "TEMP_MATRIX", {
            /**
             * A temp matrix
             * @readonly
             */
            get: function () {
                return new Matrix();
            },
            enumerable: false,
            configurable: true
        });
        return Matrix;
    }());

    // Your friendly neighbour https://en.wikipedia.org/wiki/Dihedral_group
    /*
     * Transform matrix for operation n is:
     * | ux | vx |
     * | uy | vy |
     */
    var ux = [1, 1, 0, -1, -1, -1, 0, 1, 1, 1, 0, -1, -1, -1, 0, 1];
    var uy = [0, 1, 1, 1, 0, -1, -1, -1, 0, 1, 1, 1, 0, -1, -1, -1];
    var vx = [0, -1, -1, -1, 0, 1, 1, 1, 0, 1, 1, 1, 0, -1, -1, -1];
    var vy = [1, 1, 0, -1, -1, -1, 0, 1, -1, -1, 0, 1, 1, 1, 0, -1];
    /**
     * [Cayley Table]{@link https://en.wikipedia.org/wiki/Cayley_table}
     * for the composition of each rotation in the dihederal group D8.
     * @type {number[][]}
     * @private
     */
    var rotationCayley = [];
    /**
     * Matrices for each `GD8Symmetry` rotation.
     * @type {PIXI.Matrix[]}
     * @private
     */
    var rotationMatrices = [];
    /*
     * Alias for {@code Math.sign}.
     */
    var signum = Math.sign;
    /*
     * Initializes `rotationCayley` and `rotationMatrices`. It is called
     * only once below.
     */
    function init() {
        for (var i = 0; i < 16; i++) {
            var row = [];
            rotationCayley.push(row);
            for (var j = 0; j < 16; j++) {
                /* Multiplies rotation matrices i and j. */
                var _ux = signum((ux[i] * ux[j]) + (vx[i] * uy[j]));
                var _uy = signum((uy[i] * ux[j]) + (vy[i] * uy[j]));
                var _vx = signum((ux[i] * vx[j]) + (vx[i] * vy[j]));
                var _vy = signum((uy[i] * vx[j]) + (vy[i] * vy[j]));
                /* Finds rotation matrix matching the product and pushes it. */
                for (var k = 0; k < 16; k++) {
                    if (ux[k] === _ux && uy[k] === _uy
                        && vx[k] === _vx && vy[k] === _vy) {
                        row.push(k);
                        break;
                    }
                }
            }
        }
        for (var i = 0; i < 16; i++) {
            var mat = new Matrix();
            mat.set(ux[i], uy[i], vx[i], vy[i], 0, 0);
            rotationMatrices.push(mat);
        }
    }
    init();
    /**
     * @memberof PIXI
     * @typedef {number} GD8Symmetry
     * @see PIXI.groupD8
     */
    /**
     * Implements the dihedral group D8, which is similar to
     * [group D4]{@link http://mathworld.wolfram.com/DihedralGroupD4.html};
     * D8 is the same but with diagonals, and it is used for texture
     * rotations.
     *
     * The directions the U- and V- axes after rotation
     * of an angle of `a: GD8Constant` are the vectors `(uX(a), uY(a))`
     * and `(vX(a), vY(a))`. These aren't necessarily unit vectors.
     *
     * **Origin:**<br>
     *  This is the small part of gameofbombs.com portal system. It works.
     * @see PIXI.groupD8.E
     * @see PIXI.groupD8.SE
     * @see PIXI.groupD8.S
     * @see PIXI.groupD8.SW
     * @see PIXI.groupD8.W
     * @see PIXI.groupD8.NW
     * @see PIXI.groupD8.N
     * @see PIXI.groupD8.NE
     * @author Ivan @ivanpopelyshev
     * @namespace PIXI.groupD8
     * @memberof PIXI
     */
    var groupD8 = {
        /**
         * | Rotation | Direction |
         * |----------|-----------|
         * | 0??       | East      |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        E: 0,
        /**
         * | Rotation | Direction |
         * |----------|-----------|
         * | 45?????     | Southeast |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        SE: 1,
        /**
         * | Rotation | Direction |
         * |----------|-----------|
         * | 90?????     | South     |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        S: 2,
        /**
         * | Rotation | Direction |
         * |----------|-----------|
         * | 135?????    | Southwest |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        SW: 3,
        /**
         * | Rotation | Direction |
         * |----------|-----------|
         * | 180??     | West      |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        W: 4,
        /**
         * | Rotation    | Direction    |
         * |-------------|--------------|
         * | -135??/225????? | Northwest    |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        NW: 5,
        /**
         * | Rotation    | Direction    |
         * |-------------|--------------|
         * | -90??/270?????  | North        |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        N: 6,
        /**
         * | Rotation    | Direction    |
         * |-------------|--------------|
         * | -45??/315?????  | Northeast    |
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        NE: 7,
        /**
         * Reflection about Y-axis.
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        MIRROR_VERTICAL: 8,
        /**
         * Reflection about the main diagonal.
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        MAIN_DIAGONAL: 10,
        /**
         * Reflection about X-axis.
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        MIRROR_HORIZONTAL: 12,
        /**
         * Reflection about reverse diagonal.
         * @memberof PIXI.groupD8
         * @constant {PIXI.GD8Symmetry}
         */
        REVERSE_DIAGONAL: 14,
        /**
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} ind - sprite rotation angle.
         * @returns {PIXI.GD8Symmetry} The X-component of the U-axis
         *    after rotating the axes.
         */
        uX: function (ind) { return ux[ind]; },
        /**
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} ind - sprite rotation angle.
         * @returns {PIXI.GD8Symmetry} The Y-component of the U-axis
         *    after rotating the axes.
         */
        uY: function (ind) { return uy[ind]; },
        /**
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} ind - sprite rotation angle.
         * @returns {PIXI.GD8Symmetry} The X-component of the V-axis
         *    after rotating the axes.
         */
        vX: function (ind) { return vx[ind]; },
        /**
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} ind - sprite rotation angle.
         * @returns {PIXI.GD8Symmetry} The Y-component of the V-axis
         *    after rotating the axes.
         */
        vY: function (ind) { return vy[ind]; },
        /**
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} rotation - symmetry whose opposite
         *   is needed. Only rotations have opposite symmetries while
         *   reflections don't.
         * @returns {PIXI.GD8Symmetry} The opposite symmetry of `rotation`
         */
        inv: function (rotation) {
            if (rotation & 8) // true only if between 8 & 15 (reflections)
             {
                return rotation & 15; // or rotation % 16
            }
            return (-rotation) & 7; // or (8 - rotation) % 8
        },
        /**
         * Composes the two D8 operations.
         *
         * Taking `^` as reflection:
         *
         * |       | E=0 | S=2 | W=4 | N=6 | E^=8 | S^=10 | W^=12 | N^=14 |
         * |-------|-----|-----|-----|-----|------|-------|-------|-------|
         * | E=0   | E   | S   | W   | N   | E^   | S^    | W^    | N^    |
         * | S=2   | S   | W   | N   | E   | S^   | W^    | N^    | E^    |
         * | W=4   | W   | N   | E   | S   | W^   | N^    | E^    | S^    |
         * | N=6   | N   | E   | S   | W   | N^   | E^    | S^    | W^    |
         * | E^=8  | E^  | N^  | W^  | S^  | E    | N     | W     | S     |
         * | S^=10 | S^  | E^  | N^  | W^  | S    | E     | N     | W     |
         * | W^=12 | W^  | S^  | E^  | N^  | W    | S     | E     | N     |
         * | N^=14 | N^  | W^  | S^  | E^  | N    | W     | S     | E     |
         *
         * [This is a Cayley table]{@link https://en.wikipedia.org/wiki/Cayley_table}
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} rotationSecond - Second operation, which
         *   is the row in the above cayley table.
         * @param {PIXI.GD8Symmetry} rotationFirst - First operation, which
         *   is the column in the above cayley table.
         * @returns {PIXI.GD8Symmetry} Composed operation
         */
        add: function (rotationSecond, rotationFirst) { return (rotationCayley[rotationSecond][rotationFirst]); },
        /**
         * Reverse of `add`.
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} rotationSecond - Second operation
         * @param {PIXI.GD8Symmetry} rotationFirst - First operation
         * @returns {PIXI.GD8Symmetry} Result
         */
        sub: function (rotationSecond, rotationFirst) { return (rotationCayley[rotationSecond][groupD8.inv(rotationFirst)]); },
        /**
         * Adds 180 degrees to rotation, which is a commutative
         * operation.
         * @memberof PIXI.groupD8
         * @param {number} rotation - The number to rotate.
         * @returns {number} Rotated number
         */
        rotate180: function (rotation) { return rotation ^ 4; },
        /**
         * Checks if the rotation angle is vertical, i.e. south
         * or north. It doesn't work for reflections.
         * @memberof PIXI.groupD8
         * @param {PIXI.GD8Symmetry} rotation - The number to check.
         * @returns {boolean} Whether or not the direction is vertical
         */
        isVertical: function (rotation) { return (rotation & 3) === 2; },
        /**
         * Approximates the vector `V(dx,dy)` into one of the
         * eight directions provided by `groupD8`.
         * @memberof PIXI.groupD8
         * @param {number} dx - X-component of the vector
         * @param {number} dy - Y-component of the vector
         * @returns {PIXI.GD8Symmetry} Approximation of the vector into
         *  one of the eight symmetries.
         */
        byDirection: function (dx, dy) {
            if (Math.abs(dx) * 2 <= Math.abs(dy)) {
                if (dy >= 0) {
                    return groupD8.S;
                }
                return groupD8.N;
            }
            else if (Math.abs(dy) * 2 <= Math.abs(dx)) {
                if (dx > 0) {
                    return groupD8.E;
                }
                return groupD8.W;
            }
            else if (dy > 0) {
                if (dx > 0) {
                    return groupD8.SE;
                }
                return groupD8.SW;
            }
            else if (dx > 0) {
                return groupD8.NE;
            }
            return groupD8.NW;
        },
        /**
         * Helps sprite to compensate texture packer rotation.
         * @memberof PIXI.groupD8
         * @param {PIXI.Matrix} matrix - sprite world matrix
         * @param {PIXI.GD8Symmetry} rotation - The rotation factor to use.
         * @param {number} tx - sprite anchoring
         * @param {number} ty - sprite anchoring
         */
        matrixAppendRotationInv: function (matrix, rotation, tx, ty) {
            if (tx === void 0) { tx = 0; }
            if (ty === void 0) { ty = 0; }
            // Packer used "rotation", we use "inv(rotation)"
            var mat = rotationMatrices[groupD8.inv(rotation)];
            mat.tx = tx;
            mat.ty = ty;
            matrix.append(mat);
        },
    };

    /**
     * Transform that takes care about its versions.
     * @memberof PIXI
     */
    var Transform = /** @class */ (function () {
        function Transform() {
            this.worldTransform = new Matrix();
            this.localTransform = new Matrix();
            this.position = new ObservablePoint(this.onChange, this, 0, 0);
            this.scale = new ObservablePoint(this.onChange, this, 1, 1);
            this.pivot = new ObservablePoint(this.onChange, this, 0, 0);
            this.skew = new ObservablePoint(this.updateSkew, this, 0, 0);
            this._rotation = 0;
            this._cx = 1;
            this._sx = 0;
            this._cy = 0;
            this._sy = 1;
            this._localID = 0;
            this._currentLocalID = 0;
            this._worldID = 0;
            this._parentID = 0;
        }
        /** Called when a value changes. */
        Transform.prototype.onChange = function () {
            this._localID++;
        };
        /** Called when the skew or the rotation changes. */
        Transform.prototype.updateSkew = function () {
            this._cx = Math.cos(this._rotation + this.skew.y);
            this._sx = Math.sin(this._rotation + this.skew.y);
            this._cy = -Math.sin(this._rotation - this.skew.x); // cos, added PI/2
            this._sy = Math.cos(this._rotation - this.skew.x); // sin, added PI/2
            this._localID++;
        };
        Transform.prototype.toString = function () {
            return "[@pixi/math:Transform "
                + ("position=(" + this.position.x + ", " + this.position.y + ") ")
                + ("rotation=" + this.rotation + " ")
                + ("scale=(" + this.scale.x + ", " + this.scale.y + ") ")
                + ("skew=(" + this.skew.x + ", " + this.skew.y + ") ")
                + "]";
        };
        /** Updates the local transformation matrix. */
        Transform.prototype.updateLocalTransform = function () {
            var lt = this.localTransform;
            if (this._localID !== this._currentLocalID) {
                // get the matrix values of the displayobject based on its transform properties..
                lt.a = this._cx * this.scale.x;
                lt.b = this._sx * this.scale.x;
                lt.c = this._cy * this.scale.y;
                lt.d = this._sy * this.scale.y;
                lt.tx = this.position.x - ((this.pivot.x * lt.a) + (this.pivot.y * lt.c));
                lt.ty = this.position.y - ((this.pivot.x * lt.b) + (this.pivot.y * lt.d));
                this._currentLocalID = this._localID;
                // force an update..
                this._parentID = -1;
            }
        };
        /**
         * Updates the local and the world transformation matrices.
         * @param parentTransform - The parent transform
         */
        Transform.prototype.updateTransform = function (parentTransform) {
            var lt = this.localTransform;
            if (this._localID !== this._currentLocalID) {
                // get the matrix values of the displayobject based on its transform properties..
                lt.a = this._cx * this.scale.x;
                lt.b = this._sx * this.scale.x;
                lt.c = this._cy * this.scale.y;
                lt.d = this._sy * this.scale.y;
                lt.tx = this.position.x - ((this.pivot.x * lt.a) + (this.pivot.y * lt.c));
                lt.ty = this.position.y - ((this.pivot.x * lt.b) + (this.pivot.y * lt.d));
                this._currentLocalID = this._localID;
                // force an update..
                this._parentID = -1;
            }
            if (this._parentID !== parentTransform._worldID) {
                // concat the parent matrix with the objects transform.
                var pt = parentTransform.worldTransform;
                var wt = this.worldTransform;
                wt.a = (lt.a * pt.a) + (lt.b * pt.c);
                wt.b = (lt.a * pt.b) + (lt.b * pt.d);
                wt.c = (lt.c * pt.a) + (lt.d * pt.c);
                wt.d = (lt.c * pt.b) + (lt.d * pt.d);
                wt.tx = (lt.tx * pt.a) + (lt.ty * pt.c) + pt.tx;
                wt.ty = (lt.tx * pt.b) + (lt.ty * pt.d) + pt.ty;
                this._parentID = parentTransform._worldID;
                // update the id of the transform..
                this._worldID++;
            }
        };
        /**
         * Decomposes a matrix and sets the transforms properties based on it.
         * @param matrix - The matrix to decompose
         */
        Transform.prototype.setFromMatrix = function (matrix) {
            matrix.decompose(this);
            this._localID++;
        };
        Object.defineProperty(Transform.prototype, "rotation", {
            /** The rotation of the object in radians. */
            get: function () {
                return this._rotation;
            },
            set: function (value) {
                if (this._rotation !== value) {
                    this._rotation = value;
                    this.updateSkew();
                }
            },
            enumerable: false,
            configurable: true
        });
        /** A default (identity) transform. */
        Transform.IDENTITY = new Transform();
        return Transform;
    }());

    /*
     * Math classes and utilities mixed into PIXI namespace.
     */

    exports.Circle = Circle;
    exports.DEG_TO_RAD = DEG_TO_RAD;
    exports.Ellipse = Ellipse;
    exports.Matrix = Matrix;
    exports.ObservablePoint = ObservablePoint;
    exports.PI_2 = PI_2;
    exports.Point = Point;
    exports.Polygon = Polygon;
    exports.RAD_TO_DEG = RAD_TO_DEG;
    exports.Rectangle = Rectangle;
    exports.RoundedRectangle = RoundedRectangle;
    exports.Transform = Transform;
    exports.groupD8 = groupD8;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({});
Object.assign(this.PIXI, _pixi_math);
//# sourceMappingURL=math.js.map
