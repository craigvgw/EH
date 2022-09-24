/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ISpriteMaskTarget : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ISpriteMaskTargetCachedEntity>))]
public class ISpriteMaskTargetCachedEntity : CachedEntityObject, ISpriteMaskTarget
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
        
        public decimal worldAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "worldAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldAlpha",
                    value
                );
            }
        }

        private Point __anchor;
        public Point anchor
        {
            get
            {
            if(__anchor == null)
            {
                __anchor = EventHorizonBlazorInterop.GetClass<Point>(
                    this.___guid,
                    "anchor",
                    (entity) =>
                    {
                        return new Point() { ___guid = entity.___guid };
                    }
                );
            }
            return __anchor;
            }
            set
            {
__anchor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anchor",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ISpriteMaskTargetCachedEntity() : base() { }

        public ISpriteMaskTargetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
