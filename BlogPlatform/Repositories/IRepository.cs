﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}
