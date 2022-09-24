declare namespace GlobalMixins
{
    interface DisplayObject
    {
        name: string;
    }

    interface Container
    {
        getChildByName<T extends import("./../display/index").DisplayObject = import("./../display/index").DisplayObject>(
            name: string,
            deep?: boolean,
        ): T;
    }
}
