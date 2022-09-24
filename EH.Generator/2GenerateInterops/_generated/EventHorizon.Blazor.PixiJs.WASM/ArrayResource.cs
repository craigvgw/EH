/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ArrayResource>))]
public class ArrayResource : AbstractMultiResource
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

    #endregion
    
    #region Constructor
        public ArrayResource() : base() { }

        public ArrayResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ArrayResource(
            decimal source, ISize options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ArrayResource" },
                source, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ArrayResource addBaseTextureAt(BaseTexture baseTexture, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<ArrayResource>(
                entity => new ArrayResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addBaseTextureAt" }, baseTexture, index
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

        public bool upload(Renderer renderer, BaseTexture texture, GLTexture glTexture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, renderer, texture, glTexture
                }
            );
        }
    #endregion
}
