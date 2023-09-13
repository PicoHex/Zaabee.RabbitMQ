namespace Zaabee.RabbitMQ.Abstractions;

public partial interface ISubscriber
{
    /// <summary>
    /// The subscriber cluster will get the message from its own queue which bind the default topic.
    /// </summary>
    /// <param name="resolve"></param>
    /// <param name="persistence"></param>
    /// <param name="prefetchCount"></param>
    /// <param name="consumeRetry"></param>
    /// <param name="dlx"></param>
    /// <param name="isExclusive"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    ValueTask SubscribeAsync<T>(
        Func<Action<T?>> resolve,
        bool persistence,
        ushort prefetchCount = Consts.DefaultPrefetchCount,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = false,
        bool isExclusive = false,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// The subscriber cluster will get the message from its own queue which bind the default topic.
    /// </summary>
    /// <param name="resolve"></param>
    /// <param name="persistence"></param>
    /// <param name="prefetchCount"></param>
    /// <param name="consumeRetry"></param>
    /// <param name="dlx"></param>
    /// <param name="isExclusive"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    ValueTask SubscribeAsync<T>(
        Func<Func<T?, Task>> resolve,
        bool persistence,
        ushort prefetchCount = Consts.DefaultPrefetchCount,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = false,
        bool isExclusive = false,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// The subscriber cluster will get the message from its own queue which bind the specified topic.
    /// </summary>
    /// <param name="topic"></param>
    /// <param name="resolve"></param>
    /// <param name="persistence"></param>
    /// <param name="prefetchCount"></param>
    /// <param name="consumeRetry"></param>
    /// <param name="dlx"></param>
    /// <param name="isExclusive"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    ValueTask SubscribeAsync<T>(
        string topic,
        Func<Action<T?>> resolve,
        bool persistence,
        ushort prefetchCount = Consts.DefaultPrefetchCount,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = false,
        bool isExclusive = false,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// The subscriber cluster will get the message from its own queue which bind the specified topic.
    /// </summary>
    /// <param name="topic"></param>
    /// <param name="resolve"></param>
    /// <param name="persistence"></param>
    /// <param name="prefetchCount"></param>
    /// <param name="consumeRetry"></param>
    /// <param name="dlx"></param>
    /// <param name="isExclusive"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    ValueTask SubscribeAsync<T>(
        string topic,
        Func<Func<T?, Task>> resolve,
        bool persistence,
        ushort prefetchCount = Consts.DefaultPrefetchCount,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = false,
        bool isExclusive = false,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// The subscriber cluster will get the message from its own queue which bind the specified topic.
    /// </summary>
    /// <param name="topic"></param>
    /// <param name="resolve"></param>
    /// <param name="persistence"></param>
    /// <param name="prefetchCount"></param>
    /// <param name="consumeRetry"></param>
    /// <param name="dlx"></param>
    /// <param name="isExclusive"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask SubscribeAsync(
        string topic,
        Func<Action<byte[]>> resolve,
        bool persistence,
        ushort prefetchCount = Consts.DefaultPrefetchCount,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = false,
        bool isExclusive = false,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// The subscriber cluster will get the message from its own queue which bind the specified topic.
    /// </summary>
    /// <param name="topic"></param>
    /// <param name="resolve"></param>
    /// <param name="persistence"></param>
    /// <param name="prefetchCount"></param>
    /// <param name="consumeRetry"></param>
    /// <param name="dlx"></param>
    /// <param name="isExclusive"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask SubscribeAsync(
        string topic,
        Func<Func<byte[], Task>> resolve,
        bool persistence,
        ushort prefetchCount = Consts.DefaultPrefetchCount,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = false,
        bool isExclusive = false,
        CancellationToken cancellationToken = default);
}