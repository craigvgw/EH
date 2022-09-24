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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebAudioSound>))]
    public class WebAudioSound : BaseSound
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
        private AudioBuffer __audioBuffer;
        public AudioBuffer audioBuffer
        {
            get
            {
            if(__audioBuffer == null)
            {
                __audioBuffer = EventHorizonBlazorInterop.GetClass<AudioBuffer>(
                    this.___guid,
                    "audioBuffer",
                    (entity) =>
                    {
                        return new AudioBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __audioBuffer;
            }
            set
            {
__audioBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "audioBuffer",
                    value
                );
            }
        }

        private AudioBufferSourceNode __source;
        public AudioBufferSourceNode source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<AudioBufferSourceNode>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new AudioBufferSourceNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __source;
            }
            set
            {
__source = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }

        private AudioBufferSourceNode __loopSource;
        public AudioBufferSourceNode loopSource
        {
            get
            {
            if(__loopSource == null)
            {
                __loopSource = EventHorizonBlazorInterop.GetClass<AudioBufferSourceNode>(
                    this.___guid,
                    "loopSource",
                    (entity) =>
                    {
                        return new AudioBufferSourceNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __loopSource;
            }
            set
            {
__loopSource = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopSource",
                    value
                );
            }
        }

        private GainNode __muteNode;
        public GainNode muteNode
        {
            get
            {
            if(__muteNode == null)
            {
                __muteNode = EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "muteNode",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __muteNode;
            }
            set
            {
__muteNode = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "muteNode",
                    value
                );
            }
        }

        private GainNode __volumeNode;
        public GainNode volumeNode
        {
            get
            {
            if(__volumeNode == null)
            {
                __volumeNode = EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "volumeNode",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __volumeNode;
            }
            set
            {
__volumeNode = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "volumeNode",
                    value
                );
            }
        }

        private StereoPannerNode __pannerNode;
        public StereoPannerNode pannerNode
        {
            get
            {
            if(__pannerNode == null)
            {
                __pannerNode = EventHorizonBlazorInterop.GetClass<StereoPannerNode>(
                    this.___guid,
                    "pannerNode",
                    (entity) =>
                    {
                        return new StereoPannerNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __pannerNode;
            }
            set
            {
__pannerNode = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pannerNode",
                    value
                );
            }
        }

        
        public bool hasEnded
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasEnded"
                );
            }
        }

        
        public bool hasLooped
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasLooped"
                );
            }
        }

        
        public decimal rate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rate",
                    value
                );
            }
        }

        
        public decimal detune
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "detune"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "detune",
                    value
                );
            }
        }

        
        public bool mute
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "mute"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mute",
                    value
                );
            }
        }

        
        public decimal volume
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "volume"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "volume",
                    value
                );
            }
        }

        
        public decimal seek
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "seek"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "seek",
                    value
                );
            }
        }

        
        public bool loop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loop",
                    value
                );
            }
        }

        
        public decimal pan
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pan"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pan",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebAudioSound() : base() { }

        public WebAudioSound(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebAudioSound(
            WebAudioSoundManager manager, string key, SoundConfig config = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "WebAudioSound" },
                manager, key, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public WebAudioSound setRate(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRate" }, value
                }
            );
        }

        public WebAudioSound setDetune(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDetune" }, value
                }
            );
        }

        public WebAudioSound setMute(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMute" }, value
                }
            );
        }

        public WebAudioSound setVolume(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVolume" }, value
                }
            );
        }

        public WebAudioSound setSeek(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSeek" }, value
                }
            );
        }

        public WebAudioSound setLoop(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLoop" }, value
                }
            );
        }

        public WebAudioSound setPan(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPan" }, value
                }
            );
        }
        #endregion
    }
}