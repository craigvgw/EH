/*!
 * @pixi/compressed-textures - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/compressed-textures is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

var core = require('@pixi/core');
var loaders = require('@pixi/loaders');
var utils = require('@pixi/utils');
var settings = require('@pixi/settings');
var constants = require('@pixi/constants');

var _a$2;
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
exports.INTERNAL_FORMATS = void 0;
(function (INTERNAL_FORMATS) {
    // WEBGL_compressed_texture_s3tc
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGB_S3TC_DXT1_EXT"] = 33776] = "COMPRESSED_RGB_S3TC_DXT1_EXT";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA_S3TC_DXT1_EXT"] = 33777] = "COMPRESSED_RGBA_S3TC_DXT1_EXT";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA_S3TC_DXT3_EXT"] = 33778] = "COMPRESSED_RGBA_S3TC_DXT3_EXT";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA_S3TC_DXT5_EXT"] = 33779] = "COMPRESSED_RGBA_S3TC_DXT5_EXT";
    // WEBGL_compressed_texture_s3tc_srgb
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT"] = 35917] = "COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT"] = 35918] = "COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT"] = 35919] = "COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SRGB_S3TC_DXT1_EXT"] = 35916] = "COMPRESSED_SRGB_S3TC_DXT1_EXT";
    // WEBGL_compressed_texture_etc
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_R11_EAC"] = 37488] = "COMPRESSED_R11_EAC";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SIGNED_R11_EAC"] = 37489] = "COMPRESSED_SIGNED_R11_EAC";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RG11_EAC"] = 37490] = "COMPRESSED_RG11_EAC";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SIGNED_RG11_EAC"] = 37491] = "COMPRESSED_SIGNED_RG11_EAC";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGB8_ETC2"] = 37492] = "COMPRESSED_RGB8_ETC2";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA8_ETC2_EAC"] = 37496] = "COMPRESSED_RGBA8_ETC2_EAC";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SRGB8_ETC2"] = 37493] = "COMPRESSED_SRGB8_ETC2";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SRGB8_ALPHA8_ETC2_EAC"] = 37497] = "COMPRESSED_SRGB8_ALPHA8_ETC2_EAC";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2"] = 37494] = "COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2"] = 37495] = "COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2";
    // WEBGL_compressed_texture_pvrtc
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGB_PVRTC_4BPPV1_IMG"] = 35840] = "COMPRESSED_RGB_PVRTC_4BPPV1_IMG";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA_PVRTC_4BPPV1_IMG"] = 35842] = "COMPRESSED_RGBA_PVRTC_4BPPV1_IMG";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGB_PVRTC_2BPPV1_IMG"] = 35841] = "COMPRESSED_RGB_PVRTC_2BPPV1_IMG";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA_PVRTC_2BPPV1_IMG"] = 35843] = "COMPRESSED_RGBA_PVRTC_2BPPV1_IMG";
    // WEBGL_compressed_texture_etc1
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGB_ETC1_WEBGL"] = 36196] = "COMPRESSED_RGB_ETC1_WEBGL";
    // WEBGL_compressed_texture_atc
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGB_ATC_WEBGL"] = 35986] = "COMPRESSED_RGB_ATC_WEBGL";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL"] = 35986] = "COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL";
    INTERNAL_FORMATS[INTERNAL_FORMATS["COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL"] = 34798] = "COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL";
})(exports.INTERNAL_FORMATS || (exports.INTERNAL_FORMATS = {}));
/**
 * Maps the compressed texture formats in {@link PIXI.INTERNAL_FORMATS} to the number of bytes taken by
 * each texel.
 * @memberof PIXI
 * @static
 * @ignore
 */
var INTERNAL_FORMAT_TO_BYTES_PER_PIXEL = (_a$2 = {},
    // WEBGL_compressed_texture_s3tc
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGB_S3TC_DXT1_EXT] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT1_EXT] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT3_EXT] = 1,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT5_EXT] = 1,
    // WEBGL_compressed_texture_s3tc
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SRGB_S3TC_DXT1_EXT] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT] = 1,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT] = 1,
    // WEBGL_compressed_texture_etc
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_R11_EAC] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SIGNED_R11_EAC] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RG11_EAC] = 1,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SIGNED_RG11_EAC] = 1,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGB8_ETC2] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA8_ETC2_EAC] = 1,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SRGB8_ETC2] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC] = 1,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2] = 0.5,
    // WEBGL_compressed_texture_pvrtc
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGB_PVRTC_4BPPV1_IMG] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA_PVRTC_4BPPV1_IMG] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGB_PVRTC_2BPPV1_IMG] = 0.25,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA_PVRTC_2BPPV1_IMG] = 0.25,
    // WEBGL_compressed_texture_etc1
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGB_ETC1_WEBGL] = 0.5,
    // @see https://www.khronos.org/registry/OpenGL/extensions/AMD/AMD_compressed_ATC_texture.txt
    // WEBGL_compressed_texture_atc
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGB_ATC_WEBGL] = 0.5,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL] = 1,
    _a$2[exports.INTERNAL_FORMATS.COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL] = 1,
    _a$2);

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

/**
 * Resource that fetches texture data over the network and stores it in a buffer.
 * @class
 * @extends PIXI.Resource
 * @memberof PIXI
 */
var BlobResource = /** @class */ (function (_super) {
    __extends(BlobResource, _super);
    /**
     * @param {string} source - the URL of the texture file
     * @param {PIXI.IBlobOptions} options
     * @param {boolean}[options.autoLoad] - whether to fetch the data immediately;
     *  you can fetch it later via {@link BlobResource#load}
     * @param {boolean}[options.width] - the width in pixels.
     * @param {boolean}[options.height] - the height in pixels.
     */
    function BlobResource(source, options) {
        if (options === void 0) { options = { width: 1, height: 1, autoLoad: true }; }
        var _this = this;
        var origin;
        var data;
        if (typeof source === 'string') {
            origin = source;
            data = new Uint8Array();
        }
        else {
            origin = null;
            data = source;
        }
        _this = _super.call(this, data, options) || this;
        /**
         * The URL of the texture file
         * @member {string}
         */
        _this.origin = origin;
        /**
         * The viewable buffer on the data
         * @member {ViewableBuffer}
         */
        // HINT: BlobResource allows "null" sources, assuming the child class provides an alternative
        _this.buffer = data ? new core.ViewableBuffer(data) : null;
        // Allow autoLoad = "undefined" still load the resource by default
        if (_this.origin && options.autoLoad !== false) {
            _this.load();
        }
        if (data && data.length) {
            _this.loaded = true;
            _this.onBlobLoaded(_this.buffer.rawBinaryData);
        }
        return _this;
    }
    BlobResource.prototype.onBlobLoaded = function (_data) {
        // TODO: Override this method
    };
    /** Loads the blob */
    BlobResource.prototype.load = function () {
        return __awaiter(this, void 0, Promise, function () {
            var response, blob, arrayBuffer;
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0: return [4 /*yield*/, fetch(this.origin)];
                    case 1:
                        response = _a.sent();
                        return [4 /*yield*/, response.blob()];
                    case 2:
                        blob = _a.sent();
                        return [4 /*yield*/, blob.arrayBuffer()];
                    case 3:
                        arrayBuffer = _a.sent();
                        this.data = new Uint32Array(arrayBuffer);
                        this.buffer = new core.ViewableBuffer(arrayBuffer);
                        this.loaded = true;
                        this.onBlobLoaded(arrayBuffer);
                        this.update();
                        return [2 /*return*/, this];
                }
            });
        });
    };
    return BlobResource;
}(core.BufferResource));

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
var CompressedTextureResource = /** @class */ (function (_super) {
    __extends(CompressedTextureResource, _super);
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
    function CompressedTextureResource(source, options) {
        var _this = _super.call(this, source, options) || this;
        _this.format = options.format;
        _this.levels = options.levels || 1;
        _this._width = options.width;
        _this._height = options.height;
        _this._extension = CompressedTextureResource._formatToExtension(_this.format);
        if (options.levelBuffers || _this.buffer) {
            // ViewableBuffer doesn't support byteOffset :-( so allow source to be Uint8Array
            _this._levelBuffers = options.levelBuffers
                || CompressedTextureResource._createLevelBuffers(source instanceof Uint8Array ? source : _this.buffer.uint8View, _this.format, _this.levels, 4, 4, // PVRTC has 8x4 blocks in 2bpp mode
                _this.width, _this.height);
        }
        return _this;
    }
    /**
     * @override
     * @param renderer - A reference to the current renderer
     * @param _texture - the texture
     * @param _glTexture - texture instance for this webgl context
     */
    CompressedTextureResource.prototype.upload = function (renderer, _texture, _glTexture) {
        var gl = renderer.gl;
        var extension = renderer.context.extensions[this._extension];
        if (!extension) {
            throw new Error(this._extension + " textures are not supported on the current machine");
        }
        if (!this._levelBuffers) {
            // Do not try to upload data before BlobResource loads, unless the levelBuffers were provided directly!
            return false;
        }
        for (var i = 0, j = this.levels; i < j; i++) {
            var _a = this._levelBuffers[i], levelID = _a.levelID, levelWidth = _a.levelWidth, levelHeight = _a.levelHeight, levelBuffer = _a.levelBuffer;
            gl.compressedTexImage2D(gl.TEXTURE_2D, levelID, this.format, levelWidth, levelHeight, 0, levelBuffer);
        }
        return true;
    };
    /** @protected */
    CompressedTextureResource.prototype.onBlobLoaded = function () {
        this._levelBuffers = CompressedTextureResource._createLevelBuffers(this.buffer.uint8View, this.format, this.levels, 4, 4, // PVRTC has 8x4 blocks in 2bpp mode
        this.width, this.height);
    };
    /**
     * Returns the key (to ContextSystem#extensions) for the WebGL extension supporting the compression format
     * @private
     * @param format - the compression format to get the extension for.
     */
    CompressedTextureResource._formatToExtension = function (format) {
        if (format >= 0x83F0 && format <= 0x83F3) {
            return 's3tc';
        }
        else if (format >= 0x9270 && format <= 0x9279) {
            return 'etc';
        }
        else if (format >= 0x8C00 && format <= 0x8C03) {
            return 'pvrtc';
        }
        else if (format >= 0x8D64) {
            return 'etc1';
        }
        else if (format >= 0x8C92 && format <= 0x87EE) {
            return 'atc';
        }
        throw new Error('Invalid (compressed) texture format given!');
    };
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
    CompressedTextureResource._createLevelBuffers = function (buffer, format, levels, blockWidth, blockHeight, imageWidth, imageHeight) {
        // The byte-size of the first level buffer
        var buffers = new Array(levels);
        var offset = buffer.byteOffset;
        var levelWidth = imageWidth;
        var levelHeight = imageHeight;
        var alignedLevelWidth = (levelWidth + blockWidth - 1) & ~(blockWidth - 1);
        var alignedLevelHeight = (levelHeight + blockHeight - 1) & ~(blockHeight - 1);
        var levelSize = alignedLevelWidth * alignedLevelHeight * INTERNAL_FORMAT_TO_BYTES_PER_PIXEL[format];
        for (var i = 0; i < levels; i++) {
            buffers[i] = {
                levelID: i,
                levelWidth: levels > 1 ? levelWidth : alignedLevelWidth,
                levelHeight: levels > 1 ? levelHeight : alignedLevelHeight,
                levelBuffer: new Uint8Array(buffer.buffer, offset, levelSize)
            };
            offset += levelSize;
            // Calculate levelBuffer dimensions for next iteration
            levelWidth = (levelWidth >> 1) || 1;
            levelHeight = (levelHeight >> 1) || 1;
            alignedLevelWidth = (levelWidth + blockWidth - 1) & ~(blockWidth - 1);
            alignedLevelHeight = (levelHeight + blockHeight - 1) & ~(blockHeight - 1);
            levelSize = alignedLevelWidth * alignedLevelHeight * INTERNAL_FORMAT_TO_BYTES_PER_PIXEL[format];
        }
        return buffers;
    };
    return CompressedTextureResource;
}(BlobResource));

/* eslint-enable camelcase */
/**
 * Loader plugin for handling compressed textures for all platforms.
 * @class
 * @memberof PIXI
 * @implements {PIXI.ILoaderPlugin}
 */
var CompressedTextureLoader = /** @class */ (function () {
    function CompressedTextureLoader() {
    }
    /**
     * Called after a compressed-textures manifest is loaded.
     *
     * This will then load the correct compression format for the device. Your manifest should adhere
     * to the following schema:
     *
     * ```js
     * import { INTERNAL_FORMATS } from '@pixi/constants';
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
    CompressedTextureLoader.use = function (resource, next) {
        var data = resource.data;
        var loader = this;
        if (resource.type === loaders.LoaderResource.TYPE.JSON
            && data
            && data.cacheID
            && data.textures) {
            var textures = data.textures;
            var textureURL = void 0;
            var fallbackURL = void 0;
            // Search for an extension that holds one the formats
            for (var i = 0, j = textures.length; i < j; i++) {
                var texture = textures[i];
                var url_1 = texture.src;
                var format = texture.format;
                if (!format) {
                    fallbackURL = url_1;
                }
                if (CompressedTextureLoader.textureFormats[format]) {
                    textureURL = url_1;
                    break;
                }
            }
            textureURL = textureURL || fallbackURL;
            // Make sure we have a URL
            if (!textureURL) {
                next(new Error("Cannot load compressed-textures in " + resource.url + ", make sure you provide a fallback"));
                return;
            }
            if (textureURL === resource.url) {
                // Prevent infinite loops
                next(new Error('URL of compressed texture cannot be the same as the manifest\'s URL'));
                return;
            }
            var loadOptions = {
                crossOrigin: resource.crossOrigin,
                metadata: resource.metadata.imageMetadata,
                parentResource: resource
            };
            var resourcePath = utils.url.resolve(resource.url.replace(loader.baseUrl, ''), textureURL);
            var resourceName = data.cacheID;
            // The appropriate loader should register the texture
            loader.add(resourceName, resourcePath, loadOptions, function (res) {
                if (res.error) {
                    next(res.error);
                    return;
                }
                var _a = res.texture, texture = _a === void 0 ? null : _a, _b = res.textures, textures = _b === void 0 ? {} : _b;
                // Make sure texture/textures is assigned to parent resource
                Object.assign(resource, { texture: texture, textures: textures });
                // Pass along any error
                next();
            });
        }
        else {
            next();
        }
    };
    Object.defineProperty(CompressedTextureLoader, "textureExtensions", {
        /**  Map of available texture extensions. */
        get: function () {
            if (!CompressedTextureLoader._textureExtensions) {
                // Auto-detect WebGL compressed-texture extensions
                var canvas = settings.settings.ADAPTER.createCanvas();
                var gl = canvas.getContext('webgl');
                if (!gl) {
                    console.warn('WebGL not available for compressed textures. Silently failing.');
                    return {};
                }
                var extensions = {
                    s3tc: gl.getExtension('WEBGL_compressed_texture_s3tc'),
                    s3tc_sRGB: gl.getExtension('WEBGL_compressed_texture_s3tc_srgb'),
                    etc: gl.getExtension('WEBGL_compressed_texture_etc'),
                    etc1: gl.getExtension('WEBGL_compressed_texture_etc1'),
                    pvrtc: gl.getExtension('WEBGL_compressed_texture_pvrtc')
                        || gl.getExtension('WEBKIT_WEBGL_compressed_texture_pvrtc'),
                    atc: gl.getExtension('WEBGL_compressed_texture_atc'),
                    astc: gl.getExtension('WEBGL_compressed_texture_astc')
                };
                CompressedTextureLoader._textureExtensions = extensions;
            }
            return CompressedTextureLoader._textureExtensions;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(CompressedTextureLoader, "textureFormats", {
        /** Map of available texture formats. */
        get: function () {
            if (!CompressedTextureLoader._textureFormats) {
                var extensions = CompressedTextureLoader.textureExtensions;
                CompressedTextureLoader._textureFormats = {};
                // Assign all available compressed-texture formats
                for (var extensionName in extensions) {
                    var extension = extensions[extensionName];
                    if (!extension) {
                        continue;
                    }
                    Object.assign(CompressedTextureLoader._textureFormats, Object.getPrototypeOf(extension));
                }
            }
            return CompressedTextureLoader._textureFormats;
        },
        enumerable: false,
        configurable: true
    });
    /** @ignore */
    CompressedTextureLoader.extension = core.ExtensionType.Loader;
    return CompressedTextureLoader;
}());

/**
 * Creates base-textures and textures for each compressed-texture resource and adds them into the global
 * texture cache. The first texture has two IDs - `${url}`, `${url}-1`; while the rest have an ID of the
 * form `${url}-i`.
 * @param url - the original address of the resources
 * @param resources - the resources backing texture data
 * @ignore
 */
function registerCompressedTextures(url, resources, metadata) {
    var result = {
        textures: {},
        texture: null,
    };
    if (!resources) {
        return result;
    }
    var textures = resources.map(function (resource) {
        return (new core.Texture(new core.BaseTexture(resource, Object.assign({
            mipmap: constants.MIPMAP_MODES.OFF,
            alphaMode: constants.ALPHA_MODES.NO_PREMULTIPLIED_ALPHA
        }, metadata))));
    });
    textures.forEach(function (texture, i) {
        var baseTexture = texture.baseTexture;
        var cacheID = url + "-" + (i + 1);
        core.BaseTexture.addToCache(baseTexture, cacheID);
        core.Texture.addToCache(texture, cacheID);
        if (i === 0) {
            core.BaseTexture.addToCache(baseTexture, url);
            core.Texture.addToCache(texture, url);
            result.texture = texture;
        }
        result.textures[cacheID] = texture;
    });
    return result;
}

var _a$1, _b$1;
var DDS_MAGIC_SIZE = 4;
var DDS_HEADER_SIZE = 124;
var DDS_HEADER_PF_SIZE = 32;
var DDS_HEADER_DX10_SIZE = 20;
// DDS file format magic word
var DDS_MAGIC = 0x20534444;
/**
 * DWORD offsets of the DDS file header fields (relative to file start).
 * @ignore
 */
var DDS_FIELDS = {
    SIZE: 1,
    FLAGS: 2,
    HEIGHT: 3,
    WIDTH: 4,
    MIPMAP_COUNT: 7,
    PIXEL_FORMAT: 19,
};
/**
 * DWORD offsets of the DDS PIXEL_FORMAT fields.
 * @ignore
 */
var DDS_PF_FIELDS = {
    SIZE: 0,
    FLAGS: 1,
    FOURCC: 2,
    RGB_BITCOUNT: 3,
    R_BIT_MASK: 4,
    G_BIT_MASK: 5,
    B_BIT_MASK: 6,
    A_BIT_MASK: 7
};
/**
 * DWORD offsets of the DDS_HEADER_DX10 fields.
 * @ignore
 */
var DDS_DX10_FIELDS = {
    DXGI_FORMAT: 0,
    RESOURCE_DIMENSION: 1,
    MISC_FLAG: 2,
    ARRAY_SIZE: 3,
    MISC_FLAGS2: 4
};
/**
 * @see https://docs.microsoft.com/en-us/windows/win32/api/dxgiformat/ne-dxgiformat-dxgi_format
 * @ignore
 */
// This is way over-blown for us! Lend us a hand, and remove the ones that aren't used (but set the remaining
// ones to their correct value)
var DXGI_FORMAT;
(function (DXGI_FORMAT) {
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_UNKNOWN"] = 0] = "DXGI_FORMAT_UNKNOWN";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32A32_TYPELESS"] = 1] = "DXGI_FORMAT_R32G32B32A32_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32A32_FLOAT"] = 2] = "DXGI_FORMAT_R32G32B32A32_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32A32_UINT"] = 3] = "DXGI_FORMAT_R32G32B32A32_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32A32_SINT"] = 4] = "DXGI_FORMAT_R32G32B32A32_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32_TYPELESS"] = 5] = "DXGI_FORMAT_R32G32B32_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32_FLOAT"] = 6] = "DXGI_FORMAT_R32G32B32_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32_UINT"] = 7] = "DXGI_FORMAT_R32G32B32_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32B32_SINT"] = 8] = "DXGI_FORMAT_R32G32B32_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16B16A16_TYPELESS"] = 9] = "DXGI_FORMAT_R16G16B16A16_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16B16A16_FLOAT"] = 10] = "DXGI_FORMAT_R16G16B16A16_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16B16A16_UNORM"] = 11] = "DXGI_FORMAT_R16G16B16A16_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16B16A16_UINT"] = 12] = "DXGI_FORMAT_R16G16B16A16_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16B16A16_SNORM"] = 13] = "DXGI_FORMAT_R16G16B16A16_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16B16A16_SINT"] = 14] = "DXGI_FORMAT_R16G16B16A16_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32_TYPELESS"] = 15] = "DXGI_FORMAT_R32G32_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32_FLOAT"] = 16] = "DXGI_FORMAT_R32G32_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32_UINT"] = 17] = "DXGI_FORMAT_R32G32_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G32_SINT"] = 18] = "DXGI_FORMAT_R32G32_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32G8X24_TYPELESS"] = 19] = "DXGI_FORMAT_R32G8X24_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_D32_FLOAT_S8X24_UINT"] = 20] = "DXGI_FORMAT_D32_FLOAT_S8X24_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS"] = 21] = "DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_X32_TYPELESS_G8X24_UINT"] = 22] = "DXGI_FORMAT_X32_TYPELESS_G8X24_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R10G10B10A2_TYPELESS"] = 23] = "DXGI_FORMAT_R10G10B10A2_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R10G10B10A2_UNORM"] = 24] = "DXGI_FORMAT_R10G10B10A2_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R10G10B10A2_UINT"] = 25] = "DXGI_FORMAT_R10G10B10A2_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R11G11B10_FLOAT"] = 26] = "DXGI_FORMAT_R11G11B10_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8B8A8_TYPELESS"] = 27] = "DXGI_FORMAT_R8G8B8A8_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8B8A8_UNORM"] = 28] = "DXGI_FORMAT_R8G8B8A8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8B8A8_UNORM_SRGB"] = 29] = "DXGI_FORMAT_R8G8B8A8_UNORM_SRGB";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8B8A8_UINT"] = 30] = "DXGI_FORMAT_R8G8B8A8_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8B8A8_SNORM"] = 31] = "DXGI_FORMAT_R8G8B8A8_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8B8A8_SINT"] = 32] = "DXGI_FORMAT_R8G8B8A8_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16_TYPELESS"] = 33] = "DXGI_FORMAT_R16G16_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16_FLOAT"] = 34] = "DXGI_FORMAT_R16G16_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16_UNORM"] = 35] = "DXGI_FORMAT_R16G16_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16_UINT"] = 36] = "DXGI_FORMAT_R16G16_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16_SNORM"] = 37] = "DXGI_FORMAT_R16G16_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16G16_SINT"] = 38] = "DXGI_FORMAT_R16G16_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32_TYPELESS"] = 39] = "DXGI_FORMAT_R32_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_D32_FLOAT"] = 40] = "DXGI_FORMAT_D32_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32_FLOAT"] = 41] = "DXGI_FORMAT_R32_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32_UINT"] = 42] = "DXGI_FORMAT_R32_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R32_SINT"] = 43] = "DXGI_FORMAT_R32_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R24G8_TYPELESS"] = 44] = "DXGI_FORMAT_R24G8_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_D24_UNORM_S8_UINT"] = 45] = "DXGI_FORMAT_D24_UNORM_S8_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R24_UNORM_X8_TYPELESS"] = 46] = "DXGI_FORMAT_R24_UNORM_X8_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_X24_TYPELESS_G8_UINT"] = 47] = "DXGI_FORMAT_X24_TYPELESS_G8_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8_TYPELESS"] = 48] = "DXGI_FORMAT_R8G8_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8_UNORM"] = 49] = "DXGI_FORMAT_R8G8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8_UINT"] = 50] = "DXGI_FORMAT_R8G8_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8_SNORM"] = 51] = "DXGI_FORMAT_R8G8_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8_SINT"] = 52] = "DXGI_FORMAT_R8G8_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16_TYPELESS"] = 53] = "DXGI_FORMAT_R16_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16_FLOAT"] = 54] = "DXGI_FORMAT_R16_FLOAT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_D16_UNORM"] = 55] = "DXGI_FORMAT_D16_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16_UNORM"] = 56] = "DXGI_FORMAT_R16_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16_UINT"] = 57] = "DXGI_FORMAT_R16_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16_SNORM"] = 58] = "DXGI_FORMAT_R16_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R16_SINT"] = 59] = "DXGI_FORMAT_R16_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8_TYPELESS"] = 60] = "DXGI_FORMAT_R8_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8_UNORM"] = 61] = "DXGI_FORMAT_R8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8_UINT"] = 62] = "DXGI_FORMAT_R8_UINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8_SNORM"] = 63] = "DXGI_FORMAT_R8_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8_SINT"] = 64] = "DXGI_FORMAT_R8_SINT";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_A8_UNORM"] = 65] = "DXGI_FORMAT_A8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R1_UNORM"] = 66] = "DXGI_FORMAT_R1_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R9G9B9E5_SHAREDEXP"] = 67] = "DXGI_FORMAT_R9G9B9E5_SHAREDEXP";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R8G8_B8G8_UNORM"] = 68] = "DXGI_FORMAT_R8G8_B8G8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_G8R8_G8B8_UNORM"] = 69] = "DXGI_FORMAT_G8R8_G8B8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC1_TYPELESS"] = 70] = "DXGI_FORMAT_BC1_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC1_UNORM"] = 71] = "DXGI_FORMAT_BC1_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC1_UNORM_SRGB"] = 72] = "DXGI_FORMAT_BC1_UNORM_SRGB";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC2_TYPELESS"] = 73] = "DXGI_FORMAT_BC2_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC2_UNORM"] = 74] = "DXGI_FORMAT_BC2_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC2_UNORM_SRGB"] = 75] = "DXGI_FORMAT_BC2_UNORM_SRGB";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC3_TYPELESS"] = 76] = "DXGI_FORMAT_BC3_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC3_UNORM"] = 77] = "DXGI_FORMAT_BC3_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC3_UNORM_SRGB"] = 78] = "DXGI_FORMAT_BC3_UNORM_SRGB";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC4_TYPELESS"] = 79] = "DXGI_FORMAT_BC4_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC4_UNORM"] = 80] = "DXGI_FORMAT_BC4_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC4_SNORM"] = 81] = "DXGI_FORMAT_BC4_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC5_TYPELESS"] = 82] = "DXGI_FORMAT_BC5_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC5_UNORM"] = 83] = "DXGI_FORMAT_BC5_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC5_SNORM"] = 84] = "DXGI_FORMAT_BC5_SNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B5G6R5_UNORM"] = 85] = "DXGI_FORMAT_B5G6R5_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B5G5R5A1_UNORM"] = 86] = "DXGI_FORMAT_B5G5R5A1_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B8G8R8A8_UNORM"] = 87] = "DXGI_FORMAT_B8G8R8A8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B8G8R8X8_UNORM"] = 88] = "DXGI_FORMAT_B8G8R8X8_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM"] = 89] = "DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B8G8R8A8_TYPELESS"] = 90] = "DXGI_FORMAT_B8G8R8A8_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B8G8R8A8_UNORM_SRGB"] = 91] = "DXGI_FORMAT_B8G8R8A8_UNORM_SRGB";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B8G8R8X8_TYPELESS"] = 92] = "DXGI_FORMAT_B8G8R8X8_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B8G8R8X8_UNORM_SRGB"] = 93] = "DXGI_FORMAT_B8G8R8X8_UNORM_SRGB";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC6H_TYPELESS"] = 94] = "DXGI_FORMAT_BC6H_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC6H_UF16"] = 95] = "DXGI_FORMAT_BC6H_UF16";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC6H_SF16"] = 96] = "DXGI_FORMAT_BC6H_SF16";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC7_TYPELESS"] = 97] = "DXGI_FORMAT_BC7_TYPELESS";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC7_UNORM"] = 98] = "DXGI_FORMAT_BC7_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_BC7_UNORM_SRGB"] = 99] = "DXGI_FORMAT_BC7_UNORM_SRGB";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_AYUV"] = 100] = "DXGI_FORMAT_AYUV";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_Y410"] = 101] = "DXGI_FORMAT_Y410";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_Y416"] = 102] = "DXGI_FORMAT_Y416";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_NV12"] = 103] = "DXGI_FORMAT_NV12";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_P010"] = 104] = "DXGI_FORMAT_P010";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_P016"] = 105] = "DXGI_FORMAT_P016";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_420_OPAQUE"] = 106] = "DXGI_FORMAT_420_OPAQUE";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_YUY2"] = 107] = "DXGI_FORMAT_YUY2";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_Y210"] = 108] = "DXGI_FORMAT_Y210";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_Y216"] = 109] = "DXGI_FORMAT_Y216";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_NV11"] = 110] = "DXGI_FORMAT_NV11";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_AI44"] = 111] = "DXGI_FORMAT_AI44";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_IA44"] = 112] = "DXGI_FORMAT_IA44";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_P8"] = 113] = "DXGI_FORMAT_P8";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_A8P8"] = 114] = "DXGI_FORMAT_A8P8";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_B4G4R4A4_UNORM"] = 115] = "DXGI_FORMAT_B4G4R4A4_UNORM";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_P208"] = 116] = "DXGI_FORMAT_P208";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_V208"] = 117] = "DXGI_FORMAT_V208";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_V408"] = 118] = "DXGI_FORMAT_V408";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE"] = 119] = "DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE"] = 120] = "DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE";
    DXGI_FORMAT[DXGI_FORMAT["DXGI_FORMAT_FORCE_UINT"] = 121] = "DXGI_FORMAT_FORCE_UINT";
})(DXGI_FORMAT || (DXGI_FORMAT = {}));
/**
 * Possible values of the field {@link DDS_DX10_FIELDS.RESOURCE_DIMENSION}
 * @ignore
 */
var D3D10_RESOURCE_DIMENSION;
(function (D3D10_RESOURCE_DIMENSION) {
    D3D10_RESOURCE_DIMENSION[D3D10_RESOURCE_DIMENSION["DDS_DIMENSION_TEXTURE1D"] = 2] = "DDS_DIMENSION_TEXTURE1D";
    D3D10_RESOURCE_DIMENSION[D3D10_RESOURCE_DIMENSION["DDS_DIMENSION_TEXTURE2D"] = 3] = "DDS_DIMENSION_TEXTURE2D";
    D3D10_RESOURCE_DIMENSION[D3D10_RESOURCE_DIMENSION["DDS_DIMENSION_TEXTURE3D"] = 6] = "DDS_DIMENSION_TEXTURE3D";
})(D3D10_RESOURCE_DIMENSION || (D3D10_RESOURCE_DIMENSION = {}));
var PF_FLAGS = 1;
// PIXEL_FORMAT flags
var DDPF_ALPHA = 0x2;
var DDPF_FOURCC = 0x4;
var DDPF_RGB = 0x40;
var DDPF_YUV = 0x200;
var DDPF_LUMINANCE = 0x20000;
// Four character codes for DXTn formats
var FOURCC_DXT1 = 0x31545844;
var FOURCC_DXT3 = 0x33545844;
var FOURCC_DXT5 = 0x35545844;
var FOURCC_DX10 = 0x30315844;
// Cubemap texture flag (for DDS_DX10_FIELDS.MISC_FLAG)
var DDS_RESOURCE_MISC_TEXTURECUBE = 0x4;
/**
 * Maps `FOURCC_*` formats to internal formats (see {@link PIXI.INTERNAL_FORMATS}).
 * @ignore
 */
var FOURCC_TO_FORMAT = (_a$1 = {},
    _a$1[FOURCC_DXT1] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT1_EXT,
    _a$1[FOURCC_DXT3] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT3_EXT,
    _a$1[FOURCC_DXT5] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT5_EXT,
    _a$1);
/**
 * Maps {@link DXGI_FORMAT} to types/internal-formats (see {@link PIXI.TYPES}, {@link PIXI.INTERNAL_FORMATS})
 * @ignore
 */
var DXGI_TO_FORMAT = (_b$1 = {},
    // WEBGL_compressed_texture_s3tc
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC1_TYPELESS] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT1_EXT,
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT1_EXT,
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC2_TYPELESS] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT3_EXT,
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT3_EXT,
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC3_TYPELESS] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT5_EXT,
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM] = exports.INTERNAL_FORMATS.COMPRESSED_RGBA_S3TC_DXT5_EXT,
    // WEBGL_compressed_texture_s3tc_srgb
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB] = exports.INTERNAL_FORMATS.COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT,
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM_SRGB] = exports.INTERNAL_FORMATS.COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT,
    _b$1[DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB] = exports.INTERNAL_FORMATS.COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT,
    _b$1);
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
function parseDDS(arrayBuffer) {
    var data = new Uint32Array(arrayBuffer);
    var magicWord = data[0];
    if (magicWord !== DDS_MAGIC) {
        throw new Error('Invalid DDS file magic word');
    }
    var header = new Uint32Array(arrayBuffer, 0, DDS_HEADER_SIZE / Uint32Array.BYTES_PER_ELEMENT);
    // DDS header fields
    var height = header[DDS_FIELDS.HEIGHT];
    var width = header[DDS_FIELDS.WIDTH];
    var mipmapCount = header[DDS_FIELDS.MIPMAP_COUNT];
    // PIXEL_FORMAT fields
    var pixelFormat = new Uint32Array(arrayBuffer, DDS_FIELDS.PIXEL_FORMAT * Uint32Array.BYTES_PER_ELEMENT, DDS_HEADER_PF_SIZE / Uint32Array.BYTES_PER_ELEMENT);
    var formatFlags = pixelFormat[PF_FLAGS];
    // File contains compressed texture(s)
    if (formatFlags & DDPF_FOURCC) {
        var fourCC = pixelFormat[DDS_PF_FIELDS.FOURCC];
        // File contains one DXTn compressed texture
        if (fourCC !== FOURCC_DX10) {
            var internalFormat_1 = FOURCC_TO_FORMAT[fourCC];
            var dataOffset_1 = DDS_MAGIC_SIZE + DDS_HEADER_SIZE;
            var texData = new Uint8Array(arrayBuffer, dataOffset_1);
            var resource = new CompressedTextureResource(texData, {
                format: internalFormat_1,
                width: width,
                height: height,
                levels: mipmapCount // CompressedTextureResource will separate the levelBuffers for us!
            });
            return [resource];
        }
        // FOURCC_DX10 indicates there is a 20-byte DDS_HEADER_DX10 after DDS_HEADER
        var dx10Offset = DDS_MAGIC_SIZE + DDS_HEADER_SIZE;
        var dx10Header = new Uint32Array(data.buffer, dx10Offset, DDS_HEADER_DX10_SIZE / Uint32Array.BYTES_PER_ELEMENT);
        var dxgiFormat = dx10Header[DDS_DX10_FIELDS.DXGI_FORMAT];
        var resourceDimension = dx10Header[DDS_DX10_FIELDS.RESOURCE_DIMENSION];
        var miscFlag = dx10Header[DDS_DX10_FIELDS.MISC_FLAG];
        var arraySize = dx10Header[DDS_DX10_FIELDS.ARRAY_SIZE];
        // Map dxgiFormat to PIXI.INTERNAL_FORMATS
        var internalFormat_2 = DXGI_TO_FORMAT[dxgiFormat];
        if (internalFormat_2 === undefined) {
            throw new Error("DDSParser cannot parse texture data with DXGI format " + dxgiFormat);
        }
        if (miscFlag === DDS_RESOURCE_MISC_TEXTURECUBE) {
            // FIXME: Anybody excited about cubemap compressed textures?
            throw new Error('DDSParser does not support cubemap textures');
        }
        if (resourceDimension === D3D10_RESOURCE_DIMENSION.DDS_DIMENSION_TEXTURE3D) {
            // FIXME: Anybody excited about 3D compressed textures?
            throw new Error('DDSParser does not supported 3D texture data');
        }
        // Uint8Array buffers of image data, including all mipmap levels in each image
        var imageBuffers = new Array();
        var dataOffset = DDS_MAGIC_SIZE
            + DDS_HEADER_SIZE
            + DDS_HEADER_DX10_SIZE;
        if (arraySize === 1) {
            // No need bothering with the imageSize calculation!
            imageBuffers.push(new Uint8Array(arrayBuffer, dataOffset));
        }
        else {
            // Calculate imageSize for each texture, and then locate each image's texture data
            var pixelSize = INTERNAL_FORMAT_TO_BYTES_PER_PIXEL[internalFormat_2];
            var imageSize = 0;
            var levelWidth = width;
            var levelHeight = height;
            for (var i = 0; i < mipmapCount; i++) {
                var alignedLevelWidth = Math.max(1, (levelWidth + 3) & ~3);
                var alignedLevelHeight = Math.max(1, (levelHeight + 3) & ~3);
                var levelSize = alignedLevelWidth * alignedLevelHeight * pixelSize;
                imageSize += levelSize;
                levelWidth = levelWidth >>> 1;
                levelHeight = levelHeight >>> 1;
            }
            var imageOffset = dataOffset;
            // NOTE: Cubemaps have 6-images per texture (but they aren't supported so ^_^)
            for (var i = 0; i < arraySize; i++) {
                imageBuffers.push(new Uint8Array(arrayBuffer, imageOffset, imageSize));
                imageOffset += imageSize;
            }
        }
        // Uint8Array -> CompressedTextureResource, and we're done!
        return imageBuffers.map(function (buffer) { return new CompressedTextureResource(buffer, {
            format: internalFormat_2,
            width: width,
            height: height,
            levels: mipmapCount
        }); });
    }
    if (formatFlags & DDPF_RGB) {
        // FIXME: We might want to allow uncompressed *.dds files?
        throw new Error('DDSParser does not support uncompressed texture data.');
    }
    if (formatFlags & DDPF_YUV) {
        // FIXME: Does anybody need this feature?
        throw new Error('DDSParser does not supported YUV uncompressed texture data.');
    }
    if (formatFlags & DDPF_LUMINANCE) {
        // FIXME: Microsoft says older DDS filers use this feature! Probably not worth the effort!
        throw new Error('DDSParser does not support single-channel (lumninance) texture data!');
    }
    if (formatFlags & DDPF_ALPHA) {
        // FIXME: I'm tired! See above =)
        throw new Error('DDSParser does not support single-channel (alpha) texture data!');
    }
    throw new Error('DDSParser failed to load a texture file due to an unknown reason!');
}

var _a, _b, _c;
/**
 * The 12-byte KTX file identifier
 * @see https://www.khronos.org/opengles/sdk/tools/KTX/file_format_spec/#2.1
 * @ignore
 */
var FILE_IDENTIFIER = [0xAB, 0x4B, 0x54, 0x58, 0x20, 0x31, 0x31, 0xBB, 0x0D, 0x0A, 0x1A, 0x0A];
/**
 * The value stored in the "endianness" field.
 * @see https://www.khronos.org/opengles/sdk/tools/KTX/file_format_spec/#2.2
 * @ignore
 */
var ENDIANNESS = 0x04030201;
/**
 * Byte offsets of the KTX file header fields
 * @ignore
 */
var KTX_FIELDS = {
    FILE_IDENTIFIER: 0,
    ENDIANNESS: 12,
    GL_TYPE: 16,
    GL_TYPE_SIZE: 20,
    GL_FORMAT: 24,
    GL_INTERNAL_FORMAT: 28,
    GL_BASE_INTERNAL_FORMAT: 32,
    PIXEL_WIDTH: 36,
    PIXEL_HEIGHT: 40,
    PIXEL_DEPTH: 44,
    NUMBER_OF_ARRAY_ELEMENTS: 48,
    NUMBER_OF_FACES: 52,
    NUMBER_OF_MIPMAP_LEVELS: 56,
    BYTES_OF_KEY_VALUE_DATA: 60
};
/**
 * Byte size of the file header fields in {@code KTX_FIELDS}
 * @ignore
 */
var FILE_HEADER_SIZE = 64;
/**
 * Maps {@link PIXI.TYPES} to the bytes taken per component, excluding those ones that are bit-fields.
 * @ignore
 */
var TYPES_TO_BYTES_PER_COMPONENT = (_a = {},
    _a[constants.TYPES.UNSIGNED_BYTE] = 1,
    _a[constants.TYPES.UNSIGNED_SHORT] = 2,
    _a[constants.TYPES.INT] = 4,
    _a[constants.TYPES.UNSIGNED_INT] = 4,
    _a[constants.TYPES.FLOAT] = 4,
    _a[constants.TYPES.HALF_FLOAT] = 8,
    _a);
/**
 * Number of components in each {@link PIXI.FORMATS}
 * @ignore
 */
var FORMATS_TO_COMPONENTS = (_b = {},
    _b[constants.FORMATS.RGBA] = 4,
    _b[constants.FORMATS.RGB] = 3,
    _b[constants.FORMATS.RG] = 2,
    _b[constants.FORMATS.RED] = 1,
    _b[constants.FORMATS.LUMINANCE] = 1,
    _b[constants.FORMATS.LUMINANCE_ALPHA] = 2,
    _b[constants.FORMATS.ALPHA] = 1,
    _b);
/**
 * Number of bytes per pixel in bit-field types in {@link PIXI.TYPES}
 * @ignore
 */
var TYPES_TO_BYTES_PER_PIXEL = (_c = {},
    _c[constants.TYPES.UNSIGNED_SHORT_4_4_4_4] = 2,
    _c[constants.TYPES.UNSIGNED_SHORT_5_5_5_1] = 2,
    _c[constants.TYPES.UNSIGNED_SHORT_5_6_5] = 2,
    _c);
function parseKTX(url, arrayBuffer, loadKeyValueData) {
    if (loadKeyValueData === void 0) { loadKeyValueData = false; }
    var dataView = new DataView(arrayBuffer);
    if (!validate(url, dataView)) {
        return null;
    }
    var littleEndian = dataView.getUint32(KTX_FIELDS.ENDIANNESS, true) === ENDIANNESS;
    var glType = dataView.getUint32(KTX_FIELDS.GL_TYPE, littleEndian);
    // const glTypeSize = dataView.getUint32(KTX_FIELDS.GL_TYPE_SIZE, littleEndian);
    var glFormat = dataView.getUint32(KTX_FIELDS.GL_FORMAT, littleEndian);
    var glInternalFormat = dataView.getUint32(KTX_FIELDS.GL_INTERNAL_FORMAT, littleEndian);
    var pixelWidth = dataView.getUint32(KTX_FIELDS.PIXEL_WIDTH, littleEndian);
    var pixelHeight = dataView.getUint32(KTX_FIELDS.PIXEL_HEIGHT, littleEndian) || 1; // "pixelHeight = 0" -> "1"
    var pixelDepth = dataView.getUint32(KTX_FIELDS.PIXEL_DEPTH, littleEndian) || 1; // ^^
    var numberOfArrayElements = dataView.getUint32(KTX_FIELDS.NUMBER_OF_ARRAY_ELEMENTS, littleEndian) || 1; // ^^
    var numberOfFaces = dataView.getUint32(KTX_FIELDS.NUMBER_OF_FACES, littleEndian);
    var numberOfMipmapLevels = dataView.getUint32(KTX_FIELDS.NUMBER_OF_MIPMAP_LEVELS, littleEndian);
    var bytesOfKeyValueData = dataView.getUint32(KTX_FIELDS.BYTES_OF_KEY_VALUE_DATA, littleEndian);
    // Whether the platform architecture is little endian. If littleEndian !== platformLittleEndian, then the
    // file contents must be endian-converted!
    // TODO: Endianness conversion
    // const platformLittleEndian = new Uint8Array((new Uint32Array([ENDIANNESS])).buffer)[0] === 0x01;
    if (pixelHeight === 0 || pixelDepth !== 1) {
        throw new Error('Only 2D textures are supported');
    }
    if (numberOfFaces !== 1) {
        throw new Error('CubeTextures are not supported by KTXLoader yet!');
    }
    if (numberOfArrayElements !== 1) {
        // TODO: Support splitting array-textures into multiple BaseTextures
        throw new Error('WebGL does not support array textures');
    }
    // TODO: 8x4 blocks for 2bpp pvrtc
    var blockWidth = 4;
    var blockHeight = 4;
    var alignedWidth = (pixelWidth + 3) & ~3;
    var alignedHeight = (pixelHeight + 3) & ~3;
    var imageBuffers = new Array(numberOfArrayElements);
    var imagePixels = pixelWidth * pixelHeight;
    if (glType === 0) {
        // Align to 16 pixels (4x4 blocks)
        imagePixels = alignedWidth * alignedHeight;
    }
    var imagePixelByteSize;
    if (glType !== 0) {
        // Uncompressed texture format
        if (TYPES_TO_BYTES_PER_COMPONENT[glType]) {
            imagePixelByteSize = TYPES_TO_BYTES_PER_COMPONENT[glType] * FORMATS_TO_COMPONENTS[glFormat];
        }
        else {
            imagePixelByteSize = TYPES_TO_BYTES_PER_PIXEL[glType];
        }
    }
    else {
        imagePixelByteSize = INTERNAL_FORMAT_TO_BYTES_PER_PIXEL[glInternalFormat];
    }
    if (imagePixelByteSize === undefined) {
        throw new Error('Unable to resolve the pixel format stored in the *.ktx file!');
    }
    var kvData = loadKeyValueData
        ? parseKvData(dataView, bytesOfKeyValueData, littleEndian)
        : null;
    var imageByteSize = imagePixels * imagePixelByteSize;
    var mipByteSize = imageByteSize;
    var mipWidth = pixelWidth;
    var mipHeight = pixelHeight;
    var alignedMipWidth = alignedWidth;
    var alignedMipHeight = alignedHeight;
    var imageOffset = FILE_HEADER_SIZE + bytesOfKeyValueData;
    for (var mipmapLevel = 0; mipmapLevel < numberOfMipmapLevels; mipmapLevel++) {
        var imageSize = dataView.getUint32(imageOffset, littleEndian);
        var elementOffset = imageOffset + 4;
        for (var arrayElement = 0; arrayElement < numberOfArrayElements; arrayElement++) {
            // TODO: Maybe support 3D textures? :-)
            // for (let zSlice = 0; zSlice < pixelDepth; zSlice)
            var mips = imageBuffers[arrayElement];
            if (!mips) {
                mips = imageBuffers[arrayElement] = new Array(numberOfMipmapLevels);
            }
            mips[mipmapLevel] = {
                levelID: mipmapLevel,
                // don't align mipWidth when texture not compressed! (glType not zero)
                levelWidth: numberOfMipmapLevels > 1 || glType !== 0 ? mipWidth : alignedMipWidth,
                levelHeight: numberOfMipmapLevels > 1 || glType !== 0 ? mipHeight : alignedMipHeight,
                levelBuffer: new Uint8Array(arrayBuffer, elementOffset, mipByteSize)
            };
            elementOffset += mipByteSize;
        }
        // HINT: Aligns to 4-byte boundary after jumping imageSize (in lieu of mipPadding)
        imageOffset += imageSize + 4; // (+4 to jump the imageSize field itself)
        imageOffset = imageOffset % 4 !== 0 ? imageOffset + 4 - (imageOffset % 4) : imageOffset;
        // Calculate mipWidth, mipHeight for _next_ iteration
        mipWidth = (mipWidth >> 1) || 1;
        mipHeight = (mipHeight >> 1) || 1;
        alignedMipWidth = (mipWidth + blockWidth - 1) & ~(blockWidth - 1);
        alignedMipHeight = (mipHeight + blockHeight - 1) & ~(blockHeight - 1);
        // Each mipmap level is 4-times smaller?
        mipByteSize = alignedMipWidth * alignedMipHeight * imagePixelByteSize;
    }
    // We use the levelBuffers feature of CompressedTextureResource b/c texture data is image-major, not level-major.
    if (glType !== 0) {
        return {
            uncompressed: imageBuffers.map(function (levelBuffers) {
                var buffer = levelBuffers[0].levelBuffer;
                var convertToInt = false;
                if (glType === constants.TYPES.FLOAT) {
                    buffer = new Float32Array(levelBuffers[0].levelBuffer.buffer, levelBuffers[0].levelBuffer.byteOffset, levelBuffers[0].levelBuffer.byteLength / 4);
                }
                else if (glType === constants.TYPES.UNSIGNED_INT) {
                    convertToInt = true;
                    buffer = new Uint32Array(levelBuffers[0].levelBuffer.buffer, levelBuffers[0].levelBuffer.byteOffset, levelBuffers[0].levelBuffer.byteLength / 4);
                }
                else if (glType === constants.TYPES.INT) {
                    convertToInt = true;
                    buffer = new Int32Array(levelBuffers[0].levelBuffer.buffer, levelBuffers[0].levelBuffer.byteOffset, levelBuffers[0].levelBuffer.byteLength / 4);
                }
                return {
                    resource: new core.BufferResource(buffer, {
                        width: levelBuffers[0].levelWidth,
                        height: levelBuffers[0].levelHeight,
                    }),
                    type: glType,
                    format: convertToInt ? convertFormatToInteger(glFormat) : glFormat,
                };
            }),
            kvData: kvData
        };
    }
    return {
        compressed: imageBuffers.map(function (levelBuffers) { return new CompressedTextureResource(null, {
            format: glInternalFormat,
            width: pixelWidth,
            height: pixelHeight,
            levels: numberOfMipmapLevels,
            levelBuffers: levelBuffers,
        }); }),
        kvData: kvData
    };
}
/**
 * Checks whether the arrayBuffer contains a valid *.ktx file.
 * @param url
 * @param dataView
 */
function validate(url, dataView) {
    // NOTE: Do not optimize this into 3 32-bit integer comparison because the endianness
    // of the data is not specified.
    for (var i = 0; i < FILE_IDENTIFIER.length; i++) {
        if (dataView.getUint8(i) !== FILE_IDENTIFIER[i]) {
            console.error(url + " is not a valid *.ktx file!");
            return false;
        }
    }
    return true;
}
function convertFormatToInteger(format) {
    switch (format) {
        case constants.FORMATS.RGBA: return constants.FORMATS.RGBA_INTEGER;
        case constants.FORMATS.RGB: return constants.FORMATS.RGB_INTEGER;
        case constants.FORMATS.RG: return constants.FORMATS.RG_INTEGER;
        case constants.FORMATS.RED: return constants.FORMATS.RED_INTEGER;
        default: return format;
    }
}
function parseKvData(dataView, bytesOfKeyValueData, littleEndian) {
    var kvData = new Map();
    var bytesIntoKeyValueData = 0;
    while (bytesIntoKeyValueData < bytesOfKeyValueData) {
        var keyAndValueByteSize = dataView.getUint32(FILE_HEADER_SIZE + bytesIntoKeyValueData, littleEndian);
        var keyAndValueByteOffset = FILE_HEADER_SIZE + bytesIntoKeyValueData + 4;
        var valuePadding = 3 - ((keyAndValueByteSize + 3) % 4);
        // Bounds check
        if (keyAndValueByteSize === 0 || keyAndValueByteSize > bytesOfKeyValueData - bytesIntoKeyValueData) {
            console.error('KTXLoader: keyAndValueByteSize out of bounds');
            break;
        }
        // Note: keyNulByte can't be 0 otherwise the key is an empty string.
        var keyNulByte = 0;
        for (; keyNulByte < keyAndValueByteSize; keyNulByte++) {
            if (dataView.getUint8(keyAndValueByteOffset + keyNulByte) === 0x00) {
                break;
            }
        }
        if (keyNulByte === -1) {
            console.error('KTXLoader: Failed to find null byte terminating kvData key');
            break;
        }
        var key = new TextDecoder().decode(new Uint8Array(dataView.buffer, keyAndValueByteOffset, keyNulByte));
        var value = new DataView(dataView.buffer, keyAndValueByteOffset + keyNulByte + 1, keyAndValueByteSize - keyNulByte - 1);
        kvData.set(key, value);
        // 4 = the keyAndValueByteSize field itself
        // keyAndValueByteSize = the bytes taken by the key and value
        // valuePadding = extra padding to align with 4 bytes
        bytesIntoKeyValueData += 4 + keyAndValueByteSize + valuePadding;
    }
    return kvData;
}

// Set DDS files to be loaded as an ArrayBuffer
loaders.LoaderResource.setExtensionXhrType('dds', loaders.LoaderResource.XHR_RESPONSE_TYPE.BUFFER);
/**
 * @class
 * @memberof PIXI
 * @implements {PIXI.ILoaderPlugin}
 * @see https://docs.microsoft.com/en-us/windows/win32/direct3ddds/dx-graphics-dds-pguide
 */
var DDSLoader = /** @class */ (function () {
    function DDSLoader() {
    }
    /**
     * Registers a DDS compressed texture
     * @see PIXI.Loader.loaderMiddleware
     * @param resource - loader resource that is checked to see if it is a DDS file
     * @param next - callback Function to call when done
     */
    DDSLoader.use = function (resource, next) {
        if (resource.extension === 'dds' && resource.data) {
            try {
                Object.assign(resource, registerCompressedTextures(resource.name || resource.url, parseDDS(resource.data), resource.metadata));
            }
            catch (err) {
                next(err);
                return;
            }
        }
        next();
    };
    /** @ignore */
    DDSLoader.extension = core.ExtensionType.Loader;
    return DDSLoader;
}());

// Set KTX files to be loaded as an ArrayBuffer
loaders.LoaderResource.setExtensionXhrType('ktx', loaders.LoaderResource.XHR_RESPONSE_TYPE.BUFFER);
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
var KTXLoader = /** @class */ (function () {
    function KTXLoader() {
    }
    /**
     * Called after a KTX file is loaded.
     *
     * This will parse the KTX file header and add a {@code BaseTexture} to the texture
     * cache.
     * @see PIXI.Loader.loaderMiddleware
     * @param resource - loader resource that is checked to see if it is a KTX file
     * @param next - callback Function to call when done
     */
    KTXLoader.use = function (resource, next) {
        if (resource.extension === 'ktx' && resource.data) {
            try {
                var url_1 = resource.name || resource.url;
                var _a = parseKTX(url_1, resource.data, this.loadKeyValueData), compressed = _a.compressed, uncompressed = _a.uncompressed, kvData_1 = _a.kvData;
                if (compressed) {
                    var result = registerCompressedTextures(url_1, compressed, resource.metadata);
                    if (kvData_1 && result.textures) {
                        for (var textureId in result.textures) {
                            result.textures[textureId].baseTexture.ktxKeyValueData = kvData_1;
                        }
                    }
                    Object.assign(resource, result);
                }
                else if (uncompressed) {
                    var textures_1 = {};
                    uncompressed.forEach(function (image, i) {
                        var texture = new core.Texture(new core.BaseTexture(image.resource, {
                            mipmap: constants.MIPMAP_MODES.OFF,
                            alphaMode: constants.ALPHA_MODES.NO_PREMULTIPLIED_ALPHA,
                            type: image.type,
                            format: image.format,
                        }));
                        var cacheID = url_1 + "-" + (i + 1);
                        if (kvData_1)
                            { texture.baseTexture.ktxKeyValueData = kvData_1; }
                        core.BaseTexture.addToCache(texture.baseTexture, cacheID);
                        core.Texture.addToCache(texture, cacheID);
                        if (i === 0) {
                            textures_1[url_1] = texture;
                            core.BaseTexture.addToCache(texture.baseTexture, url_1);
                            core.Texture.addToCache(texture, url_1);
                        }
                        textures_1[cacheID] = texture;
                    });
                    Object.assign(resource, { textures: textures_1 });
                }
            }
            catch (err) {
                next(err);
                return;
            }
        }
        next();
    };
    /** @ignore */
    KTXLoader.extension = core.ExtensionType.Loader;
    /**
     * If set to `true`, {@link PIXI.KTXLoader} will parse key-value data in KTX textures. This feature relies
     * on the [Encoding Standard]{@link https://encoding.spec.whatwg.org}.
     *
     * The key-value data will be available on the base-textures as {@code PIXI.BaseTexture.ktxKeyValueData}. They
     * will hold a reference to the texture data buffer, so make sure to delete key-value data once you are done
     * using it.
     */
    KTXLoader.loadKeyValueData = false;
    return KTXLoader;
}());

exports.BlobResource = BlobResource;
exports.CompressedTextureLoader = CompressedTextureLoader;
exports.CompressedTextureResource = CompressedTextureResource;
exports.DDSLoader = DDSLoader;
exports.FORMATS_TO_COMPONENTS = FORMATS_TO_COMPONENTS;
exports.INTERNAL_FORMAT_TO_BYTES_PER_PIXEL = INTERNAL_FORMAT_TO_BYTES_PER_PIXEL;
exports.KTXLoader = KTXLoader;
exports.TYPES_TO_BYTES_PER_COMPONENT = TYPES_TO_BYTES_PER_COMPONENT;
exports.TYPES_TO_BYTES_PER_PIXEL = TYPES_TO_BYTES_PER_PIXEL;
exports.parseDDS = parseDDS;
exports.parseKTX = parseKTX;
//# sourceMappingURL=compressed-textures.js.map
