/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpineContainer>))]
public class SpineContainer : Container
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
        
        public SpineGameObject[] list
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<SpineGameObject>(
                    this.___guid,
                    "list",
                    (entity) =>
                    {
                        return new SpineGameObject() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "list",
                    value
                );
            }
        }

        
        public bool exclusive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "exclusive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exclusive",
                    value
                );
            }
        }

        
        public decimal maxSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSize",
                    value
                );
            }
        }

        
        public decimal position
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "position"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private TransformMatrix __localTransform;
        public TransformMatrix localTransform
        {
            get
            {
            if(__localTransform == null)
            {
                __localTransform = EventHorizonBlazorInterop.GetClass<TransformMatrix>(
                    this.___guid,
                    "localTransform",
                    (entity) =>
                    {
                        return new TransformMatrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __localTransform;
            }
            set
            {
__localTransform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "localTransform",
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

        
        public decimal originX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originX"
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
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
        }

        private SpineGameObject __first;
        public SpineGameObject first
        {
            get
            {
            if(__first == null)
            {
                __first = EventHorizonBlazorInterop.GetClass<SpineGameObject>(
                    this.___guid,
                    "first",
                    (entity) =>
                    {
                        return new SpineGameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __first;
            }
        }

        private SpineGameObject __last;
        public SpineGameObject last
        {
            get
            {
            if(__last == null)
            {
                __last = EventHorizonBlazorInterop.GetClass<SpineGameObject>(
                    this.___guid,
                    "last",
                    (entity) =>
                    {
                        return new SpineGameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __last;
            }
        }

        private SpineGameObject __next;
        public SpineGameObject next
        {
            get
            {
            if(__next == null)
            {
                __next = EventHorizonBlazorInterop.GetClass<SpineGameObject>(
                    this.___guid,
                    "next",
                    (entity) =>
                    {
                        return new SpineGameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __next;
            }
        }

        private SpineGameObject __previous;
        public SpineGameObject previous
        {
            get
            {
            if(__previous == null)
            {
                __previous = EventHorizonBlazorInterop.GetClass<SpineGameObject>(
                    this.___guid,
                    "previous",
                    (entity) =>
                    {
                        return new SpineGameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __previous;
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
        public SpineContainer() : base() { }

        public SpineContainer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpineContainer(
            Scene scene, SpinePlugin pluginManager, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, SpineGameObject[] children = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SpineContainer" },
                scene, pluginManager, x, y, children
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public SpineContainer setExclusive(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setExclusive" }, value
                }
            );
        }

        public Rectangle getBounds(Rectangle output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, output
                }
            );
        }

        public CachedEntity pointToContainer(object source, object output = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pointToContainer" }, source, output
                }
            );
        }

        public TransformMatrix getBoundsTransformMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoundsTransformMatrix" }
                }
            );
        }

        public SpineContainer add(SpineGameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, child
                }
            );
        }

        public SpineContainer addAt(SpineGameObject child, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAt" }, child, index
                }
            );
        }

        public SpineGameObject getAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAt" }, index
                }
            );
        }

        public decimal getIndex(SpineGameObject child)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }, child
                }
            );
        }

        public SpineGameObject getByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getByName" }, name
                }
            );
        }

        public SpineGameObject getRandom(System.Nullable<decimal> startIndex = null, System.Nullable<decimal> length = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRandom" }, startIndex, length
                }
            );
        }

        public SpineGameObject getFirst(string property, object value, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFirst" }, property, value, startIndex, endIndex
                }
            );
        }

        public SpineGameObject[] getAll(string property = null, object value = null, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAll" }, property, value, startIndex, endIndex
                }
            );
        }

        public decimal count(string property, object value, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "count" }, property, value, startIndex, endIndex
                }
            );
        }

        public SpineContainer swap(SpineGameObject child1, SpineGameObject child2)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "swap" }, child1, child2
                }
            );
        }

        public SpineContainer moveTo(SpineGameObject child, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, child, index
                }
            );
        }

        public SpineContainer remove(SpineGameObject child, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, child, destroyChild
                }
            );
        }

        public SpineContainer removeAt(decimal index, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAt" }, index, destroyChild
                }
            );
        }

        public SpineContainer removeBetween(System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeBetween" }, startIndex, endIndex, destroyChild
                }
            );
        }

        public SpineContainer removeAll(System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAll" }, destroyChild
                }
            );
        }

        public SpineContainer bringToTop(SpineGameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bringToTop" }, child
                }
            );
        }

        public SpineContainer sendToBack(SpineGameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sendToBack" }, child
                }
            );
        }

        public SpineContainer moveUp(SpineGameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveUp" }, child
                }
            );
        }

        public SpineContainer moveDown(SpineGameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveDown" }, child
                }
            );
        }

        public SpineContainer reverse()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reverse" }
                }
            );
        }

        public SpineContainer shuffle()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shuffle" }
                }
            );
        }

        public SpineContainer replace(SpineGameObject oldChild, SpineGameObject newChild, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "replace" }, oldChild, newChild, destroyChild
                }
            );
        }

        public bool exists(SpineGameObject child)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "exists" }, child
                }
            );
        }

        public SpineContainer setAll(string property, object value, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAll" }, property, value, startIndex, endIndex
                }
            );
        }

        public SpineContainer setScrollFactor(decimal x, System.Nullable<decimal> y = null, System.Nullable<bool> updateChildren = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y, updateChildren
                }
            );
        }

        public SpineContainer clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public SpineContainer setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public SpineContainer setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public SpineContainer setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public SpineContainer setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }

        public SpineContainer setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public SpineContainer setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public SpineContainer clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
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

        public SpineContainer setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public SpineContainer setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public SpineContainer setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public SpineContainer setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public SpineContainer setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public SpineContainer setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public SpineContainer setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public SpineContainer setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public SpineContainer setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
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

        public decimal getParentRotation()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getParentRotation" }
                }
            );
        }

        public SpineContainer setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineContainer>(
                entity => new SpineContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }


    #endregion
}
