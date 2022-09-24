/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<KeyframeTrack>))]
public class KeyframeTrack : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static CachedEntity toJSON(KeyframeTrack track)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "KeyframeTrack", "toJSON" }, track
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public decimal[] times
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "times"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "times",
                    value
                );
            }
        }

        
        public decimal[] values
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "values"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "values",
                    value
                );
            }
        }

        
        public string ValueTypeName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "ValueTypeName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ValueTypeName",
                    value
                );
            }
        }

        
        public decimal[] TimeBufferType
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "TimeBufferType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TimeBufferType",
                    value
                );
            }
        }

        
        public decimal[] ValueBufferType
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "ValueBufferType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ValueBufferType",
                    value
                );
            }
        }

        
        public int DefaultInterpolation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "DefaultInterpolation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DefaultInterpolation",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public KeyframeTrack() : base() { }

        public KeyframeTrack(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public KeyframeTrack(
            string name, CachedEntity[] times, CachedEntity[] values, System.Nullable<int> interpolation = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "KeyframeTrack" },
                name, times, values, interpolation
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public DiscreteInterpolant InterpolantFactoryMethodDiscrete(object result)
        {
            return EventHorizonBlazorInterop.FuncClass<DiscreteInterpolant>(
                entity => new DiscreteInterpolant() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "InterpolantFactoryMethodDiscrete" }, result
                }
            );
        }

        public LinearInterpolant InterpolantFactoryMethodLinear(object result)
        {
            return EventHorizonBlazorInterop.FuncClass<LinearInterpolant>(
                entity => new LinearInterpolant() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "InterpolantFactoryMethodLinear" }, result
                }
            );
        }

        public CubicInterpolant InterpolantFactoryMethodSmooth(object result)
        {
            return EventHorizonBlazorInterop.FuncClass<CubicInterpolant>(
                entity => new CubicInterpolant() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "InterpolantFactoryMethodSmooth" }, result
                }
            );
        }

        public KeyframeTrack setInterpolation(int interpolation)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyframeTrack>(
                entity => new KeyframeTrack() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setInterpolation" }, interpolation
                }
            );
        }

        public int getInterpolation()
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[]
                {
                    new string[] { this.___guid, "getInterpolation" }
                }
            );
        }

        public decimal getValueSize()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getValueSize" }
                }
            );
        }

        public KeyframeTrack shift(decimal timeOffset)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyframeTrack>(
                entity => new KeyframeTrack() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shift" }, timeOffset
                }
            );
        }

        public KeyframeTrack scale(decimal timeScale)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyframeTrack>(
                entity => new KeyframeTrack() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, timeScale
                }
            );
        }

        public KeyframeTrack trim(decimal startTime, decimal endTime)
        {
            return EventHorizonBlazorInterop.FuncClass<KeyframeTrack>(
                entity => new KeyframeTrack() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "trim" }, startTime, endTime
                }
            );
        }

        public bool validate()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "validate" }
                }
            );
        }

        public KeyframeTrack optimize()
        {
            return EventHorizonBlazorInterop.FuncClass<KeyframeTrack>(
                entity => new KeyframeTrack() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "optimize" }
                }
            );
        }

        public KeyframeTrack clone()
        {
            return EventHorizonBlazorInterop.FuncClass<KeyframeTrack>(
                entity => new KeyframeTrack() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
    #endregion
}
