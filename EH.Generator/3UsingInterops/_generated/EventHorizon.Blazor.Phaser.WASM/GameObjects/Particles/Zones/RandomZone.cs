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

    
    
    [JsonConverter(typeof(CachedEntityConverter<RandomZone>))]
    public class RandomZone : CachedEntityObject
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
        private RandomZoneSource __source;
        public RandomZoneSource source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<RandomZoneSource>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new RandomZoneSource() { ___guid = entity.___guid };
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
        #endregion
        
        #region Constructor
        public RandomZone() : base() { }

        public RandomZone(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public RandomZone(
            RandomZoneSource source
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Particles", "Zones", "RandomZone" },
                source
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void getPoint(Particle particle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getPoint" }, particle
                }
            );
        }
        #endregion
    }
}