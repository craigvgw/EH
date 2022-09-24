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

    
    
    [JsonConverter(typeof(CachedEntityConverter<HTML5AudioSound>))]
    public class HTML5AudioSound : BaseSound
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
        public HTML5AudioSound() : base() { }

        public HTML5AudioSound(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public HTML5AudioSound(
            HTML5AudioSoundManager manager, string key, SoundConfig config = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "HTML5AudioSound" },
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

        public HTML5AudioSound setMute(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMute" }, value
                }
            );
        }

        public HTML5AudioSound setVolume(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVolume" }, value
                }
            );
        }

        public HTML5AudioSound setRate(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRate" }, value
                }
            );
        }

        public HTML5AudioSound setDetune(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDetune" }, value
                }
            );
        }

        public HTML5AudioSound setSeek(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSeek" }, value
                }
            );
        }

        public HTML5AudioSound setLoop(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLoop" }, value
                }
            );
        }

        public HTML5AudioSound setPan(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPan" }, value
                }
            );
        }
        #endregion
    }
}