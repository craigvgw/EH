/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Box2>))]
public class Box2 : CachedEntityObject
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
        private Vector2 __min;
        public Vector2 min
        {
            get
            {
            if(__min == null)
            {
                __min = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "min",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
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

        private Vector2 __max;
        public Vector2 max
        {
            get
            {
            if(__max == null)
            {
                __max = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "max",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
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
    #endregion
    
    #region Constructor
        public Box2() : base() { }

        public Box2(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Box2(
            Vector2 min = null, Vector2 max = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Box2" },
                min, max
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Box2 set(Vector2 min, Vector2 max)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, min, max
                }
            );
        }

        public Box2 setFromPoints(Vector2[] points)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromPoints" }, points
                }
            );
        }

        public Box2 setFromCenterAndSize(Vector2 center, Vector2 size)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromCenterAndSize" }, center, size
                }
            );
        }

        public Box2 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Box2 copy(Box2 box)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, box
                }
            );
        }

        public Box2 makeEmpty()
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
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

        public Vector2 getCenter(Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCenter" }, target
                }
            );
        }

        public Vector2 getSize(Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSize" }, target
                }
            );
        }

        public Box2 expandByPoint(Vector2 point)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByPoint" }, point
                }
            );
        }

        public Box2 expandByVector(Vector2 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByVector" }, vector
                }
            );
        }

        public Box2 expandByScalar(decimal scalar)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "expandByScalar" }, scalar
                }
            );
        }

        public bool containsPoint(Vector2 point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
                }
            );
        }

        public bool containsBox(Box2 box)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsBox" }, box
                }
            );
        }

        public Vector2 getParameter(Vector2 point, Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParameter" }, point, target
                }
            );
        }

        public bool intersectsBox(Box2 box)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsBox" }, box
                }
            );
        }

        public Vector2 clampPoint(Vector2 point, Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clampPoint" }, point, target
                }
            );
        }

        public decimal distanceToPoint(Vector2 point)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceToPoint" }, point
                }
            );
        }

        public Box2 intersect(Box2 box)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersect" }, box
                }
            );
        }

        public Box2 union(Box2 box)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "union" }, box
                }
            );
        }

        public Box2 translate(Vector2 offset)
        {
            return EventHorizonBlazorInterop.FuncClass<Box2>(
                entity => new Box2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, offset
                }
            );
        }

        public bool equals(Box2 box)
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
    #endregion
}
