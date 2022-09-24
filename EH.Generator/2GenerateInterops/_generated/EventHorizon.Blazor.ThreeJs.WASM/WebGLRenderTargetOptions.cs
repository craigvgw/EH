/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WebGLRenderTargetOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WebGLRenderTargetOptionsCachedEntity>))]
public class WebGLRenderTargetOptionsCachedEntity : CachedEntityObject, WebGLRenderTargetOptions
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
        
        public int wrapS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "wrapS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapS",
                    value
                );
            }
        }

        
        public int wrapT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "wrapT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapT",
                    value
                );
            }
        }

        
        public int magFilter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "magFilter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "magFilter",
                    value
                );
            }
        }

        
        public int minFilter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "minFilter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minFilter",
                    value
                );
            }
        }

        
        public decimal format
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "format"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "format",
                    value
                );
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal anisotropy
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "anisotropy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anisotropy",
                    value
                );
            }
        }

        
        public bool depthBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depthBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthBuffer",
                    value
                );
            }
        }

        
        public bool stencilBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stencilBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilBuffer",
                    value
                );
            }
        }

        
        public bool generateMipmaps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateMipmaps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateMipmaps",
                    value
                );
            }
        }

        private DepthTexture __depthTexture;
        public DepthTexture depthTexture
        {
            get
            {
            if(__depthTexture == null)
            {
                __depthTexture = EventHorizonBlazorInterop.GetClass<DepthTexture>(
                    this.___guid,
                    "depthTexture",
                    (entity) =>
                    {
                        return new DepthTexture() { ___guid = entity.___guid };
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

        
        public int encoding
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "encoding"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "encoding",
                    value
                );
            }
        }

        
        public decimal samples
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLRenderTargetOptionsCachedEntity() : base() { }

        public WebGLRenderTargetOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
