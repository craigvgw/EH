/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SphereGeometry>))]
public class SphereGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static SphereGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<SphereGeometry>(
                entity => new SphereGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "SphereGeometry", "fromJSON" }, data
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
        public SphereGeometry() : base() { }

        public SphereGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SphereGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> widthSegments = null, System.Nullable<decimal> heightSegments = null, System.Nullable<decimal> phiStart = null, System.Nullable<decimal> phiLength = null, System.Nullable<decimal> thetaStart = null, System.Nullable<decimal> thetaLength = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SphereGeometry" },
                radius, widthSegments, heightSegments, phiStart, phiLength, thetaStart, thetaLength
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
