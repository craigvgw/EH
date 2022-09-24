/// Generated - Do Not Edit
namespace Phaser.Tilemaps
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ImageCollection>))]
    public class ImageCollection : CachedEntityObject
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public decimal firstgid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "firstgid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "firstgid",
                    value
                );
            }
        }

        
        public decimal imageWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "imageWidth"
                );
            }
        }

        
        public decimal imageHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "imageHeight"
                );
            }
        }

        
        public decimal imageMarge
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "imageMarge"
                );
            }
        }

        
        public decimal imageSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "imageSpacing"
                );
            }
        }

        
        public CachedEntity properties
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "properties"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "properties",
                    value
                );
            }
        }

        
        public CachedEntity[] images
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "images",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public decimal total
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ImageCollection() : base() { }

        public ImageCollection(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ImageCollection(
            string name, decimal firstgid, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> margin = null, System.Nullable<decimal> spacing = null, object properties = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tilemaps", "ImageCollection" },
                name, firstgid, width, height, margin, spacing, properties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool containsImageIndex(decimal imageIndex)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsImageIndex" }, imageIndex
                }
            );
        }

        public ImageCollection addImage(decimal gid, string image)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageCollection>(
                entity => new ImageCollection() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addImage" }, gid, image
                }
            );
        }
        #endregion
    }
}