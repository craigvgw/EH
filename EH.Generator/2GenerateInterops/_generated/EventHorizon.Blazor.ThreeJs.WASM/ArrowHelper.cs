/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ArrowHelper>))]
public class ArrowHelper : Object3D
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

        private Line __line;
        public Line line
        {
            get
            {
            if(__line == null)
            {
                __line = EventHorizonBlazorInterop.GetClass<Line>(
                    this.___guid,
                    "line",
                    (entity) =>
                    {
                        return new Line() { ___guid = entity.___guid };
                    }
                );
            }
            return __line;
            }
            set
            {
__line = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "line",
                    value
                );
            }
        }

        private Mesh __cone;
        public Mesh cone
        {
            get
            {
            if(__cone == null)
            {
                __cone = EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "cone",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __cone;
            }
            set
            {
__cone = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cone",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ArrowHelper() : base() { }

        public ArrowHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ArrowHelper(
            Vector3 dir = null, Vector3 origin = null, System.Nullable<decimal> length = null, Color color = null, System.Nullable<decimal> headLength = null, System.Nullable<decimal> headWidth = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ArrowHelper" },
                dir, origin, length, color, headLength, headWidth
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setDirection(Vector3 dir)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDirection" }, dir
                }
            );
        }

        public void setLength(decimal length, System.Nullable<decimal> headLength = null, System.Nullable<decimal> headWidth = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLength" }, length, headLength, headWidth
                }
            );
        }

        public void setColor(Color color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColor" }, color
                }
            );
        }
    #endregion
}
