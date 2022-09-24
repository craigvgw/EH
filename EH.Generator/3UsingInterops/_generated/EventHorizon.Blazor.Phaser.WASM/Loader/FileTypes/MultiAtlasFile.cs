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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MultiAtlasFile>))]
    public class MultiAtlasFile : MultiFile
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
        public MultiAtlasFile() : base() { }

        public MultiAtlasFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MultiAtlasFile(
            LoaderPlugin loader, string key, string atlasURL = null, string path = null, string baseURL = null, XHRSettingsObject atlasXhrSettings = null, XHRSettingsObject textureXhrSettings = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "MultiAtlasFile" },
                loader, key, atlasURL, path, baseURL, atlasXhrSettings, textureXhrSettings
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void onFileComplete(File file)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onFileComplete" }, file
                }
            );
        }

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