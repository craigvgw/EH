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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CBoundsFactory>))]
    public class CBoundsFactory : CachedEntityObject
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
        public CBoundsFactory() : base() { }

        public CBoundsFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public IBoundCachedEntity create(CVertices vertices)
        {
            return EventHorizonBlazorInterop.FuncClass<IBoundCachedEntity>(
                entity => new IBoundCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, vertices
                }
            );
        }

        public void update(IBound bounds, CVertices vertices, CVector velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, bounds, vertices, velocity
                }
            );
        }

        public bool contains(IBound bounds, CVector point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, bounds, point
                }
            );
        }

        public bool overlaps(IBound boundsA, IBound boundsB)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "overlaps" }, boundsA, boundsB
                }
            );
        }

        public void translate(IBound bounds, CVector vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "translate" }, bounds, vector
                }
            );
        }

        public void shift(IBound bounds, CVector position)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shift" }, bounds, position
                }
            );
        }
        #endregion
    }
}