/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<EdgesGeometry<CachedEntity>>))]
public class EdgesGeometry<TBufferGeometry> : BufferGeometry where TBufferGeometry : CachedEntity, new()
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

        
        public CachedEntity parameters
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parameters",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parameters",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public EdgesGeometry() : base() { }

        public EdgesGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public EdgesGeometry(
            TBufferGeometry geometry = null, System.Nullable<decimal> thresholdAngle = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "EdgesGeometry" },
                geometry, thresholdAngle
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
