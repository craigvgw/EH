/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Float64BufferAttribute>))]
public class Float64BufferAttribute : BufferAttribute
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
        public Float64BufferAttribute() : base() { }

        public Float64BufferAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Float64BufferAttribute(
            Iterable<decimal> array, decimal itemSize, System.Nullable<bool> normalized = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Float64BufferAttribute" },
                array, itemSize, normalized
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
