/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Uint8BufferAttribute>))]
public class Uint8BufferAttribute : BufferAttribute
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
        public Uint8BufferAttribute() : base() { }

        public Uint8BufferAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Uint8BufferAttribute(
            Iterable<decimal> array, decimal itemSize, System.Nullable<bool> normalized = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Uint8BufferAttribute" },
                array, itemSize, normalized
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
