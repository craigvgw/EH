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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TextureSource>))]
    public class TextureSource : CachedEntityObject
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
        private CanvasRenderer __renderer;
        public CanvasRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<CanvasRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new CanvasRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderer;
            }
            set
            {
__renderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderer",
                    value
                );
            }
        }

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

        private HTMLImageElement __source;
        public HTMLImageElement source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<HTMLImageElement>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new HTMLImageElement() { ___guid = entity.___guid };
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

        private HTMLImageElement __image;
        public HTMLImageElement image
        {
            get
            {
            if(__image == null)
            {
                __image = EventHorizonBlazorInterop.GetClass<HTMLImageElement>(
                    this.___guid,
                    "image",
                    (entity) =>
                    {
                        return new HTMLImageElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __image;
            }
            set
            {
__image = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "image",
                    value
                );
            }
        }

        
        public decimal compressionAlgorithm
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "compressionAlgorithm"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "compressionAlgorithm",
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

        
        public decimal scaleMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleMode",
                    value
                );
            }
        }

        
        public bool isCanvas
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isCanvas"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isCanvas",
                    value
                );
            }
        }

        
        public bool isVideo
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVideo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isVideo",
                    value
                );
            }
        }

        
        public bool isRenderTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRenderTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRenderTexture",
                    value
                );
            }
        }

        
        public bool isGLTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isGLTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isGLTexture",
                    value
                );
            }
        }

        
        public bool isPowerOf2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPowerOf2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPowerOf2",
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

        
        public decimal glIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "glIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "glIndex",
                    value
                );
            }
        }

        
        public decimal glIndexCounter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "glIndexCounter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "glIndexCounter",
                    value
                );
            }
        }

        
        public bool flipY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipY",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextureSource() : base() { }

        public TextureSource(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TextureSource(
            Texture texture, HTMLImageElement source, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> flipY = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Textures", "TextureSource" },
                texture, source, width, height, flipY
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void init(Game game)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }, game
                }
            );
        }

        public void setFilter(int filterMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFilter" }, filterMode
                }
            );
        }

        public void setFlipY(System.Nullable<bool> value = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
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