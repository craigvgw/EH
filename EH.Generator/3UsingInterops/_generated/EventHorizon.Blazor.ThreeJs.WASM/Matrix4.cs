/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Matrix4>))]
public class Matrix4 : CachedEntityObject, Matrix
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
        
        public decimal[] elements
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "elements"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elements",
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
        }


    #endregion

    #region Methods
        public Matrix4 set(decimal n11, decimal n12, decimal n13, decimal n14, decimal n21, decimal n22, decimal n23, decimal n24, decimal n31, decimal n32, decimal n33, decimal n34, decimal n41, decimal n42, decimal n43, decimal n44)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, n11, n12, n13, n14, n21, n22, n23, n24, n31, n32, n33, n34, n41, n42, n43, n44
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

        public Matrix4 copy(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, m
                }
            );
        }

        public Matrix4 copyPosition(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, m
                }
            );
        }

        public Matrix4 extractBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "extractBasis" }, xAxis, yAxis, zAxis
                }
            );
        }

        public Matrix4 makeBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeBasis" }, xAxis, yAxis, zAxis
                }
            );
        }

        public Matrix4 extractRotation(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "extractRotation" }, m
                }
            );
        }

        public Matrix4 makeRotationFromEuler(Euler euler)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeRotationFromEuler" }, euler
                }
            );
        }

        public Matrix4 makeRotationFromQuaternion(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeRotationFromQuaternion" }, q
                }
            );
        }

        public Matrix4 lookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lookAt" }, eye, target, up
                }
            );
        }

        public Matrix4 multiply(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, m
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

        public Matrix4 multiplyToArray(Matrix4 a, Matrix4 b, decimal[] r)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyToArray" }, a, b, r
                }
            );
        }

        public Matrix4 multiplyScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyScalar" }, s
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

        public Matrix4 setPosition(Vector3 v, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, v, y, z
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

        public decimal getMaxScaleOnAxis()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxScaleOnAxis" }
                }
            );
        }

        public Matrix4 makeTranslation(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeTranslation" }, x, y, z
                }
            );
        }

        public Matrix4 makeRotationX(decimal theta)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeRotationX" }, theta
                }
            );
        }

        public Matrix4 makeRotationY(decimal theta)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeRotationY" }, theta
                }
            );
        }

        public Matrix4 makeRotationZ(decimal theta)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeRotationZ" }, theta
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

        public Matrix4 makeScale(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeScale" }, x, y, z
                }
            );
        }

        public Matrix4 makeShear(decimal xy, decimal xz, decimal yx, decimal yz, decimal zx, decimal zy)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeShear" }, xy, xz, yx, yz, zx, zy
                }
            );
        }

        public Matrix4 compose(Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "compose" }, translation, rotation, scale
                }
            );
        }

        public Matrix4 decompose(Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "decompose" }, translation, rotation, scale
                }
            );
        }

        public Matrix4 makePerspective(decimal left, decimal right, decimal bottom, decimal top, decimal near, decimal far)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makePerspective" }, left, right, bottom, top, near, far
                }
            );
        }

        public Matrix4 makeOrthographic(decimal left, decimal right, decimal top, decimal bottom, decimal near, decimal far)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeOrthographic" }, left, right, top, bottom, near, far
                }
            );
        }

        public bool equals(Matrix4 matrix)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, matrix
                }
            );
        }

        public Matrix4 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, array, offset
                }
            );
        }

        public decimal[] toArray(decimal[] array = null, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toArray" }, array, offset
                }
            );
        }

        public Matrix4 setFromMatrix3(Matrix3 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromMatrix3" }, m
                }
            );
        }

        public Matrix4 extractPosition(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "extractPosition" }, m
                }
            );
        }

        public Matrix4 setRotationFromQuaternion(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix4>(
                entity => new Matrix4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotationFromQuaternion" }, q
                }
            );
        }

        public CachedEntity multiplyVector3(object v)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "multiplyVector3" }, v
                }
            );
        }

        public CachedEntity multiplyVector4(object v)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "multiplyVector4" }, v
                }
            );
        }

        public decimal[] multiplyVector3Array(decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "multiplyVector3Array" }, array
                }
            );
        }

        public void rotateAxis(object v)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rotateAxis" }, v
                }
            );
        }

        public void crossVector(object v)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "crossVector" }, v
                }
            );
        }

        public decimal[] flattenToArrayOffset(decimal[] array, decimal offset)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "flattenToArrayOffset" }, array, offset
                }
            );
        }

        public MatrixCachedEntity getInverse(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<MatrixCachedEntity>(
                entity => new MatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInverse" }, matrix
                }
            );
        }
    #endregion
}
