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

    
    
    [JsonConverter(typeof(CachedEntityConverter<EdgeZone>))]
    public class EdgeZone : CachedEntityObject
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
        private EdgeZoneSource __source;
        public EdgeZoneSource source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<EdgeZoneSource>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new EdgeZoneSource() { ___guid = entity.___guid };
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

        
        public Point[] points
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Point>(
                    this.___guid,
                    "points",
                    (entity) =>
                    {
                        return new Point() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "points",
                    value
                );
            }
        }

        
        public decimal quantity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "quantity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "quantity",
                    value
                );
            }
        }

        
        public decimal stepRate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stepRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stepRate",
                    value
                );
            }
        }

        
        public bool yoyo
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "yoyo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "yoyo",
                    value
                );
            }
        }

        
        public decimal counter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "counter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "counter",
                    value
                );
            }
        }

        
        public bool seamless
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "seamless"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "seamless",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public EdgeZone() : base() { }

        public EdgeZone(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public EdgeZone(
            EdgeZoneSource source, decimal quantity, decimal stepRate, System.Nullable<bool> yoyo = null, System.Nullable<bool> seamless = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Particles", "Zones", "EdgeZone" },
                source, quantity, stepRate, yoyo, seamless
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public EdgeZone updateSource()
        {
            return EventHorizonBlazorInterop.FuncClass<EdgeZone>(
                entity => new EdgeZone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateSource" }
                }
            );
        }

        public EdgeZone changeSource(EdgeZoneSource source)
        {
            return EventHorizonBlazorInterop.FuncClass<EdgeZone>(
                entity => new EdgeZone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "changeSource" }, source
                }
            );
        }

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