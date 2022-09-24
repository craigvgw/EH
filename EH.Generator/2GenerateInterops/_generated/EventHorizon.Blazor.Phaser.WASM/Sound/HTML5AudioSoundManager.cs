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

    
    
    [JsonConverter(typeof(CachedEntityConverter<HTML5AudioSoundManager>))]
    public class HTML5AudioSoundManager : BaseSoundManager
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
        
        public bool override
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "override"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "override",
                    value
                );
            }
        }

        
        public decimal audioPlayDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "audioPlayDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "audioPlayDelay",
                    value
                );
            }
        }

        
        public decimal loopEndOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopEndOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopEndOffset",
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
        public HTML5AudioSoundManager() : base() { }

        public HTML5AudioSoundManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public HTML5AudioSoundManager(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "HTML5AudioSoundManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public HTML5AudioSound add(string key, SoundConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, key, config
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

        public HTML5AudioSoundManager setMute(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSoundManager>(
                entity => new HTML5AudioSoundManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMute" }, value
                }
            );
        }

        public HTML5AudioSoundManager setVolume(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSoundManager>(
                entity => new HTML5AudioSoundManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVolume" }, value
                }
            );
        }
        #endregion
    }
}