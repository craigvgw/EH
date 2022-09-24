/// Generated - Do Not Edit
namespace Phaser
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Game>))]
    public class Game : CachedEntityObject
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
        }

        private CanvasRenderer __renderer;
        public CanvasRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<CanvasRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new CanvasRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderer;
            }
            set
            {
__renderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderer",
                    value
                );
            }
        }

        private HTMLDivElement __domContainer;
        public HTMLDivElement domContainer
        {
            get
            {
            if(__domContainer == null)
            {
                __domContainer = EventHorizonBlazorInterop.GetClass<HTMLDivElement>(
                    this.___guid,
                    "domContainer",
                    (entity) =>
                    {
                        return new HTMLDivElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __domContainer;
            }
            set
            {
__domContainer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "domContainer",
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

        private CanvasRenderingContext2D __context;
        public CanvasRenderingContext2D context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<CanvasRenderingContext2D>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new CanvasRenderingContext2D() { ___guid = entity.___guid };
                    }
                );
            }
            return __context;
            }
            set
            {
__context = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "context",
                    value
                );
            }
        }

        
        public bool isBooted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBooted"
                );
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

        private AnimationManager __anims;
        public AnimationManager anims
        {
            get
            {
            if(__anims == null)
            {
                __anims = EventHorizonBlazorInterop.GetClass<AnimationManager>(
                    this.___guid,
                    "anims",
                    (entity) =>
                    {
                        return new AnimationManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __anims;
            }
            set
            {
__anims = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anims",
                    value
                );
            }
        }

        private TextureManager __textures;
        public TextureManager textures
        {
            get
            {
            if(__textures == null)
            {
                __textures = EventHorizonBlazorInterop.GetClass<TextureManager>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new TextureManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __textures;
            }
            set
            {
__textures = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textures",
                    value
                );
            }
        }

        private CacheManager __cache;
        public CacheManager cache
        {
            get
            {
            if(__cache == null)
            {
                __cache = EventHorizonBlazorInterop.GetClass<CacheManager>(
                    this.___guid,
                    "cache",
                    (entity) =>
                    {
                        return new CacheManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __cache;
            }
            set
            {
__cache = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cache",
                    value
                );
            }
        }

        private DataManager __registry;
        public DataManager registry
        {
            get
            {
            if(__registry == null)
            {
                __registry = EventHorizonBlazorInterop.GetClass<DataManager>(
                    this.___guid,
                    "registry",
                    (entity) =>
                    {
                        return new DataManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __registry;
            }
            set
            {
__registry = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "registry",
                    value
                );
            }
        }

        private InputManager __input;
        public InputManager input
        {
            get
            {
            if(__input == null)
            {
                __input = EventHorizonBlazorInterop.GetClass<InputManager>(
                    this.___guid,
                    "input",
                    (entity) =>
                    {
                        return new InputManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __input;
            }
            set
            {
__input = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "input",
                    value
                );
            }
        }

        private SceneManager __scene;
        public SceneManager scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<SceneManager>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new SceneManager() { ___guid = entity.___guid };
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

        private DeviceConf __device;
        public DeviceConf device
        {
            get
            {
            if(__device == null)
            {
                __device = EventHorizonBlazorInterop.GetClass<DeviceConf>(
                    this.___guid,
                    "device",
                    (entity) =>
                    {
                        return new DeviceConf() { ___guid = entity.___guid };
                    }
                );
            }
            return __device;
            }
            set
            {
__device = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "device",
                    value
                );
            }
        }

        private ScaleManager __scale;
        public ScaleManager scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInterop.GetClass<ScaleManager>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new ScaleManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __scale;
            }
            set
            {
__scale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        private NoAudioSoundManager __sound;
        public NoAudioSoundManager sound
        {
            get
            {
            if(__sound == null)
            {
                __sound = EventHorizonBlazorInterop.GetClass<NoAudioSoundManager>(
                    this.___guid,
                    "sound",
                    (entity) =>
                    {
                        return new NoAudioSoundManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __sound;
            }
            set
            {
__sound = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sound",
                    value
                );
            }
        }

        private TimeStep __loop;
        public TimeStep loop
        {
            get
            {
            if(__loop == null)
            {
                __loop = EventHorizonBlazorInterop.GetClass<TimeStep>(
                    this.___guid,
                    "loop",
                    (entity) =>
                    {
                        return new TimeStep() { ___guid = entity.___guid };
                    }
                );
            }
            return __loop;
            }
            set
            {
__loop = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loop",
                    value
                );
            }
        }

        private PluginManager __plugins;
        public PluginManager plugins
        {
            get
            {
            if(__plugins == null)
            {
                __plugins = EventHorizonBlazorInterop.GetClass<PluginManager>(
                    this.___guid,
                    "plugins",
                    (entity) =>
                    {
                        return new PluginManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugins;
            }
            set
            {
__plugins = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugins",
                    value
                );
            }
        }

        private FacebookInstantGamesPlugin __facebook;
        public FacebookInstantGamesPlugin facebook
        {
            get
            {
            if(__facebook == null)
            {
                __facebook = EventHorizonBlazorInterop.GetClass<FacebookInstantGamesPlugin>(
                    this.___guid,
                    "facebook",
                    (entity) =>
                    {
                        return new FacebookInstantGamesPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __facebook;
            }
            set
            {
__facebook = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "facebook",
                    value
                );
            }
        }

        
        public bool hasFocus
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasFocus"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Game() : base() { }

        public Game(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Game(
            GameConfig GameConfig = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Game" },
                GameConfig
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void step(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "step" }, time, delta
                }
            );
        }

        public void headlessStep(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "headlessStep" }, time, delta
                }
            );
        }

        public decimal getFrame()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFrame" }
                }
            );
        }

        public decimal getTime()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTime" }
                }
            );
        }

        public void destroy(bool removeCanvas, System.Nullable<bool> noReturn = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, removeCanvas, noReturn
                }
            );
        }
        #endregion
    }
}