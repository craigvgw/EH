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

    public interface IFlip : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IFlipCachedEntity>))]
    public class IFlipCachedEntity : CachedEntityObject, IFlip
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
        
        public bool flipX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipX",
                    value
                );
            }
        }

        
        public bool flipY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipY",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IFlipCachedEntity() : base() { }

        public IFlipCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IFlipCachedEntity toggleFlipX()
        {
            return EventHorizonBlazorInterop.FuncClass<IFlipCachedEntity>(
                entity => new IFlipCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipX" }
                }
            );
        }

        public IFlipCachedEntity toggleFlipY()
        {
            return EventHorizonBlazorInterop.FuncClass<IFlipCachedEntity>(
                entity => new IFlipCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipY" }
                }
            );
        }

        public IFlipCachedEntity setFlipX(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<IFlipCachedEntity>(
                entity => new IFlipCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipX" }, value
                }
            );
        }

        public IFlipCachedEntity setFlipY(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<IFlipCachedEntity>(
                entity => new IFlipCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public IFlipCachedEntity setFlip(bool x, bool y)
        {
            return EventHorizonBlazorInterop.FuncClass<IFlipCachedEntity>(
                entity => new IFlipCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlip" }, x, y
                }
            );
        }

        public IFlipCachedEntity resetFlip()
        {
            return EventHorizonBlazorInterop.FuncClass<IFlipCachedEntity>(
                entity => new IFlipCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFlip" }
                }
            );
        }
        #endregion
    }
}