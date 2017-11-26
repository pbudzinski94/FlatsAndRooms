using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class ObjectToRentPreference
    {
        public Guid ObjectToRentPreferenceId { get; set; }
        public string PreferenceDescription { get; set; }
        public ObjectToRent ObjectToRent { get; set; }
        public Guid ObjectToRentId { get; set; }
    }
}
