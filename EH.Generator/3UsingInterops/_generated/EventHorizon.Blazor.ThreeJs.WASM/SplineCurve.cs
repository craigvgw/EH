/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SplineCurve>))]
public class SplineCurve : Curve<Vector2>
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

        
        public Vector2[] points
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector2>(
                    this.___guid,
                    "points",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "points",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SplineCurve() : base() { }

        public SplineCurve(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SplineCurve(
            Vector2[] points = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SplineCurve" },
                points
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
