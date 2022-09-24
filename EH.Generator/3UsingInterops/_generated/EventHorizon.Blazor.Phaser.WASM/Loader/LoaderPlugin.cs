/// Generated - Do Not Edit
namespace Phaser.Loader
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<LoaderPlugin>))]
    public class LoaderPlugin : EventEmitter
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
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }

        private Systems __systems;
        public Systems systems
        {
            get
            {
            if(__systems == null)
            {
                __systems = EventHorizonBlazorInterop.GetClass<Systems>(
                    this.___guid,
                    "systems",
                    (entity) =>
                    {
                        return new Systems() { ___guid = entity.___guid };
                    }
                );
            }
            return __systems;
            }
            set
            {
__systems = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systems",
                    value
                );
            }
        }

        private CacheManager __cacheManager;
        public CacheManager cacheManager
        {
            get
            {
            if(__cacheManager == null)
            {
                __cacheManager = EventHorizonBlazorInterop.GetClass<CacheManager>(
                    this.___guid,
                    "cacheManager",
                    (entity) =>
                    {
                        return new CacheManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __cacheManager;
            }
            set
            {
__cacheManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cacheManager",
                    value
                );
            }
        }

        private TextureManager __textureManager;
        public TextureManager textureManager
        {
            get
            {
            if(__textureManager == null)
            {
                __textureManager = EventHorizonBlazorInterop.GetClass<TextureManager>(
                    this.___guid,
                    "textureManager",
                    (entity) =>
                    {
                        return new TextureManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureManager;
            }
            set
            {
__textureManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureManager",
                    value
                );
            }
        }

        
        public string prefix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "prefix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prefix",
                    value
                );
            }
        }

        
        public string path
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "path"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "path",
                    value
                );
            }
        }

        
        public string baseURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "baseURL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseURL",
                    value
                );
            }
        }

        
        public decimal maxParallelDownloads
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxParallelDownloads"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxParallelDownloads",
                    value
                );
            }
        }

        private XHRSettingsObject __xhr;
        public XHRSettingsObject xhr
        {
            get
            {
            if(__xhr == null)
            {
                __xhr = EventHorizonBlazorInterop.GetClass<XHRSettingsObject>(
                    this.___guid,
                    "xhr",
                    (entity) =>
                    {
                        return new XHRSettingsObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __xhr;
            }
            set
            {
__xhr = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xhr",
                    value
                );
            }
        }

        
        public string crossOrigin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "crossOrigin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "crossOrigin",
                    value
                );
            }
        }

        
        public decimal totalToLoad
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalToLoad"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalToLoad",
                    value
                );
            }
        }

        
        public decimal progress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "progress"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "progress",
                    value
                );
            }
        }

        private Set<File> __list;
        public Set<File> list
        {
            get
            {
            if(__list == null)
            {
                __list = EventHorizonBlazorInterop.GetClass<Set<File>>(
                    this.___guid,
                    "list",
                    (entity) =>
                    {
                        return new Set<File>() { ___guid = entity.___guid };
                    }
                );
            }
            return __list;
            }
            set
            {
__list = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "list",
                    value
                );
            }
        }

        private Set<File> __inflight;
        public Set<File> inflight
        {
            get
            {
            if(__inflight == null)
            {
                __inflight = EventHorizonBlazorInterop.GetClass<Set<File>>(
                    this.___guid,
                    "inflight",
                    (entity) =>
                    {
                        return new Set<File>() { ___guid = entity.___guid };
                    }
                );
            }
            return __inflight;
            }
            set
            {
__inflight = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inflight",
                    value
                );
            }
        }

        private Set<File> __queue;
        public Set<File> queue
        {
            get
            {
            if(__queue == null)
            {
                __queue = EventHorizonBlazorInterop.GetClass<Set<File>>(
                    this.___guid,
                    "queue",
                    (entity) =>
                    {
                        return new Set<File>() { ___guid = entity.___guid };
                    }
                );
            }
            return __queue;
            }
            set
            {
__queue = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "queue",
                    value
                );
            }
        }

        
        public decimal totalFailed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalFailed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalFailed",
                    value
                );
            }
        }

        
        public decimal totalComplete
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalComplete"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "totalComplete",
                    value
                );
            }
        }

        
        public decimal state
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "state"
                );
            }
        }
        #endregion
        
        #region Constructor
        public LoaderPlugin() : base() { }

        public LoaderPlugin(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LoaderPlugin(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Loader", "LoaderPlugin" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public LoaderPlugin animation(string key, string url = null, string dataKey = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "animation" }, key, url, dataKey, xhrSettings
                }
            );
        }

        public LoaderPlugin aseprite(string key, string textureURL = null, object atlasURL = null, XHRSettingsObject textureXhrSettings = null, XHRSettingsObject atlasXhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "aseprite" }, key, textureURL, atlasURL, textureXhrSettings, atlasXhrSettings
                }
            );
        }

        public LoaderPlugin atlas(string key, string textureURL = null, object atlasURL = null, XHRSettingsObject textureXhrSettings = null, XHRSettingsObject atlasXhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "atlas" }, key, textureURL, atlasURL, textureXhrSettings, atlasXhrSettings
                }
            );
        }

        public LoaderPlugin atlasXML(string key, string textureURL = null, string atlasURL = null, XHRSettingsObject textureXhrSettings = null, XHRSettingsObject atlasXhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "atlasXML" }, key, textureURL, atlasURL, textureXhrSettings, atlasXhrSettings
                }
            );
        }

        public LoaderPlugin audio(string key, string urls = null, object config = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "audio" }, key, urls, config, xhrSettings
                }
            );
        }

        public LoaderPlugin audioSprite(string key, string jsonURL, string audioURL = null, object audioConfig = null, XHRSettingsObject audioXhrSettings = null, XHRSettingsObject jsonXhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "audioSprite" }, key, jsonURL, audioURL, audioConfig, audioXhrSettings, jsonXhrSettings
                }
            );
        }

        public LoaderPlugin binary(string key, string url = null, object dataType = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "binary" }, key, url, dataType, xhrSettings
                }
            );
        }

        public LoaderPlugin bitmapFont(string key, string textureURL = null, string fontDataURL = null, XHRSettingsObject textureXhrSettings = null, XHRSettingsObject fontDataXhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bitmapFont" }, key, textureURL, fontDataURL, textureXhrSettings, fontDataXhrSettings
                }
            );
        }

        public LoaderPlugin css(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "css" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin glsl(string key, string url = null, string shaderType = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "glsl" }, key, url, shaderType, xhrSettings
                }
            );
        }

        public LoaderPlugin html(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "html" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin htmlTexture(string key, string url = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "htmlTexture" }, key, url, width, height, xhrSettings
                }
            );
        }

        public LoaderPlugin image(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "image" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin json(string key, object url = null, string dataKey = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "json" }, key, url, dataKey, xhrSettings
                }
            );
        }

        public LoaderPlugin multiatlas(string key, string atlasURL = null, string path = null, string baseURL = null, XHRSettingsObject atlasXhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiatlas" }, key, atlasURL, path, baseURL, atlasXhrSettings
                }
            );
        }

        public LoaderPlugin scripts(string key, string[] url = null, string extension = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scripts" }, key, url, extension, xhrSettings
                }
            );
        }

        public LoaderPlugin obj(string key, string objURL = null, string matURL = null, System.Nullable<bool> flipUV = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "obj" }, key, objURL, matURL, flipUV, xhrSettings
                }
            );
        }

        public LoaderPlugin pack(string key, string url = null, string dataKey = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pack" }, key, url, dataKey, xhrSettings
                }
            );
        }

        public LoaderPlugin plugin(string key, string url = null, System.Nullable<bool> start = null, string mapping = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "plugin" }, key, url, start, mapping, xhrSettings
                }
            );
        }

        public LoaderPlugin sceneFile(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sceneFile" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin scenePlugin(string key, string url = null, string systemKey = null, string sceneKey = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scenePlugin" }, key, url, systemKey, sceneKey, xhrSettings
                }
            );
        }

        public LoaderPlugin script(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "script" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin spritesheet(string key, string url = null, ImageFrameConfig frameConfig = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "spritesheet" }, key, url, frameConfig, xhrSettings
                }
            );
        }

        public LoaderPlugin svg(string key, string url = null, SVGSizeConfig svgConfig = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "svg" }, key, url, svgConfig, xhrSettings
                }
            );
        }

        public LoaderPlugin text(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "text" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin tilemapCSV(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tilemapCSV" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin tilemapImpact(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tilemapImpact" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin tilemapTiledJSON(string key, object url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tilemapTiledJSON" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin unityAtlas(string key, string textureURL = null, string atlasURL = null, XHRSettingsObject textureXhrSettings = null, XHRSettingsObject atlasXhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unityAtlas" }, key, textureURL, atlasURL, textureXhrSettings, atlasXhrSettings
                }
            );
        }

        public LoaderPlugin video(string key, string urls = null, string loadEvent = null, System.Nullable<bool> asBlob = null, System.Nullable<bool> noAudio = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "video" }, key, urls, loadEvent, asBlob, noAudio, xhrSettings
                }
            );
        }

        public LoaderPlugin xml(string key, string url = null, XHRSettingsObject xhrSettings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "xml" }, key, url, xhrSettings
                }
            );
        }

        public LoaderPlugin setBaseURL(string url = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBaseURL" }, url
                }
            );
        }

        public LoaderPlugin setPath(string path = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPath" }, path
                }
            );
        }

        public LoaderPlugin setPrefix(string prefix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPrefix" }, prefix
                }
            );
        }

        public LoaderPlugin setCORS(string crossOrigin = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCORS" }, crossOrigin
                }
            );
        }

        public void addFile(File file)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addFile" }, file
                }
            );
        }

        public bool keyExists(File file)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "keyExists" }, file
                }
            );
        }

        public bool addPack(object pack, string packKey = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "addPack" }, pack, packKey
                }
            );
        }

        public bool isLoading()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isLoading" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void start()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }
                }
            );
        }

        public void updateProgress()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateProgress" }
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

        public void nextFile(File file, bool success)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "nextFile" }, file, success
                }
            );
        }

        public void fileProcessComplete(File file)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fileProcessComplete" }, file
                }
            );
        }

        public void loadComplete()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadComplete" }
                }
            );
        }

        public void flagForRemoval(File file)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flagForRemoval" }, file
                }
            );
        }

        public LoaderPlugin saveJSON(object data, string filename = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saveJSON" }, data, filename
                }
            );
        }

        public LoaderPlugin save(object data, string filename = null, string filetype = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LoaderPlugin>(
                entity => new LoaderPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "save" }, data, filename, filetype
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
        #endregion
    }
}