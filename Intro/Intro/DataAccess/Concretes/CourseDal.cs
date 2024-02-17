using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class CorseDal
{
    List<Course> courses;
    public CorseDal()
    {

        courses = new List<Course>();
        courses.Add(new Course { Id = 1, Description = "Delphi", Name = "Delphi", Price = 0 });

    }
    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

}
