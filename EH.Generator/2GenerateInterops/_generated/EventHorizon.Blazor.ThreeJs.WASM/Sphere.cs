/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Sphere>))]
public class Sphere : CachedEntityObject
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
        private Vector3 __center;
        public Vector3 center
        {
            get
            {
            if(__center == null)
            {
                __center = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "center",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __center;
            }
            set
            {
__center = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "center",
                    value
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Sphere() : base() { }

        public Sphere(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Sphere(
            Vector3 center = null, System.Nullable<decimal> radius = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Sphere" },
                center, radius
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Sphere set(Vector3 center, decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, center, radius
                }
            );
        }

        public Sphere setFromPoints(Vector3[] points, Vector3 optionalCenter = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromPoints" }, points, optionalCenter
                }
            );
        }

        public Sphere clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Sphere copy(Sphere sphere)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, sphere
                }
            );
        }

        public Sphere expandByPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByPoint" }, point
                }
            );
        }

        public bool isEmpty()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isEmpty" }
                }
            );
        }

        public Sphere makeEmpty()
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeEmpty" }
                }
            );
        }

        public bool containsPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
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

        public bool intersectsSphere(Sphere sphere)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsSphere" }, sphere
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

        public bool intersectsPlane(Plane plane)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsPlane" }, plane
                }
            );
        }

        public Vector3 clampPoint(Vector3 point, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clampPoint" }, point, target
                }
            );
        }

        public Box3 getBoundingBox(Box3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoundingBox" }, target
                }
            );
        }

        public Sphere applyMatrix4(Matrix4 matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, matrix
                }
            );
        }

        public Sphere translate(Vector3 offset)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, offset
                }
            );
        }

        public bool equals(Sphere sphere)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, sphere
                }
            );
        }

        public Sphere union(Sphere sphere)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "union" }, sphere
                }
            );
        }

        public CachedEntity empty()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "empty" }
                }
            );
        }
    #endregion
}
