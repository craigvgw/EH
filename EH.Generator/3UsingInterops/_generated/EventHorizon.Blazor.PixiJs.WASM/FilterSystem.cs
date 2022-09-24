/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<FilterSystem>))]
public class FilterSystem : CachedEntityObject, ISystem
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
        
        public FilterState[] defaultFilterStack
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<FilterState>(
                    this.___guid,
                    "defaultFilterStack",
                    (entity) =>
                    {
                        return new FilterState() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public FilterState[] statePool
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<FilterState>(
                    this.___guid,
                    "statePool",
                    (entity) =>
                    {
                        return new FilterState() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "statePool",
                    value
                );
            }
        }

        private RenderTexturePool __texturePool;
        public RenderTexturePool texturePool
        {
            get
            {
            if(__texturePool == null)
            {
                __texturePool = EventHorizonBlazorInterop.GetClass<RenderTexturePool>(
                    this.___guid,
                    "texturePool",
                    (entity) =>
                    {
                        return new RenderTexturePool() { ___guid = entity.___guid };
                    }
                );
            }
            return __texturePool;
            }
            set
            {
__texturePool = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texturePool",
                    value
                );
            }
        }

        
        public bool forceClear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceClear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceClear",
                    value
                );
            }
        }

        
        public bool useMaxPadding
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useMaxPadding"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useMaxPadding",
                    value
                );
            }
        }

        private Renderer __renderer;
        public Renderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<Renderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new Renderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderer;
            }
            set
            {
__renderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderer",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public FilterSystem() : base() { }

        public FilterSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FilterSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "FilterSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void push(IFilterTarget target, Filter[] filters)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "push" }, target, filters
                }
            );
        }

        public void pop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pop" }
                }
            );
        }

        public void bindAndClear(RenderTexture filterTexture, System.Nullable<int> clearMode = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindAndClear" }, filterTexture, clearMode
                }
            );
        }

        public void applyFilter(Filter filter, RenderTexture input, RenderTexture output, System.Nullable<int> clearMode = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyFilter" }, filter, input, output, clearMode
                }
            );
        }

        public Matrix calculateSpriteMatrix(Matrix outputMatrix, ISpriteMaskTarget sprite)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "calculateSpriteMatrix" }, outputMatrix, sprite
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

        public RenderTexture getFilterTexture(RenderTexture input = null, System.Nullable<decimal> resolution = null, System.Nullable<int> multisample = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFilterTexture" }, input, resolution, multisample
                }
            );
        }

        public void returnFilterTexture(RenderTexture renderTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "returnFilterTexture" }, renderTexture
                }
            );
        }

        public void emptyPool()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "emptyPool" }
                }
            );
        }

        public void resize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }
                }
            );
        }
    #endregion
}
