using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] cousses = {
        new Course { Id = 1, Description = "Delphi", Name = "Delphi", Price = 0 }
    };
    public CourseManager()
    {

    }
    public  List<Course> GetAll()
    {
        //Console.WriteLine("GetAll()-> Kurslar listelendi");
        CourseDal courseDal = new(); 
        return courseDal.GetAll();
    }
}
