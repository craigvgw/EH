/// Generated - Do Not Edit
namespace Phaser.Time
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TimerEvent>))]
    public class TimerEvent : CachedEntityObject
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
        
        public decimal delay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delay"
                );
            }
        }

        
        public decimal repeat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "repeat"
                );
            }
        }

        
        public decimal repeatCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "repeatCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeatCount",
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
        }

        
        public CachedEntity callbackScope
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "callbackScope"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "callbackScope",
                    value
                );
            }
        }

        
        public CachedEntity[] args
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "args",
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
                    "args",
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

        
        public decimal startAt
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startAt"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startAt",
                    value
                );
            }
        }

        
        public decimal elapsed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "elapsed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elapsed",
                    value
                );
            }
        }

        
        public bool paused
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "paused"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "paused",
                    value
                );
            }
        }

        
        public bool hasDispatched
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasDispatched"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasDispatched",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TimerEvent() : base() { }

        public TimerEvent(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TimerEvent(
            TimerEventConfig config
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Time", "TimerEvent" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void callback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "callback" }
                }
            );
        }

        public TimerEvent reset(TimerEventConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<TimerEvent>(
                entity => new TimerEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }, config
                }
            );
        }

        public decimal getProgress()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getProgress" }
                }
            );
        }

        public decimal getOverallProgress()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getOverallProgress" }
                }
            );
        }

        public decimal getRepeatCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRepeatCount" }
                }
            );
        }

        public decimal getElapsed()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getElapsed" }
                }
            );
        }

        public decimal getElapsedSeconds()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getElapsedSeconds" }
                }
            );
        }

        public decimal getRemaining()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRemaining" }
                }
            );
        }

        public decimal getRemainingSeconds()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRemainingSeconds" }
                }
            );
        }

        public decimal getOverallRemaining()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getOverallRemaining" }
                }
            );
        }

        public decimal getOverallRemainingSeconds()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getOverallRemainingSeconds" }
                }
            );
        }

        public void remove(System.Nullable<bool> dispatchCallback = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, dispatchCallback
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}