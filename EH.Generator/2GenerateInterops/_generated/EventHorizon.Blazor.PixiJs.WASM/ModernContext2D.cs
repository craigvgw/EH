/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ModernContext2D : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ModernContext2DCachedEntity>))]
public class ModernContext2DCachedEntity : CachedEntityObject, ModernContext2D
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
        
        public decimal textLetterSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textLetterSpacing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textLetterSpacing",
                    value
                );
            }
        }

        
        public decimal letterSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "letterSpacing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "letterSpacing",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ModernContext2DCachedEntity() : base() { }

        public ModernContext2DCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
