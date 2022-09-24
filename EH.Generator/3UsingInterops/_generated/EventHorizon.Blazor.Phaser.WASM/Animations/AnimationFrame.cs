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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationFrame>))]
    public class AnimationFrame : CachedEntityObject
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
        
        public string textureKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "textureKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureKey",
                    value
                );
            }
        }

        
        public string textureFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "textureFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureFrame",
                    value
                );
            }
        }

        
        public decimal index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }

        private Frame __frame;
        public Frame frame
        {
            get
            {
            if(__frame == null)
            {
                __frame = EventHorizonBlazorInterop.GetClass<Frame>(
                    this.___guid,
                    "frame",
                    (entity) =>
                    {
                        return new Frame() { ___guid = entity.___guid };
                    }
                );
            }
            return __frame;
            }
            set
            {
__frame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public bool isFirst
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFirst"
                );
            }
        }

        
        public bool isLast
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLast"
                );
            }
        }

        private AnimationFrame __prevFrame;
        public AnimationFrame prevFrame
        {
            get
            {
            if(__prevFrame == null)
            {
                __prevFrame = EventHorizonBlazorInterop.GetClass<AnimationFrame>(
                    this.___guid,
                    "prevFrame",
                    (entity) =>
                    {
                        return new AnimationFrame() { ___guid = entity.___guid };
                    }
                );
            }
            return __prevFrame;
            }
        }

        private AnimationFrame __nextFrame;
        public AnimationFrame nextFrame
        {
            get
            {
            if(__nextFrame == null)
            {
                __nextFrame = EventHorizonBlazorInterop.GetClass<AnimationFrame>(
                    this.___guid,
                    "nextFrame",
                    (entity) =>
                    {
                        return new AnimationFrame() { ___guid = entity.___guid };
                    }
                );
            }
            return __nextFrame;
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
        }

        
        public bool isKeyFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isKeyFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isKeyFrame",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationFrame() : base() { }

        public AnimationFrame(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationFrame(
            string textureKey, string textureFrame, decimal index, Frame frame, System.Nullable<bool> isKeyFrame = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Animations", "AnimationFrame" },
                textureKey, textureFrame, index, frame, isKeyFrame
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public JSONAnimationFrame toJSON()
        {
            return EventHorizonBlazorInterop.FuncClass<JSONAnimationFrame>(
                entity => new JSONAnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
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