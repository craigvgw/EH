/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLUtils>))]
public class WebGLUtils : CachedEntityObject
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
        public WebGLUtils() : base() { }

        public WebGLUtils(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLUtils(
            WebGLRenderingContext gl, object extensions, object capabilities
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLUtils" },
                gl, extensions, capabilities
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public decimal convert(int p, System.Nullable<int> encoding = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "convert" }, p, encoding
                }
            );
        }
    #endregion
}
