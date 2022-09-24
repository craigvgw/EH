/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Prepare>))]
public class Prepare : BasePrepare
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "Prepare",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Prepare",
                    "extension",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public Prepare() : base() { }

        public Prepare(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Prepare(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Prepare" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
