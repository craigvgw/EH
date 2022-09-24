/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BatchSystem>))]
public class BatchSystem : CachedEntityObject, ISystem
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
        private ObjectRenderer __emptyRenderer;
        public ObjectRenderer emptyRenderer
        {
            get
            {
            if(__emptyRenderer == null)
            {
                __emptyRenderer = EventHorizonBlazorInterop.GetClass<ObjectRenderer>(
                    this.___guid,
                    "emptyRenderer",
                    (entity) =>
                    {
                        return new ObjectRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __emptyRenderer;
            }
        }

        private ObjectRenderer __currentRenderer;
        public ObjectRenderer currentRenderer
        {
            get
            {
            if(__currentRenderer == null)
            {
                __currentRenderer = EventHorizonBlazorInterop.GetClass<ObjectRenderer>(
                    this.___guid,
                    "currentRenderer",
                    (entity) =>
                    {
                        return new ObjectRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentRenderer;
            }
            set
            {
__currentRenderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentRenderer",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BatchSystem() : base() { }

        public BatchSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BatchSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BatchSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setObjectRenderer(ObjectRenderer objectRenderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setObjectRenderer" }, objectRenderer
                }
            );
        }

        public void flush()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flush" }
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

        public void copyBoundTextures(BaseTexture[] arr, decimal maxTextures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyBoundTextures" }, arr, maxTextures
                }
            );
        }

        public void boundArray(BatchTextureArray texArray, BaseTexture[] boundTextures, decimal batchId, decimal maxTextures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "boundArray" }, texArray, boundTextures, batchId, maxTextures
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
