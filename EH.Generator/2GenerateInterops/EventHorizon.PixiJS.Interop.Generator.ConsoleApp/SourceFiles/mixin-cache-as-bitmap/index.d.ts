/// <reference path="./global.d.ts" />

import type { AbstractRenderer } from "./../core/index";
import type { Container } from "./../display/index";
import type { IDestroyOptions } from "./../display/index";
import type { IPointData } from "./../math/index";
import type { MaskData } from "./../core/index";
import type { Rectangle } from "./../math/index";
import type { Renderer } from "./../core/index";
import { Sprite } from "./../sprite/index";

/**
 * @class
 * @ignore
 * @private
 */
export declare class CacheData {
    textureCacheId: string;
    originalRender: (renderer: Renderer) => void;
    originalRenderCanvas: (renderer: AbstractRenderer) => void;
    originalCalculateBounds: () => void;
    originalGetLocalBounds: (rect?: Rectangle) => Rectangle;
    originalUpdateTransform: () => void;
    originalDestroy: (options?: IDestroyOptions | boolean) => void;
    originalMask: Container | MaskData;
    originalFilterArea: Rectangle;
    originalContainsPoint: (point: IPointData) => boolean;
    sprite: Sprite;
    constructor();
}

export { }
