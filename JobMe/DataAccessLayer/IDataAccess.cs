using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataAccess<T>
    {
        bool Create(T obj);
        T Get(int id);
        List<T> GetAll();
        bool Update(T obj);
        void Delete(int id);
    }
}
