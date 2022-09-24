/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LightShadow>))]
public class LightShadow : CachedEntityObject
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
        private Camera __camera;
        public Camera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
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

        
        public decimal bias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bias",
                    value
                );
            }
        }

        
        public decimal normalBias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "normalBias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalBias",
                    value
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        
        public decimal blurSamples
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurSamples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurSamples",
                    value
                );
            }
        }

        private Vector2 __mapSize;
        public Vector2 mapSize
        {
            get
            {
            if(__mapSize == null)
            {
                __mapSize = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "mapSize",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __mapSize;
            }
            set
            {
__mapSize = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mapSize",
                    value
                );
            }
        }

        private WebGLRenderTarget __map;
        public WebGLRenderTarget map
        {
            get
            {
            if(__map == null)
            {
                __map = EventHorizonBlazorInterop.GetClass<WebGLRenderTarget>(
                    this.___guid,
                    "map",
                    (entity) =>
                    {
                        return new WebGLRenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __map;
            }
            set
            {
__map = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "map",
                    value
                );
            }
        }

        private WebGLRenderTarget __mapPass;
        public WebGLRenderTarget mapPass
        {
            get
            {
            if(__mapPass == null)
            {
                __mapPass = EventHorizonBlazorInterop.GetClass<WebGLRenderTarget>(
                    this.___guid,
                    "mapPass",
                    (entity) =>
                    {
                        return new WebGLRenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __mapPass;
            }
            set
            {
__mapPass = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mapPass",
                    value
                );
            }
        }

        private Matrix4 __matrix;
        public Matrix4 matrix
        {
            get
            {
            if(__matrix == null)
            {
                __matrix = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "matrix",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __matrix;
            }
            set
            {
__matrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }

        
        public bool autoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoUpdate",
                    value
                );
            }
        }

        
        public bool needsUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needsUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needsUpdate",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public LightShadow() : base() { }

        public LightShadow(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public LightShadow(
            Camera camera
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LightShadow" },
                camera
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public LightShadow copy(LightShadow source)
        {
            return EventHorizonBlazorInterop.FuncClass<LightShadow>(
                entity => new LightShadow() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }

        public LightShadow clone(System.Nullable<bool> recursive = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LightShadow>(
                entity => new LightShadow() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, recursive
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }

        public decimal getFrustum()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFrustum" }
                }
            );
        }

        public void updateMatrices(Light light, System.Nullable<decimal> viewportIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrices" }, light, viewportIndex
                }
            );
        }

        public Vector4 getViewport(decimal viewportIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getViewport" }, viewportIndex
                }
            );
        }

        public Vector2 getFrameExtents()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFrameExtents" }
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
