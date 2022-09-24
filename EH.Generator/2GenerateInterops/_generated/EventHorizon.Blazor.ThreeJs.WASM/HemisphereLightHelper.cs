/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<HemisphereLightHelper>))]
public class HemisphereLightHelper : Object3D
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
        private HemisphereLight __light;
        public HemisphereLight light
        {
            get
            {
            if(__light == null)
            {
                __light = EventHorizonBlazorInterop.GetClass<HemisphereLight>(
                    this.___guid,
                    "light",
                    (entity) =>
                    {
                        return new HemisphereLight() { ___guid = entity.___guid };
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

        private MeshBasicMaterial __material;
        public MeshBasicMaterial material
        {
            get
            {
            if(__material == null)
            {
                __material = EventHorizonBlazorInterop.GetClass<MeshBasicMaterial>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new MeshBasicMaterial() { ___guid = entity.___guid };
                    }
                );
            }
            return __material;
            }
            set
            {
__material = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "material",
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
    #endregion
    
    #region Constructor
        public HemisphereLightHelper() : base() { }

        public HemisphereLightHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public HemisphereLightHelper(
            HemisphereLight light, decimal size, Color color = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "HemisphereLightHelper" },
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
