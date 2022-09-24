/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Rectangle>))]
public class Rectangle : CachedEntityObject
{
    #region Static Accessors
        private static Rectangle __EMPTY;
        public static Rectangle EMPTY
        {
            get
            {
            if(__EMPTY == null)
            {
                __EMPTY = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    "Rectangle",
                    "EMPTY",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __EMPTY;
            }
        }
    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal left
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "left"
                );
            }
        }

        
        public decimal right
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "right"
                );
            }
        }

        
        public decimal top
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "top"
                );
            }
        }

        
        public decimal bottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottom"
                );
            }
        }
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

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        private RECT __type;
        public RECT type
        {
            get
            {
            if(__type == null)
            {
                __type = EventHorizonBlazorInterop.GetClass<RECT>(
                    this.___guid,
                    "type",
                    (entity) =>
                    {
                        return new RECT() { ___guid = entity.___guid };
                    }
                );
            }
            return __type;
            }
        }
    #endregion
    
    #region Constructor
        public Rectangle() : base() { }

        public Rectangle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Rectangle(
            string x = null, string y = null, string width = null, string height = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Rectangle" },
                x, y, width, height
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Rectangle clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Rectangle copyFrom(Rectangle rectangle)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, rectangle
                }
            );
        }

        public Rectangle copyTo(Rectangle rectangle)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyTo" }, rectangle
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

        public bool intersects(Rectangle other, Matrix transform = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersects" }, other, transform
                }
            );
        }

        public Rectangle pad(System.Nullable<decimal> paddingX = null, System.Nullable<decimal> paddingY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pad" }, paddingX, paddingY
                }
            );
        }

        public Rectangle fit(Rectangle rectangle)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fit" }, rectangle
                }
            );
        }

        public Rectangle ceil(System.Nullable<decimal> resolution = null, System.Nullable<decimal> eps = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ceil" }, resolution, eps
                }
            );
        }

        public Rectangle enlarge(Rectangle rectangle)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enlarge" }, rectangle
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
