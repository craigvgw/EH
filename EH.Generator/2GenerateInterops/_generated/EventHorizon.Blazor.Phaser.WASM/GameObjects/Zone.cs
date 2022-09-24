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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Zone>))]
    public class Zone : GameObject, IDepth, IGetBounds, IOrigin, ITransform, IScrollFactor, IVisible
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

        
        public decimal blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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
        public Zone() : base() { }

        public Zone(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Zone(
            Scene scene, decimal x, decimal y, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Zone" },
                scene, x, y, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Zone setSize(decimal width, decimal height, System.Nullable<bool> resizeInput = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, resizeInput
                }
            );
        }

        public Zone setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }

        public Zone setCircleDropZone(decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCircleDropZone" }, radius
                }
            );
        }

        public Zone setRectangleDropZone(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRectangleDropZone" }, width, height
                }
            );
        }

        public Zone setDropZone(object hitArea, HitAreaCallback hitAreaCallback)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDropZone" }, hitArea, hitAreaCallback
                }
            );
        }

        public Zone setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
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

        public Zone setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public Zone setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public Zone setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public Zone updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateDisplayOrigin" }
                }
            );
        }

        public Zone setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public Zone copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public Zone setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public Zone setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public Zone setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public Zone setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public Zone setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public Zone setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public Zone setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public Zone setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
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

        public Zone setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public Zone setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}