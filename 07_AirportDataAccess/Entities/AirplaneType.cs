using _05_IntroToEF.Entities;
using System.Collections.Generic;

namespace _07_AirportDataAccess.Entities
{
    public class AirplaneType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Airplane> Airplanes { get; set; }
    }
}
