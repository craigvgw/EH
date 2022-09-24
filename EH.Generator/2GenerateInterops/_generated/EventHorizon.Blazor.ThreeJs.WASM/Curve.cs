/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Curve<CachedEntity>>))]
public class Curve<T> : CachedEntityObject where T : CachedEntity, new()
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        #region create TODO: Get Comments as metadata identification
        private static bool IsCreateEnabled = false;
        private static readonly IDictionary<string, Func<Task>> createActionMap = new Dictionary<string, Func<Task>>();

        public static string create(
            Func<Task> callback
        )
        {
            SetupCreateStaticLoop();

            var handle = Guid.NewGuid().ToString();
            createActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool create_Remove(
            string handle
        )
        {
            return createActionMap.Remove(
                handle
            );
        }

        private static void SetupCreateStaticLoop()
        {
            if (IsCreateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.ThreeJs.WASM",
                "Curve.create",
                "CallCreateStaticActions"
            );
            IsCreateEnabled = true;
        }

        [JSInvokable]
        public static async Task CallCreateStaticActions()
        {
            foreach (var action in createActionMap.Values)
            {
                await action();
            }
        }
        #endregion
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

        
        public decimal arcLengthDivisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "arcLengthDivisions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "arcLengthDivisions",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Curve() : base() { }

        public Curve(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public T getPoint(decimal t, T optionalTarget = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoint" }, t, optionalTarget
                }
            );
        }

        public T getPointAt(decimal u, T optionalTarget = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPointAt" }, u, optionalTarget
                }
            );
        }

        public T[] getPoints(System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoints" }, divisions
                }
            );
        }

        public T[] getSpacedPoints(System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSpacedPoints" }, divisions
                }
            );
        }

        public decimal getLength()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLength" }
                }
            );
        }

        public decimal[] getLengths(System.Nullable<decimal> divisions = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLengths" }, divisions
                }
            );
        }

        public void updateArcLengths()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateArcLengths" }
                }
            );
        }

        public decimal getUtoTmapping(decimal u, decimal distance)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getUtoTmapping" }, u, distance
                }
            );
        }

        public T getTangent(decimal t, T optionalTarget = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTangent" }, t, optionalTarget
                }
            );
        }

        public T getTangentAt(decimal u, T optionalTarget = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTangentAt" }, u, optionalTarget
                }
            );
        }

        public CachedEntity computeFrenetFrames(decimal segments, System.Nullable<bool> closed = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeFrenetFrames" }, segments, closed
                }
            );
        }

        public Curve clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Curve>(
                entity => new Curve() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Curve copy(Curve<T> source)
        {
            return EventHorizonBlazorInterop.FuncClass<Curve>(
                entity => new Curve() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }

        public Curve fromJSON(object json)
        {
            return EventHorizonBlazorInterop.FuncClass<Curve>(
                entity => new Curve() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromJSON" }, json
                }
            );
        }
    #endregion
}
