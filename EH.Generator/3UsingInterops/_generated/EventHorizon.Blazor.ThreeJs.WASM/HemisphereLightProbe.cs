/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<HemisphereLightProbe>))]
public class HemisphereLightProbe : LightProbe
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
        
        public unknown isHemisphereLightProbe
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isHemisphereLightProbe"
                );
            }
        }
    #endregion
    
    #region Constructor
        public HemisphereLightProbe() : base() { }

        public HemisphereLightProbe(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public HemisphereLightProbe(
            Color skyColor = null, Color groundColor = null, System.Nullable<decimal> intensity = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "HemisphereLightProbe" },
                skyColor, groundColor, intensity
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
