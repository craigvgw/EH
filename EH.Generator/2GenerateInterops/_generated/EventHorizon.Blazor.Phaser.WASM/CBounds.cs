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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CBounds>))]
    public class CBounds : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static IBoundCachedEntity create(CVertices vertices)
        {
            return EventHorizonBlazorInterop.FuncClass<IBoundCachedEntity>(
                entity => new IBoundCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CBounds", "create" }, vertices
                }
            );
        }

        public static void update(IBound bounds, CVertices vertices, CVector velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBounds", "update" }, bounds, vertices, velocity
                }
            );
        }

        public static bool contains(IBound bounds, CVector point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "MatterJS", "CBounds", "contains" }, bounds, point
                }
            );
        }

        public static bool overlaps(IBound boundsA, IBound boundsB)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "MatterJS", "CBounds", "overlaps" }, boundsA, boundsB
                }
            );
        }

        public static void translate(IBound bounds, CVector vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBounds", "translate" }, bounds, vector
                }
            );
        }

        public static void shift(IBound bounds, CVector position)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBounds", "shift" }, bounds, position
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public CBounds() : base() { }

        public CBounds(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}