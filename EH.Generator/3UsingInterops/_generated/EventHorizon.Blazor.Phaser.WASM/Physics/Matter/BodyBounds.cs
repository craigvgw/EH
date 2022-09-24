/// Generated - Do Not Edit
namespace Phaser.Physics.Matter
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<BodyBounds>))]
    public class BodyBounds : CachedEntityObject
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
        private Vector2 __boundsCenter;
        public Vector2 boundsCenter
        {
            get
            {
            if(__boundsCenter == null)
            {
                __boundsCenter = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "boundsCenter",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundsCenter;
            }
            set
            {
__boundsCenter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundsCenter",
                    value
                );
            }
        }

        private Vector2 __centerDiff;
        public Vector2 centerDiff
        {
            get
            {
            if(__centerDiff == null)
            {
                __centerDiff = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "centerDiff",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __centerDiff;
            }
            set
            {
__centerDiff = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "centerDiff",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public BodyBounds() : base() { }

        public BodyBounds(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public bool parseBody(MatterBody body)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "parseBody" }, body
                }
            );
        }

        public Vector2 getTopLeft(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopLeft" }, body, x, y
                }
            );
        }

        public Vector2 getTopCenter(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopCenter" }, body, x, y
                }
            );
        }

        public Vector2 getTopRight(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopRight" }, body, x, y
                }
            );
        }

        public Vector2 getLeftCenter(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLeftCenter" }, body, x, y
                }
            );
        }

        public Vector2 getCenter(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCenter" }, body, x, y
                }
            );
        }

        public Vector2 getRightCenter(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRightCenter" }, body, x, y
                }
            );
        }

        public Vector2 getBottomLeft(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomLeft" }, body, x, y
                }
            );
        }

        public Vector2 getBottomCenter(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomCenter" }, body, x, y
                }
            );
        }

        public Vector2 getBottomRight(MatterBody body, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomRight" }, body, x, y
                }
            );
        }
        #endregion
    }
}