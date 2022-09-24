declare namespace GlobalMixins
{
    interface DisplayObject
    {
        getGlobalPosition(point?: import("./../math/index").Point, skipUpdate?: boolean): import("./../math/index").Point;
    }
}
