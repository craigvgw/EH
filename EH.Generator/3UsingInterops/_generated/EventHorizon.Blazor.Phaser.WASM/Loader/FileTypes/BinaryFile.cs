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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BinaryFile>))]
    public class BinaryFile : File
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
        public BinaryFile() : base() { }

        public BinaryFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BinaryFile(
            LoaderPlugin loader, string key, string url = null, XHRSettingsObject xhrSettings = null, object dataType = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "BinaryFile" },
                loader, key, url, xhrSettings, dataType
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