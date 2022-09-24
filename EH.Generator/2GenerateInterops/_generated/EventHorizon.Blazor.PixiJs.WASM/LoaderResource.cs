/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LoaderResource>))]
public class LoaderResource : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static void setExtensionLoadType(string extname, int loadType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "LoaderResource", "setExtensionLoadType" }, extname, loadType
                }
            );
        }

        public static void setExtensionXhrType(string extname, int xhrType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "LoaderResource", "setExtensionXhrType" }, extname, xhrType
                }
            );
        }
    #endregion

    #region Accessors
        
        public bool isDataUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDataUrl"
                );
            }
        }

        
        public bool isComplete
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isComplete"
                );
            }
        }

        
        public bool isLoading
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLoading"
                );
            }
        }
    #endregion

    #region Properties
        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        private Blob __blob;
        public Blob blob
        {
            get
            {
            if(__blob == null)
            {
                __blob = EventHorizonBlazorInterop.GetClass<Blob>(
                    this.___guid,
                    "blob",
                    (entity) =>
                    {
                        return new Blob() { ___guid = entity.___guid };
                    }
                );
            }
            return __blob;
            }
            set
            {
__blob = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blob",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
        }

        
        public string url
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "url"
                );
            }
        }

        
        public string extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "extension"
                );
            }
        }

        
        public CachedEntity data
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public string crossOrigin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "crossOrigin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "crossOrigin",
                    value
                );
            }
        }

        
        public decimal timeout
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeout"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeout",
                    value
                );
            }
        }

        
        public int loadType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "loadType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadType",
                    value
                );
            }
        }

        
        public string xhrType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "xhrType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xhrType",
                    value
                );
            }
        }

        private IResourceMetadataCachedEntity __metadata;
        public IResourceMetadataCachedEntity metadata
        {
            get
            {
            if(__metadata == null)
            {
                __metadata = EventHorizonBlazorInterop.GetClass<IResourceMetadataCachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new IResourceMetadataCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __metadata;
            }
            set
            {
__metadata = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "metadata",
                    value
                );
            }
        }

        private Error __error;
        public Error error
        {
            get
            {
            if(__error == null)
            {
                __error = EventHorizonBlazorInterop.GetClass<Error>(
                    this.___guid,
                    "error",
                    (entity) =>
                    {
                        return new Error() { ___guid = entity.___guid };
                    }
                );
            }
            return __error;
            }
            set
            {
__error = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "error",
                    value
                );
            }
        }

        private XMLHttpRequest __xhr;
        public XMLHttpRequest xhr
        {
            get
            {
            if(__xhr == null)
            {
                __xhr = EventHorizonBlazorInterop.GetClass<XMLHttpRequest>(
                    this.___guid,
                    "xhr",
                    (entity) =>
                    {
                        return new XMLHttpRequest() { ___guid = entity.___guid };
                    }
                );
            }
            return __xhr;
            }
            set
            {
__xhr = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xhr",
                    value
                );
            }
        }

        
        public LoaderResource[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<LoaderResource>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new LoaderResource() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal progressChunk
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "progressChunk"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "progressChunk",
                    value
                );
            }
        }

        private Signal<OnStartSignal> __onStart;
        public Signal<OnStartSignal> onStart
        {
            get
            {
            if(__onStart == null)
            {
                __onStart = EventHorizonBlazorInterop.GetClass<Signal<OnStartSignal>>(
                    this.___guid,
                    "onStart",
                    (entity) =>
                    {
                        return new Signal<OnStartSignal>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onStart;
            }
            set
            {
__onStart = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onStart",
                    value
                );
            }
        }

        private Signal<OnProgressSignal> __onProgress;
        public Signal<OnProgressSignal> onProgress
        {
            get
            {
            if(__onProgress == null)
            {
                __onProgress = EventHorizonBlazorInterop.GetClass<Signal<OnProgressSignal>>(
                    this.___guid,
                    "onProgress",
                    (entity) =>
                    {
                        return new Signal<OnProgressSignal>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onProgress;
            }
            set
            {
__onProgress = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onProgress",
                    value
                );
            }
        }

        private Signal<OnCompleteSignal> __onComplete;
        public Signal<OnCompleteSignal> onComplete
        {
            get
            {
            if(__onComplete == null)
            {
                __onComplete = EventHorizonBlazorInterop.GetClass<Signal<OnCompleteSignal>>(
                    this.___guid,
                    "onComplete",
                    (entity) =>
                    {
                        return new Signal<OnCompleteSignal>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onComplete;
            }
            set
            {
__onComplete = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onComplete",
                    value
                );
            }
        }

        private Signal<OnCompleteSignal> __onAfterMiddleware;
        public Signal<OnCompleteSignal> onAfterMiddleware
        {
            get
            {
            if(__onAfterMiddleware == null)
            {
                __onAfterMiddleware = EventHorizonBlazorInterop.GetClass<Signal<OnCompleteSignal>>(
                    this.___guid,
                    "onAfterMiddleware",
                    (entity) =>
                    {
                        return new Signal<OnCompleteSignal>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterMiddleware;
            }
            set
            {
__onAfterMiddleware = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterMiddleware",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public LoaderResource() : base() { }

        public LoaderResource(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public LoaderResource(
            string name, string url, string options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LoaderResource" },
                name, url, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void complete()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "complete" }
                }
            );
        }

        public void abort(string message)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "abort" }, message
                }
            );
        }

        public void load(OnCompleteSignal cb = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, cb
                }
            );
        }
    #endregion
}
