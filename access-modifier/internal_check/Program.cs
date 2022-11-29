internal class Program
{
    private static void Main(string[] args)
    {
        laptop l = new laptop();
        l.Phonename = "max-check";
        l.price = 4289.8;
        l.user = 1000;
    }
}
class laptop
{
    internal String Phonename;
    internal int user;
    internal double price;
    public void Mobile()
    {
        Console.WriteLine("mobile name");
    }
}