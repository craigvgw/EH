/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CatmullRomCurve3>))]
public class CatmullRomCurve3 : Curve<Vector3>
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

        
        public Vector3[] points
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "points",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
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
        public CatmullRomCurve3() : base() { }

        public CatmullRomCurve3(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CatmullRomCurve3(
            Vector3[] points = null, System.Nullable<bool> closed = null, string curveType = null, System.Nullable<decimal> tension = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CatmullRomCurve3" },
                points, closed, curveType, tension
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
