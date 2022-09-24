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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Tween>))]
    public class Tween : EventEmitter
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
        private TweenManager __parent;
        public TweenManager parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<TweenManager>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new TweenManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
            }
            set
            {
__parent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        
        public bool parentIsTimeline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "parentIsTimeline"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentIsTimeline",
                    value
                );
            }
        }

        
        public TweenDataConfig[] data
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TweenDataConfig>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new TweenDataConfig() { ___guid = entity.___guid };
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

        
        public CachedEntity[] targets
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "targets"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targets",
                    value
                );
            }
        }

        
        public decimal totalTargets
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalTargets"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalTargets",
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

        
        public decimal startDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startDelay",
                    value
                );
            }
        }

        
        public bool hasStarted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasStarted"
                );
            }
        }

        
        public bool isSeeking
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSeeking"
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

        
        public decimal offset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
            }
        }

        
        public decimal calculatedOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "calculatedOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "calculatedOffset",
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
        public Tween() : base() { }

        public Tween(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Tween(
            TweenManager parent, TweenDataConfig[] data, CachedEntity[] targets
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tweens", "Tween" },
                parent, data, targets
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getValue(System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getValue" }, index
                }
            );
        }

        public Tween setTimeScale(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
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

        public bool isPaused()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPaused" }
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

        public Tween updateTo(string key, object value, System.Nullable<bool> startToCurrent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateTo" }, key, value, startToCurrent
                }
            );
        }

        public Tween restart()
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "restart" }
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

        public void makeActive()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "makeActive" }
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

        public Tween pause()
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public Tween play(System.Nullable<bool> resetFromTimeline = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }, resetFromTimeline
                }
            );
        }

        public void resetTweenData(bool resetFromLoop)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetTweenData" }, resetFromLoop
                }
            );
        }

        public Tween resume()
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }
                }
            );
        }

        public Tween seek(decimal toPosition, System.Nullable<decimal> delta = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "seek" }, toPosition, delta
                }
            );
        }

        public Tween complete(System.Nullable<decimal> delay = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "complete" }, delay
                }
            );
        }

        public Tween remove()
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }
                }
            );
        }

        public Tween stop(System.Nullable<decimal> resetTo = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }, resetTo
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

        public decimal setStateFromEnd(Tween tween, TweenDataConfig tweenData, decimal diff)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setStateFromEnd" }, tween, tweenData, diff
                }
            );
        }

        public decimal setStateFromStart(Tween tween, TweenDataConfig tweenData, decimal diff)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setStateFromStart" }, tween, tweenData, diff
                }
            );
        }

        public bool updateTweenData(Tween tween, TweenDataConfig tweenData, decimal delta)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "updateTweenData" }, tween, tweenData, delta
                }
            );
        }


        #endregion
    }
}