/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PerspectiveCamera>))]
public class PerspectiveCamera : Camera
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
        
        public unknown type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public unknown isPerspectiveCamera
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isPerspectiveCamera"
                );
            }
        }

        
        public decimal zoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoom",
                    value
                );
            }
        }

        
        public decimal fov
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fov"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fov",
                    value
                );
            }
        }

        
        public decimal aspect
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aspect"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aspect",
                    value
                );
            }
        }

        
        public decimal near
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "near"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "near",
                    value
                );
            }
        }

        
        public decimal far
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "far"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "far",
                    value
                );
            }
        }

        
        public decimal focus
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "focus"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "focus",
                    value
                );
            }
        }

        
        public CachedEntity view
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "view",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "view",
                    value
                );
            }
        }

        
        public decimal filmGauge
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "filmGauge"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filmGauge",
                    value
                );
            }
        }

        
        public decimal filmOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "filmOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filmOffset",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public PerspectiveCamera() : base() { }

        public PerspectiveCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PerspectiveCamera(
            System.Nullable<decimal> fov = null, System.Nullable<decimal> aspect = null, System.Nullable<decimal> near = null, System.Nullable<decimal> far = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PerspectiveCamera" },
                fov, aspect, near, far
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setFocalLength(decimal focalLength)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFocalLength" }, focalLength
                }
            );
        }

        public decimal getFocalLength()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFocalLength" }
                }
            );
        }

        public decimal getEffectiveFOV()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getEffectiveFOV" }
                }
            );
        }

        public decimal getFilmWidth()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFilmWidth" }
                }
            );
        }

        public decimal getFilmHeight()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFilmHeight" }
                }
            );
        }

        public void setViewOffset(decimal fullWidth, decimal fullHeight, decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewOffset" }, fullWidth, fullHeight, x, y, width, height
                }
            );
        }

        public void clearViewOffset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearViewOffset" }
                }
            );
        }

        public void updateProjectionMatrix()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateProjectionMatrix" }
                }
            );
        }

        public CachedEntity toJSON(object meta = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, meta
                }
            );
        }

        public void setLens(decimal focalLength, System.Nullable<decimal> frameHeight = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLens" }, focalLength, frameHeight
                }
            );
        }
    #endregion
}
