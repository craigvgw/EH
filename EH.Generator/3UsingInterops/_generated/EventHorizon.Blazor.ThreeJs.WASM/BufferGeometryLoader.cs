/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BufferGeometryLoader>))]
public class BufferGeometryLoader : Loader
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
        public BufferGeometryLoader() : base() { }

        public BufferGeometryLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BufferGeometryLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BufferGeometryLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void load(string url, InstancedBufferGeometry onLoad, ActionCallback<ProgressEvent> onProgress = null, ActionCallback<ErrorEvent> onError = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<InstancedBufferGeometry> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskClass<InstancedBufferGeometry>(
                entity => new InstancedBufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }

        public InstancedBufferGeometry parse(object json)
        {
            return EventHorizonBlazorInterop.FuncClass<InstancedBufferGeometry>(
                entity => new InstancedBufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parse" }, json
                }
            );
        }
    #endregion
}
