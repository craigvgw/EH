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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TrackEntry>))]
    public class TrackEntry : CachedEntityObject
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
        
        public string animation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "animation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animation",
                    value
                );
            }
        }

        private TrackEntry __next;
        public TrackEntry next
        {
            get
            {
            if(__next == null)
            {
                __next = EventHorizonBlazorInterop.GetClass<TrackEntry>(
                    this.___guid,
                    "next",
                    (entity) =>
                    {
                        return new TrackEntry() { ___guid = entity.___guid };
                    }
                );
            }
            return __next;
            }
            set
            {
__next = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "next",
                    value
                );
            }
        }

        private TrackEntry __mixingFrom;
        public TrackEntry mixingFrom
        {
            get
            {
            if(__mixingFrom == null)
            {
                __mixingFrom = EventHorizonBlazorInterop.GetClass<TrackEntry>(
                    this.___guid,
                    "mixingFrom",
                    (entity) =>
                    {
                        return new TrackEntry() { ___guid = entity.___guid };
                    }
                );
            }
            return __mixingFrom;
            }
            set
            {
__mixingFrom = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mixingFrom",
                    value
                );
            }
        }

        private TrackEntry __mixingTo;
        public TrackEntry mixingTo
        {
            get
            {
            if(__mixingTo == null)
            {
                __mixingTo = EventHorizonBlazorInterop.GetClass<TrackEntry>(
                    this.___guid,
                    "mixingTo",
                    (entity) =>
                    {
                        return new TrackEntry() { ___guid = entity.___guid };
                    }
                );
            }
            return __mixingTo;
            }
            set
            {
__mixingTo = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mixingTo",
                    value
                );
            }
        }

        private AnimationStateListener2CachedEntity __listener;
        public AnimationStateListener2CachedEntity listener
        {
            get
            {
            if(__listener == null)
            {
                __listener = EventHorizonBlazorInterop.GetClass<AnimationStateListener2CachedEntity>(
                    this.___guid,
                    "listener",
                    (entity) =>
                    {
                        return new AnimationStateListener2CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __listener;
            }
            set
            {
__listener = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "listener",
                    value
                );
            }
        }

        
        public decimal trackIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "trackIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trackIndex",
                    value
                );
            }
        }

        
        public bool loop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loop",
                    value
                );
            }
        }

        
        public bool holdPrevious
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "holdPrevious"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "holdPrevious",
                    value
                );
            }
        }

        
        public decimal eventThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "eventThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "eventThreshold",
                    value
                );
            }
        }

        
        public decimal attachmentThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "attachmentThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachmentThreshold",
                    value
                );
            }
        }

        
        public decimal drawOrderThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "drawOrderThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawOrderThreshold",
                    value
                );
            }
        }

        
        public decimal animationStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "animationStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationStart",
                    value
                );
            }
        }

        
        public decimal animationEnd
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "animationEnd"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationEnd",
                    value
                );
            }
        }

        
        public decimal animationLast
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "animationLast"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationLast",
                    value
                );
            }
        }

        
        public decimal nextAnimationLast
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nextAnimationLast"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nextAnimationLast",
                    value
                );
            }
        }

        
        public decimal delay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delay",
                    value
                );
            }
        }

        
        public decimal trackTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "trackTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trackTime",
                    value
                );
            }
        }

        
        public decimal trackLast
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "trackLast"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trackLast",
                    value
                );
            }
        }

        
        public decimal nextTrackLast
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nextTrackLast"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nextTrackLast",
                    value
                );
            }
        }

        
        public decimal trackEnd
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "trackEnd"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trackEnd",
                    value
                );
            }
        }

        
        public decimal timeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeScale",
                    value
                );
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public decimal mixTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mixTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mixTime",
                    value
                );
            }
        }

        
        public decimal mixDuration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mixDuration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mixDuration",
                    value
                );
            }
        }

        
        public decimal interruptAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "interruptAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interruptAlpha",
                    value
                );
            }
        }

        
        public decimal totalAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalAlpha",
                    value
                );
            }
        }

        
        public int mixBlend
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "mixBlend"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mixBlend",
                    value
                );
            }
        }

        
        public decimal[] timelineMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "timelineMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timelineMode",
                    value
                );
            }
        }

        
        public TrackEntry[] timelineHoldMix
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TrackEntry>(
                    this.___guid,
                    "timelineHoldMix",
                    (entity) =>
                    {
                        return new TrackEntry() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timelineHoldMix",
                    value
                );
            }
        }

        
        public decimal[] timelinesRotation
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "timelinesRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timelinesRotation",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TrackEntry() : base() { }

        public TrackEntry(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public decimal getAnimationTime()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAnimationTime" }
                }
            );
        }

        public void setAnimationLast(decimal animationLast)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAnimationLast" }, animationLast
                }
            );
        }

        public bool isComplete()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isComplete" }
                }
            );
        }

        public void resetRotationDirections()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetRotationDirections" }
                }
            );
        }
        #endregion
    }
}