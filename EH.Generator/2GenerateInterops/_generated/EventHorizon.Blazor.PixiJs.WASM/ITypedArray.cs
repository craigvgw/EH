/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ITypedArray : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ITypedArrayCachedEntity>))]
public class ITypedArrayCachedEntity : CachedEntityObject, ITypedArray
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
        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
        }

        
        public decimal BYTES_PER_ELEMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BYTES_PER_ELEMENT"
                );
            }
        }
    #endregion
    
    #region Constructor
        public ITypedArrayCachedEntity() : base() { }

        public ITypedArrayCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
