/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGL1Renderer>))]
public class WebGL1Renderer : WebGLRenderer
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
        
        public unknown isWebGL1Renderer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isWebGL1Renderer"
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGL1Renderer() : base() { }

        public WebGL1Renderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGL1Renderer(
            WebGLRendererParameters parameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGL1Renderer" },
                parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
