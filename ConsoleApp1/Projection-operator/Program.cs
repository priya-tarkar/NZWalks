using Projection_operator;

internal class Program
{

    /*operators
     1 :select
    2:selectMany */

    private static void Main(string[] args)
    {

        //dispay id of the employee
       var f= Employee.GetAllEmployee().Select(Emp => Emp.EmployeeID);
        var f1 = Employee.GetAllEmployee().Select(emp => new { fname = emp.FirstName, gender = emp.Gender });
        foreach(var i in f1)
        {
            Console.WriteLine(i.fname+" "+i.gender);
        }



        //anonymous operator
        var s = new { id = 10, name = "priya", address = "119 lajpat nagar" };
        Console.WriteLine(s.id);
        Console.WriteLine(s.name);
        Console.WriteLine(s.address);


        var s1 = Employee.GetAllEmployee().Select(emp => new { gen = emp.Gender, an = emp.AnnualSalary / 12 });
        foreach(var r in s1)
        {
            Console.WriteLine(r.gen + " " + r.an);
        }

      /*  var sub = Employee.GetAllEmployee().SelectMany(emp => emp.subject);
        foreach(var i in sub)
        {
            Console.WriteLine(i);
        }*/

        
    }
}