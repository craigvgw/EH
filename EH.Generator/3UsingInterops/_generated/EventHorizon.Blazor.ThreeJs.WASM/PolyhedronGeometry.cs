/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PolyhedronGeometry>))]
public class PolyhedronGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static PolyhedronGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<PolyhedronGeometry>(
                entity => new PolyhedronGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "PolyhedronGeometry", "fromJSON" }, data
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
        public PolyhedronGeometry() : base() { }

        public PolyhedronGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PolyhedronGeometry(
            decimal[] vertices = null, decimal[] indices = null, System.Nullable<decimal> radius = null, System.Nullable<decimal> detail = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PolyhedronGeometry" },
                vertices, indices, radius, detail
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
