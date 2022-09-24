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

    public interface IEventTimestamped<T> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEventTimestampedCachedEntity<CachedEntity>>))]
    public class IEventTimestampedCachedEntity<T> : CachedEntityObject, IEventTimestamped<T> where T : CachedEntity, new()
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
        public IEventTimestampedCachedEntity() : base() { }

        public IEventTimestampedCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}