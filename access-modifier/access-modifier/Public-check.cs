using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    internal class Public_check
    {
        public int Id;
        public String? firstname;
        public String? lastname;
        public long phone;
        public void StudentDetails()
        {
            Console.WriteLine("The student id : " + Id);
            Console.WriteLine("The name is {0} {1}",firstname,lastname);
            Console.WriteLine("The phone number is "+ phone);


        }
    }
}
