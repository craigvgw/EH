/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AlphaFilter>))]
public class AlphaFilter : Filter
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }
    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public AlphaFilter() : base() { }

        public AlphaFilter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AlphaFilter(
            System.Nullable<decimal> alpha = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AlphaFilter" },
                alpha
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
