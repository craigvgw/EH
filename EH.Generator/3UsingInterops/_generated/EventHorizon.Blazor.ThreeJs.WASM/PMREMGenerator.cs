/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PMREMGenerator>))]
public class PMREMGenerator : CachedEntityObject
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
        public PMREMGenerator() : base() { }

        public PMREMGenerator(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PMREMGenerator(
            WebGLRenderer renderer
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PMREMGenerator" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public WebGLRenderTarget fromScene(Scene scene, System.Nullable<decimal> sigma = null, System.Nullable<decimal> near = null, System.Nullable<decimal> far = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderTarget>(
                entity => new WebGLRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromScene" }, scene, sigma, near, far
                }
            );
        }

        public WebGLRenderTarget fromEquirectangular(Texture equirectangular, WebGLRenderTarget renderTarget = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderTarget>(
                entity => new WebGLRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromEquirectangular" }, equirectangular, renderTarget
                }
            );
        }

        public WebGLRenderTarget fromCubemap(CubeTexture cubemap, WebGLRenderTarget renderTarget = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderTarget>(
                entity => new WebGLRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromCubemap" }, cubemap, renderTarget
                }
            );
        }

        public void compileCubemapShader()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "compileCubemapShader" }
                }
            );
        }

        public void compileEquirectangularShader()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "compileEquirectangularShader" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
    #endregion
}
