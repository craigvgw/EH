/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<StringKeyframeTrack>))]
public class StringKeyframeTrack : KeyframeTrack
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
        
        public string ValueTypeName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "ValueTypeName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ValueTypeName",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public StringKeyframeTrack() : base() { }

        public StringKeyframeTrack(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public StringKeyframeTrack(
            string name, CachedEntity[] times, CachedEntity[] values, System.Nullable<int> interpolation = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "StringKeyframeTrack" },
                name, times, values, interpolation
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
