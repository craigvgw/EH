/// Generated - Do Not Edit
namespace Phaser.Cameras.Scene2D.Effects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Shake>))]
    public class Shake : CachedEntityObject
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
        private Camera __camera;
        public Camera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
            }
        }

        
        public bool isRunning
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRunning"
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
        }

        private Vector2 __intensity;
        public Vector2 intensity
        {
            get
            {
            if(__intensity == null)
            {
                __intensity = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "intensity",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __intensity;
            }
            set
            {
__intensity = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intensity",
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
        #endregion
        
        #region Constructor
        public Shake() : base() { }

        public Shake(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Shake(
            Camera camera
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Cameras", "Scene2D", "Effects", "Shake" },
                camera
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Camera start(System.Nullable<decimal> duration = null, System.Nullable<decimal> intensity = null, System.Nullable<bool> force = null, CameraShakeCallback callback = null, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" }, duration, intensity, force, callback, context
                }
            );
        }

        public void preRender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRender" }
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

        public void effectComplete()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "effectComplete" }
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
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