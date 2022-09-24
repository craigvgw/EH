/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BasePrepare>))]
public class BasePrepare : CachedEntityObject
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
        
        public CachedEntity[] addHooks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "addHooks",
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
                    "addHooks",
                    value
                );
            }
        }

        
        public CachedEntity[] uploadHooks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "uploadHooks",
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
                    "uploadHooks",
                    value
                );
            }
        }

        
        public CachedEntity[] completes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "completes",
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
                    "completes",
                    value
                );
            }
        }

        
        public bool ticking
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ticking"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ticking",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BasePrepare() : base() { }

        public BasePrepare(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BasePrepare(
            AbstractRenderer renderer
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BasePrepare" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public async ValueTask upload(IDisplayObjectExtended item = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, item
                }
            );
        }

        public void tick()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "tick" }
                }
            );
        }

        public void prepareItems()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareItems" }
                }
            );
        }

        public BasePrepare registerFindHook(IFindHook addHook)
        {
            return EventHorizonBlazorInterop.FuncClass<BasePrepare>(
                entity => new BasePrepare() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerFindHook" }, addHook
                }
            );
        }

        public BasePrepare registerUploadHook(IUploadHook uploadHook)
        {
            return EventHorizonBlazorInterop.FuncClass<BasePrepare>(
                entity => new BasePrepare() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerUploadHook" }, uploadHook
                }
            );
        }

        public BasePrepare add(IDisplayObjectExtended item)
        {
            return EventHorizonBlazorInterop.FuncClass<BasePrepare>(
                entity => new BasePrepare() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, item
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
