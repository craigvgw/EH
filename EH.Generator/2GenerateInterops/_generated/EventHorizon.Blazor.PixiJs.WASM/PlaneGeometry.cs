/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PlaneGeometry>))]
public class PlaneGeometry : MeshGeometry
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
        
        public decimal segWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "segWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "segWidth",
                    value
                );
            }
        }

        
        public decimal segHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "segHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "segHeight",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public PlaneGeometry() : base() { }

        public PlaneGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PlaneGeometry(
            System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> segWidth = null, System.Nullable<decimal> segHeight = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PlaneGeometry" },
                width, height, segWidth, segHeight
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void build()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "build" }
                }
            );
        }
    #endregion
}
