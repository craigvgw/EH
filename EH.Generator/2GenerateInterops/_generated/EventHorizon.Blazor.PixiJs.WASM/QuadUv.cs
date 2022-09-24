/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<QuadUv>))]
public class QuadUv : Geometry
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
        private Buffer_2 __vertexBuffer;
        public Buffer_2 vertexBuffer
        {
            get
            {
            if(__vertexBuffer == null)
            {
                __vertexBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "vertexBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexBuffer;
            }
            set
            {
__vertexBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexBuffer",
                    value
                );
            }
        }

        private Buffer_2 __uvBuffer;
        public Buffer_2 uvBuffer
        {
            get
            {
            if(__uvBuffer == null)
            {
                __uvBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "uvBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __uvBuffer;
            }
            set
            {
__uvBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvBuffer",
                    value
                );
            }
        }

        
        public decimal[] vertices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "vertices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }

        
        public decimal[] uvs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public QuadUv() : base() { }

        public QuadUv(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public QuadUv map(Rectangle targetTextureFrame, Rectangle destinationFrame)
        {
            return EventHorizonBlazorInterop.FuncClass<QuadUv>(
                entity => new QuadUv() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "map" }, targetTextureFrame, destinationFrame
                }
            );
        }

        public QuadUv invalidate()
        {
            return EventHorizonBlazorInterop.FuncClass<QuadUv>(
                entity => new QuadUv() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "invalidate" }
                }
            );
        }
    #endregion
}
