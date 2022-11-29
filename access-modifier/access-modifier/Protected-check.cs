using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    internal class Protectedcheck
    {
        protected int carno;
        protected String carname;
        protected String carcolor;
        public void carDetails()
        {
            Console.WriteLine("Details of the car is carnumber :{0} carname :{1} carcolor:{2}", carno, carname, carcolor);

        }
    }

}
