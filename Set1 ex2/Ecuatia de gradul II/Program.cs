using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            //************* ECUATIA DE GRADUL II *****************
            //                 a*x^2+b*x+c=0
            Console.Write("Introduceti coeficientul lui x^2 (a):");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introduceti coeficientul lui x (b):");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Introduceti termenul liber (c):");
            double c = double.Parse(Console.ReadLine());
            if (a != 0)
            {
                
                double d, dSqrt, x1, x2, x12,xComplex;
                d = (b * b) - (4 * a * c);
                dSqrt = Math.Sqrt(b * b - (4 * a * c));

                if (dSqrt > 0)
                {
                    x1 = (-b - dSqrt) / (2 * a);
                    x2 = (-b + dSqrt) / (2 * a);
                    Console.WriteLine($"x1={x1}");
                    Console.WriteLine($"x2={x2}");
                }
                else if (d == 0)
                {
                    x12 = -b / (2 * a);
                    Console.WriteLine($"x={x12}");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu admite solutii reale.");
                    Console.Write("Solutiile complexe sunt:");

                    d = Math.Abs(d);
                    d = Math.Sqrt(d);
                    d= d/(2*a);
                    xComplex = (-b / (2 * a));

                    Console.WriteLine($"x1={xComplex} + {d}i");
                    Console.WriteLine($"x2={xComplex} + {d}i");
              
                }

            }
            else if (a == 0)  //Ecuatia se transforma in ecuatie de gradul I
            {
                if(b!=0)
                {
                    double x;
                    x = -c / b;
                    Console.WriteLine(x);
                }
                else
                {
                    if (c == 0)
                    { Console.WriteLine("x poate fi orice numar real."); }
                    else
                    { Console.WriteLine("Ecuatia nu are solutie."); }

                }
            }


        }
    }
}


