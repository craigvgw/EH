/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ColorMatrixFilter>))]
public class ColorMatrixFilter : Filter
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public ArrayFixed<decimal, unknown> matrix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ArrayFixed<decimal, unknown>>(
                    this.___guid,
                    "matrix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }
    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public ColorMatrixFilter() : base() { }

        public ColorMatrixFilter(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        #region grayscale TODO: Get Comments as metadata identification
        private bool _isGrayscaleEnabled = false;
        private readonly IDictionary<string, Func<Task>> _grayscaleActionMap = new Dictionary<string, Func<Task>>();

        public string grayscale(
            Func<Task> callback
        )
        {
            SetupGrayscaleLoop();

            var handle = Guid.NewGuid().ToString();
            _grayscaleActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool grayscale_Remove(
            string handle
        )
        {
            return _grayscaleActionMap.Remove(
                handle
            );
        }

        private void SetupGrayscaleLoop()
        {
            if (_isGrayscaleEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "grayscale",
                "CallGrayscaleActions",
                _invokableReference
            );
            _isGrayscaleEnabled = true;
        }

        [JSInvokable]
        public async Task CallGrayscaleActions()
        {
            foreach (var action in _grayscaleActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void brightness(decimal b, bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "brightness" }, b, multiply
                }
            );
        }

        public void tint(decimal color, System.Nullable<bool> multiply = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "tint" }, color, multiply
                }
            );
        }

        public void greyscale(decimal scale, bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "greyscale" }, scale, multiply
                }
            );
        }

        public void blackAndWhite(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blackAndWhite" }, multiply
                }
            );
        }

        public void hue(decimal rotation, bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "hue" }, rotation, multiply
                }
            );
        }

        public void contrast(decimal amount, bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "contrast" }, amount, multiply
                }
            );
        }

        public void saturate(System.Nullable<decimal> amount = null, System.Nullable<bool> multiply = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "saturate" }, amount, multiply
                }
            );
        }

        public void desaturate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "desaturate" }
                }
            );
        }

        public void negative(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "negative" }, multiply
                }
            );
        }

        public void sepia(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sepia" }, multiply
                }
            );
        }

        public void technicolor(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "technicolor" }, multiply
                }
            );
        }

        public void polaroid(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "polaroid" }, multiply
                }
            );
        }

        public void toBGR(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toBGR" }, multiply
                }
            );
        }

        public void kodachrome(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "kodachrome" }, multiply
                }
            );
        }

        public void browni(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "browni" }, multiply
                }
            );
        }

        public void vintage(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vintage" }, multiply
                }
            );
        }

        public void colorTone(decimal desaturation, decimal toned, decimal lightColor, decimal darkColor, bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "colorTone" }, desaturation, toned, lightColor, darkColor, multiply
                }
            );
        }

        public void night(decimal intensity, bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "night" }, intensity, multiply
                }
            );
        }

        public void predator(decimal amount, bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "predator" }, amount, multiply
                }
            );
        }

        public void lsd(bool multiply)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "lsd" }, multiply
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
