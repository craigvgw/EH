/// <reference path="./global.d.ts" />

import type { BaseTexture } from "./../core/index";
import { BufferResource } from "./../core/index";
import type { ExtensionMetadata } from "./../extensions/index";
import { FORMATS } from "./../constants/index";
import type { GLTexture } from "./../core/index";
import { LoaderResource } from "./../loaders/index";
import type { Renderer } from "./../core/index";
import type { Resource } from "./../core/index";
import { TYPES } from "./../constants/index";
import { ViewableBuffer } from "./../core/index";

/**
 * Resource that fetches texture data over the network and stores it in a buffer.
 * @class
 * @extends PIXI.Resource
 * @memberof PIXI
 */
export declare abstract class BlobResource extends BufferResource {
    protected origin: string;
    protected buffer: ViewableBuffer;
    protected loaded: boolean;
    /**
     * @param {string} source - the URL of the texture file
     * @param {PIXI.IBlobOptions} options
     * @param {boolean}[options.autoLoad] - whether to fetch the data immediately;
     *  you can fetch it later via {@link BlobResource#load}
     * @param {boolean}[options.width] - the width in pixels.
     * @param {boolean}[options.height] - the height in pixels.
     */
    constructor(source: string | Uint8Array | Uint32Array | Float32Array, options?: IBlobOptions);
    protected onBlobLoaded(_data: ArrayBuffer): void;
    /** Loads the blob */
    load(): Promise<Resource>;
}

/**
 * @ignore
 */
export declare type CompressedLevelBuffer = {
    levelID: number;
    levelWidth: number;
    levelHeight: number;
    levelBuffer: Uint8Array;
};

export declare type CompressedTextureExtensionRef = keyof CompressedTextureExtensions;

/** Compressed texture extensions */
export declare type CompressedTextureExtensions = {
    s3tc?: WEBGL_compressed_texture_s3tc;
    s3tc_sRGB: WEBGL_compressed_texture_s3tc_srgb;
    etc: any;
    etc1: any;
    pvrtc: any;
    atc: any;
    astc: WEBGL_compressed_texture_astc;
};

/**
 * Loader plugin for handling compressed textures for all platforms.
 * @class
 * @memberof PIXI
 * @implements {PIXI.ILoaderPlugin}
 */
export declare class CompressedTextureLoader {
    /** @ignore */
    static extension: ExtensionMetadata;
    /**  Map of available texture extensions. */
    private static _textureExtensions;
    /** Map of available texture formats. */
    private static _textureFormats;
    /**
     * Called after a compressed-textures manifest is loaded.
     *
     * This will then load the correct compression format for the device. Your manifest should adhere
     * to the following schema:
     *
     * ```js
     * import { INTERNAL_FORMATS } from "./../constants/index";
     *
     * type CompressedTextureManifest = {
     *  textures: Array<{ src: string, format?: keyof INTERNAL_FORMATS}>,
     *  cacheID: string;
     * };
     * ```
     *
     * This is an example of a .json manifest file
     *
     * ```json
     * {
     *   "cacheID":"asset",
     *   "textures":[
     *     { "src":"asset.fallback.png" },
     *     { "format":"COMPRESSED_RGBA_S3TC_DXT5_EXT", "src":"asset.s3tc.ktx" },
     *     { "format":"COMPRESSED_RGBA8_ETC2_EAC", "src":"asset.etc.ktx" },
     *     { "format":"RGBA_PVRTC_4BPPV1_IMG", "src":"asset.pvrtc.ktx" }
     *   ]
     * }
     * ```
     */
    static use(resource: LoaderResource, next: (...args: any[]) => void): void;
    /**  Map of available texture extensions. */
    static get textureExtensions(): Partial<CompressedTextureExtensions>;
    /** Map of available texture formats. */
    static get textureFormats(): {
        [P in keyof INTERNAL_FORMATS]?: number;
    };
}

/**
 * Schema for compressed-texture manifests
 * @ignore
 * @see PIXI.CompressedTextureLoader
 */
export declare type CompressedTextureManifest = {
    textures: Array<{
        src: string;
        format?: keyof INTERNAL_FORMATS;
    }>;
    cacheID: string;
};

/**
 * Resource for compressed texture formats, as follows: S3TC/DXTn (& their sRGB formats), ATC, ASTC, ETC 1/2, PVRTC.
 *
 * Compressed textures improve performance when rendering is texture-bound. The texture data stays compressed in
 * graphics memory, increasing memory locality and speeding up texture fetches. These formats can also be used to store
 * more detail in the same amount of memory.
 *
 * For most developers, container file formats are a better abstraction instead of directly handling raw texture
 * data. PixiJS provides native support for the following texture file formats (via {@link PIXI.Loader}):
 *
 * **.dds** - the DirectDraw Surface file format stores DXTn (DXT-1,3,5) data. See {@link PIXI.DDSLoader}
 * **.ktx** - the Khronos Texture Container file format supports storing all the supported WebGL compression formats.
 *  See {@link PIXI.KTXLoader}.
 * **.basis** - the BASIS supercompressed file format stores texture data in an internal format that is transcoded
 *  to the compression format supported on the device at _runtime_. It also supports transcoding into a uncompressed
 *  format as a fallback; you must install the `@pixi/basis-loader`, `@pixi/basis-transcoder` packages separately to
 *  use these files. See {@link PIXI.BasisLoader}.
 *
 * The loaders for the aforementioned formats use `CompressedTextureResource` internally. It is strongly suggested that
 * they be used instead.
 *
 * ## Working directly with CompressedTextureResource
 *
 * Since `CompressedTextureResource` inherits `BlobResource`, you can provide it a URL pointing to a file containing
 * the raw texture data (with no file headers!):
 *
 * ```js
 * // The resource backing the texture data for your textures.
 * // NOTE: You can also provide a ArrayBufferView instead of a URL. This is used when loading data from a container file
 * //   format such as KTX, DDS, or BASIS.
 * const compressedResource = new PIXI.CompressedTextureResource("bunny.dxt5", {
 *   format: PIXI.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT5_EXT,
 *   width: 256,
 *   height: 256
 * });
 *
 * // You can create a base-texture to the cache, so that future `Texture`s can be created using the `Texture.from` API.
 * const baseTexture = new PIXI.BaseTexture(compressedResource, { pmaMode: PIXI.ALPHA_MODES.NPM });
 *
 * // Create a Texture to add to the TextureCache
 * const texture = new PIXI.Texture(baseTexture);
 *
 * // Add baseTexture & texture to the global texture cache
 * PIXI.BaseTexture.addToCache(baseTexture, "bunny.dxt5");
 * PIXI.Texture.addToCache(texture, "bunny.dxt5");
 * ```
 * @memberof PIXI
 */
export declare class CompressedTextureResource extends BlobResource {
    /** The compression format */
    format: INTERNAL_FORMATS;
    /**
     * The number of mipmap levels stored in the resource buffer.
     * @default 1
     */
    levels: number;
    private _extension;
    private _levelBuffers;
    /**
     * @param source - the buffer/URL holding the compressed texture data
     * @param options
     * @param {PIXI.INTERNAL_FORMATS} options.format - the compression format
     * @param {number} options.width - the image width in pixels.
     * @param {number} options.height - the image height in pixels.
     * @param {number} [options.level=1] - the mipmap levels stored in the compressed texture, including level 0.
     * @param {number} [options.levelBuffers] - the buffers for each mipmap level. `CompressedTextureResource` can allows you
     *      to pass `null` for `source`, for cases where each level is stored in non-contiguous memory.
     */
    constructor(source: string | Uint8Array | Uint32Array, options: ICompressedTextureResourceOptions);
    /**
     * @override
     * @param renderer - A reference to the current renderer
     * @param _texture - the texture
     * @param _glTexture - texture instance for this webgl context
     */
    upload(renderer: Renderer, _texture: BaseTexture, _glTexture: GLTexture): boolean;
    /** @protected */
    protected onBlobLoaded(): void;
    /**
     * Returns the key (to ContextSystem#extensions) for the WebGL extension supporting the compression format
     * @private
     * @param format - the compression format to get the extension for.
     */
    private static _formatToExtension;
    /**
     * Pre-creates buffer views for each mipmap level
     * @private
     * @param buffer -
     * @param format - compression formats
     * @param levels - mipmap levels
     * @param blockWidth -
     * @param blockHeight -
     * @param imageWidth - width of the image in pixels
     * @param imageHeight - height of the image in pixels
     */
    private static _createLevelBuffers;
}

/**
 * @class
 * @memberof PIXI
 * @implements {PIXI.ILoaderPlugin}
 * @see https://docs.microsoft.com/en-us/windows/win32/direct3ddds/dx-graphics-dds-pguide
 */
export declare class DDSLoader {
    /** @ignore */
    static extension: ExtensionMetadata;
    /**
     * Registers a DDS compressed texture
     * @see PIXI.Loader.loaderMiddleware
     * @param resource - loader resource that is checked to see if it is a DDS file
     * @param next - callback Function to call when done
     */
    static use(resource: LoaderResource, next: (...args: any[]) => void): void;
}

/**
 * Number of components in each {@link PIXI.FORMATS}
 * @ignore
 */
export declare const FORMATS_TO_COMPONENTS: {
    [id: number]: number;
};

declare interface IBlobOptions {
    autoLoad?: boolean;
    width: number;
    height: number;
}

/**
 * @ignore
 */
export declare interface ICompressedTextureResourceOptions {
    format: INTERNAL_FORMATS;
    width: number;
    height: number;
    levels?: number;
    levelBuffers?: CompressedLevelBuffer[];
}

/**
 * Maps the compressed texture formats in {@link PIXI.INTERNAL_FORMATS} to the number of bytes taken by
 * each texel.
 * @memberof PIXI
 * @static
 * @ignore
 */
export declare const INTERNAL_FORMAT_TO_BYTES_PER_PIXEL: {
    [id: number]: number;
};

/**
 * WebGL internal formats, including compressed texture formats provided by extensions
 * @memberof PIXI
 * @static
 * @name INTERNAL_FORMATS
 * @enum {number}
 * @property {number} [COMPRESSED_RGB_S3TC_DXT1_EXT=0x83F0] -
 * @property {number} [COMPRESSED_RGBA_S3TC_DXT1_EXT=0x83F1] -
 * @property {number} [COMPRESSED_RGBA_S3TC_DXT3_EXT=0x83F2] -
 * @property {number} [COMPRESSED_RGBA_S3TC_DXT5_EXT=0x83F3] -
 * @property {number} [COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT=35917] -
 * @property {number} [COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT=35918] -
 * @property {number} [COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT=35919] -
 * @property {number} [COMPRESSED_SRGB_S3TC_DXT1_EXT=35916] -
 * @property {number} [COMPRESSED_R11_EAC=0x9270] -
 * @property {number} [COMPRESSED_SIGNED_R11_EAC=0x9271] -
 * @property {number} [COMPRESSED_RG11_EAC=0x9272] -
 * @property {number} [COMPRESSED_SIGNED_RG11_EAC=0x9273] -
 * @property {number} [COMPRESSED_RGB8_ETC2=0x9274] -
 * @property {number} [COMPRESSED_RGBA8_ETC2_EAC=0x9278] -
 * @property {number} [COMPRESSED_SRGB8_ETC2=0x9275] -
 * @property {number} [COMPRESSED_SRGB8_ALPHA8_ETC2_EAC=0x9279] -
 * @property {number} [COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2=0x9276] -
 * @property {number} [COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2=0x9277] -
 * @property {number} [COMPRESSED_RGB_PVRTC_4BPPV1_IMG=0x8C00] -
 * @property {number} [COMPRESSED_RGBA_PVRTC_4BPPV1_IMG=0x8C02] -
 * @property {number} [COMPRESSED_RGB_PVRTC_2BPPV1_IMG=0x8C01] -
 * @property {number} [COMPRESSED_RGBA_PVRTC_2BPPV1_IMG=0x8C03] -
 * @property {number} [COMPRESSED_RGB_ETC1_WEBGL=0x8D64] -
 * @property {number} [COMPRESSED_RGB_ATC_WEBGL=0x8C92] -
 * @property {number} [COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL=0x8C92] -
 * @property {number} [COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL=0x87EE] -
 */
export declare enum INTERNAL_FORMATS {
    COMPRESSED_RGB_S3TC_DXT1_EXT = 33776,
    COMPRESSED_RGBA_S3TC_DXT1_EXT = 33777,
    COMPRESSED_RGBA_S3TC_DXT3_EXT = 33778,
    COMPRESSED_RGBA_S3TC_DXT5_EXT = 33779,
    COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 35917,
    COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 35918,
    COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 35919,
    COMPRESSED_SRGB_S3TC_DXT1_EXT = 35916,
    COMPRESSED_R11_EAC = 37488,
    COMPRESSED_SIGNED_R11_EAC = 37489,
    COMPRESSED_RG11_EAC = 37490,
    COMPRESSED_SIGNED_RG11_EAC = 37491,
    COMPRESSED_RGB8_ETC2 = 37492,
    COMPRESSED_RGBA8_ETC2_EAC = 37496,
    COMPRESSED_SRGB8_ETC2 = 37493,
    COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 37497,
    COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 37494,
    COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 37495,
    COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 35840,
    COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 35842,
    COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 35841,
    COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 35843,
    COMPRESSED_RGB_ETC1_WEBGL = 36196,
    COMPRESSED_RGB_ATC_WEBGL = 35986,
    COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL = 35986,
    COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL = 34798
}

/**
 * Loader plugin for handling KTX texture container files.
 *
 * This KTX loader does not currently support the following features:
 * * cube textures
 * * 3D textures
 * * endianness conversion for big-endian machines
 * * embedded *.basis files
 *
 * It does supports the following features:
 * * multiple textures per file
 * * mipmapping (only for compressed formats)
 * * vendor-specific key/value data parsing (enable {@link PIXI.KTXLoader.loadKeyValueData})
 * @class
 * @memberof PIXI
 * @implements {PIXI.ILoaderPlugin}
 */
export declare class KTXLoader {
    /** @ignore */
    static extension: ExtensionMetadata;
    /**
     * If set to `true`, {@link PIXI.KTXLoader} will parse key-value data in KTX textures. This feature relies
     * on the [Encoding Standard]{@link https://encoding.spec.whatwg.org}.
     *
     * The key-value data will be available on the base-textures as {@code PIXI.BaseTexture.ktxKeyValueData}. They
     * will hold a reference to the texture data buffer, so make sure to delete key-value data once you are done
     * using it.
     */
    static loadKeyValueData: boolean;
    /**
     * Called after a KTX file is loaded.
     *
     * This will parse the KTX file header and add a {@code BaseTexture} to the texture
     * cache.
     * @see PIXI.Loader.loaderMiddleware
     * @param resource - loader resource that is checked to see if it is a KTX file
     * @param next - callback Function to call when done
     */
    static use(resource: LoaderResource, next: (...args: any[]) => void): void;
}

/**
 * @class
 * @memberof PIXI
 * @implements {PIXI.ILoaderPlugin}
 * @see https://docs.microsoft.com/en-us/windows/win32/direct3ddds/dx-graphics-dds-pguide
 */
/**
 * Parses the DDS file header, generates base-textures, and puts them into the texture cache.
 * @param arrayBuffer
 */
export declare function parseDDS(arrayBuffer: ArrayBuffer): CompressedTextureResource[];

export declare function parseKTX(url: string, arrayBuffer: ArrayBuffer, loadKeyValueData?: boolean): {
    compressed?: CompressedTextureResource[];
    uncompressed?: {
        resource: BufferResource;
        type: TYPES;
        format: FORMATS;
    }[];
    kvData: Map<string, DataView> | null;
};

/**
 * Maps {@link PIXI.TYPES} to the bytes taken per component, excluding those ones that are bit-fields.
 * @ignore
 */
export declare const TYPES_TO_BYTES_PER_COMPONENT: {
    [id: number]: number;
};

/**
 * Number of bytes per pixel in bit-field types in {@link PIXI.TYPES}
 * @ignore
 */
export declare const TYPES_TO_BYTES_PER_PIXEL: {
    [id: number]: number;
};

export { }
