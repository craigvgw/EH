/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface RenderItem : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<RenderItemCachedEntity>))]
public class RenderItemCachedEntity : CachedEntityObject, RenderItem
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
        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        private Object3D __object;
        public Object3D @object
        {
            get
            {
            if(__object == null)
            {
                __object = EventHorizonBlazorInterop.GetClass<Object3D>(
                    this.___guid,
                    "object",
                    (entity) =>
                    {
                        return new Object3D() { ___guid = entity.___guid };
                    }
                );
            }
            return __object;
            }
            set
            {
__object = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "object",
                    value
                );
            }
        }

        private BufferGeometry __geometry;
        public BufferGeometry geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInterop.GetClass<BufferGeometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new BufferGeometry() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometry;
            }
            set
            {
__geometry = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometry",
                    value
                );
            }
        }

        private Material __material;
        public Material material
        {
            get
            {
            if(__material == null)
            {
                __material = EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __material;
            }
            set
            {
__material = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "material",
                    value
                );
            }
        }

        private WebGLProgram __program;
        public WebGLProgram program
        {
            get
            {
            if(__program == null)
            {
                __program = EventHorizonBlazorInterop.GetClass<WebGLProgram>(
                    this.___guid,
                    "program",
                    (entity) =>
                    {
                        return new WebGLProgram() { ___guid = entity.___guid };
                    }
                );
            }
            return __program;
            }
            set
            {
__program = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "program",
                    value
                );
            }
        }

        
        public decimal groupOrder
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groupOrder"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groupOrder",
                    value
                );
            }
        }

        
        public decimal renderOrder
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderOrder"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderOrder",
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

        private Group __group;
        public Group group
        {
            get
            {
            if(__group == null)
            {
                __group = EventHorizonBlazorInterop.GetClass<Group>(
                    this.___guid,
                    "group",
                    (entity) =>
                    {
                        return new Group() { ___guid = entity.___guid };
                    }
                );
            }
            return __group;
            }
            set
            {
__group = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "group",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public RenderItemCachedEntity() : base() { }

        public RenderItemCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
