using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public class LocationRepository : Repository<Location>
    {
       

        public override bool Create(Location item)
        {
            try
            {
                dbContext.Location.Add(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Create(IEnumerable<Location> items)
        {
            try
            {
                dbContext.Location.AddRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(IEnumerable<Location> items)
        {
            try
            {
                dbContext.Location.RemoveRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(Location item)
        {
            try
            {
                dbContext.Location.Remove(item);
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
                dbContext.Location.RemoveRange(dbContext.Location.Where(x => x.LocationId == id));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override IEnumerable<Location> Get()
        {
            return dbContext.Location.ToList();
        }

        public override Location Get(Guid id)
        {
            try
            {
                return dbContext.Location.Where(x => x.LocationId == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override bool Update(Guid id, Location item)
        {
            try
            {
                if (this.Delete(id))
                {
                    dbContext.Location.Add(item);
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
