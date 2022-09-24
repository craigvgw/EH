/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<FilterState>))]
public class FilterState : CachedEntityObject
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
        private RenderTexture __renderTexture;
        public RenderTexture renderTexture
        {
            get
            {
            if(__renderTexture == null)
            {
                __renderTexture = EventHorizonBlazorInterop.GetClass<RenderTexture>(
                    this.___guid,
                    "renderTexture",
                    (entity) =>
                    {
                        return new RenderTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderTexture;
            }
            set
            {
__renderTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTexture",
                    value
                );
            }
        }

        private IFilterTargetCachedEntity __target;
        public IFilterTargetCachedEntity target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<IFilterTargetCachedEntity>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new IFilterTargetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
            }
            set
            {
__target = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        
        public bool legacy
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "legacy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "legacy",
                    value
                );
            }
        }

        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolution",
                    value
                );
            }
        }

        
        public int multisample
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "multisample"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multisample",
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
            set
            {
__sourceFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceFrame",
                    value
                );
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
            set
            {
__destinationFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "destinationFrame",
                    value
                );
            }
        }

        private Rectangle __bindingSourceFrame;
        public Rectangle bindingSourceFrame
        {
            get
            {
            if(__bindingSourceFrame == null)
            {
                __bindingSourceFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "bindingSourceFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __bindingSourceFrame;
            }
            set
            {
__bindingSourceFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bindingSourceFrame",
                    value
                );
            }
        }

        private Rectangle __bindingDestinationFrame;
        public Rectangle bindingDestinationFrame
        {
            get
            {
            if(__bindingDestinationFrame == null)
            {
                __bindingDestinationFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "bindingDestinationFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __bindingDestinationFrame;
            }
            set
            {
__bindingDestinationFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bindingDestinationFrame",
                    value
                );
            }
        }

        
        public Filter[] filters
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Filter>(
                    this.___guid,
                    "filters",
                    (entity) =>
                    {
                        return new Filter() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filters",
                    value
                );
            }
        }

        private Matrix __transform;
        public Matrix transform
        {
            get
            {
            if(__transform == null)
            {
                __transform = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "transform",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __transform;
            }
            set
            {
__transform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transform",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public FilterState() : base() { }

        public FilterState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }
    #endregion
}
