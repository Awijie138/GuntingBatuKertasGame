﻿using System;

namespace Agate.MVC.Core
{
    public class PublishSubscribe
    {
        private static PublishSubscribe _instance;
        public static PublishSubscribe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PublishSubscribe();
                }
                return _instance;
            }
        }

        protected PublishSubscribe() { }

        private Aggregator _aggregator = new Aggregator();

        public virtual void Publish<TMessage>(TMessage message)
        {
            _aggregator.Publish(message);
        }

        public virtual void Subscribe<TMessage>(Action<TMessage> subscriber)
        {
            _aggregator.Subscribe(subscriber);
        }

        public virtual void UnsubscribeAll()
        {
            _aggregator.UnsubscribeAll();
        }

        public virtual void UnsubscribeAll<TMessage>()
        {
            _aggregator.UnsubscribeAll<TMessage>();
        }

        public virtual void Unsubscribe<TMessage>(Action<TMessage> subscriber)
        {
            _aggregator.Unsubscribe(subscriber);
        }
    }
}
