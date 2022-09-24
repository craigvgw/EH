/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLMultipleRenderTargets>))]
public class WebGLMultipleRenderTargets : EventDispatcher
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
        
        public Texture[] texture
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public unknown isWebGLMultipleRenderTargets
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isWebGLMultipleRenderTargets"
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLMultipleRenderTargets() : base() { }

        public WebGLMultipleRenderTargets(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGLMultipleRenderTargets(
            decimal width, decimal height, decimal count, WebGLRenderTargetOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLMultipleRenderTargets" },
                width, height, count, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public WebGLMultipleRenderTargets setSize(decimal width, decimal height, System.Nullable<decimal> depth = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLMultipleRenderTargets>(
                entity => new WebGLMultipleRenderTargets() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, depth
                }
            );
        }

        public WebGLMultipleRenderTargets copy(WebGLMultipleRenderTargets source)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLMultipleRenderTargets>(
                entity => new WebGLMultipleRenderTargets() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }

        public WebGLMultipleRenderTargets clone()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLMultipleRenderTargets>(
                entity => new WebGLMultipleRenderTargets() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
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

        public void setTexture(Texture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, texture
                }
            );
        }
    #endregion
}
