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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Container>))]
    public class Container : GameObject, IAlphaSingle, IBlendMode, IComputedSize, IDepth, IMask, IPipeline, ITransform, IVisible
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
        
        public GameObject[] list
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<GameObject>(
                    this.___guid,
                    "list",
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

        private GameObject __first;
        public GameObject first
        {
            get
            {
            if(__first == null)
            {
                __first = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "first",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __first;
            }
        }

        private GameObject __last;
        public GameObject last
        {
            get
            {
            if(__last == null)
            {
                __last = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "last",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __last;
            }
        }

        private GameObject __next;
        public GameObject next
        {
            get
            {
            if(__next == null)
            {
                __next = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "next",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __next;
            }
        }

        private GameObject __previous;
        public GameObject previous
        {
            get
            {
            if(__previous == null)
            {
                __previous = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "previous",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
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
        public Container() : base() { }

        public Container(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Container(
            Scene scene, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, GameObject[] children = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Container" },
                scene, x, y, children
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Container setExclusive(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
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

        public Container add(GameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, child
                }
            );
        }

        public Container addAt(GameObject child, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAt" }, child, index
                }
            );
        }

        public GameObject getAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAt" }, index
                }
            );
        }

        public decimal getIndex(GameObject child)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }, child
                }
            );
        }

        public GameObject getByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getByName" }, name
                }
            );
        }

        public GameObject getRandom(System.Nullable<decimal> startIndex = null, System.Nullable<decimal> length = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRandom" }, startIndex, length
                }
            );
        }

        public GameObject getFirst(string property, object value, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFirst" }, property, value, startIndex, endIndex
                }
            );
        }

        public GameObject[] getAll(string property = null, object value = null, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
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

        public Container swap(GameObject child1, GameObject child2)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "swap" }, child1, child2
                }
            );
        }

        public Container moveTo(GameObject child, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, child, index
                }
            );
        }

        public Container moveAbove(GameObject child1, GameObject child2)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveAbove" }, child1, child2
                }
            );
        }

        public Container moveBelow(GameObject child1, GameObject child2)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveBelow" }, child1, child2
                }
            );
        }

        public Container remove(GameObject child, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, child, destroyChild
                }
            );
        }

        public Container removeAt(decimal index, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAt" }, index, destroyChild
                }
            );
        }

        public Container removeBetween(System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeBetween" }, startIndex, endIndex, destroyChild
                }
            );
        }

        public Container removeAll(System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAll" }, destroyChild
                }
            );
        }

        public Container bringToTop(GameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bringToTop" }, child
                }
            );
        }

        public Container sendToBack(GameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sendToBack" }, child
                }
            );
        }

        public Container moveUp(GameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveUp" }, child
                }
            );
        }

        public Container moveDown(GameObject child)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveDown" }, child
                }
            );
        }

        public Container reverse()
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reverse" }
                }
            );
        }

        public Container shuffle()
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shuffle" }
                }
            );
        }

        public Container replace(GameObject oldChild, GameObject newChild, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "replace" }, oldChild, newChild, destroyChild
                }
            );
        }

        public bool exists(GameObject child)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "exists" }, child
                }
            );
        }

        public Container setAll(string property, object value, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAll" }, property, value, startIndex, endIndex
                }
            );
        }

        public Container setScrollFactor(decimal x, System.Nullable<decimal> y = null, System.Nullable<bool> updateChildren = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y, updateChildren
                }
            );
        }

        public Container clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public Container setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public Container setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public Container setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public Container setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }

        public Container setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public Container setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public Container clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
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

        public bool initPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "initPipeline" }, pipeline
                }
            );
        }

        public Container setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public Container setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public Container setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
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

        public Container removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
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

        public Container setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public Container copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public Container setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public Container setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public Container setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public Container setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public Container setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public Container setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public Container setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public Container setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
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

        public Container setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }


        #endregion
    }
}