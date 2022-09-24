/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Uint16BufferAttribute>))]
public class Uint16BufferAttribute : BufferAttribute
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
        public Uint16BufferAttribute() : base() { }

        public Uint16BufferAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Uint16BufferAttribute(
            Iterable<decimal> array, decimal itemSize, System.Nullable<bool> normalized = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Uint16BufferAttribute" },
                array, itemSize, normalized
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
