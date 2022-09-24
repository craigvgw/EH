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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CSATFactory>))]
    public class CSATFactory : CachedEntityObject
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
        public CSATFactory() : base() { }

        public CSATFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public ICollisionDataCachedEntity collides(CachedEntity bodyA, CachedEntity bodyB, ICollisionData previousCollision)
        {
            return EventHorizonBlazorInterop.FuncClass<ICollisionDataCachedEntity>(
                entity => new ICollisionDataCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "collides" }, bodyA, bodyB, previousCollision
                }
            );
        }
        #endregion
    }
}