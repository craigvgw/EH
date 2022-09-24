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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleEmitter>))]
    public class ParticleEmitter : CachedEntityObject, IBlendMode, IMask, IScrollFactor, IVisible
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
        private ParticleEmitterManager __manager;
        public ParticleEmitterManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<ParticleEmitterManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new ParticleEmitterManager() { ___guid = entity.___guid };
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

        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public Frame[] frames
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Frame>(
                    this.___guid,
                    "frames",
                    (entity) =>
                    {
                        return new Frame() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frames",
                    value
                );
            }
        }

        private Frame __defaultFrame;
        public Frame defaultFrame
        {
            get
            {
            if(__defaultFrame == null)
            {
                __defaultFrame = EventHorizonBlazorInterop.GetClass<Frame>(
                    this.___guid,
                    "defaultFrame",
                    (entity) =>
                    {
                        return new Frame() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultFrame;
            }
            set
            {
__defaultFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultFrame",
                    value
                );
            }
        }

        
        public CachedEntity configFastMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "configFastMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "configFastMap",
                    value
                );
            }
        }

        
        public CachedEntity configOpMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "configOpMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "configOpMap",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private Particle __particleClass;
        public Particle particleClass
        {
            get
            {
            if(__particleClass == null)
            {
                __particleClass = EventHorizonBlazorInterop.GetClass<Particle>(
                    this.___guid,
                    "particleClass",
                    (entity) =>
                    {
                        return new Particle() { ___guid = entity.___guid };
                    }
                );
            }
            return __particleClass;
            }
            set
            {
__particleClass = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleClass",
                    value
                );
            }
        }

        private EmitterOp __x;
        public EmitterOp x
        {
            get
            {
            if(__x == null)
            {
                __x = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "x",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __x;
            }
            set
            {
__x = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        private EmitterOp __y;
        public EmitterOp y
        {
            get
            {
            if(__y == null)
            {
                __y = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "y",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __y;
            }
            set
            {
__y = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public bool radial
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "radial"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radial",
                    value
                );
            }
        }

        
        public decimal gravityX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gravityX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gravityX",
                    value
                );
            }
        }

        
        public decimal gravityY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gravityY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gravityY",
                    value
                );
            }
        }

        
        public bool acceleration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "acceleration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "acceleration",
                    value
                );
            }
        }

        private EmitterOp __accelerationX;
        public EmitterOp accelerationX
        {
            get
            {
            if(__accelerationX == null)
            {
                __accelerationX = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "accelerationX",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __accelerationX;
            }
            set
            {
__accelerationX = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "accelerationX",
                    value
                );
            }
        }

        private EmitterOp __accelerationY;
        public EmitterOp accelerationY
        {
            get
            {
            if(__accelerationY == null)
            {
                __accelerationY = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "accelerationY",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __accelerationY;
            }
            set
            {
__accelerationY = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "accelerationY",
                    value
                );
            }
        }

        private EmitterOp __maxVelocityX;
        public EmitterOp maxVelocityX
        {
            get
            {
            if(__maxVelocityX == null)
            {
                __maxVelocityX = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "maxVelocityX",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __maxVelocityX;
            }
            set
            {
__maxVelocityX = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxVelocityX",
                    value
                );
            }
        }

        private EmitterOp __maxVelocityY;
        public EmitterOp maxVelocityY
        {
            get
            {
            if(__maxVelocityY == null)
            {
                __maxVelocityY = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "maxVelocityY",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __maxVelocityY;
            }
            set
            {
__maxVelocityY = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxVelocityY",
                    value
                );
            }
        }

        private EmitterOp __speedX;
        public EmitterOp speedX
        {
            get
            {
            if(__speedX == null)
            {
                __speedX = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "speedX",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __speedX;
            }
            set
            {
__speedX = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speedX",
                    value
                );
            }
        }

        private EmitterOp __speedY;
        public EmitterOp speedY
        {
            get
            {
            if(__speedY == null)
            {
                __speedY = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "speedY",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __speedY;
            }
            set
            {
__speedY = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speedY",
                    value
                );
            }
        }

        
        public bool moveTo
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "moveTo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "moveTo",
                    value
                );
            }
        }

        private EmitterOp __moveToX;
        public EmitterOp moveToX
        {
            get
            {
            if(__moveToX == null)
            {
                __moveToX = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "moveToX",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __moveToX;
            }
            set
            {
__moveToX = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "moveToX",
                    value
                );
            }
        }

        private EmitterOp __moveToY;
        public EmitterOp moveToY
        {
            get
            {
            if(__moveToY == null)
            {
                __moveToY = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "moveToY",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __moveToY;
            }
            set
            {
__moveToY = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "moveToY",
                    value
                );
            }
        }

        private EmitterOp __bounce;
        public EmitterOp bounce
        {
            get
            {
            if(__bounce == null)
            {
                __bounce = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "bounce",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
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

        private EmitterOp __scaleX;
        public EmitterOp scaleX
        {
            get
            {
            if(__scaleX == null)
            {
                __scaleX = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "scaleX",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __scaleX;
            }
            set
            {
__scaleX = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleX",
                    value
                );
            }
        }

        private EmitterOp __scaleY;
        public EmitterOp scaleY
        {
            get
            {
            if(__scaleY == null)
            {
                __scaleY = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "scaleY",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __scaleY;
            }
            set
            {
__scaleY = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleY",
                    value
                );
            }
        }

        private EmitterOp __tint;
        public EmitterOp tint
        {
            get
            {
            if(__tint == null)
            {
                __tint = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "tint",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __tint;
            }
            set
            {
__tint = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        private EmitterOp __alpha;
        public EmitterOp alpha
        {
            get
            {
            if(__alpha == null)
            {
                __alpha = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "alpha",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __alpha;
            }
            set
            {
__alpha = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        private EmitterOp __lifespan;
        public EmitterOp lifespan
        {
            get
            {
            if(__lifespan == null)
            {
                __lifespan = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "lifespan",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __lifespan;
            }
            set
            {
__lifespan = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lifespan",
                    value
                );
            }
        }

        private EmitterOp __angle;
        public EmitterOp angle
        {
            get
            {
            if(__angle == null)
            {
                __angle = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "angle",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __angle;
            }
            set
            {
__angle = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        private EmitterOp __rotate;
        public EmitterOp rotate
        {
            get
            {
            if(__rotate == null)
            {
                __rotate = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "rotate",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotate;
            }
            set
            {
__rotate = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotate",
                    value
                );
            }
        }

        private ParticleEmitterCallback __emitCallback;
        public ParticleEmitterCallback emitCallback
        {
            get
            {
            if(__emitCallback == null)
            {
                __emitCallback = EventHorizonBlazorInterop.GetClass<ParticleEmitterCallback>(
                    this.___guid,
                    "emitCallback",
                    (entity) =>
                    {
                        return new ParticleEmitterCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __emitCallback;
            }
            set
            {
__emitCallback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitCallback",
                    value
                );
            }
        }

        
        public CachedEntity emitCallbackScope
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "emitCallbackScope",
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
                    "emitCallbackScope",
                    value
                );
            }
        }

        private ParticleDeathCallback __deathCallback;
        public ParticleDeathCallback deathCallback
        {
            get
            {
            if(__deathCallback == null)
            {
                __deathCallback = EventHorizonBlazorInterop.GetClass<ParticleDeathCallback>(
                    this.___guid,
                    "deathCallback",
                    (entity) =>
                    {
                        return new ParticleDeathCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __deathCallback;
            }
            set
            {
__deathCallback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deathCallback",
                    value
                );
            }
        }

        
        public CachedEntity deathCallbackScope
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "deathCallbackScope",
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
                    "deathCallbackScope",
                    value
                );
            }
        }

        
        public decimal maxParticles
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxParticles"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxParticles",
                    value
                );
            }
        }

        private EmitterOp __quantity;
        public EmitterOp quantity
        {
            get
            {
            if(__quantity == null)
            {
                __quantity = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "quantity",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __quantity;
            }
            set
            {
__quantity = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "quantity",
                    value
                );
            }
        }

        private EmitterOp __delay;
        public EmitterOp delay
        {
            get
            {
            if(__delay == null)
            {
                __delay = EventHorizonBlazorInterop.GetClass<EmitterOp>(
                    this.___guid,
                    "delay",
                    (entity) =>
                    {
                        return new EmitterOp() { ___guid = entity.___guid };
                    }
                );
            }
            return __delay;
            }
            set
            {
__delay = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delay",
                    value
                );
            }
        }

        
        public decimal frequency
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frequency"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frequency",
                    value
                );
            }
        }

        
        public bool on
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "on"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "on",
                    value
                );
            }
        }

        
        public bool particleBringToTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "particleBringToTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleBringToTop",
                    value
                );
            }
        }

        
        public decimal timeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeScale",
                    value
                );
            }
        }

        private EdgeZone __emitZone;
        public EdgeZone emitZone
        {
            get
            {
            if(__emitZone == null)
            {
                __emitZone = EventHorizonBlazorInterop.GetClass<EdgeZone>(
                    this.___guid,
                    "emitZone",
                    (entity) =>
                    {
                        return new EdgeZone() { ___guid = entity.___guid };
                    }
                );
            }
            return __emitZone;
            }
            set
            {
__emitZone = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitZone",
                    value
                );
            }
        }

        private DeathZone __deathZone;
        public DeathZone deathZone
        {
            get
            {
            if(__deathZone == null)
            {
                __deathZone = EventHorizonBlazorInterop.GetClass<DeathZone>(
                    this.___guid,
                    "deathZone",
                    (entity) =>
                    {
                        return new DeathZone() { ___guid = entity.___guid };
                    }
                );
            }
            return __deathZone;
            }
            set
            {
__deathZone = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deathZone",
                    value
                );
            }
        }

        private Rectangle __bounds;
        public Rectangle bounds
        {
            get
            {
            if(__bounds == null)
            {
                __bounds = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
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

        
        public bool collideLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideLeft",
                    value
                );
            }
        }

        
        public bool collideRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideRight",
                    value
                );
            }
        }

        
        public bool collideTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideTop",
                    value
                );
            }
        }

        
        public bool collideBottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideBottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideBottom",
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

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }

        
        public decimal blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }

        private GameObject __follow;
        public GameObject follow
        {
            get
            {
            if(__follow == null)
            {
                __follow = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "follow",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __follow;
            }
            set
            {
__follow = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "follow",
                    value
                );
            }
        }

        private Vector2 __followOffset;
        public Vector2 followOffset
        {
            get
            {
            if(__followOffset == null)
            {
                __followOffset = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "followOffset",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __followOffset;
            }
            set
            {
__followOffset = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "followOffset",
                    value
                );
            }
        }

        
        public bool trackVisible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "trackVisible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trackVisible",
                    value
                );
            }
        }

        
        public decimal currentFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentFrame",
                    value
                );
            }
        }

        
        public bool randomFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "randomFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "randomFrame",
                    value
                );
            }
        }

        
        public decimal frameQuantity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frameQuantity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frameQuantity",
                    value
                );
            }
        }

        private BitmapMask __mask;
        public BitmapMask mask
        {
            get
            {
            if(__mask == null)
            {
                __mask = EventHorizonBlazorInterop.GetClass<BitmapMask>(
                    this.___guid,
                    "mask",
                    (entity) =>
                    {
                        return new BitmapMask() { ___guid = entity.___guid };
                    }
                );
            }
            return __mask;
            }
            set
            {
__mask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mask",
                    value
                );
            }
        }

        
        public decimal scrollFactorX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorX",
                    value
                );
            }
        }

        
        public decimal scrollFactorY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorY",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ParticleEmitter() : base() { }

        public ParticleEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ParticleEmitter(
            ParticleEmitterManager manager, ParticleEmitterConfig config
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Particles", "ParticleEmitter" },
                manager, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public ParticleEmitter fromJSON(ParticleEmitterConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromJSON" }, config
                }
            );
        }

        public CachedEntity toJSON(object output = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, output
                }
            );
        }

        public ParticleEmitter startFollow(GameObject target, System.Nullable<decimal> offsetX = null, System.Nullable<decimal> offsetY = null, System.Nullable<bool> trackVisible = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "startFollow" }, target, offsetX, offsetY, trackVisible
                }
            );
        }

        public ParticleEmitter stopFollow()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopFollow" }
                }
            );
        }

        public Frame getFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFrame" }
                }
            );
        }

        public ParticleEmitter setFrame(CachedEntity[] frames, System.Nullable<bool> pickRandom = null, System.Nullable<decimal> quantity = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frames, pickRandom, quantity
                }
            );
        }

        public ParticleEmitter setRadial(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRadial" }, value
                }
            );
        }

        public ParticleEmitter setPosition(EmitterOpOnEmitType x, EmitterOpOnEmitType y)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y
                }
            );
        }

        public ParticleEmitter setBounds(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounds" }, x, y, width, height
                }
            );
        }

        public ParticleEmitter setSpeedX(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSpeedX" }, value
                }
            );
        }

        public ParticleEmitter setSpeedY(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSpeedY" }, value
                }
            );
        }

        public ParticleEmitter setSpeed(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSpeed" }, value
                }
            );
        }

        public ParticleEmitter setScaleX(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScaleX" }, value
                }
            );
        }

        public ParticleEmitter setScaleY(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScaleY" }, value
                }
            );
        }

        public ParticleEmitter setScale(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, value
                }
            );
        }

        public ParticleEmitter setGravityX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGravityX" }, value
                }
            );
        }

        public ParticleEmitter setGravityY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGravityY" }, value
                }
            );
        }

        public ParticleEmitter setGravity(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGravity" }, x, y
                }
            );
        }

        public ParticleEmitter setAlpha(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public ParticleEmitter setTint(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTint" }, value
                }
            );
        }

        public ParticleEmitter setEmitterAngle(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEmitterAngle" }, value
                }
            );
        }

        public ParticleEmitter setAngle(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, value
                }
            );
        }

        public ParticleEmitter setLifespan(EmitterOpOnEmitType value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLifespan" }, value
                }
            );
        }

        public ParticleEmitter setQuantity(EmitterOpOnEmitType quantity)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setQuantity" }, quantity
                }
            );
        }

        public ParticleEmitter setFrequency(decimal frequency, EmitterOpOnEmitType quantity = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrequency" }, frequency, quantity
                }
            );
        }

        public ParticleEmitter setEmitZone(ParticleEmitterEdgeZoneConfig zoneConfig = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEmitZone" }, zoneConfig
                }
            );
        }

        public ParticleEmitter setDeathZone(ParticleEmitterDeathZoneConfig zoneConfig = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDeathZone" }, zoneConfig
                }
            );
        }

        public ParticleEmitter reserve(decimal particleCount)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reserve" }, particleCount
                }
            );
        }

        public decimal getAliveParticleCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAliveParticleCount" }
                }
            );
        }

        public decimal getDeadParticleCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDeadParticleCount" }
                }
            );
        }

        public decimal getParticleCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getParticleCount" }
                }
            );
        }

        public bool atLimit()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "atLimit" }
                }
            );
        }

        public ParticleEmitter onParticleEmit(ParticleEmitterCallback callback, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "onParticleEmit" }, callback, context
                }
            );
        }

        public ParticleEmitter onParticleDeath(ParticleDeathCallback callback, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "onParticleDeath" }, callback, context
                }
            );
        }

        public ParticleEmitter killAll()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "killAll" }
                }
            );
        }

        public ParticleEmitter forEachAlive(ParticleEmitterCallback callback, object context)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "forEachAlive" }, callback, context
                }
            );
        }

        public ParticleEmitter forEachDead(ParticleEmitterCallback callback, object context)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "forEachDead" }, callback, context
                }
            );
        }

        public ParticleEmitter start()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" }
                }
            );
        }

        public ParticleEmitter stop()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public ParticleEmitter pause()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public ParticleEmitter resume()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }
                }
            );
        }

        public ParticleEmitter remove()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }
                }
            );
        }

        public ParticleEmitter depthSort()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "depthSort" }
                }
            );
        }

        public ParticleEmitter flow(decimal frequency, EmitterOpOnEmitType count = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "flow" }, frequency, count
                }
            );
        }

        public Particle explode(decimal count, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Particle>(
                entity => new Particle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "explode" }, count, x, y
                }
            );
        }

        public Particle emitParticleAt(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> count = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Particle>(
                entity => new Particle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "emitParticleAt" }, x, y, count
                }
            );
        }

        public Particle emitParticle(System.Nullable<decimal> count = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Particle>(
                entity => new Particle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "emitParticle" }, count, x, y
                }
            );
        }

        public void preUpdate(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preUpdate" }, time, delta
                }
            );
        }

        public decimal depthSortCallback(object a, object b)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "depthSortCallback" }, a, b
                }
            );
        }

        public ParticleEmitter setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public ParticleEmitter setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public ParticleEmitter clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearMask" }, destroyMask
                }
            );
        }

        public BitmapMask createBitmapMask(GameObject renderable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapMask>(
                entity => new BitmapMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBitmapMask" }, renderable
                }
            );
        }

        public GeometryMask createGeometryMask(Graphics graphics = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GeometryMask>(
                entity => new GeometryMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createGeometryMask" }, graphics
                }
            );
        }

        public ParticleEmitter setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public ParticleEmitter setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}