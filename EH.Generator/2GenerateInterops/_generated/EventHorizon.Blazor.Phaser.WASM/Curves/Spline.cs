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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Spline>))]
    public class Spline : Curve
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Spline fromJSON(JSONCurve data)
        {
            return EventHorizonBlazorInterop.FuncClass<Spline>(
                entity => new Spline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Curves", "Spline", "fromJSON" }, data
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public Vector2[] points
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector2>(
                    this.___guid,
                    "points",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "points",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Spline() : base() { }

        public Spline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Spline(
            Vector2[] points = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Curves", "Spline" },
                points
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Spline addPoints(Vector2[] points)
        {
            return EventHorizonBlazorInterop.FuncClass<Spline>(
                entity => new Spline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addPoints" }, points
                }
            );
        }

        public Vector2 addPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addPoint" }, x, y
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

        public JSONCurve toJSON()
        {
            return EventHorizonBlazorInterop.FuncClass<JSONCurve>(
                entity => new JSONCurve() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }
        #endregion
    }
}