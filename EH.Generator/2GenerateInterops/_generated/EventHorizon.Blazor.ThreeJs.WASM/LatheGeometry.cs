/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LatheGeometry>))]
public class LatheGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static LatheGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<LatheGeometry>(
                entity => new LatheGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "LatheGeometry", "fromJSON" }, data
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
        public LatheGeometry() : base() { }

        public LatheGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LatheGeometry(
            Vector2[] points = null, System.Nullable<decimal> segments = null, System.Nullable<decimal> phiStart = null, System.Nullable<decimal> phiLength = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LatheGeometry" },
                points, segments, phiStart, phiLength
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
