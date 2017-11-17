using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class DBApplierEducation : IDataAccess<ApplierEducation>
    {
        //Is an instance of DBConnection
        DbConnection conn = new DbConnection();

        public bool Create(ApplierEducation obj)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ApplierEducation Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ApplierEducation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ApplierEducation obj)
        {
            throw new NotImplementedException();
        }
    }
}
