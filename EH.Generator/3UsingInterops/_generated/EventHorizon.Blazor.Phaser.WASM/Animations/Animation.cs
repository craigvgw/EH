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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Animation>))]
    public class Animation : CachedEntityObject
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
        private AnimationManager __manager;
        public AnimationManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<AnimationManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new AnimationManager() { ___guid = entity.___guid };
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

        
        public string key
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "key"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "key",
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

        
        public AnimationFrame[] frames
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AnimationFrame>(
                    this.___guid,
                    "frames",
                    (entity) =>
                    {
                        return new AnimationFrame() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frames",
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
        #endregion
        
        #region Constructor
        public Animation() : base() { }

        public Animation(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Animation(
            AnimationManager manager, string key, Animation config
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Animations", "Animation" },
                manager, key, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getTotalFrames()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalFrames" }
                }
            );
        }

        public void calculateDuration(Animation target, decimal totalFrames, decimal duration, decimal frameRate)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateDuration" }, target, totalFrames, duration, frameRate
                }
            );
        }

        public Animation addFrame(string config)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addFrame" }, config
                }
            );
        }

        public Animation addFrameAt(decimal index, string config)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addFrameAt" }, index, config
                }
            );
        }

        public bool checkFrame(decimal index)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "checkFrame" }, index
                }
            );
        }

        public AnimationFrame[] getFrames(TextureManager textureManager, string frames, string defaultTextureKey = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationFrame>(
                entity => new AnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFrames" }, textureManager, frames, defaultTextureKey
                }
            );
        }

        public void getNextTick(AnimationState state)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getNextTick" }, state
                }
            );
        }

        public AnimationFrame getFrameByProgress(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationFrame>(
                entity => new AnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFrameByProgress" }, value
                }
            );
        }

        public void nextFrame(AnimationState state)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "nextFrame" }, state
                }
            );
        }

        public AnimationFrame getLastFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationFrame>(
                entity => new AnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLastFrame" }
                }
            );
        }

        public void previousFrame(AnimationState state)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "previousFrame" }, state
                }
            );
        }

        public Animation removeFrame(AnimationFrame frame)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeFrame" }, frame
                }
            );
        }

        public Animation removeFrameAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeFrameAt" }, index
                }
            );
        }

        public void repeatAnimation(AnimationState state)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "repeatAnimation" }, state
                }
            );
        }

        public JSONAnimation toJSON()
        {
            return EventHorizonBlazorInterop.FuncClass<JSONAnimation>(
                entity => new JSONAnimation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }

        public Animation updateFrameSequence()
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateFrameSequence" }
                }
            );
        }

        public Animation pause()
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public Animation resume()
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }
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