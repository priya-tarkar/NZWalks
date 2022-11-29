using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ordering_operator
{
    internal class Student
    {

        public int? sId { get; set; }
        public String? Name { get; set; }
        public int? TotalMarks { get; set; }
        public static List<Student> GetAll()
        {

            List<Student> l = new List<Student>
        {
            new Student
            {
                sId=101,
                Name="priya",
                TotalMarks=90
            },
            new Student
            {
                sId=101,
                Name="priya",
                TotalMarks=180
            },
            new Student
            {
                sId=103,
                Name="dancer",
                TotalMarks=900
            },
            new Student
            {
                sId=104,
                Name="black",
                TotalMarks=29
            },
        }.ToList();
            return l;
        }
    }
}
