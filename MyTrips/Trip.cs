using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyTrips
{

    internal class Trip: PlaceCity
    {
        //Properties for Trip class. Inherits from PlaceCity
        public int TripID { get; set; } //unikt for hver rejse
        public enum ModeOfTransportation { car, plane, cycle, train, bus, } //flere skal kunne vælges
        public enum Type { RoadTrip, Train, Hiking, Canoo, Work, LongWeekend, RoundTrip, ProjectOrConference, Regeneration, Tourism, FamilyVisit, FriendsVisit }
    }
    
}
