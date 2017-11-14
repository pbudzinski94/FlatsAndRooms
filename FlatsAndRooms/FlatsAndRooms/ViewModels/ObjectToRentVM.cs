using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.ViewModels
{
    public class ObjectToRentVM
    {
        public Guid ObjectToRentId { get; set; }
        public DateTime AddedDate { get; set; }
        public int Floor { get; set; }
        public string OwnerNickName { get; set; }
    }
}
