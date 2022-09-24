/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CubeTextureLoader>))]
public class CubeTextureLoader : Loader
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
        public CubeTextureLoader() : base() { }

        public CubeTextureLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CubeTextureLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CubeTextureLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CubeTexture load(string[] urls, ActionCallback<CubeTexture> onLoad = null, ActionCallback<ProgressEvent> onProgress = null, ActionCallback<ErrorEvent> onError = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CubeTexture>(
                entity => new CubeTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }, urls, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<CubeTexture> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskClass<CubeTexture>(
                entity => new CubeTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }
    #endregion
}
