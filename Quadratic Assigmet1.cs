// Using if statement
using System;
public class Exercise1
{
    public static void Main()
    {
        double a, b, c;

        double d, x1, x2, sqrt_val;
        Console.Write("\n\n");
        Console.Write("Calculate root of Quadratic Equation :\n");
        Console.Write("----------------------------------------");
        Console.Write("\n\n");

        a = 1; b = 6; c = 5;

        d = b * b - 4 * a * c;
        sqrt_val = Math.Sqrt(Math.Abs(d));
        if (d == 0)
        {
            Console.Write("Both roots are equal.\n");
            x1 = -b / (2.0 * a);
            x2 = x1;
            Console.Write("First  Root Root1= {0}\n", x1);
            Console.Write("Second Root Root2= {0}\n", x2);
        }
        else if (d > 0)
        {
            Console.Write("Both roots are real and different\n");

            x1 = ((-b + sqrt_val) / (2 * a));
            x2 = ((-b - sqrt_val) / (2 * a));

            Console.Write("First  Root Root1= {0}\n", x1);
            Console.Write("Second Root root2= {0}\n", x2);
        }
        else
        {
            Console.Write("Complex Roots;\n");
            x1 = (-b / (2 * a));
            x2 = (-b / (2 * a));
            Console.Write("First  Root Root1= {0} +i{1}\n", x1, sqrt_val);
            Console.Write("Second Root root2= {0} -i{1}\n", x2, sqrt_val);
        }  
    }
}

/*
// Using Switch statement
using System;
public class Exercise1
{
    public static void Main()
    {
        double a, b, c, count2;

        double d, x1, x2, sqrt_val;
        Console.Write("\n\n");
        Console.Write("Calculate root of Quadratic Equation :\n");
        Console.Write("----------------------------------------");
        Console.Write("\n\n");

        a = 1; b = 6; c = 5;

        d = b * b - 4 * a * c;
        sqrt_val = Math.Sqrt(Math.Abs(d));

        count2 = 0;
        while (count2 <= 2)
        {
            switch (count2)
            {
                case 0 when d == 0:
                    Console.Write("Both roots are equal.\n");

                    x1 = -b / (2.0 * a);
                    x2 = x1;

                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root Root2= {0}\n", x2);
                    break;
                case 1 when d > 0:
                    Console.Write("Both roots are real and different\n");

                    x1 = ((-b + sqrt_val) / (2 * a));
                    x2 = ((-b - sqrt_val) / (2 * a));

                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root root2= {0}\n", x2);
                    break;
                case 2 when d < 0:
                    Console.Write("Complex Roots;\n");

                    x1 = (-b / (2 * a));
                    x2 = (-b / (2 * a));

                    Console.Write("First  Root Root1= {0} +i{1}\n", x1, sqrt_val);
                    Console.Write("Second Root root2= {0} -i{1}\n", x2, sqrt_val);
                    break;
            }
            count2 += 1;
        }
    }
}
*/
