/// <reference path="./global.d.ts" />

import type { BLEND_MODES } from "./../constants/index";
import type { Buffer as Buffer_2 } from "./../core/index";
import { Container } from "./../display/index";
import type { Dict } from "./../utils/index";
import { DRAW_MODES } from "./../constants/index";
import { Geometry } from "./../core/index";
import type { IArrayBuffer } from "./../core/index";
import type { IDestroyOptions } from "./../display/index";
import type { IPointData } from "./../math/index";
import { Program } from "./../core/index";
import type { Renderer } from "./../core/index";
import { Shader } from "./../core/index";
import { State } from "./../core/index";
import type { Texture } from "./../core/index";
import { TextureMatrix } from "./../core/index";

export declare interface IMeshMaterialOptions {
    alpha?: number;
    tint?: number;
    pluginName?: string;
    program?: Program;
    uniforms?: Dict<unknown>;
}

export declare interface Mesh extends GlobalMixins.Mesh {
}

/**
 * Base mesh class.
 *
 * This class empowers you to have maximum flexibility to render any kind of WebGL visuals you can think of.
 * This class assumes a certain level of WebGL knowledge.
 * If you know a bit this should abstract enough away to make your life easier!
 *
 * Pretty much ALL WebGL can be broken down into the following:
 * - Geometry - The structure and data for the mesh. This can include anything from positions, uvs, normals, colors etc..
 * - Shader - This is the shader that PixiJS will render the geometry with (attributes in the shader must match the geometry)
 * - State - This is the state of WebGL required to render the mesh.
 *
 * Through a combination of the above elements you can render anything you want, 2D or 3D!
 * @memberof PIXI
 */
export declare class Mesh<T extends Shader = MeshMaterial> extends Container {
    /**
     * Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
     * Can be shared between multiple Mesh objects.
     * @type {PIXI.Shader|PIXI.MeshMaterial}
     */
    shader: T;
    /**
     * Represents the WebGL state the Mesh required to render, excludes shader and geometry. E.g.,
     * blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
     */
    state: State;
    /** The way the Mesh should be drawn, can be any of the {@link PIXI.DRAW_MODES} constants. */
    drawMode: DRAW_MODES;
    /**
     * Typically the index of the IndexBuffer where to start drawing.
     * @default 0
     */
    start: number;
    /**
     * How much of the geometry to draw, by default `0` renders everything.
     * @default 0
     */
    size: number;
    private _geometry;
    /** This is the caching layer used by the batcher. */
    private vertexData;
    /** If geometry is changed used to decide to re-transform the vertexData. */
    private vertexDirty;
    private _transformID;
    /** Internal roundPixels field. */
    private _roundPixels;
    /** Batched UV's are cached for atlas textures. */
    private batchUvs;
    /**
     * These are used as easy access for batching.
     * @private
     */
    uvs: Float32Array;
    /**
     * These are used as easy access for batching.
     * @private
     */
    indices: Uint16Array;
    _tintRGB: number;
    _texture: Texture;
    /**
     * @param geometry - The geometry the mesh will use.
     * @param {PIXI.MeshMaterial} shader - The shader the mesh will use.
     * @param state - The state that the WebGL context is required to be in to render the mesh
     *        if no state is provided, uses {@link PIXI.State.for2d} to create a 2D state for PixiJS.
     * @param drawMode - The drawMode, can be any of the {@link PIXI.DRAW_MODES} constants.
     */
    constructor(geometry: Geometry, shader: T, state?: State, drawMode?: DRAW_MODES);
    /**
     * Includes vertex positions, face indices, normals, colors, UVs, and
     * custom attributes within buffers, reducing the cost of passing all
     * this data to the GPU. Can be shared between multiple Mesh objects.
     */
    get geometry(): Geometry;
    set geometry(value: Geometry);
    /**
     * To change mesh uv's, change its uvBuffer data and increment its _updateID.
     * @readonly
     */
    get uvBuffer(): Buffer_2;
    /**
     * To change mesh vertices, change its uvBuffer data and increment its _updateID.
     * Incrementing _updateID is optional because most of Mesh objects do it anyway.
     * @readonly
     */
    get verticesBuffer(): Buffer_2;
    /** Alias for {@link PIXI.Mesh#shader}. */
    set material(value: T);
    get material(): T;
    /**
     * The blend mode to be applied to the Mesh. Apply a value of
     * `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
     * @default PIXI.BLEND_MODES.NORMAL;
     */
    set blendMode(value: BLEND_MODES);
    get blendMode(): BLEND_MODES;
    /**
     * If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
     * Advantages can include sharper image quality (like text) and faster rendering on canvas.
     * The main disadvantage is movement of objects may appear less smooth.
     * To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
     * @default false
     */
    set roundPixels(value: boolean);
    get roundPixels(): boolean;
    /**
     * The multiply tint applied to the Mesh. This is a hex value. A value of
     * `0xFFFFFF` will remove any tint effect.
     *
     * Null for non-MeshMaterial shaders
     * @default 0xFFFFFF
     */
    get tint(): number;
    set tint(value: number);
    /** The texture that the Mesh uses. Null for non-MeshMaterial shaders */
    get texture(): Texture;
    set texture(value: Texture);
    /**
     * Standard renderer draw.
     * @param renderer - Instance to renderer.
     */
    protected _render(renderer: Renderer): void;
    /**
     * Standard non-batching way of rendering.
     * @param renderer - Instance to renderer.
     */
    protected _renderDefault(renderer: Renderer): void;
    /**
     * Rendering by using the Batch system.
     * @param renderer - Instance to renderer.
     */
    protected _renderToBatch(renderer: Renderer): void;
    /** Updates vertexData field based on transform and vertices. */
    calculateVertices(): void;
    /** Updates uv field based on from geometry uv's or batchUvs. */
    calculateUvs(): void;
    /**
     * Updates the bounds of the mesh as a rectangle. The bounds calculation takes the worldTransform into account.
     * there must be a aVertexPosition attribute present in the geometry for bounds to be calculated correctly.
     */
    protected _calculateBounds(): void;
    /**
     * Tests if a point is inside this mesh. Works only for PIXI.DRAW_MODES.TRIANGLES.
     * @param point - The point to test.
     * @returns - The result of the test.
     */
    containsPoint(point: IPointData): boolean;
    destroy(options?: IDestroyOptions | boolean): void;
    /** The maximum number of vertices to consider batchable. Generally, the complexity of the geometry. */
    static BATCHABLE_SIZE: number;
}

/**
 * Class controls cache for UV mapping from Texture normal space to BaseTexture normal space.
 * @memberof PIXI
 */
export declare class MeshBatchUvs {
    /** UV Buffer data. */
    readonly data: Float32Array;
    /** Buffer with normalized UV's. */
    uvBuffer: Buffer_2;
    /** Material UV matrix. */
    uvMatrix: TextureMatrix;
    private _bufferUpdateId;
    private _textureUpdateId;
    _updateID: number;
    /**
     * @param uvBuffer - Buffer with normalized uv's
     * @param uvMatrix - Material UV matrix
     */
    constructor(uvBuffer: Buffer_2, uvMatrix: TextureMatrix);
    /**
     * Updates
     * @param forceUpdate - force the update
     */
    update(forceUpdate?: boolean): void;
}

/**
 * Standard 2D geometry used in PixiJS.
 *
 * Geometry can be defined without passing in a style or data if required.
 *
 * ```js
 * const geometry = new PIXI.Geometry();
 *
 * geometry.addAttribute('positions', [0, 0, 100, 0, 100, 100, 0, 100], 2);
 * geometry.addAttribute('uvs', [0,0,1,0,1,1,0,1], 2);
 * geometry.addIndex([0,1,2,1,3,2]);
 *
 * ```
 * @memberof PIXI
 */
export declare class MeshGeometry extends Geometry {
    /**
     * Dirty flag to limit update calls on Mesh. For example,
     * limiting updates on a single Mesh instance with a shared Geometry
     * within the render loop.
     * @private
     * @default -1
     */
    _updateId: number;
    /**
     * @param {Float32Array|number[]} [vertices] - Positional data on geometry.
     * @param {Float32Array|number[]} [uvs] - Texture UVs.
     * @param {Uint16Array|number[]} [index] - IndexBuffer
     */
    constructor(vertices?: IArrayBuffer, uvs?: IArrayBuffer, index?: IArrayBuffer);
    /**
     * If the vertex position is updated.
     * @readonly
     * @private
     */
    get vertexDirtyId(): number;
}

export declare interface MeshMaterial extends GlobalMixins.MeshMaterial {
}

/**
 * Slightly opinionated default shader for PixiJS 2D objects.
 * @memberof PIXI
 */
export declare class MeshMaterial extends Shader {
    /**
     * TextureMatrix instance for this Mesh, used to track Texture changes.
     * @readonly
     */
    readonly uvMatrix: TextureMatrix;
    /**
     * `true` if shader can be batch with the renderer's batch system.
     * @default true
     */
    batchable: boolean;
    /**
     * Renderer plugin for batching.
     * @default 'batch'
     */
    pluginName: string;
    _tintRGB: number;
    /**
     * Only do update if tint or alpha changes.
     * @private
     * @default false
     */
    private _colorDirty;
    private _alpha;
    private _tint;
    /**
     * @param uSampler - Texture that material uses to render.
     * @param options - Additional options
     * @param {number} [options.alpha=1] - Default alpha.
     * @param {number} [options.tint=0xFFFFFF] - Default tint.
     * @param {string} [options.pluginName='batch'] - Renderer plugin for batching.
     * @param {PIXI.Program} [options.program=0xFFFFFF] - Custom program.
     * @param {object} [options.uniforms] - Custom uniforms.
     */
    constructor(uSampler: Texture, options?: IMeshMaterialOptions);
    /** Reference to the texture being rendered. */
    get texture(): Texture;
    set texture(value: Texture);
    /**
     * This gets automatically set by the object using this.
     * @default 1
     */
    set alpha(value: number);
    get alpha(): number;
    /**
     * Multiply tint for the material.
     * @default 0xFFFFFF
     */
    set tint(value: number);
    get tint(): number;
    /** Gets called automatically by the Mesh. Intended to be overridden for custom {@link MeshMaterial} objects. */
    update(): void;
}

export { }
