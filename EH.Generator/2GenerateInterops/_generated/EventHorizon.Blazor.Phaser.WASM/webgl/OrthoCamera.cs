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

    
    
    [JsonConverter(typeof(CachedEntityConverter<OrthoCamera>))]
    public class OrthoCamera : CachedEntityObject
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
        private Vector3 __position;
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private Vector3 __direction;
        public Vector3 direction
        {
            get
            {
            if(__direction == null)
            {
                __direction = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction;
            }
            set
            {
__direction = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
            }
        }

        private Vector3 __up;
        public Vector3 up
        {
            get
            {
            if(__up == null)
            {
                __up = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "up",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __up;
            }
            set
            {
__up = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "up",
                    value
                );
            }
        }

        
        public decimal near
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "near"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "near",
                    value
                );
            }
        }

        
        public decimal far
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "far"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "far",
                    value
                );
            }
        }

        
        public decimal zoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoom",
                    value
                );
            }
        }

        
        public decimal viewportWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "viewportWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "viewportWidth",
                    value
                );
            }
        }

        
        public decimal viewportHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "viewportHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "viewportHeight",
                    value
                );
            }
        }

        private Matrix4 __projectionView;
        public Matrix4 projectionView
        {
            get
            {
            if(__projectionView == null)
            {
                __projectionView = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "projectionView",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __projectionView;
            }
            set
            {
__projectionView = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionView",
                    value
                );
            }
        }

        private Matrix4 __inverseProjectionView;
        public Matrix4 inverseProjectionView
        {
            get
            {
            if(__inverseProjectionView == null)
            {
                __inverseProjectionView = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "inverseProjectionView",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __inverseProjectionView;
            }
            set
            {
__inverseProjectionView = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverseProjectionView",
                    value
                );
            }
        }

        private Matrix4 __projection;
        public Matrix4 projection
        {
            get
            {
            if(__projection == null)
            {
                __projection = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "projection",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
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

        private Matrix4 __view;
        public Matrix4 view
        {
            get
            {
            if(__view == null)
            {
                __view = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "view",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
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
        #endregion
        
        #region Constructor
        public OrthoCamera() : base() { }

        public OrthoCamera(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public OrthoCamera(
            decimal viewportWidth, decimal viewportHeight
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "OrthoCamera" },
                viewportWidth, viewportHeight
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public Vector3 screenToWorld(Vector3 screenCoords, decimal screenWidth, decimal screenHeight)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "screenToWorld" }, screenCoords, screenWidth, screenHeight
                }
            );
        }

        public void setViewport(decimal viewportWidth, decimal viewportHeight)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewport" }, viewportWidth, viewportHeight
                }
            );
        }
        #endregion
    }
}