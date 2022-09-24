/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BatchGeometry>))]
public class BatchGeometry : Geometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public BatchGeometry() : base() { }

        public BatchGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BatchGeometry(
            System.Nullable<bool> _static = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BatchGeometry" },
                _static
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
