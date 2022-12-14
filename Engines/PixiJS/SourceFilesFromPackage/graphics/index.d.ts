/// <reference path="./global.d.ts" />

import { BatchDrawCall } from '@pixi/core';
import type { BatchDrawCall as BatchDrawCall_2 } from '@pixi/core/';
import { BatchGeometry } from '@pixi/core';
import { BLEND_MODES } from '@pixi/constants';
import { Bounds } from '@pixi/display';
import type { Circle } from '@pixi/math';
import { Container } from '@pixi/display';
import type { Ellipse } from '@pixi/math';
import type { IDestroyOptions } from '@pixi/display';
import type { IPointData } from '@pixi/math';
import type { IShape } from '@pixi/math';
import { Matrix } from '@pixi/math';
import { Point } from '@pixi/math';
import { Polygon } from '@pixi/math';
import type { Rectangle } from '@pixi/math';
import type { Renderer } from '@pixi/core';
import type { RoundedRectangle } from '@pixi/math';
import { Shader } from '@pixi/core';
import type { SHAPES } from '@pixi/math';
import { Texture } from '@pixi/core';

/**
 * Utilities for arc curves.
 * @private
 */
declare class ArcUtils {
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
    static curveTo(x1: number, y1: number, x2: number, y2: number, radius: number, points: Array<number>): IArcLikeShape;
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
    static arc(_startX: number, _startY: number, cx: number, cy: number, radius: number, startAngle: number, endAngle: number, _anticlockwise: boolean, points: Array<number>): void;
}

/**
 * A structure to hold interim batch objects for Graphics.
 * @memberof PIXI.graphicsUtils
 */
declare class BatchPart {
    style: LineStyle | FillStyle;
    start: number;
    size: number;
    attribStart: number;
    attribSize: number;
    constructor();
    /**
     * Begin batch part.
     * @param style
     * @param startIndex
     * @param attribStart
     */
    begin(style: LineStyle | FillStyle, startIndex: number, attribStart: number): void;
    /**
     * End batch part.
     * @param endIndex
     * @param endAttrib
     */
    end(endIndex: number, endAttrib: number): void;
    reset(): void;
}

/**
 * Utilities for bezier curves
 * @private
 */
declare class BezierUtils {
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
    static curveLength(fromX: number, fromY: number, cpX: number, cpY: number, cpX2: number, cpY2: number, toX: number, toY: number): number;
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
    static curveTo(cpX: number, cpY: number, cpX2: number, cpY2: number, toX: number, toY: number, points: Array<number>): void;
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
declare function buildLine(graphicsData: GraphicsData, graphicsGeometry: GraphicsGeometry): void;

/**
 * Fill style object for Graphics.
 * @memberof PIXI
 */
export declare class FillStyle {
    /**
     * The hex color value used when coloring the Graphics object.
     * @default 0xFFFFFF
     */
    color: number;
    /** The alpha value used when filling the Graphics object. */
    alpha: number;
    /**
     * The texture to be used for the fill.
     * @default 0
     */
    texture: Texture;
    /**
     * The transform applied to the texture.
     * @default null
     */
    matrix: Matrix;
    /** If the current fill is visible. */
    visible: boolean;
    constructor();
    /** Clones the object */
    clone(): FillStyle;
    /** Reset */
    reset(): void;
    /** Destroy and don't use after this. */
    destroy(): void;
}

export declare interface Graphics extends GlobalMixins.Graphics, Container {
}

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
export declare class Graphics extends Container {
    /**
     * New rendering behavior for rounded rectangles: circular arcs instead of quadratic bezier curves.
     * In the next major release, we'll enable this by default.
     */
    static nextRoundedRectBehavior: boolean;
    /**
     * Temporary point to use for containsPoint.
     * @private
     */
    static _TEMP_POINT: Point;
    /**
     * Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
     * Can be shared between multiple Graphics objects.
     */
    shader: Shader;
    /** Renderer plugin for batching */
    pluginName: string;
    /**
     * Current path
     * @readonly
     */
    currentPath: Polygon;
    /** A collections of batches! These can be drawn by the renderer batch system. */
    protected batches: Array<IGraphicsBatchElement>;
    /** Update dirty for limiting calculating tints for batches. */
    protected batchTint: number;
    /** Update dirty for limiting calculating batches.*/
    protected batchDirty: number;
    /** Copy of the object vertex data. */
    protected vertexData: Float32Array;
    /** Current fill style. */
    protected _fillStyle: FillStyle;
    /** Current line style. */
    protected _lineStyle: LineStyle;
    /** Current shape transform matrix. */
    protected _matrix: Matrix;
    /** Current hole mode is enabled. */
    protected _holeMode: boolean;
    protected _transformID: number;
    protected _tint: number;
    /**
     * Represents the WebGL state the Graphics required to render, excludes shader and geometry. E.g.,
     * blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
     */
    private state;
    private _geometry;
    /**
     * Includes vertex positions, face indices, normals, colors, UVs, and
     * custom attributes within buffers, reducing the cost of passing all
     * this data to the GPU. Can be shared between multiple Mesh or Graphics objects.
     * @readonly
     */
    get geometry(): GraphicsGeometry;
    /**
     * @param geometry - Geometry to use, if omitted will create a new GraphicsGeometry instance.
     */
    constructor(geometry?: GraphicsGeometry);
    /**
     * Creates a new Graphics object with the same values as this one.
     * Note that only the geometry of the object is cloned, not its transform (position,scale,etc)
     * @returns - A clone of the graphics object
     */
    clone(): Graphics;
    /**
     * The blend mode to be applied to the graphic shape. Apply a value of
     * `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.  Note that, since each
     * primitive in the GraphicsGeometry list is rendered sequentially, modes
     * such as `PIXI.BLEND_MODES.ADD` and `PIXI.BLEND_MODES.MULTIPLY` will
     * be applied per-primitive.
     * @default PIXI.BLEND_MODES.NORMAL
     */
    set blendMode(value: BLEND_MODES);
    get blendMode(): BLEND_MODES;
    /**
     * The tint applied to each graphic shape. This is a hex value. A value of
     * 0xFFFFFF will remove any tint effect.
     * @default 0xFFFFFF
     */
    get tint(): number;
    set tint(value: number);
    /**
     * The current fill style.
     * @readonly
     */
    get fill(): FillStyle;
    /**
     * The current line style.
     * @readonly
     */
    get line(): LineStyle;
    /**
     * Specifies the line style used for subsequent calls to Graphics methods such as the lineTo()
     * method or the drawCircle() method.
     * @param [width=0] - width of the line to draw, will update the objects stored style
     * @param [color=0x0] - color of the line to draw, will update the objects stored style
     * @param [alpha=1] - alpha of the line to draw, will update the objects stored style
     * @param [alignment=0.5] - alignment of the line to draw, (0 = inner, 0.5 = middle, 1 = outer).
     *        WebGL only.
     * @param [native=false] - If true the lines will be draw using LINES instead of TRIANGLE_STRIP
     * @returns - This Graphics object. Good for chaining method calls
     */
    lineStyle(width: number, color?: number, alpha?: number, alignment?: number, native?: boolean): this;
    /**
     * Specifies the line style used for subsequent calls to Graphics methods such as the lineTo()
     * method or the drawCircle() method.
     * @param options - Line style options
     * @param {number} [options.width=0] - width of the line to draw, will update the objects stored style
     * @param {number} [options.color=0x0] - color of the line to draw, will update the objects stored style
     * @param {number} [options.alpha=1] - alpha of the line to draw, will update the objects stored style
     * @param {number} [options.alignment=0.5] - alignment of the line to draw, (0 = inner, 0.5 = middle, 1 = outer).
     *        WebGL only.
     * @param {boolean} [options.native=false] - If true the lines will be draw using LINES instead of TRIANGLE_STRIP
     * @param {PIXI.LINE_CAP}[options.cap=PIXI.LINE_CAP.BUTT] - line cap style
     * @param {PIXI.LINE_JOIN}[options.join=PIXI.LINE_JOIN.MITER] - line join style
     * @param {number}[options.miterLimit=10] - miter limit ratio
     * @returns {PIXI.Graphics} This Graphics object. Good for chaining method calls
     */
    lineStyle(options?: ILineStyleOptions): this;
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
    lineTextureStyle(options?: ILineStyleOptions): this;
    /**
     * Start a polygon object internally.
     * @protected
     */
    protected startPoly(): void;
    /**
     * Finish the polygon object.
     * @protected
     */
    finishPoly(): void;
    /**
     * Moves the current drawing position to x, y.
     * @param x - the X coordinate to move to
     * @param y - the Y coordinate to move to
     * @returns - This Graphics object. Good for chaining method calls
     */
    moveTo(x: number, y: number): this;
    /**
     * Draws a line using the current line style from the current drawing position to (x, y);
     * The current drawing position is then set to (x, y).
     * @param x - the X coordinate to draw to
     * @param y - the Y coordinate to draw to
     * @returns - This Graphics object. Good for chaining method calls
     */
    lineTo(x: number, y: number): this;
    /**
     * Initialize the curve
     * @param x
     * @param y
     */
    protected _initCurve(x?: number, y?: number): void;
    /**
     * Calculate the points for a quadratic bezier curve and then draws it.
     * Based on: https://stackoverflow.com/questions/785097/how-do-i-implement-a-bezier-curve-in-c
     * @param cpX - Control point x
     * @param cpY - Control point y
     * @param toX - Destination point x
     * @param toY - Destination point y
     * @returns - This Graphics object. Good for chaining method calls
     */
    quadraticCurveTo(cpX: number, cpY: number, toX: number, toY: number): this;
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
    bezierCurveTo(cpX: number, cpY: number, cpX2: number, cpY2: number, toX: number, toY: number): this;
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
    arcTo(x1: number, y1: number, x2: number, y2: number, radius: number): this;
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
    arc(cx: number, cy: number, radius: number, startAngle: number, endAngle: number, anticlockwise?: boolean): this;
    /**
     * Specifies a simple one-color fill that subsequent calls to other Graphics methods
     * (such as lineTo() or drawCircle()) use when drawing.
     * @param color - the color of the fill
     * @param alpha - the alpha of the fill
     * @returns - This Graphics object. Good for chaining method calls
     */
    beginFill(color?: number, alpha?: number): this;
    /**
     * Begin the texture fill
     * @param options - Object object.
     * @param {PIXI.Texture} [options.texture=PIXI.Texture.WHITE] - Texture to fill
     * @param {number} [options.color=0xffffff] - Background to fill behind texture
     * @param {number} [options.alpha=1] - Alpha of fill
     * @param {PIXI.Matrix} [options.matrix=null] - Transform matrix
     * @returns {PIXI.Graphics} This Graphics object. Good for chaining method calls
     */
    beginTextureFill(options?: IFillStyleOptions): this;
    /**
     * Applies a fill to the lines and shapes that were added since the last call to the beginFill() method.
     * @returns - This Graphics object. Good for chaining method calls
     */
    endFill(): this;
    /**
     * Draws a rectangle shape.
     * @param x - The X coord of the top-left of the rectangle
     * @param y - The Y coord of the top-left of the rectangle
     * @param width - The width of the rectangle
     * @param height - The height of the rectangle
     * @returns - This Graphics object. Good for chaining method calls
     */
    drawRect(x: number, y: number, width: number, height: number): this;
    /**
     * Draw a rectangle shape with rounded/beveled corners.
     * @param x - The X coord of the top-left of the rectangle
     * @param y - The Y coord of the top-left of the rectangle
     * @param width - The width of the rectangle
     * @param height - The height of the rectangle
     * @param radius - Radius of the rectangle corners
     * @returns - This Graphics object. Good for chaining method calls
     */
    drawRoundedRect(x: number, y: number, width: number, height: number, radius: number): this;
    /**
     * Draws a circle.
     * @param x - The X coordinate of the center of the circle
     * @param y - The Y coordinate of the center of the circle
     * @param radius - The radius of the circle
     * @returns - This Graphics object. Good for chaining method calls
     */
    drawCircle(x: number, y: number, radius: number): this;
    /**
     * Draws an ellipse.
     * @param x - The X coordinate of the center of the ellipse
     * @param y - The Y coordinate of the center of the ellipse
     * @param width - The half width of the ellipse
     * @param height - The half height of the ellipse
     * @returns - This Graphics object. Good for chaining method calls
     */
    drawEllipse(x: number, y: number, width: number, height: number): this;
    drawPolygon(...path: Array<number> | Array<IPointData>): this;
    drawPolygon(path: Array<number> | Array<IPointData> | Polygon): this;
    /**
     * Draw any shape.
     * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - Shape to draw
     * @returns - This Graphics object. Good for chaining method calls
     */
    drawShape(shape: IShape): this;
    /**
     * Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
     * @returns - This Graphics object. Good for chaining method calls
     */
    clear(): this;
    /**
     * True if graphics consists of one rectangle, and thus, can be drawn like a Sprite and
     * masked with gl.scissor.
     * @returns - True if only 1 rect.
     */
    isFastRect(): boolean;
    /**
     * Renders the object using the WebGL renderer
     * @param renderer - The renderer
     */
    protected _render(renderer: Renderer): void;
    /** Populating batches for rendering. */
    protected _populateBatches(): void;
    /**
     * Renders the batches using the BathedRenderer plugin
     * @param renderer - The renderer
     */
    protected _renderBatched(renderer: Renderer): void;
    /**
     * Renders the graphics direct
     * @param renderer - The renderer
     */
    protected _renderDirect(renderer: Renderer): void;
    /**
     * Renders specific DrawCall
     * @param renderer
     * @param drawCall
     */
    protected _renderDrawCallDirect(renderer: Renderer, drawCall: BatchDrawCall): void;
    /**
     * Resolves shader for direct rendering
     * @param renderer - The renderer
     */
    protected _resolveDirectShader(renderer: Renderer): Shader;
    /** Retrieves the bounds of the graphic shape as a rectangle object. */
    protected _calculateBounds(): void;
    /**
     * Tests if a point is inside this graphics object
     * @param point - the point to test
     * @returns - the result of the test
     */
    containsPoint(point: IPointData): boolean;
    /** Recalculate the tint by applying tint to batches using Graphics tint. */
    protected calculateTints(): void;
    /** If there's a transform update or a change to the shape of the geometry, recalculate the vertices. */
    protected calculateVertices(): void;
    /**
     * Closes the current path.
     * @returns - Returns itself.
     */
    closePath(): this;
    /**
     * Apply a matrix to the positional data.
     * @param matrix - Matrix to use for transform current shape.
     * @returns - Returns itself.
     */
    setMatrix(matrix: Matrix): this;
    /**
     * Begin adding holes to the last draw shape
     * IMPORTANT: holes must be fully inside a shape to work
     * Also weirdness ensues if holes overlap!
     * Ellipses, Circles, Rectangles and Rounded Rectangles cannot be holes or host for holes in CanvasRenderer,
     * please use `moveTo` `lineTo`, `quadraticCurveTo` if you rely on pixi-legacy bundle.
     * @returns - Returns itself.
     */
    beginHole(): this;
    /**
     * End adding holes to the last draw shape.
     * @returns - Returns itself.
     */
    endHole(): this;
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
    destroy(options?: IDestroyOptions | boolean): void;
}

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
export declare const GRAPHICS_CURVES: IGraphicsCurvesSettings;

/**
 * A class to contain data useful for Graphics objects
 * @memberof PIXI
 */
export declare class GraphicsData {
    /**
     * The shape object to draw.
     * @member {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle}
     */
    shape: IShape;
    /** The style of the line. */
    lineStyle: LineStyle;
    /** The style of the fill. */
    fillStyle: FillStyle;
    /** The transform matrix. */
    matrix: Matrix;
    /** The type of the shape, see the Const.Shapes file for all the existing types, */
    type: SHAPES;
    /** The collection of points. */
    points: number[];
    /** The collection of holes. */
    holes: Array<GraphicsData>;
    /**
     * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - The shape object to draw.
     * @param fillStyle - the width of the line to draw
     * @param lineStyle - the color of the line to draw
     * @param matrix - Transform matrix
     */
    constructor(shape: IShape, fillStyle?: FillStyle, lineStyle?: LineStyle, matrix?: Matrix);
    /**
     * Creates a new GraphicsData object with the same values as this one.
     * @returns - Cloned GraphicsData object
     */
    clone(): GraphicsData;
    /** Destroys the Graphics data. */
    destroy(): void;
}

/**
 * The Graphics class contains methods used to draw primitive shapes such as lines, circles and
 * rectangles to the display, and to color and fill them.
 *
 * GraphicsGeometry is designed to not be continually updating the geometry since it's expensive
 * to re-tesselate using **earcut**. Consider using {@link PIXI.Mesh} for this use-case, it's much faster.
 * @memberof PIXI
 */
export declare class GraphicsGeometry extends BatchGeometry {
    /**
     * The maximum number of points to consider an object "batchable",
     * able to be batched by the renderer's batch system.
     \
     */
    static BATCHABLE_SIZE: number;
    /** Minimal distance between points that are considered different. Affects line tesselation. */
    closePointEps: number;
    /** Padding to add to the bounds. */
    boundsPadding: number;
    uvsFloat32: Float32Array;
    indicesUint16: Uint16Array | Uint32Array;
    batchable: boolean;
    /** An array of points to draw, 2 numbers per point */
    points: number[];
    /** The collection of colors */
    colors: number[];
    /** The UVs collection */
    uvs: number[];
    /** The indices of the vertices */
    indices: number[];
    /** Reference to the texture IDs. */
    textureIds: number[];
    /**
     * The collection of drawn shapes.
     * @member {PIXI.GraphicsData[]}
     */
    graphicsData: Array<GraphicsData>;
    /**
     * List of current draw calls drived from the batches.
     * @member {PIXI.BatchDrawCall[]}
     */
    drawCalls: Array<BatchDrawCall>;
    /** Batches need to regenerated if the geometry is updated. */
    batchDirty: number;
    /**
     * Intermediate abstract format sent to batch system.
     * Can be converted to drawCalls or to batchable objects.
     * @member {PIXI.graphicsUtils.BatchPart[]}
     */
    batches: Array<BatchPart>;
    /** Used to detect if the graphics object has changed. */
    protected dirty: number;
    /** Used to check if the cache is dirty. */
    protected cacheDirty: number;
    /** Used to detect if we cleared the graphicsData. */
    protected clearDirty: number;
    /** Index of the last batched shape in the stack of calls. */
    protected shapeIndex: number;
    /** Cached bounds. */
    protected _bounds: Bounds;
    /** The bounds dirty flag. */
    protected boundsDirty: number;
    constructor();
    /**
     * Get the current bounds of the graphic geometry.
     * @readonly
     */
    get bounds(): Bounds;
    /** Call if you changed graphicsData manually. Empties all batch buffers. */
    protected invalidate(): void;
    /**
     * Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
     * @returns - This GraphicsGeometry object. Good for chaining method calls
     */
    clear(): GraphicsGeometry;
    /**
     * Draws the given shape to this Graphics object. Can be any of Circle, Rectangle, Ellipse, Line or Polygon.
     * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - The shape object to draw.
     * @param fillStyle - Defines style of the fill.
     * @param lineStyle - Defines style of the lines.
     * @param matrix - Transform applied to the points of the shape.
     * @returns - Returns geometry for chaining.
     */
    drawShape(shape: IShape_2, fillStyle?: FillStyle, lineStyle?: LineStyle, matrix?: Matrix): GraphicsGeometry;
    /**
     * Draws the given shape to this Graphics object. Can be any of Circle, Rectangle, Ellipse, Line or Polygon.
     * @param {PIXI.Circle|PIXI.Ellipse|PIXI.Polygon|PIXI.Rectangle|PIXI.RoundedRectangle} shape - The shape object to draw.
     * @param matrix - Transform applied to the points of the shape.
     * @returns - Returns geometry for chaining.
     */
    drawHole(shape: IShape_2, matrix?: Matrix): GraphicsGeometry;
    /** Destroys the GraphicsGeometry object. */
    destroy(): void;
    /**
     * Check to see if a point is contained within this geometry.
     * @param point - Point to check if it's contained.
     * @returns {boolean} `true` if the point is contained within geometry.
     */
    containsPoint(point: IPointData): boolean;
    /**
     * Generates intermediate batch data. Either gets converted to drawCalls
     * or used to convert to batch objects directly by the Graphics object.
     */
    updateBatches(): void;
    /**
     * Affinity check
     * @param styleA
     * @param styleB
     */
    protected _compareStyles(styleA: FillStyle | LineStyle, styleB: FillStyle | LineStyle): boolean;
    /** Test geometry for batching process. */
    protected validateBatching(): boolean;
    /** Offset the indices so that it works with the batcher. */
    protected packBatches(): void;
    /**
     * Checks to see if this graphics geometry can be batched.
     * Currently it needs to be small enough and not contain any native lines.
     */
    protected isBatchable(): boolean;
    /** Converts intermediate batches data to drawCalls. */
    protected buildDrawCalls(): void;
    /** Packs attributes to single buffer. */
    protected packAttributes(): void;
    /**
     * Process fill part of Graphics.
     * @param data
     */
    protected processFill(data: GraphicsData): void;
    /**
     * Process line part of Graphics.
     * @param data
     */
    protected processLine(data: GraphicsData): void;
    /**
     * Process the holes data.
     * @param holes
     */
    protected processHoles(holes: Array<GraphicsData>): void;
    /** Update the local bounds of the object. Expensive to use performance-wise. */
    protected calculateBounds(): void;
    /**
     * Transform points using matrix.
     * @param points - Points to transform
     * @param matrix - Transform matrix
     */
    protected transformPoints(points: Array<number>, matrix: Matrix): void;
    /**
     * Add colors.
     * @param colors - List of colors to add to
     * @param color - Color to add
     * @param alpha - Alpha to use
     * @param size - Number of colors to add
     * @param offset
     */
    protected addColors(colors: Array<number>, color: number, alpha: number, size: number, offset?: number): void;
    /**
     * Add texture id that the shader/fragment wants to use.
     * @param textureIds
     * @param id
     * @param size
     * @param offset
     */
    protected addTextureIds(textureIds: Array<number>, id: number, size: number, offset?: number): void;
    /**
     * Generates the UVs for a shape.
     * @param verts - Vertices
     * @param uvs - UVs
     * @param texture - Reference to Texture
     * @param start - Index buffer start index.
     * @param size - The size/length for index buffer.
     * @param matrix - Optional transform for all points.
     */
    protected addUvs(verts: Array<number>, uvs: Array<number>, texture: Texture, start: number, size: number, matrix?: Matrix): void;
    /**
     * Modify uvs array according to position of texture region
     * Does not work with rotated or trimmed textures
     * @param uvs - array
     * @param texture - region
     * @param start - starting index for uvs
     * @param size - how many points to adjust
     */
    protected adjustUvs(uvs: Array<number>, texture: Texture, start: number, size: number): void;
}

export declare const graphicsUtils: {
    buildPoly: IShapeBuildCommand;
    buildCircle: IShapeBuildCommand;
    buildRectangle: IShapeBuildCommand;
    buildRoundedRectangle: IShapeBuildCommand;
    buildLine: typeof buildLine;
    ArcUtils: typeof ArcUtils;
    BezierUtils: typeof BezierUtils;
    QuadraticUtils: typeof QuadraticUtils;
    BatchPart: typeof BatchPart;
    FILL_COMMANDS: Record<SHAPES, IShapeBuildCommand>;
    BATCH_POOL: BatchPart[];
    DRAW_CALL_POOL: BatchDrawCall_2[];
};

declare interface IArcLikeShape {
    cx: number;
    cy: number;
    radius: number;
    startAngle: number;
    endAngle: number;
    anticlockwise: boolean;
}

export declare interface IFillStyleOptions {
    color?: number;
    alpha?: number;
    texture?: Texture;
    matrix?: Matrix;
}

/** Batch element computed from Graphics geometry */
export declare interface IGraphicsBatchElement {
    vertexData: Float32Array;
    blendMode: BLEND_MODES;
    indices: Uint16Array | Uint32Array;
    uvs: Float32Array;
    alpha: number;
    worldAlpha: number;
    _batchRGB: number[];
    _tintRGB: number;
    _texture: Texture;
}

export declare interface IGraphicsCurvesSettings {
    adaptive: boolean;
    maxLength: number;
    minSegments: number;
    maxSegments: number;
    epsilon: number;
    _segmentsCount(length: number, defaultSegments?: number): number;
}

export declare interface ILineStyleOptions extends IFillStyleOptions {
    width?: number;
    alignment?: number;
    native?: boolean;
    cap?: LINE_CAP;
    join?: LINE_JOIN;
    miterLimit?: number;
}

declare type IShape_2 = Circle | Ellipse | Polygon | Rectangle | RoundedRectangle;

declare interface IShapeBuildCommand {
    build(graphicsData: GraphicsData): void;
    triangulate(graphicsData: GraphicsData, target: GraphicsGeometry): void;
}

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
export declare enum LINE_CAP {
    BUTT = "butt",
    ROUND = "round",
    SQUARE = "square"
}

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
export declare enum LINE_JOIN {
    MITER = "miter",
    BEVEL = "bevel",
    ROUND = "round"
}

/**
 * Represents the line style for Graphics.
 * @memberof PIXI
 */
export declare class LineStyle extends FillStyle {
    /** The width (thickness) of any lines drawn. */
    width: number;
    /** The alignment of any lines drawn (0.5 = middle, 1 = outer, 0 = inner). WebGL only. */
    alignment: number;
    /** If true the lines will be draw using LINES instead of TRIANGLE_STRIP. */
    native: boolean;
    /**
     * Line cap style.
     * @member {PIXI.LINE_CAP}
     * @default PIXI.LINE_CAP.BUTT
     */
    cap: LINE_CAP;
    /**
     * Line join style.
     * @member {PIXI.LINE_JOIN}
     * @default PIXI.LINE_JOIN.MITER
     */
    join: LINE_JOIN;
    /** Miter limit. */
    miterLimit: number;
    /** Clones the object. */
    clone(): LineStyle;
    /** Reset the line style to default. */
    reset(): void;
}

/**
 * Utilities for quadratic curves.
 * @private
 */
declare class QuadraticUtils {
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
    static curveLength(fromX: number, fromY: number, cpX: number, cpY: number, toX: number, toY: number): number;
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
    static curveTo(cpX: number, cpY: number, toX: number, toY: number, points: Array<number>): void;
}

export { }
