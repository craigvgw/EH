/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Text_2>))]
public class Text_2 : Sprite
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static bool nextLineHeightBehavior
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "Text_2",
                    "nextLineHeightBehavior"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Text_2",
                    "nextLineHeightBehavior",
                    value
                );
            }
        }

        
        public static bool experimentalLetterSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "Text_2",
                    "experimentalLetterSpacing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Text_2",
                    "experimentalLetterSpacing",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
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
    #endregion

    #region Properties
        private HTMLCanvasElement __canvas;
        public HTMLCanvasElement canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
            set
            {
__canvas = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvas",
                    value
                );
            }
        }

        private ModernContext2DCachedEntity __context;
        public ModernContext2DCachedEntity context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<ModernContext2DCachedEntity>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new ModernContext2DCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __context;
            }
            set
            {
__context = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "context",
                    value
                );
            }
        }

        
        public decimal localStyleID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "localStyleID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "localStyleID",
                    value
                );
            }
        }

        
        public bool dirty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dirty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirty",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Text_2() : base() { }

        public Text_2(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Text_2(
            string text = null, ITextStyle style = null, HTMLCanvasElement canvas = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Text_2" },
                text, style, canvas
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void updateText(bool respectDirty)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateText" }, respectDirty
                }
            );
        }

        public void updateTransform()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTransform" }
                }
            );
        }

        public Rectangle getBounds(System.Nullable<bool> skipUpdate = null, Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, skipUpdate, rect
                }
            );
        }

        public Rectangle getLocalBounds(Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalBounds" }, rect
                }
            );
        }

        public void destroy(IDestroyOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, options
                }
            );
        }
    #endregion
}
