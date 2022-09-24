/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<RenderTextureSystem>))]
public class RenderTextureSystem : CachedEntityObject, ISystem
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
        
        public decimal[] clearColor
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "clearColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
            }
        }

        
        public MaskData[] defaultMaskStack
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<MaskData>(
                    this.___guid,
                    "defaultMaskStack",
                    (entity) =>
                    {
                        return new MaskData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultMaskStack",
                    value
                );
            }
        }

        private RenderTexture __current;
        public RenderTexture current
        {
            get
            {
            if(__current == null)
            {
                __current = EventHorizonBlazorInterop.GetClass<RenderTexture>(
                    this.___guid,
                    "current",
                    (entity) =>
                    {
                        return new RenderTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __current;
            }
            set
            {
__current = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "current",
                    value
                );
            }
        }

        private Rectangle __sourceFrame;
        public Rectangle sourceFrame
        {
            get
            {
            if(__sourceFrame == null)
            {
                __sourceFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "sourceFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __sourceFrame;
            }
        }

        private Rectangle __destinationFrame;
        public Rectangle destinationFrame
        {
            get
            {
            if(__destinationFrame == null)
            {
                __destinationFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "destinationFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __destinationFrame;
            }
        }

        private Rectangle __viewportFrame;
        public Rectangle viewportFrame
        {
            get
            {
            if(__viewportFrame == null)
            {
                __viewportFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "viewportFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __viewportFrame;
            }
        }
    #endregion
    
    #region Constructor
        public RenderTextureSystem() : base() { }

        public RenderTextureSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RenderTextureSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "RenderTextureSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void bind(RenderTexture renderTexture = null, Rectangle sourceFrame = null, Rectangle destinationFrame = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, renderTexture, sourceFrame, destinationFrame
                }
            );
        }

        public void clear(decimal[] clearColor = null, System.Nullable<int> mask = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, clearColor, mask
                }
            );
        }

        public void resize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }
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

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
    #endregion
}
