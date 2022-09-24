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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CVector>))]
    public class CVector : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static CVector create(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "create" }, x, y
                }
            );
        }

        public static CVector clone(CVector vector)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "clone" }, vector
                }
            );
        }

        public static decimal cross3(CVector vectorA, CVector vectorB, CVector vectorC)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "cross3" }, vectorA, vectorB, vectorC
                }
            );
        }

        public static CVector add(CVector vectorA, CVector vectorB, CVector output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "add" }, vectorA, vectorB, output
                }
            );
        }

        public static decimal angle(CVector vectorA, CVector vectorB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "angle" }, vectorA, vectorB
                }
            );
        }

        public static decimal cross(CVector vectorA, CVector vectorB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "cross" }, vectorA, vectorB
                }
            );
        }

        public static CVector div(CVector vector, decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "div" }, vector, scalar
                }
            );
        }

        public static Number dot(CVector vectorA, CVector vectorB)
        {
            return EventHorizonBlazorInterop.FuncClass<Number>(
                entity => new Number() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "dot" }, vectorA, vectorB
                }
            );
        }

        public static decimal magnitude(CVector vector)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "magnitude" }, vector
                }
            );
        }

        public static decimal magnitudeSquared(CVector vector)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "magnitudeSquared" }, vector
                }
            );
        }

        public static CVector mult(CVector vector, decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "mult" }, vector, scalar
                }
            );
        }

        public static CVector neg(CVector vector)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "neg" }, vector
                }
            );
        }

        public static CVector normalise(CVector vector)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "normalise" }, vector
                }
            );
        }

        public static CVector perp(CVector vector, System.Nullable<bool> negate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "perp" }, vector, negate
                }
            );
        }

        public static CVector rotate(CVector vector, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "rotate" }, vector, angle
                }
            );
        }

        public static CVector rotateAbout(CVector vector, decimal angle, CVector point, CVector output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "rotateAbout" }, vector, angle, point, output
                }
            );
        }

        public static CVector sub(CVector vectorA, CVector vectorB, CVector optional = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVector", "sub" }, vectorA, vectorB, optional
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
        #endregion
        
        #region Constructor
        public CVector() : base() { }

        public CVector(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}