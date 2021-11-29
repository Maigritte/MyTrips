using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrips
{
    internal class PlaceCity
    {
        public string City { get; set; }
        public string Place { get; set; }
        public bool VisitedCity { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime LeavingDate { get; set; }

        //Property i stedet for nedarvning
        public Destination Destination { get; set; }
    }
}
