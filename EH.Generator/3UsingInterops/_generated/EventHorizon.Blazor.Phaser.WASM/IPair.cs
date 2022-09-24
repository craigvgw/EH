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

    public interface IPair : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IPairCachedEntity>))]
    public class IPairCachedEntity : CachedEntityObject, IPair
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
        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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

        
        public CachedEntity contacts
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "contacts",
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
                    "contacts",
                    value
                );
            }
        }

        
        public CachedEntity activeContacts
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "activeContacts",
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
        public IPairCachedEntity() : base() { }

        public IPairCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}