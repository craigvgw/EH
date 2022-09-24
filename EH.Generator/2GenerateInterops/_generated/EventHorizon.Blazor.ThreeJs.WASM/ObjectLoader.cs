/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ObjectLoader>))]
public class ObjectLoader : Loader
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
        public ObjectLoader() : base() { }

        public ObjectLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ObjectLoader(
            LoadingManager manager = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ObjectLoader" },
                manager
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void load(string url, ActionCallback<ObjectType> onLoad = null, ActionCallback<ProgressEvent> onProgress = null, Error onError = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, url, onLoad, onProgress, onError
                }
            );
        }

        public ValueTask<ObjectType> loadAsync<ObjectType>(string url, ActionCallback<ProgressEvent> onProgress = null) where ObjectType : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.TaskClass<ObjectType>(
                entity => new ObjectType() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url, onProgress
                }
            );
        }

        public T parse<T>(object json, ActionCallback<Object3D> onLoad = null) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parse" }, json, onLoad
                }
            );
        }

        public ValueTask<T> parseAsync<T>(object json) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.TaskClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseAsync" }, json
                }
            );
        }

        public InstancedBufferGeometry parseGeometries(object json)
        {
            return EventHorizonBlazorInterop.FuncClass<InstancedBufferGeometry>(
                entity => new InstancedBufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseGeometries" }, json
                }
            );
        }

        public Material[] parseMaterials(object json, Texture[] textures)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseMaterials" }, json, textures
                }
            );
        }

        public AnimationClip[] parseAnimations(object json)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseAnimations" }, json
                }
            );
        }

        public CachedEntity parseImages(object json, ActionCallback onLoad)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parseImages" }, json, onLoad
                }
            );
        }

        public ValueTask<CachedEntity> parseImagesAsync(object json)
        {
            return EventHorizonBlazorInterop.TaskClass<CachedEntity>(
                entity => new CachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseImagesAsync" }, json
                }
            );
        }

        public Texture[] parseTextures(object json, object images)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseTextures" }, json, images
                }
            );
        }

        public T parseObject<T>(object data, CachedEntity[] geometries, Material[] materials, AnimationClip[] animations) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseObject" }, data, geometries, materials, animations
                }
            );
        }
    #endregion
}
