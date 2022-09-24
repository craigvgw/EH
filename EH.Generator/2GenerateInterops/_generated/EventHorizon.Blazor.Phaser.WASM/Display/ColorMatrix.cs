/// Generated - Do Not Edit
namespace Phaser.Display
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ColorMatrix>))]
    public class ColorMatrix : CachedEntityObject
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
        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ColorMatrix() : base() { }

        public ColorMatrix(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public ColorMatrix set(decimal[] value)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, value
                }
            );
        }

        public ColorMatrix reset()
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public decimal[] getData()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getData" }
                }
            );
        }

        public ColorMatrix brightness(System.Nullable<decimal> value = null, System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "brightness" }, value, multiply
                }
            );
        }

        public ColorMatrix saturate(System.Nullable<decimal> value = null, System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saturate" }, value, multiply
                }
            );
        }

        public ColorMatrix saturation(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saturation" }, multiply
                }
            );
        }

        public ColorMatrix hue(System.Nullable<decimal> rotation = null, System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "hue" }, rotation, multiply
                }
            );
        }

        public ColorMatrix grayscale(System.Nullable<decimal> value = null, System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "grayscale" }, value, multiply
                }
            );
        }

        public ColorMatrix blackWhite(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "blackWhite" }, multiply
                }
            );
        }

        public ColorMatrix contrast(System.Nullable<decimal> value = null, System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "contrast" }, value, multiply
                }
            );
        }

        public ColorMatrix negative(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negative" }, multiply
                }
            );
        }

        public ColorMatrix desaturateLuminance(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "desaturateLuminance" }, multiply
                }
            );
        }

        public ColorMatrix sepia(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sepia" }, multiply
                }
            );
        }

        public ColorMatrix night(System.Nullable<decimal> intensity = null, System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "night" }, intensity, multiply
                }
            );
        }

        public ColorMatrix lsd(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lsd" }, multiply
                }
            );
        }

        public ColorMatrix brown(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "brown" }, multiply
                }
            );
        }

        public ColorMatrix vintagePinhole(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "vintagePinhole" }, multiply
                }
            );
        }

        public ColorMatrix kodachrome(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "kodachrome" }, multiply
                }
            );
        }

        public ColorMatrix technicolor(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "technicolor" }, multiply
                }
            );
        }

        public ColorMatrix polaroid(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "polaroid" }, multiply
                }
            );
        }

        public ColorMatrix shiftToBGR(System.Nullable<bool> multiply = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shiftToBGR" }, multiply
                }
            );
        }

        public ColorMatrix multiply(decimal[] a)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorMatrix>(
                entity => new ColorMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, a
                }
            );
        }
        #endregion
    }
}