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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CEngine>))]
    public class CEngine : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void clear(CEngine engine)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CEngine", "clear" }, engine
                }
            );
        }

        public static CEngine create(object element = null, IEngineDefinition options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CEngine>(
                entity => new CEngine() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CEngine", "create" }, element, options
                }
            );
        }

        public static void merge(CEngine engineA, CEngine engineB)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CEngine", "merge" }, engineA, engineB
                }
            );
        }

        public static CEngine update(CEngine engine, System.Nullable<decimal> delta = null, System.Nullable<decimal> correction = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CEngine>(
                entity => new CEngine() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CEngine", "update" }, engine, delta, correction
                }
            );
        }

        public static void run(CEngine engine)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CEngine", "run" }, engine
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private CGrid __broadphase;
        public CGrid broadphase
        {
            get
            {
            if(__broadphase == null)
            {
                __broadphase = EventHorizonBlazorInterop.GetClass<CGrid>(
                    this.___guid,
                    "broadphase",
                    (entity) =>
                    {
                        return new CGrid() { ___guid = entity.___guid };
                    }
                );
            }
            return __broadphase;
            }
            set
            {
__broadphase = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "broadphase",
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

        
        public bool enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enabled",
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

        
        public CachedEntity pairs
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "pairs",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pairs",
                    value
                );
            }
        }

        
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
        public CEngine() : base() { }

        public CEngine(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}