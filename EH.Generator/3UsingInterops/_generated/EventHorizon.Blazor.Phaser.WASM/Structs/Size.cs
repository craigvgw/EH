/// Generated - Do Not Edit
namespace Phaser.Structs
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Size>))]
    public class Size : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Phaser",
                    "Structs.Size.NONE"
                );
            }
        }

        
        public static decimal WIDTH_CONTROLS_HEIGHT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Phaser",
                    "Structs.Size.WIDTH_CONTROLS_HEIGHT"
                );
            }
        }

        
        public static decimal HEIGHT_CONTROLS_WIDTH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Phaser",
                    "Structs.Size.HEIGHT_CONTROLS_WIDTH"
                );
            }
        }

        
        public static decimal FIT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Phaser",
                    "Structs.Size.FIT"
                );
            }
        }

        
        public static decimal ENVELOP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Phaser",
                    "Structs.Size.ENVELOP"
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal aspectMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aspectMode"
                );
            }
        }

        
        public decimal aspectRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aspectRatio"
                );
            }
        }

        
        public decimal minWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minWidth"
                );
            }
        }

        
        public decimal minHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minHeight"
                );
            }
        }

        
        public decimal maxWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxWidth"
                );
            }
        }

        
        public decimal maxHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxHeight"
                );
            }
        }

        private Vector2 __snapTo;
        public Vector2 snapTo
        {
            get
            {
            if(__snapTo == null)
            {
                __snapTo = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "snapTo",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __snapTo;
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
        #endregion
        
        #region Constructor
        public Size() : base() { }

        public Size(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Size(
            System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> aspectMode = null, object parent = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Structs", "Size" },
                width, height, aspectMode, parent
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Size setAspectMode(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAspectMode" }, value
                }
            );
        }

        public Size setSnap(System.Nullable<decimal> snapWidth = null, System.Nullable<decimal> snapHeight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSnap" }, snapWidth, snapHeight
                }
            );
        }

        public Size setParent(object parent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setParent" }, parent
                }
            );
        }

        public Size setMin(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMin" }, width, height
                }
            );
        }

        public Size setMax(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMax" }, width, height
                }
            );
        }

        public Size setSize(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public Size setAspectRatio(decimal ratio)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAspectRatio" }, ratio
                }
            );
        }

        public Size resize(decimal width, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }

        public decimal getNewWidth(decimal value, System.Nullable<bool> checkParent = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getNewWidth" }, value, checkParent
                }
            );
        }

        public decimal getNewHeight(decimal value, System.Nullable<bool> checkParent = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getNewHeight" }, value, checkParent
                }
            );
        }

        public Size constrain(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> fit = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "constrain" }, width, height, fit
                }
            );
        }

        public Size fitTo(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fitTo" }, width, height
                }
            );
        }

        public Size envelop(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "envelop" }, width, height
                }
            );
        }

        public Size setWidth(decimal width)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setWidth" }, width
                }
            );
        }

        public Size setHeight(decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHeight" }, height
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

        public void setCSS(object element)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCSS" }, element
                }
            );
        }

        public Size copy(Size destination)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, destination
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}