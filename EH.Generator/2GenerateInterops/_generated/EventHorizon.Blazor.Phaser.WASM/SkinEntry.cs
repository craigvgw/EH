/// Generated - Do Not Edit
namespace spine
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkinEntry>))]
    public class SkinEntry : CachedEntityObject
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
        
        public decimal slotIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "slotIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "slotIndex",
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

        private Attachment __attachment;
        public Attachment attachment
        {
            get
            {
            if(__attachment == null)
            {
                __attachment = EventHorizonBlazorInterop.GetClass<Attachment>(
                    this.___guid,
                    "attachment",
                    (entity) =>
                    {
                        return new Attachment() { ___guid = entity.___guid };
                    }
                );
            }
            return __attachment;
            }
            set
            {
__attachment = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachment",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SkinEntry() : base() { }

        public SkinEntry(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SkinEntry(
            decimal slotIndex, string name, Attachment attachment
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "SkinEntry" },
                slotIndex, name, attachment
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}