/*!
 * @pixi/display - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/display is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

var settings = require('@pixi/settings');
var math = require('@pixi/math');
var utils = require('@pixi/utils');

/**
 * Sets the default value for the container property 'sortableChildren'.
 * If set to true, the container will sort its children by zIndex value
 * when updateTransform() is called, or manually if sortChildren() is called.
 *
 * This actually changes the order of elements in the array, so should be treated
 * as a basic solution that is not performant compared to other solutions,
 * such as @link https://github.com/pixijs/pixi-display
 *
 * Also be aware of that this may not work nicely with the addChildAt() function,
 * as the zIndex sorting may cause the child to automatically sorted to another position.
 * @static
 * @constant
 * @name SORTABLE_CHILDREN
 * @memberof PIXI.settings
 * @type {boolean}
 * @default false
 */
settings.settings.SORTABLE_CHILDREN = false;

/**
 * 'Builder' pattern for bounds rectangles.
 *
 * This could be called an Axis-Aligned Bounding Box.
 * It is not an actual shape. It is a mutable thing; no 'EMPTY' or those kind of problems.
 * @memberof PIXI
 */
var Bounds = /** @class */ (function () {
    function Bounds() {
        this.minX = Infinity;
        this.minY = Infinity;
        this.maxX = -Infinity;
        this.maxY = -Infinity;
        this.rect = null;
        this.updateID = -1;
    }
    /**
     * Checks if bounds are empty.
     * @returns - True if empty.
     */
    Bounds.prototype.isEmpty = function () {
        return this.minX > this.maxX || this.minY > this.maxY;
    };
    /** Clears the bounds and resets. */
    Bounds.prototype.clear = function () {
        this.minX = Infinity;
        this.minY = Infinity;
        this.maxX = -Infinity;
        this.maxY = -Infinity;
    };
    /**
     * Can return Rectangle.EMPTY constant, either construct new rectangle, either use your rectangle
     * It is not guaranteed that it will return tempRect
     * @param rect - Temporary object will be used if AABB is not empty
     * @returns - A rectangle of the bounds
     */
    Bounds.prototype.getRectangle = function (rect) {
        if (this.minX > this.maxX || this.minY > this.maxY) {
            return math.Rectangle.EMPTY;
        }
        rect = rect || new math.Rectangle(0, 0, 1, 1);
        rect.x = this.minX;
        rect.y = this.minY;
        rect.width = this.maxX - this.minX;
        rect.height = this.maxY - this.minY;
        return rect;
    };
    /**
     * This function should be inlined when its possible.
     * @param point - The point to add.
     */
    Bounds.prototype.addPoint = function (point) {
        this.minX = Math.min(this.minX, point.x);
        this.maxX = Math.max(this.maxX, point.x);
        this.minY = Math.min(this.minY, point.y);
        this.maxY = Math.max(this.maxY, point.y);
    };
    /**
     * Adds a point, after transformed. This should be inlined when its possible.
     * @param matrix
     * @param point
     */
    Bounds.prototype.addPointMatrix = function (matrix, point) {
        var a = matrix.a, b = matrix.b, c = matrix.c, d = matrix.d, tx = matrix.tx, ty = matrix.ty;
        var x = (a * point.x) + (c * point.y) + tx;
        var y = (b * point.x) + (d * point.y) + ty;
        this.minX = Math.min(this.minX, x);
        this.maxX = Math.max(this.maxX, x);
        this.minY = Math.min(this.minY, y);
        this.maxY = Math.max(this.maxY, y);
    };
    /**
     * Adds a quad, not transformed
     * @param vertices - The verts to add.
     */
    Bounds.prototype.addQuad = function (vertices) {
        var minX = this.minX;
        var minY = this.minY;
        var maxX = this.maxX;
        var maxY = this.maxY;
        var x = vertices[0];
        var y = vertices[1];
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        x = vertices[2];
        y = vertices[3];
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        x = vertices[4];
        y = vertices[5];
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        x = vertices[6];
        y = vertices[7];
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        this.minX = minX;
        this.minY = minY;
        this.maxX = maxX;
        this.maxY = maxY;
    };
    /**
     * Adds sprite frame, transformed.
     * @param transform - transform to apply
     * @param x0 - left X of frame
     * @param y0 - top Y of frame
     * @param x1 - right X of frame
     * @param y1 - bottom Y of frame
     */
    Bounds.prototype.addFrame = function (transform, x0, y0, x1, y1) {
        this.addFrameMatrix(transform.worldTransform, x0, y0, x1, y1);
    };
    /**
     * Adds sprite frame, multiplied by matrix
     * @param matrix - matrix to apply
     * @param x0 - left X of frame
     * @param y0 - top Y of frame
     * @param x1 - right X of frame
     * @param y1 - bottom Y of frame
     */
    Bounds.prototype.addFrameMatrix = function (matrix, x0, y0, x1, y1) {
        var a = matrix.a;
        var b = matrix.b;
        var c = matrix.c;
        var d = matrix.d;
        var tx = matrix.tx;
        var ty = matrix.ty;
        var minX = this.minX;
        var minY = this.minY;
        var maxX = this.maxX;
        var maxY = this.maxY;
        var x = (a * x0) + (c * y0) + tx;
        var y = (b * x0) + (d * y0) + ty;
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        x = (a * x1) + (c * y0) + tx;
        y = (b * x1) + (d * y0) + ty;
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        x = (a * x0) + (c * y1) + tx;
        y = (b * x0) + (d * y1) + ty;
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        x = (a * x1) + (c * y1) + tx;
        y = (b * x1) + (d * y1) + ty;
        minX = x < minX ? x : minX;
        minY = y < minY ? y : minY;
        maxX = x > maxX ? x : maxX;
        maxY = y > maxY ? y : maxY;
        this.minX = minX;
        this.minY = minY;
        this.maxX = maxX;
        this.maxY = maxY;
    };
    /**
     * Adds screen vertices from array
     * @param vertexData - calculated vertices
     * @param beginOffset - begin offset
     * @param endOffset - end offset, excluded
     */
    Bounds.prototype.addVertexData = function (vertexData, beginOffset, endOffset) {
        var minX = this.minX;
        var minY = this.minY;
        var maxX = this.maxX;
        var maxY = this.maxY;
        for (var i = beginOffset; i < endOffset; i += 2) {
            var x = vertexData[i];
            var y = vertexData[i + 1];
            minX = x < minX ? x : minX;
            minY = y < minY ? y : minY;
            maxX = x > maxX ? x : maxX;
            maxY = y > maxY ? y : maxY;
        }
        this.minX = minX;
        this.minY = minY;
        this.maxX = maxX;
        this.maxY = maxY;
    };
    /**
     * Add an array of mesh vertices
     * @param transform - mesh transform
     * @param vertices - mesh coordinates in array
     * @param beginOffset - begin offset
     * @param endOffset - end offset, excluded
     */
    Bounds.prototype.addVertices = function (transform, vertices, beginOffset, endOffset) {
        this.addVerticesMatrix(transform.worldTransform, vertices, beginOffset, endOffset);
    };
    /**
     * Add an array of mesh vertices.
     * @param matrix - mesh matrix
     * @param vertices - mesh coordinates in array
     * @param beginOffset - begin offset
     * @param endOffset - end offset, excluded
     * @param padX - x padding
     * @param padY - y padding
     */
    Bounds.prototype.addVerticesMatrix = function (matrix, vertices, beginOffset, endOffset, padX, padY) {
        if (padX === void 0) { padX = 0; }
        if (padY === void 0) { padY = padX; }
        var a = matrix.a;
        var b = matrix.b;
        var c = matrix.c;
        var d = matrix.d;
        var tx = matrix.tx;
        var ty = matrix.ty;
        var minX = this.minX;
        var minY = this.minY;
        var maxX = this.maxX;
        var maxY = this.maxY;
        for (var i = beginOffset; i < endOffset; i += 2) {
            var rawX = vertices[i];
            var rawY = vertices[i + 1];
            var x = (a * rawX) + (c * rawY) + tx;
            var y = (d * rawY) + (b * rawX) + ty;
            minX = Math.min(minX, x - padX);
            maxX = Math.max(maxX, x + padX);
            minY = Math.min(minY, y - padY);
            maxY = Math.max(maxY, y + padY);
        }
        this.minX = minX;
        this.minY = minY;
        this.maxX = maxX;
        this.maxY = maxY;
    };
    /**
     * Adds other {@link Bounds}.
     * @param bounds - The Bounds to be added
     */
    Bounds.prototype.addBounds = function (bounds) {
        var minX = this.minX;
        var minY = this.minY;
        var maxX = this.maxX;
        var maxY = this.maxY;
        this.minX = bounds.minX < minX ? bounds.minX : minX;
        this.minY = bounds.minY < minY ? bounds.minY : minY;
        this.maxX = bounds.maxX > maxX ? bounds.maxX : maxX;
        this.maxY = bounds.maxY > maxY ? bounds.maxY : maxY;
    };
    /**
     * Adds other Bounds, masked with Bounds.
     * @param bounds - The Bounds to be added.
     * @param mask - TODO
     */
    Bounds.prototype.addBoundsMask = function (bounds, mask) {
        var _minX = bounds.minX > mask.minX ? bounds.minX : mask.minX;
        var _minY = bounds.minY > mask.minY ? bounds.minY : mask.minY;
        var _maxX = bounds.maxX < mask.maxX ? bounds.maxX : mask.maxX;
        var _maxY = bounds.maxY < mask.maxY ? bounds.maxY : mask.maxY;
        if (_minX <= _maxX && _minY <= _maxY) {
            var minX = this.minX;
            var minY = this.minY;
            var maxX = this.maxX;
            var maxY = this.maxY;
            this.minX = _minX < minX ? _minX : minX;
            this.minY = _minY < minY ? _minY : minY;
            this.maxX = _maxX > maxX ? _maxX : maxX;
            this.maxY = _maxY > maxY ? _maxY : maxY;
        }
    };
    /**
     * Adds other Bounds, multiplied by matrix. Bounds shouldn't be empty.
     * @param bounds - other bounds
     * @param matrix - multiplicator
     */
    Bounds.prototype.addBoundsMatrix = function (bounds, matrix) {
        this.addFrameMatrix(matrix, bounds.minX, bounds.minY, bounds.maxX, bounds.maxY);
    };
    /**
     * Adds other Bounds, masked with Rectangle.
     * @param bounds - TODO
     * @param area - TODO
     */
    Bounds.prototype.addBoundsArea = function (bounds, area) {
        var _minX = bounds.minX > area.x ? bounds.minX : area.x;
        var _minY = bounds.minY > area.y ? bounds.minY : area.y;
        var _maxX = bounds.maxX < area.x + area.width ? bounds.maxX : (area.x + area.width);
        var _maxY = bounds.maxY < area.y + area.height ? bounds.maxY : (area.y + area.height);
        if (_minX <= _maxX && _minY <= _maxY) {
            var minX = this.minX;
            var minY = this.minY;
            var maxX = this.maxX;
            var maxY = this.maxY;
            this.minX = _minX < minX ? _minX : minX;
            this.minY = _minY < minY ? _minY : minY;
            this.maxX = _maxX > maxX ? _maxX : maxX;
            this.maxY = _maxY > maxY ? _maxY : maxY;
        }
    };
    /**
     * Pads bounds object, making it grow in all directions.
     * If paddingY is omitted, both paddingX and paddingY will be set to paddingX.
     * @param paddingX - The horizontal padding amount.
     * @param paddingY - The vertical padding amount.
     */
    Bounds.prototype.pad = function (paddingX, paddingY) {
        if (paddingX === void 0) { paddingX = 0; }
        if (paddingY === void 0) { paddingY = paddingX; }
        if (!this.isEmpty()) {
            this.minX -= paddingX;
            this.maxX += paddingX;
            this.minY -= paddingY;
            this.maxY += paddingY;
        }
    };
    /**
     * Adds padded frame. (x0, y0) should be strictly less than (x1, y1)
     * @param x0 - left X of frame
     * @param y0 - top Y of frame
     * @param x1 - right X of frame
     * @param y1 - bottom Y of frame
     * @param padX - padding X
     * @param padY - padding Y
     */
    Bounds.prototype.addFramePad = function (x0, y0, x1, y1, padX, padY) {
        x0 -= padX;
        y0 -= padY;
        x1 += padX;
        y1 += padY;
        this.minX = this.minX < x0 ? this.minX : x0;
        this.maxX = this.maxX > x1 ? this.maxX : x1;
        this.minY = this.minY < y0 ? this.minY : y0;
        this.maxY = this.maxY > y1 ? this.maxY : y1;
    };
    return Bounds;
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

/**
 * The base class for all objects that are rendered on the screen.
 *
 * This is an abstract class and can not be used on its own; rather it should be extended.
 *
 * ## Display objects implemented in PixiJS
 *
 * | Display Object                  | Description                                                           |
 * | ------------------------------- | --------------------------------------------------------------------- |
 * | {@link PIXI.Container}          | Adds support for `children` to DisplayObject                          |
 * | {@link PIXI.Graphics}           | Shape-drawing display object similar to the Canvas API                |
 * | {@link PIXI.Sprite}             | Draws textures (i.e. images)                                          |
 * | {@link PIXI.Text}               | Draws text using the Canvas API internally                            |
 * | {@link PIXI.BitmapText}         | More scaleable solution for text rendering, reusing glyph textures    |
 * | {@link PIXI.TilingSprite}       | Draws textures/images in a tiled fashion                              |
 * | {@link PIXI.AnimatedSprite}     | Draws an animation of multiple images                                 |
 * | {@link PIXI.Mesh}               | Provides a lower-level API for drawing meshes with custom data        |
 * | {@link PIXI.NineSlicePlane}     | Mesh-related                                                          |
 * | {@link PIXI.SimpleMesh}         | v4-compatible mesh                                                    |
 * | {@link PIXI.SimplePlane}        | Mesh-related                                                          |
 * | {@link PIXI.SimpleRope}         | Mesh-related                                                          |
 *
 * ## Transforms
 *
 * The [transform]{@link DisplayObject#transform} of a display object describes the projection from its
 * local coordinate space to its parent's local coordinate space. The following properties are derived
 * from the transform:
 *
 * <table>
 *   <thead>
 *     <tr>
 *       <th>Property</th>
 *       <th>Description</th>
 *     </tr>
 *   </thead>
 *   <tbody>
 *     <tr>
 *       <td>[pivot]{@link PIXI.DisplayObject#pivot}</td>
 *       <td>
 *         Invariant under rotation, scaling, and skewing. The projection of into the parent's space of the pivot
 *         is equal to position, regardless of the other three transformations. In other words, It is the center of
 *         rotation, scaling, and skewing.
 *       </td>
 *     </tr>
 *     <tr>
 *       <td>[position]{@link PIXI.DisplayObject#position}</td>
 *       <td>
 *         Translation. This is the position of the [pivot]{@link PIXI.DisplayObject#pivot} in the parent's local
 *         space. The default value of the pivot is the origin (0,0). If the top-left corner of your display object
 *         is (0,0) in its local space, then the position will be its top-left corner in the parent's local space.
 *       </td>
 *     </tr>
 *     <tr>
 *       <td>[scale]{@link PIXI.DisplayObject#scale}</td>
 *       <td>
 *         Scaling. This will stretch (or compress) the display object's projection. The scale factors are along the
 *         local coordinate axes. In other words, the display object is scaled before rotated or skewed. The center
 *         of scaling is the [pivot]{@link PIXI.DisplayObject#pivot}.
 *       </td>
 *     </tr>
 *     <tr>
 *       <td>[rotation]{@link PIXI.DisplayObject#rotation}</td>
 *       <td>
 *          Rotation. This will rotate the display object's projection by this angle (in radians).
 *       </td>
 *     </tr>
 *     <tr>
 *       <td>[skew]{@link PIXI.DisplayObject#skew}</td>
 *       <td>
 *         <p>Skewing. This can be used to deform a rectangular display object into a parallelogram.</p>
 *         <p>
 *         In PixiJS, skew has a slightly different behaviour than the conventional meaning. It can be
 *         thought of the net rotation applied to the coordinate axes (separately). For example, if "skew.x" is
 *         ??? and "skew.y" is ??, then the line x = 0 will be rotated by ??? (y = -x*cot???) and the line y = 0 will be
 *         rotated by ?? (y = x*tan??). A line y = x*tan?? (i.e. a line at angle ?? to the x-axis in local-space) will
 *         be rotated by an angle between ??? and ??.
 *         </p>
 *         <p>
 *         It can be observed that if skew is applied equally to both axes, then it will be equivalent to applying
 *         a rotation. Indeed, if "skew.x" = -?? and "skew.y" = ??, it will produce an equivalent of "rotation" = ??.
 *         </p>
 *         <p>
 *         Another quite interesting observation is that "skew.x", "skew.y", rotation are communtative operations. Indeed,
 *         because rotation is essentially a careful combination of the two.
 *         </p>
 *       </td>
 *     </tr>
 *     <tr>
 *       <td>angle</td>
 *       <td>Rotation. This is an alias for [rotation]{@link PIXI.DisplayObject#rotation}, but in degrees.</td>
 *     </tr>
 *     <tr>
 *       <td>x</td>
 *       <td>Translation. This is an alias for position.x!</td>
 *     </tr>
 *     <tr>
 *       <td>y</td>
 *       <td>Translation. This is an alias for position.y!</td>
 *     </tr>
 *     <tr>
 *       <td>width</td>
 *       <td>
 *         Implemented in [Container]{@link PIXI.Container}. Scaling. The width property calculates scale.x by dividing
 *         the "requested" width by the local bounding box width. It is indirectly an abstraction over scale.x, and there
 *         is no concept of user-defined width.
 *       </td>
 *     </tr>
 *     <tr>
 *       <td>height</td>
 *       <td>
 *         Implemented in [Container]{@link PIXI.Container}. Scaling. The height property calculates scale.y by dividing
 *         the "requested" height by the local bounding box height. It is indirectly an abstraction over scale.y, and there
 *         is no concept of user-defined height.
 *       </td>
 *     </tr>
 *   </tbody>
 * </table>
 *
 * ## Bounds
 *
 * The bounds of a display object is defined by the minimum axis-aligned rectangle in world space that can fit
 * around it. The abstract `calculateBounds` method is responsible for providing it (and it should use the
 * `worldTransform` to calculate in world space).
 *
 * There are a few additional types of bounding boxes:
 *
 * | Bounds                | Description                                                                              |
 * | --------------------- | ---------------------------------------------------------------------------------------- |
 * | World Bounds          | This is synonymous is the regular bounds described above. See `getBounds()`.             |
 * | Local Bounds          | This the axis-aligned bounding box in the parent's local space. See `getLocalBounds()`.  |
 * | Render Bounds         | The bounds, but including extra rendering effects like filter padding.                   |
 * | Projected Bounds      | The bounds of the projected display object onto the screen. Usually equals world bounds. |
 * | Relative Bounds       | The bounds of a display object when projected onto a ancestor's (or parent's) space.     |
 * | Natural Bounds        | The bounds of an object in its own local space (not parent's space, like in local bounds)|
 * | Content Bounds        | The natural bounds when excluding all children of a `Container`.                         |
 *
 * ### calculateBounds
 *
 * [Container]{@link Container} already implements `calculateBounds` in a manner that includes children.
 *
 * But for a non-Container display object, the `calculateBounds` method must be overridden in order for `getBounds` and
 * `getLocalBounds` to work. This method must write the bounds into `this._bounds`.
 *
 * Generally, the following technique works for most simple cases: take the list of points
 * forming the "hull" of the object (i.e. outline of the object's shape), and then add them
 * using {@link PIXI.Bounds#addPointMatrix}.
 *
 * ```js
 * calculateBounds(): void
 * {
 *     const points = [...];
 *
 *     for (let i = 0, j = points.length; i < j; i++)
 *     {
 *         this._bounds.addPointMatrix(this.worldTransform, points[i]);
 *     }
 * }
 * ```
 *
 * You can optimize this for a large number of points by using {@link PIXI.Bounds#addVerticesMatrix} to pass them
 * in one array together.
 *
 * ## Alpha
 *
 * This alpha sets a display object's **relative opacity** w.r.t its parent. For example, if the alpha of a display
 * object is 0.5 and its parent's alpha is 0.5, then it will be rendered with 25% opacity (assuming alpha is not
 * applied on any ancestor further up the chain).
 *
 * The alpha with which the display object will be rendered is called the [worldAlpha]{@link PIXI.DisplayObject#worldAlpha}.
 *
 * ## Renderable vs Visible
 *
 * The `renderable` and `visible` properties can be used to prevent a display object from being rendered to the
 * screen. However, there is a subtle difference between the two. When using `renderable`, the transforms  of the display
 * object (and its children subtree) will continue to be calculated. When using `visible`, the transforms will not
 * be calculated.
 *
 * It is recommended that applications use the `renderable` property for culling. See
 * [@pixi-essentials/cull]{@link https://www.npmjs.com/package/@pixi-essentials/cull} or
 * [pixi-cull]{@link https://www.npmjs.com/package/pixi-cull} for more details.
 *
 * Otherwise, to prevent an object from rendering in the general-purpose sense - `visible` is the property to use. This
 * one is also better in terms of performance.
 * @memberof PIXI
 */
var DisplayObject = /** @class */ (function (_super) {
    __extends(DisplayObject, _super);
    function DisplayObject() {
        var _this = _super.call(this) || this;
        _this.tempDisplayObjectParent = null;
        // TODO: need to create Transform from factory
        _this.transform = new math.Transform();
        _this.alpha = 1;
        _this.visible = true;
        _this.renderable = true;
        _this.cullable = false;
        _this.cullArea = null;
        _this.parent = null;
        _this.worldAlpha = 1;
        _this._lastSortedIndex = 0;
        _this._zIndex = 0;
        _this.filterArea = null;
        _this.filters = null;
        _this._enabledFilters = null;
        _this._bounds = new Bounds();
        _this._localBounds = null;
        _this._boundsID = 0;
        _this._boundsRect = null;
        _this._localBoundsRect = null;
        _this._mask = null;
        _this._maskRefCount = 0;
        _this._destroyed = false;
        _this.isSprite = false;
        _this.isMask = false;
        return _this;
    }
    /**
     * Mixes all enumerable properties and methods from a source object to DisplayObject.
     * @param source - The source of properties and methods to mix in.
     */
    DisplayObject.mixin = function (source) {
        // in ES8/ES2017, this would be really easy:
        // Object.defineProperties(DisplayObject.prototype, Object.getOwnPropertyDescriptors(source));
        // get all the enumerable property keys
        var keys = Object.keys(source);
        // loop through properties
        for (var i = 0; i < keys.length; ++i) {
            var propertyName = keys[i];
            // Set the property using the property descriptor - this works for accessors and normal value properties
            Object.defineProperty(DisplayObject.prototype, propertyName, Object.getOwnPropertyDescriptor(source, propertyName));
        }
    };
    Object.defineProperty(DisplayObject.prototype, "destroyed", {
        /**
         * Fired when this DisplayObject is added to a Container.
         * @instance
         * @event added
         * @param {PIXI.Container} container - The container added to.
         */
        /**
         * Fired when this DisplayObject is removed from a Container.
         * @instance
         * @event removed
         * @param {PIXI.Container} container - The container removed from.
         */
        /**
         * Fired when this DisplayObject is destroyed. This event is emitted once
         * destroy is finished.
         * @instance
         * @event destroyed
         */
        /** Readonly flag for destroyed display objects. */
        get: function () {
            return this._destroyed;
        },
        enumerable: false,
        configurable: true
    });
    /** Recursively updates transform of all objects from the root to this one internal function for toLocal() */
    DisplayObject.prototype._recursivePostUpdateTransform = function () {
        if (this.parent) {
            this.parent._recursivePostUpdateTransform();
            this.transform.updateTransform(this.parent.transform);
        }
        else {
            this.transform.updateTransform(this._tempDisplayObjectParent.transform);
        }
    };
    /** Updates the object transform for rendering. TODO - Optimization pass! */
    DisplayObject.prototype.updateTransform = function () {
        this._boundsID++;
        this.transform.updateTransform(this.parent.transform);
        // multiply the alphas..
        this.worldAlpha = this.alpha * this.parent.worldAlpha;
    };
    /**
     * Calculates and returns the (world) bounds of the display object as a [Rectangle]{@link PIXI.Rectangle}.
     *
     * This method is expensive on containers with a large subtree (like the stage). This is because the bounds
     * of a container depend on its children's bounds, which recursively causes all bounds in the subtree to
     * be recalculated. The upside, however, is that calling `getBounds` once on a container will indeed update
     * the bounds of all children (the whole subtree, in fact). This side effect should be exploited by using
     * `displayObject._bounds.getRectangle()` when traversing through all the bounds in a scene graph. Otherwise,
     * calling `getBounds` on each object in a subtree will cause the total cost to increase quadratically as
     * its height increases.
     *
     * The transforms of all objects in a container's **subtree** and of all **ancestors** are updated.
     * The world bounds of all display objects in a container's **subtree** will also be recalculated.
     *
     * The `_bounds` object stores the last calculation of the bounds. You can use to entirely skip bounds
     * calculation if needed.
     *
     * ```js
     * const lastCalculatedBounds = displayObject._bounds.getRectangle(optionalRect);
     * ```
     *
     * Do know that usage of `getLocalBounds` can corrupt the `_bounds` of children (the whole subtree, actually). This
     * is a known issue that has not been solved. See [getLocalBounds]{@link PIXI.DisplayObject#getLocalBounds} for more
     * details.
     *
     * `getBounds` should be called with `skipUpdate` equal to `true` in a render() call. This is because the transforms
     * are guaranteed to be update-to-date. In fact, recalculating inside a render() call may cause corruption in certain
     * cases.
     * @param skipUpdate - Setting to `true` will stop the transforms of the scene graph from
     *  being updated. This means the calculation returned MAY be out of date BUT will give you a
     *  nice performance boost.
     * @param rect - Optional rectangle to store the result of the bounds calculation.
     * @returns - The minimum axis-aligned rectangle in world space that fits around this object.
     */
    DisplayObject.prototype.getBounds = function (skipUpdate, rect) {
        if (!skipUpdate) {
            if (!this.parent) {
                this.parent = this._tempDisplayObjectParent;
                this.updateTransform();
                this.parent = null;
            }
            else {
                this._recursivePostUpdateTransform();
                this.updateTransform();
            }
        }
        if (this._bounds.updateID !== this._boundsID) {
            this.calculateBounds();
            this._bounds.updateID = this._boundsID;
        }
        if (!rect) {
            if (!this._boundsRect) {
                this._boundsRect = new math.Rectangle();
            }
            rect = this._boundsRect;
        }
        return this._bounds.getRectangle(rect);
    };
    /**
     * Retrieves the local bounds of the displayObject as a rectangle object.
     * @param rect - Optional rectangle to store the result of the bounds calculation.
     * @returns - The rectangular bounding area.
     */
    DisplayObject.prototype.getLocalBounds = function (rect) {
        if (!rect) {
            if (!this._localBoundsRect) {
                this._localBoundsRect = new math.Rectangle();
            }
            rect = this._localBoundsRect;
        }
        if (!this._localBounds) {
            this._localBounds = new Bounds();
        }
        var transformRef = this.transform;
        var parentRef = this.parent;
        this.parent = null;
        this.transform = this._tempDisplayObjectParent.transform;
        var worldBounds = this._bounds;
        var worldBoundsID = this._boundsID;
        this._bounds = this._localBounds;
        var bounds = this.getBounds(false, rect);
        this.parent = parentRef;
        this.transform = transformRef;
        this._bounds = worldBounds;
        this._bounds.updateID += this._boundsID - worldBoundsID; // reflect side-effects
        return bounds;
    };
    /**
     * Calculates the global position of the display object.
     * @param position - The world origin to calculate from.
     * @param point - A Point object in which to store the value, optional
     *  (otherwise will create a new Point).
     * @param skipUpdate - Should we skip the update transform.
     * @returns - A point object representing the position of this object.
     */
    DisplayObject.prototype.toGlobal = function (position, point, skipUpdate) {
        if (skipUpdate === void 0) { skipUpdate = false; }
        if (!skipUpdate) {
            this._recursivePostUpdateTransform();
            // this parent check is for just in case the item is a root object.
            // If it is we need to give it a temporary parent so that displayObjectUpdateTransform works correctly
            // this is mainly to avoid a parent check in the main loop. Every little helps for performance :)
            if (!this.parent) {
                this.parent = this._tempDisplayObjectParent;
                this.displayObjectUpdateTransform();
                this.parent = null;
            }
            else {
                this.displayObjectUpdateTransform();
            }
        }
        // don't need to update the lot
        return this.worldTransform.apply(position, point);
    };
    /**
     * Calculates the local position of the display object relative to another point.
     * @param position - The world origin to calculate from.
     * @param from - The DisplayObject to calculate the global position from.
     * @param point - A Point object in which to store the value, optional
     *  (otherwise will create a new Point).
     * @param skipUpdate - Should we skip the update transform
     * @returns - A point object representing the position of this object
     */
    DisplayObject.prototype.toLocal = function (position, from, point, skipUpdate) {
        if (from) {
            position = from.toGlobal(position, point, skipUpdate);
        }
        if (!skipUpdate) {
            this._recursivePostUpdateTransform();
            // this parent check is for just in case the item is a root object.
            // If it is we need to give it a temporary parent so that displayObjectUpdateTransform works correctly
            // this is mainly to avoid a parent check in the main loop. Every little helps for performance :)
            if (!this.parent) {
                this.parent = this._tempDisplayObjectParent;
                this.displayObjectUpdateTransform();
                this.parent = null;
            }
            else {
                this.displayObjectUpdateTransform();
            }
        }
        // simply apply the matrix..
        return this.worldTransform.applyInverse(position, point);
    };
    /**
     * Set the parent Container of this DisplayObject.
     * @param container - The Container to add this DisplayObject to.
     * @returns - The Container that this DisplayObject was added to.
     */
    DisplayObject.prototype.setParent = function (container) {
        if (!container || !container.addChild) {
            throw new Error('setParent: Argument must be a Container');
        }
        container.addChild(this);
        return container;
    };
    /**
     * Convenience function to set the position, scale, skew and pivot at once.
     * @param x - The X position
     * @param y - The Y position
     * @param scaleX - The X scale value
     * @param scaleY - The Y scale value
     * @param rotation - The rotation
     * @param skewX - The X skew value
     * @param skewY - The Y skew value
     * @param pivotX - The X pivot value
     * @param pivotY - The Y pivot value
     * @returns - The DisplayObject instance
     */
    DisplayObject.prototype.setTransform = function (x, y, scaleX, scaleY, rotation, skewX, skewY, pivotX, pivotY) {
        if (x === void 0) { x = 0; }
        if (y === void 0) { y = 0; }
        if (scaleX === void 0) { scaleX = 1; }
        if (scaleY === void 0) { scaleY = 1; }
        if (rotation === void 0) { rotation = 0; }
        if (skewX === void 0) { skewX = 0; }
        if (skewY === void 0) { skewY = 0; }
        if (pivotX === void 0) { pivotX = 0; }
        if (pivotY === void 0) { pivotY = 0; }
        this.position.x = x;
        this.position.y = y;
        this.scale.x = !scaleX ? 1 : scaleX;
        this.scale.y = !scaleY ? 1 : scaleY;
        this.rotation = rotation;
        this.skew.x = skewX;
        this.skew.y = skewY;
        this.pivot.x = pivotX;
        this.pivot.y = pivotY;
        return this;
    };
    /**
     * Base destroy method for generic display objects. This will automatically
     * remove the display object from its parent Container as well as remove
     * all current event listeners and internal references. Do not use a DisplayObject
     * after calling `destroy()`.
     * @param _options
     */
    DisplayObject.prototype.destroy = function (_options) {
        if (this.parent) {
            this.parent.removeChild(this);
        }
        this._destroyed = true;
        this.transform = null;
        this.parent = null;
        this._bounds = null;
        this.mask = null;
        this.cullArea = null;
        this.filters = null;
        this.filterArea = null;
        this.hitArea = null;
        this.interactive = false;
        this.interactiveChildren = false;
        this.emit('destroyed');
        this.removeAllListeners();
    };
    Object.defineProperty(DisplayObject.prototype, "_tempDisplayObjectParent", {
        /**
         * @protected
         * @member {PIXI.Container}
         */
        get: function () {
            if (this.tempDisplayObjectParent === null) {
                // eslint-disable-next-line @typescript-eslint/no-use-before-define
                this.tempDisplayObjectParent = new TemporaryDisplayObject();
            }
            return this.tempDisplayObjectParent;
        },
        enumerable: false,
        configurable: true
    });
    /**
     * Used in Renderer, cacheAsBitmap and other places where you call an `updateTransform` on root
     *
     * ```
     * const cacheParent = elem.enableTempParent();
     * elem.updateTransform();
     * elem.disableTempParent(cacheParent);
     * ```
     * @returns - current parent
     */
    DisplayObject.prototype.enableTempParent = function () {
        var myParent = this.parent;
        this.parent = this._tempDisplayObjectParent;
        return myParent;
    };
    /**
     * Pair method for `enableTempParent`
     * @param cacheParent - Actual parent of element
     */
    DisplayObject.prototype.disableTempParent = function (cacheParent) {
        this.parent = cacheParent;
    };
    Object.defineProperty(DisplayObject.prototype, "x", {
        /**
         * The position of the displayObject on the x axis relative to the local coordinates of the parent.
         * An alias to position.x
         */
        get: function () {
            return this.position.x;
        },
        set: function (value) {
            this.transform.position.x = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "y", {
        /**
         * The position of the displayObject on the y axis relative to the local coordinates of the parent.
         * An alias to position.y
         */
        get: function () {
            return this.position.y;
        },
        set: function (value) {
            this.transform.position.y = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "worldTransform", {
        /**
         * Current transform of the object based on world (parent) factors.
         * @readonly
         */
        get: function () {
            return this.transform.worldTransform;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "localTransform", {
        /**
         * Current transform of the object based on local factors: position, scale, other stuff.
         * @readonly
         */
        get: function () {
            return this.transform.localTransform;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "position", {
        /**
         * The coordinate of the object relative to the local coordinates of the parent.
         * @since 4.0.0
         */
        get: function () {
            return this.transform.position;
        },
        set: function (value) {
            this.transform.position.copyFrom(value);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "scale", {
        /**
         * The scale factors of this object along the local coordinate axes.
         *
         * The default scale is (1, 1).
         * @since 4.0.0
         */
        get: function () {
            return this.transform.scale;
        },
        set: function (value) {
            this.transform.scale.copyFrom(value);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "pivot", {
        /**
         * The center of rotation, scaling, and skewing for this display object in its local space. The `position`
         * is the projection of `pivot` in the parent's local space.
         *
         * By default, the pivot is the origin (0, 0).
         * @since 4.0.0
         */
        get: function () {
            return this.transform.pivot;
        },
        set: function (value) {
            this.transform.pivot.copyFrom(value);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "skew", {
        /**
         * The skew factor for the object in radians.
         * @since 4.0.0
         */
        get: function () {
            return this.transform.skew;
        },
        set: function (value) {
            this.transform.skew.copyFrom(value);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "rotation", {
        /**
         * The rotation of the object in radians.
         * 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
         */
        get: function () {
            return this.transform.rotation;
        },
        set: function (value) {
            this.transform.rotation = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "angle", {
        /**
         * The angle of the object in degrees.
         * 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
         */
        get: function () {
            return this.transform.rotation * math.RAD_TO_DEG;
        },
        set: function (value) {
            this.transform.rotation = value * math.DEG_TO_RAD;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "zIndex", {
        /**
         * The zIndex of the displayObject.
         *
         * If a container has the sortableChildren property set to true, children will be automatically
         * sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
         * and thus rendered on top of other display objects within the same container.
         * @see PIXI.Container#sortableChildren
         */
        get: function () {
            return this._zIndex;
        },
        set: function (value) {
            this._zIndex = value;
            if (this.parent) {
                this.parent.sortDirty = true;
            }
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "worldVisible", {
        /**
         * Indicates if the object is globally visible.
         * @readonly
         */
        get: function () {
            var item = this;
            do {
                if (!item.visible) {
                    return false;
                }
                item = item.parent;
            } while (item);
            return true;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(DisplayObject.prototype, "mask", {
        /**
         * Sets a mask for the displayObject. A mask is an object that limits the visibility of an
         * object to the shape of the mask applied to it. In PixiJS a regular mask must be a
         * {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
         * utilities shape clipping. Furthermore, a mask of an object must be in the subtree of its parent.
         * Otherwise, `getLocalBounds` may calculate incorrect bounds, which makes the container's width and height wrong.
         * To remove a mask, set this property to `null`.
         *
         * For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
         * @example
         * const graphics = new PIXI.Graphics();
         * graphics.beginFill(0xFF3300);
         * graphics.drawRect(50, 250, 100, 100);
         * graphics.endFill();
         *
         * const sprite = new PIXI.Sprite(texture);
         * sprite.mask = graphics;
         * @todo At the moment, PIXI.CanvasRenderer doesn't support PIXI.Sprite as mask.
         */
        get: function () {
            return this._mask;
        },
        set: function (value) {
            if (this._mask === value) {
                return;
            }
            if (this._mask) {
                var maskObject = (this._mask.isMaskData
                    ? this._mask.maskObject : this._mask);
                if (maskObject) {
                    maskObject._maskRefCount--;
                    if (maskObject._maskRefCount === 0) {
                        maskObject.renderable = true;
                        maskObject.isMask = false;
                    }
                }
            }
            this._mask = value;
            if (this._mask) {
                var maskObject = (this._mask.isMaskData
                    ? this._mask.maskObject : this._mask);
                if (maskObject) {
                    if (maskObject._maskRefCount === 0) {
                        maskObject.renderable = false;
                        maskObject.isMask = true;
                    }
                    maskObject._maskRefCount++;
                }
            }
        },
        enumerable: false,
        configurable: true
    });
    return DisplayObject;
}(utils.EventEmitter));
/**
 * @private
 */
var TemporaryDisplayObject = /** @class */ (function (_super) {
    __extends(TemporaryDisplayObject, _super);
    function TemporaryDisplayObject() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.sortDirty = null;
        return _this;
    }
    return TemporaryDisplayObject;
}(DisplayObject));
/**
 * DisplayObject default updateTransform, does not update children of container.
 * Will crash if there's no parent element.
 * @memberof PIXI.DisplayObject#
 * @method displayObjectUpdateTransform
 */
DisplayObject.prototype.displayObjectUpdateTransform = DisplayObject.prototype.updateTransform;

/*!
 * @pixi/constants - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/constants is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
/**
 * Different types of environments for WebGL.
 * @static
 * @memberof PIXI
 * @name ENV
 * @enum {number}
 * @property {number} WEBGL_LEGACY - Used for older v1 WebGL devices. PixiJS will aim to ensure compatibility
 *  with older / less advanced devices. If you experience unexplained flickering prefer this environment.
 * @property {number} WEBGL - Version 1 of WebGL
 * @property {number} WEBGL2 - Version 2 of WebGL
 */
var ENV;
(function (ENV) {
    ENV[ENV["WEBGL_LEGACY"] = 0] = "WEBGL_LEGACY";
    ENV[ENV["WEBGL"] = 1] = "WEBGL";
    ENV[ENV["WEBGL2"] = 2] = "WEBGL2";
})(ENV || (ENV = {}));
/**
 * Constant to identify the Renderer Type.
 * @static
 * @memberof PIXI
 * @name RENDERER_TYPE
 * @enum {number}
 * @property {number} UNKNOWN - Unknown render type.
 * @property {number} WEBGL - WebGL render type.
 * @property {number} CANVAS - Canvas render type.
 */
var RENDERER_TYPE;
(function (RENDERER_TYPE) {
    RENDERER_TYPE[RENDERER_TYPE["UNKNOWN"] = 0] = "UNKNOWN";
    RENDERER_TYPE[RENDERER_TYPE["WEBGL"] = 1] = "WEBGL";
    RENDERER_TYPE[RENDERER_TYPE["CANVAS"] = 2] = "CANVAS";
})(RENDERER_TYPE || (RENDERER_TYPE = {}));
/**
 * Bitwise OR of masks that indicate the buffers to be cleared.
 * @static
 * @memberof PIXI
 * @name BUFFER_BITS
 * @enum {number}
 * @property {number} COLOR - Indicates the buffers currently enabled for color writing.
 * @property {number} DEPTH - Indicates the depth buffer.
 * @property {number} STENCIL - Indicates the stencil buffer.
 */
var BUFFER_BITS;
(function (BUFFER_BITS) {
    BUFFER_BITS[BUFFER_BITS["COLOR"] = 16384] = "COLOR";
    BUFFER_BITS[BUFFER_BITS["DEPTH"] = 256] = "DEPTH";
    BUFFER_BITS[BUFFER_BITS["STENCIL"] = 1024] = "STENCIL";
})(BUFFER_BITS || (BUFFER_BITS = {}));
/**
 * Various blend modes supported by PIXI.
 *
 * IMPORTANT - The WebGL renderer only supports the NORMAL, ADD, MULTIPLY and SCREEN blend modes.
 * Anything else will silently act like NORMAL.
 * @memberof PIXI
 * @name BLEND_MODES
 * @enum {number}
 * @property {number} NORMAL -
 * @property {number} ADD -
 * @property {number} MULTIPLY -
 * @property {number} SCREEN -
 * @property {number} OVERLAY -
 * @property {number} DARKEN -
 * @property {number} LIGHTEN -
 * @property {number} COLOR_DODGE -
 * @property {number} COLOR_BURN -
 * @property {number} HARD_LIGHT -
 * @property {number} SOFT_LIGHT -
 * @property {number} DIFFERENCE -
 * @property {number} EXCLUSION -
 * @property {number} HUE -
 * @property {number} SATURATION -
 * @property {number} COLOR -
 * @property {number} LUMINOSITY -
 * @property {number} NORMAL_NPM -
 * @property {number} ADD_NPM -
 * @property {number} SCREEN_NPM -
 * @property {number} NONE -
 * @property {number} SRC_IN -
 * @property {number} SRC_OUT -
 * @property {number} SRC_ATOP -
 * @property {number} DST_OVER -
 * @property {number} DST_IN -
 * @property {number} DST_OUT -
 * @property {number} DST_ATOP -
 * @property {number} SUBTRACT -
 * @property {number} SRC_OVER -
 * @property {number} ERASE -
 * @property {number} XOR -
 */
var BLEND_MODES;
(function (BLEND_MODES) {
    BLEND_MODES[BLEND_MODES["NORMAL"] = 0] = "NORMAL";
    BLEND_MODES[BLEND_MODES["ADD"] = 1] = "ADD";
    BLEND_MODES[BLEND_MODES["MULTIPLY"] = 2] = "MULTIPLY";
    BLEND_MODES[BLEND_MODES["SCREEN"] = 3] = "SCREEN";
    BLEND_MODES[BLEND_MODES["OVERLAY"] = 4] = "OVERLAY";
    BLEND_MODES[BLEND_MODES["DARKEN"] = 5] = "DARKEN";
    BLEND_MODES[BLEND_MODES["LIGHTEN"] = 6] = "LIGHTEN";
    BLEND_MODES[BLEND_MODES["COLOR_DODGE"] = 7] = "COLOR_DODGE";
    BLEND_MODES[BLEND_MODES["COLOR_BURN"] = 8] = "COLOR_BURN";
    BLEND_MODES[BLEND_MODES["HARD_LIGHT"] = 9] = "HARD_LIGHT";
    BLEND_MODES[BLEND_MODES["SOFT_LIGHT"] = 10] = "SOFT_LIGHT";
    BLEND_MODES[BLEND_MODES["DIFFERENCE"] = 11] = "DIFFERENCE";
    BLEND_MODES[BLEND_MODES["EXCLUSION"] = 12] = "EXCLUSION";
    BLEND_MODES[BLEND_MODES["HUE"] = 13] = "HUE";
    BLEND_MODES[BLEND_MODES["SATURATION"] = 14] = "SATURATION";
    BLEND_MODES[BLEND_MODES["COLOR"] = 15] = "COLOR";
    BLEND_MODES[BLEND_MODES["LUMINOSITY"] = 16] = "LUMINOSITY";
    BLEND_MODES[BLEND_MODES["NORMAL_NPM"] = 17] = "NORMAL_NPM";
    BLEND_MODES[BLEND_MODES["ADD_NPM"] = 18] = "ADD_NPM";
    BLEND_MODES[BLEND_MODES["SCREEN_NPM"] = 19] = "SCREEN_NPM";
    BLEND_MODES[BLEND_MODES["NONE"] = 20] = "NONE";
    BLEND_MODES[BLEND_MODES["SRC_OVER"] = 0] = "SRC_OVER";
    BLEND_MODES[BLEND_MODES["SRC_IN"] = 21] = "SRC_IN";
    BLEND_MODES[BLEND_MODES["SRC_OUT"] = 22] = "SRC_OUT";
    BLEND_MODES[BLEND_MODES["SRC_ATOP"] = 23] = "SRC_ATOP";
    BLEND_MODES[BLEND_MODES["DST_OVER"] = 24] = "DST_OVER";
    BLEND_MODES[BLEND_MODES["DST_IN"] = 25] = "DST_IN";
    BLEND_MODES[BLEND_MODES["DST_OUT"] = 26] = "DST_OUT";
    BLEND_MODES[BLEND_MODES["DST_ATOP"] = 27] = "DST_ATOP";
    BLEND_MODES[BLEND_MODES["ERASE"] = 26] = "ERASE";
    BLEND_MODES[BLEND_MODES["SUBTRACT"] = 28] = "SUBTRACT";
    BLEND_MODES[BLEND_MODES["XOR"] = 29] = "XOR";
})(BLEND_MODES || (BLEND_MODES = {}));
/**
 * Various webgl draw modes. These can be used to specify which GL drawMode to use
 * under certain situations and renderers.
 * @memberof PIXI
 * @static
 * @name DRAW_MODES
 * @enum {number}
 * @property {number} POINTS -
 * @property {number} LINES -
 * @property {number} LINE_LOOP -
 * @property {number} LINE_STRIP -
 * @property {number} TRIANGLES -
 * @property {number} TRIANGLE_STRIP -
 * @property {number} TRIANGLE_FAN -
 */
var DRAW_MODES;
(function (DRAW_MODES) {
    DRAW_MODES[DRAW_MODES["POINTS"] = 0] = "POINTS";
    DRAW_MODES[DRAW_MODES["LINES"] = 1] = "LINES";
    DRAW_MODES[DRAW_MODES["LINE_LOOP"] = 2] = "LINE_LOOP";
    DRAW_MODES[DRAW_MODES["LINE_STRIP"] = 3] = "LINE_STRIP";
    DRAW_MODES[DRAW_MODES["TRIANGLES"] = 4] = "TRIANGLES";
    DRAW_MODES[DRAW_MODES["TRIANGLE_STRIP"] = 5] = "TRIANGLE_STRIP";
    DRAW_MODES[DRAW_MODES["TRIANGLE_FAN"] = 6] = "TRIANGLE_FAN";
})(DRAW_MODES || (DRAW_MODES = {}));
/**
 * Various GL texture/resources formats.
 * @memberof PIXI
 * @static
 * @name FORMATS
 * @enum {number}
 * @property {number} [RGBA=6408] -
 * @property {number} [RGB=6407] -
 * @property {number} [RG=33319] -
 * @property {number} [RED=6403] -
 * @property {number} [RGBA_INTEGER=36249] -
 * @property {number} [RGB_INTEGER=36248] -
 * @property {number} [RG_INTEGER=33320] -
 * @property {number} [RED_INTEGER=36244] -
 * @property {number} [ALPHA=6406] -
 * @property {number} [LUMINANCE=6409] -
 * @property {number} [LUMINANCE_ALPHA=6410] -
 * @property {number} [DEPTH_COMPONENT=6402] -
 * @property {number} [DEPTH_STENCIL=34041] -
 */
var FORMATS;
(function (FORMATS) {
    FORMATS[FORMATS["RGBA"] = 6408] = "RGBA";
    FORMATS[FORMATS["RGB"] = 6407] = "RGB";
    FORMATS[FORMATS["RG"] = 33319] = "RG";
    FORMATS[FORMATS["RED"] = 6403] = "RED";
    FORMATS[FORMATS["RGBA_INTEGER"] = 36249] = "RGBA_INTEGER";
    FORMATS[FORMATS["RGB_INTEGER"] = 36248] = "RGB_INTEGER";
    FORMATS[FORMATS["RG_INTEGER"] = 33320] = "RG_INTEGER";
    FORMATS[FORMATS["RED_INTEGER"] = 36244] = "RED_INTEGER";
    FORMATS[FORMATS["ALPHA"] = 6406] = "ALPHA";
    FORMATS[FORMATS["LUMINANCE"] = 6409] = "LUMINANCE";
    FORMATS[FORMATS["LUMINANCE_ALPHA"] = 6410] = "LUMINANCE_ALPHA";
    FORMATS[FORMATS["DEPTH_COMPONENT"] = 6402] = "DEPTH_COMPONENT";
    FORMATS[FORMATS["DEPTH_STENCIL"] = 34041] = "DEPTH_STENCIL";
})(FORMATS || (FORMATS = {}));
/**
 * Various GL target types.
 * @memberof PIXI
 * @static
 * @name TARGETS
 * @enum {number}
 * @property {number} [TEXTURE_2D=3553] -
 * @property {number} [TEXTURE_CUBE_MAP=34067] -
 * @property {number} [TEXTURE_2D_ARRAY=35866] -
 * @property {number} [TEXTURE_CUBE_MAP_POSITIVE_X=34069] -
 * @property {number} [TEXTURE_CUBE_MAP_NEGATIVE_X=34070] -
 * @property {number} [TEXTURE_CUBE_MAP_POSITIVE_Y=34071] -
 * @property {number} [TEXTURE_CUBE_MAP_NEGATIVE_Y=34072] -
 * @property {number} [TEXTURE_CUBE_MAP_POSITIVE_Z=34073] -
 * @property {number} [TEXTURE_CUBE_MAP_NEGATIVE_Z=34074] -
 */
var TARGETS;
(function (TARGETS) {
    TARGETS[TARGETS["TEXTURE_2D"] = 3553] = "TEXTURE_2D";
    TARGETS[TARGETS["TEXTURE_CUBE_MAP"] = 34067] = "TEXTURE_CUBE_MAP";
    TARGETS[TARGETS["TEXTURE_2D_ARRAY"] = 35866] = "TEXTURE_2D_ARRAY";
    TARGETS[TARGETS["TEXTURE_CUBE_MAP_POSITIVE_X"] = 34069] = "TEXTURE_CUBE_MAP_POSITIVE_X";
    TARGETS[TARGETS["TEXTURE_CUBE_MAP_NEGATIVE_X"] = 34070] = "TEXTURE_CUBE_MAP_NEGATIVE_X";
    TARGETS[TARGETS["TEXTURE_CUBE_MAP_POSITIVE_Y"] = 34071] = "TEXTURE_CUBE_MAP_POSITIVE_Y";
    TARGETS[TARGETS["TEXTURE_CUBE_MAP_NEGATIVE_Y"] = 34072] = "TEXTURE_CUBE_MAP_NEGATIVE_Y";
    TARGETS[TARGETS["TEXTURE_CUBE_MAP_POSITIVE_Z"] = 34073] = "TEXTURE_CUBE_MAP_POSITIVE_Z";
    TARGETS[TARGETS["TEXTURE_CUBE_MAP_NEGATIVE_Z"] = 34074] = "TEXTURE_CUBE_MAP_NEGATIVE_Z";
})(TARGETS || (TARGETS = {}));
/**
 * Various GL data format types.
 * @memberof PIXI
 * @static
 * @name TYPES
 * @enum {number}
 * @property {number} [UNSIGNED_BYTE=5121] -
 * @property {number} [UNSIGNED_SHORT=5123] -
 * @property {number} [UNSIGNED_SHORT_5_6_5=33635] -
 * @property {number} [UNSIGNED_SHORT_4_4_4_4=32819] -
 * @property {number} [UNSIGNED_SHORT_5_5_5_1=32820] -
 * @property {number} [UNSIGNED_INT=5125] -
 * @property {number} [UNSIGNED_INT_10F_11F_11F_REV=35899] -
 * @property {number} [UNSIGNED_INT_2_10_10_10_REV=33640] -
 * @property {number} [UNSIGNED_INT_24_8=34042] -
 * @property {number} [UNSIGNED_INT_5_9_9_9_REV=35902] -
 * @property {number} [BYTE=5120] -
 * @property {number} [SHORT=5122] -
 * @property {number} [INT=5124] -
 * @property {number} [FLOAT=5126] -
 * @property {number} [FLOAT_32_UNSIGNED_INT_24_8_REV=36269] -
 * @property {number} [HALF_FLOAT=36193] -
 */
var TYPES;
(function (TYPES) {
    TYPES[TYPES["UNSIGNED_BYTE"] = 5121] = "UNSIGNED_BYTE";
    TYPES[TYPES["UNSIGNED_SHORT"] = 5123] = "UNSIGNED_SHORT";
    TYPES[TYPES["UNSIGNED_SHORT_5_6_5"] = 33635] = "UNSIGNED_SHORT_5_6_5";
    TYPES[TYPES["UNSIGNED_SHORT_4_4_4_4"] = 32819] = "UNSIGNED_SHORT_4_4_4_4";
    TYPES[TYPES["UNSIGNED_SHORT_5_5_5_1"] = 32820] = "UNSIGNED_SHORT_5_5_5_1";
    TYPES[TYPES["UNSIGNED_INT"] = 5125] = "UNSIGNED_INT";
    TYPES[TYPES["UNSIGNED_INT_10F_11F_11F_REV"] = 35899] = "UNSIGNED_INT_10F_11F_11F_REV";
    TYPES[TYPES["UNSIGNED_INT_2_10_10_10_REV"] = 33640] = "UNSIGNED_INT_2_10_10_10_REV";
    TYPES[TYPES["UNSIGNED_INT_24_8"] = 34042] = "UNSIGNED_INT_24_8";
    TYPES[TYPES["UNSIGNED_INT_5_9_9_9_REV"] = 35902] = "UNSIGNED_INT_5_9_9_9_REV";
    TYPES[TYPES["BYTE"] = 5120] = "BYTE";
    TYPES[TYPES["SHORT"] = 5122] = "SHORT";
    TYPES[TYPES["INT"] = 5124] = "INT";
    TYPES[TYPES["FLOAT"] = 5126] = "FLOAT";
    TYPES[TYPES["FLOAT_32_UNSIGNED_INT_24_8_REV"] = 36269] = "FLOAT_32_UNSIGNED_INT_24_8_REV";
    TYPES[TYPES["HALF_FLOAT"] = 36193] = "HALF_FLOAT";
})(TYPES || (TYPES = {}));
/**
 * Various sampler types. Correspond to `sampler`, `isampler`, `usampler` GLSL types respectively.
 * WebGL1 works only with FLOAT.
 * @memberof PIXI
 * @static
 * @name SAMPLER_TYPES
 * @enum {number}
 * @property {number} [FLOAT=0] -
 * @property {number} [INT=1] -
 * @property {number} [UINT=2] -
 */
var SAMPLER_TYPES;
(function (SAMPLER_TYPES) {
    SAMPLER_TYPES[SAMPLER_TYPES["FLOAT"] = 0] = "FLOAT";
    SAMPLER_TYPES[SAMPLER_TYPES["INT"] = 1] = "INT";
    SAMPLER_TYPES[SAMPLER_TYPES["UINT"] = 2] = "UINT";
})(SAMPLER_TYPES || (SAMPLER_TYPES = {}));
/**
 * The scale modes that are supported by pixi.
 *
 * The {@link PIXI.settings.SCALE_MODE} scale mode affects the default scaling mode of future operations.
 * It can be re-assigned to either LINEAR or NEAREST, depending upon suitability.
 * @memberof PIXI
 * @static
 * @name SCALE_MODES
 * @enum {number}
 * @property {number} LINEAR Smooth scaling
 * @property {number} NEAREST Pixelating scaling
 */
var SCALE_MODES;
(function (SCALE_MODES) {
    SCALE_MODES[SCALE_MODES["NEAREST"] = 0] = "NEAREST";
    SCALE_MODES[SCALE_MODES["LINEAR"] = 1] = "LINEAR";
})(SCALE_MODES || (SCALE_MODES = {}));
/**
 * The wrap modes that are supported by pixi.
 *
 * The {@link PIXI.settings.WRAP_MODE} wrap mode affects the default wrapping mode of future operations.
 * It can be re-assigned to either CLAMP or REPEAT, depending upon suitability.
 * If the texture is non power of two then clamp will be used regardless as WebGL can
 * only use REPEAT if the texture is po2.
 *
 * This property only affects WebGL.
 * @name WRAP_MODES
 * @memberof PIXI
 * @static
 * @enum {number}
 * @property {number} CLAMP - The textures uvs are clamped
 * @property {number} REPEAT - The texture uvs tile and repeat
 * @property {number} MIRRORED_REPEAT - The texture uvs tile and repeat with mirroring
 */
var WRAP_MODES;
(function (WRAP_MODES) {
    WRAP_MODES[WRAP_MODES["CLAMP"] = 33071] = "CLAMP";
    WRAP_MODES[WRAP_MODES["REPEAT"] = 10497] = "REPEAT";
    WRAP_MODES[WRAP_MODES["MIRRORED_REPEAT"] = 33648] = "MIRRORED_REPEAT";
})(WRAP_MODES || (WRAP_MODES = {}));
/**
 * Mipmap filtering modes that are supported by pixi.
 *
 * The {@link PIXI.settings.MIPMAP_TEXTURES} affects default texture filtering.
 * Mipmaps are generated for a baseTexture if its `mipmap` field is `ON`,
 * or its `POW2` and texture dimensions are powers of 2.
 * Due to platform restriction, `ON` option will work like `POW2` for webgl-1.
 *
 * This property only affects WebGL.
 * @name MIPMAP_MODES
 * @memberof PIXI
 * @static
 * @enum {number}
 * @property {number} OFF - No mipmaps
 * @property {number} POW2 - Generate mipmaps if texture dimensions are pow2
 * @property {number} ON - Always generate mipmaps
 * @property {number} ON_MANUAL - Use mipmaps, but do not auto-generate them; this is used with a resource
 *   that supports buffering each level-of-detail.
 */
var MIPMAP_MODES;
(function (MIPMAP_MODES) {
    MIPMAP_MODES[MIPMAP_MODES["OFF"] = 0] = "OFF";
    MIPMAP_MODES[MIPMAP_MODES["POW2"] = 1] = "POW2";
    MIPMAP_MODES[MIPMAP_MODES["ON"] = 2] = "ON";
    MIPMAP_MODES[MIPMAP_MODES["ON_MANUAL"] = 3] = "ON_MANUAL";
})(MIPMAP_MODES || (MIPMAP_MODES = {}));
/**
 * How to treat textures with premultiplied alpha
 * @name ALPHA_MODES
 * @memberof PIXI
 * @static
 * @enum {number}
 * @property {number} NO_PREMULTIPLIED_ALPHA - Source is not premultiplied, leave it like that.
 *  Option for compressed and data textures that are created from typed arrays.
 * @property {number} PREMULTIPLY_ON_UPLOAD - Source is not premultiplied, premultiply on upload.
 *  Default option, used for all loaded images.
 * @property {number} PREMULTIPLIED_ALPHA - Source is already premultiplied
 *  Example: spine atlases with `_pma` suffix.
 * @property {number} NPM - Alias for NO_PREMULTIPLIED_ALPHA.
 * @property {number} UNPACK - Default option, alias for PREMULTIPLY_ON_UPLOAD.
 * @property {number} PMA - Alias for PREMULTIPLIED_ALPHA.
 */
var ALPHA_MODES;
(function (ALPHA_MODES) {
    ALPHA_MODES[ALPHA_MODES["NPM"] = 0] = "NPM";
    ALPHA_MODES[ALPHA_MODES["UNPACK"] = 1] = "UNPACK";
    ALPHA_MODES[ALPHA_MODES["PMA"] = 2] = "PMA";
    ALPHA_MODES[ALPHA_MODES["NO_PREMULTIPLIED_ALPHA"] = 0] = "NO_PREMULTIPLIED_ALPHA";
    ALPHA_MODES[ALPHA_MODES["PREMULTIPLY_ON_UPLOAD"] = 1] = "PREMULTIPLY_ON_UPLOAD";
    ALPHA_MODES[ALPHA_MODES["PREMULTIPLY_ALPHA"] = 2] = "PREMULTIPLY_ALPHA";
    ALPHA_MODES[ALPHA_MODES["PREMULTIPLIED_ALPHA"] = 2] = "PREMULTIPLIED_ALPHA";
})(ALPHA_MODES || (ALPHA_MODES = {}));
/**
 * Configure whether filter textures are cleared after binding.
 *
 * Filter textures need not be cleared if the filter does not use pixel blending. {@link CLEAR_MODES.BLIT} will detect
 * this and skip clearing as an optimization.
 * @name CLEAR_MODES
 * @memberof PIXI
 * @static
 * @enum {number}
 * @property {number} BLEND - Do not clear the filter texture. The filter's output will blend on top of the output texture.
 * @property {number} CLEAR - Always clear the filter texture.
 * @property {number} BLIT - Clear only if {@link FilterSystem.forceClear} is set or if the filter uses pixel blending.
 * @property {number} NO - Alias for BLEND, same as `false` in earlier versions
 * @property {number} YES - Alias for CLEAR, same as `true` in earlier versions
 * @property {number} AUTO - Alias for BLIT
 */
var CLEAR_MODES;
(function (CLEAR_MODES) {
    CLEAR_MODES[CLEAR_MODES["NO"] = 0] = "NO";
    CLEAR_MODES[CLEAR_MODES["YES"] = 1] = "YES";
    CLEAR_MODES[CLEAR_MODES["AUTO"] = 2] = "AUTO";
    CLEAR_MODES[CLEAR_MODES["BLEND"] = 0] = "BLEND";
    CLEAR_MODES[CLEAR_MODES["CLEAR"] = 1] = "CLEAR";
    CLEAR_MODES[CLEAR_MODES["BLIT"] = 2] = "BLIT";
})(CLEAR_MODES || (CLEAR_MODES = {}));
/**
 * The gc modes that are supported by pixi.
 *
 * The {@link PIXI.settings.GC_MODE} Garbage Collection mode for PixiJS textures is AUTO
 * If set to GC_MODE, the renderer will occasionally check textures usage. If they are not
 * used for a specified period of time they will be removed from the GPU. They will of course
 * be uploaded again when they are required. This is a silent behind the scenes process that
 * should ensure that the GPU does not  get filled up.
 *
 * Handy for mobile devices!
 * This property only affects WebGL.
 * @name GC_MODES
 * @enum {number}
 * @static
 * @memberof PIXI
 * @property {number} AUTO - Garbage collection will happen periodically automatically
 * @property {number} MANUAL - Garbage collection will need to be called manually
 */
var GC_MODES;
(function (GC_MODES) {
    GC_MODES[GC_MODES["AUTO"] = 0] = "AUTO";
    GC_MODES[GC_MODES["MANUAL"] = 1] = "MANUAL";
})(GC_MODES || (GC_MODES = {}));
/**
 * Constants that specify float precision in shaders.
 * @name PRECISION
 * @memberof PIXI
 * @constant
 * @static
 * @enum {string}
 * @property {string} [LOW='lowp'] -
 * @property {string} [MEDIUM='mediump'] -
 * @property {string} [HIGH='highp'] -
 */
var PRECISION;
(function (PRECISION) {
    PRECISION["LOW"] = "lowp";
    PRECISION["MEDIUM"] = "mediump";
    PRECISION["HIGH"] = "highp";
})(PRECISION || (PRECISION = {}));
/**
 * Constants for mask implementations.
 * We use `type` suffix because it leads to very different behaviours
 * @name MASK_TYPES
 * @memberof PIXI
 * @static
 * @enum {number}
 * @property {number} NONE - Mask is ignored
 * @property {number} SCISSOR - Scissor mask, rectangle on screen, cheap
 * @property {number} STENCIL - Stencil mask, 1-bit, medium, works only if renderer supports stencil
 * @property {number} SPRITE - Mask that uses SpriteMaskFilter, uses temporary RenderTexture
 * @property {number} COLOR - Color mask (RGBA)
 */
var MASK_TYPES;
(function (MASK_TYPES) {
    MASK_TYPES[MASK_TYPES["NONE"] = 0] = "NONE";
    MASK_TYPES[MASK_TYPES["SCISSOR"] = 1] = "SCISSOR";
    MASK_TYPES[MASK_TYPES["STENCIL"] = 2] = "STENCIL";
    MASK_TYPES[MASK_TYPES["SPRITE"] = 3] = "SPRITE";
    MASK_TYPES[MASK_TYPES["COLOR"] = 4] = "COLOR";
})(MASK_TYPES || (MASK_TYPES = {}));
/**
 * Bitwise OR of masks that indicate the color channels that are rendered to.
 * @static
 * @memberof PIXI
 * @name COLOR_MASK_BITS
 * @enum {number}
 * @property {number} RED - Red channel.
 * @property {number} GREEN - Green channel
 * @property {number} BLUE - Blue channel.
 * @property {number} ALPHA - Alpha channel.
 */
var COLOR_MASK_BITS;
(function (COLOR_MASK_BITS) {
    COLOR_MASK_BITS[COLOR_MASK_BITS["RED"] = 1] = "RED";
    COLOR_MASK_BITS[COLOR_MASK_BITS["GREEN"] = 2] = "GREEN";
    COLOR_MASK_BITS[COLOR_MASK_BITS["BLUE"] = 4] = "BLUE";
    COLOR_MASK_BITS[COLOR_MASK_BITS["ALPHA"] = 8] = "ALPHA";
})(COLOR_MASK_BITS || (COLOR_MASK_BITS = {}));
/**
 * Constants for multi-sampling antialiasing.
 * @see PIXI.Framebuffer#multisample
 * @name MSAA_QUALITY
 * @memberof PIXI
 * @static
 * @enum {number}
 * @property {number} NONE - No multisampling for this renderTexture
 * @property {number} LOW - Try 2 samples
 * @property {number} MEDIUM - Try 4 samples
 * @property {number} HIGH - Try 8 samples
 */
var MSAA_QUALITY;
(function (MSAA_QUALITY) {
    MSAA_QUALITY[MSAA_QUALITY["NONE"] = 0] = "NONE";
    MSAA_QUALITY[MSAA_QUALITY["LOW"] = 2] = "LOW";
    MSAA_QUALITY[MSAA_QUALITY["MEDIUM"] = 4] = "MEDIUM";
    MSAA_QUALITY[MSAA_QUALITY["HIGH"] = 8] = "HIGH";
})(MSAA_QUALITY || (MSAA_QUALITY = {}));
/**
 * Constants for various buffer types in Pixi
 * @see PIXI.BUFFER_TYPE
 * @name BUFFER_TYPE
 * @memberof PIXI
 * @static
 * @enum {number}
 * @property {number} ELEMENT_ARRAY_BUFFER - buffer type for using as an index buffer
 * @property {number} ARRAY_BUFFER - buffer type for using attribute data
 * @property {number} UNIFORM_BUFFER - the buffer type is for uniform buffer objects
 */
var BUFFER_TYPE;
(function (BUFFER_TYPE) {
    BUFFER_TYPE[BUFFER_TYPE["ELEMENT_ARRAY_BUFFER"] = 34963] = "ELEMENT_ARRAY_BUFFER";
    BUFFER_TYPE[BUFFER_TYPE["ARRAY_BUFFER"] = 34962] = "ARRAY_BUFFER";
    // NOT YET SUPPORTED
    BUFFER_TYPE[BUFFER_TYPE["UNIFORM_BUFFER"] = 35345] = "UNIFORM_BUFFER";
})(BUFFER_TYPE || (BUFFER_TYPE = {}));

function sortChildren(a, b) {
    if (a.zIndex === b.zIndex) {
        return a._lastSortedIndex - b._lastSortedIndex;
    }
    return a.zIndex - b.zIndex;
}
/**
 * Container is a general-purpose display object that holds children. It also adds built-in support for advanced
 * rendering features like masking and filtering.
 *
 * It is the base class of all display objects that act as a container for other objects, including Graphics
 * and Sprite.
 *
 * ```js
 * import { BlurFilter } from '@pixi/filter-blur';
 * import { Container } from '@pixi/display';
 * import { Graphics } from '@pixi/graphics';
 * import { Sprite } from '@pixi/sprite';
 *
 * let container = new Container();
 * let sprite = Sprite.from("https://s3-us-west-2.amazonaws.com/s.cdpn.io/693612/IaUrttj.png");
 *
 * sprite.width = 512;
 * sprite.height = 512;
 *
 * // Adds a sprite as a child to this container. As a result, the sprite will be rendered whenever the container
 * // is rendered.
 * container.addChild(sprite);
 *
 * // Blurs whatever is rendered by the container
 * container.filters = [new BlurFilter()];
 *
 * // Only the contents within a circle at the center should be rendered onto the screen.
 * container.mask = new Graphics()
 *  .beginFill(0xffffff)
 *  .drawCircle(sprite.width / 2, sprite.height / 2, Math.min(sprite.width, sprite.height) / 2)
 *  .endFill();
 * ```
 * @memberof PIXI
 */
var Container = /** @class */ (function (_super) {
    __extends(Container, _super);
    function Container() {
        var _this = _super.call(this) || this;
        _this.children = [];
        _this.sortableChildren = settings.settings.SORTABLE_CHILDREN;
        _this.sortDirty = false;
        return _this;
        /**
         * Fired when a DisplayObject is added to this Container.
         * @event PIXI.Container#childAdded
         * @param {PIXI.DisplayObject} child - The child added to the Container.
         * @param {PIXI.Container} container - The container that added the child.
         * @param {number} index - The children's index of the added child.
         */
        /**
         * Fired when a DisplayObject is removed from this Container.
         * @event PIXI.DisplayObject#childRemoved
         * @param {PIXI.DisplayObject} child - The child removed from the Container.
         * @param {PIXI.Container} container - The container that removed the child.
         * @param {number} index - The former children's index of the removed child
         */
    }
    /**
     * Overridable method that can be used by Container subclasses whenever the children array is modified.
     * @param _length
     */
    Container.prototype.onChildrenChange = function (_length) {
        /* empty */
    };
    /**
     * Adds one or more children to the container.
     *
     * Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`
     * @param {...PIXI.DisplayObject} children - The DisplayObject(s) to add to the container
     * @returns {PIXI.DisplayObject} - The first child that was added.
     */
    Container.prototype.addChild = function () {
        var arguments$1 = arguments;

        var children = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            children[_i] = arguments$1[_i];
        }
        // if there is only one argument we can bypass looping through the them
        if (children.length > 1) {
            // loop through the array and add all children
            for (var i = 0; i < children.length; i++) {
                // eslint-disable-next-line prefer-rest-params
                this.addChild(children[i]);
            }
        }
        else {
            var child = children[0];
            // if the child has a parent then lets remove it as PixiJS objects can only exist in one place
            if (child.parent) {
                child.parent.removeChild(child);
            }
            child.parent = this;
            this.sortDirty = true;
            // ensure child transform will be recalculated
            child.transform._parentID = -1;
            this.children.push(child);
            // ensure bounds will be recalculated
            this._boundsID++;
            // TODO - lets either do all callbacks or all events.. not both!
            this.onChildrenChange(this.children.length - 1);
            this.emit('childAdded', child, this, this.children.length - 1);
            child.emit('added', this);
        }
        return children[0];
    };
    /**
     * Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown
     * @param {PIXI.DisplayObject} child - The child to add
     * @param {number} index - The index to place the child in
     * @returns {PIXI.DisplayObject} The child that was added.
     */
    Container.prototype.addChildAt = function (child, index) {
        if (index < 0 || index > this.children.length) {
            throw new Error(child + "addChildAt: The index " + index + " supplied is out of bounds " + this.children.length);
        }
        if (child.parent) {
            child.parent.removeChild(child);
        }
        child.parent = this;
        this.sortDirty = true;
        // ensure child transform will be recalculated
        child.transform._parentID = -1;
        this.children.splice(index, 0, child);
        // ensure bounds will be recalculated
        this._boundsID++;
        // TODO - lets either do all callbacks or all events.. not both!
        this.onChildrenChange(index);
        child.emit('added', this);
        this.emit('childAdded', child, this, index);
        return child;
    };
    /**
     * Swaps the position of 2 Display Objects within this container.
     * @param child - First display object to swap
     * @param child2 - Second display object to swap
     */
    Container.prototype.swapChildren = function (child, child2) {
        if (child === child2) {
            return;
        }
        var index1 = this.getChildIndex(child);
        var index2 = this.getChildIndex(child2);
        this.children[index1] = child2;
        this.children[index2] = child;
        this.onChildrenChange(index1 < index2 ? index1 : index2);
    };
    /**
     * Returns the index position of a child DisplayObject instance
     * @param child - The DisplayObject instance to identify
     * @returns - The index position of the child display object to identify
     */
    Container.prototype.getChildIndex = function (child) {
        var index = this.children.indexOf(child);
        if (index === -1) {
            throw new Error('The supplied DisplayObject must be a child of the caller');
        }
        return index;
    };
    /**
     * Changes the position of an existing child in the display object container
     * @param child - The child DisplayObject instance for which you want to change the index number
     * @param index - The resulting index number for the child display object
     */
    Container.prototype.setChildIndex = function (child, index) {
        if (index < 0 || index >= this.children.length) {
            throw new Error("The index " + index + " supplied is out of bounds " + this.children.length);
        }
        var currentIndex = this.getChildIndex(child);
        utils.removeItems(this.children, currentIndex, 1); // remove from old position
        this.children.splice(index, 0, child); // add at new position
        this.onChildrenChange(index);
    };
    /**
     * Returns the child at the specified index
     * @param index - The index to get the child at
     * @returns - The child at the given index, if any.
     */
    Container.prototype.getChildAt = function (index) {
        if (index < 0 || index >= this.children.length) {
            throw new Error("getChildAt: Index (" + index + ") does not exist.");
        }
        return this.children[index];
    };
    /**
     * Removes one or more children from the container.
     * @param {...PIXI.DisplayObject} children - The DisplayObject(s) to remove
     * @returns {PIXI.DisplayObject} The first child that was removed.
     */
    Container.prototype.removeChild = function () {
        var arguments$1 = arguments;

        var children = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            children[_i] = arguments$1[_i];
        }
        // if there is only one argument we can bypass looping through the them
        if (children.length > 1) {
            // loop through the arguments property and remove all children
            for (var i = 0; i < children.length; i++) {
                this.removeChild(children[i]);
            }
        }
        else {
            var child = children[0];
            var index = this.children.indexOf(child);
            if (index === -1)
                { return null; }
            child.parent = null;
            // ensure child transform will be recalculated
            child.transform._parentID = -1;
            utils.removeItems(this.children, index, 1);
            // ensure bounds will be recalculated
            this._boundsID++;
            // TODO - lets either do all callbacks or all events.. not both!
            this.onChildrenChange(index);
            child.emit('removed', this);
            this.emit('childRemoved', child, this, index);
        }
        return children[0];
    };
    /**
     * Removes a child from the specified index position.
     * @param index - The index to get the child from
     * @returns The child that was removed.
     */
    Container.prototype.removeChildAt = function (index) {
        var child = this.getChildAt(index);
        // ensure child transform will be recalculated..
        child.parent = null;
        child.transform._parentID = -1;
        utils.removeItems(this.children, index, 1);
        // ensure bounds will be recalculated
        this._boundsID++;
        // TODO - lets either do all callbacks or all events.. not both!
        this.onChildrenChange(index);
        child.emit('removed', this);
        this.emit('childRemoved', child, this, index);
        return child;
    };
    /**
     * Removes all children from this container that are within the begin and end indexes.
     * @param beginIndex - The beginning position.
     * @param endIndex - The ending position. Default value is size of the container.
     * @returns - List of removed children
     */
    Container.prototype.removeChildren = function (beginIndex, endIndex) {
        if (beginIndex === void 0) { beginIndex = 0; }
        if (endIndex === void 0) { endIndex = this.children.length; }
        var begin = beginIndex;
        var end = endIndex;
        var range = end - begin;
        var removed;
        if (range > 0 && range <= end) {
            removed = this.children.splice(begin, range);
            for (var i = 0; i < removed.length; ++i) {
                removed[i].parent = null;
                if (removed[i].transform) {
                    removed[i].transform._parentID = -1;
                }
            }
            this._boundsID++;
            this.onChildrenChange(beginIndex);
            for (var i = 0; i < removed.length; ++i) {
                removed[i].emit('removed', this);
                this.emit('childRemoved', removed[i], this, i);
            }
            return removed;
        }
        else if (range === 0 && this.children.length === 0) {
            return [];
        }
        throw new RangeError('removeChildren: numeric values are outside the acceptable range.');
    };
    /** Sorts children by zIndex. Previous order is maintained for 2 children with the same zIndex. */
    Container.prototype.sortChildren = function () {
        var sortRequired = false;
        for (var i = 0, j = this.children.length; i < j; ++i) {
            var child = this.children[i];
            child._lastSortedIndex = i;
            if (!sortRequired && child.zIndex !== 0) {
                sortRequired = true;
            }
        }
        if (sortRequired && this.children.length > 1) {
            this.children.sort(sortChildren);
        }
        this.sortDirty = false;
    };
    /** Updates the transform on all children of this container for rendering. */
    Container.prototype.updateTransform = function () {
        if (this.sortableChildren && this.sortDirty) {
            this.sortChildren();
        }
        this._boundsID++;
        this.transform.updateTransform(this.parent.transform);
        // TODO: check render flags, how to process stuff here
        this.worldAlpha = this.alpha * this.parent.worldAlpha;
        for (var i = 0, j = this.children.length; i < j; ++i) {
            var child = this.children[i];
            if (child.visible) {
                child.updateTransform();
            }
        }
    };
    /**
     * Recalculates the bounds of the container.
     *
     * This implementation will automatically fit the children's bounds into the calculation. Each child's bounds
     * is limited to its mask's bounds or filterArea, if any is applied.
     */
    Container.prototype.calculateBounds = function () {
        this._bounds.clear();
        this._calculateBounds();
        for (var i = 0; i < this.children.length; i++) {
            var child = this.children[i];
            if (!child.visible || !child.renderable) {
                continue;
            }
            child.calculateBounds();
            // TODO: filter+mask, need to mask both somehow
            if (child._mask) {
                var maskObject = (child._mask.isMaskData
                    ? child._mask.maskObject : child._mask);
                if (maskObject) {
                    maskObject.calculateBounds();
                    this._bounds.addBoundsMask(child._bounds, maskObject._bounds);
                }
                else {
                    this._bounds.addBounds(child._bounds);
                }
            }
            else if (child.filterArea) {
                this._bounds.addBoundsArea(child._bounds, child.filterArea);
            }
            else {
                this._bounds.addBounds(child._bounds);
            }
        }
        this._bounds.updateID = this._boundsID;
    };
    /**
     * Retrieves the local bounds of the displayObject as a rectangle object.
     *
     * Calling `getLocalBounds` may invalidate the `_bounds` of the whole subtree below. If using it inside a render()
     * call, it is advised to call `getBounds()` immediately after to recalculate the world bounds of the subtree.
     * @param rect - Optional rectangle to store the result of the bounds calculation.
     * @param skipChildrenUpdate - Setting to `true` will stop re-calculation of children transforms,
     *  it was default behaviour of pixi 4.0-5.2 and caused many problems to users.
     * @returns - The rectangular bounding area.
     */
    Container.prototype.getLocalBounds = function (rect, skipChildrenUpdate) {
        if (skipChildrenUpdate === void 0) { skipChildrenUpdate = false; }
        var result = _super.prototype.getLocalBounds.call(this, rect);
        if (!skipChildrenUpdate) {
            for (var i = 0, j = this.children.length; i < j; ++i) {
                var child = this.children[i];
                if (child.visible) {
                    child.updateTransform();
                }
            }
        }
        return result;
    };
    /**
     * Recalculates the content bounds of this object. This should be overriden to
     * calculate the bounds of this specific object (not including children).
     * @protected
     */
    Container.prototype._calculateBounds = function () {
        // FILL IN//
    };
    /**
     * Renders this object and its children with culling.
     * @protected
     * @param {PIXI.Renderer} renderer - The renderer
     */
    Container.prototype._renderWithCulling = function (renderer) {
        var sourceFrame = renderer.renderTexture.sourceFrame;
        // If the source frame is empty, stop rendering.
        if (!(sourceFrame.width > 0 && sourceFrame.height > 0)) {
            return;
        }
        // Render the content of the container only if its bounds intersect with the source frame.
        // All filters are on the stack at this point, and the filter source frame is bound:
        // therefore, even if the bounds to non intersect the filter frame, the filter
        // is still applied and any filter padding that is in the frame is rendered correctly.
        var bounds;
        var transform;
        // If cullArea is set, we use this rectangle instead of the bounds of the object. The cullArea
        // rectangle must completely contain the container and its children including filter padding.
        if (this.cullArea) {
            bounds = this.cullArea;
            transform = this.worldTransform;
        }
        // If the container doesn't override _render, we can skip the bounds calculation and intersection test.
        else if (this._render !== Container.prototype._render) {
            bounds = this.getBounds(true);
        }
        // Render the container if the source frame intersects the bounds.
        if (bounds && sourceFrame.intersects(bounds, transform)) {
            this._render(renderer);
        }
        // If the bounds are defined by cullArea and do not intersect with the source frame, stop rendering.
        else if (this.cullArea) {
            return;
        }
        // Unless cullArea is set, we cannot skip the children if the bounds of the container do not intersect
        // the source frame, because the children might have filters with nonzero padding, which may intersect
        // with the source frame while the bounds do not: filter padding is not included in the bounds.
        // If cullArea is not set, render the children with culling temporarily enabled so that they are not rendered
        // if they are out of frame; otherwise, render the children normally.
        for (var i = 0, j = this.children.length; i < j; ++i) {
            var child = this.children[i];
            var childCullable = child.cullable;
            child.cullable = childCullable || !this.cullArea;
            child.render(renderer);
            child.cullable = childCullable;
        }
    };
    /**
     * Renders the object using the WebGL renderer.
     *
     * The [_render]{@link PIXI.Container#_render} method is be overriden for rendering the contents of the
     * container itself. This `render` method will invoke it, and also invoke the `render` methods of all
     * children afterward.
     *
     * If `renderable` or `visible` is false or if `worldAlpha` is not positive or if `cullable` is true and
     * the bounds of this object are out of frame, this implementation will entirely skip rendering.
     * See {@link PIXI.DisplayObject} for choosing between `renderable` or `visible`. Generally,
     * setting alpha to zero is not recommended for purely skipping rendering.
     *
     * When your scene becomes large (especially when it is larger than can be viewed in a single screen), it is
     * advised to employ **culling** to automatically skip rendering objects outside of the current screen.
     * See [cullable]{@link PIXI.DisplayObject#cullable} and [cullArea]{@link PIXI.DisplayObject#cullArea}.
     * Other culling methods might be better suited for a large number static objects; see
     * [@pixi-essentials/cull]{@link https://www.npmjs.com/package/@pixi-essentials/cull} and
     * [pixi-cull]{@link https://www.npmjs.com/package/pixi-cull}.
     *
     * The [renderAdvanced]{@link PIXI.Container#renderAdvanced} method is internally used when when masking or
     * filtering is applied on a container. This does, however, break batching and can affect performance when
     * masking and filtering is applied extensively throughout the scene graph.
     * @param renderer - The renderer
     */
    Container.prototype.render = function (renderer) {
        // if the object is not visible or the alpha is 0 then no need to render this element
        if (!this.visible || this.worldAlpha <= 0 || !this.renderable) {
            return;
        }
        // do a quick check to see if this element has a mask or a filter.
        if (this._mask || (this.filters && this.filters.length)) {
            this.renderAdvanced(renderer);
        }
        else if (this.cullable) {
            this._renderWithCulling(renderer);
        }
        else {
            this._render(renderer);
            for (var i = 0, j = this.children.length; i < j; ++i) {
                this.children[i].render(renderer);
            }
        }
    };
    /**
     * Render the object using the WebGL renderer and advanced features.
     * @param renderer - The renderer
     */
    Container.prototype.renderAdvanced = function (renderer) {
        var filters = this.filters;
        var mask = this._mask;
        // push filter first as we need to ensure the stencil buffer is correct for any masking
        if (filters) {
            if (!this._enabledFilters) {
                this._enabledFilters = [];
            }
            this._enabledFilters.length = 0;
            for (var i = 0; i < filters.length; i++) {
                if (filters[i].enabled) {
                    this._enabledFilters.push(filters[i]);
                }
            }
        }
        var flush = (filters && this._enabledFilters && this._enabledFilters.length)
            || (mask && (!mask.isMaskData
                || (mask.enabled && (mask.autoDetect || mask.type !== MASK_TYPES.NONE))));
        if (flush) {
            renderer.batch.flush();
        }
        if (filters && this._enabledFilters && this._enabledFilters.length) {
            renderer.filter.push(this, this._enabledFilters);
        }
        if (mask) {
            renderer.mask.push(this, this._mask);
        }
        if (this.cullable) {
            this._renderWithCulling(renderer);
        }
        else {
            this._render(renderer);
            for (var i = 0, j = this.children.length; i < j; ++i) {
                this.children[i].render(renderer);
            }
        }
        if (flush) {
            renderer.batch.flush();
        }
        if (mask) {
            renderer.mask.pop(this);
        }
        if (filters && this._enabledFilters && this._enabledFilters.length) {
            renderer.filter.pop();
        }
    };
    /**
     * To be overridden by the subclasses.
     * @param _renderer - The renderer
     */
    Container.prototype._render = function (_renderer) {
        // this is where content itself gets rendered...
    };
    /**
     * Removes all internal references and listeners as well as removes children from the display list.
     * Do not use a Container after calling `destroy`.
     * @param options - Options parameter. A boolean will act as if all options
     *  have been set to that value
     * @param {boolean} [options.children=false] - if set to true, all the children will have their destroy
     *  method called as well. 'options' will be passed on to those calls.
     * @param {boolean} [options.texture=false] - Only used for child Sprites if options.children is set to true
     *  Should it destroy the texture of the child sprite
     * @param {boolean} [options.baseTexture=false] - Only used for child Sprites if options.children is set to true
     *  Should it destroy the base texture of the child sprite
     */
    Container.prototype.destroy = function (options) {
        _super.prototype.destroy.call(this);
        this.sortDirty = false;
        var destroyChildren = typeof options === 'boolean' ? options : options && options.children;
        var oldChildren = this.removeChildren(0, this.children.length);
        if (destroyChildren) {
            for (var i = 0; i < oldChildren.length; ++i) {
                oldChildren[i].destroy(options);
            }
        }
    };
    Object.defineProperty(Container.prototype, "width", {
        /** The width of the Container, setting this will actually modify the scale to achieve the value set. */
        get: function () {
            return this.scale.x * this.getLocalBounds().width;
        },
        set: function (value) {
            var width = this.getLocalBounds().width;
            if (width !== 0) {
                this.scale.x = value / width;
            }
            else {
                this.scale.x = 1;
            }
            this._width = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Container.prototype, "height", {
        /** The height of the Container, setting this will actually modify the scale to achieve the value set. */
        get: function () {
            return this.scale.y * this.getLocalBounds().height;
        },
        set: function (value) {
            var height = this.getLocalBounds().height;
            if (height !== 0) {
                this.scale.y = value / height;
            }
            else {
                this.scale.y = 1;
            }
            this._height = value;
        },
        enumerable: false,
        configurable: true
    });
    return Container;
}(DisplayObject));
/**
 * Container default updateTransform, does update children of container.
 * Will crash if there's no parent element.
 * @memberof PIXI.Container#
 * @method containerUpdateTransform
 */
Container.prototype.containerUpdateTransform = Container.prototype.updateTransform;

exports.Bounds = Bounds;
exports.Container = Container;
exports.DisplayObject = DisplayObject;
exports.TemporaryDisplayObject = TemporaryDisplayObject;
//# sourceMappingURL=display.js.map
