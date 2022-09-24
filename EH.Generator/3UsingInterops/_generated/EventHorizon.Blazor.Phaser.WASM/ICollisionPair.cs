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

    public interface ICollisionPair : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICollisionPairCachedEntity>))]
    public class ICollisionPairCachedEntity : CachedEntityObject, ICollisionPair
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

        private CBody __bodyA;
        public CBody bodyA
        {
            get
            {
            if(__bodyA == null)
            {
                __bodyA = EventHorizonBlazorInterop.GetClass<CBody>(
                    this.___guid,
                    "bodyA",
                    (entity) =>
                    {
                        return new CBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __bodyA;
            }
            set
            {
__bodyA = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bodyA",
                    value
                );
            }
        }

        private CBody __bodyB;
        public CBody bodyB
        {
            get
            {
            if(__bodyB == null)
            {
                __bodyB = EventHorizonBlazorInterop.GetClass<CBody>(
                    this.___guid,
                    "bodyB",
                    (entity) =>
                    {
                        return new CBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __bodyB;
            }
            set
            {
__bodyB = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bodyB",
                    value
                );
            }
        }

        
        public CVector[] activeContacts
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CVector>(
                    this.___guid,
                    "activeContacts",
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
                    "activeContacts",
                    value
                );
            }
        }

        
        public decimal separation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "separation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "separation",
                    value
                );
            }
        }

        
        public bool isActive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isActive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isActive",
                    value
                );
            }
        }

        
        public bool confirmedActive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "confirmedActive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "confirmedActive",
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

        
        public decimal timeCreated
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeCreated"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeCreated",
                    value
                );
            }
        }

        
        public decimal timeUpdated
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeUpdated"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeUpdated",
                    value
                );
            }
        }

        private ICollisionDataCachedEntity __collision;
        public ICollisionDataCachedEntity collision
        {
            get
            {
            if(__collision == null)
            {
                __collision = EventHorizonBlazorInterop.GetClass<ICollisionDataCachedEntity>(
                    this.___guid,
                    "collision",
                    (entity) =>
                    {
                        return new ICollisionDataCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __collision;
            }
            set
            {
__collision = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collision",
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
        #endregion
        
        #region Constructor
        public ICollisionPairCachedEntity() : base() { }

        public ICollisionPairCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}