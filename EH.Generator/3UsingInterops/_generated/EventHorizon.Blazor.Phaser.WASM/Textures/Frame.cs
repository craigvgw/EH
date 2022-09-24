/// Generated - Do Not Edit
namespace Phaser.Textures
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Frame>))]
    public class Frame : CachedEntityObject
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
        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
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

        private TextureSource __source;
        public TextureSource source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<TextureSource>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new TextureSource() { ___guid = entity.___guid };
                    }
                );
            }
            return __source;
            }
            set
            {
__source = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }

        
        public decimal sourceIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sourceIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceIndex",
                    value
                );
            }
        }

        private WebGLTexture __glTexture;
        public WebGLTexture glTexture
        {
            get
            {
            if(__glTexture == null)
            {
                __glTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "glTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __glTexture;
            }
            set
            {
__glTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "glTexture",
                    value
                );
            }
        }

        
        public decimal cutX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cutX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cutX",
                    value
                );
            }
        }

        
        public decimal cutY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cutY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cutY",
                    value
                );
            }
        }

        
        public decimal cutWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cutWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cutWidth",
                    value
                );
            }
        }

        
        public decimal cutHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cutHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cutHeight",
                    value
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
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

        
        public decimal halfWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "halfWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "halfWidth",
                    value
                );
            }
        }

        
        public decimal halfHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "halfHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "halfHeight",
                    value
                );
            }
        }

        
        public decimal centerX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "centerX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "centerX",
                    value
                );
            }
        }

        
        public decimal centerY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "centerY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "centerY",
                    value
                );
            }
        }

        
        public decimal pivotX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pivotX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pivotX",
                    value
                );
            }
        }

        
        public decimal pivotY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pivotY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pivotY",
                    value
                );
            }
        }

        
        public bool customPivot
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "customPivot"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customPivot",
                    value
                );
            }
        }

        
        public bool rotated
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rotated"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotated",
                    value
                );
            }
        }

        
        public decimal autoRound
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "autoRound"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoRound",
                    value
                );
            }
        }

        
        public CachedEntity customData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "customData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customData",
                    value
                );
            }
        }

        
        public decimal u0
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "u0"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "u0",
                    value
                );
            }
        }

        
        public decimal v0
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "v0"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v0",
                    value
                );
            }
        }

        
        public decimal u1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "u1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "u1",
                    value
                );
            }
        }

        
        public decimal v1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "v1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v1",
                    value
                );
            }
        }

        
        public decimal realWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "realWidth"
                );
            }
        }

        
        public decimal realHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "realHeight"
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
        }

        
        public bool trimmed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "trimmed"
                );
            }
        }

        
        public CachedEntity canvasData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "canvasData"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Frame() : base() { }

        public Frame(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Frame(
            Texture texture, decimal name, decimal sourceIndex, decimal x, decimal y, decimal width, decimal height
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Textures", "Frame" },
                texture, name, sourceIndex, x, y, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Frame setSize(decimal width, decimal height, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, x, y
                }
            );
        }

        public Frame setTrim(decimal actualWidth, decimal actualHeight, decimal destX, decimal destY, decimal destWidth, decimal destHeight)
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTrim" }, actualWidth, actualHeight, destX, destY, destWidth, destHeight
                }
            );
        }

        public CachedEntity setCropUVs(object crop, decimal x, decimal y, decimal width, decimal height, bool flipX, bool flipY)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCropUVs" }, crop, x, y, width, height, flipX, flipY
                }
            );
        }

        public CachedEntity updateCropUVs(object crop, bool flipX, bool flipY)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCropUVs" }, crop, flipX, flipY
                }
            );
        }

        public Frame setUVs(decimal width, decimal height, decimal u0, decimal v0, decimal u1, decimal v1)
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUVs" }, width, height, u0, v0, u1, v1
                }
            );
        }

        public Frame updateUVs()
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateUVs" }
                }
            );
        }

        public Frame updateUVsInverted()
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateUVsInverted" }
                }
            );
        }

        public Frame clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}