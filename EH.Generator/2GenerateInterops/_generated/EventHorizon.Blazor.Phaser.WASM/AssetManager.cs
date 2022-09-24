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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AssetManager>))]
    public class AssetManager : CachedEntityObject, Disposable
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
        public AssetManager() : base() { }

        public AssetManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AssetManager(
            ActionResultCallback<HTMLImageElement, CachedEntity> textureLoader, string pathPrefix = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "AssetManager" },
                textureLoader, pathPrefix
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void loadBinary(string path, ActionCallback<string, decimal[]> success = null, ActionCallback<string, string> error = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadBinary" }, path, success, error
                }
            );
        }

        public void loadText(string path, ActionCallback<string, string> success = null, ActionCallback<string, string> error = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadText" }, path, success, error
                }
            );
        }

        public void loadTexture(string path, ActionCallback<string, HTMLImageElement> success = null, ActionCallback<string, string> error = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadTexture" }, path, success, error
                }
            );
        }

        public void loadTextureData(string path, string data, ActionCallback<string, HTMLImageElement> success = null, ActionCallback<string, string> error = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadTextureData" }, path, data, success, error
                }
            );
        }

        public void loadTextureAtlas(string path, ActionCallback<string, TextureAtlas> success = null, ActionCallback<string, string> error = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadTextureAtlas" }, path, success, error
                }
            );
        }

        public CachedEntity get(string path)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, path
                }
            );
        }

        public void remove(string path)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, path
                }
            );
        }

        public void removeAll()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeAll" }
                }
            );
        }

        public bool isLoadingComplete()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isLoadingComplete" }
                }
            );
        }

        public decimal getToLoad()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getToLoad" }
                }
            );
        }

        public decimal getLoaded()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLoaded" }
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