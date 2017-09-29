using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CtrUser : IController<User>
    {
        private DbUser dbUser = new DbUser();

        public void Create(User entity)
        {
            dbUser.Create(entity);
        }

        public void Delete(int id)
        {
            dbUser.Delete(id);
        }

        public User Get(int id)
        {
            return dbUser.Get(id);
        }

        public List<User> GetAll()
        {
            return dbUser.GetAll();
        }

        public void Update(User entity)
        {
            dbUser.Update(entity);
        }
    }
}
