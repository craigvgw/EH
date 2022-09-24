/// Generated - Do Not Edit
namespace Phaser.GameObjects.Particles.Zones
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<DeathZone>))]
    public class DeathZone : CachedEntityObject
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
        private DeathZoneSource __source;
        public DeathZoneSource source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<DeathZoneSource>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new DeathZoneSource() { ___guid = entity.___guid };
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

        
        public bool killOnEnter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "killOnEnter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "killOnEnter",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public DeathZone() : base() { }

        public DeathZone(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public DeathZone(
            DeathZoneSource source, bool killOnEnter
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Particles", "Zones", "DeathZone" },
                source, killOnEnter
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool willKill(Particle particle)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "willKill" }, particle
                }
            );
        }
        #endregion
    }
}