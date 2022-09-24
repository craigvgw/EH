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

    
    
    [JsonConverter(typeof(CachedEntityConverter<RotateTo>))]
    public class RotateTo : CachedEntityObject
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

        
        public decimal source
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "source"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }

        
        public decimal current
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "current"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "current",
                    value
                );
            }
        }

        
        public decimal destination
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "destination"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "destination",
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

        
        public bool clockwise
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clockwise"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clockwise",
                    value
                );
            }
        }

        
        public bool shortestPath
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shortestPath"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shortestPath",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public RotateTo() : base() { }

        public RotateTo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public RotateTo(
            Camera camera
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Cameras", "Scene2D", "Effects", "RotateTo" },
                camera
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void ease()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "ease" }
                }
            );
        }

        public Camera start(decimal radians, System.Nullable<bool> shortestPath = null, System.Nullable<decimal> duration = null, string ease = null, System.Nullable<bool> force = null, ActionCallback<Camera, decimal, decimal> callback = null, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" }, radians, shortestPath, duration, ease, force, callback, context
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