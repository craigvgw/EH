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

    public interface IStatic : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IStaticCachedEntity>))]
    public class IStaticCachedEntity : CachedEntityObject, IStatic
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
        public IStaticCachedEntity() : base() { }

        public IStaticCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public GameObject setStatic(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setStatic" }, value
                }
            );
        }

        public bool isStatic()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isStatic" }
                }
            );
        }
        #endregion
    }
}