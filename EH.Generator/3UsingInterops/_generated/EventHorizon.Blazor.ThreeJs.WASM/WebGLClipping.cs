/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLClipping>))]
public class WebGLClipping : CachedEntityObject
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
        
        public CachedEntity uniform
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "uniform",
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
                    "uniform",
                    value
                );
            }
        }

        
        public decimal numPlanes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "numPlanes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "numPlanes",
                    value
                );
            }
        }

        
        public decimal numIntersection
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "numIntersection"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "numIntersection",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLClipping() : base() { }

        public WebGLClipping(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLClipping(
            WebGLProperties properties
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLClipping" },
                properties
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public bool init(CachedEntity[] planes, bool enableLocalClipping, Camera camera)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "init" }, planes, enableLocalClipping, camera
                }
            );
        }

        public void beginShadows()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "beginShadows" }
                }
            );
        }

        public void endShadows()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "endShadows" }
                }
            );
        }

        public void setState(Material material, Camera camera, bool useCache)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setState" }, material, camera, useCache
                }
            );
        }
    #endregion
}
