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

    
    
    [JsonConverter(typeof(CachedEntityConverter<LightPipeline>))]
    public class LightPipeline : MultiPipeline
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
        
        public CachedEntity defaultNormalMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "defaultNormalMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultNormalMap",
                    value
                );
            }
        }

        
        public bool lightsActive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lightsActive"
                );
            }
        }
        #endregion
        
        #region Constructor
        public LightPipeline() : base() { }

        public LightPipeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LightPipeline(
            WebGLPipelineConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "Pipelines", "LightPipeline" },
                config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void boot()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "boot" }
                }
            );
        }

        public void setNormalMapRotation(decimal rotation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setNormalMapRotation" }, rotation
                }
            );
        }

        public WebGLTexture getNormalMap(GameObject gameObject = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNormalMap" }, gameObject
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
        #endregion
    }
}