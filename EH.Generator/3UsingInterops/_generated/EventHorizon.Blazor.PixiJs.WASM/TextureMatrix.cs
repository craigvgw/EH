/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TextureMatrix>))]
public class TextureMatrix : CachedEntityObject
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
        private Matrix __mapCoord;
        public Matrix mapCoord
        {
            get
            {
            if(__mapCoord == null)
            {
                __mapCoord = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "mapCoord",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __mapCoord;
            }
            set
            {
__mapCoord = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mapCoord",
                    value
                );
            }
        }

        
        public decimal clampOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clampOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clampOffset",
                    value
                );
            }
        }

        
        public decimal clampMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clampMargin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clampMargin",
                    value
                );
            }
        }

        
        public decimal[] uClampFrame
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uClampFrame"
                );
            }
        }

        
        public decimal[] uClampOffset
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uClampOffset"
                );
            }
        }

        
        public bool isSimple
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSimple"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isSimple",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public TextureMatrix() : base() { }

        public TextureMatrix(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TextureMatrix(
            Texture texture, System.Nullable<decimal> clampMargin = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TextureMatrix" },
                texture, clampMargin
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public decimal[] multiplyUvs(decimal[] uvs, decimal[] outPixi = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "multiplyUvs" }, uvs, outPixi
                }
            );
        }

        public bool update(System.Nullable<bool> forceUpdate = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, forceUpdate
                }
            );
        }
    #endregion
}
