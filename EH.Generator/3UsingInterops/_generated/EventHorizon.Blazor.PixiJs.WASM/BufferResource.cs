/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BufferResource>))]
public class BufferResource : Resource
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static decimal[] test(unknown source)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "BufferResource", "test" }, source
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public decimal[] data
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "data"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BufferResource() : base() { }

        public BufferResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BufferResource(
            decimal[] source, ISize options
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BufferResource" },
                source, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public bool upload(Renderer renderer, BaseTexture baseTexture, GLTexture glTexture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, renderer, baseTexture, glTexture
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
