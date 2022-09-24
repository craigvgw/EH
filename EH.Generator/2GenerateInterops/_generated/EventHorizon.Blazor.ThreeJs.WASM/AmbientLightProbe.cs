/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AmbientLightProbe>))]
public class AmbientLightProbe : LightProbe
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
        
        public unknown isAmbientLightProbe
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isAmbientLightProbe"
                );
            }
        }
    #endregion
    
    #region Constructor
        public AmbientLightProbe() : base() { }

        public AmbientLightProbe(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AmbientLightProbe(
            Color color = null, System.Nullable<decimal> intensity = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AmbientLightProbe" },
                color, intensity
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
