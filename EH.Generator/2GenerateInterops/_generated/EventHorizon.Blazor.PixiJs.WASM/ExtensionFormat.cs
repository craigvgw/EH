/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ExtensionFormat : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ExtensionFormatCachedEntity>))]
public class ExtensionFormatCachedEntity : CachedEntityObject, ExtensionFormat
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
        
        public int[] type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
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
        public ExtensionFormatCachedEntity() : base() { }

        public ExtensionFormatCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
