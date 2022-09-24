/// Generated - Do Not Edit
namespace Phaser.PhaserMath
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Matrix4>))]
    public class Matrix4 : CachedEntityObject
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
        
        public decimal[] val
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "val"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "val",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Matrix4() : base() { }

        public Matrix4(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Matrix4(
            Matrix4 m = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "PhaserMath", "Matrix4" },
                m
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Matrix4 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Matrix4 set(Matrix4 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, src
                }
            );
        }

        public Matrix4 setValues(decimal m00, decimal m01, decimal m02, decimal m03, decimal m10, decimal m11, decimal m12, decimal m13, decimal m20, decimal m21, decimal m22, decimal m23, decimal m30, decimal m31, decimal m32, decimal m33)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setValues" }, m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33
                }
            );
        }

        public Matrix4 copy(Matrix4 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, src
                }
            );
        }

        public Matrix4 fromArray(decimal[] a)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, a
                }
            );
        }

        public Matrix4 zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "zero" }
                }
            );
        }

        public Matrix4 transform(Vector3 position, Vector3 scale, Quaternion rotation)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transform" }, position, scale, rotation
                }
            );
        }

        public Matrix4 xyz(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "xyz" }, x, y, z
                }
            );
        }

        public Matrix4 scaling(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaling" }, x, y, z
                }
            );
        }

        public Matrix4 identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "identity" }
                }
            );
        }

        public Matrix4 transpose()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transpose" }
                }
            );
        }

        public Matrix4 getInverse(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInverse" }, m
                }
            );
        }

        public Matrix4 invert()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "invert" }
                }
            );
        }

        public Matrix4 adjoint()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "adjoint" }
                }
            );
        }

        public decimal determinant()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "determinant" }
                }
            );
        }

        public Matrix4 multiply(Matrix4 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, src
                }
            );
        }

        public Matrix4 multiplyLocal(Matrix4 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyLocal" }, src
                }
            );
        }

        public Matrix4 premultiply(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "premultiply" }, m
                }
            );
        }

        public Matrix4 multiplyMatrices(Matrix4 a, Matrix4 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyMatrices" }, a, b
                }
            );
        }

        public Matrix4 translate(Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, v
                }
            );
        }

        public Matrix4 translateXYZ(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translateXYZ" }, x, y, z
                }
            );
        }

        public Matrix4 scale(Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, v
                }
            );
        }

        public Matrix4 scaleXYZ(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleXYZ" }, x, y, z
                }
            );
        }

        public Matrix4 makeRotationAxis(Vector3 axis, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeRotationAxis" }, axis, angle
                }
            );
        }

        public Matrix4 rotate(decimal rad, Vector3 axis)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, rad, axis
                }
            );
        }

        public Matrix4 rotateX(decimal rad)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateX" }, rad
                }
            );
        }

        public Matrix4 rotateY(decimal rad)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateY" }, rad
                }
            );
        }

        public Matrix4 rotateZ(decimal rad)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateZ" }, rad
                }
            );
        }

        public Matrix4 fromRotationTranslation(Quaternion q, Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromRotationTranslation" }, q, v
                }
            );
        }

        public Matrix4 fromQuat(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromQuat" }, q
                }
            );
        }

        public Matrix4 frustum(decimal left, decimal right, decimal bottom, decimal top, decimal near, decimal far)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "frustum" }, left, right, bottom, top, near, far
                }
            );
        }

        public Matrix4 perspective(decimal fovy, decimal aspect, decimal near, decimal far)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "perspective" }, fovy, aspect, near, far
                }
            );
        }

        public Matrix4 perspectiveLH(decimal width, decimal height, decimal near, decimal far)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "perspectiveLH" }, width, height, near, far
                }
            );
        }

        public Matrix4 ortho(decimal left, decimal right, decimal bottom, decimal top, decimal near, decimal far)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ortho" }, left, right, bottom, top, near, far
                }
            );
        }

        public Matrix4 lookAtRH(Vector3 eye, Vector3 target, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lookAtRH" }, eye, target, up
                }
            );
        }

        public Matrix4 lookAt(Vector3 eye, Vector3 center, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lookAt" }, eye, center, up
                }
            );
        }

        public Matrix4 yawPitchRoll(decimal yaw, decimal pitch, decimal roll)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "yawPitchRoll" }, yaw, pitch, roll
                }
            );
        }

        public Matrix4 setWorldMatrix(Vector3 rotation, Vector3 position, Vector3 scale, Matrix4 viewMatrix = null, Matrix4 projectionMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setWorldMatrix" }, rotation, position, scale, viewMatrix, projectionMatrix
                }
            );
        }

        public Matrix4 multiplyToMat4(Matrix4 src, Matrix4 out)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyToMat4" }, src, out
                }
            );
        }

        public Matrix4 fromRotationXYTranslation(Vector3 rotation, Vector3 position, bool translateFirst)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromRotationXYTranslation" }, rotation, position, translateFirst
                }
            );
        }

        public decimal getMaxScaleOnAxis()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxScaleOnAxis" }
                }
            );
        }
        #endregion
    }
}