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

    public interface IConstraintDefinition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IConstraintDefinitionCachedEntity>))]
    public class IConstraintDefinitionCachedEntity : CachedEntityObject, IConstraintDefinition
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
        private IBodyDefinitionCachedEntity __bodyA;
        public IBodyDefinitionCachedEntity bodyA
        {
            get
            {
            if(__bodyA == null)
            {
                __bodyA = EventHorizonBlazorInterop.GetClass<IBodyDefinitionCachedEntity>(
                    this.___guid,
                    "bodyA",
                    (entity) =>
                    {
                        return new IBodyDefinitionCachedEntity() { ___guid = entity.___guid };
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

        private IBodyDefinitionCachedEntity __bodyB;
        public IBodyDefinitionCachedEntity bodyB
        {
            get
            {
            if(__bodyB == null)
            {
                __bodyB = EventHorizonBlazorInterop.GetClass<IBodyDefinitionCachedEntity>(
                    this.___guid,
                    "bodyB",
                    (entity) =>
                    {
                        return new IBodyDefinitionCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
            }
        }

        private CVector __pointA;
        public CVector pointA
        {
            get
            {
            if(__pointA == null)
            {
                __pointA = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "pointA",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointA;
            }
            set
            {
__pointA = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointA",
                    value
                );
            }
        }

        private CVector __pointB;
        public CVector pointB
        {
            get
            {
            if(__pointB == null)
            {
                __pointB = EventHorizonBlazorInterop.GetClass<CVector>(
                    this.___guid,
                    "pointB",
                    (entity) =>
                    {
                        return new CVector() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointB;
            }
            set
            {
__pointB = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointB",
                    value
                );
            }
        }

        private IConstraintRenderDefinitionCachedEntity __render;
        public IConstraintRenderDefinitionCachedEntity render
        {
            get
            {
            if(__render == null)
            {
                __render = EventHorizonBlazorInterop.GetClass<IConstraintRenderDefinitionCachedEntity>(
                    this.___guid,
                    "render",
                    (entity) =>
                    {
                        return new IConstraintRenderDefinitionCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal stiffness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stiffness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stiffness",
                    value
                );
            }
        }

        
        public decimal damping
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "damping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "damping",
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
        #endregion
        
        #region Constructor
        public IConstraintDefinitionCachedEntity() : base() { }

        public IConstraintDefinitionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}