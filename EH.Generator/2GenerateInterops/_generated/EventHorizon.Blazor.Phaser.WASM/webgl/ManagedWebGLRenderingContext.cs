/// Generated - Do Not Edit
namespace spine.webgl
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ManagedWebGLRenderingContext>))]
    public class ManagedWebGLRenderingContext : CachedEntityObject
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
        private HTMLCanvasElement __canvas;
        public HTMLCanvasElement canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
            set
            {
__canvas = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvas",
                    value
                );
            }
        }

        private WebGLRenderingContext __gl;
        public WebGLRenderingContext gl
        {
            get
            {
            if(__gl == null)
            {
                __gl = EventHorizonBlazorInterop.GetClass<WebGLRenderingContext>(
                    this.___guid,
                    "gl",
                    (entity) =>
                    {
                        return new WebGLRenderingContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __gl;
            }
            set
            {
__gl = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gl",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ManagedWebGLRenderingContext() : base() { }

        public ManagedWebGLRenderingContext(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ManagedWebGLRenderingContext(
            HTMLCanvasElement canvasOrContext, object contextConfig = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "ManagedWebGLRenderingContext" },
                canvasOrContext, contextConfig
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void addRestorable(Restorable restorable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addRestorable" }, restorable
                }
            );
        }

        public void removeRestorable(Restorable restorable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeRestorable" }, restorable
                }
            );
        }
        #endregion
    }
}