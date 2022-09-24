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

    
    
    [JsonConverter(typeof(CachedEntityConverter<UtilityPipeline>))]
    public class UtilityPipeline : WebGLPipeline
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

        private WebGLShader __copyShader;
        public WebGLShader copyShader
        {
            get
            {
            if(__copyShader == null)
            {
                __copyShader = EventHorizonBlazorInterop.GetClass<WebGLShader>(
                    this.___guid,
                    "copyShader",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __copyShader;
            }
            set
            {
__copyShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "copyShader",
                    value
                );
            }
        }

        private WebGLShader __addShader;
        public WebGLShader addShader
        {
            get
            {
            if(__addShader == null)
            {
                __addShader = EventHorizonBlazorInterop.GetClass<WebGLShader>(
                    this.___guid,
                    "addShader",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __addShader;
            }
            set
            {
__addShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "addShader",
                    value
                );
            }
        }

        private WebGLShader __linearShader;
        public WebGLShader linearShader
        {
            get
            {
            if(__linearShader == null)
            {
                __linearShader = EventHorizonBlazorInterop.GetClass<WebGLShader>(
                    this.___guid,
                    "linearShader",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __linearShader;
            }
            set
            {
__linearShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linearShader",
                    value
                );
            }
        }

        private WebGLShader __colorMatrixShader;
        public WebGLShader colorMatrixShader
        {
            get
            {
            if(__colorMatrixShader == null)
            {
                __colorMatrixShader = EventHorizonBlazorInterop.GetClass<WebGLShader>(
                    this.___guid,
                    "colorMatrixShader",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorMatrixShader;
            }
            set
            {
__colorMatrixShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorMatrixShader",
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
        public UtilityPipeline() : base() { }

        public UtilityPipeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public UtilityPipeline(
            WebGLPipelineConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "Pipelines", "UtilityPipeline" },
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

        public void copyToGame(RenderTarget source)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyToGame" }, source
                }
            );
        }

        public void drawFrame(RenderTarget source, RenderTarget target = null, System.Nullable<bool> clearAlpha = null, ColorMatrix colorMatrix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawFrame" }, source, target, clearAlpha, colorMatrix
                }
            );
        }

        public void blendFrames(RenderTarget source1, RenderTarget source2, RenderTarget target = null, System.Nullable<decimal> strength = null, System.Nullable<bool> clearAlpha = null, WebGLShader blendShader = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendFrames" }, source1, source2, target, strength, clearAlpha, blendShader
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

        public void setUVs(decimal uA, decimal vA, decimal uB, decimal vB, decimal uC, decimal vC, decimal uD, decimal vD)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setUVs" }, uA, vA, uB, vB, uC, vC, uD, vD
                }
            );
        }

        public void setTargetUVs(RenderTarget source, RenderTarget target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTargetUVs" }, source, target
                }
            );
        }

        public void flipX()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flipX" }
                }
            );
        }

        public void flipY()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flipY" }
                }
            );
        }

        public void resetUVs()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetUVs" }
                }
            );
        }
        #endregion
    }
}