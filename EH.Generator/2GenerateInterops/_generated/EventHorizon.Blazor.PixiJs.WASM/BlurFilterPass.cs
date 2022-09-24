/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BlurFilterPass>))]
public class BlurFilterPass : Filter
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
    #endregion

    #region Properties
        
        public bool horizontal
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "horizontal"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "horizontal",
                    value
                );
            }
        }

        
        public decimal strength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "strength"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "strength",
                    value
                );
            }
        }

        
        public decimal passes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "passes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "passes",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BlurFilterPass() : base() { }

        public BlurFilterPass(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BlurFilterPass(
            bool horizontal, System.Nullable<decimal> strength = null, System.Nullable<decimal> quality = null, System.Nullable<decimal> resolution = null, System.Nullable<decimal> kernelSize = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BlurFilterPass" },
                horizontal, strength, quality, resolution, kernelSize
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
