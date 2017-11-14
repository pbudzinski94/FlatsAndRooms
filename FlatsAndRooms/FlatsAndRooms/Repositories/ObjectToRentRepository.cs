using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public class ObjectToRentRepository : Repository<ObjectToRent>
    {
        

        public override bool Create(ObjectToRent item)
        {
            try
            {
                dbContext.ObjectToRents.Add(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Create(IEnumerable<ObjectToRent> items)
        {
            try
            {
                dbContext.ObjectToRents.AddRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public override bool Delete(IEnumerable<ObjectToRent> items)
        {
            try
            {
                dbContext.ObjectToRents.RemoveRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(ObjectToRent item)
        {
            try
            {
                dbContext.ObjectToRents.Remove(item);
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
                dbContext.ObjectToRents.RemoveRange(dbContext.ObjectToRents.Where(x => x.ObjectToRentId == id));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override IEnumerable<ObjectToRent> Get()
        {
            return dbContext.ObjectToRents.ToList();
        }

        public override ObjectToRent Get(Guid id)
        {
            try
            {
                return dbContext.ObjectToRents.Where(x => x.ObjectToRentId == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override bool Update(Guid id, ObjectToRent item)
        {
            try
            {
                if (this.Delete(id))
                {
                    dbContext.ObjectToRents.Add(item);
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
