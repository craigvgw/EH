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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Slot>))]
    public class Slot : CachedEntityObject
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
        private SlotData __data;
        public SlotData data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<SlotData>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new SlotData() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        private Bone __bone;
        public Bone bone
        {
            get
            {
            if(__bone == null)
            {
                __bone = EventHorizonBlazorInterop.GetClass<Bone>(
                    this.___guid,
                    "bone",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
            }
            return __bone;
            }
            set
            {
__bone = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bone",
                    value
                );
            }
        }

        private Color __color;
        public Color color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        private Color __darkColor;
        public Color darkColor
        {
            get
            {
            if(__darkColor == null)
            {
                __darkColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "darkColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __darkColor;
            }
            set
            {
__darkColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "darkColor",
                    value
                );
            }
        }

        
        public decimal[] deform
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "deform"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deform",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Slot() : base() { }

        public Slot(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Slot(
            SlotData data, Bone bone
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "Slot" },
                data, bone
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Attachment getAttachment()
        {
            return EventHorizonBlazorInterop.FuncClass<Attachment>(
                entity => new Attachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttachment" }
                }
            );
        }

        public void setAttachment(Attachment attachment)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAttachment" }, attachment
                }
            );
        }

        public void setAttachmentTime(decimal time)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAttachmentTime" }, time
                }
            );
        }

        public decimal getAttachmentTime()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttachmentTime" }
                }
            );
        }

        public void setToSetupPose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setToSetupPose" }
                }
            );
        }
        #endregion
    }
}