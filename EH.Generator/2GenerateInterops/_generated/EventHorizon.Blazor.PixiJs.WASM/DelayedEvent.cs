/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface DelayedEvent : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<DelayedEventCachedEntity>))]
public class DelayedEventCachedEntity : CachedEntityObject, DelayedEvent
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
        private DisplayObject __displayObject;
        public DisplayObject displayObject
        {
            get
            {
            if(__displayObject == null)
            {
                __displayObject = EventHorizonBlazorInterop.GetClass<DisplayObject>(
                    this.___guid,
                    "displayObject",
                    (entity) =>
                    {
                        return new DisplayObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __displayObject;
            }
            set
            {
__displayObject = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayObject",
                    value
                );
            }
        }

        
        public string eventString
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "eventString"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "eventString",
                    value
                );
            }
        }

        private InteractionEvent __eventData;
        public InteractionEvent eventData
        {
            get
            {
            if(__eventData == null)
            {
                __eventData = EventHorizonBlazorInterop.GetClass<InteractionEvent>(
                    this.___guid,
                    "eventData",
                    (entity) =>
                    {
                        return new InteractionEvent() { ___guid = entity.___guid };
                    }
                );
            }
            return __eventData;
            }
            set
            {
__eventData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "eventData",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public DelayedEventCachedEntity() : base() { }

        public DelayedEventCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
