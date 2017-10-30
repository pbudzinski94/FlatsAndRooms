using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public interface IPreference
    {
        Guid UserPreferencesId { get; set; }
        string PreferenceDescription { get; set; }
    }
}
