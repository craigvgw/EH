/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Circle>))]
public class Circle : CachedEntityObject
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

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        private CIRC __type;
        public CIRC type
        {
            get
            {
            if(__type == null)
            {
                __type = EventHorizonBlazorInterop.GetClass<CIRC>(
                    this.___guid,
                    "type",
                    (entity) =>
                    {
                        return new CIRC() { ___guid = entity.___guid };
                    }
                );
            }
            return __type;
            }
        }
    #endregion
    
    #region Constructor
        public Circle() : base() { }

        public Circle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Circle(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> radius = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Circle" },
                x, y, radius
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Circle clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Circle>(
                entity => new Circle() { ___guid = entity.___guid },
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

        public Rectangle getBounds()
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }
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
