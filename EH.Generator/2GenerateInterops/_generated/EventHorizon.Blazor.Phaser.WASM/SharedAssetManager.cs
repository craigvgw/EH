/// Generated - Do Not Edit
namespace spine
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<SharedAssetManager>))]
    public class SharedAssetManager : CachedEntityObject, Disposable
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
        public SharedAssetManager() : base() { }

        public SharedAssetManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SharedAssetManager(
            string pathPrefix = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "SharedAssetManager" },
                pathPrefix
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void loadText(string clientId, string path)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadText" }, clientId, path
                }
            );
        }

        public void loadJson(string clientId, string path)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadJson" }, clientId, path
                }
            );
        }

        public void loadTexture(string clientId, ActionResultCallback<HTMLImageElement, CachedEntity> textureLoader, string path)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadTexture" }, clientId, textureLoader, path
                }
            );
        }

        public CachedEntity get(string clientId, string path)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, clientId, path
                }
            );
        }

        public bool isLoadingComplete(string clientId)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isLoadingComplete" }, clientId
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public bool hasErrors()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasErrors" }
                }
            );
        }

// getErrors is not supported by the platform yet
        #endregion
    }
}