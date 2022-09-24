/// Generated - Do Not Edit
namespace Phaser.Input
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<InputPlugin>))]
    public class InputPlugin : EventEmitter
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
        private GamepadPlugin __gamepad;
        public GamepadPlugin gamepad
        {
            get
            {
            if(__gamepad == null)
            {
                __gamepad = EventHorizonBlazorInterop.GetClass<GamepadPlugin>(
                    this.___guid,
                    "gamepad",
                    (entity) =>
                    {
                        return new GamepadPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __gamepad;
            }
            set
            {
__gamepad = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gamepad",
                    value
                );
            }
        }

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

        private SettingsObject __settings;
        public SettingsObject settings
        {
            get
            {
            if(__settings == null)
            {
                __settings = EventHorizonBlazorInterop.GetClass<SettingsObject>(
                    this.___guid,
                    "settings",
                    (entity) =>
                    {
                        return new SettingsObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __settings;
            }
            set
            {
__settings = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "settings",
                    value
                );
            }
        }

        private InputManager __manager;
        public InputManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<InputManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new InputManager() { ___guid = entity.___guid };
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

        private DisplayList __displayList;
        public DisplayList displayList
        {
            get
            {
            if(__displayList == null)
            {
                __displayList = EventHorizonBlazorInterop.GetClass<DisplayList>(
                    this.___guid,
                    "displayList",
                    (entity) =>
                    {
                        return new DisplayList() { ___guid = entity.___guid };
                    }
                );
            }
            return __displayList;
            }
            set
            {
__displayList = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayList",
                    value
                );
            }
        }

        private CameraManager __cameras;
        public CameraManager cameras
        {
            get
            {
            if(__cameras == null)
            {
                __cameras = EventHorizonBlazorInterop.GetClass<CameraManager>(
                    this.___guid,
                    "cameras",
                    (entity) =>
                    {
                        return new CameraManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameras;
            }
            set
            {
__cameras = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameras",
                    value
                );
            }
        }

        private MouseManager __mouse;
        public MouseManager mouse
        {
            get
            {
            if(__mouse == null)
            {
                __mouse = EventHorizonBlazorInterop.GetClass<MouseManager>(
                    this.___guid,
                    "mouse",
                    (entity) =>
                    {
                        return new MouseManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __mouse;
            }
            set
            {
__mouse = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mouse",
                    value
                );
            }
        }

        
        public bool topOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "topOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "topOnly",
                    value
                );
            }
        }

        
        public decimal pollRate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pollRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pollRate",
                    value
                );
            }
        }

        
        public decimal dragDistanceThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dragDistanceThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dragDistanceThreshold",
                    value
                );
            }
        }

        
        public decimal dragTimeThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dragTimeThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dragTimeThreshold",
                    value
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
        }

        
        public bool isOver
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isOver"
                );
            }
        }

        private Pointer __mousePointer;
        public Pointer mousePointer
        {
            get
            {
            if(__mousePointer == null)
            {
                __mousePointer = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "mousePointer",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __mousePointer;
            }
        }

        private Pointer __activePointer;
        public Pointer activePointer
        {
            get
            {
            if(__activePointer == null)
            {
                __activePointer = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "activePointer",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __activePointer;
            }
        }

        private Pointer __pointer1;
        public Pointer pointer1
        {
            get
            {
            if(__pointer1 == null)
            {
                __pointer1 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer1",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer1;
            }
        }

        private Pointer __pointer2;
        public Pointer pointer2
        {
            get
            {
            if(__pointer2 == null)
            {
                __pointer2 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer2",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer2;
            }
        }

        private Pointer __pointer3;
        public Pointer pointer3
        {
            get
            {
            if(__pointer3 == null)
            {
                __pointer3 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer3",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer3;
            }
        }

        private Pointer __pointer4;
        public Pointer pointer4
        {
            get
            {
            if(__pointer4 == null)
            {
                __pointer4 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer4",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer4;
            }
        }

        private Pointer __pointer5;
        public Pointer pointer5
        {
            get
            {
            if(__pointer5 == null)
            {
                __pointer5 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer5",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer5;
            }
        }

        private Pointer __pointer6;
        public Pointer pointer6
        {
            get
            {
            if(__pointer6 == null)
            {
                __pointer6 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer6",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer6;
            }
        }

        private Pointer __pointer7;
        public Pointer pointer7
        {
            get
            {
            if(__pointer7 == null)
            {
                __pointer7 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer7",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer7;
            }
        }

        private Pointer __pointer8;
        public Pointer pointer8
        {
            get
            {
            if(__pointer8 == null)
            {
                __pointer8 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer8",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer8;
            }
        }

        private Pointer __pointer9;
        public Pointer pointer9
        {
            get
            {
            if(__pointer9 == null)
            {
                __pointer9 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer9",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer9;
            }
        }

        private Pointer __pointer10;
        public Pointer pointer10
        {
            get
            {
            if(__pointer10 == null)
            {
                __pointer10 = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer10",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer10;
            }
        }

        private KeyboardPlugin __keyboard;
        public KeyboardPlugin keyboard
        {
            get
            {
            if(__keyboard == null)
            {
                __keyboard = EventHorizonBlazorInterop.GetClass<KeyboardPlugin>(
                    this.___guid,
                    "keyboard",
                    (entity) =>
                    {
                        return new KeyboardPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __keyboard;
            }
            set
            {
__keyboard = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keyboard",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public InputPlugin() : base() { }

        public InputPlugin(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public InputPlugin(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "InputPlugin" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isActive()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isActive" }
                }
            );
        }

        public bool updatePoll(decimal time, decimal delta)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "updatePoll" }, time, delta
                }
            );
        }

        public GameObject clear(GameObject gameObject, System.Nullable<bool> skipQueue = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }, gameObject, skipQueue
                }
            );
        }

        public void disable(GameObject gameObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disable" }, gameObject
                }
            );
        }

        public InputPlugin enable(GameObject gameObject, InputConfiguration hitArea = null, HitAreaCallback hitAreaCallback = null, System.Nullable<bool> dropZone = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enable" }, gameObject, hitArea, hitAreaCallback, dropZone
                }
            );
        }

        public GameObject[] hitTestPointer(Pointer pointer)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "hitTestPointer" }, pointer
                }
            );
        }

        public decimal getDragState(Pointer pointer)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDragState" }, pointer
                }
            );
        }

        public void setDragState(Pointer pointer, decimal state)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDragState" }, pointer, state
                }
            );
        }

        public InputPlugin setDraggable(GameObject gameObjects, System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDraggable" }, gameObjects, value
                }
            );
        }

        public void makePixelPerfect(System.Nullable<decimal> alphaTolerance = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "makePixelPerfect" }, alphaTolerance
                }
            );
        }

        public InputPlugin setHitArea(GameObject gameObjects, InputConfiguration hitArea = null, HitAreaCallback hitAreaCallback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHitArea" }, gameObjects, hitArea, hitAreaCallback
                }
            );
        }

        public InputPlugin setHitAreaCircle(GameObject gameObjects, decimal x, decimal y, decimal radius, HitAreaCallback callback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHitAreaCircle" }, gameObjects, x, y, radius, callback
                }
            );
        }

        public InputPlugin setHitAreaEllipse(GameObject gameObjects, decimal x, decimal y, decimal width, decimal height, HitAreaCallback callback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHitAreaEllipse" }, gameObjects, x, y, width, height, callback
                }
            );
        }

        public InputPlugin setHitAreaFromTexture(GameObject gameObjects, HitAreaCallback callback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHitAreaFromTexture" }, gameObjects, callback
                }
            );
        }

        public InputPlugin setHitAreaRectangle(GameObject gameObjects, decimal x, decimal y, decimal width, decimal height, HitAreaCallback callback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHitAreaRectangle" }, gameObjects, x, y, width, height, callback
                }
            );
        }

        public InputPlugin setHitAreaTriangle(GameObject gameObjects, decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3, HitAreaCallback callback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHitAreaTriangle" }, gameObjects, x1, y1, x2, y2, x3, y3, callback
                }
            );
        }

        public InputPlugin enableDebug(GameObject gameObject, System.Nullable<decimal> color = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableDebug" }, gameObject, color
                }
            );
        }

        public InputPlugin removeDebug(GameObject gameObject)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeDebug" }, gameObject
                }
            );
        }

        public InputPlugin setPollAlways()
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPollAlways" }
                }
            );
        }

        public InputPlugin setPollOnMove()
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPollOnMove" }
                }
            );
        }

        public InputPlugin setPollRate(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPollRate" }, value
                }
            );
        }

        public InputPlugin setGlobalTopOnly(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGlobalTopOnly" }, value
                }
            );
        }

        public InputPlugin setTopOnly(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTopOnly" }, value
                }
            );
        }

        public GameObject[] sortGameObjects(GameObject[] gameObjects, Pointer pointer)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sortGameObjects" }, gameObjects, pointer
                }
            );
        }

        public GameObject[] sortDropZones(GameObject[] gameObjects)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sortDropZones" }, gameObjects
                }
            );
        }

        public InputPlugin stopPropagation()
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopPropagation" }
                }
            );
        }

        public Pointer[] addPointer(System.Nullable<decimal> quantity = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Pointer>(
                entity => new Pointer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addPointer" }, quantity
                }
            );
        }

        public InputPlugin setDefaultCursor(string cursor)
        {
            return EventHorizonBlazorInterop.FuncClass<InputPlugin>(
                entity => new InputPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDefaultCursor" }, cursor
                }
            );
        }
        #endregion
    }
}