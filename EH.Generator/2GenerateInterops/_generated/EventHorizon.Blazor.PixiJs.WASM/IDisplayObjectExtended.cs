/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IDisplayObjectExtended : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IDisplayObjectExtendedCachedEntity>))]
public class IDisplayObjectExtendedCachedEntity : CachedEntityObject, IDisplayObjectExtended
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
        private TextStyle __style;
        public TextStyle style
        {
            get
            {
            if(__style == null)
            {
                __style = EventHorizonBlazorInterop.GetClass<TextStyle>(
                    this.___guid,
                    "style",
                    (entity) =>
                    {
                        return new TextStyle() { ___guid = entity.___guid };
                    }
                );
            }
            return __style;
            }
            set
            {
__style = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "style",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IDisplayObjectExtendedCachedEntity() : base() { }

        public IDisplayObjectExtendedCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
