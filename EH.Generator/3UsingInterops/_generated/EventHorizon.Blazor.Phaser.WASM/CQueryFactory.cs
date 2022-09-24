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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CQueryFactory>))]
    public class CQueryFactory : CachedEntityObject
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
        public CQueryFactory() : base() { }

        public CQueryFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public ICollisionDataCachedEntity[] ray(CachedEntity[] bodies, CVector startPoint, CVector endPoint, System.Nullable<decimal> rayWidth = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ICollisionDataCachedEntity>(
                entity => new ICollisionDataCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ray" }, bodies, startPoint, endPoint, rayWidth
                }
            );
        }

        public CachedEntity[] region(CachedEntity[] bodies, CBounds bounds, System.Nullable<bool> outside = null)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "region" }, bodies, bounds, outside
                }
            );
        }

        public CachedEntity[] point(CachedEntity[] bodies, CVector point)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "point" }, bodies, point
                }
            );
        }
        #endregion
    }
}