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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MatterPhysics>))]
    public class MatterPhysics : CachedEntityObject
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

        private MatterWorldConfig __config;
        public MatterWorldConfig config
        {
            get
            {
            if(__config == null)
            {
                __config = EventHorizonBlazorInterop.GetClass<MatterWorldConfig>(
                    this.___guid,
                    "config",
                    (entity) =>
                    {
                        return new MatterWorldConfig() { ___guid = entity.___guid };
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

        private BodyBounds __bodyBounds;
        public BodyBounds bodyBounds
        {
            get
            {
            if(__bodyBounds == null)
            {
                __bodyBounds = EventHorizonBlazorInterop.GetClass<BodyBounds>(
                    this.___guid,
                    "bodyBounds",
                    (entity) =>
                    {
                        return new BodyBounds() { ___guid = entity.___guid };
                    }
                );
            }
            return __bodyBounds;
            }
            set
            {
__bodyBounds = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bodyBounds",
                    value
                );
            }
        }

        private CBodyFactory __body;
        public CBodyFactory body
        {
            get
            {
            if(__body == null)
            {
                __body = EventHorizonBlazorInterop.GetClass<CBodyFactory>(
                    this.___guid,
                    "body",
                    (entity) =>
                    {
                        return new CBodyFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __body;
            }
            set
            {
__body = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "body",
                    value
                );
            }
        }

        private CCompositeFactory __composite;
        public CCompositeFactory composite
        {
            get
            {
            if(__composite == null)
            {
                __composite = EventHorizonBlazorInterop.GetClass<CCompositeFactory>(
                    this.___guid,
                    "composite",
                    (entity) =>
                    {
                        return new CCompositeFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __composite;
            }
            set
            {
__composite = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "composite",
                    value
                );
            }
        }

        private CDetectorFactory __detector;
        public CDetectorFactory detector
        {
            get
            {
            if(__detector == null)
            {
                __detector = EventHorizonBlazorInterop.GetClass<CDetectorFactory>(
                    this.___guid,
                    "detector",
                    (entity) =>
                    {
                        return new CDetectorFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __detector;
            }
            set
            {
__detector = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "detector",
                    value
                );
            }
        }

        private CGridFactory __grid;
        public CGridFactory grid
        {
            get
            {
            if(__grid == null)
            {
                __grid = EventHorizonBlazorInterop.GetClass<CGridFactory>(
                    this.___guid,
                    "grid",
                    (entity) =>
                    {
                        return new CGridFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __grid;
            }
            set
            {
__grid = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "grid",
                    value
                );
            }
        }

        private CPairFactory __pair;
        public CPairFactory pair
        {
            get
            {
            if(__pair == null)
            {
                __pair = EventHorizonBlazorInterop.GetClass<CPairFactory>(
                    this.___guid,
                    "pair",
                    (entity) =>
                    {
                        return new CPairFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __pair;
            }
            set
            {
__pair = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pair",
                    value
                );
            }
        }

        private CPairsFactory __pairs;
        public CPairsFactory pairs
        {
            get
            {
            if(__pairs == null)
            {
                __pairs = EventHorizonBlazorInterop.GetClass<CPairsFactory>(
                    this.___guid,
                    "pairs",
                    (entity) =>
                    {
                        return new CPairsFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __pairs;
            }
            set
            {
__pairs = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pairs",
                    value
                );
            }
        }

        private CQueryFactory __query;
        public CQueryFactory query
        {
            get
            {
            if(__query == null)
            {
                __query = EventHorizonBlazorInterop.GetClass<CQueryFactory>(
                    this.___guid,
                    "query",
                    (entity) =>
                    {
                        return new CQueryFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __query;
            }
            set
            {
__query = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "query",
                    value
                );
            }
        }

        private CResolverFactory __resolver;
        public CResolverFactory resolver
        {
            get
            {
            if(__resolver == null)
            {
                __resolver = EventHorizonBlazorInterop.GetClass<CResolverFactory>(
                    this.___guid,
                    "resolver",
                    (entity) =>
                    {
                        return new CResolverFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __resolver;
            }
            set
            {
__resolver = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolver",
                    value
                );
            }
        }

        private CSATFactory __sat;
        public CSATFactory sat
        {
            get
            {
            if(__sat == null)
            {
                __sat = EventHorizonBlazorInterop.GetClass<CSATFactory>(
                    this.___guid,
                    "sat",
                    (entity) =>
                    {
                        return new CSATFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __sat;
            }
            set
            {
__sat = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sat",
                    value
                );
            }
        }

        private CConstraintFactory __constraint;
        public CConstraintFactory constraint
        {
            get
            {
            if(__constraint == null)
            {
                __constraint = EventHorizonBlazorInterop.GetClass<CConstraintFactory>(
                    this.___guid,
                    "constraint",
                    (entity) =>
                    {
                        return new CConstraintFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __constraint;
            }
            set
            {
__constraint = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constraint",
                    value
                );
            }
        }

        private CBodiesFactory __bodies;
        public CBodiesFactory bodies
        {
            get
            {
            if(__bodies == null)
            {
                __bodies = EventHorizonBlazorInterop.GetClass<CBodiesFactory>(
                    this.___guid,
                    "bodies",
                    (entity) =>
                    {
                        return new CBodiesFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __bodies;
            }
            set
            {
__bodies = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bodies",
                    value
                );
            }
        }

        private CCompositesFactory __composites;
        public CCompositesFactory composites
        {
            get
            {
            if(__composites == null)
            {
                __composites = EventHorizonBlazorInterop.GetClass<CCompositesFactory>(
                    this.___guid,
                    "composites",
                    (entity) =>
                    {
                        return new CCompositesFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __composites;
            }
            set
            {
__composites = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "composites",
                    value
                );
            }
        }

        private CAxesFactory __axes;
        public CAxesFactory axes
        {
            get
            {
            if(__axes == null)
            {
                __axes = EventHorizonBlazorInterop.GetClass<CAxesFactory>(
                    this.___guid,
                    "axes",
                    (entity) =>
                    {
                        return new CAxesFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __axes;
            }
            set
            {
__axes = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "axes",
                    value
                );
            }
        }

        private CBoundsFactory __bounds;
        public CBoundsFactory bounds
        {
            get
            {
            if(__bounds == null)
            {
                __bounds = EventHorizonBlazorInterop.GetClass<CBoundsFactory>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new CBoundsFactory() { ___guid = entity.___guid };
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

        private CSvgFactory __svg;
        public CSvgFactory svg
        {
            get
            {
            if(__svg == null)
            {
                __svg = EventHorizonBlazorInterop.GetClass<CSvgFactory>(
                    this.___guid,
                    "svg",
                    (entity) =>
                    {
                        return new CSvgFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __svg;
            }
            set
            {
__svg = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "svg",
                    value
                );
            }
        }

        private CVectorFactory __vector;
        public CVectorFactory vector
        {
            get
            {
            if(__vector == null)
            {
                __vector = EventHorizonBlazorInterop.GetClass<CVectorFactory>(
                    this.___guid,
                    "vector",
                    (entity) =>
                    {
                        return new CVectorFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __vector;
            }
            set
            {
__vector = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vector",
                    value
                );
            }
        }

        private CVerticesFactory __vertices;
        public CVerticesFactory vertices
        {
            get
            {
            if(__vertices == null)
            {
                __vertices = EventHorizonBlazorInterop.GetClass<CVerticesFactory>(
                    this.___guid,
                    "vertices",
                    (entity) =>
                    {
                        return new CVerticesFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertices;
            }
            set
            {
__vertices = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }

        private CVerticesFactory __verts;
        public CVerticesFactory verts
        {
            get
            {
            if(__verts == null)
            {
                __verts = EventHorizonBlazorInterop.GetClass<CVerticesFactory>(
                    this.___guid,
                    "verts",
                    (entity) =>
                    {
                        return new CVerticesFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __verts;
            }
            set
            {
__verts = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "verts",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public MatterPhysics() : base() { }

        public MatterPhysics(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public MatterPhysics(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Matter", "MatterPhysics" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public MatterWorldConfig getConfig()
        {
            return EventHorizonBlazorInterop.FuncClass<MatterWorldConfig>(
                entity => new MatterWorldConfig() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getConfig" }
                }
            );
        }

        public MatterPhysics enableAttractorPlugin()
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableAttractorPlugin" }
                }
            );
        }

        public MatterPhysics enableWrapPlugin()
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableWrapPlugin" }
                }
            );
        }

        public MatterPhysics enableCollisionEventsPlugin()
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableCollisionEventsPlugin" }
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

        public MatterPhysics set60Hz()
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set60Hz" }
                }
            );
        }

        public MatterPhysics set30Hz()
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set30Hz" }
                }
            );
        }

        public void step(System.Nullable<decimal> delta = null, System.Nullable<decimal> correction = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "step" }, delta, correction
                }
            );
        }

        public bool containsPoint(MatterBody body, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, body, x, y
                }
            );
        }

        public MatterBody[] intersectPoint(decimal x, decimal y, MatterBody[] bodies = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<MatterBody>(
                entity => new MatterBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectPoint" }, x, y, bodies
                }
            );
        }

        public MatterBody[] intersectRect(decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> outside = null, MatterBody[] bodies = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<MatterBody>(
                entity => new MatterBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectRect" }, x, y, width, height, outside, bodies
                }
            );
        }

        public MatterBody[] intersectRay(decimal x1, decimal y1, decimal x2, decimal y2, System.Nullable<decimal> rayWidth = null, MatterBody[] bodies = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<MatterBody>(
                entity => new MatterBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectRay" }, x1, y1, x2, y2, rayWidth, bodies
                }
            );
        }

        public MatterBody[] intersectBody(MatterBody body, MatterBody[] bodies = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<MatterBody>(
                entity => new MatterBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectBody" }, body, bodies
                }
            );
        }

        public bool overlap(MatterBody target, MatterBody[] bodies = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> overlapCallback = null, ActionCallback<GameObjectWithBody, GameObjectWithBody> processCallback = null, object callbackContext = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "overlap" }, target, bodies, overlapCallback, processCallback, callbackContext
                }
            );
        }

        public MatterPhysics setCollisionCategory(MatterBody[] bodies, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionCategory" }, bodies, value
                }
            );
        }

        public MatterPhysics setCollisionGroup(MatterBody[] bodies, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionGroup" }, bodies, value
                }
            );
        }

        public MatterPhysics setCollidesWith(MatterBody[] bodies, decimal categories)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollidesWith" }, bodies, categories
                }
            );
        }

        public TBodyType[] getMatterBodies(CachedEntity[] bodies = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<TBodyType>(
                entity => new TBodyType() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMatterBodies" }, bodies
                }
            );
        }

        public MatterPhysics setVelocity(MatterBody bodies, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVelocity" }, bodies, x, y
                }
            );
        }

        public MatterPhysics setVelocityX(MatterBody bodies, decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVelocityX" }, bodies, x
                }
            );
        }

        public MatterPhysics setVelocityY(MatterBody bodies, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVelocityY" }, bodies, y
                }
            );
        }

        public MatterPhysics setAngularVelocity(MatterBody bodies, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" }, bodies, value
                }
            );
        }

        public MatterPhysics applyForce(MatterBody bodies, Vector2Like force)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyForce" }, bodies, force
                }
            );
        }

        public MatterPhysics applyForceFromPosition(MatterBody bodies, Vector2Like position, decimal speed, System.Nullable<decimal> angle = null)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyForceFromPosition" }, bodies, position, speed, angle
                }
            );
        }

        public MatterPhysics applyForceFromAngle(MatterBody bodies, decimal speed, System.Nullable<decimal> angle = null)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyForceFromAngle" }, bodies, speed, angle
                }
            );
        }

        public decimal getConstraintLength(TConstraintType constraint)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getConstraintLength" }, constraint
                }
            );
        }

        public MatterPhysics alignBody(MatterBody body, decimal x, decimal y, decimal align)
        {
            return EventHorizonBlazorInterop.FuncClass<MatterPhysics>(
                entity => new MatterPhysics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "alignBody" }, body, x, y, align
                }
            );
        }
        #endregion
    }
}