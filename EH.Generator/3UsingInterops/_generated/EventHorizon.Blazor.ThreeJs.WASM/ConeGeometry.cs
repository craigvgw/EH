/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ConeGeometry>))]
public class ConeGeometry : CylinderGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static ConeGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<ConeGeometry>(
                entity => new ConeGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "ConeGeometry", "fromJSON" }, data
                }
            );
        }
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
        public ConeGeometry() : base() { }

        public ConeGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ConeGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radialSegments = null, System.Nullable<decimal> heightSegments = null, System.Nullable<bool> openEnded = null, System.Nullable<decimal> thetaStart = null, System.Nullable<decimal> thetaLength = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ConeGeometry" },
                radius, height, radialSegments, heightSegments, openEnded, thetaStart, thetaLength
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
