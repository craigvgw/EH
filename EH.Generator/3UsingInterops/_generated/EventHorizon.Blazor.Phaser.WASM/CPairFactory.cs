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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CPairFactory>))]
    public class CPairFactory : CachedEntityObject
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
        public CPairFactory() : base() { }

        public CPairFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public IPairCachedEntity create(ICollisionData collision, decimal timestamp)
        {
            return EventHorizonBlazorInterop.FuncClass<IPairCachedEntity>(
                entity => new IPairCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, collision, timestamp
                }
            );
        }

        public void update(IPair pair, ICollisionData collision, decimal timestamp)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, pair, collision, timestamp
                }
            );
        }

        public void setActive(IPair pair, bool isActive, decimal timestamp)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setActive" }, pair, isActive, timestamp
                }
            );
        }

        public string id(CachedEntity bodyA, CachedEntity bodyB)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "id" }, bodyA, bodyB
                }
            );
        }
        #endregion
    }
}