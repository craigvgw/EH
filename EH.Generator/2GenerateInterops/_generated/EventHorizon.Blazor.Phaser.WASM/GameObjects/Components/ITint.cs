/// Generated - Do Not Edit
namespace Phaser.GameObjects.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface ITint : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ITintCachedEntity>))]
    public class ITintCachedEntity : CachedEntityObject, ITint
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
        
        public decimal tintTopLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintTopLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintTopLeft",
                    value
                );
            }
        }

        
        public decimal tintTopRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintTopRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintTopRight",
                    value
                );
            }
        }

        
        public decimal tintBottomLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintBottomLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintBottomLeft",
                    value
                );
            }
        }

        
        public decimal tintBottomRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintBottomRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintBottomRight",
                    value
                );
            }
        }

        
        public bool tintFill
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "tintFill"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintFill",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        
        public bool isTinted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isTinted"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ITintCachedEntity() : base() { }

        public ITintCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ITintCachedEntity clearTint()
        {
            return EventHorizonBlazorInterop.FuncClass<ITintCachedEntity>(
                entity => new ITintCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearTint" }
                }
            );
        }

        public ITintCachedEntity setTint(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITintCachedEntity>(
                entity => new ITintCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTint" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public ITintCachedEntity setTintFill(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITintCachedEntity>(
                entity => new ITintCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTintFill" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }
        #endregion
    }
}