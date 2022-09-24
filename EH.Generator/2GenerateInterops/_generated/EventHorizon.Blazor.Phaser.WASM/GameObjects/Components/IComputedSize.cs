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

    public interface IComputedSize : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IComputedSizeCachedEntity>))]
    public class IComputedSizeCachedEntity : CachedEntityObject, IComputedSize
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

        
        public decimal displayWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayWidth",
                    value
                );
            }
        }

        
        public decimal displayHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayHeight",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IComputedSizeCachedEntity() : base() { }

        public IComputedSizeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IComputedSizeCachedEntity setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<IComputedSizeCachedEntity>(
                entity => new IComputedSizeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public IComputedSizeCachedEntity setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<IComputedSizeCachedEntity>(
                entity => new IComputedSizeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }
        #endregion
    }
}