using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class Location
    {
        public Guid LocationId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public ObjectToRent ObjectToRent { get; set; }
    }
}
