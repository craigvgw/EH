/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<FileLoader>))]
public class FileLoader : Loader
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
        private MimeType __mimeType;
        public MimeType mimeType
        {
            get
            {
            if(__mimeType == null)
            {
                __mimeType = EventHorizonBlazorInterop.GetClass<MimeType>(
                    this.___guid,
                    "mimeType",
                    (entity) =>
                    {
                        return new MimeType() { ___guid = entity.___guid };
                    }
                );
            }
            return __mimeType;
            }
            set
            {
__mimeType = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mimeType",
                    value
                );
            }
        }

        
        public string responseType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "responseType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "responseType",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public FileLoader() : base() { }

        public FileLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FileLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "FileLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CachedEntity load(string url, string onLoad = null, ActionCallback<ProgressEvent> onProgress = null, ActionCallback<ErrorEvent> onError = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<string> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.Task<string>(
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }

        public FileLoader setMimeType(MimeType mimeType)
        {
            return EventHorizonBlazorInterop.FuncClass<FileLoader>(
                entity => new FileLoader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMimeType" }, mimeType
                }
            );
        }

        public FileLoader setResponseType(string responseType)
        {
            return EventHorizonBlazorInterop.FuncClass<FileLoader>(
                entity => new FileLoader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setResponseType" }, responseType
                }
            );
        }
    #endregion
}
