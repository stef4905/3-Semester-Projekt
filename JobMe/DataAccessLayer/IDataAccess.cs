﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataAccess<T>
    {
        void Create(T obj);
        T Get(int id);
        List<T> GetAll();
        void Update(T obj);
        void Delete(int id);
    }
}
