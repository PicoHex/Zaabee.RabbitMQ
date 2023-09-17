namespace Zaabee.RabbitMQ;

public partial class ZaabeeRabbitMqClient
{
    /// <inheritdoc />
    public void Subscribe<T>(
        Func<Action<T?>> resolve,
        bool persistence,
        ushort prefetchCount = 10,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = true,
        bool isExclusive = false) =>
        Subscribe(GetTopicName(typeof(T)),
            resolve,
            persistence,
            prefetchCount,
            consumeRetry,
            dlx,
            isExclusive);

    /// <inheritdoc />
    public void Subscribe<T>(
        string topic,
        Func<Action<T?>> resolve,
        bool persistence,
        ushort prefetchCount = 10,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = true,
        bool isExclusive = false)
    {
        var queue = GetQueueName(resolve);
        // The exclusive queue do not have dlx
        Consume(
            GetExchangeParam(topic, persistence),
            GetQueueParam(queue, persistence, isExclusive),
            dlx && !isExclusive ? GetExchangeParam(topic, persistence, ExchangeRole.Dlx) : null,
            dlx && !isExclusive ? GetQueueParam(queue, persistence, isExclusive, QueueRole.Dlx) : null,
            resolve,
            prefetchCount,
            consumeRetry);
    }

    /// <inheritdoc />
    public void Subscribe(
        string topic,
        Func<Action<byte[]>> resolve,
        bool persistence,
        ushort prefetchCount = 10,
        int consumeRetry = Consts.DefaultConsumeRetry,
        bool dlx = true,
        bool isExclusive = false)
    {
        var queue = GetQueueName(resolve);
        // The exclusive queue do not have dlx
        Consume(GetExchangeParam(topic, persistence),
            GetQueueParam(queue, persistence, isExclusive),
            dlx && !isExclusive ? GetExchangeParam(topic, persistence, ExchangeRole.Dlx) : null,
            dlx && !isExclusive ? GetQueueParam(queue, persistence, isExclusive, QueueRole.Dlx) : null,
            resolve,
            prefetchCount,
            consumeRetry);
    }
}