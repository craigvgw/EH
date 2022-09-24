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

    public interface ICompositeDefinition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICompositeDefinitionCachedEntity>))]
    public class ICompositeDefinitionCachedEntity : CachedEntityObject, ICompositeDefinition
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
        
        public CachedEntity[] bodies
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "bodies"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bodies",
                    value
                );
            }
        }

        
        public CachedEntity[] composites
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "composites"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "composites",
                    value
                );
            }
        }

        
        public CachedEntity[] constraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "constraints"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constraints",
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

        
        public bool isModified
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isModified"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isModified",
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
        public ICompositeDefinitionCachedEntity() : base() { }

        public ICompositeDefinitionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}