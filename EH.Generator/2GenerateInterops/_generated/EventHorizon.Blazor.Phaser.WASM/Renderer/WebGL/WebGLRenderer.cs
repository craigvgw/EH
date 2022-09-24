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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLRenderer>))]
    public class WebGLRenderer : EventEmitter
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
        
        public CachedEntity config
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "config"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "config",
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

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private PipelineManager __pipelines;
        public PipelineManager pipelines
        {
            get
            {
            if(__pipelines == null)
            {
                __pipelines = EventHorizonBlazorInterop.GetClass<PipelineManager>(
                    this.___guid,
                    "pipelines",
                    (entity) =>
                    {
                        return new PipelineManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __pipelines;
            }
            set
            {
__pipelines = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pipelines",
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

        private HTMLCanvasElement __canvas;
        public HTMLCanvasElement canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
            set
            {
__canvas = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvas",
                    value
                );
            }
        }

        
        public CachedEntity[] blendModes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "blendModes",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendModes",
                    value
                );
            }
        }

        
        public bool contextLost
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "contextLost"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contextLost",
                    value
                );
            }
        }

        private SnapshotState __snapshotState;
        public SnapshotState snapshotState
        {
            get
            {
            if(__snapshotState == null)
            {
                __snapshotState = EventHorizonBlazorInterop.GetClass<SnapshotState>(
                    this.___guid,
                    "snapshotState",
                    (entity) =>
                    {
                        return new SnapshotState() { ___guid = entity.___guid };
                    }
                );
            }
            return __snapshotState;
            }
            set
            {
__snapshotState = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snapshotState",
                    value
                );
            }
        }

        
        public decimal currentActiveTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentActiveTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentActiveTexture",
                    value
                );
            }
        }

        
        public decimal startActiveTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startActiveTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startActiveTexture",
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

        
        public CachedEntity[] textureIndexes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "textureIndexes",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureIndexes",
                    value
                );
            }
        }

        
        public CachedEntity[] tempTextures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "tempTextures",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tempTextures",
                    value
                );
            }
        }

        private WebGLTexture __textureZero;
        public WebGLTexture textureZero
        {
            get
            {
            if(__textureZero == null)
            {
                __textureZero = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "textureZero",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureZero;
            }
            set
            {
__textureZero = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureZero",
                    value
                );
            }
        }

        private WebGLTexture __normalTexture;
        public WebGLTexture normalTexture
        {
            get
            {
            if(__normalTexture == null)
            {
                __normalTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "normalTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __normalTexture;
            }
            set
            {
__normalTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalTexture",
                    value
                );
            }
        }

        private WebGLFramebuffer __currentFramebuffer;
        public WebGLFramebuffer currentFramebuffer
        {
            get
            {
            if(__currentFramebuffer == null)
            {
                __currentFramebuffer = EventHorizonBlazorInterop.GetClass<WebGLFramebuffer>(
                    this.___guid,
                    "currentFramebuffer",
                    (entity) =>
                    {
                        return new WebGLFramebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentFramebuffer;
            }
            set
            {
__currentFramebuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentFramebuffer",
                    value
                );
            }
        }

        
        public WebGLFramebuffer[] fboStack
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<WebGLFramebuffer>(
                    this.___guid,
                    "fboStack",
                    (entity) =>
                    {
                        return new WebGLFramebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fboStack",
                    value
                );
            }
        }

        private WebGLProgram __currentProgram;
        public WebGLProgram currentProgram
        {
            get
            {
            if(__currentProgram == null)
            {
                __currentProgram = EventHorizonBlazorInterop.GetClass<WebGLProgram>(
                    this.___guid,
                    "currentProgram",
                    (entity) =>
                    {
                        return new WebGLProgram() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentProgram;
            }
            set
            {
__currentProgram = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentProgram",
                    value
                );
            }
        }

        
        public decimal currentBlendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentBlendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentBlendMode",
                    value
                );
            }
        }

        
        public bool currentScissorEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "currentScissorEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentScissorEnabled",
                    value
                );
            }
        }

        private Uint32Array __currentScissor;
        public Uint32Array currentScissor
        {
            get
            {
            if(__currentScissor == null)
            {
                __currentScissor = EventHorizonBlazorInterop.GetClass<Uint32Array>(
                    this.___guid,
                    "currentScissor",
                    (entity) =>
                    {
                        return new Uint32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentScissor;
            }
            set
            {
__currentScissor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentScissor",
                    value
                );
            }
        }

        private Uint32Array __scissorStack;
        public Uint32Array scissorStack
        {
            get
            {
            if(__scissorStack == null)
            {
                __scissorStack = EventHorizonBlazorInterop.GetClass<Uint32Array>(
                    this.___guid,
                    "scissorStack",
                    (entity) =>
                    {
                        return new Uint32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __scissorStack;
            }
            set
            {
__scissorStack = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scissorStack",
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

        
        public string[] supportedExtensions
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "supportedExtensions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "supportedExtensions",
                    value
                );
            }
        }

        private ANGLE_instanced_arrays __instancedArraysExtension;
        public ANGLE_instanced_arrays instancedArraysExtension
        {
            get
            {
            if(__instancedArraysExtension == null)
            {
                __instancedArraysExtension = EventHorizonBlazorInterop.GetClass<ANGLE_instanced_arrays>(
                    this.___guid,
                    "instancedArraysExtension",
                    (entity) =>
                    {
                        return new ANGLE_instanced_arrays() { ___guid = entity.___guid };
                    }
                );
            }
            return __instancedArraysExtension;
            }
            set
            {
__instancedArraysExtension = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instancedArraysExtension",
                    value
                );
            }
        }

        private OES_vertex_array_object __vaoExtension;
        public OES_vertex_array_object vaoExtension
        {
            get
            {
            if(__vaoExtension == null)
            {
                __vaoExtension = EventHorizonBlazorInterop.GetClass<OES_vertex_array_object>(
                    this.___guid,
                    "vaoExtension",
                    (entity) =>
                    {
                        return new OES_vertex_array_object() { ___guid = entity.___guid };
                    }
                );
            }
            return __vaoExtension;
            }
            set
            {
__vaoExtension = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vaoExtension",
                    value
                );
            }
        }

        
        public CachedEntity extensions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "extensions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "extensions",
                    value
                );
            }
        }

        
        public CachedEntity[] glFormats
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "glFormats",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "glFormats",
                    value
                );
            }
        }

        private WebGLTextureCompression __compression;
        public WebGLTextureCompression compression
        {
            get
            {
            if(__compression == null)
            {
                __compression = EventHorizonBlazorInterop.GetClass<WebGLTextureCompression>(
                    this.___guid,
                    "compression",
                    (entity) =>
                    {
                        return new WebGLTextureCompression() { ___guid = entity.___guid };
                    }
                );
            }
            return __compression;
            }
            set
            {
__compression = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "compression",
                    value
                );
            }
        }

        
        public decimal drawingBufferHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "drawingBufferHeight"
                );
            }
        }

        private WebGLTexture __blankTexture;
        public WebGLTexture blankTexture
        {
            get
            {
            if(__blankTexture == null)
            {
                __blankTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "blankTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __blankTexture;
            }
        }

        private WebGLTexture __whiteTexture;
        public WebGLTexture whiteTexture
        {
            get
            {
            if(__whiteTexture == null)
            {
                __whiteTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "whiteTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __whiteTexture;
            }
        }

        
        public decimal maskCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maskCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskCount",
                    value
                );
            }
        }

        
        public GeometryMask[] maskStack
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<GeometryMask>(
                    this.___guid,
                    "maskStack",
                    (entity) =>
                    {
                        return new GeometryMask() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskStack",
                    value
                );
            }
        }

        
        public CachedEntity currentMask
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "currentMask",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentMask",
                    value
                );
            }
        }

        
        public CachedEntity currentCameraMask
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "currentCameraMask",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentCameraMask",
                    value
                );
            }
        }

        
        public CachedEntity glFuncMap
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "glFuncMap",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "glFuncMap",
                    value
                );
            }
        }

        
        public string currentType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "currentType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentType",
                    value
                );
            }
        }

        
        public bool newType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "newType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "newType",
                    value
                );
            }
        }

        
        public bool nextTypeMatch
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "nextTypeMatch"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nextTypeMatch",
                    value
                );
            }
        }

        
        public bool finalType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "finalType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "finalType",
                    value
                );
            }
        }

        private GLenum __mipmapFilter;
        public GLenum mipmapFilter
        {
            get
            {
            if(__mipmapFilter == null)
            {
                __mipmapFilter = EventHorizonBlazorInterop.GetClass<GLenum>(
                    this.___guid,
                    "mipmapFilter",
                    (entity) =>
                    {
                        return new GLenum() { ___guid = entity.___guid };
                    }
                );
            }
            return __mipmapFilter;
            }
            set
            {
__mipmapFilter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mipmapFilter",
                    value
                );
            }
        }

        
        public decimal textureFlush
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textureFlush"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureFlush",
                    value
                );
            }
        }

        
        public bool isTextureClean
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isTextureClean"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isTextureClean",
                    value
                );
            }
        }

        
        public bool isBooted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBooted"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBooted",
                    value
                );
            }
        }

        private RenderTarget __renderTarget;
        public RenderTarget renderTarget
        {
            get
            {
            if(__renderTarget == null)
            {
                __renderTarget = EventHorizonBlazorInterop.GetClass<RenderTarget>(
                    this.___guid,
                    "renderTarget",
                    (entity) =>
                    {
                        return new RenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderTarget;
            }
            set
            {
__renderTarget = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTarget",
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
        #endregion
        
        #region Constructor
        public WebGLRenderer() : base() { }

        public WebGLRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGLRenderer(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "WebGLRenderer" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void contextLostHandler()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "contextLostHandler" }
                }
            );
        }

        public void contextRestoredHandler()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "contextRestoredHandler" }
                }
            );
        }

        public WebGLRenderer init(object config)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "init" }, config
                }
            );
        }

        public void onResize(Size gameSize, Size baseSize)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onResize" }, gameSize, baseSize
                }
            );
        }

        public void beginCapture(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "beginCapture" }, width, height
                }
            );
        }

        public RenderTarget endCapture()
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTarget>(
                entity => new RenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "endCapture" }
                }
            );
        }

        public WebGLRenderer resize(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }

        public decimal getAspectRatio()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAspectRatio" }
                }
            );
        }

        public WebGLRenderer setProjectionMatrix(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setProjectionMatrix" }, width, height
                }
            );
        }

        public void resetProjectionMatrix()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetProjectionMatrix" }
                }
            );
        }

        public bool hasExtension(string extensionName)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasExtension" }, extensionName
                }
            );
        }

        public CachedEntity getExtension(string extensionName)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getExtension" }, extensionName
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

        public decimal[] pushScissor(decimal x, decimal y, decimal width, decimal height, System.Nullable<decimal> drawingBufferHeight = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "pushScissor" }, x, y, width, height, drawingBufferHeight
                }
            );
        }

        public void setScissor(decimal x, decimal y, decimal width, decimal height, System.Nullable<decimal> drawingBufferHeight = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setScissor" }, x, y, width, height, drawingBufferHeight
                }
            );
        }

        public void resetScissor()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetScissor" }
                }
            );
        }

        public void popScissor()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "popScissor" }
                }
            );
        }

        public bool hasActiveStencilMask()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasActiveStencilMask" }
                }
            );
        }

        public void resetViewport()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetViewport" }
                }
            );
        }

        public bool setBlendMode(decimal blendModeId, System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, blendModeId, force
                }
            );
        }

        public decimal addBlendMode(GLenum[] func, GLenum equation)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "addBlendMode" }, func, equation
                }
            );
        }

        public WebGLRenderer removeBlendMode(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeBlendMode" }, index
                }
            );
        }

        public decimal setTextureSource(TextureSource textureSource)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureSource" }, textureSource
                }
            );
        }

        public bool isNewNormalMap(WebGLTexture texture, WebGLTexture normalMap)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isNewNormalMap" }, texture, normalMap
                }
            );
        }

        public void setTextureZero(WebGLTexture texture, System.Nullable<bool> flush = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureZero" }, texture, flush
                }
            );
        }

        public void clearTextureZero()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearTextureZero" }
                }
            );
        }

        public void setNormalMap(WebGLTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setNormalMap" }, texture
                }
            );
        }

        public void clearNormalMap()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearNormalMap" }
                }
            );
        }

        public void unbindTextures(System.Nullable<bool> all = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbindTextures" }, all
                }
            );
        }

        public void resetTextures(System.Nullable<bool> all = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetTextures" }, all
                }
            );
        }

        public decimal setTexture2D(WebGLTexture texture)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture2D" }, texture
                }
            );
        }

        public WebGLRenderer pushFramebuffer(WebGLFramebuffer framebuffer, System.Nullable<bool> updateScissor = null, System.Nullable<bool> resetTextures = null, System.Nullable<bool> setViewport = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pushFramebuffer" }, framebuffer, updateScissor, resetTextures, setViewport
                }
            );
        }

        public WebGLRenderer setFramebuffer(WebGLFramebuffer framebuffer, System.Nullable<bool> updateScissor = null, System.Nullable<bool> resetTextures = null, System.Nullable<bool> setViewport = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFramebuffer" }, framebuffer, updateScissor, resetTextures, setViewport
                }
            );
        }

        public WebGLFramebuffer popFramebuffer(System.Nullable<bool> updateScissor = null, System.Nullable<bool> resetTextures = null, System.Nullable<bool> setViewport = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLFramebuffer>(
                entity => new WebGLFramebuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "popFramebuffer" }, updateScissor, resetTextures, setViewport
                }
            );
        }

        public bool setProgram(WebGLProgram program)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setProgram" }, program
                }
            );
        }

        public WebGLRenderer resetProgram()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetProgram" }
                }
            );
        }

        public WebGLTexture createTextureFromSource(object source, decimal width, decimal height, decimal scaleMode)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTextureFromSource" }, source, width, height, scaleMode
                }
            );
        }

        public WebGLTexture createTexture2D(decimal mipLevel, decimal minFilter, decimal magFilter, decimal wrapT, decimal wrapS, decimal format, object pixels, decimal width, decimal height, System.Nullable<bool> pma = null, System.Nullable<bool> forceSize = null, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTexture2D" }, mipLevel, minFilter, magFilter, wrapT, wrapS, format, pixels, width, height, pma, forceSize, flipY
                }
            );
        }

        public WebGLFramebuffer createFramebuffer(decimal width, decimal height, WebGLTexture renderTexture, System.Nullable<bool> addDepthStencilBuffer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLFramebuffer>(
                entity => new WebGLFramebuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFramebuffer" }, width, height, renderTexture, addDepthStencilBuffer
                }
            );
        }

        public WebGLProgram createProgram(string vertexShader, string fragmentShader)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgram>(
                entity => new WebGLProgram() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createProgram" }, vertexShader, fragmentShader
                }
            );
        }

        public WebGLBuffer createVertexBuffer(ArrayBuffer initialDataOrSize, decimal bufferUsage)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLBuffer>(
                entity => new WebGLBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createVertexBuffer" }, initialDataOrSize, bufferUsage
                }
            );
        }

        public WebGLBuffer createIndexBuffer(ArrayBuffer initialDataOrSize, decimal bufferUsage)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLBuffer>(
                entity => new WebGLBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createIndexBuffer" }, initialDataOrSize, bufferUsage
                }
            );
        }

        public WebGLRenderer deleteTexture(WebGLTexture texture, System.Nullable<bool> reset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "deleteTexture" }, texture, reset
                }
            );
        }

        public WebGLRenderer deleteFramebuffer(WebGLFramebuffer framebuffer)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "deleteFramebuffer" }, framebuffer
                }
            );
        }

        public WebGLRenderer deleteProgram(WebGLProgram program)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "deleteProgram" }, program
                }
            );
        }

        public WebGLRenderer deleteBuffer(WebGLBuffer vertexBuffer)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "deleteBuffer" }, vertexBuffer
                }
            );
        }

        public void preRenderCamera(Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRenderCamera" }, camera
                }
            );
        }

        public void postRenderCamera(Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postRenderCamera" }, camera
                }
            );
        }

        public void preRender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRender" }
                }
            );
        }

        public void render(Scene scene, GameObject[] children, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, scene, children, camera
                }
            );
        }

        public void postRender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postRender" }
                }
            );
        }

        public WebGLRenderer snapshot(SnapshotCallback callback, string type = null, System.Nullable<decimal> encoderOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshot" }, callback, type, encoderOptions
                }
            );
        }

        public WebGLRenderer snapshotArea(decimal x, decimal y, decimal width, decimal height, SnapshotCallback callback, string type = null, System.Nullable<decimal> encoderOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotArea" }, x, y, width, height, callback, type, encoderOptions
                }
            );
        }

        public WebGLRenderer snapshotPixel(decimal x, decimal y, SnapshotCallback callback)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotPixel" }, x, y, callback
                }
            );
        }

        public WebGLRenderer snapshotFramebuffer(WebGLFramebuffer framebuffer, decimal bufferWidth, decimal bufferHeight, SnapshotCallback callback, System.Nullable<bool> getPixel = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string type = null, System.Nullable<decimal> encoderOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotFramebuffer" }, framebuffer, bufferWidth, bufferHeight, callback, getPixel, x, y, width, height, type, encoderOptions
                }
            );
        }

        public WebGLTexture canvasToTexture(HTMLCanvasElement srcCanvas, WebGLTexture dstTexture = null, System.Nullable<bool> noRepeat = null, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "canvasToTexture" }, srcCanvas, dstTexture, noRepeat, flipY
                }
            );
        }

        public WebGLTexture createCanvasTexture(HTMLCanvasElement srcCanvas, System.Nullable<bool> noRepeat = null, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCanvasTexture" }, srcCanvas, noRepeat, flipY
                }
            );
        }

        public WebGLTexture updateCanvasTexture(HTMLCanvasElement srcCanvas, WebGLTexture dstTexture, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateCanvasTexture" }, srcCanvas, dstTexture, flipY
                }
            );
        }

        public WebGLTexture createVideoTexture(HTMLVideoElement srcVideo, System.Nullable<bool> noRepeat = null, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createVideoTexture" }, srcVideo, noRepeat, flipY
                }
            );
        }

        public WebGLTexture updateVideoTexture(HTMLVideoElement srcVideo, WebGLTexture dstTexture, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTexture>(
                entity => new WebGLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateVideoTexture" }, srcVideo, dstTexture, flipY
                }
            );
        }

        public WebGLRenderer setTextureFilter(decimal texture, decimal filter)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderer>(
                entity => new WebGLRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTextureFilter" }, texture, filter
                }
            );
        }

        public decimal getMaxTextureSize()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxTextureSize" }
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