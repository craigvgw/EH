/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<RopeGeometry>))]
public class RopeGeometry : MeshGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
        }
    #endregion

    #region Properties
        
        public IPointCachedEntity[] points
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IPointCachedEntity>(
                    this.___guid,
                    "points",
                    (entity) =>
                    {
                        return new IPointCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "points",
                    value
                );
            }
        }

        
        public decimal textureScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textureScale"
                );
            }
        }
    #endregion
    
    #region Constructor
        public RopeGeometry() : base() { }

        public RopeGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RopeGeometry(
            decimal width, IPoint[] points, System.Nullable<decimal> textureScale = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "RopeGeometry" },
                width, points, textureScale
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void updateVertices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateVertices" }
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
