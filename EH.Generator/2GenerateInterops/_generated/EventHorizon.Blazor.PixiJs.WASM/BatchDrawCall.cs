/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BatchDrawCall>))]
public class BatchDrawCall : CachedEntityObject
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
        private BatchTextureArray __texArray;
        public BatchTextureArray texArray
        {
            get
            {
            if(__texArray == null)
            {
                __texArray = EventHorizonBlazorInterop.GetClass<BatchTextureArray>(
                    this.___guid,
                    "texArray",
                    (entity) =>
                    {
                        return new BatchTextureArray() { ___guid = entity.___guid };
                    }
                );
            }
            return __texArray;
            }
            set
            {
__texArray = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texArray",
                    value
                );
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
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

        
        public int blend
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blend"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blend",
                    value
                );
            }
        }

        
        public decimal start
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "start"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "start",
                    value
                );
            }
        }

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }

        
        public CachedEntity data
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "data",
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
                    "data",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BatchDrawCall() : base() { }

        public BatchDrawCall(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
