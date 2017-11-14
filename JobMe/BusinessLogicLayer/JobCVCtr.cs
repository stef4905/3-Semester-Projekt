using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    class JobCVCtr : ICollection<JobCV>
    {
        public int Count => throw new NotImplementedException();
        public bool IsReadOnly => throw new NotImplementedException();

        DBJobCV dbJobCV = new DBJobCV();

        /// <summary>
        /// Add the object of an job CV into the database
        /// </summary>
        /// <param name="item"></param>
        public void Add(JobCV item)
        {
            dbJobCV.Create(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(JobCV item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(JobCV[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<JobCV> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(JobCV item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
