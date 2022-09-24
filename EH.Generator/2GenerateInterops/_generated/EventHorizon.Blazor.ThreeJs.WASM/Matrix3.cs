/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Matrix3>))]
public class Matrix3 : CachedEntityObject, Matrix
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
        public Matrix3() : base() { }

        public Matrix3(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public Matrix3 set(decimal n11, decimal n12, decimal n13, decimal n21, decimal n22, decimal n23, decimal n31, decimal n32, decimal n33)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, n11, n12, n13, n21, n22, n23, n31, n32, n33
                }
            );
        }

        public Matrix3 identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "identity" }
                }
            );
        }

        public Matrix3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Matrix3 copy(Matrix3 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, m
                }
            );
        }

        public Matrix3 extractBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "extractBasis" }, xAxis, yAxis, zAxis
                }
            );
        }

        public Matrix3 setFromMatrix4(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromMatrix4" }, m
                }
            );
        }

        public Matrix3 multiplyScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
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

        public Matrix3 invert()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "invert" }
                }
            );
        }

        public Matrix3 transpose()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transpose" }
                }
            );
        }

        public Matrix3 getNormalMatrix(Matrix4 matrix4)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNormalMatrix" }, matrix4
                }
            );
        }

        public Matrix3 transposeIntoArray(decimal[] r)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transposeIntoArray" }, r
                }
            );
        }

        public Matrix3 setUvTransform(decimal tx, decimal ty, decimal sx, decimal sy, decimal rotation, decimal cx, decimal cy)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUvTransform" }, tx, ty, sx, sy, rotation, cx, cy
                }
            );
        }

        public Matrix3 scale(decimal sx, decimal sy)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, sx, sy
                }
            );
        }

        public Matrix3 rotate(decimal theta)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, theta
                }
            );
        }

        public Matrix3 translate(decimal tx, decimal ty)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, tx, ty
                }
            );
        }

        public bool equals(Matrix3 matrix)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, matrix
                }
            );
        }

        public Matrix3 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
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

        public Matrix3 multiply(Matrix3 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, m
                }
            );
        }

        public Matrix3 premultiply(Matrix3 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "premultiply" }, m
                }
            );
        }

        public Matrix3 multiplyMatrices(Matrix3 a, Matrix3 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyMatrices" }, a, b
                }
            );
        }

        public CachedEntity multiplyVector3(Vector3 vector)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "multiplyVector3" }, vector
                }
            );
        }

        public CachedEntity multiplyVector3Array(object a)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "multiplyVector3Array" }, a
                }
            );
        }

        public Matrix3 getInverse(Matrix4 matrix, System.Nullable<bool> throwOnDegenerate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInverse" }, matrix, throwOnDegenerate
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
    #endregion
}
