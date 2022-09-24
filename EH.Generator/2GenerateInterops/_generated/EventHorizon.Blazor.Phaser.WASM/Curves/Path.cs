/// Generated - Do Not Edit
namespace Phaser.Curves
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Path>))]
    public class Path : CachedEntityObject
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public Curve[] curves
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Curve>(
                    this.___guid,
                    "curves",
                    (entity) =>
                    {
                        return new Curve() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "curves",
                    value
                );
            }
        }

        
        public decimal[] cacheLengths
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "cacheLengths"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cacheLengths",
                    value
                );
            }
        }

        
        public bool autoClose
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClose"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClose",
                    value
                );
            }
        }

        private Vector2 __startPoint;
        public Vector2 startPoint
        {
            get
            {
            if(__startPoint == null)
            {
                __startPoint = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "startPoint",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __startPoint;
            }
            set
            {
__startPoint = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startPoint",
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
            ___guid = entity.___guid;
        }

        public Path(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Curves", "Path" },
                x, y
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Path add(Curve curve)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, curve
                }
            );
        }

        public Path circleTo(decimal radius, System.Nullable<bool> clockwise = null, System.Nullable<decimal> rotation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "circleTo" }, radius, clockwise, rotation
                }
            );
        }

        public Path closePath()
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "closePath" }
                }
            );
        }

        public Path cubicBezierTo(decimal x, decimal y, decimal control1X, System.Nullable<decimal> control1Y = null, System.Nullable<decimal> control2X = null, System.Nullable<decimal> control2Y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cubicBezierTo" }, x, y, control1X, control1Y, control2X, control2Y
                }
            );
        }

        public Path quadraticBezierTo(decimal x, System.Nullable<decimal> y = null, System.Nullable<decimal> controlX = null, System.Nullable<decimal> controlY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "quadraticBezierTo" }, x, y, controlX, controlY
                }
            );
        }

        public G draw<G>(Graphics graphics, System.Nullable<decimal> pointsTotal = null) where G : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<G>(
                entity => new G() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "draw" }, graphics, pointsTotal
                }
            );
        }

        public Path ellipseTo(System.Nullable<decimal> xRadius = null, System.Nullable<decimal> yRadius = null, System.Nullable<decimal> startAngle = null, System.Nullable<decimal> endAngle = null, System.Nullable<bool> clockwise = null, System.Nullable<decimal> rotation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ellipseTo" }, xRadius, yRadius, startAngle, endAngle, clockwise, rotation
                }
            );
        }

        public Path fromJSON(JSONPath data)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromJSON" }, data
                }
            );
        }

        public O getBounds<O>(O out = null, System.Nullable<decimal> accuracy = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, out, accuracy
                }
            );
        }

        public decimal[] getCurveLengths()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCurveLengths" }
                }
            );
        }

        public O getEndPoint<O>(O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEndPoint" }, out
                }
            );
        }

        public decimal getLength()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLength" }
                }
            );
        }

        public O getPoint<O>(decimal t, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoint" }, t, out
                }
            );
        }

        public Vector2[] getPoints(System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoints" }, divisions
                }
            );
        }

        public O getRandomPoint<O>(O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRandomPoint" }, out
                }
            );
        }

        public Vector2[] getSpacedPoints(System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSpacedPoints" }, divisions
                }
            );
        }

        public O getStartPoint<O>(O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getStartPoint" }, out
                }
            );
        }

        public O getTangent<O>(decimal t, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTangent" }, t, out
                }
            );
        }

        public Path lineTo(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineTo" }, x, y
                }
            );
        }

        public Path splineTo(Vector2[] points)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "splineTo" }, points
                }
            );
        }

        public Path moveTo(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, x, y
                }
            );
        }

        public JSONPath toJSON()
        {
            return EventHorizonBlazorInterop.FuncClass<JSONPath>(
                entity => new JSONPath() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }

        public void updateArcLengths()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateArcLengths" }
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}