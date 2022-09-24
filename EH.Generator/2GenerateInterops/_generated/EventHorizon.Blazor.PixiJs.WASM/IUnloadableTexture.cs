/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IUnloadableTexture : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IUnloadableTextureCachedEntity>))]
public class IUnloadableTextureCachedEntity : CachedEntityObject, IUnloadableTexture
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
        
        public IUnloadableTextureCachedEntity[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IUnloadableTextureCachedEntity>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new IUnloadableTextureCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "children",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IUnloadableTextureCachedEntity() : base() { }

        public IUnloadableTextureCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
