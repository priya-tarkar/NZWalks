using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    /*operators
     1: To List
    2:ToArray
    3:ToDictionary
    4:ToLookUp
    5: Cast
    6:OfType
    7:AsEnumerable
    8:ASqueryable
    */
    private static void Main(string[] args)
    {
        //to list
        int[] n = { 1, 2, 3, 4 };
        List<int> l = n.ToList();
        foreach (int i in l)
        {
            Console.WriteLine(i);
        }

        //to array
        List<String> list = new List<string> { "priya", "bhawna", "garima", "tarkar" };
        String[] str = (from i in list orderby i descending select i).ToArray();
        foreach (var j in str)
        {
            Console.WriteLine(j);
        }

        //to dictionary
        List<Student> lst = new List<Student>
        {
            new Student{StudentId=101,Name="priya",TotalMarks=900},
            new Student{StudentId=189,Name="tarkar",TotalMarks=10000},
            new Student{StudentId=189,Name="piyuhj",TotalMarks=900}
        };
        var dict = lst.ToLookup(w => w.StudentId);
        foreach (var i in dict)
        {
            Console.WriteLine(i.Key);
            foreach (var j in dict[i.Key])
            {
                Console.WriteLine(j.Name + "\t" + j.TotalMarks);
            }
        }




        //cast operator : throw exception for different type
        ArrayList list1 = new ArrayList();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add("4");
       // IEnumerable<int> j1 = list1.Cast<int>();

        /*foreach(int i in j1)
        {
            Console.WriteLine(i);
        }*/

        //oftype operatot : will not throw exception if return type is not valid

        IEnumerable<int> j3 = list1.OfType<int>();

        foreach (int i in j3)
        {
            Console.WriteLine(i);
        }



    }
}
class Student
{
    public int StudentId { get; set; }
    public String Name { get; set; }
    public int TotalMarks { get; set; }
}