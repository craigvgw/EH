/// Generated - Do Not Edit
namespace Phaser.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<PluginManager>))]
    public class PluginManager : CachedEntityObject
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

        
        public GlobalPlugin[] plugins
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<GlobalPlugin>(
                    this.___guid,
                    "plugins",
                    (entity) =>
                    {
                        return new GlobalPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugins",
                    value
                );
            }
        }

        
        public string[] scenePlugins
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "scenePlugins"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scenePlugins",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PluginManager() : base() { }

        public PluginManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PluginManager(
            Game game
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Plugins", "PluginManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isActive(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isActive" }, key
                }
            );
        }

        public BasePlugin start(string key, string runAs = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BasePlugin>(
                entity => new BasePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" }, key, runAs
                }
            );
        }

        public PluginManager stop(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<PluginManager>(
                entity => new PluginManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }, key
                }
            );
        }

        public BasePlugin get(string key, System.Nullable<bool> autoStart = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BasePlugin>(
                entity => new BasePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, key, autoStart
                }
            );
        }

        public BasePlugin getClass(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<BasePlugin>(
                entity => new BasePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getClass" }, key
                }
            );
        }

        public void removeGlobalPlugin(string key)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeGlobalPlugin" }, key
                }
            );
        }

        public void removeScenePlugin(string key)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeScenePlugin" }, key
                }
            );
        }

        public void removeGameObject(string key, System.Nullable<bool> removeFromFactory = null, System.Nullable<bool> removeFromCreator = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeGameObject" }, key, removeFromFactory, removeFromCreator
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