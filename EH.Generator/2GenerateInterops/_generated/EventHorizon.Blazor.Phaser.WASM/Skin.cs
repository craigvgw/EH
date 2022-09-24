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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Skin>))]
    public class Skin : CachedEntityObject
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

        
        public Map<Attachment>[] attachments
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Map<Attachment>>(
                    this.___guid,
                    "attachments",
                    (entity) =>
                    {
                        return new Map<Attachment>() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachments",
                    value
                );
            }
        }

        
        public BoneData[] bones
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BoneData>(
                    this.___guid,
                    "bones",
                    (entity) =>
                    {
                        return new BoneData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bones",
                    value
                );
            }
        }

        
        public ConstraintData[] constraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<ConstraintData>(
                    this.___guid,
                    "constraints",
                    (entity) =>
                    {
                        return new ConstraintData() { ___guid = entity.___guid };
                    }
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
        #endregion
        
        #region Constructor
        public Skin() : base() { }

        public Skin(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Skin(
            string name
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "Skin" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setAttachment(decimal slotIndex, string name, Attachment attachment)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAttachment" }, slotIndex, name, attachment
                }
            );
        }

        public void addSkin(Skin skin)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addSkin" }, skin
                }
            );
        }

        public void copySkin(Skin skin)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copySkin" }, skin
                }
            );
        }

        public Attachment getAttachment(decimal slotIndex, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Attachment>(
                entity => new Attachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttachment" }, slotIndex, name
                }
            );
        }

        public void removeAttachment(decimal slotIndex, string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeAttachment" }, slotIndex, name
                }
            );
        }

        public SkinEntry[] getAttachments()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<SkinEntry>(
                entity => new SkinEntry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttachments" }
                }
            );
        }

        public void getAttachmentsForSlot(decimal slotIndex, SkinEntry[] attachments)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAttachmentsForSlot" }, slotIndex, attachments
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void attachAll(Skeleton skeleton, Skin oldSkin)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachAll" }, skeleton, oldSkin
                }
            );
        }
        #endregion
    }
}