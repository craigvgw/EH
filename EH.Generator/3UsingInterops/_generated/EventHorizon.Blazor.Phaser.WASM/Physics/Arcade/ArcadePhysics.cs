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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ArcadePhysics>))]
    public class ArcadePhysics : CachedEntityObject
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

        private ArcadeWorldConfig __config;
        public ArcadeWorldConfig config
        {
            get
            {
            if(__config == null)
            {
                __config = EventHorizonBlazorInterop.GetClass<ArcadeWorldConfig>(
                    this.___guid,
                    "config",
                    (entity) =>
                    {
                        return new ArcadeWorldConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __config;
            }
            set
            {
__config = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "config",
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

        private Factory __add;
        public Factory add
        {
            get
            {
            if(__add == null)
            {
                __add = EventHorizonBlazorInterop.GetClass<Factory>(
                    this.___guid,
                    "add",
                    (entity) =>
                    {
                        return new Factory() { ___guid = entity.___guid };
                    }
                );
            }
            return __add;
            }
            set
            {
__add = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "add",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ArcadePhysics() : base() { }

        public ArcadePhysics(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ArcadePhysics(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Arcade", "ArcadePhysics" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void enableUpdate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableUpdate" }
                }
            );
        }

        public void disableUpdate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableUpdate" }
                }
            );
        }

        public ArcadeWorldConfig getConfig()
        {
            return EventHorizonBlazorInterop.FuncClass<ArcadeWorldConfig>(
                entity => new ArcadeWorldConfig() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getConfig" }
                }
            );
        }

        public bool overlap(ArcadeColliderType object1, ArcadeColliderType object2 = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback = null, object callbackContext = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "overlap" }, object1, object2, collideCallback, processCallback, callbackContext
                }
            );
        }

        public bool collide(ArcadeColliderType object1, ArcadeColliderType object2 = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback = null, object callbackContext = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "collide" }, object1, object2, collideCallback, processCallback, callbackContext
                }
            );
        }

        public bool collideTiles(GameObject sprite, Tile[] tiles, ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback = null, object callbackContext = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "collideTiles" }, sprite, tiles, collideCallback, processCallback, callbackContext
                }
            );
        }

        public bool overlapTiles(GameObject sprite, Tile[] tiles, ActionCallback<GameObjectWithBody, GameObjectWithBody> collideCallback = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback = null, object callbackContext = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "overlapTiles" }, sprite, tiles, collideCallback, processCallback, callbackContext
                }
            );
        }

        public World pause()
        {
            return EventHorizonBlazorInterop.FuncClass<World>(
                entity => new World() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public World resume()
        {
            return EventHorizonBlazorInterop.FuncClass<World>(
                entity => new World() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }
                }
            );
        }

        public decimal accelerateTo(GameObject gameObject, decimal x, decimal y, System.Nullable<decimal> speed = null, System.Nullable<decimal> xSpeedMax = null, System.Nullable<decimal> ySpeedMax = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "accelerateTo" }, gameObject, x, y, speed, xSpeedMax, ySpeedMax
                }
            );
        }

        public decimal accelerateToObject(GameObject gameObject, GameObject destination, System.Nullable<decimal> speed = null, System.Nullable<decimal> xSpeedMax = null, System.Nullable<decimal> ySpeedMax = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "accelerateToObject" }, gameObject, destination, speed, xSpeedMax, ySpeedMax
                }
            );
        }

        public Body closest(object source, Body[] targets = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "closest" }, source, targets
                }
            );
        }

        public Body furthest(object source, Body[] targets = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "furthest" }, source, targets
                }
            );
        }

        public decimal moveTo(GameObject gameObject, decimal x, decimal y, System.Nullable<decimal> speed = null, System.Nullable<decimal> maxTime = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, gameObject, x, y, speed, maxTime
                }
            );
        }

        public decimal moveToObject(GameObject gameObject, object destination, System.Nullable<decimal> speed = null, System.Nullable<decimal> maxTime = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "moveToObject" }, gameObject, destination, speed, maxTime
                }
            );
        }

        public Vector2 velocityFromAngle(decimal angle, System.Nullable<decimal> speed = null, Vector2 vec2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "velocityFromAngle" }, angle, speed, vec2
                }
            );
        }

        public Vector2 velocityFromRotation(decimal rotation, System.Nullable<decimal> speed = null, Vector2 vec2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "velocityFromRotation" }, rotation, speed, vec2
                }
            );
        }

        public Body[] overlapRect(decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> includeDynamic = null, System.Nullable<bool> includeStatic = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "overlapRect" }, x, y, width, height, includeDynamic, includeStatic
                }
            );
        }

        public Body[] overlapCirc(decimal x, decimal y, decimal radius, System.Nullable<bool> includeDynamic = null, System.Nullable<bool> includeStatic = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "overlapCirc" }, x, y, radius, includeDynamic, includeStatic
                }
            );
        }

        public void shutdown()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shutdown" }
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