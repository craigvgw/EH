/*!
 * @pixi/sprite-animated - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/sprite-animated is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
import { Texture } from '@pixi/core';
import { Sprite } from '@pixi/sprite';
import { Ticker, UPDATE_PRIORITY } from '@pixi/ticker';

/*! *****************************************************************************
Copyright (c) Microsoft Corporation.

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
PERFORMANCE OF THIS SOFTWARE.
***************************************************************************** */
/* global Reflect, Promise */

var extendStatics = function(d, b) {
    extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) { if (b.hasOwnProperty(p)) { d[p] = b[p]; } } };
    return extendStatics(d, b);
};

function __extends(d, b) {
    extendStatics(d, b);
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
}

/**
 * An AnimatedSprite is a simple way to display an animation depicted by a list of textures.
 *
 * ```js
 * let alienImages = ["image_sequence_01.png","image_sequence_02.png","image_sequence_03.png","image_sequence_04.png"];
 * let textureArray = [];
 *
 * for (let i=0; i < 4; i++)
 * {
 *      let texture = PIXI.Texture.from(alienImages[i]);
 *      textureArray.push(texture);
 * };
 *
 * let animatedSprite = new PIXI.AnimatedSprite(textureArray);
 * ```
 *
 * The more efficient and simpler way to create an animated sprite is using a {@link PIXI.Spritesheet}
 * containing the animation definitions:
 *
 * ```js
 * PIXI.Loader.shared.add("assets/spritesheet.json").load(setup);
 *
 * function setup() {
 *   let sheet = PIXI.Loader.shared.resources["assets/spritesheet.json"].spritesheet;
 *   animatedSprite = new PIXI.AnimatedSprite(sheet.animations["image_sequence"]);
 *   ...
 * }
 * ```
 * @memberof PIXI
 */
var AnimatedSprite = /** @class */ (function (_super) {
    __extends(AnimatedSprite, _super);
    /**
     * @param textures - An array of {@link PIXI.Texture} or frame
     *  objects that make up the animation.
     * @param {boolean} [autoUpdate=true] - Whether to use PIXI.Ticker.shared to auto update animation time.
     */
    function AnimatedSprite(textures, autoUpdate) {
        if (autoUpdate === void 0) { autoUpdate = true; }
        var _this = _super.call(this, textures[0] instanceof Texture ? textures[0] : textures[0].texture) || this;
        _this._textures = null;
        _this._durations = null;
        _this._autoUpdate = autoUpdate;
        _this._isConnectedToTicker = false;
        _this.animationSpeed = 1;
        _this.loop = true;
        _this.updateAnchor = false;
        _this.onComplete = null;
        _this.onFrameChange = null;
        _this.onLoop = null;
        _this._currentTime = 0;
        _this._playing = false;
        _this._previousFrame = null;
        _this.textures = textures;
        return _this;
    }
    /** Stops the AnimatedSprite. */
    AnimatedSprite.prototype.stop = function () {
        if (!this._playing) {
            return;
        }
        this._playing = false;
        if (this._autoUpdate && this._isConnectedToTicker) {
            Ticker.shared.remove(this.update, this);
            this._isConnectedToTicker = false;
        }
    };
    /** Plays the AnimatedSprite. */
    AnimatedSprite.prototype.play = function () {
        if (this._playing) {
            return;
        }
        this._playing = true;
        if (this._autoUpdate && !this._isConnectedToTicker) {
            Ticker.shared.add(this.update, this, UPDATE_PRIORITY.HIGH);
            this._isConnectedToTicker = true;
        }
    };
    /**
     * Stops the AnimatedSprite and goes to a specific frame.
     * @param frameNumber - Frame index to stop at.
     */
    AnimatedSprite.prototype.gotoAndStop = function (frameNumber) {
        this.stop();
        var previousFrame = this.currentFrame;
        this._currentTime = frameNumber;
        if (previousFrame !== this.currentFrame) {
            this.updateTexture();
        }
    };
    /**
     * Goes to a specific frame and begins playing the AnimatedSprite.
     * @param frameNumber - Frame index to start at.
     */
    AnimatedSprite.prototype.gotoAndPlay = function (frameNumber) {
        var previousFrame = this.currentFrame;
        this._currentTime = frameNumber;
        if (previousFrame !== this.currentFrame) {
            this.updateTexture();
        }
        this.play();
    };
    /**
     * Updates the object transform for rendering.
     * @param deltaTime - Time since last tick.
     */
    AnimatedSprite.prototype.update = function (deltaTime) {
        if (!this._playing) {
            return;
        }
        var elapsed = this.animationSpeed * deltaTime;
        var previousFrame = this.currentFrame;
        if (this._durations !== null) {
            var lag = this._currentTime % 1 * this._durations[this.currentFrame];
            lag += elapsed / 60 * 1000;
            while (lag < 0) {
                this._currentTime--;
                lag += this._durations[this.currentFrame];
            }
            var sign = Math.sign(this.animationSpeed * deltaTime);
            this._currentTime = Math.floor(this._currentTime);
            while (lag >= this._durations[this.currentFrame]) {
                lag -= this._durations[this.currentFrame] * sign;
                this._currentTime += sign;
            }
            this._currentTime += lag / this._durations[this.currentFrame];
        }
        else {
            this._currentTime += elapsed;
        }
        if (this._currentTime < 0 && !this.loop) {
            this.gotoAndStop(0);
            if (this.onComplete) {
                this.onComplete();
            }
        }
        else if (this._currentTime >= this._textures.length && !this.loop) {
            this.gotoAndStop(this._textures.length - 1);
            if (this.onComplete) {
                this.onComplete();
            }
        }
        else if (previousFrame !== this.currentFrame) {
            if (this.loop && this.onLoop) {
                if (this.animationSpeed > 0 && this.currentFrame < previousFrame) {
                    this.onLoop();
                }
                else if (this.animationSpeed < 0 && this.currentFrame > previousFrame) {
                    this.onLoop();
                }
            }
            this.updateTexture();
        }
    };
    /** Updates the displayed texture to match the current frame index. */
    AnimatedSprite.prototype.updateTexture = function () {
        var currentFrame = this.currentFrame;
        if (this._previousFrame === currentFrame) {
            return;
        }
        this._previousFrame = currentFrame;
        this._texture = this._textures[currentFrame];
        this._textureID = -1;
        this._textureTrimmedID = -1;
        this._cachedTint = 0xFFFFFF;
        this.uvs = this._texture._uvs.uvsFloat32;
        if (this.updateAnchor) {
            this._anchor.copyFrom(this._texture.defaultAnchor);
        }
        if (this.onFrameChange) {
            this.onFrameChange(this.currentFrame);
        }
    };
    /**
     * Stops the AnimatedSprite and destroys it.
     * @param {object|boolean} [options] - Options parameter. A boolean will act as if all options
     *  have been set to that value.
     * @param {boolean} [options.children=false] - If set to true, all the children will have their destroy
     *      method called as well. 'options' will be passed on to those calls.
     * @param {boolean} [options.texture=false] - Should it destroy the current texture of the sprite as well.
     * @param {boolean} [options.baseTexture=false] - Should it destroy the base texture of the sprite as well.
     */
    AnimatedSprite.prototype.destroy = function (options) {
        this.stop();
        _super.prototype.destroy.call(this, options);
        this.onComplete = null;
        this.onFrameChange = null;
        this.onLoop = null;
    };
    /**
     * A short hand way of creating an AnimatedSprite from an array of frame ids.
     * @param frames - The array of frames ids the AnimatedSprite will use as its texture frames.
     * @returns - The new animated sprite with the specified frames.
     */
    AnimatedSprite.fromFrames = function (frames) {
        var textures = [];
        for (var i = 0; i < frames.length; ++i) {
            textures.push(Texture.from(frames[i]));
        }
        return new AnimatedSprite(textures);
    };
    /**
     * A short hand way of creating an AnimatedSprite from an array of image ids.
     * @param images - The array of image urls the AnimatedSprite will use as its texture frames.
     * @returns The new animate sprite with the specified images as frames.
     */
    AnimatedSprite.fromImages = function (images) {
        var textures = [];
        for (var i = 0; i < images.length; ++i) {
            textures.push(Texture.from(images[i]));
        }
        return new AnimatedSprite(textures);
    };
    Object.defineProperty(AnimatedSprite.prototype, "totalFrames", {
        /**
         * The total number of frames in the AnimatedSprite. This is the same as number of textures
         * assigned to the AnimatedSprite.
         * @readonly
         * @default 0
         */
        get: function () {
            return this._textures.length;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(AnimatedSprite.prototype, "textures", {
        /** The array of textures used for this AnimatedSprite. */
        get: function () {
            return this._textures;
        },
        set: function (value) {
            if (value[0] instanceof Texture) {
                this._textures = value;
                this._durations = null;
            }
            else {
                this._textures = [];
                this._durations = [];
                for (var i = 0; i < value.length; i++) {
                    this._textures.push(value[i].texture);
                    this._durations.push(value[i].time);
                }
            }
            this._previousFrame = null;
            this.gotoAndStop(0);
            this.updateTexture();
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(AnimatedSprite.prototype, "currentFrame", {
        /**
         * The AnimatedSprites current frame index.
         * @readonly
         */
        get: function () {
            var currentFrame = Math.floor(this._currentTime) % this._textures.length;
            if (currentFrame < 0) {
                currentFrame += this._textures.length;
            }
            return currentFrame;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(AnimatedSprite.prototype, "playing", {
        /**
         * Indicates if the AnimatedSprite is currently playing.
         * @readonly
         */
        get: function () {
            return this._playing;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(AnimatedSprite.prototype, "autoUpdate", {
        /** Whether to use PIXI.Ticker.shared to auto update animation time. */
        get: function () {
            return this._autoUpdate;
        },
        set: function (value) {
            if (value !== this._autoUpdate) {
                this._autoUpdate = value;
                if (!this._autoUpdate && this._isConnectedToTicker) {
                    Ticker.shared.remove(this.update, this);
                    this._isConnectedToTicker = false;
                }
                else if (this._autoUpdate && !this._isConnectedToTicker && this._playing) {
                    Ticker.shared.add(this.update, this);
                    this._isConnectedToTicker = true;
                }
            }
        },
        enumerable: false,
        configurable: true
    });
    return AnimatedSprite;
}(Sprite));

export { AnimatedSprite };
//# sourceMappingURL=sprite-animated.mjs.map
