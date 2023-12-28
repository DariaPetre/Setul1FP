using System;
namespace Ecuatia_de_gradul_I
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //************ ECUATIA DE GRADUL I ********
            //                  ax+b=0
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());

            if (a != 0)
            {
                float x;
                x = -b / a;
                Console.WriteLine(x);
            }
            else if (a == 0) 
            {
               if(b == 0)
                {
                    Console.WriteLine("x poate fi orice numar real.");
                }
                else
                { 
                    Console.WriteLine("Ecuatia nu are solutie.");
                }
            
            }

        }
    }
}