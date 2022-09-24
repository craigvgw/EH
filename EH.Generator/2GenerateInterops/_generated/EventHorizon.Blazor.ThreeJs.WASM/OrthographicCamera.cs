/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<OrthographicCamera>))]
public class OrthographicCamera : Camera
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

        
        public unknown isOrthographicCamera
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isOrthographicCamera"
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

        
        public decimal left
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "left"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "left",
                    value
                );
            }
        }

        
        public decimal right
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "right"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "right",
                    value
                );
            }
        }

        
        public decimal top
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "top"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "top",
                    value
                );
            }
        }

        
        public decimal bottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bottom",
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
    #endregion
    
    #region Constructor
        public OrthographicCamera() : base() { }

        public OrthographicCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public OrthographicCamera(
            System.Nullable<decimal> left = null, System.Nullable<decimal> right = null, System.Nullable<decimal> top = null, System.Nullable<decimal> bottom = null, System.Nullable<decimal> near = null, System.Nullable<decimal> far = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "OrthographicCamera" },
                left, right, top, bottom, near, far
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void updateProjectionMatrix()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateProjectionMatrix" }
                }
            );
        }

        public void setViewOffset(decimal fullWidth, decimal fullHeight, decimal offsetX, decimal offsetY, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewOffset" }, fullWidth, fullHeight, offsetX, offsetY, width, height
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

        public CachedEntity toJSON(object meta = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, meta
                }
            );
        }
    #endregion
}
