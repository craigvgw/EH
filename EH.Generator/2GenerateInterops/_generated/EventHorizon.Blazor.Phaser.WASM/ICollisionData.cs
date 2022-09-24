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

    public interface ICollisionData : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICollisionDataCachedEntity>))]
    public class ICollisionDataCachedEntity : CachedEntityObject, ICollisionData
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
        
        public bool collided
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collided"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collided",
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

        private CBody __axisBody;
        public CBody axisBody
        {
            get
            {
            if(__axisBody == null)
            {
                __axisBody = EventHorizonBlazorInterop.GetClass<CBody>(
                    this.___guid,
                    "axisBody",
                    (entity) =>
                    {
                        return new CBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __axisBody;
            }
            set
            {
__axisBody = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "axisBody",
                    value
                );
            }
        }

        
        public decimal axisNumber
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "axisNumber"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "axisNumber",
                    value
                );
            }
        }

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        private CBody __parentA;
        public CBody parentA
        {
            get
            {
            if(__parentA == null)
            {
                __parentA = EventHorizonBlazorInterop.GetClass<CBody>(
                    this.___guid,
                    "parentA",
                    (entity) =>
                    {
                        return new CBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentA;
            }
            set
            {
__parentA = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentA",
                    value
                );
            }
        }

        private CBody __parentB;
        public CBody parentB
        {
            get
            {
            if(__parentB == null)
            {
                __parentB = EventHorizonBlazorInterop.GetClass<CBody>(
                    this.___guid,
                    "parentB",
                    (entity) =>
                    {
                        return new CBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentB;
            }
            set
            {
__parentB = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentB",
                    value
                );
            }
        }

        private CVector __normal;
        public CVector normal
        {
            get
            {
            if(__normal == null)
            {
                __normal = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __normal;
            }
            set
            {
__normal = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normal",
                    value
                );
            }
        }

        private CVector __tangent;
        public CVector tangent
        {
            get
            {
            if(__tangent == null)
            {
                __tangent = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "tangent",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __tangent;
            }
            set
            {
__tangent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tangent",
                    value
                );
            }
        }

        private CVector __penetration;
        public CVector penetration
        {
            get
            {
            if(__penetration == null)
            {
                __penetration = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "penetration",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __penetration;
            }
            set
            {
__penetration = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "penetration",
                    value
                );
            }
        }

        
        public CVector[] supports
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CVector>(
                    this.___guid,
                    "supports",
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
                    "supports",
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
        public ICollisionDataCachedEntity() : base() { }

        public ICollisionDataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}