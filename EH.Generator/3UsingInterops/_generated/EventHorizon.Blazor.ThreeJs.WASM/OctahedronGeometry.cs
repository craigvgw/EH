/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<OctahedronGeometry>))]
public class OctahedronGeometry : PolyhedronGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static OctahedronGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<OctahedronGeometry>(
                entity => new OctahedronGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "OctahedronGeometry", "fromJSON" }, data
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
        public OctahedronGeometry() : base() { }

        public OctahedronGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public OctahedronGeometry(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> detail = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "OctahedronGeometry" },
                radius, detail
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
