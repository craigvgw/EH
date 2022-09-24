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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Collider>))]
    public class Collider : CachedEntityObject
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

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }

        
        public bool overlapOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "overlapOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overlapOnly",
                    value
                );
            }
        }

        private ArcadeColliderType __object1;
        public ArcadeColliderType object1
        {
            get
            {
            if(__object1 == null)
            {
                __object1 = EventHorizonBlazorInterop.GetClass<ArcadeColliderType>(
                    this.___guid,
                    "object1",
                    (entity) =>
                    {
                        return new ArcadeColliderType() { ___guid = entity.___guid };
                    }
                );
            }
            return __object1;
            }
            set
            {
__object1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "object1",
                    value
                );
            }
        }

        private ArcadeColliderType __object2;
        public ArcadeColliderType object2
        {
            get
            {
            if(__object2 == null)
            {
                __object2 = EventHorizonBlazorInterop.GetClass<ArcadeColliderType>(
                    this.___guid,
                    "object2",
                    (entity) =>
                    {
                        return new ArcadeColliderType() { ___guid = entity.___guid };
                    }
                );
            }
            return __object2;
            }
            set
            {
__object2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "object2",
                    value
                );
            }
        }

        
        public ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<GameObjectWithBody, GameObjectWithBody>>(
                    this.___guid,
                    "collideCallback"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideCallback",
                    value
                );
            }
        }

        
        public ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<GameObjectWithBody, GameObjectWithBody>>(
                    this.___guid,
                    "processCallback"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "processCallback",
                    value
                );
            }
        }

        
        public CachedEntity callbackContext
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "callbackContext"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "callbackContext",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Collider() : base() { }

        public Collider(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Collider(
            World world, bool overlapOnly, ArcadeColliderType object1, ArcadeColliderType object2, ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback, object callbackContext
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Arcade", "Collider" },
                world, overlapOnly, object1, object2, collideCallback, processCallback, callbackContext
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Collider setName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Collider>(
                entity => new Collider() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setName" }, name
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}