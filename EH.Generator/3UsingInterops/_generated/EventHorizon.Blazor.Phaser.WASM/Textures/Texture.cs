/// Generated - Do Not Edit
namespace Phaser.Textures
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Texture>))]
    public class Texture : CachedEntityObject
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
        private TextureManager __manager;
        public TextureManager manager
        {
            get
            {
            if(__manager == null)
            {
                __manager = EventHorizonBlazorInterop.GetClass<TextureManager>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new TextureManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __manager;
            }
            set
            {
__manager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manager",
                    value
                );
            }
        }

        
        public string key
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "key"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "key",
                    value
                );
            }
        }

        
        public TextureSource[] source
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TextureSource>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new TextureSource() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }

        
        public CachedEntity[] dataSource
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "dataSource",
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
                    "dataSource",
                    value
                );
            }
        }

        
        public CachedEntity frames
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "frames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frames",
                    value
                );
            }
        }

        
        public CachedEntity customData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "customData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customData",
                    value
                );
            }
        }

        
        public string firstFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "firstFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "firstFrame",
                    value
                );
            }
        }

        
        public decimal frameTotal
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frameTotal"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frameTotal",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Texture() : base() { }

        public Texture(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Texture(
            TextureManager manager, string key, HTMLImageElement source, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Textures", "Texture" },
                manager, key, source, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Frame add(decimal name, decimal sourceIndex, decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, name, sourceIndex, x, y, width, height
                }
            );
        }

        public bool remove(string name)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, name
                }
            );
        }

        public bool has(string name)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "has" }, name
                }
            );
        }

        public Frame get(string name = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, name
                }
            );
        }

        public decimal getTextureSourceIndex(TextureSource source)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTextureSourceIndex" }, source
                }
            );
        }

        public Frame[] getFramesFromTextureSource(decimal sourceIndex, System.Nullable<bool> includeBase = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFramesFromTextureSource" }, sourceIndex, includeBase
                }
            );
        }

        public string[] getFrameNames(System.Nullable<bool> includeBase = null)
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getFrameNames" }, includeBase
                }
            );
        }

        public HTMLImageElement getSourceImage(string name = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLImageElement>(
                entity => new HTMLImageElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSourceImage" }, name
                }
            );
        }

        public HTMLImageElement getDataSourceImage(string name = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLImageElement>(
                entity => new HTMLImageElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDataSourceImage" }, name
                }
            );
        }

        public void setDataSource(HTMLImageElement data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDataSource" }, data
                }
            );
        }

        public void setFilter(int filterMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFilter" }, filterMode
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