/*!
 * @pixi/mixin-get-global-position - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/mixin-get-global-position is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
this.PIXI = this.PIXI || {};
(function (display, math) {
    'use strict';

    /**
     * Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.
     * @method getGlobalPosition
     * @memberof PIXI.DisplayObject#
     * @param {PIXI.Point} [point=new PIXI.Point()] - The point to write the global value to.
     * @param {boolean} [skipUpdate=false] - Setting to true will stop the transforms of the scene graph from
     *  being updated. This means the calculation returned MAY be out of date BUT will give you a
     *  nice performance boost.
     * @returns {PIXI.Point} The updated point.
     */
    display.DisplayObject.prototype.getGlobalPosition = function getGlobalPosition(point, skipUpdate) {
        if (point === void 0) { point = new math.Point(); }
        if (skipUpdate === void 0) { skipUpdate = false; }
        if (this.parent) {
            this.parent.toGlobal(this.position, point, skipUpdate);
        }
        else {
            point.x = this.position.x;
            point.y = this.position.y;
        }
        return point;
    };

})(PIXI, PIXI);
//# sourceMappingURL=mixin-get-global-position.js.map
