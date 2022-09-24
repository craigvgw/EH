/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IRendererRenderOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IRendererRenderOptionsCachedEntity>))]
public class IRendererRenderOptionsCachedEntity : CachedEntityObject, IRendererRenderOptions
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
        private RenderTexture __renderTexture;
        public RenderTexture renderTexture
        {
            get
            {
            if(__renderTexture == null)
            {
                __renderTexture = EventHorizonBlazorInterop.GetClass<RenderTexture>(
                    this.___guid,
                    "renderTexture",
                    (entity) =>
                    {
                        return new RenderTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderTexture;
            }
            set
            {
__renderTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTexture",
                    value
                );
            }
        }

        
        public bool clear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clear",
                    value
                );
            }
        }

        private Matrix __transform;
        public Matrix transform
        {
            get
            {
            if(__transform == null)
            {
                __transform = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "transform",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __transform;
            }
            set
            {
__transform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transform",
                    value
                );
            }
        }

        
        public bool skipUpdateTransform
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipUpdateTransform"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipUpdateTransform",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IRendererRenderOptionsCachedEntity() : base() { }

        public IRendererRenderOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
