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

    public interface IEngineTimingOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEngineTimingOptionsCachedEntity>))]
    public class IEngineTimingOptionsCachedEntity : CachedEntityObject, IEngineTimingOptions
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
        
        public decimal timeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeScale",
                    value
                );
            }
        }

        
        public decimal timestamp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timestamp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timestamp",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IEngineTimingOptionsCachedEntity() : base() { }

        public IEngineTimingOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}