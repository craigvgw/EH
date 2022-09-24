/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CompressedTextureLoader>))]
public class CompressedTextureLoader : Loader
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
        public CompressedTextureLoader() : base() { }

        public CompressedTextureLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CompressedTextureLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CompressedTextureLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CompressedTexture load(string url, ActionCallback<CompressedTexture> onLoad, ActionCallback<ProgressEvent> onProgress = null, ActionCallback<ErrorEvent> onError = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CompressedTexture>(
                entity => new CompressedTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<CompressedTexture> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskClass<CompressedTexture>(
                entity => new CompressedTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }
    #endregion
}
