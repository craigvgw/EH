/// Generated - Do Not Edit
namespace Phaser.Renderer.WebGL.Pipelines
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<PointLightPipeline>))]
    public class PointLightPipeline : WebGLPipeline
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

        #endregion
        
        #region Constructor
        public PointLightPipeline() : base() { }

        public PointLightPipeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PointLightPipeline(
            WebGLPipelineConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "Pipelines", "PointLightPipeline" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void batchPointLight(PointLight light, Camera camera, decimal x0, decimal y0, decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3, decimal lightX, decimal lightY)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchPointLight" }, light, camera, x0, y0, x1, y1, x2, y2, x3, y3, lightX, lightY
                }
            );
        }

        public void batchLightVert(decimal x, decimal y, decimal lightX, decimal lightY, decimal radius, decimal attenuation, decimal r, decimal g, decimal b, decimal a)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchLightVert" }, x, y, lightX, lightY, radius, attenuation, r, g, b, a
                }
            );
        }
        #endregion
    }
}