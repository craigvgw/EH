/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLColorBuffer>))]
public class WebGLColorBuffer : CachedEntityObject
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

    #endregion
    
    #region Constructor
        public WebGLColorBuffer() : base() { }

        public WebGLColorBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public void setMask(bool colorMask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, colorMask
                }
            );
        }

        public void setLocked(bool @lock)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLocked" }, @lock
                }
            );
        }

        public void setClear(decimal r, decimal g, decimal b, decimal a, bool premultipliedAlpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setClear" }, r, g, b, a, premultipliedAlpha
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
