using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class EquipmentObjectToRent
    {
        public Guid EquipmentObjectToRentId { get; set; }
        public string EquipmentDescription { get; set; }
        public ObjectToRent ObjectToRent { get; set; }
        public Guid ObjectToRentId { get; set; }
        public Equipment Equipment { get; set; }
        public Guid EquipmentId { get; set; }
    }
}
