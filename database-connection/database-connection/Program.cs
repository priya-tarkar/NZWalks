using database_connection.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        customerContext obj = new customerContext();
        var c = obj.Students.Select(x => x.Name);
        foreach(var b in c)
        {
            Console.WriteLine(b);
        }

        //aggregates function on database

        //1:min function
        var minclass = obj.Students.Select(x => x.Class).Min();
        Console.WriteLine("minimum class of student "+minclass);

        //2:max function
        var maxname = obj.Students.Select(x => x.Name).Max(x => x.Length);
        Console.WriteLine("no. of character in maxlength name "+maxname);

        //3:count function
        var blacklover = obj.Students.Where(x => x.FavouriteColor == "black").Count();
        Console.WriteLine("black colour lover " + blacklover);


        //4: sum function
        var sumclasses = obj.Students.Select(x => x.Class).Sum();
        Console.WriteLine("sum os all classes " + sumclasses);


        //5: average function
       // var aveid = obj.Students.Where(x => x.Class==12).Select obj;




        //restriction operators

        var t1 = obj.Customerdetails.Where(x => x.Custgender == "male");
        foreach(var r in t1)
        {
            Console.WriteLine(r.Custname);
        }
        var t2 = obj.Customerdetails.Select(x => x.Custname);
        foreach(var r in t2)
        {
            Console.WriteLine(r);
        }

    }
}