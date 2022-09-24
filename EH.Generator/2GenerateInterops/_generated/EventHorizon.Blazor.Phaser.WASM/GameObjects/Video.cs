/// Generated - Do Not Edit
namespace Phaser.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Video>))]
    public class Video : GameObject, IAlpha, IBlendMode, IDepth, IFlip, IGetBounds, IMask, IOrigin, IPipeline, IScrollFactor, ISize, ITextureCrop, ITint, ITransform, IVisible
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
        private HTMLVideoElement __video;
        public HTMLVideoElement video
        {
            get
            {
            if(__video == null)
            {
                __video = EventHorizonBlazorInterop.GetClass<HTMLVideoElement>(
                    this.___guid,
                    "video",
                    (entity) =>
                    {
                        return new HTMLVideoElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __video;
            }
            set
            {
__video = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "video",
                    value
                );
            }
        }

        private Texture __videoTexture;
        public Texture videoTexture
        {
            get
            {
            if(__videoTexture == null)
            {
                __videoTexture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "videoTexture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __videoTexture;
            }
            set
            {
__videoTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "videoTexture",
                    value
                );
            }
        }

        private TextureSource __videoTextureSource;
        public TextureSource videoTextureSource
        {
            get
            {
            if(__videoTextureSource == null)
            {
                __videoTextureSource = EventHorizonBlazorInterop.GetClass<TextureSource>(
                    this.___guid,
                    "videoTextureSource",
                    (entity) =>
                    {
                        return new TextureSource() { ___guid = entity.___guid };
                    }
                );
            }
            return __videoTextureSource;
            }
            set
            {
__videoTextureSource = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "videoTextureSource",
                    value
                );
            }
        }

        private CanvasTexture __snapshotTexture;
        public CanvasTexture snapshotTexture
        {
            get
            {
            if(__snapshotTexture == null)
            {
                __snapshotTexture = EventHorizonBlazorInterop.GetClass<CanvasTexture>(
                    this.___guid,
                    "snapshotTexture",
                    (entity) =>
                    {
                        return new CanvasTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __snapshotTexture;
            }
            set
            {
__snapshotTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snapshotTexture",
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

        
        public bool touchLocked
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "touchLocked"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "touchLocked",
                    value
                );
            }
        }

        
        public bool playWhenUnlocked
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "playWhenUnlocked"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playWhenUnlocked",
                    value
                );
            }
        }

        
        public decimal retryLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "retryLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "retryLimit",
                    value
                );
            }
        }

        
        public decimal retry
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "retry"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "retry",
                    value
                );
            }
        }

        
        public decimal retryInterval
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "retryInterval"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "retryInterval",
                    value
                );
            }
        }

        
        public CachedEntity markers
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "markers",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "markers",
                    value
                );
            }
        }

        
        public bool removeVideoElementOnDestroy
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "removeVideoElementOnDestroy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "removeVideoElementOnDestroy",
                    value
                );
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public decimal alphaTopLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaTopLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaTopLeft",
                    value
                );
            }
        }

        
        public decimal alphaTopRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaTopRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaTopRight",
                    value
                );
            }
        }

        
        public decimal alphaBottomLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaBottomLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBottomLeft",
                    value
                );
            }
        }

        
        public decimal alphaBottomRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaBottomRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBottomRight",
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

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        
        public bool flipX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipX",
                    value
                );
            }
        }

        private BitmapMask __mask;
        public BitmapMask mask
        {
            get
            {
            if(__mask == null)
            {
                __mask = EventHorizonBlazorInterop.GetClass<BitmapMask>(
                    this.___guid,
                    "mask",
                    (entity) =>
                    {
                        return new BitmapMask() { ___guid = entity.___guid };
                    }
                );
            }
            return __mask;
            }
            set
            {
__mask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mask",
                    value
                );
            }
        }

        
        public decimal originX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originX",
                    value
                );
            }
        }

        
        public decimal originY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originY",
                    value
                );
            }
        }

        
        public decimal displayOriginX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginX",
                    value
                );
            }
        }

        
        public decimal displayOriginY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginY",
                    value
                );
            }
        }

        private WebGLPipeline __defaultPipeline;
        public WebGLPipeline defaultPipeline
        {
            get
            {
            if(__defaultPipeline == null)
            {
                __defaultPipeline = EventHorizonBlazorInterop.GetClass<WebGLPipeline>(
                    this.___guid,
                    "defaultPipeline",
                    (entity) =>
                    {
                        return new WebGLPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultPipeline;
            }
            set
            {
__defaultPipeline = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultPipeline",
                    value
                );
            }
        }

        private WebGLPipeline __pipeline;
        public WebGLPipeline pipeline
        {
            get
            {
            if(__pipeline == null)
            {
                __pipeline = EventHorizonBlazorInterop.GetClass<WebGLPipeline>(
                    this.___guid,
                    "pipeline",
                    (entity) =>
                    {
                        return new WebGLPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __pipeline;
            }
            set
            {
__pipeline = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pipeline",
                    value
                );
            }
        }

        
        public bool hasPostPipeline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPostPipeline"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasPostPipeline",
                    value
                );
            }
        }

        
        public PostFXPipeline[] postPipelines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<PostFXPipeline>(
                    this.___guid,
                    "postPipelines",
                    (entity) =>
                    {
                        return new PostFXPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postPipelines",
                    value
                );
            }
        }

        
        public CachedEntity pipelineData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "pipelineData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pipelineData",
                    value
                );
            }
        }

        
        public decimal scrollFactorX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorX",
                    value
                );
            }
        }

        
        public decimal scrollFactorY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorY",
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

        
        public decimal displayWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayWidth",
                    value
                );
            }
        }

        
        public decimal displayHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayHeight",
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

        private Frame __frame;
        public Frame frame
        {
            get
            {
            if(__frame == null)
            {
                __frame = EventHorizonBlazorInterop.GetClass<Frame>(
                    this.___guid,
                    "frame",
                    (entity) =>
                    {
                        return new Frame() { ___guid = entity.___guid };
                    }
                );
            }
            return __frame;
            }
            set
            {
__frame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public bool isCropped
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isCropped"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isCropped",
                    value
                );
            }
        }

        
        public decimal tintTopLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintTopLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintTopLeft",
                    value
                );
            }
        }

        
        public decimal tintTopRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintTopRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintTopRight",
                    value
                );
            }
        }

        
        public decimal tintBottomLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintBottomLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintBottomLeft",
                    value
                );
            }
        }

        
        public decimal tintBottomRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintBottomRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintBottomRight",
                    value
                );
            }
        }

        
        public bool tintFill
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "tintFill"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintFill",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        
        public bool isTinted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isTinted"
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

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
            }
        }

        
        public decimal w
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
                    value
                );
            }
        }

        
        public decimal scale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        
        public decimal scaleX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleX",
                    value
                );
            }
        }

        
        public decimal scaleY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleY",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Video() : base() { }

        public Video(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Video(
            Scene scene, decimal x, decimal y, string key = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Video" },
                scene, x, y, key
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Video play(System.Nullable<bool> loop = null, System.Nullable<decimal> markerIn = null, System.Nullable<decimal> markerOut = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }, loop, markerIn, markerOut
                }
            );
        }

        public Video changeSource(string key, System.Nullable<bool> autoplay = null, System.Nullable<bool> loop = null, System.Nullable<decimal> markerIn = null, System.Nullable<decimal> markerOut = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "changeSource" }, key, autoplay, loop, markerIn, markerOut
                }
            );
        }

        public Video addMarker(string key, decimal markerIn, decimal markerOut)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addMarker" }, key, markerIn, markerOut
                }
            );
        }

        public Video playMarker(string key, System.Nullable<bool> loop = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "playMarker" }, key, loop
                }
            );
        }

        public Video removeMarker(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeMarker" }, key
                }
            );
        }

        public CanvasTexture snapshot(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshot" }, width, height
                }
            );
        }

        public CanvasTexture snapshotArea(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> srcWidth = null, System.Nullable<decimal> srcHeight = null, System.Nullable<decimal> destWidth = null, System.Nullable<decimal> destHeight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotArea" }, x, y, srcWidth, srcHeight, destWidth, destHeight
                }
            );
        }

        public CanvasTexture saveSnapshotTexture(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saveSnapshotTexture" }, key
                }
            );
        }

        public Video loadURL(string url, string loadEvent = null, System.Nullable<bool> noAudio = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadURL" }, url, loadEvent, noAudio
                }
            );
        }

        public Video loadMediaStream(string stream, string loadEvent = null, System.Nullable<bool> noAudio = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadMediaStream" }, stream, loadEvent, noAudio
                }
            );
        }

        public void playHandler()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "playHandler" }
                }
            );
        }

        public void completeHandler()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "completeHandler" }
                }
            );
        }

        public void timeUpdateHandler()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "timeUpdateHandler" }
                }
            );
        }

        public void updateTexture()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTexture" }
                }
            );
        }

        public string getVideoKey()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getVideoKey" }
                }
            );
        }

        public Video seekTo(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "seekTo" }, value
                }
            );
        }

        public decimal getCurrentTime()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCurrentTime" }
                }
            );
        }

        public Video setCurrentTime(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCurrentTime" }, value
                }
            );
        }

        public bool isSeeking()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isSeeking" }
                }
            );
        }

        public decimal getProgress()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getProgress" }
                }
            );
        }

        public decimal getDuration()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDuration" }
                }
            );
        }

        public Video setMute(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMute" }, value
                }
            );
        }

        public bool isMuted()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isMuted" }
                }
            );
        }

        public Video setPaused(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPaused" }, value
                }
            );
        }

        public decimal getVolume()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVolume" }
                }
            );
        }

        public Video setVolume(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVolume" }, value
                }
            );
        }

        public decimal getPlaybackRate()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPlaybackRate" }
                }
            );
        }

        public Video setPlaybackRate(System.Nullable<decimal> rate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPlaybackRate" }, rate
                }
            );
        }

        public bool getLoop()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "getLoop" }
                }
            );
        }

        public Video setLoop(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLoop" }, value
                }
            );
        }

        public bool isPlaying()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPlaying" }
                }
            );
        }

        public bool isPaused()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPaused" }
                }
            );
        }

        public Texture saveTexture(string key, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saveTexture" }, key, flipY
                }
            );
        }

        public Video stop()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public void removeVideoElement()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeVideoElement" }
                }
            );
        }

        public Video clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public Video setAlpha(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public Video setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public Video setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public Video toggleFlipX()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipX" }
                }
            );
        }

        public Video toggleFlipY()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipY" }
                }
            );
        }

        public Video setFlipX(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipX" }, value
                }
            );
        }

        public Video setFlipY(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public Video setFlip(bool x, bool y)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlip" }, x, y
                }
            );
        }

        public Video resetFlip()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFlip" }
                }
            );
        }

        public O getCenter<O>(O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCenter" }, output
                }
            );
        }

        public O getTopLeft<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopLeft" }, output, includeParent
                }
            );
        }

        public O getTopCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopCenter" }, output, includeParent
                }
            );
        }

        public O getTopRight<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopRight" }, output, includeParent
                }
            );
        }

        public O getLeftCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLeftCenter" }, output, includeParent
                }
            );
        }

        public O getRightCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRightCenter" }, output, includeParent
                }
            );
        }

        public O getBottomLeft<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomLeft" }, output, includeParent
                }
            );
        }

        public O getBottomCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomCenter" }, output, includeParent
                }
            );
        }

        public O getBottomRight<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomRight" }, output, includeParent
                }
            );
        }

        public O getBounds<O>(O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, output
                }
            );
        }

        public Video setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public Video clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearMask" }, destroyMask
                }
            );
        }

        public BitmapMask createBitmapMask(GameObject renderable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapMask>(
                entity => new BitmapMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBitmapMask" }, renderable
                }
            );
        }

        public GeometryMask createGeometryMask(Graphics graphics = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GeometryMask>(
                entity => new GeometryMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createGeometryMask" }, graphics
                }
            );
        }

        public Video setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public Video setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public Video setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public Video updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateDisplayOrigin" }
                }
            );
        }

        public bool initPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "initPipeline" }, pipeline
                }
            );
        }

        public Video setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public Video setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public Video setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipelineData" }, key, value
                }
            );
        }

        public PostFXPipeline getPostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<PostFXPipeline>(
                entity => new PostFXPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPostPipeline" }, pipeline
                }
            );
        }

        public bool resetPipeline(System.Nullable<bool> resetPostPipelines = null, System.Nullable<bool> resetData = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "resetPipeline" }, resetPostPipelines, resetData
                }
            );
        }

        public void resetPostPipeline(System.Nullable<bool> resetData = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetPostPipeline" }, resetData
                }
            );
        }

        public Video removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removePostPipeline" }, pipeline
                }
            );
        }

        public string getPipelineName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getPipelineName" }
                }
            );
        }

        public Video setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public Video setSizeToFrame(Frame frame)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSizeToFrame" }, frame
                }
            );
        }

        public Video setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public Video setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }

        public Video setCrop(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCrop" }, x, y, width, height
                }
            );
        }

        public Video setTexture(string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, key, frame
                }
            );
        }

        public Video setFrame(string frame, System.Nullable<bool> updateSize = null, System.Nullable<bool> updateOrigin = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frame, updateSize, updateOrigin
                }
            );
        }

        public Video clearTint()
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearTint" }
                }
            );
        }

        public Video setTint(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTint" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public Video setTintFill(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTintFill" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public Video setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public Video copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public Video setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public Video setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public Video setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public Video setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public Video setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public Video setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public Video setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public Video setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setW" }, value
                }
            );
        }

        public TransformMatrix getLocalTransformMatrix(TransformMatrix tempMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalTransformMatrix" }, tempMatrix
                }
            );
        }

        public TransformMatrix getWorldTransformMatrix(TransformMatrix tempMatrix = null, TransformMatrix parentMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldTransformMatrix" }, tempMatrix, parentMatrix
                }
            );
        }

        public Vector2 getLocalPoint(decimal x, decimal y, Vector2 point = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalPoint" }, x, y, point, camera
                }
            );
        }

        public decimal getParentRotation()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getParentRotation" }
                }
            );
        }

        public Video setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}