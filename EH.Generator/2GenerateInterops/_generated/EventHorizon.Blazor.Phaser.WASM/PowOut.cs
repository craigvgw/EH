/// Generated - Do Not Edit
namespace spine
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<PowOut>))]
    public class PowOut : Pow
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
        public PowOut() : base() { }

        public PowOut(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PowOut(
            decimal power
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "PowOut" },
                power
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal applyInternal(decimal a)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "applyInternal" }, a
                }
            );
        }
        #endregion
    }
}