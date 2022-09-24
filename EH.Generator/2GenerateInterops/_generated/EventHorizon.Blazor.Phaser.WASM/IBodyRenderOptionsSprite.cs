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

    public interface IBodyRenderOptionsSprite : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IBodyRenderOptionsSpriteCachedEntity>))]
    public class IBodyRenderOptionsSpriteCachedEntity : CachedEntityObject, IBodyRenderOptionsSprite
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
        
        public decimal xOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "xOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xOffset",
                    value
                );
            }
        }

        
        public decimal yOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "yOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "yOffset",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IBodyRenderOptionsSpriteCachedEntity() : base() { }

        public IBodyRenderOptionsSpriteCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}