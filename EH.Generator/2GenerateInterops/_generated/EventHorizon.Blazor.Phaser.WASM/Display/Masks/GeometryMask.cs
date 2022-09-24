/// Generated - Do Not Edit
namespace Phaser.Display.Masks
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<GeometryMask>))]
    public class GeometryMask : CachedEntityObject
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
        private Graphics __geometryMask;
        public Graphics geometryMask
        {
            get
            {
            if(__geometryMask == null)
            {
                __geometryMask = EventHorizonBlazorInterop.GetClass<Graphics>(
                    this.___guid,
                    "geometryMask",
                    (entity) =>
                    {
                        return new Graphics() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometryMask;
            }
            set
            {
__geometryMask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometryMask",
                    value
                );
            }
        }

        
        public bool invertAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertAlpha",
                    value
                );
            }
        }

        
        public bool isStencil
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStencil"
                );
            }
        }
        #endregion
        
        #region Constructor
        public GeometryMask() : base() { }

        public GeometryMask(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GeometryMask(
            Scene scene, Graphics graphicsGeometry
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Display", "Masks", "GeometryMask" },
                scene, graphicsGeometry
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public GeometryMask setShape(Graphics graphicsGeometry)
        {
            return EventHorizonBlazorInterop.FuncClass<GeometryMask>(
                entity => new GeometryMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShape" }, graphicsGeometry
                }
            );
        }

        public GeometryMask setInvertAlpha(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GeometryMask>(
                entity => new GeometryMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setInvertAlpha" }, value
                }
            );
        }

        public void preRenderWebGL(WebGLRenderer renderer, GameObject child, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRenderWebGL" }, renderer, child, camera
                }
            );
        }

        public void applyStencil(WebGLRenderer renderer, Camera camera, bool inc)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyStencil" }, renderer, camera, inc
                }
            );
        }

        public void postRenderWebGL(WebGLRenderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postRenderWebGL" }, renderer
                }
            );
        }

        public void preRenderCanvas(CanvasRenderer renderer, GameObject mask, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRenderCanvas" }, renderer, mask, camera
                }
            );
        }

        public void postRenderCanvas(CanvasRenderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postRenderCanvas" }, renderer
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