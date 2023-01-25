using System;

namespace SumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter array Elements");
            for (int i = 0; i < 5; i++)
            {
                //Storing value in an array
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Class2.Add(arr);
        }
    }
}
