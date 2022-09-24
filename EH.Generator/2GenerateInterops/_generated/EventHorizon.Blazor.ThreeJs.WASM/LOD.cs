/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LOD>))]
public class LOD : Object3D
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

        
        public CachedEntity[] levels
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "levels",
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
                    "levels",
                    value
                );
            }
        }

        
        public bool autoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoUpdate",
                    value
                );
            }
        }

        
        public unknown isLOD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isLOD"
                );
            }
        }

        
        public CachedEntity[] objects
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "objects",
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
                    "objects",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public LOD() : base() { }

        public LOD(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public LOD addLevel(Object3D @object, System.Nullable<decimal> distance = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LOD>(
                entity => new LOD() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addLevel" }, @object, distance
                }
            );
        }

        public decimal getCurrentLevel()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCurrentLevel" }
                }
            );
        }

        public Object3D getObjectForDistance(decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectForDistance" }, distance
                }
            );
        }

        public void raycast(Raycaster raycaster, Intersection[] intersects)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "raycast" }, raycaster, intersects
                }
            );
        }

        public void update(Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, camera
                }
            );
        }

        public CachedEntity toJSON(object meta)
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
