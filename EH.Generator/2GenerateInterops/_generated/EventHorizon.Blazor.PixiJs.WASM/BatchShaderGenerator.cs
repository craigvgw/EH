/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BatchShaderGenerator>))]
public class BatchShaderGenerator : CachedEntityObject
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
        
        public string vertexSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vertexSrc"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexSrc",
                    value
                );
            }
        }

        
        public string fragTemplate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fragTemplate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fragTemplate",
                    value
                );
            }
        }

        
        public CachedEntity programCache
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "programCache",
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
                    "programCache",
                    value
                );
            }
        }

        
        public CachedEntity defaultGroupCache
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "defaultGroupCache",
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
                    "defaultGroupCache",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BatchShaderGenerator() : base() { }

        public BatchShaderGenerator(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BatchShaderGenerator(
            string vertexSrc, string fragTemplate
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BatchShaderGenerator" },
                vertexSrc, fragTemplate
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Shader generateShader(decimal maxTextures)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateShader" }, maxTextures
                }
            );
        }

        public string generateSampleSrc(decimal maxTextures)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "generateSampleSrc" }, maxTextures
                }
            );
        }
    #endregion
}
