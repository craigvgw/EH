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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Color>))]
    public class Color : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static ColorObject[] ColorSpectrum(System.Nullable<decimal> limit = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ColorObject>(
                entity => new ColorObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "ColorSpectrum" }, limit
                }
            );
        }

        public static ColorObject ColorToRGBA(decimal color)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorObject>(
                entity => new ColorObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "ColorToRGBA" }, color
                }
            );
        }

        public static string ComponentToHex(decimal color)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "ComponentToHex" }, color
                }
            );
        }

        public static decimal GetColor(decimal red, decimal green, decimal blue)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "GetColor" }, red, green, blue
                }
            );
        }

        public static decimal GetColor32(decimal red, decimal green, decimal blue, decimal alpha)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "GetColor32" }, red, green, blue, alpha
                }
            );
        }

        public static Color HexStringToColor(string hex)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "HexStringToColor" }, hex
                }
            );
        }

        public static Color HSLToColor(decimal h, decimal s, decimal l)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "HSLToColor" }, h, s, l
                }
            );
        }

        public static ColorObject[] HSVColorWheel(System.Nullable<decimal> s = null, System.Nullable<decimal> v = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ColorObject>(
                entity => new ColorObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "HSVColorWheel" }, s, v
                }
            );
        }

        public static ColorObject HSVToRGB(decimal h, decimal s, decimal v, ColorObject out = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorObject>(
                entity => new ColorObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "HSVToRGB" }, h, s, v, out
                }
            );
        }

        public static decimal HueToComponent(decimal p, decimal q, decimal t)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "HueToComponent" }, p, q, t
                }
            );
        }

        public static Color IntegerToColor(decimal input)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "IntegerToColor" }, input
                }
            );
        }

        public static ColorObject IntegerToRGB(decimal input)
        {
            return EventHorizonBlazorInterop.FuncClass<ColorObject>(
                entity => new ColorObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "IntegerToRGB" }, input
                }
            );
        }

        public static Color ObjectToColor(InputColorObject input)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "ObjectToColor" }, input
                }
            );
        }

        public static Color RandomRGB(System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "RandomRGB" }, min, max
                }
            );
        }

        public static Color RGBStringToColor(string rgb)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "RGBStringToColor" }, rgb
                }
            );
        }

        public static HSVColorObject RGBToHSV(decimal r, decimal g, decimal b, HSVColorObject out = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HSVColorObject>(
                entity => new HSVColorObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "RGBToHSV" }, r, g, b, out
                }
            );
        }

        public static string RGBToString(decimal r, decimal g, decimal b, System.Nullable<decimal> a = null, string prefix = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "RGBToString" }, r, g, b, a, prefix
                }
            );
        }

        public static Color ValueToColor(string input)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Display", "Color", "ValueToColor" }, input
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal[] gl
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "gl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gl",
                    value
                );
            }
        }

        
        public decimal color
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "color"
                );
            }
        }

        
        public decimal color32
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "color32"
                );
            }
        }

        
        public string rgba
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "rgba"
                );
            }
        }

        
        public decimal redGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "redGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "redGL",
                    value
                );
            }
        }

        
        public decimal greenGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "greenGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "greenGL",
                    value
                );
            }
        }

        
        public decimal blueGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blueGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blueGL",
                    value
                );
            }
        }

        
        public decimal alphaGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaGL",
                    value
                );
            }
        }

        
        public decimal red
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "red"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "red",
                    value
                );
            }
        }

        
        public decimal green
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "green"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "green",
                    value
                );
            }
        }

        
        public decimal blue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blue",
                    value
                );
            }
        }

        
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

        
        public decimal h
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "h"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "h",
                    value
                );
            }
        }

        
        public decimal s
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "s"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "s",
                    value
                );
            }
        }

        
        public decimal v
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "v"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v",
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
            System.Nullable<decimal> red = null, System.Nullable<decimal> green = null, System.Nullable<decimal> blue = null, System.Nullable<decimal> alpha = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Display", "Color" },
                red, green, blue, alpha
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Color transparent()
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transparent" }
                }
            );
        }

        public Color setTo(decimal red, decimal green, decimal blue, System.Nullable<decimal> alpha = null, System.Nullable<bool> updateHSV = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTo" }, red, green, blue, alpha, updateHSV
                }
            );
        }

        public Color setGLTo(decimal red, decimal green, decimal blue, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGLTo" }, red, green, blue, alpha
                }
            );
        }

        public Color setFromRGB(InputColorObject color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromRGB" }, color
                }
            );
        }

        public Color setFromHSV(decimal h, decimal s, decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromHSV" }, h, s, v
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

        public Color gray(decimal shade)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "gray" }, shade
                }
            );
        }

        public Color random(System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "random" }, min, max
                }
            );
        }

        public Color randomGray(System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "randomGray" }, min, max
                }
            );
        }

        public Color saturate(decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saturate" }, amount
                }
            );
        }

        public Color desaturate(decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "desaturate" }, amount
                }
            );
        }

        public Color lighten(decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lighten" }, amount
                }
            );
        }

        public Color darken(decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "darken" }, amount
                }
            );
        }

        public Color brighten(decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "brighten" }, amount
                }
            );
        }
        #endregion
    }
}