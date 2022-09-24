/// Generated - Do Not Edit
namespace Phaser.Sound
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseSound>))]
    public class BaseSound : EventEmitter
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
        
        public string key
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "key"
                );
            }
        }

        
        public bool isPlaying
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPlaying"
                );
            }
        }

        
        public bool isPaused
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPaused"
                );
            }
        }

        
        public decimal totalRate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalRate"
                );
            }
        }

        
        public decimal duration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "duration"
                );
            }
        }

        
        public decimal totalDuration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalDuration"
                );
            }
        }

        
        public CachedEntity markers
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "markers",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private SoundMarker __currentMarker;
        public SoundMarker currentMarker
        {
            get
            {
            if(__currentMarker == null)
            {
                __currentMarker = EventHorizonBlazorInterop.GetClass<SoundMarker>(
                    this.___guid,
                    "currentMarker",
                    (entity) =>
                    {
                        return new SoundMarker() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentMarker;
            }
        }
        #endregion
        
        #region Constructor
        public BaseSound() : base() { }

        public BaseSound(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BaseSound(
            BaseSoundManager manager, string key, SoundConfig config = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "BaseSound" },
                manager, key, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool addMarker(SoundMarker marker)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "addMarker" }, marker
                }
            );
        }

        public bool updateMarker(SoundMarker marker)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "updateMarker" }, marker
                }
            );
        }

        public SoundMarker removeMarker(string markerName)
        {
            return EventHorizonBlazorInterop.FuncClass<SoundMarker>(
                entity => new SoundMarker() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeMarker" }, markerName
                }
            );
        }

        public bool play(string markerName = null, SoundConfig config = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "play" }, markerName, config
                }
            );
        }

        public bool pause()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public bool resume()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "resume" }
                }
            );
        }

        public bool stop()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}