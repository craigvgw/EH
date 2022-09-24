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

    public interface IMass : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IMassCachedEntity>))]
    public class IMassCachedEntity : CachedEntityObject, IMass
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
        public IMassCachedEntity() : base() { }

        public IMassCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IMassCachedEntity setMass(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<IMassCachedEntity>(
                entity => new IMassCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMass" }, value
                }
            );
        }
        #endregion
    }
}