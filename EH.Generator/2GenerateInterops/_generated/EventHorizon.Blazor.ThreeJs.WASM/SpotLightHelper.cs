/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpotLightHelper>))]
public class SpotLightHelper : Object3D
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
        private Light __light;
        public Light light
        {
            get
            {
            if(__light == null)
            {
                __light = EventHorizonBlazorInterop.GetClass<Light>(
                    this.___guid,
                    "light",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
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

        private LineSegments __cone;
        public LineSegments cone
        {
            get
            {
            if(__cone == null)
            {
                __cone = EventHorizonBlazorInterop.GetClass<LineSegments>(
                    this.___guid,
                    "cone",
                    (entity) =>
                    {
                        return new LineSegments() { ___guid = entity.___guid };
                    }
                );
            }
            return __cone;
            }
            set
            {
__cone = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cone",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SpotLightHelper() : base() { }

        public SpotLightHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpotLightHelper(
            Light light, Color color = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SpotLightHelper" },
                light, color
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
