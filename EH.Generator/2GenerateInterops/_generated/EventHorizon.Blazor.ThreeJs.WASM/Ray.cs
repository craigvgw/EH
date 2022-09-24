/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Ray>))]
public class Ray : CachedEntityObject
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
        private Vector3 __origin;
        public Vector3 origin
        {
            get
            {
            if(__origin == null)
            {
                __origin = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "origin",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __origin;
            }
            set
            {
__origin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "origin",
                    value
                );
            }
        }

        private Vector3 __direction;
        public Vector3 direction
        {
            get
            {
            if(__direction == null)
            {
                __direction = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction;
            }
            set
            {
__direction = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Ray() : base() { }

        public Ray(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Ray(
            Vector3 origin = null, Vector3 direction = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Ray" },
                origin, direction
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Ray set(Vector3 origin, Vector3 direction)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, origin, direction
                }
            );
        }

        public Ray clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Ray copy(Ray ray)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, ray
                }
            );
        }

        public Vector3 at(decimal t, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "at" }, t, target
                }
            );
        }

        public Ray lookAt(Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lookAt" }, v
                }
            );
        }

        public Ray recast(decimal t)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "recast" }, t
                }
            );
        }

        public Vector3 closestPointToPoint(Vector3 point, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "closestPointToPoint" }, point, target
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

        public decimal distanceSqToPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceSqToPoint" }, point
                }
            );
        }

        public decimal distanceSqToSegment(Vector3 v0, Vector3 v1, Vector3 optionalPointOnRay = null, Vector3 optionalPointOnSegment = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceSqToSegment" }, v0, v1, optionalPointOnRay, optionalPointOnSegment
                }
            );
        }

        public Vector3 intersectSphere(Sphere sphere, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectSphere" }, sphere, target
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

        public decimal distanceToPlane(Plane plane)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToPlane" }, plane
                }
            );
        }

        public Vector3 intersectPlane(Plane plane, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectPlane" }, plane, target
                }
            );
        }

        public bool intersectsPlane(Plane plane)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsPlane" }, plane
                }
            );
        }

        public Vector3 intersectBox(Box3 box, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectBox" }, box, target
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

        public Vector3 intersectTriangle(Vector3 a, Vector3 b, Vector3 c, bool backfaceCulling, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectTriangle" }, a, b, c, backfaceCulling, target
                }
            );
        }

        public Ray applyMatrix4(Matrix4 matrix4)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, matrix4
                }
            );
        }

        public bool equals(Ray ray)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, ray
                }
            );
        }

        public CachedEntity isIntersectionBox(object b)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "isIntersectionBox" }, b
                }
            );
        }

        public CachedEntity isIntersectionPlane(object p)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "isIntersectionPlane" }, p
                }
            );
        }

        public CachedEntity isIntersectionSphere(object s)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "isIntersectionSphere" }, s
                }
            );
        }
    #endregion
}
