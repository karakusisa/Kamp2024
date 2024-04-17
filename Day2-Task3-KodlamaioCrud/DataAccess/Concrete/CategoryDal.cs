using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : IDal<Category>
    {
        List<Category> _categories= new();
        public bool Add(Category entity)
        {
            _categories.Add(entity);
            return entity!=null;

        }

        public Category Get(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public bool Remove(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            return _categories.Remove(category);
        }

        public bool Update(Category entity)
        {
            var category = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (category != null)
            {
                category.Name = entity.Name;                
                return true;
            }
            return false;
            
        }
    }
}
