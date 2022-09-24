/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Spritesheet>))]
public class Spritesheet : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static unknown BATCH_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    "Spritesheet",
                    "BATCH_SIZE"
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public Spritesheet[] linkedSheets
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Spritesheet>(
                    this.___guid,
                    "linkedSheets",
                    (entity) =>
                    {
                        return new Spritesheet() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linkedSheets",
                    value
                );
            }
        }

        private BaseTexture __baseTexture;
        public BaseTexture baseTexture
        {
            get
            {
            if(__baseTexture == null)
            {
                __baseTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "baseTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __baseTexture;
            }
            set
            {
__baseTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseTexture",
                    value
                );
            }
        }

        
        public CachedEntity textures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "textures"
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

        
        public CachedEntity animations
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "animations"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        private ISpritesheetDataCachedEntity __data;
        public ISpritesheetDataCachedEntity data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<ISpritesheetDataCachedEntity>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new ISpritesheetDataCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolution",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Spritesheet() : base() { }

        public Spritesheet(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Spritesheet(
            BaseTexture texture, ISpritesheetData data, string resolutionFilename = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Spritesheet" },
                texture, data, resolutionFilename
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ValueTask<CachedEntity> parse()
        {
            return EventHorizonBlazorInterop.TaskClass<CachedEntity>(
                entity => new CachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parse" }
                }
            );
        }

        public void destroy(System.Nullable<bool> destroyBase = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, destroyBase
                }
            );
        }
    #endregion
}
