/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MaterialLoader>))]
public class MaterialLoader : Loader
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
        
        public CachedEntity textures
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "textures",
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
                    "textures",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MaterialLoader() : base() { }

        public MaterialLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MaterialLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MaterialLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void load(string url, ActionCallback<Material> onLoad, ActionCallback<ProgressEvent> onProgress = null, Error onError = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<Material> loadAsync(string url, ActionCallback<ProgressEvent> onProgress = null)
        {
            return EventHorizonBlazorInterop.TaskClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }

        public MaterialLoader setTextures(object textures)
        {
            return EventHorizonBlazorInterop.FuncClass<MaterialLoader>(
                entity => new MaterialLoader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTextures" }, textures
                }
            );
        }

        public Material parse(object json)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parse" }, json
                }
            );
        }
    #endregion
}
