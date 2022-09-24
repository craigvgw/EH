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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SlotData>))]
    public class SlotData : CachedEntityObject
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
        
        public decimal index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
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

        private BoneData __boneData;
        public BoneData boneData
        {
            get
            {
            if(__boneData == null)
            {
                __boneData = EventHorizonBlazorInterop.GetClass<BoneData>(
                    this.___guid,
                    "boneData",
                    (entity) =>
                    {
                        return new BoneData() { ___guid = entity.___guid };
                    }
                );
            }
            return __boneData;
            }
            set
            {
__boneData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneData",
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

        
        public string attachmentName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "attachmentName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachmentName",
                    value
                );
            }
        }

        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SlotData() : base() { }

        public SlotData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SlotData(
            decimal index, string name, BoneData boneData
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "SlotData" },
                index, name, boneData
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}