﻿using System;
using System.Collections.Generic;

namespace _05_IntroToEF.Entities
{

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }


        /////Relational Type : Flight --- Client (*....*)
        public ICollection<Flight> Flights { get; set; }

    }
}
