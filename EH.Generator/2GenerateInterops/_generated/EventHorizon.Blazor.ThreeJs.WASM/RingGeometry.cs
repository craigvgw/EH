/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<RingGeometry>))]
public class RingGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static RingGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<RingGeometry>(
                entity => new RingGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "RingGeometry", "fromJSON" }, data
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
        public RingGeometry() : base() { }

        public RingGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RingGeometry(
            System.Nullable<decimal> innerRadius = null, System.Nullable<decimal> outerRadius = null, System.Nullable<decimal> thetaSegments = null, System.Nullable<decimal> phiSegments = null, System.Nullable<decimal> thetaStart = null, System.Nullable<decimal> thetaLength = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "RingGeometry" },
                innerRadius, outerRadius, thetaSegments, phiSegments, thetaStart, thetaLength
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
