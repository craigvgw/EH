/// Generated - Do Not Edit
namespace Phaser.Input.Gamepad
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<GamepadPlugin>))]
    public class GamepadPlugin : EventEmitter
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

        private InputPlugin __sceneInputPlugin;
        public InputPlugin sceneInputPlugin
        {
            get
            {
            if(__sceneInputPlugin == null)
            {
                __sceneInputPlugin = EventHorizonBlazorInterop.GetClass<InputPlugin>(
                    this.___guid,
                    "sceneInputPlugin",
                    (entity) =>
                    {
                        return new InputPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __sceneInputPlugin;
            }
            set
            {
__sceneInputPlugin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sceneInputPlugin",
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

        
        public CachedEntity target
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        
        public Gamepad[] gamepads
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Gamepad>(
                    this.___guid,
                    "gamepads",
                    (entity) =>
                    {
                        return new Gamepad() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gamepads",
                    value
                );
            }
        }

        
        public decimal total
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "total",
                    value
                );
            }
        }

        private Gamepad __pad1;
        public Gamepad pad1
        {
            get
            {
            if(__pad1 == null)
            {
                __pad1 = EventHorizonBlazorInterop.GetClass<Gamepad>(
                    this.___guid,
                    "pad1",
                    (entity) =>
                    {
                        return new Gamepad() { ___guid = entity.___guid };
                    }
                );
            }
            return __pad1;
            }
            set
            {
__pad1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pad1",
                    value
                );
            }
        }

        private Gamepad __pad2;
        public Gamepad pad2
        {
            get
            {
            if(__pad2 == null)
            {
                __pad2 = EventHorizonBlazorInterop.GetClass<Gamepad>(
                    this.___guid,
                    "pad2",
                    (entity) =>
                    {
                        return new Gamepad() { ___guid = entity.___guid };
                    }
                );
            }
            return __pad2;
            }
            set
            {
__pad2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pad2",
                    value
                );
            }
        }

        private Gamepad __pad3;
        public Gamepad pad3
        {
            get
            {
            if(__pad3 == null)
            {
                __pad3 = EventHorizonBlazorInterop.GetClass<Gamepad>(
                    this.___guid,
                    "pad3",
                    (entity) =>
                    {
                        return new Gamepad() { ___guid = entity.___guid };
                    }
                );
            }
            return __pad3;
            }
            set
            {
__pad3 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pad3",
                    value
                );
            }
        }

        private Gamepad __pad4;
        public Gamepad pad4
        {
            get
            {
            if(__pad4 == null)
            {
                __pad4 = EventHorizonBlazorInterop.GetClass<Gamepad>(
                    this.___guid,
                    "pad4",
                    (entity) =>
                    {
                        return new Gamepad() { ___guid = entity.___guid };
                    }
                );
            }
            return __pad4;
            }
            set
            {
__pad4 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pad4",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public GamepadPlugin() : base() { }

        public GamepadPlugin(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public GamepadPlugin(
            InputPlugin sceneInputPlugin
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "Gamepad", "GamepadPlugin" },
                sceneInputPlugin
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

        public void disconnectAll()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disconnectAll" }
                }
            );
        }

        public Gamepad[] getAll()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Gamepad>(
                entity => new Gamepad() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAll" }
                }
            );
        }

        public Gamepad getPad(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Gamepad>(
                entity => new Gamepad() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPad" }, index
                }
            );
        }
        #endregion
    }
}