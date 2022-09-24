/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface PageMeshData : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<PageMeshDataCachedEntity>))]
public class PageMeshDataCachedEntity : CachedEntityObject, PageMeshData
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
        
        public decimal index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }

        
        public decimal indexCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indexCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indexCount",
                    value
                );
            }
        }

        
        public decimal vertexCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vertexCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexCount",
                    value
                );
            }
        }

        
        public decimal uvsCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uvsCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvsCount",
                    value
                );
            }
        }

        
        public decimal total
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "total",
                    value
                );
            }
        }

        private Mesh __mesh;
        public Mesh mesh
        {
            get
            {
            if(__mesh == null)
            {
                __mesh = EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "mesh",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __mesh;
            }
            set
            {
__mesh = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mesh",
                    value
                );
            }
        }

        
        public decimal[] vertices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "vertices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }

        
        public decimal[] uvs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }

        private Uint16Array __indices;
        public Uint16Array indices
        {
            get
            {
            if(__indices == null)
            {
                __indices = EventHorizonBlazorInterop.GetClass<Uint16Array>(
                    this.___guid,
                    "indices",
                    (entity) =>
                    {
                        return new Uint16Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __indices;
            }
            set
            {
__indices = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indices",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public PageMeshDataCachedEntity() : base() { }

        public PageMeshDataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
