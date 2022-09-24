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

    
    
    [JsonConverter(typeof(CachedEntityConverter<KeyCombo>))]
    public class KeyCombo : CachedEntityObject
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
        private KeyboardPlugin __manager;
        public KeyboardPlugin manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<KeyboardPlugin>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new KeyboardPlugin() { ___guid = entity.___guid };
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

        
        public CachedEntity[] keyCodes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "keyCodes",
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
                    "keyCodes",
                    value
                );
            }
        }

        
        public decimal current
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "current"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "current",
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

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }

        
        public decimal timeLastMatched
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeLastMatched"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeLastMatched",
                    value
                );
            }
        }

        
        public bool matched
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "matched"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matched",
                    value
                );
            }
        }

        
        public decimal timeMatched
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeMatched"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeMatched",
                    value
                );
            }
        }

        
        public bool resetOnWrongKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "resetOnWrongKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resetOnWrongKey",
                    value
                );
            }
        }

        
        public decimal maxKeyDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxKeyDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxKeyDelay",
                    value
                );
            }
        }

        
        public bool resetOnMatch
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "resetOnMatch"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resetOnMatch",
                    value
                );
            }
        }

        
        public bool deleteOnMatch
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "deleteOnMatch"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deleteOnMatch",
                    value
                );
            }
        }

        
        public decimal progress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "progress"
                );
            }
        }
        #endregion
        
        #region Constructor
        public KeyCombo() : base() { }

        public KeyCombo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public KeyCombo(
            KeyboardPlugin keyboardPlugin, string keys, KeyComboConfig config = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Input", "Keyboard", "KeyCombo" },
                keyboardPlugin, keys, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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