/// Generated - Do Not Edit
namespace Phaser.GameObjects.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface ITransform : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ITransformCachedEntity>))]
    public class ITransformCachedEntity : CachedEntityObject, ITransform
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
        #endregion
        
        #region Constructor
        public ITransformCachedEntity() : base() { }

        public ITransformCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ITransformCachedEntity setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public ITransformCachedEntity copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public ITransformCachedEntity setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public ITransformCachedEntity setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public ITransformCachedEntity setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public ITransformCachedEntity setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public ITransformCachedEntity setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public ITransformCachedEntity setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public ITransformCachedEntity setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public ITransformCachedEntity setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITransformCachedEntity>(
                entity => new ITransformCachedEntity() { ___guid = entity.___guid },
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
        #endregion
    }
}