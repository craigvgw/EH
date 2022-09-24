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

    
    
    [JsonConverter(typeof(CachedEntityConverter<RopePipeline>))]
    public class RopePipeline : MultiPipeline
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
        public RopePipeline() : base() { }

        public RopePipeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RopePipeline(
            WebGLPipelineConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "Pipelines", "RopePipeline" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}