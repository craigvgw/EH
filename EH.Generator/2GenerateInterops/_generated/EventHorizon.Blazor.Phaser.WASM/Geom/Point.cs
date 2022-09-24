/// Generated - Do Not Edit
namespace Phaser.Geom
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Point>))]
    public class Point : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static O Ceil<O>(O point) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Ceil" }, point
                }
            );
        }

        public static Point Clone(Point source)
        {
            return EventHorizonBlazorInterop.FuncClass<Point>(
                entity => new Point() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Clone" }, source
                }
            );
        }

        public static O CopyFrom<O>(Point source, O dest) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "CopyFrom" }, source, dest
                }
            );
        }

        public static bool Equals(Point point, Point toCompare)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Equals" }, point, toCompare
                }
            );
        }

        public static O Floor<O>(O point) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Floor" }, point
                }
            );
        }

        public static O GetCentroid<O>(Vector2Like[] points, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "GetCentroid" }, points, out
                }
            );
        }

        public static decimal GetMagnitude(Point point)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "GetMagnitude" }, point
                }
            );
        }

        public static decimal GetMagnitudeSq(Point point)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "GetMagnitudeSq" }, point
                }
            );
        }

        public static O GetRectangleFromPoints<O>(Vector2Like[] points, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "GetRectangleFromPoints" }, points, out
                }
            );
        }

        public static O Interpolate<O>(Point pointA, Point pointB, System.Nullable<decimal> t = null, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Interpolate" }, pointA, pointB, t, out
                }
            );
        }

        public static O Invert<O>(O point) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Invert" }, point
                }
            );
        }

        public static O Negative<O>(Point point, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Negative" }, point, out
                }
            );
        }

        public static O Project<O>(Point pointA, Point pointB, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "Project" }, pointA, pointB, out
                }
            );
        }

        public static O ProjectUnit<O>(Point pointA, Point pointB, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "ProjectUnit" }, pointA, pointB, out
                }
            );
        }

        public static O SetMagnitude<O>(O point, decimal magnitude) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Point", "SetMagnitude" }, point, magnitude
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Point() : base() { }

        public Point(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Point(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Geom", "Point" },
                x, y
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Point setTo(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Point>(
                entity => new Point() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTo" }, x, y
                }
            );
        }
        #endregion
    }
}