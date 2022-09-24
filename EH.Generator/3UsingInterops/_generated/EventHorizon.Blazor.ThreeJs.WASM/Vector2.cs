/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Vector2>))]
public class Vector2 : CachedEntityObject, Vector
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

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public unknown isVector2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isVector2"
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
        }

        public Vector2(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Vector2" },
                x, y
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Vector2 set(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y
                }
            );
        }

        public Vector2 setScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScalar" }, scalar
                }
            );
        }

        public Vector2 setX(decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, x
                }
            );
        }

        public Vector2 setY(decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, y
                }
            );
        }

        public Vector2 setComponent(decimal index, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setComponent" }, index, value
                }
            );
        }

        public decimal getComponent(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getComponent" }, index
                }
            );
        }

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

        public Vector2 copy(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, v
                }
            );
        }

        public Vector2 add(Vector2 v, Vector2 w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, v, w
                }
            );
        }

        public Vector2 addScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScalar" }, s
                }
            );
        }

        public Vector2 addVectors(Vector2 a, Vector2 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addVectors" }, a, b
                }
            );
        }

        public Vector2 addScaledVector(Vector2 v, decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScaledVector" }, v, s
                }
            );
        }

        public Vector2 sub(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sub" }, v
                }
            );
        }

        public Vector2 subScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subScalar" }, s
                }
            );
        }

        public Vector2 subVectors(Vector2 a, Vector2 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subVectors" }, a, b
                }
            );
        }

        public Vector2 multiply(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, v
                }
            );
        }

        public Vector2 multiplyScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyScalar" }, scalar
                }
            );
        }

        public Vector2 divide(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divide" }, v
                }
            );
        }

        public Vector2 divideScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divideScalar" }, s
                }
            );
        }

        public Vector2 applyMatrix3(Matrix3 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix3" }, m
                }
            );
        }

        public Vector2 min(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "min" }, v
                }
            );
        }

        public Vector2 max(Vector2 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "max" }, v
                }
            );
        }

        public Vector2 clamp(Vector2 min, Vector2 max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clamp" }, min, max
                }
            );
        }

        public Vector2 clampScalar(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clampScalar" }, min, max
                }
            );
        }

        public Vector2 clampLength(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clampLength" }, min, max
                }
            );
        }

        public Vector2 floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "floor" }
                }
            );
        }

        public Vector2 ceil()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ceil" }
                }
            );
        }

        public Vector2 round()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "round" }
                }
            );
        }

        public Vector2 roundToZero()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "roundToZero" }
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

        public decimal dot(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "dot" }, v
                }
            );
        }

        public decimal cross(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "cross" }, v
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

        public decimal length()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "length" }
                }
            );
        }

        public decimal lengthManhattan()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "lengthManhattan" }
                }
            );
        }

        public decimal manhattanLength()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "manhattanLength" }
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

        public decimal angle()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "angle" }
                }
            );
        }

        public decimal distanceTo(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceTo" }, v
                }
            );
        }

        public decimal distanceToSquared(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToSquared" }, v
                }
            );
        }

        public decimal distanceToManhattan(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToManhattan" }, v
                }
            );
        }

        public decimal manhattanDistanceTo(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "manhattanDistanceTo" }, v
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

        public Vector2 lerp(Vector2 v, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerp" }, v, alpha
                }
            );
        }

        public Vector2 lerpVectors(Vector2 v1, Vector2 v2, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerpVectors" }, v1, v2, alpha
                }
            );
        }

        public bool equals(Vector2 v)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, v
                }
            );
        }

        public Vector2 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
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

        public Vector2 fromBufferAttribute(BufferAttribute attribute, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromBufferAttribute" }, attribute, index
                }
            );
        }

        public Vector2 rotateAround(Vector2 center, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateAround" }, center, angle
                }
            );
        }

        public Vector2 random()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "random" }
                }
            );
        }
    #endregion
}
