using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPractice
{
    class Fabinocci
    {
        public void series()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int a = 2, b = 4, c, i;
            for (i = 2; i <= num; i++)
            {
                c = a + b;
                Console.WriteLine("The febinocci_Series is:" + c);
                a = b;
                b = c;
            }
        }
    }
}
