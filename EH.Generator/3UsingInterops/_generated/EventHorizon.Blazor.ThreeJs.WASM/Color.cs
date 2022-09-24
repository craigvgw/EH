/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Color>))]
public class Color : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
// NAMES is not supported by the platform yet
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public unknown isColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isColor"
                );
            }
        }

        
        public decimal r
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "r"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "r",
                    value
                );
            }
        }

        
        public decimal g
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "g"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "g",
                    value
                );
            }
        }

        
        public decimal b
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Color() : base() { }

        public Color(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Color(
            Color color = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Color" },
                color
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Color set(Color color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, color
                }
            );
        }

        public Color setScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScalar" }, scalar
                }
            );
        }

        public Color setHex(decimal hex, System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHex" }, hex, colorSpace
                }
            );
        }

        public Color setRGB(decimal r, decimal g, decimal b, System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRGB" }, r, g, b, colorSpace
                }
            );
        }

        public Color setHSL(decimal h, decimal s, decimal l, System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHSL" }, h, s, l, colorSpace
                }
            );
        }

        public Color setStyle(string style, System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setStyle" }, style, colorSpace
                }
            );
        }

        public Color setColorName(string style, System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColorName" }, style, colorSpace
                }
            );
        }

        public Color clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Color copy(Color color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, color
                }
            );
        }

        public Color copySRGBToLinear(Color color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copySRGBToLinear" }, color
                }
            );
        }

        public Color copyLinearToSRGB(Color color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyLinearToSRGB" }, color
                }
            );
        }

        public Color convertSRGBToLinear()
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "convertSRGBToLinear" }
                }
            );
        }

        public Color convertLinearToSRGB()
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "convertLinearToSRGB" }
                }
            );
        }

        public decimal getHex(System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHex" }, colorSpace
                }
            );
        }

        public string getHexString(System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getHexString" }, colorSpace
                }
            );
        }

        public HSLCachedEntity getHSL(HSL target, System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HSLCachedEntity>(
                entity => new HSLCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getHSL" }, target, colorSpace
                }
            );
        }

        public RGBCachedEntity getRGB(RGB target, System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RGBCachedEntity>(
                entity => new RGBCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRGB" }, target, colorSpace
                }
            );
        }

        public string getStyle(System.Nullable<NoColorSpace> colorSpace = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getStyle" }, colorSpace
                }
            );
        }

        public Color offsetHSL(decimal h, decimal s, decimal l)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "offsetHSL" }, h, s, l
                }
            );
        }

        public Color add(Color color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, color
                }
            );
        }

        public Color addColors(Color color1, Color color2)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addColors" }, color1, color2
                }
            );
        }

        public Color addScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScalar" }, s
                }
            );
        }

        public Color sub(Color color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sub" }, color
                }
            );
        }

        public Color multiply(Color color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, color
                }
            );
        }

        public Color multiplyScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyScalar" }, s
                }
            );
        }

        public Color lerp(Color color, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerp" }, color, alpha
                }
            );
        }

        public Color lerpColors(Color color1, Color color2, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerpColors" }, color1, color2, alpha
                }
            );
        }

        public Color lerpHSL(Color color, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerpHSL" }, color, alpha
                }
            );
        }

        public bool equals(Color color)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, color
                }
            );
        }

        public Color fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, array, offset
                }
            );
        }

        public decimal[] toArray(decimal[] array = null, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toArray" }, array, offset
                }
            );
        }

        public Color fromBufferAttribute(BufferAttribute attribute, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromBufferAttribute" }, attribute, index
                }
            );
        }
    #endregion
}
