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

    public interface IFriction : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IFrictionCachedEntity>))]
    public class IFrictionCachedEntity : CachedEntityObject, IFriction
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
        public IFrictionCachedEntity() : base() { }

        public IFrictionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IFrictionCachedEntity setFriction(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IFrictionCachedEntity>(
                entity => new IFrictionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFriction" }, x, y
                }
            );
        }

        public IFrictionCachedEntity setFrictionX(decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<IFrictionCachedEntity>(
                entity => new IFrictionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrictionX" }, x
                }
            );
        }

        public IFrictionCachedEntity setFrictionY(decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<IFrictionCachedEntity>(
                entity => new IFrictionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrictionY" }, y
                }
            );
        }
        #endregion
    }
}