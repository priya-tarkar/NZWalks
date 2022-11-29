using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection_operator
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender{ get; set; }
        public int AnnualSalary { get; set; }
        public List<String> subject { get; set; }

        public static List<Employee> GetAllEmployee()
        {
            List<Employee> lst = new List<Employee>
            {
                new Employee
                {
                    EmployeeID=1,
                    FirstName="priya",
                    LastName="tarkar",
                    Gender="Female",
                    AnnualSalary=6000,
                    subject={"physics","c#"}

                },
                new Employee
                {
                    EmployeeID=2,
                    FirstName="bhawna",
                    LastName="sisodiya",
                    Gender="Female",
                    AnnualSalary=11000,
                  subject={"chemistry","Maths","english"}

                },
                new Employee
                {
                    EmployeeID=5,
                    FirstName="priya",
                    LastName="kumar",
                    Gender="Male",
                    AnnualSalary=21000,
                     subject={"dance","physical","english"}

                }
            }.ToList();
            return lst;
        }

    }
    
}
