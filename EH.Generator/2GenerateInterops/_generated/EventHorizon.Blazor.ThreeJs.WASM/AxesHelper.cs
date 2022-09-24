/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AxesHelper>))]
public class AxesHelper : LineSegments
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
        public AxesHelper() : base() { }

        public AxesHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AxesHelper(
            System.Nullable<decimal> size = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AxesHelper" },
                size
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public AxesHelper setColors(Color xAxisColor, Color yAxisColor, Color zAxisColor)
        {
            return EventHorizonBlazorInterop.FuncClass<AxesHelper>(
                entity => new AxesHelper() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColors" }, xAxisColor, yAxisColor, zAxisColor
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
    #endregion
}
