using DataAccessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ApplierCtr : IController<Applier>
    {
        //Connection to database
        private DbApplier dbApplier = new DbApplier();

        public void Create(Applier obj)
        {
            dbApplier.Create(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Applier Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Applier> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Applier obj)
        {
            throw new NotImplementedException();
        }
    }
}
