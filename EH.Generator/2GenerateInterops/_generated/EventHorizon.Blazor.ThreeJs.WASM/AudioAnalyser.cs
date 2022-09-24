/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AudioAnalyser>))]
public class AudioAnalyser : CachedEntityObject
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
        private AnalyserNode __analyser;
        public AnalyserNode analyser
        {
            get
            {
            if(__analyser == null)
            {
                __analyser = EventHorizonBlazorInterop.GetClass<AnalyserNode>(
                    this.___guid,
                    "analyser",
                    (entity) =>
                    {
                        return new AnalyserNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __analyser;
            }
            set
            {
__analyser = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "analyser",
                    value
                );
            }
        }

        
        public decimal[] data
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "data"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public AudioAnalyser() : base() { }

        public AudioAnalyser(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AudioAnalyser(
            Audio<AudioNode> audio, System.Nullable<decimal> fftSize = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AudioAnalyser" },
                audio, fftSize
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public decimal[] getFrequencyData()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFrequencyData" }
                }
            );
        }

        public decimal getAverageFrequency()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAverageFrequency" }
                }
            );
        }

        public CachedEntity getData(object file)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getData" }, file
                }
            );
        }
    #endregion
}
