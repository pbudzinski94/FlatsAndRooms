using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.ViewModels
{
    public class UserToShowVM
    {
        public Guid UserId { get; set; }
        public string NickName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
