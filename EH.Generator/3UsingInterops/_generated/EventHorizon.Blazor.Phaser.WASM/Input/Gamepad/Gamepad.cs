/// Generated - Do Not Edit
namespace Phaser.Input.Gamepad
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Gamepad>))]
    public class Gamepad : EventEmitter
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
        private GamepadPlugin __manager;
        public GamepadPlugin manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<GamepadPlugin>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new GamepadPlugin() { ___guid = entity.___guid };
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

        
        public CachedEntity pad
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "pad",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pad",
                    value
                );
            }
        }

        
        public string id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public decimal index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }

        
        public Button[] buttons
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Button>(
                    this.___guid,
                    "buttons",
                    (entity) =>
                    {
                        return new Button() { ___guid = entity.___guid };
                    }
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

        
        public Axis[] axes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Axis>(
                    this.___guid,
                    "axes",
                    (entity) =>
                    {
                        return new Axis() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "axes",
                    value
                );
            }
        }

        private GamepadHapticActuator __vibration;
        public GamepadHapticActuator vibration
        {
            get
            {
            if(__vibration == null)
            {
                __vibration = EventHorizonBlazorInterop.GetClass<GamepadHapticActuator>(
                    this.___guid,
                    "vibration",
                    (entity) =>
                    {
                        return new GamepadHapticActuator() { ___guid = entity.___guid };
                    }
                );
            }
            return __vibration;
            }
            set
            {
__vibration = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vibration",
                    value
                );
            }
        }

        private Vector2 __leftStick;
        public Vector2 leftStick
        {
            get
            {
            if(__leftStick == null)
            {
                __leftStick = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "leftStick",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __leftStick;
            }
            set
            {
__leftStick = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "leftStick",
                    value
                );
            }
        }

        private Vector2 __rightStick;
        public Vector2 rightStick
        {
            get
            {
            if(__rightStick == null)
            {
                __rightStick = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "rightStick",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __rightStick;
            }
            set
            {
__rightStick = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rightStick",
                    value
                );
            }
        }

        
        public bool connected
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "connected"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "connected",
                    value
                );
            }
        }

        
        public decimal timestamp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timestamp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timestamp",
                    value
                );
            }
        }

        
        public bool left
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "left"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "left",
                    value
                );
            }
        }

        
        public bool right
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "right"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "right",
                    value
                );
            }
        }

        
        public bool up
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "up"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "up",
                    value
                );
            }
        }

        
        public bool down
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "down"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "down",
                    value
                );
            }
        }

        
        public bool A
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "A"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "A",
                    value
                );
            }
        }

        
        public bool Y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "Y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "Y",
                    value
                );
            }
        }

        
        public bool X
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "X"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "X",
                    value
                );
            }
        }

        
        public bool B
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "B"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "B",
                    value
                );
            }
        }

        
        public decimal L1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "L1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "L1",
                    value
                );
            }
        }

        
        public decimal L2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "L2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "L2",
                    value
                );
            }
        }

        
        public decimal R1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "R1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "R1",
                    value
                );
            }
        }

        
        public decimal R2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "R2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "R2",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Gamepad() : base() { }

        public Gamepad(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Gamepad(
            GamepadPlugin manager, Pad pad
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "Gamepad", "Gamepad" },
                manager, pad
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getAxisTotal()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAxisTotal" }
                }
            );
        }

        public decimal getAxisValue(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAxisValue" }, index
                }
            );
        }

        public void setAxisThreshold(decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisThreshold" }, value
                }
            );
        }

        public decimal getButtonTotal()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getButtonTotal" }
                }
            );
        }

        public decimal getButtonValue(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getButtonValue" }, index
                }
            );
        }

        public bool isButtonDown(decimal index)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isButtonDown" }, index
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