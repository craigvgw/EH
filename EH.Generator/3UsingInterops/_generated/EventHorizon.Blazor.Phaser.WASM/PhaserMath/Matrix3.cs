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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Matrix3>))]
    public class Matrix3 : CachedEntityObject
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
        public Matrix3() : base() { }

        public Matrix3(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Matrix3(
            Matrix3 m = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "PhaserMath", "Matrix3" },
                m
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public Matrix3 set(Matrix3 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, src
                }
            );
        }

        public Matrix3 copy(Matrix3 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, src
                }
            );
        }

        public Matrix3 fromMat4(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromMat4" }, m
                }
            );
        }

        public Matrix3 fromArray(CachedEntity[] a)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, a
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

        public Matrix3 adjoint()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
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

        public Matrix3 multiply(Matrix3 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, src
                }
            );
        }

        public Matrix3 translate(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, v
                }
            );
        }

        public Matrix3 rotate(decimal rad)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, rad
                }
            );
        }

        public Matrix3 scale(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, v
                }
            );
        }

        public Matrix3 fromQuat(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromQuat" }, q
                }
            );
        }

        public Matrix3 normalFromMat4(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix3>(
                entity => new Matrix3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalFromMat4" }, m
                }
            );
        }
        #endregion
    }
}