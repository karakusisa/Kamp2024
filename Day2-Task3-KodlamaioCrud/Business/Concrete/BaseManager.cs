using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaseManager<S, T> : IManager<T>
        where T : class, IEntity
        where S : class, IDal<T>, new()
        
    {
        protected S _service = new S();

        public bool Add(T entity)
        {
            return _service.Add(entity);
        }

        public T Get(int id)
        {
            return _service.Get(id);
        }

        public List<T> GetAll()
        {
            return _service.GetAll();
        }

        public bool Remove(int id)
        {
            return _service.Remove(id);
        }

        public bool Update(T entity)
        {
            return _service.Update(entity);
        }
    }
}
