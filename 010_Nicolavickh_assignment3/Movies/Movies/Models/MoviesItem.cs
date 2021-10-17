using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MoviesItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string duration { get; set; }
        public DateTime release_date { get; set; }
    }
}
