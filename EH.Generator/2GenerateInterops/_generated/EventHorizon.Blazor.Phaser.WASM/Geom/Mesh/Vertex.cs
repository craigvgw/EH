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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vertex>))]
    public class Vertex : Vector3
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
        
        public decimal vx
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vx"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vx",
                    value
                );
            }
        }

        
        public decimal vy
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vy",
                    value
                );
            }
        }

        
        public decimal vz
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vz"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vz",
                    value
                );
            }
        }

        
        public decimal nx
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nx"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nx",
                    value
                );
            }
        }

        
        public decimal ny
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ny"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ny",
                    value
                );
            }
        }

        
        public decimal nz
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nz"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nz",
                    value
                );
            }
        }

        
        public decimal u
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "u"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "u",
                    value
                );
            }
        }

        
        public decimal v
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "v"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "v",
                    value
                );
            }
        }

        
        public decimal color
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
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

        
        public decimal ta
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ta"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ta",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Vertex() : base() { }

        public Vertex(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Vertex(
            decimal x, decimal y, decimal z, decimal u, decimal v, System.Nullable<decimal> color = null, System.Nullable<decimal> alpha = null, System.Nullable<decimal> nx = null, System.Nullable<decimal> ny = null, System.Nullable<decimal> nz = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Geom", "Mesh", "Vertex" },
                x, y, z, u, v, color, alpha, nx, ny, nz
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Vertex setUVs(decimal u, decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vertex>(
                entity => new Vertex() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUVs" }, u, v
                }
            );
        }

        public void transformCoordinatesLocal(Matrix4 transformMatrix, decimal width, decimal height, decimal cameraZ)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "transformCoordinatesLocal" }, transformMatrix, width, height, cameraZ
                }
            );
        }

        public Vertex update(decimal a, decimal b, decimal c, decimal d, decimal e, decimal f, bool roundPixels, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Vertex>(
                entity => new Vertex() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }, a, b, c, d, e, f, roundPixels, alpha
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
        #endregion
    }
}