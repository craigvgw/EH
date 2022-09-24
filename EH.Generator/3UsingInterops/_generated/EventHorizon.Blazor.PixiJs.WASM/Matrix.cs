/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Matrix>))]
public class Matrix : CachedEntityObject
{
    #region Static Accessors
        private static Matrix __IDENTITY;
        public static Matrix IDENTITY
        {
            get
            {
            if(__IDENTITY == null)
            {
                __IDENTITY = EventHorizonBlazorInterop.GetClass<Matrix>(
                    "Matrix",
                    "IDENTITY",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __IDENTITY;
            }
        }

        private static Matrix __TEMP_MATRIX;
        public static Matrix TEMP_MATRIX
        {
            get
            {
            if(__TEMP_MATRIX == null)
            {
                __TEMP_MATRIX = EventHorizonBlazorInterop.GetClass<Matrix>(
                    "Matrix",
                    "TEMP_MATRIX",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __TEMP_MATRIX;
            }
        }
    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public decimal a
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "a"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "a",
                    value
                );
            }
        }

        
        public decimal b
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }

        
        public decimal c
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "c"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "c",
                    value
                );
            }
        }

        
        public decimal d
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "d"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "d",
                    value
                );
            }
        }

        
        public decimal tx
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tx"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tx",
                    value
                );
            }
        }

        
        public decimal ty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ty",
                    value
                );
            }
        }

        
        public decimal[] array
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "array"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "array",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Matrix() : base() { }

        public Matrix(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Matrix(
            System.Nullable<decimal> a = null, System.Nullable<decimal> b = null, System.Nullable<decimal> c = null, System.Nullable<decimal> d = null, System.Nullable<decimal> tx = null, System.Nullable<decimal> ty = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Matrix" },
                a, b, c, d, tx, ty
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void fromArray(decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, array
                }
            );
        }

        public Matrix set(decimal a, decimal b, decimal c, decimal d, decimal tx, decimal ty)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, a, b, c, d, tx, ty
                }
            );
        }

        public decimal[] toArray(bool transpose, decimal[] outPixi = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toArray" }, transpose, outPixi
                }
            );
        }

        public P apply<P>(IPointData pos, P newPos = null) where P : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<P>(
                entity => new P() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "apply" }, pos, newPos
                }
            );
        }

        public P applyInverse<P>(IPointData pos, P newPos = null) where P : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<P>(
                entity => new P() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyInverse" }, pos, newPos
                }
            );
        }

        public Matrix translate(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, x, y
                }
            );
        }

        public Matrix scale(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, x, y
                }
            );
        }

        public Matrix rotate(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, angle
                }
            );
        }

        public Matrix append(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "append" }, matrix
                }
            );
        }

        public Matrix setTransform(decimal x, decimal y, decimal pivotX, decimal pivotY, decimal scaleX, decimal scaleY, decimal rotation, decimal skewX, decimal skewY)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTransform" }, x, y, pivotX, pivotY, scaleX, scaleY, rotation, skewX, skewY
                }
            );
        }

        public Matrix prepend(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "prepend" }, matrix
                }
            );
        }

        public Transform decompose(Transform transform)
        {
            return EventHorizonBlazorInterop.FuncClass<Transform>(
                entity => new Transform() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "decompose" }, transform
                }
            );
        }

        public Matrix invert()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "invert" }
                }
            );
        }

        public Matrix identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "identity" }
                }
            );
        }

        public Matrix clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Matrix copyTo(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyTo" }, matrix
                }
            );
        }

        public Matrix copyFrom(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, matrix
                }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }
    #endregion
}
