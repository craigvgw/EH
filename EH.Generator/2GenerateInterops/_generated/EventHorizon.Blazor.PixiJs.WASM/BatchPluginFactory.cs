/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BatchPluginFactory>))]
public class BatchPluginFactory : CachedEntityObject
{
    #region Static Accessors
        
        public static string defaultVertexSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BatchPluginFactory",
                    "defaultVertexSrc"
                );
            }
        }

        
        public static string defaultFragmentTemplate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BatchPluginFactory",
                    "defaultFragmentTemplate"
                );
            }
        }
    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static AbstractBatchRenderer create(IBatchFactoryOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractBatchRenderer>(
                entity => new AbstractBatchRenderer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BatchPluginFactory", "create" }, options
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public BatchPluginFactory() : base() { }

        public BatchPluginFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
