/// Generated - Do Not Edit
namespace Phaser.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Light>))]
    public class Light : Circle, IScrollFactor, IVisible
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal RENDER_MASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Phaser",
                    "GameObjects.Light.RENDER_MASK"
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private RGB __color;
        public RGB color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<RGB>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new RGB() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal intensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intensity",
                    value
                );
            }
        }

        
        public decimal scrollFactorX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorX",
                    value
                );
            }
        }

        
        public decimal scrollFactorY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorY",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Light() : base() { }

        public Light(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Light(
            decimal x, decimal y, decimal radius, decimal r, decimal g, decimal b, decimal intensity
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Light" },
                x, y, radius, r, g, b, intensity
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool willRender(Camera camera)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "willRender" }, camera
                }
            );
        }

        public Light setColor(decimal rgb)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColor" }, rgb
                }
            );
        }

        public Light setIntensity(decimal intensity)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIntensity" }, intensity
                }
            );
        }

        public Light setRadius(decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRadius" }, radius
                }
            );
        }

        public Light setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public Light setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}