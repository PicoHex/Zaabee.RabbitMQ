﻿using System;

namespace Zaabee.RabbitMQ.Abstractions
{
    public interface IZaabeeRabbitMqClient
    {
        void PublishEvent<T>(T @event);
        void PublishEvent(string eventName, byte[] body);
        void PublishMessage<T>(T message);
        void PublishMessage(string messageName, byte[] body);

        /// <summary>
        /// The subscriber cluster will receive the event by the default queue.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="prefetchCount"></param>
        /// <typeparam name="T"></typeparam>
        void ReceiveEvent<T>(Action<T> handle, ushort prefetchCount = 10);

        /// <summary>
        /// The subscriber cluster will receive the event by its own queue.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="prefetchCount"></param>
        /// <typeparam name="T"></typeparam>
        void SubscribeEvent<T>(Action<T> handle, ushort prefetchCount = 10);

        /// <summary>
        /// The subscriber cluster will receive the message by the default queue.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="prefetchCount"></param>
        /// <typeparam name="T"></typeparam>
        void ReceiveMessage<T>(Action<T> handle, ushort prefetchCount = 10);

        /// <summary>
        /// The subscriber cluster will receive the message by its own queue.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="prefetchCount"></param>
        /// <typeparam name="T"></typeparam>
        void SubscribeMessage<T>(Action<T> handle, ushort prefetchCount = 10);

        /// <summary>
        /// The subscriber node will receive the message by its own queue.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="prefetchCount"></param>
        /// <typeparam name="T"></typeparam>
        void ListenMessage<T>(Action<T> handle, ushort prefetchCount = 10);
    }
}