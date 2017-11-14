using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public class ObjectToRentPreferencesRepository : Repository<ObjectToRentPreference>
    {
        

        public override bool Create(ObjectToRentPreference item)
        {
            try
            {
                dbContext.ObjectToRentPreferences.Add(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Create(IEnumerable<ObjectToRentPreference> items)
        {
            try
            {
                dbContext.ObjectToRentPreferences.AddRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(IEnumerable<ObjectToRentPreference> items)
        {
            try
            {
                dbContext.ObjectToRentPreferences.RemoveRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(ObjectToRentPreference item)
        {
            try
            {
                dbContext.ObjectToRentPreferences.Remove(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(Guid id)
        {
            try
            {
                dbContext.ObjectToRentPreferences.RemoveRange(dbContext.ObjectToRentPreferences.Where(x => x.ObjectToRentPreferenceId == id));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override IEnumerable<ObjectToRentPreference> Get()
        {
            return dbContext.ObjectToRentPreferences.ToList();
        }

        public override ObjectToRentPreference Get(Guid id)
        {
            try
            {
                return dbContext.ObjectToRentPreferences.Where(x => x.ObjectToRentPreferenceId == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override bool Update(Guid id, ObjectToRentPreference item)
        {
            try
            {
                if (this.Delete(id))
                {
                    dbContext.ObjectToRentPreferences.Add(item);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
