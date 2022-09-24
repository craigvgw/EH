/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BoxGeometry>))]
public class BoxGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static BoxGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<BoxGeometry>(
                entity => new BoxGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BoxGeometry", "fromJSON" }, data
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
        public BoxGeometry() : base() { }

        public BoxGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BoxGeometry(
            System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> depth = null, System.Nullable<decimal> widthSegments = null, System.Nullable<decimal> heightSegments = null, System.Nullable<decimal> depthSegments = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BoxGeometry" },
                width, height, depth, widthSegments, heightSegments, depthSegments
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
