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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ScenePlugin>))]
    public class ScenePlugin : BasePlugin
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
        
        public string pluginKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pluginKey"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ScenePlugin() : base() { }

        public ScenePlugin(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ScenePlugin(
            Scene scene, PluginManager pluginManager, string pluginKey
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Plugins", "ScenePlugin" },
                scene, pluginManager, pluginKey
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void boot()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "boot" }
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