/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InstancedMesh<CachedEntity>>))]
public class InstancedMesh<TGeometry, Material> : Mesh<TGeometry, TMaterial> where TGeometry : CachedEntity, new() where Material : CachedEntity, new()
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
        
        public decimal count
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "count",
                    value
                );
            }
        }

        private InstancedBufferAttribute __instanceColor;
        public InstancedBufferAttribute instanceColor
        {
            get
            {
            if(__instanceColor == null)
            {
                __instanceColor = EventHorizonBlazorInterop.GetClass<InstancedBufferAttribute>(
                    this.___guid,
                    "instanceColor",
                    (entity) =>
                    {
                        return new InstancedBufferAttribute() { ___guid = entity.___guid };
                    }
                );
            }
            return __instanceColor;
            }
            set
            {
__instanceColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instanceColor",
                    value
                );
            }
        }

        private InstancedBufferAttribute __instanceMatrix;
        public InstancedBufferAttribute instanceMatrix
        {
            get
            {
            if(__instanceMatrix == null)
            {
                __instanceMatrix = EventHorizonBlazorInterop.GetClass<InstancedBufferAttribute>(
                    this.___guid,
                    "instanceMatrix",
                    (entity) =>
                    {
                        return new InstancedBufferAttribute() { ___guid = entity.___guid };
                    }
                );
            }
            return __instanceMatrix;
            }
            set
            {
__instanceMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instanceMatrix",
                    value
                );
            }
        }

        
        public unknown isInstancedMesh
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isInstancedMesh"
                );
            }
        }
    #endregion
    
    #region Constructor
        public InstancedMesh() : base() { }

        public InstancedMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public InstancedMesh(
            decimal count, TGeometry geometry = null, TMaterial material = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "InstancedMesh" },
                geometry, material, count
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void getColorAt(decimal index, Color color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getColorAt" }, index, color
                }
            );
        }

        public void getMatrixAt(decimal index, Matrix4 matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getMatrixAt" }, index, matrix
                }
            );
        }

        public void setColorAt(decimal index, Color color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColorAt" }, index, color
                }
            );
        }

        public void setMatrixAt(decimal index, Matrix4 matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMatrixAt" }, index, matrix
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
    #endregion
}
