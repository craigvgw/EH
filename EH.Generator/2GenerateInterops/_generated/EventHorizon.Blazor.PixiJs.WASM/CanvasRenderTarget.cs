/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CanvasRenderTarget>))]
public class CanvasRenderTarget : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

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

        private CanvasRenderingContext2D __context;
        public CanvasRenderingContext2D context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<CanvasRenderingContext2D>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new CanvasRenderingContext2D() { ___guid = entity.___guid };
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
    
    #region Constructor
        public CanvasRenderTarget() : base() { }

        public CanvasRenderTarget(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public CanvasRenderTarget(
            decimal width, decimal height, System.Nullable<decimal> resolution = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CanvasRenderTarget" },
                width, height, resolution
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void resize(decimal desiredWidth, decimal desiredHeight)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, desiredWidth, desiredHeight
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
