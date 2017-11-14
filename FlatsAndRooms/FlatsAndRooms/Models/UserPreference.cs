using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class UserPreference
    {
        public Guid UserPreferenceId { get; set; }
        public string PreferenceDescription { get; set; }
        public User User { get; set; }
    }
}
