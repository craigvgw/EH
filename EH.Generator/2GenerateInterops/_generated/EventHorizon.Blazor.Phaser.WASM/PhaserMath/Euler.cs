/// Generated - Do Not Edit
namespace Phaser.PhaserMath
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Euler>))]
    public class Euler : CachedEntityObject
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
        public Euler() : base() { }

        public Euler(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Euler(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "PhaserMath", "Euler" },
                x, y, z
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}