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

    public interface IOrigin : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IOriginCachedEntity>))]
    public class IOriginCachedEntity : CachedEntityObject, IOrigin
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
        
        public decimal originX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originX",
                    value
                );
            }
        }

        
        public decimal originY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originY",
                    value
                );
            }
        }

        
        public decimal displayOriginX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginX",
                    value
                );
            }
        }

        
        public decimal displayOriginY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginY",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IOriginCachedEntity() : base() { }

        public IOriginCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IOriginCachedEntity setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IOriginCachedEntity>(
                entity => new IOriginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public IOriginCachedEntity setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<IOriginCachedEntity>(
                entity => new IOriginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public IOriginCachedEntity setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IOriginCachedEntity>(
                entity => new IOriginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public IOriginCachedEntity updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<IOriginCachedEntity>(
                entity => new IOriginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateDisplayOrigin" }
                }
            );
        }
        #endregion
    }
}