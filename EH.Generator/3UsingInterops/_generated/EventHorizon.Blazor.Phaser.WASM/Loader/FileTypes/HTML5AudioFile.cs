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

    
    
    [JsonConverter(typeof(CachedEntityConverter<HTML5AudioFile>))]
    public class HTML5AudioFile : File
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
        public HTML5AudioFile() : base() { }

        public HTML5AudioFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public HTML5AudioFile(
            LoaderPlugin loader, string key, string urlConfig = null, XHRSettingsObject xhrSettings = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "HTML5AudioFile" },
                loader, key, urlConfig, xhrSettings
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void onLoad()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onLoad" }
                }
            );
        }

        public void onError()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onError" }
                }
            );
        }

        public void onProgress()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onProgress" }
                }
            );
        }

        public void load()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }
                }
            );
        }
        #endregion
    }
}