using System;

namespace AreaAndCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            const double PI = 3.14;
            Console.Write("\nEnter the radius of circle ");
            r = Convert.ToDouble(Console.ReadLine());
            Class1 c1 = new Class1();
            double Area = 0.00;
            double Circumference = 0.00;
            c1.AreaCircumference(r, PI, ref Area, ref Circumference);
            Console.WriteLine("Area of Circle:{0}", Area);
            Console.WriteLine("Circumference of Circle:{0}", Circumference);
        }
    }
}
