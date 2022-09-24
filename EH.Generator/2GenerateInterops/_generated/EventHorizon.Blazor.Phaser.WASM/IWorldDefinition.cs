/// Generated - Do Not Edit
namespace MatterJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IWorldDefinition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IWorldDefinitionCachedEntity>))]
    public class IWorldDefinitionCachedEntity : CachedEntityObject, IWorldDefinition
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
        private IGravityCachedEntity __gravity;
        public IGravityCachedEntity gravity
        {
            get
            {
            if(__gravity == null)
            {
                __gravity = EventHorizonBlazorInterop.GetClass<IGravityCachedEntity>(
                    this.___guid,
                    "gravity",
                    (entity) =>
                    {
                        return new IGravityCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __gravity;
            }
            set
            {
__gravity = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gravity",
                    value
                );
            }
        }

        private IBoundCachedEntity __bounds;
        public IBoundCachedEntity bounds
        {
            get
            {
            if(__bounds == null)
            {
                __bounds = EventHorizonBlazorInterop.GetClass<IBoundCachedEntity>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new IBoundCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __bounds;
            }
            set
            {
__bounds = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bounds",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IWorldDefinitionCachedEntity() : base() { }

        public IWorldDefinitionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}