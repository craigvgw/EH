/// Generated - Do Not Edit
namespace spine
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TextureAtlas>))]
    public class TextureAtlas : CachedEntityObject, Disposable
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
        
        public TextureAtlasPage[] pages
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TextureAtlasPage>(
                    this.___guid,
                    "pages",
                    (entity) =>
                    {
                        return new TextureAtlasPage() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pages",
                    value
                );
            }
        }

        
        public TextureAtlasRegion[] regions
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TextureAtlasRegion>(
                    this.___guid,
                    "regions",
                    (entity) =>
                    {
                        return new TextureAtlasRegion() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "regions",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextureAtlas() : base() { }

        public TextureAtlas(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TextureAtlas(
            string atlasText, ActionResultCallback<string, CachedEntity> textureLoader
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "TextureAtlas" },
                atlasText, textureLoader
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public TextureAtlasRegion findRegion(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<TextureAtlasRegion>(
                entity => new TextureAtlasRegion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findRegion" }, name
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
}