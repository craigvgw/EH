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

    
    
    [JsonConverter(typeof(CachedEntityConverter<QuadraticBezier>))]
    public class QuadraticBezier : Curve
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static QuadraticBezier fromJSON(JSONCurve data)
        {
            return EventHorizonBlazorInterop.FuncClass<QuadraticBezier>(
                entity => new QuadraticBezier() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Phaser", "Curves", "QuadraticBezier", "fromJSON" }, data
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

        private Vector2 __p2;
        public Vector2 p2
        {
            get
            {
            if(__p2 == null)
            {
                __p2 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "p2",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __p2;
            }
            set
            {
__p2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "p2",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public QuadraticBezier() : base() { }

        public QuadraticBezier(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public QuadraticBezier(
            Vector2 p0, Vector2 p1, Vector2 p2
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Curves", "QuadraticBezier" },
                p0, p1, p2
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

        public G draw<G>(G graphics, System.Nullable<decimal> pointsTotal = null) where G : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<G>(
                entity => new G() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "draw" }, graphics, pointsTotal
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