/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MeshGeometry>))]
public class MeshGeometry : Geometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal vertexDirtyId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vertexDirtyId"
                );
            }
        }
    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public MeshGeometry() : base() { }

        public MeshGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MeshGeometry(
            IArrayBuffer vertices = null, IArrayBuffer uvs = null, IArrayBuffer index = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MeshGeometry" },
                vertices, uvs, index
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
