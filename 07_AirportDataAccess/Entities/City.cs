using _05_IntroToEF.Entities;
using System.Collections.Generic;

namespace _07_AirportDataAccess.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
