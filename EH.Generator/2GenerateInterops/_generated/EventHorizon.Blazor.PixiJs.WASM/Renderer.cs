/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Renderer>))]
public class Renderer : AbstractRenderer
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static AbstractRenderer create(IRendererOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractRenderer>(
                entity => new AbstractRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Renderer", "create" }, options
                }
            );
        }

        public static void registerPlugin(string pluginName, IRendererPluginConstructor ctor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "Renderer", "registerPlugin" }, pluginName, ctor
                }
            );
        }
    #endregion

    #region Accessors
        
        public CachedEntity extract
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "extract"
                );
            }
        }
    #endregion

    #region Properties
        private IRenderingContextCachedEntity __gl;
        public IRenderingContextCachedEntity gl
        {
            get
            {
            if(__gl == null)
            {
                __gl = EventHorizonBlazorInterop.GetClass<IRenderingContextCachedEntity>(
                    this.___guid,
                    "gl",
                    (entity) =>
                    {
                        return new IRenderingContextCachedEntity() { ___guid = entity.___guid };
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

        private UniformGroup __globalUniforms;
        public UniformGroup globalUniforms
        {
            get
            {
            if(__globalUniforms == null)
            {
                __globalUniforms = EventHorizonBlazorInterop.GetClass<UniformGroup>(
                    this.___guid,
                    "globalUniforms",
                    (entity) =>
                    {
                        return new UniformGroup() { ___guid = entity.___guid };
                    }
                );
            }
            return __globalUniforms;
            }
            set
            {
__globalUniforms = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalUniforms",
                    value
                );
            }
        }

        
        public decimal CONTEXT_UID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CONTEXT_UID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CONTEXT_UID",
                    value
                );
            }
        }

        
        public bool renderingToScreen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderingToScreen"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderingToScreen",
                    value
                );
            }
        }

        
        public int multisample
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "multisample"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multisample",
                    value
                );
            }
        }

        private MaskSystem __mask;
        public MaskSystem mask
        {
            get
            {
            if(__mask == null)
            {
                __mask = EventHorizonBlazorInterop.GetClass<MaskSystem>(
                    this.___guid,
                    "mask",
                    (entity) =>
                    {
                        return new MaskSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __mask;
            }
            set
            {
__mask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mask",
                    value
                );
            }
        }

        private ContextSystem __context;
        public ContextSystem context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<ContextSystem>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new ContextSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __context;
            }
            set
            {
__context = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "context",
                    value
                );
            }
        }

        private StateSystem __state;
        public StateSystem state
        {
            get
            {
            if(__state == null)
            {
                __state = EventHorizonBlazorInterop.GetClass<StateSystem>(
                    this.___guid,
                    "state",
                    (entity) =>
                    {
                        return new StateSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __state;
            }
            set
            {
__state = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }

        private ShaderSystem __shader;
        public ShaderSystem shader
        {
            get
            {
            if(__shader == null)
            {
                __shader = EventHorizonBlazorInterop.GetClass<ShaderSystem>(
                    this.___guid,
                    "shader",
                    (entity) =>
                    {
                        return new ShaderSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __shader;
            }
            set
            {
__shader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shader",
                    value
                );
            }
        }

        private TextureSystem __texture;
        public TextureSystem texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<TextureSystem>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new TextureSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        private BufferSystem __buffer;
        public BufferSystem buffer
        {
            get
            {
            if(__buffer == null)
            {
                __buffer = EventHorizonBlazorInterop.GetClass<BufferSystem>(
                    this.___guid,
                    "buffer",
                    (entity) =>
                    {
                        return new BufferSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __buffer;
            }
            set
            {
__buffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buffer",
                    value
                );
            }
        }

        private GeometrySystem __geometry;
        public GeometrySystem geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInterop.GetClass<GeometrySystem>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new GeometrySystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometry;
            }
            set
            {
__geometry = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometry",
                    value
                );
            }
        }

        private FramebufferSystem __framebuffer;
        public FramebufferSystem framebuffer
        {
            get
            {
            if(__framebuffer == null)
            {
                __framebuffer = EventHorizonBlazorInterop.GetClass<FramebufferSystem>(
                    this.___guid,
                    "framebuffer",
                    (entity) =>
                    {
                        return new FramebufferSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __framebuffer;
            }
            set
            {
__framebuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "framebuffer",
                    value
                );
            }
        }

        private ScissorSystem __scissor;
        public ScissorSystem scissor
        {
            get
            {
            if(__scissor == null)
            {
                __scissor = EventHorizonBlazorInterop.GetClass<ScissorSystem>(
                    this.___guid,
                    "scissor",
                    (entity) =>
                    {
                        return new ScissorSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __scissor;
            }
            set
            {
__scissor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scissor",
                    value
                );
            }
        }

        private StencilSystem __stencil;
        public StencilSystem stencil
        {
            get
            {
            if(__stencil == null)
            {
                __stencil = EventHorizonBlazorInterop.GetClass<StencilSystem>(
                    this.___guid,
                    "stencil",
                    (entity) =>
                    {
                        return new StencilSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __stencil;
            }
            set
            {
__stencil = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencil",
                    value
                );
            }
        }

        private ProjectionSystem __projection;
        public ProjectionSystem projection
        {
            get
            {
            if(__projection == null)
            {
                __projection = EventHorizonBlazorInterop.GetClass<ProjectionSystem>(
                    this.___guid,
                    "projection",
                    (entity) =>
                    {
                        return new ProjectionSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __projection;
            }
            set
            {
__projection = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projection",
                    value
                );
            }
        }

        private TextureGCSystem __textureGC;
        public TextureGCSystem textureGC
        {
            get
            {
            if(__textureGC == null)
            {
                __textureGC = EventHorizonBlazorInterop.GetClass<TextureGCSystem>(
                    this.___guid,
                    "textureGC",
                    (entity) =>
                    {
                        return new TextureGCSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureGC;
            }
            set
            {
__textureGC = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureGC",
                    value
                );
            }
        }

        private FilterSystem __filter;
        public FilterSystem filter
        {
            get
            {
            if(__filter == null)
            {
                __filter = EventHorizonBlazorInterop.GetClass<FilterSystem>(
                    this.___guid,
                    "filter",
                    (entity) =>
                    {
                        return new FilterSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __filter;
            }
            set
            {
__filter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filter",
                    value
                );
            }
        }

        private RenderTextureSystem __renderTexture;
        public RenderTextureSystem renderTexture
        {
            get
            {
            if(__renderTexture == null)
            {
                __renderTexture = EventHorizonBlazorInterop.GetClass<RenderTextureSystem>(
                    this.___guid,
                    "renderTexture",
                    (entity) =>
                    {
                        return new RenderTextureSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderTexture;
            }
            set
            {
__renderTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTexture",
                    value
                );
            }
        }

        private BatchSystem __batch;
        public BatchSystem batch
        {
            get
            {
            if(__batch == null)
            {
                __batch = EventHorizonBlazorInterop.GetClass<BatchSystem>(
                    this.___guid,
                    "batch",
                    (entity) =>
                    {
                        return new BatchSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __batch;
            }
            set
            {
__batch = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "batch",
                    value
                );
            }
        }

        
        public CachedEntity runners
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "runners",
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
                    "runners",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Renderer() : base() { }

        public Renderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Renderer(
            IRendererOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Renderer" },
                options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Renderer addSystem(ISystemConstructor ClassRef, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Renderer>(
                entity => new Renderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addSystem" }, ClassRef, name
                }
            );
        }

        public void render(IRenderableObject displayObject, IRendererRenderOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, displayObject, options
                }
            );
        }

        public RenderTexture generateTexture(IRenderableObject displayObject, IGenerateTextureOptions options = null, System.Nullable<decimal> resolution = null, Rectangle region = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateTexture" }, displayObject, options, resolution, region
                }
            );
        }

        public void resize(decimal desiredScreenWidth, decimal desiredScreenHeight)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, desiredScreenWidth, desiredScreenHeight
                }
            );
        }

        public Renderer reset()
        {
            return EventHorizonBlazorInterop.FuncClass<Renderer>(
                entity => new Renderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
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

        public void destroy(System.Nullable<bool> removeView = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, removeView
                }
            );
        }
    #endregion
}
