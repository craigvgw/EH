/// Generated - Do Not Edit
namespace Phaser.Physics.Matter
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TileBody>))]
    public class TileBody : EventEmitter, IBounce, ICollision, IFriction, IGravity, IMass, ISensor, ISleep, IStatic
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
        private Tile __tile;
        public Tile tile
        {
            get
            {
            if(__tile == null)
            {
                __tile = EventHorizonBlazorInterop.GetClass<Tile>(
                    this.___guid,
                    "tile",
                    (entity) =>
                    {
                        return new Tile() { ___guid = entity.___guid };
                    }
                );
            }
            return __tile;
            }
            set
            {
__tile = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tile",
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

        private Vector2 __centerOfMass;
        public Vector2 centerOfMass
        {
            get
            {
            if(__centerOfMass == null)
            {
                __centerOfMass = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "centerOfMass",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __centerOfMass;
            }
        }
        #endregion
        
        #region Constructor
        public TileBody() : base() { }

        public TileBody(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TileBody(
            World world, Tile tile, MatterTileOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Matter", "TileBody" },
                world, tile, options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public TileBody setFromTileRectangle(MatterBodyTileOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromTileRectangle" }, options
                }
            );
        }

        public TileBody setFromTileCollision(MatterBodyTileOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromTileCollision" }, options
                }
            );
        }

        public TileBody setBody(TBodyType body, System.Nullable<bool> addToWorld = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBody" }, body, addToWorld
                }
            );
        }

        public TileBody removeBody()
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeBody" }
                }
            );
        }

        public TileBody destroy()
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }

        public GameObject setBounce(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounce" }, value
                }
            );
        }

        public GameObject setCollisionCategory(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionCategory" }, value
                }
            );
        }

        public GameObject setCollisionGroup(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionGroup" }, value
                }
            );
        }

        public GameObject setCollidesWith(decimal categories)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollidesWith" }, categories
                }
            );
        }

        public GameObject setFriction(decimal value, System.Nullable<decimal> air = null, System.Nullable<decimal> fstatic = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFriction" }, value, air, fstatic
                }
            );
        }

        public GameObject setFrictionAir(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrictionAir" }, value
                }
            );
        }

        public GameObject setFrictionStatic(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrictionStatic" }, value
                }
            );
        }

        public GameObject setIgnoreGravity(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIgnoreGravity" }, value
                }
            );
        }

        public GameObject setMass(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMass" }, value
                }
            );
        }

        public GameObject setDensity(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDensity" }, value
                }
            );
        }

        public GameObject setSensor(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSensor" }, value
                }
            );
        }

        public bool isSensor()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isSensor" }
                }
            );
        }

        public TileBody setToSleep()
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setToSleep" }
                }
            );
        }

        public TileBody setAwake()
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAwake" }
                }
            );
        }

        public TileBody setSleepThreshold(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepThreshold" }, value
                }
            );
        }

        public TileBody setSleepEvents(bool start, bool end)
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepEvents" }, start, end
                }
            );
        }

        public TileBody setSleepStartEvent(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepStartEvent" }, value
                }
            );
        }

        public TileBody setSleepEndEvent(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<TileBody>(
                entity => new TileBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSleepEndEvent" }, value
                }
            );
        }

        public GameObject setStatic(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setStatic" }, value
                }
            );
        }

        public bool isStatic()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isStatic" }
                }
            );
        }


        #endregion
    }
}