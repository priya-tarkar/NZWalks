internal class Program
{
    private static void Main(string[] args)
    {
        /* operators
         1: min
        2: max
        3:count
        4:sum
        5:average
        */

        int[] arr = { 9, 7, 1, 10, 4, 7, 14 };
        //to find min val
        // var f = arr.Where(x => x % 2 == 0).Min();

        var f = (from i in arr where i % 2 == 0 select i).Min();
            // foreach(var p in f)
            //{
            Console.WriteLine("minimum even number value " + f);
        //}

        //to find max val
        //var f1 = arr.Max();
        var f1 = (from i in arr where i % 2 != 0 select i).Max();
        Console.WriteLine("max no." + f1);

        //sum of all no.
        var sum = arr.Sum();
        var sum1 = (from i in arr select i).Sum();
        Console.WriteLine("sum of number" + sum1);

        //count of element
        var c = arr.Where(x=>x%2!=0).Count();
        var c1 = (from i in arr select i).Count();
        Console.WriteLine("number of elements" + c);

        //avaerage of number
        Console.WriteLine(arr.Average());



        String[] cnt = { "india", "chin", "bangladesh" };
        int min = cnt.Min(x => x.Length);
        int max = cnt.Max(x => x.Length);

        var minl = (from i in cnt select i.Length).Min(); 

        Console.WriteLine("the min " + minl);
        Console.WriteLine("the max " + max);


    }
}