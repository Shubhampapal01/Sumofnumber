using System;
using System.Collections.Generic;
using System.Text;

namespace Sumofnumber.Conditional_Statements
{
    class If_elseif
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("number iis negative");
            }
            else
            {
                Console.WriteLine("number is Zero");
            }



        }
    }
    // enter 3 sub marks calculate percentage & display grade
    class Per
    {
        static void Main(string[] args)
        {
           
            
                Console.WriteLine("enter first sub marks");
                int marks1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter second sub marks");
                int marks2 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter third sub marks");
                int marks3 = int.Parse(Console.ReadLine());

                int total = marks1 + marks2 + marks3;
            float average = total /5F;
            float percentage = average * 100;
            Console.WriteLine("percentage"+percentage);
                
            if(percentage>=75)
            {
                Console.WriteLine("grade is A");
            }
            else if(percentage>=50&&percentage<75)
            {
                Console.WriteLine("grade is B");
            }
            else if(percentage<50&&percentage>=40)
            {
                Console.WriteLine("grade is C");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            
        }
    }
    // accept  THREE number from user and print greatest number 
    class Gteatest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if((x>y)&&(x>z))
            {
                Console.WriteLine(x+"is a greater number");
            }
            else if((y>z)&&(y>x))
            {
                Console.WriteLine(y+"is a greater number");
            }
            else
            {
                Console.WriteLine(z+"is a greater number");
            }
        }
    }
    // accept thr year from user & print wheather is it leap or not
    class Leap
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter the year");
            year =Convert.ToInt32(Console.ReadLine());
            if(year%4==0||year%400==0)
            {
                Console.WriteLine("is a leap year");
            }
            else 
            {
                Console.WriteLine("is not a leap year");
            }
        }
    }

    class Day
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num==0)
            {
                Console.WriteLine("today is sunday");

            }
            else if(num==1)
            {
                Console.WriteLine("today is monday");
            }
            else if(num==2)
            {
                Console.WriteLine("today is tuesday");
            }
            else if(num==3)
            {
                Console.WriteLine("today is wednesday");
            }
            else if(num==4)
            {
                Console.WriteLine("today is thursday");
            }
            else if(num==5)
            {
                Console.WriteLine("today is friday");
            }
            else if(num==6)
            {
                Console.WriteLine("today is saturday");
            }
            else
            {
                Console.WriteLine("enter the correct number");
            }
        }
    }
}
