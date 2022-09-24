/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AnimationLoader>))]
public class AnimationLoader : Loader
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
        public AnimationLoader() : base() { }

        public AnimationLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AnimationLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AnimationLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void load(string url, ActionCallback<AnimationClip[]> onLoad, ActionCallback<ProgressEvent> onProgress = null, ActionCallback<ErrorEvent> onError = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<AnimationClip[]> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskArrayClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }

        public AnimationClip[] parse(object json)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parse" }, json
                }
            );
        }
    #endregion
}
