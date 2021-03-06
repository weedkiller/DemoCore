﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCore.Domain.Core.Events
{
    [Table("StoredEvent", Schema = "EventStore")]
    public class StoredEvent : Event
    {
        public StoredEvent(Event theEvent, string data, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = theEvent.AggregateId;
            MessageType = theEvent.MessageType;
            Data = data;
            User = user;
        }

        // EF Constructor
        protected StoredEvent() { }

        public Guid Id { get; private protected set; }

        public string Data { get; private protected set; }

        public string User { get; private protected set; }
    }
}
