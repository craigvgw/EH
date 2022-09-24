/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<FramebufferTexture>))]
public class FramebufferTexture : Texture
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
        
        public unknown isFramebufferTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isFramebufferTexture"
                );
            }
        }
    #endregion
    
    #region Constructor
        public FramebufferTexture() : base() { }

        public FramebufferTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FramebufferTexture(
            decimal width, decimal height, int format
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "FramebufferTexture" },
                width, height, format
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
