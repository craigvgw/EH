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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebAudioSoundManager>))]
    public class WebAudioSoundManager : BaseSoundManager
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

        private GainNode __masterMuteNode;
        public GainNode masterMuteNode
        {
            get
            {
            if(__masterMuteNode == null)
            {
                __masterMuteNode = EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "masterMuteNode",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __masterMuteNode;
            }
            set
            {
__masterMuteNode = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "masterMuteNode",
                    value
                );
            }
        }

        private GainNode __masterVolumeNode;
        public GainNode masterVolumeNode
        {
            get
            {
            if(__masterVolumeNode == null)
            {
                __masterVolumeNode = EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "masterVolumeNode",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __masterVolumeNode;
            }
            set
            {
__masterVolumeNode = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "masterVolumeNode",
                    value
                );
            }
        }

        private AudioNode __destination;
        public AudioNode destination
        {
            get
            {
            if(__destination == null)
            {
                __destination = EventHorizonBlazorInterop.GetClass<AudioNode>(
                    this.___guid,
                    "destination",
                    (entity) =>
                    {
                        return new AudioNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __destination;
            }
            set
            {
__destination = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "destination",
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
        #endregion
        
        #region Constructor
        public WebAudioSoundManager() : base() { }

        public WebAudioSoundManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebAudioSoundManager(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "WebAudioSoundManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public AudioContext createAudioContext(Game game)
        {
            return EventHorizonBlazorInterop.FuncClass<AudioContext>(
                entity => new AudioContext() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createAudioContext" }, game
                }
            );
        }

        public WebAudioSoundManager setAudioContext(AudioContext context)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSoundManager>(
                entity => new WebAudioSoundManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAudioContext" }, context
                }
            );
        }

        public WebAudioSound add(string key, SoundConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSound>(
                entity => new WebAudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, key, config
                }
            );
        }

        public void decodeAudio(DecodeAudioConfig[] audioKey = null, ArrayBuffer audioData = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "decodeAudio" }, audioKey, audioData
                }
            );
        }

        public void @unlock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "@unlock" }
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

        public WebAudioSoundManager setMute(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSoundManager>(
                entity => new WebAudioSoundManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMute" }, value
                }
            );
        }

        public WebAudioSoundManager setVolume(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<WebAudioSoundManager>(
                entity => new WebAudioSoundManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVolume" }, value
                }
            );
        }
        #endregion
    }
}