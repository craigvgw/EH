/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<NineSlicePlane>))]
public class NineSlicePlane : SimplePlane
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private ITypedArrayCachedEntity __vertices;
        public ITypedArrayCachedEntity vertices
        {
            get
            {
            if(__vertices == null)
            {
                __vertices = EventHorizonBlazorInterop.GetClass<ITypedArrayCachedEntity>(
                    this.___guid,
                    "vertices",
                    (entity) =>
                    {
                        return new ITypedArrayCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertices;
            }
            set
            {
__vertices = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal leftWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "leftWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "leftWidth",
                    value
                );
            }
        }

        
        public decimal rightWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rightWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rightWidth",
                    value
                );
            }
        }

        
        public decimal topHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "topHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "topHeight",
                    value
                );
            }
        }

        
        public decimal bottomHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottomHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bottomHeight",
                    value
                );
            }
        }
    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public NineSlicePlane() : base() { }

        public NineSlicePlane(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public NineSlicePlane(
            Texture texture, System.Nullable<decimal> leftWidth = null, System.Nullable<decimal> topHeight = null, System.Nullable<decimal> rightWidth = null, System.Nullable<decimal> bottomHeight = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "NineSlicePlane" },
                texture, leftWidth, topHeight, rightWidth, bottomHeight
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void textureUpdated()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "textureUpdated" }
                }
            );
        }

        public void updateHorizontalVertices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateHorizontalVertices" }
                }
            );
        }

        public void updateVerticalVertices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateVerticalVertices" }
                }
            );
        }
    #endregion
}
