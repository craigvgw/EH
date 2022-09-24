/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TreeSearch>))]
public class TreeSearch : CachedEntityObject
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
        public TreeSearch() : base() { }

        public TreeSearch(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public bool recursiveFindHit(InteractionEvent interactionEvent, DisplayObject displayObject, ActionCallback<InteractionEvent, DisplayObject, bool> func = null, System.Nullable<bool> hitTest = null, System.Nullable<bool> interactive = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "recursiveFindHit" }, interactionEvent, displayObject, func, hitTest, interactive
                }
            );
        }

        public void findHit(InteractionEvent interactionEvent, DisplayObject displayObject, ActionCallback<InteractionEvent, DisplayObject, bool> func = null, System.Nullable<bool> hitTest = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "findHit" }, interactionEvent, displayObject, func, hitTest
                }
            );
        }
    #endregion
}
