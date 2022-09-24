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

    public interface IChamferableBodyDefinition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IChamferableBodyDefinitionCachedEntity>))]
    public class IChamferableBodyDefinitionCachedEntity : CachedEntityObject, IChamferableBodyDefinition
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
        private IChamferCachedEntity __chamfer;
        public IChamferCachedEntity chamfer
        {
            get
            {
            if(__chamfer == null)
            {
                __chamfer = EventHorizonBlazorInterop.GetClass<IChamferCachedEntity>(
                    this.___guid,
                    "chamfer",
                    (entity) =>
                    {
                        return new IChamferCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __chamfer;
            }
            set
            {
__chamfer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "chamfer",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IChamferableBodyDefinitionCachedEntity() : base() { }

        public IChamferableBodyDefinitionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}