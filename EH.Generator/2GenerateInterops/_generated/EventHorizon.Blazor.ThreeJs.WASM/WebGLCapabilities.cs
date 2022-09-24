/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLCapabilities>))]
public class WebGLCapabilities : CachedEntityObject
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
        
        public bool isWebGL2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isWebGL2"
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

        
        public decimal maxTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxTextures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxTextures",
                    value
                );
            }
        }

        
        public decimal maxVertexTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxVertexTextures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxVertexTextures",
                    value
                );
            }
        }

        
        public decimal maxTextureSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxTextureSize",
                    value
                );
            }
        }

        
        public decimal maxCubemapSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxCubemapSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxCubemapSize",
                    value
                );
            }
        }

        
        public decimal maxAttributes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxAttributes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxAttributes",
                    value
                );
            }
        }

        
        public decimal maxVertexUniforms
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxVertexUniforms"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxVertexUniforms",
                    value
                );
            }
        }

        
        public decimal maxVaryings
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxVaryings"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxVaryings",
                    value
                );
            }
        }

        
        public decimal maxFragmentUniforms
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxFragmentUniforms"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxFragmentUniforms",
                    value
                );
            }
        }

        
        public bool vertexTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "vertexTextures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexTextures",
                    value
                );
            }
        }

        
        public bool floatFragmentTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "floatFragmentTextures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "floatFragmentTextures",
                    value
                );
            }
        }

        
        public bool floatVertexTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "floatVertexTextures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "floatVertexTextures",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLCapabilities() : base() { }

        public WebGLCapabilities(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLCapabilities(
            WebGLRenderingContext gl, object extensions, WebGLCapabilitiesParameters parameters
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLCapabilities" },
                gl, extensions, parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public decimal getMaxAnisotropy()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxAnisotropy" }
                }
            );
        }

        public string getMaxPrecision(string precision)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxPrecision" }, precision
                }
            );
        }
    #endregion
}
