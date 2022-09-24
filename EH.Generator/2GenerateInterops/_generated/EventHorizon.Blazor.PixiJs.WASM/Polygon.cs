/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Polygon>))]
public class Polygon : CachedEntityObject
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
        
        public decimal[] points
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "points"
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

        
        public bool closeStroke
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "closeStroke"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "closeStroke",
                    value
                );
            }
        }

        private POLY __type;
        public POLY type
        {
            get
            {
            if(__type == null)
            {
                __type = EventHorizonBlazorInterop.GetClass<POLY>(
                    this.___guid,
                    "type",
                    (entity) =>
                    {
                        return new POLY() { ___guid = entity.___guid };
                    }
                );
            }
            return __type;
            }
        }
    #endregion
    
    #region Constructor
        public Polygon() : base() { }

        public Polygon(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Polygon(
            IPointData[] points
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Polygon" },
                points
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Polygon clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Polygon>(
                entity => new Polygon() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public bool contains(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, x, y
                }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }
    #endregion
}
