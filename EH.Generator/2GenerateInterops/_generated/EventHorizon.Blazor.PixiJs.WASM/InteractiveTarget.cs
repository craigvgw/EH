/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface InteractiveTarget : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<InteractiveTargetCachedEntity>))]
public class InteractiveTargetCachedEntity : CachedEntityObject, InteractiveTarget
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
        
        public bool interactive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "interactive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interactive",
                    value
                );
            }
        }

        
        public bool interactiveChildren
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "interactiveChildren"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interactiveChildren",
                    value
                );
            }
        }

        private IHitAreaCachedEntity __hitArea;
        public IHitAreaCachedEntity hitArea
        {
            get
            {
            if(__hitArea == null)
            {
                __hitArea = EventHorizonBlazorInterop.GetClass<IHitAreaCachedEntity>(
                    this.___guid,
                    "hitArea",
                    (entity) =>
                    {
                        return new IHitAreaCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __hitArea;
            }
            set
            {
__hitArea = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hitArea",
                    value
                );
            }
        }

        
        public unknown cursor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "cursor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cursor",
                    value
                );
            }
        }

        
        public bool buttonMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "buttonMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buttonMode",
                    value
                );
            }
        }

        
        public CachedEntity trackedPointers
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "trackedPointers",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trackedPointers",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InteractiveTargetCachedEntity() : base() { }

        public InteractiveTargetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
