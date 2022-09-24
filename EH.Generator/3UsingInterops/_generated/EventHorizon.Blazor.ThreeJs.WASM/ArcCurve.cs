/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ArcCurve>))]
public class ArcCurve : EllipseCurve
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
        public ArcCurve() : base() { }

        public ArcCurve(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ArcCurve(
            decimal aX, decimal aY, decimal aRadius, decimal aStartAngle, decimal aEndAngle, bool aClockwise
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ArcCurve" },
                aX, aY, aRadius, aStartAngle, aEndAngle, aClockwise
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
