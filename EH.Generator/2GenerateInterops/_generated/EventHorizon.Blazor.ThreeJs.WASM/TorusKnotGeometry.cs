/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TorusKnotGeometry>))]
public class TorusKnotGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static TorusKnotGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<TorusKnotGeometry>(
                entity => new TorusKnotGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "TorusKnotGeometry", "fromJSON" }, data
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
        public TorusKnotGeometry() : base() { }

        public TorusKnotGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TorusKnotGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> tube = null, System.Nullable<decimal> tubularSegments = null, System.Nullable<decimal> radialSegments = null, System.Nullable<decimal> p = null, System.Nullable<decimal> q = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TorusKnotGeometry" },
                radius, tube, tubularSegments, radialSegments, p, q
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
