using ordering_operator;

internal class Program
{
    private static void Main(string[] args)
    {
        /*operators
         1:orderby
        2: oredrby
        3:thenby
        4:thenby descing
        5: reverse*/

        //orderby descing
        var t = Student.GetAll().OrderByDescending  (x=>x.Name);

        var t1 = from i in Student.GetAll()
                 orderby  i.Name descending
                 select i ;
        foreach(var i in t1)
        {
            Console.WriteLine(i.Name);
        }

        //        orderby
        var t2 = Student.GetAll().OrderBy(x => x.Name);

        foreach (var i in t2)
        {
            Console.WriteLine(i.Name);
        }

        //thenby
        var h1 = Student.GetAll().OrderBy(x => x.sId).ThenBy(x => x.Name).ThenByDescending(x=>x.TotalMarks);

        foreach (var i in h1)
        {
            Console.WriteLine(i.sId+" "+i.Name+" "+i.TotalMarks);
        }

        Console.WriteLine("--------------------------------------------");
        var h2 = from i in Student.GetAll()
                 orderby i.sId, i.Name, i.TotalMarks descending
                 select i;
        foreach (var i in h2)
        {
            Console.WriteLine(i.sId + " " + i.Name + " " + i.TotalMarks);
        }
        IEnumerable<Student> ft = Student.GetAll();

        var ro = ft.Reverse();


    }
}