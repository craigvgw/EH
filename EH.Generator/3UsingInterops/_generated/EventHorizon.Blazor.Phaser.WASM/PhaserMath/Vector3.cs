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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector3>))]
    public class Vector3 : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Vector3 __ZERO;
        public static Vector3 ZERO
        {
            get
            {
            if(__ZERO == null)
            {
                __ZERO = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.ZERO",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ZERO;
            }
        }

        private static Vector3 __RIGHT;
        public static Vector3 RIGHT
        {
            get
            {
            if(__RIGHT == null)
            {
                __RIGHT = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.RIGHT",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __RIGHT;
            }
        }

        private static Vector3 __LEFT;
        public static Vector3 LEFT
        {
            get
            {
            if(__LEFT == null)
            {
                __LEFT = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.LEFT",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __LEFT;
            }
        }

        private static Vector3 __UP;
        public static Vector3 UP
        {
            get
            {
            if(__UP == null)
            {
                __UP = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.UP",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __UP;
            }
        }

        private static Vector3 __DOWN;
        public static Vector3 DOWN
        {
            get
            {
            if(__DOWN == null)
            {
                __DOWN = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.DOWN",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __DOWN;
            }
        }

        private static Vector3 __FORWARD;
        public static Vector3 FORWARD
        {
            get
            {
            if(__FORWARD == null)
            {
                __FORWARD = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.FORWARD",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __FORWARD;
            }
        }

        private static Vector3 __BACK;
        public static Vector3 BACK
        {
            get
            {
            if(__BACK == null)
            {
                __BACK = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.BACK",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __BACK;
            }
        }

        private static Vector3 __ONE;
        public static Vector3 ONE
        {
            get
            {
            if(__ONE == null)
            {
                __ONE = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Phaser",
                    "PhaserMath.Vector3.ONE",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ONE;
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Vector3() : base() { }

        public Vector3(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Vector3(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "PhaserMath", "Vector3" },
                x, y, z
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Vector3 up()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "up" }
                }
            );
        }

        public Vector3 min(Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "min" }, v
                }
            );
        }

        public Vector3 max(Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "max" }, v
                }
            );
        }

        public Vector3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Vector3 addVectors(Vector3 a, Vector3 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addVectors" }, a, b
                }
            );
        }

        public Vector3 crossVectors(Vector3 a, Vector3 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "crossVectors" }, a, b
                }
            );
        }

        public bool equals(Vector3 v)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, v
                }
            );
        }

        public Vector3 copy(Vector2 src)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, src
                }
            );
        }

        public Vector3 set(decimal x, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y, z
                }
            );
        }

        public Vector3 setFromMatrixPosition(Matrix4 mat4)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromMatrixPosition" }, mat4
                }
            );
        }

        public Vector3 setFromMatrixColumn(Matrix4 mat4, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromMatrixColumn" }, mat4, index
                }
            );
        }

        public Vector3 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, array, offset
                }
            );
        }

        public Vector3 add(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, v
                }
            );
        }

        public Vector3 addScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScalar" }, s
                }
            );
        }

        public Vector3 addScale(Vector2 v, decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScale" }, v, scale
                }
            );
        }

        public Vector3 subtract(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtract" }, v
                }
            );
        }

        public Vector3 multiply(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, v
                }
            );
        }

        public Vector3 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public Vector3 divide(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divide" }, v
                }
            );
        }

        public Vector3 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public decimal distance(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distance" }, v
                }
            );
        }

        public decimal distanceSq(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceSq" }, v
                }
            );
        }

        public decimal length()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "length" }
                }
            );
        }

        public decimal lengthSq()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "lengthSq" }
                }
            );
        }

        public Vector3 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public decimal dot(Vector3 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "dot" }, v
                }
            );
        }

        public Vector3 cross(Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cross" }, v
                }
            );
        }

        public Vector3 lerp(Vector3 v, System.Nullable<decimal> t = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerp" }, v, t
                }
            );
        }

        public Vector3 applyMatrix3(Matrix3 mat3)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix3" }, mat3
                }
            );
        }

        public Vector3 applyMatrix4(Matrix4 mat4)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, mat4
                }
            );
        }

        public Vector3 transformMat3(Matrix3 mat)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformMat3" }, mat
                }
            );
        }

        public Vector3 transformMat4(Matrix4 mat)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformMat4" }, mat
                }
            );
        }

        public Vector3 transformCoordinates(Matrix4 mat)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformCoordinates" }, mat
                }
            );
        }

        public Vector3 transformQuat(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformQuat" }, q
                }
            );
        }

        public Vector3 project(Matrix4 mat)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "project" }, mat
                }
            );
        }

        public Vector3 projectViewMatrix(Matrix4 viewMatrix, Matrix4 projectionMatrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "projectViewMatrix" }, viewMatrix, projectionMatrix
                }
            );
        }

        public Vector3 unprojectViewMatrix(Matrix4 projectionMatrix, Matrix4 worldMatrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unprojectViewMatrix" }, projectionMatrix, worldMatrix
                }
            );
        }

        public Vector3 unproject(Vector4 viewport, Matrix4 invProjectionView)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unproject" }, viewport, invProjectionView
                }
            );
        }

        public Vector3 reset()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }
        #endregion
    }
}