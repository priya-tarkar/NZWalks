internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> l = new List<Employee>
        {
            new Employee { Employeeid=1,EmployeeName=" ",Age=21},
            new Employee { Employeeid = 2, EmployeeName = "operator", Age = 29 },
            new Employee { Employeeid = 4, EmployeeName = "mobile", Age = 30 }

        };

       // Func<Employee, bool> isyoung = delegate (Employee s)
       // {
          //  return s.Age > 18 && s.Age < 30;
        //};

       // var fil = from s in l 
                 // where isyoung(s)
                 // select s;
        

        var f = l.Where(x => x.EmployeeName.Length==0);
        foreach (var j in f)
        {
            Console.WriteLine(j.Employeeid);
        }



    }
    
}
public class Employee
{
    public int  Employeeid{ get; set; }
    public String EmployeeName { get; set; }
    public int Age { get; set; }
}