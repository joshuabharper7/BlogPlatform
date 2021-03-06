using BlogPlatform.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public interface IRepository<T> : ISelectList
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
