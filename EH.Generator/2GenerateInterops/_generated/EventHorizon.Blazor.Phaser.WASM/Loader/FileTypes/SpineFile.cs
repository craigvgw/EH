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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SpineFile>))]
    public class SpineFile : MultiFile
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
        public SpineFile() : base() { }

        public SpineFile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpineFile(
            LoaderPlugin loader, string key, string jsonURL, string atlasURL, bool preMultipliedAlpha, XHRSettingsObject jsonXhrSettings, XHRSettingsObject atlasXhrSettings
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "FileTypes", "SpineFile" },
                loader, key, jsonURL, atlasURL, preMultipliedAlpha, jsonXhrSettings, atlasXhrSettings
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