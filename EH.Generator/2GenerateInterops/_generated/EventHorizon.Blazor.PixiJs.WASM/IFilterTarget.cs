/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IFilterTarget : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IFilterTargetCachedEntity>))]
public class IFilterTargetCachedEntity : CachedEntityObject, IFilterTarget
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
        private Rectangle __filterArea;
        public Rectangle filterArea
        {
            get
            {
            if(__filterArea == null)
            {
                __filterArea = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "filterArea",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __filterArea;
            }
            set
            {
__filterArea = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filterArea",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IFilterTargetCachedEntity() : base() { }

        public IFilterTargetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public Rectangle getBounds(System.Nullable<bool> skipUpdate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, skipUpdate
                }
            );
        }
    #endregion
}
