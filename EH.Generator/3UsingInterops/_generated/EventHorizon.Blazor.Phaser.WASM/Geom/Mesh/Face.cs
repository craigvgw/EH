/// Generated - Do Not Edit
namespace Phaser.Geom.Mesh
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Face>))]
    public class Face : CachedEntityObject
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
        private Vertex __vertex1;
        public Vertex vertex1
        {
            get
            {
            if(__vertex1 == null)
            {
                __vertex1 = EventHorizonBlazorInterop.GetClass<Vertex>(
                    this.___guid,
                    "vertex1",
                    (entity) =>
                    {
                        return new Vertex() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertex1;
            }
            set
            {
__vertex1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertex1",
                    value
                );
            }
        }

        private Vertex __vertex2;
        public Vertex vertex2
        {
            get
            {
            if(__vertex2 == null)
            {
                __vertex2 = EventHorizonBlazorInterop.GetClass<Vertex>(
                    this.___guid,
                    "vertex2",
                    (entity) =>
                    {
                        return new Vertex() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertex2;
            }
            set
            {
__vertex2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertex2",
                    value
                );
            }
        }

        private Vertex __vertex3;
        public Vertex vertex3
        {
            get
            {
            if(__vertex3 == null)
            {
                __vertex3 = EventHorizonBlazorInterop.GetClass<Vertex>(
                    this.___guid,
                    "vertex3",
                    (entity) =>
                    {
                        return new Vertex() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertex3;
            }
            set
            {
__vertex3 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertex3",
                    value
                );
            }
        }

        private Rectangle __bounds;
        public Rectangle bounds
        {
            get
            {
            if(__bounds == null)
            {
                __bounds = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __bounds;
            }
            set
            {
__bounds = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bounds",
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

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Face() : base() { }

        public Face(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Face(
            Vertex vertex1, Vertex vertex2, Vertex vertex3
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Geom", "Mesh", "Face" },
                vertex1, vertex2, vertex3
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Vector2 getInCenter(System.Nullable<bool> local = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInCenter" }, local
                }
            );
        }

        public bool contains(decimal x, decimal y, TransformMatrix calcMatrix = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, x, y, calcMatrix
                }
            );
        }

        public bool isCounterClockwise(decimal z)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isCounterClockwise" }, z
                }
            );
        }

        public decimal load(decimal[] F32, Uint32Array U32, decimal offset, decimal textureUnit, decimal tintEffect)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, F32, U32, offset, textureUnit, tintEffect
                }
            );
        }

        public Face transformCoordinatesLocal(Matrix4 transformMatrix, decimal width, decimal height, decimal cameraZ)
        {
            return EventHorizonBlazorInterop.FuncClass<Face>(
                entity => new Face() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformCoordinatesLocal" }, transformMatrix, width, height, cameraZ
                }
            );
        }

        public Face updateBounds()
        {
            return EventHorizonBlazorInterop.FuncClass<Face>(
                entity => new Face() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateBounds" }
                }
            );
        }

        public bool isInView(Camera camera, bool hideCCW, decimal z, decimal alpha, decimal a, decimal b, decimal c, decimal d, decimal e, decimal f, bool roundPixels)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isInView" }, camera, hideCCW, z, alpha, a, b, c, d, e, f, roundPixels
                }
            );
        }

        public Face translate(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Face>(
                entity => new Face() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, x, y
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