/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TextMetrics_2>))]
public class TextMetrics_2 : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static string METRICS_STRING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "TextMetrics_2",
                    "METRICS_STRING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "TextMetrics_2",
                    "METRICS_STRING",
                    value
                );
            }
        }

        
        public static string BASELINE_SYMBOL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "TextMetrics_2",
                    "BASELINE_SYMBOL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "TextMetrics_2",
                    "BASELINE_SYMBOL",
                    value
                );
            }
        }

        
        public static decimal BASELINE_MULTIPLIER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "TextMetrics_2",
                    "BASELINE_MULTIPLIER"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "TextMetrics_2",
                    "BASELINE_MULTIPLIER",
                    value
                );
            }
        }

        
        public static decimal HEIGHT_MULTIPLIER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "TextMetrics_2",
                    "HEIGHT_MULTIPLIER"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "TextMetrics_2",
                    "HEIGHT_MULTIPLIER",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static TextMetrics_2 measureText(string text, TextStyle style, System.Nullable<bool> wordWrap = null, HTMLCanvasElement canvas = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TextMetrics_2>(
                entity => new TextMetrics_2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "TextMetrics_2", "measureText" }, text, style, wordWrap, canvas
                }
            );
        }

        public static bool isBreakingSpace(string char, string _nextChar = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "TextMetrics_2", "isBreakingSpace" }, char, _nextChar
                }
            );
        }

        public static bool canBreakWords(string _token, bool breakWords)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "TextMetrics_2", "canBreakWords" }, _token, breakWords
                }
            );
        }

        public static bool canBreakChars(string _char, string _nextChar, string _token, decimal _index, bool _breakWords)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "TextMetrics_2", "canBreakChars" }, _char, _nextChar, _token, _index, _breakWords
                }
            );
        }

        public static string[] wordWrapSplit(string token)
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { "TextMetrics_2", "wordWrapSplit" }, token
                }
            );
        }

        public static IFontMetricsCachedEntity measureFont(string font)
        {
            return EventHorizonBlazorInterop.FuncClass<IFontMetricsCachedEntity>(
                entity => new IFontMetricsCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "TextMetrics_2", "measureFont" }, font
                }
            );
        }

        public static void clearMetrics(string font = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "TextMetrics_2", "clearMetrics" }, font
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string text
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "text"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "text",
                    value
                );
            }
        }

        private TextStyle __style;
        public TextStyle style
        {
            get
            {
            if(__style == null)
            {
                __style = EventHorizonBlazorInterop.GetClass<TextStyle>(
                    this.___guid,
                    "style",
                    (entity) =>
                    {
                        return new TextStyle() { ___guid = entity.___guid };
                    }
                );
            }
            return __style;
            }
            set
            {
__style = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "style",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public string[] lines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "lines"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lines",
                    value
                );
            }
        }

        
        public decimal[] lineWidths
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "lineWidths"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineWidths",
                    value
                );
            }
        }

        
        public decimal lineHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineHeight",
                    value
                );
            }
        }

        
        public decimal maxLineWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLineWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxLineWidth",
                    value
                );
            }
        }

        private IFontMetricsCachedEntity __fontProperties;
        public IFontMetricsCachedEntity fontProperties
        {
            get
            {
            if(__fontProperties == null)
            {
                __fontProperties = EventHorizonBlazorInterop.GetClass<IFontMetricsCachedEntity>(
                    this.___guid,
                    "fontProperties",
                    (entity) =>
                    {
                        return new IFontMetricsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __fontProperties;
            }
            set
            {
__fontProperties = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontProperties",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public TextMetrics_2() : base() { }

        public TextMetrics_2(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TextMetrics_2(
            string text, TextStyle style, decimal width, decimal height, string[] lines, decimal[] lineWidths, decimal lineHeight, decimal maxLineWidth, IFontMetrics fontProperties
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TextMetrics_2" },
                text, style, width, height, lines, lineWidths, lineHeight, maxLineWidth, fontProperties
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
