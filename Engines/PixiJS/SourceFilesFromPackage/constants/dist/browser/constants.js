/*!
 * @pixi/constants - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/constants is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_constants = (function (exports) {
    'use strict';

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
    exports.ENV = void 0;
    (function (ENV) {
        ENV[ENV["WEBGL_LEGACY"] = 0] = "WEBGL_LEGACY";
        ENV[ENV["WEBGL"] = 1] = "WEBGL";
        ENV[ENV["WEBGL2"] = 2] = "WEBGL2";
    })(exports.ENV || (exports.ENV = {}));
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
    exports.RENDERER_TYPE = void 0;
    (function (RENDERER_TYPE) {
        RENDERER_TYPE[RENDERER_TYPE["UNKNOWN"] = 0] = "UNKNOWN";
        RENDERER_TYPE[RENDERER_TYPE["WEBGL"] = 1] = "WEBGL";
        RENDERER_TYPE[RENDERER_TYPE["CANVAS"] = 2] = "CANVAS";
    })(exports.RENDERER_TYPE || (exports.RENDERER_TYPE = {}));
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
    exports.BUFFER_BITS = void 0;
    (function (BUFFER_BITS) {
        BUFFER_BITS[BUFFER_BITS["COLOR"] = 16384] = "COLOR";
        BUFFER_BITS[BUFFER_BITS["DEPTH"] = 256] = "DEPTH";
        BUFFER_BITS[BUFFER_BITS["STENCIL"] = 1024] = "STENCIL";
    })(exports.BUFFER_BITS || (exports.BUFFER_BITS = {}));
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
    exports.BLEND_MODES = void 0;
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
    })(exports.BLEND_MODES || (exports.BLEND_MODES = {}));
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
    exports.DRAW_MODES = void 0;
    (function (DRAW_MODES) {
        DRAW_MODES[DRAW_MODES["POINTS"] = 0] = "POINTS";
        DRAW_MODES[DRAW_MODES["LINES"] = 1] = "LINES";
        DRAW_MODES[DRAW_MODES["LINE_LOOP"] = 2] = "LINE_LOOP";
        DRAW_MODES[DRAW_MODES["LINE_STRIP"] = 3] = "LINE_STRIP";
        DRAW_MODES[DRAW_MODES["TRIANGLES"] = 4] = "TRIANGLES";
        DRAW_MODES[DRAW_MODES["TRIANGLE_STRIP"] = 5] = "TRIANGLE_STRIP";
        DRAW_MODES[DRAW_MODES["TRIANGLE_FAN"] = 6] = "TRIANGLE_FAN";
    })(exports.DRAW_MODES || (exports.DRAW_MODES = {}));
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
    exports.FORMATS = void 0;
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
    })(exports.FORMATS || (exports.FORMATS = {}));
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
    exports.TARGETS = void 0;
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
    })(exports.TARGETS || (exports.TARGETS = {}));
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
    exports.TYPES = void 0;
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
    })(exports.TYPES || (exports.TYPES = {}));
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
    exports.SAMPLER_TYPES = void 0;
    (function (SAMPLER_TYPES) {
        SAMPLER_TYPES[SAMPLER_TYPES["FLOAT"] = 0] = "FLOAT";
        SAMPLER_TYPES[SAMPLER_TYPES["INT"] = 1] = "INT";
        SAMPLER_TYPES[SAMPLER_TYPES["UINT"] = 2] = "UINT";
    })(exports.SAMPLER_TYPES || (exports.SAMPLER_TYPES = {}));
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
    exports.SCALE_MODES = void 0;
    (function (SCALE_MODES) {
        SCALE_MODES[SCALE_MODES["NEAREST"] = 0] = "NEAREST";
        SCALE_MODES[SCALE_MODES["LINEAR"] = 1] = "LINEAR";
    })(exports.SCALE_MODES || (exports.SCALE_MODES = {}));
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
    exports.WRAP_MODES = void 0;
    (function (WRAP_MODES) {
        WRAP_MODES[WRAP_MODES["CLAMP"] = 33071] = "CLAMP";
        WRAP_MODES[WRAP_MODES["REPEAT"] = 10497] = "REPEAT";
        WRAP_MODES[WRAP_MODES["MIRRORED_REPEAT"] = 33648] = "MIRRORED_REPEAT";
    })(exports.WRAP_MODES || (exports.WRAP_MODES = {}));
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
    exports.MIPMAP_MODES = void 0;
    (function (MIPMAP_MODES) {
        MIPMAP_MODES[MIPMAP_MODES["OFF"] = 0] = "OFF";
        MIPMAP_MODES[MIPMAP_MODES["POW2"] = 1] = "POW2";
        MIPMAP_MODES[MIPMAP_MODES["ON"] = 2] = "ON";
        MIPMAP_MODES[MIPMAP_MODES["ON_MANUAL"] = 3] = "ON_MANUAL";
    })(exports.MIPMAP_MODES || (exports.MIPMAP_MODES = {}));
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
    exports.ALPHA_MODES = void 0;
    (function (ALPHA_MODES) {
        ALPHA_MODES[ALPHA_MODES["NPM"] = 0] = "NPM";
        ALPHA_MODES[ALPHA_MODES["UNPACK"] = 1] = "UNPACK";
        ALPHA_MODES[ALPHA_MODES["PMA"] = 2] = "PMA";
        ALPHA_MODES[ALPHA_MODES["NO_PREMULTIPLIED_ALPHA"] = 0] = "NO_PREMULTIPLIED_ALPHA";
        ALPHA_MODES[ALPHA_MODES["PREMULTIPLY_ON_UPLOAD"] = 1] = "PREMULTIPLY_ON_UPLOAD";
        ALPHA_MODES[ALPHA_MODES["PREMULTIPLY_ALPHA"] = 2] = "PREMULTIPLY_ALPHA";
        ALPHA_MODES[ALPHA_MODES["PREMULTIPLIED_ALPHA"] = 2] = "PREMULTIPLIED_ALPHA";
    })(exports.ALPHA_MODES || (exports.ALPHA_MODES = {}));
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
    exports.CLEAR_MODES = void 0;
    (function (CLEAR_MODES) {
        CLEAR_MODES[CLEAR_MODES["NO"] = 0] = "NO";
        CLEAR_MODES[CLEAR_MODES["YES"] = 1] = "YES";
        CLEAR_MODES[CLEAR_MODES["AUTO"] = 2] = "AUTO";
        CLEAR_MODES[CLEAR_MODES["BLEND"] = 0] = "BLEND";
        CLEAR_MODES[CLEAR_MODES["CLEAR"] = 1] = "CLEAR";
        CLEAR_MODES[CLEAR_MODES["BLIT"] = 2] = "BLIT";
    })(exports.CLEAR_MODES || (exports.CLEAR_MODES = {}));
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
    exports.GC_MODES = void 0;
    (function (GC_MODES) {
        GC_MODES[GC_MODES["AUTO"] = 0] = "AUTO";
        GC_MODES[GC_MODES["MANUAL"] = 1] = "MANUAL";
    })(exports.GC_MODES || (exports.GC_MODES = {}));
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
    exports.PRECISION = void 0;
    (function (PRECISION) {
        PRECISION["LOW"] = "lowp";
        PRECISION["MEDIUM"] = "mediump";
        PRECISION["HIGH"] = "highp";
    })(exports.PRECISION || (exports.PRECISION = {}));
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
    exports.MASK_TYPES = void 0;
    (function (MASK_TYPES) {
        MASK_TYPES[MASK_TYPES["NONE"] = 0] = "NONE";
        MASK_TYPES[MASK_TYPES["SCISSOR"] = 1] = "SCISSOR";
        MASK_TYPES[MASK_TYPES["STENCIL"] = 2] = "STENCIL";
        MASK_TYPES[MASK_TYPES["SPRITE"] = 3] = "SPRITE";
        MASK_TYPES[MASK_TYPES["COLOR"] = 4] = "COLOR";
    })(exports.MASK_TYPES || (exports.MASK_TYPES = {}));
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
    exports.COLOR_MASK_BITS = void 0;
    (function (COLOR_MASK_BITS) {
        COLOR_MASK_BITS[COLOR_MASK_BITS["RED"] = 1] = "RED";
        COLOR_MASK_BITS[COLOR_MASK_BITS["GREEN"] = 2] = "GREEN";
        COLOR_MASK_BITS[COLOR_MASK_BITS["BLUE"] = 4] = "BLUE";
        COLOR_MASK_BITS[COLOR_MASK_BITS["ALPHA"] = 8] = "ALPHA";
    })(exports.COLOR_MASK_BITS || (exports.COLOR_MASK_BITS = {}));
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
    exports.MSAA_QUALITY = void 0;
    (function (MSAA_QUALITY) {
        MSAA_QUALITY[MSAA_QUALITY["NONE"] = 0] = "NONE";
        MSAA_QUALITY[MSAA_QUALITY["LOW"] = 2] = "LOW";
        MSAA_QUALITY[MSAA_QUALITY["MEDIUM"] = 4] = "MEDIUM";
        MSAA_QUALITY[MSAA_QUALITY["HIGH"] = 8] = "HIGH";
    })(exports.MSAA_QUALITY || (exports.MSAA_QUALITY = {}));
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
    exports.BUFFER_TYPE = void 0;
    (function (BUFFER_TYPE) {
        BUFFER_TYPE[BUFFER_TYPE["ELEMENT_ARRAY_BUFFER"] = 34963] = "ELEMENT_ARRAY_BUFFER";
        BUFFER_TYPE[BUFFER_TYPE["ARRAY_BUFFER"] = 34962] = "ARRAY_BUFFER";
        // NOT YET SUPPORTED
        BUFFER_TYPE[BUFFER_TYPE["UNIFORM_BUFFER"] = 35345] = "UNIFORM_BUFFER";
    })(exports.BUFFER_TYPE || (exports.BUFFER_TYPE = {}));

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({});
Object.assign(this.PIXI, _pixi_constants);
//# sourceMappingURL=constants.js.map
