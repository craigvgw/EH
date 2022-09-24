/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpinePlugin>))]
public class SpinePlugin : ScenePlugin
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
        
        public bool isWebGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isWebGL"
                );
            }
        }

        private BaseCache __cache;
        public BaseCache cache
        {
            get
            {
            if(__cache == null)
            {
                __cache = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "cache",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __cache;
            }
            set
            {
__cache = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cache",
                    value
                );
            }
        }

        private BaseCache __spineTextures;
        public BaseCache spineTextures
        {
            get
            {
            if(__spineTextures == null)
            {
                __spineTextures = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "spineTextures",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __spineTextures;
            }
            set
            {
__spineTextures = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spineTextures",
                    value
                );
            }
        }

        private BaseCache __json;
        public BaseCache json
        {
            get
            {
            if(__json == null)
            {
                __json = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "json",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __json;
            }
            set
            {
__json = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "json",
                    value
                );
            }
        }

        private TextureManager __textures;
        public TextureManager textures
        {
            get
            {
            if(__textures == null)
            {
                __textures = EventHorizonBlazorInterop.GetClass<TextureManager>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new TextureManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __textures;
            }
            set
            {
__textures = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textures",
                    value
                );
            }
        }

        
        public bool drawDebug
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawDebug"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawDebug",
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

        private CanvasRenderer __renderer;
        public CanvasRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<CanvasRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new CanvasRenderer() { ___guid = entity.___guid };
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

        private SceneRenderer __sceneRenderer;
        public SceneRenderer sceneRenderer
        {
            get
            {
            if(__sceneRenderer == null)
            {
                __sceneRenderer = EventHorizonBlazorInterop.GetClass<SceneRenderer>(
                    this.___guid,
                    "sceneRenderer",
                    (entity) =>
                    {
                        return new SceneRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __sceneRenderer;
            }
            set
            {
__sceneRenderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sceneRenderer",
                    value
                );
            }
        }

        private SkeletonRenderer __skeletonRenderer;
        public SkeletonRenderer skeletonRenderer
        {
            get
            {
            if(__skeletonRenderer == null)
            {
                __skeletonRenderer = EventHorizonBlazorInterop.GetClass<SkeletonRenderer>(
                    this.___guid,
                    "skeletonRenderer",
                    (entity) =>
                    {
                        return new SkeletonRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __skeletonRenderer;
            }
            set
            {
__skeletonRenderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletonRenderer",
                    value
                );
            }
        }

        private SkeletonDebugRenderer __skeletonDebugRenderer;
        public SkeletonDebugRenderer skeletonDebugRenderer
        {
            get
            {
            if(__skeletonDebugRenderer == null)
            {
                __skeletonDebugRenderer = EventHorizonBlazorInterop.GetClass<SkeletonDebugRenderer>(
                    this.___guid,
                    "skeletonDebugRenderer",
                    (entity) =>
                    {
                        return new SkeletonDebugRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __skeletonDebugRenderer;
            }
            set
            {
__skeletonDebugRenderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletonDebugRenderer",
                    value
                );
            }
        }

        private spine __plugin;
        public spine plugin
        {
            get
            {
            if(__plugin == null)
            {
                __plugin = EventHorizonBlazorInterop.GetClass<spine>(
                    this.___guid,
                    "plugin",
                    (entity) =>
                    {
                        return new spine() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugin;
            }
            set
            {
__plugin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugin",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SpinePlugin() : base() { }

        public SpinePlugin(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpinePlugin(
            Scene scene, PluginManager pluginManager
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SpinePlugin" },
                scene, pluginManager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public TextureAtlas getAtlasCanvas(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<TextureAtlas>(
                entity => new TextureAtlas() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAtlasCanvas" }, key
                }
            );
        }

        public TextureAtlas getAtlasWebGL(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<TextureAtlas>(
                entity => new TextureAtlas() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAtlasWebGL" }, key
                }
            );
        }

        public Vector2 worldToLocal(decimal x, decimal y, Skeleton skeleton, Bone bone = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "worldToLocal" }, x, y, skeleton, bone
                }
            );
        }

        public Vector2 getVector2(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVector2" }, x, y
                }
            );
        }

        public Vector2 getVector3(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVector3" }, x, y, z
                }
            );
        }

        public SpinePlugin setDebugBones(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugBones" }, value
                }
            );
        }

        public SpinePlugin setDebugRegionAttachments(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugRegionAttachments" }, value
                }
            );
        }

        public SpinePlugin setDebugBoundingBoxes(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugBoundingBoxes" }, value
                }
            );
        }

        public SpinePlugin setDebugMeshHull(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugMeshHull" }, value
                }
            );
        }

        public SpinePlugin setDebugMeshTriangles(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugMeshTriangles" }, value
                }
            );
        }

        public SpinePlugin setDebugPaths(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugPaths" }, value
                }
            );
        }

        public SpinePlugin setDebugSkeletonXY(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugSkeletonXY" }, value
                }
            );
        }

        public SpinePlugin setDebugClipping(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDebugClipping" }, value
                }
            );
        }

        public SpinePlugin setEffect(VertexEffect effect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpinePlugin>(
                entity => new SpinePlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEffect" }, effect
                }
            );
        }

        public CachedEntity createSkeleton(string key, object skeletonJSON = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createSkeleton" }, key, skeletonJSON
                }
            );
        }

        public CachedEntity createAnimationState(Skeleton skeleton)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createAnimationState" }, skeleton
                }
            );
        }

        public CachedEntity getBounds(Skeleton skeleton)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, skeleton
                }
            );
        }

        public void onResize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onResize" }
                }
            );
        }

        public SpineGameObject add(decimal x, decimal y, string key = null, string animationName = null, System.Nullable<bool> loop = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, x, y, key, animationName, loop
                }
            );
        }

        public SpineGameObject make(SpineGameObjectConfig config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "make" }, config, addToScene
                }
            );
        }
    #endregion
}
