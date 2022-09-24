/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LineLoop<CachedEntity>>))]
public class LineLoop<TGeometry, Material> : Line<TGeometry, TMaterial> where TGeometry : CachedEntity, new() where Material : CachedEntity, new()
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
        
        public unknown type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public unknown isLineLoop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isLineLoop"
                );
            }
        }
    #endregion
    
    #region Constructor
        public LineLoop() : base() { }

        public LineLoop(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LineLoop(
            TGeometry geometry = null, TMaterial material = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LineLoop" },
                geometry, material
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
