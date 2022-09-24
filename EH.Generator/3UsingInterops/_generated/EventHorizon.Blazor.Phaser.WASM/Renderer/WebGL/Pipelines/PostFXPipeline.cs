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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PostFXPipeline>))]
    public class PostFXPipeline : WebGLPipeline
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
        private GameObject __gameObject;
        public GameObject gameObject
        {
            get
            {
            if(__gameObject == null)
            {
                __gameObject = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "gameObject",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __gameObject;
            }
            set
            {
__gameObject = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gameObject",
                    value
                );
            }
        }

        private ColorMatrix __colorMatrix;
        public ColorMatrix colorMatrix
        {
            get
            {
            if(__colorMatrix == null)
            {
                __colorMatrix = EventHorizonBlazorInterop.GetClass<ColorMatrix>(
                    this.___guid,
                    "colorMatrix",
                    (entity) =>
                    {
                        return new ColorMatrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorMatrix;
            }
            set
            {
__colorMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorMatrix",
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
        public PostFXPipeline() : base() { }

        public PostFXPipeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PostFXPipeline(
            WebGLPipelineConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "Pipelines", "PostFXPipeline" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void copyFrame(RenderTarget source, RenderTarget target = null, System.Nullable<decimal> brightness = null, System.Nullable<bool> clear = null, System.Nullable<bool> clearAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void drawFrame(RenderTarget source, RenderTarget target = null, System.Nullable<bool> clearAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawFrame" }, source, target, clearAlpha
                }
            );
        }

        public void blendFrames(RenderTarget source1, RenderTarget source2, RenderTarget target = null, System.Nullable<decimal> strength = null, System.Nullable<bool> clearAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendFrames" }, source1, source2, target, strength, clearAlpha
                }
            );
        }

        public void blendFramesAdditive(RenderTarget source1, RenderTarget source2, RenderTarget target = null, System.Nullable<decimal> strength = null, System.Nullable<bool> clearAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendFramesAdditive" }, source1, source2, target, strength, clearAlpha
                }
            );
        }

        public void clearFrame(RenderTarget target, System.Nullable<bool> clearAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearFrame" }, target, clearAlpha
                }
            );
        }

        public void blitFrame(RenderTarget source, RenderTarget target, System.Nullable<decimal> brightness = null, System.Nullable<bool> clear = null, System.Nullable<bool> clearAlpha = null, System.Nullable<bool> eraseMode = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blitFrame" }, source, target, brightness, clear, clearAlpha, eraseMode
                }
            );
        }

        public void copyFrameRect(RenderTarget source, RenderTarget target, decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> clear = null, System.Nullable<bool> clearAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyFrameRect" }, source, target, x, y, width, height, clear, clearAlpha
                }
            );
        }

        public void bindAndDraw(RenderTarget source, RenderTarget target = null, System.Nullable<bool> clear = null, System.Nullable<bool> clearAlpha = null, WebGLShader currentShader = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindAndDraw" }, source, target, clear, clearAlpha, currentShader
                }
            );
        }
        #endregion
    }
}