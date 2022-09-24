/// Generated - Do Not Edit
namespace Phaser.Loader
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<File>))]
    public class File : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void createObjectURL(HTMLImageElement image, Blob blob, string defaultType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "Phaser", "Loader", "File", "createObjectURL" }, image, blob, defaultType
                }
            );
        }

        public static void revokeObjectURL(HTMLImageElement image)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "Phaser", "Loader", "File", "revokeObjectURL" }, image
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private LoaderPlugin __loader;
        public LoaderPlugin loader
        {
            get
            {
            if(__loader == null)
            {
                __loader = EventHorizonBlazorInterop.GetClass<LoaderPlugin>(
                    this.___guid,
                    "loader",
                    (entity) =>
                    {
                        return new LoaderPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __loader;
            }
            set
            {
__loader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loader",
                    value
                );
            }
        }

        private BaseCache __cache;
        public BaseCache cache
        {
            get
            {
            if(__cache == null)
            {
                __cache = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "cache",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __cache;
            }
            set
            {
__cache = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cache",
                    value
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
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

        
        public string key
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "key"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "key",
                    value
                );
            }
        }

        
        public CachedEntity url
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "url"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "url",
                    value
                );
            }
        }

        
        public string src
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "src"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "src",
                    value
                );
            }
        }

        private XHRSettingsObject __xhrSettings;
        public XHRSettingsObject xhrSettings
        {
            get
            {
            if(__xhrSettings == null)
            {
                __xhrSettings = EventHorizonBlazorInterop.GetClass<XHRSettingsObject>(
                    this.___guid,
                    "xhrSettings",
                    (entity) =>
                    {
                        return new XHRSettingsObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __xhrSettings;
            }
            set
            {
__xhrSettings = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xhrSettings",
                    value
                );
            }
        }

        private XMLHttpRequest __xhrLoader;
        public XMLHttpRequest xhrLoader
        {
            get
            {
            if(__xhrLoader == null)
            {
                __xhrLoader = EventHorizonBlazorInterop.GetClass<XMLHttpRequest>(
                    this.___guid,
                    "xhrLoader",
                    (entity) =>
                    {
                        return new XMLHttpRequest() { ___guid = entity.___guid };
                    }
                );
            }
            return __xhrLoader;
            }
            set
            {
__xhrLoader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xhrLoader",
                    value
                );
            }
        }

        
        public decimal state
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "state"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }

        
        public decimal bytesTotal
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bytesTotal"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bytesTotal",
                    value
                );
            }
        }

        
        public decimal bytesLoaded
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bytesLoaded"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bytesLoaded",
                    value
                );
            }
        }

        
        public decimal percentComplete
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "percentComplete"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "percentComplete",
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

        
        public CachedEntity config
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "config",
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
                    "config",
                    value
                );
            }
        }

        private MultiFile __multiFile;
        public MultiFile multiFile
        {
            get
            {
            if(__multiFile == null)
            {
                __multiFile = EventHorizonBlazorInterop.GetClass<MultiFile>(
                    this.___guid,
                    "multiFile",
                    (entity) =>
                    {
                        return new MultiFile() { ___guid = entity.___guid };
                    }
                );
            }
            return __multiFile;
            }
            set
            {
__multiFile = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multiFile",
                    value
                );
            }
        }

        private File __linkFile;
        public File linkFile
        {
            get
            {
            if(__linkFile == null)
            {
                __linkFile = EventHorizonBlazorInterop.GetClass<File>(
                    this.___guid,
                    "linkFile",
                    (entity) =>
                    {
                        return new File() { ___guid = entity.___guid };
                    }
                );
            }
            return __linkFile;
            }
            set
            {
__linkFile = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linkFile",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public File() : base() { }

        public File(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public File(
            LoaderPlugin loader, FileConfig fileConfig
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "File" },
                loader, fileConfig
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setLink(File fileB)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLink" }, fileB
                }
            );
        }

        public void resetXHR()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetXHR" }
                }
            );
        }

        public void load()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }
                }
            );
        }

        public void onLoad(XMLHttpRequest xhr, ProgressEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onLoad" }, xhr, @event
                }
            );
        }

        public void onError(XMLHttpRequest xhr, ProgressEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onError" }, xhr, @event
                }
            );
        }

        public void onProgress(ProgressEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onProgress" }, @event
                }
            );
        }

        public void onProcess()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onProcess" }
                }
            );
        }

        public void onProcessComplete()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onProcessComplete" }
                }
            );
        }

        public void onProcessError()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onProcessError" }
                }
            );
        }

        public bool hasCacheConflict()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasCacheConflict" }
                }
            );
        }

        public void addToCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addToCache" }
                }
            );
        }

        public void pendingDestroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pendingDestroy" }
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}