internal class Program
{
    private static void Main(string[] args)
    {

        /*operators
         1:take
        2:skip
        3:takewhile
        4:skipwhile
        */

        //take
        String[] c = { "aus", "canada", "germany", "us", "india", "uk", "Italy" };
        IEnumerable<String> res = c.TakeLast(3).Reverse();
        foreach(var i in res)
        {
            Console.WriteLine(i);
        }
        //through sql
        var k = (from i in c select i).Take(3);
        foreach (var i in k)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("----------------------------------");

        //2:skip method
        var j = c.Skip(3);
        foreach (var i in j)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------------------------------");
        var j1 = c.TakeWhile(x => x.Length > 2);
        foreach (var i in j1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("----------------------------------");
        var j2 = c.SkipWhile(x => x.Length > 2);
        foreach (var i in j2)
        {
            Console.WriteLine(i);
        }



        /*
         * deferred or lazy operator
         * immediate operator*/

        List<>





    }

    }