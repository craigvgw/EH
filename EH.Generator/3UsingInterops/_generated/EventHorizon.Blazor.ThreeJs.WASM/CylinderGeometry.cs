/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CylinderGeometry>))]
public class CylinderGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static CylinderGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<CylinderGeometry>(
                entity => new CylinderGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "CylinderGeometry", "fromJSON" }, data
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

        
        public CachedEntity parameters
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parameters",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parameters",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CylinderGeometry() : base() { }

        public CylinderGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CylinderGeometry(
            System.Nullable<decimal> radiusTop = null, System.Nullable<decimal> radiusBottom = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radialSegments = null, System.Nullable<decimal> heightSegments = null, System.Nullable<bool> openEnded = null, System.Nullable<decimal> thetaStart = null, System.Nullable<decimal> thetaLength = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CylinderGeometry" },
                radiusTop, radiusBottom, height, radialSegments, heightSegments, openEnded, thetaStart, thetaLength
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
