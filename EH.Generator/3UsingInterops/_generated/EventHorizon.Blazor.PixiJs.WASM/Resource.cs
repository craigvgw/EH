/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Resource>))]
public class Resource : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static bool test(string _source, string _extension = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "Resource", "test" }, _source, _extension
                }
            );
        }
    #endregion

    #region Accessors
        
        public bool valid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "valid"
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
        }
    #endregion

    #region Properties
        
        public string src
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "src"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "src",
                    value
                );
            }
        }

        
        public bool destroyed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "destroyed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "destroyed",
                    value
                );
            }
        }

        
        public bool internalPixi
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "internalPixi"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "internalPixi",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Resource() : base() { }

        public Resource(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Resource(
            System.Nullable<decimal> width = null, System.Nullable<decimal> height = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Resource" },
                width, height
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

        public void unbind(BaseTexture baseTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }, baseTexture
                }
            );
        }

        public void resize(decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public ValueTask<Resource> load()
        {
            return EventHorizonBlazorInterop.TaskClass<Resource>(
                entity => new Resource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }
                }
            );
        }

        public bool upload(Renderer renderer, BaseTexture baseTexture, GLTexture glTexture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, renderer, baseTexture, glTexture
                }
            );
        }

        public bool style(Renderer _renderer, BaseTexture _baseTexture, GLTexture _glTexture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "style" }, _renderer, _baseTexture, _glTexture
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

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
    #endregion
}
