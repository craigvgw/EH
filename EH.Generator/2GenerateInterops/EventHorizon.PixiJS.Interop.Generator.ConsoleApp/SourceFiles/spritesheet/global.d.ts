declare namespace GlobalMixins
{
    interface LoaderResource
    {
        /** Reference to Spritesheet object created. */
        spritesheet?: import("./../spritesheet/index").Spritesheet;

        /** Dictionary of textures from Spritesheet. */
        textures?: {[name: string]: import("./../core/index").Texture};
    }
}
