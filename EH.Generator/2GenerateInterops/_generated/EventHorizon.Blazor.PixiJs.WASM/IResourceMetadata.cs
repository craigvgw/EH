/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IResourceMetadata : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IResourceMetadataCachedEntity>))]
public class IResourceMetadataCachedEntity : CachedEntityObject, IResourceMetadata
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
        private HTMLImageElement __loadElement;
        public HTMLImageElement loadElement
        {
            get
            {
            if(__loadElement == null)
            {
                __loadElement = EventHorizonBlazorInterop.GetClass<HTMLImageElement>(
                    this.___guid,
                    "loadElement",
                    (entity) =>
                    {
                        return new HTMLImageElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __loadElement;
            }
            set
            {
__loadElement = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadElement",
                    value
                );
            }
        }

        
        public bool skipSource
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipSource"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipSource",
                    value
                );
            }
        }

        
        public string mimeType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "mimeType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mimeType",
                    value
                );
            }
        }

        private IResourceMetadataCachedEntity __imageMetadata;
        public IResourceMetadataCachedEntity imageMetadata
        {
            get
            {
            if(__imageMetadata == null)
            {
                __imageMetadata = EventHorizonBlazorInterop.GetClass<IResourceMetadataCachedEntity>(
                    this.___guid,
                    "imageMetadata",
                    (entity) =>
                    {
                        return new IResourceMetadataCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageMetadata;
            }
            set
            {
__imageMetadata = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageMetadata",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IResourceMetadataCachedEntity() : base() { }

        public IResourceMetadataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
