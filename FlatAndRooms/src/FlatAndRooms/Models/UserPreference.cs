using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class UserPreference : IPreference
    {
        public Guid UserPreferencesId { get; set; }
        public string PreferenceDescription { get; set; }
        public User User { get; set; }
    }
}
