/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Line3>))]
public class Line3 : CachedEntityObject
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
        private Vector3 __start;
        public Vector3 start
        {
            get
            {
            if(__start == null)
            {
                __start = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "start",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __start;
            }
            set
            {
__start = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "start",
                    value
                );
            }
        }

        private Vector3 __end;
        public Vector3 end
        {
            get
            {
            if(__end == null)
            {
                __end = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "end",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __end;
            }
            set
            {
__end = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "end",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Line3() : base() { }

        public Line3(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Line3(
            Vector3 start = null, Vector3 end = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Line3" },
                start, end
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Line3 set(Vector3 start = null, Vector3 end = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Line3>(
                entity => new Line3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, start, end
                }
            );
        }

        public Line3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Line3>(
                entity => new Line3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Line3 copy(Line3 line)
        {
            return EventHorizonBlazorInterop.FuncClass<Line3>(
                entity => new Line3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, line
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

        public Vector3 delta(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "delta" }, target
                }
            );
        }

        public decimal distanceSq()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distanceSq" }
                }
            );
        }

        public decimal distance()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "distance" }
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

        public decimal closestPointToPointParameter(Vector3 point, System.Nullable<bool> clampToLine = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "closestPointToPointParameter" }, point, clampToLine
                }
            );
        }

        public Vector3 closestPointToPoint(Vector3 point, bool clampToLine, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "closestPointToPoint" }, point, clampToLine, target
                }
            );
        }

        public Line3 applyMatrix4(Matrix4 matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Line3>(
                entity => new Line3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, matrix
                }
            );
        }

        public bool equals(Line3 line)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, line
                }
            );
        }
    #endregion
}
