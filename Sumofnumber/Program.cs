using System;

namespace Sumofnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the number");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine($"sum is {sum}");

        }
    }
    // Assignment operator
    class Program2
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10, c = 10, d = 10;
            a += 10;
            b -= 10;
            c *= 10;
            d /= 10;
            Console.WriteLine($"value of a{a}");
            Console.WriteLine($"value of b{b}");
            Console.WriteLine($"value of c{c}");
            Console.WriteLine($"value of d{d}");
        }
    }
    //relational operator
    class Program3
    {
        static void Main(string[] args)
        {
            int a = 20, b = 19;
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
        }
    }
    // accept the radius from user &calculate the area of circle
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            int r = int.Parse(Console.ReadLine());
            Double PI;
            PI = 3.14;
            double Area_of_Circle = PI * r * r;
            Console.WriteLine(Area_of_Circle);


        }
    }
    // accept 3 marks of subject and calculate total and percentage
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the marks");
            int marks1 = Convert.ToInt32(Console.ReadLine());
            int marks2 = Convert.ToInt32(Console.ReadLine());
            int marks3 = Convert.ToInt32(Console.ReadLine());
            int total = marks1 + marks2 + marks3;
            double percentage = total / 3;
            Console.WriteLine($"total marks{total}and percentage{percentage}");

        }
    }
    //create a program using all arithmatic oprator
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"sum is{sum}");

            int Sub = num1 - num2;
            Console.WriteLine($"sub is{Sub}");

            int multiply = num1 * num2;
            Console.WriteLine($"multiply is{multiply}");

            double Div = num1 / num2;
            Console.WriteLine($"Div is{Div}");

            int mod = num1 % num2;
            Console.WriteLine($"Remender is{mod}");


        }
    }
    //Accept the radius from user &calculate the area of circle
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius");
            int r = int.Parse(Console.ReadLine());
            double PI;
            PI = 3.14;
            double Areaofcircle = PI * r * r;
            Console.WriteLine($"Areaofcircle{Areaofcircle}");
        }
    }
    //Accept the value L &B calculate the area of rectangle
    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the L & B");
            int L = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int area;
            area = L * B;
            Console.WriteLine($"Area of rectangle{area}");

        }
    }
    // accept the number from user and print square and cube
    class Program9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int square, cube;
            square = num * num;
            cube = num * num * num;
            Console.WriteLine($"Square is{square} cube is{cube}");
        }
    }
    //
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the basic salary");
            int bs = int.Parse(Console.ReadLine());

            // calculate hra=12%of basic salary
            double hra = (12 * bs) / 100;
            Console.WriteLine($"hra is {hra}");

            //da=20% OF BASIC SALARY
            double da = (20 * bs) / 100;
            Console.WriteLine($"the da of employee{da}");

            //ta=10% of basic salary
            double ta = (10 * bs) / 100;
            Console.WriteLine($"the ta of employee{ta}");

            //pf=12% of basic salary
            double pf = (12 * bs) / 100;
            Console.WriteLine($"the pf of employee{pf}");

            //Net paid salary of employee
            double totalsalary = bs + hra + da + ta - pf;
            Console.WriteLine($"the total salary of the employee{totalsalary}");

        }
    }
    // swap of two number using third variable
    class Program11
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 20;
            b = 40;
            Console.WriteLine($"Display number a={a} b={b}");


            c = a;
            a = b;
            b = c;
            Console.WriteLine($"swapping of two number using third variable a={a} b={b}");


        }
    }
    // swap of two number without using third variable
    class Program12
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 30;
            b = 20;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"swap number a={a} b={b}");
        }
    }
    // accept the number from user & check the number is even or odd
    class Program13
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
