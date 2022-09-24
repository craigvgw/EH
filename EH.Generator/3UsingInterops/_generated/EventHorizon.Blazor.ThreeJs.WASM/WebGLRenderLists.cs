/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLRenderLists>))]
public class WebGLRenderLists : CachedEntityObject
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
        public WebGLRenderLists() : base() { }

        public WebGLRenderLists(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLRenderLists(
            WebGLProperties properties
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLRenderLists" },
                properties
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public WebGLRenderList get(Scene scene, decimal renderCallDepth)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderList>(
                entity => new WebGLRenderList() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, scene, renderCallDepth
                }
            );
        }
    #endregion
}
