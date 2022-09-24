/// Generated - Do Not Edit
namespace Phaser.Renderer.WebGL
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<PipelineManager>))]
    public class PipelineManager : CachedEntityObject
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
        private Game __game;
        public Game game
        {
            get
            {
            if(__game == null)
            {
                __game = EventHorizonBlazorInterop.GetClass<Game>(
                    this.___guid,
                    "game",
                    (entity) =>
                    {
                        return new Game() { ___guid = entity.___guid };
                    }
                );
            }
            return __game;
            }
            set
            {
__game = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "game",
                    value
                );
            }
        }

        private WebGLRenderer __renderer;
        public WebGLRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<WebGLRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new WebGLRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderer;
            }
            set
            {
__renderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderer",
                    value
                );
            }
        }

// classes is not supported by the platform yet

// postPipelineClasses is not supported by the platform yet

// pipelines is not supported by the platform yet

        private WebGLPipeline __current;
        public WebGLPipeline current
        {
            get
            {
            if(__current == null)
            {
                __current = EventHorizonBlazorInterop.GetClass<WebGLPipeline>(
                    this.___guid,
                    "current",
                    (entity) =>
                    {
                        return new WebGLPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __current;
            }
            set
            {
__current = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "current",
                    value
                );
            }
        }

        private WebGLPipeline __previous;
        public WebGLPipeline previous
        {
            get
            {
            if(__previous == null)
            {
                __previous = EventHorizonBlazorInterop.GetClass<WebGLPipeline>(
                    this.___guid,
                    "previous",
                    (entity) =>
                    {
                        return new WebGLPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __previous;
            }
            set
            {
__previous = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "previous",
                    value
                );
            }
        }

        private MultiPipeline __MULTI_PIPELINE;
        public MultiPipeline MULTI_PIPELINE
        {
            get
            {
            if(__MULTI_PIPELINE == null)
            {
                __MULTI_PIPELINE = EventHorizonBlazorInterop.GetClass<MultiPipeline>(
                    this.___guid,
                    "MULTI_PIPELINE",
                    (entity) =>
                    {
                        return new MultiPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __MULTI_PIPELINE;
            }
            set
            {
__MULTI_PIPELINE = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MULTI_PIPELINE",
                    value
                );
            }
        }

        private BitmapMaskPipeline __BITMAPMASK_PIPELINE;
        public BitmapMaskPipeline BITMAPMASK_PIPELINE
        {
            get
            {
            if(__BITMAPMASK_PIPELINE == null)
            {
                __BITMAPMASK_PIPELINE = EventHorizonBlazorInterop.GetClass<BitmapMaskPipeline>(
                    this.___guid,
                    "BITMAPMASK_PIPELINE",
                    (entity) =>
                    {
                        return new BitmapMaskPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __BITMAPMASK_PIPELINE;
            }
            set
            {
__BITMAPMASK_PIPELINE = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BITMAPMASK_PIPELINE",
                    value
                );
            }
        }

        private UtilityPipeline __UTILITY_PIPELINE;
        public UtilityPipeline UTILITY_PIPELINE
        {
            get
            {
            if(__UTILITY_PIPELINE == null)
            {
                __UTILITY_PIPELINE = EventHorizonBlazorInterop.GetClass<UtilityPipeline>(
                    this.___guid,
                    "UTILITY_PIPELINE",
                    (entity) =>
                    {
                        return new UtilityPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __UTILITY_PIPELINE;
            }
            set
            {
__UTILITY_PIPELINE = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UTILITY_PIPELINE",
                    value
                );
            }
        }

        private RenderTarget __fullFrame1;
        public RenderTarget fullFrame1
        {
            get
            {
            if(__fullFrame1 == null)
            {
                __fullFrame1 = EventHorizonBlazorInterop.GetClass<RenderTarget>(
                    this.___guid,
                    "fullFrame1",
                    (entity) =>
                    {
                        return new RenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __fullFrame1;
            }
            set
            {
__fullFrame1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fullFrame1",
                    value
                );
            }
        }

        private RenderTarget __fullFrame2;
        public RenderTarget fullFrame2
        {
            get
            {
            if(__fullFrame2 == null)
            {
                __fullFrame2 = EventHorizonBlazorInterop.GetClass<RenderTarget>(
                    this.___guid,
                    "fullFrame2",
                    (entity) =>
                    {
                        return new RenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __fullFrame2;
            }
            set
            {
__fullFrame2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fullFrame2",
                    value
                );
            }
        }

        private RenderTarget __halfFrame1;
        public RenderTarget halfFrame1
        {
            get
            {
            if(__halfFrame1 == null)
            {
                __halfFrame1 = EventHorizonBlazorInterop.GetClass<RenderTarget>(
                    this.___guid,
                    "halfFrame1",
                    (entity) =>
                    {
                        return new RenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __halfFrame1;
            }
            set
            {
__halfFrame1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "halfFrame1",
                    value
                );
            }
        }

        private RenderTarget __halfFrame2;
        public RenderTarget halfFrame2
        {
            get
            {
            if(__halfFrame2 == null)
            {
                __halfFrame2 = EventHorizonBlazorInterop.GetClass<RenderTarget>(
                    this.___guid,
                    "halfFrame2",
                    (entity) =>
                    {
                        return new RenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __halfFrame2;
            }
            set
            {
__halfFrame2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "halfFrame2",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PipelineManager() : base() { }

        public PipelineManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PipelineManager(
            WebGLRenderer renderer
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "PipelineManager" },
                renderer
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void boot(PipelineConfig pipelineConfig = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "boot" }, pipelineConfig
                }
            );
        }

        public WebGLPipeline add(string name, WebGLPipeline pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, name, pipeline
                }
            );
        }

        public void flush()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flush" }
                }
            );
        }

        public bool has(string pipeline)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "has" }, pipeline
                }
            );
        }

        public WebGLPipeline get(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, pipeline
                }
            );
        }

        public PostFXPipeline getPostPipeline(string pipeline, GameObject gameObject = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PostFXPipeline>(
                entity => new PostFXPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPostPipeline" }, pipeline, gameObject
                }
            );
        }

        public void remove(string name, System.Nullable<bool> removeClass = null, System.Nullable<bool> removePostPipelineClass = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, name, removeClass, removePostPipelineClass
                }
            );
        }

        public WebGLPipeline set(WebGLPipeline pipeline, GameObject gameObject = null, WebGLShader currentShader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, pipeline, gameObject, currentShader
                }
            );
        }

        public void preBatch(GameObject gameObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preBatch" }, gameObject
                }
            );
        }

        public void postBatch(GameObject gameObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postBatch" }, gameObject
                }
            );
        }

        public void preBatchCamera(Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preBatchCamera" }, camera
                }
            );
        }

        public void postBatchCamera(Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postBatchCamera" }, camera
                }
            );
        }

        public bool isCurrent(WebGLPipeline pipeline, WebGLShader currentShader = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isCurrent" }, pipeline, currentShader
                }
            );
        }

        public PipelineManager copyFrame(RenderTarget source, RenderTarget target = null, System.Nullable<decimal> brightness = null, System.Nullable<bool> clear = null, System.Nullable<bool> clearAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PipelineManager>(
                entity => new PipelineManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrame" }, source, target, brightness, clear, clearAlpha
                }
            );
        }

        public void copyToGame(RenderTarget source)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyToGame" }, source
                }
            );
        }

        public PipelineManager drawFrame(RenderTarget source, RenderTarget target = null, System.Nullable<bool> clearAlpha = null, ColorMatrix colorMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PipelineManager>(
                entity => new PipelineManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawFrame" }, source, target, clearAlpha, colorMatrix
                }
            );
        }

        public PipelineManager blendFrames(RenderTarget source1, RenderTarget source2, RenderTarget target = null, System.Nullable<decimal> strength = null, System.Nullable<bool> clearAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PipelineManager>(
                entity => new PipelineManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "blendFrames" }, source1, source2, target, strength, clearAlpha
                }
            );
        }

        public PipelineManager blendFramesAdditive(RenderTarget source1, RenderTarget source2, RenderTarget target = null, System.Nullable<decimal> strength = null, System.Nullable<bool> clearAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PipelineManager>(
                entity => new PipelineManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "blendFramesAdditive" }, source1, source2, target, strength, clearAlpha
                }
            );
        }

        public PipelineManager clearFrame(RenderTarget target, System.Nullable<bool> clearAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PipelineManager>(
                entity => new PipelineManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearFrame" }, target, clearAlpha
                }
            );
        }

        public PipelineManager blitFrame(RenderTarget source, RenderTarget target, System.Nullable<decimal> brightness = null, System.Nullable<bool> clear = null, System.Nullable<bool> clearAlpha = null, System.Nullable<bool> eraseMode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PipelineManager>(
                entity => new PipelineManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "blitFrame" }, source, target, brightness, clear, clearAlpha, eraseMode
                }
            );
        }

        public PipelineManager copyFrameRect(RenderTarget source, RenderTarget target, decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> clear = null, System.Nullable<bool> clearAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PipelineManager>(
                entity => new PipelineManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrameRect" }, source, target, x, y, width, height, clear, clearAlpha
                }
            );
        }

        public bool forceZero()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "forceZero" }
                }
            );
        }

        public MultiPipeline setMulti()
        {
            return EventHorizonBlazorInterop.FuncClass<MultiPipeline>(
                entity => new MultiPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMulti" }
                }
            );
        }

        public UtilityPipeline setUtility(WebGLShader currentShader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<UtilityPipeline>(
                entity => new UtilityPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUtility" }, currentShader
                }
            );
        }

        public void rebind(WebGLPipeline pipeline = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rebind" }, pipeline
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
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
}