/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLProgram>))]
public class WebGLProgram : CachedEntityObject
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public string cacheKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "cacheKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cacheKey",
                    value
                );
            }
        }

        
        public decimal usedTimes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "usedTimes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "usedTimes",
                    value
                );
            }
        }

        
        public CachedEntity program
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "program",
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
                    "program",
                    value
                );
            }
        }

        private WebGLShader __vertexShader;
        public WebGLShader vertexShader
        {
            get
            {
            if(__vertexShader == null)
            {
                __vertexShader = EventHorizonBlazorInterop.GetClass<WebGLShader>(
                    this.___guid,
                    "vertexShader",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexShader;
            }
            set
            {
__vertexShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexShader",
                    value
                );
            }
        }

        private WebGLShader __fragmentShader;
        public WebGLShader fragmentShader
        {
            get
            {
            if(__fragmentShader == null)
            {
                __fragmentShader = EventHorizonBlazorInterop.GetClass<WebGLShader>(
                    this.___guid,
                    "fragmentShader",
                    (entity) =>
                    {
                        return new WebGLShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __fragmentShader;
            }
            set
            {
__fragmentShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fragmentShader",
                    value
                );
            }
        }

        
        public CachedEntity uniforms
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "uniforms",
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
                    "uniforms",
                    value
                );
            }
        }

        
        public CachedEntity attributes
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "attributes",
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
                    "attributes",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLProgram() : base() { }

        public WebGLProgram(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLProgram(
            WebGLRenderer renderer, string cacheKey, object parameters
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLProgram" },
                renderer, cacheKey, parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public WebGLUniforms getUniforms()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLUniforms>(
                entity => new WebGLUniforms() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUniforms" }
                }
            );
        }

        public CachedEntity getAttributes()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" }
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
