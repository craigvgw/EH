/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Triangle>))]
public class Triangle : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Vector3 getNormal(Vector3 a, Vector3 b, Vector3 c, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Triangle", "getNormal" }, a, b, c, target
                }
            );
        }

        public static Vector3 getBarycoord(Vector3 point, Vector3 a, Vector3 b, Vector3 c, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Triangle", "getBarycoord" }, point, a, b, c, target
                }
            );
        }

        public static bool containsPoint(Vector3 point, Vector3 a, Vector3 b, Vector3 c)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Triangle", "containsPoint" }, point, a, b, c
                }
            );
        }

        public static Vector2 getUV(Vector3 point, Vector3 p1, Vector3 p2, Vector3 p3, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Triangle", "getUV" }, point, p1, p2, p3, uv1, uv2, uv3, target
                }
            );
        }

        public static bool isFrontFacing(Vector3 a, Vector3 b, Vector3 c, Vector3 direction)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Triangle", "isFrontFacing" }, a, b, c, direction
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        private Vector3 __a;
        public Vector3 a
        {
            get
            {
            if(__a == null)
            {
                __a = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "a",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __a;
            }
            set
            {
__a = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "a",
                    value
                );
            }
        }

        private Vector3 __b;
        public Vector3 b
        {
            get
            {
            if(__b == null)
            {
                __b = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "b",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __b;
            }
            set
            {
__b = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }

        private Vector3 __c;
        public Vector3 c
        {
            get
            {
            if(__c == null)
            {
                __c = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "c",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __c;
            }
            set
            {
__c = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "c",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Triangle() : base() { }

        public Triangle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Triangle(
            Vector3 a = null, Vector3 b = null, Vector3 c = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Triangle" },
                a, b, c
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Triangle set(Vector3 a, Vector3 b, Vector3 c)
        {
            return EventHorizonBlazorInterop.FuncClass<Triangle>(
                entity => new Triangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, a, b, c
                }
            );
        }

        public Triangle setFromPointsAndIndices(Vector3[] points, decimal i0, decimal i1, decimal i2)
        {
            return EventHorizonBlazorInterop.FuncClass<Triangle>(
                entity => new Triangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromPointsAndIndices" }, points, i0, i1, i2
                }
            );
        }

        public Triangle setFromAttributeAndIndices(BufferAttribute attribute, decimal i0, decimal i1, decimal i2)
        {
            return EventHorizonBlazorInterop.FuncClass<Triangle>(
                entity => new Triangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromAttributeAndIndices" }, attribute, i0, i1, i2
                }
            );
        }

        public Triangle clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Triangle>(
                entity => new Triangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Triangle copy(Triangle triangle)
        {
            return EventHorizonBlazorInterop.FuncClass<Triangle>(
                entity => new Triangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, triangle
                }
            );
        }

        public decimal getArea()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getArea" }
                }
            );
        }

        public Vector3 getMidpoint(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMidpoint" }, target
                }
            );
        }

        public Vector3 getNormal(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNormal" }, target
                }
            );
        }

        public Plane getPlane(Plane target)
        {
            return EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPlane" }, target
                }
            );
        }

        public Vector3 getBarycoord(Vector3 point, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBarycoord" }, point, target
                }
            );
        }

        public Vector2 getUV(Vector3 point, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUV" }, point, uv1, uv2, uv3, target
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

        public bool intersectsBox(Box3 box)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsBox" }, box
                }
            );
        }

        public bool isFrontFacing(Vector3 direction)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isFrontFacing" }, direction
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

        public bool equals(Triangle triangle)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, triangle
                }
            );
        }
    #endregion
}
