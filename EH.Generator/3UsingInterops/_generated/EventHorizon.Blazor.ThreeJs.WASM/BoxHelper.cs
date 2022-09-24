/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BoxHelper>))]
public class BoxHelper : LineSegments
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
    #endregion
    
    #region Constructor
        public BoxHelper() : base() { }

        public BoxHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BoxHelper(
            Object3D @object, Color color = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BoxHelper" },
                @object, color
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update(Object3D @object = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, @object
                }
            );
        }

        public BoxHelper setFromObject(Object3D @object)
        {
            return EventHorizonBlazorInterop.FuncClass<BoxHelper>(
                entity => new BoxHelper() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromObject" }, @object
                }
            );
        }
    #endregion
}
