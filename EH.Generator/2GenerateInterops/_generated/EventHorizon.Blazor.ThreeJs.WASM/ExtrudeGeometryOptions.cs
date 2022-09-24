/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ExtrudeGeometryOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ExtrudeGeometryOptionsCachedEntity>))]
public class ExtrudeGeometryOptionsCachedEntity : CachedEntityObject, ExtrudeGeometryOptions
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
        
        public decimal curveSegments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "curveSegments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "curveSegments",
                    value
                );
            }
        }

        
        public decimal steps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "steps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "steps",
                    value
                );
            }
        }

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        
        public bool bevelEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "bevelEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bevelEnabled",
                    value
                );
            }
        }

        
        public decimal bevelThickness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bevelThickness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bevelThickness",
                    value
                );
            }
        }

        
        public decimal bevelSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bevelSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bevelSize",
                    value
                );
            }
        }

        
        public decimal bevelOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bevelOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bevelOffset",
                    value
                );
            }
        }

        
        public decimal bevelSegments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bevelSegments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bevelSegments",
                    value
                );
            }
        }

        private Curve<Vector3> __extrudePath;
        public Curve<Vector3> extrudePath
        {
            get
            {
            if(__extrudePath == null)
            {
                __extrudePath = EventHorizonBlazorInterop.GetClass<Curve<Vector3>>(
                    this.___guid,
                    "extrudePath",
                    (entity) =>
                    {
                        return new Curve<Vector3>() { ___guid = entity.___guid };
                    }
                );
            }
            return __extrudePath;
            }
            set
            {
__extrudePath = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "extrudePath",
                    value
                );
            }
        }

        private UVGeneratorCachedEntity __UVGenerator;
        public UVGeneratorCachedEntity UVGenerator
        {
            get
            {
            if(__UVGenerator == null)
            {
                __UVGenerator = EventHorizonBlazorInterop.GetClass<UVGeneratorCachedEntity>(
                    this.___guid,
                    "UVGenerator",
                    (entity) =>
                    {
                        return new UVGeneratorCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __UVGenerator;
            }
            set
            {
__UVGenerator = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UVGenerator",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ExtrudeGeometryOptionsCachedEntity() : base() { }

        public ExtrudeGeometryOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
