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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NoAudioSoundManager>))]
    public class NoAudioSoundManager : BaseSoundManager
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
        public NoAudioSoundManager() : base() { }

        public NoAudioSoundManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public NoAudioSoundManager(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Sound", "NoAudioSoundManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}