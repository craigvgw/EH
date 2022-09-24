/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BlurFilter>))]
public class BlurFilter : Filter
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal blur
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blur"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blur",
                    value
                );
            }
        }

        
        public decimal quality
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "quality"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "quality",
                    value
                );
            }
        }

        
        public decimal blurX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurX",
                    value
                );
            }
        }

        
        public decimal blurY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurY",
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

        
        public bool repeatEdgePixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "repeatEdgePixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeatEdgePixels",
                    value
                );
            }
        }
    #endregion

    #region Properties
        private BlurFilterPass __blurXFilter;
        public BlurFilterPass blurXFilter
        {
            get
            {
            if(__blurXFilter == null)
            {
                __blurXFilter = EventHorizonBlazorInterop.GetClass<BlurFilterPass>(
                    this.___guid,
                    "blurXFilter",
                    (entity) =>
                    {
                        return new BlurFilterPass() { ___guid = entity.___guid };
                    }
                );
            }
            return __blurXFilter;
            }
            set
            {
__blurXFilter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurXFilter",
                    value
                );
            }
        }

        private BlurFilterPass __blurYFilter;
        public BlurFilterPass blurYFilter
        {
            get
            {
            if(__blurYFilter == null)
            {
                __blurYFilter = EventHorizonBlazorInterop.GetClass<BlurFilterPass>(
                    this.___guid,
                    "blurYFilter",
                    (entity) =>
                    {
                        return new BlurFilterPass() { ___guid = entity.___guid };
                    }
                );
            }
            return __blurYFilter;
            }
            set
            {
__blurYFilter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurYFilter",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BlurFilter() : base() { }

        public BlurFilter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BlurFilter(
            System.Nullable<decimal> strength = null, System.Nullable<decimal> quality = null, System.Nullable<decimal> resolution = null, System.Nullable<decimal> kernelSize = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BlurFilter" },
                strength, quality, resolution, kernelSize
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void apply(FilterSystem filterManager, RenderTexture input, RenderTexture output, int clearMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "apply" }, filterManager, input, output, clearMode
                }
            );
        }
    #endregion
}
