/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Sprite>))]
public class Sprite : Object3D
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

        
        public unknown isSprite
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isSprite"
                );
            }
        }

        private BufferGeometry __geometry;
        public BufferGeometry geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInterop.GetClass<BufferGeometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new BufferGeometry() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometry;
            }
            set
            {
__geometry = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometry",
                    value
                );
            }
        }

        private SpriteMaterial __material;
        public SpriteMaterial material
        {
            get
            {
            if(__material == null)
            {
                __material = EventHorizonBlazorInterop.GetClass<SpriteMaterial>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new SpriteMaterial() { ___guid = entity.___guid };
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

        private Vector2 __center;
        public Vector2 center
        {
            get
            {
            if(__center == null)
            {
                __center = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "center",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __center;
            }
            set
            {
__center = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "center",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Sprite() : base() { }

        public Sprite(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Sprite(
            SpriteMaterial material = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Sprite" },
                material
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void raycast(Raycaster raycaster, Intersection[] intersects)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "raycast" }, raycaster, intersects
                }
            );
        }

        public Sprite copy(Sprite source)
        {
            return EventHorizonBlazorInterop.FuncClass<Sprite>(
                entity => new Sprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }
    #endregion
}
