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

    
    
    [JsonConverter(typeof(CachedEntityConverter<DOMElement>))]
    public class DOMElement : GameObject, IAlphaSingle, IBlendMode, IDepth, IOrigin, IScrollFactor, ITransform, IVisible
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
        private Element __parent;
        public Element parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<Element>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new Element() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
            }
            set
            {
__parent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        private BaseCache __cache;
        public BaseCache cache
        {
            get
            {
            if(__cache == null)
            {
                __cache = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "cache",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __cache;
            }
            set
            {
__cache = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cache",
                    value
                );
            }
        }

        private Element __node;
        public Element node
        {
            get
            {
            if(__node == null)
            {
                __node = EventHorizonBlazorInterop.GetClass<Element>(
                    this.___guid,
                    "node",
                    (entity) =>
                    {
                        return new Element() { ___guid = entity.___guid };
                    }
                );
            }
            return __node;
            }
            set
            {
__node = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "node",
                    value
                );
            }
        }

        
        public bool transformOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "transformOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transformOnly",
                    value
                );
            }
        }

        
        public decimal skewX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "skewX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skewX",
                    value
                );
            }
        }

        
        public decimal skewY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "skewY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skewY",
                    value
                );
            }
        }

        private Vector4 __rotate3d;
        public Vector4 rotate3d
        {
            get
            {
            if(__rotate3d == null)
            {
                __rotate3d = EventHorizonBlazorInterop.GetClass<Vector4>(
                    this.___guid,
                    "rotate3d",
                    (entity) =>
                    {
                        return new Vector4() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotate3d;
            }
            set
            {
__rotate3d = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotate3d",
                    value
                );
            }
        }

        
        public string rotate3dAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "rotate3dAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotate3dAngle",
                    value
                );
            }
        }

        
        public string pointerEvents
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pointerEvents"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerEvents",
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

        
        public decimal perspective
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "perspective"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "perspective",
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
        public DOMElement() : base() { }

        public DOMElement(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DOMElement(
            Scene scene, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, Element element = null, string style = null, string innerText = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "DOMElement" },
                scene, x, y, element, style, innerText
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public DOMElement setSkew(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSkew" }, x, y
                }
            );
        }

        public DOMElement setPerspective(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPerspective" }, value
                }
            );
        }

        public DOMElement addListener(string events)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addListener" }, events
                }
            );
        }

        public DOMElement removeListener(string events)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeListener" }, events
                }
            );
        }

        public DOMElement createElement(string tagName, string style = null, string innerText = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createElement" }, tagName, style, innerText
                }
            );
        }

        public DOMElement setElement(string element, string style = null, string innerText = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setElement" }, element, style, innerText
                }
            );
        }

        public DOMElement createFromCache(string The, string tagName = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFromCache" }, The, tagName
                }
            );
        }

        public DOMElement createFromHTML(string html, string tagName = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFromHTML" }, html, tagName
                }
            );
        }

        public DOMElement removeElement()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeElement" }
                }
            );
        }

        public DOMElement updateSize()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateSize" }
                }
            );
        }

        public Element getChildByProperty(string property, string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Element>(
                entity => new Element() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildByProperty" }, property, value
                }
            );
        }

        public Element getChildByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Element>(
                entity => new Element() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildByID" }, id
                }
            );
        }

        public Element getChildByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Element>(
                entity => new Element() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildByName" }, name
                }
            );
        }

        public DOMElement setClassName(string className)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setClassName" }, className
                }
            );
        }

        public DOMElement setText(string text)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setText" }, text
                }
            );
        }

        public DOMElement setHTML(string html)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHTML" }, html
                }
            );
        }

        public bool willRender()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "willRender" }
                }
            );
        }

        public DOMElement clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public DOMElement setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public DOMElement setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public DOMElement setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public DOMElement setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public DOMElement setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public DOMElement setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public DOMElement updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateDisplayOrigin" }
                }
            );
        }

        public DOMElement setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public DOMElement setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public DOMElement copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public DOMElement setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public DOMElement setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public DOMElement setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public DOMElement setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public DOMElement setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public DOMElement setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public DOMElement setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public DOMElement setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
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

        public DOMElement setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}