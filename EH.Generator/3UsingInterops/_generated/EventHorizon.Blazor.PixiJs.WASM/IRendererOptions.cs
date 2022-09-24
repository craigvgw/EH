/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IRendererOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IRendererOptionsCachedEntity>))]
public class IRendererOptionsCachedEntity : CachedEntityObject, IRendererOptions
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

        private HTMLCanvasElement __view;
        public HTMLCanvasElement view
        {
            get
            {
            if(__view == null)
            {
                __view = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "view",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __view;
            }
            set
            {
__view = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "view",
                    value
                );
            }
        }

        
        public bool useContextAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useContextAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useContextAlpha",
                    value
                );
            }
        }

        
        public bool transparent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "transparent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transparent",
                    value
                );
            }
        }

        
        public bool autoDensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoDensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoDensity",
                    value
                );
            }
        }

        
        public bool antialias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "antialias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "antialias",
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

        
        public bool preserveDrawingBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preserveDrawingBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preserveDrawingBuffer",
                    value
                );
            }
        }

        
        public bool clearBeforeRender
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clearBeforeRender"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearBeforeRender",
                    value
                );
            }
        }

        
        public decimal backgroundColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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

        
        public decimal backgroundAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "backgroundAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backgroundAlpha",
                    value
                );
            }
        }

        private WebGLPowerPreference __powerPreference;
        public WebGLPowerPreference powerPreference
        {
            get
            {
            if(__powerPreference == null)
            {
                __powerPreference = EventHorizonBlazorInterop.GetClass<WebGLPowerPreference>(
                    this.___guid,
                    "powerPreference",
                    (entity) =>
                    {
                        return new WebGLPowerPreference() { ___guid = entity.___guid };
                    }
                );
            }
            return __powerPreference;
            }
            set
            {
__powerPreference = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "powerPreference",
                    value
                );
            }
        }

        private IRenderingContextCachedEntity __context;
        public IRenderingContextCachedEntity context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<IRenderingContextCachedEntity>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new IRenderingContextCachedEntity() { ___guid = entity.___guid };
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
    #endregion
    
    #region Constructor
        public IRendererOptionsCachedEntity() : base() { }

        public IRendererOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
