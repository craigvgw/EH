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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkeletonDebugRenderer>))]
    public class SkeletonDebugRenderer : CachedEntityObject, Disposable
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
        private Color __boneLineColor;
        public Color boneLineColor
        {
            get
            {
            if(__boneLineColor == null)
            {
                __boneLineColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "boneLineColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __boneLineColor;
            }
            set
            {
__boneLineColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneLineColor",
                    value
                );
            }
        }

        private Color __boneOriginColor;
        public Color boneOriginColor
        {
            get
            {
            if(__boneOriginColor == null)
            {
                __boneOriginColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "boneOriginColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __boneOriginColor;
            }
            set
            {
__boneOriginColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneOriginColor",
                    value
                );
            }
        }

        private Color __attachmentLineColor;
        public Color attachmentLineColor
        {
            get
            {
            if(__attachmentLineColor == null)
            {
                __attachmentLineColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "attachmentLineColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __attachmentLineColor;
            }
            set
            {
__attachmentLineColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachmentLineColor",
                    value
                );
            }
        }

        private Color __triangleLineColor;
        public Color triangleLineColor
        {
            get
            {
            if(__triangleLineColor == null)
            {
                __triangleLineColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "triangleLineColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __triangleLineColor;
            }
            set
            {
__triangleLineColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "triangleLineColor",
                    value
                );
            }
        }

        private Color __pathColor;
        public Color pathColor
        {
            get
            {
            if(__pathColor == null)
            {
                __pathColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "pathColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __pathColor;
            }
            set
            {
__pathColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pathColor",
                    value
                );
            }
        }

        private Color __clipColor;
        public Color clipColor
        {
            get
            {
            if(__clipColor == null)
            {
                __clipColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "clipColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipColor;
            }
            set
            {
__clipColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipColor",
                    value
                );
            }
        }

        private Color __aabbColor;
        public Color aabbColor
        {
            get
            {
            if(__aabbColor == null)
            {
                __aabbColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "aabbColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __aabbColor;
            }
            set
            {
__aabbColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aabbColor",
                    value
                );
            }
        }

        
        public bool drawBones
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawBones"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawBones",
                    value
                );
            }
        }

        
        public bool drawRegionAttachments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawRegionAttachments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawRegionAttachments",
                    value
                );
            }
        }

        
        public bool drawBoundingBoxes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawBoundingBoxes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawBoundingBoxes",
                    value
                );
            }
        }

        
        public bool drawMeshHull
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawMeshHull"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawMeshHull",
                    value
                );
            }
        }

        
        public bool drawMeshTriangles
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawMeshTriangles"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawMeshTriangles",
                    value
                );
            }
        }

        
        public bool drawPaths
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawPaths"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawPaths",
                    value
                );
            }
        }

        
        public bool drawSkeletonXY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawSkeletonXY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawSkeletonXY",
                    value
                );
            }
        }

        
        public bool drawClipping
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawClipping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawClipping",
                    value
                );
            }
        }

        
        public bool premultipliedAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "premultipliedAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "premultipliedAlpha",
                    value
                );
            }
        }

        
        public decimal scale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        
        public decimal boneWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "boneWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneWidth",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SkeletonDebugRenderer() : base() { }

        public SkeletonDebugRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SkeletonDebugRenderer(
            ManagedWebGLRenderingContext context
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "SkeletonDebugRenderer" },
                context
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void draw(ShapeRenderer shapes, Skeleton skeleton, string[] ignoredBones = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "draw" }, shapes, skeleton, ignoredBones
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