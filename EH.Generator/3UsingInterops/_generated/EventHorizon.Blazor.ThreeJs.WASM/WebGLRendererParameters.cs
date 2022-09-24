/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WebGLRendererParameters : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WebGLRendererParametersCachedEntity>))]
public class WebGLRendererParametersCachedEntity : CachedEntityObject, WebGLRendererParameters
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

        private WebGLRenderingContext __context;
        public WebGLRenderingContext context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<WebGLRenderingContext>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new WebGLRenderingContext() { ___guid = entity.___guid };
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

        
        public string precision
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "precision"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "precision",
                    value
                );
            }
        }

        
        public bool alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
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

        
        public bool premultipliedAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "premultipliedAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "premultipliedAlpha",
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

        
        public bool stencil
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stencil"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencil",
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

        
        public string powerPreference
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "powerPreference"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "powerPreference",
                    value
                );
            }
        }

        
        public bool depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        
        public bool logarithmicDepthBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "logarithmicDepthBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "logarithmicDepthBuffer",
                    value
                );
            }
        }

        
        public bool failIfMajorPerformanceCaveat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "failIfMajorPerformanceCaveat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "failIfMajorPerformanceCaveat",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLRendererParametersCachedEntity() : base() { }

        public WebGLRendererParametersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
