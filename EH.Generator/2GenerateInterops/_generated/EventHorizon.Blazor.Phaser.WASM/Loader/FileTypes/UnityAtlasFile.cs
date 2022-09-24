/// Generated - Do Not Edit
namespace Phaser.Loader.FileTypes
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<UnityAtlasFile>))]
    public class UnityAtlasFile : MultiFile
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

        #endregion
        
        #region Constructor
        public UnityAtlasFile() : base() { }

        public UnityAtlasFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public UnityAtlasFile(
            LoaderPlugin loader, string key, string textureURL = null, string atlasURL = null, XHRSettingsObject textureXhrSettings = null, XHRSettingsObject atlasXhrSettings = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "UnityAtlasFile" },
                loader, key, textureURL, atlasURL, textureXhrSettings, atlasXhrSettings
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void addToCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addToCache" }
                }
            );
        }
        #endregion
    }
}