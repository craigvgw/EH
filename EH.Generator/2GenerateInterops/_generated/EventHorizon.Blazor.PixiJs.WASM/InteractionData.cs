/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InteractionData>))]
public class InteractionData : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal pointerId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerId"
                );
            }
        }
    #endregion

    #region Properties
        private Point __global;
        public Point global
        {
            get
            {
            if(__global == null)
            {
                __global = EventHorizonBlazorInterop.GetClass<Point>(
                    this.___guid,
                    "global",
                    (entity) =>
                    {
                        return new Point() { ___guid = entity.___guid };
                    }
                );
            }
            return __global;
            }
            set
            {
__global = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "global",
                    value
                );
            }
        }

        private DisplayObject __target;
        public DisplayObject target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<DisplayObject>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new DisplayObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
            }
            set
            {
__target = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        
        public PointerEvent originalEvent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<PointerEvent>(
                    this.___guid,
                    "originalEvent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originalEvent",
                    value
                );
            }
        }

        
        public decimal identifier
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "identifier"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "identifier",
                    value
                );
            }
        }

        
        public bool isPrimary
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPrimary"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPrimary",
                    value
                );
            }
        }

        
        public decimal button
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "button"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "button",
                    value
                );
            }
        }

        
        public decimal buttons
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buttons"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buttons",
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

        
        public decimal tiltX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tiltX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tiltX",
                    value
                );
            }
        }

        
        public decimal tiltY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tiltY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tiltY",
                    value
                );
            }
        }

        
        public string pointerType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pointerType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerType",
                    value
                );
            }
        }

        
        public decimal pressure
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pressure"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pressure",
                    value
                );
            }
        }

        
        public decimal rotationAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotationAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotationAngle",
                    value
                );
            }
        }

        
        public decimal twist
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "twist"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "twist",
                    value
                );
            }
        }

        
        public decimal tangentialPressure
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tangentialPressure"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tangentialPressure",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InteractionData() : base() { }

        public InteractionData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public P getLocalPosition<P>(DisplayObject displayObject, P point = null, IPointData globalPos = null) where P : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<P>(
                entity => new P() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalPosition" }, displayObject, point, globalPos
                }
            );
        }

        public void copyEvent(Touch @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyEvent" }, @event
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }
    #endregion
}
