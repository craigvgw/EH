/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Camera>))]
public class Camera : Object3D
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
        private Matrix4 __matrixWorldInverse;
        public Matrix4 matrixWorldInverse
        {
            get
            {
            if(__matrixWorldInverse == null)
            {
                __matrixWorldInverse = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "matrixWorldInverse",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __matrixWorldInverse;
            }
            set
            {
__matrixWorldInverse = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixWorldInverse",
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

        private Matrix4 __projectionMatrixInverse;
        public Matrix4 projectionMatrixInverse
        {
            get
            {
            if(__projectionMatrixInverse == null)
            {
                __projectionMatrixInverse = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "projectionMatrixInverse",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __projectionMatrixInverse;
            }
            set
            {
__projectionMatrixInverse = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionMatrixInverse",
                    value
                );
            }
        }

        
        public unknown isCamera
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isCamera"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Camera() : base() { }

        public Camera(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public Vector3 getWorldDirection(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldDirection" }, target
                }
            );
        }

        public void updateMatrixWorld(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrixWorld" }, force
                }
            );
        }
    #endregion
}
