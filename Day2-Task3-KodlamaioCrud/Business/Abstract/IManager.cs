using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IManager<T> where T : class, IEntity
    {
        T Get(int id);
        List<T> GetAll();
        bool Add(T entity);
        bool Remove(int id);
        bool Update(T entity);
    }
}
