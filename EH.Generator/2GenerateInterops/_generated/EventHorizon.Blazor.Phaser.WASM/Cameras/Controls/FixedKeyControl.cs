/// Generated - Do Not Edit
namespace Phaser.Cameras.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<FixedKeyControl>))]
    public class FixedKeyControl : CachedEntityObject
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
            set
            {
__camera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }

        private Key __left;
        public Key left
        {
            get
            {
            if(__left == null)
            {
                __left = EventHorizonBlazorInterop.GetClass<Key>(
                    this.___guid,
                    "left",
                    (entity) =>
                    {
                        return new Key() { ___guid = entity.___guid };
                    }
                );
            }
            return __left;
            }
            set
            {
__left = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "left",
                    value
                );
            }
        }

        private Key __right;
        public Key right
        {
            get
            {
            if(__right == null)
            {
                __right = EventHorizonBlazorInterop.GetClass<Key>(
                    this.___guid,
                    "right",
                    (entity) =>
                    {
                        return new Key() { ___guid = entity.___guid };
                    }
                );
            }
            return __right;
            }
            set
            {
__right = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "right",
                    value
                );
            }
        }

        private Key __up;
        public Key up
        {
            get
            {
            if(__up == null)
            {
                __up = EventHorizonBlazorInterop.GetClass<Key>(
                    this.___guid,
                    "up",
                    (entity) =>
                    {
                        return new Key() { ___guid = entity.___guid };
                    }
                );
            }
            return __up;
            }
            set
            {
__up = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "up",
                    value
                );
            }
        }

        private Key __down;
        public Key down
        {
            get
            {
            if(__down == null)
            {
                __down = EventHorizonBlazorInterop.GetClass<Key>(
                    this.___guid,
                    "down",
                    (entity) =>
                    {
                        return new Key() { ___guid = entity.___guid };
                    }
                );
            }
            return __down;
            }
            set
            {
__down = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "down",
                    value
                );
            }
        }

        private Key __zoomIn;
        public Key zoomIn
        {
            get
            {
            if(__zoomIn == null)
            {
                __zoomIn = EventHorizonBlazorInterop.GetClass<Key>(
                    this.___guid,
                    "zoomIn",
                    (entity) =>
                    {
                        return new Key() { ___guid = entity.___guid };
                    }
                );
            }
            return __zoomIn;
            }
            set
            {
__zoomIn = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomIn",
                    value
                );
            }
        }

        private Key __zoomOut;
        public Key zoomOut
        {
            get
            {
            if(__zoomOut == null)
            {
                __zoomOut = EventHorizonBlazorInterop.GetClass<Key>(
                    this.___guid,
                    "zoomOut",
                    (entity) =>
                    {
                        return new Key() { ___guid = entity.___guid };
                    }
                );
            }
            return __zoomOut;
            }
            set
            {
__zoomOut = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomOut",
                    value
                );
            }
        }

        
        public decimal zoomSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoomSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomSpeed",
                    value
                );
            }
        }

        
        public decimal minZoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minZoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minZoom",
                    value
                );
            }
        }

        
        public decimal maxZoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxZoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxZoom",
                    value
                );
            }
        }

        
        public decimal speedX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speedX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speedX",
                    value
                );
            }
        }

        
        public decimal speedY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speedY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speedY",
                    value
                );
            }
        }

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public FixedKeyControl() : base() { }

        public FixedKeyControl(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public FixedKeyControl(
            FixedKeyControlConfig config
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Cameras", "Controls", "FixedKeyControl" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public FixedKeyControl start()
        {
            return EventHorizonBlazorInterop.FuncClass<FixedKeyControl>(
                entity => new FixedKeyControl() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" }
                }
            );
        }

        public FixedKeyControl stop()
        {
            return EventHorizonBlazorInterop.FuncClass<FixedKeyControl>(
                entity => new FixedKeyControl() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public FixedKeyControl setCamera(Camera camera)
        {
            return EventHorizonBlazorInterop.FuncClass<FixedKeyControl>(
                entity => new FixedKeyControl() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCamera" }, camera
                }
            );
        }

        public void update(decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, delta
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