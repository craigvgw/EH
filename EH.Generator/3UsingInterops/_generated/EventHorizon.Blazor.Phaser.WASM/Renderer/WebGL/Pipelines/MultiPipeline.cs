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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MultiPipeline>))]
    public class MultiPipeline : WebGLPipeline
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
        private TransformMatrix __calcMatrix;
        public TransformMatrix calcMatrix
        {
            get
            {
            if(__calcMatrix == null)
            {
                __calcMatrix = EventHorizonBlazorInterop.GetClass<TransformMatrix>(
                    this.___guid,
                    "calcMatrix",
                    (entity) =>
                    {
                        return new TransformMatrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __calcMatrix;
            }
            set
            {
__calcMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "calcMatrix",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public MultiPipeline() : base() { }

        public MultiPipeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MultiPipeline(
            WebGLPipelineConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "Pipelines", "MultiPipeline" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public MultiPipeline bind()
        {
            return EventHorizonBlazorInterop.FuncClass<MultiPipeline>(
                entity => new MultiPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bind" }
                }
            );
        }

        public void batchSprite(Image gameObject, Camera camera, TransformMatrix parentTransformMatrix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchSprite" }, gameObject, camera, parentTransformMatrix
                }
            );
        }

        public void batchTexture(GameObject gameObject, WebGLTexture texture, decimal textureWidth, decimal textureHeight, decimal srcX, decimal srcY, decimal srcWidth, decimal srcHeight, decimal scaleX, decimal scaleY, decimal rotation, bool flipX, bool flipY, decimal scrollFactorX, decimal scrollFactorY, decimal displayOriginX, decimal displayOriginY, decimal frameX, decimal frameY, decimal frameWidth, decimal frameHeight, decimal tintTL, decimal tintTR, decimal tintBL, decimal tintBR, decimal tintEffect, decimal uOffset, decimal vOffset, Camera camera, TransformMatrix parentTransformMatrix, System.Nullable<bool> skipFlip = null, System.Nullable<decimal> textureUnit = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchTexture" }, gameObject, texture, textureWidth, textureHeight, srcX, srcY, srcWidth, srcHeight, scaleX, scaleY, rotation, flipX, flipY, scrollFactorX, scrollFactorY, displayOriginX, displayOriginY, frameX, frameY, frameWidth, frameHeight, tintTL, tintTR, tintBL, tintBR, tintEffect, uOffset, vOffset, camera, parentTransformMatrix, skipFlip, textureUnit
                }
            );
        }

        public void batchTextureFrame(Frame frame, decimal x, decimal y, decimal tint, decimal alpha, TransformMatrix transformMatrix, TransformMatrix parentTransformMatrix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchTextureFrame" }, frame, x, y, tint, alpha, transformMatrix, parentTransformMatrix
                }
            );
        }

        public void batchFillRect(decimal x, decimal y, decimal width, decimal height, TransformMatrix currentMatrix, TransformMatrix parentMatrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchFillRect" }, x, y, width, height, currentMatrix, parentMatrix
                }
            );
        }

        public void batchFillTriangle(decimal x0, decimal y0, decimal x1, decimal y1, decimal x2, decimal y2, TransformMatrix currentMatrix, TransformMatrix parentMatrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchFillTriangle" }, x0, y0, x1, y1, x2, y2, currentMatrix, parentMatrix
                }
            );
        }

        public void batchStrokeTriangle(decimal x0, decimal y0, decimal x1, decimal y1, decimal x2, decimal y2, decimal lineWidth, TransformMatrix currentMatrix, TransformMatrix parentMatrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchStrokeTriangle" }, x0, y0, x1, y1, x2, y2, lineWidth, currentMatrix, parentMatrix
                }
            );
        }

        public void batchFillPath(Vector2Like[] path, TransformMatrix currentMatrix, TransformMatrix parentMatrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchFillPath" }, path, currentMatrix, parentMatrix
                }
            );
        }

        public void batchStrokePath(Vector2Like[] path, decimal lineWidth, bool pathOpen, TransformMatrix currentMatrix, TransformMatrix parentMatrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchStrokePath" }, path, lineWidth, pathOpen, currentMatrix, parentMatrix
                }
            );
        }

        public void batchLine(decimal ax, decimal ay, decimal bx, decimal by, decimal aLineWidth, decimal bLineWidth, decimal index, bool closePath, TransformMatrix currentMatrix, TransformMatrix parentMatrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchLine" }, ax, ay, bx, by, aLineWidth, bLineWidth, index, closePath, currentMatrix, parentMatrix
                }
            );
        }
        #endregion
    }
}