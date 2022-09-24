/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TubeGeometry>))]
public class TubeGeometry : BufferGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static TubeGeometry fromJSON(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<TubeGeometry>(
                entity => new TubeGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "TubeGeometry", "fromJSON" }, data
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
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

        
        public CachedEntity parameters
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parameters",
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
                    "parameters",
                    value
                );
            }
        }

        
        public Vector3[] tangents
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "tangents",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tangents",
                    value
                );
            }
        }

        
        public Vector3[] normals
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "normals",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normals",
                    value
                );
            }
        }

        
        public Vector3[] binormals
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "binormals",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "binormals",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public TubeGeometry() : base() { }

        public TubeGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TubeGeometry(
            Curve<Vector3> path = null, System.Nullable<decimal> tubularSegments = null, System.Nullable<decimal> radius = null, System.Nullable<decimal> radiusSegments = null, System.Nullable<bool> closed = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TubeGeometry" },
                path, tubularSegments, radius, radiusSegments, closed
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
