/// Generated - Do Not Edit
namespace Phaser.GameObjects.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface ITextureCrop : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ITextureCropCachedEntity>))]
    public class ITextureCropCachedEntity : CachedEntityObject, ITextureCrop
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

        private Frame __frame;
        public Frame frame
        {
            get
            {
            if(__frame == null)
            {
                __frame = EventHorizonBlazorInterop.GetClass<Frame>(
                    this.___guid,
                    "frame",
                    (entity) =>
                    {
                        return new Frame() { ___guid = entity.___guid };
                    }
                );
            }
            return __frame;
            }
            set
            {
__frame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public bool isCropped
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isCropped"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isCropped",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ITextureCropCachedEntity() : base() { }

        public ITextureCropCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ITextureCropCachedEntity setCrop(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITextureCropCachedEntity>(
                entity => new ITextureCropCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCrop" }, x, y, width, height
                }
            );
        }

        public ITextureCropCachedEntity setTexture(string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITextureCropCachedEntity>(
                entity => new ITextureCropCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, key, frame
                }
            );
        }

        public ITextureCropCachedEntity setFrame(string frame, System.Nullable<bool> updateSize = null, System.Nullable<bool> updateOrigin = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ITextureCropCachedEntity>(
                entity => new ITextureCropCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frame, updateSize, updateOrigin
                }
            );
        }
        #endregion
    }
}