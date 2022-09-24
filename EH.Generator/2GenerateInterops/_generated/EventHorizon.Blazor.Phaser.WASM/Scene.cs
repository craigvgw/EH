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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Scene>))]
    public class Scene : CachedEntityObject
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
        private Systems __sys;
        public Systems sys
        {
            get
            {
            if(__sys == null)
            {
                __sys = EventHorizonBlazorInterop.GetClass<Systems>(
                    this.___guid,
                    "sys",
                    (entity) =>
                    {
                        return new Systems() { ___guid = entity.___guid };
                    }
                );
            }
            return __sys;
            }
            set
            {
__sys = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sys",
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

        private ScenePlugin __scene;
        public ScenePlugin scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<ScenePlugin>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new ScenePlugin() { ___guid = entity.___guid };
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

        private DisplayList __children;
        public DisplayList children
        {
            get
            {
            if(__children == null)
            {
                __children = EventHorizonBlazorInterop.GetClass<DisplayList>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new DisplayList() { ___guid = entity.___guid };
                    }
                );
            }
            return __children;
            }
            set
            {
__children = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "children",
                    value
                );
            }
        }

        private LightsManager __lights;
        public LightsManager lights
        {
            get
            {
            if(__lights == null)
            {
                __lights = EventHorizonBlazorInterop.GetClass<LightsManager>(
                    this.___guid,
                    "lights",
                    (entity) =>
                    {
                        return new LightsManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __lights;
            }
            set
            {
__lights = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lights",
                    value
                );
            }
        }

        private DataManager __data;
        public DataManager data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<DataManager>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new DataManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        private InputPlugin __input;
        public InputPlugin input
        {
            get
            {
            if(__input == null)
            {
                __input = EventHorizonBlazorInterop.GetClass<InputPlugin>(
                    this.___guid,
                    "input",
                    (entity) =>
                    {
                        return new InputPlugin() { ___guid = entity.___guid };
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

        private LoaderPlugin __load;
        public LoaderPlugin load
        {
            get
            {
            if(__load == null)
            {
                __load = EventHorizonBlazorInterop.GetClass<LoaderPlugin>(
                    this.___guid,
                    "load",
                    (entity) =>
                    {
                        return new LoaderPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __load;
            }
            set
            {
__load = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "load",
                    value
                );
            }
        }

        private Clock __time;
        public Clock time
        {
            get
            {
            if(__time == null)
            {
                __time = EventHorizonBlazorInterop.GetClass<Clock>(
                    this.___guid,
                    "time",
                    (entity) =>
                    {
                        return new Clock() { ___guid = entity.___guid };
                    }
                );
            }
            return __time;
            }
            set
            {
__time = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "time",
                    value
                );
            }
        }

        private TweenManager __tweens;
        public TweenManager tweens
        {
            get
            {
            if(__tweens == null)
            {
                __tweens = EventHorizonBlazorInterop.GetClass<TweenManager>(
                    this.___guid,
                    "tweens",
                    (entity) =>
                    {
                        return new TweenManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __tweens;
            }
            set
            {
__tweens = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tweens",
                    value
                );
            }
        }

        private ArcadePhysics __physics;
        public ArcadePhysics physics
        {
            get
            {
            if(__physics == null)
            {
                __physics = EventHorizonBlazorInterop.GetClass<ArcadePhysics>(
                    this.___guid,
                    "physics",
                    (entity) =>
                    {
                        return new ArcadePhysics() { ___guid = entity.___guid };
                    }
                );
            }
            return __physics;
            }
            set
            {
__physics = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "physics",
                    value
                );
            }
        }

        private MatterPhysics __matter;
        public MatterPhysics matter
        {
            get
            {
            if(__matter == null)
            {
                __matter = EventHorizonBlazorInterop.GetClass<MatterPhysics>(
                    this.___guid,
                    "matter",
                    (entity) =>
                    {
                        return new MatterPhysics() { ___guid = entity.___guid };
                    }
                );
            }
            return __matter;
            }
            set
            {
__matter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matter",
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
        #endregion
        
        #region Constructor
        public Scene() : base() { }

        public Scene(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Scene(
            string config
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Scene" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void update(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, time, delta
                }
            );
        }
        #endregion
    }
}