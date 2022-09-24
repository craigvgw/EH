/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<RawShaderMaterial>))]
public class RawShaderMaterial : ShaderMaterial
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

    #endregion
    
    #region Constructor
        public RawShaderMaterial() : base() { }

        public RawShaderMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RawShaderMaterial(
            ShaderMaterialParameters parameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "RawShaderMaterial" },
                parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
