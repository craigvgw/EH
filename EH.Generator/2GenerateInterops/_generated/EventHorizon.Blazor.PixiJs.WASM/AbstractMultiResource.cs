/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AbstractMultiResource>))]
public class AbstractMultiResource : Resource
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
        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
        }

        
        public BaseTexture[] items
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BaseTexture>(
                    this.___guid,
                    "items",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "items",
                    value
                );
            }
        }

        
        public decimal[] itemDirtyIds
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "itemDirtyIds"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "itemDirtyIds",
                    value
                );
            }
        }

        private BaseTexture __baseTexture;
        public BaseTexture baseTexture
        {
            get
            {
            if(__baseTexture == null)
            {
                __baseTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "baseTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __baseTexture;
            }
            set
            {
__baseTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseTexture",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public AbstractMultiResource() : base() { }

        public AbstractMultiResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AbstractMultiResource(
            decimal length, ISize options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AbstractMultiResource" },
                length, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public AbstractMultiResource addBaseTextureAt(BaseTexture baseTexture, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMultiResource>(
                entity => new AbstractMultiResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addBaseTextureAt" }, baseTexture, index
                }
            );
        }

        public AbstractMultiResource addResourceAt(Resource resource, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMultiResource>(
                entity => new AbstractMultiResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addResourceAt" }, resource, index
                }
            );
        }

        public void bind(BaseTexture baseTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, baseTexture
                }
            );
        }

        public void unbind(BaseTexture baseTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }, baseTexture
                }
            );
        }

        public ValueTask<AbstractMultiResource> load()
        {
            return EventHorizonBlazorInterop.TaskClass<AbstractMultiResource>(
                entity => new AbstractMultiResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }
                }
            );
        }
    #endregion
}
