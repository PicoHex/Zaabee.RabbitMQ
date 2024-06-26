namespace Aoxe.RabbitMQ.Abstractions;

public static partial class PublisherExtension
{
    /// <summary>
    /// Send the command to the default topic.
    /// </summary>
    /// <param name="publisher"></param>
    /// <param name="command"></param>
    /// <param name="publishRetry"></param>
    /// <typeparam name="T"></typeparam>
    public static void SendCommand<T>(
        this IPublisher publisher,
        T? command,
        int publishRetry = Consts.DefaultPublishRetry
    )
    {
        var topic = InternalHelper.GetTopicName(typeof(T));
        publisher.Publish(topic, command, true, publishRetry, topic);
    }

    /// <summary>
    /// Send the command to the specified topic.
    /// </summary>
    /// <param name="publisher"></param>
    /// <param name="topic"></param>
    /// <param name="command"></param>
    /// <param name="publishRetry"></param>
    /// <typeparam name="T"></typeparam>
    public static void SendCommand<T>(
        this IPublisher publisher,
        string topic,
        T? command,
        int publishRetry = Consts.DefaultPublishRetry
    ) => publisher.Publish(topic, command, true, publishRetry, topic);

    /// <summary>
    /// Send the command to the specified topic.
    /// </summary>
    /// <param name="publisher"></param>
    /// <param name="topic"></param>
    /// <param name="body"></param>
    /// <param name="publishRetry"></param>
    public static void SendCommand(
        this IPublisher publisher,
        string topic,
        byte[] body,
        int publishRetry = Consts.DefaultPublishRetry
    ) => publisher.Publish(topic, body, true, publishRetry, topic);
}
