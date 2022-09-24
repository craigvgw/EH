/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IGraphicsBatchElement : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IGraphicsBatchElementCachedEntity>))]
public class IGraphicsBatchElementCachedEntity : CachedEntityObject, IGraphicsBatchElement
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
        
        public decimal[] vertexData
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "vertexData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexData",
                    value
                );
            }
        }

        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }

        private Uint16Array __indices;
        public Uint16Array indices
        {
            get
            {
            if(__indices == null)
            {
                __indices = EventHorizonBlazorInterop.GetClass<Uint16Array>(
                    this.___guid,
                    "indices",
                    (entity) =>
                    {
                        return new Uint16Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __indices;
            }
            set
            {
__indices = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indices",
                    value
                );
            }
        }

        
        public decimal[] uvs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
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
    #endregion
    
    #region Constructor
        public IGraphicsBatchElementCachedEntity() : base() { }

        public IGraphicsBatchElementCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
