/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LineCurve>))]
public class LineCurve : Curve<Vector2>
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
    #endregion
    
    #region Constructor
        public LineCurve() : base() { }

        public LineCurve(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LineCurve(
            Vector2 v1, Vector2 v2
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LineCurve" },
                v1, v2
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
