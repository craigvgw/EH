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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NoAudioSound>))]
    public class NoAudioSound : CachedEntityObject
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
        public NoAudioSound() : base() { }

        public NoAudioSound(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public NoAudioSound(
            NoAudioSoundManager manager, string key, SoundConfig config = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "NoAudioSound" },
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

        public unknown removeMarker(string markerName)
        {
            return EventHorizonBlazorInterop.Func<unknown>(
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