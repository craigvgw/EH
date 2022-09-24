/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IAddOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IAddOptionsCachedEntity>))]
public class IAddOptionsCachedEntity : CachedEntityObject, IAddOptions
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
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

        
        public string url
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
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

        private LoaderResource __parentResource;
        public LoaderResource parentResource
        {
            get
            {
            if(__parentResource == null)
            {
                __parentResource = EventHorizonBlazorInterop.GetClass<LoaderResource>(
                    this.___guid,
                    "parentResource",
                    (entity) =>
                    {
                        return new LoaderResource() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentResource;
            }
            set
            {
__parentResource = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentResource",
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

        
        public int xhrType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
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

        private OnCompleteSignal __onComplete;
        public OnCompleteSignal onComplete
        {
            get
            {
            if(__onComplete == null)
            {
                __onComplete = EventHorizonBlazorInterop.GetClass<OnCompleteSignal>(
                    this.___guid,
                    "onComplete",
                    (entity) =>
                    {
                        return new OnCompleteSignal() { ___guid = entity.___guid };
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

        private OnCompleteSignal __callback;
        public OnCompleteSignal callback
        {
            get
            {
            if(__callback == null)
            {
                __callback = EventHorizonBlazorInterop.GetClass<OnCompleteSignal>(
                    this.___guid,
                    "callback",
                    (entity) =>
                    {
                        return new OnCompleteSignal() { ___guid = entity.___guid };
                    }
                );
            }
            return __callback;
            }
            set
            {
__callback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "callback",
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
    #endregion
    
    #region Constructor
        public IAddOptionsCachedEntity() : base() { }

        public IAddOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
