/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Shape>))]
public class Shape : Path
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

        
        public string uuid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uuid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uuid",
                    value
                );
            }
        }

        
        public Path[] holes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Path>(
                    this.___guid,
                    "holes",
                    (entity) =>
                    {
                        return new Path() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "holes",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Shape() : base() { }

        public Shape(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Shape(
            Vector2[] points = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Shape" },
                points
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
// getPointsHoles is not supported by the platform yet

        public CachedEntity extractPoints(decimal divisions)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "extractPoints" }, divisions
                }
            );
        }
    #endregion
}
