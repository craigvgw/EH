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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseSoundManager>))]
    public class BaseSoundManager : EventEmitter
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
        private Game __game;
        public Game game
        {
            get
            {
            if(__game == null)
            {
                __game = EventHorizonBlazorInterop.GetClass<Game>(
                    this.___guid,
                    "game",
                    (entity) =>
                    {
                        return new Game() { ___guid = entity.___guid };
                    }
                );
            }
            return __game;
            }
        }

        private BaseCache __jsonCache;
        public BaseCache jsonCache
        {
            get
            {
            if(__jsonCache == null)
            {
                __jsonCache = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "jsonCache",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __jsonCache;
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

        
        public bool pauseOnBlur
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pauseOnBlur"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pauseOnBlur",
                    value
                );
            }
        }

        
        public bool locked
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "locked"
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
        #endregion
        
        #region Constructor
        public BaseSoundManager() : base() { }

        public BaseSoundManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BaseSoundManager(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "BaseSoundManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public BaseSound add(string key, SoundConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseSound>(
                entity => new BaseSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, key, config
                }
            );
        }

        public HTML5AudioSound addAudioSprite(string key, SoundConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTML5AudioSound>(
                entity => new HTML5AudioSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAudioSprite" }, key, config
                }
            );
        }

        public BaseSound get(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseSound>(
                entity => new BaseSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, key
                }
            );
        }

        public BaseSound[] getAll(string key)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<BaseSound>(
                entity => new BaseSound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAll" }, key
                }
            );
        }

        public bool play(string key, SoundConfig extra = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "play" }, key, extra
                }
            );
        }

        public bool playAudioSprite(string key, string spriteName, SoundConfig config = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "playAudioSprite" }, key, spriteName, config
                }
            );
        }

        public bool remove(BaseSound sound)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, sound
                }
            );
        }

        public void removeAll()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeAll" }
                }
            );
        }

        public decimal removeByKey(string key)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeByKey" }, key
                }
            );
        }

        public void pauseAll()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pauseAll" }
                }
            );
        }

        public void resumeAll()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resumeAll" }
                }
            );
        }

        public void stopAll()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopAll" }
                }
            );
        }

        public decimal stopByKey(string key)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "stopByKey" }, key
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

        public BaseSoundManager setRate(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseSoundManager>(
                entity => new BaseSoundManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRate" }, value
                }
            );
        }

        public BaseSoundManager setDetune(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseSoundManager>(
                entity => new BaseSoundManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDetune" }, value
                }
            );
        }
        #endregion
    }
}