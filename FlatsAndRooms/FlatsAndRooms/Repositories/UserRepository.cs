using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public class UserRepository : Repository<User>
    {
        

        public override bool Create(User item)
        {
            try
            {
                dbContext.Users.Add(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Create(IEnumerable<User> items)
        {
            try
            {
                dbContext.Users.AddRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(IEnumerable<User> items)
        {
            try
            {
                dbContext.Users.RemoveRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(User item)
        {
            try
            {
                dbContext.Users.Remove(item);
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
                dbContext.Users.RemoveRange(dbContext.Users.Where(x => x.UserId == id));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override IEnumerable<User> Get()
        {
            return (from u in dbContext.Users select u).ToList();
        }

        public override User Get(Guid id)
        {
            try
            {
                return dbContext.Users.Where(x => x.UserId == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override bool Update(Guid id, User item)
        {
            try
            {
                if (this.Delete(id))
                {
                    dbContext.Users.Add(item);
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
