/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AnimationMixer>))]
public class AnimationMixer : EventDispatcher
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
    #endregion
    
    #region Constructor
        public AnimationMixer() : base() { }

        public AnimationMixer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AnimationMixer(
            Object3D root
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AnimationMixer" },
                root
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public AnimationAction clipAction(AnimationClip clip, Object3D root = null, System.Nullable<int> blendMode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clipAction" }, clip, root, blendMode
                }
            );
        }

        public AnimationAction existingAction(AnimationClip clip, Object3D root = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationAction>(
                entity => new AnimationAction() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "existingAction" }, clip, root
                }
            );
        }

        public AnimationMixer stopAllAction()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationMixer>(
                entity => new AnimationMixer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopAllAction" }
                }
            );
        }

        public AnimationMixer update(decimal deltaTime)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationMixer>(
                entity => new AnimationMixer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }, deltaTime
                }
            );
        }

        public AnimationMixer setTime(decimal timeInSeconds)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationMixer>(
                entity => new AnimationMixer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTime" }, timeInSeconds
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

        public void uncacheClip(AnimationClip clip)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uncacheClip" }, clip
                }
            );
        }

        public void uncacheRoot(Object3D root)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uncacheRoot" }, root
                }
            );
        }

        public void uncacheAction(AnimationClip clip, Object3D root = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uncacheAction" }, clip, root
                }
            );
        }
    #endregion
}
