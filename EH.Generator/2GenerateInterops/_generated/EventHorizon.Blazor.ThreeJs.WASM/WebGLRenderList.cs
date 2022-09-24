/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLRenderList>))]
public class WebGLRenderList : CachedEntityObject
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
        
        public RenderItemCachedEntity[] opaque
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<RenderItemCachedEntity>(
                    this.___guid,
                    "opaque",
                    (entity) =>
                    {
                        return new RenderItemCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "opaque",
                    value
                );
            }
        }

        
        public RenderItemCachedEntity[] transparent
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<RenderItemCachedEntity>(
                    this.___guid,
                    "transparent",
                    (entity) =>
                    {
                        return new RenderItemCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transparent",
                    value
                );
            }
        }

        
        public RenderItemCachedEntity[] transmissive
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<RenderItemCachedEntity>(
                    this.___guid,
                    "transmissive",
                    (entity) =>
                    {
                        return new RenderItemCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transmissive",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLRenderList() : base() { }

        public WebGLRenderList(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLRenderList(
            WebGLProperties properties
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLRenderList" },
                properties
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void init()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }
                }
            );
        }

        public void push(Object3D @object, Material material, decimal groupOrder, decimal z, BufferGeometry geometry = null, Group group = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "push" }, @object, geometry, material, groupOrder, z, group
                }
            );
        }

        public void unshift(Object3D @object, Material material, decimal groupOrder, decimal z, BufferGeometry geometry = null, Group group = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unshift" }, @object, geometry, material, groupOrder, z, group
                }
            );
        }

        public void sort(ActionResultCallback<object, object, decimal> opaqueSort, ActionResultCallback<object, object, decimal> transparentSort)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sort" }, opaqueSort, transparentSort
                }
            );
        }

        public void finish()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "finish" }
                }
            );
        }
    #endregion
}
