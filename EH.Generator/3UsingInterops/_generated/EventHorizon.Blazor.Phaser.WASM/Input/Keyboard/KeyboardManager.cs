/// Generated - Do Not Edit
namespace Phaser.Input.Keyboard
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<KeyboardManager>))]
    public class KeyboardManager : CachedEntityObject
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

        
        public bool preventDefault
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventDefault"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventDefault",
                    value
                );
            }
        }

        
        public decimal[] captures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "captures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "captures",
                    value
                );
            }
        }

        
        public bool enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enabled",
                    value
                );
            }
        }

        
        public CachedEntity target
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "target",
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
                    "target",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public KeyboardManager() : base() { }

        public KeyboardManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public KeyboardManager(
            InputManager inputManager
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "Keyboard", "KeyboardManager" },
                inputManager
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void onKeyDown()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onKeyDown" }
                }
            );
        }

        public void onKeyUp()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onKeyUp" }
                }
            );
        }

        public void startListeners()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startListeners" }
                }
            );
        }

        public void stopListeners()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopListeners" }
                }
            );
        }

        public void addCapture(string keycode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCapture" }, keycode
                }
            );
        }

        public void removeCapture(string keycode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeCapture" }, keycode
                }
            );
        }

        public void clearCaptures()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearCaptures" }
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