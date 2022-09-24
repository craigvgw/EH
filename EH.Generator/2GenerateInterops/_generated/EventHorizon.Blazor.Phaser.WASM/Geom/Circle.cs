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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Circle>))]
    public class Circle : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static decimal Area(Circle circle)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "Area" }, circle
                }
            );
        }

        public static decimal Circumference(Circle circle)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "Circumference" }, circle
                }
            );
        }

        public static O CircumferencePoint<O>(Circle circle, decimal angle, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "CircumferencePoint" }, circle, angle, out
                }
            );
        }

        public static Circle Clone(Circle source)
        {
            return EventHorizonBlazorInterop.FuncClass<Circle>(
                entity => new Circle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "Clone" }, source
                }
            );
        }

        public static bool Contains(Circle circle, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "Contains" }, circle, x, y
                }
            );
        }

        public static bool ContainsPoint(Circle circle, Point point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "ContainsPoint" }, circle, point
                }
            );
        }

        public static bool ContainsRect(Circle circle, Rectangle rect)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "ContainsRect" }, circle, rect
                }
            );
        }

        public static O CopyFrom<O>(Circle source, O dest) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "CopyFrom" }, source, dest
                }
            );
        }

        public static bool Equals(Circle circle, Circle toCompare)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "Equals" }, circle, toCompare
                }
            );
        }

        public static O GetBounds<O>(Circle circle, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "GetBounds" }, circle, out
                }
            );
        }

        public static O GetPoint<O>(Circle circle, decimal position, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "GetPoint" }, circle, position, out
                }
            );
        }

        public static Point[] GetPoints(Circle circle, decimal quantity, System.Nullable<decimal> stepRate = null, CachedEntity[] output = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Point>(
                entity => new Point() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "GetPoints" }, circle, quantity, stepRate, output
                }
            );
        }

        public static O Offset<O>(O circle, decimal x, decimal y) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "Offset" }, circle, x, y
                }
            );
        }

        public static O OffsetPoint<O>(O circle, Point point) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "OffsetPoint" }, circle, point
                }
            );
        }

        public static O Random<O>(Circle circle, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Geom", "Circle", "Random" }, circle, out
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

        
        public decimal diameter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "diameter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diameter",
                    value
                );
            }
        }

        
        public decimal left
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "left"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "left",
                    value
                );
            }
        }

        
        public decimal right
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "right"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "right",
                    value
                );
            }
        }

        
        public decimal top
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "top"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "top",
                    value
                );
            }
        }

        
        public decimal bottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bottom",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Circle() : base() { }

        public Circle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Circle(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> radius = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Geom", "Circle" },
                x, y, radius
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool contains(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, x, y
                }
            );
        }

        public O getPoint<O>(decimal position, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoint" }, position, out
                }
            );
        }

        public O getPoints<O>(decimal quantity, System.Nullable<decimal> stepRate = null, O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoints" }, quantity, stepRate, output
                }
            );
        }

        public O getRandomPoint<O>(O point = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRandomPoint" }, point
                }
            );
        }

        public Circle setTo(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> radius = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Circle>(
                entity => new Circle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTo" }, x, y, radius
                }
            );
        }

        public Circle setEmpty()
        {
            return EventHorizonBlazorInterop.FuncClass<Circle>(
                entity => new Circle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEmpty" }
                }
            );
        }

        public Circle setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Circle>(
                entity => new Circle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y
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
        #endregion
    }
}