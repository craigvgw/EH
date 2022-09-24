/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ImageBitmapLoader>))]
public class ImageBitmapLoader : Loader
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
        
        public CachedEntity options
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "options"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "options",
                    value
                );
            }
        }

        
        public unknown isImageBitmapLoader
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isImageBitmapLoader"
                );
            }
        }
    #endregion
    
    #region Constructor
        public ImageBitmapLoader() : base() { }

        public ImageBitmapLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ImageBitmapLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ImageBitmapLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ImageBitmapLoader setOptions(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageBitmapLoader>(
                entity => new ImageBitmapLoader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOptions" }, options
                }
            );
        }

        public CachedEntity load(string url, ActionCallback<ImageBitmap> onLoad = null, ActionCallback<ProgressEvent> onProgress = null, ActionCallback<ErrorEvent> onError = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<ImageBitmap> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskClass<ImageBitmap>(
                entity => new ImageBitmap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }
    #endregion
}
