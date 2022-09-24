/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AnimationAction>))]
public class AnimationAction : CachedEntityObject
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
        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }

        
        public int loop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
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

        
        public decimal weight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "weight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "weight",
                    value
                );
            }
        }

        
        public decimal repetitions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "repetitions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repetitions",
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

        
        public bool enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enabled",
                    value
                );
            }
        }

        
        public bool clampWhenFinished
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clampWhenFinished"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clampWhenFinished",
                    value
                );
            }
        }

        
        public bool zeroSlopeAtStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "zeroSlopeAtStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zeroSlopeAtStart",
                    value
                );
            }
        }

        
        public bool zeroSlopeAtEnd
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "zeroSlopeAtEnd"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zeroSlopeAtEnd",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public AnimationAction() : base() { }

        public AnimationAction(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationAction(
            AnimationMixer mixer, AnimationClip clip, Object3D localRoot = null, System.Nullable<int> blendMode = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AnimationAction" },
                mixer, clip, localRoot, blendMode
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public AnimationAction play()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }
                }
            );
        }

        public AnimationAction stop()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public AnimationAction reset()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public bool isRunning()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isRunning" }
                }
            );
        }

        public bool isScheduled()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isScheduled" }
                }
            );
        }

        public AnimationAction startAt(decimal time)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "startAt" }, time
                }
            );
        }

        public AnimationAction setLoop(int mode, decimal repetitions)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLoop" }, mode, repetitions
                }
            );
        }

        public AnimationAction setEffectiveWeight(decimal weight)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEffectiveWeight" }, weight
                }
            );
        }

        public decimal getEffectiveWeight()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getEffectiveWeight" }
                }
            );
        }

        public AnimationAction fadeIn(decimal duration)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fadeIn" }, duration
                }
            );
        }

        public AnimationAction fadeOut(decimal duration)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fadeOut" }, duration
                }
            );
        }

        public AnimationAction crossFadeFrom(AnimationAction fadeOutAction, decimal duration, bool warp)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "crossFadeFrom" }, fadeOutAction, duration, warp
                }
            );
        }

        public AnimationAction crossFadeTo(AnimationAction fadeInAction, decimal duration, bool warp)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "crossFadeTo" }, fadeInAction, duration, warp
                }
            );
        }

        public AnimationAction stopFading()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopFading" }
                }
            );
        }

        public AnimationAction setEffectiveTimeScale(decimal timeScale)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEffectiveTimeScale" }, timeScale
                }
            );
        }

        public decimal getEffectiveTimeScale()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getEffectiveTimeScale" }
                }
            );
        }

        public AnimationAction setDuration(decimal duration)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDuration" }, duration
                }
            );
        }

        public AnimationAction syncWith(AnimationAction action)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "syncWith" }, action
                }
            );
        }

        public AnimationAction halt(decimal duration)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "halt" }, duration
                }
            );
        }

        public AnimationAction warp(decimal statTimeScale, decimal endTimeScale, decimal duration)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "warp" }, statTimeScale, endTimeScale, duration
                }
            );
        }

        public AnimationAction stopWarping()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopWarping" }
                }
            );
        }

        public AnimationMixer getMixer()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationMixer>(
                entity => new AnimationMixer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMixer" }
                }
            );
        }

        public AnimationClip getClip()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getClip" }
                }
            );
        }

        public Object3D getRoot()
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRoot" }
                }
            );
        }
    #endregion
}
