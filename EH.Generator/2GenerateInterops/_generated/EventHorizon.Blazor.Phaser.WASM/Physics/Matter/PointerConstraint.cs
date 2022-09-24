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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PointerConstraint>))]
    public class PointerConstraint : CachedEntityObject
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

        private Camera __camera;
        public Camera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
            }
            set
            {
__camera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }

        private Pointer __pointer;
        public Pointer pointer
        {
            get
            {
            if(__pointer == null)
            {
                __pointer = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer;
            }
            set
            {
__pointer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointer",
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

        private TBodyType __body;
        public TBodyType body
        {
            get
            {
            if(__body == null)
            {
                __body = EventHorizonBlazorInterop.GetClass<TBodyType>(
                    this.___guid,
                    "body",
                    (entity) =>
                    {
                        return new TBodyType() { ___guid = entity.___guid };
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

        private TBodyType __part;
        public TBodyType part
        {
            get
            {
            if(__part == null)
            {
                __part = EventHorizonBlazorInterop.GetClass<TBodyType>(
                    this.___guid,
                    "part",
                    (entity) =>
                    {
                        return new TBodyType() { ___guid = entity.___guid };
                    }
                );
            }
            return __part;
            }
            set
            {
__part = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "part",
                    value
                );
            }
        }

        private TConstraintType __constraint;
        public TConstraintType constraint
        {
            get
            {
            if(__constraint == null)
            {
                __constraint = EventHorizonBlazorInterop.GetClass<TConstraintType>(
                    this.___guid,
                    "constraint",
                    (entity) =>
                    {
                        return new TConstraintType() { ___guid = entity.___guid };
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
        #endregion
        
        #region Constructor
        public PointerConstraint() : base() { }

        public PointerConstraint(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PointerConstraint(
            Scene scene, World world, object options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Physics", "Matter", "PointerConstraint" },
                scene, world, options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void onDown(Pointer pointer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onDown" }, pointer
                }
            );
        }

        public void onUp(Pointer pointer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onUp" }, pointer
                }
            );
        }

        public bool getBody()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "getBody" }
                }
            );
        }

        public bool hitTestBody(TBodyType body, Vector2 position)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hitTestBody" }, body, position
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

        public void stopDrag()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopDrag" }
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