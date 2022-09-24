/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Loader>))]
public class Loader : CachedEntityObject
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

        
        public bool withCredentials
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "withCredentials"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "withCredentials",
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

        
        public string resourcePath
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "resourcePath"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resourcePath",
                    value
                );
            }
        }

        private LoadingManager __manager;
        public LoadingManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<LoadingManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new LoadingManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __manager;
            }
            set
            {
__manager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manager",
                    value
                );
            }
        }

        
        public CachedEntity requestHeader
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "requestHeader",
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
                    "requestHeader",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Loader() : base() { }

        public Loader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Loader(
            LoadingManager manager = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Loader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ValueTask<CachedEntity> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskClass<CachedEntity>(
                entity => new CachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }

        public Loader setCrossOrigin(string crossOrigin)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCrossOrigin" }, crossOrigin
                }
            );
        }

        public Loader setWithCredentials(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setWithCredentials" }, value
                }
            );
        }

        public Loader setPath(string path)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPath" }, path
                }
            );
        }

        public Loader setResourcePath(string resourcePath)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setResourcePath" }, resourcePath
                }
            );
        }

        public Loader setRequestHeader(object requestHeader)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRequestHeader" }, requestHeader
                }
            );
        }
    #endregion
}
