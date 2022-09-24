/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLIndexedBufferRenderer>))]
public class WebGLIndexedBufferRenderer : CachedEntityObject
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
        public WebGLIndexedBufferRenderer() : base() { }

        public WebGLIndexedBufferRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLIndexedBufferRenderer(
            WebGLRenderingContext gl, object extensions, object info, object capabilities
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLIndexedBufferRenderer" },
                gl, extensions, info, capabilities
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setMode(object value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMode" }, value
                }
            );
        }

        public void setIndex(object index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setIndex" }, index
                }
            );
        }

        public void render(object start, decimal count)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, start, count
                }
            );
        }

        public void renderInstances(object start, decimal count, decimal primcount)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "renderInstances" }, start, count, primcount
                }
            );
        }
    #endregion
}
