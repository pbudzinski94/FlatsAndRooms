using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class Equipment
    {
        public Guid EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        IEnumerable<EquipmentObjectToRent> EquipmentObjectToRents { get; set; }
    }
}
