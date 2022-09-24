/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ISpritesheetFrameData : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ISpritesheetFrameDataCachedEntity>))]
public class ISpritesheetFrameDataCachedEntity : CachedEntityObject, ISpritesheetFrameData
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
        
        public CachedEntity frame
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "frame",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public bool trimmed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "trimmed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trimmed",
                    value
                );
            }
        }

        
        public bool rotated
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rotated"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotated",
                    value
                );
            }
        }

        
        public CachedEntity sourceSize
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "sourceSize",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceSize",
                    value
                );
            }
        }

        
        public CachedEntity spriteSourceSize
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "spriteSourceSize",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spriteSourceSize",
                    value
                );
            }
        }

        private IPointDataCachedEntity __anchor;
        public IPointDataCachedEntity anchor
        {
            get
            {
            if(__anchor == null)
            {
                __anchor = EventHorizonBlazorInterop.GetClass<IPointDataCachedEntity>(
                    this.___guid,
                    "anchor",
                    (entity) =>
                    {
                        return new IPointDataCachedEntity() { ___guid = entity.___guid };
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
        public ISpritesheetFrameDataCachedEntity() : base() { }

        public ISpritesheetFrameDataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
