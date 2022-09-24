/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CircleGeometry>))]
public class CircleGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static CircleGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<CircleGeometry>(
                entity => new CircleGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "CircleGeometry", "fromJSON" }, data
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
        public CircleGeometry() : base() { }

        public CircleGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CircleGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> segments = null, System.Nullable<decimal> thetaStart = null, System.Nullable<decimal> thetaLength = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CircleGeometry" },
                radius, segments, thetaStart, thetaLength
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
