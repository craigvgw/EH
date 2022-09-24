/// Generated - Do Not Edit
namespace Phaser.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Config>))]
    public class Config : CachedEntityObject
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
        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
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
        }

        private ZoomType __zoom;
        public ZoomType zoom
        {
            get
            {
            if(__zoom == null)
            {
                __zoom = EventHorizonBlazorInterop.GetClass<ZoomType>(
                    this.___guid,
                    "zoom",
                    (entity) =>
                    {
                        return new ZoomType() { ___guid = entity.___guid };
                    }
                );
            }
            return __zoom;
            }
        }

        
        public CachedEntity parent
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private ScaleModeType __scaleMode;
        public ScaleModeType scaleMode
        {
            get
            {
            if(__scaleMode == null)
            {
                __scaleMode = EventHorizonBlazorInterop.GetClass<ScaleModeType>(
                    this.___guid,
                    "scaleMode",
                    (entity) =>
                    {
                        return new ScaleModeType() { ___guid = entity.___guid };
                    }
                );
            }
            return __scaleMode;
            }
        }

        
        public bool expandParent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "expandParent"
                );
            }
        }

        
        public bool autoRound
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoRound"
                );
            }
        }

        private CenterType __autoCenter;
        public CenterType autoCenter
        {
            get
            {
            if(__autoCenter == null)
            {
                __autoCenter = EventHorizonBlazorInterop.GetClass<CenterType>(
                    this.___guid,
                    "autoCenter",
                    (entity) =>
                    {
                        return new CenterType() { ___guid = entity.___guid };
                    }
                );
            }
            return __autoCenter;
            }
        }

        
        public decimal resizeInterval
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resizeInterval"
                );
            }
        }

        
        public CachedEntity fullscreenTarget
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "fullscreenTarget"
                );
            }
        }

        
        public decimal minWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minWidth"
                );
            }
        }

        
        public decimal maxWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxWidth"
                );
            }
        }

        
        public decimal minHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minHeight"
                );
            }
        }

        
        public decimal maxHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxHeight"
                );
            }
        }

        
        public decimal renderType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderType"
                );
            }
        }

        private HTMLCanvasElement __canvas;
        public HTMLCanvasElement canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
        }

        private CanvasRenderingContext2D __context;
        public CanvasRenderingContext2D context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<CanvasRenderingContext2D>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new CanvasRenderingContext2D() { ___guid = entity.___guid };
                    }
                );
            }
            return __context;
            }
        }

        
        public string canvasStyle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "canvasStyle"
                );
            }
        }

        
        public bool customEnvironment
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "customEnvironment"
                );
            }
        }

        
        public CachedEntity sceneConfig
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "sceneConfig"
                );
            }
        }

        
        public string[] seed
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "seed"
                );
            }
        }

        
        public string gameTitle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "gameTitle"
                );
            }
        }

        
        public string gameURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "gameURL"
                );
            }
        }

        
        public string gameVersion
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "gameVersion"
                );
            }
        }

        
        public bool autoFocus
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoFocus"
                );
            }
        }

        
        public bool domCreateContainer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "domCreateContainer"
                );
            }
        }

        
        public bool domBehindCanvas
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "domBehindCanvas"
                );
            }
        }

        
        public string domPointerEvents
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "domPointerEvents"
                );
            }
        }

        
        public bool inputKeyboard
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputKeyboard"
                );
            }
        }

        
        public CachedEntity inputKeyboardEventTarget
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "inputKeyboardEventTarget",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public decimal[] inputKeyboardCapture
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "inputKeyboardCapture"
                );
            }
        }

        
        public bool inputMouse
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputMouse"
                );
            }
        }

        
        public CachedEntity inputMouseEventTarget
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "inputMouseEventTarget",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public bool inputMousePreventDefaultDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputMousePreventDefaultDown"
                );
            }
        }

        
        public bool inputMousePreventDefaultUp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputMousePreventDefaultUp"
                );
            }
        }

        
        public bool inputMousePreventDefaultMove
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputMousePreventDefaultMove"
                );
            }
        }

        
        public bool inputMousePreventDefaultWheel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputMousePreventDefaultWheel"
                );
            }
        }

        
        public bool inputTouch
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputTouch"
                );
            }
        }

        
        public CachedEntity inputTouchEventTarget
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "inputTouchEventTarget",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public bool inputTouchCapture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputTouchCapture"
                );
            }
        }

        
        public decimal inputActivePointers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inputActivePointers"
                );
            }
        }

        
        public decimal inputSmoothFactor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inputSmoothFactor"
                );
            }
        }

        
        public bool inputWindowEvents
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputWindowEvents"
                );
            }
        }

        
        public bool inputGamepad
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputGamepad"
                );
            }
        }

        
        public CachedEntity inputGamepadEventTarget
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "inputGamepadEventTarget",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public bool disableContextMenu
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableContextMenu"
                );
            }
        }

        private AudioConfig __audio;
        public AudioConfig audio
        {
            get
            {
            if(__audio == null)
            {
                __audio = EventHorizonBlazorInterop.GetClass<AudioConfig>(
                    this.___guid,
                    "audio",
                    (entity) =>
                    {
                        return new AudioConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __audio;
            }
        }

        
        public bool hideBanner
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hideBanner"
                );
            }
        }

        
        public bool hidePhaser
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hidePhaser"
                );
            }
        }

        
        public string bannerTextColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "bannerTextColor"
                );
            }
        }

        
        public string[] bannerBackgroundColor
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "bannerBackgroundColor"
                );
            }
        }

        private FPSConfig __fps;
        public FPSConfig fps
        {
            get
            {
            if(__fps == null)
            {
                __fps = EventHorizonBlazorInterop.GetClass<FPSConfig>(
                    this.___guid,
                    "fps",
                    (entity) =>
                    {
                        return new FPSConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __fps;
            }
        }

        private PipelineConfig __pipeline;
        public PipelineConfig pipeline
        {
            get
            {
            if(__pipeline == null)
            {
                __pipeline = EventHorizonBlazorInterop.GetClass<PipelineConfig>(
                    this.___guid,
                    "pipeline",
                    (entity) =>
                    {
                        return new PipelineConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __pipeline;
            }
        }

        
        public bool antialias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "antialias"
                );
            }
        }

        
        public bool antialiasGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "antialiasGL"
                );
            }
        }

        
        public string mipmapFilter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "mipmapFilter"
                );
            }
        }

        
        public bool desynchronized
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "desynchronized"
                );
            }
        }

        
        public bool roundPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "roundPixels"
                );
            }
        }

        
        public bool pixelArt
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pixelArt"
                );
            }
        }

        
        public bool transparent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "transparent"
                );
            }
        }

        
        public bool clearBeforeRender
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clearBeforeRender"
                );
            }
        }

        
        public bool preserveDrawingBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preserveDrawingBuffer"
                );
            }
        }

        
        public bool premultipliedAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "premultipliedAlpha"
                );
            }
        }

        
        public bool failIfMajorPerformanceCaveat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "failIfMajorPerformanceCaveat"
                );
            }
        }

        
        public string powerPreference
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "powerPreference"
                );
            }
        }

        
        public decimal batchSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "batchSize"
                );
            }
        }

        
        public decimal maxTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxTextures"
                );
            }
        }

        
        public decimal maxLights
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLights"
                );
            }
        }

        private Color __backgroundColor;
        public Color backgroundColor
        {
            get
            {
            if(__backgroundColor == null)
            {
                __backgroundColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "backgroundColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __backgroundColor;
            }
        }

        private BootCallback __preBoot;
        public BootCallback preBoot
        {
            get
            {
            if(__preBoot == null)
            {
                __preBoot = EventHorizonBlazorInterop.GetClass<BootCallback>(
                    this.___guid,
                    "preBoot",
                    (entity) =>
                    {
                        return new BootCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __preBoot;
            }
        }

        private BootCallback __postBoot;
        public BootCallback postBoot
        {
            get
            {
            if(__postBoot == null)
            {
                __postBoot = EventHorizonBlazorInterop.GetClass<BootCallback>(
                    this.___guid,
                    "postBoot",
                    (entity) =>
                    {
                        return new BootCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __postBoot;
            }
        }

        private PhysicsConfig __physics;
        public PhysicsConfig physics
        {
            get
            {
            if(__physics == null)
            {
                __physics = EventHorizonBlazorInterop.GetClass<PhysicsConfig>(
                    this.___guid,
                    "physics",
                    (entity) =>
                    {
                        return new PhysicsConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __physics;
            }
        }

        
        public bool defaultPhysicsSystem
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "defaultPhysicsSystem"
                );
            }
        }

        
        public string loaderBaseURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loaderBaseURL"
                );
            }
        }

        
        public string loaderPath
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loaderPath"
                );
            }
        }

        
        public decimal loaderMaxParallelDownloads
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loaderMaxParallelDownloads"
                );
            }
        }

        
        public string loaderCrossOrigin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loaderCrossOrigin"
                );
            }
        }

        
        public string loaderResponseType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loaderResponseType"
                );
            }
        }

        
        public bool loaderAsync
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loaderAsync"
                );
            }
        }

        
        public string loaderUser
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loaderUser"
                );
            }
        }

        
        public string loaderPassword
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loaderPassword"
                );
            }
        }

        
        public decimal loaderTimeout
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loaderTimeout"
                );
            }
        }

        
        public bool loaderWithCredentials
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loaderWithCredentials"
                );
            }
        }

        
        public CachedEntity installGlobalPlugins
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "installGlobalPlugins",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public CachedEntity installScenePlugins
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "installScenePlugins",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public CachedEntity defaultPlugins
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "defaultPlugins",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public string defaultImage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultImage"
                );
            }
        }

        
        public string missingImage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "missingImage"
                );
            }
        }

        
        public string whiteImage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "whiteImage"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Config() : base() { }

        public Config(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Config(
            GameConfig GameConfig = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Core", "Config" },
                GameConfig
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}