/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TetrahedronGeometry>))]
public class TetrahedronGeometry : PolyhedronGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static TetrahedronGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<TetrahedronGeometry>(
                entity => new TetrahedronGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "TetrahedronGeometry", "fromJSON" }, data
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
        public TetrahedronGeometry() : base() { }

        public TetrahedronGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TetrahedronGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> detail = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TetrahedronGeometry" },
                radius, detail
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
