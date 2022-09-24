/// Generated - Do Not Edit
namespace Phaser.Input
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Pointer>))]
    public class Pointer : CachedEntityObject
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
        private InputManager __manager;
        public InputManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<InputManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new InputManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __manager;
            }
            set
            {
__manager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manager",
                    value
                );
            }
        }

        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
        }

        private TouchEvent __event;
        public TouchEvent @event
        {
            get
            {
            if(__event == null)
            {
                __event = EventHorizonBlazorInterop.GetClass<TouchEvent>(
                    this.___guid,
                    "event",
                    (entity) =>
                    {
                        return new TouchEvent() { ___guid = entity.___guid };
                    }
                );
            }
            return __event;
            }
            set
            {
__event = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "event",
                    value
                );
            }
        }

        
        public CachedEntity downElement
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "downElement",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public CachedEntity upElement
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "upElement",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
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

        
        public decimal button
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "button"
                );
            }
        }

        
        public decimal buttons
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buttons"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buttons",
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
        }

        private Vector2 __prevPosition;
        public Vector2 prevPosition
        {
            get
            {
            if(__prevPosition == null)
            {
                __prevPosition = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "prevPosition",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __prevPosition;
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

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
        }

        
        public decimal distance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distance"
                );
            }
        }

        
        public decimal smoothFactor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "smoothFactor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "smoothFactor",
                    value
                );
            }
        }

        
        public decimal motionFactor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "motionFactor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "motionFactor",
                    value
                );
            }
        }

        
        public decimal worldX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "worldX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldX",
                    value
                );
            }
        }

        
        public decimal worldY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "worldY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldY",
                    value
                );
            }
        }

        
        public decimal moveTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "moveTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "moveTime",
                    value
                );
            }
        }

        
        public decimal downX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "downX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "downX",
                    value
                );
            }
        }

        
        public decimal downY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "downY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "downY",
                    value
                );
            }
        }

        
        public decimal downTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "downTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "downTime",
                    value
                );
            }
        }

        
        public decimal upX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upX",
                    value
                );
            }
        }

        
        public decimal upY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upY",
                    value
                );
            }
        }

        
        public decimal upTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upTime",
                    value
                );
            }
        }

        
        public bool primaryDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "primaryDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "primaryDown",
                    value
                );
            }
        }

        
        public bool isDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isDown",
                    value
                );
            }
        }

        
        public bool wasTouch
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "wasTouch"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wasTouch",
                    value
                );
            }
        }

        
        public bool wasCanceled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "wasCanceled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wasCanceled",
                    value
                );
            }
        }

        
        public decimal movementX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "movementX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "movementX",
                    value
                );
            }
        }

        
        public decimal movementY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "movementY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "movementY",
                    value
                );
            }
        }

        
        public decimal identifier
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "identifier"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "identifier",
                    value
                );
            }
        }

        
        public decimal pointerId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerId",
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

        
        public bool locked
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "locked"
                );
            }
        }

        
        public decimal deltaX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "deltaX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaX",
                    value
                );
            }
        }

        
        public decimal deltaY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "deltaY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaY",
                    value
                );
            }
        }

        
        public decimal deltaZ
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "deltaZ"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaZ",
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

        
        public decimal time
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "time"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Pointer() : base() { }

        public Pointer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Pointer(
            InputManager manager, decimal id
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "Pointer" },
                manager, id
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Pointer updateWorldPoint(Camera camera)
        {
            return EventHorizonBlazorInterop.FuncClass<Pointer>(
                entity => new Pointer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateWorldPoint" }, camera
                }
            );
        }

        public Vector2 positionToCamera(Camera camera, Vector2 output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "positionToCamera" }, camera, output
                }
            );
        }

        public bool noButtonDown()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "noButtonDown" }
                }
            );
        }

        public bool leftButtonDown()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "leftButtonDown" }
                }
            );
        }

        public bool rightButtonDown()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "rightButtonDown" }
                }
            );
        }

        public bool middleButtonDown()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "middleButtonDown" }
                }
            );
        }

        public bool backButtonDown()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "backButtonDown" }
                }
            );
        }

        public bool forwardButtonDown()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "forwardButtonDown" }
                }
            );
        }

        public bool leftButtonReleased()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "leftButtonReleased" }
                }
            );
        }

        public bool rightButtonReleased()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "rightButtonReleased" }
                }
            );
        }

        public bool middleButtonReleased()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "middleButtonReleased" }
                }
            );
        }

        public bool backButtonReleased()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "backButtonReleased" }
                }
            );
        }

        public bool forwardButtonReleased()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "forwardButtonReleased" }
                }
            );
        }

        public decimal getDistance()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDistance" }
                }
            );
        }

        public decimal getDistanceX()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDistanceX" }
                }
            );
        }

        public decimal getDistanceY()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDistanceY" }
                }
            );
        }

        public decimal getDuration()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDuration" }
                }
            );
        }

        public decimal getAngle()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAngle" }
                }
            );
        }

        public CachedEntity[] getInterpolatedPosition(System.Nullable<decimal> steps = null, CachedEntity[] out = null)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getInterpolatedPosition" }, steps, out
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