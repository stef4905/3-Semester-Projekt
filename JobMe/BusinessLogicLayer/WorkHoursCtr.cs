using DataAccessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class WorkHoursCtr : IController<WorkHours>
    {

        DbWorkHour dbWorkHour = new DbWorkHour();

        public void Create(WorkHours obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public WorkHours Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is a method that calls the GetAll method from the DbAccesLayer
        /// </summary>
        /// <returns></returns>
        public List<WorkHours> GetAll()
        {
           return dbWorkHour.GetAll();
        }

        public void Update(WorkHours obj)
        {
            throw new NotImplementedException();
        }
    }
}
