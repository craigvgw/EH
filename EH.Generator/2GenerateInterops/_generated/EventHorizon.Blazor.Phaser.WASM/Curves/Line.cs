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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Line>))]
    public class Line : Curve
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Line fromJSON(JSONCurve data)
        {
            return EventHorizonBlazorInterop.FuncClass<Line>(
                entity => new Line() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Curves", "Line", "fromJSON" }, data
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

        private Vector2 __p1;
        public Vector2 p1
        {
            get
            {
            if(__p1 == null)
            {
                __p1 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "p1",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __p1;
            }
            set
            {
__p1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "p1",
                    value
                );
            }
        }

        
        public decimal arcLengthDivisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "arcLengthDivisions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "arcLengthDivisions",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Line() : base() { }

        public Line(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Line(
            Vector2 p0, Vector2 p1 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Curves", "Line" },
                p0, p1
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public O getBounds<O>(O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, out
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

        public decimal getResolution(System.Nullable<decimal> divisions = null)
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

        public O getPointAt<O>(decimal u, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPointAt" }, u, out
                }
            );
        }

        public O getTangent<O>(System.Nullable<decimal> t = null, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTangent" }, t, out
                }
            );
        }

        public decimal getUtoTmapping(decimal u, decimal distance, System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getUtoTmapping" }, u, distance, divisions
                }
            );
        }

        public G draw<G>(G graphics) where G : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<G>(
                entity => new G() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "draw" }, graphics
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