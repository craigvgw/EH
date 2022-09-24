declare namespace GlobalMixins
{
    // eslint-disable-next-line @typescript-eslint/no-empty-interface
    interface IDisplayObject extends Partial<import("./../accessibility/index").IAccessibleTarget>
    {

    }
}
