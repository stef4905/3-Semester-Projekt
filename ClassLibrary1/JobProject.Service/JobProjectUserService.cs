using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelLayer;
using BusinessLogicLayer;

namespace JobProject.Service
{
    public class JobProjectUserService : IJobProjectUserService
    {
        private CtrUser ctr = new CtrUser();

        public void Create(User user)
        {
            ctr.Create(user);
        }

        public void Delete(int id)
        {
            ctr.Delete(id);
        }

        public User Get(int id)
        {
            return ctr.Get(id);
        }

        public List<User> GetAll()
        {
            return ctr.GetAll();
        }

        public void Update(User user)
        {
            ctr.Update(user);
        }
    }
}