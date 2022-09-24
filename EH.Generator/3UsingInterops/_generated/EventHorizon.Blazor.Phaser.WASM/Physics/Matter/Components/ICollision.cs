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

    public interface ICollision : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICollisionCachedEntity>))]
    public class ICollisionCachedEntity : CachedEntityObject, ICollision
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
        public ICollisionCachedEntity() : base() { }

        public ICollisionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public GameObject setCollisionCategory(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionCategory" }, value
                }
            );
        }

        public GameObject setCollisionGroup(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionGroup" }, value
                }
            );
        }

        public GameObject setCollidesWith(decimal categories)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollidesWith" }, categories
                }
            );
        }


        #endregion
    }
}