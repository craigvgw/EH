/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ContextSystem>))]
public class ContextSystem : CachedEntityObject, ISystem
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public bool isLost
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLost"
                );
            }
        }
    #endregion

    #region Properties
        
        public decimal webGLVersion
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "webGLVersion"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "webGLVersion",
                    value
                );
            }
        }

        private ISupportDictCachedEntity __supports;
        public ISupportDictCachedEntity supports
        {
            get
            {
            if(__supports == null)
            {
                __supports = EventHorizonBlazorInterop.GetClass<ISupportDictCachedEntity>(
                    this.___guid,
                    "supports",
                    (entity) =>
                    {
                        return new ISupportDictCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __supports;
            }
        }

        private WebGLExtensionsCachedEntity __extensions;
        public WebGLExtensionsCachedEntity extensions
        {
            get
            {
            if(__extensions == null)
            {
                __extensions = EventHorizonBlazorInterop.GetClass<WebGLExtensionsCachedEntity>(
                    this.___guid,
                    "extensions",
                    (entity) =>
                    {
                        return new WebGLExtensionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __extensions;
            }
            set
            {
__extensions = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "extensions",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ContextSystem() : base() { }

        public ContextSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ContextSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ContextSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void initFromContext(IRenderingContext gl)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initFromContext" }, gl
                }
            );
        }

        public void initFromOptions(WebGLContextAttributes options)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initFromOptions" }, options
                }
            );
        }

        public IRenderingContextCachedEntity createContext(HTMLCanvasElement canvas, WebGLContextAttributes options)
        {
            return EventHorizonBlazorInterop.FuncClass<IRenderingContextCachedEntity>(
                entity => new IRenderingContextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createContext" }, canvas, options
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
