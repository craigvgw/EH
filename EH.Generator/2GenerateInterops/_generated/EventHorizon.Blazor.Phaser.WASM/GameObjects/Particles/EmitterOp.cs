/// Generated - Do Not Edit
namespace Phaser.GameObjects.Particles
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<EmitterOp>))]
    public class EmitterOp : CachedEntityObject
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
        
        public string propertyKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "propertyKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "propertyKey",
                    value
                );
            }
        }

        
        public decimal propertyValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "propertyValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "propertyValue",
                    value
                );
            }
        }

        
        public decimal defaultValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultValue",
                    value
                );
            }
        }

        
        public decimal steps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "steps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "steps",
                    value
                );
            }
        }

        
        public decimal counter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "counter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "counter",
                    value
                );
            }
        }

        
        public decimal start
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "start"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "start",
                    value
                );
            }
        }

        
        public decimal end
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "end"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "end",
                    value
                );
            }
        }

        
        public bool emitOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "emitOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitOnly",
                    value
                );
            }
        }

        private EmitterOpOnEmitCallback __onEmit;
        public EmitterOpOnEmitCallback onEmit
        {
            get
            {
            if(__onEmit == null)
            {
                __onEmit = EventHorizonBlazorInterop.GetClass<EmitterOpOnEmitCallback>(
                    this.___guid,
                    "onEmit",
                    (entity) =>
                    {
                        return new EmitterOpOnEmitCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __onEmit;
            }
            set
            {
__onEmit = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onEmit",
                    value
                );
            }
        }

        private EmitterOpOnUpdateCallback __onUpdate;
        public EmitterOpOnUpdateCallback onUpdate
        {
            get
            {
            if(__onUpdate == null)
            {
                __onUpdate = EventHorizonBlazorInterop.GetClass<EmitterOpOnUpdateCallback>(
                    this.___guid,
                    "onUpdate",
                    (entity) =>
                    {
                        return new EmitterOpOnUpdateCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __onUpdate;
            }
            set
            {
__onUpdate = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onUpdate",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public EmitterOp() : base() { }

        public EmitterOp(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public EmitterOp(
            ParticleEmitterConfig config, string key, decimal defaultValue, System.Nullable<bool> emitOnly = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Particles", "EmitterOp" },
                config, key, defaultValue, emitOnly
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void ease()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "ease" }
                }
            );
        }

        public void loadConfig(ParticleEmitterConfig config = null, string newKey = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadConfig" }, config, newKey
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }

        public EmitterOp onChange(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<EmitterOp>(
                entity => new EmitterOp() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "onChange" }, value
                }
            );
        }

        public EmitterOp setMethods()
        {
            return EventHorizonBlazorInterop.FuncClass<EmitterOp>(
                entity => new EmitterOp() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMethods" }
                }
            );
        }

        public bool has(object @object, string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "has" }, @object, key
                }
            );
        }

        public bool hasBoth(object @object, string key1, string key2)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasBoth" }, @object, key1, key2
                }
            );
        }

        public bool hasEither(object @object, string key1, string key2)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasEither" }, @object, key1, key2
                }
            );
        }

        public decimal defaultEmit(Particle particle, string key, System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "defaultEmit" }, particle, key, value
                }
            );
        }

        public decimal defaultUpdate(Particle particle, string key, decimal t, decimal value)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "defaultUpdate" }, particle, key, t, value
                }
            );
        }

        public decimal staticValueEmit()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "staticValueEmit" }
                }
            );
        }

        public decimal staticValueUpdate()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "staticValueUpdate" }
                }
            );
        }

        public decimal randomStaticValueEmit()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "randomStaticValueEmit" }
                }
            );
        }

        public decimal randomRangedValueEmit(Particle particle, string key)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "randomRangedValueEmit" }, particle, key
                }
            );
        }

        public decimal steppedEmit()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "steppedEmit" }
                }
            );
        }

        public decimal easedValueEmit(Particle particle, string key)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "easedValueEmit" }, particle, key
                }
            );
        }

        public decimal easeValueUpdate(Particle particle, string key, decimal t)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "easeValueUpdate" }, particle, key, t
                }
            );
        }
        #endregion
    }
}