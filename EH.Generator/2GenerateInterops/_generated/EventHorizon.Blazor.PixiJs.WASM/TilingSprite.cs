/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TilingSprite>))]
public class TilingSprite : Sprite
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static TilingSprite from(string source, IBaseTextureOptions options)
        {
            return EventHorizonBlazorInterop.FuncClass<TilingSprite>(
                entity => new TilingSprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "TilingSprite", "from" }, source, options
                }
            );
        }
    #endregion

    #region Accessors
        
        public decimal clampMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clampMargin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clampMargin",
                    value
                );
            }
        }

        private ObservablePoint __tileScale;
        public ObservablePoint tileScale
        {
            get
            {
            if(__tileScale == null)
            {
                __tileScale = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "tileScale",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __tileScale;
            }
            set
            {
__tileScale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tileScale",
                    value
                );
            }
        }

        private ObservablePoint __tilePosition;
        public ObservablePoint tilePosition
        {
            get
            {
            if(__tilePosition == null)
            {
                __tilePosition = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "tilePosition",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __tilePosition;
            }
            set
            {
__tilePosition = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tilePosition",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }
    #endregion

    #region Properties
        private Transform __tileTransform;
        public Transform tileTransform
        {
            get
            {
            if(__tileTransform == null)
            {
                __tileTransform = EventHorizonBlazorInterop.GetClass<Transform>(
                    this.___guid,
                    "tileTransform",
                    (entity) =>
                    {
                        return new Transform() { ___guid = entity.___guid };
                    }
                );
            }
            return __tileTransform;
            }
            set
            {
__tileTransform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tileTransform",
                    value
                );
            }
        }

        private TextureMatrix __uvMatrix;
        public TextureMatrix uvMatrix
        {
            get
            {
            if(__uvMatrix == null)
            {
                __uvMatrix = EventHorizonBlazorInterop.GetClass<TextureMatrix>(
                    this.___guid,
                    "uvMatrix",
                    (entity) =>
                    {
                        return new TextureMatrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __uvMatrix;
            }
            set
            {
__uvMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvMatrix",
                    value
                );
            }
        }

        
        public bool uvRespectAnchor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "uvRespectAnchor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvRespectAnchor",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public TilingSprite() : base() { }

        public TilingSprite(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TilingSprite(
            Texture texture, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TilingSprite" },
                texture, width, height
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Rectangle getLocalBounds(Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalBounds" }, rect
                }
            );
        }

        public bool containsPoint(IPointData point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
                }
            );
        }

        public void destroy(IDestroyOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, options
                }
            );
        }
    #endregion
}
