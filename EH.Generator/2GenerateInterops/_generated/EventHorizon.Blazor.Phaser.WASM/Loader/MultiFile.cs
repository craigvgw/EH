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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MultiFile>))]
    public class MultiFile : CachedEntityObject
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

        
        public File[] files
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<File>(
                    this.___guid,
                    "files",
                    (entity) =>
                    {
                        return new File() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "files",
                    value
                );
            }
        }

        
        public bool complete
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "complete"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "complete",
                    value
                );
            }
        }

        
        public decimal pending
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pending"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pending",
                    value
                );
            }
        }

        
        public decimal failed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "failed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "failed",
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

        
        public string baseURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "baseURL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseURL",
                    value
                );
            }
        }

        
        public string path
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "path"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "path",
                    value
                );
            }
        }

        
        public string prefix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "prefix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prefix",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public MultiFile() : base() { }

        public MultiFile(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public MultiFile(
            LoaderPlugin loader, string type, string key, File[] files
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "MultiFile" },
                loader, type, key, files
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isReadyToProcess()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyToProcess" }
                }
            );
        }

        public MultiFile addToMultiFile(File files)
        {
            return EventHorizonBlazorInterop.FuncClass<MultiFile>(
                entity => new MultiFile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addToMultiFile" }, files
                }
            );
        }

        public void onFileComplete(File file)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onFileComplete" }, file
                }
            );
        }

        public void onFileFailed(File file)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onFileFailed" }, file
                }
            );
        }
        #endregion
    }
}