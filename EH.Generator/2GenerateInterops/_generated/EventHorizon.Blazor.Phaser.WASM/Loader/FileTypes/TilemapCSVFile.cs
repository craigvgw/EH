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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TilemapCSVFile>))]
    public class TilemapCSVFile : File
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
        public TilemapCSVFile() : base() { }

        public TilemapCSVFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TilemapCSVFile(
            LoaderPlugin loader, string key, string url = null, XHRSettingsObject xhrSettings = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "TilemapCSVFile" },
                loader, key, url, xhrSettings
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