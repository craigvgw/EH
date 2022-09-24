/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BatchPart>))]
public class BatchPart : CachedEntityObject
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
        private LineStyle __style;
        public LineStyle style
        {
            get
            {
            if(__style == null)
            {
                __style = EventHorizonBlazorInterop.GetClass<LineStyle>(
                    this.___guid,
                    "style",
                    (entity) =>
                    {
                        return new LineStyle() { ___guid = entity.___guid };
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

        
        public decimal attribStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "attribStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attribStart",
                    value
                );
            }
        }

        
        public decimal attribSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "attribSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attribSize",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BatchPart() : base() { }

        public BatchPart(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public void begin(LineStyle style, decimal startIndex, decimal attribStart)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "begin" }, style, startIndex, attribStart
                }
            );
        }

        public void end(decimal endIndex, decimal endAttrib)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }, endIndex, endAttrib
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }
    #endregion
}
