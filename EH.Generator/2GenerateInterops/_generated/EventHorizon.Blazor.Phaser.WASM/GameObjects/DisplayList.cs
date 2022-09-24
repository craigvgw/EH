/// Generated - Do Not Edit
namespace Phaser.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<DisplayList>))]
    public class DisplayList : List<GameObject>
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
        
        public bool sortChildrenFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sortChildrenFlag"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sortChildrenFlag",
                    value
                );
            }
        }

        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }

        private Systems __systems;
        public Systems systems
        {
            get
            {
            if(__systems == null)
            {
                __systems = EventHorizonBlazorInterop.GetClass<Systems>(
                    this.___guid,
                    "systems",
                    (entity) =>
                    {
                        return new Systems() { ___guid = entity.___guid };
                    }
                );
            }
            return __systems;
            }
            set
            {
__systems = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systems",
                    value
                );
            }
        }

        private EventEmitter __events;
        public EventEmitter events
        {
            get
            {
            if(__events == null)
            {
                __events = EventHorizonBlazorInterop.GetClass<EventEmitter>(
                    this.___guid,
                    "events",
                    (entity) =>
                    {
                        return new EventEmitter() { ___guid = entity.___guid };
                    }
                );
            }
            return __events;
            }
            set
            {
__events = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "events",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public DisplayList() : base() { }

        public DisplayList(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DisplayList(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "DisplayList" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void queueDepthSort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "queueDepthSort" }
                }
            );
        }

        public void depthSort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "depthSort" }
                }
            );
        }

        public decimal sortByDepth(GameObject childA, GameObject childB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "sortByDepth" }, childA, childB
                }
            );
        }

        public GameObject[] getChildren()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }
        #endregion
    }
}