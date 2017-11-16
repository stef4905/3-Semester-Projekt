using BusinessLogicLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFJobMeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ApplierService" in both code and config file together.
    public class ApplierService : IApplierService
    {
        private ApplierCtr applierCtr = new ApplierCtr();

        public void Create(Applier applier)
        {
            applierCtr.Create(applier);
        }

        public List<Applier> GetAllAppliers()
        {
            return applierCtr.GetAll();
        }
    }
}
