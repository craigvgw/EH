/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Application>))]
public class Application : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static void registerPlugin(IApplicationPlugin plugin)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "Application", "registerPlugin" }, plugin
                }
            );
        }
    #endregion

    #region Accessors
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
    #endregion

    #region Properties
        private Container __stage;
        public Container stage
        {
            get
            {
            if(__stage == null)
            {
                __stage = EventHorizonBlazorInterop.GetClass<Container>(
                    this.___guid,
                    "stage",
                    (entity) =>
                    {
                        return new Container() { ___guid = entity.___guid };
                    }
                );
            }
            return __stage;
            }
            set
            {
__stage = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stage",
                    value
                );
            }
        }

        private Renderer __renderer;
        public Renderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<Renderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new Renderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderer;
            }
            set
            {
__renderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderer",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Application() : base() { }

        public Application(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Application(
            IApplicationOptions options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Application" },
                options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void render()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public void destroy(System.Nullable<bool> removeView = null, IDestroyOptions stageOptions = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, removeView, stageOptions
                }
            );
        }
    #endregion
}
