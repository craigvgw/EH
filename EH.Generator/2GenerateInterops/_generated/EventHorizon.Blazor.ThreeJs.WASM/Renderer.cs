/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface Renderer : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<RendererCachedEntity>))]
public class RendererCachedEntity : CachedEntityObject, Renderer
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
        private HTMLCanvasElement __domElement;
        public HTMLCanvasElement domElement
        {
            get
            {
            if(__domElement == null)
            {
                __domElement = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "domElement",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __domElement;
            }
            set
            {
__domElement = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "domElement",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public RendererCachedEntity() : base() { }

        public RendererCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public void render(Object3D scene, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, scene, camera
                }
            );
        }

        public void setSize(decimal width, decimal height, System.Nullable<bool> updateStyle = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, updateStyle
                }
            );
        }
    #endregion
}
