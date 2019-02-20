﻿using DemoCore.Domain.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCore.Domain.Models
{
    [Table("Occupation", Schema = "DemoCoreData")]
    public class Occupation: Entity
    {
        public Occupation(int id)
        {
            Id = id;
        }
        public Occupation(): this(0)
        {

        }
        public int Id { get; private set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
        public List<OccupationWorkAvailability> WorkAvailabilities { get; set; }
        public List<OccupationBestWorkTime> BestWorkTimes { get; set; }

        public override bool Validate()
        {
            //TODO Implement Validate
            return true;

        }
    }
}
