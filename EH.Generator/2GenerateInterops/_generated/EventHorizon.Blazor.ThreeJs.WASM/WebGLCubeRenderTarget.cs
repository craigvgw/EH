/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLCubeRenderTarget>))]
public class WebGLCubeRenderTarget : WebGLRenderTarget
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
        private CubeTexture __texture;
        public CubeTexture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<CubeTexture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new CubeTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLCubeRenderTarget() : base() { }

        public WebGLCubeRenderTarget(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGLCubeRenderTarget(
            decimal size, WebGLRenderTargetOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLCubeRenderTarget" },
                size, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public WebGLCubeRenderTarget fromEquirectangularTexture(WebGLRenderer renderer, Texture texture)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLCubeRenderTarget>(
                entity => new WebGLCubeRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromEquirectangularTexture" }, renderer, texture
                }
            );
        }

        public void clear(WebGLRenderer renderer, bool color, bool depth, bool stencil)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, renderer, color, depth, stencil
                }
            );
        }
    #endregion
}
