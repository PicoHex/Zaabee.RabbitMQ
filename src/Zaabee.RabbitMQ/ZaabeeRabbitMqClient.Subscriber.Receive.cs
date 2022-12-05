namespace Zaabee.RabbitMQ;

public partial class ZaabeeRabbitMqClient
{
    public void Receive<T>(
        Func<Action<T?>> resolve,
        bool persistence,
        ushort prefetchCount = DefaultPrefetchCount,
        int retry = 0,
        bool dlx = false)
    {
        var topic = GetTypeName(typeof(T));
        var exchangeParam = GetExchangeParam(topic, MessageType.Message);
        var queueParam = GetQueueParam(topic, MessageType.Message, SubscribeType.Receive);
        Subscribe(exchangeParam, queueParam, resolve, MessageType.Message, prefetchCount);
    }

    public void Receive<T>(
        Func<Func<T?, Task>> resolve,
        bool persistence,
        ushort prefetchCount = DefaultPrefetchCount,
        int retry = 0,
        bool dlx = false)
    {
        var topic = GetTypeName(typeof(T));
        var exchangeParam = GetExchangeParam(topic, MessageType.Message);
        var queueParam = GetQueueParam(topic, MessageType.Message, SubscribeType.Receive);
        Subscribe(exchangeParam, queueParam, resolve, MessageType.Message, prefetchCount);
    }

    public void Receive<T>(
        string topic,
        Func<Action<T?>> resolve,
        bool persistence,
        ushort prefetchCount = DefaultPrefetchCount,
        int retry = 0,
        bool dlx = false)
    {
        var exchangeParam = GetExchangeParam(topic, MessageType.Message);
        var queueParam = GetQueueParam(topic, MessageType.Message, SubscribeType.Receive);
        Subscribe(exchangeParam, queueParam, resolve, MessageType.Message, prefetchCount);
    }

    public void Receive<T>(
        string topic,
        Func<Func<T?, Task>> resolve,
        bool persistence,
        ushort prefetchCount = DefaultPrefetchCount,
        int retry = 0,
        bool dlx = false)
    {
        var exchangeParam = GetExchangeParam(topic, MessageType.Message);
        var queueParam = GetQueueParam(topic, MessageType.Message, SubscribeType.Receive);
        Subscribe(exchangeParam, queueParam, resolve, MessageType.Message, prefetchCount);
    }

    public void Receive(
        string topic,
        Func<Action<byte[]>> resolve,
        bool persistence,
        ushort prefetchCount = DefaultPrefetchCount,
        int retry = 0,
        bool dlx = false)
    {
        var exchangeParam = GetExchangeParam(topic, MessageType.Message);
        var queueParam = GetQueueParam(topic, MessageType.Message, SubscribeType.Receive);
        Subscribe(exchangeParam, queueParam, resolve, MessageType.Message, prefetchCount);
    }

    public void Receive(
        string topic,
        Func<Func<byte[], Task>> resolve,
        bool persistence,
        ushort prefetchCount = DefaultPrefetchCount,
        int retry = 0,
        bool dlx = false)
    {
        var exchangeParam = GetExchangeParam(topic, MessageType.Message);
        var queueParam = GetQueueParam(topic, MessageType.Message, SubscribeType.Receive);
        Subscribe(exchangeParam, queueParam, resolve, MessageType.Message, prefetchCount);
    }
}