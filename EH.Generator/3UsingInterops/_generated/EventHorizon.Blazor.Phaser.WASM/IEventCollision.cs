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

    public interface IEventCollision<T> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEventCollisionCachedEntity<CachedEntity>>))]
    public class IEventCollisionCachedEntity<T> : CachedEntityObject, IEventCollision<T> where T : CachedEntity, new()
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
        
        public IPairCachedEntity[] pairs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IPairCachedEntity>(
                    this.___guid,
                    "pairs",
                    (entity) =>
                    {
                        return new IPairCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pairs",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IEventCollisionCachedEntity() : base() { }

        public IEventCollisionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}