/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLAttributes>))]
public class WebGLAttributes : CachedEntityObject
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
        public WebGLAttributes() : base() { }

        public WebGLAttributes(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLAttributes(
            WebGLRenderingContext gl, WebGLCapabilities capabilities
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLAttributes" },
                gl, capabilities
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CachedEntity get(BufferAttribute attribute)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, attribute
                }
            );
        }

        public void remove(BufferAttribute attribute)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, attribute
                }
            );
        }

        public void update(BufferAttribute attribute, decimal bufferType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, attribute, bufferType
                }
            );
        }
    #endregion
}
