/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SimpleRope>))]
public class SimpleRope : Mesh
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
        
        public bool autoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoUpdate",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SimpleRope() : base() { }

        public SimpleRope(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SimpleRope(
            Texture texture, IPoint[] points, System.Nullable<decimal> textureScale = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SimpleRope" },
                texture, points, textureScale
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
