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

    
    
    [JsonConverter(typeof(CachedEntityConverter<StaticBody>))]
    public class StaticBody : CachedEntityObject
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

        private GameObject __gameObject;
        public GameObject gameObject
        {
            get
            {
            if(__gameObject == null)
            {
                __gameObject = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "gameObject",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __gameObject;
            }
            set
            {
__gameObject = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gameObject",
                    value
                );
            }
        }

        
        public bool debugShowBody
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "debugShowBody"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "debugShowBody",
                    value
                );
            }
        }

        
        public decimal debugBodyColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "debugBodyColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "debugBodyColor",
                    value
                );
            }
        }

        
        public bool enable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enable",
                    value
                );
            }
        }

        
        public bool isCircle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isCircle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isCircle",
                    value
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        private Vector2 __offset;
        public Vector2 offset
        {
            get
            {
            if(__offset == null)
            {
                __offset = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "offset",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __offset;
            }
        }

        private Vector2 __position;
        public Vector2 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal halfWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "halfWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "halfWidth",
                    value
                );
            }
        }

        
        public decimal halfHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "halfHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "halfHeight",
                    value
                );
            }
        }

        private Vector2 __center;
        public Vector2 center
        {
            get
            {
            if(__center == null)
            {
                __center = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "center",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __center;
            }
            set
            {
__center = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "center",
                    value
                );
            }
        }

        private Vector2 __velocity;
        public Vector2 velocity
        {
            get
            {
            if(__velocity == null)
            {
                __velocity = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "velocity",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __velocity;
            }
        }

        
        public bool allowGravity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowGravity"
                );
            }
        }

        private Vector2 __gravity;
        public Vector2 gravity
        {
            get
            {
            if(__gravity == null)
            {
                __gravity = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "gravity",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __gravity;
            }
        }

        private Vector2 __bounce;
        public Vector2 bounce
        {
            get
            {
            if(__bounce == null)
            {
                __bounce = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "bounce",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __bounce;
            }
        }

        
        public bool onWorldBounds
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "onWorldBounds"
                );
            }
        }

        
        public bool onCollide
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "onCollide"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCollide",
                    value
                );
            }
        }

        
        public bool onOverlap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "onOverlap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onOverlap",
                    value
                );
            }
        }

        
        public decimal mass
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mass"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mass",
                    value
                );
            }
        }

        
        public bool immovable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "immovable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "immovable",
                    value
                );
            }
        }

        
        public bool pushable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pushable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pushable",
                    value
                );
            }
        }

        
        public bool customSeparateX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "customSeparateX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customSeparateX",
                    value
                );
            }
        }

        
        public bool customSeparateY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "customSeparateY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customSeparateY",
                    value
                );
            }
        }

        
        public decimal overlapX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overlapX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overlapX",
                    value
                );
            }
        }

        
        public decimal overlapY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overlapY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overlapY",
                    value
                );
            }
        }

        
        public decimal overlapR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overlapR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overlapR",
                    value
                );
            }
        }

        
        public bool embedded
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "embedded"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "embedded",
                    value
                );
            }
        }

        
        public bool collideWorldBounds
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideWorldBounds"
                );
            }
        }

        private ArcadeBodyCollision __checkCollision;
        public ArcadeBodyCollision checkCollision
        {
            get
            {
            if(__checkCollision == null)
            {
                __checkCollision = EventHorizonBlazorInterop.GetClass<ArcadeBodyCollision>(
                    this.___guid,
                    "checkCollision",
                    (entity) =>
                    {
                        return new ArcadeBodyCollision() { ___guid = entity.___guid };
                    }
                );
            }
            return __checkCollision;
            }
            set
            {
__checkCollision = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkCollision",
                    value
                );
            }
        }

        private ArcadeBodyCollision __touching;
        public ArcadeBodyCollision touching
        {
            get
            {
            if(__touching == null)
            {
                __touching = EventHorizonBlazorInterop.GetClass<ArcadeBodyCollision>(
                    this.___guid,
                    "touching",
                    (entity) =>
                    {
                        return new ArcadeBodyCollision() { ___guid = entity.___guid };
                    }
                );
            }
            return __touching;
            }
            set
            {
__touching = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "touching",
                    value
                );
            }
        }

        private ArcadeBodyCollision __wasTouching;
        public ArcadeBodyCollision wasTouching
        {
            get
            {
            if(__wasTouching == null)
            {
                __wasTouching = EventHorizonBlazorInterop.GetClass<ArcadeBodyCollision>(
                    this.___guid,
                    "wasTouching",
                    (entity) =>
                    {
                        return new ArcadeBodyCollision() { ___guid = entity.___guid };
                    }
                );
            }
            return __wasTouching;
            }
            set
            {
__wasTouching = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wasTouching",
                    value
                );
            }
        }

        private ArcadeBodyCollision __blocked;
        public ArcadeBodyCollision blocked
        {
            get
            {
            if(__blocked == null)
            {
                __blocked = EventHorizonBlazorInterop.GetClass<ArcadeBodyCollision>(
                    this.___guid,
                    "blocked",
                    (entity) =>
                    {
                        return new ArcadeBodyCollision() { ___guid = entity.___guid };
                    }
                );
            }
            return __blocked;
            }
            set
            {
__blocked = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blocked",
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

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public decimal left
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "left"
                );
            }
        }

        
        public decimal right
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "right"
                );
            }
        }

        
        public decimal top
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "top"
                );
            }
        }

        
        public decimal bottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottom"
                );
            }
        }
        #endregion
        
        #region Constructor
        public StaticBody() : base() { }

        public StaticBody(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public StaticBody(
            World world, GameObject gameObject
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Arcade", "StaticBody" },
                world, gameObject
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public StaticBody setGameObject(GameObject gameObject, System.Nullable<bool> update = null)
        {
            return EventHorizonBlazorInterop.FuncClass<StaticBody>(
                entity => new StaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGameObject" }, gameObject, update
                }
            );
        }

        public StaticBody updateFromGameObject()
        {
            return EventHorizonBlazorInterop.FuncClass<StaticBody>(
                entity => new StaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateFromGameObject" }
                }
            );
        }

        public StaticBody setOffset(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<StaticBody>(
                entity => new StaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOffset" }, x, y
                }
            );
        }

        public StaticBody setSize(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> center = null)
        {
            return EventHorizonBlazorInterop.FuncClass<StaticBody>(
                entity => new StaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, center
                }
            );
        }

        public StaticBody setCircle(decimal radius, System.Nullable<decimal> offsetX = null, System.Nullable<decimal> offsetY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<StaticBody>(
                entity => new StaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCircle" }, radius, offsetX, offsetY
                }
            );
        }

        public void updateCenter()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCenter" }
                }
            );
        }

        public void reset(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }, x, y
                }
            );
        }

        public StaticBody stop()
        {
            return EventHorizonBlazorInterop.FuncClass<StaticBody>(
                entity => new StaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public ArcadeBodyBounds getBounds(ArcadeBodyBounds obj)
        {
            return EventHorizonBlazorInterop.FuncClass<ArcadeBodyBounds>(
                entity => new ArcadeBodyBounds() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, obj
                }
            );
        }

        public bool hitTest(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hitTest" }, x, y
                }
            );
        }

        public void postUpdate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postUpdate" }
                }
            );
        }

        public decimal deltaAbsX()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "deltaAbsX" }
                }
            );
        }

        public decimal deltaAbsY()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "deltaAbsY" }
                }
            );
        }

        public decimal deltaX()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "deltaX" }
                }
            );
        }

        public decimal deltaY()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "deltaY" }
                }
            );
        }

        public decimal deltaZ()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "deltaZ" }
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

        public void drawDebug(Graphics graphic)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawDebug" }, graphic
                }
            );
        }

        public bool willDrawDebug()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "willDrawDebug" }
                }
            );
        }

        public StaticBody setMass(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<StaticBody>(
                entity => new StaticBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMass" }, value
                }
            );
        }
        #endregion
    }
}