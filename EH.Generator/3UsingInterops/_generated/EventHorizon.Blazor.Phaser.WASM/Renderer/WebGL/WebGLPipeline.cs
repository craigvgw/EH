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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLPipeline>))]
    public class WebGLPipeline : EventEmitter
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

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

        private PipelineManager __manager;
        public PipelineManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<PipelineManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new PipelineManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __manager;
            }
            set
            {
__manager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manager",
                    value
                );
            }
        }

        private WebGLRenderingContext __gl;
        public WebGLRenderingContext gl
        {
            get
            {
            if(__gl == null)
            {
                __gl = EventHorizonBlazorInterop.GetClass<WebGLRenderingContext>(
                    this.___guid,
                    "gl",
                    (entity) =>
                    {
                        return new WebGLRenderingContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __gl;
            }
            set
            {
__gl = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gl",
                    value
                );
            }
        }

        private HTMLCanvasElement __view;
        public HTMLCanvasElement view
        {
            get
            {
            if(__view == null)
            {
                __view = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "view",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __view;
            }
            set
            {
__view = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "view",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal vertexCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vertexCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexCount",
                    value
                );
            }
        }

        
        public decimal vertexCapacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vertexCapacity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexCapacity",
                    value
                );
            }
        }

        private ArrayBuffer __vertexData;
        public ArrayBuffer vertexData
        {
            get
            {
            if(__vertexData == null)
            {
                __vertexData = EventHorizonBlazorInterop.GetClass<ArrayBuffer>(
                    this.___guid,
                    "vertexData",
                    (entity) =>
                    {
                        return new ArrayBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexData;
            }
        }

        private WebGLBuffer __vertexBuffer;
        public WebGLBuffer vertexBuffer
        {
            get
            {
            if(__vertexBuffer == null)
            {
                __vertexBuffer = EventHorizonBlazorInterop.GetClass<WebGLBuffer>(
                    this.___guid,
                    "vertexBuffer",
                    (entity) =>
                    {
                        return new WebGLBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexBuffer;
            }
        }

        private GLenum __topology;
        public GLenum topology
        {
            get
            {
            if(__topology == null)
            {
                __topology = EventHorizonBlazorInterop.GetClass<GLenum>(
                    this.___guid,
                    "topology",
                    (entity) =>
                    {
                        return new GLenum() { ___guid = entity.___guid };
                    }
                );
            }
            return __topology;
            }
            set
            {
__topology = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "topology",
                    value
                );
            }
        }

        
        public decimal[] bytes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "bytes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bytes",
                    value
                );
            }
        }

        
        public decimal[] vertexViewF32
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "vertexViewF32"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexViewF32",
                    value
                );
            }
        }

        private Uint32Array __vertexViewU32;
        public Uint32Array vertexViewU32
        {
            get
            {
            if(__vertexViewU32 == null)
            {
                __vertexViewU32 = EventHorizonBlazorInterop.GetClass<Uint32Array>(
                    this.___guid,
                    "vertexViewU32",
                    (entity) =>
                    {
                        return new Uint32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexViewU32;
            }
            set
            {
__vertexViewU32 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexViewU32",
                    value
                );
            }
        }

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }

        
        public decimal currentUnit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentUnit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentUnit",
                    value
                );
            }
        }

        
        public bool forceZero
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceZero"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceZero",
                    value
                );
            }
        }

        
        public bool hasBooted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasBooted"
                );
            }
        }

        
        public bool isPostFX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPostFX"
                );
            }
        }

        
        public RenderTarget[] renderTargets
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<RenderTarget>(
                    this.___guid,
                    "renderTargets",
                    (entity) =>
                    {
                        return new RenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTargets",
                    value
                );
            }
        }

        private RenderTarget __currentRenderTarget;
        public RenderTarget currentRenderTarget
        {
            get
            {
            if(__currentRenderTarget == null)
            {
                __currentRenderTarget = EventHorizonBlazorInterop.GetClass<RenderTarget>(
                    this.___guid,
                    "currentRenderTarget",
                    (entity) =>
                    {
                        return new RenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentRenderTarget;
            }
            set
            {
__currentRenderTarget = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentRenderTarget",
                    value
                );
            }
        }

        
        public WebGLShader[] shaders
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<WebGLShader>(
                    this.___guid,
                    "shaders",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shaders",
                    value
                );
            }
        }

        private WebGLShader __currentShader;
        public WebGLShader currentShader
        {
            get
            {
            if(__currentShader == null)
            {
                __currentShader = EventHorizonBlazorInterop.GetClass<WebGLShader>(
                    this.___guid,
                    "currentShader",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentShader;
            }
            set
            {
__currentShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentShader",
                    value
                );
            }
        }

        private Matrix4 __projectionMatrix;
        public Matrix4 projectionMatrix
        {
            get
            {
            if(__projectionMatrix == null)
            {
                __projectionMatrix = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "projectionMatrix",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __projectionMatrix;
            }
            set
            {
__projectionMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionMatrix",
                    value
                );
            }
        }

        
        public decimal projectionWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "projectionWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionWidth",
                    value
                );
            }
        }

        
        public decimal projectionHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "projectionHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionHeight",
                    value
                );
            }
        }

        private WebGLPipelineConfig __config;
        public WebGLPipelineConfig config
        {
            get
            {
            if(__config == null)
            {
                __config = EventHorizonBlazorInterop.GetClass<WebGLPipelineConfig>(
                    this.___guid,
                    "config",
                    (entity) =>
                    {
                        return new WebGLPipelineConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __config;
            }
            set
            {
__config = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "config",
                    value
                );
            }
        }

        
        public bool glReset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "glReset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "glReset",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebGLPipeline() : base() { }

        public WebGLPipeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGLPipeline(
            WebGLPipelineConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "WebGLPipeline" },
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

        public void onBoot()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onBoot" }
                }
            );
        }

        public void onResize(decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onResize" }, width, height
                }
            );
        }

        public WebGLPipeline setShader(WebGLShader shader, System.Nullable<bool> setAttributes = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShader" }, shader, setAttributes
                }
            );
        }

        public WebGLShader getShaderByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShaderByName" }, name
                }
            );
        }

        public WebGLPipeline setShadersFromConfig(WebGLPipelineConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadersFromConfig" }, config
                }
            );
        }

        public decimal setGameObject(GameObject gameObject, Frame frame = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setGameObject" }, gameObject, frame
                }
            );
        }

        public bool shouldFlush(System.Nullable<decimal> amount = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "shouldFlush" }, amount
                }
            );
        }

        public WebGLPipeline resize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }

        public WebGLPipeline setProjectionMatrix(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setProjectionMatrix" }, width, height
                }
            );
        }

        public void updateProjectionMatrix()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateProjectionMatrix" }
                }
            );
        }

        public WebGLPipeline bind(WebGLShader currentShader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bind" }, currentShader
                }
            );
        }

        public WebGLPipeline rebind(WebGLShader currentShader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rebind" }, currentShader
                }
            );
        }

        public bool setVertexBuffer()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setVertexBuffer" }
                }
            );
        }

        public WebGLPipeline preBatch(GameObject gameObject = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "preBatch" }, gameObject
                }
            );
        }

        public WebGLPipeline postBatch(GameObject gameObject = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "postBatch" }, gameObject
                }
            );
        }

        public void onDraw(RenderTarget renderTarget)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onDraw" }, renderTarget
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public WebGLPipeline flush(System.Nullable<bool> isPostFlush = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "flush" }, isPostFlush
                }
            );
        }

        public void onActive(WebGLShader currentShader)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onActive" }, currentShader
                }
            );
        }

        public void onBind(GameObject gameObject = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onBind" }, gameObject
                }
            );
        }

        public void onRebind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onRebind" }
                }
            );
        }

        public void onBatch(GameObject gameObject = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onBatch" }, gameObject
                }
            );
        }

        public void onPreBatch(GameObject gameObject = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onPreBatch" }, gameObject
                }
            );
        }

        public void onPostBatch(GameObject gameObject = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onPostBatch" }, gameObject
                }
            );
        }

        public void onPreRender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onPreRender" }
                }
            );
        }

        public void onRender(Scene scene, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onRender" }, scene, camera
                }
            );
        }

        public void onPostRender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onPostRender" }
                }
            );
        }

        public void onBeforeFlush(System.Nullable<bool> isPostFlush = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onBeforeFlush" }, isPostFlush
                }
            );
        }

        public void onAfterFlush(System.Nullable<bool> isPostFlush = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onAfterFlush" }, isPostFlush
                }
            );
        }

        public void batchVert(decimal x, decimal y, decimal u, decimal v, decimal unit, decimal tintEffect, decimal tint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchVert" }, x, y, u, v, unit, tintEffect, tint
                }
            );
        }

        public bool batchQuad(decimal x0, decimal y0, decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3, decimal u0, decimal v0, decimal u1, decimal v1, decimal tintTL, decimal tintTR, decimal tintBL, decimal tintBR, decimal tintEffect, GameObject gameObject = null, WebGLTexture texture = null, System.Nullable<decimal> unit = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "batchQuad" }, gameObject, x0, y0, x1, y1, x2, y2, x3, y3, u0, v0, u1, v1, tintTL, tintTR, tintBL, tintBR, tintEffect, texture, unit
                }
            );
        }

        public bool batchTri(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3, decimal u0, decimal v0, decimal u1, decimal v1, decimal tintTL, decimal tintTR, decimal tintBL, decimal tintEffect, GameObject gameObject = null, WebGLTexture texture = null, System.Nullable<decimal> unit = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "batchTri" }, gameObject, x1, y1, x2, y2, x3, y3, u0, v0, u1, v1, tintTL, tintTR, tintBL, tintEffect, texture, unit
                }
            );
        }

        public void drawFillRect(decimal x, decimal y, decimal width, decimal height, decimal color, decimal alpha, WebGLTexture texture = null, System.Nullable<bool> flipUV = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawFillRect" }, x, y, width, height, color, alpha, texture, flipUV
                }
            );
        }

        public decimal setTexture2D(WebGLTexture texture = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture2D" }, texture
                }
            );
        }

        public WebGLPipeline bindTexture(WebGLTexture target = null, System.Nullable<decimal> unit = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bindTexture" }, target, unit
                }
            );
        }

        public WebGLPipeline bindRenderTarget(RenderTarget target = null, System.Nullable<decimal> unit = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bindRenderTarget" }, target, unit
                }
            );
        }

        public WebGLPipeline setTime(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTime" }, name
                }
            );
        }

        public WebGLPipeline set1f(string name, decimal x, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1f" }, name, x, shader
                }
            );
        }

        public WebGLPipeline set2f(string name, decimal x, decimal y, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2f" }, name, x, y, shader
                }
            );
        }

        public WebGLPipeline set3f(string name, decimal x, decimal y, decimal z, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3f" }, name, x, y, z, shader
                }
            );
        }

        public WebGLPipeline set4f(string name, decimal x, decimal y, decimal z, decimal w, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4f" }, name, x, y, z, w, shader
                }
            );
        }

        public WebGLPipeline set1fv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1fv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set2fv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2fv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set3fv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3fv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set4fv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4fv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set1iv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1iv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set2iv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2iv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set3iv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3iv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set4iv(string name, decimal[] arr, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4iv" }, name, arr, shader
                }
            );
        }

        public WebGLPipeline set1i(string name, decimal x, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1i" }, name, x, shader
                }
            );
        }

        public WebGLPipeline set2i(string name, decimal x, decimal y, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2i" }, name, x, y, shader
                }
            );
        }

        public WebGLPipeline set3i(string name, decimal x, decimal y, decimal z, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3i" }, name, x, y, z, shader
                }
            );
        }

        public WebGLPipeline set4i(string name, decimal x, decimal y, decimal z, decimal w, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4i" }, name, x, y, z, w, shader
                }
            );
        }

        public WebGLPipeline setMatrix2fv(string name, bool transpose, decimal[] matrix, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix2fv" }, name, transpose, matrix, shader
                }
            );
        }

        public WebGLPipeline setMatrix3fv(string name, bool transpose, decimal[] matrix, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix3fv" }, name, transpose, matrix, shader
                }
            );
        }

        public WebGLPipeline setMatrix4fv(string name, bool transpose, decimal[] matrix, WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix4fv" }, name, transpose, matrix, shader
                }
            );
        }

        public WebGLPipeline destroy()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLPipeline>(
                entity => new WebGLPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}