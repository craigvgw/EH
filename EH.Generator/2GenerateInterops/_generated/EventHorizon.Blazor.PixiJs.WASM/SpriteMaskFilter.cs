/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpriteMaskFilter>))]
public class SpriteMaskFilter : Filter
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private IMaskTargetCachedEntity __maskSprite;
        public IMaskTargetCachedEntity maskSprite
        {
            get
            {
            if(__maskSprite == null)
            {
                __maskSprite = EventHorizonBlazorInterop.GetClass<IMaskTargetCachedEntity>(
                    this.___guid,
                    "maskSprite",
                    (entity) =>
                    {
                        return new IMaskTargetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __maskSprite;
            }
            set
            {
__maskSprite = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskSprite",
                    value
                );
            }
        }
    #endregion

    #region Properties
        private Matrix __maskMatrix;
        public Matrix maskMatrix
        {
            get
            {
            if(__maskMatrix == null)
            {
                __maskMatrix = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "maskMatrix",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __maskMatrix;
            }
            set
            {
__maskMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskMatrix",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SpriteMaskFilter() : base() { }

        public SpriteMaskFilter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpriteMaskFilter(
            IMaskTarget sprite
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SpriteMaskFilter" },
                sprite
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
