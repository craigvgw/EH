/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Box3>))]
public class Box3 : CachedEntityObject
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
        private Vector3 __min;
        public Vector3 min
        {
            get
            {
            if(__min == null)
            {
                __min = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "min",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __min;
            }
            set
            {
__min = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "min",
                    value
                );
            }
        }

        private Vector3 __max;
        public Vector3 max
        {
            get
            {
            if(__max == null)
            {
                __max = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "max",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __max;
            }
            set
            {
__max = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "max",
                    value
                );
            }
        }

        
        public unknown isBox3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isBox3"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Box3() : base() { }

        public Box3(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Box3(
            Vector3 min = null, Vector3 max = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Box3" },
                min, max
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Box3 set(Vector3 min, Vector3 max)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, min, max
                }
            );
        }

        public Box3 setFromArray(decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromArray" }, array
                }
            );
        }

        public Box3 setFromBufferAttribute(BufferAttribute bufferAttribute)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromBufferAttribute" }, bufferAttribute
                }
            );
        }

        public Box3 setFromPoints(Vector3[] points)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromPoints" }, points
                }
            );
        }

        public Box3 setFromCenterAndSize(Vector3 center, Vector3 size)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromCenterAndSize" }, center, size
                }
            );
        }

        public Box3 setFromObject(Object3D @object, System.Nullable<bool> precise = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromObject" }, @object, precise
                }
            );
        }

        public Box3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Box3 copy(Box3 box)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, box
                }
            );
        }

        public Box3 makeEmpty()
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeEmpty" }
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

        public Vector3 getCenter(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCenter" }, target
                }
            );
        }

        public Vector3 getSize(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSize" }, target
                }
            );
        }

        public Box3 expandByPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByPoint" }, point
                }
            );
        }

        public Box3 expandByVector(Vector3 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByVector" }, vector
                }
            );
        }

        public Box3 expandByScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByScalar" }, scalar
                }
            );
        }

        public Box3 expandByObject(Object3D @object, System.Nullable<bool> precise = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByObject" }, @object, precise
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

        public bool containsBox(Box3 box)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsBox" }, box
                }
            );
        }

        public Vector3 getParameter(Vector3 point, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParameter" }, point, target
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

        public bool intersectsPlane(Plane plane)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsPlane" }, plane
                }
            );
        }

        public bool intersectsTriangle(Triangle triangle)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsTriangle" }, triangle
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

        public decimal distanceToPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToPoint" }, point
                }
            );
        }

        public Sphere getBoundingSphere(Sphere target)
        {
            return EventHorizonBlazorInterop.FuncClass<Sphere>(
                entity => new Sphere() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoundingSphere" }, target
                }
            );
        }

        public Box3 intersect(Box3 box)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersect" }, box
                }
            );
        }

        public Box3 union(Box3 box)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "union" }, box
                }
            );
        }

        public Box3 applyMatrix4(Matrix4 matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, matrix
                }
            );
        }

        public Box3 translate(Vector3 offset)
        {
            return EventHorizonBlazorInterop.FuncClass<Box3>(
                entity => new Box3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, offset
                }
            );
        }

        public bool equals(Box3 box)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, box
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

        public CachedEntity isIntersectionBox(object b)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "isIntersectionBox" }, b
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
