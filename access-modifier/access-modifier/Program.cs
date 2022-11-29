using access_modifier;
using System.Security.Cryptography.X509Certificates;

internal class Program: Protectedcheck
{
    public int key;
    public  static void Main(string[] args)
    {
        //public access modifier example
        Public_check p1 = new Public_check();
        p1.firstname = "reenu";
        p1.lastname = "sharma";
        p1.Id = 1;
        p1.phone = 9892839;
        p1.StudentDetails();



        //private access modifier example
        private_check p2 = new private_check();
        p2.Custamout = 30.98;
        p2.CustId = 1;
        p2.Custgender = "female";
        //p2.customerDetails();



        //protected access modifier example
        Program p3 = new Program();
        p3.carno = 1;
        p3.carname = "BMW";
        p3.carcolor = "Blue";
        p3.carDetails();



    }


}