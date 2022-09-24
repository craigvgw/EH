/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AudioLoader>))]
public class AudioLoader : Loader
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
        public AudioLoader() : base() { }

        public AudioLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AudioLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AudioLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void load(string url, ActionCallback<AudioBuffer> onLoad, ActionCallback<ProgressEvent> onProgress = null, ActionCallback<ErrorEvent> onError = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<AudioBuffer> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskClass<AudioBuffer>(
                entity => new AudioBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }
    #endregion
}
