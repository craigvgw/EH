/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IGenerateTextureOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IGenerateTextureOptionsCachedEntity>))]
public class IGenerateTextureOptionsCachedEntity : CachedEntityObject, IGenerateTextureOptions
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
        
        public int scaleMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "scaleMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleMode",
                    value
                );
            }
        }

        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolution",
                    value
                );
            }
        }

        private Rectangle __region;
        public Rectangle region
        {
            get
            {
            if(__region == null)
            {
                __region = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "region",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __region;
            }
            set
            {
__region = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "region",
                    value
                );
            }
        }

        
        public int multisample
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "multisample"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multisample",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IGenerateTextureOptionsCachedEntity() : base() { }

        public IGenerateTextureOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
