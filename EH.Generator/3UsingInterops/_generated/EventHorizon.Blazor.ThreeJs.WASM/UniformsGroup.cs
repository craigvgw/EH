/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<UniformsGroup>))]
public class UniformsGroup : EventDispatcher
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
        
        public unknown isUniformsGroup
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isUniformsGroup"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isUniformsGroup",
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

        
        public int usage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "usage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "usage",
                    value
                );
            }
        }

        
        public Uniform[] uniforms
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Uniform>(
                    this.___guid,
                    "uniforms",
                    (entity) =>
                    {
                        return new Uniform() { ___guid = entity.___guid };
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
    #endregion
    
    #region Constructor
        public UniformsGroup() : base() { }

        public UniformsGroup(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public UniformsGroup add(Uniform uniform)
        {
            return EventHorizonBlazorInterop.FuncClass<UniformsGroup>(
                entity => new UniformsGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, uniform
                }
            );
        }

        public UniformsGroup remove(Uniform uniform)
        {
            return EventHorizonBlazorInterop.FuncClass<UniformsGroup>(
                entity => new UniformsGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, uniform
                }
            );
        }

        public UniformsGroup setName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<UniformsGroup>(
                entity => new UniformsGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setName" }, name
                }
            );
        }

        public UniformsGroup setUsage(int value)
        {
            return EventHorizonBlazorInterop.FuncClass<UniformsGroup>(
                entity => new UniformsGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUsage" }, value
                }
            );
        }

        public UniformsGroup dispose()
        {
            return EventHorizonBlazorInterop.FuncClass<UniformsGroup>(
                entity => new UniformsGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public UniformsGroup copy(UniformsGroup source)
        {
            return EventHorizonBlazorInterop.FuncClass<UniformsGroup>(
                entity => new UniformsGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }

        public UniformsGroup clone()
        {
            return EventHorizonBlazorInterop.FuncClass<UniformsGroup>(
                entity => new UniformsGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
    #endregion
}
