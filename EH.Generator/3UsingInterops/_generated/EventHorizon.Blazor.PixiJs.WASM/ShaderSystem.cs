/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ShaderSystem>))]
public class ShaderSystem : CachedEntityObject, ISystem
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
        private Shader __shader;
        public Shader shader
        {
            get
            {
            if(__shader == null)
            {
                __shader = EventHorizonBlazorInterop.GetClass<Shader>(
                    this.___guid,
                    "shader",
                    (entity) =>
                    {
                        return new Shader() { ___guid = entity.___guid };
                    }
                );
            }
            return __shader;
            }
            set
            {
__shader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shader",
                    value
                );
            }
        }

        private Program __program;
        public Program program
        {
            get
            {
            if(__program == null)
            {
                __program = EventHorizonBlazorInterop.GetClass<Program>(
                    this.___guid,
                    "program",
                    (entity) =>
                    {
                        return new Program() { ___guid = entity.___guid };
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

        
        public bool destroyed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "destroyed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "destroyed",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ShaderSystem() : base() { }

        public ShaderSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ShaderSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ShaderSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void systemCheck()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "systemCheck" }
                }
            );
        }

        public GLProgram bind(Shader shader, System.Nullable<bool> dontSync = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GLProgram>(
                entity => new GLProgram() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bind" }, shader, dontSync
                }
            );
        }

        public void setUniforms(CachedEntity uniforms)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setUniforms" }, uniforms
                }
            );
        }

        public void syncUniformGroup(UniformGroup group, object syncData = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncUniformGroup" }, group, syncData
                }
            );
        }

        public void syncUniforms(UniformGroup group, GLProgram glProgram, object syncData)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncUniforms" }, group, glProgram, syncData
                }
            );
        }

        public ActionCallback<CachedEntity[]> createSyncGroups(UniformGroup group)
        {
            return EventHorizonBlazorInterop.Func<ActionCallback<CachedEntity[]>>(
                new object[]
                {
                    new string[] { this.___guid, "createSyncGroups" }, group
                }
            );
        }

        public void syncUniformBufferGroup(UniformGroup group, string name = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncUniformBufferGroup" }, group, name
                }
            );
        }

        public GLProgram getGlProgram()
        {
            return EventHorizonBlazorInterop.FuncClass<GLProgram>(
                entity => new GLProgram() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getGlProgram" }
                }
            );
        }

        public GLProgram generateProgram(Shader shader)
        {
            return EventHorizonBlazorInterop.FuncClass<GLProgram>(
                entity => new GLProgram() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateProgram" }, shader
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
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
