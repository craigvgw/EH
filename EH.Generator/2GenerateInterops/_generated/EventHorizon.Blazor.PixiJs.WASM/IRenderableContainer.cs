/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IRenderableContainer : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IRenderableContainerCachedEntity>))]
public class IRenderableContainerCachedEntity : CachedEntityObject, IRenderableContainer
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
        public IRenderableContainerCachedEntity() : base() { }

        public IRenderableContainerCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public Rectangle getLocalBounds(Rectangle rect = null, System.Nullable<bool> skipChildrenUpdate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalBounds" }, rect, skipChildrenUpdate
                }
            );
        }
    #endregion
}
