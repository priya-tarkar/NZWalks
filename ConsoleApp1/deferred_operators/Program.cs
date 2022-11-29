using deferred_operators;

internal class Program
{
    private static void Main(string[] args)
    {
        //var h = from i in Student.getall() where i.TotalMarks == 800 select i;

        Student.getall().Add(new Student
        {
            StudentId = 102,
            Name = "liar",
            TotalMarks = 800

        });
        foreach(var y in Student.getall())
        {
            Console.WriteLine(y.Name);
        }
    }
}