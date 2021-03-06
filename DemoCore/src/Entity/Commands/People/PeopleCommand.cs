﻿using DemoCore.Domain.Core.Commands;
using DemoCore.Domain.Models;
using System;
using static DemoCore.Domain.Core.Enums.EntityStateEnum;

namespace DemoCore.Domain.Commands
{
    public abstract class PeopleCommand: Command
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Skype { get; protected set; }
        public string Phone { get; protected set; }
        public string LinkedIn { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public string Portfolio { get; protected set; }
        public bool IsDeveloper { get; protected set; }
        public bool IsDesigner { get; protected set; }
        public int OccupationId { get; protected set; }
        public Occupation Occupation { get; protected set; }
        public int KnowledgeId { get; protected set; }
        public Knowledge Knowledge { get; protected set; }
        public EntityStateOptions EntityState { get; protected set; }
    }
}
