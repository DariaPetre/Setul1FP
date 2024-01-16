using System;
namespace Set1_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****~n se divide cu k~******
            Console.Write("n=");
            double n = double.Parse(Console.ReadLine());

            Console.Write("k=");
            double k = double.Parse(Console.ReadLine());

            if(k == 0 )
            {
                throw new ArgumentException("k nu poate fi 0.");
            }

            if(n % k == 0)
            {
                Console.WriteLine("n se divide cu k.");
            }
            else
            {
                Console.WriteLine("n NU se divide cu k.");
            }

        }
    }
}