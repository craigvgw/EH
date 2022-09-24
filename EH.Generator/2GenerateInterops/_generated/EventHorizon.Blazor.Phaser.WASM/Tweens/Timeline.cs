/// Generated - Do Not Edit
namespace Phaser.Tweens
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Timeline>))]
    public class Timeline : EventEmitter
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
        private TweenManager __manager;
        public TweenManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<TweenManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new TweenManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __manager;
            }
            set
            {
__manager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manager",
                    value
                );
            }
        }

        
        public bool isTimeline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isTimeline"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isTimeline",
                    value
                );
            }
        }

        
        public CachedEntity[] data
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "data",
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
                    "data",
                    value
                );
            }
        }

        
        public decimal totalData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalData",
                    value
                );
            }
        }

        
        public bool useFrames
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useFrames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useFrames",
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

        
        public decimal loop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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

        
        public decimal loopDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopDelay",
                    value
                );
            }
        }

        
        public decimal loopCounter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopCounter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopCounter",
                    value
                );
            }
        }

        
        public decimal completeDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "completeDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "completeDelay",
                    value
                );
            }
        }

        
        public decimal countdown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "countdown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "countdown",
                    value
                );
            }
        }

        
        public decimal state
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "state"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
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

        
        public decimal totalElapsed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalElapsed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalElapsed",
                    value
                );
            }
        }

        
        public decimal duration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "duration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "duration",
                    value
                );
            }
        }

        
        public decimal progress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "progress"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "progress",
                    value
                );
            }
        }

        
        public decimal totalDuration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalDuration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalDuration",
                    value
                );
            }
        }

        
        public decimal totalProgress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalProgress"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalProgress",
                    value
                );
            }
        }

        
        public CachedEntity callbacks
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "callbacks"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "callbacks",
                    value
                );
            }
        }

        
        public CachedEntity callbackScope
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "callbackScope",
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
                    "callbackScope",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Timeline() : base() { }

        public Timeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Timeline(
            TweenManager manager
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tweens", "Timeline" },
                manager
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Timeline setTimeScale(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Timeline>(
                entity => new Timeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTimeScale" }, value
                }
            );
        }

        public decimal getTimeScale()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTimeScale" }
                }
            );
        }

        public bool isPlaying()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPlaying" }
                }
            );
        }

        public Timeline add(TweenBuilderConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Timeline>(
                entity => new Timeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, config
                }
            );
        }

        public Timeline queue(Tween tween)
        {
            return EventHorizonBlazorInterop.FuncClass<Timeline>(
                entity => new Timeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "queue" }, tween
                }
            );
        }

        public bool hasOffset(Tween tween)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasOffset" }, tween
                }
            );
        }

        public bool isOffsetAbsolute(decimal value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isOffsetAbsolute" }, value
                }
            );
        }

        public bool isOffsetRelative(string value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isOffsetRelative" }, value
                }
            );
        }

        public decimal getRelativeOffset(string value, decimal base)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRelativeOffset" }, value, base
                }
            );
        }

        public void calcDuration()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calcDuration" }
                }
            );
        }

        public bool init()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "init" }
                }
            );
        }

        public void resetTweens(bool resetFromLoop)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetTweens" }, resetFromLoop
                }
            );
        }

        public TweenManager makeActive(Tween tween)
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeActive" }, tween
                }
            );
        }

        public void play()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "play" }
                }
            );
        }

        public void nextState()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "nextState" }
                }
            );
        }

        public bool update(decimal timestamp, decimal delta)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, timestamp, delta
                }
            );
        }

        public void stop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public Timeline pause()
        {
            return EventHorizonBlazorInterop.FuncClass<Timeline>(
                entity => new Timeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public Timeline resume()
        {
            return EventHorizonBlazorInterop.FuncClass<Timeline>(
                entity => new Timeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }
                }
            );
        }

        public bool hasTarget(object target)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTarget" }, target
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