/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ShapeGeometry>))]
public class ShapeGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static ShapeGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<ShapeGeometry>(
                entity => new ShapeGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "ShapeGeometry", "fromJSON" }, data
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
        public ShapeGeometry() : base() { }

        public ShapeGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ShapeGeometry(
            Shape shapes = null, System.Nullable<decimal> curveSegments = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ShapeGeometry" },
                shapes, curveSegments
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
