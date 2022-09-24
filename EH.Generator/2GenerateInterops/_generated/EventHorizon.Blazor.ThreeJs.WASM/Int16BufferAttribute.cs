/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Int16BufferAttribute>))]
public class Int16BufferAttribute : BufferAttribute
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
        public Int16BufferAttribute() : base() { }

        public Int16BufferAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Int16BufferAttribute(
            Iterable<decimal> array, decimal itemSize, System.Nullable<bool> normalized = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Int16BufferAttribute" },
                array, itemSize, normalized
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
