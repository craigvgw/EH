/// Generated - Do Not Edit
namespace spine
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<EventQueue>))]
    public class EventQueue : CachedEntityObject
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
        
        public CachedEntity[] objects
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "objects",
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
                    "objects",
                    value
                );
            }
        }

        
        public bool drainDisabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drainDisabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drainDisabled",
                    value
                );
            }
        }

        private AnimationState __animState;
        public AnimationState animState
        {
            get
            {
            if(__animState == null)
            {
                __animState = EventHorizonBlazorInterop.GetClass<AnimationState>(
                    this.___guid,
                    "animState",
                    (entity) =>
                    {
                        return new AnimationState() { ___guid = entity.___guid };
                    }
                );
            }
            return __animState;
            }
            set
            {
__animState = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animState",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public EventQueue() : base() { }

        public EventQueue(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public EventQueue(
            AnimationState animState
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "EventQueue" },
                animState
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void start(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }, entry
                }
            );
        }

        public void interrupt(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "interrupt" }, entry
                }
            );
        }

        public void end(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }, entry
                }
            );
        }

        public void dispose(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, entry
                }
            );
        }

        public void complete(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "complete" }, entry
                }
            );
        }

        public void @event(TrackEntry entry, string @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "@event" }, entry, @event
                }
            );
        }

        public void drain()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drain" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }
        #endregion
    }
}