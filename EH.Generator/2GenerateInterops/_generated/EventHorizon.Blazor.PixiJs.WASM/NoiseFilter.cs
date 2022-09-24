/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<NoiseFilter>))]
public class NoiseFilter : Filter
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal noise
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "noise"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noise",
                    value
                );
            }
        }

        
        public decimal seed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "seed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "seed",
                    value
                );
            }
        }
    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public NoiseFilter() : base() { }

        public NoiseFilter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public NoiseFilter(
            System.Nullable<decimal> noise = null, System.Nullable<decimal> seed = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "NoiseFilter" },
                noise, seed
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
