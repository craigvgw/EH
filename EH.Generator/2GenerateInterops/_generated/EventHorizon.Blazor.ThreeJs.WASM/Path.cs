/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Path>))]
public class Path : CurvePath<Vector2>
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
        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private Vector2 __currentPoint;
        public Vector2 currentPoint
        {
            get
            {
            if(__currentPoint == null)
            {
                __currentPoint = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "currentPoint",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentPoint;
            }
            set
            {
__currentPoint = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentPoint",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Path() : base() { }

        public Path(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Path(
            Vector2[] points = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Path" },
                points
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Path fromPoints(Vector2[] vectors)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromPoints" }, vectors
                }
            );
        }

        public Path setFromPoints(Vector2[] vectors)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromPoints" }, vectors
                }
            );
        }

        public Path moveTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, x, y
                }
            );
        }

        public Path lineTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineTo" }, x, y
                }
            );
        }

        public Path quadraticCurveTo(decimal aCPx, decimal aCPy, decimal aX, decimal aY)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "quadraticCurveTo" }, aCPx, aCPy, aX, aY
                }
            );
        }

        public Path bezierCurveTo(decimal aCP1x, decimal aCP1y, decimal aCP2x, decimal aCP2y, decimal aX, decimal aY)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bezierCurveTo" }, aCP1x, aCP1y, aCP2x, aCP2y, aX, aY
                }
            );
        }

        public Path splineThru(Vector2[] pts)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "splineThru" }, pts
                }
            );
        }

        public Path arc(decimal aX, decimal aY, decimal aRadius, decimal aStartAngle, decimal aEndAngle, bool aClockwise)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "arc" }, aX, aY, aRadius, aStartAngle, aEndAngle, aClockwise
                }
            );
        }

        public Path absarc(decimal aX, decimal aY, decimal aRadius, decimal aStartAngle, decimal aEndAngle, bool aClockwise)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "absarc" }, aX, aY, aRadius, aStartAngle, aEndAngle, aClockwise
                }
            );
        }

        public Path ellipse(decimal aX, decimal aY, decimal xRadius, decimal yRadius, decimal aStartAngle, decimal aEndAngle, bool aClockwise, decimal aRotation)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ellipse" }, aX, aY, xRadius, yRadius, aStartAngle, aEndAngle, aClockwise, aRotation
                }
            );
        }

        public Path absellipse(decimal aX, decimal aY, decimal xRadius, decimal yRadius, decimal aStartAngle, decimal aEndAngle, bool aClockwise, decimal aRotation)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "absellipse" }, aX, aY, xRadius, yRadius, aStartAngle, aEndAngle, aClockwise, aRotation
                }
            );
        }
    #endregion
}
