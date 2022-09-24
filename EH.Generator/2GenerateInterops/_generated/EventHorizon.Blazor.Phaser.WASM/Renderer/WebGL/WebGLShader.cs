/// Generated - Do Not Edit
namespace Phaser.Renderer.WebGL
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLShader>))]
    public class WebGLShader : CachedEntityObject
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
        private WebGLPipeline __pipeline;
        public WebGLPipeline pipeline
        {
            get
            {
            if(__pipeline == null)
            {
                __pipeline = EventHorizonBlazorInterop.GetClass<WebGLPipeline>(
                    this.___guid,
                    "pipeline",
                    (entity) =>
                    {
                        return new WebGLPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __pipeline;
            }
            set
            {
__pipeline = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pipeline",
                    value
                );
            }
        }

        
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

        private WebGLRenderer __renderer;
        public WebGLRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<WebGLRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new WebGLRenderer() { ___guid = entity.___guid };
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

        private WebGLProgram __program;
        public WebGLProgram program
        {
            get
            {
            if(__program == null)
            {
                __program = EventHorizonBlazorInterop.GetClass<WebGLProgram>(
                    this.___guid,
                    "program",
                    (entity) =>
                    {
                        return new WebGLProgram() { ___guid = entity.___guid };
                    }
                );
            }
            return __program;
            }
            set
            {
__program = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "program",
                    value
                );
            }
        }

        
        public WebGLPipelineAttribute[] attributes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<WebGLPipelineAttribute>(
                    this.___guid,
                    "attributes",
                    (entity) =>
                    {
                        return new WebGLPipelineAttribute() { ___guid = entity.___guid };
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

        
        public decimal vertexComponentCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vertexComponentCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexComponentCount",
                    value
                );
            }
        }

        
        public decimal vertexSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vertexSize"
                );
            }
        }

        private WebGLPipelineUniformsConfig __uniforms;
        public WebGLPipelineUniformsConfig uniforms
        {
            get
            {
            if(__uniforms == null)
            {
                __uniforms = EventHorizonBlazorInterop.GetClass<WebGLPipelineUniformsConfig>(
                    this.___guid,
                    "uniforms",
                    (entity) =>
                    {
                        return new WebGLPipelineUniformsConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __uniforms;
            }
            set
            {
__uniforms = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniforms",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebGLShader() : base() { }

        public WebGLShader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLShader(
            WebGLPipeline pipeline, string name, string vertexShader, string fragmentShader, WebGLPipelineAttributeConfig[] attributes
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "WebGLShader" },
                pipeline, name, vertexShader, fragmentShader, attributes
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void createAttributes(WebGLPipelineAttributeConfig[] attributes)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createAttributes" }, attributes
                }
            );
        }

        public WebGLShader bind(System.Nullable<bool> setAttributes = null, System.Nullable<bool> flush = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bind" }, setAttributes, flush
                }
            );
        }

        public WebGLShader rebind()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rebind" }
                }
            );
        }

        public WebGLShader setAttribPointers(System.Nullable<bool> reset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAttribPointers" }, reset
                }
            );
        }

        public WebGLShader createUniforms()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createUniforms" }
                }
            );
        }

        public bool hasUniform(string name)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasUniform" }, name
                }
            );
        }

        public WebGLShader resetUniform(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetUniform" }, name
                }
            );
        }

        public WebGLShader set1f(string name, decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1f" }, name, x
                }
            );
        }

        public WebGLShader set2f(string name, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2f" }, name, x, y
                }
            );
        }

        public WebGLShader set3f(string name, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3f" }, name, x, y, z
                }
            );
        }

        public WebGLShader set4f(string name, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4f" }, name, x, y, z, w
                }
            );
        }

        public WebGLShader set1fv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1fv" }, name, arr
                }
            );
        }

        public WebGLShader set2fv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2fv" }, name, arr
                }
            );
        }

        public WebGLShader set3fv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3fv" }, name, arr
                }
            );
        }

        public WebGLShader set4fv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4fv" }, name, arr
                }
            );
        }

        public WebGLShader set1iv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1iv" }, name, arr
                }
            );
        }

        public WebGLShader set2iv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2iv" }, name, arr
                }
            );
        }

        public WebGLShader set3iv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3iv" }, name, arr
                }
            );
        }

        public WebGLShader set4iv(string name, decimal[] arr)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4iv" }, name, arr
                }
            );
        }

        public WebGLShader set1i(string name, decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set1i" }, name, x
                }
            );
        }

        public WebGLShader set2i(string name, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set2i" }, name, x, y
                }
            );
        }

        public WebGLShader set3i(string name, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set3i" }, name, x, y, z
                }
            );
        }

        public WebGLShader set4i(string name, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set4i" }, name, x, y, z, w
                }
            );
        }

        public WebGLShader setMatrix2fv(string name, bool transpose, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix2fv" }, name, transpose, matrix
                }
            );
        }

        public WebGLShader setMatrix3fv(string name, bool transpose, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix3fv" }, name, transpose, matrix
                }
            );
        }

        public WebGLShader setMatrix4fv(string name, bool transpose, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShader>(
                entity => new WebGLShader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix4fv" }, name, transpose, matrix
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
}