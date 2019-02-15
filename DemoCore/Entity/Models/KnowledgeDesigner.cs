﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Domain.Models
{
    public class KnowledgeDesigner
    {
        public KnowledgeDesigner(): this(0)
        {

        }
        public KnowledgeDesigner(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
        public int KnowledgeId { get; set; }
        public Knowledge Knowledge { get; set; }
        public int DesignerId { get; set; }
        public Designer Designer { get; set; }
        public int Value { get; set; }
    }
}