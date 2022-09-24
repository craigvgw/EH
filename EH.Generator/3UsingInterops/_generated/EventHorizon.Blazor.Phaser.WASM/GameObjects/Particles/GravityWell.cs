/// Generated - Do Not Edit
namespace Phaser.GameObjects.Particles
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<GravityWell>))]
    public class GravityWell : CachedEntityObject
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
        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }

        
        public decimal power
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "power"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "power",
                    value
                );
            }
        }

        
        public decimal epsilon
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "epsilon"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "epsilon",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public GravityWell() : base() { }

        public GravityWell(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GravityWell(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> power = null, System.Nullable<decimal> epsilon = null, System.Nullable<decimal> gravity = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Particles", "GravityWell" },
                x, y, power, epsilon, gravity
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void update(Particle particle, decimal delta, decimal step)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, particle, delta, step
                }
            );
        }
        #endregion
    }
}