using _07_AirportDataAccess.Entities;
using System.Collections.Generic;

namespace _05_IntroToEF.Entities
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int MaxPassangers { get; set; }

        //Navigation properties
        /////Relational Type : Flight --- Airplane (1....*)
        public ICollection<Flight> Flights { get; set; }

        public AirplaneType AirplaneType { get; set; }
        public int AirplaneTypeId { get; set; }
    }
}
