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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SceneManager>))]
    public class SceneManager : CachedEntityObject
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

// keys is not supported by the platform yet

        
        public Scene[] scenes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Scene>(
                    this.___guid,
                    "scenes",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scenes",
                    value
                );
            }
        }

        
        public bool isProcessing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isProcessing"
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

        
        public decimal customViewports
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "customViewports"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customViewports",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SceneManager() : base() { }

        public SceneManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SceneManager(
            Game game, object sceneConfig
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Scenes", "SceneManager" },
                game, sceneConfig
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void processQueue()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "processQueue" }
                }
            );
        }

        public Scene add(string key, Scene sceneConfig, System.Nullable<bool> autoStart = null, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, key, sceneConfig, autoStart, data
                }
            );
        }

        public SceneManager remove(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, key
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

        public void render(CanvasRenderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, renderer
                }
            );
        }

        public Scene[] getScenes(System.Nullable<bool> isActive = null, System.Nullable<bool> inReverse = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScenes" }, isActive, inReverse
                }
            );
        }

        public Scene getScene(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScene" }, key
                }
            );
        }

        public bool isActive(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isActive" }, key
                }
            );
        }

        public bool isPaused(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPaused" }, key
                }
            );
        }

        public bool isVisible(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isVisible" }, key
                }
            );
        }

        public bool isSleeping(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isSleeping" }, key
                }
            );
        }

        public SceneManager pause(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }, key, data
                }
            );
        }

        public SceneManager resume(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }, key, data
                }
            );
        }

        public SceneManager sleep(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sleep" }, key, data
                }
            );
        }

        public SceneManager wake(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "wake" }, key, data
                }
            );
        }

        public SceneManager run(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "run" }, key, data
                }
            );
        }

        public SceneManager start(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" }, key, data
                }
            );
        }

        public SceneManager stop(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }, key, data
                }
            );
        }

        public SceneManager switch(string from, string to)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "switch" }, from, to
                }
            );
        }

        public Scene getAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAt" }, index
                }
            );
        }

        public decimal getIndex(string key)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }, key
                }
            );
        }

        public SceneManager bringToTop(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bringToTop" }, key
                }
            );
        }

        public SceneManager sendToBack(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sendToBack" }, key
                }
            );
        }

        public SceneManager moveDown(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveDown" }, key
                }
            );
        }

        public SceneManager moveUp(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveUp" }, key
                }
            );
        }

        public SceneManager moveAbove(string keyA, string keyB)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveAbove" }, keyA, keyB
                }
            );
        }

        public SceneManager moveBelow(string keyA, string keyB)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveBelow" }, keyA, keyB
                }
            );
        }

        public SceneManager swapPosition(string keyA, string keyB)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneManager>(
                entity => new SceneManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "swapPosition" }, keyA, keyB
                }
            );
        }

        public void dump()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dump" }
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