/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ExtrudeGeometry>))]
public class ExtrudeGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static ExtrudeGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<ExtrudeGeometry>(
                entity => new ExtrudeGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "ExtrudeGeometry", "fromJSON" }, data
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
        public ExtrudeGeometry() : base() { }

        public ExtrudeGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ExtrudeGeometry(
            Shape shapes = null, ExtrudeGeometryOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ExtrudeGeometry" },
                shapes, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void addShapeList(Shape[] shapes, object options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addShapeList" }, shapes, options
                }
            );
        }

        public void addShape(Shape shape, object options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addShape" }, shape, options
                }
            );
        }
    #endregion
}
