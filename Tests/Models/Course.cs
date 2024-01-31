using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CorseName { get; set; }

        public long CourseCost { get; set;}
        public ICollection<CustomerCourse> CustomerCourses { get; set; }


    }
}
