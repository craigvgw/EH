/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IRendererOptionsAuto : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IRendererOptionsAutoCachedEntity>))]
public class IRendererOptionsAutoCachedEntity : CachedEntityObject, IRendererOptionsAuto
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
        
        public bool forceCanvas
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceCanvas"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceCanvas",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IRendererOptionsAutoCachedEntity() : base() { }

        public IRendererOptionsAutoCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
