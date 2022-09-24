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

    public interface IBlendMode : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IBlendModeCachedEntity>))]
    public class IBlendModeCachedEntity : CachedEntityObject, IBlendMode
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
        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IBlendModeCachedEntity() : base() { }

        public IBlendModeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IBlendModeCachedEntity setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<IBlendModeCachedEntity>(
                entity => new IBlendModeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }
        #endregion
    }
}