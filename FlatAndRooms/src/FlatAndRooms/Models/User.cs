using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string NickName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<ObjectToRent> ObjectsToRent { get; set; }
        public IEnumerable<UserPreference> UserPreference { get; set; }
    }
}
