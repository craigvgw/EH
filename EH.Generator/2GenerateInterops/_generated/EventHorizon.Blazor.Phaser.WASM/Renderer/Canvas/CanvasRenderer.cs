/// Generated - Do Not Edit
namespace Phaser.Renderer.Canvas
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasRenderer>))]
    public class CanvasRenderer : EventEmitter
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
        
        public CachedEntity config
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "config"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "config",
                    value
                );
            }
        }

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
            set
            {
__game = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "game",
                    value
                );
            }
        }

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal drawCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "drawCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawCount",
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

        private HTMLCanvasElement __gameCanvas;
        public HTMLCanvasElement gameCanvas
        {
            get
            {
            if(__gameCanvas == null)
            {
                __gameCanvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "gameCanvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __gameCanvas;
            }
            set
            {
__gameCanvas = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gameCanvas",
                    value
                );
            }
        }

        private CanvasRenderingContext2D __gameContext;
        public CanvasRenderingContext2D gameContext
        {
            get
            {
            if(__gameContext == null)
            {
                __gameContext = EventHorizonBlazorInterop.GetClass<CanvasRenderingContext2D>(
                    this.___guid,
                    "gameContext",
                    (entity) =>
                    {
                        return new CanvasRenderingContext2D() { ___guid = entity.___guid };
                    }
                );
            }
            return __gameContext;
            }
            set
            {
__gameContext = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gameContext",
                    value
                );
            }
        }

        private CanvasRenderingContext2D __currentContext;
        public CanvasRenderingContext2D currentContext
        {
            get
            {
            if(__currentContext == null)
            {
                __currentContext = EventHorizonBlazorInterop.GetClass<CanvasRenderingContext2D>(
                    this.___guid,
                    "currentContext",
                    (entity) =>
                    {
                        return new CanvasRenderingContext2D() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentContext;
            }
            set
            {
__currentContext = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentContext",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "antialias",
                    value
                );
            }
        }

        
        public CachedEntity[] blendModes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "blendModes",
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
                    "blendModes",
                    value
                );
            }
        }

        private SnapshotState __snapshotState;
        public SnapshotState snapshotState
        {
            get
            {
            if(__snapshotState == null)
            {
                __snapshotState = EventHorizonBlazorInterop.GetClass<SnapshotState>(
                    this.___guid,
                    "snapshotState",
                    (entity) =>
                    {
                        return new SnapshotState() { ___guid = entity.___guid };
                    }
                );
            }
            return __snapshotState;
            }
            set
            {
__snapshotState = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snapshotState",
                    value
                );
            }
        }

        
        public bool isBooted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBooted"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBooted",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasRenderer() : base() { }

        public CanvasRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CanvasRenderer(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "Canvas", "CanvasRenderer" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void init()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }
                }
            );
        }

        public void onResize(Size gameSize, Size baseSize)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onResize" }, gameSize, baseSize
                }
            );
        }

        public void resize(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }

        public void resetTransform()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetTransform" }
                }
            );
        }

        public CanvasRenderer setBlendMode(string blendMode)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderer>(
                entity => new CanvasRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, blendMode
                }
            );
        }

        public CanvasRenderer setContext(CanvasRenderingContext2D ctx = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderer>(
                entity => new CanvasRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setContext" }, ctx
                }
            );
        }

        public CanvasRenderer setAlpha(decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderer>(
                entity => new CanvasRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, alpha
                }
            );
        }

        public void preRender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRender" }
                }
            );
        }

        public void render(Scene scene, GameObject[] children, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, scene, children, camera
                }
            );
        }

        public void postRender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postRender" }
                }
            );
        }

        public CanvasRenderer snapshotCanvas(HTMLCanvasElement canvas, SnapshotCallback callback, System.Nullable<bool> getPixel = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string type = null, System.Nullable<decimal> encoderOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderer>(
                entity => new CanvasRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotCanvas" }, canvas, callback, getPixel, x, y, width, height, type, encoderOptions
                }
            );
        }

        public CanvasRenderer snapshot(SnapshotCallback callback, string type = null, System.Nullable<decimal> encoderOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderer>(
                entity => new CanvasRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshot" }, callback, type, encoderOptions
                }
            );
        }

        public CanvasRenderer snapshotArea(decimal x, decimal y, decimal width, decimal height, SnapshotCallback callback, string type = null, System.Nullable<decimal> encoderOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderer>(
                entity => new CanvasRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotArea" }, x, y, width, height, callback, type, encoderOptions
                }
            );
        }

        public CanvasRenderer snapshotPixel(decimal x, decimal y, SnapshotCallback callback)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderer>(
                entity => new CanvasRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotPixel" }, x, y, callback
                }
            );
        }

        public void batchSprite(GameObject sprite, Frame frame, Camera camera, TransformMatrix parentTransformMatrix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "batchSprite" }, sprite, frame, camera, parentTransformMatrix
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