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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CAxesFactory>))]
    public class CAxesFactory : CachedEntityObject
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
        public CAxesFactory() : base() { }

        public CAxesFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public CVector[] fromVertices(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromVertices" }, vertices
                }
            );
        }

        public void rotate(CVector[] axes, decimal angle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, axes, angle
                }
            );
        }
        #endregion
    }
}