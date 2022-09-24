declare namespace GlobalMixins
{
    interface Application
    {
        ticker: import("./../ticker/index").Ticker;
        stop(): void;
        start(): void;
    }

    interface IApplicationOptions
    {
        autoStart?: boolean;
        sharedTicker?: boolean;
    }
}
