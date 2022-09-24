/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IBatchFactoryOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IBatchFactoryOptionsCachedEntity>))]
public class IBatchFactoryOptionsCachedEntity : CachedEntityObject, IBatchFactoryOptions
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
        
        public string vertex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vertex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertex",
                    value
                );
            }
        }

        
        public string fragment
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fragment"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fragment",
                    value
                );
            }
        }

        private BatchGeometry __geometryClass;
        public BatchGeometry geometryClass
        {
            get
            {
            if(__geometryClass == null)
            {
                __geometryClass = EventHorizonBlazorInterop.GetClass<BatchGeometry>(
                    this.___guid,
                    "geometryClass",
                    (entity) =>
                    {
                        return new BatchGeometry() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometryClass;
            }
            set
            {
__geometryClass = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometryClass",
                    value
                );
            }
        }

        
        public decimal vertexSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vertexSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexSize",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IBatchFactoryOptionsCachedEntity() : base() { }

        public IBatchFactoryOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
