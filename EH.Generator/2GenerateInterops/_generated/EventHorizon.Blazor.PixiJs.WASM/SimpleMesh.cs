/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SimpleMesh>))]
public class SimpleMesh : Mesh
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private ITypedArrayCachedEntity __vertices;
        public ITypedArrayCachedEntity vertices
        {
            get
            {
            if(__vertices == null)
            {
                __vertices = EventHorizonBlazorInterop.GetClass<ITypedArrayCachedEntity>(
                    this.___guid,
                    "vertices",
                    (entity) =>
                    {
                        return new ITypedArrayCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertices;
            }
            set
            {
__vertices = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public bool autoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoUpdate",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SimpleMesh() : base() { }

        public SimpleMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SimpleMesh(
            Texture texture = null, IArrayBuffer vertices = null, IArrayBuffer uvs = null, IArrayBuffer indices = null, System.Nullable<int> drawMode = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SimpleMesh" },
                texture, vertices, uvs, indices, drawMode
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
