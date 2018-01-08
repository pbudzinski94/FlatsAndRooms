using FlatAndRooms.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.ViewModels
{
    public class AdvertismentToAdd
    {
        public ObjectToRentType Type { get; set; }
        public Guid UserId { get; set; }
        public int RoomsNumber { get; set; }
        public int Floor { get; set; }
        public double Prize { get; set; }
        public int PeopleNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public IEnumerable<EquipmentVM> Equipments { get; set; }
    }
}
