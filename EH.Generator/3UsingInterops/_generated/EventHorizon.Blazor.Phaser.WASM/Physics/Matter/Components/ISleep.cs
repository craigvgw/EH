/// Generated - Do Not Edit
namespace Phaser.Physics.Matter.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface ISleep : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISleepCachedEntity>))]
    public class ISleepCachedEntity : CachedEntityObject, ISleep
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

        #endregion
        
        #region Constructor
        public ISleepCachedEntity() : base() { }

        public ISleepCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ISleepCachedEntity setToSleep()
        {
            return EventHorizonBlazorInterop.FuncClass<ISleepCachedEntity>(
                entity => new ISleepCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setToSleep" }
                }
            );
        }

        public ISleepCachedEntity setAwake()
        {
            return EventHorizonBlazorInterop.FuncClass<ISleepCachedEntity>(
                entity => new ISleepCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAwake" }
                }
            );
        }

        public ISleepCachedEntity setSleepThreshold(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ISleepCachedEntity>(
                entity => new ISleepCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepThreshold" }, value
                }
            );
        }

        public ISleepCachedEntity setSleepEvents(bool start, bool end)
        {
            return EventHorizonBlazorInterop.FuncClass<ISleepCachedEntity>(
                entity => new ISleepCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepEvents" }, start, end
                }
            );
        }

        public ISleepCachedEntity setSleepStartEvent(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<ISleepCachedEntity>(
                entity => new ISleepCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepStartEvent" }, value
                }
            );
        }

        public ISleepCachedEntity setSleepEndEvent(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<ISleepCachedEntity>(
                entity => new ISleepCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepEndEvent" }, value
                }
            );
        }
        #endregion
    }
}