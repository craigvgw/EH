/// Generated - Do Not Edit
namespace spine.webgl
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TexCoordAttribute>))]
    public class TexCoordAttribute : VertexAttribute
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
        public TexCoordAttribute() : base() { }

        public TexCoordAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TexCoordAttribute(
            System.Nullable<decimal> unit = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "TexCoordAttribute" },
                unit
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}