using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deferred_operators
{
    internal class Student
    {
        public int? StudentId { get; set; }
        public String? Name { get; set; }
        public int? TotalMarks { get; set; }
        public static List<Student> getall()
        {

            List<Student> l = new List<Student>
        {
            new Student
            {
                StudentId=101,
                Name="priya",
                TotalMarks=900
            },
            new Student
            {
                StudentId=102,
                Name="bhawna",
                TotalMarks=800
            },
            new Student
            {
                StudentId=103,
                Name="tarkar",
                TotalMarks=800
            }
        }.ToList();
            return l;


        }

    }
}
