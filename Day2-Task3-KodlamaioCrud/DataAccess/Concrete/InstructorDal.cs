using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IDal<Insructor>
    {
        List<Insructor> _insructors = new();
        public bool Add(Insructor entity)
        {
            _insructors.Add(entity);
            return entity != null;
        }

        public Insructor Get(int id)
        {
            return _insructors.FirstOrDefault(c => c.Id == id);
        }

        public List<Insructor> GetAll()
        {
            return _insructors;
        }

        public bool Remove(int id)
        {
            var insructor = _insructors.FirstOrDefault(c=>c.Id == id);
            if (insructor != null)
            {
                return _insructors.Remove(insructor);                
            }
            return false;

        }

        public bool Update(Insructor entity)
        {
            var insructor = _insructors.FirstOrDefault(c => c.Id == entity.Id);
            if (insructor != null)
            {
                insructor.Name = entity.Name;
                insructor.LastName = entity.LastName;
                return true;
            }
            return false;
        }
    }
}
