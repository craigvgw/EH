/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLExtensions>))]
public class WebGLExtensions : CachedEntityObject
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
        public WebGLExtensions() : base() { }

        public WebGLExtensions(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLExtensions(
            WebGLRenderingContext gl
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLExtensions" },
                gl
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public bool has(string name)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "has" }, name
                }
            );
        }

        public void init(WebGLCapabilities capabilities)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }, capabilities
                }
            );
        }

        public CachedEntity get(string name)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, name
                }
            );
        }
    #endregion
}
