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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Curve>))]
    public class Curve : CachedEntityObject
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

        
        public decimal defaultDivisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultDivisions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultDivisions",
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

        
        public decimal[] cacheArcLengths
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "cacheArcLengths"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cacheArcLengths",
                    value
                );
            }
        }

        
        public bool needsUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needsUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needsUpdate",
                    value
                );
            }
        }

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Curve() : base() { }

        public Curve(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Curve(
            string type
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Curves", "Curve" },
                type
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public Rectangle getBounds(Rectangle out = null, System.Nullable<decimal> accuracy = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, out, accuracy
                }
            );
        }

        public Point[] getDistancePoints(decimal distance)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Point>(
                entity => new Point() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDistancePoints" }, distance
                }
            );
        }

        public Vector2 getEndPoint(Vector2 out = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
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

        public decimal[] getLengths(System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLengths" }, divisions
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

        public O getPoints<O>(System.Nullable<decimal> divisions = null, System.Nullable<decimal> stepRate = null, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoints" }, divisions, stepRate, out
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

        public Vector2[] getSpacedPoints(System.Nullable<decimal> divisions = null, System.Nullable<decimal> stepRate = null, CachedEntity[] out = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSpacedPoints" }, divisions, stepRate, out
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

        public O getTangentAt<O>(decimal u, O out = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTangentAt" }, u, out
                }
            );
        }

        public decimal getTFromDistance(decimal distance, System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTFromDistance" }, distance, divisions
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

        public void updateArcLengths()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateArcLengths" }
                }
            );
        }
        #endregion
    }
}