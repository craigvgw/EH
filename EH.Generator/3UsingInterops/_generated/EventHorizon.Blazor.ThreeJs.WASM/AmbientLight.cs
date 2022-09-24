/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AmbientLight>))]
public class AmbientLight : Light
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
        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public unknown isAmbientLight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isAmbientLight"
                );
            }
        }
    #endregion
    
    #region Constructor
        public AmbientLight() : base() { }

        public AmbientLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AmbientLight(
            Color color = null, System.Nullable<decimal> intensity = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AmbientLight" },
                color, intensity
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
