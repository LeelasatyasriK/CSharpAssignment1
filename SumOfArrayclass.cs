using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfArrayElements
{
    class Class2
    {
        static int Sum=0;
        public static void Add(params int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
               Sum+= arr2[i];
            }
            Console.WriteLine("Sum of array Elements={0}", Sum);

        }
        
    }
}
