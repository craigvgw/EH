/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<DiscreteInterpolant>))]
public class DiscreteInterpolant : Interpolant
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
        public DiscreteInterpolant() : base() { }

        public DiscreteInterpolant(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DiscreteInterpolant(
            object parameterPositions, object samplesValues, decimal sampleSize, object resultBuffer = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "DiscreteInterpolant" },
                parameterPositions, samplesValues, sampleSize, resultBuffer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CachedEntity interpolate_(decimal i1, decimal t0, decimal t, decimal t1)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "interpolate_" }, i1, t0, t, t1
                }
            );
        }
    #endregion
}
