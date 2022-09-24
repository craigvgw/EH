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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Factory>))]
    public class Factory : CachedEntityObject
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

        private Systems __sys;
        public Systems sys
        {
            get
            {
            if(__sys == null)
            {
                __sys = EventHorizonBlazorInterop.GetClass<Systems>(
                    this.___guid,
                    "sys",
                    (entity) =>
                    {
                        return new Systems() { ___guid = entity.___guid };
                    }
                );
            }
            return __sys;
            }
            set
            {
__sys = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sys",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Factory() : base() { }

        public Factory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Factory(
            World world
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Arcade", "Factory" },
                world
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Collider collider(GameObject object1, GameObject object2, ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback = null, object callbackContext = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Collider>(
                entity => new Collider() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "collider" }, object1, object2, collideCallback, processCallback, callbackContext
                }
            );
        }

        public Collider overlap(GameObject object1, GameObject object2, ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback = null, object callbackContext = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Collider>(
                entity => new Collider() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "overlap" }, object1, object2, collideCallback, processCallback, callbackContext
                }
            );
        }

        public G existing<G>(G gameObject, System.Nullable<bool> isStatic = null) where G : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<G>(
                entity => new G() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "existing" }, gameObject, isStatic
                }
            );
        }

        public ImageWithStaticBody staticImage(decimal x, decimal y, string texture, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageWithStaticBody>(
                entity => new ImageWithStaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "staticImage" }, x, y, texture, frame
                }
            );
        }

        public ImageWithDynamicBody image(decimal x, decimal y, string texture, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageWithDynamicBody>(
                entity => new ImageWithDynamicBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "image" }, x, y, texture, frame
                }
            );
        }

        public SpriteWithStaticBody staticSprite(decimal x, decimal y, string texture, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpriteWithStaticBody>(
                entity => new SpriteWithStaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "staticSprite" }, x, y, texture, frame
                }
            );
        }

        public SpriteWithDynamicBody sprite(decimal x, decimal y, string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpriteWithDynamicBody>(
                entity => new SpriteWithDynamicBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sprite" }, x, y, key, frame
                }
            );
        }

        public StaticGroup staticGroup(GameObject[] children = null, GroupConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<StaticGroup>(
                entity => new StaticGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "staticGroup" }, children, config
                }
            );
        }

        public Group group(GameObject[] children = null, PhysicsGroupConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "group" }, children, config
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