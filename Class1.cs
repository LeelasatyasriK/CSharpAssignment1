using System;
using System.Collections.Generic;
using System.Text;

namespace AreaAndCircumference
{
    class Class1
    {
        double Area = 0.00;
        double Circumference = 0.00;
        public void AreaCircumference(double rd ,double Pi,ref double Area,ref double Circumference)
        {
             Area = Pi * rd * rd;
             Circumference = 2 * Pi * rd;

        }
    }
}
