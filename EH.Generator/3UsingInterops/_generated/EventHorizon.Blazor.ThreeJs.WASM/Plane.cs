/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Plane>))]
public class Plane : CachedEntityObject
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
        private Vector3 __normal;
        public Vector3 normal
        {
            get
            {
            if(__normal == null)
            {
                __normal = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __normal;
            }
            set
            {
__normal = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normal",
                    value
                );
            }
        }

        
        public decimal constant
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "constant"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constant",
                    value
                );
            }
        }

        
        public unknown isPlane
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isPlane"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Plane() : base() { }

        public Plane(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Plane(
            Vector3 normal = null, System.Nullable<decimal> constant = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Plane" },
                normal, constant
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Plane set(Vector3 normal, decimal constant)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, normal, constant
                }
            );
        }

        public Plane setComponents(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setComponents" }, x, y, z, w
                }
            );
        }

        public Plane setFromNormalAndCoplanarPoint(Vector3 normal, Vector3 point)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromNormalAndCoplanarPoint" }, normal, point
                }
            );
        }

        public Plane setFromCoplanarPoints(Vector3 a, Vector3 b, Vector3 c)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromCoplanarPoints" }, a, b, c
                }
            );
        }

        public Plane clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Plane copy(Plane plane)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, plane
                }
            );
        }

        public Plane normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Plane negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public decimal distanceToPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToPoint" }, point
                }
            );
        }

        public decimal distanceToSphere(Sphere sphere)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToSphere" }, sphere
                }
            );
        }

        public Vector3 projectPoint(Vector3 point, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "projectPoint" }, point, target
                }
            );
        }

        public Vector3 intersectLine(Line3 line, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectLine" }, line, target
                }
            );
        }

        public bool intersectsLine(Line3 line)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsLine" }, line
                }
            );
        }

        public bool intersectsBox(Box3 box)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsBox" }, box
                }
            );
        }

        public bool intersectsSphere(Sphere sphere)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsSphere" }, sphere
                }
            );
        }

        public Vector3 coplanarPoint(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "coplanarPoint" }, target
                }
            );
        }

        public Plane applyMatrix4(Matrix4 matrix, Matrix3 optionalNormalMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, matrix, optionalNormalMatrix
                }
            );
        }

        public Plane translate(Vector3 offset)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, offset
                }
            );
        }

        public bool equals(Plane plane)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, plane
                }
            );
        }

        public CachedEntity isIntersectionLine(object l)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "isIntersectionLine" }, l
                }
            );
        }
    #endregion
}
