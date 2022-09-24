declare namespace GlobalMixins
{
    interface IApplication
    {
        resizeTo: Window | HTMLElement;
        resize(): void;
        queueResize: () => void;
        cancelResize: () => void;
    }

    interface IApplicationOptions
    {
        resizeTo?: Window | HTMLElement;
    }
}
