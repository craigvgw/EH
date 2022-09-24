/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CubicBezierCurve>))]
public class CubicBezierCurve : Curve<Vector2>
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

        private Vector2 __v0;
        public Vector2 v0
        {
            get
            {
            if(__v0 == null)
            {
                __v0 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "v0",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __v0;
            }
            set
            {
__v0 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v0",
                    value
                );
            }
        }

        private Vector2 __v1;
        public Vector2 v1
        {
            get
            {
            if(__v1 == null)
            {
                __v1 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "v1",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __v1;
            }
            set
            {
__v1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v1",
                    value
                );
            }
        }

        private Vector2 __v2;
        public Vector2 v2
        {
            get
            {
            if(__v2 == null)
            {
                __v2 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "v2",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __v2;
            }
            set
            {
__v2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v2",
                    value
                );
            }
        }

        private Vector2 __v3;
        public Vector2 v3
        {
            get
            {
            if(__v3 == null)
            {
                __v3 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "v3",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __v3;
            }
            set
            {
__v3 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v3",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CubicBezierCurve() : base() { }

        public CubicBezierCurve(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CubicBezierCurve(
            Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CubicBezierCurve" },
                v0, v1, v2, v3
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
