/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CompressedTextureResource>))]
public class CompressedTextureResource : BlobResource
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
        
        public int format
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "format"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "format",
                    value
                );
            }
        }

        
        public decimal levels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "levels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "levels",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CompressedTextureResource() : base() { }

        public CompressedTextureResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CompressedTextureResource(
            string source, ICompressedTextureResourceOptions options
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CompressedTextureResource" },
                source, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public bool upload(Renderer renderer, BaseTexture _texture, GLTexture _glTexture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, renderer, _texture, _glTexture
                }
            );
        }
    #endregion
}
