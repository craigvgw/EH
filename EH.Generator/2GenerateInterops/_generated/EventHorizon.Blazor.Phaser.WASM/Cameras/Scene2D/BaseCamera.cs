/// Generated - Do Not Edit
namespace Phaser.Cameras.Scene2D
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseCamera>))]
    public class BaseCamera : EventEmitter, IAlpha, IVisible
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
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }

        private SceneManager __sceneManager;
        public SceneManager sceneManager
        {
            get
            {
            if(__sceneManager == null)
            {
                __sceneManager = EventHorizonBlazorInterop.GetClass<SceneManager>(
                    this.___guid,
                    "sceneManager",
                    (entity) =>
                    {
                        return new SceneManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __sceneManager;
            }
            set
            {
__sceneManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sceneManager",
                    value
                );
            }
        }

        private ScaleManager __scaleManager;
        public ScaleManager scaleManager
        {
            get
            {
            if(__scaleManager == null)
            {
                __scaleManager = EventHorizonBlazorInterop.GetClass<ScaleManager>(
                    this.___guid,
                    "scaleManager",
                    (entity) =>
                    {
                        return new ScaleManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __scaleManager;
            }
            set
            {
__scaleManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleManager",
                    value
                );
            }
        }

        private CameraManager __cameraManager;
        public CameraManager cameraManager
        {
            get
            {
            if(__cameraManager == null)
            {
                __cameraManager = EventHorizonBlazorInterop.GetClass<CameraManager>(
                    this.___guid,
                    "cameraManager",
                    (entity) =>
                    {
                        return new CameraManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraManager;
            }
            set
            {
__cameraManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraManager",
                    value
                );
            }
        }

        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
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

        
        public bool roundPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "roundPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roundPixels",
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

        
        public bool useBounds
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBounds"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBounds",
                    value
                );
            }
        }

        private Rectangle __worldView;
        public Rectangle worldView
        {
            get
            {
            if(__worldView == null)
            {
                __worldView = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "worldView",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __worldView;
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

        
        public bool transparent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "transparent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transparent",
                    value
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
            set
            {
__backgroundColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backgroundColor",
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

        
        public bool disableCull
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableCull"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableCull",
                    value
                );
            }
        }

        private Vector2 __midPoint;
        public Vector2 midPoint
        {
            get
            {
            if(__midPoint == null)
            {
                __midPoint = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "midPoint",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __midPoint;
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

        
        public GameObject[] renderList
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<GameObject>(
                    this.___guid,
                    "renderList",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderList",
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

        
        public decimal scrollX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollX",
                    value
                );
            }
        }

        
        public decimal scrollY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollY",
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

        
        public decimal zoomX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoomX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomX",
                    value
                );
            }
        }

        
        public decimal zoomY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoomY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomY",
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
        #endregion
        
        #region Constructor
        public BaseCamera() : base() { }

        public BaseCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BaseCamera(
            decimal x, decimal y, decimal width, decimal height
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Cameras", "Scene2D", "BaseCamera" },
                x, y, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void addToRenderList(GameObject child)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addToRenderList" }, child
                }
            );
        }

        public BaseCamera setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public BaseCamera setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public Vector2 getScroll(decimal x, decimal y, Vector2 out = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScroll" }, x, y, out
                }
            );
        }

        public BaseCamera centerOnX(decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "centerOnX" }, x
                }
            );
        }

        public BaseCamera centerOnY(decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "centerOnY" }, y
                }
            );
        }

        public BaseCamera centerOn(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "centerOn" }, x, y
                }
            );
        }

        public BaseCamera centerToBounds()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "centerToBounds" }
                }
            );
        }

        public BaseCamera centerToSize()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "centerToSize" }
                }
            );
        }

        public G cull<G>(G renderableObjects) where G : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<G>(
                entity => new G() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cull" }, renderableObjects
                }
            );
        }

        public O getWorldPoint<O>(decimal x, decimal y, O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldPoint" }, x, y, output
                }
            );
        }

        public BaseCamera ignore(GameObject entries)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ignore" }, entries
                }
            );
        }

        public decimal clampX(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "clampX" }, x
                }
            );
        }

        public decimal clampY(decimal y)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "clampY" }, y
                }
            );
        }

        public BaseCamera removeBounds()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeBounds" }
                }
            );
        }

        public BaseCamera setAngle(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, value
                }
            );
        }

        public BaseCamera setBackgroundColor(string color = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBackgroundColor" }, color
                }
            );
        }

        public BaseCamera setBounds(decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> centerOn = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBounds" }, x, y, width, height, centerOn
                }
            );
        }

        public Rectangle getBounds(Rectangle out = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, out
                }
            );
        }

        public BaseCamera setName(string value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setName" }, value
                }
            );
        }

        public BaseCamera setPosition(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y
                }
            );
        }

        public BaseCamera setRotation(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, value
                }
            );
        }

        public BaseCamera setRoundPixels(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRoundPixels" }, value
                }
            );
        }

        public BaseCamera setScene(Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScene" }, scene
                }
            );
        }

        public BaseCamera setScroll(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScroll" }, x, y
                }
            );
        }

        public BaseCamera setSize(decimal width, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public BaseCamera setViewport(decimal x, decimal y, decimal width, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setViewport" }, x, y, width, height
                }
            );
        }

        public BaseCamera setZoom(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZoom" }, x, y
                }
            );
        }

        public BaseCamera setMask(BitmapMask mask, System.Nullable<bool> fixedPosition = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask, fixedPosition
                }
            );
        }

        public BaseCamera clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearMask" }, destroyMask
                }
            );
        }

        public BaseCamera setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }

        public JSONCamera toJSON()
        {
            return EventHorizonBlazorInterop.FuncClass<JSONCamera>(
                entity => new JSONCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
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

        public BaseCamera clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCamera>(
                entity => new BaseCamera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }
        #endregion
    }
}