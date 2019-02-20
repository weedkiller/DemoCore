﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoCore.Domain.Models
{
    [Table("KnowledgeDeveloper", Schema = "DemoCoreData")]
    public class KnowledgeDeveloper
    {
        public KnowledgeDeveloper(): this(0)
        {

        }
        public KnowledgeDeveloper(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
        public int KnowledgeId { get; set; }
        public Knowledge Knowledge { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public int Value { get; set; }
    }
}
