/// Generated - Do Not Edit
namespace Phaser.Cameras.Scene2D
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CameraManager>))]
    public class CameraManager : CachedEntityObject
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
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }

        private Systems __systems;
        public Systems systems
        {
            get
            {
            if(__systems == null)
            {
                __systems = EventHorizonBlazorInterop.GetClass<Systems>(
                    this.___guid,
                    "systems",
                    (entity) =>
                    {
                        return new Systems() { ___guid = entity.___guid };
                    }
                );
            }
            return __systems;
            }
            set
            {
__systems = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systems",
                    value
                );
            }
        }

        
        public bool roundPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "roundPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roundPixels",
                    value
                );
            }
        }

        
        public Camera[] cameras
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Camera>(
                    this.___guid,
                    "cameras",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameras",
                    value
                );
            }
        }

        private Camera __main;
        public Camera main
        {
            get
            {
            if(__main == null)
            {
                __main = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "main",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __main;
            }
            set
            {
__main = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "main",
                    value
                );
            }
        }

        private Camera __default;
        public Camera default
        {
            get
            {
            if(__default == null)
            {
                __default = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "default",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __default;
            }
            set
            {
__default = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "default",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CameraManager() : base() { }

        public CameraManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public CameraManager(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Cameras", "Scene2D", "CameraManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Camera add(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> makeMain = null, string name = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, x, y, width, height, makeMain, name
                }
            );
        }

        public Camera addExisting(Camera camera, System.Nullable<bool> makeMain = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addExisting" }, camera, makeMain
                }
            );
        }

        public decimal getTotal(System.Nullable<bool> isVisible = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotal" }, isVisible
                }
            );
        }

        public CameraManager fromJSON(CameraConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<CameraManager>(
                entity => new CameraManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromJSON" }, config
                }
            );
        }

        public Camera getCamera(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCamera" }, name
                }
            );
        }

        public Camera[] getCamerasBelowPointer(Pointer pointer)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCamerasBelowPointer" }, pointer
                }
            );
        }

        public decimal remove(Camera camera, System.Nullable<bool> runDestroy = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, camera, runDestroy
                }
            );
        }

        public GameObject[] getVisibleChildren(GameObject[] children, Camera camera)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVisibleChildren" }, children, camera
                }
            );
        }

        public Camera resetAll()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetAll" }
                }
            );
        }

        public void onResize(Size gameSize, Size baseSize)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onResize" }, gameSize, baseSize
                }
            );
        }

        public void resize(decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }
        #endregion
    }
}