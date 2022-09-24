/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IRenderableObject : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IRenderableObjectCachedEntity>))]
public class IRenderableObjectCachedEntity : CachedEntityObject, IRenderableObject
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
        private IRenderableContainerCachedEntity __parent;
        public IRenderableContainerCachedEntity parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<IRenderableContainerCachedEntity>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new IRenderableContainerCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
            }
            set
            {
__parent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IRenderableObjectCachedEntity() : base() { }

        public IRenderableObjectCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public IRenderableContainerCachedEntity enableTempParent()
        {
            return EventHorizonBlazorInterop.FuncClass<IRenderableContainerCachedEntity>(
                entity => new IRenderableContainerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableTempParent" }
                }
            );
        }

        public void updateTransform()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTransform" }
                }
            );
        }

        public void disableTempParent(IRenderableContainer parent)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableTempParent" }, parent
                }
            );
        }

        public void render(Renderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, renderer
                }
            );
        }
    #endregion
}
