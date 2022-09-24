/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<DisplacementFilter>))]
public class DisplacementFilter : Filter
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private Texture __map;
        public Texture map
        {
            get
            {
            if(__map == null)
            {
                __map = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "map",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __map;
            }
            set
            {
__map = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "map",
                    value
                );
            }
        }
    #endregion

    #region Properties
        private ISpriteMaskTargetCachedEntity __maskSprite;
        public ISpriteMaskTargetCachedEntity maskSprite
        {
            get
            {
            if(__maskSprite == null)
            {
                __maskSprite = EventHorizonBlazorInterop.GetClass<ISpriteMaskTargetCachedEntity>(
                    this.___guid,
                    "maskSprite",
                    (entity) =>
                    {
                        return new ISpriteMaskTargetCachedEntity() { ___guid = entity.___guid };
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

        private Point __scale;
        public Point scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInterop.GetClass<Point>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new Point() { ___guid = entity.___guid };
                    }
                );
            }
            return __scale;
            }
            set
            {
__scale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public DisplacementFilter() : base() { }

        public DisplacementFilter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DisplacementFilter(
            ISpriteMaskTarget sprite, System.Nullable<decimal> scale = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "DisplacementFilter" },
                sprite, scale
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
