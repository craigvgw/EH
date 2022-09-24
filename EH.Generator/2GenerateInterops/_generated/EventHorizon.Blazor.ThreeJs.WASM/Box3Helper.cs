/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Box3Helper>))]
public class Box3Helper : LineSegments
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

        private Box3 __box;
        public Box3 box
        {
            get
            {
            if(__box == null)
            {
                __box = EventHorizonBlazorInterop.GetClass<Box3>(
                    this.___guid,
                    "box",
                    (entity) =>
                    {
                        return new Box3() { ___guid = entity.___guid };
                    }
                );
            }
            return __box;
            }
            set
            {
__box = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "box",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Box3Helper() : base() { }

        public Box3Helper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Box3Helper(
            Box3 box, Color color = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Box3Helper" },
                box, color
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
