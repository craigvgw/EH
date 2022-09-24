/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLCubeUVMaps>))]
public class WebGLCubeUVMaps : CachedEntityObject
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
        
        public void Texture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<void>(
                    this.___guid,
                    "Texture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "Texture",
                    value
                );
            }
        }

        
        public void T
        {
            get
            {
            return EventHorizonBlazorInterop.Get<void>(
                    this.___guid,
                    "T"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "T",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLCubeUVMaps() : base() { }

        public WebGLCubeUVMaps(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLCubeUVMaps(
            WebGLRenderer renderer
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLCubeUVMaps" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public unknown get<T>(T texture)
        {
            return EventHorizonBlazorInterop.Func<unknown>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, texture
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
    #endregion
}
