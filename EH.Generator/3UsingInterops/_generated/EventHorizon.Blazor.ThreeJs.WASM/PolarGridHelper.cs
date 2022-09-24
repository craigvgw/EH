/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PolarGridHelper>))]
public class PolarGridHelper : LineSegments
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
    #endregion
    
    #region Constructor
        public PolarGridHelper() : base() { }

        public PolarGridHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PolarGridHelper(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> radials = null, System.Nullable<decimal> circles = null, System.Nullable<decimal> divisions = null, Color color1 = null, Color color2 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PolarGridHelper" },
                radius, radials, circles, divisions, color1, color2
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
