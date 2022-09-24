/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Sprite>))]
public class Sprite : Container
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Sprite from(TextureSource source, IBaseTextureOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Sprite>(
                entity => new Sprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Sprite", "from" }, source, options
                }
            );
        }
    #endregion

    #region Accessors
        
        public bool roundPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "roundPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roundPixels",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        private ObservablePoint __anchor;
        public ObservablePoint anchor
        {
            get
            {
            if(__anchor == null)
            {
                __anchor = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "anchor",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __anchor;
            }
            set
            {
__anchor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anchor",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

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
        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }

        private Uint16Array __indices;
        public Uint16Array indices
        {
            get
            {
            if(__indices == null)
            {
                __indices = EventHorizonBlazorInterop.GetClass<Uint16Array>(
                    this.___guid,
                    "indices",
                    (entity) =>
                    {
                        return new Uint16Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __indices;
            }
            set
            {
__indices = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indices",
                    value
                );
            }
        }

        
        public string pluginName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pluginName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pluginName",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Sprite() : base() { }

        public Sprite(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Sprite(
            Texture texture = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Sprite" },
                texture
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void calculateVertices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateVertices" }
                }
            );
        }

        public void calculateTrimmedVertices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateTrimmedVertices" }
                }
            );
        }

        public Rectangle getLocalBounds(Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalBounds" }, rect
                }
            );
        }

        public bool containsPoint(IPointData point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
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
