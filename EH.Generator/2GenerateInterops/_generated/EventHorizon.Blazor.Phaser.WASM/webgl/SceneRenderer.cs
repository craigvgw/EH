/// Generated - Do Not Edit
namespace spine.webgl
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<SceneRenderer>))]
    public class SceneRenderer : CachedEntityObject, Disposable
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
        private ManagedWebGLRenderingContext __context;
        public ManagedWebGLRenderingContext context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<ManagedWebGLRenderingContext>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new ManagedWebGLRenderingContext() { ___guid = entity.___guid };
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

        private OrthoCamera __camera;
        public OrthoCamera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<OrthoCamera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new OrthoCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
            }
            set
            {
__camera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }

        private PolygonBatcher __batcher;
        public PolygonBatcher batcher
        {
            get
            {
            if(__batcher == null)
            {
                __batcher = EventHorizonBlazorInterop.GetClass<PolygonBatcher>(
                    this.___guid,
                    "batcher",
                    (entity) =>
                    {
                        return new PolygonBatcher() { ___guid = entity.___guid };
                    }
                );
            }
            return __batcher;
            }
            set
            {
__batcher = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "batcher",
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
        #endregion
        
        #region Constructor
        public SceneRenderer() : base() { }

        public SceneRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SceneRenderer(
            HTMLCanvasElement canvas, ManagedWebGLRenderingContext context, System.Nullable<bool> twoColorTint = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "SceneRenderer" },
                canvas, context, twoColorTint
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void begin()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "begin" }
                }
            );
        }

        public void drawSkeleton(Skeleton skeleton, System.Nullable<bool> premultipliedAlpha = null, System.Nullable<decimal> slotRangeStart = null, System.Nullable<decimal> slotRangeEnd = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawSkeleton" }, skeleton, premultipliedAlpha, slotRangeStart, slotRangeEnd
                }
            );
        }

        public void drawSkeletonDebug(Skeleton skeleton, System.Nullable<bool> premultipliedAlpha = null, string[] ignoredBones = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawSkeletonDebug" }, skeleton, premultipliedAlpha, ignoredBones
                }
            );
        }

        public void drawTexture(GLTexture texture, decimal x, decimal y, decimal width, decimal height, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawTexture" }, texture, x, y, width, height, color
                }
            );
        }

        public void drawTextureUV(GLTexture texture, decimal x, decimal y, decimal width, decimal height, decimal u, decimal v, decimal u2, decimal v2, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawTextureUV" }, texture, x, y, width, height, u, v, u2, v2, color
                }
            );
        }

        public void drawTextureRotated(GLTexture texture, decimal x, decimal y, decimal width, decimal height, decimal pivotX, decimal pivotY, decimal angle, Color color = null, System.Nullable<bool> premultipliedAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawTextureRotated" }, texture, x, y, width, height, pivotX, pivotY, angle, color, premultipliedAlpha
                }
            );
        }

        public void drawRegion(TextureAtlasRegion region, decimal x, decimal y, decimal width, decimal height, Color color = null, System.Nullable<bool> premultipliedAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawRegion" }, region, x, y, width, height, color, premultipliedAlpha
                }
            );
        }

        public void line(decimal x, decimal y, decimal x2, decimal y2, Color color = null, Color color2 = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "line" }, x, y, x2, y2, color, color2
                }
            );
        }

        public void triangle(bool filled, decimal x, decimal y, decimal x2, decimal y2, decimal x3, decimal y3, Color color = null, Color color2 = null, Color color3 = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "triangle" }, filled, x, y, x2, y2, x3, y3, color, color2, color3
                }
            );
        }

        public void quad(bool filled, decimal x, decimal y, decimal x2, decimal y2, decimal x3, decimal y3, decimal x4, decimal y4, Color color = null, Color color2 = null, Color color3 = null, Color color4 = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "quad" }, filled, x, y, x2, y2, x3, y3, x4, y4, color, color2, color3, color4
                }
            );
        }

        public void rect(bool filled, decimal x, decimal y, decimal width, decimal height, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rect" }, filled, x, y, width, height, color
                }
            );
        }

        public void rectLine(bool filled, decimal x1, decimal y1, decimal x2, decimal y2, decimal width, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rectLine" }, filled, x1, y1, x2, y2, width, color
                }
            );
        }

        public void polygon(decimal[] polygonVertices, decimal offset, decimal count, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "polygon" }, polygonVertices, offset, count, color
                }
            );
        }

        public void circle(bool filled, decimal x, decimal y, decimal radius, Color color = null, System.Nullable<decimal> segments = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "circle" }, filled, x, y, radius, color, segments
                }
            );
        }

        public void curve(decimal x1, decimal y1, decimal cx1, decimal cy1, decimal cx2, decimal cy2, decimal x2, decimal y2, decimal segments, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "curve" }, x1, y1, cx1, cy1, cx2, cy2, x2, y2, segments, color
                }
            );
        }

        public void end()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }
                }
            );
        }

        public void resize(int resizeMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, resizeMode
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}