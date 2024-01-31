using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Models
{
    public class CustomerCourse
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set;}

    }
}
