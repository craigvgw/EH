/*!
 * @pixi/runner - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/runner is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
var _pixi_runner = (function (exports) {
    'use strict';

    /**
     * A Runner is a highly performant and simple alternative to signals. Best used in situations
     * where events are dispatched to many objects at high frequency (say every frame!)
     *
     *
     * like a signal..
     * ```
     * import { Runner } from '@pixi/runner';
     *
     * const myObject = {
     *     loaded: new Runner('loaded')
     * }
     *
     * const listener = {
     *     loaded: function(){
     *         // thin
     *     }
     * }
     *
     * myObject.loaded.add(listener);
     *
     * myObject.loaded.emit();
     * ```
     *
     * Or for handling calling the same function on many items
     * ```
     * import { Runner } from '@pixi/runner';
     *
     * const myGame = {
     *     update: new Runner('update')
     * }
     *
     * const gameObject = {
     *     update: function(time){
     *         // update my gamey state
     *     }
     * }
     *
     * myGame.update.add(gameObject);
     *
     * myGame.update.emit(time);
     * ```
     * @memberof PIXI
     */
    var Runner = /** @class */ (function () {
        /**
         * @param name - The function name that will be executed on the listeners added to this Runner.
         */
        function Runner(name) {
            this.items = [];
            this._name = name;
            this._aliasCount = 0;
        }
        /* eslint-disable jsdoc/require-param, jsdoc/check-param-names */
        /**
         * Dispatch/Broadcast Runner to all listeners added to the queue.
         * @param {...any} params - (optional) parameters to pass to each listener
         */
        /*  eslint-enable jsdoc/require-param, jsdoc/check-param-names */
        Runner.prototype.emit = function (a0, a1, a2, a3, a4, a5, a6, a7) {
            if (arguments.length > 8) {
                throw new Error('max arguments reached');
            }
            var _a = this, name = _a.name, items = _a.items;
            this._aliasCount++;
            for (var i = 0, len = items.length; i < len; i++) {
                items[i][name](a0, a1, a2, a3, a4, a5, a6, a7);
            }
            if (items === this.items) {
                this._aliasCount--;
            }
            return this;
        };
        Runner.prototype.ensureNonAliasedItems = function () {
            if (this._aliasCount > 0 && this.items.length > 1) {
                this._aliasCount = 0;
                this.items = this.items.slice(0);
            }
        };
        /**
         * Add a listener to the Runner
         *
         * Runners do not need to have scope or functions passed to them.
         * All that is required is to pass the listening object and ensure that it has contains a function that has the same name
         * as the name provided to the Runner when it was created.
         *
         * Eg A listener passed to this Runner will require a 'complete' function.
         *
         * ```
         * import { Runner } from '@pixi/runner';
         *
         * const complete = new Runner('complete');
         * ```
         *
         * The scope used will be the object itself.
         * @param {any} item - The object that will be listening.
         */
        Runner.prototype.add = function (item) {
            if (item[this._name]) {
                this.ensureNonAliasedItems();
                this.remove(item);
                this.items.push(item);
            }
            return this;
        };
        /**
         * Remove a single listener from the dispatch queue.
         * @param {any} item - The listener that you would like to remove.
         */
        Runner.prototype.remove = function (item) {
            var index = this.items.indexOf(item);
            if (index !== -1) {
                this.ensureNonAliasedItems();
                this.items.splice(index, 1);
            }
            return this;
        };
        /**
         * Check to see if the listener is already in the Runner
         * @param {any} item - The listener that you would like to check.
         */
        Runner.prototype.contains = function (item) {
            return this.items.indexOf(item) !== -1;
        };
        /** Remove all listeners from the Runner */
        Runner.prototype.removeAll = function () {
            this.ensureNonAliasedItems();
            this.items.length = 0;
            return this;
        };
        /** Remove all references, don't use after this. */
        Runner.prototype.destroy = function () {
            this.removeAll();
            this.items = null;
            this._name = null;
        };
        Object.defineProperty(Runner.prototype, "empty", {
            /**
             * `true` if there are no this Runner contains no listeners
             * @readonly
             */
            get: function () {
                return this.items.length === 0;
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Runner.prototype, "name", {
            /**
             * The name of the runner.
             * @readonly
             */
            get: function () {
                return this._name;
            },
            enumerable: false,
            configurable: true
        });
        return Runner;
    }());
    Object.defineProperties(Runner.prototype, {
        /**
         * Alias for `emit`
         * @memberof PIXI.Runner#
         * @method dispatch
         * @see PIXI.Runner#emit
         */
        dispatch: { value: Runner.prototype.emit },
        /**
         * Alias for `emit`
         * @memberof PIXI.Runner#
         * @method run
         * @see PIXI.Runner#emit
         */
        run: { value: Runner.prototype.emit },
    });

    exports.Runner = Runner;

    Object.defineProperty(exports, '__esModule', { value: true });

    return exports;

})({});
Object.assign(this.PIXI, _pixi_runner);
//# sourceMappingURL=runner.js.map
