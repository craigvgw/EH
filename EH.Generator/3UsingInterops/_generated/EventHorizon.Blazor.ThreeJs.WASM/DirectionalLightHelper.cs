/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<DirectionalLightHelper>))]
public class DirectionalLightHelper : Object3D
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
        private DirectionalLight __light;
        public DirectionalLight light
        {
            get
            {
            if(__light == null)
            {
                __light = EventHorizonBlazorInterop.GetClass<DirectionalLight>(
                    this.___guid,
                    "light",
                    (entity) =>
                    {
                        return new DirectionalLight() { ___guid = entity.___guid };
                    }
                );
            }
            return __light;
            }
            set
            {
__light = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "light",
                    value
                );
            }
        }

        private Line __lightPlane;
        public Line lightPlane
        {
            get
            {
            if(__lightPlane == null)
            {
                __lightPlane = EventHorizonBlazorInterop.GetClass<Line>(
                    this.___guid,
                    "lightPlane",
                    (entity) =>
                    {
                        return new Line() { ___guid = entity.___guid };
                    }
                );
            }
            return __lightPlane;
            }
            set
            {
__lightPlane = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightPlane",
                    value
                );
            }
        }

        private Line __targetLine;
        public Line targetLine
        {
            get
            {
            if(__targetLine == null)
            {
                __targetLine = EventHorizonBlazorInterop.GetClass<Line>(
                    this.___guid,
                    "targetLine",
                    (entity) =>
                    {
                        return new Line() { ___guid = entity.___guid };
                    }
                );
            }
            return __targetLine;
            }
            set
            {
__targetLine = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetLine",
                    value
                );
            }
        }

        
        public Color color
        {
            get
            {
            return EventHorizonBlazorInterop.Get<Color>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        private Matrix4 __matrix;
        public Matrix4 matrix
        {
            get
            {
            if(__matrix == null)
            {
                __matrix = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "matrix",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __matrix;
            }
            set
            {
__matrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }

        
        public bool matrixAutoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "matrixAutoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixAutoUpdate",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public DirectionalLightHelper() : base() { }

        public DirectionalLightHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DirectionalLightHelper(
            DirectionalLight light, System.Nullable<decimal> size = null, Color color = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "DirectionalLightHelper" },
                light, size, color
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }
    #endregion
}
