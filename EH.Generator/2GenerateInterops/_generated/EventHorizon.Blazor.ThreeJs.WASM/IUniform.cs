/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IUniform<TValue> : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IUniformCachedEntity<CachedEntity>>))]
public class IUniformCachedEntity<TValue> : CachedEntityObject, IUniform<TValue> where TValue : CachedEntity, new()
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
        private TValue __value;
        public TValue value
        {
            get
            {
            if(__value == null)
            {
                __value = EventHorizonBlazorInterop.GetClass<TValue>(
                    this.___guid,
                    "value",
                    (entity) =>
                    {
                        return new TValue() { ___guid = entity.___guid };
                    }
                );
            }
            return __value;
            }
            set
            {
__value = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IUniformCachedEntity() : base() { }

        public IUniformCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
