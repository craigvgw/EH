/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InteractionEvent>))]
public class InteractionEvent : CachedEntityObject
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
        
        public bool stopped
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stopped"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stopped",
                    value
                );
            }
        }

        private DisplayObject __stopsPropagatingAt;
        public DisplayObject stopsPropagatingAt
        {
            get
            {
            if(__stopsPropagatingAt == null)
            {
                __stopsPropagatingAt = EventHorizonBlazorInterop.GetClass<DisplayObject>(
                    this.___guid,
                    "stopsPropagatingAt",
                    (entity) =>
                    {
                        return new DisplayObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __stopsPropagatingAt;
            }
            set
            {
__stopsPropagatingAt = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stopsPropagatingAt",
                    value
                );
            }
        }

        
        public bool stopPropagationHint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stopPropagationHint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stopPropagationHint",
                    value
                );
            }
        }

        private DisplayObject __target;
        public DisplayObject target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<DisplayObject>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new DisplayObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
            }
            set
            {
__target = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        private DisplayObject __currentTarget;
        public DisplayObject currentTarget
        {
            get
            {
            if(__currentTarget == null)
            {
                __currentTarget = EventHorizonBlazorInterop.GetClass<DisplayObject>(
                    this.___guid,
                    "currentTarget",
                    (entity) =>
                    {
                        return new DisplayObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentTarget;
            }
            set
            {
__currentTarget = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentTarget",
                    value
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private InteractionData __data;
        public InteractionData data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<InteractionData>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new InteractionData() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InteractionEvent() : base() { }

        public InteractionEvent(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public void stopPropagation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopPropagation" }
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }
    #endregion
}
