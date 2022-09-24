/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CubeResource>))]
public class CubeResource : AbstractMultiResource
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static decimal SIDES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "CubeResource",
                    "SIDES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "CubeResource",
                    "SIDES",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static string test(unknown source)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "CubeResource", "test" }, source
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public L items
        {
            get
            {
            return EventHorizonBlazorInterop.Get<L>(
                    this.___guid,
                    "items"
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

        
        public bool linkBaseTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "linkBaseTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linkBaseTexture",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CubeResource() : base() { }

        public CubeResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CubeResource(
            string source = null, ICubeResourceOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CubeResource" },
                source, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void bind(BaseTexture baseTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, baseTexture
                }
            );
        }

        public CubeResource addBaseTextureAt(BaseTexture baseTexture, decimal index, System.Nullable<bool> linkBaseTexture = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CubeResource>(
                entity => new CubeResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addBaseTextureAt" }, baseTexture, index, linkBaseTexture
                }
            );
        }

        public bool upload(Renderer renderer, BaseTexture _baseTexture, GLTexture glTexture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, renderer, _baseTexture, glTexture
                }
            );
        }
    #endregion
}
