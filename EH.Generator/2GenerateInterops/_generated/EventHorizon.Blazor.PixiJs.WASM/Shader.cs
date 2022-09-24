/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Shader>))]
public class Shader : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Shader from(string vertexSrc = null, string fragmentSrc = null, CachedEntity uniforms = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Shader", "from" }, vertexSrc, fragmentSrc, uniforms
                }
            );
        }
    #endregion

    #region Accessors
        
        public CachedEntity uniforms
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "uniforms"
                );
            }
        }
    #endregion

    #region Properties
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

        private UniformGroup __uniformGroup;
        public UniformGroup uniformGroup
        {
            get
            {
            if(__uniformGroup == null)
            {
                __uniformGroup = EventHorizonBlazorInterop.GetClass<UniformGroup>(
                    this.___guid,
                    "uniformGroup",
                    (entity) =>
                    {
                        return new UniformGroup() { ___guid = entity.___guid };
                    }
                );
            }
            return __uniformGroup;
            }
            set
            {
__uniformGroup = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniformGroup",
                    value
                );
            }
        }

        
        public decimal uniformBindCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniformBindCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniformBindCount",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Shader() : base() { }

        public Shader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Shader(
            Program program, CachedEntity uniforms = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Shader" },
                program, uniforms
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public bool checkUniformExists(string name, UniformGroup group)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "checkUniformExists" }, name, group
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
