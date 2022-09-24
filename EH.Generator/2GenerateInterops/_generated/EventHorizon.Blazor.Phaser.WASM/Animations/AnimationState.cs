/// Generated - Do Not Edit
namespace Phaser.Animations
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationState>))]
    public class AnimationState : CachedEntityObject
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
        private GameObject __parent;
        public GameObject parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
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

        private AnimationManager __animationManager;
        public AnimationManager animationManager
        {
            get
            {
            if(__animationManager == null)
            {
                __animationManager = EventHorizonBlazorInterop.GetClass<AnimationManager>(
                    this.___guid,
                    "animationManager",
                    (entity) =>
                    {
                        return new AnimationManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __animationManager;
            }
            set
            {
__animationManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationManager",
                    value
                );
            }
        }

        
        public bool isPlaying
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPlaying"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPlaying",
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasStarted",
                    value
                );
            }
        }

        private Animation __currentAnim;
        public Animation currentAnim
        {
            get
            {
            if(__currentAnim == null)
            {
                __currentAnim = EventHorizonBlazorInterop.GetClass<Animation>(
                    this.___guid,
                    "currentAnim",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentAnim;
            }
            set
            {
__currentAnim = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentAnim",
                    value
                );
            }
        }

        private AnimationFrame __currentFrame;
        public AnimationFrame currentFrame
        {
            get
            {
            if(__currentFrame == null)
            {
                __currentFrame = EventHorizonBlazorInterop.GetClass<AnimationFrame>(
                    this.___guid,
                    "currentFrame",
                    (entity) =>
                    {
                        return new AnimationFrame() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentFrame;
            }
            set
            {
__currentFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentFrame",
                    value
                );
            }
        }

        
        public string nextAnim
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "nextAnim"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nextAnim",
                    value
                );
            }
        }

        
        public CachedEntity[] nextAnimsQueue
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "nextAnimsQueue",
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
                    "nextAnimsQueue",
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

        
        public decimal frameRate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frameRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frameRate",
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

        
        public decimal msPerFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "msPerFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "msPerFrame",
                    value
                );
            }
        }

        
        public bool skipMissedFrames
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipMissedFrames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipMissedFrames",
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

        
        public decimal repeat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "repeat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeat",
                    value
                );
            }
        }

        
        public decimal repeatDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "repeatDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeatDelay",
                    value
                );
            }
        }

        
        public bool yoyo
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "yoyo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "yoyo",
                    value
                );
            }
        }

        
        public bool showOnStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showOnStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showOnStart",
                    value
                );
            }
        }

        
        public bool hideOnComplete
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hideOnComplete"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hideOnComplete",
                    value
                );
            }
        }

        
        public bool forward
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forward"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forward",
                    value
                );
            }
        }

        
        public bool inReverse
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inReverse"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inReverse",
                    value
                );
            }
        }

        
        public decimal accumulator
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "accumulator"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "accumulator",
                    value
                );
            }
        }

        
        public decimal nextTick
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nextTick"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nextTick",
                    value
                );
            }
        }

        
        public decimal delayCounter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delayCounter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayCounter",
                    value
                );
            }
        }

        
        public decimal repeatCounter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "repeatCounter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeatCounter",
                    value
                );
            }
        }

        
        public bool pendingRepeat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pendingRepeat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pendingRepeat",
                    value
                );
            }
        }

        
        public bool isPaused
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPaused"
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationState() : base() { }

        public AnimationState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationState(
            GameObject parent
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Animations", "AnimationState" },
                parent
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public GameObject chain(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "chain" }, key
                }
            );
        }

        public string getName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getName" }
                }
            );
        }

        public string getFrameName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getFrameName" }
                }
            );
        }

        public GameObject pause(AnimationFrame atFrame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }, atFrame
                }
            );
        }

        public GameObject resume(AnimationFrame fromFrame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }, fromFrame
                }
            );
        }

        public GameObject playAfterDelay(string key, decimal delay)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "playAfterDelay" }, key, delay
                }
            );
        }

        public GameObject playAfterRepeat(string key, System.Nullable<decimal> repeatCount = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "playAfterRepeat" }, key, repeatCount
                }
            );
        }

        public GameObject play(string key, System.Nullable<bool> ignoreIfPlaying = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }, key, ignoreIfPlaying
                }
            );
        }

        public GameObject playReverse(string key, System.Nullable<bool> ignoreIfPlaying = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "playReverse" }, key, ignoreIfPlaying
                }
            );
        }

        public GameObject startAnimation(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "startAnimation" }, key
                }
            );
        }

        public GameObject reverse()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reverse" }
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

        public GameObject setProgress(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setProgress" }, value
                }
            );
        }

        public GameObject setRepeat(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRepeat" }, value
                }
            );
        }

        public void globalRemove(string key = null, Animation animation = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "globalRemove" }, key, animation
                }
            );
        }

        public GameObject restart(System.Nullable<bool> includeDelay = null, System.Nullable<bool> resetRepeats = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "restart" }, includeDelay, resetRepeats
                }
            );
        }

        public GameObject complete()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "complete" }
                }
            );
        }

        public GameObject stop()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public GameObject stopAfterDelay(decimal delay)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopAfterDelay" }, delay
                }
            );
        }

        public GameObject stopAfterRepeat(System.Nullable<decimal> repeatCount = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopAfterRepeat" }, repeatCount
                }
            );
        }

        public GameObject stopOnFrame(AnimationFrame frame)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopOnFrame" }, frame
                }
            );
        }

        public decimal getTotalFrames()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalFrames" }
                }
            );
        }

        public void update(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, time, delta
                }
            );
        }

        public GameObject setCurrentFrame(AnimationFrame animationFrame)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCurrentFrame" }, animationFrame
                }
            );
        }

        public GameObject nextFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "nextFrame" }
                }
            );
        }

        public GameObject previousFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "previousFrame" }
                }
            );
        }

        public Animation get(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, key
                }
            );
        }

        public bool exists(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "exists" }, key
                }
            );
        }

        public Animation create(Animation config)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, config
                }
            );
        }

        public AnimationFrame[] generateFrameNames(string key, GenerateFrameNames config = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationFrame>(
                entity => new AnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateFrameNames" }, key, config
                }
            );
        }

        public AnimationFrame[] generateFrameNumbers(string key, GenerateFrameNumbers config)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationFrame>(
                entity => new AnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateFrameNumbers" }, key, config
                }
            );
        }

        public Animation remove(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, key
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