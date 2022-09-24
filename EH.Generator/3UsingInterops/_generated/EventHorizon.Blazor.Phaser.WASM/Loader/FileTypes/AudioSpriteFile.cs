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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AudioSpriteFile>))]
    public class AudioSpriteFile : MultiFile
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
        public AudioSpriteFile() : base() { }

        public AudioSpriteFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AudioSpriteFile(
            LoaderPlugin loader, string key, string jsonURL, Object audioURL = null, object audioConfig = null, XHRSettingsObject audioXhrSettings = null, XHRSettingsObject jsonXhrSettings = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "AudioSpriteFile" },
                loader, key, jsonURL, audioURL, audioConfig, audioXhrSettings, jsonXhrSettings
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