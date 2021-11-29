using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrips
{
    internal class Food: PlaceCity
    {
        public string Dish { get; set; }
        public bool Consumed { get; set; }
        public string Notes { get; set; }

        //StringBuilder Notes
    }
}
