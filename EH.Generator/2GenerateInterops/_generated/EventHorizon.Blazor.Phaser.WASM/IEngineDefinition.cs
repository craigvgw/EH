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

    public interface IEngineDefinition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEngineDefinitionCachedEntity>))]
    public class IEngineDefinitionCachedEntity : CachedEntityObject, IEngineDefinition
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
        
        public decimal positionIterations
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "positionIterations"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "positionIterations",
                    value
                );
            }
        }

        
        public decimal velocityIterations
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "velocityIterations"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "velocityIterations",
                    value
                );
            }
        }

        
        public decimal constraintIterations
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "constraintIterations"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constraintIterations",
                    value
                );
            }
        }

        
        public bool enableSleeping
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableSleeping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableSleeping",
                    value
                );
            }
        }

        private IEngineTimingOptionsCachedEntity __timing;
        public IEngineTimingOptionsCachedEntity timing
        {
            get
            {
            if(__timing == null)
            {
                __timing = EventHorizonBlazorInterop.GetClass<IEngineTimingOptionsCachedEntity>(
                    this.___guid,
                    "timing",
                    (entity) =>
                    {
                        return new IEngineTimingOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __timing;
            }
            set
            {
__timing = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timing",
                    value
                );
            }
        }

        private CGrid __grid;
        public CGrid grid
        {
            get
            {
            if(__grid == null)
            {
                __grid = EventHorizonBlazorInterop.GetClass<CGrid>(
                    this.___guid,
                    "grid",
                    (entity) =>
                    {
                        return new CGrid() { ___guid = entity.___guid };
                    }
                );
            }
            return __grid;
            }
            set
            {
__grid = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "grid",
                    value
                );
            }
        }

        private World __world;
        public World world
        {
            get
            {
            if(__world == null)
            {
                __world = EventHorizonBlazorInterop.GetClass<World>(
                    this.___guid,
                    "world",
                    (entity) =>
                    {
                        return new World() { ___guid = entity.___guid };
                    }
                );
            }
            return __world;
            }
            set
            {
__world = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "world",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IEngineDefinitionCachedEntity() : base() { }

        public IEngineDefinitionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}