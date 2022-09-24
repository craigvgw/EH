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

    
    
    [JsonConverter(typeof(CachedEntityConverter<World>))]
    public class World : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static World add(World world, CachedEntity body)
        {
            return EventHorizonBlazorInterop.FuncClass<World>(
                entity => new World() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "World", "add" }, world, body
                }
            );
        }

        public static World addBody(World world, CachedEntity body)
        {
            return EventHorizonBlazorInterop.FuncClass<World>(
                entity => new World() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "World", "addBody" }, world, body
                }
            );
        }

        public static World addComposite(World world, CachedEntity composite)
        {
            return EventHorizonBlazorInterop.FuncClass<World>(
                entity => new World() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "World", "addComposite" }, world, composite
                }
            );
        }

        public static World addConstraint(World world, CachedEntity constraint)
        {
            return EventHorizonBlazorInterop.FuncClass<World>(
                entity => new World() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "World", "addConstraint" }, world, constraint
                }
            );
        }

        public static void clear(World world, bool keepStatic)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "World", "clear" }, world, keepStatic
                }
            );
        }

        public static World create(IWorldDefinition options)
        {
            return EventHorizonBlazorInterop.FuncClass<World>(
                entity => new World() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "World", "create" }, options
                }
            );
        }
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

        private CBounds __bounds;
        public CBounds bounds
        {
            get
            {
            if(__bounds == null)
            {
                __bounds = EventHorizonBlazorInterop.GetClass<CBounds>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new CBounds() { ___guid = entity.___guid };
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
        public World() : base() { }

        public World(
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