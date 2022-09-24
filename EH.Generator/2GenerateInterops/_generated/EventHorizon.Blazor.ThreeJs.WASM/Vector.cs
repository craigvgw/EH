/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface Vector : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<VectorCachedEntity>))]
public class VectorCachedEntity : CachedEntityObject, Vector
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

    #endregion
    
    #region Constructor
        public VectorCachedEntity() : base() { }

        public VectorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public VectorCachedEntity setComponent(decimal index, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
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

        public VectorCachedEntity set(decimal[] args)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, args
                }
            );
        }

        public VectorCachedEntity setScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScalar" }, scalar
                }
            );
        }

        public VectorCachedEntity copy(Vector v)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, v
                }
            );
        }

        public VectorCachedEntity add(Vector v)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, v
                }
            );
        }

        public VectorCachedEntity addVectors(Vector a, Vector b)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addVectors" }, a, b
                }
            );
        }

        public VectorCachedEntity addScaledVector(Vector vector, decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScaledVector" }, vector, scale
                }
            );
        }

        public VectorCachedEntity addScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScalar" }, scalar
                }
            );
        }

        public VectorCachedEntity sub(Vector v)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sub" }, v
                }
            );
        }

        public VectorCachedEntity subVectors(Vector a, Vector b)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subVectors" }, a, b
                }
            );
        }

        public VectorCachedEntity multiplyScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyScalar" }, s
                }
            );
        }

        public VectorCachedEntity divideScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divideScalar" }, s
                }
            );
        }

        public VectorCachedEntity negate()
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public decimal dot(Vector v)
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

        public VectorCachedEntity normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public decimal distanceTo(Vector v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceTo" }, v
                }
            );
        }

        public decimal distanceToSquared(Vector v)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToSquared" }, v
                }
            );
        }

        public VectorCachedEntity setLength(decimal l)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLength" }, l
                }
            );
        }

        public VectorCachedEntity lerp(Vector v, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerp" }, v, alpha
                }
            );
        }

        public bool equals(Vector v)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, v
                }
            );
        }

        public VectorCachedEntity clone()
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity>(
                entity => new VectorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
    #endregion
}
