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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Key>))]
    public class Key : EventEmitter
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
        private KeyboardPlugin __plugin;
        public KeyboardPlugin plugin
        {
            get
            {
            if(__plugin == null)
            {
                __plugin = EventHorizonBlazorInterop.GetClass<KeyboardPlugin>(
                    this.___guid,
                    "plugin",
                    (entity) =>
                    {
                        return new KeyboardPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugin;
            }
            set
            {
__plugin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugin",
                    value
                );
            }
        }

        
        public decimal keyCode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "keyCode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keyCode",
                    value
                );
            }
        }

        private KeyboardEvent __originalEvent;
        public KeyboardEvent originalEvent
        {
            get
            {
            if(__originalEvent == null)
            {
                __originalEvent = EventHorizonBlazorInterop.GetClass<KeyboardEvent>(
                    this.___guid,
                    "originalEvent",
                    (entity) =>
                    {
                        return new KeyboardEvent() { ___guid = entity.___guid };
                    }
                );
            }
            return __originalEvent;
            }
            set
            {
__originalEvent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originalEvent",
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

        
        public bool isUp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isUp",
                    value
                );
            }
        }

        
        public bool altKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "altKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "altKey",
                    value
                );
            }
        }

        
        public bool ctrlKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ctrlKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ctrlKey",
                    value
                );
            }
        }

        
        public bool shiftKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shiftKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shiftKey",
                    value
                );
            }
        }

        
        public bool metaKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "metaKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "metaKey",
                    value
                );
            }
        }

        
        public decimal location
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "location"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "location",
                    value
                );
            }
        }

        
        public decimal timeDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeDown",
                    value
                );
            }
        }

        
        public decimal duration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "duration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "duration",
                    value
                );
            }
        }

        
        public decimal timeUp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeUp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeUp",
                    value
                );
            }
        }

        
        public bool emitOnRepeat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "emitOnRepeat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitOnRepeat",
                    value
                );
            }
        }

        
        public decimal repeats
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "repeats"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeats",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Key() : base() { }

        public Key(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Key(
            KeyboardPlugin plugin, decimal keyCode
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "Keyboard", "Key" },
                plugin, keyCode
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Key setEmitOnRepeat(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Key>(
                entity => new Key() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEmitOnRepeat" }, value
                }
            );
        }

        public void onDown(KeyboardEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onDown" }, @event
                }
            );
        }

        public void onUp(KeyboardEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onUp" }, @event
                }
            );
        }

        public Key reset()
        {
            return EventHorizonBlazorInterop.FuncClass<Key>(
                entity => new Key() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
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