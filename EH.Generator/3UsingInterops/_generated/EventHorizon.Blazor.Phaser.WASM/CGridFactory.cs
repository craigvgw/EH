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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CGridFactory>))]
    public class CGridFactory : CachedEntityObject
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
        public CGridFactory() : base() { }

        public CGridFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public CGrid create(IGridDefinition options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CGrid>(
                entity => new CGrid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, options
                }
            );
        }

        public void update(CGrid grid, CachedEntity[] bodies, CEngine engine, bool forceUpdate)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, grid, bodies, engine, forceUpdate
                }
            );
        }

        public void clear(CGrid grid)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, grid
                }
            );
        }
        #endregion
    }
}