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

    public interface ISensor : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISensorCachedEntity>))]
    public class ISensorCachedEntity : CachedEntityObject, ISensor
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
        public ISensorCachedEntity() : base() { }

        public ISensorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public GameObject setSensor(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSensor" }, value
                }
            );
        }

        public bool isSensor()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isSensor" }
                }
            );
        }
        #endregion
    }
}