/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MeshBatchUvs>))]
public class MeshBatchUvs : CachedEntityObject
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
        
        public decimal[] data
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "data"
                );
            }
        }

        private Buffer_2 __uvBuffer;
        public Buffer_2 uvBuffer
        {
            get
            {
            if(__uvBuffer == null)
            {
                __uvBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "uvBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __uvBuffer;
            }
            set
            {
__uvBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvBuffer",
                    value
                );
            }
        }

        private TextureMatrix __uvMatrix;
        public TextureMatrix uvMatrix
        {
            get
            {
            if(__uvMatrix == null)
            {
                __uvMatrix = EventHorizonBlazorInterop.GetClass<TextureMatrix>(
                    this.___guid,
                    "uvMatrix",
                    (entity) =>
                    {
                        return new TextureMatrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __uvMatrix;
            }
            set
            {
__uvMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvMatrix",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MeshBatchUvs() : base() { }

        public MeshBatchUvs(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public MeshBatchUvs(
            Buffer_2 uvBuffer, TextureMatrix uvMatrix
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MeshBatchUvs" },
                uvBuffer, uvMatrix
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update(System.Nullable<bool> forceUpdate = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, forceUpdate
                }
            );
        }
    #endregion
}
