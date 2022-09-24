/// Generated - Do Not Edit
namespace Phaser.Display
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<RGB>))]
    public class RGB : CachedEntityObject
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
        
        public bool dirty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dirty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirty",
                    value
                );
            }
        }

        
        public decimal r
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "r"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "r",
                    value
                );
            }
        }

        
        public decimal g
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "g"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "g",
                    value
                );
            }
        }

        
        public decimal b
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public RGB() : base() { }

        public RGB(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public RGB(
            System.Nullable<decimal> red = null, System.Nullable<decimal> green = null, System.Nullable<decimal> blue = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Display", "RGB" },
                red, green, blue
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void onChangeCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onChangeCallback" }
                }
            );
        }

        public RGB set(System.Nullable<decimal> red = null, System.Nullable<decimal> green = null, System.Nullable<decimal> blue = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RGB>(
                entity => new RGB() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, red, green, blue
                }
            );
        }

        public bool equals(decimal red, decimal green, decimal blue)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, red, green, blue
                }
            );
        }

        public void onChange()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onChange" }
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