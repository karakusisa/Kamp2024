using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : IDal<Course>
    {
        List<Course> _courses = new ();
        
        public bool Add(Course entity)
        {
            _courses.Add(entity);            
            return entity != null;
        }

        public Course Get(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id); 
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public bool Remove(int id)
        {
            var course = _courses.FirstOrDefault(c=>c.Id == id);
            return _courses.Remove(course);
        }

        public bool Update(Course entity)
        {
            var course = _courses.FirstOrDefault(c => c.Id == entity.Id);
            if (course != null)
            {
                course.Name = entity.Name;
                course.CategoryId = entity.CategoryId;
                course.Progress = entity.Progress;
                course.ImageUrl = entity.ImageUrl;
                return true;
            }
            
            return false;      
        }
    }
}
