declare namespace GlobalMixins
{
    type InteractiveTarget = import("./../interaction/index").InteractiveTarget;
    // eslint-disable-next-line @typescript-eslint/no-empty-interface
    interface DisplayObject extends InteractiveTarget
    {

    }
}
