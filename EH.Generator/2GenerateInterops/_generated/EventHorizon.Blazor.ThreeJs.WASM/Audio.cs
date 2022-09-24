/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Audio<CachedEntity>>))]
public class Audio<NodeType> : Object3D where NodeType : CachedEntity, new()
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
        
        public unknown type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
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

        private AudioListener __listener;
        public AudioListener listener
        {
            get
            {
            if(__listener == null)
            {
                __listener = EventHorizonBlazorInterop.GetClass<AudioListener>(
                    this.___guid,
                    "listener",
                    (entity) =>
                    {
                        return new AudioListener() { ___guid = entity.___guid };
                    }
                );
            }
            return __listener;
            }
            set
            {
__listener = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "listener",
                    value
                );
            }
        }

        private AudioContext __context;
        public AudioContext context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<AudioContext>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new AudioContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __context;
            }
            set
            {
__context = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "context",
                    value
                );
            }
        }

        private GainNode __gain;
        public GainNode gain
        {
            get
            {
            if(__gain == null)
            {
                __gain = EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "gain",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __gain;
            }
            set
            {
__gain = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gain",
                    value
                );
            }
        }

        
        public bool autoplay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoplay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoplay",
                    value
                );
            }
        }

        private AudioBuffer __buffer;
        public AudioBuffer buffer
        {
            get
            {
            if(__buffer == null)
            {
                __buffer = EventHorizonBlazorInterop.GetClass<AudioBuffer>(
                    this.___guid,
                    "buffer",
                    (entity) =>
                    {
                        return new AudioBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __buffer;
            }
            set
            {
__buffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buffer",
                    value
                );
            }
        }

        
        public decimal detune
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "detune"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "detune",
                    value
                );
            }
        }

        
        public bool loop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loop",
                    value
                );
            }
        }

        
        public decimal loopStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopStart",
                    value
                );
            }
        }

        
        public decimal loopEnd
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopEnd"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopEnd",
                    value
                );
            }
        }

        
        public decimal offset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
            }
        }

        
        public decimal duration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "duration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "duration",
                    value
                );
            }
        }

        
        public decimal playbackRate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "playbackRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playbackRate",
                    value
                );
            }
        }

        
        public bool isPlaying
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPlaying"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPlaying",
                    value
                );
            }
        }

        
        public bool hasPlaybackControl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPlaybackControl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasPlaybackControl",
                    value
                );
            }
        }

        
        public string sourceType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "sourceType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceType",
                    value
                );
            }
        }

        private AudioBufferSourceNode __source;
        public AudioBufferSourceNode source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<AudioBufferSourceNode>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new AudioBufferSourceNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __source;
            }
            set
            {
__source = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }

        
        public AudioNode[] filters
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AudioNode>(
                    this.___guid,
                    "filters",
                    (entity) =>
                    {
                        return new AudioNode() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filters",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Audio() : base() { }

        public Audio(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Audio(
            AudioListener listener
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Audio" },
                listener
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public NodeType getOutput()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeType>(
                entity => new NodeType() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getOutput" }
                }
            );
        }

        public Audio setNodeSource(AudioBufferSourceNode audioNode)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setNodeSource" }, audioNode
                }
            );
        }

        public Audio setMediaElementSource(HTMLMediaElement mediaElement)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMediaElementSource" }, mediaElement
                }
            );
        }

        public Audio setMediaStreamSource(MediaStream mediaStream)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMediaStreamSource" }, mediaStream
                }
            );
        }

        public Audio setBuffer(AudioBuffer audioBuffer)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBuffer" }, audioBuffer
                }
            );
        }

        public Audio play(System.Nullable<decimal> delay = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }, delay
                }
            );
        }

        public void onEnded()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onEnded" }
                }
            );
        }

        public Audio pause()
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public Audio stop()
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public Audio connect()
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "connect" }
                }
            );
        }

        public Audio disconnect()
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disconnect" }
                }
            );
        }

        public Audio setDetune(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDetune" }, value
                }
            );
        }

        public decimal getDetune()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDetune" }
                }
            );
        }

        public AudioNode[] getFilters()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AudioNode>(
                entity => new AudioNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFilters" }
                }
            );
        }

        public Audio setFilters(AudioNode[] value)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFilters" }, value
                }
            );
        }

        public AudioNode getFilter()
        {
            return EventHorizonBlazorInterop.FuncClass<AudioNode>(
                entity => new AudioNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFilter" }
                }
            );
        }

        public Audio setFilter(AudioNode filter)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFilter" }, filter
                }
            );
        }

        public Audio setPlaybackRate(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPlaybackRate" }, value
                }
            );
        }

        public decimal getPlaybackRate()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPlaybackRate" }
                }
            );
        }

        public bool getLoop()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "getLoop" }
                }
            );
        }

        public Audio setLoop(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLoop" }, value
                }
            );
        }

        public Audio setLoopStart(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLoopStart" }, value
                }
            );
        }

        public Audio setLoopEnd(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLoopEnd" }, value
                }
            );
        }

        public decimal getVolume()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVolume" }
                }
            );
        }

        public Audio setVolume(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVolume" }, value
                }
            );
        }

        public Audio load(string file)
        {
            return EventHorizonBlazorInterop.FuncClass<Audio>(
                entity => new Audio() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }, file
                }
            );
        }
    #endregion
}
