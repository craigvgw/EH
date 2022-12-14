/*!
 * @pixi/mixin-get-child-by-name - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/mixin-get-child-by-name is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
import { DisplayObject, Container } from '@pixi/display';

/**
 * The instance name of the object.
 * @memberof PIXI.DisplayObject#
 * @member {string} name
 */
DisplayObject.prototype.name = null;
/**
 * Returns the display object in the container.
 *
 * Recursive searches are done in a preorder traversal.
 * @method getChildByName
 * @memberof PIXI.Container#
 * @param {string} name - Instance name.
 * @param {boolean}[deep=false] - Whether to search recursively
 * @returns {PIXI.DisplayObject} The child with the specified name.
 */
Container.prototype.getChildByName = function getChildByName(name, deep) {
    for (var i = 0, j = this.children.length; i < j; i++) {
        if (this.children[i].name === name) {
            return this.children[i];
        }
    }
    if (deep) {
        for (var i = 0, j = this.children.length; i < j; i++) {
            var child = this.children[i];
            if (!child.getChildByName) {
                continue;
            }
            var target = child.getChildByName(name, true);
            if (target) {
                return target;
            }
        }
    }
    return null;
};
//# sourceMappingURL=mixin-get-child-by-name.mjs.map
