/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ISpriteMaskFilter : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ISpriteMaskFilterCachedEntity>))]
public class ISpriteMaskFilterCachedEntity : CachedEntityObject, ISpriteMaskFilter
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
        private IMaskTargetCachedEntity __maskSprite;
        public IMaskTargetCachedEntity maskSprite
        {
            get
            {
            if(__maskSprite == null)
            {
                __maskSprite = EventHorizonBlazorInterop.GetClass<IMaskTargetCachedEntity>(
                    this.___guid,
                    "maskSprite",
                    (entity) =>
                    {
                        return new IMaskTargetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __maskSprite;
            }
            set
            {
__maskSprite = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskSprite",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ISpriteMaskFilterCachedEntity() : base() { }

        public ISpriteMaskFilterCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
