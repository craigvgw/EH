/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ICubeResourceOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ICubeResourceOptionsCachedEntity>))]
public class ICubeResourceOptionsCachedEntity : CachedEntityObject, ICubeResourceOptions
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
        
        public bool autoLoad
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoLoad"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoLoad",
                    value
                );
            }
        }

        
        public bool linkBaseTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "linkBaseTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linkBaseTexture",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ICubeResourceOptionsCachedEntity() : base() { }

        public ICubeResourceOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
