/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TextureSystem>))]
public class TextureSystem : CachedEntityObject, ISystem
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
        
        public BaseTexture[] boundTextures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BaseTexture>(
                    this.___guid,
                    "boundTextures",
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
                    "boundTextures",
                    value
                );
            }
        }

        
        public BaseTexture[] managedTextures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BaseTexture>(
                    this.___guid,
                    "managedTextures",
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
                    "managedTextures",
                    value
                );
            }
        }

        
        public decimal currentLocation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentLocation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentLocation",
                    value
                );
            }
        }

        
        public CachedEntity emptyTextures
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "emptyTextures",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emptyTextures",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public TextureSystem() : base() { }

        public TextureSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TextureSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TextureSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void contextChange()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "contextChange" }
                }
            );
        }

        public void bind(Texture texture, System.Nullable<decimal> location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, texture, location
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public void unbind(BaseTexture texture = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }, texture
                }
            );
        }

        public void ensureSamplerType(decimal maxTextures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "ensureSamplerType" }, maxTextures
                }
            );
        }

        public GLTexture initTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.FuncClass<GLTexture>(
                entity => new GLTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "initTexture" }, texture
                }
            );
        }

        public void initTextureType(BaseTexture texture, GLTexture glTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initTextureType" }, texture, glTexture
                }
            );
        }

        public void updateTexture(BaseTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTexture" }, texture
                }
            );
        }

        public void destroyTexture(BaseTexture texture, System.Nullable<bool> skipRemove = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroyTexture" }, texture, skipRemove
                }
            );
        }

        public void updateTextureStyle(BaseTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureStyle" }, texture
                }
            );
        }

        public void setStyle(BaseTexture texture, GLTexture glTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setStyle" }, texture, glTexture
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
