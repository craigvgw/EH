/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Quaternion>))]
public class Quaternion : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Quaternion slerpFlat(decimal[] dst, decimal dstOffset, decimal[] src0, decimal srcOffset, decimal[] src1, decimal stcOffset1, decimal t)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Quaternion", "slerpFlat" }, dst, dstOffset, src0, srcOffset, src1, stcOffset1, t
                }
            );
        }

        public static decimal[] multiplyQuaternionsFlat(decimal[] dst, decimal dstOffset, decimal[] src0, decimal srcOffset, decimal[] src1, decimal stcOffset1)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "Quaternion", "multiplyQuaternionsFlat" }, dst, dstOffset, src0, srcOffset, src1, stcOffset1
                }
            );
        }

        public static decimal slerp(Quaternion qa, Quaternion qb, Quaternion qm, decimal t)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Quaternion", "slerp" }, qa, qb, qm, t
                }
            );
        }
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

        
        public unknown isQuaternion
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isQuaternion"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Quaternion() : base() { }

        public Quaternion(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Quaternion(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Quaternion" },
                x, y, z, w
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Quaternion set(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y, z, w
                }
            );
        }

        public Quaternion clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Quaternion copy(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, q
                }
            );
        }

        public Quaternion setFromEuler(Euler euler, System.Nullable<bool> update = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromEuler" }, euler, update
                }
            );
        }

        public Quaternion setFromAxisAngle(Vector3 axis, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromAxisAngle" }, axis, angle
                }
            );
        }

        public Quaternion setFromRotationMatrix(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromRotationMatrix" }, m
                }
            );
        }

        public Quaternion setFromUnitVectors(Vector3 vFrom, Vector3 vTo)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromUnitVectors" }, vFrom, vTo
                }
            );
        }

        public decimal angleTo(Quaternion q)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "angleTo" }, q
                }
            );
        }

        public Quaternion rotateTowards(Quaternion q, decimal step)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateTowards" }, q, step
                }
            );
        }

        public Quaternion identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "identity" }
                }
            );
        }

        public Quaternion invert()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "invert" }
                }
            );
        }

        public Quaternion conjugate()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "conjugate" }
                }
            );
        }

        public decimal dot(Quaternion v)
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

        public Quaternion normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Quaternion multiply(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, q
                }
            );
        }

        public Quaternion premultiply(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "premultiply" }, q
                }
            );
        }

        public Quaternion multiplyQuaternions(Quaternion a, Quaternion b)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyQuaternions" }, a, b
                }
            );
        }

        public Quaternion slerp(Quaternion qb, decimal t)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "slerp" }, qb, t
                }
            );
        }

        public Quaternion slerpQuaternions(Quaternion qa, Quaternion qb, decimal t)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "slerpQuaternions" }, qa, qb, t
                }
            );
        }

        public bool equals(Quaternion v)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, v
                }
            );
        }

        public Quaternion fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
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

        public CachedEntity multiplyVector3(object v)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "multiplyVector3" }, v
                }
            );
        }

        public Quaternion random()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "random" }
                }
            );
        }
    #endregion
}
