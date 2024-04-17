using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Insructor:BaseEntity
    {
        public string LastName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
