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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AudioFile>))]
    public class AudioFile : File
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
        public AudioFile() : base() { }

        public AudioFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AudioFile(
            LoaderPlugin loader, string key, object urlConfig = null, XHRSettingsObject xhrSettings = null, AudioContext audioContext = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "AudioFile" },
                loader, key, urlConfig, xhrSettings, audioContext
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void onProcess()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onProcess" }
                }
            );
        }
        #endregion
    }
}