/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<EllipseCurve>))]
public class EllipseCurve : Curve<Vector2>
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

        
        public decimal aX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aX",
                    value
                );
            }
        }

        
        public decimal aY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aY",
                    value
                );
            }
        }

        
        public decimal xRadius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "xRadius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xRadius",
                    value
                );
            }
        }

        
        public decimal yRadius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "yRadius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "yRadius",
                    value
                );
            }
        }

        
        public decimal aStartAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aStartAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aStartAngle",
                    value
                );
            }
        }

        
        public decimal aEndAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aEndAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aEndAngle",
                    value
                );
            }
        }

        
        public bool aClockwise
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "aClockwise"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aClockwise",
                    value
                );
            }
        }

        
        public decimal aRotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aRotation",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public EllipseCurve() : base() { }

        public EllipseCurve(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public EllipseCurve(
            decimal aX, decimal aY, decimal xRadius, decimal yRadius, decimal aStartAngle, decimal aEndAngle, bool aClockwise, decimal aRotation
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "EllipseCurve" },
                aX, aY, xRadius, yRadius, aStartAngle, aEndAngle, aClockwise, aRotation
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
