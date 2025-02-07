﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ISTSU0_ADT_2023241.Models
{
    public enum Genre
    {
        Metal, Rock, Pop, Blues, Jazz, RapMetal, DeathCore
    }
    public class Band
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        //[JsonIgnore]
        public virtual List<Guitarist> Guitarists { get; set; }
    }
}
