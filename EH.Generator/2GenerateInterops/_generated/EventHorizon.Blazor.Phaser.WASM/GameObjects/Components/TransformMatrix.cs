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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TransformMatrix>))]
    public class TransformMatrix : CachedEntityObject
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
        
        public decimal[] matrix
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matrix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }

        
        public CachedEntity decomposedMatrix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "decomposedMatrix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "decomposedMatrix",
                    value
                );
            }
        }

        
        public decimal a
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "a"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "a",
                    value
                );
            }
        }

        
        public decimal b
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }

        
        public decimal c
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "c"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "c",
                    value
                );
            }
        }

        
        public decimal d
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "d"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "d",
                    value
                );
            }
        }

        
        public decimal e
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "e"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "e",
                    value
                );
            }
        }

        
        public decimal f
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "f"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "f",
                    value
                );
            }
        }

        
        public decimal tx
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tx"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tx",
                    value
                );
            }
        }

        
        public decimal ty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ty",
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
        }

        
        public decimal rotationNormalized
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotationNormalized"
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
        }
        #endregion
        
        #region Constructor
        public TransformMatrix() : base() { }

        public TransformMatrix(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TransformMatrix(
            System.Nullable<decimal> a = null, System.Nullable<decimal> b = null, System.Nullable<decimal> c = null, System.Nullable<decimal> d = null, System.Nullable<decimal> tx = null, System.Nullable<decimal> ty = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Components", "TransformMatrix" },
                a, b, c, d, tx, ty
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public TransformMatrix loadIdentity()
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadIdentity" }
                }
            );
        }

        public TransformMatrix translate(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, x, y
                }
            );
        }

        public TransformMatrix scale(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, x, y
                }
            );
        }

        public TransformMatrix rotate(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, angle
                }
            );
        }

        public TransformMatrix multiply(TransformMatrix rhs, TransformMatrix out = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, rhs, out
                }
            );
        }

        public TransformMatrix multiplyWithOffset(TransformMatrix src, decimal offsetX, decimal offsetY)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyWithOffset" }, src, offsetX, offsetY
                }
            );
        }

        public TransformMatrix transform(decimal a, decimal b, decimal c, decimal d, decimal tx, decimal ty)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transform" }, a, b, c, d, tx, ty
                }
            );
        }

        public Point transformPoint(decimal x, decimal y, Point point)
        {
            return EventHorizonBlazorInterop.FuncClass<Point>(
                entity => new Point() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformPoint" }, x, y, point
                }
            );
        }

        public TransformMatrix invert()
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "invert" }
                }
            );
        }

        public TransformMatrix copyFrom(TransformMatrix src)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, src
                }
            );
        }

        public TransformMatrix copyFromArray(CachedEntity[] src)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFromArray" }, src
                }
            );
        }

        public CanvasRenderingContext2D copyToContext(CanvasRenderingContext2D ctx)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderingContext2D>(
                entity => new CanvasRenderingContext2D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyToContext" }, ctx
                }
            );
        }

        public CanvasRenderingContext2D setToContext(CanvasRenderingContext2D ctx)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderingContext2D>(
                entity => new CanvasRenderingContext2D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setToContext" }, ctx
                }
            );
        }

        public CachedEntity[] copyToArray(CachedEntity[] out = null)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyToArray" }, out
                }
            );
        }

        public TransformMatrix setTransform(decimal a, decimal b, decimal c, decimal d, decimal tx, decimal ty)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTransform" }, a, b, c, d, tx, ty
                }
            );
        }

        public CachedEntity decomposeMatrix()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "decomposeMatrix" }
                }
            );
        }

        public TransformMatrix applyITRS(decimal x, decimal y, decimal rotation, decimal scaleX, decimal scaleY)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyITRS" }, x, y, rotation, scaleX, scaleY
                }
            );
        }

        public Vector2 applyInverse(decimal x, decimal y, Vector2 output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyInverse" }, x, y, output
                }
            );
        }

        public decimal getX(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getX" }, x, y
                }
            );
        }

        public decimal getY(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getY" }, x, y
                }
            );
        }

        public decimal getXRound(decimal x, decimal y, System.Nullable<bool> round = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getXRound" }, x, y, round
                }
            );
        }

        public decimal getYRound(decimal x, decimal y, System.Nullable<bool> round = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getYRound" }, x, y, round
                }
            );
        }

        public string getCSSMatrix()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getCSSMatrix" }
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