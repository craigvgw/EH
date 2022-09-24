/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IVideoResourceOptionsElement : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IVideoResourceOptionsElementCachedEntity>))]
public class IVideoResourceOptionsElementCachedEntity : CachedEntityObject, IVideoResourceOptionsElement
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
        
        public string src
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "src"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "src",
                    value
                );
            }
        }

        
        public string mime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "mime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mime",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IVideoResourceOptionsElementCachedEntity() : base() { }

        public IVideoResourceOptionsElementCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
