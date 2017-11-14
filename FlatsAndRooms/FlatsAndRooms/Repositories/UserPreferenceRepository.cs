using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public class UserPreferenceRepository : Repository<UserPreference>
    {
       

        public override bool Create(UserPreference item)
        {
            try
            {
                dbContext.UserPreference.Add(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Create(IEnumerable<UserPreference> items)
        {
            try
            {
                dbContext.UserPreference.AddRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(IEnumerable<UserPreference> items)
        {
            try
            {
                dbContext.UserPreference.RemoveRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(UserPreference item)
        {
            try
            {
                dbContext.UserPreference.Remove(item);
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
                dbContext.UserPreference.RemoveRange(dbContext.UserPreference.Where(x => x.UserPreferenceId == id));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override IEnumerable<UserPreference> Get()
        {
            return dbContext.UserPreference.ToList();
        }

        public override UserPreference Get(Guid id)
        {
            try
            {
                return dbContext.UserPreference.Where(x => x.UserPreferenceId == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override bool Update(Guid id, UserPreference item)
        {
            try
            {
                if (this.Delete(id))
                {
                    dbContext.UserPreference.Add(item);
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
