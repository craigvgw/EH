/// Generated - Do Not Edit
namespace MatterJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IBodyRenderOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IBodyRenderOptionsCachedEntity>))]
    public class IBodyRenderOptionsCachedEntity : CachedEntityObject, IBodyRenderOptions
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
        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }

        
        public decimal opacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "opacity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "opacity",
                    value
                );
            }
        }

        private IBodyRenderOptionsSpriteCachedEntity __sprite;
        public IBodyRenderOptionsSpriteCachedEntity sprite
        {
            get
            {
            if(__sprite == null)
            {
                __sprite = EventHorizonBlazorInterop.GetClass<IBodyRenderOptionsSpriteCachedEntity>(
                    this.___guid,
                    "sprite",
                    (entity) =>
                    {
                        return new IBodyRenderOptionsSpriteCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __sprite;
            }
            set
            {
__sprite = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sprite",
                    value
                );
            }
        }

        
        public decimal fillColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fillColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillColor",
                    value
                );
            }
        }

        
        public decimal fillOpacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fillOpacity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillOpacity",
                    value
                );
            }
        }

        
        public decimal lineColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineColor",
                    value
                );
            }
        }

        
        public decimal lineOpacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineOpacity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineOpacity",
                    value
                );
            }
        }

        
        public decimal lineThickness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineThickness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineThickness",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IBodyRenderOptionsCachedEntity() : base() { }

        public IBodyRenderOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}