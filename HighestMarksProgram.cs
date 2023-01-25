using System;

namespace HighestMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] Marks = new int[5];

            // Accepting value from user 
            for (i = 0; i < 5; i++)
            {
                Console.Write("Enter your number:");
                //Storing value in an array
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int highestmark = 0;
            for (i = 0; i < 5; i++)
            {
                if (Marks[i] > highestmark)
                    highestmark = Marks[i];
            }
            Console.WriteLine("Highest Marks are:{0}",highestmark);
        }
    }
}
