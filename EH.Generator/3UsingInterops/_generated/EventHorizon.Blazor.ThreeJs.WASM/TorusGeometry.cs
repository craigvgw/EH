/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TorusGeometry>))]
public class TorusGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static TorusGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<TorusGeometry>(
                entity => new TorusGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "TorusGeometry", "fromJSON" }, data
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
        public TorusGeometry() : base() { }

        public TorusGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TorusGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> tube = null, System.Nullable<decimal> radialSegments = null, System.Nullable<decimal> tubularSegments = null, System.Nullable<decimal> arc = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TorusGeometry" },
                radius, tube, radialSegments, tubularSegments, arc
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
