/// Generated - Do Not Edit
namespace Phaser.Input.Keyboard
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<KeyboardPlugin>))]
    public class KeyboardPlugin : EventEmitter
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
            set
            {
__game = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "game",
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

        private KeyboardManager __manager;
        public KeyboardManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<KeyboardManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new KeyboardManager() { ___guid = entity.___guid };
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

        
        public Key[] keys
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Key>(
                    this.___guid,
                    "keys",
                    (entity) =>
                    {
                        return new Key() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keys",
                    value
                );
            }
        }

        
        public KeyCombo[] combos
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<KeyCombo>(
                    this.___guid,
                    "combos",
                    (entity) =>
                    {
                        return new KeyCombo() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "combos",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public KeyboardPlugin() : base() { }

        public KeyboardPlugin(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public KeyboardPlugin(
            InputPlugin sceneInputPlugin
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "Keyboard", "KeyboardPlugin" },
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

        public KeyboardPlugin addCapture(string keycode)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addCapture" }, keycode
                }
            );
        }

        public KeyboardPlugin removeCapture(string keycode)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeCapture" }, keycode
                }
            );
        }

        public decimal[] getCaptures()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCaptures" }
                }
            );
        }

        public KeyboardPlugin enableGlobalCapture()
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableGlobalCapture" }
                }
            );
        }

        public KeyboardPlugin disableGlobalCapture()
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disableGlobalCapture" }
                }
            );
        }

        public KeyboardPlugin clearCaptures()
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearCaptures" }
                }
            );
        }

        public CursorKeys createCursorKeys()
        {
            return EventHorizonBlazorInterop.FuncClass<CursorKeys>(
                entity => new CursorKeys() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCursorKeys" }
                }
            );
        }

        public CachedEntity addKeys(object keys, System.Nullable<bool> enableCapture = null, System.Nullable<bool> emitOnRepeat = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addKeys" }, keys, enableCapture, emitOnRepeat
                }
            );
        }

        public Key addKey(Key key, System.Nullable<bool> enableCapture = null, System.Nullable<bool> emitOnRepeat = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Key>(
                entity => new Key() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addKey" }, key, enableCapture, emitOnRepeat
                }
            );
        }

        public KeyboardPlugin removeKey(Key key, System.Nullable<bool> destroy = null)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeKey" }, key, destroy
                }
            );
        }

        public KeyboardPlugin removeAllKeys(System.Nullable<bool> destroy = null)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAllKeys" }, destroy
                }
            );
        }

        public KeyCombo createCombo(string keys, KeyComboConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyCombo>(
                entity => new KeyCombo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCombo" }, keys, config
                }
            );
        }

        public bool checkDown(Key key, System.Nullable<decimal> duration = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "checkDown" }, key, duration
                }
            );
        }

        public KeyboardPlugin resetKeys()
        {
            return EventHorizonBlazorInterop.FuncClass<KeyboardPlugin>(
                entity => new KeyboardPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetKeys" }
                }
            );
        }
        #endregion
    }
}