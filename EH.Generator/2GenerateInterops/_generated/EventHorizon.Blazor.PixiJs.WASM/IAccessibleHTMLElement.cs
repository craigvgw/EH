/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IAccessibleHTMLElement : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IAccessibleHTMLElementCachedEntity>))]
public class IAccessibleHTMLElementCachedEntity : CachedEntityObject, IAccessibleHTMLElement
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

        private DisplayObject __displayObject;
        public DisplayObject displayObject
        {
            get
            {
            if(__displayObject == null)
            {
                __displayObject = EventHorizonBlazorInterop.GetClass<DisplayObject>(
                    this.___guid,
                    "displayObject",
                    (entity) =>
                    {
                        return new DisplayObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __displayObject;
            }
            set
            {
__displayObject = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayObject",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IAccessibleHTMLElementCachedEntity() : base() { }

        public IAccessibleHTMLElementCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
