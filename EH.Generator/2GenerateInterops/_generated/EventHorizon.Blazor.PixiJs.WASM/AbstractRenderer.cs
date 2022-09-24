/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AbstractRenderer>))]
public class AbstractRenderer : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
        }

        
        public decimal backgroundColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "backgroundColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backgroundColor",
                    value
                );
            }
        }

        
        public decimal backgroundAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "backgroundAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backgroundAlpha",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
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

        
        public bool clearBeforeRender
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clearBeforeRender"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearBeforeRender",
                    value
                );
            }
        }

        private IRendererOptionsCachedEntity __options;
        public IRendererOptionsCachedEntity options
        {
            get
            {
            if(__options == null)
            {
                __options = EventHorizonBlazorInterop.GetClass<IRendererOptionsCachedEntity>(
                    this.___guid,
                    "options",
                    (entity) =>
                    {
                        return new IRendererOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __options;
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
            }
        }

        private Rectangle __screen;
        public Rectangle screen
        {
            get
            {
            if(__screen == null)
            {
                __screen = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "screen",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __screen;
            }
        }

        private HTMLCanvasElement __view;
        public HTMLCanvasElement view
        {
            get
            {
            if(__view == null)
            {
                __view = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "view",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __view;
            }
        }

        private IRendererPluginsCachedEntity __plugins;
        public IRendererPluginsCachedEntity plugins
        {
            get
            {
            if(__plugins == null)
            {
                __plugins = EventHorizonBlazorInterop.GetClass<IRendererPluginsCachedEntity>(
                    this.___guid,
                    "plugins",
                    (entity) =>
                    {
                        return new IRendererPluginsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugins;
            }
        }

        
        public bool useContextAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useContextAlpha"
                );
            }
        }

        
        public bool autoDensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoDensity"
                );
            }
        }

        
        public bool preserveDrawingBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preserveDrawingBuffer"
                );
            }
        }
    #endregion
    
    #region Constructor
        public AbstractRenderer() : base() { }

        public AbstractRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AbstractRenderer(
            System.Nullable<int> type = null, IRendererOptions options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AbstractRenderer" },
                type, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void initPlugins(IRendererPlugins staticMap)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initPlugins" }, staticMap
                }
            );
        }

        public void resize(decimal desiredScreenWidth, decimal desiredScreenHeight)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, desiredScreenWidth, desiredScreenHeight
                }
            );
        }

        public RenderTexture generateTexture(IRenderableObject displayObject, IGenerateTextureOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateTexture" }, displayObject, options
                }
            );
        }

        public AbstractRenderer addSystem(ISystemConstructor ClassRef, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractRenderer>(
                entity => new AbstractRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addSystem" }, ClassRef, name
                }
            );
        }

        public void render(IRenderableObject displayObject, IRendererRenderOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, displayObject, options
                }
            );
        }

        public void destroy(System.Nullable<bool> removeView = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, removeView
                }
            );
        }
    #endregion
}
