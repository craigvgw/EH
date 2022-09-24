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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TextStyle>))]
    public class TextStyle : CachedEntityObject
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
        private Text __parent;
        public Text parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<Text>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new Text() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
            }
            set
            {
__parent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        
        public string fontFamily
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontFamily"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontFamily",
                    value
                );
            }
        }

        
        public string fontSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontSize",
                    value
                );
            }
        }

        
        public string fontStyle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontStyle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontStyle",
                    value
                );
            }
        }

        
        public string backgroundColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "backgroundColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backgroundColor",
                    value
                );
            }
        }

        
        public string color
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public string stroke
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "stroke"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stroke",
                    value
                );
            }
        }

        
        public decimal strokeThickness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "strokeThickness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "strokeThickness",
                    value
                );
            }
        }

        
        public decimal shadowOffsetX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowOffsetX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowOffsetX",
                    value
                );
            }
        }

        
        public decimal shadowOffsetY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowOffsetY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowOffsetY",
                    value
                );
            }
        }

        
        public string shadowColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "shadowColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowColor",
                    value
                );
            }
        }

        
        public decimal shadowBlur
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowBlur"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowBlur",
                    value
                );
            }
        }

        
        public bool shadowStroke
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowStroke"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowStroke",
                    value
                );
            }
        }

        
        public bool shadowFill
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowFill"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowFill",
                    value
                );
            }
        }

        
        public string align
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "align"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "align",
                    value
                );
            }
        }

        
        public decimal maxLines
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLines"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxLines",
                    value
                );
            }
        }

        
        public decimal fixedWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fixedWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fixedWidth",
                    value
                );
            }
        }

        
        public decimal fixedHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fixedHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fixedHeight",
                    value
                );
            }
        }

        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolution",
                    value
                );
            }
        }

        
        public bool rtl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rtl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rtl",
                    value
                );
            }
        }

        
        public string testString
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "testString"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "testString",
                    value
                );
            }
        }

        
        public decimal baselineX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "baselineX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baselineX",
                    value
                );
            }
        }

        
        public decimal baselineY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "baselineY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baselineY",
                    value
                );
            }
        }

        
        public decimal wordWrapWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wordWrapWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wordWrapWidth",
                    value
                );
            }
        }

        
        public ActionCallback<string, Text> wordWrapCallback
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<string, Text>>(
                    this.___guid,
                    "wordWrapCallback"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wordWrapCallback",
                    value
                );
            }
        }

        
        public CachedEntity wordWrapCallbackScope
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "wordWrapCallbackScope"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wordWrapCallbackScope",
                    value
                );
            }
        }

        
        public bool wordWrapUseAdvanced
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "wordWrapUseAdvanced"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wordWrapUseAdvanced",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextStyle() : base() { }

        public TextStyle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TextStyle(
            Text text, TextStyle style
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "TextStyle" },
                text, style
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Text setStyle(TextStyle style, System.Nullable<bool> updateText = null, System.Nullable<bool> setDefaults = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setStyle" }, style, updateText, setDefaults
                }
            );
        }

        public void syncFont(HTMLCanvasElement canvas, CanvasRenderingContext2D context)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncFont" }, canvas, context
                }
            );
        }

        public void syncStyle(HTMLCanvasElement canvas, CanvasRenderingContext2D context)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncStyle" }, canvas, context
                }
            );
        }

        public void syncShadow(CanvasRenderingContext2D context, bool enabled)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncShadow" }, context, enabled
                }
            );
        }

        public Text update(bool recalculateMetrics)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }, recalculateMetrics
                }
            );
        }

        public Text setFont(string font, System.Nullable<bool> updateText = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFont" }, font, updateText
                }
            );
        }

        public Text setFontFamily(string family)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFontFamily" }, family
                }
            );
        }

        public Text setFontStyle(string style)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFontStyle" }, style
                }
            );
        }

        public Text setFontSize(decimal size)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFontSize" }, size
                }
            );
        }

        public Text setTestString(string @string)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTestString" }, @string
                }
            );
        }

        public Text setFixedSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFixedSize" }, width, height
                }
            );
        }

        public Text setBackgroundColor(string color)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBackgroundColor" }, color
                }
            );
        }

        public Text setFill(string color)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFill" }, color
                }
            );
        }

        public Text setColor(string color)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColor" }, color
                }
            );
        }

        public Text setResolution(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setResolution" }, value
                }
            );
        }

        public Text setStroke(string color, decimal thickness)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setStroke" }, color, thickness
                }
            );
        }

        public Text setShadow(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string color = null, System.Nullable<decimal> blur = null, System.Nullable<bool> shadowStroke = null, System.Nullable<bool> shadowFill = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadow" }, x, y, color, blur, shadowStroke, shadowFill
                }
            );
        }

        public Text setShadowOffset(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadowOffset" }, x, y
                }
            );
        }

        public Text setShadowColor(string color = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadowColor" }, color
                }
            );
        }

        public Text setShadowBlur(System.Nullable<decimal> blur = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadowBlur" }, blur
                }
            );
        }

        public Text setShadowStroke(bool enabled)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadowStroke" }, enabled
                }
            );
        }

        public Text setShadowFill(bool enabled)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadowFill" }, enabled
                }
            );
        }

        public Text setWordWrapWidth(decimal width, System.Nullable<bool> useAdvancedWrap = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setWordWrapWidth" }, width, useAdvancedWrap
                }
            );
        }

        public Text setWordWrapCallback(ActionCallback<string, Text> callback, object scope = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setWordWrapCallback" }, callback, scope
                }
            );
        }

        public Text setAlign(string align = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlign" }, align
                }
            );
        }

        public Text setMaxLines(System.Nullable<decimal> max = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaxLines" }, max
                }
            );
        }

        public TextMetrics getTextMetrics()
        {
            return EventHorizonBlazorInterop.FuncClass<TextMetrics>(
                entity => new TextMetrics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTextMetrics" }
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
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
        #endregion
    }
}