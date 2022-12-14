/*!
 * @pixi/utils - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/utils is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
this.PIXI.utils = this.PIXI.utils || {};
var _pixi_utils = (function (exports, settings, constants) {
	'use strict';

	var commonjsGlobal = typeof globalThis !== 'undefined' ? globalThis : typeof window !== 'undefined' ? window : typeof global !== 'undefined' ? global : typeof self !== 'undefined' ? self : {};

	function getDefaultExportFromCjs (x) {
		return x && x.__esModule && Object.prototype.hasOwnProperty.call(x, 'default') ? x['default'] : x;
	}

	function createCommonjsModule(fn, basedir, module) {
		return module = {
			path: basedir,
			exports: {},
			require: function (path, base) {
				return commonjsRequire(path, (base === undefined || base === null) ? module.path : base);
			}
		}, fn(module, module.exports), module.exports;
	}

	function getDefaultExportFromNamespaceIfPresent (n) {
		return n && Object.prototype.hasOwnProperty.call(n, 'default') ? n['default'] : n;
	}

	function getDefaultExportFromNamespaceIfNotNamed (n) {
		return n && Object.prototype.hasOwnProperty.call(n, 'default') && Object.keys(n).length === 1 ? n['default'] : n;
	}

	function getAugmentedNamespace(n) {
		if (n.__esModule) return n;
		var a = Object.defineProperty({}, '__esModule', {value: true});
		Object.keys(n).forEach(function (k) {
			var d = Object.getOwnPropertyDescriptor(n, k);
			Object.defineProperty(a, k, d.get ? d : {
				enumerable: true,
				get: function () {
					return n[k];
				}
			});
		});
		return a;
	}

	function commonjsRequire () {
		throw new Error('Dynamic requires are not currently supported by @rollup/plugin-commonjs');
	}

	var eventemitter3 = createCommonjsModule(function (module) {
	'use strict';

	var has = Object.prototype.hasOwnProperty
	  , prefix = '~';

	/**
	 * Constructor to create a storage for our `EE` objects.
	 * An `Events` instance is a plain object whose properties are event names.
	 *
	 * @constructor
	 * @private
	 */
	function Events() {}

	//
	// We try to not inherit from `Object.prototype`. In some engines creating an
	// instance in this way is faster than calling `Object.create(null)` directly.
	// If `Object.create(null)` is not supported we prefix the event names with a
	// character to make sure that the built-in object properties are not
	// overridden or used as an attack vector.
	//
	if (Object.create) {
	  Events.prototype = Object.create(null);

	  //
	  // This hack is needed because the `__proto__` property is still inherited in
	  // some old browsers like Android 4, iPhone 5.1, Opera 11 and Safari 5.
	  //
	  if (!new Events().__proto__) { prefix = false; }
	}

	/**
	 * Representation of a single event listener.
	 *
	 * @param {Function} fn The listener function.
	 * @param {*} context The context to invoke the listener with.
	 * @param {Boolean} [once=false] Specify if the listener is a one-time listener.
	 * @constructor
	 * @private
	 */
	function EE(fn, context, once) {
	  this.fn = fn;
	  this.context = context;
	  this.once = once || false;
	}

	/**
	 * Add a listener for a given event.
	 *
	 * @param {EventEmitter} emitter Reference to the `EventEmitter` instance.
	 * @param {(String|Symbol)} event The event name.
	 * @param {Function} fn The listener function.
	 * @param {*} context The context to invoke the listener with.
	 * @param {Boolean} once Specify if the listener is a one-time listener.
	 * @returns {EventEmitter}
	 * @private
	 */
	function addListener(emitter, event, fn, context, once) {
	  if (typeof fn !== 'function') {
	    throw new TypeError('The listener must be a function');
	  }

	  var listener = new EE(fn, context || emitter, once)
	    , evt = prefix ? prefix + event : event;

	  if (!emitter._events[evt]) { emitter._events[evt] = listener, emitter._eventsCount++; }
	  else if (!emitter._events[evt].fn) { emitter._events[evt].push(listener); }
	  else { emitter._events[evt] = [emitter._events[evt], listener]; }

	  return emitter;
	}

	/**
	 * Clear event by name.
	 *
	 * @param {EventEmitter} emitter Reference to the `EventEmitter` instance.
	 * @param {(String|Symbol)} evt The Event name.
	 * @private
	 */
	function clearEvent(emitter, evt) {
	  if (--emitter._eventsCount === 0) { emitter._events = new Events(); }
	  else { delete emitter._events[evt]; }
	}

	/**
	 * Minimal `EventEmitter` interface that is molded against the Node.js
	 * `EventEmitter` interface.
	 *
	 * @constructor
	 * @public
	 */
	function EventEmitter() {
	  this._events = new Events();
	  this._eventsCount = 0;
	}

	/**
	 * Return an array listing the events for which the emitter has registered
	 * listeners.
	 *
	 * @returns {Array}
	 * @public
	 */
	EventEmitter.prototype.eventNames = function eventNames() {
	  var names = []
	    , events
	    , name;

	  if (this._eventsCount === 0) { return names; }

	  for (name in (events = this._events)) {
	    if (has.call(events, name)) { names.push(prefix ? name.slice(1) : name); }
	  }

	  if (Object.getOwnPropertySymbols) {
	    return names.concat(Object.getOwnPropertySymbols(events));
	  }

	  return names;
	};

	/**
	 * Return the listeners registered for a given event.
	 *
	 * @param {(String|Symbol)} event The event name.
	 * @returns {Array} The registered listeners.
	 * @public
	 */
	EventEmitter.prototype.listeners = function listeners(event) {
	  var evt = prefix ? prefix + event : event
	    , handlers = this._events[evt];

	  if (!handlers) { return []; }
	  if (handlers.fn) { return [handlers.fn]; }

	  for (var i = 0, l = handlers.length, ee = new Array(l); i < l; i++) {
	    ee[i] = handlers[i].fn;
	  }

	  return ee;
	};

	/**
	 * Return the number of listeners listening to a given event.
	 *
	 * @param {(String|Symbol)} event The event name.
	 * @returns {Number} The number of listeners.
	 * @public
	 */
	EventEmitter.prototype.listenerCount = function listenerCount(event) {
	  var evt = prefix ? prefix + event : event
	    , listeners = this._events[evt];

	  if (!listeners) { return 0; }
	  if (listeners.fn) { return 1; }
	  return listeners.length;
	};

	/**
	 * Calls each of the listeners registered for a given event.
	 *
	 * @param {(String|Symbol)} event The event name.
	 * @returns {Boolean} `true` if the event had listeners, else `false`.
	 * @public
	 */
	EventEmitter.prototype.emit = function emit(event, a1, a2, a3, a4, a5) {
	  var arguments$1 = arguments;

	  var evt = prefix ? prefix + event : event;

	  if (!this._events[evt]) { return false; }

	  var listeners = this._events[evt]
	    , len = arguments.length
	    , args
	    , i;

	  if (listeners.fn) {
	    if (listeners.once) { this.removeListener(event, listeners.fn, undefined, true); }

	    switch (len) {
	      case 1: return listeners.fn.call(listeners.context), true;
	      case 2: return listeners.fn.call(listeners.context, a1), true;
	      case 3: return listeners.fn.call(listeners.context, a1, a2), true;
	      case 4: return listeners.fn.call(listeners.context, a1, a2, a3), true;
	      case 5: return listeners.fn.call(listeners.context, a1, a2, a3, a4), true;
	      case 6: return listeners.fn.call(listeners.context, a1, a2, a3, a4, a5), true;
	    }

	    for (i = 1, args = new Array(len -1); i < len; i++) {
	      args[i - 1] = arguments$1[i];
	    }

	    listeners.fn.apply(listeners.context, args);
	  } else {
	    var length = listeners.length
	      , j;

	    for (i = 0; i < length; i++) {
	      if (listeners[i].once) { this.removeListener(event, listeners[i].fn, undefined, true); }

	      switch (len) {
	        case 1: listeners[i].fn.call(listeners[i].context); break;
	        case 2: listeners[i].fn.call(listeners[i].context, a1); break;
	        case 3: listeners[i].fn.call(listeners[i].context, a1, a2); break;
	        case 4: listeners[i].fn.call(listeners[i].context, a1, a2, a3); break;
	        default:
	          if (!args) { for (j = 1, args = new Array(len -1); j < len; j++) {
	            args[j - 1] = arguments$1[j];
	          } }

	          listeners[i].fn.apply(listeners[i].context, args);
	      }
	    }
	  }

	  return true;
	};

	/**
	 * Add a listener for a given event.
	 *
	 * @param {(String|Symbol)} event The event name.
	 * @param {Function} fn The listener function.
	 * @param {*} [context=this] The context to invoke the listener with.
	 * @returns {EventEmitter} `this`.
	 * @public
	 */
	EventEmitter.prototype.on = function on(event, fn, context) {
	  return addListener(this, event, fn, context, false);
	};

	/**
	 * Add a one-time listener for a given event.
	 *
	 * @param {(String|Symbol)} event The event name.
	 * @param {Function} fn The listener function.
	 * @param {*} [context=this] The context to invoke the listener with.
	 * @returns {EventEmitter} `this`.
	 * @public
	 */
	EventEmitter.prototype.once = function once(event, fn, context) {
	  return addListener(this, event, fn, context, true);
	};

	/**
	 * Remove the listeners of a given event.
	 *
	 * @param {(String|Symbol)} event The event name.
	 * @param {Function} fn Only remove the listeners that match this function.
	 * @param {*} context Only remove the listeners that have this context.
	 * @param {Boolean} once Only remove one-time listeners.
	 * @returns {EventEmitter} `this`.
	 * @public
	 */
	EventEmitter.prototype.removeListener = function removeListener(event, fn, context, once) {
	  var evt = prefix ? prefix + event : event;

	  if (!this._events[evt]) { return this; }
	  if (!fn) {
	    clearEvent(this, evt);
	    return this;
	  }

	  var listeners = this._events[evt];

	  if (listeners.fn) {
	    if (
	      listeners.fn === fn &&
	      (!once || listeners.once) &&
	      (!context || listeners.context === context)
	    ) {
	      clearEvent(this, evt);
	    }
	  } else {
	    for (var i = 0, events = [], length = listeners.length; i < length; i++) {
	      if (
	        listeners[i].fn !== fn ||
	        (once && !listeners[i].once) ||
	        (context && listeners[i].context !== context)
	      ) {
	        events.push(listeners[i]);
	      }
	    }

	    //
	    // Reset the array, or remove it completely if we have no more listeners.
	    //
	    if (events.length) { this._events[evt] = events.length === 1 ? events[0] : events; }
	    else { clearEvent(this, evt); }
	  }

	  return this;
	};

	/**
	 * Remove all listeners, or those of the specified event.
	 *
	 * @param {(String|Symbol)} [event] The event name.
	 * @returns {EventEmitter} `this`.
	 * @public
	 */
	EventEmitter.prototype.removeAllListeners = function removeAllListeners(event) {
	  var evt;

	  if (event) {
	    evt = prefix ? prefix + event : event;
	    if (this._events[evt]) { clearEvent(this, evt); }
	  } else {
	    this._events = new Events();
	    this._eventsCount = 0;
	  }

	  return this;
	};

	//
	// Alias methods names because people roll like that.
	//
	EventEmitter.prototype.off = EventEmitter.prototype.removeListener;
	EventEmitter.prototype.addListener = EventEmitter.prototype.on;

	//
	// Expose the prefix.
	//
	EventEmitter.prefixed = prefix;

	//
	// Allow `EventEmitter` to be imported as module namespace.
	//
	EventEmitter.EventEmitter = EventEmitter;

	//
	// Expose the module.
	//
	if ('undefined' !== 'object') {
	  module.exports = EventEmitter;
	}
	});

	'use strict';

	var earcut_1 = earcut;
	var _default = earcut;

	function earcut(data, holeIndices, dim) {

	    dim = dim || 2;

	    var hasHoles = holeIndices && holeIndices.length,
	        outerLen = hasHoles ? holeIndices[0] * dim : data.length,
	        outerNode = linkedList(data, 0, outerLen, dim, true),
	        triangles = [];

	    if (!outerNode || outerNode.next === outerNode.prev) { return triangles; }

	    var minX, minY, maxX, maxY, x, y, invSize;

	    if (hasHoles) { outerNode = eliminateHoles(data, holeIndices, outerNode, dim); }

	    // if the shape is not too simple, we'll use z-order curve hash later; calculate polygon bbox
	    if (data.length > 80 * dim) {
	        minX = maxX = data[0];
	        minY = maxY = data[1];

	        for (var i = dim; i < outerLen; i += dim) {
	            x = data[i];
	            y = data[i + 1];
	            if (x < minX) { minX = x; }
	            if (y < minY) { minY = y; }
	            if (x > maxX) { maxX = x; }
	            if (y > maxY) { maxY = y; }
	        }

	        // minX, minY and invSize are later used to transform coords into integers for z-order calculation
	        invSize = Math.max(maxX - minX, maxY - minY);
	        invSize = invSize !== 0 ? 32767 / invSize : 0;
	    }

	    earcutLinked(outerNode, triangles, dim, minX, minY, invSize, 0);

	    return triangles;
	}

	// create a circular doubly linked list from polygon points in the specified winding order
	function linkedList(data, start, end, dim, clockwise) {
	    var i, last;

	    if (clockwise === (signedArea(data, start, end, dim) > 0)) {
	        for (i = start; i < end; i += dim) { last = insertNode(i, data[i], data[i + 1], last); }
	    } else {
	        for (i = end - dim; i >= start; i -= dim) { last = insertNode(i, data[i], data[i + 1], last); }
	    }

	    if (last && equals(last, last.next)) {
	        removeNode(last);
	        last = last.next;
	    }

	    return last;
	}

	// eliminate colinear or duplicate points
	function filterPoints(start, end) {
	    if (!start) { return start; }
	    if (!end) { end = start; }

	    var p = start,
	        again;
	    do {
	        again = false;

	        if (!p.steiner && (equals(p, p.next) || area(p.prev, p, p.next) === 0)) {
	            removeNode(p);
	            p = end = p.prev;
	            if (p === p.next) { break; }
	            again = true;

	        } else {
	            p = p.next;
	        }
	    } while (again || p !== end);

	    return end;
	}

	// main ear slicing loop which triangulates a polygon (given as a linked list)
	function earcutLinked(ear, triangles, dim, minX, minY, invSize, pass) {
	    if (!ear) { return; }

	    // interlink polygon nodes in z-order
	    if (!pass && invSize) { indexCurve(ear, minX, minY, invSize); }

	    var stop = ear,
	        prev, next;

	    // iterate through ears, slicing them one by one
	    while (ear.prev !== ear.next) {
	        prev = ear.prev;
	        next = ear.next;

	        if (invSize ? isEarHashed(ear, minX, minY, invSize) : isEar(ear)) {
	            // cut off the triangle
	            triangles.push(prev.i / dim | 0);
	            triangles.push(ear.i / dim | 0);
	            triangles.push(next.i / dim | 0);

	            removeNode(ear);

	            // skipping the next vertex leads to less sliver triangles
	            ear = next.next;
	            stop = next.next;

	            continue;
	        }

	        ear = next;

	        // if we looped through the whole remaining polygon and can't find any more ears
	        if (ear === stop) {
	            // try filtering points and slicing again
	            if (!pass) {
	                earcutLinked(filterPoints(ear), triangles, dim, minX, minY, invSize, 1);

	            // if this didn't work, try curing all small self-intersections locally
	            } else if (pass === 1) {
	                ear = cureLocalIntersections(filterPoints(ear), triangles, dim);
	                earcutLinked(ear, triangles, dim, minX, minY, invSize, 2);

	            // as a last resort, try splitting the remaining polygon into two
	            } else if (pass === 2) {
	                splitEarcut(ear, triangles, dim, minX, minY, invSize);
	            }

	            break;
	        }
	    }
	}

	// check whether a polygon node forms a valid ear with adjacent nodes
	function isEar(ear) {
	    var a = ear.prev,
	        b = ear,
	        c = ear.next;

	    if (area(a, b, c) >= 0) { return false; } // reflex, can't be an ear

	    // now make sure we don't have other points inside the potential ear
	    var ax = a.x, bx = b.x, cx = c.x, ay = a.y, by = b.y, cy = c.y;

	    // triangle bbox; min & max are calculated like this for speed
	    var x0 = ax < bx ? (ax < cx ? ax : cx) : (bx < cx ? bx : cx),
	        y0 = ay < by ? (ay < cy ? ay : cy) : (by < cy ? by : cy),
	        x1 = ax > bx ? (ax > cx ? ax : cx) : (bx > cx ? bx : cx),
	        y1 = ay > by ? (ay > cy ? ay : cy) : (by > cy ? by : cy);

	    var p = c.next;
	    while (p !== a) {
	        if (p.x >= x0 && p.x <= x1 && p.y >= y0 && p.y <= y1 &&
	            pointInTriangle(ax, ay, bx, by, cx, cy, p.x, p.y) &&
	            area(p.prev, p, p.next) >= 0) { return false; }
	        p = p.next;
	    }

	    return true;
	}

	function isEarHashed(ear, minX, minY, invSize) {
	    var a = ear.prev,
	        b = ear,
	        c = ear.next;

	    if (area(a, b, c) >= 0) { return false; } // reflex, can't be an ear

	    var ax = a.x, bx = b.x, cx = c.x, ay = a.y, by = b.y, cy = c.y;

	    // triangle bbox; min & max are calculated like this for speed
	    var x0 = ax < bx ? (ax < cx ? ax : cx) : (bx < cx ? bx : cx),
	        y0 = ay < by ? (ay < cy ? ay : cy) : (by < cy ? by : cy),
	        x1 = ax > bx ? (ax > cx ? ax : cx) : (bx > cx ? bx : cx),
	        y1 = ay > by ? (ay > cy ? ay : cy) : (by > cy ? by : cy);

	    // z-order range for the current triangle bbox;
	    var minZ = zOrder(x0, y0, minX, minY, invSize),
	        maxZ = zOrder(x1, y1, minX, minY, invSize);

	    var p = ear.prevZ,
	        n = ear.nextZ;

	    // look for points inside the triangle in both directions
	    while (p && p.z >= minZ && n && n.z <= maxZ) {
	        if (p.x >= x0 && p.x <= x1 && p.y >= y0 && p.y <= y1 && p !== a && p !== c &&
	            pointInTriangle(ax, ay, bx, by, cx, cy, p.x, p.y) && area(p.prev, p, p.next) >= 0) { return false; }
	        p = p.prevZ;

	        if (n.x >= x0 && n.x <= x1 && n.y >= y0 && n.y <= y1 && n !== a && n !== c &&
	            pointInTriangle(ax, ay, bx, by, cx, cy, n.x, n.y) && area(n.prev, n, n.next) >= 0) { return false; }
	        n = n.nextZ;
	    }

	    // look for remaining points in decreasing z-order
	    while (p && p.z >= minZ) {
	        if (p.x >= x0 && p.x <= x1 && p.y >= y0 && p.y <= y1 && p !== a && p !== c &&
	            pointInTriangle(ax, ay, bx, by, cx, cy, p.x, p.y) && area(p.prev, p, p.next) >= 0) { return false; }
	        p = p.prevZ;
	    }

	    // look for remaining points in increasing z-order
	    while (n && n.z <= maxZ) {
	        if (n.x >= x0 && n.x <= x1 && n.y >= y0 && n.y <= y1 && n !== a && n !== c &&
	            pointInTriangle(ax, ay, bx, by, cx, cy, n.x, n.y) && area(n.prev, n, n.next) >= 0) { return false; }
	        n = n.nextZ;
	    }

	    return true;
	}

	// go through all polygon nodes and cure small local self-intersections
	function cureLocalIntersections(start, triangles, dim) {
	    var p = start;
	    do {
	        var a = p.prev,
	            b = p.next.next;

	        if (!equals(a, b) && intersects(a, p, p.next, b) && locallyInside(a, b) && locallyInside(b, a)) {

	            triangles.push(a.i / dim | 0);
	            triangles.push(p.i / dim | 0);
	            triangles.push(b.i / dim | 0);

	            // remove two nodes involved
	            removeNode(p);
	            removeNode(p.next);

	            p = start = b;
	        }
	        p = p.next;
	    } while (p !== start);

	    return filterPoints(p);
	}

	// try splitting polygon into two and triangulate them independently
	function splitEarcut(start, triangles, dim, minX, minY, invSize) {
	    // look for a valid diagonal that divides the polygon into two
	    var a = start;
	    do {
	        var b = a.next.next;
	        while (b !== a.prev) {
	            if (a.i !== b.i && isValidDiagonal(a, b)) {
	                // split the polygon in two by the diagonal
	                var c = splitPolygon(a, b);

	                // filter colinear points around the cuts
	                a = filterPoints(a, a.next);
	                c = filterPoints(c, c.next);

	                // run earcut on each half
	                earcutLinked(a, triangles, dim, minX, minY, invSize, 0);
	                earcutLinked(c, triangles, dim, minX, minY, invSize, 0);
	                return;
	            }
	            b = b.next;
	        }
	        a = a.next;
	    } while (a !== start);
	}

	// link every hole into the outer loop, producing a single-ring polygon without holes
	function eliminateHoles(data, holeIndices, outerNode, dim) {
	    var queue = [],
	        i, len, start, end, list;

	    for (i = 0, len = holeIndices.length; i < len; i++) {
	        start = holeIndices[i] * dim;
	        end = i < len - 1 ? holeIndices[i + 1] * dim : data.length;
	        list = linkedList(data, start, end, dim, false);
	        if (list === list.next) { list.steiner = true; }
	        queue.push(getLeftmost(list));
	    }

	    queue.sort(compareX);

	    // process holes from left to right
	    for (i = 0; i < queue.length; i++) {
	        outerNode = eliminateHole(queue[i], outerNode);
	    }

	    return outerNode;
	}

	function compareX(a, b) {
	    return a.x - b.x;
	}

	// find a bridge between vertices that connects hole with an outer ring and and link it
	function eliminateHole(hole, outerNode) {
	    var bridge = findHoleBridge(hole, outerNode);
	    if (!bridge) {
	        return outerNode;
	    }

	    var bridgeReverse = splitPolygon(bridge, hole);

	    // filter collinear points around the cuts
	    filterPoints(bridgeReverse, bridgeReverse.next);
	    return filterPoints(bridge, bridge.next);
	}

	// David Eberly's algorithm for finding a bridge between hole and outer polygon
	function findHoleBridge(hole, outerNode) {
	    var p = outerNode,
	        hx = hole.x,
	        hy = hole.y,
	        qx = -Infinity,
	        m;

	    // find a segment intersected by a ray from the hole's leftmost point to the left;
	    // segment's endpoint with lesser x will be potential connection point
	    do {
	        if (hy <= p.y && hy >= p.next.y && p.next.y !== p.y) {
	            var x = p.x + (hy - p.y) * (p.next.x - p.x) / (p.next.y - p.y);
	            if (x <= hx && x > qx) {
	                qx = x;
	                m = p.x < p.next.x ? p : p.next;
	                if (x === hx) { return m; } // hole touches outer segment; pick leftmost endpoint
	            }
	        }
	        p = p.next;
	    } while (p !== outerNode);

	    if (!m) { return null; }

	    // look for points inside the triangle of hole point, segment intersection and endpoint;
	    // if there are no points found, we have a valid connection;
	    // otherwise choose the point of the minimum angle with the ray as connection point

	    var stop = m,
	        mx = m.x,
	        my = m.y,
	        tanMin = Infinity,
	        tan;

	    p = m;

	    do {
	        if (hx >= p.x && p.x >= mx && hx !== p.x &&
	                pointInTriangle(hy < my ? hx : qx, hy, mx, my, hy < my ? qx : hx, hy, p.x, p.y)) {

	            tan = Math.abs(hy - p.y) / (hx - p.x); // tangential

	            if (locallyInside(p, hole) &&
	                (tan < tanMin || (tan === tanMin && (p.x > m.x || (p.x === m.x && sectorContainsSector(m, p)))))) {
	                m = p;
	                tanMin = tan;
	            }
	        }

	        p = p.next;
	    } while (p !== stop);

	    return m;
	}

	// whether sector in vertex m contains sector in vertex p in the same coordinates
	function sectorContainsSector(m, p) {
	    return area(m.prev, m, p.prev) < 0 && area(p.next, m, m.next) < 0;
	}

	// interlink polygon nodes in z-order
	function indexCurve(start, minX, minY, invSize) {
	    var p = start;
	    do {
	        if (p.z === 0) { p.z = zOrder(p.x, p.y, minX, minY, invSize); }
	        p.prevZ = p.prev;
	        p.nextZ = p.next;
	        p = p.next;
	    } while (p !== start);

	    p.prevZ.nextZ = null;
	    p.prevZ = null;

	    sortLinked(p);
	}

	// Simon Tatham's linked list merge sort algorithm
	// http://www.chiark.greenend.org.uk/~sgtatham/algorithms/listsort.html
	function sortLinked(list) {
	    var i, p, q, e, tail, numMerges, pSize, qSize,
	        inSize = 1;

	    do {
	        p = list;
	        list = null;
	        tail = null;
	        numMerges = 0;

	        while (p) {
	            numMerges++;
	            q = p;
	            pSize = 0;
	            for (i = 0; i < inSize; i++) {
	                pSize++;
	                q = q.nextZ;
	                if (!q) { break; }
	            }
	            qSize = inSize;

	            while (pSize > 0 || (qSize > 0 && q)) {

	                if (pSize !== 0 && (qSize === 0 || !q || p.z <= q.z)) {
	                    e = p;
	                    p = p.nextZ;
	                    pSize--;
	                } else {
	                    e = q;
	                    q = q.nextZ;
	                    qSize--;
	                }

	                if (tail) { tail.nextZ = e; }
	                else { list = e; }

	                e.prevZ = tail;
	                tail = e;
	            }

	            p = q;
	        }

	        tail.nextZ = null;
	        inSize *= 2;

	    } while (numMerges > 1);

	    return list;
	}

	// z-order of a point given coords and inverse of the longer side of data bbox
	function zOrder(x, y, minX, minY, invSize) {
	    // coords are transformed into non-negative 15-bit integer range
	    x = (x - minX) * invSize | 0;
	    y = (y - minY) * invSize | 0;

	    x = (x | (x << 8)) & 0x00FF00FF;
	    x = (x | (x << 4)) & 0x0F0F0F0F;
	    x = (x | (x << 2)) & 0x33333333;
	    x = (x | (x << 1)) & 0x55555555;

	    y = (y | (y << 8)) & 0x00FF00FF;
	    y = (y | (y << 4)) & 0x0F0F0F0F;
	    y = (y | (y << 2)) & 0x33333333;
	    y = (y | (y << 1)) & 0x55555555;

	    return x | (y << 1);
	}

	// find the leftmost node of a polygon ring
	function getLeftmost(start) {
	    var p = start,
	        leftmost = start;
	    do {
	        if (p.x < leftmost.x || (p.x === leftmost.x && p.y < leftmost.y)) { leftmost = p; }
	        p = p.next;
	    } while (p !== start);

	    return leftmost;
	}

	// check if a point lies within a convex triangle
	function pointInTriangle(ax, ay, bx, by, cx, cy, px, py) {
	    return (cx - px) * (ay - py) >= (ax - px) * (cy - py) &&
	           (ax - px) * (by - py) >= (bx - px) * (ay - py) &&
	           (bx - px) * (cy - py) >= (cx - px) * (by - py);
	}

	// check if a diagonal between two polygon nodes is valid (lies in polygon interior)
	function isValidDiagonal(a, b) {
	    return a.next.i !== b.i && a.prev.i !== b.i && !intersectsPolygon(a, b) && // dones't intersect other edges
	           (locallyInside(a, b) && locallyInside(b, a) && middleInside(a, b) && // locally visible
	            (area(a.prev, a, b.prev) || area(a, b.prev, b)) || // does not create opposite-facing sectors
	            equals(a, b) && area(a.prev, a, a.next) > 0 && area(b.prev, b, b.next) > 0); // special zero-length case
	}

	// signed area of a triangle
	function area(p, q, r) {
	    return (q.y - p.y) * (r.x - q.x) - (q.x - p.x) * (r.y - q.y);
	}

	// check if two points are equal
	function equals(p1, p2) {
	    return p1.x === p2.x && p1.y === p2.y;
	}

	// check if two segments intersect
	function intersects(p1, q1, p2, q2) {
	    var o1 = sign$1(area(p1, q1, p2));
	    var o2 = sign$1(area(p1, q1, q2));
	    var o3 = sign$1(area(p2, q2, p1));
	    var o4 = sign$1(area(p2, q2, q1));

	    if (o1 !== o2 && o3 !== o4) { return true; } // general case

	    if (o1 === 0 && onSegment(p1, p2, q1)) { return true; } // p1, q1 and p2 are collinear and p2 lies on p1q1
	    if (o2 === 0 && onSegment(p1, q2, q1)) { return true; } // p1, q1 and q2 are collinear and q2 lies on p1q1
	    if (o3 === 0 && onSegment(p2, p1, q2)) { return true; } // p2, q2 and p1 are collinear and p1 lies on p2q2
	    if (o4 === 0 && onSegment(p2, q1, q2)) { return true; } // p2, q2 and q1 are collinear and q1 lies on p2q2

	    return false;
	}

	// for collinear points p, q, r, check if point q lies on segment pr
	function onSegment(p, q, r) {
	    return q.x <= Math.max(p.x, r.x) && q.x >= Math.min(p.x, r.x) && q.y <= Math.max(p.y, r.y) && q.y >= Math.min(p.y, r.y);
	}

	function sign$1(num) {
	    return num > 0 ? 1 : num < 0 ? -1 : 0;
	}

	// check if a polygon diagonal intersects any polygon segments
	function intersectsPolygon(a, b) {
	    var p = a;
	    do {
	        if (p.i !== a.i && p.next.i !== a.i && p.i !== b.i && p.next.i !== b.i &&
	                intersects(p, p.next, a, b)) { return true; }
	        p = p.next;
	    } while (p !== a);

	    return false;
	}

	// check if a polygon diagonal is locally inside the polygon
	function locallyInside(a, b) {
	    return area(a.prev, a, a.next) < 0 ?
	        area(a, b, a.next) >= 0 && area(a, a.prev, b) >= 0 :
	        area(a, b, a.prev) < 0 || area(a, a.next, b) < 0;
	}

	// check if the middle point of a polygon diagonal is inside the polygon
	function middleInside(a, b) {
	    var p = a,
	        inside = false,
	        px = (a.x + b.x) / 2,
	        py = (a.y + b.y) / 2;
	    do {
	        if (((p.y > py) !== (p.next.y > py)) && p.next.y !== p.y &&
	                (px < (p.next.x - p.x) * (py - p.y) / (p.next.y - p.y) + p.x))
	            { inside = !inside; }
	        p = p.next;
	    } while (p !== a);

	    return inside;
	}

	// link two polygon vertices with a bridge; if the vertices belong to the same ring, it splits polygon into two;
	// if one belongs to the outer ring and another to a hole, it merges it into a single ring
	function splitPolygon(a, b) {
	    var a2 = new Node(a.i, a.x, a.y),
	        b2 = new Node(b.i, b.x, b.y),
	        an = a.next,
	        bp = b.prev;

	    a.next = b;
	    b.prev = a;

	    a2.next = an;
	    an.prev = a2;

	    b2.next = a2;
	    a2.prev = b2;

	    bp.next = b2;
	    b2.prev = bp;

	    return b2;
	}

	// create a node and optionally link it with previous one (in a circular doubly linked list)
	function insertNode(i, x, y, last) {
	    var p = new Node(i, x, y);

	    if (!last) {
	        p.prev = p;
	        p.next = p;

	    } else {
	        p.next = last.next;
	        p.prev = last;
	        last.next.prev = p;
	        last.next = p;
	    }
	    return p;
	}

	function removeNode(p) {
	    p.next.prev = p.prev;
	    p.prev.next = p.next;

	    if (p.prevZ) { p.prevZ.nextZ = p.nextZ; }
	    if (p.nextZ) { p.nextZ.prevZ = p.prevZ; }
	}

	function Node(i, x, y) {
	    // vertex index in coordinates array
	    this.i = i;

	    // vertex coordinates
	    this.x = x;
	    this.y = y;

	    // previous and next vertex nodes in a polygon ring
	    this.prev = null;
	    this.next = null;

	    // z-order curve value
	    this.z = 0;

	    // previous and next nodes in z-order
	    this.prevZ = null;
	    this.nextZ = null;

	    // indicates whether this is a steiner point
	    this.steiner = false;
	}

	// return a percentage difference between the polygon area and its triangulation area;
	// used to verify correctness of triangulation
	earcut.deviation = function (data, holeIndices, dim, triangles) {
	    var hasHoles = holeIndices && holeIndices.length;
	    var outerLen = hasHoles ? holeIndices[0] * dim : data.length;

	    var polygonArea = Math.abs(signedArea(data, 0, outerLen, dim));
	    if (hasHoles) {
	        for (var i = 0, len = holeIndices.length; i < len; i++) {
	            var start = holeIndices[i] * dim;
	            var end = i < len - 1 ? holeIndices[i + 1] * dim : data.length;
	            polygonArea -= Math.abs(signedArea(data, start, end, dim));
	        }
	    }

	    var trianglesArea = 0;
	    for (i = 0; i < triangles.length; i += 3) {
	        var a = triangles[i] * dim;
	        var b = triangles[i + 1] * dim;
	        var c = triangles[i + 2] * dim;
	        trianglesArea += Math.abs(
	            (data[a] - data[c]) * (data[b + 1] - data[a + 1]) -
	            (data[a] - data[b]) * (data[c + 1] - data[a + 1]));
	    }

	    return polygonArea === 0 && trianglesArea === 0 ? 0 :
	        Math.abs((trianglesArea - polygonArea) / polygonArea);
	};

	function signedArea(data, start, end, dim) {
	    var sum = 0;
	    for (var i = start, j = end - dim; i < end; i += dim) {
	        sum += (data[j] - data[i]) * (data[i + 1] + data[j + 1]);
	        j = i;
	    }
	    return sum;
	}

	// turn a polygon in a multi-dimensional array form (e.g. as in GeoJSON) into a form Earcut accepts
	earcut.flatten = function (data) {
	    var dim = data[0][0].length,
	        result = {vertices: [], holes: [], dimensions: dim},
	        holeIndex = 0;

	    for (var i = 0; i < data.length; i++) {
	        for (var j = 0; j < data[i].length; j++) {
	            for (var d = 0; d < dim; d++) { result.vertices.push(data[i][j][d]); }
	        }
	        if (i > 0) {
	            holeIndex += data[i - 1].length;
	            result.holes.push(holeIndex);
	        }
	    }
	    return result;
	};
	earcut_1.default = _default;

	var punycode = createCommonjsModule(function (module, exports) {
	/*! https://mths.be/punycode v1.3.2 by @mathias */
	;(function(root) {

		/** Detect free variables */
		var freeExports = 'object' == 'object' && exports &&
			!exports.nodeType && exports;
		var freeModule = 'object' == 'object' && module &&
			!module.nodeType && module;
		var freeGlobal = typeof commonjsGlobal == 'object' && commonjsGlobal;
		if (
			freeGlobal.global === freeGlobal ||
			freeGlobal.window === freeGlobal ||
			freeGlobal.self === freeGlobal
		) {
			root = freeGlobal;
		}

		/**
		 * The `punycode` object.
		 * @name punycode
		 * @type Object
		 */
		var punycode,

		/** Highest positive signed 32-bit float value */
		maxInt = 2147483647, // aka. 0x7FFFFFFF or 2^31-1

		/** Bootstring parameters */
		base = 36,
		tMin = 1,
		tMax = 26,
		skew = 38,
		damp = 700,
		initialBias = 72,
		initialN = 128, // 0x80
		delimiter = '-', // '\x2D'

		/** Regular expressions */
		regexPunycode = /^xn--/,
		regexNonASCII = /[^\x20-\x7E]/, // unprintable ASCII chars + non-ASCII chars
		regexSeparators = /[\x2E\u3002\uFF0E\uFF61]/g, // RFC 3490 separators

		/** Error messages */
		errors = {
			'overflow': 'Overflow: input needs wider integers to process',
			'not-basic': 'Illegal input >= 0x80 (not a basic code point)',
			'invalid-input': 'Invalid input'
		},

		/** Convenience shortcuts */
		baseMinusTMin = base - tMin,
		floor = Math.floor,
		stringFromCharCode = String.fromCharCode,

		/** Temporary variable */
		key;

		/*--------------------------------------------------------------------------*/

		/**
		 * A generic error utility function.
		 * @private
		 * @param {String} type The error type.
		 * @returns {Error} Throws a `RangeError` with the applicable error message.
		 */
		function error(type) {
			throw RangeError(errors[type]);
		}

		/**
		 * A generic `Array#map` utility function.
		 * @private
		 * @param {Array} array The array to iterate over.
		 * @param {Function} callback The function that gets called for every array
		 * item.
		 * @returns {Array} A new array of values returned by the callback function.
		 */
		function map(array, fn) {
			var length = array.length;
			var result = [];
			while (length--) {
				result[length] = fn(array[length]);
			}
			return result;
		}

		/**
		 * A simple `Array#map`-like wrapper to work with domain name strings or email
		 * addresses.
		 * @private
		 * @param {String} domain The domain name or email address.
		 * @param {Function} callback The function that gets called for every
		 * character.
		 * @returns {Array} A new string of characters returned by the callback
		 * function.
		 */
		function mapDomain(string, fn) {
			var parts = string.split('@');
			var result = '';
			if (parts.length > 1) {
				// In email addresses, only the domain name should be punycoded. Leave
				// the local part (i.e. everything up to `@`) intact.
				result = parts[0] + '@';
				string = parts[1];
			}
			// Avoid `split(regex)` for IE8 compatibility. See #17.
			string = string.replace(regexSeparators, '\x2E');
			var labels = string.split('.');
			var encoded = map(labels, fn).join('.');
			return result + encoded;
		}

		/**
		 * Creates an array containing the numeric code points of each Unicode
		 * character in the string. While JavaScript uses UCS-2 internally,
		 * this function will convert a pair of surrogate halves (each of which
		 * UCS-2 exposes as separate characters) into a single code point,
		 * matching UTF-16.
		 * @see `punycode.ucs2.encode`
		 * @see <https://mathiasbynens.be/notes/javascript-encoding>
		 * @memberOf punycode.ucs2
		 * @name decode
		 * @param {String} string The Unicode input string (UCS-2).
		 * @returns {Array} The new array of code points.
		 */
		function ucs2decode(string) {
			var output = [],
			    counter = 0,
			    length = string.length,
			    value,
			    extra;
			while (counter < length) {
				value = string.charCodeAt(counter++);
				if (value >= 0xD800 && value <= 0xDBFF && counter < length) {
					// high surrogate, and there is a next character
					extra = string.charCodeAt(counter++);
					if ((extra & 0xFC00) == 0xDC00) { // low surrogate
						output.push(((value & 0x3FF) << 10) + (extra & 0x3FF) + 0x10000);
					} else {
						// unmatched surrogate; only append this code unit, in case the next
						// code unit is the high surrogate of a surrogate pair
						output.push(value);
						counter--;
					}
				} else {
					output.push(value);
				}
			}
			return output;
		}

		/**
		 * Creates a string based on an array of numeric code points.
		 * @see `punycode.ucs2.decode`
		 * @memberOf punycode.ucs2
		 * @name encode
		 * @param {Array} codePoints The array of numeric code points.
		 * @returns {String} The new Unicode string (UCS-2).
		 */
		function ucs2encode(array) {
			return map(array, function(value) {
				var output = '';
				if (value > 0xFFFF) {
					value -= 0x10000;
					output += stringFromCharCode(value >>> 10 & 0x3FF | 0xD800);
					value = 0xDC00 | value & 0x3FF;
				}
				output += stringFromCharCode(value);
				return output;
			}).join('');
		}

		/**
		 * Converts a basic code point into a digit/integer.
		 * @see `digitToBasic()`
		 * @private
		 * @param {Number} codePoint The basic numeric code point value.
		 * @returns {Number} The numeric value of a basic code point (for use in
		 * representing integers) in the range `0` to `base - 1`, or `base` if
		 * the code point does not represent a value.
		 */
		function basicToDigit(codePoint) {
			if (codePoint - 48 < 10) {
				return codePoint - 22;
			}
			if (codePoint - 65 < 26) {
				return codePoint - 65;
			}
			if (codePoint - 97 < 26) {
				return codePoint - 97;
			}
			return base;
		}

		/**
		 * Converts a digit/integer into a basic code point.
		 * @see `basicToDigit()`
		 * @private
		 * @param {Number} digit The numeric value of a basic code point.
		 * @returns {Number} The basic code point whose value (when used for
		 * representing integers) is `digit`, which needs to be in the range
		 * `0` to `base - 1`. If `flag` is non-zero, the uppercase form is
		 * used; else, the lowercase form is used. The behavior is undefined
		 * if `flag` is non-zero and `digit` has no uppercase form.
		 */
		function digitToBasic(digit, flag) {
			//  0..25 map to ASCII a..z or A..Z
			// 26..35 map to ASCII 0..9
			return digit + 22 + 75 * (digit < 26) - ((flag != 0) << 5);
		}

		/**
		 * Bias adaptation function as per section 3.4 of RFC 3492.
		 * http://tools.ietf.org/html/rfc3492#section-3.4
		 * @private
		 */
		function adapt(delta, numPoints, firstTime) {
			var k = 0;
			delta = firstTime ? floor(delta / damp) : delta >> 1;
			delta += floor(delta / numPoints);
			for (/* no initialization */; delta > baseMinusTMin * tMax >> 1; k += base) {
				delta = floor(delta / baseMinusTMin);
			}
			return floor(k + (baseMinusTMin + 1) * delta / (delta + skew));
		}

		/**
		 * Converts a Punycode string of ASCII-only symbols to a string of Unicode
		 * symbols.
		 * @memberOf punycode
		 * @param {String} input The Punycode string of ASCII-only symbols.
		 * @returns {String} The resulting string of Unicode symbols.
		 */
		function decode(input) {
			// Don't use UCS-2
			var output = [],
			    inputLength = input.length,
			    out,
			    i = 0,
			    n = initialN,
			    bias = initialBias,
			    basic,
			    j,
			    index,
			    oldi,
			    w,
			    k,
			    digit,
			    t,
			    /** Cached calculation results */
			    baseMinusT;

			// Handle the basic code points: let `basic` be the number of input code
			// points before the last delimiter, or `0` if there is none, then copy
			// the first basic code points to the output.

			basic = input.lastIndexOf(delimiter);
			if (basic < 0) {
				basic = 0;
			}

			for (j = 0; j < basic; ++j) {
				// if it's not a basic code point
				if (input.charCodeAt(j) >= 0x80) {
					error('not-basic');
				}
				output.push(input.charCodeAt(j));
			}

			// Main decoding loop: start just after the last delimiter if any basic code
			// points were copied; start at the beginning otherwise.

			for (index = basic > 0 ? basic + 1 : 0; index < inputLength; /* no final expression */) {

				// `index` is the index of the next character to be consumed.
				// Decode a generalized variable-length integer into `delta`,
				// which gets added to `i`. The overflow checking is easier
				// if we increase `i` as we go, then subtract off its starting
				// value at the end to obtain `delta`.
				for (oldi = i, w = 1, k = base; /* no condition */; k += base) {

					if (index >= inputLength) {
						error('invalid-input');
					}

					digit = basicToDigit(input.charCodeAt(index++));

					if (digit >= base || digit > floor((maxInt - i) / w)) {
						error('overflow');
					}

					i += digit * w;
					t = k <= bias ? tMin : (k >= bias + tMax ? tMax : k - bias);

					if (digit < t) {
						break;
					}

					baseMinusT = base - t;
					if (w > floor(maxInt / baseMinusT)) {
						error('overflow');
					}

					w *= baseMinusT;

				}

				out = output.length + 1;
				bias = adapt(i - oldi, out, oldi == 0);

				// `i` was supposed to wrap around from `out` to `0`,
				// incrementing `n` each time, so we'll fix that now:
				if (floor(i / out) > maxInt - n) {
					error('overflow');
				}

				n += floor(i / out);
				i %= out;

				// Insert `n` at position `i` of the output
				output.splice(i++, 0, n);

			}

			return ucs2encode(output);
		}

		/**
		 * Converts a string of Unicode symbols (e.g. a domain name label) to a
		 * Punycode string of ASCII-only symbols.
		 * @memberOf punycode
		 * @param {String} input The string of Unicode symbols.
		 * @returns {String} The resulting Punycode string of ASCII-only symbols.
		 */
		function encode(input) {
			var n,
			    delta,
			    handledCPCount,
			    basicLength,
			    bias,
			    j,
			    m,
			    q,
			    k,
			    t,
			    currentValue,
			    output = [],
			    /** `inputLength` will hold the number of code points in `input`. */
			    inputLength,
			    /** Cached calculation results */
			    handledCPCountPlusOne,
			    baseMinusT,
			    qMinusT;

			// Convert the input in UCS-2 to Unicode
			input = ucs2decode(input);

			// Cache the length
			inputLength = input.length;

			// Initialize the state
			n = initialN;
			delta = 0;
			bias = initialBias;

			// Handle the basic code points
			for (j = 0; j < inputLength; ++j) {
				currentValue = input[j];
				if (currentValue < 0x80) {
					output.push(stringFromCharCode(currentValue));
				}
			}

			handledCPCount = basicLength = output.length;

			// `handledCPCount` is the number of code points that have been handled;
			// `basicLength` is the number of basic code points.

			// Finish the basic string - if it is not empty - with a delimiter
			if (basicLength) {
				output.push(delimiter);
			}

			// Main encoding loop:
			while (handledCPCount < inputLength) {

				// All non-basic code points < n have been handled already. Find the next
				// larger one:
				for (m = maxInt, j = 0; j < inputLength; ++j) {
					currentValue = input[j];
					if (currentValue >= n && currentValue < m) {
						m = currentValue;
					}
				}

				// Increase `delta` enough to advance the decoder's <n,i> state to <m,0>,
				// but guard against overflow
				handledCPCountPlusOne = handledCPCount + 1;
				if (m - n > floor((maxInt - delta) / handledCPCountPlusOne)) {
					error('overflow');
				}

				delta += (m - n) * handledCPCountPlusOne;
				n = m;

				for (j = 0; j < inputLength; ++j) {
					currentValue = input[j];

					if (currentValue < n && ++delta > maxInt) {
						error('overflow');
					}

					if (currentValue == n) {
						// Represent delta as a generalized variable-length integer
						for (q = delta, k = base; /* no condition */; k += base) {
							t = k <= bias ? tMin : (k >= bias + tMax ? tMax : k - bias);
							if (q < t) {
								break;
							}
							qMinusT = q - t;
							baseMinusT = base - t;
							output.push(
								stringFromCharCode(digitToBasic(t + qMinusT % baseMinusT, 0))
							);
							q = floor(qMinusT / baseMinusT);
						}

						output.push(stringFromCharCode(digitToBasic(q, 0)));
						bias = adapt(delta, handledCPCountPlusOne, handledCPCount == basicLength);
						delta = 0;
						++handledCPCount;
					}
				}

				++delta;
				++n;

			}
			return output.join('');
		}

		/**
		 * Converts a Punycode string representing a domain name or an email address
		 * to Unicode. Only the Punycoded parts of the input will be converted, i.e.
		 * it doesn't matter if you call it on a string that has already been
		 * converted to Unicode.
		 * @memberOf punycode
		 * @param {String} input The Punycoded domain name or email address to
		 * convert to Unicode.
		 * @returns {String} The Unicode representation of the given Punycode
		 * string.
		 */
		function toUnicode(input) {
			return mapDomain(input, function(string) {
				return regexPunycode.test(string)
					? decode(string.slice(4).toLowerCase())
					: string;
			});
		}

		/**
		 * Converts a Unicode string representing a domain name or an email address to
		 * Punycode. Only the non-ASCII parts of the domain name will be converted,
		 * i.e. it doesn't matter if you call it with a domain that's already in
		 * ASCII.
		 * @memberOf punycode
		 * @param {String} input The domain name or email address to convert, as a
		 * Unicode string.
		 * @returns {String} The Punycode representation of the given domain name or
		 * email address.
		 */
		function toASCII(input) {
			return mapDomain(input, function(string) {
				return regexNonASCII.test(string)
					? 'xn--' + encode(string)
					: string;
			});
		}

		/*--------------------------------------------------------------------------*/

		/** Define the public API */
		punycode = {
			/**
			 * A string representing the current Punycode.js version number.
			 * @memberOf punycode
			 * @type String
			 */
			'version': '1.3.2',
			/**
			 * An object of methods to convert from JavaScript's internal character
			 * representation (UCS-2) to Unicode code points, and back.
			 * @see <https://mathiasbynens.be/notes/javascript-encoding>
			 * @memberOf punycode
			 * @type Object
			 */
			'ucs2': {
				'decode': ucs2decode,
				'encode': ucs2encode
			},
			'decode': decode,
			'encode': encode,
			'toASCII': toASCII,
			'toUnicode': toUnicode
		};

		/** Expose `punycode` */
		// Some AMD build optimizers, like r.js, check for specific condition patterns
		// like the following:
		if (
			typeof undefined == 'function' &&
			typeof undefined.amd == 'object' &&
			undefined.amd
		) {
			undefined('punycode', function() {
				return punycode;
			});
		} else if (freeExports && freeModule) {
			if (module.exports == freeExports) { // in Node.js or RingoJS v0.8.0+
				freeModule.exports = punycode;
			} else { // in Narwhal or RingoJS v0.7.0-
				for (key in punycode) {
					punycode.hasOwnProperty(key) && (freeExports[key] = punycode[key]);
				}
			}
		} else { // in Rhino or a web browser
			root.punycode = punycode;
		}

	}(commonjsGlobal));
	});

	'use strict';

	var util = {
	  isString: function(arg) {
	    return typeof(arg) === 'string';
	  },
	  isObject: function(arg) {
	    return typeof(arg) === 'object' && arg !== null;
	  },
	  isNull: function(arg) {
	    return arg === null;
	  },
	  isNullOrUndefined: function(arg) {
	    return arg == null;
	  }
	};

	// Copyright Joyent, Inc. and other Node contributors.
	//
	// Permission is hereby granted, free of charge, to any person obtaining a
	// copy of this software and associated documentation files (the
	// "Software"), to deal in the Software without restriction, including
	// without limitation the rights to use, copy, modify, merge, publish,
	// distribute, sublicense, and/or sell copies of the Software, and to permit
	// persons to whom the Software is furnished to do so, subject to the
	// following conditions:
	//
	// The above copyright notice and this permission notice shall be included
	// in all copies or substantial portions of the Software.
	//
	// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
	// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
	// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
	// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
	// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
	// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
	// USE OR OTHER DEALINGS IN THE SOFTWARE.

	'use strict';

	// If obj.hasOwnProperty has been overridden, then calling
	// obj.hasOwnProperty(prop) will break.
	// See: https://github.com/joyent/node/issues/1707
	function hasOwnProperty(obj, prop) {
	  return Object.prototype.hasOwnProperty.call(obj, prop);
	}

	var decode = function(qs, sep, eq, options) {
	  sep = sep || '&';
	  eq = eq || '=';
	  var obj = {};

	  if (typeof qs !== 'string' || qs.length === 0) {
	    return obj;
	  }

	  var regexp = /\+/g;
	  qs = qs.split(sep);

	  var maxKeys = 1000;
	  if (options && typeof options.maxKeys === 'number') {
	    maxKeys = options.maxKeys;
	  }

	  var len = qs.length;
	  // maxKeys <= 0 means that we should not limit keys count
	  if (maxKeys > 0 && len > maxKeys) {
	    len = maxKeys;
	  }

	  for (var i = 0; i < len; ++i) {
	    var x = qs[i].replace(regexp, '%20'),
	        idx = x.indexOf(eq),
	        kstr, vstr, k, v;

	    if (idx >= 0) {
	      kstr = x.substr(0, idx);
	      vstr = x.substr(idx + 1);
	    } else {
	      kstr = x;
	      vstr = '';
	    }

	    k = decodeURIComponent(kstr);
	    v = decodeURIComponent(vstr);

	    if (!hasOwnProperty(obj, k)) {
	      obj[k] = v;
	    } else if (Array.isArray(obj[k])) {
	      obj[k].push(v);
	    } else {
	      obj[k] = [obj[k], v];
	    }
	  }

	  return obj;
	};

	// Copyright Joyent, Inc. and other Node contributors.
	//
	// Permission is hereby granted, free of charge, to any person obtaining a
	// copy of this software and associated documentation files (the
	// "Software"), to deal in the Software without restriction, including
	// without limitation the rights to use, copy, modify, merge, publish,
	// distribute, sublicense, and/or sell copies of the Software, and to permit
	// persons to whom the Software is furnished to do so, subject to the
	// following conditions:
	//
	// The above copyright notice and this permission notice shall be included
	// in all copies or substantial portions of the Software.
	//
	// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
	// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
	// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
	// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
	// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
	// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
	// USE OR OTHER DEALINGS IN THE SOFTWARE.

	'use strict';

	var stringifyPrimitive = function(v) {
	  switch (typeof v) {
	    case 'string':
	      return v;

	    case 'boolean':
	      return v ? 'true' : 'false';

	    case 'number':
	      return isFinite(v) ? v : '';

	    default:
	      return '';
	  }
	};

	var encode = function(obj, sep, eq, name) {
	  sep = sep || '&';
	  eq = eq || '=';
	  if (obj === null) {
	    obj = undefined;
	  }

	  if (typeof obj === 'object') {
	    return Object.keys(obj).map(function(k) {
	      var ks = encodeURIComponent(stringifyPrimitive(k)) + eq;
	      if (Array.isArray(obj[k])) {
	        return obj[k].map(function(v) {
	          return ks + encodeURIComponent(stringifyPrimitive(v));
	        }).join(sep);
	      } else {
	        return ks + encodeURIComponent(stringifyPrimitive(obj[k]));
	      }
	    }).join(sep);

	  }

	  if (!name) { return ''; }
	  return encodeURIComponent(stringifyPrimitive(name)) + eq +
	         encodeURIComponent(stringifyPrimitive(obj));
	};

	var querystring = createCommonjsModule(function (module, exports) {
	'use strict';

	exports.decode = exports.parse = decode;
	exports.encode = exports.stringify = encode;
	});

	// Copyright Joyent, Inc. and other Node contributors.
	//
	// Permission is hereby granted, free of charge, to any person obtaining a
	// copy of this software and associated documentation files (the
	// "Software"), to deal in the Software without restriction, including
	// without limitation the rights to use, copy, modify, merge, publish,
	// distribute, sublicense, and/or sell copies of the Software, and to permit
	// persons to whom the Software is furnished to do so, subject to the
	// following conditions:
	//
	// The above copyright notice and this permission notice shall be included
	// in all copies or substantial portions of the Software.
	//
	// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
	// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
	// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
	// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
	// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
	// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
	// USE OR OTHER DEALINGS IN THE SOFTWARE.

	'use strict';




	var parse = urlParse;
	var resolve = urlResolve;
	var resolveObject = urlResolveObject;
	var format = urlFormat;

	var Url_1 = Url;

	function Url() {
	  this.protocol = null;
	  this.slashes = null;
	  this.auth = null;
	  this.host = null;
	  this.port = null;
	  this.hostname = null;
	  this.hash = null;
	  this.search = null;
	  this.query = null;
	  this.pathname = null;
	  this.path = null;
	  this.href = null;
	}

	// Reference: RFC 3986, RFC 1808, RFC 2396

	// define these here so at least they only have to be
	// compiled once on the first module load.
	var protocolPattern = /^([a-z0-9.+-]+:)/i,
	    portPattern = /:[0-9]*$/,

	    // Special case for a simple path URL
	    simplePathPattern = /^(\/\/?(?!\/)[^\?\s]*)(\?[^\s]*)?$/,

	    // RFC 2396: characters reserved for delimiting URLs.
	    // We actually just auto-escape these.
	    delims = ['<', '>', '"', '`', ' ', '\r', '\n', '\t'],

	    // RFC 2396: characters not allowed for various reasons.
	    unwise = ['{', '}', '|', '\\', '^', '`'].concat(delims),

	    // Allowed by RFCs, but cause of XSS attacks.  Always escape these.
	    autoEscape = ['\''].concat(unwise),
	    // Characters that are never ever allowed in a hostname.
	    // Note that any invalid chars are also handled, but these
	    // are the ones that are *expected* to be seen, so we fast-path
	    // them.
	    nonHostChars = ['%', '/', '?', ';', '#'].concat(autoEscape),
	    hostEndingChars = ['/', '?', '#'],
	    hostnameMaxLen = 255,
	    hostnamePartPattern = /^[+a-z0-9A-Z_-]{0,63}$/,
	    hostnamePartStart = /^([+a-z0-9A-Z_-]{0,63})(.*)$/,
	    // protocols that can allow "unsafe" and "unwise" chars.
	    unsafeProtocol = {
	      'javascript': true,
	      'javascript:': true
	    },
	    // protocols that never have a hostname.
	    hostlessProtocol = {
	      'javascript': true,
	      'javascript:': true
	    },
	    // protocols that always contain a // bit.
	    slashedProtocol = {
	      'http': true,
	      'https': true,
	      'ftp': true,
	      'gopher': true,
	      'file': true,
	      'http:': true,
	      'https:': true,
	      'ftp:': true,
	      'gopher:': true,
	      'file:': true
	    };

	function urlParse(url, parseQueryString, slashesDenoteHost) {
	  if (url && util.isObject(url) && url instanceof Url) { return url; }

	  var u = new Url;
	  u.parse(url, parseQueryString, slashesDenoteHost);
	  return u;
	}

	Url.prototype.parse = function(url, parseQueryString, slashesDenoteHost) {
	  if (!util.isString(url)) {
	    throw new TypeError("Parameter 'url' must be a string, not " + typeof url);
	  }

	  // Copy chrome, IE, opera backslash-handling behavior.
	  // Back slashes before the query string get converted to forward slashes
	  // See: https://code.google.com/p/chromium/issues/detail?id=25916
	  var queryIndex = url.indexOf('?'),
	      splitter =
	          (queryIndex !== -1 && queryIndex < url.indexOf('#')) ? '?' : '#',
	      uSplit = url.split(splitter),
	      slashRegex = /\\/g;
	  uSplit[0] = uSplit[0].replace(slashRegex, '/');
	  url = uSplit.join(splitter);

	  var rest = url;

	  // trim before proceeding.
	  // This is to support parse stuff like "  http://foo.com  \n"
	  rest = rest.trim();

	  if (!slashesDenoteHost && url.split('#').length === 1) {
	    // Try fast path regexp
	    var simplePath = simplePathPattern.exec(rest);
	    if (simplePath) {
	      this.path = rest;
	      this.href = rest;
	      this.pathname = simplePath[1];
	      if (simplePath[2]) {
	        this.search = simplePath[2];
	        if (parseQueryString) {
	          this.query = querystring.parse(this.search.substr(1));
	        } else {
	          this.query = this.search.substr(1);
	        }
	      } else if (parseQueryString) {
	        this.search = '';
	        this.query = {};
	      }
	      return this;
	    }
	  }

	  var proto = protocolPattern.exec(rest);
	  if (proto) {
	    proto = proto[0];
	    var lowerProto = proto.toLowerCase();
	    this.protocol = lowerProto;
	    rest = rest.substr(proto.length);
	  }

	  // figure out if it's got a host
	  // user@server is *always* interpreted as a hostname, and url
	  // resolution will treat //foo/bar as host=foo,path=bar because that's
	  // how the browser resolves relative URLs.
	  if (slashesDenoteHost || proto || rest.match(/^\/\/[^@\/]+@[^@\/]+/)) {
	    var slashes = rest.substr(0, 2) === '//';
	    if (slashes && !(proto && hostlessProtocol[proto])) {
	      rest = rest.substr(2);
	      this.slashes = true;
	    }
	  }

	  if (!hostlessProtocol[proto] &&
	      (slashes || (proto && !slashedProtocol[proto]))) {

	    // there's a hostname.
	    // the first instance of /, ?, ;, or # ends the host.
	    //
	    // If there is an @ in the hostname, then non-host chars *are* allowed
	    // to the left of the last @ sign, unless some host-ending character
	    // comes *before* the @-sign.
	    // URLs are obnoxious.
	    //
	    // ex:
	    // http://a@b@c/ => user:a@b host:c
	    // http://a@b?@c => user:a host:c path:/?@c

	    // v0.12 TODO(isaacs): This is not quite how Chrome does things.
	    // Review our test case against browsers more comprehensively.

	    // find the first instance of any hostEndingChars
	    var hostEnd = -1;
	    for (var i = 0; i < hostEndingChars.length; i++) {
	      var hec = rest.indexOf(hostEndingChars[i]);
	      if (hec !== -1 && (hostEnd === -1 || hec < hostEnd))
	        { hostEnd = hec; }
	    }

	    // at this point, either we have an explicit point where the
	    // auth portion cannot go past, or the last @ char is the decider.
	    var auth, atSign;
	    if (hostEnd === -1) {
	      // atSign can be anywhere.
	      atSign = rest.lastIndexOf('@');
	    } else {
	      // atSign must be in auth portion.
	      // http://a@b/c@d => host:b auth:a path:/c@d
	      atSign = rest.lastIndexOf('@', hostEnd);
	    }

	    // Now we have a portion which is definitely the auth.
	    // Pull that off.
	    if (atSign !== -1) {
	      auth = rest.slice(0, atSign);
	      rest = rest.slice(atSign + 1);
	      this.auth = decodeURIComponent(auth);
	    }

	    // the host is the remaining to the left of the first non-host char
	    hostEnd = -1;
	    for (var i = 0; i < nonHostChars.length; i++) {
	      var hec = rest.indexOf(nonHostChars[i]);
	      if (hec !== -1 && (hostEnd === -1 || hec < hostEnd))
	        { hostEnd = hec; }
	    }
	    // if we still have not hit it, then the entire thing is a host.
	    if (hostEnd === -1)
	      { hostEnd = rest.length; }

	    this.host = rest.slice(0, hostEnd);
	    rest = rest.slice(hostEnd);

	    // pull out port.
	    this.parseHost();

	    // we've indicated that there is a hostname,
	    // so even if it's empty, it has to be present.
	    this.hostname = this.hostname || '';

	    // if hostname begins with [ and ends with ]
	    // assume that it's an IPv6 address.
	    var ipv6Hostname = this.hostname[0] === '[' &&
	        this.hostname[this.hostname.length - 1] === ']';

	    // validate a little.
	    if (!ipv6Hostname) {
	      var hostparts = this.hostname.split(/\./);
	      for (var i = 0, l = hostparts.length; i < l; i++) {
	        var part = hostparts[i];
	        if (!part) { continue; }
	        if (!part.match(hostnamePartPattern)) {
	          var newpart = '';
	          for (var j = 0, k = part.length; j < k; j++) {
	            if (part.charCodeAt(j) > 127) {
	              // we replace non-ASCII char with a temporary placeholder
	              // we need this to make sure size of hostname is not
	              // broken by replacing non-ASCII by nothing
	              newpart += 'x';
	            } else {
	              newpart += part[j];
	            }
	          }
	          // we test again with ASCII char only
	          if (!newpart.match(hostnamePartPattern)) {
	            var validParts = hostparts.slice(0, i);
	            var notHost = hostparts.slice(i + 1);
	            var bit = part.match(hostnamePartStart);
	            if (bit) {
	              validParts.push(bit[1]);
	              notHost.unshift(bit[2]);
	            }
	            if (notHost.length) {
	              rest = '/' + notHost.join('.') + rest;
	            }
	            this.hostname = validParts.join('.');
	            break;
	          }
	        }
	      }
	    }

	    if (this.hostname.length > hostnameMaxLen) {
	      this.hostname = '';
	    } else {
	      // hostnames are always lower case.
	      this.hostname = this.hostname.toLowerCase();
	    }

	    if (!ipv6Hostname) {
	      // IDNA Support: Returns a punycoded representation of "domain".
	      // It only converts parts of the domain name that
	      // have non-ASCII characters, i.e. it doesn't matter if
	      // you call it with a domain that already is ASCII-only.
	      this.hostname = punycode.toASCII(this.hostname);
	    }

	    var p = this.port ? ':' + this.port : '';
	    var h = this.hostname || '';
	    this.host = h + p;
	    this.href += this.host;

	    // strip [ and ] from the hostname
	    // the host field still retains them, though
	    if (ipv6Hostname) {
	      this.hostname = this.hostname.substr(1, this.hostname.length - 2);
	      if (rest[0] !== '/') {
	        rest = '/' + rest;
	      }
	    }
	  }

	  // now rest is set to the post-host stuff.
	  // chop off any delim chars.
	  if (!unsafeProtocol[lowerProto]) {

	    // First, make 100% sure that any "autoEscape" chars get
	    // escaped, even if encodeURIComponent doesn't think they
	    // need to be.
	    for (var i = 0, l = autoEscape.length; i < l; i++) {
	      var ae = autoEscape[i];
	      if (rest.indexOf(ae) === -1)
	        { continue; }
	      var esc = encodeURIComponent(ae);
	      if (esc === ae) {
	        esc = escape(ae);
	      }
	      rest = rest.split(ae).join(esc);
	    }
	  }


	  // chop off from the tail first.
	  var hash = rest.indexOf('#');
	  if (hash !== -1) {
	    // got a fragment string.
	    this.hash = rest.substr(hash);
	    rest = rest.slice(0, hash);
	  }
	  var qm = rest.indexOf('?');
	  if (qm !== -1) {
	    this.search = rest.substr(qm);
	    this.query = rest.substr(qm + 1);
	    if (parseQueryString) {
	      this.query = querystring.parse(this.query);
	    }
	    rest = rest.slice(0, qm);
	  } else if (parseQueryString) {
	    // no query string, but parseQueryString still requested
	    this.search = '';
	    this.query = {};
	  }
	  if (rest) { this.pathname = rest; }
	  if (slashedProtocol[lowerProto] &&
	      this.hostname && !this.pathname) {
	    this.pathname = '/';
	  }

	  //to support http.request
	  if (this.pathname || this.search) {
	    var p = this.pathname || '';
	    var s = this.search || '';
	    this.path = p + s;
	  }

	  // finally, reconstruct the href based on what has been validated.
	  this.href = this.format();
	  return this;
	};

	// format a parsed object into a url string
	function urlFormat(obj) {
	  // ensure it's an object, and not a string url.
	  // If it's an obj, this is a no-op.
	  // this way, you can call url_format() on strings
	  // to clean up potentially wonky urls.
	  if (util.isString(obj)) { obj = urlParse(obj); }
	  if (!(obj instanceof Url)) { return Url.prototype.format.call(obj); }
	  return obj.format();
	}

	Url.prototype.format = function() {
	  var auth = this.auth || '';
	  if (auth) {
	    auth = encodeURIComponent(auth);
	    auth = auth.replace(/%3A/i, ':');
	    auth += '@';
	  }

	  var protocol = this.protocol || '',
	      pathname = this.pathname || '',
	      hash = this.hash || '',
	      host = false,
	      query = '';

	  if (this.host) {
	    host = auth + this.host;
	  } else if (this.hostname) {
	    host = auth + (this.hostname.indexOf(':') === -1 ?
	        this.hostname :
	        '[' + this.hostname + ']');
	    if (this.port) {
	      host += ':' + this.port;
	    }
	  }

	  if (this.query &&
	      util.isObject(this.query) &&
	      Object.keys(this.query).length) {
	    query = querystring.stringify(this.query);
	  }

	  var search = this.search || (query && ('?' + query)) || '';

	  if (protocol && protocol.substr(-1) !== ':') { protocol += ':'; }

	  // only the slashedProtocols get the //.  Not mailto:, xmpp:, etc.
	  // unless they had them to begin with.
	  if (this.slashes ||
	      (!protocol || slashedProtocol[protocol]) && host !== false) {
	    host = '//' + (host || '');
	    if (pathname && pathname.charAt(0) !== '/') { pathname = '/' + pathname; }
	  } else if (!host) {
	    host = '';
	  }

	  if (hash && hash.charAt(0) !== '#') { hash = '#' + hash; }
	  if (search && search.charAt(0) !== '?') { search = '?' + search; }

	  pathname = pathname.replace(/[?#]/g, function(match) {
	    return encodeURIComponent(match);
	  });
	  search = search.replace('#', '%23');

	  return protocol + host + pathname + search + hash;
	};

	function urlResolve(source, relative) {
	  return urlParse(source, false, true).resolve(relative);
	}

	Url.prototype.resolve = function(relative) {
	  return this.resolveObject(urlParse(relative, false, true)).format();
	};

	function urlResolveObject(source, relative) {
	  if (!source) { return relative; }
	  return urlParse(source, false, true).resolveObject(relative);
	}

	Url.prototype.resolveObject = function(relative) {
	  if (util.isString(relative)) {
	    var rel = new Url();
	    rel.parse(relative, false, true);
	    relative = rel;
	  }

	  var result = new Url();
	  var tkeys = Object.keys(this);
	  for (var tk = 0; tk < tkeys.length; tk++) {
	    var tkey = tkeys[tk];
	    result[tkey] = this[tkey];
	  }

	  // hash is always overridden, no matter what.
	  // even href="" will remove it.
	  result.hash = relative.hash;

	  // if the relative url is empty, then there's nothing left to do here.
	  if (relative.href === '') {
	    result.href = result.format();
	    return result;
	  }

	  // hrefs like //foo/bar always cut to the protocol.
	  if (relative.slashes && !relative.protocol) {
	    // take everything except the protocol from relative
	    var rkeys = Object.keys(relative);
	    for (var rk = 0; rk < rkeys.length; rk++) {
	      var rkey = rkeys[rk];
	      if (rkey !== 'protocol')
	        { result[rkey] = relative[rkey]; }
	    }

	    //urlParse appends trailing / to urls like http://www.example.com
	    if (slashedProtocol[result.protocol] &&
	        result.hostname && !result.pathname) {
	      result.path = result.pathname = '/';
	    }

	    result.href = result.format();
	    return result;
	  }

	  if (relative.protocol && relative.protocol !== result.protocol) {
	    // if it's a known url protocol, then changing
	    // the protocol does weird things
	    // first, if it's not file:, then we MUST have a host,
	    // and if there was a path
	    // to begin with, then we MUST have a path.
	    // if it is file:, then the host is dropped,
	    // because that's known to be hostless.
	    // anything else is assumed to be absolute.
	    if (!slashedProtocol[relative.protocol]) {
	      var keys = Object.keys(relative);
	      for (var v = 0; v < keys.length; v++) {
	        var k = keys[v];
	        result[k] = relative[k];
	      }
	      result.href = result.format();
	      return result;
	    }

	    result.protocol = relative.protocol;
	    if (!relative.host && !hostlessProtocol[relative.protocol]) {
	      var relPath = (relative.pathname || '').split('/');
	      while (relPath.length && !(relative.host = relPath.shift())){ ; }
	      if (!relative.host) { relative.host = ''; }
	      if (!relative.hostname) { relative.hostname = ''; }
	      if (relPath[0] !== '') { relPath.unshift(''); }
	      if (relPath.length < 2) { relPath.unshift(''); }
	      result.pathname = relPath.join('/');
	    } else {
	      result.pathname = relative.pathname;
	    }
	    result.search = relative.search;
	    result.query = relative.query;
	    result.host = relative.host || '';
	    result.auth = relative.auth;
	    result.hostname = relative.hostname || relative.host;
	    result.port = relative.port;
	    // to support http.request
	    if (result.pathname || result.search) {
	      var p = result.pathname || '';
	      var s = result.search || '';
	      result.path = p + s;
	    }
	    result.slashes = result.slashes || relative.slashes;
	    result.href = result.format();
	    return result;
	  }

	  var isSourceAbs = (result.pathname && result.pathname.charAt(0) === '/'),
	      isRelAbs = (
	          relative.host ||
	          relative.pathname && relative.pathname.charAt(0) === '/'
	      ),
	      mustEndAbs = (isRelAbs || isSourceAbs ||
	                    (result.host && relative.pathname)),
	      removeAllDots = mustEndAbs,
	      srcPath = result.pathname && result.pathname.split('/') || [],
	      relPath = relative.pathname && relative.pathname.split('/') || [],
	      psychotic = result.protocol && !slashedProtocol[result.protocol];

	  // if the url is a non-slashed url, then relative
	  // links like ../.. should be able
	  // to crawl up to the hostname, as well.  This is strange.
	  // result.protocol has already been set by now.
	  // Later on, put the first path part into the host field.
	  if (psychotic) {
	    result.hostname = '';
	    result.port = null;
	    if (result.host) {
	      if (srcPath[0] === '') { srcPath[0] = result.host; }
	      else { srcPath.unshift(result.host); }
	    }
	    result.host = '';
	    if (relative.protocol) {
	      relative.hostname = null;
	      relative.port = null;
	      if (relative.host) {
	        if (relPath[0] === '') { relPath[0] = relative.host; }
	        else { relPath.unshift(relative.host); }
	      }
	      relative.host = null;
	    }
	    mustEndAbs = mustEndAbs && (relPath[0] === '' || srcPath[0] === '');
	  }

	  if (isRelAbs) {
	    // it's absolute.
	    result.host = (relative.host || relative.host === '') ?
	                  relative.host : result.host;
	    result.hostname = (relative.hostname || relative.hostname === '') ?
	                      relative.hostname : result.hostname;
	    result.search = relative.search;
	    result.query = relative.query;
	    srcPath = relPath;
	    // fall through to the dot-handling below.
	  } else if (relPath.length) {
	    // it's relative
	    // throw away the existing file, and take the new path instead.
	    if (!srcPath) { srcPath = []; }
	    srcPath.pop();
	    srcPath = srcPath.concat(relPath);
	    result.search = relative.search;
	    result.query = relative.query;
	  } else if (!util.isNullOrUndefined(relative.search)) {
	    // just pull out the search.
	    // like href='?foo'.
	    // Put this after the other two cases because it simplifies the booleans
	    if (psychotic) {
	      result.hostname = result.host = srcPath.shift();
	      //occationaly the auth can get stuck only in host
	      //this especially happens in cases like
	      //url.resolveObject('mailto:local1@domain1', 'local2@domain2')
	      var authInHost = result.host && result.host.indexOf('@') > 0 ?
	                       result.host.split('@') : false;
	      if (authInHost) {
	        result.auth = authInHost.shift();
	        result.host = result.hostname = authInHost.shift();
	      }
	    }
	    result.search = relative.search;
	    result.query = relative.query;
	    //to support http.request
	    if (!util.isNull(result.pathname) || !util.isNull(result.search)) {
	      result.path = (result.pathname ? result.pathname : '') +
	                    (result.search ? result.search : '');
	    }
	    result.href = result.format();
	    return result;
	  }

	  if (!srcPath.length) {
	    // no path at all.  easy.
	    // we've already handled the other stuff above.
	    result.pathname = null;
	    //to support http.request
	    if (result.search) {
	      result.path = '/' + result.search;
	    } else {
	      result.path = null;
	    }
	    result.href = result.format();
	    return result;
	  }

	  // if a url ENDs in . or .., then it must get a trailing slash.
	  // however, if it ends in anything else non-slashy,
	  // then it must NOT get a trailing slash.
	  var last = srcPath.slice(-1)[0];
	  var hasTrailingSlash = (
	      (result.host || relative.host || srcPath.length > 1) &&
	      (last === '.' || last === '..') || last === '');

	  // strip single dots, resolve double dots to parent dir
	  // if the path tries to go above the root, `up` ends up > 0
	  var up = 0;
	  for (var i = srcPath.length; i >= 0; i--) {
	    last = srcPath[i];
	    if (last === '.') {
	      srcPath.splice(i, 1);
	    } else if (last === '..') {
	      srcPath.splice(i, 1);
	      up++;
	    } else if (up) {
	      srcPath.splice(i, 1);
	      up--;
	    }
	  }

	  // if the path is allowed to go above the root, restore leading ..s
	  if (!mustEndAbs && !removeAllDots) {
	    for (; up--; up) {
	      srcPath.unshift('..');
	    }
	  }

	  if (mustEndAbs && srcPath[0] !== '' &&
	      (!srcPath[0] || srcPath[0].charAt(0) !== '/')) {
	    srcPath.unshift('');
	  }

	  if (hasTrailingSlash && (srcPath.join('/').substr(-1) !== '/')) {
	    srcPath.push('');
	  }

	  var isAbsolute = srcPath[0] === '' ||
	      (srcPath[0] && srcPath[0].charAt(0) === '/');

	  // put the host back
	  if (psychotic) {
	    result.hostname = result.host = isAbsolute ? '' :
	                                    srcPath.length ? srcPath.shift() : '';
	    //occationaly the auth can get stuck only in host
	    //this especially happens in cases like
	    //url.resolveObject('mailto:local1@domain1', 'local2@domain2')
	    var authInHost = result.host && result.host.indexOf('@') > 0 ?
	                     result.host.split('@') : false;
	    if (authInHost) {
	      result.auth = authInHost.shift();
	      result.host = result.hostname = authInHost.shift();
	    }
	  }

	  mustEndAbs = mustEndAbs || (result.host && srcPath.length);

	  if (mustEndAbs && !isAbsolute) {
	    srcPath.unshift('');
	  }

	  if (!srcPath.length) {
	    result.pathname = null;
	    result.path = null;
	  } else {
	    result.pathname = srcPath.join('/');
	  }

	  //to support request.http
	  if (!util.isNull(result.pathname) || !util.isNull(result.search)) {
	    result.path = (result.pathname ? result.pathname : '') +
	                  (result.search ? result.search : '');
	  }
	  result.auth = relative.auth || result.auth;
	  result.slashes = result.slashes || relative.slashes;
	  result.href = result.format();
	  return result;
	};

	Url.prototype.parseHost = function() {
	  var host = this.host;
	  var port = portPattern.exec(host);
	  if (port) {
	    port = port[0];
	    if (port !== ':') {
	      this.port = port.substr(1);
	    }
	    host = host.substr(0, host.length - port.length);
	  }
	  if (host) { this.hostname = host; }
	};

	var url$1 = {
		parse: parse,
		resolve: resolve,
		resolveObject: resolveObject,
		format: format,
		Url: Url_1
	};

	/**
	 * This file contains redeclared types for Node `url` and `querystring` modules. These modules
	 * don't provide their own typings but instead are a part of the full Node typings. The purpose of
	 * this file is to redeclare the required types to avoid having the whole Node types as a
	 * dependency.
	 */
	var url = {
	    parse: parse,
	    format: format,
	    resolve: resolve,
	};

	function assertPath(path) {
	    if (typeof path !== 'string') {
	        throw new TypeError("Path must be a string. Received " + JSON.stringify(path));
	    }
	}
	function escapeRegExp(string) {
	    return string.replace(/[.*+?^${}()|[\]\\]/g, '\\$&'); // $& means the whole matched string
	}
	function replaceAll(str, find, replace) {
	    return str.replace(new RegExp(escapeRegExp(find), 'g'), replace);
	}
	// Resolves . and .. elements in a path with directory names
	function normalizeStringPosix(path, allowAboveRoot) {
	    var res = '';
	    var lastSegmentLength = 0;
	    var lastSlash = -1;
	    var dots = 0;
	    var code;
	    for (var i = 0; i <= path.length; ++i) {
	        if (i < path.length) {
	            code = path.charCodeAt(i);
	        }
	        else if (code === 47) {
	            break;
	        }
	        else {
	            code = 47;
	        }
	        if (code === 47) {
	            if (lastSlash === i - 1 || dots === 1) {
	                // NOOP
	            }
	            else if (lastSlash !== i - 1 && dots === 2) {
	                if (res.length < 2
	                    || lastSegmentLength !== 2
	                    || res.charCodeAt(res.length - 1) !== 46
	                    || res.charCodeAt(res.length - 2) !== 46) {
	                    if (res.length > 2) {
	                        var lastSlashIndex = res.lastIndexOf('/');
	                        if (lastSlashIndex !== res.length - 1) {
	                            if (lastSlashIndex === -1) {
	                                res = '';
	                                lastSegmentLength = 0;
	                            }
	                            else {
	                                res = res.slice(0, lastSlashIndex);
	                                lastSegmentLength = res.length - 1 - res.lastIndexOf('/');
	                            }
	                            lastSlash = i;
	                            dots = 0;
	                            continue;
	                        }
	                    }
	                    else if (res.length === 2 || res.length === 1) {
	                        res = '';
	                        lastSegmentLength = 0;
	                        lastSlash = i;
	                        dots = 0;
	                        continue;
	                    }
	                }
	                if (allowAboveRoot) {
	                    if (res.length > 0) {
	                        res += '/..';
	                    }
	                    else {
	                        res = '..';
	                    }
	                    lastSegmentLength = 2;
	                }
	            }
	            else {
	                if (res.length > 0) {
	                    res += "/" + path.slice(lastSlash + 1, i);
	                }
	                else {
	                    res = path.slice(lastSlash + 1, i);
	                }
	                lastSegmentLength = i - lastSlash - 1;
	            }
	            lastSlash = i;
	            dots = 0;
	        }
	        else if (code === 46 && dots !== -1) {
	            ++dots;
	        }
	        else {
	            dots = -1;
	        }
	    }
	    return res;
	}
	var path = {
	    /**
	     * Converts a path to posix format.
	     * @param path - The path to convert to posix
	     */
	    toPosix: function (path) { return replaceAll(path, '\\', '/'); },
	    /**
	     * Checks if the path is a URL
	     * @param path - The path to check
	     */
	    isUrl: function (path) { return (/^https?:/).test(this.toPosix(path)); },
	    /**
	     * Checks if the path is a data URL
	     * @param path - The path to check
	     */
	    isDataUrl: function (path) {
	        // eslint-disable-next-line max-len
	        return (/^data:([a-z]+\/[a-z0-9-+.]+(;[a-z0-9-.!#$%*+.{}|~`]+=[a-z0-9-.!#$%*+.{}()_|~`]+)*)?(;base64)?,([a-z0-9!$&',()*+;=\-._~:@\/?%\s<>]*?)$/i)
	            .test(path);
	    },
	    /**
	     * Checks if the path has a protocol e.g. http://
	     * This will return true for windows file paths
	     * @param path - The path to check
	     */
	    hasProtocol: function (path) { return (/^[^/:]+:\//).test(this.toPosix(path)); },
	    /**
	     * Returns the protocol of the path e.g. http://, C:/, file:///
	     * @param path - The path to get the protocol from
	     */
	    getProtocol: function (path) {
	        assertPath(path);
	        path = this.toPosix(path);
	        var protocol = '';
	        var isFile = (/^file:\/\/\//).exec(path);
	        var isHttp = (/^[^/:]+:\/\//).exec(path);
	        var isWindows = (/^[^/:]+:\//).exec(path);
	        if (isFile || isHttp || isWindows) {
	            var arr = (isFile === null || isFile === void 0 ? void 0 : isFile[0]) || (isHttp === null || isHttp === void 0 ? void 0 : isHttp[0]) || (isWindows === null || isWindows === void 0 ? void 0 : isWindows[0]);
	            protocol = arr;
	            path = path.slice(arr.length);
	        }
	        return protocol;
	    },
	    /**
	     * Converts URL to an absolute path.
	     * When loading from a Web Worker, we must use absolute paths.
	     * If the URL is already absolute we return it as is
	     * If it's not, we convert it
	     * @param url - The URL to test
	     * @param customBaseUrl - The base URL to use
	     * @param customRootUrl - The root URL to use
	     */
	    toAbsolute: function (url, customBaseUrl, customRootUrl) {
	        if (this.isDataUrl(url))
	            { return url; }
	        var baseUrl = this.toPosix(customBaseUrl !== null && customBaseUrl !== void 0 ? customBaseUrl : settings.settings.ADAPTER.getBaseUrl());
	        var rootUrl = this.toPosix(customRootUrl !== null && customRootUrl !== void 0 ? customRootUrl : this.rootname(baseUrl));
	        assertPath(url);
	        url = this.toPosix(url);
	        // root relative url
	        if (url.startsWith('/')) {
	            return path.join(rootUrl, url.slice(1));
	        }
	        var absolutePath = this.isAbsolute(url) ? url : this.join(baseUrl, url);
	        return absolutePath;
	    },
	    /**
	     * Normalizes the given path, resolving '..' and '.' segments
	     * @param path - The path to normalize
	     */
	    normalize: function (path) {
	        path = this.toPosix(path);
	        assertPath(path);
	        if (path.length === 0)
	            { return '.'; }
	        var protocol = '';
	        var isAbsolute = path.startsWith('/');
	        if (this.hasProtocol(path)) {
	            protocol = this.rootname(path);
	            path = path.slice(protocol.length);
	        }
	        var trailingSeparator = path.endsWith('/');
	        // Normalize the path
	        path = normalizeStringPosix(path, false);
	        if (path.length > 0 && trailingSeparator)
	            { path += '/'; }
	        if (isAbsolute)
	            { return "/" + path; }
	        return protocol + path;
	    },
	    /**
	     * Determines if path is an absolute path.
	     * Absolute paths can be urls, data urls, or paths on disk
	     * @param path - The path to test
	     */
	    isAbsolute: function (path) {
	        assertPath(path);
	        path = this.toPosix(path);
	        if (this.hasProtocol(path))
	            { return true; }
	        return path.startsWith('/');
	    },
	    /**
	     * Joins all given path segments together using the platform-specific separator as a delimiter,
	     * then normalizes the resulting path
	     * @param segments - The segments of the path to join
	     */
	    join: function () {
	        var arguments$1 = arguments;

	        var segments = [];
	        for (var _i = 0; _i < arguments.length; _i++) {
	            segments[_i] = arguments$1[_i];
	        }
	        if (segments.length === 0) {
	            return '.';
	        }
	        var joined;
	        for (var i = 0; i < segments.length; ++i) {
	            var arg = segments[i];
	            assertPath(arg);
	            if (arg.length > 0) {
	                if (joined === undefined)
	                    { joined = arg; }
	                else
	                    { joined += "/" + arg; }
	            }
	        }
	        if (joined === undefined) {
	            return '.';
	        }
	        return this.normalize(joined);
	    },
	    /**
	     * Returns the directory name of a path
	     * @param path - The path to parse
	     */
	    dirname: function (path) {
	        assertPath(path);
	        if (path.length === 0)
	            { return '.'; }
	        path = this.toPosix(path);
	        var code = path.charCodeAt(0);
	        var hasRoot = code === 47;
	        var end = -1;
	        var matchedSlash = true;
	        var proto = this.getProtocol(path);
	        var origpath = path;
	        path = path.slice(proto.length);
	        for (var i = path.length - 1; i >= 1; --i) {
	            code = path.charCodeAt(i);
	            if (code === 47) {
	                if (!matchedSlash) {
	                    end = i;
	                    break;
	                }
	            }
	            else {
	                // We saw the first non-path separator
	                matchedSlash = false;
	            }
	        }
	        // if end is -1 and its a url then we need to add the path back
	        // eslint-disable-next-line no-nested-ternary
	        if (end === -1)
	            { return hasRoot ? '/' : this.isUrl(origpath) ? proto + path : proto; }
	        if (hasRoot && end === 1)
	            { return '//'; }
	        return proto + path.slice(0, end);
	    },
	    /**
	     * Returns the root of the path e.g. /, C:/, file:///, http://domain.com/
	     * @param path - The path to parse
	     */
	    rootname: function (path) {
	        assertPath(path);
	        path = this.toPosix(path);
	        var root = '';
	        if (path.startsWith('/'))
	            { root = '/'; }
	        else {
	            root = this.getProtocol(path);
	        }
	        if (this.isUrl(path)) {
	            // need to find the first path separator
	            var index = path.indexOf('/', root.length);
	            if (index !== -1) {
	                root = path.slice(0, index);
	            }
	            else
	                { root = path; }
	            if (!root.endsWith('/'))
	                { root += '/'; }
	        }
	        return root;
	    },
	    /**
	     * Returns the last portion of a path
	     * @param path - The path to test
	     * @param ext - Optional extension to remove
	     */
	    basename: function (path, ext) {
	        assertPath(path);
	        if (ext)
	            { assertPath(ext); }
	        path = this.toPosix(path);
	        var start = 0;
	        var end = -1;
	        var matchedSlash = true;
	        var i;
	        if (ext !== undefined && ext.length > 0 && ext.length <= path.length) {
	            if (ext.length === path.length && ext === path)
	                { return ''; }
	            var extIdx = ext.length - 1;
	            var firstNonSlashEnd = -1;
	            for (i = path.length - 1; i >= 0; --i) {
	                var code = path.charCodeAt(i);
	                if (code === 47) {
	                    // If we reached a path separator that was not part of a set of path
	                    // separators at the end of the string, stop now
	                    if (!matchedSlash) {
	                        start = i + 1;
	                        break;
	                    }
	                }
	                else {
	                    if (firstNonSlashEnd === -1) {
	                        // We saw the first non-path separator, remember this index in case
	                        // we need it if the extension ends up not matching
	                        matchedSlash = false;
	                        firstNonSlashEnd = i + 1;
	                    }
	                    if (extIdx >= 0) {
	                        // Try to match the explicit extension
	                        if (code === ext.charCodeAt(extIdx)) {
	                            if (--extIdx === -1) {
	                                // We matched the extension, so mark this as the end of our path
	                                // component
	                                end = i;
	                            }
	                        }
	                        else {
	                            // Extension does not match, so our result is the entire path
	                            // component
	                            extIdx = -1;
	                            end = firstNonSlashEnd;
	                        }
	                    }
	                }
	            }
	            if (start === end)
	                { end = firstNonSlashEnd; }
	            else if (end === -1)
	                { end = path.length; }
	            return path.slice(start, end);
	        }
	        for (i = path.length - 1; i >= 0; --i) {
	            if (path.charCodeAt(i) === 47) {
	                // If we reached a path separator that was not part of a set of path
	                // separators at the end of the string, stop now
	                if (!matchedSlash) {
	                    start = i + 1;
	                    break;
	                }
	            }
	            else if (end === -1) {
	                // We saw the first non-path separator, mark this as the end of our
	                // path component
	                matchedSlash = false;
	                end = i + 1;
	            }
	        }
	        if (end === -1)
	            { return ''; }
	        return path.slice(start, end);
	    },
	    /**
	     * Returns the extension of the path, from the last occurrence of the . (period) character to end of string in the last
	     * portion of the path. If there is no . in the last portion of the path, or if there are no . characters other than
	     * the first character of the basename of path, an empty string is returned.
	     * @param path - The path to parse
	     */
	    extname: function (path) {
	        assertPath(path);
	        path = this.toPosix(path);
	        var startDot = -1;
	        var startPart = 0;
	        var end = -1;
	        var matchedSlash = true;
	        // Track the state of characters (if any) we see before our first dot and
	        // after any path separator we find
	        var preDotState = 0;
	        for (var i = path.length - 1; i >= 0; --i) {
	            var code = path.charCodeAt(i);
	            if (code === 47) {
	                // If we reached a path separator that was not part of a set of path
	                // separators at the end of the string, stop now
	                if (!matchedSlash) {
	                    startPart = i + 1;
	                    break;
	                }
	                continue;
	            }
	            if (end === -1) {
	                // We saw the first non-path separator, mark this as the end of our
	                // extension
	                matchedSlash = false;
	                end = i + 1;
	            }
	            if (code === 46) {
	                // If this is our first dot, mark it as the start of our extension
	                if (startDot === -1)
	                    { startDot = i; }
	                else if (preDotState !== 1)
	                    { preDotState = 1; }
	            }
	            else if (startDot !== -1) {
	                // We saw a non-dot and non-path separator before our dot, so we should
	                // have a good chance at having a non-empty extension
	                preDotState = -1;
	            }
	        }
	        if (startDot === -1 || end === -1
	            // We saw a non-dot character immediately before the dot
	            || preDotState === 0
	            // The (right-most) trimmed path component is exactly '..'
	            // eslint-disable-next-line no-mixed-operators
	            || preDotState === 1 && startDot === end - 1 && startDot === startPart + 1) {
	            return '';
	        }
	        return path.slice(startDot, end);
	    },
	    /**
	     * Parses a path into an object containing the 'root', `dir`, `base`, `ext`, and `name` properties.
	     * @param path - The path to parse
	     */
	    parse: function (path) {
	        assertPath(path);
	        var ret = { root: '', dir: '', base: '', ext: '', name: '' };
	        if (path.length === 0)
	            { return ret; }
	        path = this.toPosix(path);
	        var code = path.charCodeAt(0);
	        var isAbsolute = this.isAbsolute(path);
	        var start;
	        var protocol = '';
	        ret.root = this.rootname(path);
	        if (isAbsolute || this.hasProtocol(path)) {
	            start = 1;
	        }
	        else {
	            start = 0;
	        }
	        var startDot = -1;
	        var startPart = 0;
	        var end = -1;
	        var matchedSlash = true;
	        var i = path.length - 1;
	        // Track the state of characters (if any) we see before our first dot and
	        // after any path separator we find
	        var preDotState = 0;
	        // Get non-dir info
	        for (; i >= start; --i) {
	            code = path.charCodeAt(i);
	            if (code === 47) {
	                // If we reached a path separator that was not part of a set of path
	                // separators at the end of the string, stop now
	                if (!matchedSlash) {
	                    startPart = i + 1;
	                    break;
	                }
	                continue;
	            }
	            if (end === -1) {
	                // We saw the first non-path separator, mark this as the end of our
	                // extension
	                matchedSlash = false;
	                end = i + 1;
	            }
	            if (code === 46) {
	                // If this is our first dot, mark it as the start of our extension
	                if (startDot === -1)
	                    { startDot = i; }
	                else if (preDotState !== 1)
	                    { preDotState = 1; }
	            }
	            else if (startDot !== -1) {
	                // We saw a non-dot and non-path separator before our dot, so we should
	                // have a good chance at having a non-empty extension
	                preDotState = -1;
	            }
	        }
	        if (startDot === -1 || end === -1
	            // We saw a non-dot character immediately before the dot
	            || preDotState === 0
	            // The (right-most) trimmed path component is exactly '..'
	            // eslint-disable-next-line no-mixed-operators
	            || preDotState === 1 && startDot === end - 1 && startDot === startPart + 1) {
	            if (end !== -1) {
	                if (startPart === 0 && isAbsolute)
	                    { ret.base = ret.name = path.slice(1, end); }
	                else
	                    { ret.base = ret.name = path.slice(startPart, end); }
	            }
	        }
	        else {
	            if (startPart === 0 && isAbsolute) {
	                ret.name = path.slice(1, startDot);
	                ret.base = path.slice(1, end);
	            }
	            else {
	                ret.name = path.slice(startPart, startDot);
	                ret.base = path.slice(startPart, end);
	            }
	            ret.ext = path.slice(startDot, end);
	        }
	        ret.dir = this.dirname(path);
	        if (protocol)
	            { ret.dir = protocol + ret.dir; }
	        return ret;
	    },
	    sep: '/',
	    delimiter: ':'
	};

	/**
	 * The prefix that denotes a URL is for a retina asset.
	 * @static
	 * @name RETINA_PREFIX
	 * @memberof PIXI.settings
	 * @type {RegExp}
	 * @default /@([0-9\.]+)x/
	 * @example `@2x`
	 */
	settings.settings.RETINA_PREFIX = /@([0-9\.]+)x/;
	/**
	 * Should the `failIfMajorPerformanceCaveat` flag be enabled as a context option used in the `isWebGLSupported` function.
	 * If set to true, a WebGL renderer can fail to be created if the browser thinks there could be performance issues when
	 * using WebGL.
	 *
	 * In PixiJS v6 this has changed from true to false by default, to allow WebGL to work in as many scenarios as possible.
	 * However, some users may have a poor experience, for example, if a user has a gpu or driver version blacklisted by the
	 * browser.
	 *
	 * If your application requires high performance rendering, you may wish to set this to false.
	 * We recommend one of two options if you decide to set this flag to false:
	 *
	 * 1: Use the `pixi.js-legacy` package, which includes a Canvas renderer as a fallback in case high performance WebGL is
	 *    not supported.
	 *
	 * 2: Call `isWebGLSupported` (which if found in the PIXI.utils package) in your code before attempting to create a PixiJS
	 *    renderer, and show an error message to the user if the function returns false, explaining that their device & browser
	 *    combination does not support high performance WebGL.
	 *    This is a much better strategy than trying to create a PixiJS renderer and finding it then fails.
	 * @static
	 * @name FAIL_IF_MAJOR_PERFORMANCE_CAVEAT
	 * @memberof PIXI.settings
	 * @type {boolean}
	 * @default false
	 */
	settings.settings.FAIL_IF_MAJOR_PERFORMANCE_CAVEAT = false;

	var saidHello = false;
	var VERSION = '6.5.2';
	/**
	 * Skips the hello message of renderers that are created after this is run.
	 * @function skipHello
	 * @memberof PIXI.utils
	 */
	function skipHello() {
	    saidHello = true;
	}
	/**
	 * Logs out the version and renderer information for this running instance of PIXI.
	 * If you don't want to see this message you can run `PIXI.utils.skipHello()` before
	 * creating your renderer. Keep in mind that doing that will forever make you a jerk face.
	 * @static
	 * @function sayHello
	 * @memberof PIXI.utils
	 * @param {string} type - The string renderer type to log.
	 */
	function sayHello(type) {
	    var _a;
	    if (saidHello) {
	        return;
	    }
	    if (settings.settings.ADAPTER.getNavigator().userAgent.toLowerCase().indexOf('chrome') > -1) {
	        var args = [
	            "\n %c %c %c PixiJS " + VERSION + " - \u2730 " + type + " \u2730  %c  %c  http://www.pixijs.com/  %c %c \u2665%c\u2665%c\u2665 \n\n",
	            'background: #ff66a5; padding:5px 0;',
	            'background: #ff66a5; padding:5px 0;',
	            'color: #ff66a5; background: #030307; padding:5px 0;',
	            'background: #ff66a5; padding:5px 0;',
	            'background: #ffc3dc; padding:5px 0;',
	            'background: #ff66a5; padding:5px 0;',
	            'color: #ff2424; background: #fff; padding:5px 0;',
	            'color: #ff2424; background: #fff; padding:5px 0;',
	            'color: #ff2424; background: #fff; padding:5px 0;' ];
	        (_a = globalThis.console).log.apply(_a, args);
	    }
	    else if (globalThis.console) {
	        globalThis.console.log("PixiJS " + VERSION + " - " + type + " - http://www.pixijs.com/");
	    }
	    saidHello = true;
	}

	var supported;
	/**
	 * Helper for checking for WebGL support.
	 * @memberof PIXI.utils
	 * @function isWebGLSupported
	 * @returns {boolean} Is WebGL supported.
	 */
	function isWebGLSupported() {
	    if (typeof supported === 'undefined') {
	        supported = (function supported() {
	            var contextOptions = {
	                stencil: true,
	                failIfMajorPerformanceCaveat: settings.settings.FAIL_IF_MAJOR_PERFORMANCE_CAVEAT,
	            };
	            try {
	                if (!settings.settings.ADAPTER.getWebGLRenderingContext()) {
	                    return false;
	                }
	                var canvas = settings.settings.ADAPTER.createCanvas();
	                var gl = (canvas.getContext('webgl', contextOptions)
	                    || canvas.getContext('experimental-webgl', contextOptions));
	                var success = !!(gl && gl.getContextAttributes().stencil);
	                if (gl) {
	                    var loseContext = gl.getExtension('WEBGL_lose_context');
	                    if (loseContext) {
	                        loseContext.loseContext();
	                    }
	                }
	                gl = null;
	                return success;
	            }
	            catch (e) {
	                return false;
	            }
	        })();
	    }
	    return supported;
	}

	var aliceblue = "#f0f8ff";
	var antiquewhite = "#faebd7";
	var aqua = "#00ffff";
	var aquamarine = "#7fffd4";
	var azure = "#f0ffff";
	var beige = "#f5f5dc";
	var bisque = "#ffe4c4";
	var black = "#000000";
	var blanchedalmond = "#ffebcd";
	var blue = "#0000ff";
	var blueviolet = "#8a2be2";
	var brown = "#a52a2a";
	var burlywood = "#deb887";
	var cadetblue = "#5f9ea0";
	var chartreuse = "#7fff00";
	var chocolate = "#d2691e";
	var coral = "#ff7f50";
	var cornflowerblue = "#6495ed";
	var cornsilk = "#fff8dc";
	var crimson = "#dc143c";
	var cyan = "#00ffff";
	var darkblue = "#00008b";
	var darkcyan = "#008b8b";
	var darkgoldenrod = "#b8860b";
	var darkgray = "#a9a9a9";
	var darkgreen = "#006400";
	var darkgrey = "#a9a9a9";
	var darkkhaki = "#bdb76b";
	var darkmagenta = "#8b008b";
	var darkolivegreen = "#556b2f";
	var darkorange = "#ff8c00";
	var darkorchid = "#9932cc";
	var darkred = "#8b0000";
	var darksalmon = "#e9967a";
	var darkseagreen = "#8fbc8f";
	var darkslateblue = "#483d8b";
	var darkslategray = "#2f4f4f";
	var darkslategrey = "#2f4f4f";
	var darkturquoise = "#00ced1";
	var darkviolet = "#9400d3";
	var deeppink = "#ff1493";
	var deepskyblue = "#00bfff";
	var dimgray = "#696969";
	var dimgrey = "#696969";
	var dodgerblue = "#1e90ff";
	var firebrick = "#b22222";
	var floralwhite = "#fffaf0";
	var forestgreen = "#228b22";
	var fuchsia = "#ff00ff";
	var gainsboro = "#dcdcdc";
	var ghostwhite = "#f8f8ff";
	var goldenrod = "#daa520";
	var gold = "#ffd700";
	var gray = "#808080";
	var green = "#008000";
	var greenyellow = "#adff2f";
	var grey = "#808080";
	var honeydew = "#f0fff0";
	var hotpink = "#ff69b4";
	var indianred = "#cd5c5c";
	var indigo = "#4b0082";
	var ivory = "#fffff0";
	var khaki = "#f0e68c";
	var lavenderblush = "#fff0f5";
	var lavender = "#e6e6fa";
	var lawngreen = "#7cfc00";
	var lemonchiffon = "#fffacd";
	var lightblue = "#add8e6";
	var lightcoral = "#f08080";
	var lightcyan = "#e0ffff";
	var lightgoldenrodyellow = "#fafad2";
	var lightgray = "#d3d3d3";
	var lightgreen = "#90ee90";
	var lightgrey = "#d3d3d3";
	var lightpink = "#ffb6c1";
	var lightsalmon = "#ffa07a";
	var lightseagreen = "#20b2aa";
	var lightskyblue = "#87cefa";
	var lightslategray = "#778899";
	var lightslategrey = "#778899";
	var lightsteelblue = "#b0c4de";
	var lightyellow = "#ffffe0";
	var lime = "#00ff00";
	var limegreen = "#32cd32";
	var linen = "#faf0e6";
	var magenta = "#ff00ff";
	var maroon = "#800000";
	var mediumaquamarine = "#66cdaa";
	var mediumblue = "#0000cd";
	var mediumorchid = "#ba55d3";
	var mediumpurple = "#9370db";
	var mediumseagreen = "#3cb371";
	var mediumslateblue = "#7b68ee";
	var mediumspringgreen = "#00fa9a";
	var mediumturquoise = "#48d1cc";
	var mediumvioletred = "#c71585";
	var midnightblue = "#191970";
	var mintcream = "#f5fffa";
	var mistyrose = "#ffe4e1";
	var moccasin = "#ffe4b5";
	var navajowhite = "#ffdead";
	var navy = "#000080";
	var oldlace = "#fdf5e6";
	var olive = "#808000";
	var olivedrab = "#6b8e23";
	var orange = "#ffa500";
	var orangered = "#ff4500";
	var orchid = "#da70d6";
	var palegoldenrod = "#eee8aa";
	var palegreen = "#98fb98";
	var paleturquoise = "#afeeee";
	var palevioletred = "#db7093";
	var papayawhip = "#ffefd5";
	var peachpuff = "#ffdab9";
	var peru = "#cd853f";
	var pink = "#ffc0cb";
	var plum = "#dda0dd";
	var powderblue = "#b0e0e6";
	var purple = "#800080";
	var rebeccapurple = "#663399";
	var red = "#ff0000";
	var rosybrown = "#bc8f8f";
	var royalblue = "#4169e1";
	var saddlebrown = "#8b4513";
	var salmon = "#fa8072";
	var sandybrown = "#f4a460";
	var seagreen = "#2e8b57";
	var seashell = "#fff5ee";
	var sienna = "#a0522d";
	var silver = "#c0c0c0";
	var skyblue = "#87ceeb";
	var slateblue = "#6a5acd";
	var slategray = "#708090";
	var slategrey = "#708090";
	var snow = "#fffafa";
	var springgreen = "#00ff7f";
	var steelblue = "#4682b4";
	var tan = "#d2b48c";
	var teal = "#008080";
	var thistle = "#d8bfd8";
	var tomato = "#ff6347";
	var turquoise = "#40e0d0";
	var violet = "#ee82ee";
	var wheat = "#f5deb3";
	var white = "#ffffff";
	var whitesmoke = "#f5f5f5";
	var yellow = "#ffff00";
	var yellowgreen = "#9acd32";
	var cssColorNames = {
		aliceblue: aliceblue,
		antiquewhite: antiquewhite,
		aqua: aqua,
		aquamarine: aquamarine,
		azure: azure,
		beige: beige,
		bisque: bisque,
		black: black,
		blanchedalmond: blanchedalmond,
		blue: blue,
		blueviolet: blueviolet,
		brown: brown,
		burlywood: burlywood,
		cadetblue: cadetblue,
		chartreuse: chartreuse,
		chocolate: chocolate,
		coral: coral,
		cornflowerblue: cornflowerblue,
		cornsilk: cornsilk,
		crimson: crimson,
		cyan: cyan,
		darkblue: darkblue,
		darkcyan: darkcyan,
		darkgoldenrod: darkgoldenrod,
		darkgray: darkgray,
		darkgreen: darkgreen,
		darkgrey: darkgrey,
		darkkhaki: darkkhaki,
		darkmagenta: darkmagenta,
		darkolivegreen: darkolivegreen,
		darkorange: darkorange,
		darkorchid: darkorchid,
		darkred: darkred,
		darksalmon: darksalmon,
		darkseagreen: darkseagreen,
		darkslateblue: darkslateblue,
		darkslategray: darkslategray,
		darkslategrey: darkslategrey,
		darkturquoise: darkturquoise,
		darkviolet: darkviolet,
		deeppink: deeppink,
		deepskyblue: deepskyblue,
		dimgray: dimgray,
		dimgrey: dimgrey,
		dodgerblue: dodgerblue,
		firebrick: firebrick,
		floralwhite: floralwhite,
		forestgreen: forestgreen,
		fuchsia: fuchsia,
		gainsboro: gainsboro,
		ghostwhite: ghostwhite,
		goldenrod: goldenrod,
		gold: gold,
		gray: gray,
		green: green,
		greenyellow: greenyellow,
		grey: grey,
		honeydew: honeydew,
		hotpink: hotpink,
		indianred: indianred,
		indigo: indigo,
		ivory: ivory,
		khaki: khaki,
		lavenderblush: lavenderblush,
		lavender: lavender,
		lawngreen: lawngreen,
		lemonchiffon: lemonchiffon,
		lightblue: lightblue,
		lightcoral: lightcoral,
		lightcyan: lightcyan,
		lightgoldenrodyellow: lightgoldenrodyellow,
		lightgray: lightgray,
		lightgreen: lightgreen,
		lightgrey: lightgrey,
		lightpink: lightpink,
		lightsalmon: lightsalmon,
		lightseagreen: lightseagreen,
		lightskyblue: lightskyblue,
		lightslategray: lightslategray,
		lightslategrey: lightslategrey,
		lightsteelblue: lightsteelblue,
		lightyellow: lightyellow,
		lime: lime,
		limegreen: limegreen,
		linen: linen,
		magenta: magenta,
		maroon: maroon,
		mediumaquamarine: mediumaquamarine,
		mediumblue: mediumblue,
		mediumorchid: mediumorchid,
		mediumpurple: mediumpurple,
		mediumseagreen: mediumseagreen,
		mediumslateblue: mediumslateblue,
		mediumspringgreen: mediumspringgreen,
		mediumturquoise: mediumturquoise,
		mediumvioletred: mediumvioletred,
		midnightblue: midnightblue,
		mintcream: mintcream,
		mistyrose: mistyrose,
		moccasin: moccasin,
		navajowhite: navajowhite,
		navy: navy,
		oldlace: oldlace,
		olive: olive,
		olivedrab: olivedrab,
		orange: orange,
		orangered: orangered,
		orchid: orchid,
		palegoldenrod: palegoldenrod,
		palegreen: palegreen,
		paleturquoise: paleturquoise,
		palevioletred: palevioletred,
		papayawhip: papayawhip,
		peachpuff: peachpuff,
		peru: peru,
		pink: pink,
		plum: plum,
		powderblue: powderblue,
		purple: purple,
		rebeccapurple: rebeccapurple,
		red: red,
		rosybrown: rosybrown,
		royalblue: royalblue,
		saddlebrown: saddlebrown,
		salmon: salmon,
		sandybrown: sandybrown,
		seagreen: seagreen,
		seashell: seashell,
		sienna: sienna,
		silver: silver,
		skyblue: skyblue,
		slateblue: slateblue,
		slategray: slategray,
		slategrey: slategrey,
		snow: snow,
		springgreen: springgreen,
		steelblue: steelblue,
		tan: tan,
		teal: teal,
		thistle: thistle,
		tomato: tomato,
		turquoise: turquoise,
		violet: violet,
		wheat: wheat,
		white: white,
		whitesmoke: whitesmoke,
		yellow: yellow,
		yellowgreen: yellowgreen
	};

	/**
	 * Converts a hexadecimal color number to an [R, G, B] array of normalized floats (numbers from 0.0 to 1.0).
	 * @example
	 * PIXI.utils.hex2rgb(0xffffff); // returns [1, 1, 1]
	 * @memberof PIXI.utils
	 * @function hex2rgb
	 * @param {number} hex - The hexadecimal number to convert
	 * @param  {number[]} [out=[]] - If supplied, this array will be used rather than returning a new one
	 * @returns {number[]} An array representing the [R, G, B] of the color where all values are floats.
	 */
	function hex2rgb(hex, out) {
	    if (out === void 0) { out = []; }
	    out[0] = ((hex >> 16) & 0xFF) / 255;
	    out[1] = ((hex >> 8) & 0xFF) / 255;
	    out[2] = (hex & 0xFF) / 255;
	    return out;
	}
	/**
	 * Converts a hexadecimal color number to a string.
	 * @example
	 * PIXI.utils.hex2string(0xffffff); // returns "#ffffff"
	 * @memberof PIXI.utils
	 * @function hex2string
	 * @param {number} hex - Number in hex (e.g., `0xffffff`)
	 * @returns {string} The string color (e.g., `"#ffffff"`).
	 */
	function hex2string(hex) {
	    var hexString = hex.toString(16);
	    hexString = '000000'.substring(0, 6 - hexString.length) + hexString;
	    return "#" + hexString;
	}
	/**
	 * Converts a string to a hexadecimal color number.
	 * It can handle:
	 *  hex strings starting with #: "#ffffff"
	 *  hex strings starting with 0x: "0xffffff"
	 *  hex strings without prefix: "ffffff"
	 *  css colors: "black"
	 * @example
	 * PIXI.utils.string2hex("#ffffff"); // returns 0xffffff
	 * @memberof PIXI.utils
	 * @function string2hex
	 * @param {string} string - The string color (e.g., `"#ffffff"`)
	 * @returns {number} Number in hexadecimal.
	 */
	function string2hex(string) {
	    if (typeof string === 'string') {
	        string = cssColorNames[string.toLowerCase()] || string;
	        if (string[0] === '#') {
	            string = string.slice(1);
	        }
	    }
	    return parseInt(string, 16);
	}
	/**
	 * Converts a color as an [R, G, B] array of normalized floats to a hexadecimal number.
	 * @example
	 * PIXI.utils.rgb2hex([1, 1, 1]); // returns 0xffffff
	 * @memberof PIXI.utils
	 * @function rgb2hex
	 * @param {number[]} rgb - Array of numbers where all values are normalized floats from 0.0 to 1.0.
	 * @returns {number} Number in hexadecimal.
	 */
	function rgb2hex(rgb) {
	    return (((rgb[0] * 255) << 16) + ((rgb[1] * 255) << 8) + (rgb[2] * 255 | 0));
	}

	/**
	 * Corrects PixiJS blend, takes premultiplied alpha into account
	 * @memberof PIXI.utils
	 * @function mapPremultipliedBlendModes
	 * @private
	 * @returns {Array<number[]>} Mapped modes.
	 */
	function mapPremultipliedBlendModes() {
	    var pm = [];
	    var npm = [];
	    for (var i = 0; i < 32; i++) {
	        pm[i] = i;
	        npm[i] = i;
	    }
	    pm[constants.BLEND_MODES.NORMAL_NPM] = constants.BLEND_MODES.NORMAL;
	    pm[constants.BLEND_MODES.ADD_NPM] = constants.BLEND_MODES.ADD;
	    pm[constants.BLEND_MODES.SCREEN_NPM] = constants.BLEND_MODES.SCREEN;
	    npm[constants.BLEND_MODES.NORMAL] = constants.BLEND_MODES.NORMAL_NPM;
	    npm[constants.BLEND_MODES.ADD] = constants.BLEND_MODES.ADD_NPM;
	    npm[constants.BLEND_MODES.SCREEN] = constants.BLEND_MODES.SCREEN_NPM;
	    var array = [];
	    array.push(npm);
	    array.push(pm);
	    return array;
	}
	/**
	 * maps premultiply flag and blendMode to adjusted blendMode
	 * @memberof PIXI.utils
	 * @constant premultiplyBlendMode
	 * @type {Array<number[]>}
	 */
	var premultiplyBlendMode = mapPremultipliedBlendModes();
	/**
	 * changes blendMode according to texture format
	 * @memberof PIXI.utils
	 * @function correctBlendMode
	 * @param {number} blendMode - supposed blend mode
	 * @param {boolean} premultiplied - whether source is premultiplied
	 * @returns {number} true blend mode for this texture
	 */
	function correctBlendMode(blendMode, premultiplied) {
	    return premultiplyBlendMode[premultiplied ? 1 : 0][blendMode];
	}
	/**
	 * combines rgb and alpha to out array
	 * @memberof PIXI.utils
	 * @function premultiplyRgba
	 * @param {Float32Array|number[]} rgb - input rgb
	 * @param {number} alpha - alpha param
	 * @param {Float32Array} [out] - output
	 * @param {boolean} [premultiply=true] - do premultiply it
	 * @returns {Float32Array} vec4 rgba
	 */
	function premultiplyRgba(rgb, alpha, out, premultiply) {
	    out = out || new Float32Array(4);
	    if (premultiply || premultiply === undefined) {
	        out[0] = rgb[0] * alpha;
	        out[1] = rgb[1] * alpha;
	        out[2] = rgb[2] * alpha;
	    }
	    else {
	        out[0] = rgb[0];
	        out[1] = rgb[1];
	        out[2] = rgb[2];
	    }
	    out[3] = alpha;
	    return out;
	}
	/**
	 * premultiplies tint
	 * @memberof PIXI.utils
	 * @function premultiplyTint
	 * @param {number} tint - integer RGB
	 * @param {number} alpha - floating point alpha (0.0-1.0)
	 * @returns {number} tint multiplied by alpha
	 */
	function premultiplyTint(tint, alpha) {
	    if (alpha === 1.0) {
	        return (alpha * 255 << 24) + tint;
	    }
	    if (alpha === 0.0) {
	        return 0;
	    }
	    var R = ((tint >> 16) & 0xFF);
	    var G = ((tint >> 8) & 0xFF);
	    var B = (tint & 0xFF);
	    R = ((R * alpha) + 0.5) | 0;
	    G = ((G * alpha) + 0.5) | 0;
	    B = ((B * alpha) + 0.5) | 0;
	    return (alpha * 255 << 24) + (R << 16) + (G << 8) + B;
	}
	/**
	 * converts integer tint and float alpha to vec4 form, premultiplies by default
	 * @memberof PIXI.utils
	 * @function premultiplyTintToRgba
	 * @param {number} tint - input tint
	 * @param {number} alpha - alpha param
	 * @param {Float32Array} [out] - output
	 * @param {boolean} [premultiply=true] - do premultiply it
	 * @returns {Float32Array} vec4 rgba
	 */
	function premultiplyTintToRgba(tint, alpha, out, premultiply) {
	    out = out || new Float32Array(4);
	    out[0] = ((tint >> 16) & 0xFF) / 255.0;
	    out[1] = ((tint >> 8) & 0xFF) / 255.0;
	    out[2] = (tint & 0xFF) / 255.0;
	    if (premultiply || premultiply === undefined) {
	        out[0] *= alpha;
	        out[1] *= alpha;
	        out[2] *= alpha;
	    }
	    out[3] = alpha;
	    return out;
	}

	/**
	 * Generic Mask Stack data structure
	 * @memberof PIXI.utils
	 * @function createIndicesForQuads
	 * @param {number} size - Number of quads
	 * @param {Uint16Array|Uint32Array} [outBuffer] - Buffer for output, length has to be `6 * size`
	 * @returns {Uint16Array|Uint32Array} - Resulting index buffer
	 */
	function createIndicesForQuads(size, outBuffer) {
	    if (outBuffer === void 0) { outBuffer = null; }
	    // the total number of indices in our array, there are 6 points per quad.
	    var totalIndices = size * 6;
	    outBuffer = outBuffer || new Uint16Array(totalIndices);
	    if (outBuffer.length !== totalIndices) {
	        throw new Error("Out buffer length is incorrect, got " + outBuffer.length + " and expected " + totalIndices);
	    }
	    // fill the indices with the quads to draw
	    for (var i = 0, j = 0; i < totalIndices; i += 6, j += 4) {
	        outBuffer[i + 0] = j + 0;
	        outBuffer[i + 1] = j + 1;
	        outBuffer[i + 2] = j + 2;
	        outBuffer[i + 3] = j + 0;
	        outBuffer[i + 4] = j + 2;
	        outBuffer[i + 5] = j + 3;
	    }
	    return outBuffer;
	}

	function getBufferType(array) {
	    if (array.BYTES_PER_ELEMENT === 4) {
	        if (array instanceof Float32Array) {
	            return 'Float32Array';
	        }
	        else if (array instanceof Uint32Array) {
	            return 'Uint32Array';
	        }
	        return 'Int32Array';
	    }
	    else if (array.BYTES_PER_ELEMENT === 2) {
	        if (array instanceof Uint16Array) {
	            return 'Uint16Array';
	        }
	    }
	    else if (array.BYTES_PER_ELEMENT === 1) {
	        if (array instanceof Uint8Array) {
	            return 'Uint8Array';
	        }
	    }
	    // TODO map out the rest of the array elements!
	    return null;
	}

	/* eslint-disable object-shorthand */
	var map = { Float32Array: Float32Array, Uint32Array: Uint32Array, Int32Array: Int32Array, Uint8Array: Uint8Array };
	function interleaveTypedArrays(arrays, sizes) {
	    var outSize = 0;
	    var stride = 0;
	    var views = {};
	    for (var i = 0; i < arrays.length; i++) {
	        stride += sizes[i];
	        outSize += arrays[i].length;
	    }
	    var buffer = new ArrayBuffer(outSize * 4);
	    var out = null;
	    var littleOffset = 0;
	    for (var i = 0; i < arrays.length; i++) {
	        var size = sizes[i];
	        var array = arrays[i];
	        /*
	        @todo This is unsafe casting but consistent with how the code worked previously. Should it stay this way
	              or should and `getBufferTypeUnsafe` function be exposed that throws an Error if unsupported type is passed?
	         */
	        var type = getBufferType(array);
	        if (!views[type]) {
	            views[type] = new map[type](buffer);
	        }
	        out = views[type];
	        for (var j = 0; j < array.length; j++) {
	            var indexStart = ((j / size | 0) * stride) + littleOffset;
	            var index = j % size;
	            out[indexStart + index] = array[j];
	        }
	        littleOffset += size;
	    }
	    return new Float32Array(buffer);
	}

	// Taken from the bit-twiddle package
	/**
	 * Rounds to next power of two.
	 * @function nextPow2
	 * @memberof PIXI.utils
	 * @param {number} v - input value
	 * @returns {number} - next rounded power of two
	 */
	function nextPow2(v) {
	    v += v === 0 ? 1 : 0;
	    --v;
	    v |= v >>> 1;
	    v |= v >>> 2;
	    v |= v >>> 4;
	    v |= v >>> 8;
	    v |= v >>> 16;
	    return v + 1;
	}
	/**
	 * Checks if a number is a power of two.
	 * @function isPow2
	 * @memberof PIXI.utils
	 * @param {number} v - input value
	 * @returns {boolean} `true` if value is power of two
	 */
	function isPow2(v) {
	    return !(v & (v - 1)) && (!!v);
	}
	/**
	 * Computes ceil of log base 2
	 * @function log2
	 * @memberof PIXI.utils
	 * @param {number} v - input value
	 * @returns {number} logarithm base 2
	 */
	function log2(v) {
	    var r = (v > 0xFFFF ? 1 : 0) << 4;
	    v >>>= r;
	    var shift = (v > 0xFF ? 1 : 0) << 3;
	    v >>>= shift;
	    r |= shift;
	    shift = (v > 0xF ? 1 : 0) << 2;
	    v >>>= shift;
	    r |= shift;
	    shift = (v > 0x3 ? 1 : 0) << 1;
	    v >>>= shift;
	    r |= shift;
	    return r | (v >> 1);
	}

	/**
	 * Remove items from a javascript array without generating garbage
	 * @function removeItems
	 * @memberof PIXI.utils
	 * @param {Array<any>} arr - Array to remove elements from
	 * @param {number} startIdx - starting index
	 * @param {number} removeCount - how many to remove
	 */
	function removeItems(arr, startIdx, removeCount) {
	    var length = arr.length;
	    var i;
	    if (startIdx >= length || removeCount === 0) {
	        return;
	    }
	    removeCount = (startIdx + removeCount > length ? length - startIdx : removeCount);
	    var len = length - removeCount;
	    for (i = startIdx; i < len; ++i) {
	        arr[i] = arr[i + removeCount];
	    }
	    arr.length = len;
	}

	/**
	 * Returns sign of number
	 * @memberof PIXI.utils
	 * @function sign
	 * @param {number} n - the number to check the sign of
	 * @returns {number} 0 if `n` is 0, -1 if `n` is negative, 1 if `n` is positive
	 */
	function sign(n) {
	    if (n === 0)
	        { return 0; }
	    return n < 0 ? -1 : 1;
	}

	var nextUid = 0;
	/**
	 * Gets the next unique identifier
	 * @memberof PIXI.utils
	 * @function uid
	 * @returns {number} The next unique identifier to use.
	 */
	function uid() {
	    return ++nextUid;
	}

	// A map of warning messages already fired
	var warnings = {};
	/**
	 * Helper for warning developers about deprecated features & settings.
	 * A stack track for warnings is given; useful for tracking-down where
	 * deprecated methods/properties/classes are being used within the code.
	 * @memberof PIXI.utils
	 * @function deprecation
	 * @param {string} version - The version where the feature became deprecated
	 * @param {string} message - Message should include what is deprecated, where, and the new solution
	 * @param {number} [ignoreDepth=3] - The number of steps to ignore at the top of the error stack
	 *        this is mostly to ignore internal deprecation calls.
	 */
	function deprecation(version, message, ignoreDepth) {
	    if (ignoreDepth === void 0) { ignoreDepth = 3; }
	    // Ignore duplicat
	    if (warnings[message]) {
	        return;
	    }
	    /* eslint-disable no-console */
	    var stack = new Error().stack;
	    // Handle IE < 10 and Safari < 6
	    if (typeof stack === 'undefined') {
	        console.warn('PixiJS Deprecation Warning: ', message + "\nDeprecated since v" + version);
	    }
	    else {
	        // chop off the stack trace which includes PixiJS internal calls
	        stack = stack.split('\n').splice(ignoreDepth).join('\n');
	        if (console.groupCollapsed) {
	            console.groupCollapsed('%cPixiJS Deprecation Warning: %c%s', 'color:#614108;background:#fffbe6', 'font-weight:normal;color:#614108;background:#fffbe6', message + "\nDeprecated since v" + version);
	            console.warn(stack);
	            console.groupEnd();
	        }
	        else {
	            console.warn('PixiJS Deprecation Warning: ', message + "\nDeprecated since v" + version);
	            console.warn(stack);
	        }
	    }
	    /* eslint-enable no-console */
	    warnings[message] = true;
	}

	/**
	 * @todo Describe property usage
	 * @static
	 * @name ProgramCache
	 * @memberof PIXI.utils
	 * @type {object}
	 */
	var ProgramCache = {};
	/**
	 * @todo Describe property usage
	 * @static
	 * @name TextureCache
	 * @memberof PIXI.utils
	 * @type {object}
	 */
	var TextureCache = Object.create(null);
	/**
	 * @todo Describe property usage
	 * @static
	 * @name BaseTextureCache
	 * @memberof PIXI.utils
	 * @type {object}
	 */
	var BaseTextureCache = Object.create(null);
	/**
	 * Destroys all texture in the cache
	 * @memberof PIXI.utils
	 * @function destroyTextureCache
	 */
	function destroyTextureCache() {
	    var key;
	    for (key in TextureCache) {
	        TextureCache[key].destroy();
	    }
	    for (key in BaseTextureCache) {
	        BaseTextureCache[key].destroy();
	    }
	}
	/**
	 * Removes all textures from cache, but does not destroy them
	 * @memberof PIXI.utils
	 * @function clearTextureCache
	 */
	function clearTextureCache() {
	    var key;
	    for (key in TextureCache) {
	        delete TextureCache[key];
	    }
	    for (key in BaseTextureCache) {
	        delete BaseTextureCache[key];
	    }
	}

	/**
	 * Creates a Canvas element of the given size to be used as a target for rendering to.
	 * @class
	 * @memberof PIXI.utils
	 */
	var CanvasRenderTarget = /** @class */ (function () {
	    /**
	     * @param width - the width for the newly created canvas
	     * @param height - the height for the newly created canvas
	     * @param {number} [resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio of the canvas
	     */
	    function CanvasRenderTarget(width, height, resolution) {
	        this.canvas = settings.settings.ADAPTER.createCanvas();
	        this.context = this.canvas.getContext('2d');
	        this.resolution = resolution || settings.settings.RESOLUTION;
	        this.resize(width, height);
	    }
	    /**
	     * Clears the canvas that was created by the CanvasRenderTarget class.
	     * @private
	     */
	    CanvasRenderTarget.prototype.clear = function () {
	        this.context.setTransform(1, 0, 0, 1, 0, 0);
	        this.context.clearRect(0, 0, this.canvas.width, this.canvas.height);
	    };
	    /**
	     * Resizes the canvas to the specified width and height.
	     * @param desiredWidth - the desired width of the canvas
	     * @param desiredHeight - the desired height of the canvas
	     */
	    CanvasRenderTarget.prototype.resize = function (desiredWidth, desiredHeight) {
	        this.canvas.width = Math.round(desiredWidth * this.resolution);
	        this.canvas.height = Math.round(desiredHeight * this.resolution);
	    };
	    /** Destroys this canvas. */
	    CanvasRenderTarget.prototype.destroy = function () {
	        this.context = null;
	        this.canvas = null;
	    };
	    Object.defineProperty(CanvasRenderTarget.prototype, "width", {
	        /**
	         * The width of the canvas buffer in pixels.
	         * @member {number}
	         */
	        get: function () {
	            return this.canvas.width;
	        },
	        set: function (val) {
	            this.canvas.width = Math.round(val);
	        },
	        enumerable: false,
	        configurable: true
	    });
	    Object.defineProperty(CanvasRenderTarget.prototype, "height", {
	        /**
	         * The height of the canvas buffer in pixels.
	         * @member {number}
	         */
	        get: function () {
	            return this.canvas.height;
	        },
	        set: function (val) {
	            this.canvas.height = Math.round(val);
	        },
	        enumerable: false,
	        configurable: true
	    });
	    return CanvasRenderTarget;
	}());

	/**
	 * Trim transparent borders from a canvas
	 * @memberof PIXI.utils
	 * @function trimCanvas
	 * @param {HTMLCanvasElement} canvas - the canvas to trim
	 * @returns {object} Trim data
	 */
	function trimCanvas(canvas) {
	    // https://gist.github.com/remy/784508
	    var width = canvas.width;
	    var height = canvas.height;
	    var context = canvas.getContext('2d');
	    var imageData = context.getImageData(0, 0, width, height);
	    var pixels = imageData.data;
	    var len = pixels.length;
	    var bound = {
	        top: null,
	        left: null,
	        right: null,
	        bottom: null,
	    };
	    var data = null;
	    var i;
	    var x;
	    var y;
	    for (i = 0; i < len; i += 4) {
	        if (pixels[i + 3] !== 0) {
	            x = (i / 4) % width;
	            y = ~~((i / 4) / width);
	            if (bound.top === null) {
	                bound.top = y;
	            }
	            if (bound.left === null) {
	                bound.left = x;
	            }
	            else if (x < bound.left) {
	                bound.left = x;
	            }
	            if (bound.right === null) {
	                bound.right = x + 1;
	            }
	            else if (bound.right < x) {
	                bound.right = x + 1;
	            }
	            if (bound.bottom === null) {
	                bound.bottom = y;
	            }
	            else if (bound.bottom < y) {
	                bound.bottom = y;
	            }
	        }
	    }
	    if (bound.top !== null) {
	        width = bound.right - bound.left;
	        height = bound.bottom - bound.top + 1;
	        data = context.getImageData(bound.left, bound.top, width, height);
	    }
	    return {
	        height: height,
	        width: width,
	        data: data,
	    };
	}

	/**
	 * Regexp for data URI.
	 * Based on: {@link https://github.com/ragingwind/data-uri-regex}
	 * @static
	 * @constant {RegExp|string} DATA_URI
	 * @memberof PIXI
	 * @example data:image/png;base64
	 */
	var DATA_URI = /^\s*data:(?:([\w-]+)\/([\w+.-]+))?(?:;charset=([\w-]+))?(?:;(base64))?,(.*)/i;

	/**
	 * @memberof PIXI.utils
	 * @interface DecomposedDataUri
	 */
	/**
	 * type, eg. `image`
	 * @memberof PIXI.utils.DecomposedDataUri#
	 * @member {string} mediaType
	 */
	/**
	 * Sub type, eg. `png`
	 * @memberof PIXI.utils.DecomposedDataUri#
	 * @member {string} subType
	 */
	/**
	 * @memberof PIXI.utils.DecomposedDataUri#
	 * @member {string} charset
	 */
	/**
	 * Data encoding, eg. `base64`
	 * @memberof PIXI.utils.DecomposedDataUri#
	 * @member {string} encoding
	 */
	/**
	 * The actual data
	 * @memberof PIXI.utils.DecomposedDataUri#
	 * @member {string} data
	 */
	/**
	 * Split a data URI into components. Returns undefined if
	 * parameter `dataUri` is not a valid data URI.
	 * @memberof PIXI.utils
	 * @function decomposeDataUri
	 * @param {string} dataUri - the data URI to check
	 * @returns {PIXI.utils.DecomposedDataUri|undefined} The decomposed data uri or undefined
	 */
	function decomposeDataUri(dataUri) {
	    var dataUriMatch = DATA_URI.exec(dataUri);
	    if (dataUriMatch) {
	        return {
	            mediaType: dataUriMatch[1] ? dataUriMatch[1].toLowerCase() : undefined,
	            subType: dataUriMatch[2] ? dataUriMatch[2].toLowerCase() : undefined,
	            charset: dataUriMatch[3] ? dataUriMatch[3].toLowerCase() : undefined,
	            encoding: dataUriMatch[4] ? dataUriMatch[4].toLowerCase() : undefined,
	            data: dataUriMatch[5],
	        };
	    }
	    return undefined;
	}

	var tempAnchor;
	/**
	 * Sets the `crossOrigin` property for this resource based on if the url
	 * for this resource is cross-origin. If crossOrigin was manually set, this
	 * function does nothing.
	 * Nipped from the resource loader!
	 * @ignore
	 * @param {string} url - The url to test.
	 * @param {object} [loc=window.location] - The location object to test against.
	 * @returns {string} The crossOrigin value to use (or empty string for none).
	 */
	function determineCrossOrigin(url$1, loc) {
	    if (loc === void 0) { loc = globalThis.location; }
	    // data: and javascript: urls are considered same-origin
	    if (url$1.indexOf('data:') === 0) {
	        return '';
	    }
	    // default is window.location
	    loc = loc || globalThis.location;
	    if (!tempAnchor) {
	        tempAnchor = document.createElement('a');
	    }
	    // let the browser determine the full href for the url of this resource and then
	    // parse with the node url lib, we can't use the properties of the anchor element
	    // because they don't work in IE9 :(
	    tempAnchor.href = url$1;
	    var parsedUrl = url.parse(tempAnchor.href);
	    var samePort = (!parsedUrl.port && loc.port === '') || (parsedUrl.port === loc.port);
	    // if cross origin
	    if (parsedUrl.hostname !== loc.hostname || !samePort || parsedUrl.protocol !== loc.protocol) {
	        return 'anonymous';
	    }
	    return '';
	}

	/**
	 * get the resolution / device pixel ratio of an asset by looking for the prefix
	 * used by spritesheets and image urls
	 * @memberof PIXI.utils
	 * @function getResolutionOfUrl
	 * @param {string} url - the image path
	 * @param {number} [defaultValue=1] - the defaultValue if no filename prefix is set.
	 * @returns {number} resolution / device pixel ratio of an asset
	 */
	function getResolutionOfUrl(url, defaultValue) {
	    var resolution = settings.settings.RETINA_PREFIX.exec(url);
	    if (resolution) {
	        return parseFloat(resolution[1]);
	    }
	    return defaultValue !== undefined ? defaultValue : 1;
	}

	/**
	 * Generalized convenience utilities for PIXI.
	 * @example
	 * // Extend PIXI's internal Event Emitter.
	 * class MyEmitter extends PIXI.utils.EventEmitter {
	 *   constructor() {
	 *      super();
	 *      console.log("Emitter created!");
	 *   }
	 * }
	 *
	 * // Get info on current device
	 * console.log(PIXI.utils.isMobile);
	 *
	 * // Convert hex color to string
	 * console.log(PIXI.utils.hex2string(0xff00ff)); // returns: "#ff00ff"
	 * @namespace PIXI.utils
	 */

	Object.defineProperty(exports, 'isMobile', {
		enumerable: true,
		get: function () { return settings.isMobile; }
	});
	exports.BaseTextureCache = BaseTextureCache;
	exports.CanvasRenderTarget = CanvasRenderTarget;
	exports.DATA_URI = DATA_URI;
	exports.EventEmitter = eventemitter3;
	exports.ProgramCache = ProgramCache;
	exports.TextureCache = TextureCache;
	exports.clearTextureCache = clearTextureCache;
	exports.correctBlendMode = correctBlendMode;
	exports.createIndicesForQuads = createIndicesForQuads;
	exports.decomposeDataUri = decomposeDataUri;
	exports.deprecation = deprecation;
	exports.destroyTextureCache = destroyTextureCache;
	exports.determineCrossOrigin = determineCrossOrigin;
	exports.earcut = earcut_1;
	exports.getBufferType = getBufferType;
	exports.getResolutionOfUrl = getResolutionOfUrl;
	exports.hex2rgb = hex2rgb;
	exports.hex2string = hex2string;
	exports.interleaveTypedArrays = interleaveTypedArrays;
	exports.isPow2 = isPow2;
	exports.isWebGLSupported = isWebGLSupported;
	exports.log2 = log2;
	exports.nextPow2 = nextPow2;
	exports.path = path;
	exports.premultiplyBlendMode = premultiplyBlendMode;
	exports.premultiplyRgba = premultiplyRgba;
	exports.premultiplyTint = premultiplyTint;
	exports.premultiplyTintToRgba = premultiplyTintToRgba;
	exports.removeItems = removeItems;
	exports.rgb2hex = rgb2hex;
	exports.sayHello = sayHello;
	exports.sign = sign;
	exports.skipHello = skipHello;
	exports.string2hex = string2hex;
	exports.trimCanvas = trimCanvas;
	exports.uid = uid;
	exports.url = url;

	Object.defineProperty(exports, '__esModule', { value: true });

	return exports;

})({}, PIXI, PIXI);
Object.assign(this.PIXI.utils, _pixi_utils);
//# sourceMappingURL=utils.js.map
