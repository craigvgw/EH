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
        private static Loader __shared;
        public static Loader shared
        {
            get
            {
            if(__shared == null)
            {
                __shared = EventHorizonBlazorInterop.GetClass<Loader>(
                    "Loader",
                    "shared",
                    (entity) =>
                    {
                        return new Loader() { ___guid = entity.___guid };
                    }
                );
            }
            return __shared;
            }
        }
    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Loader registerPlugin(ILoaderPlugin plugin)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Loader", "registerPlugin" }, plugin
                }
            );
        }
    #endregion

    #region Accessors
        
        public decimal concurrency
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "concurrency"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "concurrency",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public string baseUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "baseUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseUrl",
                    value
                );
            }
        }

        
        public decimal progress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "progress"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "progress",
                    value
                );
            }
        }

        
        public bool loading
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loading"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loading",
                    value
                );
            }
        }

        
        public string defaultQueryString
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultQueryString"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultQueryString",
                    value
                );
            }
        }

        
        public CachedEntity resources
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "resources"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resources",
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

        private Signal<OnErrorSignal> __onError;
        public Signal<OnErrorSignal> onError
        {
            get
            {
            if(__onError == null)
            {
                __onError = EventHorizonBlazorInterop.GetClass<Signal<OnErrorSignal>>(
                    this.___guid,
                    "onError",
                    (entity) =>
                    {
                        return new Signal<OnErrorSignal>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onError;
            }
            set
            {
__onError = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onError",
                    value
                );
            }
        }

        private Signal<OnLoadSignal> __onLoad;
        public Signal<OnLoadSignal> onLoad
        {
            get
            {
            if(__onLoad == null)
            {
                __onLoad = EventHorizonBlazorInterop.GetClass<Signal<OnLoadSignal>>(
                    this.___guid,
                    "onLoad",
                    (entity) =>
                    {
                        return new Signal<OnLoadSignal>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onLoad;
            }
            set
            {
__onLoad = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onLoad",
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

        private ILoaderAddCachedEntity __add;
        public ILoaderAddCachedEntity add
        {
            get
            {
            if(__add == null)
            {
                __add = EventHorizonBlazorInterop.GetClass<ILoaderAddCachedEntity>(
                    this.___guid,
                    "add",
                    (entity) =>
                    {
                        return new ILoaderAddCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __add;
            }
            set
            {
__add = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "add",
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
            string baseUrl = null, System.Nullable<decimal> concurrency = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Loader" },
                baseUrl, concurrency
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Loader pre(ActionCallback<LoaderResource, ActionResultCallback<ActionCallback<CachedEntity[]>>> fn)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pre" }, fn
                }
            );
        }

        public Loader use(ActionCallback<LoaderResource, ActionResultCallback<ActionCallback<CachedEntity[]>>> fn)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "use" }, fn
                }
            );
        }

        public Loader reset()
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public Loader load(OnCompleteSignal cb = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }, cb
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
