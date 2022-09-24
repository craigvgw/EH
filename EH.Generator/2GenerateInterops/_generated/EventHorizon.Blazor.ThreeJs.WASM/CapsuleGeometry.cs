/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CapsuleGeometry>))]
public class CapsuleGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static CapsuleGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<CapsuleGeometry>(
                entity => new CapsuleGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "CapsuleGeometry", "fromJSON" }, data
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
        public CapsuleGeometry() : base() { }

        public CapsuleGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CapsuleGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> length = null, System.Nullable<decimal> capSegments = null, System.Nullable<decimal> radialSegments = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CapsuleGeometry" },
                radius, length, capSegments, radialSegments
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
