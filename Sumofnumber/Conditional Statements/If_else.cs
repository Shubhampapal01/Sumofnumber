using System;
using System.Collections.Generic;
using System.Text;

namespace Sumofnumber.Conditional_Statements
{
    class If_else
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }

            
        }
    }
}
