/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SphericalHarmonics3>))]
public class SphericalHarmonics3 : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static void getBasisAt(Vector3 normal, decimal[] shBasis)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "SphericalHarmonics3", "getBasisAt" }, normal, shBasis
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public Vector3[] coefficients
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "coefficients",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "coefficients",
                    value
                );
            }
        }

        
        public unknown isSphericalHarmonics3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isSphericalHarmonics3"
                );
            }
        }
    #endregion
    
    #region Constructor
        public SphericalHarmonics3() : base() { }

        public SphericalHarmonics3(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public SphericalHarmonics3 set(Vector3[] coefficients)
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, coefficients
                }
            );
        }

        public SphericalHarmonics3 zero()
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "zero" }
                }
            );
        }

        public SphericalHarmonics3 add(SphericalHarmonics3 sh)
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, sh
                }
            );
        }

        public SphericalHarmonics3 addScaledSH(SphericalHarmonics3 sh, decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addScaledSH" }, sh, s
                }
            );
        }

        public SphericalHarmonics3 scale(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, s
                }
            );
        }

        public SphericalHarmonics3 lerp(SphericalHarmonics3 sh, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lerp" }, sh, alpha
                }
            );
        }

        public bool equals(SphericalHarmonics3 sh)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, sh
                }
            );
        }

        public SphericalHarmonics3 copy(SphericalHarmonics3 sh)
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, sh
                }
            );
        }

        public SphericalHarmonics3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public SphericalHarmonics3 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SphericalHarmonics3>(
                entity => new SphericalHarmonics3() { ___guid = entity.___guid },
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

        public Vector3 getAt(Vector3 normal, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAt" }, normal, target
                }
            );
        }

        public Vector3 getIrradianceAt(Vector3 normal, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getIrradianceAt" }, normal, target
                }
            );
        }
    #endregion
}
