using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDal<T>
        where T : class, IEntity
    {
        T Get(int id);
        List<T> GetAll();
        bool Add(T entity);
        bool Remove(int id);
        bool Update(T entity);
        
    }
}
