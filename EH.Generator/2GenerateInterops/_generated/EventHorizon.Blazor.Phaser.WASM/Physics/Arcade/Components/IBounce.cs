/// Generated - Do Not Edit
namespace Phaser.Physics.Arcade.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IBounce : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IBounceCachedEntity>))]
    public class IBounceCachedEntity : CachedEntityObject, IBounce
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
        public IBounceCachedEntity() : base() { }

        public IBounceCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IBounceCachedEntity setBounce(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IBounceCachedEntity>(
                entity => new IBounceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounce" }, x, y
                }
            );
        }

        public IBounceCachedEntity setBounceX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<IBounceCachedEntity>(
                entity => new IBounceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounceX" }, value
                }
            );
        }

        public IBounceCachedEntity setBounceY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<IBounceCachedEntity>(
                entity => new IBounceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounceY" }, value
                }
            );
        }

        public IBounceCachedEntity setCollideWorldBounds(System.Nullable<bool> value = null, System.Nullable<decimal> bounceX = null, System.Nullable<decimal> bounceY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IBounceCachedEntity>(
                entity => new IBounceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollideWorldBounds" }, value, bounceX, bounceY
                }
            );
        }
        #endregion
    }
}