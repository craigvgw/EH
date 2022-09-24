/// Generated - Do Not Edit
namespace Phaser.Physics.Arcade
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<StaticGroup>))]
    public class StaticGroup : Group
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

        
        public decimal physicsType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "physicsType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "physicsType",
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
        public StaticGroup() : base() { }

        public StaticGroup(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public StaticGroup(
            World world, Scene scene, GameObject[] children = null, GroupConfig config = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Arcade", "StaticGroup" },
                world, scene, children, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void createCallbackHandler(GameObject child)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createCallbackHandler" }, child
                }
            );
        }

        public void removeCallbackHandler(GameObject child)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeCallbackHandler" }, child
                }
            );
        }

        public void createMultipleCallbackHandler(GameObject[] entries)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createMultipleCallbackHandler" }, entries
                }
            );
        }

        public StaticGroup refresh()
        {
            return EventHorizonBlazorInterop.FuncClass<StaticGroup>(
                entity => new StaticGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refresh" }
                }
            );
        }
        #endregion
    }
}