using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    internal class private_check
    {
        private int custId;
        private String custlocation;
        private String custgender;
        private double custamout;

        public int CustId { get => custId; set => custId = value; }
        public string Custlocation { get => custlocation; set => custlocation = value; }
        public string Custgender { get => custgender; set => custgender = value; }
        public double Custamout { get => custamout; set => custamout = value; }

        private void customerDetails()
        {
            Console.WriteLine("The customer-details are \ncustomer id:{ 0}\ncustlocation:{1}\ncustgender:{2}\ncustamout:{3} ", custId, custlocation, custgender, custamout);

        }
    }
}
