﻿namespace Zaabee.RabbitMQ.Demo;

public class Subscriber
{
    public void TestEventHandler(TestEvent? testEvent)
    {

    }

    public Task TestEventHandlerAsync(TestEvent? testEvent)
    {
        return Task.CompletedTask;
    }

    public void TestEventExceptionHandler(TestEvent testEvent)
    {
        throw new Exception("Test");
    }

    public void TestEventWithVersionHandler(TestEventWithVersion testEventWithVersion)
    {

    }

    public void TestEventExceptionWithVersionHandler(TestEventWithVersion? testEventWithVersion)
    {
        throw new Exception("Test");
    }

    public void TestMessageHandler(TestMessage? testMessage)
    {
        var i = testMessage;
        if (i is not null)
            i.Timestamp = DateTimeOffset.Now;
    }
}