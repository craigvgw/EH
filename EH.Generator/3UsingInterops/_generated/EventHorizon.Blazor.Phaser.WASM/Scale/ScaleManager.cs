/// Generated - Do Not Edit
namespace Phaser.Scale
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ScaleManager>))]
    public class ScaleManager : EventEmitter
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
        private Game __game;
        public Game game
        {
            get
            {
            if(__game == null)
            {
                __game = EventHorizonBlazorInterop.GetClass<Game>(
                    this.___guid,
                    "game",
                    (entity) =>
                    {
                        return new Game() { ___guid = entity.___guid };
                    }
                );
            }
            return __game;
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
            set
            {
__canvas = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvas",
                    value
                );
            }
        }

        private Rectangle __canvasBounds;
        public Rectangle canvasBounds
        {
            get
            {
            if(__canvasBounds == null)
            {
                __canvasBounds = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "canvasBounds",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvasBounds;
            }
            set
            {
__canvasBounds = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvasBounds",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        
        public bool parentIsWindow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "parentIsWindow"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentIsWindow",
                    value
                );
            }
        }

        private Size __parentSize;
        public Size parentSize
        {
            get
            {
            if(__parentSize == null)
            {
                __parentSize = EventHorizonBlazorInterop.GetClass<Size>(
                    this.___guid,
                    "parentSize",
                    (entity) =>
                    {
                        return new Size() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentSize;
            }
            set
            {
__parentSize = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentSize",
                    value
                );
            }
        }

        private Size __gameSize;
        public Size gameSize
        {
            get
            {
            if(__gameSize == null)
            {
                __gameSize = EventHorizonBlazorInterop.GetClass<Size>(
                    this.___guid,
                    "gameSize",
                    (entity) =>
                    {
                        return new Size() { ___guid = entity.___guid };
                    }
                );
            }
            return __gameSize;
            }
            set
            {
__gameSize = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gameSize",
                    value
                );
            }
        }

        private Size __baseSize;
        public Size baseSize
        {
            get
            {
            if(__baseSize == null)
            {
                __baseSize = EventHorizonBlazorInterop.GetClass<Size>(
                    this.___guid,
                    "baseSize",
                    (entity) =>
                    {
                        return new Size() { ___guid = entity.___guid };
                    }
                );
            }
            return __baseSize;
            }
            set
            {
__baseSize = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseSize",
                    value
                );
            }
        }

        private Size __displaySize;
        public Size displaySize
        {
            get
            {
            if(__displaySize == null)
            {
                __displaySize = EventHorizonBlazorInterop.GetClass<Size>(
                    this.___guid,
                    "displaySize",
                    (entity) =>
                    {
                        return new Size() { ___guid = entity.___guid };
                    }
                );
            }
            return __displaySize;
            }
            set
            {
__displaySize = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displaySize",
                    value
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
            set
            {
__scaleMode = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleMode",
                    value
                );
            }
        }

        
        public decimal zoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoom",
                    value
                );
            }
        }

        private Vector2 __displayScale;
        public Vector2 displayScale
        {
            get
            {
            if(__displayScale == null)
            {
                __displayScale = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "displayScale",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __displayScale;
            }
            set
            {
__displayScale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayScale",
                    value
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoRound",
                    value
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
            set
            {
__autoCenter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoCenter",
                    value
                );
            }
        }

        private OrientationType __orientation;
        public OrientationType orientation
        {
            get
            {
            if(__orientation == null)
            {
                __orientation = EventHorizonBlazorInterop.GetClass<OrientationType>(
                    this.___guid,
                    "orientation",
                    (entity) =>
                    {
                        return new OrientationType() { ___guid = entity.___guid };
                    }
                );
            }
            return __orientation;
            }
            set
            {
__orientation = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orientation",
                    value
                );
            }
        }

        private Fullscreen __fullscreen;
        public Fullscreen fullscreen
        {
            get
            {
            if(__fullscreen == null)
            {
                __fullscreen = EventHorizonBlazorInterop.GetClass<Fullscreen>(
                    this.___guid,
                    "fullscreen",
                    (entity) =>
                    {
                        return new Fullscreen() { ___guid = entity.___guid };
                    }
                );
            }
            return __fullscreen;
            }
            set
            {
__fullscreen = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fullscreen",
                    value
                );
            }
        }

        
        public CachedEntity fullscreenTarget
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "fullscreenTarget",
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
                    "fullscreenTarget",
                    value
                );
            }
        }

        
        public bool dirty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dirty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirty",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resizeInterval",
                    value
                );
            }
        }

        
        public bool isFullscreen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFullscreen"
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

        
        public bool isPortrait
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPortrait"
                );
            }
        }

        
        public bool isLandscape
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLandscape"
                );
            }
        }

        
        public bool isGamePortrait
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isGamePortrait"
                );
            }
        }

        
        public bool isGameLandscape
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isGameLandscape"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ScaleManager() : base() { }

        public ScaleManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ScaleManager(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Scale", "ScaleManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void getParent(GameConfig config)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getParent" }, config
                }
            );
        }

        public bool getParentBounds()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "getParentBounds" }
                }
            );
        }

        public bool lockOrientation(string orientation)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "lockOrientation" }, orientation
                }
            );
        }

        public ScaleManager setParentSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<ScaleManager>(
                entity => new ScaleManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setParentSize" }, width, height
                }
            );
        }

        public ScaleManager setGameSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<ScaleManager>(
                entity => new ScaleManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGameSize" }, width, height
                }
            );
        }

        public ScaleManager resize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<ScaleManager>(
                entity => new ScaleManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }

        public ScaleManager setZoom(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<ScaleManager>(
                entity => new ScaleManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZoom" }, value
                }
            );
        }

        public ScaleManager setMaxZoom()
        {
            return EventHorizonBlazorInterop.FuncClass<ScaleManager>(
                entity => new ScaleManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaxZoom" }
                }
            );
        }

        public ScaleManager refresh(System.Nullable<decimal> previousWidth = null, System.Nullable<decimal> previousHeight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ScaleManager>(
                entity => new ScaleManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refresh" }, previousWidth, previousHeight
                }
            );
        }

        public void updateOrientation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateOrientation" }
                }
            );
        }

        public void updateScale()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateScale" }
                }
            );
        }

        public decimal getMaxZoom()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxZoom" }
                }
            );
        }

        public void updateCenter()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCenter" }
                }
            );
        }

        public void updateBounds()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateBounds" }
                }
            );
        }

        public decimal transformX(decimal pageX)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "transformX" }, pageX
                }
            );
        }

        public decimal transformY(decimal pageY)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "transformY" }, pageY
                }
            );
        }

        public void startFullscreen(object fullscreenOptions = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startFullscreen" }, fullscreenOptions
                }
            );
        }

        public CachedEntity getFullscreenTarget()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFullscreenTarget" }
                }
            );
        }

        public void removeFullscreenTarget()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeFullscreenTarget" }
                }
            );
        }

        public void stopFullscreen()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopFullscreen" }
                }
            );
        }

        public void toggleFullscreen(object fullscreenOptions = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toggleFullscreen" }, fullscreenOptions
                }
            );
        }

        public void startListeners()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startListeners" }
                }
            );
        }

        public void onFullScreenError()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onFullScreenError" }
                }
            );
        }

        public void step(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "step" }, time, delta
                }
            );
        }

        public void stopListeners()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopListeners" }
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