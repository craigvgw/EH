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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector2>))]
    public class Vector2 : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Vector2 __ZERO;
        public static Vector2 ZERO
        {
            get
            {
            if(__ZERO == null)
            {
                __ZERO = EventHorizonBlazorInterop.GetClass<Vector2>(
                    "Phaser",
                    "PhaserMath.Vector2.ZERO",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __ZERO;
            }
        }

        private static Vector2 __RIGHT;
        public static Vector2 RIGHT
        {
            get
            {
            if(__RIGHT == null)
            {
                __RIGHT = EventHorizonBlazorInterop.GetClass<Vector2>(
                    "Phaser",
                    "PhaserMath.Vector2.RIGHT",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __RIGHT;
            }
        }

        private static Vector2 __LEFT;
        public static Vector2 LEFT
        {
            get
            {
            if(__LEFT == null)
            {
                __LEFT = EventHorizonBlazorInterop.GetClass<Vector2>(
                    "Phaser",
                    "PhaserMath.Vector2.LEFT",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __LEFT;
            }
        }

        private static Vector2 __UP;
        public static Vector2 UP
        {
            get
            {
            if(__UP == null)
            {
                __UP = EventHorizonBlazorInterop.GetClass<Vector2>(
                    "Phaser",
                    "PhaserMath.Vector2.UP",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __UP;
            }
        }

        private static Vector2 __DOWN;
        public static Vector2 DOWN
        {
            get
            {
            if(__DOWN == null)
            {
                __DOWN = EventHorizonBlazorInterop.GetClass<Vector2>(
                    "Phaser",
                    "PhaserMath.Vector2.DOWN",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __DOWN;
            }
        }

        private static Vector2 __ONE;
        public static Vector2 ONE
        {
            get
            {
            if(__ONE == null)
            {
                __ONE = EventHorizonBlazorInterop.GetClass<Vector2>(
                    "Phaser",
                    "PhaserMath.Vector2.ONE",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
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
        #endregion
        
        #region Constructor
        public Vector2() : base() { }

        public Vector2(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Vector2(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "PhaserMath", "Vector2" },
                x, y
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Vector2 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Vector2 copy(Vector2Like src)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, src
                }
            );
        }

        public Vector2 setFromObject(Vector2Like obj)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromObject" }, obj
                }
            );
        }

        public Vector2 set(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y
                }
            );
        }

        public Vector2 setTo(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTo" }, x, y
                }
            );
        }

        public Vector2 setToPolar(decimal azimuth, System.Nullable<decimal> radius = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setToPolar" }, azimuth, radius
                }
            );
        }

        public bool equals(Vector2Like v)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, v
                }
            );
        }

        public bool fuzzyEquals(Vector2Like v, System.Nullable<decimal> epsilon = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "fuzzyEquals" }, v, epsilon
                }
            );
        }

        public decimal angle()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "angle" }
                }
            );
        }

        public Vector2 setAngle(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, angle
                }
            );
        }

        public Vector2 add(Vector2Like src)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, src
                }
            );
        }

        public Vector2 subtract(Vector2Like src)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtract" }, src
                }
            );
        }

        public Vector2 multiply(Vector2Like src)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, src
                }
            );
        }

        public Vector2 scale(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, value
                }
            );
        }

        public Vector2 divide(Vector2Like src)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divide" }, src
                }
            );
        }

        public Vector2 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public decimal distance(Vector2Like src)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distance" }, src
                }
            );
        }

        public decimal distanceSq(Vector2Like src)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceSq" }, src
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

        public Vector2 setLength(decimal length)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLength" }, length
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

        public Vector2 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Vector2 normalizeRightHand()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalizeRightHand" }
                }
            );
        }

        public Vector2 normalizeLeftHand()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalizeLeftHand" }
                }
            );
        }

        public decimal dot(Vector2Like src)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "dot" }, src
                }
            );
        }

        public decimal cross(Vector2Like src)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "cross" }, src
                }
            );
        }

        public Vector2 lerp(Vector2Like src, System.Nullable<decimal> t = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerp" }, src, t
                }
            );
        }

        public Vector2 transformMat3(Matrix3 mat)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformMat3" }, mat
                }
            );
        }

        public Vector2 transformMat4(Matrix4 mat)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformMat4" }, mat
                }
            );
        }

        public Vector2 reset()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public Vector2 limit(decimal max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "limit" }, max
                }
            );
        }

        public Vector2 reflect(Vector2 normal)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reflect" }, normal
                }
            );
        }

        public Vector2 mirror(Vector2 axis)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "mirror" }, axis
                }
            );
        }

        public Vector2 rotate(decimal delta)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, delta
                }
            );
        }
        #endregion
    }
}