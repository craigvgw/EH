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

    public interface IAlphaSingle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IAlphaSingleCachedEntity>))]
    public class IAlphaSingleCachedEntity : CachedEntityObject, IAlphaSingle
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
        #endregion
        
        #region Constructor
        public IAlphaSingleCachedEntity() : base() { }

        public IAlphaSingleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IAlphaSingleCachedEntity clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<IAlphaSingleCachedEntity>(
                entity => new IAlphaSingleCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public IAlphaSingleCachedEntity setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IAlphaSingleCachedEntity>(
                entity => new IAlphaSingleCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }
        #endregion
    }
}