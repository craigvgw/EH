/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MaskData>))]
public class MaskData : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private ISpriteMaskFilter_2 __filter;
        public ISpriteMaskFilter_2 filter
        {
            get
            {
            if(__filter == null)
            {
                __filter = EventHorizonBlazorInterop.GetClass<ISpriteMaskFilter_2>(
                    this.___guid,
                    "filter",
                    (entity) =>
                    {
                        return new ISpriteMaskFilter_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __filter;
            }
            set
            {
__filter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filter",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
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

        
        public bool autoDetect
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoDetect"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoDetect",
                    value
                );
            }
        }

        private IMaskTargetCachedEntity __maskObject;
        public IMaskTargetCachedEntity maskObject
        {
            get
            {
            if(__maskObject == null)
            {
                __maskObject = EventHorizonBlazorInterop.GetClass<IMaskTargetCachedEntity>(
                    this.___guid,
                    "maskObject",
                    (entity) =>
                    {
                        return new IMaskTargetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __maskObject;
            }
            set
            {
__maskObject = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskObject",
                    value
                );
            }
        }

        
        public bool pooled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pooled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pooled",
                    value
                );
            }
        }

        
        public bool isMaskData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMaskData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isMaskData",
                    value
                );
            }
        }

        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolution",
                    value
                );
            }
        }

        
        public int multisample
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "multisample"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multisample",
                    value
                );
            }
        }

        
        public bool enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enabled",
                    value
                );
            }
        }

        
        public int colorMask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "colorMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorMask",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MaskData() : base() { }

        public MaskData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public MaskData(
            IMaskTarget maskObject = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MaskData" },
                maskObject
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public void copyCountersOrReset(MaskData maskAbove = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyCountersOrReset" }, maskAbove
                }
            );
        }
    #endregion
}
