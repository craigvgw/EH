/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Vector4>))]
public class Vector4 : CachedEntityObject, Vector
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

        
        public decimal w
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
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

        
        public unknown isVector4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isVector4"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Vector4() : base() { }

        public Vector4(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Vector4(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Vector4" },
                x, y, z, w
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Vector4 set(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y, z, w
                }
            );
        }

        public Vector4 setScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScalar" }, scalar
                }
            );
        }

        public Vector4 setX(decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, x
                }
            );
        }

        public Vector4 setY(decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, y
                }
            );
        }

        public Vector4 setZ(decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, z
                }
            );
        }

        public Vector4 setW(decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setW" }, w
                }
            );
        }

        public Vector4 setComponent(decimal index, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
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

        public Vector4 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Vector4 copy(Vector4 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, v
                }
            );
        }

        public Vector4 add(Vector4 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, v
                }
            );
        }

        public Vector4 addScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScalar" }, scalar
                }
            );
        }

        public Vector4 addVectors(Vector4 a, Vector4 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addVectors" }, a, b
                }
            );
        }

        public Vector4 addScaledVector(Vector4 v, decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScaledVector" }, v, s
                }
            );
        }

        public Vector4 sub(Vector4 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sub" }, v
                }
            );
        }

        public Vector4 subScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subScalar" }, s
                }
            );
        }

        public Vector4 subVectors(Vector4 a, Vector4 b)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subVectors" }, a, b
                }
            );
        }

        public Vector4 multiply(Vector4 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, v
                }
            );
        }

        public Vector4 multiplyScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyScalar" }, s
                }
            );
        }

        public Vector4 applyMatrix4(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, m
                }
            );
        }

        public Vector4 divideScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divideScalar" }, s
                }
            );
        }

        public Vector4 setAxisAngleFromQuaternion(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAxisAngleFromQuaternion" }, q
                }
            );
        }

        public Vector4 setAxisAngleFromRotationMatrix(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAxisAngleFromRotationMatrix" }, m
                }
            );
        }

        public Vector4 min(Vector4 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "min" }, v
                }
            );
        }

        public Vector4 max(Vector4 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "max" }, v
                }
            );
        }

        public Vector4 clamp(Vector4 min, Vector4 max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clamp" }, min, max
                }
            );
        }

        public Vector4 clampScalar(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clampScalar" }, min, max
                }
            );
        }

        public Vector4 floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "floor" }
                }
            );
        }

        public Vector4 ceil()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ceil" }
                }
            );
        }

        public Vector4 round()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "round" }
                }
            );
        }

        public Vector4 roundToZero()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "roundToZero" }
                }
            );
        }

        public Vector4 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public decimal dot(Vector4 v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "dot" }, v
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

        public decimal manhattanLength()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "manhattanLength" }
                }
            );
        }

        public Vector4 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Vector4 setLength(decimal length)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLength" }, length
                }
            );
        }

        public Vector4 lerp(Vector4 v, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerp" }, v, alpha
                }
            );
        }

        public Vector4 lerpVectors(Vector4 v1, Vector4 v2, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerpVectors" }, v1, v2, alpha
                }
            );
        }

        public bool equals(Vector4 v)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, v
                }
            );
        }

        public Vector4 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
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

        public Vector4 fromBufferAttribute(BufferAttribute attribute, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromBufferAttribute" }, attribute, index
                }
            );
        }

        public Vector4 random()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "random" }
                }
            );
        }
    #endregion
}
