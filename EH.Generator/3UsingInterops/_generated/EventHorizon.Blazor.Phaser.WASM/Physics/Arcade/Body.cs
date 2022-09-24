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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Body>))]
    public class Body : CachedEntityObject
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

        
        public CachedEntity transform
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "transform"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transform",
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

        
        public bool debugShowVelocity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "debugShowVelocity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "debugShowVelocity",
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
            set
            {
__offset = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
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

        private Vector2 __prev;
        public Vector2 prev
        {
            get
            {
            if(__prev == null)
            {
                __prev = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "prev",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __prev;
            }
            set
            {
__prev = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prev",
                    value
                );
            }
        }

        private Vector2 __prevFrame;
        public Vector2 prevFrame
        {
            get
            {
            if(__prevFrame == null)
            {
                __prevFrame = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "prevFrame",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __prevFrame;
            }
            set
            {
__prevFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prevFrame",
                    value
                );
            }
        }

        
        public bool allowRotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowRotation",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        
        public decimal preRotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "preRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preRotation",
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
        }

        
        public decimal sourceWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sourceWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceWidth",
                    value
                );
            }
        }

        
        public decimal sourceHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sourceHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceHeight",
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
            set
            {
__velocity = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "velocity",
                    value
                );
            }
        }

        private Vector2 __newVelocity;
        public Vector2 newVelocity
        {
            get
            {
            if(__newVelocity == null)
            {
                __newVelocity = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "newVelocity",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __newVelocity;
            }
        }

        private Vector2 __deltaMax;
        public Vector2 deltaMax
        {
            get
            {
            if(__deltaMax == null)
            {
                __deltaMax = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "deltaMax",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __deltaMax;
            }
            set
            {
__deltaMax = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaMax",
                    value
                );
            }
        }

        private Vector2 __acceleration;
        public Vector2 acceleration
        {
            get
            {
            if(__acceleration == null)
            {
                __acceleration = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "acceleration",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __acceleration;
            }
            set
            {
__acceleration = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "acceleration",
                    value
                );
            }
        }

        
        public bool allowDrag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowDrag"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowDrag",
                    value
                );
            }
        }

        private Vector2 __drag;
        public Vector2 drag
        {
            get
            {
            if(__drag == null)
            {
                __drag = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "drag",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __drag;
            }
            set
            {
__drag = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drag",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowGravity",
                    value
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
            set
            {
__bounce = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bounce",
                    value
                );
            }
        }

        private Vector2 __worldBounce;
        public Vector2 worldBounce
        {
            get
            {
            if(__worldBounce == null)
            {
                __worldBounce = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "worldBounce",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __worldBounce;
            }
            set
            {
__worldBounce = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldBounce",
                    value
                );
            }
        }

        private Rectangle __customBoundsRectangle;
        public Rectangle customBoundsRectangle
        {
            get
            {
            if(__customBoundsRectangle == null)
            {
                __customBoundsRectangle = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "customBoundsRectangle",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __customBoundsRectangle;
            }
            set
            {
__customBoundsRectangle = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customBoundsRectangle",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onWorldBounds",
                    value
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

        private Vector2 __maxVelocity;
        public Vector2 maxVelocity
        {
            get
            {
            if(__maxVelocity == null)
            {
                __maxVelocity = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "maxVelocity",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __maxVelocity;
            }
            set
            {
__maxVelocity = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxVelocity",
                    value
                );
            }
        }

        
        public decimal maxSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSpeed",
                    value
                );
            }
        }

        private Vector2 __friction;
        public Vector2 friction
        {
            get
            {
            if(__friction == null)
            {
                __friction = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "friction",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __friction;
            }
            set
            {
__friction = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "friction",
                    value
                );
            }
        }

        
        public bool useDamping
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useDamping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useDamping",
                    value
                );
            }
        }

        
        public decimal angularVelocity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularVelocity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularVelocity",
                    value
                );
            }
        }

        
        public decimal angularAcceleration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularAcceleration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularAcceleration",
                    value
                );
            }
        }

        
        public decimal angularDrag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularDrag"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularDrag",
                    value
                );
            }
        }

        
        public decimal maxAngular
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxAngular"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxAngular",
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

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal speed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speed",
                    value
                );
            }
        }

        
        public decimal facing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "facing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "facing",
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

        
        public bool moves
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "moves"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "moves",
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideWorldBounds",
                    value
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

        
        public bool syncBounds
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "syncBounds"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "syncBounds",
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
        public Body() : base() { }

        public Body(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Body(
            World world, GameObject gameObject
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Arcade", "Body" },
                world, gameObject
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateBounds()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateBounds" }
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

        public void updateFromGameObject()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateFromGameObject" }
                }
            );
        }

        public void resetFlags(System.Nullable<bool> clear = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetFlags" }, clear
                }
            );
        }

        public void preUpdate(bool willStep, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preUpdate" }, willStep, delta
                }
            );
        }

        public void update(decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, delta
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

        public Body setBoundsRectangle(Rectangle bounds = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBoundsRectangle" }, bounds
                }
            );
        }

        public bool checkWorldBounds()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "checkWorldBounds" }
                }
            );
        }

        public Body setOffset(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOffset" }, x, y
                }
            );
        }

        public Body setSize(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> center = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, center
                }
            );
        }

        public Body setCircle(decimal radius, System.Nullable<decimal> offsetX = null, System.Nullable<decimal> offsetY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCircle" }, radius, offsetX, offsetY
                }
            );
        }

        public void reset(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }, x, y
                }
            );
        }

        public Body stop()
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
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

        public bool onFloor()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "onFloor" }
                }
            );
        }

        public bool onCeiling()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "onCeiling" }
                }
            );
        }

        public bool onWall()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "onWall" }
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

        public decimal deltaXFinal()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "deltaXFinal" }
                }
            );
        }

        public decimal deltaYFinal()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "deltaYFinal" }
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

        public Body setCollideWorldBounds(System.Nullable<bool> value = null, System.Nullable<decimal> bounceX = null, System.Nullable<decimal> bounceY = null, System.Nullable<bool> onWorldBounds = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollideWorldBounds" }, value, bounceX, bounceY, onWorldBounds
                }
            );
        }

        public Body setVelocity(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVelocity" }, x, y
                }
            );
        }

        public Body setVelocityX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVelocityX" }, value
                }
            );
        }

        public Body setVelocityY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVelocityY" }, value
                }
            );
        }

        public Body setMaxVelocity(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaxVelocity" }, x, y
                }
            );
        }

        public Body setMaxVelocityX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaxVelocityX" }, value
                }
            );
        }

        public Body setMaxVelocityY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaxVelocityY" }, value
                }
            );
        }

        public Body setMaxSpeed(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaxSpeed" }, value
                }
            );
        }

        public Body setBounce(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounce" }, x, y
                }
            );
        }

        public Body setBounceX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounceX" }, value
                }
            );
        }

        public Body setBounceY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounceY" }, value
                }
            );
        }

        public Body setAcceleration(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAcceleration" }, x, y
                }
            );
        }

        public Body setAccelerationX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAccelerationX" }, value
                }
            );
        }

        public Body setAccelerationY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAccelerationY" }, value
                }
            );
        }

        public Body setAllowDrag(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAllowDrag" }, value
                }
            );
        }

        public Body setAllowGravity(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAllowGravity" }, value
                }
            );
        }

        public Body setAllowRotation(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAllowRotation" }, value
                }
            );
        }

        public Body setDrag(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDrag" }, x, y
                }
            );
        }

        public Body setDamping(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDamping" }, value
                }
            );
        }

        public Body setDragX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDragX" }, value
                }
            );
        }

        public Body setDragY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDragY" }, value
                }
            );
        }

        public Body setGravity(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGravity" }, x, y
                }
            );
        }

        public Body setGravityX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGravityX" }, value
                }
            );
        }

        public Body setGravityY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGravityY" }, value
                }
            );
        }

        public Body setFriction(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFriction" }, x, y
                }
            );
        }

        public Body setFrictionX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrictionX" }, value
                }
            );
        }

        public Body setFrictionY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrictionY" }, value
                }
            );
        }

        public Body setAngularVelocity(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" }, value
                }
            );
        }

        public Body setAngularAcceleration(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngularAcceleration" }, value
                }
            );
        }

        public Body setAngularDrag(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngularDrag" }, value
                }
            );
        }

        public Body setMass(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMass" }, value
                }
            );
        }

        public Body setImmovable(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setImmovable" }, value
                }
            );
        }

        public Body setEnable(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Body>(
                entity => new Body() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEnable" }, value
                }
            );
        }

        public void processX(decimal x, System.Nullable<decimal> vx = null, System.Nullable<bool> left = null, System.Nullable<bool> right = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "processX" }, x, vx, left, right
                }
            );
        }

        public void processY(decimal y, System.Nullable<decimal> vy = null, System.Nullable<bool> up = null, System.Nullable<bool> down = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "processY" }, y, vy, up, down
                }
            );
        }
        #endregion
    }
}