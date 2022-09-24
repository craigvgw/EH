/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WebGLCapabilitiesParameters : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WebGLCapabilitiesParametersCachedEntity>))]
public class WebGLCapabilitiesParametersCachedEntity : CachedEntityObject, WebGLCapabilitiesParameters
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
        
        public string precision
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "precision"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "precision",
                    value
                );
            }
        }

        
        public bool logarithmicDepthBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "logarithmicDepthBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "logarithmicDepthBuffer",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLCapabilitiesParametersCachedEntity() : base() { }

        public WebGLCapabilitiesParametersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
