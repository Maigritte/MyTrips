using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrips
{
    internal class LiteratureFilm: Destination
    {
        public string Title { get; set; }
        public bool ReadWatched { get; set; }

        public string Author { get; set; }

        public string Subject {get; set; }

    }
}
