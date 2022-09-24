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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CBodiesFactory>))]
    public class CBodiesFactory : CachedEntityObject
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
        public CBodiesFactory() : base() { }

        public CBodiesFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public CachedEntity circle(decimal x, decimal y, decimal radius, IBodyDefinition options = null, System.Nullable<decimal> maxSides = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "circle" }, x, y, radius, options, maxSides
                }
            );
        }

        public CachedEntity polygon(decimal x, decimal y, decimal sides, decimal radius, IChamferableBodyDefinition options = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "polygon" }, x, y, sides, radius, options
                }
            );
        }

        public CachedEntity rectangle(decimal x, decimal y, decimal width, decimal height, IChamferableBodyDefinition options = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rectangle" }, x, y, width, height, options
                }
            );
        }

        public CachedEntity trapezoid(decimal x, decimal y, decimal width, decimal height, decimal slope, IChamferableBodyDefinition options = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "trapezoid" }, x, y, width, height, slope, options
                }
            );
        }

        public CachedEntity fromVertices(decimal x, decimal y, CVector[][] vertexSets, IBodyDefinition options = null, System.Nullable<bool> flagInternal = null, System.Nullable<decimal> removeCollinear = null, System.Nullable<decimal> minimumArea = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fromVertices" }, x, y, vertexSets, options, flagInternal, removeCollinear, minimumArea
                }
            );
        }
        #endregion
    }
}