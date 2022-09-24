/// Generated - Do Not Edit
namespace MatterJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IBodyDefinition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IBodyDefinitionCachedEntity>))]
    public class IBodyDefinitionCachedEntity : CachedEntityObject, IBodyDefinition
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
        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal angularSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSpeed",
                    value
                );
            }
        }

        
        public decimal angularVelocity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularVelocity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularVelocity",
                    value
                );
            }
        }

        
        public decimal area
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "area"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "area",
                    value
                );
            }
        }

        
        public CVector[] axes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CVector>(
                    this.___guid,
                    "axes",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
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

        private IBoundCachedEntity __bounds;
        public IBoundCachedEntity bounds
        {
            get
            {
            if(__bounds == null)
            {
                __bounds = EventHorizonBlazorInterop.GetClass<IBoundCachedEntity>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new IBoundCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal density
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "density"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "density",
                    value
                );
            }
        }

        private CVector __force;
        public CVector force
        {
            get
            {
            if(__force == null)
            {
                __force = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "force",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __force;
            }
            set
            {
__force = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "force",
                    value
                );
            }
        }

        
        public decimal friction
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "friction"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "friction",
                    value
                );
            }
        }

        
        public decimal frictionAir
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frictionAir"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frictionAir",
                    value
                );
            }
        }

        
        public decimal inertia
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertia"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertia",
                    value
                );
            }
        }

        
        public decimal inverseInertia
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inverseInertia"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverseInertia",
                    value
                );
            }
        }

        
        public decimal inverseMass
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inverseMass"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverseMass",
                    value
                );
            }
        }

        
        public bool isSensor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSensor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isSensor",
                    value
                );
            }
        }

        
        public bool isSleeping
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSleeping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isSleeping",
                    value
                );
            }
        }

        
        public bool isStatic
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStatic"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isStatic",
                    value
                );
            }
        }

        
        public string label
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "label"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "label",
                    value
                );
            }
        }

        
        public decimal mass
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mass"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mass",
                    value
                );
            }
        }

        
        public decimal motion
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "motion"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "motion",
                    value
                );
            }
        }

        private CVector __position;
        public CVector position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
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

        private IBodyRenderOptionsCachedEntity __render;
        public IBodyRenderOptionsCachedEntity render
        {
            get
            {
            if(__render == null)
            {
                __render = EventHorizonBlazorInterop.GetClass<IBodyRenderOptionsCachedEntity>(
                    this.___guid,
                    "render",
                    (entity) =>
                    {
                        return new IBodyRenderOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __render;
            }
            set
            {
__render = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "render",
                    value
                );
            }
        }

        
        public decimal restitution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "restitution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "restitution",
                    value
                );
            }
        }

        
        public decimal sleepThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sleepThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sleepThreshold",
                    value
                );
            }
        }

        
        public decimal slop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "slop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "slop",
                    value
                );
            }
        }

        
        public decimal speed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speed",
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

        
        public decimal torque
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "torque"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "torque",
                    value
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private CVector __velocity;
        public CVector velocity
        {
            get
            {
            if(__velocity == null)
            {
                __velocity = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "velocity",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __velocity;
            }
            set
            {
__velocity = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "velocity",
                    value
                );
            }
        }

        
        public CVector[] vertices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CVector>(
                    this.___guid,
                    "vertices",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }

        
        public CachedEntity[] parts
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "parts"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parts",
                    value
                );
            }
        }

        
        public CachedEntity parent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "parent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        
        public decimal frictionStatic
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frictionStatic"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frictionStatic",
                    value
                );
            }
        }

        private ICollisionFilterCachedEntity __collisionFilter;
        public ICollisionFilterCachedEntity collisionFilter
        {
            get
            {
            if(__collisionFilter == null)
            {
                __collisionFilter = EventHorizonBlazorInterop.GetClass<ICollisionFilterCachedEntity>(
                    this.___guid,
                    "collisionFilter",
                    (entity) =>
                    {
                        return new ICollisionFilterCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __collisionFilter;
            }
            set
            {
__collisionFilter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionFilter",
                    value
                );
            }
        }

        
        public CachedEntity gameObject
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "gameObject",
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
                    "gameObject",
                    value
                );
            }
        }

        private CVector __gravityScale;
        public CVector gravityScale
        {
            get
            {
            if(__gravityScale == null)
            {
                __gravityScale = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "gravityScale",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __gravityScale;
            }
            set
            {
__gravityScale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gravityScale",
                    value
                );
            }
        }

        
        public bool ignoreGravity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreGravity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreGravity",
                    value
                );
            }
        }

        
        public bool ignorePointer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignorePointer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignorePointer",
                    value
                );
            }
        }

        
        public CachedEntity onCollideWith
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "onCollideWith",
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
                    "onCollideWith",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IBodyDefinitionCachedEntity() : base() { }

        public IBodyDefinitionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void onCollideCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onCollideCallback" }
                }
            );
        }

        public void onCollideEndCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onCollideEndCallback" }
                }
            );
        }

        public void onCollideActiveCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onCollideActiveCallback" }
                }
            );
        }
        #endregion
    }
}