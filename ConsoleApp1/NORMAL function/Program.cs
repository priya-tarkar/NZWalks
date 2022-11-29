using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 9, 7, 1, 10, 4, 7, 14 };

        int? res = arr[0];
        foreach(var i in arr)
        {

            if(i<res && i%2==0)
            {
                res = i;
            }
        }
        Console.WriteLine(res);
    }
}