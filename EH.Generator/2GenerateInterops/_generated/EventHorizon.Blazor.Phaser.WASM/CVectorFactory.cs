/// Generated - Do Not Edit
namespace MatterJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CVectorFactory>))]
    public class CVectorFactory : CachedEntityObject
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
        public CVectorFactory() : base() { }

        public CVectorFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public CVector create(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, x, y
                }
            );
        }

        public CVector clone(CVector vector)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, vector
                }
            );
        }

        public decimal cross3(CVector vectorA, CVector vectorB, CVector vectorC)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "cross3" }, vectorA, vectorB, vectorC
                }
            );
        }

        public CVector add(CVector vectorA, CVector vectorB, CVector output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, vectorA, vectorB, output
                }
            );
        }

        public decimal angle(CVector vectorA, CVector vectorB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "angle" }, vectorA, vectorB
                }
            );
        }

        public decimal cross(CVector vectorA, CVector vectorB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "cross" }, vectorA, vectorB
                }
            );
        }

        public CVector div(CVector vector, decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "div" }, vector, scalar
                }
            );
        }

        public decimal dot(CVector vectorA, CVector vectorB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "dot" }, vectorA, vectorB
                }
            );
        }

        public decimal magnitude(CVector vector)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "magnitude" }, vector
                }
            );
        }

        public decimal magnitudeSquared(CVector vector)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "magnitudeSquared" }, vector
                }
            );
        }

        public CVector mult(CVector vector, decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "mult" }, vector, scalar
                }
            );
        }

        public CVector neg(CVector vector)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "neg" }, vector
                }
            );
        }

        public CVector normalise(CVector vector)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalise" }, vector
                }
            );
        }

        public CVector perp(CVector vector, System.Nullable<bool> negate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "perp" }, vector, negate
                }
            );
        }

        public CVector rotate(CVector vector, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, vector, angle
                }
            );
        }

        public CVector rotateAbout(CVector vector, decimal angle, CVector point, CVector output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateAbout" }, vector, angle, point, output
                }
            );
        }

        public CVector sub(CVector vectorA, CVector vectorB, CVector optional = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sub" }, vectorA, vectorB, optional
                }
            );
        }
        #endregion
    }
}