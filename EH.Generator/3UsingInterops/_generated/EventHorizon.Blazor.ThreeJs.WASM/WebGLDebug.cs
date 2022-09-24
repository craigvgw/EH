/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WebGLDebug : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WebGLDebugCachedEntity>))]
public class WebGLDebugCachedEntity : CachedEntityObject, WebGLDebug
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
        
        public bool checkShaderErrors
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkShaderErrors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkShaderErrors",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLDebugCachedEntity() : base() { }

        public WebGLDebugCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
