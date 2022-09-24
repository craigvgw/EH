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

    
    
    [JsonConverter(typeof(CachedEntityConverter<InputManager>))]
    public class InputManager : CachedEntityObject
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
        private Game __game;
        public Game game
        {
            get
            {
            if(__game == null)
            {
                __game = EventHorizonBlazorInterop.GetClass<Game>(
                    this.___guid,
                    "game",
                    (entity) =>
                    {
                        return new Game() { ___guid = entity.___guid };
                    }
                );
            }
            return __game;
            }
        }

        private ScaleManager __scaleManager;
        public ScaleManager scaleManager
        {
            get
            {
            if(__scaleManager == null)
            {
                __scaleManager = EventHorizonBlazorInterop.GetClass<ScaleManager>(
                    this.___guid,
                    "scaleManager",
                    (entity) =>
                    {
                        return new ScaleManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __scaleManager;
            }
            set
            {
__scaleManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleManager",
                    value
                );
            }
        }

        private HTMLCanvasElement __canvas;
        public HTMLCanvasElement canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
            set
            {
__canvas = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvas",
                    value
                );
            }
        }

        private Config __config;
        public Config config
        {
            get
            {
            if(__config == null)
            {
                __config = EventHorizonBlazorInterop.GetClass<Config>(
                    this.___guid,
                    "config",
                    (entity) =>
                    {
                        return new Config() { ___guid = entity.___guid };
                    }
                );
            }
            return __config;
            }
            set
            {
__config = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "config",
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

        private EventEmitter __events;
        public EventEmitter events
        {
            get
            {
            if(__events == null)
            {
                __events = EventHorizonBlazorInterop.GetClass<EventEmitter>(
                    this.___guid,
                    "events",
                    (entity) =>
                    {
                        return new EventEmitter() { ___guid = entity.___guid };
                    }
                );
            }
            return __events;
            }
            set
            {
__events = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "events",
                    value
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

        
        public string defaultCursor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultCursor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultCursor",
                    value
                );
            }
        }

        private KeyboardManager __keyboard;
        public KeyboardManager keyboard
        {
            get
            {
            if(__keyboard == null)
            {
                __keyboard = EventHorizonBlazorInterop.GetClass<KeyboardManager>(
                    this.___guid,
                    "keyboard",
                    (entity) =>
                    {
                        return new KeyboardManager() { ___guid = entity.___guid };
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

        private TouchManager __touch;
        public TouchManager touch
        {
            get
            {
            if(__touch == null)
            {
                __touch = EventHorizonBlazorInterop.GetClass<TouchManager>(
                    this.___guid,
                    "touch",
                    (entity) =>
                    {
                        return new TouchManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __touch;
            }
            set
            {
__touch = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "touch",
                    value
                );
            }
        }

        
        public Pointer[] pointers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Pointer>(
                    this.___guid,
                    "pointers",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointers",
                    value
                );
            }
        }

        
        public decimal pointersTotal
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointersTotal"
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
            set
            {
__mousePointer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mousePointer",
                    value
                );
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
            set
            {
__activePointer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activePointer",
                    value
                );
            }
        }

        
        public bool globalTopOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "globalTopOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalTopOnly",
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
        }
        #endregion
        
        #region Constructor
        public InputManager() : base() { }

        public InputManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public InputManager(
            Game game, object config
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "InputManager" },
                game, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setDefaultCursor(string cursor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDefaultCursor" }, cursor
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

        public void updateInputPlugins(decimal type, Pointer[] pointers)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateInputPlugins" }, type, pointers
                }
            );
        }

        public CachedEntity[] hitTest(Pointer pointer, CachedEntity[] gameObjects, Camera camera, CachedEntity[] output = null)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "hitTest" }, pointer, gameObjects, camera, output
                }
            );
        }

        public bool pointWithinHitArea(GameObject gameObject, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "pointWithinHitArea" }, gameObject, x, y
                }
            );
        }

        public bool pointWithinInteractiveObject(InteractiveObject @object, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "pointWithinInteractiveObject" }, @object, x, y
                }
            );
        }

        public void transformPointer(Pointer pointer, decimal pageX, decimal pageY, bool wasMove)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "transformPointer" }, pointer, pageX, pageY, wasMove
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