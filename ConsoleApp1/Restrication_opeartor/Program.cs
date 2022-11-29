internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 9, 7, 1, 10, 4, 7, 14 };
        Func<int, bool> f = x => x % 2 == 0;
        var f1 = arr.Where(x=>mymethod(x));
        foreach (var i in f1)
        {
            Console.WriteLine(i);
        }


        //to print index
        
    }

        //passing method as a parameter
        public static bool mymethod(int n)
        {
        return n % 2 == 0;


        }
        //var f2=arr.Where()
    }


