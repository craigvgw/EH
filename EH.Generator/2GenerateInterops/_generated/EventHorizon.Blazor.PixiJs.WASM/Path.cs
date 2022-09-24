/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface Path : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<PathCachedEntity>))]
public class PathCachedEntity : CachedEntityObject, Path
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
        
        public string sep
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "sep"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sep",
                    value
                );
            }
        }

        
        public string delimiter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "delimiter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delimiter",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public PathCachedEntity() : base() { }

        public PathCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        #region toPosix TODO: Get Comments as metadata identification
        private bool _isToPosixEnabled = false;
        private readonly IDictionary<string, Func<Task>> _toPosixActionMap = new Dictionary<string, Func<Task>>();

        public string toPosix(
            Func<Task> callback
        )
        {
            SetupToPosixLoop();

            var handle = Guid.NewGuid().ToString();
            _toPosixActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool toPosix_Remove(
            string handle
        )
        {
            return _toPosixActionMap.Remove(
                handle
            );
        }

        private void SetupToPosixLoop()
        {
            if (_isToPosixEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "toPosix",
                "CallToPosixActions",
                _invokableReference
            );
            _isToPosixEnabled = true;
        }

        [JSInvokable]
        public async Task CallToPosixActions()
        {
            foreach (var action in _toPosixActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region toAbsolute TODO: Get Comments as metadata identification
        private bool _isToAbsoluteEnabled = false;
        private readonly IDictionary<string, Func<Task>> _toAbsoluteActionMap = new Dictionary<string, Func<Task>>();

        public string toAbsolute(
            Func<Task> callback
        )
        {
            SetupToAbsoluteLoop();

            var handle = Guid.NewGuid().ToString();
            _toAbsoluteActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool toAbsolute_Remove(
            string handle
        )
        {
            return _toAbsoluteActionMap.Remove(
                handle
            );
        }

        private void SetupToAbsoluteLoop()
        {
            if (_isToAbsoluteEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "toAbsolute",
                "CallToAbsoluteActions",
                _invokableReference
            );
            _isToAbsoluteEnabled = true;
        }

        [JSInvokable]
        public async Task CallToAbsoluteActions()
        {
            foreach (var action in _toAbsoluteActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region isUrl TODO: Get Comments as metadata identification
        private bool _isIsUrlEnabled = false;
        private readonly IDictionary<string, Func<Task>> _isUrlActionMap = new Dictionary<string, Func<Task>>();

        public string isUrl(
            Func<Task> callback
        )
        {
            SetupIsUrlLoop();

            var handle = Guid.NewGuid().ToString();
            _isUrlActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool isUrl_Remove(
            string handle
        )
        {
            return _isUrlActionMap.Remove(
                handle
            );
        }

        private void SetupIsUrlLoop()
        {
            if (_isIsUrlEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "isUrl",
                "CallIsUrlActions",
                _invokableReference
            );
            _isIsUrlEnabled = true;
        }

        [JSInvokable]
        public async Task CallIsUrlActions()
        {
            foreach (var action in _isUrlActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region isDataUrl TODO: Get Comments as metadata identification
        private bool _isIsDataUrlEnabled = false;
        private readonly IDictionary<string, Func<Task>> _isDataUrlActionMap = new Dictionary<string, Func<Task>>();

        public string isDataUrl(
            Func<Task> callback
        )
        {
            SetupIsDataUrlLoop();

            var handle = Guid.NewGuid().ToString();
            _isDataUrlActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool isDataUrl_Remove(
            string handle
        )
        {
            return _isDataUrlActionMap.Remove(
                handle
            );
        }

        private void SetupIsDataUrlLoop()
        {
            if (_isIsDataUrlEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "isDataUrl",
                "CallIsDataUrlActions",
                _invokableReference
            );
            _isIsDataUrlEnabled = true;
        }

        [JSInvokable]
        public async Task CallIsDataUrlActions()
        {
            foreach (var action in _isDataUrlActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region hasProtocol TODO: Get Comments as metadata identification
        private bool _isHasProtocolEnabled = false;
        private readonly IDictionary<string, Func<Task>> _hasProtocolActionMap = new Dictionary<string, Func<Task>>();

        public string hasProtocol(
            Func<Task> callback
        )
        {
            SetupHasProtocolLoop();

            var handle = Guid.NewGuid().ToString();
            _hasProtocolActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool hasProtocol_Remove(
            string handle
        )
        {
            return _hasProtocolActionMap.Remove(
                handle
            );
        }

        private void SetupHasProtocolLoop()
        {
            if (_isHasProtocolEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "hasProtocol",
                "CallHasProtocolActions",
                _invokableReference
            );
            _isHasProtocolEnabled = true;
        }

        [JSInvokable]
        public async Task CallHasProtocolActions()
        {
            foreach (var action in _hasProtocolActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getProtocol TODO: Get Comments as metadata identification
        private bool _isGetProtocolEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getProtocolActionMap = new Dictionary<string, Func<Task>>();

        public string getProtocol(
            Func<Task> callback
        )
        {
            SetupGetProtocolLoop();

            var handle = Guid.NewGuid().ToString();
            _getProtocolActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getProtocol_Remove(
            string handle
        )
        {
            return _getProtocolActionMap.Remove(
                handle
            );
        }

        private void SetupGetProtocolLoop()
        {
            if (_isGetProtocolEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getProtocol",
                "CallGetProtocolActions",
                _invokableReference
            );
            _isGetProtocolEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetProtocolActions()
        {
            foreach (var action in _getProtocolActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region normalize TODO: Get Comments as metadata identification
        private bool _isNormalizeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _normalizeActionMap = new Dictionary<string, Func<Task>>();

        public string normalize(
            Func<Task> callback
        )
        {
            SetupNormalizeLoop();

            var handle = Guid.NewGuid().ToString();
            _normalizeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool normalize_Remove(
            string handle
        )
        {
            return _normalizeActionMap.Remove(
                handle
            );
        }

        private void SetupNormalizeLoop()
        {
            if (_isNormalizeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "normalize",
                "CallNormalizeActions",
                _invokableReference
            );
            _isNormalizeEnabled = true;
        }

        [JSInvokable]
        public async Task CallNormalizeActions()
        {
            foreach (var action in _normalizeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region join TODO: Get Comments as metadata identification
        private bool _isJoinEnabled = false;
        private readonly IDictionary<string, Func<Task>> _joinActionMap = new Dictionary<string, Func<Task>>();

        public string join(
            Func<Task> callback
        )
        {
            SetupJoinLoop();

            var handle = Guid.NewGuid().ToString();
            _joinActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool join_Remove(
            string handle
        )
        {
            return _joinActionMap.Remove(
                handle
            );
        }

        private void SetupJoinLoop()
        {
            if (_isJoinEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "join",
                "CallJoinActions",
                _invokableReference
            );
            _isJoinEnabled = true;
        }

        [JSInvokable]
        public async Task CallJoinActions()
        {
            foreach (var action in _joinActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region isAbsolute TODO: Get Comments as metadata identification
        private bool _isIsAbsoluteEnabled = false;
        private readonly IDictionary<string, Func<Task>> _isAbsoluteActionMap = new Dictionary<string, Func<Task>>();

        public string isAbsolute(
            Func<Task> callback
        )
        {
            SetupIsAbsoluteLoop();

            var handle = Guid.NewGuid().ToString();
            _isAbsoluteActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool isAbsolute_Remove(
            string handle
        )
        {
            return _isAbsoluteActionMap.Remove(
                handle
            );
        }

        private void SetupIsAbsoluteLoop()
        {
            if (_isIsAbsoluteEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "isAbsolute",
                "CallIsAbsoluteActions",
                _invokableReference
            );
            _isIsAbsoluteEnabled = true;
        }

        [JSInvokable]
        public async Task CallIsAbsoluteActions()
        {
            foreach (var action in _isAbsoluteActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region dirname TODO: Get Comments as metadata identification
        private bool _isDirnameEnabled = false;
        private readonly IDictionary<string, Func<Task>> _dirnameActionMap = new Dictionary<string, Func<Task>>();

        public string dirname(
            Func<Task> callback
        )
        {
            SetupDirnameLoop();

            var handle = Guid.NewGuid().ToString();
            _dirnameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool dirname_Remove(
            string handle
        )
        {
            return _dirnameActionMap.Remove(
                handle
            );
        }

        private void SetupDirnameLoop()
        {
            if (_isDirnameEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "dirname",
                "CallDirnameActions",
                _invokableReference
            );
            _isDirnameEnabled = true;
        }

        [JSInvokable]
        public async Task CallDirnameActions()
        {
            foreach (var action in _dirnameActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region rootname TODO: Get Comments as metadata identification
        private bool _isRootnameEnabled = false;
        private readonly IDictionary<string, Func<Task>> _rootnameActionMap = new Dictionary<string, Func<Task>>();

        public string rootname(
            Func<Task> callback
        )
        {
            SetupRootnameLoop();

            var handle = Guid.NewGuid().ToString();
            _rootnameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool rootname_Remove(
            string handle
        )
        {
            return _rootnameActionMap.Remove(
                handle
            );
        }

        private void SetupRootnameLoop()
        {
            if (_isRootnameEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "rootname",
                "CallRootnameActions",
                _invokableReference
            );
            _isRootnameEnabled = true;
        }

        [JSInvokable]
        public async Task CallRootnameActions()
        {
            foreach (var action in _rootnameActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region basename TODO: Get Comments as metadata identification
        private bool _isBasenameEnabled = false;
        private readonly IDictionary<string, Func<Task>> _basenameActionMap = new Dictionary<string, Func<Task>>();

        public string basename(
            Func<Task> callback
        )
        {
            SetupBasenameLoop();

            var handle = Guid.NewGuid().ToString();
            _basenameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool basename_Remove(
            string handle
        )
        {
            return _basenameActionMap.Remove(
                handle
            );
        }

        private void SetupBasenameLoop()
        {
            if (_isBasenameEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "basename",
                "CallBasenameActions",
                _invokableReference
            );
            _isBasenameEnabled = true;
        }

        [JSInvokable]
        public async Task CallBasenameActions()
        {
            foreach (var action in _basenameActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region extname TODO: Get Comments as metadata identification
        private bool _isExtnameEnabled = false;
        private readonly IDictionary<string, Func<Task>> _extnameActionMap = new Dictionary<string, Func<Task>>();

        public string extname(
            Func<Task> callback
        )
        {
            SetupExtnameLoop();

            var handle = Guid.NewGuid().ToString();
            _extnameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool extname_Remove(
            string handle
        )
        {
            return _extnameActionMap.Remove(
                handle
            );
        }

        private void SetupExtnameLoop()
        {
            if (_isExtnameEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "extname",
                "CallExtnameActions",
                _invokableReference
            );
            _isExtnameEnabled = true;
        }

        [JSInvokable]
        public async Task CallExtnameActions()
        {
            foreach (var action in _extnameActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region parse TODO: Get Comments as metadata identification
        private bool _isParseEnabled = false;
        private readonly IDictionary<string, Func<Task>> _parseActionMap = new Dictionary<string, Func<Task>>();

        public string parse(
            Func<Task> callback
        )
        {
            SetupParseLoop();

            var handle = Guid.NewGuid().ToString();
            _parseActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool parse_Remove(
            string handle
        )
        {
            return _parseActionMap.Remove(
                handle
            );
        }

        private void SetupParseLoop()
        {
            if (_isParseEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "parse",
                "CallParseActions",
                _invokableReference
            );
            _isParseEnabled = true;
        }

        [JSInvokable]
        public async Task CallParseActions()
        {
            foreach (var action in _parseActionMap.Values)
            {
                await action();
            }
        }
        #endregion
    #endregion
}
