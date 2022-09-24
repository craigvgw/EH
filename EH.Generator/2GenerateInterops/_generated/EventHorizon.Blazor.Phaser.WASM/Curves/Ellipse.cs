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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Ellipse>))]
    public class Ellipse : Curve
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Ellipse fromJSON(JSONEllipseCurve data)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Curves", "Ellipse", "fromJSON" }, data
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Vector2 __p0;
        public Vector2 p0
        {
            get
            {
            if(__p0 == null)
            {
                __p0 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "p0",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __p0;
            }
            set
            {
__p0 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "p0",
                    value
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

        
        public decimal xRadius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "xRadius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xRadius",
                    value
                );
            }
        }

        
        public decimal yRadius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "yRadius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "yRadius",
                    value
                );
            }
        }

        
        public decimal startAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startAngle",
                    value
                );
            }
        }

        
        public decimal endAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "endAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "endAngle",
                    value
                );
            }
        }

        
        public bool clockwise
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clockwise"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clockwise",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Ellipse() : base() { }

        public Ellipse(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Ellipse(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> xRadius = null, System.Nullable<decimal> yRadius = null, System.Nullable<decimal> startAngle = null, System.Nullable<decimal> endAngle = null, System.Nullable<bool> clockwise = null, System.Nullable<decimal> rotation = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Curves", "Ellipse" },
                x, y, xRadius, yRadius, startAngle, endAngle, clockwise, rotation
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public decimal getResolution(decimal divisions)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getResolution" }, divisions
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

        public Ellipse setXRadius(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXRadius" }, value
                }
            );
        }

        public Ellipse setYRadius(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setYRadius" }, value
                }
            );
        }

        public Ellipse setWidth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setWidth" }, value
                }
            );
        }

        public Ellipse setHeight(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHeight" }, value
                }
            );
        }

        public Ellipse setStartAngle(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setStartAngle" }, value
                }
            );
        }

        public Ellipse setEndAngle(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEndAngle" }, value
                }
            );
        }

        public Ellipse setClockwise(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setClockwise" }, value
                }
            );
        }

        public Ellipse setRotation(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, value
                }
            );
        }

        public JSONEllipseCurve toJSON()
        {
            return EventHorizonBlazorInterop.FuncClass<JSONEllipseCurve>(
                entity => new JSONEllipseCurve() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }
        #endregion
    }
}