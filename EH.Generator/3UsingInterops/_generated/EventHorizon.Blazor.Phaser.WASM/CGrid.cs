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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CGrid>))]
    public class CGrid : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static CGrid create(IGridDefinition options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CGrid>(
                entity => new CGrid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CGrid", "create" }, options
                }
            );
        }

        public static void update(CGrid grid, CachedEntity[] bodies, CEngine engine, bool forceUpdate)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CGrid", "update" }, grid, bodies, engine, forceUpdate
                }
            );
        }

        public static void clear(CGrid grid)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CGrid", "clear" }, grid
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public CGrid() : base() { }

        public CGrid(
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