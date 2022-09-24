/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SimplePlane>))]
public class SimplePlane : Mesh
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public bool autoResize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoResize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoResize",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SimplePlane() : base() { }

        public SimplePlane(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SimplePlane(
            Texture texture, System.Nullable<decimal> verticesX = null, System.Nullable<decimal> verticesY = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SimplePlane" },
                texture, verticesX, verticesY
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void textureUpdated()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "textureUpdated" }
                }
            );
        }

        public void destroy(IDestroyOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, options
                }
            );
        }
    #endregion
}
