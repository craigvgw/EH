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

    public interface IAlpha : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IAlphaCachedEntity>))]
    public class IAlphaCachedEntity : CachedEntityObject, IAlpha
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
        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public decimal alphaTopLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaTopLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaTopLeft",
                    value
                );
            }
        }

        
        public decimal alphaTopRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaTopRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaTopRight",
                    value
                );
            }
        }

        
        public decimal alphaBottomLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaBottomLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBottomLeft",
                    value
                );
            }
        }

        
        public decimal alphaBottomRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaBottomRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBottomRight",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IAlphaCachedEntity() : base() { }

        public IAlphaCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IAlphaCachedEntity clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<IAlphaCachedEntity>(
                entity => new IAlphaCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public IAlphaCachedEntity setAlpha(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IAlphaCachedEntity>(
                entity => new IAlphaCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }
        #endregion
    }
}