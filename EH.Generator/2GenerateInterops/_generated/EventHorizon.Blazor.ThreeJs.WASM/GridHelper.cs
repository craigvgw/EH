/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<GridHelper>))]
public class GridHelper : LineSegments
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
        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
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
    #endregion
    
    #region Constructor
        public GridHelper() : base() { }

        public GridHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public GridHelper(
            System.Nullable<decimal> size = null, System.Nullable<decimal> divisions = null, Color color1 = null, Color color2 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "GridHelper" },
                size, divisions, color1, color2
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setColors(Color color1 = null, Color color2 = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColors" }, color1, color2
                }
            );
        }
    #endregion
}
