/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLTextures>))]
public class WebGLTextures : CachedEntityObject
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

    #endregion
    
    #region Constructor
        public WebGLTextures() : base() { }

        public WebGLTextures(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLTextures(
            WebGLRenderingContext gl, WebGLExtensions extensions, WebGLState state, WebGLProperties properties, WebGLCapabilities capabilities, WebGLUtils utils, WebGLInfo info
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLTextures" },
                gl, extensions, state, properties, capabilities, utils, info
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void allocateTextureUnit()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "allocateTextureUnit" }
                }
            );
        }

        public void resetTextureUnits()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetTextureUnits" }
                }
            );
        }

        public void setTexture2D(object texture, decimal slot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture2D" }, texture, slot
                }
            );
        }

        public void setTexture2DArray(object texture, decimal slot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture2DArray" }, texture, slot
                }
            );
        }

        public void setTexture3D(object texture, decimal slot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture3D" }, texture, slot
                }
            );
        }

        public void setTextureCube(object texture, decimal slot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureCube" }, texture, slot
                }
            );
        }

        public void setupRenderTarget(object renderTarget)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setupRenderTarget" }, renderTarget
                }
            );
        }

        public void updateRenderTargetMipmap(object renderTarget)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateRenderTargetMipmap" }, renderTarget
                }
            );
        }

        public void updateMultisampleRenderTarget(object renderTarget)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMultisampleRenderTarget" }, renderTarget
                }
            );
        }

        public void safeSetTexture2D(object texture, decimal slot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "safeSetTexture2D" }, texture, slot
                }
            );
        }

        public void safeSetTextureCube(object texture, decimal slot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "safeSetTextureCube" }, texture, slot
                }
            );
        }
    #endregion
}
