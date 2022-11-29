using Calculator;
using System.Security.Cryptography.X509Certificates;

internal class calculator : Airthmetic_Operations
{
    public static void Main(String[] args)
    {

        PerformOperations();
    }

    public static void PerformOperations()
    {
        String? ans = "y";
        do
        {
            double g1;
            double g2;
            
            try
            {
                Console.WriteLine("please enter first number");
                 g1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter Second number");
                 g2 = Convert.ToDouble(Console.ReadLine());

           }
            catch(Exception e)
            {
                Console.WriteLine("please enter the valid number");
                break;
            }
            Console.WriteLine("please select an operation");
            String k = Console.ReadLine();
            calci(k, g1, g2);

            Console.WriteLine("Do U want to continue \n y : yes\n  n:no");
            ans = Console.ReadLine();


        } while (ans == "y" || ans == "Y");

    }
    public static void calci(String k, double g1, double g2)
    {
        switch (k)
        {
            case "+":
                addition(g1, g2);
                break;
            case "-":
                Subtration(g1, g2);
                break;
            case "*":
                Multiplication(g1, g2);
                break;
            case "/":
                Division(g1, g2);
                break;

            default:
                Console.WriteLine("enter correct operation");
                break;
        }


    }


}

