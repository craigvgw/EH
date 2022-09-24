/// Generated - Do Not Edit
namespace Phaser.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Systems>))]
    public class Systems : CachedEntityObject
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

        
        public string config
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "config"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "config",
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

        private GameObjectFactory __add;
        public GameObjectFactory add
        {
            get
            {
            if(__add == null)
            {
                __add = EventHorizonBlazorInterop.GetClass<GameObjectFactory>(
                    this.___guid,
                    "add",
                    (entity) =>
                    {
                        return new GameObjectFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __add;
            }
            set
            {
__add = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "add",
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

        private GameObjectCreator __make;
        public GameObjectCreator make
        {
            get
            {
            if(__make == null)
            {
                __make = EventHorizonBlazorInterop.GetClass<GameObjectCreator>(
                    this.___guid,
                    "make",
                    (entity) =>
                    {
                        return new GameObjectCreator() { ___guid = entity.___guid };
                    }
                );
            }
            return __make;
            }
            set
            {
__make = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "make",
                    value
                );
            }
        }

        private ScenePlugin __scenePlugin;
        public ScenePlugin scenePlugin
        {
            get
            {
            if(__scenePlugin == null)
            {
                __scenePlugin = EventHorizonBlazorInterop.GetClass<ScenePlugin>(
                    this.___guid,
                    "scenePlugin",
                    (entity) =>
                    {
                        return new ScenePlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __scenePlugin;
            }
            set
            {
__scenePlugin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scenePlugin",
                    value
                );
            }
        }

        private UpdateList __updateList;
        public UpdateList updateList
        {
            get
            {
            if(__updateList == null)
            {
                __updateList = EventHorizonBlazorInterop.GetClass<UpdateList>(
                    this.___guid,
                    "updateList",
                    (entity) =>
                    {
                        return new UpdateList() { ___guid = entity.___guid };
                    }
                );
            }
            return __updateList;
            }
            set
            {
__updateList = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateList",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Systems() : base() { }

        public Systems(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Systems(
            Scene scene, string config
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Scenes", "Systems" },
                scene, config
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

        public void render(CanvasRenderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, renderer
                }
            );
        }

        public void queueDepthSort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "queueDepthSort" }
                }
            );
        }

        public void depthSort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "depthSort" }
                }
            );
        }

        public Systems pause(object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Systems>(
                entity => new Systems() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }, data
                }
            );
        }

        public Systems resume(object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Systems>(
                entity => new Systems() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }, data
                }
            );
        }

        public Systems sleep(object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Systems>(
                entity => new Systems() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sleep" }, data
                }
            );
        }

        public Systems wake(object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Systems>(
                entity => new Systems() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "wake" }, data
                }
            );
        }

        public CachedEntity getData()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getData" }
                }
            );
        }

        public bool isSleeping()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isSleeping" }
                }
            );
        }

        public bool isActive()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isActive" }
                }
            );
        }

        public bool isPaused()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPaused" }
                }
            );
        }

        public bool isTransitioning()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isTransitioning" }
                }
            );
        }

        public bool isTransitionOut()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isTransitionOut" }
                }
            );
        }

        public bool isTransitionIn()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isTransitionIn" }
                }
            );
        }

        public bool isVisible()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isVisible" }
                }
            );
        }

        public Systems setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Systems>(
                entity => new Systems() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }

        public Systems setActive(bool value, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Systems>(
                entity => new Systems() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setActive" }, value, data
                }
            );
        }

        public void start(object data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }, data
                }
            );
        }

        public void shutdown(object data = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shutdown" }, data
                }
            );
        }
        #endregion
    }
}