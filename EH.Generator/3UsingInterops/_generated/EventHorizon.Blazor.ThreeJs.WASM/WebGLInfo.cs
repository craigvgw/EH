/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLInfo>))]
public class WebGLInfo : CachedEntityObject
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
        
        public bool autoReset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoReset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoReset",
                    value
                );
            }
        }

        
        public CachedEntity memory
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "memory",
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
                    "memory",
                    value
                );
            }
        }

        
        public WebGLProgram[] programs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<WebGLProgram>(
                    this.___guid,
                    "programs",
                    (entity) =>
                    {
                        return new WebGLProgram() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "programs",
                    value
                );
            }
        }

        
        public CachedEntity render
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "render",
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
                    "render",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLInfo() : base() { }

        public WebGLInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLInfo(
            WebGLRenderingContext gl
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLInfo" },
                gl
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update(decimal count, decimal mode, decimal instanceCount)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, count, mode, instanceCount
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
