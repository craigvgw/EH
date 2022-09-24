/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AudioListener>))]
public class AudioListener : Object3D
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
        
        public unknown type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private AudioContext __context;
        public AudioContext context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<AudioContext>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new AudioContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __context;
            }
            set
            {
__context = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "context",
                    value
                );
            }
        }

        private GainNode __gain;
        public GainNode gain
        {
            get
            {
            if(__gain == null)
            {
                __gain = EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "gain",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __gain;
            }
            set
            {
__gain = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gain",
                    value
                );
            }
        }

        
        public CachedEntity filter
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "filter",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filter",
                    value
                );
            }
        }

        
        public decimal timeDelta
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeDelta"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeDelta",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public AudioListener() : base() { }

        public AudioListener(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public GainNode getInput()
        {
            return EventHorizonBlazorInterop.FuncClass<GainNode>(
                entity => new GainNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInput" }
                }
            );
        }

        public AudioListener removeFilter()
        {
            return EventHorizonBlazorInterop.FuncClass<AudioListener>(
                entity => new AudioListener() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeFilter" }
                }
            );
        }

        public AudioListener setFilter(object value)
        {
            return EventHorizonBlazorInterop.FuncClass<AudioListener>(
                entity => new AudioListener() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFilter" }, value
                }
            );
        }

        public CachedEntity getFilter()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFilter" }
                }
            );
        }

        public AudioListener setMasterVolume(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<AudioListener>(
                entity => new AudioListener() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMasterVolume" }, value
                }
            );
        }

        public decimal getMasterVolume()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMasterVolume" }
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
