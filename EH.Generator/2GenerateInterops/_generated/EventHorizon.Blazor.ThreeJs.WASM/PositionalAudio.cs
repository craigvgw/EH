/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PositionalAudio>))]
public class PositionalAudio : Audio<PannerNode>
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
        private PannerNode __panner;
        public PannerNode panner
        {
            get
            {
            if(__panner == null)
            {
                __panner = EventHorizonBlazorInterop.GetClass<PannerNode>(
                    this.___guid,
                    "panner",
                    (entity) =>
                    {
                        return new PannerNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __panner;
            }
            set
            {
__panner = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panner",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public PositionalAudio() : base() { }

        public PositionalAudio(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PositionalAudio(
            AudioListener listener
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PositionalAudio" },
                listener
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public PannerNode getOutput()
        {
            return EventHorizonBlazorInterop.FuncClass<PannerNode>(
                entity => new PannerNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getOutput" }
                }
            );
        }

        public PositionalAudio setRefDistance(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<PositionalAudio>(
                entity => new PositionalAudio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRefDistance" }, value
                }
            );
        }

        public decimal getRefDistance()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRefDistance" }
                }
            );
        }

        public PositionalAudio setRolloffFactor(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<PositionalAudio>(
                entity => new PositionalAudio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRolloffFactor" }, value
                }
            );
        }

        public decimal getRolloffFactor()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRolloffFactor" }
                }
            );
        }

        public PositionalAudio setDistanceModel(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<PositionalAudio>(
                entity => new PositionalAudio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDistanceModel" }, value
                }
            );
        }

        public string getDistanceModel()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getDistanceModel" }
                }
            );
        }

        public PositionalAudio setMaxDistance(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<PositionalAudio>(
                entity => new PositionalAudio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaxDistance" }, value
                }
            );
        }

        public decimal getMaxDistance()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxDistance" }
                }
            );
        }

        public PositionalAudio setDirectionalCone(decimal coneInnerAngle, decimal coneOuterAngle, decimal coneOuterGain)
        {
            return EventHorizonBlazorInterop.FuncClass<PositionalAudio>(
                entity => new PositionalAudio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDirectionalCone" }, coneInnerAngle, coneOuterAngle, coneOuterGain
                }
            );
        }

        public void updateMatrixWorld(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrixWorld" }, force
                }
            );
        }
    #endregion
}
