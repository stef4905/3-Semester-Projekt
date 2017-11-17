using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ApplierEducationCtr : IController<ApplierEducation>
    {
        DBApplierEducation dbApplierEducation = new DBApplierEducation();

        public void Create(ApplierEducation obj)
        {
            dbApplierEducation.Create(obj);
        }

        public void Delete(int id)
        {
            dbApplierEducation.Delete(id);
        }

        public ApplierEducation Get(int id)
        {
            return dbApplierEducation.Get(id);
        }

        public List<ApplierEducation> GetAllByJobCVId(int id)
        {
            return dbApplierEducation.GetAllByJobCVId(id);
        }

        public List<ApplierEducation> GetAll()
        {
            return dbApplierEducation.GetAll();
        }

        public void Update(ApplierEducation obj)
        {
            dbApplierEducation.Update(obj);
        }
    }
}
