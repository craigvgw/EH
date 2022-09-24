/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LineSegments<CachedEntity>>))]
public class LineSegments<TGeometry, Material> : Line<TGeometry, TMaterial> where TGeometry : CachedEntity, new() where Material : CachedEntity, new()
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

        
        public unknown isLineSegments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isLineSegments"
                );
            }
        }
    #endregion
    
    #region Constructor
        public LineSegments() : base() { }

        public LineSegments(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LineSegments(
            TGeometry geometry = null, TMaterial material = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LineSegments" },
                geometry, material
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
