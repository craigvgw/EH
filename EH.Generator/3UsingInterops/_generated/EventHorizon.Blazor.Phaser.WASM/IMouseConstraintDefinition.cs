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

    public interface IMouseConstraintDefinition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IMouseConstraintDefinitionCachedEntity>))]
    public class IMouseConstraintDefinitionCachedEntity : CachedEntityObject, IMouseConstraintDefinition
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
        
        public CachedEntity constraint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "constraint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constraint",
                    value
                );
            }
        }

        private ICollisionFilterCachedEntity __collisionFilter;
        public ICollisionFilterCachedEntity collisionFilter
        {
            get
            {
            if(__collisionFilter == null)
            {
                __collisionFilter = EventHorizonBlazorInterop.GetClass<ICollisionFilterCachedEntity>(
                    this.___guid,
                    "collisionFilter",
                    (entity) =>
                    {
                        return new ICollisionFilterCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __collisionFilter;
            }
            set
            {
__collisionFilter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionFilter",
                    value
                );
            }
        }

        
        public CachedEntity body
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "body"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "body",
                    value
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IMouseConstraintDefinitionCachedEntity() : base() { }

        public IMouseConstraintDefinitionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}