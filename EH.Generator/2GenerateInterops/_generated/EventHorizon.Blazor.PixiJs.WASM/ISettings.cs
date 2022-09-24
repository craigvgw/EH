/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ISettings : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ISettingsCachedEntity>))]
public class ISettingsCachedEntity : CachedEntityObject, ISettings
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
        private IAdapterCachedEntity __ADAPTER;
        public IAdapterCachedEntity ADAPTER
        {
            get
            {
            if(__ADAPTER == null)
            {
                __ADAPTER = EventHorizonBlazorInterop.GetClass<IAdapterCachedEntity>(
                    this.___guid,
                    "ADAPTER",
                    (entity) =>
                    {
                        return new IAdapterCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ADAPTER;
            }
            set
            {
__ADAPTER = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ADAPTER",
                    value
                );
            }
        }

        
        public int MIPMAP_TEXTURES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "MIPMAP_TEXTURES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MIPMAP_TEXTURES",
                    value
                );
            }
        }

        
        public decimal ANISOTROPIC_LEVEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ANISOTROPIC_LEVEL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ANISOTROPIC_LEVEL",
                    value
                );
            }
        }

        
        public decimal RESOLUTION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RESOLUTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RESOLUTION",
                    value
                );
            }
        }

        
        public decimal FILTER_RESOLUTION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FILTER_RESOLUTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FILTER_RESOLUTION",
                    value
                );
            }
        }

        
        public int FILTER_MULTISAMPLE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "FILTER_MULTISAMPLE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FILTER_MULTISAMPLE",
                    value
                );
            }
        }

        
        public decimal SPRITE_MAX_TEXTURES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SPRITE_MAX_TEXTURES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPRITE_MAX_TEXTURES",
                    value
                );
            }
        }

        
        public decimal SPRITE_BATCH_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SPRITE_BATCH_SIZE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPRITE_BATCH_SIZE",
                    value
                );
            }
        }

        private IRenderOptionsCachedEntity __RENDER_OPTIONS;
        public IRenderOptionsCachedEntity RENDER_OPTIONS
        {
            get
            {
            if(__RENDER_OPTIONS == null)
            {
                __RENDER_OPTIONS = EventHorizonBlazorInterop.GetClass<IRenderOptionsCachedEntity>(
                    this.___guid,
                    "RENDER_OPTIONS",
                    (entity) =>
                    {
                        return new IRenderOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __RENDER_OPTIONS;
            }
            set
            {
__RENDER_OPTIONS = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RENDER_OPTIONS",
                    value
                );
            }
        }

        
        public int GC_MODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "GC_MODE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GC_MODE",
                    value
                );
            }
        }

        
        public decimal GC_MAX_IDLE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GC_MAX_IDLE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GC_MAX_IDLE",
                    value
                );
            }
        }

        
        public decimal GC_MAX_CHECK_COUNT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GC_MAX_CHECK_COUNT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GC_MAX_CHECK_COUNT",
                    value
                );
            }
        }

        
        public int WRAP_MODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "WRAP_MODE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "WRAP_MODE",
                    value
                );
            }
        }

        
        public int SCALE_MODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "SCALE_MODE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SCALE_MODE",
                    value
                );
            }
        }

        
        public int PRECISION_VERTEX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "PRECISION_VERTEX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PRECISION_VERTEX",
                    value
                );
            }
        }

        
        public int PRECISION_FRAGMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "PRECISION_FRAGMENT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PRECISION_FRAGMENT",
                    value
                );
            }
        }

        
        public bool CAN_UPLOAD_SAME_BUFFER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CAN_UPLOAD_SAME_BUFFER"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CAN_UPLOAD_SAME_BUFFER",
                    value
                );
            }
        }

        
        public bool CREATE_IMAGE_BITMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CREATE_IMAGE_BITMAP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CREATE_IMAGE_BITMAP",
                    value
                );
            }
        }

        
        public bool ROUND_PIXELS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ROUND_PIXELS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ROUND_PIXELS",
                    value
                );
            }
        }

        private RegExp __RETINA_PREFIX;
        public RegExp RETINA_PREFIX
        {
            get
            {
            if(__RETINA_PREFIX == null)
            {
                __RETINA_PREFIX = EventHorizonBlazorInterop.GetClass<RegExp>(
                    this.___guid,
                    "RETINA_PREFIX",
                    (entity) =>
                    {
                        return new RegExp() { ___guid = entity.___guid };
                    }
                );
            }
            return __RETINA_PREFIX;
            }
            set
            {
__RETINA_PREFIX = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RETINA_PREFIX",
                    value
                );
            }
        }

        
        public bool FAIL_IF_MAJOR_PERFORMANCE_CAVEAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "FAIL_IF_MAJOR_PERFORMANCE_CAVEAT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FAIL_IF_MAJOR_PERFORMANCE_CAVEAT",
                    value
                );
            }
        }

        
        public decimal UPLOADS_PER_FRAME
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UPLOADS_PER_FRAME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UPLOADS_PER_FRAME",
                    value
                );
            }
        }

        
        public bool SORTABLE_CHILDREN
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SORTABLE_CHILDREN"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SORTABLE_CHILDREN",
                    value
                );
            }
        }

        
        public int PREFER_ENV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "PREFER_ENV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PREFER_ENV",
                    value
                );
            }
        }

        
        public bool STRICT_TEXTURE_CACHE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "STRICT_TEXTURE_CACHE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "STRICT_TEXTURE_CACHE",
                    value
                );
            }
        }

        
        public decimal MESH_CANVAS_PADDING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MESH_CANVAS_PADDING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MESH_CANVAS_PADDING",
                    value
                );
            }
        }

        
        public decimal TARGET_FPMS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TARGET_FPMS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TARGET_FPMS",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ISettingsCachedEntity() : base() { }

        public ISettingsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
