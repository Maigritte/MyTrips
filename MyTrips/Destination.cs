using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrips
{//enum ligger udenfor klassen
    public enum Country { Brazil, Germany, Italy, Sweden, Norway, Estonia, Latvia, Lithuania, Switzerland, Belgium, Poland, UK, USA, France, Austria, Spain, Ireland, CzhechRepublic, Slovenia, Scotland, NorthernIreland, Greenland, Japan, Russia, Belarus, Mexico, Nigaragua, Etc }
    public enum Language { English, Danish, Portuguese, German, French, Flemish, Japanese, Thai, Russian, Norwegian, Swedish, Lithuanian }
    internal class Destination

    {
        public int ID { get; set; }
        public Country Country { get; set; }
        public bool VisitedCountry { get; set; }
        public Language Language { get; set; }
        public bool SpokenLanguage { get; set; }   
    }
}
