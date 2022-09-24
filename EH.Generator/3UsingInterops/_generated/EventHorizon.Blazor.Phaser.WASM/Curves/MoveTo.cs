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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MoveTo>))]
    public class MoveTo : CachedEntityObject
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
        #endregion
        
        #region Constructor
        public MoveTo() : base() { }

        public MoveTo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public MoveTo(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Curves", "MoveTo" },
                x, y
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public decimal getResolution()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getResolution" }
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