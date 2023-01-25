using System;
using System.Collections.Generic;
using System.Text;

namespace SwapNumbers
{
    class Class1
    {
        public void Swap(int a, int b)
        {
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap a= " + a + " b= " + b);

        }
    }
}
