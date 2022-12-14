import type { BaseTexture } from "./../core/index";
import { default as earcut_2 } from 'earcut';
import { EventEmitter } from "./../eventemitter3/index";
import { isMobile } from "./../settings/index";
import type { ITypedArray } from "./../core/index";
import type { Program } from "./../core/index";
import type { Texture } from "./../core/index";

export declare type ArrayFixed<T, L extends number> = [T, ...Array<T>] & {
    length: L;
};

/**
 * @todo Describe property usage
 * @static
 * @name BaseTextureCache
 * @memberof PIXI.utils
 * @type {object}
 */
export declare const BaseTextureCache: {
    [key: string]: BaseTexture;
};

/**
 * Creates a Canvas element of the given size to be used as a target for rendering to.
 * @class
 * @memberof PIXI.utils
 */
export declare class CanvasRenderTarget {
    /** The Canvas object that belongs to this CanvasRenderTarget. */
    canvas: HTMLCanvasElement;
    /** A CanvasRenderingContext2D object representing a two-dimensional rendering context. */
    context: CanvasRenderingContext2D;
    /**
     * The resolution / device pixel ratio of the canvas
     * @default 1
     */
    resolution: number;
    /**
     * @param width - the width for the newly created canvas
     * @param height - the height for the newly created canvas
     * @param {number} [resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio of the canvas
     */
    constructor(width: number, height: number, resolution?: number);
    /**
     * Clears the canvas that was created by the CanvasRenderTarget class.
     * @private
     */
    clear(): void;
    /**
     * Resizes the canvas to the specified width and height.
     * @param desiredWidth - the desired width of the canvas
     * @param desiredHeight - the desired height of the canvas
     */
    resize(desiredWidth: number, desiredHeight: number): void;
    /** Destroys this canvas. */
    destroy(): void;
    /**
     * The width of the canvas buffer in pixels.
     * @member {number}
     */
    get width(): number;
    set width(val: number);
    /**
     * The height of the canvas buffer in pixels.
     * @member {number}
     */
    get height(): number;
    set height(val: number);
}

/**
 * Removes all textures from cache, but does not destroy them
 * @memberof PIXI.utils
 * @function clearTextureCache
 */
export declare function clearTextureCache(): void;

/**
 * changes blendMode according to texture format
 * @memberof PIXI.utils
 * @function correctBlendMode
 * @param {number} blendMode - supposed blend mode
 * @param {boolean} premultiplied - whether source is premultiplied
 * @returns {number} true blend mode for this texture
 */
export declare function correctBlendMode(blendMode: number, premultiplied: boolean): number;

/**
 * Generic Mask Stack data structure
 * @memberof PIXI.utils
 * @function createIndicesForQuads
 * @param {number} size - Number of quads
 * @param {Uint16Array|Uint32Array} [outBuffer] - Buffer for output, length has to be `6 * size`
 * @returns {Uint16Array|Uint32Array} - Resulting index buffer
 */
export declare function createIndicesForQuads(size: number, outBuffer?: Uint16Array | Uint32Array): Uint16Array | Uint32Array;

/**
 * Regexp for data URI.
 * Based on: {@link https://github.com/ragingwind/data-uri-regex}
 * @static
 * @constant {RegExp|string} DATA_URI
 * @memberof PIXI
 * @example data:image/png;base64
 */
export declare const DATA_URI: RegExp;

/**
 * @memberof PIXI.utils
 * @interface DecomposedDataUri
 */
/**
 * type, eg. `image`
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} mediaType
 */
/**
 * Sub type, eg. `png`
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} subType
 */
/**
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} charset
 */
/**
 * Data encoding, eg. `base64`
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} encoding
 */
/**
 * The actual data
 * @memberof PIXI.utils.DecomposedDataUri#
 * @member {string} data
 */
/**
 * Split a data URI into components. Returns undefined if
 * parameter `dataUri` is not a valid data URI.
 * @memberof PIXI.utils
 * @function decomposeDataUri
 * @param {string} dataUri - the data URI to check
 * @returns {PIXI.utils.DecomposedDataUri|undefined} The decomposed data uri or undefined
 */
export declare function decomposeDataUri(dataUri: string): DecomposedDataUri;

export declare interface DecomposedDataUri {
    mediaType: string;
    subType: string;
    charset: string;
    encoding: string;
    data: string;
}

/**
 * Helper for warning developers about deprecated features & settings.
 * A stack track for warnings is given; useful for tracking-down where
 * deprecated methods/properties/classes are being used within the code.
 * @memberof PIXI.utils
 * @function deprecation
 * @param {string} version - The version where the feature became deprecated
 * @param {string} message - Message should include what is deprecated, where, and the new solution
 * @param {number} [ignoreDepth=3] - The number of steps to ignore at the top of the error stack
 *        this is mostly to ignore internal deprecation calls.
 */
export declare function deprecation(version: string, message: string, ignoreDepth?: number): void;

/**
 * Destroys all texture in the cache
 * @memberof PIXI.utils
 * @function destroyTextureCache
 */
export declare function destroyTextureCache(): void;

/**
 * Sets the `crossOrigin` property for this resource based on if the url
 * for this resource is cross-origin. If crossOrigin was manually set, this
 * function does nothing.
 * Nipped from the resource loader!
 * @ignore
 * @param {string} url - The url to test.
 * @param {object} [loc=window.location] - The location object to test against.
 * @returns {string} The crossOrigin value to use (or empty string for none).
 */
export declare function determineCrossOrigin(url: string, loc?: Location): string;

export declare type Dict<T> = {
    [key: string]: T;
};

export { earcut_2 as earcut }

export { EventEmitter }

declare type FormatFunction = {
    (URL: URL, options?: URLFormatOptions): string;
    (urlObject: UrlObject | string): string;
};

export declare function getBufferType(array: ITypedArray): 'Float32Array' | 'Uint32Array' | 'Int32Array' | 'Uint16Array' | 'Uint8Array' | null;

/**
 * get the resolution / device pixel ratio of an asset by looking for the prefix
 * used by spritesheets and image urls
 * @memberof PIXI.utils
 * @function getResolutionOfUrl
 * @param {string} url - the image path
 * @param {number} [defaultValue=1] - the defaultValue if no filename prefix is set.
 * @returns {number} resolution / device pixel ratio of an asset
 */
export declare function getResolutionOfUrl(url: string, defaultValue?: number): number;

/**
 * Converts a hexadecimal color number to an [R, G, B] array of normalized floats (numbers from 0.0 to 1.0).
 * @example
 * PIXI.utils.hex2rgb(0xffffff); // returns [1, 1, 1]
 * @memberof PIXI.utils
 * @function hex2rgb
 * @param {number} hex - The hexadecimal number to convert
 * @param  {number[]} [out=[]] - If supplied, this array will be used rather than returning a new one
 * @returns {number[]} An array representing the [R, G, B] of the color where all values are floats.
 */
export declare function hex2rgb(hex: number, outPixi?: Array<number> | Float32Array): Array<number> | Float32Array;

/**
 * Converts a hexadecimal color number to a string.
 * @example
 * PIXI.utils.hex2string(0xffffff); // returns "#ffffff"
 * @memberof PIXI.utils
 * @function hex2string
 * @param {number} hex - Number in hex (e.g., `0xffffff`)
 * @returns {string} The string color (e.g., `"#ffffff"`).
 */
export declare function hex2string(hex: number): string;

export declare function interleaveTypedArrays(arrays: PackedArray[], sizes: number[]): Float32Array;

export { isMobile }

/**
 * Checks if a number is a power of two.
 * @function isPow2
 * @memberof PIXI.utils
 * @param {number} v - input value
 * @returns {boolean} `true` if value is power of two
 */
export declare function isPow2(v: number): boolean;

/**
 * Helper for checking for WebGL support.
 * @memberof PIXI.utils
 * @function isWebGLSupported
 * @returns {boolean} Is WebGL supported.
 */
export declare function isWebGLSupported(): boolean;

/**
 * Computes ceil of log base 2
 * @function log2
 * @memberof PIXI.utils
 * @param {number} v - input value
 * @returns {number} logarithm base 2
 */
export declare function log2(v: number): number;

/**
 * Rounds to next power of two.
 * @function nextPow2
 * @memberof PIXI.utils
 * @param {number} v - input value
 * @returns {number} - next rounded power of two
 */
export declare function nextPow2(v: number): number;

declare type PackedArray = Float32Array | Uint32Array | Int32Array | Uint8Array;

/**
 * This file contains redeclared types for Node `url` and `querystring` modules. These modules
 * don't provide their own typings but instead are a part of the full Node typings. The purpose of
 * this file is to redeclare the required types to avoid having the whole Node types as a
 * dependency.
 */
declare interface ParsedUrlQuery {
    [key: string]: string | string[];
}

declare interface ParsedUrlQueryInput {
    [key: string]: any;
}

declare type ParseFunction = {
    (urlStr: string): UrlWithStringQuery;
    (urlStr: string, parseQueryString: false | undefined, slashesDenoteHost?: boolean): UrlWithStringQuery;
    (urlStr: string, parseQueryString: true, slashesDenoteHost?: boolean): UrlWithParsedQuery;
    (urlStr: string, parseQueryString: boolean, slashesDenoteHost?: boolean): Url;
};

export declare interface Path {
    toPosix: (path: string) => string;
    toAbsolute: (url: string, baseUrl?: string, rootUrl?: string) => string;
    isUrl: (path: string) => boolean;
    isDataUrl: (path: string) => boolean;
    hasProtocol: (path: string) => boolean;
    getProtocol: (path: string) => string;
    normalize: (path: string) => string;
    join: (...paths: string[]) => string;
    isAbsolute: (path: string) => boolean;
    dirname: (path: string) => string;
    rootname: (path: string) => string;
    basename: (path: string, ext?: string) => string;
    extname: (path: string) => string;
    parse: (path: string) => {
        root?: string;
        dir?: string;
        base?: string;
        ext?: string;
        name?: string;
    };
    sep: string;
    delimiter: string;
}

export declare const path: Path;

/**
 * maps premultiply flag and blendMode to adjusted blendMode
 * @memberof PIXI.utils
 * @constant premultiplyBlendMode
 * @type {Array<number[]>}
 */
export declare const premultiplyBlendMode: number[][];

/**
 * combines rgb and alpha to out array
 * @memberof PIXI.utils
 * @function premultiplyRgba
 * @param {Float32Array|number[]} rgb - input rgb
 * @param {number} alpha - alpha param
 * @param {Float32Array} [out] - output
 * @param {boolean} [premultiply=true] - do premultiply it
 * @returns {Float32Array} vec4 rgba
 */
export declare function premultiplyRgba(rgb: Float32Array | number[], alpha: number, outPixi?: Float32Array, premultiply?: boolean): Float32Array;

/**
 * premultiplies tint
 * @memberof PIXI.utils
 * @function premultiplyTint
 * @param {number} tint - integer RGB
 * @param {number} alpha - floating point alpha (0.0-1.0)
 * @returns {number} tint multiplied by alpha
 */
export declare function premultiplyTint(tint: number, alpha: number): number;

/**
 * converts integer tint and float alpha to vec4 form, premultiplies by default
 * @memberof PIXI.utils
 * @function premultiplyTintToRgba
 * @param {number} tint - input tint
 * @param {number} alpha - alpha param
 * @param {Float32Array} [out] - output
 * @param {boolean} [premultiply=true] - do premultiply it
 * @returns {Float32Array} vec4 rgba
 */
export declare function premultiplyTintToRgba(tint: number, alpha: number, outPixi: Float32Array, premultiply?: boolean): Float32Array;

/**
 * @todo Describe property usage
 * @static
 * @name ProgramCache
 * @memberof PIXI.utils
 * @type {object}
 */
export declare const ProgramCache: {
    [key: string]: Program;
};

/**
 * Remove items from a javascript array without generating garbage
 * @function removeItems
 * @memberof PIXI.utils
 * @param {Array<any>} arr - Array to remove elements from
 * @param {number} startIdx - starting index
 * @param {number} removeCount - how many to remove
 */
export declare function removeItems(arr: any[], startIdx: number, removeCount: number): void;

declare type ResolveFunction = {
    (from: string, to: string): string;
};

/**
 * Converts a color as an [R, G, B] array of normalized floats to a hexadecimal number.
 * @example
 * PIXI.utils.rgb2hex([1, 1, 1]); // returns 0xffffff
 * @memberof PIXI.utils
 * @function rgb2hex
 * @param {number[]} rgb - Array of numbers where all values are normalized floats from 0.0 to 1.0.
 * @returns {number} Number in hexadecimal.
 */
export declare function rgb2hex(rgb: number[] | Float32Array): number;

/**
 * Logs out the version and renderer information for this running instance of PIXI.
 * If you don't want to see this message you can run `PIXI.utils.skipHello()` before
 * creating your renderer. Keep in mind that doing that will forever make you a jerk face.
 * @static
 * @function sayHello
 * @memberof PIXI.utils
 * @param {string} type - The string renderer type to log.
 */
export declare function sayHello(type: string): void;

/**
 * Returns sign of number
 * @memberof PIXI.utils
 * @function sign
 * @param {number} n - the number to check the sign of
 * @returns {number} 0 if `n` is 0, -1 if `n` is negative, 1 if `n` is positive
 */
export declare function sign(n: number): -1 | 0 | 1;

/**
 * Skips the hello message of renderers that are created after this is run.
 * @function skipHello
 * @memberof PIXI.utils
 */
export declare function skipHello(): void;

/**
 * Converts a string to a hexadecimal color number.
 * It can handle:
 *  hex strings starting with #: "#ffffff"
 *  hex strings starting with 0x: "0xffffff"
 *  hex strings without prefix: "ffffff"
 *  css colors: "black"
 * @example
 * PIXI.utils.string2hex("#ffffff"); // returns 0xffffff
 * @memberof PIXI.utils
 * @function string2hex
 * @param {string} string - The string color (e.g., `"#ffffff"`)
 * @returns {number} Number in hexadecimal.
 */
export declare function string2hex(string: string): number;

/**
 * @todo Describe property usage
 * @static
 * @name TextureCache
 * @memberof PIXI.utils
 * @type {object}
 */
export declare const TextureCache: {
    [key: string]: Texture;
};

/**
 * Trim transparent borders from a canvas
 * @memberof PIXI.utils
 * @function trimCanvas
 * @param {HTMLCanvasElement} canvas - the canvas to trim
 * @returns {object} Trim data
 */
export declare function trimCanvas(canvas: HTMLCanvasElement): {
    width: number;
    height: number;
    data?: ImageData;
};

/**
 * Gets the next unique identifier
 * @memberof PIXI.utils
 * @function uid
 * @returns {number} The next unique identifier to use.
 */
export declare function uid(): number;

declare interface Url extends UrlObjectCommon {
    port?: string;
    query?: string | null | ParsedUrlQuery;
}

export declare const url: {
    parse: ParseFunction;
    format: FormatFunction;
    resolve: ResolveFunction;
};

declare interface URLFormatOptions {
    auth?: boolean;
    fragment?: boolean;
    search?: boolean;
    unicode?: boolean;
}

declare interface UrlObject extends UrlObjectCommon {
    port?: string | number;
    query?: string | null | ParsedUrlQueryInput;
}

declare interface UrlObjectCommon {
    auth?: string;
    hash?: string;
    host?: string;
    hostname?: string;
    href?: string;
    path?: string;
    pathname?: string;
    protocol?: string;
    search?: string;
    slashes?: boolean;
}

declare interface UrlWithParsedQuery extends Url {
    query: ParsedUrlQuery;
}

declare interface UrlWithStringQuery extends Url {
    query: string | null;
}

export { }
