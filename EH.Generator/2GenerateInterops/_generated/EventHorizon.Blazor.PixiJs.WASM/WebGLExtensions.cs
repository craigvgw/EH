/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WebGLExtensions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WebGLExtensionsCachedEntity>))]
public class WebGLExtensionsCachedEntity : CachedEntityObject, WebGLExtensions
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        private WEBGL_draw_buffers __drawBuffers;
        public WEBGL_draw_buffers drawBuffers
        {
            get
            {
            if(__drawBuffers == null)
            {
                __drawBuffers = EventHorizonBlazorInterop.GetClass<WEBGL_draw_buffers>(
                    this.___guid,
                    "drawBuffers",
                    (entity) =>
                    {
                        return new WEBGL_draw_buffers() { ___guid = entity.___guid };
                    }
                );
            }
            return __drawBuffers;
            }
            set
            {
__drawBuffers = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawBuffers",
                    value
                );
            }
        }

        private OES_texture_float __depthTexture;
        public OES_texture_float depthTexture
        {
            get
            {
            if(__depthTexture == null)
            {
                __depthTexture = EventHorizonBlazorInterop.GetClass<OES_texture_float>(
                    this.___guid,
                    "depthTexture",
                    (entity) =>
                    {
                        return new OES_texture_float() { ___guid = entity.___guid };
                    }
                );
            }
            return __depthTexture;
            }
            set
            {
__depthTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthTexture",
                    value
                );
            }
        }

        private WEBGL_lose_context __loseContext;
        public WEBGL_lose_context loseContext
        {
            get
            {
            if(__loseContext == null)
            {
                __loseContext = EventHorizonBlazorInterop.GetClass<WEBGL_lose_context>(
                    this.___guid,
                    "loseContext",
                    (entity) =>
                    {
                        return new WEBGL_lose_context() { ___guid = entity.___guid };
                    }
                );
            }
            return __loseContext;
            }
            set
            {
__loseContext = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loseContext",
                    value
                );
            }
        }

        private OES_vertex_array_object __vertexArrayObject;
        public OES_vertex_array_object vertexArrayObject
        {
            get
            {
            if(__vertexArrayObject == null)
            {
                __vertexArrayObject = EventHorizonBlazorInterop.GetClass<OES_vertex_array_object>(
                    this.___guid,
                    "vertexArrayObject",
                    (entity) =>
                    {
                        return new OES_vertex_array_object() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexArrayObject;
            }
            set
            {
__vertexArrayObject = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexArrayObject",
                    value
                );
            }
        }

        private EXT_texture_filter_anisotropic __anisotropicFiltering;
        public EXT_texture_filter_anisotropic anisotropicFiltering
        {
            get
            {
            if(__anisotropicFiltering == null)
            {
                __anisotropicFiltering = EventHorizonBlazorInterop.GetClass<EXT_texture_filter_anisotropic>(
                    this.___guid,
                    "anisotropicFiltering",
                    (entity) =>
                    {
                        return new EXT_texture_filter_anisotropic() { ___guid = entity.___guid };
                    }
                );
            }
            return __anisotropicFiltering;
            }
            set
            {
__anisotropicFiltering = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anisotropicFiltering",
                    value
                );
            }
        }

        private OES_element_index_uint __uint32ElementIndex;
        public OES_element_index_uint uint32ElementIndex
        {
            get
            {
            if(__uint32ElementIndex == null)
            {
                __uint32ElementIndex = EventHorizonBlazorInterop.GetClass<OES_element_index_uint>(
                    this.___guid,
                    "uint32ElementIndex",
                    (entity) =>
                    {
                        return new OES_element_index_uint() { ___guid = entity.___guid };
                    }
                );
            }
            return __uint32ElementIndex;
            }
            set
            {
__uint32ElementIndex = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uint32ElementIndex",
                    value
                );
            }
        }

        private OES_texture_float __floatTexture;
        public OES_texture_float floatTexture
        {
            get
            {
            if(__floatTexture == null)
            {
                __floatTexture = EventHorizonBlazorInterop.GetClass<OES_texture_float>(
                    this.___guid,
                    "floatTexture",
                    (entity) =>
                    {
                        return new OES_texture_float() { ___guid = entity.___guid };
                    }
                );
            }
            return __floatTexture;
            }
            set
            {
__floatTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "floatTexture",
                    value
                );
            }
        }

        private OES_texture_float_linear __floatTextureLinear;
        public OES_texture_float_linear floatTextureLinear
        {
            get
            {
            if(__floatTextureLinear == null)
            {
                __floatTextureLinear = EventHorizonBlazorInterop.GetClass<OES_texture_float_linear>(
                    this.___guid,
                    "floatTextureLinear",
                    (entity) =>
                    {
                        return new OES_texture_float_linear() { ___guid = entity.___guid };
                    }
                );
            }
            return __floatTextureLinear;
            }
            set
            {
__floatTextureLinear = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "floatTextureLinear",
                    value
                );
            }
        }

        private OES_texture_half_float __textureHalfFloat;
        public OES_texture_half_float textureHalfFloat
        {
            get
            {
            if(__textureHalfFloat == null)
            {
                __textureHalfFloat = EventHorizonBlazorInterop.GetClass<OES_texture_half_float>(
                    this.___guid,
                    "textureHalfFloat",
                    (entity) =>
                    {
                        return new OES_texture_half_float() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureHalfFloat;
            }
            set
            {
__textureHalfFloat = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureHalfFloat",
                    value
                );
            }
        }

        private OES_texture_half_float_linear __textureHalfFloatLinear;
        public OES_texture_half_float_linear textureHalfFloatLinear
        {
            get
            {
            if(__textureHalfFloatLinear == null)
            {
                __textureHalfFloatLinear = EventHorizonBlazorInterop.GetClass<OES_texture_half_float_linear>(
                    this.___guid,
                    "textureHalfFloatLinear",
                    (entity) =>
                    {
                        return new OES_texture_half_float_linear() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureHalfFloatLinear;
            }
            set
            {
__textureHalfFloatLinear = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureHalfFloatLinear",
                    value
                );
            }
        }

        private WEBGL_color_buffer_float __colorBufferFloat;
        public WEBGL_color_buffer_float colorBufferFloat
        {
            get
            {
            if(__colorBufferFloat == null)
            {
                __colorBufferFloat = EventHorizonBlazorInterop.GetClass<WEBGL_color_buffer_float>(
                    this.___guid,
                    "colorBufferFloat",
                    (entity) =>
                    {
                        return new WEBGL_color_buffer_float() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorBufferFloat;
            }
            set
            {
__colorBufferFloat = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorBufferFloat",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_s3tc __s3tc;
        public WEBGL_compressed_texture_s3tc s3tc
        {
            get
            {
            if(__s3tc == null)
            {
                __s3tc = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_s3tc>(
                    this.___guid,
                    "s3tc",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_s3tc() { ___guid = entity.___guid };
                    }
                );
            }
            return __s3tc;
            }
            set
            {
__s3tc = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "s3tc",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_s3tc_srgb __s3tc_sRGB;
        public WEBGL_compressed_texture_s3tc_srgb s3tc_sRGB
        {
            get
            {
            if(__s3tc_sRGB == null)
            {
                __s3tc_sRGB = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_s3tc_srgb>(
                    this.___guid,
                    "s3tc_sRGB",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_s3tc_srgb() { ___guid = entity.___guid };
                    }
                );
            }
            return __s3tc_sRGB;
            }
            set
            {
__s3tc_sRGB = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "s3tc_sRGB",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_etc_2CachedEntity __etc;
        public WEBGL_compressed_texture_etc_2CachedEntity etc
        {
            get
            {
            if(__etc == null)
            {
                __etc = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_etc_2CachedEntity>(
                    this.___guid,
                    "etc",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_etc_2CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __etc;
            }
            set
            {
__etc = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "etc",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_etc1_2CachedEntity __etc1;
        public WEBGL_compressed_texture_etc1_2CachedEntity etc1
        {
            get
            {
            if(__etc1 == null)
            {
                __etc1 = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_etc1_2CachedEntity>(
                    this.___guid,
                    "etc1",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_etc1_2CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __etc1;
            }
            set
            {
__etc1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "etc1",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_pvrtc_2CachedEntity __pvrtc;
        public WEBGL_compressed_texture_pvrtc_2CachedEntity pvrtc
        {
            get
            {
            if(__pvrtc == null)
            {
                __pvrtc = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_pvrtc_2CachedEntity>(
                    this.___guid,
                    "pvrtc",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_pvrtc_2CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __pvrtc;
            }
            set
            {
__pvrtc = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pvrtc",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_atcCachedEntity __atc;
        public WEBGL_compressed_texture_atcCachedEntity atc
        {
            get
            {
            if(__atc == null)
            {
                __atc = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_atcCachedEntity>(
                    this.___guid,
                    "atc",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_atcCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __atc;
            }
            set
            {
__atc = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "atc",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_astc __astc;
        public WEBGL_compressed_texture_astc astc
        {
            get
            {
            if(__astc == null)
            {
                __astc = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_astc>(
                    this.___guid,
                    "astc",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_astc() { ___guid = entity.___guid };
                    }
                );
            }
            return __astc;
            }
            set
            {
__astc = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "astc",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLExtensionsCachedEntity() : base() { }

        public WebGLExtensionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
