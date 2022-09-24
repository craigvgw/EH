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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CDetectorFactory>))]
    public class CDetectorFactory : CachedEntityObject
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
        public CDetectorFactory() : base() { }

        public CDetectorFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public ICollisionDataCachedEntity[] collisions(IPair[] broadphasePairs, CEngine engine)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ICollisionDataCachedEntity>(
                entity => new ICollisionDataCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "collisions" }, broadphasePairs, engine
                }
            );
        }

        public bool canCollide(ICollisionFilter filterA, ICollisionFilter filterB)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "canCollide" }, filterA, filterB
                }
            );
        }
        #endregion
    }
}