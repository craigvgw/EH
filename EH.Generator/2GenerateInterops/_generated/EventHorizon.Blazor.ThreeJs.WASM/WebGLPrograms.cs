/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLPrograms>))]
public class WebGLPrograms : CachedEntityObject
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
        
        public WebGLProgram[] programs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<WebGLProgram>(
                    this.___guid,
                    "programs",
                    (entity) =>
                    {
                        return new WebGLProgram() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "programs",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLPrograms() : base() { }

        public WebGLPrograms(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLPrograms(
            WebGLRenderer renderer, WebGLCubeMaps cubemaps, WebGLExtensions extensions, WebGLCapabilities capabilities, WebGLBindingStates bindingStates, WebGLClipping clipping
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLPrograms" },
                renderer, cubemaps, extensions, capabilities, bindingStates, clipping
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CachedEntity getParameters(Material material, object lights, CachedEntity[] shadows, Scene scene, object @object)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getParameters" }, material, lights, shadows, scene, @object
                }
            );
        }

        public string getProgramCacheKey(object parameters)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getProgramCacheKey" }, parameters
                }
            );
        }

        public CachedEntity getUniforms(Material material)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getUniforms" }, material
                }
            );
        }

        public WebGLProgram acquireProgram(object parameters, string cacheKey)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgram>(
                entity => new WebGLProgram() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "acquireProgram" }, parameters, cacheKey
                }
            );
        }

        public void releaseProgram(WebGLProgram program)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseProgram" }, program
                }
            );
        }
    #endregion
}
