/// Generated - Do Not Edit
namespace Phaser.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TimeStep>))]
    public class TimeStep : CachedEntityObject
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
        private Game __game;
        public Game game
        {
            get
            {
            if(__game == null)
            {
                __game = EventHorizonBlazorInterop.GetClass<Game>(
                    this.___guid,
                    "game",
                    (entity) =>
                    {
                        return new Game() { ___guid = entity.___guid };
                    }
                );
            }
            return __game;
            }
        }

        private RequestAnimationFrame __raf;
        public RequestAnimationFrame raf
        {
            get
            {
            if(__raf == null)
            {
                __raf = EventHorizonBlazorInterop.GetClass<RequestAnimationFrame>(
                    this.___guid,
                    "raf",
                    (entity) =>
                    {
                        return new RequestAnimationFrame() { ___guid = entity.___guid };
                    }
                );
            }
            return __raf;
            }
        }

        
        public bool started
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "started"
                );
            }
        }

        
        public bool running
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "running"
                );
            }
        }

        
        public decimal minFps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minFps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minFps",
                    value
                );
            }
        }

        
        public decimal targetFps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "targetFps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetFps",
                    value
                );
            }
        }

        
        public decimal actualFps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualFps"
                );
            }
        }

        
        public decimal nextFpsUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nextFpsUpdate"
                );
            }
        }

        
        public decimal framesThisSecond
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "framesThisSecond"
                );
            }
        }

        private TimeStepCallback __callback;
        public TimeStepCallback callback
        {
            get
            {
            if(__callback == null)
            {
                __callback = EventHorizonBlazorInterop.GetClass<TimeStepCallback>(
                    this.___guid,
                    "callback",
                    (entity) =>
                    {
                        return new TimeStepCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __callback;
            }
            set
            {
__callback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "callback",
                    value
                );
            }
        }

        
        public bool forceSetTimeOut
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceSetTimeOut"
                );
            }
        }

        
        public decimal time
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "time"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "time",
                    value
                );
            }
        }

        
        public decimal startTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startTime",
                    value
                );
            }
        }

        
        public decimal lastTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lastTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lastTime",
                    value
                );
            }
        }

        
        public decimal frame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frame"
                );
            }
        }

        
        public bool inFocus
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inFocus"
                );
            }
        }

        
        public decimal delta
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delta"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delta",
                    value
                );
            }
        }

        
        public decimal deltaIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "deltaIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaIndex",
                    value
                );
            }
        }

        
        public decimal[] deltaHistory
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "deltaHistory"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaHistory",
                    value
                );
            }
        }

        
        public decimal deltaSmoothingMax
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "deltaSmoothingMax"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaSmoothingMax",
                    value
                );
            }
        }

        
        public decimal panicMax
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "panicMax"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panicMax",
                    value
                );
            }
        }

        
        public decimal rawDelta
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rawDelta"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rawDelta",
                    value
                );
            }
        }

        
        public decimal now
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "now"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "now",
                    value
                );
            }
        }

        
        public bool smoothStep
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "smoothStep"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "smoothStep",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TimeStep() : base() { }

        public TimeStep(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TimeStep(
            Game game, FPSConfig config
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Core", "TimeStep" },
                game, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void blur()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blur" }
                }
            );
        }

        public void focus()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "focus" }
                }
            );
        }

        public void pause()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public void resume()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resume" }
                }
            );
        }

        public void resetDelta()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetDelta" }
                }
            );
        }

        public void start(TimeStepCallback callback)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }, callback
                }
            );
        }

        public void step()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "step" }
                }
            );
        }

        public void tick()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "tick" }
                }
            );
        }

        public void sleep()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sleep" }
                }
            );
        }

        public void wake(System.Nullable<bool> seamless = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "wake" }, seamless
                }
            );
        }

        public decimal getDuration()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDuration" }
                }
            );
        }

        public decimal getDurationMS()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDurationMS" }
                }
            );
        }

        public TimeStep stop()
        {
            return EventHorizonBlazorInterop.FuncClass<TimeStep>(
                entity => new TimeStep() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
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