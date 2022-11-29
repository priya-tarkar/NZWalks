
using Calculator;
using System;
using System.Security.Cryptography.X509Certificates;

internal class calculator:Airthmetic_Operations
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
            Console.WriteLine("This is a calculator \n enter first no");
            double g1;
            bool a1 = double.TryParse(Console.ReadLine(), out g1);
            //Console.WriteLine(a1);
            if (a1 == false)
            {
                Console.WriteLine("please enter a valid number");
                break;
            }
            double g2;
            Console.WriteLine("enter second no");
            bool a2 = double.TryParse(Console.ReadLine(), out g2);


            if (a2 == false)
            {
                Console.WriteLine("please enter a valid number");
                break;

            }
            Console.WriteLine("please select an operation");
            String k = Console.ReadLine();
            calci(k, g1, g2);

            Console.WriteLine("Do U want to continue");
            ans = Console.ReadLine();


        } while (ans == "y" || ans == "Y");

    }
    public static  void calci(String k, double g1, double g2)
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
            case "%":
                Division(g1, g2);
                break;

            default:
                Console.WriteLine("enter correct operation");
                break;
        }


    }
   

}