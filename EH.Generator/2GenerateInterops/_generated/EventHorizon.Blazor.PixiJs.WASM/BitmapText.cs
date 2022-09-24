/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BitmapText>))]
public class BitmapText : Container
{
    #region Static Accessors

    #endregion

    #region Static Properties
        private static IBitmapTextStyleCachedEntity __styleDefaults;
        public static IBitmapTextStyleCachedEntity styleDefaults
        {
            get
            {
            if(__styleDefaults == null)
            {
                __styleDefaults = EventHorizonBlazorInterop.GetClass<IBitmapTextStyleCachedEntity>(
                    "BitmapText",
                    "styleDefaults",
                    (entity) =>
                    {
                        return new IBitmapTextStyleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __styleDefaults;
            }
            set
            {
__styleDefaults = null;
                EventHorizonBlazorInterop.Set(
                    "BitmapText",
                    "styleDefaults",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        
        public unknown align
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
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

        
        public string fontName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontName",
                    value
                );
            }
        }

        
        public decimal fontSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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

        private ObservablePoint __anchor;
        public ObservablePoint anchor
        {
            get
            {
            if(__anchor == null)
            {
                __anchor = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "anchor",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __anchor;
            }
            set
            {
__anchor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anchor",
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

        
        public decimal maxWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxWidth",
                    value
                );
            }
        }

        
        public decimal maxLineHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLineHeight"
                );
            }
        }

        
        public decimal textWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textWidth"
                );
            }
        }

        
        public decimal letterSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "letterSpacing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "letterSpacing",
                    value
                );
            }
        }

        
        public bool roundPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "roundPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roundPixels",
                    value
                );
            }
        }

        
        public decimal textHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textHeight"
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
        public BitmapText() : base() { }

        public BitmapText(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BitmapText(
            string text, IBitmapTextStyle style = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BitmapText" },
                text, style
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void updateText()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateText" }
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

        public Rectangle getLocalBounds()
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalBounds" }
                }
            );
        }

        public void destroy(System.Nullable<bool> options = null)
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
