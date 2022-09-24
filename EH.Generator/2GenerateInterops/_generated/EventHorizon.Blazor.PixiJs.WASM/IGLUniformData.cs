/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<IGLUniformData>))]
public class IGLUniformData : CachedEntityObject
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
        private WebGLUniformLocation __location;
        public WebGLUniformLocation location
        {
            get
            {
            if(__location == null)
            {
                __location = EventHorizonBlazorInterop.GetClass<WebGLUniformLocation>(
                    this.___guid,
                    "location",
                    (entity) =>
                    {
                        return new WebGLUniformLocation() { ___guid = entity.___guid };
                    }
                );
            }
            return __location;
            }
            set
            {
__location = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "location",
                    value
                );
            }
        }

        
        public decimal value
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "value"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IGLUniformData() : base() { }

        public IGLUniformData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
