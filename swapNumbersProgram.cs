using System;
namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            int j = Convert.ToInt32(Console.ReadLine());
            Class1 c = new Class1();
            c.Swap(i, j);


        }
    }
}
