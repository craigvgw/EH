/// Generated - Do Not Edit
namespace Phaser.Cache
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CacheManager>))]
    public class CacheManager : CachedEntityObject
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
        private BaseCache __binary;
        public BaseCache binary
        {
            get
            {
            if(__binary == null)
            {
                __binary = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "binary",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __binary;
            }
            set
            {
__binary = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "binary",
                    value
                );
            }
        }

        private BaseCache __bitmapFont;
        public BaseCache bitmapFont
        {
            get
            {
            if(__bitmapFont == null)
            {
                __bitmapFont = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "bitmapFont",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __bitmapFont;
            }
            set
            {
__bitmapFont = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bitmapFont",
                    value
                );
            }
        }

        private BaseCache __json;
        public BaseCache json
        {
            get
            {
            if(__json == null)
            {
                __json = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "json",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __json;
            }
            set
            {
__json = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "json",
                    value
                );
            }
        }

        private BaseCache __physics;
        public BaseCache physics
        {
            get
            {
            if(__physics == null)
            {
                __physics = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "physics",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __physics;
            }
            set
            {
__physics = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "physics",
                    value
                );
            }
        }

        private BaseCache __shader;
        public BaseCache shader
        {
            get
            {
            if(__shader == null)
            {
                __shader = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "shader",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __shader;
            }
            set
            {
__shader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shader",
                    value
                );
            }
        }

        private BaseCache __audio;
        public BaseCache audio
        {
            get
            {
            if(__audio == null)
            {
                __audio = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "audio",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __audio;
            }
            set
            {
__audio = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "audio",
                    value
                );
            }
        }

        private BaseCache __video;
        public BaseCache video
        {
            get
            {
            if(__video == null)
            {
                __video = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "video",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __video;
            }
            set
            {
__video = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "video",
                    value
                );
            }
        }

        private BaseCache __text;
        public BaseCache text
        {
            get
            {
            if(__text == null)
            {
                __text = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "text",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __text;
            }
            set
            {
__text = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "text",
                    value
                );
            }
        }

        private BaseCache __html;
        public BaseCache html
        {
            get
            {
            if(__html == null)
            {
                __html = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "html",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __html;
            }
            set
            {
__html = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "html",
                    value
                );
            }
        }

        private BaseCache __obj;
        public BaseCache obj
        {
            get
            {
            if(__obj == null)
            {
                __obj = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "obj",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __obj;
            }
            set
            {
__obj = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "obj",
                    value
                );
            }
        }

        private BaseCache __tilemap;
        public BaseCache tilemap
        {
            get
            {
            if(__tilemap == null)
            {
                __tilemap = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "tilemap",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __tilemap;
            }
            set
            {
__tilemap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tilemap",
                    value
                );
            }
        }

        private BaseCache __xml;
        public BaseCache xml
        {
            get
            {
            if(__xml == null)
            {
                __xml = EventHorizonBlazorInterop.GetClass<BaseCache>(
                    this.___guid,
                    "xml",
                    (entity) =>
                    {
                        return new BaseCache() { ___guid = entity.___guid };
                    }
                );
            }
            return __xml;
            }
            set
            {
__xml = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xml",
                    value
                );
            }
        }

        
        public CachedEntity custom
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "custom",
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
                    "custom",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CacheManager() : base() { }

        public CacheManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public CacheManager(
            Game game
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Cache", "CacheManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public BaseCache addCustom(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCache>(
                entity => new BaseCache() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addCustom" }, key
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
}