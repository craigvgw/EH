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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ClippingAttachment>))]
    public class ClippingAttachment : VertexAttachment
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
        private SlotData __endSlot;
        public SlotData endSlot
        {
            get
            {
            if(__endSlot == null)
            {
                __endSlot = EventHorizonBlazorInterop.GetClass<SlotData>(
                    this.___guid,
                    "endSlot",
                    (entity) =>
                    {
                        return new SlotData() { ___guid = entity.___guid };
                    }
                );
            }
            return __endSlot;
            }
            set
            {
__endSlot = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "endSlot",
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
        #endregion
        
        #region Constructor
        public ClippingAttachment() : base() { }

        public ClippingAttachment(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ClippingAttachment(
            string name
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "ClippingAttachment" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Attachment copy()
        {
            return EventHorizonBlazorInterop.FuncClass<Attachment>(
                entity => new Attachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }
                }
            );
        }
        #endregion
    }
}