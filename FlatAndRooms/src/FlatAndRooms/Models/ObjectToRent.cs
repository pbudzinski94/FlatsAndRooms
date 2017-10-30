using FlatAndRooms.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class ObjectToRent
    {
        public Guid ObjectToRentId { get; set; }
        public DateTime AddedDate { get; set; }
        public ObjectToRentType Type { get; set; }
        public int RoomsNumber { get; set; }
        public int Floor { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
        IEnumerable<EquipmentObjectToRent> EquipmentObjectToRents { get; set; }
        public IEnumerable<UserPreference> UserPreference { get; set; }
    }
}
