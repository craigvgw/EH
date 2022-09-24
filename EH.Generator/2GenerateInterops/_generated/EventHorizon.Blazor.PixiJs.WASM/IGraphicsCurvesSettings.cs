/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IGraphicsCurvesSettings : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IGraphicsCurvesSettingsCachedEntity>))]
public class IGraphicsCurvesSettingsCachedEntity : CachedEntityObject, IGraphicsCurvesSettings
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
        
        public bool adaptive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "adaptive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "adaptive",
                    value
                );
            }
        }

        
        public decimal maxLength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLength"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxLength",
                    value
                );
            }
        }

        
        public decimal minSegments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minSegments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minSegments",
                    value
                );
            }
        }

        
        public decimal maxSegments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSegments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSegments",
                    value
                );
            }
        }

        
        public decimal epsilon
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "epsilon"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "epsilon",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IGraphicsCurvesSettingsCachedEntity() : base() { }

        public IGraphicsCurvesSettingsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
